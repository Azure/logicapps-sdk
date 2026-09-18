//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubutilsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubutilsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> PostMarkdown([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodycontext = null)
        {
            var apiCallPath = "/markdown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodymode != null)
            {
                if (bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(bodymode);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["mode"] = "markdown";
                bodypropCount++;
            }

            if (bodycontext != null)
            {
                body["context"] = ExpressionConverter.ConvertO(bodycontext);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> PostMarkdownRaw([WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = "/markdown/raw";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string[]> GetVersions()
        {
            var apiCallPath = "/versions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> GetZen([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            var apiCallPath = "/zen";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<License[]> GetLicenses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<bool> featured = null, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            var apiCallPath = "/licenses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(30);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (featured != null)
                callPayload.Queries["featured"] = ExpressionConverter.Convert(featured);
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            return new ApiConnectionAction<License[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<LicenseAdvanced> GetLicense([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> license, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            var apiCallPath = String.Format("/licenses/{0}", ExpressionConverter.ConvertWithUrlEncoding(license, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            return new ApiConnectionAction<LicenseAdvanced>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct[]> GetCodesOfConduct([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            var apiCallPath = "/codes_of_conduct";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            return new ApiConnectionAction<CodeOfConduct[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct> GetCodeOfConduct([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> codeOfConduct, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            var apiCallPath = String.Format("/codes_of_conduct/{0}", ExpressionConverter.ConvertWithUrlEncoding(codeOfConduct, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
            if (xGitHubApiVersion != null)
                callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
            return new ApiConnectionAction<CodeOfConduct>(callPayload);
        }
    }

    public class GithubutilsipTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodymodeInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "gfm")]
        Gfm
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "text/plain")]
        TextPlain,
        [EnumMember(Value = "text/x-markdown")]
        TextXMarkdown
    }

    public class License
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spdx_id")]
        public string SpdxId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }
    }

    public class LicenseAdvanced
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spdx_id")]
        public string SpdxId { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("implementation")]
        public string Implementation { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("conditions")]
        public string[] Conditions { get; set; }

        [JsonProperty("limitations")]
        public string[] Limitations { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class CodeOfConduct
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Githubutilsip;

    public partial class WorkflowManagedActions
    {
        public GithubutilsipActions Githubutilsip(string connectionId) => new GithubutilsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GithubutilsipTriggers Githubutilsip(string connectionId) => new GithubutilsipTriggers(connectionId);
    }
}