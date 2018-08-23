// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.workbookChartDataLabelFormat&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.workbookChartDataLabelFormat&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "WorkbookChartDataLabelFormatObject", DefaultParameterSetName = @"microsoft.graph.workbookChartDataLabelFormat")]
    [ODataType("microsoft.graph.workbookChartDataLabelFormat")]
    public class New_WorkbookChartDataLabelFormatObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabelFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFill")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabelFormat", HelpMessage = @"The &quot;fill&quot; property, of type &quot;microsoft.graph.workbookChartFill&quot;.")]
        public System.Object fill { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.workbookChartDataLabelFormat&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.workbookChartFont")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.workbookChartDataLabelFormat", HelpMessage = @"The &quot;font&quot; property, of type &quot;microsoft.graph.workbookChartFont&quot;.")]
        public System.Object font { get; set; }
    }
}