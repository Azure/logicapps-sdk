//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbauddocuments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbauddocumentsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbauddocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<ConstituentApiFileDefinition> CreateDocument([WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<bool> bodyincludeThumbnail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiFileDefinition> __BuildCreateDocument(WorkflowExpression<string> bodyfileName = null, WorkflowExpression<bool> bodyincludeThumbnail = null)
        {
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowExpression.Validate(bodyincludeThumbnail, nameof(bodyincludeThumbnail), required: false);
            return new DeferredBodyAction<ConstituentApiFileDefinition>(() =>
            {
                var apiCallPath = "/constituent/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                    bodypropCount++;
                }

                if (bodyincludeThumbnail != null)
                {
                    body["upload_thumbnail"] = ExpressionConverter.ConvertO(bodyincludeThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiFileDefinition>(callPayload);
            });
        }
    }

    public class BlackbauddocumentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiFileDefinition
    {
        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("file_upload_request")]
        public ConstituentApiFileDefinitionFileUploadType FileUpload { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_upload_request")]
        public ConstituentApiFileDefinitionThumbnailUploadType ThumbnailUpload { get; set; }
    }

    public class ConstituentApiFileDefinitionFileUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ConstituentApiFileDefinitionThumbnailUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbauddocuments;

    public partial class WorkflowManagedActions
    {
        public BlackbauddocumentsActions Blackbauddocuments(string connectionId) => new BlackbauddocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbauddocumentsTriggers Blackbauddocuments(string connectionId) => new BlackbauddocumentsTriggers(connectionId);
    }
}