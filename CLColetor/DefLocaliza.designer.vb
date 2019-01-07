<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DefLocaliza
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtARMAZEM_CIA_COD = New System.Windows.Forms.ComboBox
        Me.txtARMAZEM_NUM = New System.Windows.Forms.ComboBox
        Me.txtARMAZEM_PRACA = New System.Windows.Forms.ComboBox
        Me.chkAtivo = New System.Windows.Forms.CheckBox
        Me.btnnumme = New System.Windows.Forms.Button
        Me.btnnumma = New System.Windows.Forms.Button
        Me.btnprame = New System.Windows.Forms.Button
        Me.btnprama = New System.Windows.Forms.Button
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(129, 233)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(103, 29)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Salvar e Sair"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 24)
        Me.Label2.Text = "Companhia"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(11, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(220, 20)
        Me.Label22.Text = "Def. Localização em cada Leitura"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.Text = "Armazém"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.Text = "Praça"
        '
        'txtARMAZEM_CIA_COD
        '
        Me.txtARMAZEM_CIA_COD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_CIA_COD.Location = New System.Drawing.Point(88, 68)
        Me.txtARMAZEM_CIA_COD.Name = "txtARMAZEM_CIA_COD"
        Me.txtARMAZEM_CIA_COD.Size = New System.Drawing.Size(134, 23)
        Me.txtARMAZEM_CIA_COD.TabIndex = 27
        '
        'txtARMAZEM_NUM
        '
        Me.txtARMAZEM_NUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_NUM.Location = New System.Drawing.Point(74, 97)
        Me.txtARMAZEM_NUM.Name = "txtARMAZEM_NUM"
        Me.txtARMAZEM_NUM.Size = New System.Drawing.Size(80, 23)
        Me.txtARMAZEM_NUM.TabIndex = 28
        '
        'txtARMAZEM_PRACA
        '
        Me.txtARMAZEM_PRACA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtARMAZEM_PRACA.Location = New System.Drawing.Point(74, 127)
        Me.txtARMAZEM_PRACA.Name = "txtARMAZEM_PRACA"
        Me.txtARMAZEM_PRACA.Size = New System.Drawing.Size(148, 23)
        Me.txtARMAZEM_PRACA.TabIndex = 29
        '
        'chkAtivo
        '
        Me.chkAtivo.Location = New System.Drawing.Point(11, 204)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(208, 20)
        Me.chkAtivo.TabIndex = 36
        Me.chkAtivo.Text = "Preencher em etiquetas lidas"
        '
        'btnnumme
        '
        Me.btnnumme.Location = New System.Drawing.Point(159, 95)
        Me.btnnumme.Name = "btnnumme"
        Me.btnnumme.Size = New System.Drawing.Size(29, 30)
        Me.btnnumme.TabIndex = 42
        Me.btnnumme.Text = "-"
        '
        'btnnumma
        '
        Me.btnnumma.Location = New System.Drawing.Point(193, 95)
        Me.btnnumma.Name = "btnnumma"
        Me.btnnumma.Size = New System.Drawing.Size(29, 30)
        Me.btnnumma.TabIndex = 42
        Me.btnnumma.Text = "+"
        '
        'btnprame
        '
        Me.btnprame.Location = New System.Drawing.Point(133, 156)
        Me.btnprame.Name = "btnprame"
        Me.btnprame.Size = New System.Drawing.Size(41, 35)
        Me.btnprame.TabIndex = 42
        Me.btnprame.Text = "-"
        '
        'btnprama
        '
        Me.btnprama.Location = New System.Drawing.Point(180, 156)
        Me.btnprama.Name = "btnprama"
        Me.btnprama.Size = New System.Drawing.Size(41, 35)
        Me.btnprama.TabIndex = 42
        Me.btnprama.Text = "+"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(155, 39)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(67, 23)
        Me.btnAtualizar.TabIndex = 47
        Me.btnAtualizar.Text = "Atualizar"
        '
        'DefLocaliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnprama)
        Me.Controls.Add(Me.btnprame)
        Me.Controls.Add(Me.btnnumma)
        Me.Controls.Add(Me.btnnumme)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.txtARMAZEM_PRACA)
        Me.Controls.Add(Me.txtARMAZEM_NUM)
        Me.Controls.Add(Me.txtARMAZEM_CIA_COD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "DefLocaliza"
        Me.Text = "Definição de Localização"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtARMAZEM_CIA_COD As System.Windows.Forms.ComboBox
    Friend WithEvents txtARMAZEM_NUM As System.Windows.Forms.ComboBox
    Friend WithEvents txtARMAZEM_PRACA As System.Windows.Forms.ComboBox
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents btnnumme As System.Windows.Forms.Button
    Friend WithEvents btnnumma As System.Windows.Forms.Button
    Friend WithEvents btnprame As System.Windows.Forms.Button
    Friend WithEvents btnprama As System.Windows.Forms.Button
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
End Class
