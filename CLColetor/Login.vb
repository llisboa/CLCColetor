Public Class Login

    Public Cfg As Local.GConfig

    Public Sub Salva()
        Cfg.Conteudo("ULTIMO_USUARIO") = txtUsuario.Text
        Cfg.Conteudo("SERVIDOR_WEBSERVICE") = txtSERVIDOR.Text
        Cfg.Conteudo("USUARIOS") = Master.txtUSUARIOS.Text
        Cfg.Conteudo("ID_COLETOR") = Master.txtID_COLETOR.Text
        Cfg.Salva()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim ok As Boolean = False
        txtUsuario.Text = UCase(txtUsuario.Text)
        txtSENHA.Text = UCase(txtSENHA.Text)
        If txtUsuario.Text = "MASTER" And txtSENHA.Text = "CADRIX" Then
            ok = True
        Else
            Dim Itens() As String = Split(Master.txtUSUARIOS.Text, ";")
            For z As Integer = 0 To Itens.Length - 1 Step 2
                If txtUsuario.Text = Itens(z) And txtSENHA.Text = Itens(z + 1) Then
                    ok = True
                End If
            Next
        End If

        If ok Then

            If txtUsuario.Text = "MASTER" Then
                Master.Show()
            Else
                Salva()
                Opcoes.CarregaConfig()


                Princ.btnMenu.Text = txtUsuario.Text
                Princ.Show()
            End If
        Else
            MsgBox("Informe usuário válido e senha correta.")
        End If


    End Sub

    Function BaseDir() As String
        Return Princ.BASEDIR
    End Function

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.Path.GetFileName(Local.NomeExec) = "Atualiza.exe" Then
            Dim Tentar As Boolean = True
            MsgBox("CLC - Certifique-se de que o programa CLC tenha fechado corretamente antes de continuar.", MsgBoxStyle.OkOnly, "Atualização automática")
            Local.Copia(BaseDir() & "\CLColetor.exe", BaseDir() & "\CLColetor.bkp")

Novamente:
            Try
                Alert.Mostra("CLC - Aguarde. Programa sendo atualizado.")
                Local.Copia(BaseDir() & "\Atualiza.exe", BaseDir() & "\CLColetor.exe")
                Local.Espera(1)
                Local.ExecShell(BaseDir() & "\CLColetor.exe")
                Alert.Esconde()
            Catch ex As Exception
                If MsgBox("Falha na atualização. Deseja tentar novamente? (" & ex.Message & ")") = MsgBoxResult.Yes Then
                    GoTo novamente
                End If
            End Try

            Application.Exit()
            Exit Sub
        End If

        Me.Text = Local.AplDescr
        Cfg = New Local.GConfig(BaseDir() & "\CLColetor.CFG")

        Master.txtUSUARIOS.Text = Local.NZ(Cfg.Conteudo("USUARIOS"), "")
        Master.txtID_COLETOR.Text = Local.NZ(Cfg.Conteudo("ID_COLETOR"), "")
        txtUsuario.Items.Clear()
        Dim Itens() As String = Split(Master.txtUSUARIOS.Text, ";")
        For z As Integer = 0 To Itens.Length - 1 Step 2
            txtUsuario.Items.Add(Itens(z))
        Next

        txtUsuario.Text = Local.NZ(Cfg.Conteudo("ULTIMO_USUARIO"), "")
        txtSERVIDOR.Text = Local.NZ(Cfg.Conteudo("SERVIDOR_WEBSERVICE"), "")

        If txtUsuario.Text <> "" Then
            txtSENHA.Focus()
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub
End Class