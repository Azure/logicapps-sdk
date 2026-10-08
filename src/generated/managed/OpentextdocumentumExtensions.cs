//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextdocumentum
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextdocumentumActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/document/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IBodyWorkflowAction<DocumentRead> GetDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentRead> __BuildGetDocument(WorkflowExpression<string> id, WorkflowExpression<string> configurationSet)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            return new DeferredBodyAction<DocumentRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/document/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentContent))]
        public IBodyWorkflowAction<File> GetDocumentContent([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<File> __BuildGetDocumentContent(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<File>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentProperties))]
        public IBodyWorkflowAction<DocumentMetadataRead> GetDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentMetadataRead> __BuildGetDocumentProperties(WorkflowExpression<string> id, WorkflowExpression<string> configurationSet)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            return new DeferredBodyAction<DocumentMetadataRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentMetadataRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocumentContent))]
        public IWorkflowAction UpdateDocumentContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fileDtofileName, [WorkflowExpression] Func<string> fileDtofileContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocumentContent(WorkflowExpression<string> id, WorkflowExpression<string> fileDtofileName, WorkflowExpression<string> fileDtofileContent)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fileDtofileName, nameof(fileDtofileName), required: true);
            WorkflowExpression.Validate(fileDtofileContent, nameof(fileDtofileContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/document/update-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileDto = new JObject();
                var fileDtopropCount = 0;
                fileDtopropCount++;
                fileDto["name"] = ExpressionConverter.ConvertO(fileDtofileName);
                fileDtopropCount++;
                fileDto["content"] = ExpressionConverter.ConvertO(fileDtofileContent);
                if (fileDtopropCount > 0)
                {
                    callPayload.Body = fileDto;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<string> CreateDocument([WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> documentDtoparentID, [WorkflowExpression] Func<string> documentDtofilefileName, [WorkflowExpression] Func<string> documentDtofilefileContent, [WorkflowExpression] Func<string> documentDtometadatadisplayName, [WorkflowExpression] Func<object> documentDtometadatafields, [WorkflowExpression] Func<string> documentDtometadatadescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateDocument(WorkflowExpression<string> configurationSet, WorkflowExpression<string> documentDtoparentID, WorkflowExpression<string> documentDtofilefileName, WorkflowExpression<string> documentDtofilefileContent, WorkflowExpression<string> documentDtometadatadisplayName, WorkflowExpression<object> documentDtometadatafields, WorkflowExpression<string> documentDtometadatadescription = null)
        {
            WorkflowExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            WorkflowExpression.Validate(documentDtoparentID, nameof(documentDtoparentID), required: true);
            WorkflowExpression.Validate(documentDtofilefileName, nameof(documentDtofilefileName), required: true);
            WorkflowExpression.Validate(documentDtofilefileContent, nameof(documentDtofilefileContent), required: true);
            WorkflowExpression.Validate(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            WorkflowExpression.Validate(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            WorkflowExpression.Validate(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                documentDtopropCount++;
                documentDto["parentId"] = ExpressionConverter.ConvertO(documentDtoparentID);
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(documentDtofilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(documentDtofilefileContent);
                if (fileObjectpropCount > 0)
                {
                    documentDto["file"] = fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(documentDtometadatadisplayName);
                if (documentDtometadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = ExpressionConverter.ConvertO(documentDtometadatafields);
                if (metadataObjectpropCount > 0)
                {
                    documentDto["metadata"] = metadataObject;
                    documentDtopropCount++;
                }

                if (documentDtopropCount > 0)
                {
                    callPayload.Body = documentDto;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocument))]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> documentDtofilefileName, [WorkflowExpression] Func<string> documentDtofilefileContent, [WorkflowExpression] Func<string> documentDtometadatadisplayName, [WorkflowExpression] Func<object> documentDtometadatafields, [WorkflowExpression] Func<string> documentDtometadatadescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocument(WorkflowExpression<string> id, WorkflowExpression<string> configurationSet, WorkflowExpression<string> documentDtofilefileName, WorkflowExpression<string> documentDtofilefileContent, WorkflowExpression<string> documentDtometadatadisplayName, WorkflowExpression<object> documentDtometadatafields, WorkflowExpression<string> documentDtometadatadescription = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            WorkflowExpression.Validate(documentDtofilefileName, nameof(documentDtofilefileName), required: true);
            WorkflowExpression.Validate(documentDtofilefileContent, nameof(documentDtofilefileContent), required: true);
            WorkflowExpression.Validate(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            WorkflowExpression.Validate(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            WorkflowExpression.Validate(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/document/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(documentDtofilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(documentDtofilefileContent);
                if (fileObjectpropCount > 0)
                {
                    documentDto["file"] = fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(documentDtometadatadisplayName);
                if (documentDtometadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = ExpressionConverter.ConvertO(documentDtometadatafields);
                if (metadataObjectpropCount > 0)
                {
                    documentDto["metadata"] = metadataObject;
                    documentDtopropCount++;
                }

                if (documentDtopropCount > 0)
                {
                    callPayload.Body = documentDto;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocumentProperties))]
        public IWorkflowAction UpdateDocumentProperties([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> configurationSet, [WorkflowExpression] Func<string> metadataDtodisplayName, [WorkflowExpression] Func<object> metadataDtofields, [WorkflowExpression] Func<string> metadataDtodescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocumentProperties(WorkflowExpression<string> id, WorkflowExpression<string> configurationSet, WorkflowExpression<string> metadataDtodisplayName, WorkflowExpression<object> metadataDtofields, WorkflowExpression<string> metadataDtodescription = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(configurationSet, nameof(configurationSet), required: true);
            WorkflowExpression.Validate(metadataDtodisplayName, nameof(metadataDtodisplayName), required: true);
            WorkflowExpression.Validate(metadataDtofields, nameof(metadataDtofields), required: true);
            WorkflowExpression.Validate(metadataDtodescription, nameof(metadataDtodescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/document/update-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadataDto = new JObject();
                var metadataDtopropCount = 0;
                metadataDtopropCount++;
                metadataDto["displayName"] = ExpressionConverter.ConvertO(metadataDtodisplayName);
                if (metadataDtodescription != null)
                {
                    metadataDto["description"] = ExpressionConverter.ConvertO(metadataDtodescription);
                    metadataDtopropCount++;
                }

                metadataDtopropCount++;
                metadataDto["fields"] = ExpressionConverter.ConvertO(metadataDtofields);
                if (metadataDtopropCount > 0)
                {
                    callPayload.Body = metadataDto;
                }

                return new ApiConnectionAction(callPayload);
            });
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