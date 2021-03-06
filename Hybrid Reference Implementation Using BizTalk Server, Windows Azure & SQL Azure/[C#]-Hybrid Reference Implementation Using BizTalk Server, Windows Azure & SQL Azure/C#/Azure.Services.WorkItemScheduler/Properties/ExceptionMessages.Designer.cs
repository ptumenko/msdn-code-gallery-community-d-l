﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso.Cloud.Integration.Azure.Services.WorkItemScheduler.Properties {
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
    internal class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Contoso.Cloud.Integration.Azure.Services.WorkItemScheduler.Properties.ExceptionMe" +
                            "ssages", typeof(ExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to No body segments were defined in the batch metadata for item {0} of type {1}..
        /// </summary>
        internal static string NoBodySegments {
            get {
                return ResourceManager.GetString("NoBodySegments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No footer segments were defined in the batch metadata for item {0} of type {1}..
        /// </summary>
        internal static string NoFooterSegments {
            get {
                return ResourceManager.GetString("NoFooterSegments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No header segments were defined in the batch metadata for item {0} of type {1}..
        /// </summary>
        internal static string NoHeaderSegments {
            get {
                return ResourceManager.GetString("NoHeaderSegments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No batch metadata was resolved for item {0} of type {1}. Please make sure that the above item type is registered in the metadata store..
        /// </summary>
        internal static string UnresolvedBatchMetadata {
            get {
                return ResourceManager.GetString("UnresolvedBatchMetadata", resourceCulture);
            }
        }
    }
}
