Imports Microsoft.VisualBasic


Public Class DefStatus
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub DefStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Local.carregacombo(txtETIQ_STATUS_COD, Princ.CombosUsu.Tables("STATUS_ESTOQUE"), "COD")
    End Sub
End Class