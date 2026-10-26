//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yeeflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YeeflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemResponse, ApiConnectionActionConfiguration> AddItem(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<AddItemInput>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetItemResponse, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<DeleteItemResponse, ApiConnectionActionConfiguration> DeleteItem(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeleteItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UpdateItemResponse, ApiConnectionActionConfiguration> UpdateItem(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> id, Expression<Func<UpdateItemInput>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetListFieldsResponse, ApiConnectionActionConfiguration> GetListFields(Expression<Func<string>> application, Expression<Func<string>> listId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<GetListFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/fields", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetListFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<StartWorkflowResponse, ApiConnectionActionConfiguration> StartWorkflow(Expression<Func<string>> application, Expression<Func<string>> key, Expression<Func<StartWorkflowInput>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StartWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflow/forms/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetAgentDefinitionResponse, ApiConnectionActionConfiguration> GetAgentDefinition(Expression<Func<string>> application, Expression<Func<string>> agentId)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            return new DeferredBodyAction<GetAgentDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}", __workflow_agentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetAgentDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<RunAgentResponse, ApiConnectionActionConfiguration> RunAgent(Expression<Func<string>> application, Expression<Func<string>> agentId, Expression<Func<object>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/run", __workflow_agentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<QueryItemsResponse, ApiConnectionActionConfiguration> QueryItems(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<QueryItemsInput>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QueryItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/query", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QueryItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemFileResponse, ApiConnectionActionConfiguration> AddItemFile(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> id, Expression<Func<string>> fileName, Expression<Func<string>> body, Expression<Func<string>> fieldId = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: false);
            return new DeferredBodyAction<AddItemFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}/files", __workflow_listId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_fieldId != null)
                    callPayload.Queries["FieldID"] = ExpressionConverter.Convert(__workflow_fieldId);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddItemFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UploadFileResponse, ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> fileName, Expression<Func<string>> body)
        {
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetFilePropertyResponse, ApiConnectionActionConfiguration> GetFileProperty(Expression<Func<string>> fieldValue = null)
        {
            var __workflow_fieldValue = WorkflowExpression.Compile(fieldValue, nameof(fieldValue), required: false);
            return new DeferredBodyAction<GetFilePropertyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/files/properties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fieldValue != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValue);
                return new ApiConnectionAction<GetFilePropertyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileContent(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}/content", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddLibraryFileResponse, ApiConnectionActionConfiguration> AddLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> fileName, Expression<Func<string>> body, Expression<Func<string>> path = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            return new DeferredBodyAction<AddLibraryFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/library", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddLibraryFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/library/{1}/content", __workflow_listId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class YeeflowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemCreated(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<OnItemCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/1", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemModified(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<OnItemModifiedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/2", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemCreatedModified(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<OnItemCreatedModifiedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/3", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemDeleted(Expression<Func<string>> application, Expression<Func<string>> listId, Expression<Func<OnItemDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/4", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddItemResponse
    {
        [JsonProperty("Data")]
        public string ItemId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class AddItemInput
    {
        public JToken Data { get; set; }
    }

    public class GetItemResponse
    {
        public JToken Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class DeleteItemResponse
    {
        [JsonProperty("Data")]
        public string ItemId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateItemResponse
    {
        [JsonProperty("Data")]
        public string ItemId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateItemInput
    {
        public int? RowVersion { get; set; }
        public JToken Data { get; set; }
    }

    public class GetListFieldsResponse
    {
        public GetListFieldsResponseDataTypeItem[] Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class GetListFieldsResponseDataTypeItem
    {
        [JsonProperty("FieldID")]
        public string FieldId { get; set; }
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string InternalName { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
        public string Rules { get; set; }
        public bool IsSort { get; set; }
        public bool IsIndex { get; set; }
        public bool IsSystem { get; set; }
        public bool IsUnique { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }

    public class StartWorkflowResponse
    {
        public StartWorkflowResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class StartWorkflowResponseDataType
    {
        [JsonProperty("ApplicationID")]
        public string ApplicationId { get; set; }
        public string FlowNo { get; set; }
    }

    public class StartWorkflowInput
    {
        [JsonProperty("ApplicantID")]
        public string ApplicantId { get; set; }
        public JToken Variables { get; set; }
    }

    public class GetAgentDefinitionResponse
    {
        public GetAgentDefinitionResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class GetAgentDefinitionResponseDataType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GetAgentDefinitionResponseDataTypeInputVariablesTypeItem[] InputVariables { get; set; }
        public GetAgentDefinitionResponseDataTypeOutputVariablesTypeItem[] OutputVariables { get; set; }
    }

    public class GetAgentDefinitionResponseDataTypeInputVariablesTypeItem
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class GetAgentDefinitionResponseDataTypeOutputVariablesTypeItem
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class RunAgentResponse
    {
        public JToken Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class QueryItemsResponse
    {
        [JsonProperty("Data")]
        public JToken[] Items { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public int TotalCount { get; set; }
    }

    public class QueryItemsInput
    {
        public string[] Fields { get; set; }
        public ListDataWhereRequest[] Filters { get; set; }
        public QueryItemsInputSortsTypeItem[] Sorts { get; set; }

        [JsonProperty("PageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PageNumber { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PageSize { get; set; } = 10;
    }

    public class ListDataWhereRequest
    {
        public string Field { get; set; }
        public string Value { get; set; }

        [JsonProperty("Type")]
        public int FilterType { get; set; }
        public ListDataWhereRequestPreType Pre { get; set; }
        public ListDataWhereRequest[] Child { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListDataWhereRequestPreType
    {
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or
    }

    public class QueryItemsInputSortsTypeItem
    {
        public string Field { get; set; }

        [JsonProperty("Desc")]
        public bool? IsDescending { get; set; }
    }

    public class AddItemFileResponse
    {
        [JsonProperty("Data")]
        public string ItemId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UploadFileResponse
    {
        public UploadFileResponseDataType Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UploadFileResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }
    }

    public class GetFilePropertyResponse
    {
        [JsonProperty("Data")]
        public GetFilePropertyResponseFilePropertiesTypeItem[] FileProperties { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class GetFilePropertyResponseFilePropertiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }
    }

    public class AddLibraryFileResponse
    {
        [JsonProperty("Data")]
        public string ItemId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class OnItemCreatedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnItemModifiedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnItemCreatedModifiedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class OnItemDeletedInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yeeflow;

    public partial class WorkflowManagedActions
    {
        public YeeflowActions Yeeflow(string connectionId) => new YeeflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YeeflowTriggers Yeeflow(string connectionId) => new YeeflowTriggers(connectionId);
    }
}