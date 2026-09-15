//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rencore
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RencoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rencore")]
        public IWorkflowAction ApiAnalyze(Expression<Func<string>> analysisRequestfile, Expression<Func<string>> analysisRequestfileName, Expression<Func<string>> analysisRequestlicense = null)
        {
            var apiCallPath = "/api/analyze";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var analysisRequest = new JObject();
            var analysisRequestpropCount = 0;
            analysisRequestpropCount++;
            analysisRequest["file"] = CSharpExpressionConverter.ConvertToken(analysisRequestfile);
            analysisRequestpropCount++;
            analysisRequest["fileName"] = CSharpExpressionConverter.ConvertToken(analysisRequestfileName);
            if (analysisRequestlicense != null)
            {
                analysisRequest["license"] = CSharpExpressionConverter.ConvertToken(analysisRequestlicense);
                analysisRequestpropCount++;
            }

            if (analysisRequestpropCount > 0)
            {
                callPayload.Body = analysisRequest;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class RencoreTriggers([ConnectionName] string connectionId)
    {
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