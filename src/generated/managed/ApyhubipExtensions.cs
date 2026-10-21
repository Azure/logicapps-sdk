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
        public IBodyWorkflowAction<ArchiveFilePostResponse> ArchiveFile(Expression<Func<string[]>> bodyurls, Expression<Func<string>> output = null)
        {
            var __workflow_bodyurls = WorkflowExpression.Compile(bodyurls, nameof(bodyurls), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveFilePostResponse>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArchiveFilePostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveURLPostResponse> ArchiveURL(Expression<Func<string[]>> bodyurls, Expression<Func<string>> output = null)
        {
            var __workflow_bodyurls = WorkflowExpression.Compile(bodyurls, nameof(bodyurls), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<ArchiveURLPostResponse>(() =>
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ArchiveURLPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<UnarchiveURLPostResponse> UnarchiveURL(Expression<Func<string>> bodyurl)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            return new DeferredBodyAction<UnarchiveURLPostResponse>(() =>
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnarchiveURLPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
