<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Conferencia
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnFechar = New System.Windows.Forms.Button
        Me.grdPraca = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.Seq = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Etiq = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Peso = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Corrida = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtdPeças = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Armazem = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ArmNum = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Praça = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Viagem = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Avaria = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Obs = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnEtiq = New System.Windows.Forms.Button
        Me.pnl01 = New System.Windows.Forms.Panel
        Me.txtConfir = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescr = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.txtARMAZEM_PRACA = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtARMAZEM_NUM = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtARMAZEM_CIA_COD = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTipo01 = New System.Windows.Forms.Label
        Me.btnSalva = New System.Windows.Forms.Button
        Me.lblTipo02 = New System.Windows.Forms.Label
        Me.pnl02 = New System.Windows.Forms.Panel
        Me.btnAtualiza = New System.Windows.Forms.Button
        Me.btnDigita = New System.Windows.Forms.Button
        Me.OFP = New System.Windows.Forms.OpenFileDialog
        Me.pnl03 = New System.Windows.Forms.Panel
        Me.lblTots = New System.Windows.Forms.Label
        Me.txtCond = New System.Windows.Forms.ComboBox
        Me.Etiquetas = New System.Windows.Forms.Label
        Me.btnSalvar2 = New System.Windows.Forms.Button
        Me.grdEtiqueta = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnl01.SuspendLayout()
        Me.pnl02.SuspendLayout()
        Me.pnl03.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.btnFechar.Location = New System.Drawing.Point(0, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(72, 31)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Voltar"
        '
        'grdPraca
        '
        Me.grdPraca.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdPraca.Location = New System.Drawing.Point(7, 32)
        Me.grdPraca.Name = "grdPraca"
        Me.grdPraca.Size = New System.Drawing.Size(227, 194)
        Me.grdPraca.TabIndex = 1
        Me.grdPraca.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Seq)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Etiq)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Peso)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Corrida)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.QtdPeças)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Armazem)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.ArmNum)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Praça)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Status)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Viagem)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Avaria)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Obs)
        Me.DataGridTableStyle1.MappingName = "Etiq"
        '
        'Seq
        '
        Me.Seq.Format = ""
        Me.Seq.FormatInfo = Nothing
        Me.Seq.HeaderText = "Seq"
        Me.Seq.MappingName = "Seq"
        Me.Seq.Width = 30
        '
        'Etiq
        '
        Me.Etiq.Format = ""
        Me.Etiq.FormatInfo = Nothing
        Me.Etiq.HeaderText = "Etiq"
        Me.Etiq.MappingName = "Etiq"
        Me.Etiq.Width = 80
        '
        'Peso
        '
        Me.Peso.Format = ""
        Me.Peso.FormatInfo = Nothing
        Me.Peso.HeaderText = "Peso"
        Me.Peso.MappingName = "Peso"
        '
        'Corrida
        '
        Me.Corrida.Format = ""
        Me.Corrida.FormatInfo = Nothing
        Me.Corrida.HeaderText = "Corrida"
        Me.Corrida.MappingName = "Corrida"
        '
        'QtdPeças
        '
        Me.QtdPeças.Format = ""
        Me.QtdPeças.FormatInfo = Nothing
        Me.QtdPeças.HeaderText = "QtdPçs"
        Me.QtdPeças.MappingName = "QtdPeças"
        Me.QtdPeças.Width = 40
        '
        'Armazem
        '
        Me.Armazem.Format = ""
        Me.Armazem.FormatInfo = Nothing
        Me.Armazem.HeaderText = "Armazem"
        Me.Armazem.MappingName = "Armazem"
        Me.Armazem.Width = 60
        '
        'ArmNum
        '
        Me.ArmNum.Format = ""
        Me.ArmNum.FormatInfo = Nothing
        Me.ArmNum.HeaderText = "ArmNum"
        Me.ArmNum.MappingName = "ArmNum"
        '
        'Praça
        '
        Me.Praça.Format = ""
        Me.Praça.FormatInfo = Nothing
        Me.Praça.HeaderText = "Praça"
        Me.Praça.MappingName = "Praça"
        '
        'Status
        '
        Me.Status.Format = ""
        Me.Status.FormatInfo = Nothing
        Me.Status.HeaderText = "Status"
        Me.Status.MappingName = "Status"
        Me.Status.Width = 70
        '
        'Viagem
        '
        Me.Viagem.Format = ""
        Me.Viagem.FormatInfo = Nothing
        Me.Viagem.HeaderText = "Viagem"
        Me.Viagem.MappingName = "Viagem"
        Me.Viagem.Width = 70
        '
        'Avaria
        '
        Me.Avaria.Format = ""
        Me.Avaria.FormatInfo = Nothing
        Me.Avaria.HeaderText = "Avaria"
        Me.Avaria.MappingName = "Avaria"
        '
        'Obs
        '
        Me.Obs.Format = ""
        Me.Obs.FormatInfo = Nothing
        Me.Obs.HeaderText = "Obs"
        Me.Obs.MappingName = "Obs"
        '
        'btnEtiq
        '
        Me.btnEtiq.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnEtiq.Location = New System.Drawing.Point(94, 231)
        Me.btnEtiq.Name = "btnEtiq"
        Me.btnEtiq.Size = New System.Drawing.Size(43, 35)
        Me.btnEtiq.TabIndex = 5
        Me.btnEtiq.Text = "Etiqueta"
        '
        'pnl01
        '
        Me.pnl01.BackColor = System.Drawing.Color.Silver
        Me.pnl01.Controls.Add(Me.txtConfir)
        Me.pnl01.Controls.Add(Me.Label5)
        Me.pnl01.Controls.Add(Me.txtDescr)
        Me.pnl01.Controls.Add(Me.Label4)
        Me.pnl01.Controls.Add(Me.btnAtualizar)
        Me.pnl01.Controls.Add(Me.txtARMAZEM_PRACA)
        Me.pnl01.Controls.Add(Me.Label3)
        Me.pnl01.Controls.Add(Me.txtARMAZEM_NUM)
        Me.pnl01.Controls.Add(Me.Label2)
        Me.pnl01.Controls.Add(Me.txtARMAZEM_CIA_COD)
        Me.pnl01.Controls.Add(Me.Label1)
        Me.pnl01.Controls.Add(Me.lblTipo01)
        Me.pnl01.Controls.Add(Me.btnEtiq)
        Me.pnl01.Controls.Add(Me.btnSalva)
        Me.pnl01.Location = New System.Drawing.Point(12, 33)
        Me.pnl01.Name = "pnl01"
        Me.pnl01.Size = New System.Drawing.Size(240, 272)
        '
        'txtConfir
        '
        Me.txtConfir.Location = New System.Drawing.Point(122, 200)
        Me.txtConfir.Name = "txtConfir"
        Me.txtConfir.Size = New System.Drawing.Size(109, 23)
        Me.txtConfir.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.Text = "Confirm.Visual"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(84, 140)
        Me.txtDescr.Multiline = True
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(148, 58)
        Me.txtDescr.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.Text = "Descrição"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(165, 36)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(67, 23)
        Me.btnAtualizar.TabIndex = 75
        Me.btnAtualizar.Text = "Atualizar"
        '
        'txtARMAZEM_PRACA
        '
        Me.txtARMAZEM_PRACA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_PRACA.Location = New System.Drawing.Point(84, 113)
        Me.txtARMAZEM_PRACA.Name = "txtARMAZEM_PRACA"
        Me.txtARMAZEM_PRACA.Size = New System.Drawing.Size(148, 23)
        Me.txtARMAZEM_PRACA.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.Text = "Praça"
        '
        'txtARMAZEM_NUM
        '
        Me.txtARMAZEM_NUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_NUM.Location = New System.Drawing.Point(84, 89)
        Me.txtARMAZEM_NUM.Name = "txtARMAZEM_NUM"
        Me.txtARMAZEM_NUM.Size = New System.Drawing.Size(80, 23)
        Me.txtARMAZEM_NUM.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.Text = "Arm.Num."
        '
        'txtARMAZEM_CIA_COD
        '
        Me.txtARMAZEM_CIA_COD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_CIA_COD.Location = New System.Drawing.Point(84, 65)
        Me.txtARMAZEM_CIA_COD.Name = "txtARMAZEM_CIA_COD"
        Me.txtARMAZEM_CIA_COD.Size = New System.Drawing.Size(148, 23)
        Me.txtARMAZEM_CIA_COD.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.Text = "Estabelecim."
        '
        'lblTipo01
        '
        Me.lblTipo01.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo01.Name = "lblTipo01"
        Me.lblTipo01.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo01.Text = "Critérios"
        '
        'btnSalva
        '
        Me.btnSalva.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnSalva.Location = New System.Drawing.Point(143, 231)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(43, 35)
        Me.btnSalva.TabIndex = 87
        Me.btnSalva.Text = "Salva"
        '
        'lblTipo02
        '
        Me.lblTipo02.Location = New System.Drawing.Point(78, 2)
        Me.lblTipo02.Name = "lblTipo02"
        Me.lblTipo02.Size = New System.Drawing.Size(123, 19)
        Me.lblTipo02.Text = "Praças"
        '
        'pnl02
        '
        Me.pnl02.BackColor = System.Drawing.Color.Silver
        Me.pnl02.Controls.Add(Me.btnAtualiza)
        Me.pnl02.Controls.Add(Me.lblTipo02)
        Me.pnl02.Controls.Add(Me.btnDigita)
        Me.pnl02.Controls.Add(Me.grdPraca)
        Me.pnl02.Location = New System.Drawing.Point(275, 33)
        Me.pnl02.Name = "pnl02"
        Me.pnl02.Size = New System.Drawing.Size(240, 272)
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnAtualiza.Location = New System.Drawing.Point(94, 231)
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(43, 35)
        Me.btnAtualiza.TabIndex = 7
        Me.btnAtualiza.Text = "Atualiza"
        '
        'btnDigita
        '
        Me.btnDigita.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnDigita.Location = New System.Drawing.Point(143, 231)
        Me.btnDigita.Name = "btnDigita"
        Me.btnDigita.Size = New System.Drawing.Size(43, 35)
        Me.btnDigita.TabIndex = 6
        Me.btnDigita.Text = "Digita"
        '
        'pnl03
        '
        Me.pnl03.BackColor = System.Drawing.Color.Silver
        Me.pnl03.Controls.Add(Me.lblTots)
        Me.pnl03.Controls.Add(Me.txtCond)
        Me.pnl03.Controls.Add(Me.Etiquetas)
        Me.pnl03.Controls.Add(Me.btnSalvar2)
        Me.pnl03.Controls.Add(Me.grdEtiqueta)
        Me.pnl03.Controls.Add(Me.Label6)
        Me.pnl03.Location = New System.Drawing.Point(534, 33)
        Me.pnl03.Name = "pnl03"
        Me.pnl03.Size = New System.Drawing.Size(240, 272)
        '
        'lblTots
        '
        Me.lblTots.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblTots.Location = New System.Drawing.Point(59, 205)
        Me.lblTots.Name = "lblTots"
        Me.lblTots.Size = New System.Drawing.Size(63, 61)
        '
        'txtCond
        '
        Me.txtCond.Items.Add("OK")
        Me.txtCond.Items.Add("DUPL")
        Me.txtCond.Items.Add("NOVA")
        Me.txtCond.Location = New System.Drawing.Point(162, 203)
        Me.txtCond.Name = "txtCond"
        Me.txtCond.Size = New System.Drawing.Size(71, 23)
        Me.txtCond.TabIndex = 7
        '
        'Etiquetas
        '
        Me.Etiquetas.Location = New System.Drawing.Point(78, 2)
        Me.Etiquetas.Name = "Etiquetas"
        Me.Etiquetas.Size = New System.Drawing.Size(123, 19)
        Me.Etiquetas.Text = "Etiquetas"
        '
        'btnSalvar2
        '
        Me.btnSalvar2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.btnSalvar2.Location = New System.Drawing.Point(144, 231)
        Me.btnSalvar2.Name = "btnSalvar2"
        Me.btnSalvar2.Size = New System.Drawing.Size(43, 35)
        Me.btnSalvar2.TabIndex = 6
        Me.btnSalvar2.Text = "Salva"
        '
        'grdEtiqueta
        '
        Me.grdEtiqueta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdEtiqueta.Location = New System.Drawing.Point(7, 32)
        Me.grdEtiqueta.Name = "grdEtiqueta"
        Me.grdEtiqueta.Size = New System.Drawing.Size(227, 169)
        Me.grdEtiqueta.TabIndex = 1
        Me.grdEtiqueta.TableStyles.Add(Me.DataGridTableStyle2)
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Seq)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Etiq)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Peso)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Corrida)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.QtdPeças)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Armazem)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.ArmNum)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Praça)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Status)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Viagem)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Avaria)
        Me.DataGridTableStyle2.GridColumnStyles.Add(Me.Obs)
        Me.DataGridTableStyle2.MappingName = "Etiq"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(125, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.Text = "Cond:"
        '
        'Conferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(824, 637)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.pnl03)
        Me.Controls.Add(Me.pnl01)
        Me.Controls.Add(Me.pnl02)
        Me.Menu = Me.mainMenu1
        Me.Name = "Conferencia"
        Me.Text = "Conferência de Praça"
        Me.pnl01.ResumeLayout(False)
        Me.pnl02.ResumeLayout(False)
        Me.pnl03.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents grdPraca As System.Windows.Forms.DataGrid
    Friend WithEvents btnEtiq As System.Windows.Forms.Button
    Friend WithEvents pnl01 As System.Windows.Forms.Panel
    Friend WithEvents lblTipo01 As System.Windows.Forms.Label
    Friend WithEvents lblTipo02 As System.Windows.Forms.Label
    Friend WithEvents pnl02 As System.Windows.Forms.Panel
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Seq As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Etiq As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Corrida As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtdPeças As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Armazem As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ArmNum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Praça As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Viagem As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Avaria As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Obs As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtARMAZEM_PRACA As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtARMAZEM_NUM As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtARMAZEM_CIA_COD As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OFP As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents pnl03 As System.Windows.Forms.Panel
    Friend WithEvents Etiquetas As System.Windows.Forms.Label
    Friend WithEvents btnSalvar2 As System.Windows.Forms.Button
    Friend WithEvents grdEtiqueta As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents txtConfir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnAtualiza As System.Windows.Forms.Button
    Friend WithEvents btnDigita As System.Windows.Forms.Button
    Friend WithEvents txtCond As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTots As System.Windows.Forms.Label
End Class
