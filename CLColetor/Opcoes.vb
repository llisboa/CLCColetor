Imports Microsoft.VisualBasic


Public Class Opcoes

    Function UpdateOrInsert(ByVal Tabela As String, ByVal Chave As String, ByVal Pesquisa As String, ByVal Campo As String, ByVal Conteudo As String) As String
        Dim SQL As String = "UPDATE " & Tabela & " SET " & Campo & " = '" & Local.Tratex(Conteudo) & "' WHERE USUARIO = '" & Local.Tratex(Login.txtUsuario.Text) & "' AND " & Chave & " = '" & Local.Tratex(Pesquisa) & "';" & vbCrLf
        SQL &= "IF SQL%NOTFOUND THEN" & vbCrLf
        SQL &= "INSERT INTO " & Tabela & "(USUARIO, " & Chave & ", " & Campo & ") VALUES('" & Local.Tratex(Login.txtUsuario.Text) & "', '" & Local.Tratex(Pesquisa) & "', '" & Local.Tratex(Conteudo) & "');" & vbCrLf
        SQL &= "END IF;" & vbCrLf
        Return SQL
    End Function

    Public Sub SalvaConfig()
        Dim Tentar As Boolean = True
        Do While Tentar
            Try
                Dim TXT As String = "BEGIN" & vbCrLf
                For Each ctl As Control In Local.ProcuraCtl(Me, "txt" & "*", , False)
                    TXT &= UpdateOrInsert("IM.SYS_CONFIG_USUARIO", "PARAM", UCase("COL_" & Mid(ctl.Name, 4)), "CONFIG", ctl.Text)
                Next
                TXT &= "END"
                Princ.DSGravaRem(TXT)
                Tentar = False
            Catch EX As Exception
                If MsgBox("Não gravou suas preferências. Tentar novamente?... (" & EX.Message & ")", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Tentar = False
                End If
            End Try
        Loop
    End Sub

    Public Sub CarregaConfig()
        Dim DS As System.Data.DataSet
        Dim Arquivo As String = Princ.LocalDeDocs & "\CONFIG_" & Login.txtUsuario.Text & ".DSN"
        Try
            DS = Princ.DSCarregaRem("SELECT PARAM,CONFIG FROM IM.SYS_CONFIG_USUARIO WHERE USUARIO='" & Local.Tratex(Login.txtUsuario.Text) & "' AND PARAM LIKE 'COL_%'")
            DS.WriteXml(Arquivo)
        Catch ex As Exception
            DS = New System.Data.DataSet
            DS.ReadXml(Arquivo)
        End Try
        Try
            For Each ctl As Control In Local.ProcuraCtl(Me, "txt" & "*", , False)
                Try
                    Dim RW() As System.Data.DataRow = DS.Tables(0).Select("PARAM = '" & UCase(Local.Tratex("COL_" & Mid(ctl.Name, 4))) & "'")
                    If RW.Length > 0 Then
                        ctl.Text = RW(0)!CONFIG
                    End If
                Catch ex As Exception
                End Try
            Next
        Catch
        End Try
        txtTonMax_TextChanged(Nothing, Nothing)
        txtTimeOut_TextChanged(Nothing, Nothing)
        If txtTAMGRIDCOLETAOFF.Text = "" Then
            txtTAMGRIDCOLETAOFF.Text = "70;150;100;150;150;200;120;120;200;180;300;300"
        End If
        If txtTAMGRIDPRACAS.Text = "" Then
            txtTAMGRIDPRACAS.Text = "120;120;250;120;120;"
        End If
        If txtTAMGRIDETIQUETAS.Text = "" Then
            txtTAMGRIDETIQUETAS.Text = "150;200;100;100"
        End If
    End Sub

    Private Sub btnFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        SalvaConfig()
        Princ.AcertaTimeOut()
        Me.Hide()
    End Sub

    Private Sub txtTonMax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTonMax.TextChanged
        Try
            txtTonMax.Text = Math.Max(Val(txtTonMax.Text), 50)
        Catch
            txtTonMax.Text = 100
        End Try
    End Sub

    Private Sub txtTimeOut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimeOut.TextChanged
        Try
            txtTimeOut.Text = Local.NZV(Val(txtTimeOut.Text), 5)
        Catch
            txtTimeOut.Text = 5
        End Try
    End Sub

End Class