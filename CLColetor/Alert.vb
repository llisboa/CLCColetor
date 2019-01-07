Public Class Alert

    Public Sub Mostra(ByVal Texto As String)
        lbl.Text = Texto
        Me.Show()
        Application.DoEvents()
    End Sub
    Public Sub Esconde()
        Me.Visible = False
    End Sub
    Private Sub Alert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class