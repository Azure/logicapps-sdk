//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveFilePostResponse> ArchiveFile([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> output = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/generate/archive/file-urls/archive-file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = SourceExpressionConverter.ConvertO(output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = SourceExpressionConverter.ConvertToken(bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArchiveFilePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<ArchiveURLPostResponse> ArchiveURL([WorkflowExpression] Func<string[]> bodyurls, [WorkflowExpression] Func<string> output = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/generate/archive/file-urls/archive-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = SourceExpressionConverter.ConvertO(output);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = SourceExpressionConverter.ConvertToken(bodyurls);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ArchiveURLPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubip")]
        public IBodyWorkflowAction<UnarchiveURLPostResponse> UnarchiveURL([WorkflowExpression] Func<string> bodyurl)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/extract/archive/url/file-urls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnarchiveURLPostResponse>(BuildSourceInput);
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