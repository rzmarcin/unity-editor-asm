﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnityEditorAssemblyCreator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UnityEditorAssemblyCreator.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;name&quot;: &quot;%asmname&quot;,
        ///    &quot;references&quot;: [
        ///       %references
        ///    ],
        ///    &quot;optionalUnityReferences&quot;: [],
        ///    &quot;includePlatforms&quot;: [
        ///        &quot;Editor&quot;
        ///    ],
        ///    &quot;excludePlatforms&quot;: [],
        ///    &quot;allowUnsafeCode&quot;: false,
        ///    &quot;overrideReferences&quot;: false,
        ///    &quot;precompiledReferences&quot;: [],
        ///    &quot;autoReferenced&quot;: true,
        ///    &quot;defineConstraints&quot;: []
        ///}.
        /// </summary>
        public static string AssemblyContents {
            get {
                return ResourceManager.GetString("AssemblyContents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} directories found, creating assembly definitions....
        /// </summary>
        public static string DIRECTORIES_FOUND {
            get {
                return ResourceManager.GetString("DIRECTORIES_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done..
        /// </summary>
        public static string DONE {
            get {
                return ResourceManager.GetString("DONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid path.
        /// </summary>
        public static string INVALID_PATH {
            get {
                return ResourceManager.GetString("INVALID_PATH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: uac &lt;assetsDirPath&gt; [references].
        /// </summary>
        public static string USAGE {
            get {
                return ResourceManager.GetString("USAGE", resourceCulture);
            }
        }
    }
}
