﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;

namespace ICSharpCode.Build.Tasks
{
	/// <summary>
	/// Contains a list of .NET assemblies.
	/// </summary>
	static class KnownFrameworkAssemblies
	{
		// This table was generated using the code in SharpDevelop\src\Main\Base\Project\Src\Gui\Dialogs\ReferenceDialog\GacReferencePanel.cs
		readonly static Dictionary<string, string> fullAssemblyNameToRequiredFrameworkVersionDictionary = new Dictionary<string, string> {
			{ "PresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "System.Printing, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "Microsoft.Build.Conversion.v3.5, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "Microsoft.Build.Engine, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "Microsoft.Build.Framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "Microsoft.Build.Tasks.v3.5, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "Microsoft.Build.Utilities.v3.5, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "Microsoft.VisualC.STLCLR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "PresentationBuildTasks, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationCFFRasterizer, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationFramework.Aero, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationFramework.Classic, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationFramework.Luna, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationFramework.Royale, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "PresentationUI, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "ReachFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "Sentinel.v3.5Client, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "System.AddIn, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.AddIn.Contract, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.ComponentModel.DataAnnotations, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Data.DataSetExtensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Entity.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Linq, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Services, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Services.Client, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Data.Services.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.DirectoryServices.AccountManagement, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.IdentityModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.0" },
			{ "System.IdentityModel.Selectors, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.0" },
			{ "System.IO.Log, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.0" },
			{ "System.Management.Instrumentation, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Net, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "3.5" },
			{ "System.Runtime.Serialization, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.0" },
			{ "System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.0" },
			{ "System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Speech, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "System.Web.Abstractions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Web.DynamicData, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Web.DynamicData.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Web.Entity.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Web.Extensions.Design, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Web.Routing, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Windows.Presentation, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "System.Workflow.Activities, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "System.Workflow.ComponentModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "System.Workflow.Runtime, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "System.WorkflowServices, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.5" },
			{ "System.Xml.Linq, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "3.5" },
			{ "UIAutomationClient, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "UIAutomationClientsideProviders, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "UIAutomationProvider, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "UIAutomationTypes, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "WindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			{ "WindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "3.0" },
			
			// 4.0 Table. Manually modified to exclude assemblies from previous .NET versions.
			{ "CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "ISymWrapper, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.OracleClient, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Printing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Accessibility, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "IEExecRemote, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "IEHost, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "IIEHost, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.Build.Conversion.v3.5, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.Build.Engine, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.Build.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.Build.Tasks.v3.5, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.Build.Utilities.v3.5, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.JScript, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "Microsoft.VisualC, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "PresentationBuildTasks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "PresentationFramework.Classic, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "PresentationFramework.Luna, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "PresentationFramework.Royale, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "ReachFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.AddIn, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.ComponentModel.Composition, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Entity.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Services, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Services.Client, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.Services.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Data.SqlXml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Deployment, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.DirectoryServices.AccountManagement, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.DirectoryServices.Protocols, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.IdentityModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.IO.Log, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Management.Instrumentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Net, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Runtime.Serialization.Formatters.Soap, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.ServiceModel.Channels, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.ServiceModel.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Web.Abstractions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.DynamicData, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.DynamicData.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.Entity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Web.Entity.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.Mobile, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Web.RegularExpressions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Web.Routing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Web.Services, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "4.0" },
			{ "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Windows.Presentation, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Workflow.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Workflow.ComponentModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Workflow.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.WorkflowServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Xaml.Hosting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "4.0" },
			{ "UIAutomationClient, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "UIAutomationClientsideProviders, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "UIAutomationProvider, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "UIAutomationTypes, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
			{ "WindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", "4.0" },
		};
		
		public static IEnumerable<string> FullAssemblyNames {
			get { return fullAssemblyNameToRequiredFrameworkVersionDictionary.Keys; }
		}
		
		public static bool TryGetRequiredFrameworkVersion(string fullAssemblyName, out string version)
		{
			return fullAssemblyNameToRequiredFrameworkVersionDictionary.TryGetValue(fullAssemblyName, out version);
		}
	}
}
