//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azurefile
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzurefileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IWorkflowAction DeleteFile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath([WorkflowExpression] Func<string> path)
        {
            var apiCallPath = "/datasets/default/GetFileByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            var apiCallPath = "/datasets/default/GetFileContentByPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            var apiCallPath = String.Format("/datasets/default/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["inferContentType"] = Convert.ToString(true);
            if (inferContentType != null)
                callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(inferContentType);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = "/datasets/default/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            var apiCallPath = "/datasets/default/copyFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            var apiCallPath = "/datasets/default/extractFolderV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["destination"] = ExpressionConverter.Convert(destination);
            callPayload.Queries["overwrite"] = Convert.ToString(false);
            if (overwrite != null)
                callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
            callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
            return new ApiConnectionAction<BlobMetadata[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azurefile")]
        public IBodyWorkflowAction<BlobMetadataPage> ListFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/foldersV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["nextPageMarker"] = Convert.ToString("");
            callPayload.Queries["useFlatListing"] = Convert.ToString(false);
            return new ApiConnectionAction<BlobMetadataPage>(callPayload);
        }
    }

    public class AzurefileTriggers([ConnectionName] string connectionId)
    {
    }

    public class BlobMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class BlobMetadataPage
    {
        [JsonProperty("value")]
        public BlobMetadata[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azurefile;

    public partial class WorkflowManagedActions
    {
        public AzurefileActions Azurefile(string connectionId) => new AzurefileActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzurefileTriggers Azurefile(string connectionId) => new AzurefileTriggers(connectionId);
    }
}