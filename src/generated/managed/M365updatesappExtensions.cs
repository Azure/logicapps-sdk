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
        public IOutputWorkflowTrigger<JToken[]> ListReceivedReportsByReportDefinition(Expression<Func<string>> reportDefinitionId, string triggerName = null)
        {
            var apiCallPath = String.Format("/connector/powerautomate/triggers/{0}/reports", ExpressionConverter.ConvertWithUrlEncoding(reportDefinitionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<JToken[]>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken[]> ListReceivedReports(string triggerName = null)
        {
            var apiCallPath = "/connector/powerautomate/triggers/reports";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<JToken[]>(callPayload);
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