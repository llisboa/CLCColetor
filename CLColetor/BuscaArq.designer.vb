<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BuscaArq
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.lstArq = New System.Windows.Forms.ListBox
        Me.btnAtual = New System.Windows.Forms.Button
        Me.btnUpload = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(160, 233)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(72, 29)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Selecionar"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(220, 20)
        Me.Label22.Text = "Escolha Arquivo Desejado"
        '
        'lstArq
        '
        Me.lstArq.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lstArq.Location = New System.Drawing.Point(6, 28)
        Me.lstArq.Name = "lstArq"
        Me.lstArq.Size = New System.Drawing.Size(224, 158)
        Me.lstArq.TabIndex = 4
        '
        'btnAtual
        '
        Me.btnAtual.Location = New System.Drawing.Point(5, 233)
        Me.btnAtual.Name = "btnAtual"
        Me.btnAtual.Size = New System.Drawing.Size(72, 29)
        Me.btnAtual.TabIndex = 1
        Me.btnAtual.Text = "Atualizar"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(159, 198)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(72, 29)
        Me.btnUpload.TabIndex = 6
        Me.btnUpload.Text = "Upload"
        '
        'BuscaArq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.lstArq)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnAtual)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "BuscaArq"
        Me.Text = "Escolher Arquivo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lstArq As System.Windows.Forms.ListBox
    Friend WithEvents btnAtual As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
End Class
