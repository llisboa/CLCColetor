Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes

<Assembly: AssemblyTitle("CLColetor")> 
<Assembly: AssemblyDescription("Controle para logística programa coletor.")> 
<Assembly: AssemblyCompany("Intercraft Solutions")> 
<Assembly: AssemblyProduct("Controle e Logística Comercial para Coletor MC9500 e Compatíveis")> 
<Assembly: AssemblyCopyright("Copyright ©  2011 - Intercraft Solutions")> 
<Assembly: AssemblyTrademark("Controle e Logística Comercial")> 

<Assembly: CLSCompliant(True)>

<Assembly: ComVisible(False)>

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("c3daa15d-63eb-4d25-b3a4-aa453ffff354")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers
' by using the '*' as shown below:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("03.30.00.00")> 

'Below attribute is to suppress FxCop warning "CA2232 : Microsoft.Usage : Add STAThreadAttribute to assembly"
' as Device app does not support STA thread.
<Assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")>
