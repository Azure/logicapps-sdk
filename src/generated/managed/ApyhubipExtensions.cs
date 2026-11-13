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
        public IBodyWorkflowAction<ArchiveFileResponse, ApiConnectionActionConfiguration> ArchiveFile(Expression<Func<ArchiveFileBodyInput>> body, Expression<Func<string>> output = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveUrlResponse, ApiConnectionActionConfiguration> ArchiveUrl(Expression<Func<ArchiveFileBodyInput>> body, Expression<Func<string>> output = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<UnarchiveUrlResponse, ApiConnectionActionConfiguration> UnarchiveUrl(Expression<Func<UnarchiveUrlBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UnarchiveUrlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UnarchiveUrlResponse>(callPayload);
            });
        }
    }

    public class ApyhubipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArchiveFileResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class ArchiveFileBodyInput
    {
        public ArchiveFileBodyInput(string[] urls)
        {
            this.Urls = urls;
        }

        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Urls { get; set; }
    }

    public class ArchiveUrlResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UnarchiveUrlResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UnarchiveUrlBodyInput
    {
        public UnarchiveUrlBodyInput(string url)
        {
            this.Url = url;
        }

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