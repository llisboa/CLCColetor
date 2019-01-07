<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Princ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Princ))
        Me.pnl01 = New System.Windows.Forms.Panel
        Me.btnRepete = New System.Windows.Forms.Button
        Me.lblLeitura = New System.Windows.Forms.Label
        Me.txtVOLUME_PECAS_QTD = New System.Windows.Forms.TextBox
        Me.btnConf = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSalvaPeso = New System.Windows.Forms.Button
        Me.btnTroca = New System.Windows.Forms.Button
        Me.txtETIQ_STATUS_COD = New System.Windows.Forms.TextBox
        Me.txtNR_CORRIDA = New System.Windows.Forms.TextBox
        Me.txtARMAZEM_PRACA = New System.Windows.Forms.TextBox
        Me.txtPESO_BALANCA_BRUTO = New System.Windows.Forms.TextBox
        Me.txtPESO_BRUTO = New System.Windows.Forms.TextBox
        Me.txtARMAZEM_NUM = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPESO_LIQUIDO = New System.Windows.Forms.TextBox
        Me.txtPESO_BALANCA_LIQ = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPRODUTO_COD = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtESPEC = New System.Windows.Forms.TextBox
        Me.txtFORNEC_COD = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCOR = New System.Windows.Forms.TextBox
        Me.btnBusca = New System.Windows.Forms.Button
        Me.txtETIQUETA = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.btnFoto = New System.Windows.Forms.Button
        Me.btnKey = New System.Windows.Forms.Button
        Me.btnAtual = New System.Windows.Forms.Button
        Me.txtVIAGEM_REF = New System.Windows.Forms.TextBox
        Me.txtORDEM_VENDA_REF = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPED_REF = New System.Windows.Forms.TextBox
        Me.txtINFNFE_IDE_NNF = New System.Windows.Forms.TextBox
        Me.txtINFNFE_IDE_SERIE = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.pnl02 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPED_ITEM = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTipo02 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtETIQ_FORN = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.pnl03 = New System.Windows.Forms.Panel
        Me.btnRecalc = New System.Windows.Forms.Button
        Me.txtARMAZEM_CIA_COD = New System.Windows.Forms.ComboBox
        Me.txtAPRES_PESO_TIPO = New System.Windows.Forms.TextBox
        Me.btnArmaz = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTipo03 = New System.Windows.Forms.Label
        Me.txtPESO_TEORICO = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnl04 = New System.Windows.Forms.Panel
        Me.btnAvariaSalva = New System.Windows.Forms.Button
        Me.txtAVARIA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblTipo05 = New System.Windows.Forms.Label
        Me.ctxMenu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.btnMenu = New System.Windows.Forms.Button
        Me.Barc = New Barcode.Barcode
        Me.pnl05 = New System.Windows.Forms.Panel
        Me.btnObsSalva = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblTipo06 = New System.Windows.Forms.Label
        Me.txtOBS = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.pnl01.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl02.SuspendLayout()
        Me.pnl03.SuspendLayout()
        Me.pnl04.SuspendLayout()
        Me.pnl05.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl01
        '
        Me.pnl01.BackColor = System.Drawing.Color.Silver
        Me.pnl01.Controls.Add(Me.btnRepete)
        Me.pnl01.Controls.Add(Me.lblLeitura)
        Me.pnl01.Controls.Add(Me.txtVOLUME_PECAS_QTD)
        Me.pnl01.Controls.Add(Me.btnConf)
        Me.pnl01.Controls.Add(Me.Button1)
        Me.pnl01.Controls.Add(Me.btnSalvaPeso)
        Me.pnl01.Controls.Add(Me.btnTroca)
        Me.pnl01.Controls.Add(Me.txtETIQ_STATUS_COD)
        Me.pnl01.Controls.Add(Me.txtNR_CORRIDA)
        Me.pnl01.Controls.Add(Me.txtARMAZEM_PRACA)
        Me.pnl01.Controls.Add(Me.txtPESO_BALANCA_BRUTO)
        Me.pnl01.Controls.Add(Me.txtPESO_BRUTO)
        Me.pnl01.Controls.Add(Me.txtARMAZEM_NUM)
        Me.pnl01.Controls.Add(Me.Label34)
        Me.pnl01.Controls.Add(Me.Label13)
        Me.pnl01.Controls.Add(Me.txtPESO_LIQUIDO)
        Me.pnl01.Controls.Add(Me.txtPESO_BALANCA_LIQ)
        Me.pnl01.Controls.Add(Me.Label14)
        Me.pnl01.Controls.Add(Me.Label10)
        Me.pnl01.Controls.Add(Me.txtPRODUTO_COD)
        Me.pnl01.Controls.Add(Me.Label12)
        Me.pnl01.Controls.Add(Me.txtESPEC)
        Me.pnl01.Controls.Add(Me.txtFORNEC_COD)
        Me.pnl01.Controls.Add(Me.Label7)
        Me.pnl01.Controls.Add(Me.Label5)
        Me.pnl01.Controls.Add(Me.Label2)
        Me.pnl01.Controls.Add(Me.Label8)
        Me.pnl01.Location = New System.Drawing.Point(9, 35)
        Me.pnl01.Name = "pnl01"
        Me.pnl01.Size = New System.Drawing.Size(240, 272)
        '
        'btnRepete
        '
        Me.btnRepete.Location = New System.Drawing.Point(193, 1)
        Me.btnRepete.Name = "btnRepete"
        Me.btnRepete.Size = New System.Drawing.Size(23, 15)
        Me.btnRepete.TabIndex = 25
        Me.btnRepete.Text = "<"
        '
        'lblLeitura
        '
        Me.lblLeitura.BackColor = System.Drawing.Color.Silver
        Me.lblLeitura.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblLeitura.ForeColor = System.Drawing.Color.Gold
        Me.lblLeitura.Location = New System.Drawing.Point(78, 2)
        Me.lblLeitura.Name = "lblLeitura"
        Me.lblLeitura.Size = New System.Drawing.Size(113, 15)
        '
        'txtVOLUME_PECAS_QTD
        '
        Me.txtVOLUME_PECAS_QTD.BackColor = System.Drawing.Color.White
        Me.txtVOLUME_PECAS_QTD.Location = New System.Drawing.Point(100, 94)
        Me.txtVOLUME_PECAS_QTD.Name = "txtVOLUME_PECAS_QTD"
        Me.txtVOLUME_PECAS_QTD.Size = New System.Drawing.Size(53, 23)
        Me.txtVOLUME_PECAS_QTD.TabIndex = 2
        Me.txtVOLUME_PECAS_QTD.Tag = "###0"
        '
        'btnConf
        '
        Me.btnConf.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnConf.Location = New System.Drawing.Point(199, 182)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(35, 23)
        Me.btnConf.TabIndex = 9
        Me.btnConf.Text = "Conf."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Button1.Location = New System.Drawing.Point(199, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Limpa"
        '
        'btnSalvaPeso
        '
        Me.btnSalvaPeso.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnSalvaPeso.Location = New System.Drawing.Point(144, 231)
        Me.btnSalvaPeso.Name = "btnSalvaPeso"
        Me.btnSalvaPeso.Size = New System.Drawing.Size(43, 35)
        Me.btnSalvaPeso.TabIndex = 15
        Me.btnSalvaPeso.Text = "Salva"
        '
        'btnTroca
        '
        Me.btnTroca.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnTroca.Location = New System.Drawing.Point(10, 138)
        Me.btnTroca.Name = "btnTroca"
        Me.btnTroca.Size = New System.Drawing.Size(44, 38)
        Me.btnTroca.TabIndex = 5
        Me.btnTroca.Text = "Troca"
        '
        'txtETIQ_STATUS_COD
        '
        Me.txtETIQ_STATUS_COD.BackColor = System.Drawing.Color.Gainsboro
        Me.txtETIQ_STATUS_COD.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtETIQ_STATUS_COD.Location = New System.Drawing.Point(7, 71)
        Me.txtETIQ_STATUS_COD.Name = "txtETIQ_STATUS_COD"
        Me.txtETIQ_STATUS_COD.Size = New System.Drawing.Size(146, 23)
        Me.txtETIQ_STATUS_COD.TabIndex = 0
        '
        'txtNR_CORRIDA
        '
        Me.txtNR_CORRIDA.BackColor = System.Drawing.Color.DarkGray
        Me.txtNR_CORRIDA.Location = New System.Drawing.Point(152, 94)
        Me.txtNR_CORRIDA.Name = "txtNR_CORRIDA"
        Me.txtNR_CORRIDA.Size = New System.Drawing.Size(75, 23)
        Me.txtNR_CORRIDA.TabIndex = 3
        '
        'txtARMAZEM_PRACA
        '
        Me.txtARMAZEM_PRACA.Location = New System.Drawing.Point(81, 242)
        Me.txtARMAZEM_PRACA.Name = "txtARMAZEM_PRACA"
        Me.txtARMAZEM_PRACA.Size = New System.Drawing.Size(60, 23)
        Me.txtARMAZEM_PRACA.TabIndex = 14
        Me.txtARMAZEM_PRACA.Tag = ""
        '
        'txtPESO_BALANCA_BRUTO
        '
        Me.txtPESO_BALANCA_BRUTO.BackColor = System.Drawing.Color.White
        Me.txtPESO_BALANCA_BRUTO.Location = New System.Drawing.Point(138, 206)
        Me.txtPESO_BALANCA_BRUTO.Name = "txtPESO_BALANCA_BRUTO"
        Me.txtPESO_BALANCA_BRUTO.Size = New System.Drawing.Size(58, 23)
        Me.txtPESO_BALANCA_BRUTO.TabIndex = 11
        Me.txtPESO_BALANCA_BRUTO.Tag = "##0.000"
        '
        'txtPESO_BRUTO
        '
        Me.txtPESO_BRUTO.BackColor = System.Drawing.Color.DarkGray
        Me.txtPESO_BRUTO.Location = New System.Drawing.Point(138, 182)
        Me.txtPESO_BRUTO.Name = "txtPESO_BRUTO"
        Me.txtPESO_BRUTO.Size = New System.Drawing.Size(58, 23)
        Me.txtPESO_BRUTO.TabIndex = 8
        Me.txtPESO_BRUTO.Tag = "##0.000"
        '
        'txtARMAZEM_NUM
        '
        Me.txtARMAZEM_NUM.Location = New System.Drawing.Point(26, 242)
        Me.txtARMAZEM_NUM.Name = "txtARMAZEM_NUM"
        Me.txtARMAZEM_NUM.Size = New System.Drawing.Size(34, 23)
        Me.txtARMAZEM_NUM.TabIndex = 13
        Me.txtARMAZEM_NUM.Tag = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(6, 246)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 20)
        Me.Label34.Text = "Nr."
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(116, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 20)
        Me.Label13.Text = "Brt."
        '
        'txtPESO_LIQUIDO
        '
        Me.txtPESO_LIQUIDO.BackColor = System.Drawing.Color.DarkGray
        Me.txtPESO_LIQUIDO.Location = New System.Drawing.Point(58, 182)
        Me.txtPESO_LIQUIDO.Name = "txtPESO_LIQUIDO"
        Me.txtPESO_LIQUIDO.Size = New System.Drawing.Size(58, 23)
        Me.txtPESO_LIQUIDO.TabIndex = 7
        Me.txtPESO_LIQUIDO.Tag = "##0.000"
        '
        'txtPESO_BALANCA_LIQ
        '
        Me.txtPESO_BALANCA_LIQ.BackColor = System.Drawing.Color.White
        Me.txtPESO_BALANCA_LIQ.Location = New System.Drawing.Point(58, 206)
        Me.txtPESO_BALANCA_LIQ.Name = "txtPESO_BALANCA_LIQ"
        Me.txtPESO_BALANCA_LIQ.Size = New System.Drawing.Size(58, 23)
        Me.txtPESO_BALANCA_LIQ.TabIndex = 10
        Me.txtPESO_BALANCA_LIQ.Tag = "##0.000"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(7, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 20)
        Me.Label14.Text = "Forn.Líq."
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(62, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 20)
        Me.Label10.Text = "Pç."
        '
        'txtPRODUTO_COD
        '
        Me.txtPRODUTO_COD.BackColor = System.Drawing.Color.DarkGray
        Me.txtPRODUTO_COD.Location = New System.Drawing.Point(60, 116)
        Me.txtPRODUTO_COD.Name = "txtPRODUTO_COD"
        Me.txtPRODUTO_COD.Size = New System.Drawing.Size(167, 23)
        Me.txtPRODUTO_COD.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(116, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 20)
        Me.Label12.Text = "Brt."
        '
        'txtESPEC
        '
        Me.txtESPEC.BackColor = System.Drawing.Color.DarkGray
        Me.txtESPEC.Location = New System.Drawing.Point(60, 138)
        Me.txtESPEC.Multiline = True
        Me.txtESPEC.Name = "txtESPEC"
        Me.txtESPEC.Size = New System.Drawing.Size(167, 38)
        Me.txtESPEC.TabIndex = 6
        '
        'txtFORNEC_COD
        '
        Me.txtFORNEC_COD.BackColor = System.Drawing.Color.DarkGray
        Me.txtFORNEC_COD.Location = New System.Drawing.Point(152, 72)
        Me.txtFORNEC_COD.Name = "txtFORNEC_COD"
        Me.txtFORNEC_COD.Size = New System.Drawing.Size(75, 23)
        Me.txtFORNEC_COD.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.Text = "Prod."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.Text = "QtdPçs/Corrida"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.Text = "Peso Liq."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(6, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.Text = "Localização"
        '
        'txtCOR
        '
        Me.txtCOR.BackColor = System.Drawing.Color.DarkGray
        Me.txtCOR.Location = New System.Drawing.Point(83, 182)
        Me.txtCOR.Name = "txtCOR"
        Me.txtCOR.Size = New System.Drawing.Size(143, 23)
        Me.txtCOR.TabIndex = 5
        '
        'btnBusca
        '
        Me.btnBusca.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnBusca.Location = New System.Drawing.Point(191, 4)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(44, 29)
        Me.btnBusca.TabIndex = 4
        Me.btnBusca.Text = "Ler"
        '
        'txtETIQUETA
        '
        Me.txtETIQUETA.Location = New System.Drawing.Point(78, 15)
        Me.txtETIQUETA.Name = "txtETIQUETA"
        Me.txtETIQUETA.Size = New System.Drawing.Size(111, 23)
        Me.txtETIQUETA.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnBusca)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnFoto)
        Me.Panel1.Controls.Add(Me.btnKey)
        Me.Panel1.Controls.Add(Me.btnAtual)
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 36)
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Button5.Location = New System.Drawing.Point(144, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 29)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Localiza"
        '
        'btnFoto
        '
        Me.btnFoto.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnFoto.Location = New System.Drawing.Point(97, 4)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(44, 29)
        Me.btnFoto.TabIndex = 2
        Me.btnFoto.Text = "Foto"
        '
        'btnKey
        '
        Me.btnKey.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnKey.Location = New System.Drawing.Point(50, 4)
        Me.btnKey.Name = "btnKey"
        Me.btnKey.Size = New System.Drawing.Size(44, 29)
        Me.btnKey.TabIndex = 1
        Me.btnKey.Text = "OffLine"
        '
        'btnAtual
        '
        Me.btnAtual.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnAtual.Location = New System.Drawing.Point(3, 4)
        Me.btnAtual.Name = "btnAtual"
        Me.btnAtual.Size = New System.Drawing.Size(44, 29)
        Me.btnAtual.TabIndex = 0
        Me.btnAtual.Text = "Atualiza"
        '
        'txtVIAGEM_REF
        '
        Me.txtVIAGEM_REF.BackColor = System.Drawing.Color.DarkGray
        Me.txtVIAGEM_REF.Location = New System.Drawing.Point(83, 138)
        Me.txtVIAGEM_REF.Name = "txtVIAGEM_REF"
        Me.txtVIAGEM_REF.Size = New System.Drawing.Size(143, 23)
        Me.txtVIAGEM_REF.TabIndex = 3
        '
        'txtORDEM_VENDA_REF
        '
        Me.txtORDEM_VENDA_REF.BackColor = System.Drawing.Color.DarkGray
        Me.txtORDEM_VENDA_REF.Location = New System.Drawing.Point(83, 116)
        Me.txtORDEM_VENDA_REF.Name = "txtORDEM_VENDA_REF"
        Me.txtORDEM_VENDA_REF.Size = New System.Drawing.Size(143, 23)
        Me.txtORDEM_VENDA_REF.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(14, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 20)
        Me.Label17.Text = "Viagem"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(14, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.Text = "Ordem"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(14, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.Text = "Armazém"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(14, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 20)
        Me.Label19.Text = "Ped./Item"
        '
        'txtPED_REF
        '
        Me.txtPED_REF.BackColor = System.Drawing.Color.DarkGray
        Me.txtPED_REF.Location = New System.Drawing.Point(83, 94)
        Me.txtPED_REF.Name = "txtPED_REF"
        Me.txtPED_REF.Size = New System.Drawing.Size(109, 23)
        Me.txtPED_REF.TabIndex = 0
        '
        'txtINFNFE_IDE_NNF
        '
        Me.txtINFNFE_IDE_NNF.BackColor = System.Drawing.Color.DarkGray
        Me.txtINFNFE_IDE_NNF.Location = New System.Drawing.Point(152, 204)
        Me.txtINFNFE_IDE_NNF.Name = "txtINFNFE_IDE_NNF"
        Me.txtINFNFE_IDE_NNF.Size = New System.Drawing.Size(74, 23)
        Me.txtINFNFE_IDE_NNF.TabIndex = 7
        '
        'txtINFNFE_IDE_SERIE
        '
        Me.txtINFNFE_IDE_SERIE.BackColor = System.Drawing.Color.DarkGray
        Me.txtINFNFE_IDE_SERIE.Location = New System.Drawing.Point(83, 204)
        Me.txtINFNFE_IDE_SERIE.Name = "txtINFNFE_IDE_SERIE"
        Me.txtINFNFE_IDE_SERIE.Size = New System.Drawing.Size(33, 23)
        Me.txtINFNFE_IDE_SERIE.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(120, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 20)
        Me.Label20.Text = "Num"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(14, 208)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 20)
        Me.Label21.Text = "NF Serie"
        '
        'pnl02
        '
        Me.pnl02.BackColor = System.Drawing.Color.Silver
        Me.pnl02.Controls.Add(Me.txtINFNFE_IDE_NNF)
        Me.pnl02.Controls.Add(Me.txtINFNFE_IDE_SERIE)
        Me.pnl02.Controls.Add(Me.Label20)
        Me.pnl02.Controls.Add(Me.Label21)
        Me.pnl02.Controls.Add(Me.txtCOR)
        Me.pnl02.Controls.Add(Me.Label3)
        Me.pnl02.Controls.Add(Me.txtPED_ITEM)
        Me.pnl02.Controls.Add(Me.Panel2)
        Me.pnl02.Controls.Add(Me.lblTipo02)
        Me.pnl02.Controls.Add(Me.Label23)
        Me.pnl02.Controls.Add(Me.txtETIQ_FORN)
        Me.pnl02.Controls.Add(Me.txtVIAGEM_REF)
        Me.pnl02.Controls.Add(Me.txtPED_REF)
        Me.pnl02.Controls.Add(Me.txtORDEM_VENDA_REF)
        Me.pnl02.Controls.Add(Me.Label18)
        Me.pnl02.Controls.Add(Me.Label31)
        Me.pnl02.Controls.Add(Me.Label19)
        Me.pnl02.Controls.Add(Me.Label17)
        Me.pnl02.Location = New System.Drawing.Point(272, 14)
        Me.pnl02.Name = "pnl02"
        Me.pnl02.Size = New System.Drawing.Size(240, 272)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.Text = "Cor"
        '
        'txtPED_ITEM
        '
        Me.txtPED_ITEM.BackColor = System.Drawing.Color.DarkGray
        Me.txtPED_ITEM.Location = New System.Drawing.Point(193, 94)
        Me.txtPED_ITEM.Name = "txtPED_ITEM"
        Me.txtPED_ITEM.Size = New System.Drawing.Size(33, 23)
        Me.txtPED_ITEM.TabIndex = 1
        Me.txtPED_ITEM.Tag = "000"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(1, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 36)
        '
        'lblTipo02
        '
        Me.lblTipo02.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo02.Name = "lblTipo02"
        Me.lblTipo02.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo02.Text = "Referências"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(4, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(175, 20)
        Me.Label23.Text = "Referências"
        '
        'txtETIQ_FORN
        '
        Me.txtETIQ_FORN.BackColor = System.Drawing.Color.DarkGray
        Me.txtETIQ_FORN.Location = New System.Drawing.Point(83, 160)
        Me.txtETIQ_FORN.Name = "txtETIQ_FORN"
        Me.txtETIQ_FORN.Size = New System.Drawing.Size(143, 23)
        Me.txtETIQ_FORN.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(14, 163)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 20)
        Me.Label31.Text = "Forneced."
        '
        'pnl03
        '
        Me.pnl03.BackColor = System.Drawing.Color.Silver
        Me.pnl03.Controls.Add(Me.btnRecalc)
        Me.pnl03.Controls.Add(Me.txtARMAZEM_CIA_COD)
        Me.pnl03.Controls.Add(Me.txtAPRES_PESO_TIPO)
        Me.pnl03.Controls.Add(Me.btnArmaz)
        Me.pnl03.Controls.Add(Me.Panel3)
        Me.pnl03.Controls.Add(Me.lblTipo03)
        Me.pnl03.Controls.Add(Me.txtPESO_TEORICO)
        Me.pnl03.Controls.Add(Me.Label15)
        Me.pnl03.Controls.Add(Me.Label26)
        Me.pnl03.Controls.Add(Me.Label11)
        Me.pnl03.Controls.Add(Me.Label25)
        Me.pnl03.Controls.Add(Me.Label4)
        Me.pnl03.Location = New System.Drawing.Point(528, 14)
        Me.pnl03.Name = "pnl03"
        Me.pnl03.Size = New System.Drawing.Size(240, 272)
        '
        'btnRecalc
        '
        Me.btnRecalc.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnRecalc.Location = New System.Drawing.Point(117, 92)
        Me.btnRecalc.Name = "btnRecalc"
        Me.btnRecalc.Size = New System.Drawing.Size(35, 23)
        Me.btnRecalc.TabIndex = 27
        Me.btnRecalc.Text = "Recalc."
        '
        'txtARMAZEM_CIA_COD
        '
        Me.txtARMAZEM_CIA_COD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_CIA_COD.Location = New System.Drawing.Point(83, 165)
        Me.txtARMAZEM_CIA_COD.Name = "txtARMAZEM_CIA_COD"
        Me.txtARMAZEM_CIA_COD.Size = New System.Drawing.Size(143, 23)
        Me.txtARMAZEM_CIA_COD.TabIndex = 2
        '
        'txtAPRES_PESO_TIPO
        '
        Me.txtAPRES_PESO_TIPO.BackColor = System.Drawing.Color.DarkGray
        Me.txtAPRES_PESO_TIPO.Location = New System.Drawing.Point(200, 92)
        Me.txtAPRES_PESO_TIPO.Name = "txtAPRES_PESO_TIPO"
        Me.txtAPRES_PESO_TIPO.Size = New System.Drawing.Size(33, 23)
        Me.txtAPRES_PESO_TIPO.TabIndex = 1
        '
        'btnArmaz
        '
        Me.btnArmaz.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnArmaz.Location = New System.Drawing.Point(143, 231)
        Me.btnArmaz.Name = "btnArmaz"
        Me.btnArmaz.Size = New System.Drawing.Size(43, 35)
        Me.btnArmaz.TabIndex = 3
        Me.btnArmaz.Text = "Salva"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Location = New System.Drawing.Point(1, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 36)
        '
        'lblTipo03
        '
        Me.lblTipo03.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo03.Name = "lblTipo03"
        Me.lblTipo03.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo03.Text = "Dados Gerais"
        '
        'txtPESO_TEORICO
        '
        Me.txtPESO_TEORICO.BackColor = System.Drawing.Color.DarkGray
        Me.txtPESO_TEORICO.Location = New System.Drawing.Point(58, 92)
        Me.txtPESO_TEORICO.Name = "txtPESO_TEORICO"
        Me.txtPESO_TEORICO.Size = New System.Drawing.Size(52, 23)
        Me.txtPESO_TEORICO.TabIndex = 0
        Me.txtPESO_TEORICO.Tag = "##0.000"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(5, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 20)
        Me.Label15.Text = "Teórico"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(4, 143)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(175, 20)
        Me.Label26.Text = "Localização do Material"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(4, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(175, 20)
        Me.Label25.Text = "Peso"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(162, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.Text = "Unid."
        '
        'pnl04
        '
        Me.pnl04.BackColor = System.Drawing.Color.Silver
        Me.pnl04.Controls.Add(Me.btnAvariaSalva)
        Me.pnl04.Controls.Add(Me.txtAVARIA)
        Me.pnl04.Controls.Add(Me.Label1)
        Me.pnl04.Controls.Add(Me.Panel5)
        Me.pnl04.Controls.Add(Me.lblTipo05)
        Me.pnl04.Location = New System.Drawing.Point(3, 343)
        Me.pnl04.Name = "pnl04"
        Me.pnl04.Size = New System.Drawing.Size(240, 272)
        '
        'btnAvariaSalva
        '
        Me.btnAvariaSalva.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnAvariaSalva.Location = New System.Drawing.Point(143, 231)
        Me.btnAvariaSalva.Name = "btnAvariaSalva"
        Me.btnAvariaSalva.Size = New System.Drawing.Size(43, 35)
        Me.btnAvariaSalva.TabIndex = 1
        Me.btnAvariaSalva.Text = "Salva"
        '
        'txtAVARIA
        '
        Me.txtAVARIA.Location = New System.Drawing.Point(5, 91)
        Me.txtAVARIA.Multiline = True
        Me.txtAVARIA.Name = "txtAVARIA"
        Me.txtAVARIA.Size = New System.Drawing.Size(230, 112)
        Me.txtAVARIA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 20)
        Me.Label1.Text = "Avaria"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(1, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 36)
        '
        'lblTipo05
        '
        Me.lblTipo05.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo05.Name = "lblTipo05"
        Me.lblTipo05.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo05.Text = "Avaria do Produto"
        '
        'ctxMenu
        '
        Me.ctxMenu.MenuItems.Add(Me.MenuItem1)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem5)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem13)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem15)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem11)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem18)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem9)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem10)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem3)
        Me.ctxMenu.MenuItems.Add(Me.MenuItem6)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem4)
        Me.MenuItem1.Text = "Preenchimento Automático"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Definir Localização"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "Definir Status"
        '
        'MenuItem5
        '
        Me.MenuItem5.MenuItems.Add(Me.MenuItem12)
        Me.MenuItem5.Text = "Registro em Log"
        '
        'MenuItem12
        '
        Me.MenuItem12.Text = "Novo"
        '
        'MenuItem13
        '
        Me.MenuItem13.MenuItems.Add(Me.MenuItem24)
        Me.MenuItem13.MenuItems.Add(Me.MenuItem14)
        Me.MenuItem13.Text = "Carregamento"
        '
        'MenuItem24
        '
        Me.MenuItem24.Text = "Etiquetas"
        '
        'MenuItem14
        '
        Me.MenuItem14.Text = "Registro Off-Line"
        '
        'MenuItem15
        '
        Me.MenuItem15.MenuItems.Add(Me.MenuItem16)
        Me.MenuItem15.Text = "Conferência"
        '
        'MenuItem16
        '
        Me.MenuItem16.Text = "Etiquetas na Praça"
        '
        'MenuItem11
        '
        Me.MenuItem11.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.MenuItems.Add(Me.MenuItem19)
        Me.MenuItem18.MenuItems.Add(Me.MenuItem20)
        Me.MenuItem18.MenuItems.Add(Me.MenuItem21)
        Me.MenuItem18.Text = "Utilitários"
        '
        'MenuItem19
        '
        Me.MenuItem19.Text = "Calculadora"
        '
        'MenuItem20
        '
        Me.MenuItem20.Text = "Relógio"
        '
        'MenuItem21
        '
        Me.MenuItem21.Text = "Gerenciador de Tarefas"
        '
        'MenuItem9
        '
        Me.MenuItem9.MenuItems.Add(Me.MenuItem8)
        Me.MenuItem9.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem9.MenuItems.Add(Me.MenuItem17)
        Me.MenuItem9.MenuItems.Add(Me.MenuItem22)
        Me.MenuItem9.MenuItems.Add(Me.MenuItem23)
        Me.MenuItem9.MenuItems.Add(Me.MenuItem25)
        Me.MenuItem9.Text = "O Sistema"
        '
        'MenuItem8
        '
        Me.MenuItem8.Text = "Sobre o Sistema"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "Opções"
        '
        'MenuItem17
        '
        Me.MenuItem17.Text = "Status da Rede"
        '
        'MenuItem22
        '
        Me.MenuItem22.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Text = "Atualizar o Aplicativo"
        '
        'MenuItem10
        '
        Me.MenuItem10.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Logar com Outro Usuário"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "Sair do Sistema"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(72, 31)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menu"
        '
        'Barc
        '
        Me.Barc.DecoderParameters.CODABAR = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.CODABARParams.ClsiEditing = False
        Me.Barc.DecoderParameters.CODABARParams.NotisEditing = False
        Me.Barc.DecoderParameters.CODABARParams.Redundancy = True
        Me.Barc.DecoderParameters.CODE128 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.CODE128Params.EAN128 = True
        Me.Barc.DecoderParameters.CODE128Params.ISBT128 = True
        Me.Barc.DecoderParameters.CODE128Params.Other128 = True
        Me.Barc.DecoderParameters.CODE128Params.Redundancy = False
        Me.Barc.DecoderParameters.CODE39 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.CODE39Params.Code32Prefix = False
        Me.Barc.DecoderParameters.CODE39Params.Concatenation = False
        Me.Barc.DecoderParameters.CODE39Params.ConvertToCode32 = False
        Me.Barc.DecoderParameters.CODE39Params.FullAscii = False
        Me.Barc.DecoderParameters.CODE39Params.Redundancy = False
        Me.Barc.DecoderParameters.CODE39Params.ReportCheckDigit = False
        Me.Barc.DecoderParameters.CODE39Params.VerifyCheckDigit = False
        Me.Barc.DecoderParameters.CODE93 = Barcode.DisabledEnabled.Undefined
        Me.Barc.DecoderParameters.CODE93Params.Redundancy = False
        Me.Barc.DecoderParameters.D2OF5 = Barcode.DisabledEnabled.Disabled
        Me.Barc.DecoderParameters.D2OF5Params.Redundancy = True
        Me.Barc.DecoderParameters.EAN13 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.EAN8 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.EAN8Params.ConvertToEAN13 = False
        Me.Barc.DecoderParameters.I2OF5 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.I2OF5Params.CheckDigitScheme = Symbol.Barcode.I2OF5.CheckDigitSchemes.None
        Me.Barc.DecoderParameters.I2OF5Params.ConvertToEAN13 = False
        Me.Barc.DecoderParameters.I2OF5Params.Redundancy = True
        Me.Barc.DecoderParameters.I2OF5Params.ReportCheckDigit = False
        Me.Barc.DecoderParameters.KOREAN_3OF5 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.MSI = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.MSIParams.CheckDigitCount = Symbol.Barcode.MSI.CheckDigitCounts.One
        Me.Barc.DecoderParameters.MSIParams.CheckDigitScheme = Symbol.Barcode.MSI.CheckDigitSchemes.Mod_11_10
        Me.Barc.DecoderParameters.MSIParams.Redundancy = True
        Me.Barc.DecoderParameters.MSIParams.ReportCheckDigit = False
        Me.Barc.DecoderParameters.UPCA = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.UPCAParams.Preamble = Symbol.Barcode.UPC.Preambles.System
        Me.Barc.DecoderParameters.UPCAParams.ReportCheckDigit = True
        Me.Barc.DecoderParameters.UPCE0 = Barcode.DisabledEnabled.Enabled
        Me.Barc.DecoderParameters.UPCE0Params.ConvertToUPCA = False
        Me.Barc.DecoderParameters.UPCE0Params.Preamble = Symbol.Barcode.UPC.Preambles.None
        Me.Barc.DecoderParameters.UPCE0Params.ReportCheckDigit = False
        Me.Barc.DeviceName = Nothing
        Me.Barc.EnableScanner = False
        Me.Barc.ReaderParameters.ReaderSpecific.ContactSpecific.InitialScanTime = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ContactSpecific.PulseDelay = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ContactSpecific.QuietZoneRatio = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.AimDuration = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.BeamTimer = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.DPMMode = Barcode.DPM_MODE.DPM_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusMode = Barcode.FOCUS_MODE.FOCUS_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.FocusPosition = Barcode.FOCUS_POSITION.FOCUS_POSITION_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.IlluminationMode = Barcode.ILLUMINATION_MODE.ILLUMINATION_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCaptureTimeout = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.ImageCompressionTimeout = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.Inverse1DMode = Barcode.INVERSE1D_MODE.INVERSE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistMode = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.PicklistModeEx = Barcode.PICKLIST_MODE.PICKLIST_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.PointerTimer = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.PoorQuality1DMode = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedback = Barcode.VIEWFINDER_FEEDBACK.VIEWFINDER_FEEDBACK_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFFeedbackTime = -1
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFMode = Barcode.VIEWFINDER_MODE.VIEWFINDER_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Bottom = 0
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Left = 0
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Right = 0
        Me.Barc.ReaderParameters.ReaderSpecific.ImagerSpecific.VFPosition.Top = 0
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.AimDuration = -1
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.AimMode = Barcode.AIM_MODE.AIM_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.AimType = Barcode.AIM_TYPE.AIM_TYPE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.BeamTimer = -1
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.BidirRedundancy = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.ControlScanLed = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.DBPMode = Barcode.DBP_MODE.DBP_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.KlasseEinsEnable = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.LinearSecurityLevel = Barcode.LINEAR_SECURITY_LEVEL.SECURITY_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.NarrowBeam = Barcode.DisabledEnabled.Undefined
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.PointerTimer = -1
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.RasterHeight = -1
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.RasterMode = Barcode.RASTER_MODE.RASTER_MODE_UNDEFINED
        Me.Barc.ReaderParameters.ReaderSpecific.LaserSpecific.ScanLedLogicLevel = Barcode.DisabledEnabled.Undefined
        Me.Barc.ScanParameters.BeepFrequency = 2670
        Me.Barc.ScanParameters.BeepTime = 200
        Me.Barc.ScanParameters.CodeIdType = Barcode.CodeIdTypes.None
        Me.Barc.ScanParameters.LedTime = 3000
        Me.Barc.ScanParameters.ScanType = Barcode.ScanTypes.Foreground
        Me.Barc.ScanParameters.WaveFile = ""
        '
        'pnl05
        '
        Me.pnl05.BackColor = System.Drawing.Color.Silver
        Me.pnl05.Controls.Add(Me.btnObsSalva)
        Me.pnl05.Controls.Add(Me.Panel6)
        Me.pnl05.Controls.Add(Me.lblTipo06)
        Me.pnl05.Controls.Add(Me.txtOBS)
        Me.pnl05.Controls.Add(Me.Label33)
        Me.pnl05.Location = New System.Drawing.Point(286, 345)
        Me.pnl05.Name = "pnl05"
        Me.pnl05.Size = New System.Drawing.Size(240, 272)
        '
        'btnObsSalva
        '
        Me.btnObsSalva.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnObsSalva.Location = New System.Drawing.Point(143, 231)
        Me.btnObsSalva.Name = "btnObsSalva"
        Me.btnObsSalva.Size = New System.Drawing.Size(43, 35)
        Me.btnObsSalva.TabIndex = 1
        Me.btnObsSalva.Text = "Salva"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Location = New System.Drawing.Point(1, 33)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(238, 36)
        '
        'lblTipo06
        '
        Me.lblTipo06.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo06.Name = "lblTipo06"
        Me.lblTipo06.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo06.Text = "Obs. Interna"
        '
        'txtOBS
        '
        Me.txtOBS.Location = New System.Drawing.Point(5, 89)
        Me.txtOBS.Multiline = True
        Me.txtOBS.Name = "txtOBS"
        Me.txtOBS.Size = New System.Drawing.Size(230, 112)
        Me.txtOBS.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(6, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(175, 20)
        Me.Label33.Text = "Observações"
        '
        'MenuItem25
        '
        Me.MenuItem25.Text = "Upload de Docs"
        '
        'Princ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1036, 674)
        Me.Controls.Add(Me.txtETIQUETA)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pnl03)
        Me.Controls.Add(Me.pnl02)
        Me.Controls.Add(Me.pnl04)
        Me.Controls.Add(Me.pnl05)
        Me.Controls.Add(Me.pnl01)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Princ"
        Me.Text = "Form1"
        Me.pnl01.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnl02.ResumeLayout(False)
        Me.pnl03.ResumeLayout(False)
        Me.pnl04.ResumeLayout(False)
        Me.pnl05.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl01 As System.Windows.Forms.Panel
    Friend WithEvents txtPRODUTO_COD As System.Windows.Forms.TextBox
    Friend WithEvents txtESPEC As System.Windows.Forms.TextBox
    Friend WithEvents txtCOR As System.Windows.Forms.TextBox
    Friend WithEvents txtFORNEC_COD As System.Windows.Forms.TextBox
    Friend WithEvents txtETIQUETA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPESO_BRUTO As System.Windows.Forms.TextBox
    Friend WithEvents txtPESO_LIQUIDO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtARMAZEM_PRACA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPESO_BALANCA_BRUTO As System.Windows.Forms.TextBox
    Friend WithEvents txtPESO_BALANCA_LIQ As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVIAGEM_REF As System.Windows.Forms.TextBox
    Friend WithEvents txtORDEM_VENDA_REF As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtINFNFE_IDE_NNF As System.Windows.Forms.TextBox
    Friend WithEvents txtINFNFE_IDE_SERIE As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPED_REF As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pnl02 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents pnl03 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents pnl04 As System.Windows.Forms.Panel
    Friend WithEvents ctxMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents lblTipo02 As System.Windows.Forms.Label
    Friend WithEvents lblTipo03 As System.Windows.Forms.Label
    Friend WithEvents lblTipo05 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtETIQ_FORN As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents btnAtual As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnFoto As System.Windows.Forms.Button
    Friend WithEvents btnKey As System.Windows.Forms.Button
    Friend WithEvents Barc As Barcode.Barcode
    Friend WithEvents txtPESO_TEORICO As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtARMAZEM_NUM As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtETIQ_STATUS_COD As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents btnBusca As System.Windows.Forms.Button
    Friend WithEvents lblLeitura As System.Windows.Forms.Label
    Friend WithEvents txtAPRES_PESO_TIPO As System.Windows.Forms.TextBox
    Friend WithEvents pnl05 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblTipo06 As System.Windows.Forms.Label
    Friend WithEvents txtOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNR_CORRIDA As System.Windows.Forms.TextBox
    Friend WithEvents txtPED_ITEM As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents btnSalvaPeso As System.Windows.Forms.Button
    Friend WithEvents btnTroca As System.Windows.Forms.Button
    Friend WithEvents btnArmaz As System.Windows.Forms.Button
    Friend WithEvents btnObsSalva As System.Windows.Forms.Button
    Friend WithEvents txtAVARIA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAvariaSalva As System.Windows.Forms.Button
    Friend WithEvents txtARMAZEM_CIA_COD As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVOLUME_PECAS_QTD As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRecalc As System.Windows.Forms.Button
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRepete As System.Windows.Forms.Button
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem

End Class
