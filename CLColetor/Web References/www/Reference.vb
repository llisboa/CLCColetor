﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4971
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4971.
'
Namespace www
    
    '''<remarks/>
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ConsultaSoap", [Namespace]:="http://www.intermesa.com.br/interface/")>  _
    Partial Public Class Consulta
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://www.intermesa.com.br/interface/consulta_v03.26.asmx"
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/ObtemOpcArmazem", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ObtemOpcArmazem(ByVal Armazem As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("ObtemOpcArmazem", New Object() {Armazem})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginObtemOpcArmazem(ByVal Armazem As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ObtemOpcArmazem", New Object() {Armazem}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndObtemOpcArmazem(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/SalvaObs", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SalvaObs(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Texto As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("SalvaObs", New Object() {Usuario, Senha, Equip, Etiqueta, Texto})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginSalvaObs(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Texto As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SalvaObs", New Object() {Usuario, Senha, Equip, Etiqueta, Texto}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSalvaObs(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/SalvaAvaria", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SalvaAvaria(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Texto As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("SalvaAvaria", New Object() {Usuario, Senha, Equip, Etiqueta, Texto})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginSalvaAvaria(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Texto As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SalvaAvaria", New Object() {Usuario, Senha, Equip, Etiqueta, Texto}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSalvaAvaria(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/TrocaUnidMedida", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function TrocaUnidMedida(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Pedido As String, ByVal Item As Integer, ByVal Unid As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("TrocaUnidMedida", New Object() {Usuario, Senha, Equip, Pedido, Item, Unid})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginTrocaUnidMedida(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Pedido As String, ByVal Item As Integer, ByVal Unid As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TrocaUnidMedida", New Object() {Usuario, Senha, Equip, Pedido, Item, Unid}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndTrocaUnidMedida(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/SalvaPesoBalanca", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SalvaPesoBalanca(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Liquido As Double, ByVal Bruto As Double, ByVal QtdPecas As Integer) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("SalvaPesoBalanca", New Object() {Usuario, Senha, Equip, Etiqueta, Liquido, Bruto, QtdPecas})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginSalvaPesoBalanca(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Liquido As Double, ByVal Bruto As Double, ByVal QtdPecas As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SalvaPesoBalanca", New Object() {Usuario, Senha, Equip, Etiqueta, Liquido, Bruto, QtdPecas}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSalvaPesoBalanca(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/AtualizaStatus", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function AtualizaStatus(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Status As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("AtualizaStatus", New Object() {Usuario, Senha, Equip, Etiqueta, Status})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginAtualizaStatus(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Status As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AtualizaStatus", New Object() {Usuario, Senha, Equip, Etiqueta, Status}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndAtualizaStatus(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/SalvaLocaliza", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function SalvaLocaliza(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Armazem As String, ByVal Num As String, ByVal Praca As String, ByVal Linha As Integer, ByVal Coluna As Integer) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("SalvaLocaliza", New Object() {Usuario, Senha, Equip, Etiqueta, Armazem, Num, Praca, Linha, Coluna})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginSalvaLocaliza(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Etiqueta As String, ByVal Armazem As String, ByVal Num As String, ByVal Praca As String, ByVal Linha As Integer, ByVal Coluna As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SalvaLocaliza", New Object() {Usuario, Senha, Equip, Etiqueta, Armazem, Num, Praca, Linha, Coluna}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSalvaLocaliza(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/CarregaCombosUsu", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CarregaCombosUsu(ByVal Usuario As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("CarregaCombosUsu", New Object() {Usuario})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginCarregaCombosUsu(ByVal Usuario As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("CarregaCombosUsu", New Object() {Usuario}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndCarregaCombosUsu(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/RastrEtiqApres", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RastrEtiqApres(ByVal EtiqApres As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("RastrEtiqApres", New Object() {EtiqApres})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginRastrEtiqApres(ByVal EtiqApres As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("RastrEtiqApres", New Object() {EtiqApres}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndRastrEtiqApres(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/RastrEtiqRefCli", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RastrEtiqRefCli(ByVal RefCli As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("RastrEtiqRefCli", New Object() {RefCli})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginRastrEtiqRefCli(ByVal RefCli As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("RastrEtiqRefCli", New Object() {RefCli}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndRastrEtiqRefCli(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/RastrEtiqCodBarras", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function RastrEtiqCodBarras(ByVal AplRefBarras As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("RastrEtiqCodBarras", New Object() {AplRefBarras})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginRastrEtiqCodBarras(ByVal AplRefBarras As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("RastrEtiqCodBarras", New Object() {AplRefBarras}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndRastrEtiqCodBarras(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/ArquivoBin", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ArquivoBin(ByVal ArquivoEmDown As String) As <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("ArquivoBin", New Object() {ArquivoEmDown})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Function BeginArquivoBin(ByVal ArquivoEmDown As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ArquivoBin", New Object() {ArquivoEmDown}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndArquivoBin(ByVal asyncResult As System.IAsyncResult) As Byte()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/DSCarregaRem", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DSCarregaRem(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Consulta As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("DSCarregaRem", New Object() {Usuario, Senha, Equip, Consulta})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginDSCarregaRem(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Consulta As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DSCarregaRem", New Object() {Usuario, Senha, Equip, Consulta}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndDSCarregaRem(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/DSGravaRem", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function DSGravaRem(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Consulta As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("DSGravaRem", New Object() {Usuario, Senha, Equip, Consulta})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginDSGravaRem(ByVal Usuario As String, ByVal Senha As String, ByVal Equip As String, ByVal Consulta As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("DSGravaRem", New Object() {Usuario, Senha, Equip, Consulta}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndDSGravaRem(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/ArquivoMomentoModif", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ArquivoMomentoModif(ByVal Arquivo As String) As Date
            Dim results() As Object = Me.Invoke("ArquivoMomentoModif", New Object() {Arquivo})
            Return CType(results(0),Date)
        End Function
        
        '''<remarks/>
        Public Function BeginArquivoMomentoModif(ByVal Arquivo As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ArquivoMomentoModif", New Object() {Arquivo}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndArquivoMomentoModif(ByVal asyncResult As System.IAsyncResult) As Date
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Date)
        End Function
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.intermesa.com.br/interface/ArquivoUpload", RequestNamespace:="http://www.intermesa.com.br/interface/", ResponseNamespace:="http://www.intermesa.com.br/interface/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ArquivoUpload(ByVal Arquivo As String, <System.Xml.Serialization.XmlElementAttribute(DataType:="base64Binary")> ByVal Dados() As Byte) As Boolean
            Dim results() As Object = Me.Invoke("ArquivoUpload", New Object() {Arquivo, Dados})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Function BeginArquivoUpload(ByVal Arquivo As String, ByVal Dados() As Byte, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ArquivoUpload", New Object() {Arquivo, Dados}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndArquivoUpload(ByVal asyncResult As System.IAsyncResult) As Boolean
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Boolean)
        End Function
    End Class
End Namespace
