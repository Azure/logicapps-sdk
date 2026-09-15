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
        public IBodyWorkflowAction<CloudCreateResponse> CloudCreate(Expression<Func<string>> bodytext, Expression<Func<double>> bodyscale, Expression<Func<int>> bodywidth, Expression<Func<int>> bodyheight, Expression<Func<string[]>> bodycolors = null, Expression<Func<string>> bodyfont = null, Expression<Func<bool>> bodyuseStopwords = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyuppercase = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            bodypropCount++;
            body["scale"] = CSharpExpressionConverter.ConvertToken(bodyscale);
            bodypropCount++;
            body["width"] = CSharpExpressionConverter.ConvertToken(bodywidth);
            bodypropCount++;
            body["height"] = CSharpExpressionConverter.ConvertToken(bodyheight);
            if (bodycolors != null)
            {
                body["colors"] = CSharpExpressionConverter.ConvertToken(bodycolors);
                bodypropCount++;
            }

            if (bodyfont != null)
            {
                body["font"] = CSharpExpressionConverter.ConvertToken(bodyfont);
                bodypropCount++;
            }

            if (bodyuseStopwords != null)
            {
                body["use_stopwords"] = CSharpExpressionConverter.ConvertToken(bodyuseStopwords);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = CSharpExpressionConverter.ConvertToken(bodylanguage);
                bodypropCount++;
            }

            if (bodyuppercase != null)
            {
                body["uppercase"] = CSharpExpressionConverter.ConvertToken(bodyuppercase);
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