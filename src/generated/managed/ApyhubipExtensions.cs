//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveFile))]
        public IBodyWorkflowAction<ArchiveFilePostResponse> ArchiveFile([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> output = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArchiveFilePostResponse> __BuildArchiveFile(WorkflowExpression<string[]> bodyurls, WorkflowExpression<string> output = null)
        {
            WorkflowExpression.Validate(bodyurls, nameof(bodyurls), required: true);
            WorkflowExpression.Validate(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveFilePostResponse>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArchiveFilePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveURL))]
        public IBodyWorkflowAction<ArchiveURLPostResponse> ArchiveURL([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> output = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArchiveURLPostResponse> __BuildArchiveURL(WorkflowExpression<string[]> bodyurls, WorkflowExpression<string> output = null)
        {
            WorkflowExpression.Validate(bodyurls, nameof(bodyurls), required: true);
            WorkflowExpression.Validate(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveURLPostResponse>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArchiveURLPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [WorkflowExpressionFactory(nameof(__BuildUnarchiveURL))]
        public IBodyWorkflowAction<UnarchiveURLPostResponse> UnarchiveURL([WorkflowExpression] Func<string> bodyurl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnarchiveURLPostResponse> __BuildUnarchiveURL(WorkflowExpression<string> bodyurl)
        {
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            return new DeferredBodyAction<UnarchiveURLPostResponse>(() =>
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class ArchiveURLPostResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class UnarchiveURLPostResponse
    {
        [JsonProperty("data")]
        public string[] Data { get; set; }
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