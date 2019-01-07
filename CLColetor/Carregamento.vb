Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Windows.Forms


Public Class Carregamento
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        'Opcoes.txtTAMGRIDCOLETAOFF.Text = Local.ObtemTamCols(grdEtiq, DS.Tables(0).TableName)
        Hide()
    End Sub

    Dim MinhaTela As Local.Tela

    Dim _DSResumo As System.Data.DataSet
    Property DSResumo() As System.Data.DataSet
        Get
            If IsNothing(_DSResumo) Then
                _DSResumo = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "Resumo"
                TB.Columns.Add("Data", GetType(Integer))
                TB.Columns.Add("Carrega", GetType(String))
                TB.Columns.Add("Viagem", GetType(String))
                TB.Columns.Add("Qtd", GetType(Double))
                TB.Columns.Add("Unid", GetType(String))
                _DSResumo.Tables.Add(TB)
            End If
            Return _DSResumo
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSResumo = value
        End Set
    End Property

    Dim _DSCarrega As System.Data.DataSet
    Property DSCarrega() As System.Data.DataSet
        Get
            If IsNothing(_DSCarrega) Then
                _DSCarrega = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "Carregamento"
                TB.Columns.Add("Viagem", GetType(String))
                TB.Columns.Add("Seq", GetType(Integer))
                TB.Columns.Add("Produto", GetType(String))
                TB.Columns.Add("Espec", GetType(String))
                TB.Columns.Add("PeçasPorVol", GetType(Integer))
                TB.Columns.Add("Qtd", GetType(Double))
                TB.Columns.Add("Unid", GetType(String))
                TB.Columns.Add("QtdVol", GetType(Integer))
                TB.Columns.Add("Embalagem", GetType(String))
                TB.Columns.Add("PesoLiq", GetType(Double))
                TB.Columns.Add("PesoBrt", GetType(Double))
                _DSCarrega.Tables.Add(TB)
            End If
            Return _DSCarrega
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSCarrega = value
        End Set
    End Property


    Dim _DSCarregaEtiq As System.Data.DataSet
    Property DSCarregaEtiq() As System.Data.DataSet
        Get
            If IsNothing(_DSCarregaEtiq) Then
                _DSCarregaEtiq = New System.Data.DataSet
                Dim TB As New System.Data.DataTable
                TB.TableName = "CarregaEtiq"
                TB.Columns.Add("Etiqueta", GetType(Integer))
                TB.Columns.Add("PesoLiq", GetType(String))
                TB.Columns.Add("PesoBrt", GetType(Double))
                TB.Columns.Add("PeçasPorVol", GetType(String))
                TB.Columns.Add("Status", GetType(Integer))
                _DSCarregaEtiq.Tables.Add(TB)
            End If
            Return _DSCarregaEtiq
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSCarregaEtiq = value
        End Set
    End Property

    Private Sub Carregamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = Local.AplDescr
            MinhaTela = New Local.Tela(Me, 510, 535, "pnl")
        Catch EX As Exception
            MsgBox(EX.Message & " ao carregar")
        End Try
    End Sub

    Dim SQLResumo As String = "select NVL(CARREGA_ATA,CARREGA_ETA) Data, CARREGA_NOME Carrega, VIAGEM_REF Viagem, SUM(EMB_PED_UNID) Qtd, PED_UNID Unid FROM IM.VW_COL_INSTRUCAO group by NVL(CARREGA_ATA,CARREGA_ETA), CARREGA_NOME, VIAGEM_REF, PED_UNID HAVING NOT CARREGA_NOME IS NULL"

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Try
            DSResumo = Princ.DSCarregaRem(SQLResumo & " ORDER BY 1,2,3")
            grdResumo.DataSource = DSResumo.Tables(0)

            Dim SQL As String = "SELECT SEL.VIAGEM_REF, SEL.SEQ, SEL.PRODUTO_COD, SEL.ESPEC, SEL.VOLUME_PECAS_QTD, SEL.EMB_PED_UNID, SEL.PED_UNID, SEL.QTD_VOL, SEL.EMBALAGEM, SEL.PESO_LIQUIDO, SEL.PESO_BRUTO  FROM IM.VW_COL_INSTRUCAO SEL, (" & SQLResumo & ") DOM WHERE NVL(SEL.CARREGA_ATA,SEL.CARREGA_ETA) = DOM.Data AND SEL.CARREGA_NOME = DOM.Carrega AND SEL.VIAGEM_REF = DOM.Viagem AND SEL.PED_UNID = DOM.Unid ORDER BY 1,2"

            DSCarrega = Princ.DSCarregaRem(SQL)
            grdCarrega.DataSource = DSCarrega.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message & " ao carregar dados.")
        End Try
    End Sub
End Class