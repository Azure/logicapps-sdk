//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.M365updatesapp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class M365updatesappActions([ConnectionName] string connectionId)
    {
    }

    public class M365updatesappTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[], ApiConnectionPollingTriggerConfiguration> ListReceivedReportsByReportDefinition(Expression<Func<string>> reportDefinitionId)
        {
            var __workflow_reportDefinitionId = WorkflowExpression.Compile(reportDefinitionId, nameof(reportDefinitionId), required: true);
            return new DeferredBodyTrigger<JToken[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/connector/powerautomate/triggers/{0}/reports", __workflow_reportDefinitionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<JToken[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<JToken[], ApiConnectionPollingTriggerConfiguration> ListReceivedReports()
        {
            return new DeferredBodyTrigger<JToken[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/connector/powerautomate/triggers/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<JToken[]>(callPayload);
            });
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.M365updatesapp;

    public partial class WorkflowManagedActions
    {
        public M365updatesappActions M365updatesapp(string connectionId) => new M365updatesappActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public M365updatesappTriggers M365updatesapp(string connectionId) => new M365updatesappTriggers(connectionId);
    }
}