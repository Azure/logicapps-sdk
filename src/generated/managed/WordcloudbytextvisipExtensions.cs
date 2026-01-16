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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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