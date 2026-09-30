//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextdocumentum
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextdocumentumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/document/delete/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentRead> GetDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/document/get/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<File> GetDocumentContent([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-content/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<File>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentMetadataRead> GetDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-properties/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentMetadataRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fileDtofileName, [WorkflowExpression] Func<string> fileDtofileContent)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(fileDtofileName, nameof(fileDtofileName), required: true);
            SourceExpression.Validate(fileDtofileContent, nameof(fileDtofileContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/document/update-content/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileDto = new JObject();
                var fileDtopropCount = 0;
                fileDtopropCount++;
                fileDto["name"] = SourceExpressionConverter.ConvertToken(fileDtofileName);
                fileDtopropCount++;
                fileDto["content"] = SourceExpressionConverter.ConvertToken(fileDtofileContent);
                if (fileDtopropCount > 0)
                {
                    callPayload.Body = fileDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> documentDtoparentId, [WorkflowExpression] Func<string> documentDtoFilefileName, [WorkflowExpression] Func<string> documentDtoFilefileContent, [WorkflowExpression] Func<string> documentDtometadatadisplayName, [WorkflowExpression] Func<object> documentDtometadatafields, [WorkflowExpression] Func<string> documentDtometadatadescription = null)
        {
            SourceExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            SourceExpression.Validate(documentDtoparentId, nameof(documentDtoparentId), required: true);
            SourceExpression.Validate(documentDtoFilefileName, nameof(documentDtoFilefileName), required: true);
            SourceExpression.Validate(documentDtoFilefileContent, nameof(documentDtoFilefileContent), required: true);
            SourceExpression.Validate(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            SourceExpression.Validate(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            SourceExpression.Validate(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                documentDtopropCount++;
                documentDto["parentId"] = SourceExpressionConverter.ConvertToken(documentDtoparentId);
                var @fileObject = new JObject();
                var @fileObjectpropCount = 0;
                @fileObjectpropCount++;
                @fileObject["name"] = SourceExpressionConverter.ConvertToken(documentDtoFilefileName);
                @fileObjectpropCount++;
                @fileObject["content"] = SourceExpressionConverter.ConvertToken(documentDtoFilefileContent);
                if (@fileObjectpropCount > 0)
                {
                    documentDto["file"] = @fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = SourceExpressionConverter.ConvertToken(documentDtometadatadisplayName);
                if (documentDtometadatadescription != null)
                {
                    metadataObject["description"] = SourceExpressionConverter.ConvertToken(documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = SourceExpressionConverter.ConvertToken(documentDtometadatafields);
                if (metadataObjectpropCount > 0)
                {
                    documentDto["metadata"] = metadataObject;
                    documentDtopropCount++;
                }

                if (documentDtopropCount > 0)
                {
                    callPayload.Body = documentDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> documentDtoFilefileName, [WorkflowExpression] Func<string> documentDtoFilefileContent, [WorkflowExpression] Func<string> documentDtometadatadisplayName, [WorkflowExpression] Func<object> documentDtometadatafields, [WorkflowExpression] Func<string> documentDtometadatadescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            SourceExpression.Validate(documentDtoFilefileName, nameof(documentDtoFilefileName), required: true);
            SourceExpression.Validate(documentDtoFilefileContent, nameof(documentDtoFilefileContent), required: true);
            SourceExpression.Validate(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            SourceExpression.Validate(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            SourceExpression.Validate(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/update/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                var @fileObject = new JObject();
                var @fileObjectpropCount = 0;
                @fileObjectpropCount++;
                @fileObject["name"] = SourceExpressionConverter.ConvertToken(documentDtoFilefileName);
                @fileObjectpropCount++;
                @fileObject["content"] = SourceExpressionConverter.ConvertToken(documentDtoFilefileContent);
                if (@fileObjectpropCount > 0)
                {
                    documentDto["file"] = @fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = SourceExpressionConverter.ConvertToken(documentDtometadatadisplayName);
                if (documentDtometadatadescription != null)
                {
                    metadataObject["description"] = SourceExpressionConverter.ConvertToken(documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = SourceExpressionConverter.ConvertToken(documentDtometadatafields);
                if (metadataObjectpropCount > 0)
                {
                    documentDto["metadata"] = metadataObject;
                    documentDtopropCount++;
                }

                if (documentDtopropCount > 0)
                {
                    callPayload.Body = documentDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> metadataDtodisplayName, [WorkflowExpression] Func<object> metadataDtofields, [WorkflowExpression] Func<string> metadataDtodescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            SourceExpression.Validate(metadataDtodisplayName, nameof(metadataDtodisplayName), required: true);
            SourceExpression.Validate(metadataDtofields, nameof(metadataDtofields), required: true);
            SourceExpression.Validate(metadataDtodescription, nameof(metadataDtodescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/document/update-properties/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadataDto = new JObject();
                var metadataDtopropCount = 0;
                metadataDtopropCount++;
                metadataDto["displayName"] = SourceExpressionConverter.ConvertToken(metadataDtodisplayName);
                if (metadataDtodescription != null)
                {
                    metadataDto["description"] = SourceExpressionConverter.ConvertToken(metadataDtodescription);
                    metadataDtopropCount++;
                }

                metadataDtopropCount++;
                metadataDto["fields"] = SourceExpressionConverter.ConvertToken(metadataDtofields);
                if (metadataDtopropCount > 0)
                {
                    callPayload.Body = metadataDto;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class OpentextdocumentumTriggers([ConnectionName] string connectionId)
    {
    }

    public class DocumentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parentId")]
        public string ParentID { get; set; }

        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("metadata")]
        public DocumentMetadataRead Metadata { get; set; }
    }

    public class File
    {
        [JsonProperty("name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public class DocumentMetadataRead
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opentextdocumentum;

    public partial class WorkflowManagedActions
    {
        public OpentextdocumentumActions Opentextdocumentum(string connectionId) => new OpentextdocumentumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpentextdocumentumTriggers Opentextdocumentum(string connectionId) => new OpentextdocumentumTriggers(connectionId);
    }
}