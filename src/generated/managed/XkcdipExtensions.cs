//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xkcdip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XkcdipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xkcdip")]
        public IBodyWorkflowAction<ComicGetResponse> ComicGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/info.0.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComicGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xkcdip")]
        public IBodyWorkflowAction<ComicGetAResponse> ComicGetA([WorkflowExpression] Func<int> number)
        {
            SourceExpression.Validate(number, nameof(number), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/info.0.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComicGetAResponse>(BuildSourceInput);
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