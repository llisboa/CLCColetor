Imports Symbol.Barcode
Imports Symbol.Imaging

Public Class Princ

    Private MyRadio As Symbol.WirelessLAN.Radio = Nothing

    Sub Fecha()
        Try
            Opcoes.SalvaConfig()
            MinhaTela = Nothing
            Barc.EnableScanner = False
            Barc.Dispose()
            Me.Menu.Dispose()
            MyBase.Close()
        Catch
        End Try
        Application.Exit()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Deseja sair do sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Fecha()
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " em clique de menu")
        End Try
    End Sub

    Dim MinhaTela As Local.Tela

    Dim www As New www.Consulta
    Dim wwwisc As New wwwisc.Consulta

    Public ReadOnly Property ArquivoUpload(ByVal Arquivo As String, ByVal Dados() As Byte) As Boolean
        Get
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return wwwisc.ArquivoUpload(Arquivo, Dados)
            End If
            Return www.ArquivoUpload(Arquivo, Dados)
        End Get
    End Property

    Public ReadOnly Property ArquivoMomentoModif(ByVal Arquivo As String) As Date
        Get
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return wwwisc.ArquivoMomentoModif(Arquivo)
            End If
            Return www.ArquivoMomentoModif(Arquivo)
        End Get
    End Property


    Public ReadOnly Property DSCarregaRem(ByVal Consulta As String) As System.Data.DataSet
        Get
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRet(wwwisc.DSCarregaRem(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Consulta))
            End If
            Return DSRet(www.DSCarregaRem(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Consulta))
        End Get
    End Property


    Public Sub DSGravaRem(ByVal Consulta As String)
        Dim DS As System.Data.DataSet
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            DS = wwwisc.DSGravaRem(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Consulta)
        Else
            DS = www.DSGravaRem(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Consulta)
        End If
        If Not IsNothing(DS) AndAlso DS.Tables.Count > 0 AndAlso DS.Tables(0).Columns.Count = 1 AndAlso DS.Tables(0).Columns(0).ColumnName = "EX_MSG" AndAlso DS.Tables(0).Rows.Count = 1 AndAlso DS.Tables(0).Rows(0)(0) <> "OK" Then
            Throw New Exception(DS.Tables(0).Rows(0)(0))
        End If
    End Sub


    Public ReadOnly Property IdColetor() As String
        Get
            Return Login.Cfg.Conteudo("ID_COLETOR")
        End Get
    End Property

    Dim DS As System.Data.DataSet = Nothing

    Sub Atualiza()
        Try
            Local.CarregaCombo(txtARMAZEM_CIA_COD, CombosUsu().Tables("CIA_ARMAZEM"), "COD")
        Catch ex As Exception
            MsgBox(ex.Message & " atualizando lista de companhias de armazém")
        End Try
    End Sub

    Sub NovoLog()
        Lista = System.IO.Path.GetDirectoryName(ListaPadrao) & "\" & System.IO.Path.GetFileNameWithoutExtension(ListaPadrao) & "_" & IIf(IdColetor <> "", IdColetor & "_", "") & Format(Now, "yyyyMMdd_HHmmss_") & System.IO.Path.GetExtension(ListaPadrao)
        Local.ArqLog(Lista, "DATA HORA;ETIQUETA;PRODUTO;DIMENSAO | QUALIDADE;ARMAZEM_NOME;ARMAZEM_NUM;PRACA;PEDIDO;ITEM")
    End Sub

    Sub AcertaTimeOut()
        www.Timeout = 12000
        wwwisc.Timeout = 12000
        Try
            www.Timeout = Val(Opcoes.txtTimeOut.Text) * 1000
            wwwisc.Timeout = Val(Opcoes.txtTimeOut.Text) * 1000
        Catch
        End Try
    End Sub

    Const ULTIMA_LEITURA As String = "Última Leitura..."

    Private Sub Princ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lblLeitura.Text = ULTIMA_LEITURA
            AcertaTimeOut()
            NovoLog()
            Me.Text = Local.AplDescr
            MinhaTela = New Local.Tela(Me, 510, 535, "pnl")
            AddHandler MinhaTela.NotificaTxt, AddressOf Notifica
            Barc.EnableScanner = True
            Me.Menu = New MainMenu

            Atualiza()
            WirelessSinal()
        Catch ex As Exception
            MsgBox(ex.Message & " em início")
        End Try

        Application.DoEvents()
        Alert.Esconde()
        Login.Hide()
    End Sub

    Sub Notifica(ByVal Texto As String)
        lblLeitura.Text = Texto
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        ctxMenu.Show(sender, New System.Drawing.Point(0, 0))
    End Sub

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        Try
            Alert.Mostra("CLC - Obtendo dados da etiqueta pela rede.")
            DS = RastrEtiqApres(txtETIQUETA.Text)
            Me.Focus()
            Mostra()

            RegistraLog()

            Def()
        Catch ex As Exception
            MsgBox(ex.Message & " em busca")
        End Try
        Alert.Esconde()
    End Sub

    Sub Mostra()
        If Not IsNothing(DS) AndAlso DS.Tables.Count > 0 AndAlso DS.Tables(0).Rows.Count > 0 Then
            txtPESO_BALANCA_BRUTO.Text = ""
            txtPESO_BALANCA_LIQ.Text = ""
            Local.CarregaRowEmTela(Me, "txt", DS.Tables(0).Rows(0))
        Else
            Local.CarregaRowEmTela(Me, "txt", Nothing)
        End If
        MinhaTela.Ativo = 1
        MinhaTela.Ativa()
    End Sub

    Function ObtemOpcArmazem(ByVal Armazem As String) As System.Data.DataSet
        Try
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRet(wwwisc.ObtemOpcArmazem(Armazem))
            End If
            Return DSRet(www.ObtemOpcArmazem(Armazem))
        Catch ex As Exception
            MsgBox(ex.Message & " em obtenção dos dados do armazém")
        End Try
        Return Nothing
    End Function

    Function ArquivoBin(ByVal Arquivo As String) As Byte()
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return wwwisc.ArquivoBin(Arquivo)
        End If
        Return www.ArquivoBin(Arquivo)
    End Function

    Function DSRet(ByVal DS As System.Data.DataSet) As System.Data.DataSet
        If Not IsNothing(DS) AndAlso DS.Tables.Count > 0 AndAlso DS.Tables(0).Columns.Count = 1 AndAlso DS.Tables(0).Columns(0).ColumnName = "EX_MSG" AndAlso DS.Tables(0).Rows.Count = 1 AndAlso DS.Tables(0).Rows(0)(0) <> "OK" Then
            Throw New Exception(DS.Tables(0).Rows(0)(0))
        End If
        Return DS
    End Function


    Function RastrEtiqApres(ByVal Texto As String) As System.Data.DataSet
        Try
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRet(wwwisc.RastrEtiqApres(Texto))
            End If
            Return DSRet(www.RastrEtiqApres(Texto))
        Catch ex As Exception
            MsgBox(ex.Message & " em rastreamento de etiqueta")
        End Try
        Return Nothing
    End Function


    Function RastrEtiqCodBarras(ByVal Texto As String) As System.Data.DataSet
        Try
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRet(wwwisc.RastrEtiqCodBarras(Texto))
            End If

            Return DSRet(www.RastrEtiqCodBarras(Texto))
        Catch ex As Exception
            MsgBox(ex.Message & " em rastreamento de etiqueta por código de barras")
        End Try
        Return Nothing
    End Function

    Function CarregaCombosUsu(ByVal Usuario As String) As System.Data.DataSet
        Try
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRet(wwwisc.CarregaCombosUsu(Usuario))
            End If
            Return DSRet(www.CarregaCombosUsu(Usuario))
        Catch ex As Exception
            MsgBox(ex.Message & " em carga de dados do usuário")
        End Try
        Return Nothing
    End Function

    Function DSRetBool(ByVal DS As System.Data.DataSet) As Boolean
        If Not IsNothing(DS) AndAlso DS.Tables.Count > 0 AndAlso DS.Tables(0).Columns.Count = 1 AndAlso DS.Tables(0).Columns(0).ColumnName = "EX_MSG" AndAlso DS.Tables(0).Rows.Count = 1 AndAlso DS.Tables(0).Rows(0)(0) <> "OK" Then
            Throw New Exception(DS.Tables(0).Rows(0)(0))
        End If
        Return True
    End Function

    Function TrocaUnidMedida(ByVal Pedido As String, ByVal Item As String, ByVal UnidProx As String) As Boolean
        Try
            If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
                Return DSRetBool(wwwisc.TrocaUnidMedida(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Pedido, Item, UnidProx))
            End If
            Return DSRetBool(www.TrocaUnidMedida(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Pedido, Item, UnidProx))
        Catch ex As Exception
            MsgBox(ex.Message & " em troca de unidade para dimensão no item")
        End Try
    End Function


    Function SalvaPesoBalanca(ByVal Etiqueta As String, ByVal Liquido As Double, ByVal Bruto As Double, ByVal QtdPecas As Integer) As Boolean
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return DSRetBool(wwwisc.SalvaPesoBalanca(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Liquido, Bruto, QtdPecas))
        End If
        Return DSRetBool(www.SalvaPesoBalanca(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Liquido, Bruto, QtdPecas))
    End Function

    Function SalvaLocaliza(ByVal Etiqueta As String, ByVal Armazem As String, ByVal Num As String, ByVal Praca As String, ByVal LINHA As Integer, ByVal COLUNA As Integer) As Boolean
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return DSRetBool(wwwisc.SalvaLocaliza(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Armazem, Num, Praca, LINHA, COLUNA))
        End If
        Return DSRetBool(www.SalvaLocaliza(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Armazem, Num, Praca, LINHA, COLUNA))
    End Function

    Function SalvaObs(ByVal Etiqueta As String, ByVal Texto As String) As Boolean
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return DSRetBool(wwwisc.SalvaObs(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Texto))
        End If
        Return DSRetBool(www.SalvaObs(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Texto))
    End Function

    Function SalvaAvaria(ByVal Etiqueta As String, ByVal Texto As String) As Boolean
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return DSRetBool(wwwisc.SalvaAvaria(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Texto))
        End If
        Return DSRetBool(www.SalvaAvaria(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Texto))
    End Function

    Function AtualizaStatus(ByVal Etiqueta As String, ByVal Status As String) As Boolean
        If Login.txtSERVIDOR.Text = "wwwisc.intermesa" Then
            Return DSRetBool(wwwisc.AtualizaStatus(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Status))
        End If
        Return DSRetBool(www.AtualizaStatus(Login.txtUsuario.Text, Login.txtSENHA.Text, IdColetor, Etiqueta, Status))
    End Function

    Sub Def()
        Dim Atualizou As Boolean = False
        If DefLocaliza.chkAtivo.Checked Then
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Mudar localização para " & DefLocaliza.txtARMAZEM_CIA_COD.Text & " Arm.Num." & DefLocaliza.txtARMAZEM_NUM.Text & " Praça " & DefLocaliza.txtARMAZEM_PRACA.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not SalvaLocaliza(txtETIQUETA.Text, DefLocaliza.txtARMAZEM_CIA_COD.Text, DefLocaliza.txtARMAZEM_NUM.Text, DefLocaliza.txtARMAZEM_PRACA.Text, 0, 0) Then
                    MsgBox("Falha na atualização da localização.")
                Else
                    Atualizou = True
                End If
            End If
        End If
        If DefStatus.chkAtivo.Checked Then
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Mudar status para " & DefStatus.txtETIQ_STATUS_COD.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not AtualizaStatus(txtETIQUETA.Text, DefStatus.txtETIQ_STATUS_COD.Text) Then
                    MsgBox("Falha na atualização do status")
                Else
                    Atualizou = True
                End If
            End If
        End If
        If Atualizou Then
            DS = RastrEtiqApres(txtETIQUETA.Text)
            Mostra()
        End If
    End Sub

    Public Driver As String = ""
    Public LocalDeDocs As String = Driver & "\MY DOCUMENTS"
    Dim ListaPadrao As String = LocalDeDocs & "\COLETA.TXT"
    Private _Lista As String = ""

    Public Function BaseDir() As String
        Return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        'Return "C:\VBNET\CLCColetor\CLColetor_V03.29.09\CLColetor\bin\Debug"
    End Function


    Public Property Lista() As String
        Get
            Return _Lista
        End Get
        Set(ByVal value As String)
            _Lista = value
        End Set
    End Property

    Sub RegistraLog(Optional ByVal Texto As String = "")
        If Texto = "" Then
            Local.ArqLog(Lista, Format(Now, "yyyy-MM-dd HH:mm:ss") & ";" & txtETIQUETA.Text & ";" & txtPRODUTO_COD.Text & ";" & txtESPEC.Text & ";" & txtARMAZEM_CIA_COD.Text & ";" & txtARMAZEM_NUM.Text & ";" & txtARMAZEM_PRACA.Text & ";" & txtPED_REF.Text & ";" & txtPED_ITEM.Text)
        Else
            Local.ArqLog(Lista, Format(Now, "yyyy-MM-dd HH:mm:ss") & ";" & Texto)
        End If
    End Sub

    Private Sub Barc_OnRead(ByVal sender As System.Object, ByVal readerData As Symbol.Barcode.ReaderData) Handles Barc.OnRead
        Try
            If ColetaOff.Visible Then
                ColetaOff.Focus()
                ColetaOff.Barc_OnRead(sender, readerData)
            ElseIf Conferencia.Visible Then
                Conferencia.Focus()
                Conferencia.Barc_OnRead(sender, readerData)
            Else
                Focus()
                Alert.Mostra("CLC - Obtendo etiqueta pela rede.")
                If readerData.Result = 0 Then
                    Notifica(readerData.Text)

                    Try
                        DS = RastrEtiqCodBarras(readerData.Text)
                        Mostra()
                        RegistraLog()
                        Def()
                    Catch ex As Exception
                        MsgBox(ex.Message & " na carga de dados")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " em leitura de cod de barras")
        End Try
        Alert.Esconde()
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Sobre.Show()
        Sobre.Focus()
    End Sub

    Sub MenuFecha()
        MenuItem6_Click(Nothing, Nothing)
    End Sub


    Private Sub btnKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKey.Click
        ColetaOff.Show()
        ColetaOff.MOSTRA(1)
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Master.Show()
        Master.Focus()
    End Sub

    Private Sub btnAtual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtual.Click
        Try
            Atualiza()
            If txtETIQUETA.Text <> "" Then
                Dim Digit As String = Replace(txtETIQUETA.Text, ".", "")
                Notifica(Digit)
                If Len(Digit) = 9 Then
                    Digit = "250" & Digit
                End If
                DS = RastrEtiqCodBarras(Digit)
                Mostra()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " na atualização dos dados")
        End Try
    End Sub

    Property TipoForm() As String
        Get
            Return lblTipo02.Text
        End Get
        Set(ByVal value As String)
            For Each ctl As Control In Controls
                If ctl.Name.StartsWith("lblTipo") Then
                    ctl.Text = value
                End If
            Next
        End Set
    End Property

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        DefLocaliza.Show()
        DefLocaliza.Focus()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        DefStatus.Show()
        DefStatus.Focus()
    End Sub


    Private _Params As System.Data.DataSet = Nothing
    Property CombosUsu() As System.Data.DataSet
        Get
            If IsNothing(_Params) Then
                _Params = CarregaCombosUsu(Login.txtUsuario.Text)
            End If
            Return _Params
        End Get
        Set(ByVal value As System.Data.DataSet)
            _Params = value
        End Set
    End Property

    Private Sub btnTroca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTroca.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Trocar unidade de dimensão no item de pedido?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                Alert.Mostra("CLC - Alterando item da base. Aguarde.")
                Dim PROX As String = ""
                If Local.NZ(txtESPEC.Text.StartsWith("MM:"), "") Then
                    PROX = "POL"
                ElseIf txtESPEC.Text.StartsWith("POL:") Then
                    PROX = "OU"
                Else
                    PROX = "MM"
                End If

                If Not TrocaUnidMedida(txtPED_REF.Text, txtPED_ITEM.Text, PROX) Then
                    MsgBox("Falha na troca da unidade. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Ok")
                    Atualiza()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " trocando unidade de apres dimensão no item")
        End Try
        Alert.Esconde()
    End Sub

    Private Sub btnSalvaPeso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaPeso.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Salvar peso?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim tonmax As Integer = Val(Opcoes.txtTonMax.Text)

                If txtPESO_BALANCA_LIQ.Text <> "" And txtPESO_BALANCA_BRUTO.Text = "" Then
                    txtPESO_BALANCA_BRUTO.Text = txtPESO_BALANCA_LIQ.Text
                End If
                If txtPESO_BALANCA_BRUTO.Text <> "" And txtPESO_BALANCA_LIQ.Text = "" Then
                    txtPESO_BALANCA_LIQ.Text = txtPESO_BALANCA_BRUTO.Text
                End If
                Dim liq As Double = Val(Replace(txtPESO_BALANCA_LIQ.Text, ",", "."))
                Dim brt As Double = Val(Replace(txtPESO_BALANCA_BRUTO.Text, ",", "."))
                If liq > tonmax Or brt > tonmax Then
                    liq = liq / 1000
                    brt = brt / 1000
                    txtPESO_BALANCA_LIQ.Text = Format(liq, txtPESO_BALANCA_LIQ.Tag)
                    txtPESO_BALANCA_BRUTO.Text = Format(brt, txtPESO_BALANCA_BRUTO.Tag)
                End If
                If liq > brt Then
                    MsgBox("Líquido não pode ser maior que bruto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                Dim QTDPECAS As Integer = Val(txtVOLUME_PECAS_QTD.Text)

                Alert.Mostra("CLC - Salvando peso e localização. Aguarde.")
                If Not SalvaPesoBalanca(txtETIQUETA.Text, liq, brt, QTDPECAS) Then
                    MsgBox("Falha na atualização do peso. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Else
                    If SalvaArmazem() Then
                        MsgBox("Ok")
                    Else
                        MsgBox("Alteração do peso foi feita, mas localização não. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " salvando peso")
        End Try
        Alert.Esconde()
    End Sub

    Function SalvaArmazem() As Boolean
        Return SalvaLocaliza(txtETIQUETA.Text, txtARMAZEM_CIA_COD.Text, txtARMAZEM_NUM.Text, txtARMAZEM_PRACA.Text, 0, 0)
    End Function

    Public Sub btnArmaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArmaz.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Salvar alterações na localização?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not SalvaArmazem() Then
                    MsgBox("Falha na atualização da localização. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Ok")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " salvanndo detalhes de localização")
        End Try
    End Sub

    Private Sub btnObsSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObsSalva.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Salvar observações?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not SalvaObs(txtETIQUETA.Text, txtOBS.Text) Then
                    MsgBox("Falha no registro da observação. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Ok")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " salvando observações")
        End Try
    End Sub

    Private Sub btnAvariaSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvariaSalva.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Salvar detalhes de avaria?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Not SalvaAvaria(txtETIQUETA.Text, txtAVARIA.Text) Then
                    MsgBox("Falha no registro de avaria. Tentar novamente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Ok")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " salvando detalhes de avaria")
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DefLocaliza.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Login.txtSENHA.Text = ""
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        NovoLog()
        MsgBox("Outro log iniciado com nome " & Lista)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtPESO_BALANCA_BRUTO.Text = ""
        txtPESO_BALANCA_LIQ.Text = ""
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Opcoes.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        btnKey_Click(Nothing, Nothing)
    End Sub

    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        txtPESO_BALANCA_LIQ.Text = txtPESO_LIQUIDO.Text
        txtPESO_BALANCA_BRUTO.Text = txtPESO_BRUTO.Text
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Conferencia.Show()
    End Sub

    Private Sub btnRecalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecalc.Click
        Try
            If Not Opcoes.chkAtivo.Checked OrElse MsgBox("Calcular novo peso teórico para o item?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                Alert.Mostra("CLC - Alterando item da base. Aguarde.")
                Dim DS As New System.Data.DataSet
                DS = DSCarregaRem("SELECT NVL((QTD * PESO),0) NOVO_PESO, QTD, PESO FROM (SELECT NVL(ETQ.VOLUME_PECAS_QTD,0) QTD, NVL(PE.PESO_TEORICO_PECA,0) PESO FROM IM.ETIQUETA ETQ, IM.PED_ITEM PI, IM.PROD_ESPEC PE WHERE ETQ.PED_ITEM = PI.ITEM (+) AND ETQ.PED_REF = PI.PED_REF (+) AND PI.PRODUTO_COD = PE.PRODUTO_COD (+) AND PI.ESPEC_SEQ = PE.SEQ (+) AND ETQ.ETIQUETA = '" & Local.Tratex(txtETIQUETA.Text) & "')")
                Dim QtdPecas As Double = DS.Tables(0).Rows(0)(1)
                Dim PesoTeorico As Double = DS.Tables(0).Rows(0)(2)
                Dim NovoPeso As Double = DS.Tables(0).Rows(0)(0)
                If DS.Tables(0).Rows.Count > 0 Then
                    If QtdPecas = 0 Then
                        MsgBox("Quantidade de peças não informada." & QtdPecas, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    ElseIf PesoTeorico = 0 Then
                        MsgBox("Peso teórico não informado." & PesoTeorico, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    Else
                        Try
                            DSGravaRem("UPDATE IM.ETIQUETA SET PESO_TEORICO = " & Replace(NovoPeso, ",", ".") & " WHERE ETIQUETA = '" & Local.Tratex(txtETIQUETA.Text) & "'")
                            MsgBox("Ok")
                            Atualiza()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Else
                    Throw New Exception("Especificação de produto não encontrado")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " calculando peso teórico do item.")
        End Try
        Alert.Esconde()
    End Sub

    Sub WirelessSinal()
        MyRadio = New Symbol.WirelessLAN.Radio
        AddHandler Me.MyRadio.StatusNotify, New EventHandler(AddressOf AtualizaSinal)
    End Sub

    Sub AtualizaNivelRede()
        Try
            Dim signalinfo As Symbol.WirelessLAN.Signal = Me.MyRadio.Signal
            StatusRede.Progress.Value = signalinfo.Percent
            StatusRede.Percentu.Text = signalinfo.Percent.ToString & "%"
            Dim Ret As String = Microsoft.VisualBasic.Left(Format(Now, "HH:mm:ss") & " " & signalinfo.Percent.ToString & "% em " & Me.MyRadio.ESSID.Text & vbCrLf & StatusRede.txtLog.Text, 300)
            StatusRede.txtLog.Text = Ret
        Catch
        End Try
    End Sub


    Private Sub AtualizaSinal(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim MyStatus As Symbol.WirelessLAN.WLANStatus = Me.MyRadio.GetNextStatus()
            If Not (MyStatus Is Nothing) Then
                Select Case MyStatus.Change
                    Case Symbol.WirelessLAN.ChangeType.ESSID
                        AtualizaNomeRede()
                    Case Symbol.WirelessLAN.ChangeType.SIGNAL
                        AtualizaNivelRede()
                End Select
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Sub AtualizaNomeRede()
        Try
            StatusRede.lblRede.Text = Me.MyRadio.ESSID.Text
        Catch
        End Try
    End Sub


    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        StatusRede.Show()
        StatusRede.Focus()
    End Sub

    Private Sub btnRepete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepete.Click
        If lblLeitura.Text <> ULTIMA_LEITURA Then
            txtETIQUETA.Text = lblLeitura.Text
        End If
    End Sub

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click
        Try
            Shell("PIMG.EXE", AppWinStyle.MaximizedFocus)
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Try
            Shell("MOBILECALCULATOR.EXE", AppWinStyle.MaximizedFocus)
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Try
            Shell("CLOCK.EXE", AppWinStyle.MaximizedFocus)
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Try
            Shell("TASKMGR.EXE", AppWinStyle.MaximizedFocus)
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Try
            Dim Arquivo As String = "CLColetor.exe"
            Dim ArqDown As String = "~/down/" & Arquivo
            Dim Atualiza As String = Local.BaseDir() & "\Atualiza.exe"
            Dim AppMomServer As Date = ArquivoMomentoModif(ArqDown)
            Dim AppMomLocal As Date = System.IO.File.GetLastWriteTime(Local.NomeExec)

            If DateDiff(DateInterval.Minute, AppMomLocal, AppMomServer) <> 0 Then
                If MsgBox("Versão mais atual disponível. Deseja atualizar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                Else
                    Alert.Mostra("CLC - Aguarde. Baixando arquivo mais atual.")
                    If System.IO.File.Exists(Atualiza) Then
                        System.IO.File.Delete(Atualiza)
                    End If
                    Local.SalvaByteArray(www.ArquivoBin(Arquivo), Atualiza)
                    Local.ExecShell(Atualiza)
                    Fecha()
                    Exit Sub
                End If
            End If
            MsgBox("Não existem atualizações para este aplicativo.")
        Catch ex As Exception
            MsgBox("Falha ao tentar encontrar atualização. (" & ex.Message & ")")
        End Try
        Alert.Esconde()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Carregamento.Show()
        Carregamento.Focus()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        BuscaArq.btnUpload_Click(Nothing, Nothing)
    End Sub
End Class
