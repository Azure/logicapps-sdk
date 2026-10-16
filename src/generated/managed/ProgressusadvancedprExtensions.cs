//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Progressusadvancedpr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProgressusadvancedprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "progressusadvancedpr")]
        public IWorkflowAction Get(Expression<Func<string>> aPIVersion, Expression<Func<string>> tenantID, Expression<Func<string>> environmentName, Expression<Func<aPINameInput>> aPIName, Expression<Func<string>> aPIVersion2, Expression<Func<string>> companyID, Expression<Func<pluralAPINameInput>> pluralAPIName, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_aPIVersion = WorkflowExpression.Compile(aPIVersion, nameof(aPIVersion), required: true);
            var __workflow_tenantID = WorkflowExpression.Compile(tenantID, nameof(tenantID), required: true);
            var __workflow_environmentName = WorkflowExpression.Compile(environmentName, nameof(environmentName), required: true);
            var __workflow_aPIName = WorkflowExpression.Compile(aPIName, nameof(aPIName), required: true);
            var __workflow_aPIVersion2 = WorkflowExpression.Compile(aPIVersion2, nameof(aPIVersion2), required: true);
            var __workflow_companyID = WorkflowExpression.Compile(companyID, nameof(companyID), required: true);
            var __workflow_pluralAPIName = WorkflowExpression.Compile(pluralAPIName, nameof(pluralAPIName), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/api/progressus/{3}/{4}/companies({5})/{6}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tenantID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_environmentName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_aPIVersion2, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_pluralAPIName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ProgressusadvancedprTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
