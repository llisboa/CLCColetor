<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.txtSERVIDOR = New System.Windows.Forms.ComboBox
        Me.txtSENHA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnEntrar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnFechar = New System.Windows.Forms.Button
        Me.txtUsuario = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'txtSERVIDOR
        '
        Me.txtSERVIDOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtSERVIDOR.Items.Add("www.intermesa")
        Me.txtSERVIDOR.Items.Add("wwwisc.intermesa")
        Me.txtSERVIDOR.Items.Add("wwwisc2.intermesa")
        Me.txtSERVIDOR.Location = New System.Drawing.Point(84, 154)
        Me.txtSERVIDOR.Name = "txtSERVIDOR"
        Me.txtSERVIDOR.Size = New System.Drawing.Size(143, 23)
        Me.txtSERVIDOR.TabIndex = 2
        Me.txtSERVIDOR.Text = "wwwisc.intermesa"
        '
        'txtSENHA
        '
        Me.txtSENHA.Location = New System.Drawing.Point(84, 131)
        Me.txtSENHA.Name = "txtSENHA"
        Me.txtSENHA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSENHA.Size = New System.Drawing.Size(143, 23)
        Me.txtSENHA.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.Text = "Usuário"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.Text = "Senha"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.Text = "Servidor"
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(50, 193)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(68, 23)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(133, 193)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(68, 23)
        Me.btnFechar.TabIndex = 4
        Me.btnFechar.Text = "Fechar"
        '
        'txtUsuario
        '
        Me.txtUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtUsuario.Location = New System.Drawing.Point(84, 109)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(143, 23)
        Me.txtUsuario.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(241, 240)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSERVIDOR)
        Me.Controls.Add(Me.txtSENHA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Menu = Me.mainMenu1
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSERVIDOR As System.Windows.Forms.ComboBox
    Friend WithEvents txtSENHA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.ComboBox
End Class
