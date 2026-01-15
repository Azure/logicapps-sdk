//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Alchemy
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlchemyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alchemy")]
        public IBodyWorkflowAction<GetSelfHelpInsightsResponse> GetSelfHelpInsights(Expression<Func<string>> bodyText)
        {
            var apiCallPath = "/api/v1/insights/dcp/esshelp-dcp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodyText);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetSelfHelpInsightsResponse>(callPayload);
        }
    }

    public class AlchemyTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSelfHelpInsightsResponse
    {
        public bool IsAIInsightsVisible { get; set; }
        public bool IsAdapativeCardVisible { get; set; }
        public GetSelfHelpInsightsResponseClientDiagnosticsType ClientDiagnostics { get; set; }
        public string AimId { get; set; }
        public GetSelfHelpInsightsResponseAIInsightsType AIInsights { get; set; }
    }

    public class GetSelfHelpInsightsResponseClientDiagnosticsType
    {
        public bool IsClientDiagVisible { get; set; }
        public int ClientDiagId { get; set; }
        public string ClientDiagTitle { get; set; }
    }

    public class GetSelfHelpInsightsResponseAIInsightsType
    {
        public string GPTInsight { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Alchemy;

    public partial class WorkflowManagedActions
    {
        public AlchemyActions Alchemy(string connectionId) => new AlchemyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlchemyTriggers Alchemy(string connectionId) => new AlchemyTriggers(connectionId);
    }
}