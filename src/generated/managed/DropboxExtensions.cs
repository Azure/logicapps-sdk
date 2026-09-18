//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DropboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadata([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> GetFileMetadataByPath([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/GetFileByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/GetFileContentByPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/copyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dropbox")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/extractFolderV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }
    }

    public class DropboxTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/triggers/onnewfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnNewFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/triggers/batch/onnewfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = SourceExpressionConverter.ConvertO(maxFileCount);
                return callPayload;
            }

            return new ApiConnectionTrigger<BlobMetadata[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<BlobMetadata[]> OnUpdatedFiles([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> maxFileCount = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(maxFileCount, nameof(maxFileCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/triggers/batch/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["maxFileCount"] = Convert.ToString(10);
                if (maxFileCount != null)
                    callPayload.Queries["maxFileCount"] = SourceExpressionConverter.ConvertO(maxFileCount);
                return callPayload;
            }

            return new ApiConnectionTrigger<BlobMetadata[]>(BuildSourceInput, triggerName, recurrence);
        }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox;

    public partial class WorkflowManagedActions
    {
        public DropboxActions Dropbox(string connectionId) => new DropboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DropboxTriggers Dropbox(string connectionId) => new DropboxTriggers(connectionId);
    }
}