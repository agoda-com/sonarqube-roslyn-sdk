﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.Plugins.Roslyn.CommandLine {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CmdLineResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CmdLineResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.Plugins.Roslyn.CommandLine.CmdLineResources", typeof(CmdLineResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /acceptLicenses - indicates that you accept the licenses for any packages that required license acceptance.
        /// </summary>
        internal static string ArgDescription_AcceptLicenses {
            get {
                return ResourceManager.GetString("ArgDescription_AcceptLicenses", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /a:[NuGet package id]  or  /a:[NuGet package id]:[version].
        /// </summary>
        internal static string ArgDescription_AnalzyerRef {
            get {
                return ResourceManager.GetString("ArgDescription_AnalzyerRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /recurse - search for analyzers in target package and any dependencies.
        /// </summary>
        internal static string ArgDescription_RecurseDependencies {
            get {
                return ResourceManager.GetString("ArgDescription_RecurseDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /s:[path to sqale xml file].
        /// </summary>
        internal static string ArgDescription_SqaleXmlFile {
            get {
                return ResourceManager.GetString("ArgDescription_SqaleXmlFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsed NuGet reference. Id: {0}, version: {1}.
        /// </summary>
        internal static string DEBUG_ParsedReference {
            get {
                return ResourceManager.GetString("DEBUG_ParsedReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using SQALE file &apos;{0}&apos;.
        /// </summary>
        internal static string DEBUG_UsingSqaleFile {
            get {
                return ResourceManager.GetString("DEBUG_UsingSqaleFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid NuGet package version: {0}.
        /// </summary>
        internal static string ERROR_InvalidVersion {
            get {
                return ResourceManager.GetString("ERROR_InvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package id must be specified.
        /// </summary>
        internal static string ERROR_MissingPackageId {
            get {
                return ResourceManager.GetString("ERROR_MissingPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified SQALE file could not found: {0}.
        /// </summary>
        internal static string ERROR_SqaleFileNotFound {
            get {
                return ResourceManager.GetString("ERROR_SqaleFileNotFound", resourceCulture);
            }
        }
    }
}
