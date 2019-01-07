Imports Microsoft.VisualBasic


Public Class Conferencia
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Opcoes.txtTAMGRIDETIQUETAS.Text = Local.ObtemTamCols(grdEtiqueta, DataEtiqueta.Tables(0).TableName)
        Opcoes.txtTAMGRIDPRACAS.Text = Local.ObtemTamCols(grdPraca, DataPraca.Tables(0).TableName)
        Hide()
    End Sub

    Dim MinhaTela As Local.Tela

    Private Sub Conferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Local.AplDescr
        MinhaTela = New Local.Tela(Me, 510, 535, "pnl")
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Local.ObtemTamCols(grdEtiqueta, DataEtiqueta.Tables(0).Namespace))
        MsgBox(Local.ObtemTamCols(grdPraca, DataPraca.Tables(0).Namespace))
        OFP.FileName = Princ.LocalDeDocs
        OFP.ShowDialog()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Local.DSArmazens = Nothing
            DefLocaliza_Load(Nothing, Nothing)
            AtualizaCols()
        Catch ex As Exception
            MsgBox(ex.Message & " atualizando lista de companhias")
        End Try
    End Sub

    Public Sub AtualizaCols()
        Local.DefineTamCols(grdPraca, "Praca", Opcoes.txtTAMGRIDPRACAS.Text)
        Local.DefineTamCols(grdEtiqueta, "Etiqueta", Opcoes.txtTAMGRIDETIQUETAS.Text)
    End Sub
    Private Sub DefLocaliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Local.CarregaCombo(txtARMAZEM_CIA_COD, Princ.CombosUsu.Tables("CIA_ARMAZEM"), "COD")
        Catch ex As Exception
            MsgBox(ex.Message & " na carga das definições de localização")
        End Try
    End Sub

    Dim DataPraca As System.Data.DataSet
    Private Sub txtARMAZEM_CIA_COD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtARMAZEM_CIA_COD.SelectedIndexChanged
        Try
            Alert.Mostra("CLC - Obtendo informações do armazém.")
            txtARMAZEM_NUM.Items.Clear()
            txtARMAZEM_PRACA.Items.Clear()
            Dim AR1 As New ArrayList
            For Each LINHA As System.Data.DataRow In Local.DSArmazens(txtARMAZEM_CIA_COD.Text).Tables(0).Rows
                Dim col0 As String = Trim(Local.NZ(LINHA(0), ""))
                Dim col1 As String = Trim(Local.NZ(LINHA(1), ""))
                If AR1.IndexOf(col0) = -1 Then
                    AR1.Add(col0)
                End If
            Next
            AR1.Sort()
            For Each ITEM As String In AR1
                txtARMAZEM_NUM.Items.Add(ITEM)
            Next
            Dim SQL As String = "SELECT AP.ARMAZEM_NUM, AP.PRACA, AP.DESCR, AP.QTD_VOL_CONF, Count(R.ETIQUETA) AS VOLUMES " & _
            "FROM IM.ARMAZEM_PRACA AP, (SELECT * FROM IM.VW_COL_RASTREA_ETIQ WHERE not ETIQ_STATUS_COD in ('CARREGADO', 'CANCELADO', 'CONFERIR')) R " & _
            "WHERE AP.ARMAZEM_CIA_COD = '" & Local.Tratex(txtARMAZEM_CIA_COD.Text) & "' AND AP.PRACA = R.ARMAZEM_PRACA (+) AND AP.ARMAZEM_NUM = R.ARMAZEM_NUM (+) AND AP.ARMAZEM_CIA_COD = R.ARMAZEM_CIA_COD (+) " & _
            "GROUP BY AP.ARMAZEM_NUM, AP.PRACA, AP.DESCR, AP.QTD_VOL_CONF " & _
            "ORDER BY AP.ARMAZEM_NUM, AP.PRACA"
            DataPraca = Princ.DSCarregaRem(SQL)
            DataPraca.Tables(0).TableName = "Praca"
            grdPraca.DataSource = DataPraca.Tables(0)
        Catch EX As Exception
            MsgBox(EX.Message & " em carga de opções de armazenamento")
        End Try
        Alert.Esconde()
    End Sub

    Private Sub txtARMAZEM_NUM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtARMAZEM_NUM.SelectedIndexChanged
        Try
            txtARMAZEM_PRACA.Items.Clear()
            Dim AR1 As New ArrayList
            For Each LINHA As System.Data.DataRow In Local.DSArmazens(txtARMAZEM_CIA_COD.Text).Tables(0).Rows
                Dim col0 As String = Trim(Local.NZ(LINHA(0), ""))
                Dim col1 As String = Trim(Local.NZ(LINHA(1), ""))
                If col0 = txtARMAZEM_NUM.Text Then
                    If AR1.IndexOf(col1) = -1 Then
                        AR1.Add(col1)
                    End If
                End If
            Next
            AR1.Sort()
            For Each ITEM As String In AR1
                txtARMAZEM_PRACA.Items.Add(ITEM)
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " na alteração do número do armazém")
        End Try
    End Sub

    Sub Tots()
        Dim Tots As New Dictionary(Of String, Integer)
        For Each Linha As System.Data.DataRow In DataEtiqueta.Tables(0).Rows
            Dim CHAVE As String = Local.NZ(Linha!CONF, "PEND")
            If Not Tots.ContainsKey(CHAVE) Then
                Tots.Add(CHAVE, 1)
            Else
                Tots(CHAVE) = Tots(CHAVE) + 1
            End If
        Next
        lblTots.Text = ""
        For Each Item As String In Tots.Keys
            lblTots.Text = lblTots.Text & IIf(lblTots.Text <> "", vbCrLf, "") & Item & ":" & Tots(Item)
        Next
    End Sub

    Dim ORD As Integer
    Dim DataEtiqueta As System.Data.DataSet
    Private Sub txtARMAZEM_PRACA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtARMAZEM_PRACA.SelectedIndexChanged
        Try
            DataEtiqueta = Princ.DSCarregaRem("SELECT REPLACE(ETIQUETA,'.','') ETIQUETA, STATUS_COD, '' CONF, '' ORDEM FROM IM.ETIQUETA WHERE ARMAZEM_CIA_COD = '" & Local.Tratex(txtARMAZEM_CIA_COD.Text) & "' AND ARM_NUM = '" & Local.Tratex(txtARMAZEM_NUM.Text) & "' AND ARM_PRACA = '" & Local.Tratex(txtARMAZEM_PRACA.Text) & "'")
            DataEtiqueta.Tables(0).TableName = "Etiqueta"
            grdEtiqueta.DataSource = DataEtiqueta.Tables(0)
            AtualizaCols()
            ORD = 1
            Tots()

            For Z As Integer = 0 To DataPraca.Tables(0).Rows.Count - 1
                grdPraca.UnSelect(Z)
            Next
            SoInfoAdd = True

            For z As Integer = 0 To DataPraca.Tables(0).Rows.Count - 1
                If DataPraca.Tables(0).Rows(z)(0) = txtARMAZEM_NUM.Text And DataPraca.Tables(0).Rows(z)(1) = txtARMAZEM_PRACA.Text Then
                    grdPraca.CurrentRowIndex = z
                    grdPraca.Select(z)
                    Exit For
                End If
            Next

        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
        SoInfoAdd = False
    End Sub


    Dim SoInfoAdd As Boolean = False
    Private Sub grdPraca_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdPraca.CurrentCellChanged
        Try
            Dim RW As System.Data.DataRow = DataPraca.Tables(0).Rows(grdPraca.CurrentCell.RowNumber)
            If Not SoInfoAdd Then
                Local.SelecionaValor(txtARMAZEM_NUM, Local.NZ(RW(0), ""))
                Local.SelecionaValor(txtARMAZEM_PRACA, Local.NZ(RW(1), ""))
                txtARMAZEM_PRACA_SelectedIndexChanged(Nothing, Nothing)
            End If
            txtDescr.Text = Local.NZ(RW(2), "")
            txtConfir.Text = Local.NZ(RW(3), "")
        Catch ex As Exception
            MsgBox(ex.Message & " ao mudar linha da praça")
        End Try
    End Sub

    Public Sub Barc_OnRead(ByVal sender As System.Object, ByVal readerData As Symbol.Barcode.ReaderData)
        Try
            If readerData.Result = 0 Then
                TrataEntrada(readerData.Text)
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao ler código de barras")
        End Try
    End Sub

    Sub TrataEntrada(ByVal Texto As String)
        If Texto.StartsWith("250") Then
            Dim ACHOU As Boolean = False
            For Each linha As System.Data.DataRow In DataEtiqueta.Tables(0).Rows
                If linha!ETIQUETA = Mid(Texto, 4) Then
                    Dim C As String = Local.NZ(linha("CONF"), "")
                    If C = "OK" Then
                        linha("CONF") = "DUPL"
                    ElseIf C.StartsWith("DUPL") Then
                        linha("CONF") = "DUPL" & Str(Val(Local.NZV(Mid(C, 5), "1")) + 1)
                    Else
                        linha("CONF") = "OK"
                    End If
                    Dim ORDANT As String = Local.NZ(linha("ORDEM"), "")
                    linha("ORDEM") = ORDANT & IIf(ORDANT <> "", ";", "") & ORD
                    ACHOU = True
                End If
            Next
            If Not ACHOU Then
                DataEtiqueta.Tables(0).Rows.Add(Mid(Texto, 4), "", "NOVA", ORD)
            End If
            ORD += 1
        Else
            MsgBox("Código inválido para esta atividade.")
        End If
        Tots()
    End Sub
    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualiza.Click
        txtARMAZEM_CIA_COD_SelectedIndexChanged(Nothing, Nothing)
    End Sub


    Private Sub btnDigita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigita.Click
        Try
            Dim Entrada As String = InputBox("Digite etiqueta")
            TrataEntrada("250" & Replace(Entrada, ".", ""))
        Catch EX As Exception
            MsgBox(EX.Message & " ao digitar etiqueta")
        End Try
    End Sub

    Private Sub btnEtiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEtiq.Click
        MinhaTela.Mostra(2)
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Try
            If MsgBox("Confirma gravação de visual e descrição na praça?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Princ.DSGravaRem("UPDATE IM.ARMAZEM_PRACA SET DESCR = '" & Local.Tratex(txtDescr.Text) & "', QTD_VOL_CONF = " & Local.Tratex(txtConfir.Text) & " WHERE ARMAZEM_CIA_COD = '" & Local.Tratex(txtARMAZEM_CIA_COD.Text) & "' AND ARMAZEM_NUM = '" & Local.Tratex(txtARMAZEM_NUM.Text) & "' AND PRACA = '" & Local.Tratex(txtARMAZEM_PRACA.Text) & "'")
            End If
            MsgBox("Ok")
        Catch EX As Exception
            MsgBox(EX.Message & " em gravação de dados de praça")
        End Try
    End Sub

    Private Sub grdEtiqueta_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEtiqueta.CurrentCellChanged
        Try
            Dim RW As System.Data.DataRow = DataEtiqueta.Tables(0).Rows(grdEtiqueta.CurrentCell.RowNumber)
            Local.SelecionaValor(txtCond, Local.NZ(RW(2), ""))
        Catch EX As Exception
            MsgBox(EX.Message & " ao mudar linha da etiqueta")
        End Try
    End Sub

    Private Sub btnSalvar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar2.Click
        Try
            Dim RW As System.Data.DataRow = DataEtiqueta.Tables(0).Rows(grdEtiqueta.CurrentCell.RowNumber)
            RW(2) = txtCond.Text
            Tots()
        Catch EX As Exception
            MsgBox(EX.Message & " ao tentar salvar condição")
        End Try
    End Sub

End Class