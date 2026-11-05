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
        public IBodyWorkflowAction<ArchiveFileResponse, ApiConnectionActionConfiguration> ArchiveFile(Expression<Func<string>> output = null, Expression<Func<ArchiveFileBodyInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArchiveFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveURLResponse, ApiConnectionActionConfiguration> ArchiveURL(Expression<Func<string>> output = null, Expression<Func<ArchiveFileBodyInput>> body = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ArchiveURLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ArchiveURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<UnarchiveURLResponse, ApiConnectionActionConfiguration> UnarchiveURL(Expression<Func<UnarchiveURLBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UnarchiveURLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UnarchiveURLResponse>(callPayload);
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
        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Urls { get; set; }
    }

    public class ArchiveURLResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UnarchiveURLResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class UnarchiveURLBodyInput
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