// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.deviceComplianceSettingState&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.deviceComplianceSettingState&quot; objects in the &quot;deviceComplianceSettingStates&quot; collection.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneDeviceComplianceSettingState", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceTypePropertyName("deviceComplianceSettingStateODataType")]
    [ResourceReference]
    public class Get_IntuneDeviceComplianceSettingState : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String deviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [Sortable]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{deviceComplianceSettingStateId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.deviceComplianceSettingState&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.deviceComplianceSettingState&quot; object to the &quot;deviceComplianceSettingStates&quot; collection.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneDeviceComplianceSettingState", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.deviceComplianceSettingState")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceTypePropertyName("deviceComplianceSettingStateODataType")]
    [ResourceReference]
    public class New_IntuneDeviceComplianceSettingState : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String deviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{deviceComplianceSettingStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.deviceComplianceSettingState&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneDeviceComplianceSettingState", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.deviceComplianceSettingState")]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceTypePropertyName("deviceComplianceSettingStateODataType")]
    public class Update_IntuneDeviceComplianceSettingState : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String deviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;setting&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The setting class name and property name.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;setting&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String setting { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Setting Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;settingName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String settingName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The Device Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The user Id that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User email address that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userEmail&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userEmail { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User Name that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The User PrincipalName that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;userPrincipalName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userPrincipalName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The device model that is being reported</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceModel&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String deviceModel { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The compliance state of the setting</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;notApplicable&apos;, &apos;compliant&apos;, &apos;remediated&apos;, &apos;nonCompliant&apos;, &apos;error&apos;, &apos;conflict&apos;, &apos;notAssigned&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.complianceStatus")]
        [Selectable]
        [ValidateSet(@"unknown", @"notApplicable", @"compliant", @"remediated", @"nonCompliant", @"error", @"conflict", @"notAssigned")]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.complianceStatus&quot;.")]
        public System.String state { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.deviceComplianceSettingState&quot; type.</para>
        ///     <para type="description">The DateTime when device compliance grace period expires</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.deviceComplianceSettingState", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;complianceGracePeriodExpirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset complianceGracePeriodExpirationDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{deviceComplianceSettingStateId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.deviceComplianceSettingState&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.deviceComplianceSettingState&quot; object from the &quot;deviceComplianceSettingStates&quot; collection.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/deviceComplianceSettingStateId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneDeviceComplianceSettingState", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.deviceComplianceSettingState")]
    [ResourceTypePropertyName("deviceComplianceSettingStateODataType")]
    public class Remove_IntuneDeviceComplianceSettingState : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.deviceComplianceSettingState&quot; object in the &quot;deviceComplianceSettingStates&quot; collection.")]
        public System.String deviceComplianceSettingStateId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.deviceCompliancePolicySettingStateSummary&quot; object in the &quot;deviceCompliancePolicySettingStateSummaries&quot; collection.")]
        public System.String deviceCompliancePolicySettingStateSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummaryId}/deviceComplianceSettingStates/{deviceComplianceSettingStateId}";
        }
    }
}