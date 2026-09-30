//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordcloudbytextvisip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordcloudbytextvisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordcloudbytextvisip")]
        public IBodyWorkflowAction<CloudCreateResponse> CloudCreate([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<double> bodyscale, [WorkflowExpression] Func<int> bodywidth, [WorkflowExpression] Func<int> bodyheight, [WorkflowExpression] Func<string[]> bodycolors = null, [WorkflowExpression] Func<string> bodyfont = null, [WorkflowExpression] Func<bool> bodyuseStopwords = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyuppercase = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            bodypropCount++;
            body["scale"] = ExpressionConverter.ConvertO(bodyscale);
            bodypropCount++;
            body["width"] = ExpressionConverter.ConvertO(bodywidth);
            bodypropCount++;
            body["height"] = ExpressionConverter.ConvertO(bodyheight);
            if (bodycolors != null)
            {
                body["colors"] = ExpressionConverter.ConvertO(bodycolors);
                bodypropCount++;
            }

            if (bodyfont != null)
            {
                body["font"] = ExpressionConverter.ConvertO(bodyfont);
                bodypropCount++;
            }

            if (bodyuseStopwords != null)
            {
                body["use_stopwords"] = ExpressionConverter.ConvertO(bodyuseStopwords);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyuppercase != null)
            {
                body["uppercase"] = ExpressionConverter.ConvertO(bodyuppercase);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CloudCreateResponse>(callPayload);
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