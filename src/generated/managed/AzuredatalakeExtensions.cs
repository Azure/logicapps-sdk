//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredatalake
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredatalakeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<FolderResponse> ListFiles([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> path = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("LISTSTATUS");
                if (path != null)
                    callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<FolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed> CreateFolder([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> path)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/store/folders/webhdfs/v1/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("MKDIRS");
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<OperationPerformed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string> AppendFileConcurrent([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<appendModeInput> appendMode = null, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhdfsext/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("concurrentappend");
                callPayload.Queries["appendMode"] = Convert.ToString("autocreate");
                if (appendMode != null)
                    callPayload.Queries["appendMode"] = SourceExpressionConverter.Convert(appendMode);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<string> ReadFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("OPEN");
                callPayload.Queries["read"] = Convert.ToString("true");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction UploadFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<bool> overwrite = null, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("CREATE");
                callPayload.Queries["write"] = Convert.ToString("true");
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IWorkflowAction AppendFileSequential([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("APPEND");
                callPayload.Queries["append"] = Convert.ToString("true");
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredatalake")]
        public IBodyWorkflowAction<OperationPerformed> DeleteFile([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> filepath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhdfs/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filepath, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = SourceExpressionConverter.ConvertO(account);
                callPayload.Queries["op"] = Convert.ToString("DELETE");
                return callPayload;
            }

            return new ApiConnectionAction<OperationPerformed>(BuildSourceInput);
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