//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubutilsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubutilsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PostMarkdown(Expression<Func<string>> bodytext, Expression<Func<string>> xGitHubApiVersion = null, Expression<Func<bodymodeInput>> bodymode = null, Expression<Func<string>> bodycontext = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: false);
            var __workflow_bodycontext = WorkflowExpression.Compile(bodycontext, nameof(bodycontext), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/markdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodymode != null)
                {
                    if (__workflow_bodymode != null)
                    {
                        body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["mode"] = "markdown";
                    bodypropCount++;
                }

                if (__workflow_bodycontext != null)
                {
                    body["context"] = ExpressionConverter.ConvertO(__workflow_bodycontext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PostMarkdownRaw(Expression<Func<contentTypeInput>> contentType, Expression<Func<string>> xGitHubApiVersion = null, Expression<Func<string>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/markdown/raw";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetVersions()
        {
            var apiCallPath = "/versions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetZen(Expression<Func<string>> xGitHubApiVersion = null)
        {
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/zen";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<License[], ApiConnectionActionConfiguration> GetLicenses(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<bool>> featured = null, Expression<Func<string>> xGitHubApiVersion = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_featured = WorkflowExpression.Compile(featured, nameof(featured), required: false);
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<License[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/licenses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_featured != null)
                    callPayload.Queries["featured"] = ExpressionConverter.Convert(__workflow_featured);
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                return new ApiConnectionAction<License[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<LicenseAdvanced, ApiConnectionActionConfiguration> GetLicense(Expression<Func<string>> license, Expression<Func<string>> xGitHubApiVersion = null)
        {
            var __workflow_license = WorkflowExpression.Compile(license, nameof(license), required: true);
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<LicenseAdvanced, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/licenses/{0}", __workflow_license.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                return new ApiConnectionAction<LicenseAdvanced>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct[], ApiConnectionActionConfiguration> GetCodesOfConduct(Expression<Func<string>> xGitHubApiVersion = null)
        {
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<CodeOfConduct[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/codes_of_conduct";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                return new ApiConnectionAction<CodeOfConduct[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct, ApiConnectionActionConfiguration> GetCodeOfConduct(Expression<Func<string>> codeOfConduct, Expression<Func<string>> xGitHubApiVersion = null)
        {
            var __workflow_codeOfConduct = WorkflowExpression.Compile(codeOfConduct, nameof(codeOfConduct), required: true);
            var __workflow_xGitHubApiVersion = WorkflowExpression.Compile(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<CodeOfConduct, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codes_of_conduct/{0}", __workflow_codeOfConduct.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (__workflow_xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(__workflow_xGitHubApiVersion);
                return new ApiConnectionAction<CodeOfConduct>(callPayload);
            });
        }
    }

    public class GithubutilsipTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymodeInput
    {
        [EnumMember(Value = "markdown")]
        Markdown,
        [EnumMember(Value = "gfm")]
        Gfm
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
