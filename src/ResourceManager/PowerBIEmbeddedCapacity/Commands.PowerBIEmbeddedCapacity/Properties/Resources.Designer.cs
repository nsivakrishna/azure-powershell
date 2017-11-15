﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.PowerBIEmbeddedCapacity.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.PowerBIEmbeddedCapacity.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to PowerBI Embedded Capacity with name &apos;{0}&apos; already exists..
        /// </summary>
        internal static string PowerBIEmbeddedCapacityExists
        {
            get {
                return ResourceManager.GetString("PowerBIEmbeddedCapacityExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Create PowerBI Embedded Capacity.
        /// </summary>
        internal static string CreateNewPowerBIEmbeddedCapacity
        {
            get {
                return ResourceManager.GetString("CreateNewPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;default &quot;.
        /// </summary>
        internal static string DefaultAclWord {
            get {
                return ResourceManager.GetString("DefaultAclWord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find capacity: &apos;{0}&apos; in any resource group in the currently selected subscription: {1}. Please ensure this capacity exists and that the current user has access to it..
        /// </summary>
        internal static string FailedToDiscoverResourceGroup {
            get {
                return ResourceManager.GetString("FailedToDiscoverResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default subscription has been designated. Use Select-AzureSubscription -Default &lt;subscriptionName&gt; to set the default subscription..
        /// </summary>
        internal static string InvalidDefaultSubscription {
            get {
                return ResourceManager.GetString("InvalidDefaultSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Sku: &apos;{0}&apos;. Available Skus are: &apos;{1}&apos;.
        /// </summary>
        internal static string InvalidSku {
            get {
                return ResourceManager.GetString("InvalidSku", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to PowerBIEmbedded capacity operation failed with the following error code: {0} and message: {1}.
        /// </summary>
        internal static string LongRunningOperationFailed {
            get {
                return ResourceManager.GetString("LongRunningOperationFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No subscription found in the context.  Please ensure that the credentials you provided are authorized to access an Azure subscription, then run Login-AzurePowerBIEmbeddedCapacityAccount to login..
        /// </summary>
        internal static string NoSubscriptionInContext {
            get {
                return ResourceManager.GetString("NoSubscriptionInContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove PowerBI Embedded Capacity: &apos;{0}&apos;?.
        /// </summary>
        internal static string RemovePowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("RemovePowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove PowerBI Embedded Capacity.
        /// </summary>
        internal static string RemovingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("RemovingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to resume PowerBI Embedded Capacity: &apos;{0}&apos;?.
        /// </summary>
        internal static string ResumePowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("ResumePowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resume PowerBI Embedded Capacity.
        /// </summary>
        internal static string ResumingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("ResumingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script file at path &apos;{0}&apos; does not exist or the current user does not have permission to it. Please ensure the path exists and is accessible..
        /// </summary>
        internal static string ScriptFilePathDoesNotExist {
            get {
                return ResourceManager.GetString("ScriptFilePathDoesNotExist", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot perform the requested operation because the specified capacity &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string CapacityDoesNotExist
        {
            get {
                return ResourceManager.GetString("CapacityDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to suspend PowerBI Embedded Capacity: &apos;{0}&apos;?.
        /// </summary>
        internal static string SuspendPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("SuspendPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suspend PowerBI Embedded Capacity.
        /// </summary>
        internal static string SuspendingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("SuspendingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation is being cancelled, please wait....
        /// </summary>
        internal static string TaskCancelledMessage {
            get {
                return ResourceManager.GetString("TaskCancelledMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to update PowerBI Embedded Capacity: &apos;{0}&apos;?.
        /// </summary>
        internal static string UpdatePowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("UpdatePowerBIEmbeddedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update PowerBI Embedded Capacity.
        /// </summary>
        internal static string UpdatingPowerBIEmbeddedCapacity {
            get {
                return ResourceManager.GetString("UpdatingPowerBIEmbeddedCapacity", resourceCulture);
            }
        }
    }
}