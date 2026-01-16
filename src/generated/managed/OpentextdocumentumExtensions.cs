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
        public IBodyWorkflowAction<string> CreateDocumentV2(Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtoparentID, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v1/document/delete/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentRead> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var apiCallPath = String.Format("/api/v1/document/get/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<File> GetDocumentContent(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v1/document/get-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentMetadataRead> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var apiCallPath = String.Format("/api/v1/document/get-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentMetadataRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> fileDtofileName, Expression<Func<string>> fileDtofileContent)
        {
            var apiCallPath = String.Format("/api/v1/document/update-content/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentPropertiesV2(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> metadataDtodisplayName, Expression<Func<object>> metadataDtofields, Expression<Func<string>> metadataDtodescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/update-properties/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentV2(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var apiCallPath = String.Format("/api/v2/document/update/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(configurationSet, 1));
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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