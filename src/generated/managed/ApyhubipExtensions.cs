//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveFilePostResponse, ApiConnectionActionConfiguration> ArchiveFile(Expression<Func<string>> output = null, Expression<Func<ArchiveFilePostInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArchiveFilePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveFilePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveURLPostResponse, ApiConnectionActionConfiguration> ArchiveURL(Expression<Func<string>> output = null, Expression<Func<ArchiveURLPostInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArchiveURLPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveURLPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<UnarchiveURLPostResponse, ApiConnectionActionConfiguration> UnarchiveURL(Expression<Func<UnarchiveURLPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UnarchiveURLPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UnarchiveURLPostResponse>(callPayload);
            });
        }
    }

    public class ApyhubipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArchiveFilePostResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class ArchiveFilePostInput
    {
        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Urls { get; set; }
    }

    public class ArchiveURLPostResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class ArchiveURLPostInput
    {
        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Urls { get; set; }
    }

    public class UnarchiveURLPostResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UnarchiveURLPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubip;

    public partial class WorkflowManagedActions
    {
        public ApyhubipActions Apyhubip(string connectionId) => new ApyhubipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApyhubipTriggers Apyhubip(string connectionId) => new ApyhubipTriggers(connectionId);
    }
}