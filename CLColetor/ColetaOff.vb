Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Windows.Forms


Public Class ColetaOff
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        On Error Resume Next
        Opcoes.txtTAMGRIDCOLETAOFF.Text = Local.ObtemTamCols(grdEtiq, DS.Tables(0).TableName)
        Opcoes.txtTAMGRIDOFFVIAGITENS.Text = Local.ObtemTamCols(grdViagItens, DSItens.Tables(0).TableName)
        Opcoes.txtTAMGRIDESTOQ.Text = Local.ObtemTamCols(grdEstoque, DSEstoq.Tables(0).TableName)
        Hide()
    End Sub

    Dim MinhaTela As Local.Tela

    Dim _DSEstoq As System.Data.DataSet
    Property DSEstoq() As System.Data.DataSet
        Get
            If IsNothing(_DSEstoq) Then
                _DSEstoq = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "Estoq"
                TB.Columns.Add("Estabelec", GetType(String))
                TB.Columns.Add("Armazém", GetType(String))
                TB.Columns.Add("Praça", GetType(String))
                TB.Columns.Add("QtdPeças", GetType(Integer))
                TB.Columns.Add("Status", GetType(String))
                TB.Columns.Add("QtdVols", GetType(Integer))
                _DSEstoq.Tables.Add(TB)
            End If
            Return _DSEstoq
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSEstoq = value
        End Set
    End Property

    Dim _DS As System.Data.DataSet
    Property DS() As System.Data.DataSet
        Get
            If IsNothing(_DS) Then
                _DS = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "EtiqOff"
                TB.Columns.Add("Seq", GetType(Integer))
                TB.Columns.Add("Etiq", GetType(String))
                TB.Columns.Add("Peso", GetType(Double))
                TB.Columns.Add("Corrida", GetType(String))
                TB.Columns.Add("QtdPeças", GetType(Integer))
                TB.Columns.Add("Armazem", GetType(String))
                TB.Columns.Add("ArmNum", GetType(String))
                TB.Columns.Add("Praça", GetType(String))
                TB.Columns.Add("Status", GetType(String))
                TB.Columns.Add("Viagem", GetType(String))
                TB.Columns.Add("Avaria", GetType(String))
                TB.Columns.Add("Obs", GetType(String))
                _DS.Tables.Add(TB)
                TB = New System.Data.DataTable
                TB.TableName = "Coleta"
                TB.Columns.Add("Viagem", GetType(String))
                TB.Columns.Add("Escala", GetType(String))
                TB.Columns.Add("Chegada", GetType(Date))
                TB.Columns.Add("Saída", GetType(Date))
                TB.Columns.Add("Obs", GetType(String))
                TB.Columns.Add("Lonado", GetType(Boolean))
                TB.Columns.Add("Molhado", GetType(Boolean))
                TB.Columns.Add("Envelopado", GetType(Boolean))
                TB.Columns.Add("ComMadeira", GetType(Boolean))
                TB.Columns.Add("NotaEntreg", GetType(Boolean))
                TB.Columns.Add("CertifComNF", GetType(Boolean))
                _DS.Tables.Add(TB)
            End If
            Return _DS
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DS = value
        End Set
    End Property



    Sub DefineArq()
        Try
            Dim ListaPadrao As String = "COLETA_OFF.DSN"
            Me.txtArq.Text = System.IO.Path.GetFileNameWithoutExtension(ListaPadrao) & "_" & IIf(Princ.IdColetor <> "", Princ.IdColetor & "_", "") & Format(Now, "yyyyMMdd_HHmmss_") & System.IO.Path.GetExtension(ListaPadrao)
        Catch EX As Exception
            MsgBox(EX.Message & " definindo arquivo")
        End Try
    End Sub

    Public Sub AtualizaCols()
        Local.DefineTamCols(grdEtiq, DS.Tables(0).TableName, Opcoes.txtTAMGRIDCOLETAOFF.Text)
        Local.DefineTamCols(grdViagItens, DSItens.Tables(0).TableName, Opcoes.txtTAMGRIDOFFVIAGITENS.Text)
        Local.DefineTamCols(grdEstoque, DSEstoq.Tables(0).TableName, Opcoes.txtTAMGRIDESTOQ.Text)
    End Sub


    Private Sub ColetaOff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DefineArq()
            Me.Text = Local.AplDescr
            MinhaTela = New Local.Tela(Me, 510, 535, "pnl")
            grdEtiq.DataSource = DS.Tables(0)
            Dim Opc As String = "AVARIADO;BENEFICIAMENTO;CANCELADO;CARREGADO;CONFERIDO;CONFERIR;DEVOLVIDO;DEVOLVIDO/AVARIADO;DISPONÍVEL;FATURADO;FRACIONADO;INDUSTRIALIZADO;RESERVADO;SUCATA;SEPARADO"
            Local.CarregaCombo(txtPadStatus, Opc)
            Local.CarregaCombo(txtStatus, Opc)
            AtualizaViagItens()
            AtualizaEstoq()
            AtualizaCols()

        Catch EX As Exception
            MsgBox(EX.Message & " ao carregar")
        End Try
    End Sub


    Public Function RDado(ByVal Linha As System.Data.DataRow, ByVal Campo As String) As Object
        If IsNothing(Linha) Then
            Return Nothing
        End If
        Return Linha!Campo
    End Function


    Public Sub Barc_OnRead(ByVal sender As System.Object, ByVal readerData As Symbol.Barcode.ReaderData)
        Try
            If readerData.Result = 0 Then
                If txtPadViagem.Text = "" Or txtPadVItem.Text = "" Then
                    MsgBox("Informar viagem e item no preenchimento automático.")
                    MinhaTela.Mostra(6)
                    Exit Sub
                End If

                If txtPadStatus.Text = "" Then
                    MsgBox("Defina status padrão para preenchimento automático.")
                    MinhaTela.Mostra(6)
                    Exit Sub
                End If

                Dim DADOSETIQ As System.Data.DataRow = Nothing
                If chkConfere.Checked Then
                    Try
                        Dim ETIQ As String = readerData.Text
                        If ETIQ.StartsWith("250") Then
                            ETIQ = Mid(ETIQ, 4)
                        End If
                        Dim ds As System.Data.DataSet = Princ.DSCarregaRem("SELECT * FROM IM.VW_COL_RASTREA_ETIQ WHERE REPLACE(ETIQUETA,'.','')='" & Local.Tratex(ETIQ) & "'")
                        If ds.Tables(0).Rows.Count > 0 Then
                            DADOSETIQ = ds.Tables(0).Rows(0)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message & " na carga de etiq.")
                    End Try
                End If

                Incluir(readerData.Text, RDado(DADOSETIQ, "PESO_INTERPRET_LIQ"))

                If MinhaTela.Ativo <> 1 Then
                    MinhaTela.Mostra(1)
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao ler código de barras")
        End Try
    End Sub

    Sub Incluir(ByVal Texto As String, Optional ByVal Peso As Double = 0)
        Dim incluir As Boolean = True
        Dim R() As System.Data.DataRow = DS.Tables(0).Select("Etiq = '" & Local.Tratex(Texto) & "'")
        If R.Length > 0 Then
            If MsgBox("Esta etiqueta já foi lida (" & R.Length & " etiq" & IIf(R.Length > 1, "s", "") & "). Deseja atualizá-la?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each Linha As System.Data.DataRow In R
                    DS.Tables(0).Rows.Remove(Linha)
                Next
            Else
                If MsgBox("Incluir novamente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    incluir = False
                End If
            End If
        End If
        If incluir Then
            Dim M As Integer = 0
            For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
                If Linha!Seq > M Then
                    M = Linha!Seq
                End If
            Next
            DS.Tables(0).Rows.Add(M + 1, Texto, IIf(Peso = 0, Nothing, Peso), Nothing, Nothing, Nothing, Nothing, Nothing, DbNullSeVazio(txtPadStatus.Text), txtPadViagem.Text & "/" & txtPadVItem.Text, Nothing, Nothing)
        End If
        AtualizaTotDS()
    End Sub

    Sub AtualizaTotDS()
        Dim SomaPeso As Double = 0
        For Each Linha As System.Data.DataRow In DS.Tables(0).Rows
            SomaPeso += Local.NZV(Linha(2), 0.0#)
        Next
        lblTot.Text = "Total:" & DS.Tables(0).Rows.Count & " Peso:" & Format(SomaPeso, "0.000")
    End Sub

    Private Sub btnDigitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDigitar.Click
        Try
            Dim Etiq As String = InputBox("Entre com etiqueta:")
            If Etiq <> "" Then
                Etiq = Replace(Etiq, ".", "")
                If Len(Etiq) = 12 Or Len(Etiq) = 9 Then
                    Incluir(Etiq)
                Else
                    MsgBox("Etiqueta deve ter ou 12 (com apl 250 na frente) ou apenas etiqueta sem pontos.", MsgBoxStyle.Information)
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao digitar texto")
        End Try
    End Sub

    Dim LinhaAtual As Integer = -1
    Private Sub grdEtiq_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEtiq.CurrentCellChanged
        Try
            If LinhaAtual <> grdEtiq.CurrentCell.RowNumber Then
                Dim RW As System.Data.DataRow = DS.Tables(0).Rows(grdEtiq.CurrentCell.RowNumber)
                txtEtiq.Text = Local.NZ(RW!ETIQ, "")
                txtPeso.Text = Local.NZ(RW!PESO, "")
                txtStatus.Text = Local.NZ(RW!STATUS, "")
                txtViagem.Text = Local.NZ(RW!VIAGEM, "")
                txtCorrida.Text = Local.NZ(RW!CORRIDA, "")
                txtPecas.Text = Local.NZ(RW("QTDPEÇAS"), "")
                txtArmazem.Text = Local.NZ(RW!ARMAZEM, "")
                txtArmNum.Text = Local.NZ(RW!ARMNUM, "")
                txtPraca.Text = Local.NZ(RW("PRAÇA"), "")
                txtAvaria.Text = Local.NZ(RW!AVARIA, "")
                txtObs.Text = Local.NZ(RW!OBS, "")
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao tentar selecionar linha")
        End Try
    End Sub

    Function DbNullSeVazio(ByVal Texto As String) As Object
        If Texto = "" Then
            Return System.Convert.DBNull
        End If
        Return Texto
    End Function

    Dim tonmax As Integer = Val(Opcoes.txtTonMax.Text)

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Try
            Dim RW As System.Data.DataRow = DS.Tables(0).Rows(grdEtiq.CurrentCell.RowNumber)
            If txtEtiq.Text = "" Then
                MsgBox("Etiqueta deve ser preenchida.")
                Exit Sub
            End If
            RW!ETIQ = txtEtiq.Text
            If txtPeso.Text = "" Then
                RW!PESO = System.Convert.DBNull
            Else
                Dim Ton As Double = Val(Replace(txtPeso.Text, ",", "."))
                If Ton > tonmax Then
                    If Ton > tonmax Then
                        Ton = Ton / 1000
                        txtPeso.Text = Format(Ton, txtPeso.Tag)
                    End If
                End If
                RW!PESO = Ton
            End If
            RW!STATUS = DbNullSeVazio(txtStatus.Text)
            RW!VIAGEM = DbNullSeVazio(txtViagem.Text)
            RW!CORRIDA = DbNullSeVazio(txtCorrida.Text)
            If txtPecas.Text = "" Then
                RW!corrida = System.Convert.DBNull
            Else
                RW("QTDPEÇAS") = Val(txtPecas.Text)
            End If
            AtualizaTotDS()
            MsgBox("Ok")
        Catch EX As Exception
            MsgBox(EX.Message & " ao salvar tela de status")
        End Try
    End Sub

    Private Sub btnSalvar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar2.Click
        Try
            Dim RW As System.Data.DataRow = DS.Tables(0).Rows(grdEtiq.CurrentCell.RowNumber)
            RW!ARMAZEM = DbNullSeVazio(txtArmazem.Text)
            RW!ARMNUM = DbNullSeVazio(txtArmNum.Text)
            RW("PRAÇA") = DbNullSeVazio(txtPraca.Text)
            RW!AVARIA = DbNullSeVazio(txtAvaria.Text)
            RW!OBS = DbNullSeVazio(txtObs.Text)
            MsgBox("Ok")
        Catch EX As Exception
            MsgBox(EX.Message & " ao salvar tela de armazém")
        End Try
    End Sub

    Private Sub btnLimpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpa.Click
        Try
            If MsgBox("Deseja limpar captura?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DS.Tables(0).Rows.Clear()
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao limpar leitura")
        End Try
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Try
            Dim Arq As String = Princ.LocalDeDocs & "\" & txtArq.Text
            DS.WriteXml(Arq)
            MsgBox("Arquivo " & Arq & " salvo.")
        Catch EX As Exception
            MsgBox(EX.Message & " salvando etiquetas lidas")
        End Try
    End Sub

    Sub Carrega(ByVal Arquivo As String)
        Try
            txtArq.Text = Arquivo
            Dim Arq As String = Princ.LocalDeDocs & "\" & Arquivo
            DS.Tables(0).Rows.Clear()
            DS.ReadXml(Arq)
            MsgBox("Arquivo " & Arq & " carregado.")
        Catch EX As Exception
            MsgBox(EX.Message & " carregando arquivo")
        End Try
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Try
            If MsgBox("Caso precise salvar antes, faça agora. Deseja definir novo arquivo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DefineArq()
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " definindo novo arquivo")
        End Try
    End Sub

    Private Sub btnPreDef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreDef.Click
        MinhaTela.Mostra(4)
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        BuscaArq.Show()
        BuscaArq.Atualiza()
    End Sub

    Sub MOSTRA(ByVal Pag As Integer)
        MinhaTela.Mostra(Pag)
    End Sub

    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        Try
            Dim RW As System.Data.DataRow = DS.Tables(0).Rows(grdEtiq.CurrentCell.RowNumber)
            RW.Delete()
            AtualizaTotDS()
            MsgBox("Ok")
        Catch EX As Exception
            MsgBox(EX.Message & " ao tentar excluir linha")
        End Try
    End Sub

    Private Sub btnCarrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarrega.Click
        Try
            Dim DSStat As System.Data.DataSet = Princ.DSCarregaRem("SELECT COD FROM IM.STATUS_ESTOQUE ORDER BY 1")
            Dim DSViag As System.Data.DataSet = Princ.DSCarregaRem("SELECT VIAGEM_REF FROM (SELECT * FROM IM.VW_COL_INSTRUCAO WHERE TO_CHAR(NVL(CARREGA_ATA,CARREGA_ETA),'YYYY-MM-DD') >= '" & Format(Ini, "yyyy-MM-dd") & "' AND TO_CHAR(NVL(CARREGA_ATA,CARREGA_ETA),'YYYY-MM-DD') <= '" & Format(Fim, "yyyy-MM-dd") & "') GROUP BY VIAGEM_REF ORDER BY 1 DESC")

            Local.CarregaCombo(txtPadStatus, DSStat.Tables(0), "COD")
            Local.CarregaCombo(txtStatus, DSStat.Tables(0), "COD")
            Local.CarregaCombo(txtPadViagem, DSViag.Tables(0), "VIAGEM_REF")

            MsgBox("Dados carregados.")
        Catch EX As Exception
            MsgBox(EX.Message & " tentando atualizar status e viagem.")
        End Try
    End Sub

    Sub AtualizaViagItens()
        grdViagItens.DataSource = DSItens.Tables(0)
        lblTotViagItens.Text = "Total: " & DSItens.Tables(0).Rows.Count
    End Sub

    Private Sub btnCarregaViagemItens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregaViagemItens.Click
        Try
            DSItens = Princ.DSCarregaRem("SELECT SEQ ""Seq"", ESCALA_CARREGA || '-' || CARREGA_NOME ""Escala"", PRODUTO_COD ""Produto"", ESPEC ""Espec"", VOLUME_PECAS_QTD ""PecasPorVol"",QTD_VOL ""QtdVol"", EMB_PED_UNID ""Qtd"",PED_UNID ""Unid"" FROM IM.VW_COL_INSTRUCAO WHERE VIAGEM_REF = '" & Local.Tratex(txtPadViagem.Text) & "' ORDER BY 1")
            DSItens.Tables(0).TableName = "ViagItens"
            AtualizaViagItens()
        Catch EX As Exception
            MsgBox(EX.Message & " na carga dos itens de viagem.")
        End Try
    End Sub

    Private _DSItens As System.Data.DataSet
    Property DSItens() As System.Data.DataSet
        Get
            If IsNothing(_DSItens) Then
                _DSItens = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "ViagItens"
                TB.Columns.Add("Seq", GetType(Integer))
                TB.Columns.Add("Escala", GetType(String))
                TB.Columns.Add("Produto", GetType(String))
                TB.Columns.Add("Espec", GetType(String))
                TB.Columns.Add("PecasPorVol", GetType(Integer))
                TB.Columns.Add("QtdVol", GetType(Integer))
                TB.Columns.Add("Qtd", GetType(Double))
                TB.Columns.Add("Unid", GetType(String))
                _DSItens.Tables.Add(TB)
            End If
            Return _DSItens
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSItens = value
        End Set
    End Property

    Private Sub btnMais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMais.Click
        Try
            txtPadVItem.Text = Val(txtPadVItem.Text) + 1
        Catch
        End Try
    End Sub

    Private Sub btnMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenos.Click
        Try
            txtPadVItem.Text = Math.Max(Val(txtPadVItem.Text) - 1, 1)
        Catch
        End Try
    End Sub

    Private Sub grdViagItens_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdViagItens.CurrentCellChanged, grdEstoque.CurrentCellChanged
        Try
            Dim RW As System.Data.DataRow = DSItens.Tables(0).Rows(grdViagItens.CurrentCell.RowNumber)
            txtPadVItem.Text = RW!Seq
            txtPadProd.Text = RW!Produto
            txtPadEspec.Text = RW!Espec
            CarregaColeta(txtPadViagem.Text, RW!Escala)
        Catch
        End Try
    End Sub

    Sub SalvaColeta()
        Dim RW() As System.Data.DataRow = DS.Tables("Coleta").Select("Viagem='" & Local.Tratex(txtDetViagem.Text) & "' and Escala='" & Local.Tratex(txtDetColeta.Text) & "'")
        For z As Integer = 0 To RW.Length - 1
            DS.Tables("Coleta").Rows.Remove(RW(z))
        Next
        Dim cheg As Date = Nothing
        Dim sai As Date = Nothing
        Try
            cheg = CDate(txtDetChegada.Text)
        Catch
        End Try
        Try
            sai = CDate(txtDetSaída.Text)
        Catch
        End Try

        DS.Tables("Coleta").Rows.Add(txtDetViagem.Text, txtDetColeta.Text, IIf(txtDetChegada.Text = "", Convert.DBNull, cheg), IIf(txtDetSaída.Text = "", Convert.DBNull, sai), txtDetObs.Text, txtDetLonado.Checked, txtDetMolhado.Checked, txtDetEnvelopado.Checked, txtDetComMadeira.Checked, txtDetNotaEntreg.Checked, txtDetCertifComNF.Checked)
    End Sub

    Sub CarregaColeta(ByVal Viagem As String, ByVal Coleta As String)
        Dim RW() As System.Data.DataRow = DS.Tables("Coleta").Select("Viagem='" & Local.Tratex(Viagem) & "' and Escala='" & Local.Tratex(Coleta) & "'")
        If RW.Length > 0 Then
            Local.CarregaRowEmTela(pnl06, "txtDet", RW(0))
        Else
            Local.CarregaRowEmTela(pnl06, "txtDet", Nothing)
            txtDetViagem.Text = Viagem
            txtDetColeta.Text = Coleta
        End If
    End Sub

    Private Sub btnCarrega5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarrega5.Click
        Try
            Local.CarregaCombo(txtPadProd, Princ.DSCarregaRem("select distinct PRODUTO_COD from IM.VW_COL_RASTREA_ETIQ order by 1").Tables(0), "PRODUTO_COD")
            Local.CarregaCombo(txtPadEspec, Princ.DSCarregaRem("select distinct ESPEC from IM.VW_COL_RASTREA_ETIQ WHERE PRODUTO_COD = '" & Local.Tratex(txtPadProd.Text) & "' AND ESPEC LIKE '%" & Local.Tratex(txtPadTrecho.Text) & "%'").Tables(0), "ESPEC")
            MsgBox("Dados carregados.")
        Catch EX As Exception
            MsgBox(EX.Message & " tentando atualizar estoque atual.")
        End Try
    End Sub

    Private Sub btnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnData.Click
        pnlCal.Visible = True
    End Sub

    Private Ini As Date = Now
    Private Fim As Date = Now

    Private Sub btnIntervalConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervalConfirm.Click
        Try
            pnlCal.Visible = False
            Dim i As String = Format(cal.SelectionStart, "yyyy-MM-dd")
            Dim f As String = Format(cal.SelectionEnd, "yyyy-MM-dd")
            Dim h As String = Format(Now, "yyyy-MM-dd")
            If i = h And f = h Then
                btnData.Text = "Hoje"
            ElseIf i = f Then
                btnData.Text = i
            Else
                btnData.Text = i & ".." & Format(cal.SelectionEnd, "MM-dd")
            End If
            Ini = cal.SelectionStart
            Fim = cal.SelectionEnd
        Catch ex As Exception
            MsgBox(ex.Message & " na definição do intervalo de datas.")
        End Try
    End Sub

    Private Sub btnIntervaloCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntervaloCancel.Click
        pnlCal.Visible = False
    End Sub

    Private Sub btnProcura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcura.Click
        Try
            Dim sql As String = "select ARMAZEM_CIA_COD ""Estabelec"", ARMAZEM_NUM ""Armazém"", ARMAZEM_PRACA ""Praça"", VOLUME_PECAS_QTD ""QtdPeças"", ETIQ_STATUS_COD ""Status"", COUNT(*) ""QtdVols"" "
            sql &= "from (SELECT * FROM IM.VW_COL_RASTREA_ETIQ WHERE PRODUTO_COD = '" & Local.Tratex(txtPadProd.Text) & "' AND ESPEC = '" & Local.Tratex(txtPadEspec.Text) & "') group by ARMAZEM_CIA_COD, ARMAZEM_NUM, ARMAZEM_PRACA, ETIQ_STATUS_COD, VOLUME_PECAS_QTD "
            sql &= "having not ETIQ_STATUS_COD in ('CARREGADO', 'CANCELADO') ORDER BY 1,2,3,4"
            DSEstoq = Princ.DSCarregaRem(sql)
            DSEstoq.Tables(0).TableName = "Estoq"
            AtualizaEstoq()
        Catch EX As Exception
            MsgBox(EX.Message & " na carga dos itens do estoque.")
        End Try
    End Sub

    Sub AtualizaEstoq()
        grdEstoque.DataSource = DSEstoq.Tables(0)
        lblTotEstoq.Text = "Total: " & DSEstoq.Tables(0).Rows.Count
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MinhaTela.Mostra(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MinhaTela.Mostra(5)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MinhaTela.Mostra(6)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MinhaTela.Mostra(1)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MinhaTela.Mostra(4)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MinhaTela.Mostra(6)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MinhaTela.Mostra(1)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MinhaTela.Mostra(4)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MinhaTela.Mostra(5)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtDetChegada.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtDetSaída.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            If txtViagem.Text = "[DEFINIR]" Then
                MsgBox("Selecione antes uma coleta.")
                MinhaTela.Mostra(4)
                Exit Sub
            End If
            If txtDetChegada.Text <> "" Then
                Try
                    Dim d As Date = CDate(txtDetChegada.Text)
                Catch ex As Exception
                    MsgBox("Corrija formato de data e hora yyyy-MM-dd HH:mm:ss em chegada.")
                    txtDetChegada.Focus()
                    Exit Sub
                End Try
            End If
            If txtDetSaída.Text <> "" Then
                Try
                    Dim d As Date = CDate(txtDetSaída.Text)
                Catch ex As Exception
                    MsgBox("Corrija formato de data e hora yyyy-MM-dd HH:mm:ss em saída.")
                    txtDetChegada.Focus()
                    Exit Sub
                End Try
            End If
            If MsgBox("Deseja salvar estado da viagem atual?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SalvaColeta()
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " gravando detalhes de coleta.")
        End Try
    End Sub

    Private Sub btnLerPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLerPeso.Click
        Dim ArPeso As New ArrayList
        For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
            If Local.NZV(ROW!PESO, 0.0#) = 0.0# Then
                Dim ETIQ As String = ROW!ETIQ
                ETIQ = ETIQ.Substring(3).Insert(2, ".").Insert(5, ".")
                ArPeso.Add(ETIQ)
            End If
        Next
        Try
            Dim DSLocal As System.Data.DataSet = Princ.DSCarregaRem("SELECT ETIQUETA, PESO_INTERPRET_BRUTO FROM IM.VW_COL_RASTREA_ETIQ WHERE ETIQUETA IN ( '" & Join(ArPeso.ToArray, "','") & "')")
            For Each ROW As System.Data.DataRow In DS.Tables(0).Rows
                Dim ETIQ As String = ROW!ETIQ
                ETIQ = ETIQ.Substring(3).Insert(2, ".").Insert(5, ".")
                Dim Linhas() As System.Data.DataRow = DSLocal.Tables(0).Select("ETIQUETA = '" & ETIQ & "'")
                If Linhas.Length > 0 Then
                    ROW!PESO = Local.NZV(Linhas(0)!PESO_INTERPRET_BRUTO, 0.0#)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " falha na conexão com rede ao obter peso.")
        End Try
        AtualizaTotDS()
    End Sub
End Class