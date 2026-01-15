//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Azuredatalake
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatalakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<FolderResponse> ListFiles(Expression<Func<string>> account, Expression<Func<string>> path = null)
        {
            var apiCallPath = "/store/folders/webhdfs/v1/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("LISTSTATUS");
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<FolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed> CreateFolder(Expression<Func<string>> account, Expression<Func<string>> path)
        {
            var apiCallPath = "/store/folders/webhdfs/v1/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("MKDIRS");
            callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            return new ApiConnectionAction<OperationPerformed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string> AppendFileConcurrent(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<appendModeInput>> appendMode = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/webhdfsext/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("concurrentappend");
            callPayload.Queries["appendMode"] = Convert.ToString("autocreate");
            if (appendMode != null)
                callPayload.Queries["appendMode"] = ExpressionConverter.Convert(appendMode);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string> ReadFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var apiCallPath = String.Format("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("OPEN");
            callPayload.Queries["read"] = Convert.ToString("true");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction UploadFile(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<bool>> overwrite = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction AppendFileSequential(Expression<Func<string>> account, Expression<Func<string>> filepath, Expression<Func<string>> body = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("APPEND");
            callPayload.Queries["append"] = Convert.ToString("true");
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed> DeleteFile(Expression<Func<string>> account, Expression<Func<string>> filepath)
        {
            var apiCallPath = String.Format("/webhdfs/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(filepath, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            callPayload.Queries["op"] = Convert.ToString("DELETE");
            return new ApiConnectionAction<OperationPerformed>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Azuredatalake;

    public partial class WorkflowManagedActions
    {
        public AzuredatalakeActions Azuredatalake(string connectionId) => new AzuredatalakeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredatalakeTriggers Azuredatalake(string connectionId) => new AzuredatalakeTriggers(connectionId);
    }
}