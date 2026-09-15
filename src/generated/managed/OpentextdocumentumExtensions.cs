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
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/document/delete/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentRead> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/document/get/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<File> GetDocumentContent(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-content/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<File>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentMetadataRead> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/document/get-properties/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentMetadataRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> fileDtofileName, Expression<Func<string>> fileDtofileContent)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/document/update-content/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var fileDto = new JObject();
            var fileDtopropCount = 0;
            fileDtopropCount++;
            fileDto["name"] = CSharpExpressionConverter.ConvertToken(fileDtofileName);
            fileDtopropCount++;
            fileDto["content"] = CSharpExpressionConverter.ConvertToken(fileDtofileContent);
            if (fileDtopropCount > 0)
            {
                callPayload.Body = fileDto;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<string> CreateDocument(Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtoparentID, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v2/document/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var documentDto = new JObject();
            var documentDtopropCount = 0;
            documentDtopropCount++;
            documentDto["parentId"] = CSharpExpressionConverter.ConvertToken(documentDtoparentID);
            var fileObject = new JObject();
            var fileObjectpropCount = 0;
            fileObjectpropCount++;
            fileObject["name"] = CSharpExpressionConverter.ConvertToken(documentDtofilefileName);
            fileObjectpropCount++;
            fileObject["content"] = CSharpExpressionConverter.ConvertToken(documentDtofilefileContent);
            if (fileObjectpropCount > 0)
            {
                documentDto["file"] = fileObject;
                documentDtopropCount++;
            }

            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["displayName"] = CSharpExpressionConverter.ConvertToken(documentDtometadatadisplayName);
            if (documentDtometadatadescription != null)
            {
                metadataObject["description"] = CSharpExpressionConverter.ConvertToken(documentDtometadatadescription);
                metadataObjectpropCount++;
            }

            metadataObjectpropCount++;
            metadataObject["fields"] = CSharpExpressionConverter.ConvertToken(documentDtometadatafields);
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
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v2/document/update/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var documentDto = new JObject();
            var documentDtopropCount = 0;
            var fileObject = new JObject();
            var fileObjectpropCount = 0;
            fileObjectpropCount++;
            fileObject["name"] = CSharpExpressionConverter.ConvertToken(documentDtofilefileName);
            fileObjectpropCount++;
            fileObject["content"] = CSharpExpressionConverter.ConvertToken(documentDtofilefileContent);
            if (fileObjectpropCount > 0)
            {
                documentDto["file"] = fileObject;
                documentDtopropCount++;
            }

            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            metadataObjectpropCount++;
            metadataObject["displayName"] = CSharpExpressionConverter.ConvertToken(documentDtometadatadisplayName);
            if (documentDtometadatadescription != null)
            {
                metadataObject["description"] = CSharpExpressionConverter.ConvertToken(documentDtometadatadescription);
                metadataObjectpropCount++;
            }

            metadataObjectpropCount++;
            metadataObject["fields"] = CSharpExpressionConverter.ConvertToken(documentDtometadatafields);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> metadataDtodisplayName, Expression<Func<object>> metadataDtofields, Expression<Func<string>> metadataDtodescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v2/document/update-properties/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationSet, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var metadataDto = new JObject();
            var metadataDtopropCount = 0;
            metadataDtopropCount++;
            metadataDto["displayName"] = CSharpExpressionConverter.ConvertToken(metadataDtodisplayName);
            if (metadataDtodescription != null)
            {
                metadataDto["description"] = CSharpExpressionConverter.ConvertToken(metadataDtodescription);
                metadataDtopropCount++;
            }

            metadataDtopropCount++;
            metadataDto["fields"] = CSharpExpressionConverter.ConvertToken(metadataDtofields);
            if (metadataDtopropCount > 0)
            {
                callPayload.Body = metadataDto;
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