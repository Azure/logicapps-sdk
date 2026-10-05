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
        [WorkflowExpressionFactory(nameof(__BuildGet))]
        public IWorkflowAction Get([WorkflowExpression] Func<string> aPIVersion, [WorkflowExpression] Func<string> tenantID, [WorkflowExpression] Func<string> environmentName, [WorkflowExpression] Func<aPINameInput> aPIName, [WorkflowExpression] Func<string> aPIVersion2, [WorkflowExpression] Func<string> companyID, [WorkflowExpression] Func<pluralAPINameInput> pluralAPIName, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGet(WorkflowValue<string> aPIVersion, WorkflowValue<string> tenantID, WorkflowValue<string> environmentName, WorkflowValue<aPINameInput> aPIName, WorkflowValue<string> aPIVersion2, WorkflowValue<string> companyID, WorkflowValue<pluralAPINameInput> pluralAPIName, WorkflowValue<string> filter = null, WorkflowValue<string> select = null, WorkflowValue<string> orderby = null)
        {
            WorkflowValue.Validate(aPIVersion, nameof(aPIVersion), required: true);
            WorkflowValue.Validate(tenantID, nameof(tenantID), required: true);
            WorkflowValue.Validate(environmentName, nameof(environmentName), required: true);
            WorkflowValue.Validate(aPIName, nameof(aPIName), required: true);
            WorkflowValue.Validate(aPIVersion2, nameof(aPIVersion2), required: true);
            WorkflowValue.Validate(companyID, nameof(companyID), required: true);
            WorkflowValue.Validate(pluralAPIName, nameof(pluralAPIName), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/api/progressus/{3}/{4}/companies({5})/{6}", ExpressionConverter.ConvertWithUrlEncoding(aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantID, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentName, 1), ExpressionConverter.ConvertWithUrlEncoding(aPIName, 1), ExpressionConverter.ConvertWithUrlEncoding(aPIVersion2, 1), ExpressionConverter.ConvertWithUrlEncoding(companyID, 1), ExpressionConverter.ConvertWithUrlEncoding(pluralAPIName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                return new ApiConnectionAction(callPayload);
            });
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
