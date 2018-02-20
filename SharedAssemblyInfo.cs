using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("WPFAppCICD")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2018")]
[assembly: AssemblyTrademark("")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]

[assembly: AssemblyDescription("Flavor=Debug")] // a.k.a. "Comments"

#else

[assembly: AssemblyConfiguration("Retail")]

[assembly: AssemblyDescription("Flavor=Retail")] // a.k.a. "Comments"

#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.1.0")]
[assembly: AssemblyFileVersion("1.0.1.0")]