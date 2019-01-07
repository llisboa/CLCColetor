Imports Microsoft.VisualBasic


Public Class BuscaArq

    Private Sub Sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Sub Atualiza()
        Try
            lstArq.Items.Clear()
            For Each arq As String In Local.ListaDir(Princ.LocalDeDocs, "*.DSN", False)
                lstArq.Items.Add(System.IO.Path.GetFileName(arq))
            Next
        Catch ex As Exception
            MsgBox(ex.Message & " procurando arquivos no disco")
        End Try
    End Sub

    Private Sub btnAtual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtual.Click
        Atualiza()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Sel As String = lstArq.Text
            If Sel = "" Then
                MsgBox("Selecione um arquivo antes.")
            Else
                If MsgBox("Deseja carregar " & Sel & "? Isso apagará qualquer registro que não esteja salvo.", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                    ColetaOff.Carrega(Sel)
                End If
                Me.Hide()
            End If
        Catch EX As Exception
            MsgBox(EX.Message & " ao selecionar arquivo")
        End Try
    End Sub

    Public Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If MsgBox("Deseja atualizar lista de arquivos remotos deste coletor?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Local.UploadDocs()
        End If
    End Sub
End Class