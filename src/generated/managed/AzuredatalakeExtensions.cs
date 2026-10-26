//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatalake
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatalakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<FolderResponse, ApiConnectionActionConfiguration> ListFiles(Expression<Func<string>> account, Expression<Func<string>> path = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            return new DeferredBodyAction<FolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("LISTSTATUS");
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<FolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed, ApiConnectionActionConfiguration> CreateFolder(Expression<Func<string>> account, Expression<Func<string>> path)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<OperationPerformed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("MKDIRS");
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                return new ApiConnectionAction<OperationPerformed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AppendFileConcurrent(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<string>> body, Expression<Func<appendModeInput>> appendMode = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_filepath = WorkflowExpression.Compile(filepath, nameof(filepath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_appendMode = WorkflowExpression.Compile(appendMode, nameof(appendMode), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhdfsext/{0}", __workflow_filepath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("concurrentappend");
                callPayload.Queries["appendMode"] = Convert.ToString("autocreate");
                if (__workflow_appendMode != null)
                    callPayload.Queries["appendMode"] = ExpressionConverter.Convert(__workflow_appendMode);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReadFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_filepath = WorkflowExpression.Compile(filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhdfs/v1/{0}", __workflow_filepath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("OPEN");
                callPayload.Queries["read"] = Convert.ToString("true");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<string>> body, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_filepath = WorkflowExpression.Compile(filepath, nameof(filepath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhdfs/v1/{0}", __workflow_filepath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("CREATE");
                callPayload.Queries["write"] = Convert.ToString("true");
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendFileSequential(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<string>> body, Expression<Func<int>> offset = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_filepath = WorkflowExpression.Compile(filepath, nameof(filepath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhdfs/v1/{0}", __workflow_filepath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("APPEND");
                callPayload.Queries["append"] = Convert.ToString("true");
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed, ApiConnectionActionConfiguration> DeleteFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_filepath = WorkflowExpression.Compile(filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<OperationPerformed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhdfs/v1/{0}", __workflow_filepath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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