//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordcloudbytextvisip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordcloudbytextvisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordcloudbytextvisip")]
        public IBodyWorkflowAction<CloudCreateResponse, ApiConnectionActionConfiguration> CloudCreate(Expression<Func<string>> bodytext, Expression<Func<double>> bodyscale, Expression<Func<int>> bodywidth, Expression<Func<int>> bodyheight, Expression<Func<string[]>> bodycolors = null, Expression<Func<string>> bodyfont = null, Expression<Func<bool>> bodyuseStopwords = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyuppercase = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyscale = WorkflowExpression.Compile(bodyscale, nameof(bodyscale), required: true);
            var __workflow_bodywidth = WorkflowExpression.Compile(bodywidth, nameof(bodywidth), required: true);
            var __workflow_bodyheight = WorkflowExpression.Compile(bodyheight, nameof(bodyheight), required: true);
            var __workflow_bodycolors = WorkflowExpression.Compile(bodycolors, nameof(bodycolors), required: false);
            var __workflow_bodyfont = WorkflowExpression.Compile(bodyfont, nameof(bodyfont), required: false);
            var __workflow_bodyuseStopwords = WorkflowExpression.Compile(bodyuseStopwords, nameof(bodyuseStopwords), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyuppercase = WorkflowExpression.Compile(bodyuppercase, nameof(bodyuppercase), required: false);
            return new DeferredBodyAction<CloudCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["scale"] = ExpressionConverter.ConvertO(__workflow_bodyscale);
                bodypropCount++;
                body["width"] = ExpressionConverter.ConvertO(__workflow_bodywidth);
                bodypropCount++;
                body["height"] = ExpressionConverter.ConvertO(__workflow_bodyheight);
                if (__workflow_bodycolors != null)
                {
                    body["colors"] = ExpressionConverter.ConvertO(__workflow_bodycolors);
                    bodypropCount++;
                }

                if (__workflow_bodyfont != null)
                {
                    body["font"] = ExpressionConverter.ConvertO(__workflow_bodyfont);
                    bodypropCount++;
                }

                if (__workflow_bodyuseStopwords != null)
                {
                    body["use_stopwords"] = ExpressionConverter.ConvertO(__workflow_bodyuseStopwords);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyuppercase != null)
                {
                    body["uppercase"] = ExpressionConverter.ConvertO(__workflow_bodyuppercase);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CloudCreateResponse>(callPayload);
            });
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
