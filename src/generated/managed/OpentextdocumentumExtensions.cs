//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opentextdocumentum
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpentextdocumentumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/document/delete/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentRead> GetDocument(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationSet = WorkflowExpression.Compile(configurationSet, nameof(configurationSet), required: true);
            return new DeferredBodyAction<DocumentRead>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/document/get/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationSet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentRead>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<File> GetDocumentContent(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/document/get-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<File>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<DocumentMetadataRead> GetDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationSet)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationSet = WorkflowExpression.Compile(configurationSet, nameof(configurationSet), required: true);
            return new DeferredBodyAction<DocumentMetadataRead>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/document/get-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationSet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentMetadataRead>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentContent(Expression<Func<string>> id, Expression<Func<string>> fileDtofileName, Expression<Func<string>> fileDtofileContent)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fileDtofileName = WorkflowExpression.Compile(fileDtofileName, nameof(fileDtofileName), required: true);
            var __workflow_fileDtofileContent = WorkflowExpression.Compile(fileDtofileContent, nameof(fileDtofileContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/document/update-content/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var fileDto = new JObject();
                var fileDtopropCount = 0;
                fileDtopropCount++;
                fileDto["name"] = ExpressionConverter.ConvertO(__workflow_fileDtofileName);
                fileDtopropCount++;
                fileDto["content"] = ExpressionConverter.ConvertO(__workflow_fileDtofileContent);
                if (fileDtopropCount > 0)
                {
                    callPayload.Body = fileDto;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IBodyWorkflowAction<string> CreateDocument(Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtoparentID, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var __workflow_configurationSet = WorkflowExpression.Compile(configurationSet, nameof(configurationSet), required: true);
            var __workflow_documentDtoparentID = WorkflowExpression.Compile(documentDtoparentID, nameof(documentDtoparentID), required: true);
            var __workflow_documentDtofilefileName = WorkflowExpression.Compile(documentDtofilefileName, nameof(documentDtofilefileName), required: true);
            var __workflow_documentDtofilefileContent = WorkflowExpression.Compile(documentDtofilefileContent, nameof(documentDtofilefileContent), required: true);
            var __workflow_documentDtometadatadisplayName = WorkflowExpression.Compile(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            var __workflow_documentDtometadatafields = WorkflowExpression.Compile(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            var __workflow_documentDtometadatadescription = WorkflowExpression.Compile(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/create/{0}", __workflow_configurationSet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                documentDtopropCount++;
                documentDto["parentId"] = ExpressionConverter.ConvertO(__workflow_documentDtoparentID);
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(__workflow_documentDtofilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(__workflow_documentDtofilefileContent);
                if (fileObjectpropCount > 0)
                {
                    documentDto["file"] = fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatadisplayName);
                if (__workflow_documentDtometadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatafields);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> documentDtofilefileName, Expression<Func<string>> documentDtofilefileContent, Expression<Func<string>> documentDtometadatadisplayName, Expression<Func<object>> documentDtometadatafields, Expression<Func<string>> documentDtometadatadescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationSet = WorkflowExpression.Compile(configurationSet, nameof(configurationSet), required: true);
            var __workflow_documentDtofilefileName = WorkflowExpression.Compile(documentDtofilefileName, nameof(documentDtofilefileName), required: true);
            var __workflow_documentDtofilefileContent = WorkflowExpression.Compile(documentDtofilefileContent, nameof(documentDtofilefileContent), required: true);
            var __workflow_documentDtometadatadisplayName = WorkflowExpression.Compile(documentDtometadatadisplayName, nameof(documentDtometadatadisplayName), required: true);
            var __workflow_documentDtometadatafields = WorkflowExpression.Compile(documentDtometadatafields, nameof(documentDtometadatafields), required: true);
            var __workflow_documentDtometadatadescription = WorkflowExpression.Compile(documentDtometadatadescription, nameof(documentDtometadatadescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/update/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationSet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var documentDto = new JObject();
                var documentDtopropCount = 0;
                var fileObject = new JObject();
                var fileObjectpropCount = 0;
                fileObjectpropCount++;
                fileObject["name"] = ExpressionConverter.ConvertO(__workflow_documentDtofilefileName);
                fileObjectpropCount++;
                fileObject["content"] = ExpressionConverter.ConvertO(__workflow_documentDtofilefileContent);
                if (fileObjectpropCount > 0)
                {
                    documentDto["file"] = fileObject;
                    documentDtopropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                metadataObjectpropCount++;
                metadataObject["displayName"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatadisplayName);
                if (__workflow_documentDtometadatadescription != null)
                {
                    metadataObject["description"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatadescription);
                    metadataObjectpropCount++;
                }

                metadataObjectpropCount++;
                metadataObject["fields"] = ExpressionConverter.ConvertO(__workflow_documentDtometadatafields);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opentextdocumentum")]
        public IWorkflowAction UpdateDocumentProperties(Expression<Func<string>> id, Expression<Func<string>> configurationSet, Expression<Func<string>> metadataDtodisplayName, Expression<Func<object>> metadataDtofields, Expression<Func<string>> metadataDtodescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationSet = WorkflowExpression.Compile(configurationSet, nameof(configurationSet), required: true);
            var __workflow_metadataDtodisplayName = WorkflowExpression.Compile(metadataDtodisplayName, nameof(metadataDtodisplayName), required: true);
            var __workflow_metadataDtofields = WorkflowExpression.Compile(metadataDtofields, nameof(metadataDtofields), required: true);
            var __workflow_metadataDtodescription = WorkflowExpression.Compile(metadataDtodescription, nameof(metadataDtodescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/document/update-properties/{0}/{1}", __workflow_id.WithUrlEncoding(1), __workflow_configurationSet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var metadataDto = new JObject();
                var metadataDtopropCount = 0;
                metadataDtopropCount++;
                metadataDto["displayName"] = ExpressionConverter.ConvertO(__workflow_metadataDtodisplayName);
                if (__workflow_metadataDtodescription != null)
                {
                    metadataDto["description"] = ExpressionConverter.ConvertO(__workflow_metadataDtodescription);
                    metadataDtopropCount++;
                }

                metadataDtopropCount++;
                metadataDto["fields"] = ExpressionConverter.ConvertO(__workflow_metadataDtofields);
                if (metadataDtopropCount > 0)
                {
                    callPayload.Body = metadataDto;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
