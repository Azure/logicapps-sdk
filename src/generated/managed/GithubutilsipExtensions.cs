//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubutilsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubutilsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> PostMarkdown([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<bodymodeInput> bodymode = null, [WorkflowExpression] Func<string> bodycontext = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            SourceExpression.Validate(bodymode, nameof(bodymode), required: false);
            SourceExpression.Validate(bodycontext, nameof(bodycontext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/markdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodymode != null)
                {
                    if (bodymode != null)
                    {
                        body["mode"] = SourceExpressionConverter.Convert(bodymode);
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
                    body["context"] = SourceExpressionConverter.ConvertToken(bodycontext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> PostMarkdownRaw([WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> xGitHubApiVersion = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/markdown/raw";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string[]> GetVersions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/versions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<string> GetZen([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/zen";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<License[]> GetLicenses([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<bool> featured = null, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            SourceExpression.Validate(featured, nameof(featured), required: false);
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/licenses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(30);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (featured != null)
                    callPayload.Queries["featured"] = SourceExpressionConverter.ConvertO(featured);
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<License[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<LicenseAdvanced> GetLicense([WorkflowExpression] Func<string> license, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            SourceExpression.Validate(license, nameof(license), required: true);
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/licenses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(license, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<LicenseAdvanced>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct[]> GetCodesOfConduct([WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codes_of_conduct";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accept"] = Convert.ToString("application/vnd.github+json");
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<CodeOfConduct[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubutilsip")]
        public IBodyWorkflowAction<CodeOfConduct> GetCodeOfConduct([WorkflowExpression] Func<string> codeOfConduct, [WorkflowExpression] Func<string> xGitHubApiVersion = null)
        {
            SourceExpression.Validate(codeOfConduct, nameof(codeOfConduct), required: true);
            SourceExpression.Validate(xGitHubApiVersion, nameof(xGitHubApiVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codes_of_conduct/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(codeOfConduct, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-GitHub-Api-Version"] = Convert.ToString("2022-11-28");
                if (xGitHubApiVersion != null)
                    callPayload.Headers["X-GitHub-Api-Version"] = SourceExpressionConverter.ConvertO(xGitHubApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<CodeOfConduct>(BuildSourceInput);
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