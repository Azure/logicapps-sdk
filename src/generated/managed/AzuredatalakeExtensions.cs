//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatalake
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatalakeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildListFiles))]
        public IBodyWorkflowAction<FolderResponse> ListFiles([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> path = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderResponse> __BuildListFiles(WorkflowExpression<string> account, WorkflowExpression<string> path = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(path, nameof(path), required: false);
            return new DeferredBodyAction<FolderResponse>(() =>
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("LISTSTATUS");
                if (path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<FolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<OperationPerformed> CreateFolder([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> path)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationPerformed> __BuildCreateFolder(WorkflowExpression<string> account, WorkflowExpression<string> path)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(path, nameof(path), required: true);
            return new DeferredBodyAction<OperationPerformed>(() =>
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("MKDIRS");
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
                return new ApiConnectionAction<OperationPerformed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildAppendFileConcurrent))]
        public IBodyWorkflowAction<string> AppendFileConcurrent([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<appendModeInput> appendMode = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAppendFileConcurrent(WorkflowExpression<string> account, WorkflowExpression<string> filepath, WorkflowExpression<appendModeInput> appendMode = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(filepath, nameof(filepath), required: true);
            WorkflowExpression.Validate(appendMode, nameof(appendMode), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfsext/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("concurrentappend");
                callPayload.Queries["appendMode"] = Convert.ToString("autocreate");
                if (appendMode != null)
                    callPayload.Queries["appendMode"] = ExpressionConverter.Convert(appendMode);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildReadFile))]
        public IBodyWorkflowAction<string> ReadFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReadFile(WorkflowExpression<string> account, WorkflowExpression<string> filepath)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("OPEN");
                callPayload.Queries["read"] = Convert.ToString("true");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IWorkflowAction UploadFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<bool> overwrite = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadFile(WorkflowExpression<string> account, WorkflowExpression<string> filepath, WorkflowExpression<bool> overwrite = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(filepath, nameof(filepath), required: true);
            WorkflowExpression.Validate(overwrite, nameof(overwrite), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("CREATE");
                callPayload.Queries["write"] = Convert.ToString("true");
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(overwrite);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildAppendFileSequential))]
        public IWorkflowAction AppendFileSequential([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAppendFileSequential(WorkflowExpression<string> account, WorkflowExpression<string> filepath, WorkflowExpression<string> body = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(filepath, nameof(filepath), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("APPEND");
                callPayload.Queries["append"] = Convert.ToString("true");
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFile))]
        public IBodyWorkflowAction<OperationPerformed> DeleteFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationPerformed> __BuildDeleteFile(WorkflowExpression<string> account, WorkflowExpression<string> filepath)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<OperationPerformed>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                callPayload.Queries["op"] = Convert.ToString("DELETE");
                return new ApiConnectionAction<OperationPerformed>(callPayload);
            });
        }
    }

    public class AzuredatalakeTriggers([ConnectionName] string connectionId)
    {
    }

    public class FolderResponse
    {
        public FolderResponseFileStatusesType FileStatuses { get; set; }
    }

    public class FolderResponseFileStatusesType
    {
        public FileStatusArrayItem[] FileStatus { get; set; }
    }

    public class FileStatusArrayItem
    {
        [JsonProperty("pathSuffix")]
        public string FileName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("blockSize")]
        public int BlockSize { get; set; }

        [JsonProperty("accessTime")]
        public int AccessTime { get; set; }

        [JsonProperty("modificationTime")]
        public int ModificationTime { get; set; }
    }

    public class OperationPerformed
    {
        [JsonProperty("boolean")]
        public bool IsSuccessful { get; set; }
    }

    public enum appendModeInput
    {
        [EnumMember(Value = "autocreate")]
        Autocreate,
        [EnumMember(Value = "")]
        None
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatalake;

    public partial class WorkflowManagedActions
    {
        public AzuredatalakeActions Azuredatalake(string connectionId) => new AzuredatalakeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredatalakeTriggers Azuredatalake(string connectionId) => new AzuredatalakeTriggers(connectionId);
    }
}