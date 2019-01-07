Public Class Local

    Shared Sub ExecShell(ByVal Prog As String)
        Shell("""" & Prog & """", AppWinStyle.MaximizedFocus)
    End Sub

    Public Shared Sub SalvaByteArray(ByVal Ar() As Byte, ByVal ArqCompress As String)
        Dim St As New System.IO.StreamWriter(ArqCompress)
        St.BaseStream.Write(Ar, 0, Ar.Length)
        St.Flush()
        St.Close()
    End Sub


    Shared Sub Copia(ByVal Origem As String, ByVal Destino As String)
        If System.IO.File.Exists(Destino) Then
            System.IO.File.Delete(Destino)
        End If
        System.IO.File.Copy(Origem, Destino)
    End Sub

    Shared Function ArqLog(Optional ByVal Arquivo As String = "", Optional ByVal Linha As String = ".") As Boolean
        If Arquivo = "" Then
            Arquivo = Princ.LocalDeDocs & "\Log.txt"
        End If
        Dim Saida As New System.IO.StreamWriter(Arquivo, True)
        Saida.WriteLine(Linha)
        Saida.Flush()
        Saida.Close()
    End Function

    Shared Function AplVer() As String
        Dim Nomes() As String = Split(System.Reflection.Assembly.GetExecutingAssembly.FullName, ", ")
        Return "V" & Split(Nomes(1), "=")(1)
    End Function

    Shared Function AplDescr() As String
        Dim Nomes() As String = Split(System.Reflection.Assembly.GetExecutingAssembly.FullName, ", ")
        Return Nomes(0) & " - " & AplVer()
    End Function

    Shared Function NomeExec() As String
        Return System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
    End Function

    Shared Function BaseDir() As String
        Return System.IO.Path.GetDirectoryName(NomeExec)
    End Function

    Shared Function ProcuraCtl(ByVal Local As Object, ByVal Nome As String, Optional ByVal Tipo As String = "", Optional ByVal SoPrimeiro As Boolean = True) As Object
        Dim Arr As New List(Of Control)
        Dim BControls As Object = Nothing
        Try
            If TypeOf Local Is Panel Then
                BControls = CType(Local, Panel).Controls
            ElseIf TypeOf Local Is Form Then
                BControls = CType(Local, Form).Controls
            End If
        Catch
        End Try
        If Not IsNothing(BControls) Then
            For Each Ctl As Control In BControls
                If Ctl.Name Like Nome Then
                    If SoPrimeiro Then
                        Return Ctl
                    End If
                    Arr.Add(Ctl)
                Else
                    Dim Ret As Object = ProcuraCtl(Ctl, Nome, Tipo, SoPrimeiro)
                    If SoPrimeiro Then
                        Return Ret
                    Else
                        Arr.AddRange(Ret)
                    End If
                End If
            Next
        End If
        Return Arr
    End Function

    Shared Function NZV(ByVal Valor As Object, Optional ByVal Def As Object = Nothing) As Object
        Dim Result As Object = NZ(Valor, Def)
        If TypeOf Result Is String AndAlso Result = "" Then
            Return Def
        ElseIf TypeOf Result Is Decimal AndAlso Result = 0 Then
            Return Def
        ElseIf TypeOf Result Is Double AndAlso Result = 0 Then
            Return Def
        ElseIf TypeOf Result Is Single AndAlso Result = 0 Then
            Return Def
        ElseIf TypeOf Result Is Int32 AndAlso Result = 0 Then
            Return Def
        ElseIf TypeOf Result Is Byte AndAlso Result = 0 Then
            Return Def
        End If
        Return Result
    End Function


    Shared Function NZ(ByVal Valor As Object, Optional ByVal Def As Object = Nothing) As Object
        Dim tipo As String

        If Not IsNothing(Def) Then
            tipo = Def.GetType.ToString
        ElseIf IsNothing(Valor) Then
            Return Nothing
        Else
            tipo = Valor.GetType.ToString.Trim
        End If

        If IsNothing(Valor) OrElse IsDBNull(Valor) OrElse ((tipo = "System.DateTime" Or Valor.GetType.ToString = "System.DateTime") AndAlso Valor = CDate(Nothing)) Then
            Valor = Def
        End If

        Select Case tipo
            Case "System.Decimal"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, Decimal)
                End If
                Return CType(Valor, Decimal)
            Case "System.String"
                If Valor.GetType.IsEnum Then
                    Return Valor.ToString
                End If
                Return CType(Valor, String)
            Case "System.Double"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, Double)
                End If
                Return CType(Valor, Double)
            Case "System.Boolean"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return False
                End If
                Return CType(Valor, Boolean)
            Case "System.DateTime"
                Return CType(Valor, System.DateTime)
            Case "System.Single"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, Single)
                End If
                Return CType(Valor, System.Single)
            Case "System.Byte"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, Byte)
                End If
                Return CType(Valor, System.Byte)
            Case "System.Char"
                Return CType(Valor, System.Char)
            Case "System.SByte"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, SByte)
                End If
                Return CType(Valor, System.SByte)
            Case "System.Int32"
                If Valor.GetType.ToString = "System.String" AndAlso Valor = "" Then
                    Return CType(0, Int32)
                End If
                Return CType(Valor, Int32)
            Case "System.DBNull"
                Return Valor
            Case "System.Collections.ArrayList"
                Return ParamArrayToArrayList(Valor)
            Case "System.Data.DataSet"
                If IsNothing(Valor) Then
                    Return Def
                End If
                Return Valor
        End Select

        Return CType(Valor, String)
    End Function

    Public Shared Sub SelecionaValor(ByVal Combo As ComboBox, ByVal Valor As Object)
        For Each Item As Object In Combo.Items
            If Item = Valor Then
                Combo.Text = Item
                Exit Sub
            End If
        Next
        Combo.Items.Add(Valor)
        SelecionaValor(Combo, Valor)
    End Sub

    Shared Sub CarregaRowEmTela(ByVal Container As Object, ByVal Prefixo As String, ByVal Linha As System.Data.DataRow)
        For Each ctl As Control In Local.ProcuraCtl(Container, Prefixo & "*", , False)
            If Not IsNothing(Linha) Then
                Try
                    Dim VALOR As Object = Linha(Mid(ctl.Name, Len(Prefixo) + 1))
                    If TypeOf ctl Is TextBox Then
                        If ctl.Tag <> "" Then
                            If TypeOf VALOR Is Date Then
                                ctl.Text = Format(VALOR, ctl.Tag)
                            Else
                                Dim NUM As Double = Val(Replace(NZ(VALOR, ""), ",", "."))
                                If NUM <> 0 Then
                                    ctl.Text = Replace(Format(NUM, ctl.Tag), ",", ".")
                                End If
                            End If
                        Else
                            ctl.Text = NZ(VALOR, "")
                        End If
                    ElseIf TypeOf ctl Is ComboBox Then
                        SelecionaValor(ctl, NZ(VALOR, ""))
                    End If
                Catch ex As Exception
                    ctl.Text = "[erro:" & ex.Message & "]"
                End Try
            Else
                ctl.Text = ""
            End If
        Next
    End Sub


    Class Tela
        Public Altura As Integer
        Public Largura As Integer
        Public FF As Windows.Forms.Form
        Public Paineis As New ArrayList
        Public PrefPaineis As String
        Public Ativo As Integer = 1
        Sub New(ByVal FF As Windows.Forms.Form, ByVal Largura As Integer, ByVal Altura As Integer, ByVal PrefPaineis As String)
            Me.Altura = Altura
            Me.Largura = Largura
            Me.FF = FF
            Me.Paineis = Paineis
            Me.PrefPaineis = PrefPaineis
            Paineis.Clear()
            For Each Ctl As Control In Me.FF.Controls
                If Ctl.Name.StartsWith(PrefPaineis) Then
                    Paineis.Add(Ctl)
                End If

                AddHandler Ctl.MouseDown, AddressOf MouseDown
                AddHandler Ctl.MouseUp, AddressOf MouseMove
            Next
            For z As Integer = 0 To Paineis.Count - 1
                Dim lbl As New Label
                Dim pnl As Panel = Paineis(z)
                Dim Num As Integer = Val(Mid(pnl.Name, Len(PrefPaineis) + 1))
                lbl.Text = Num & "/" & (Paineis.Count)
                lbl.Width = 100
                lbl.Height = 40
                lbl.TextAlign = ContentAlignment.TopRight
                lbl.Left = pnl.Width - lbl.Width - 2
                lbl.Top = 4
                pnl.Controls.Add(lbl)
                Dim btn As Button
                If Num > 1 Then
                    btn = New Button
                    btn.Location = New System.Drawing.Point(3, 462)
                    btn.Size = New System.Drawing.Size(100, 70)
                    btn.Text = "<"
                    pnl.Controls.Add(btn)
                    AddHandler btn.Click, AddressOf MostraAnterior
                End If
                If Num < Paineis.Count Then
                    btn = New Button
                    btn.Location = New System.Drawing.Point(376, 462)
                    btn.Size = New System.Drawing.Size(100, 70)
                    btn.Text = ">"
                    AddHandler btn.Click, AddressOf MostraPosterior
                    pnl.Controls.Add(btn)
                End If
            Next
            FF.FormBorderStyle = FormBorderStyle.None
            FF.Width = Largura
            FF.Height = Altura
            FF.AutoScroll = False
            Ativa()
        End Sub

        Sub Mostra(ByVal Pag As Integer)
            Ativo = Pag
            Ativa()
        End Sub

        Sub MostraAnterior()
            Ativo -= 1
            Ativa()
        End Sub

        Sub MostraPosterior()
            Ativo += 1
            Ativa()
        End Sub

        Private Function PegaPainel(ByVal Num As Integer) As Panel
            For Each Pnl As Panel In Paineis
                Dim Pos As Integer = Val(Mid(Pnl.Name, Len(PrefPaineis) + 1))
                If Num = Pos Then
                    Return Pnl
                End If
            Next
            Return Nothing
        End Function

        Sub EscondePaineis(ByVal Menos As String)
            For Each Pnl As Panel In Paineis
                If Pnl.Name <> Menos Then
                    Pnl.Visible = False
                Else
                    Pnl.Visible = True
                End If
            Next
        End Sub

        Dim Anterior As Panel = Nothing
        Public Desloc As Integer = 150
        Private Deslocando As Boolean = False
        Sub Ativa()
            If Not Deslocando Then
                Deslocando = True
                If Ativo < 1 Then
                    Ativo = 1
                ElseIf Ativo > Paineis.Count Then
                    Ativo = Paineis.Count
                End If

                Dim Esconder As String = ""
                If Not IsNothing(Anterior) Then
                    Esconder = Anterior.Name
                End If
                EscondePaineis(Esconder)

                Dim pnl As Panel = PegaPainel(Ativo)
                If Not IsNothing(Anterior) Then
                    Dim NumAnt As Integer = Val(Mid(Anterior.Name, Len(PrefPaineis) + 1))
                    If NumAnt <> Ativo Then

                        Dim dx As Integer = 0
                        pnl.Top = 0
                        If NumAnt < Ativo Then
                            dx = -Desloc
                            pnl.Left = Largura + 1
                        Else
                            dx = Desloc
                            pnl.Left = -Largura
                        End If
                        pnl.Visible = True
                        For Z As Integer = pnl.Left To 0 Step dx
                            pnl.Left = Z
                            Anterior.Left += dx
                            For zz As Integer = 0 To 4
                                Application.DoEvents()
                            Next
                        Next
                        pnl.Left = 0
                        Anterior.Visible = False
                    End If
                Else
                    pnl.Left = 0
                    pnl.Top = 0
                    pnl.Visible = True
                End If
                Anterior = pnl
                Deslocando = False
            End If
        End Sub
        Dim EXInicio As Integer
        Dim EYInicio As Integer
        Public Sub Reg(ByVal Evento As String, ByVal EX As Integer, ByVal EY As Integer)
            If Evento = "DOWN" Then
                EXInicio = EX
                EYInicio = EY
            ElseIf Evento = "MOVE" Then
                If EX > EXInicio Then
                    Ativo = Math.Max(Ativo - 1, 1)
                ElseIf EX < EXInicio Then
                    Ativo = Math.Min(Ativo + 1, Paineis.Count)
                End If
                Ativa()
            End If
        End Sub

        Private Sub MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Reg("DOWN", e.X, e.Y)
        End Sub

        Private Sub MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Reg("MOVE", e.X, e.Y)
        End Sub

        Event NotificaTxt(ByVal Texto As String)

        Sub Notifica(ByVal Texto As String)
            RaiseEvent NotificaTxt(Texto)
        End Sub
    End Class

    Public Shared Sub CarregaCombo(ByVal Combo As ComboBox, ByVal Lista As String, Optional ByVal Delim As String = ";")
        Dim Ar As New ArrayList
        For Each Item As String In Split(Lista, Delim)
            Ar.Add(Item)
        Next
        CarregaCombo(Combo, Ar)
    End Sub

    Public Shared Sub CarregaCombo(ByVal Combo As ComboBox, ByVal Lista As ArrayList)
        Dim Anterior As String = Combo.Text
        If Not Lista.Contains(Anterior) Then
            Lista.Add(Anterior)
        End If
        Lista.Sort()
        Combo.Items.Clear()
        For Each Item As String In Lista
            Combo.Items.Add(Item)
        Next
        Combo.Text = Anterior
    End Sub

    Public Shared Sub CarregaCombo(ByVal Combo As ComboBox, ByVal Tabela As System.Data.DataTable, ByVal Campo As String)
        Dim AR As New ArrayList
        For Each Linhas As System.Data.DataRow In Tabela.Rows
            AR.Add(Linhas(Campo))
        Next
        CarregaCombo(Combo, AR)
    End Sub

    Public Shared Function EscapSql(ByVal Conteudo As String) As String
        Return Replace(Conteudo, "'", "''")
    End Function

    Class GConfig
        Public Arquivo As String = ""
        Sub New(ByVal Arquivo As String)
            Me.Arquivo = Arquivo
            Carrega()
        End Sub
        Public Property Conteudo(ByVal Param As String) As Object
            Get
                Dim RR() As System.Data.DataRow = DS.Tables("CONFIG").Select("PARAM='" & Local.Tratex(Param) & "'")
                If RR.Length > 0 Then
                    Return RR(0)("CONTEUDO")
                End If
                Return Nothing
            End Get
            Set(ByVal value As Object)
                Dim RR() As System.Data.DataRow = DS.Tables("CONFIG").Select("PARAM='" & Local.Tratex(Param) & "'")
                If RR.Length > 0 Then
                    RR(0)("CONTEUDO") = value
                End If
                DS.Tables("CONFIG").Rows.Add(Param, value)
            End Set
        End Property
        Public DS As System.Data.DataSet
        Public Sub Salva()
            Dim PARAMS As New List(Of String)
            Dim Z As Integer = 0
            Do While Z < DS.Tables(0).Rows.Count
                If Not PARAMS.Contains(DS.Tables(0).Rows(Z)!PARAM) Then
                    PARAMS.Add(DS.Tables(0).Rows(Z)!PARAM)
                    Z += 1
                Else
                    DS.Tables(0).Rows(Z).Delete()
                End If
            Loop
            DS.WriteXml(Arquivo)
        End Sub
        Public Sub Carrega()
            Try
                DS = New System.Data.DataSet
                DS.ReadXml(Arquivo)
                If DS.Tables.Count = 0 Then
                    Novo()
                End If
            Catch EX As Exception
                Novo()
            End Try
        End Sub
        Public Sub Novo()
            DS = New System.Data.DataSet
            Dim TB As New System.Data.DataTable
            TB.TableName = "CONFIG"
            TB.Columns.Add("PARAM", GetType(String))
            TB.Columns.Add("CONTEUDO", GetType(Object))
            DS.Tables.Add(TB)
        End Sub
    End Class

    Shared Sub Espera(ByVal Segundos As Double)
        Dim n As Date = Now
        Do While (Now - n).TotalSeconds < Segundos
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    Shared Function ExprExpr(ByVal Delim As String, ByVal DelimAlternativo As String, ByVal Inicial As String, ByVal ParamArray Segmentos() As String) As String
        Inicial = NZ(Inicial, "")
        Dim Lista As ArrayList = ParamArrayToArrayList(Segmentos)
        For Each item As String In Lista
            If Not IsNothing(item) Then
                If Not IsNothing(DelimAlternativo) AndAlso DelimAlternativo <> "" Then
                    item = item.Replace(DelimAlternativo, Delim)
                End If
                item = NZ(item, "")
                If item <> "" Then
                    If Inicial <> "" Then
                        If Inicial.EndsWith(Delim) AndAlso item.StartsWith(Delim) Then
                            Inicial &= CType(item, String).Substring(Delim.Length)
                        ElseIf Inicial.EndsWith(Delim) OrElse item.StartsWith(Delim) Then
                            Inicial &= item
                        Else
                            Inicial &= Delim & item
                        End If
                    Else
                        Inicial &= item
                    End If
                End If
            End If
        Next
        Return Inicial
    End Function

    Public Shared Function FileExpr(ByVal Arquivo As String) As String
        If Arquivo.StartsWith("~/") Then
            Return Replace(Arquivo, "~/", BaseDir() & "/" & Arquivo)
        End If
        Return Arquivo
    End Function

    Public Shared Function ListaDir(ByVal Diretorio As String, Optional ByVal Criterio As String = "*.*", Optional ByVal SubDir As Boolean = True) As ArrayList
        Dim ret As New ArrayList
        Diretorio = FileExpr(Diretorio)
        If Diretorio <> "" Then
            For Each fl As String In System.IO.Directory.GetFiles(Diretorio, Criterio)
                ret.Add(fl)
            Next
            If SubDir Then
                For Each dr As String In System.IO.Directory.GetDirectories(Diretorio)
                    ret.AddRange(ListaDir(dr, Criterio))
                Next
            End If
        End If
        Return ret
    End Function

    Public Shared Function Tratex(ByVal Texto As String) As String
        Return Replace(Texto, "'", "''")
    End Function

    Private Shared _DSArmazens As System.Data.DataSet
    Public Shared Property DSArmazens(Optional ByVal TxtCiaCod As String = Nothing) As System.Data.DataSet
        Get
            If IsNothing(_DSArmazens) Then
                _DSArmazens = Princ.ObtemOpcArmazem(TxtCiaCod)
            End If
            Return _DSArmazens
        End Get
        Set(ByVal value As System.Data.DataSet)
            _DSArmazens = value
        End Set
    End Property


    Public Shared Function ParamArrayToArrayList(ByVal ParamArray Params() As Object) As Object
        ' caso não existam parâmetros
        If IsNothing(Params) OrElse Params.Length = 0 Then
            Return New ArrayList
        End If

        ' caso já seja um arraylist
        If Params.Length = 1 And TypeOf (Params(0)) Is ArrayList Then
            Return Params(0)
        End If

        ' caso tenha que juntar
        Dim ListaParametros As ArrayList = New ArrayList
        For Each Item As Object In Params
            If Not IsNothing(Item) Then

                ' >> TIPOS PREVISTOS EM ARRAYLIST...
                ' array
                ' arraylist
                ' string
                ' dataset
                ' datarowcollection

                If TypeOf Item Is Array Then
                    For Each SubItem As Object In Item
                        ListaParametros.AddRange(ParamArrayToArrayList(SubItem))
                    Next
                ElseIf TypeOf Item Is ArrayList OrElse Item.GetType.ToString.StartsWith("System.Collections.Generic.List") Then
                    ListaParametros.AddRange(Item)
                ElseIf TypeOf Item Is String Then
                    ListaParametros.Add(Item)
                Else
                    ListaParametros.Add(Item)
                End If
            End If
        Next
        Return ListaParametros
    End Function

    Public Shared Function ObtemTamCols(ByVal dgg As DataGrid, ByVal NomeTab As String) As String
        Dim Tams As String = ""
        For Each Estilo As DataGridTableStyle In dgg.TableStyles
            If Estilo.MappingName = NomeTab Then
                For Each Col As DataGridColumnStyle In Estilo.GridColumnStyles
                    Tams &= IIf(Tams <> "", ";", "") & Col.Width
                Next
            End If
        Next
        Return Tams
    End Function

    Public Shared Sub DefineTamCols(ByVal dgg As DataGrid, ByVal NomeTab As String, ByVal TamCols As String)
        Dim tb As System.Data.DataTable = dgg.DataSource
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle
        tableStyle.MappingName = NomeTab
        Dim TAM() As String = Split(TamCols, ";")
        For Z As Integer = 0 To tb.Columns.Count - 1
            Dim c As System.Data.DataColumn = tb.Columns(Z)
            Dim dtgColumn As New DataGridTextBoxColumn
            dtgColumn.MappingName = c.ColumnName
            dtgColumn.HeaderText = c.ColumnName
            If Z < TAM.Length Then
                dtgColumn.Width = Val(TAM(Z))
            Else
                dtgColumn.Width = 120
            End If
            tableStyle.GridColumnStyles.Add(dtgColumn)
        Next
        dgg.TableStyles.Clear()
        dgg.TableStyles.Add(tableStyle)
        dgg.Refresh()
        dgg.ResumeLayout()
    End Sub

    Public Shared Function IPLocal(Optional ByVal MascPrior As String = "*.*") As List(Of String)
        Dim Ret As New List(Of String)
        Try
            Dim Nome As String = System.Net.Dns.GetHostName()
            Dim IPH As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(Nome)

            For Each IP As System.Net.IPAddress In IPH.AddressList
                If IP.ToString <> "0.0.0.0" Then
                    Ret.Add(IP.ToString)
                End If
            Next

            Dim RetTem As New List(Of String)
            Dim RetNaoTem As New List(Of String)
            For Each Item As String In Ret
                If Item Like MascPrior Then
                    RetTem.Add(Item)
                Else
                    RetNaoTem.Add(Item)
                End If
            Next
            Ret.Clear()
            RetTem.Sort()
            RetNaoTem.Sort()
            Ret.AddRange(RetTem)
            Ret.AddRange(RetNaoTem)
            Return Ret
        Catch
            Ret.Add("[desconhecido]")
            Return Ret
        End Try
    End Function

    Public Shared Function ArquivoBin(ByVal Arquivo As String) As Byte()
        Dim BR As System.IO.BinaryReader = Nothing
        Dim FS As New System.IO.FileStream(FileExpr(Arquivo), System.IO.FileMode.Open, System.IO.FileAccess.Read)
        BR = New System.IO.BinaryReader(FS)
        Dim B() As Byte = BR.ReadBytes(Convert.ToInt32(BR.BaseStream.Length))
        FS.Close()
        BR.Close()
        Return B
    End Function

    Public Shared Function TextoToDefsData(ByVal Texto As String) As Dictionary(Of String, Date)
        Dim ArqDef As New Dictionary(Of String, Date)
        For Each linha As String In Split(Texto, vbCrLf)
            Dim pos As Integer = InStr(linha, ";")
            If pos <> 0 Then
                Dim data As Date = Nothing
                Try
                    data = CDate(Mid(linha, pos + 1))
                Catch
                End Try
                ArqDef.Add(UCase(Microsoft.VisualBasic.Left(linha, pos - 1)), data)
            End If
        Next
        Return ArqDef
    End Function

    Public Shared Function DefsDataToTexto(ByVal Defs As Dictionary(Of String, Date)) As String
        Dim Texto As String = ""
        For Each Chave As String In Defs.Keys
            Texto &= IIf(Texto <> "", vbCrLf, "") & Chave & ";" & Format(Defs(Chave), "yyyy-MM-dd HH:mm:ss")
        Next
        Return Texto
    End Function

    Shared Function StrToByteArray(ByVal Texto As String) As Byte()
        Try
            Dim Cod As New System.Text.ASCIIEncoding
            Return Cod.GetBytes(Texto)
        Catch
            Return Nothing
        End Try
    End Function

    Shared Function ByteArrayToStr(ByVal Bytes() As Byte) As String
        Try
            Dim Cod As New System.Text.ASCIIEncoding
            Return Cod.GetString(Bytes, 0, Bytes.Length)
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Sub UploadDocs()
        Try
            Dim Lista As ArrayList = Local.ListaDir(Princ.LocalDeDocs, "*.DSN", False)
            Dim PrefArqs As String = "coletor/" & Local.IPLocal("10.*")(0) & "/Docs"
            Dim ArquivoDefs As String = Local.ExprExpr("/", "", PrefArqs, "ListaDir.txt")

            Dim ArqDefs As Dictionary(Of String, Date) = Nothing
            Try
                Dim DefsBin() As Byte = Princ.ArquivoBin(ArquivoDefs)
                Dim TxtArqDefs As String = Local.ByteArrayToStr(DefsBin)
                ArqDefs = Local.TextoToDefsData(TxtArqDefs)
            Catch
                ArqDefs = New Dictionary(Of String, Date)
            End Try


            Dim Tot As Integer = 0
            Dim Ignorar As Boolean = False
            For z As Integer = 0 To Lista.Count - 1
