//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.M365updatesapp
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class M365updatesappActions([ConnectionName] string connectionId)
    {
    }

    public class M365updatesappTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildListReceivedReportsByReportDefinition))]
        public IBodyWorkflowTrigger<JToken[]> ListReceivedReportsByReportDefinition([WorkflowExpression] Func<string> reportDefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken[]> __BuildListReceivedReportsByReportDefinition(WorkflowValue<string> reportDefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(reportDefinitionId, nameof(reportDefinitionId), required: true);
            return new DeferredBodyTrigger<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/connector/powerautomate/triggers/{0}/reports", ExpressionConverter.ConvertWithUrlEncoding(reportDefinitionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<JToken[]>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<JToken[]> ListReceivedReports(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/connector/powerautomate/triggers/reports";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<JToken[]>(callPayload, triggerName, recurrence);
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
