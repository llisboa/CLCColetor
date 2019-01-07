<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DefStatus
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
        Me.txtETIQ_STATUS_COD = New System.Windows.Forms.ComboBox
        Me.chkAtivo = New System.Windows.Forms.CheckBox
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
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.Text = "Status"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(11, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(220, 20)
        Me.Label22.Text = "Def. Status Etiq. em cada Leitura"
        '
        'txtETIQ_STATUS_COD
        '
        Me.txtETIQ_STATUS_COD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.txtETIQ_STATUS_COD.Location = New System.Drawing.Point(80, 36)
        Me.txtETIQ_STATUS_COD.Name = "txtETIQ_STATUS_COD"
        Me.txtETIQ_STATUS_COD.Size = New System.Drawing.Size(143, 23)
        Me.txtETIQ_STATUS_COD.TabIndex = 26
        '
        'chkAtivo
        '
        Me.chkAtivo.Location = New System.Drawing.Point(15, 207)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(208, 20)
        Me.chkAtivo.TabIndex = 37
        Me.chkAtivo.Text = "Preencher em etiquetas lidas"
        '
        'DefStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.txtETIQ_STATUS_COD)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "DefStatus"
        Me.Text = "Definição de Status de Etiqueta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtETIQ_STATUS_COD As System.Windows.Forms.ComboBox
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
End Class
