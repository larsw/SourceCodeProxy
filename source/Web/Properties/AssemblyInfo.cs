using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("SourceCodeProxy.Web")]
[assembly: AssemblyDescription("Source Code Proxy Web to use in conjunction with Atlassian Stash and GitLink.")]
#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif
[assembly: AssemblyCompany("Lars Wilhelmsen")]
[assembly: AssemblyProduct("SourceCodeProxy")]
[assembly: AssemblyCopyright("Copyright © 2016 Lars Wilhelmsen, all rights reserved.")]

[assembly: ComVisible(false)]

[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyFileVersion("0.1.0.0")]
