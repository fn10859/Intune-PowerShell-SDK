// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; objects in the &quot;mobileAppConfigurations&quot; collection.</para>
    ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
    ///     <para type="description">Graph call: GET ~/deviceAppManagement/mobileAppConfigurations</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneMobileAppConfigurationPolicy", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration", "microsoft.graph.iosMobileAppConfiguration")]
    [ResourceTypePropertyName("mobileAppConfigurationODataType")]
    [ResourceReference]
    public class Get_IntuneMobileAppConfigurationPolicy : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">the associated app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        public System.String[] targetedMobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignemenets for app configration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
        [Selectable]
        [Expandable]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
        [Selectable]
        [Expandable]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration device status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object deviceStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration user status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserSummary")]
        [Selectable]
        [Expandable]
        [Sortable]
        public System.Object userStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">mdm app configuration Base64 binary.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.iosMobileAppConfiguration")]
        public System.Byte[] encodedSettingXml { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">app configuration setting items.</para>
        /// </summary>
        [ODataType("microsoft.graph.appConfigurationSettingItem")]
        [Selectable]
        [DerivedType("microsoft.graph.iosMobileAppConfiguration")]
        public System.Object[] settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object to the &quot;mobileAppConfigurations&quot; collection.</para>
    ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
    ///     <para type="description">Graph call: POST ~/deviceAppManagement/mobileAppConfigurations</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneMobileAppConfigurationPolicy", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration", "microsoft.graph.iosMobileAppConfiguration")]
    [ResourceTypePropertyName("mobileAppConfigurationODataType")]
    [ResourceReference]
    public class New_IntuneMobileAppConfigurationPolicy : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">the associated app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] targetedMobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignemenets for app configration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration device status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        public System.Object deviceStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration user status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        public System.Object userStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.iosMobileAppConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter iosMobileAppConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">mdm app configuration Base64 binary.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] encodedSettingXml { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">app configuration setting items.</para>
        /// </summary>
        [ODataType("microsoft.graph.appConfigurationSettingItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.")]
        public System.Object[] settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
    ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceAppManagement/mobileAppConfigurations</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneMobileAppConfigurationPolicy", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration", "microsoft.graph.iosMobileAppConfiguration")]
    [ResourceTypePropertyName("mobileAppConfigurationODataType")]
    public class Update_IntuneMobileAppConfigurationPolicy : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">the associated app.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;targetedMobileApps&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] targetedMobileApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided description of the Device Configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Admin provided name of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">Version of the device configuration.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">The list of group assignemenets for app configration.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationAssignment")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationAssignment&quot;.")]
        public System.Object[] assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationDeviceStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus&quot;.")]
        public System.Object[] deviceStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">List of ManagedDeviceMobileAppConfigurationUserStatus.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserStatus")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatuses&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserStatus&quot;.")]
        public System.Object[] userStatuses { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration device status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationDeviceSummary&quot;.")]
        public System.Object deviceStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">App configuration user status summary.</para>
        /// </summary>
        [ODataType("microsoft.graph.managedDeviceMobileAppConfigurationUserSummary")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.managedDeviceMobileAppConfiguration", HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userStatusSummary&quot; property, of type &quot;microsoft.graph.managedDeviceMobileAppConfigurationUserSummary&quot;.")]
        public System.Object userStatusSummary { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.iosMobileAppConfiguration")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.")]
        public System.Management.Automation.SwitchParameter iosMobileAppConfiguration { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">mdm app configuration Base64 binary.</para>
        /// </summary>
        [ODataType("Edm.Binary")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;encodedSettingXml&quot; property, of type &quot;Edm.Binary&quot;.")]
        public System.Byte[] encodedSettingXml { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppConfiguration&quot; type.</para>
        ///     <para type="description">app configuration setting items.</para>
        /// </summary>
        [ODataType("microsoft.graph.appConfigurationSettingItem")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppConfiguration", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settings&quot; property, of type &quot;microsoft.graph.appConfigurationSettingItem&quot;.")]
        public System.Object[] settings { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object from the &quot;mobileAppConfigurations&quot; collection.</para>
    ///     <para type="description">The Managed Device Mobile Application Configurations.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceAppManagement/mobileAppConfigurations/managedDeviceMobileAppConfigurationId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneMobileAppConfigurationPolicy", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.managedDeviceMobileAppConfiguration", "microsoft.graph.iosMobileAppConfiguration")]
    [ResourceTypePropertyName("mobileAppConfigurationODataType")]
    public class Remove_IntuneMobileAppConfigurationPolicy : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.managedDeviceMobileAppConfiguration&quot; object in the &quot;mobileAppConfigurations&quot; collection.")]
        public System.String managedDeviceMobileAppConfigurationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfigurationId}";
        }
    }
}