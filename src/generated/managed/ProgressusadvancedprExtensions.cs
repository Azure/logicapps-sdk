//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Progressusadvancedpr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProgressusadvancedprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "progressusadvancedpr")]
        public IWorkflowAction Get([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> aPIVersion, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tenantID, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> environmentName, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<aPINameInput> aPIName, [WorkflowExpression] Func<string> aPIVersion2, [WorkflowExpression] Func<string> companyID, [WorkflowExpression] Func<pluralAPINameInput> pluralAPIName, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}/api/progressus/{3}/{4}/companies({5})/{6}", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantID, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentName, 1), ExpressionConverter.ConvertWithUrlEncoding(aPIName, 1), ExpressionConverter.ConvertWithUrlEncoding(aPIVersion2, 1), ExpressionConverter.ConvertWithUrlEncoding(companyID, 1), ExpressionConverter.ConvertWithUrlEncoding(pluralAPIName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ProgressusadvancedprTriggers([ConnectionName] string connectionId)
    {
    }

    public enum aPINameInput
    {
        [EnumMember(Value = "resource")]
        Resource,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "externalproject")]
        Externalproject,
        [EnumMember(Value = "integrationproject")]
        Integrationproject,
        [EnumMember(Value = "integrationtask")]
        Integrationtask,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "externaltask")]
        Externaltask,
        [EnumMember(Value = "timecard")]
        Timecard,
        [EnumMember(Value = "timeperiod")]
        Timeperiod,
        [EnumMember(Value = "integrationlog")]
        Integrationlog,
        [EnumMember(Value = "integrationsetup")]
        Integrationsetup
    }

    public enum pluralAPINameInput
    {
        [EnumMember(Value = "resources")]
        Resources,
        [EnumMember(Value = "projects")]
        Projects,
        [EnumMember(Value = "externalprojects")]
        Externalprojects,
        [EnumMember(Value = "integrationprojects")]
        Integrationprojects,
        [EnumMember(Value = "integrationtasks")]
        Integrationtasks,
        [EnumMember(Value = "tasks")]
        Tasks,
        [EnumMember(Value = "externaltasks")]
        Externaltasks,
        [EnumMember(Value = "timecards")]
        Timecards,
        [EnumMember(Value = "timeperiods")]
        Timeperiods,
        [EnumMember(Value = "integrationlogs")]
        Integrationlogs,
        [EnumMember(Value = "integrationsetup")]
        Integrationsetup
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Progressusadvancedpr;

    public partial class WorkflowManagedActions
    {
        public ProgressusadvancedprActions Progressusadvancedpr(string connectionId) => new ProgressusadvancedprActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProgressusadvancedprTriggers Progressusadvancedpr(string connectionId) => new ProgressusadvancedprTriggers(connectionId);
    }
}