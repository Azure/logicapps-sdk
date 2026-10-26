//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rencore
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RencoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rencore")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApiAnalyze(Expression<Func<ApiAnalyzePostInput>> analysisRequest)
        {
            var __workflow_analysisRequest = WorkflowExpression.Compile(analysisRequest, nameof(analysisRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_analysisRequest);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RencoreTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiAnalyzePostInput
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }

        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rencore;

    public partial class WorkflowManagedActions
    {
        public RencoreActions Rencore(string connectionId) => new RencoreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RencoreTriggers Rencore(string connectionId) => new RencoreTriggers(connectionId);
    }
}