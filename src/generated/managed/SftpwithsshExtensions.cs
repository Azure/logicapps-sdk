//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sftpwithssh
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SftpwithsshActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> UpdateFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = SourceExpressionConverter.ConvertO(readFileMetadataFromServer);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> skipDeleteIfFileNotFoundOnServer = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(skipDeleteIfFileNotFoundOnServer, nameof(skipDeleteIfFileNotFoundOnServer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = Convert.ToString(false);
                if (skipDeleteIfFileNotFoundOnServer != null)
                    callPayload.Headers["SkipDeleteIfFileNotFoundOnServer"] = SourceExpressionConverter.ConvertO(skipDeleteIfFileNotFoundOnServer);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> CreateFile([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = SourceExpressionConverter.ConvertO(readFileMetadataFromServer);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadataResponse> RenameFile([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> newName, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(newName, nameof(newName), required: true);
            SourceExpression.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/default/files/{0}/rename", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["newName"] = SourceExpressionConverter.ConvertO(newName);
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = SourceExpressionConverter.ConvertO(readFileMetadataFromServer);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null, [WorkflowExpression] Func<bool> readFileMetadataFromServer = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            SourceExpression.Validate(readFileMetadataFromServer, nameof(readFileMetadataFromServer), required: false);
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
                callPayload.Headers["ReadFileMetadataFromServer"] = Convert.ToString(true);
                if (readFileMetadataFromServer != null)
                    callPayload.Headers["ReadFileMetadataFromServer"] = SourceExpressionConverter.ConvertO(readFileMetadataFromServer);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
        public IBodyWorkflowAction<BlobMetadata> CreateFolder([WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sftpwithssh")]
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

    public class SftpwithsshTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> includeFileContent = null, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(includeFileContent, nameof(includeFileContent), required: false);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/default/triggers/onupdatedfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                if (includeFileContent != null)
                    callPayload.Queries["includeFileContent"] = SourceExpressionConverter.ConvertO(includeFileContent);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
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
                callPayload.Queries["checkBothCreatedAndModifiedDateTime"] = Convert.ToString(false);
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

    public class BlobMetadataResponse
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sftpwithssh;

    public partial class WorkflowManagedActions
    {
        public SftpwithsshActions Sftpwithssh(string connectionId) => new SftpwithsshActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SftpwithsshTriggers Sftpwithssh(string connectionId) => new SftpwithsshTriggers(connectionId);
    }
}