//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Snapforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SnapformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "snapforms")]
        public IBodyWorkflowAction<TemporaryUrl> TemporaryFileUrl([WorkflowExpression] Func<string> formSlug, [WorkflowExpression] Func<string> responseId, [WorkflowExpression] Func<string> fileKey)
        {
            SourceExpression.Validate(formSlug, nameof(formSlug), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            SourceExpression.Validate(fileKey, nameof(fileKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forms/{0}/responses/{1}/temporary-file-url/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formSlug, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(responseId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemporaryUrl>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "snapforms")]
        public IBodyWorkflowAction<TemporaryUrl> TemporaryPdfUrl([WorkflowExpression] Func<string> formSlug, [WorkflowExpression] Func<string> responseId)
        {
            SourceExpression.Validate(formSlug, nameof(formSlug), required: true);
            SourceExpression.Validate(responseId, nameof(responseId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forms/{0}/responses/{1}/temporary-pdf-url", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formSlug, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(responseId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemporaryUrl>(BuildSourceInput);
        }
    }

    public class SnapformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResource> WebhookTrigger([WorkflowExpression] Func<string> formSlug, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(formSlug, nameof(formSlug), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/forms/{0}/responses/hooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formSlug, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["active"] = true;
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["event"] = "responses";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookCreationResource>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class TemporaryUrl
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("url")]
        public string FileURL { get; set; }
    }

    public class WebhookCreationResource
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Snapforms;

    public partial class WorkflowManagedActions
    {
        public SnapformsActions Snapforms(string connectionId) => new SnapformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SnapformsTriggers Snapforms(string connectionId) => new SnapformsTriggers(connectionId);
    }
}