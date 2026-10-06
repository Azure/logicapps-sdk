//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shrtcodeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShrtcodeipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        [WorkflowExpressionFactory(nameof(__BuildShortenLink))]
        public IBodyWorkflowAction<ShortenLinkResponse> ShortenLink([WorkflowExpression] Func<string> url)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShortenLinkResponse> __BuildShortenLink(WorkflowExpression<string> url)
        {
            WorkflowExpression.Validate(url, nameof(url), required: true);
            return new DeferredBodyAction<ShortenLinkResponse>(() =>
            {
                var apiCallPath = "/shorten";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                return new ApiConnectionAction<ShortenLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        [WorkflowExpressionFactory(nameof(__BuildGettingInformationLink))]
        public IBodyWorkflowAction<GettingInformationLinkResponse> GettingInformationLink([WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shrtcodeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GettingInformationLinkResponse> __BuildGettingInformationLink(WorkflowExpression<string> code)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<GettingInformationLinkResponse>(() =>
            {
                var apiCallPath = "/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
                return new ApiConnectionAction<GettingInformationLinkResponse>(callPayload);
            });
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