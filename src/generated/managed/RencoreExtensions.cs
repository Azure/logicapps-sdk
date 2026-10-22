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
        public IWorkflowAction<ApiConnectionActionConfiguration> ApiAnalyze(Expression<Func<string>> analysisRequestfile, Expression<Func<string>> analysisRequestfileName, Expression<Func<string>> analysisRequestlicense = null)
        {
            var __workflow_analysisRequestfile = WorkflowExpression.Compile(analysisRequestfile, nameof(analysisRequestfile), required: true);
            var __workflow_analysisRequestfileName = WorkflowExpression.Compile(analysisRequestfileName, nameof(analysisRequestfileName), required: true);
            var __workflow_analysisRequestlicense = WorkflowExpression.Compile(analysisRequestlicense, nameof(analysisRequestlicense), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var analysisRequest = new JObject();
                var analysisRequestpropCount = 0;
                analysisRequestpropCount++;
                analysisRequest["file"] = ExpressionConverter.ConvertO(__workflow_analysisRequestfile);
                analysisRequestpropCount++;
                analysisRequest["fileName"] = ExpressionConverter.ConvertO(__workflow_analysisRequestfileName);
                if (__workflow_analysisRequestlicense != null)
                {
                    analysisRequest["license"] = ExpressionConverter.ConvertO(__workflow_analysisRequestlicense);
                    analysisRequestpropCount++;
                }

                if (analysisRequestpropCount > 0)
                {
                    callPayload.Body = analysisRequest;
                }

                return new ApiConnectionAction(callPayload);
            });
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
