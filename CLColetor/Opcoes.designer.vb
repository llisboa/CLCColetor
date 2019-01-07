<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Opcoes
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
        Me.chkAtivo = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnFechar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTimeOut = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTonMax = New System.Windows.Forms.TextBox
        Me.txtTAMGRIDCOLETAOFF = New System.Windows.Forms.TextBox
        Me.txtTAMGRIDETIQUETAS = New System.Windows.Forms.TextBox
        Me.txtTAMGRIDPRACAS = New System.Windows.Forms.TextBox
        Me.txtTAMGRIDOFFVIAGITENS = New System.Windows.Forms.TextBox
        Me.txtTAMGRIDESTOQ = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'chkAtivo
        '
        Me.chkAtivo.Checked = True
        Me.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAtivo.Location = New System.Drawing.Point(8, 17)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(23, 28)
        Me.chkAtivo.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(7, 1)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(220, 20)
        Me.Label22.Text = "Opções do Aplicativo"
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(125, 239)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(103, 20)
        Me.btnFechar.TabIndex = 38
        Me.btnFechar.Text = "Salvar e Sair"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 31)
        Me.Label1.Text = "Solicitar confirmação para operações " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de alteração na base de dados."
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Location = New System.Drawing.Point(171, 66)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(49, 23)
        Me.txtTimeOut.TabIndex = 41
        Me.txtTimeOut.Text = "5"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(15, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 36)
        Me.Label2.Text = "Tempo de espera para requisições na Internet (segs)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(14, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 39)
        Me.Label3.Text = "Ton máxima na entrada de peso"
        '
        'txtTonMax
        '
        Me.txtTonMax.Location = New System.Drawing.Point(171, 100)
        Me.txtTonMax.Name = "txtTonMax"
        Me.txtTonMax.Size = New System.Drawing.Size(49, 23)
        Me.txtTonMax.TabIndex = 48
        Me.txtTonMax.Text = "100"
        '
        'txtTAMGRIDCOLETAOFF
        '
        Me.txtTAMGRIDCOLETAOFF.Location = New System.Drawing.Point(19, 194)
        Me.txtTAMGRIDCOLETAOFF.Name = "txtTAMGRIDCOLETAOFF"
        Me.txtTAMGRIDCOLETAOFF.Size = New System.Drawing.Size(179, 23)
        Me.txtTAMGRIDCOLETAOFF.TabIndex = 53
        Me.txtTAMGRIDCOLETAOFF.Visible = False
        '
        'txtTAMGRIDETIQUETAS
        '
        Me.txtTAMGRIDETIQUETAS.Location = New System.Drawing.Point(19, 198)
        Me.txtTAMGRIDETIQUETAS.Name = "txtTAMGRIDETIQUETAS"
        Me.txtTAMGRIDETIQUETAS.Size = New System.Drawing.Size(179, 23)
        Me.txtTAMGRIDETIQUETAS.TabIndex = 54
        Me.txtTAMGRIDETIQUETAS.Visible = False
        '
        'txtTAMGRIDPRACAS
        '
        Me.txtTAMGRIDPRACAS.Location = New System.Drawing.Point(19, 202)
        Me.txtTAMGRIDPRACAS.Name = "txtTAMGRIDPRACAS"
        Me.txtTAMGRIDPRACAS.Size = New System.Drawing.Size(179, 23)
        Me.txtTAMGRIDPRACAS.TabIndex = 55
        Me.txtTAMGRIDPRACAS.Visible = False
        '
        'txtTAMGRIDOFFVIAGITENS
        '
        Me.txtTAMGRIDOFFVIAGITENS.Location = New System.Drawing.Point(19, 207)
        Me.txtTAMGRIDOFFVIAGITENS.Name = "txtTAMGRIDOFFVIAGITENS"
        Me.txtTAMGRIDOFFVIAGITENS.Size = New System.Drawing.Size(179, 23)
        Me.txtTAMGRIDOFFVIAGITENS.TabIndex = 60
        Me.txtTAMGRIDOFFVIAGITENS.Visible = False
        '
        'txtTAMGRIDESTOQ
        '
        Me.txtTAMGRIDESTOQ.Location = New System.Drawing.Point(19, 210)
        Me.txtTAMGRIDESTOQ.Name = "txtTAMGRIDESTOQ"
        Me.txtTAMGRIDESTOQ.Size = New System.Drawing.Size(179, 23)
        Me.txtTAMGRIDESTOQ.TabIndex = 65
        Me.txtTAMGRIDESTOQ.Visible = False
        '
        'Opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(234, 267)
        Me.Controls.Add(Me.txtTAMGRIDESTOQ)
        Me.Controls.Add(Me.txtTAMGRIDOFFVIAGITENS)
        Me.Controls.Add(Me.txtTAMGRIDPRACAS)
        Me.Controls.Add(Me.txtTAMGRIDETIQUETAS)
        Me.Controls.Add(Me.txtTAMGRIDCOLETAOFF)
        Me.Controls.Add(Me.txtTonMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTimeOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnFechar)
        Me.Menu = Me.mainMenu1
        Me.Name = "Opcoes"
        Me.Text = "Opções do Aplicativo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTonMax As System.Windows.Forms.TextBox
    Friend WithEvents txtTAMGRIDCOLETAOFF As System.Windows.Forms.TextBox
    Friend WithEvents txtTAMGRIDETIQUETAS As System.Windows.Forms.TextBox
    Friend WithEvents txtTAMGRIDPRACAS As System.Windows.Forms.TextBox
    Friend WithEvents txtTAMGRIDOFFVIAGITENS As System.Windows.Forms.TextBox
    Friend WithEvents txtTAMGRIDESTOQ As System.Windows.Forms.TextBox
End Class