novamente:
                Try
                    Dim ARQ As String = System.IO.Path.GetFileName(Lista.Item(z))
                    Dim ArqUp As String = Local.ExprExpr("/", "", PrefArqs, ARQ)
                    Dim ArqDoc As String = Local.ExprExpr("/", "", Princ.LocalDeDocs, ARQ)


                    Dim Momento As Date = System.IO.File.GetLastWriteTime(ArqDoc)
                    Dim Chave As String = UCase(ArqUp)

                    If Not ArqDefs.ContainsKey(Chave) OrElse ArqDefs(Chave) <> Momento Then
                        Dim B() As Byte = Local.ArquivoBin(ArqDoc)
                        If Not Princ.ArquivoUpload(ArqUp, B) Then
                            Throw New Exception("Arquivo não foi salvo")
                        End If
                        Tot += 1
                        If Not ArqDefs.ContainsKey(Chave) Then
                            ArqDefs.Add(Chave, Momento)
                        Else
                            ArqDefs(Chave) = Momento
                        End If
                    End If

                Catch ex As Exception
                    If Not Ignorar Then
                        Select Case MsgBox(ex.Message & " ao tentar dar upload. Deseja tentar novamente? [sim] para repetir, [não] para ir para próximo ou [cancel] para cancelar upload.", MsgBoxStyle.YesNoCancel)
                            Case MsgBoxResult.Yes
                                GoTo novamente
                            Case MsgBoxResult.Cancel
                                Exit Sub
                        End Select
                        If MsgBox("Deseja ignorar os próximos erros?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Ignorar = True
                        End If
                    End If
                End Try
            Next
            If Tot > 0 Then
                Dim TxtArqDefs = Local.DefsDataToTexto(ArqDefs)
                If Not Princ.ArquivoUpload(ArquivoDefs, Local.StrToByteArray(TxtArqDefs)) Then
                    Throw New Exception("Arquivo não foi salvo")
                End If
            End If
            MsgBox("Término de upload. Total de arquivos carregados: " & Tot)
        Catch ex As Exception
            MsgBox(ex.Message & " fazendo upload de arquivos do dir docs.")
        End Try
    End Sub

End Class
