Imports Microsoft.VisualBasic


Public Class DefLocaliza
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub DefLocaliza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Local.CarregaCombo(txtARMAZEM_CIA_COD, Princ.CombosUsu.Tables("CIA_ARMAZEM"), "COD")
        Catch ex As Exception
            MsgBox(ex.Message & " na carga das definições de localização")
        End Try
    End Sub

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
        Catch EX As Exception
            MsgBox(EX.Message & " em carga de opções de armazenamento")
        End Try
        Alert.Esconde()
    End Sub

    Private Sub btnnumme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnumme.Click
        Try
            Dim IND As Integer = txtARMAZEM_NUM.Items.IndexOf(txtARMAZEM_NUM.Text)
            If IND > 0 Then
                txtARMAZEM_NUM.Text = txtARMAZEM_NUM.Items(IND - 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " tentando escolher número do armazém")
        End Try
    End Sub

    Private Sub btnnumma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnumma.Click
        Try
            Dim IND As Integer = txtARMAZEM_NUM.Items.IndexOf(txtARMAZEM_NUM.Text)
            If IND <> -1 And IND < (txtARMAZEM_NUM.Items.Count - 1) Then
                txtARMAZEM_NUM.Text = txtARMAZEM_NUM.Items(IND + 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " tentando escolher número do armazém")
        End Try
    End Sub

    Private Sub btnprame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprame.Click
        Try
            Dim IND As Integer = txtARMAZEM_PRACA.Items.IndexOf(txtARMAZEM_PRACA.Text)
            If IND > 0 Then
                txtARMAZEM_PRACA.Text = txtARMAZEM_PRACA.Items(IND - 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " tentando escolher praça")
        End Try
    End Sub

    Private Sub btnprama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprama.Click
        Try
            Dim IND As Integer = txtARMAZEM_PRACA.Items.IndexOf(txtARMAZEM_PRACA.Text)
            If IND <> -1 And IND < (txtARMAZEM_PRACA.Items.Count - 1) Then
                txtARMAZEM_PRACA.Text = txtARMAZEM_PRACA.Items(IND + 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " tentando escolher praça")
        End Try
    End Sub


    Private Sub txtARMAZEM_NUM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtARMAZEM_NUM.SelectedIndexChanged
        Try
            txtARMAZEM_PRACA.Items.Clear()
            Dim AR1 As New ArrayList
            For Each LINHA As System.Data.DataRow In Local.DSArmazens.Tables(0).Rows
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

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Local.DSArmazens = Nothing
            DefLocaliza_Load(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message & " atualizando lista de companhias")
        End Try
    End Sub

End Class