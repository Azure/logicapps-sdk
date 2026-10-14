//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatalake
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AzuredatalakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<FolderResponse> ListFiles(Expression<Func<string>> account, Expression<Func<string>> path = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: false);
            return new DeferredBodyAction<FolderResponse>(() =>
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
        public IBodyWorkflowAction<OperationPerformed> CreateFolder(Expression<Func<string>> account, Expression<Func<string>> path)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: true);
            return new DeferredBodyAction<OperationPerformed>(() =>
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
        public IBodyWorkflowAction<string> AppendFileConcurrent(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<appendModeInput>> appendMode = null, Expression<Func<string>> body = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_filepath = filepath == null ? null : WorkflowExpression.Compile(filepath);
            WorkflowExpression.Validate(__workflow_filepath, nameof(filepath), required: true);
            var __workflow_appendMode = appendMode == null ? null : WorkflowExpression.Compile(appendMode);
            WorkflowExpression.Validate(__workflow_appendMode, nameof(appendMode), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfsext/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_filepath, 1));
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
        public IBodyWorkflowAction<string> ReadFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_filepath = filepath == null ? null : WorkflowExpression.Compile(filepath);
            WorkflowExpression.Validate(__workflow_filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_filepath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                callPayload.Queries["op"] = Convert.ToString("OPEN");
                callPayload.Queries["read"] = Convert.ToString("true");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction UploadFile(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<bool>> overwrite = null, Expression<Func<string>> body = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_filepath = filepath == null ? null : WorkflowExpression.Compile(filepath);
            WorkflowExpression.Validate(__workflow_filepath, nameof(filepath), required: true);
            var __workflow_overwrite = overwrite == null ? null : WorkflowExpression.Compile(overwrite);
            WorkflowExpression.Validate(__workflow_overwrite, nameof(overwrite), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_filepath, 1));
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
        public IWorkflowAction AppendFileSequential(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<string>> body = null, Expression<Func<int>> offset = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_filepath = filepath == null ? null : WorkflowExpression.Compile(filepath);
            WorkflowExpression.Validate(__workflow_filepath, nameof(filepath), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_filepath, 1));
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
        public IBodyWorkflowAction<OperationPerformed> DeleteFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_filepath = filepath == null ? null : WorkflowExpression.Compile(filepath);
            WorkflowExpression.Validate(__workflow_filepath, nameof(filepath), required: true);
            return new DeferredBodyAction<OperationPerformed>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_filepath, 1));
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
