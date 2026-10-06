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
        [WorkflowExpressionFactory(nameof(__BuildPostMarkdown))]
        public IBodyWorkflowAction<string> PostMarkdown([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodycontext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostMarkdown(WorkflowExpression<string> bodytext, WorkflowExpression<string> xGitHubApiVersion = null, WorkflowExpression<bodymodeInput> bodymode = null, WorkflowExpression<string> bodycontext = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodycontext, nameof(bodycontext), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [WorkflowExpressionFactory(nameof(__BuildPostMarkdownRaw))]
        public IBodyWorkflowAction<string> PostMarkdownRaw([WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPostMarkdownRaw(WorkflowExpression<contentTypeInput> contentType, WorkflowExpression<string> xGitHubApiVersion = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildGetZen))]
        public IBodyWorkflowAction<string> GetZen([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetZen(WorkflowExpression<string> xGitHubApiVersion = null)
        {
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/zen";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLicenses))]
        public IBodyWorkflowAction<License[]> GetLicenses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<bool> featured = null, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<License[]> __BuildGetLicenses(WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<bool> featured = null, WorkflowExpression<string> xGitHubApiVersion = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(featured, nameof(featured), required: false);
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<License[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [WorkflowExpressionFactory(nameof(__BuildGetLicense))]
        public IBodyWorkflowAction<LicenseAdvanced> GetLicense([WorkflowExpression] Func<string> license, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LicenseAdvanced> __BuildGetLicense(WorkflowExpression<string> license, WorkflowExpression<string> xGitHubApiVersion = null)
        {
            WorkflowExpression.Validate(license, nameof(license), required: true);
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<LicenseAdvanced>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/licenses/{0}", ExpressionConverter.ConvertWithUrlEncoding(license, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
                return new ApiConnectionAction<LicenseAdvanced>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCodesOfConduct))]
        public IBodyWorkflowAction<CodeOfConduct[]> GetCodesOfConduct([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CodeOfConduct[]> __BuildGetCodesOfConduct(WorkflowExpression<string> xGitHubApiVersion = null)
        {
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<CodeOfConduct[]>(() =>
            {
                var apiCallPath = "/codes_of_conduct";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
                return new ApiConnectionAction<CodeOfConduct[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCodeOfConduct))]
        public IBodyWorkflowAction<CodeOfConduct> GetCodeOfConduct([WorkflowExpression] Func<string> codeOfConduct, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CodeOfConduct> __BuildGetCodeOfConduct(WorkflowExpression<string> codeOfConduct, WorkflowExpression<string> xGitHubApiVersion = null)
        {
            WorkflowExpression.Validate(codeOfConduct, nameof(codeOfConduct), required: true);
            WorkflowExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            return new DeferredBodyAction<CodeOfConduct>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codes_of_conduct/{0}", ExpressionConverter.ConvertWithUrlEncoding(codeOfConduct, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = ExpressionConverter.Convert(xGitHubApiVersion);
                return new ApiConnectionAction<CodeOfConduct>(callPayload);
            });
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