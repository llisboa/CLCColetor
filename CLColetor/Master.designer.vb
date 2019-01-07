<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Master
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
        Me.txtUSUARIOS = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID_COLETOR = New System.Windows.Forms.TextBox
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
        'txtUSUARIOS
        '
        Me.txtUSUARIOS.Location = New System.Drawing.Point(11, 68)
        Me.txtUSUARIOS.Multiline = True
        Me.txtUSUARIOS.Name = "txtUSUARIOS"
        Me.txtUSUARIOS.Size = New System.Drawing.Size(209, 99)
        Me.txtUSUARIOS.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 34)
        Me.Label2.Text = "Usuários e respectivas senhas separados por ponto e vírgula:"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(11, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(175, 20)
        Me.Label22.Text = "Configurações"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.Text = "Id Coletor:"
        '
        'txtID_COLETOR
        '
        Me.txtID_COLETOR.Location = New System.Drawing.Point(77, 177)
        Me.txtID_COLETOR.Name = "txtID_COLETOR"
        Me.txtID_COLETOR.Size = New System.Drawing.Size(143, 23)
        Me.txtID_COLETOR.TabIndex = 18
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.txtID_COLETOR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtUSUARIOS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "Master"
        Me.Text = "Master Especificações"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtUSUARIOS As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID_COLETOR As System.Windows.Forms.TextBox
End Class
