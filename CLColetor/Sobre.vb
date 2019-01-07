Imports Microsoft.VisualBasic


Public Class Sobre

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub Sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Local.AplDescr

        Dim Exec As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        Dim Titulo As System.Reflection.AssemblyTitleAttribute = System.Reflection.AssemblyDescriptionAttribute.GetCustomAttribute(Exec, GetType(System.Reflection.AssemblyTitleAttribute))
        Dim Produto As System.Reflection.AssemblyProductAttribute = System.Reflection.AssemblyDescriptionAttribute.GetCustomAttribute(Exec, GetType(System.Reflection.AssemblyProductAttribute))
        Dim Copyright As System.Reflection.AssemblyCopyrightAttribute = System.Reflection.AssemblyDescriptionAttribute.GetCustomAttribute(Exec, GetType(System.Reflection.AssemblyCopyrightAttribute))

        lblProd.Text = Titulo.Title & " - " & Produto.Product
        lblProd.Text &= vbCrLf & "Prog: " & Local.AplVer()
        lblProd.Text &= vbCrLf & Copyright.Copyright
        lblProd.Text &= vbCrLf & My.Resources.INFO_LICENCA
        'lblProd.Text &= vbCrLf & "Servidor em " & Icraft.IcftBase.DSValor("UTL_INADDR.GET_HOST_NAME || ' (' || UTL_INADDR.GET_HOST_ADDRESS || ')'", "DUAL", Login.Strconn, "")
        'lblProd.Text &= vbCrLf & "Base " & Icraft.IcftBase.DSValor("NAME || ' DBID ' || DBID || ' com checkpoint ' || CHECKPOINT_CHANGE# || ' em ' || LOG_MODE", "V$DATABASE", Login.Strconn, "")
        'lblProd.Text &= vbCrLf & "Última atualização em " & Icraft.IcftBase.DSValor("TO_CHAR(SCN_TO_TIMESTAMP(CHECKPOINT_CHANGE#),'YYYY-MM-DD HH24:MI:SS')", "V$DATABASE", Login.Strconn, "")
    End Sub
End Class