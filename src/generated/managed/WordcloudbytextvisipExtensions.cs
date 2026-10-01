//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordcloudbytextvisip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordcloudbytextvisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordcloudbytextvisip")]
        public IBodyWorkflowAction<CloudCreateResponse> CloudCreate([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<double> bodyscale, [WorkflowExpression] Func<int> bodywidth, [WorkflowExpression] Func<int> bodyheight, [WorkflowExpression] Func<string[]> bodycolors = null, [WorkflowExpression] Func<string> bodyfont = null, [WorkflowExpression] Func<bool> bodyuseStopwords = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyuppercase = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                bodypropCount++;
                body["scale"] = SourceExpressionConverter.ConvertToken(bodyscale);
                bodypropCount++;
                body["width"] = SourceExpressionConverter.ConvertToken(bodywidth);
                bodypropCount++;
                body["height"] = SourceExpressionConverter.ConvertToken(bodyheight);
                if (bodycolors != null)
                {
                    body["colors"] = SourceExpressionConverter.ConvertToken(bodycolors);
                    bodypropCount++;
                }

                if (bodyfont != null)
                {
                    body["font"] = SourceExpressionConverter.ConvertToken(bodyfont);
                    bodypropCount++;
                }

                if (bodyuseStopwords != null)
                {
                    body["use_stopwords"] = SourceExpressionConverter.ConvertToken(bodyuseStopwords);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodyuppercase != null)
                {
                    body["uppercase"] = SourceExpressionConverter.ConvertToken(bodyuppercase);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloudCreateResponse>(BuildSourceInput);
        }
    }

    public class WordcloudbytextvisipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CloudCreateResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wordcloudbytextvisip;

    public partial class WorkflowManagedActions
    {
        public WordcloudbytextvisipActions Wordcloudbytextvisip(string connectionId) => new WordcloudbytextvisipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WordcloudbytextvisipTriggers Wordcloudbytextvisip(string connectionId) => new WordcloudbytextvisipTriggers(connectionId);
    }
}