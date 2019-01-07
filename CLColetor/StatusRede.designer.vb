<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StatusRede
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
        Me.Label22 = New System.Windows.Forms.Label
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.lblRede = New System.Windows.Forms.Label
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Percentu = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(129, 233)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(103, 29)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(11, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 20)
        Me.Label22.Text = "Nível da Rede:"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(12, 33)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(213, 12)
        '
        'lblRede
        '
        Me.lblRede.Location = New System.Drawing.Point(110, 14)
        Me.lblRede.Name = "lblRede"
        Me.lblRede.Size = New System.Drawing.Size(93, 18)
        Me.lblRede.Text = "."
        '
        'txtLog
        '
        Me.txtLog.AcceptsReturn = True
        Me.txtLog.Location = New System.Drawing.Point(13, 66)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(211, 156)
        Me.txtLog.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.Text = "Log:"
        '
        'Percentu
        '
        Me.Percentu.Location = New System.Drawing.Point(191, 44)
        Me.Percentu.Name = "Percentu"
        Me.Percentu.Size = New System.Drawing.Size(32, 20)
        Me.Percentu.Text = "0%"
        Me.Percentu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusRede
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Percentu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRede)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "StatusRede"
        Me.Text = "Status da Rede"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblRede As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Progress As System.Windows.Forms.ProgressBar
    Public WithEvents txtLog As System.Windows.Forms.TextBox
    Public WithEvents Percentu As System.Windows.Forms.Label
End Class
