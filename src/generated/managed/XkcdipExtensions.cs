//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xkcdip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XkcdipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xkcdip")]
        public IBodyWorkflowAction<ComicGetResponse, ApiConnectionActionConfiguration> ComicGet()
        {
            return new DeferredBodyAction<ComicGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/info.0.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComicGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xkcdip")]
        public IBodyWorkflowAction<ComicGetAResponse, ApiConnectionActionConfiguration> ComicGetA(Expression<Func<int>> number)
        {
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            return new DeferredBodyAction<ComicGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/info.0.json", __workflow_number.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComicGetAResponse>(callPayload);
            });
        }
    }

    public class XkcdipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ComicGetResponse
    {
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("news")]
        public string News { get; set; }

        [JsonProperty("safe_title")]
        public string SafeTitle { get; set; }

        [JsonProperty("transcript")]
        public string Transcript { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }
    }

    public class ComicGetAResponse
    {
        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("news")]
        public string News { get; set; }

        [JsonProperty("safe_title")]
        public string SafeTitle { get; set; }

        [JsonProperty("transcript")]
        public string Transcript { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xkcdip;

    public partial class WorkflowManagedActions
    {
        public XkcdipActions Xkcdip(string connectionId) => new XkcdipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XkcdipTriggers Xkcdip(string connectionId) => new XkcdipTriggers(connectionId);
    }
}