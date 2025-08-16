using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Resources;

#if DEV10
[assembly: AssemblyTitle("Microsoft.VisualStudio.Project.10.0")]
[assembly: AssemblyProduct("Microsoft.VisualStudio.Project.10.0")]
[assembly: Guid("960478ac-46c3-49b9-86aa-470db94a52c6")]
#elif DEV11
[assembly: AssemblyTitle("Microsoft.VisualStudio.Project.11.0")]
[assembly: AssemblyProduct("Microsoft.VisualStudio.Project.11.0")]
[assembly: Guid("21885ca2-3159-4737-b7df-f937704df394")]
#elif DEV12
[assembly: AssemblyTitle("Microsoft.VisualStudio.Project.12.0")]
[assembly: AssemblyProduct("Microsoft.VisualStudio.Project.12.0")]
[assembly: Guid("b746a4b5-43e2-49f8-9a76-828ad3a96142")]
#elif DEV16
[assembly: AssemblyTitle("Microsoft.VisualStudio.Project.16.0")]
[assembly: AssemblyProduct("Microsoft.VisualStudio.Project.16.0")]
[assembly: Guid("a6a9cb31-3c78-45e8-9892-99cf03c62a90")]
#elif DEV17
[assembly: AssemblyTitle("Microsoft.VisualStudio.Project.17.0")]
[assembly: AssemblyProduct("Microsoft.VisualStudio.Project.17.0")]
[assembly: Guid("D3B2E051-37DD-4195-9CC0-22A24A0B040E")]
#else
#error Unknown target.
#endif
[assembly: AssemblyDescription("MPF Implementation of VS Projects")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0-dev")]

[assembly: NeutralResourcesLanguageAttribute("en")]
