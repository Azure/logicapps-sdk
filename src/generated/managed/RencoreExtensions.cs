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
        public IWorkflowAction ApiAnalyze([WorkflowExpression] Func<string> analysisRequestFile, [WorkflowExpression] Func<string> analysisRequestfileName, [WorkflowExpression] Func<string> analysisRequestlicense = null)
        {
            SourceExpression.Validate(analysisRequestFile, nameof(analysisRequestFile), required: true);
            SourceExpression.Validate(analysisRequestfileName, nameof(analysisRequestfileName), required: true);
            SourceExpression.Validate(analysisRequestlicense, nameof(analysisRequestlicense), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/analyze";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var analysisRequest = new JObject();
                var analysisRequestpropCount = 0;
                analysisRequestpropCount++;
                analysisRequest["file"] = SourceExpressionConverter.ConvertToken(analysisRequestFile);
                analysisRequestpropCount++;
                analysisRequest["fileName"] = SourceExpressionConverter.ConvertToken(analysisRequestfileName);
                if (analysisRequestlicense != null)
                {
                    analysisRequest["license"] = SourceExpressionConverter.ConvertToken(analysisRequestlicense);
                    analysisRequestpropCount++;
                }

                if (analysisRequestpropCount > 0)
                {
                    callPayload.Body = analysisRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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