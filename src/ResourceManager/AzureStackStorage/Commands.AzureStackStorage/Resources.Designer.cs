﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureStack.AzureConsistentStorage.Commands {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AzureStack.AzureConsistentStorage.Commands.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Performing the operation Add ACS Farm &apos;{0}&apos;..
        /// </summary>
        internal static string AddFarmDescription {
            get {
                return ResourceManager.GetString("AddFarmDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;add ACS Farm &apos;{0}&apos;&quot;?.
        /// </summary>
        internal static string AddFarmWarning {
            get {
                return ResourceManager.GetString("AddFarmWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad parameter set.
        /// </summary>
        internal static string BadParameterSet {
            get {
                return ResourceManager.GetString("BadParameterSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ACS Blob Service.
        /// </summary>
        internal static string BlobService {
            get {
                return ResourceManager.GetString("BlobService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the acquisition &apos;{0}&apos;..
        /// </summary>
        internal static string DeleteAcquisitionVerboseDescription {
            get {
                return ResourceManager.GetString("DeleteAcquisitionVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the acquisition &apos;{0}&apos;?.
        /// </summary>
        internal static string DeleteAcquisitionVerboseWarning {
            get {
                return ResourceManager.GetString("DeleteAcquisitionVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete the ACS quota &apos;{0}&apos;..
        /// </summary>
        internal static string DeleteQuotaDescription {
            get {
                return ResourceManager.GetString("DeleteQuotaDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the ACS quota &apos;{0}&apos;?.
        /// </summary>
        internal static string DeleteQuotaWarning {
            get {
                return ResourceManager.GetString("DeleteQuotaWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling Node &apos;{0}&apos; in Storage cluster &apos;{1}&apos;..
        /// </summary>
        internal static string DisableNodeVerboseDescription {
            get {
                return ResourceManager.GetString("DisableNodeVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to disable Node &apos;{0}&apos; in Storage cluster &apos;{1}&apos;?.
        /// </summary>
        internal static string DisableNodeVerboseWarning {
            get {
                return ResourceManager.GetString("DisableNodeVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling Node &apos;{0}&apos; in Storage cluster &apos;{1}&apos;..
        /// </summary>
        internal static string EnableNodeVerboseDescription {
            get {
                return ResourceManager.GetString("EnableNodeVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to enable Node &apos;{0}&apos; in Storage cluster &apos;{1}&apos;?.
        /// </summary>
        internal static string EnableNodeVerboseWarning {
            get {
                return ResourceManager.GetString("EnableNodeVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get undeleted storage account via Account Id or one of its properties is invalid: Tenant Subscription Id, Tenant View Id, Tenant Resource Group Name, Location..
        /// </summary>
        internal static string FailedToGetAccount {
            get {
                return ResourceManager.GetString("FailedToGetAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to undelete storage account..
        /// </summary>
        internal static string FailedToUndeleteAccount {
            get {
                return ResourceManager.GetString("FailedToUndeleteAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure profile is invalid, Make sure that you are in the Azure context with the Add-AzureEnvironment and Add-AzureAccount cmdlets..
        /// </summary>
        internal static string InvalidProfile {
            get {
                return ResourceManager.GetString("InvalidProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This role type is not supported: &apos;{0}&apos;.
        /// </summary>
        internal static string InvalidRoleTypeErrorMessageFormat {
            get {
                return ResourceManager.GetString("InvalidRoleTypeErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ACS Management Service.
        /// </summary>
        internal static string ManagementService {
            get {
                return ResourceManager.GetString("ManagementService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing the operation clear ACS storage accounts on Farm &apos;{0}&apos;..
        /// </summary>
        internal static string OnDemandGcDescription {
            get {
                return ResourceManager.GetString("OnDemandGcDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;clear ACS storage accounts on Farm &apos;{0}&apos;&quot;?.
        /// </summary>
        internal static string OnDemandGcWarning {
            get {
                return ResourceManager.GetString("OnDemandGcWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation is failed. Error code is: &apos;{0}&apos;.
        /// </summary>
        internal static string OperationFailedErrorMessage {
            get {
                return ResourceManager.GetString("OperationFailedErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If specified VersionedAccountName parameter, PartialAccountName, StorageAccountStatus or TenantSubscriptionId parameters must not be set..
        /// </summary>
        internal static string OtherParameterMustNotSetWithVersionedAccountNameSet {
            get {
                return ResourceManager.GetString("OtherParameterMustNotSetWithVersionedAccountNameSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ACS Queue Service.
        /// </summary>
        internal static string QueueService {
            get {
                return ResourceManager.GetString("QueueService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restarting role instance &apos;{0}&apos; with type &apos;{1}&apos;..
        /// </summary>
        internal static string RestartRoleInstanceVerboseDescription {
            get {
                return ResourceManager.GetString("RestartRoleInstanceVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to restart role instance &apos;{0}&apos; with type &apos;{1}&apos;..
        /// </summary>
        internal static string RestartRoleInstanceVerboseWarning {
            get {
                return ResourceManager.GetString("RestartRoleInstanceVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieve properties of undeleted storage account to prepare for resource sync.
        /// </summary>
        internal static string RetrieveUndeletedStorageAccount {
            get {
                return ResourceManager.GetString("RetrieveUndeletedStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing the operation set ACS Farm &apos;{0}&apos;, {1}..
        /// </summary>
        internal static string SetFarmDescription {
            get {
                return ResourceManager.GetString("SetFarmDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;set ACS Farm &apos;{0}&apos;, {1}&quot;?.
        /// </summary>
        internal static string SetFarmWarning {
            get {
                return ResourceManager.GetString("SetFarmWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing the operation set ACS quota &apos;{0}&apos;..
        /// </summary>
        internal static string SetQuotaDescription {
            get {
                return ResourceManager.GetString("SetQuotaDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;set ACS quota &apos;{0}&apos;&quot;?.
        /// </summary>
        internal static string SetQuotaWarning {
            get {
                return ResourceManager.GetString("SetQuotaWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing the operation set {0} {1}..
        /// </summary>
        internal static string SetServiceDescription {
            get {
                return ResourceManager.GetString("SetServiceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        internal static string SetServiceSettingParameter {
            get {
                return ResourceManager.GetString("SetServiceSettingParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;set {0}{1}&quot;?.
        /// </summary>
        internal static string SetServiceWarning {
            get {
                return ResourceManager.GetString("SetServiceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string ShouldContinueCaption {
            get {
                return ResourceManager.GetString("ShouldContinueCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string ShouldProcessCaption {
            get {
                return ResourceManager.GetString("ShouldProcessCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified SMB share will be removed.
        /// </summary>
        internal static string ShouldProcessRemoveSmbShare {
            get {
                return ResourceManager.GetString("ShouldProcessRemoveSmbShare", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to fault {0}.
        /// </summary>
        internal static string ShouldResolveFaultProcessTargetFormat {
            get {
                return ResourceManager.GetString("ShouldResolveFaultProcessTargetFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue with resolve fault?.
        /// </summary>
        internal static string ShouldResoveFaultContinueQuery {
            get {
                return ResourceManager.GetString("ShouldResoveFaultContinueQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting Blob server instance &apos;{0}&apos;..
        /// </summary>
        internal static string StartBlobServerRoleInstanceVerboseDescription {
            get {
                return ResourceManager.GetString("StartBlobServerRoleInstanceVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to start Blob server role instance ‘{0}’?.
        /// </summary>
        internal static string StartBlobServerRoleInstanceVerboseWarning {
            get {
                return ResourceManager.GetString("StartBlobServerRoleInstanceVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Blob server instance &apos;{0}&apos;..
        /// </summary>
        internal static string StopBlobServerRoleInstanceVerboseDescription {
            get {
                return ResourceManager.GetString("StopBlobServerRoleInstanceVerboseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop Blob server role instance ‘{0}’?.
        /// </summary>
        internal static string StopBlobServerRoleInstanceVerboseWarning {
            get {
                return ResourceManager.GetString("StopBlobServerRoleInstanceVerboseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage Account &apos;{0}&apos;.
        /// </summary>
        internal static string StorageAccount {
            get {
                return ResourceManager.GetString("StorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storage Account With VersionedAccountName &apos;{0}&apos;.
        /// </summary>
        internal static string StorageAccountAdminView {
            get {
                return ResourceManager.GetString("StorageAccountAdminView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource Sync.
        /// </summary>
        internal static string SyncOperation {
            get {
                return ResourceManager.GetString("SyncOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ACS Table Service.
        /// </summary>
        internal static string TableService {
            get {
                return ResourceManager.GetString("TableService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both the parameters Token, AdminUri and SubscriptionId are required..
        /// </summary>
        internal static string TokenAndAdminUriRequired {
            get {
                return ResourceManager.GetString("TokenAndAdminUriRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Triger resource sync now..
        /// </summary>
        internal static string TriggerResourceSync {
            get {
                return ResourceManager.GetString("TriggerResourceSync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undelete.
        /// </summary>
        internal static string UndeleteOperation {
            get {
                return ResourceManager.GetString("UndeleteOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing the operation update the settings on ACS Role Instance &apos;{0}&apos; with type &apos;{1}&apos;..
        /// </summary>
        internal static string UpdateRoleInstanceSettingDescription {
            get {
                return ResourceManager.GetString("UpdateRoleInstanceSettingDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to perform the operation &quot;update the settings on ACS Role Instance &apos;{0}&apos; with type &apos;{1}&apos;&quot;?.
        /// </summary>
        internal static string UpdateRoleInstanceSettingWarning {
            get {
                return ResourceManager.GetString("UpdateRoleInstanceSettingWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument should be an absolute URI..
        /// </summary>
        internal static string ValidateAbsoluteUriNotAbsolute {
            get {
                return ResourceManager.GetString("ValidateAbsoluteUriNotAbsolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Uri type is expected..
        /// </summary>
        internal static string ValidateAbsoluteUriWrongType {
            get {
                return ResourceManager.GetString("ValidateAbsoluteUriWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument should be a valid UNC..
        /// </summary>
        internal static string ValidateUncNotValidUnc {
            get {
                return ResourceManager.GetString("ValidateUncNotValidUnc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Uri type is expected..
        /// </summary>
        internal static string ValidateUncWrongType {
            get {
                return ResourceManager.GetString("ValidateUncWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait a few minutes to let frontdoor finish sync job. After that storage account can be accessed by tenant user..
        /// </summary>
        internal static string WaitAfterArmSync {
            get {
                return ResourceManager.GetString("WaitAfterArmSync", resourceCulture);
            }
        }
    }
}
