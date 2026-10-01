//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shrtcodeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShrtcodeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        public IBodyWorkflowAction<ShortenLinkResponse> ShortenLink([WorkflowExpression] Func<string> url)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/shorten";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                return callPayload;
            }

            return new ApiConnectionAction<ShortenLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        public IBodyWorkflowAction<GettingInformationLinkResponse> GettingInformationLink([WorkflowExpression] Func<string> code)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                return callPayload;
            }

            return new ApiConnectionAction<GettingInformationLinkResponse>(BuildSourceInput);
        }
    }

    public class ShrtcodeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ShortenLinkResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public ShortenLinkResponseResultType Result { get; set; }
    }

    public class ShortenLinkResponseResultType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("short_link")]
        public string ShortLink { get; set; }

        [JsonProperty("full_short_link")]
        public string FullShortLink { get; set; }

        [JsonProperty("short_link2")]
        public string ShortLink2 { get; set; }

        [JsonProperty("full_short_link2")]
        public string FullShortLink2 { get; set; }

        [JsonProperty("share_link")]
        public string ShareLink { get; set; }

        [JsonProperty("full_share_link")]
        public string FullShareLink { get; set; }

        [JsonProperty("original_link")]
        public string OriginalLink { get; set; }
    }

    public class GettingInformationLinkResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("result")]
        public GettingInformationLinkResponseResultType Result { get; set; }
    }

    public class GettingInformationLinkResponseResultType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("password_protected")]
        public bool PasswordProtected { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shrtcodeip;

    public partial class WorkflowManagedActions
    {
        public ShrtcodeipActions Shrtcodeip(string connectionId) => new ShrtcodeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShrtcodeipTriggers Shrtcodeip(string connectionId) => new ShrtcodeipTriggers(connectionId);
    }
}