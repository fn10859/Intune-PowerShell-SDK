// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; objects in the &quot;protectedAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input protected apps through xml files</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("protectedAppLockerFileODataType")]
    [ResourceIdPropertyName("protectedAppLockerFileId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.")]
        public System.String protectedAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles/{protectedAppLockerFileId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object to the &quot;protectedAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input protected apps through xml files</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("protectedAppLockerFileODataType")]
    [ResourceIdPropertyName("protectedAppLockerFileId")]
    [ResourceReference]
    public class New_DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String protectedAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles/{protectedAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input protected apps through xml files</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("protectedAppLockerFileODataType")]
    [ResourceIdPropertyName("protectedAppLockerFileId")]
    public class Update_DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.")]
        public System.String protectedAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">The friendly name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">SHA256 hash of the file</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;fileHash&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String fileHash { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">File as a byte array</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;file&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLockerFile", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String version { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles/{protectedAppLockerFileId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles/protectedAppLockerFileId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object from the &quot;protectedAppLockerFiles&quot; collection.</para>
    ///     <para type="description">Another way to input protected apps through xml files</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLockerFile")]
    [ResourceTypePropertyName("protectedAppLockerFileODataType")]
    [ResourceIdPropertyName("protectedAppLockerFileId")]
    public class Remove_DeviceAppManagement_WindowsInformationProtectionPolicies_ProtectedAppLockerFiles : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLockerFile&quot; object in the &quot;protectedAppLockerFiles&quot; collection.")]
        public System.String protectedAppLockerFileId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; object in the &quot;windowsInformationProtectionPolicies&quot; collection.")]
        public System.String windowsInformationProtectionPolicyId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.</para>
        /// </summary>
        [Selectable]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.windowsInformationProtectionPolicy&quot; objects.")]
        public System.String windowsInformationProtectionPolicyODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/windowsInformationProtectionPolicies/{windowsInformationProtectionPolicyId}/{windowsInformationProtectionPolicyODataType}/protectedAppLockerFiles/{protectedAppLockerFileId}";
        }
    }
}