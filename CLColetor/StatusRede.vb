Imports Microsoft.VisualBasic


Public Class StatusRede

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub StatusRede_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Princ.AtualizaNomeRede()
        Princ.AtualizaNivelRede()
    End Sub
End Class