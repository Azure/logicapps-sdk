//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbauddocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbauddocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbauddocuments")]
        public IBodyWorkflowAction<ConstituentApiFileDefinition> CreateDocument([WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<bool> bodyincludeThumbnail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyincludeThumbnail != null)
                {
                    body["upload_thumbnail"] = SourceExpressionConverter.ConvertToken(bodyincludeThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiFileDefinition>(BuildSourceInput);
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