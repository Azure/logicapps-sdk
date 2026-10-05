//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rencore
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RencoreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rencore")]
        [WorkflowExpressionFactory(nameof(__BuildApiAnalyze))]
        public IWorkflowAction ApiAnalyze([WorkflowExpression] Func<string> analysisRequestfile, [WorkflowExpression] Func<string> analysisRequestfileName, [WorkflowExpression] Func<string> analysisRequestlicense = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApiAnalyze(WorkflowValue<string> analysisRequestfile, WorkflowValue<string> analysisRequestfileName, WorkflowValue<string> analysisRequestlicense = null)
        {
            WorkflowValue.Validate(analysisRequestfile, nameof(analysisRequestfile), required: true);
            WorkflowValue.Validate(analysisRequestfileName, nameof(analysisRequestfileName), required: true);
            WorkflowValue.Validate(analysisRequestlicense, nameof(analysisRequestlicense), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var analysisRequest = new JObject();
                var analysisRequestpropCount = 0;
                analysisRequestpropCount++;
                analysisRequest["file"] = ExpressionConverter.ConvertO(analysisRequestfile);
                analysisRequestpropCount++;
                analysisRequest["fileName"] = ExpressionConverter.ConvertO(analysisRequestfileName);
                if (analysisRequestlicense != null)
                {
                    analysisRequest["license"] = ExpressionConverter.ConvertO(analysisRequestlicense);
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
