//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.M365updatesapp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class M365updatesappActions([ConnectionName] string connectionId)
    {
    }

    public class M365updatesappTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken[]> ListReceivedReportsByReportDefinition([WorkflowExpression] Func<string> reportDefinitionId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(reportDefinitionId, nameof(reportDefinitionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/connector/powerautomate/triggers/{0}/reports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportDefinitionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken[]> ListReceivedReports(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/powerautomate/triggers/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken[]>(BuildSourceInput, triggerName, recurrence);
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