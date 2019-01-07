Imports Microsoft.VisualBasic


Public Class Master
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        txtUSUARIOS.Text = UCase(txtUSUARIOS.Text)
        Login.Salva()
        Princ.Show()
        MsgBox("Dados registrados.")
    End Sub

    Private Sub Master_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Hide()
    End Sub
End Class