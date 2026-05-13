//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yeeflow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YeeflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemResponse> AddItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<object>> bodydata = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydata != null)
            {
                body["Data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetItemResponse> GetItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<GetItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<DeleteItemResponse> DeleteItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<DeleteItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UpdateItemResponse> UpdateItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id, Expression<Func<int>> bodyrowVersion = null, Expression<Func<object>> bodydata = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrowVersion != null)
            {
                body["RowVersion"] = ExpressionConverter.ConvertO(bodyrowVersion);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["Data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetListFieldsResponse> GetListFields(Expression<Func<string>> application, Expression<Func<string>> listID)
        {
            var apiCallPath = String.Format("/lists/41/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<GetListFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<StartWorkflowResponse> StartWorkflow(Expression<Func<string>> application, Expression<Func<string>> key, Expression<Func<string>> bodyapplicantID = null, Expression<Func<object>> bodyvariables = null)
        {
            var apiCallPath = "/workflow/forms/start";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyapplicantID != null)
            {
                body["ApplicantID"] = ExpressionConverter.ConvertO(bodyapplicantID);
                bodypropCount++;
            }

            if (bodyvariables != null)
            {
                body["Variables"] = ExpressionConverter.ConvertO(bodyvariables);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StartWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetAgentDefinitionResponse> GetAgentDefinition(Expression<Func<string>> application, Expression<Func<string>> agentID)
        {
            var apiCallPath = String.Format("/agents/{0}", ExpressionConverter.ConvertWithUrlEncoding(agentID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<GetAgentDefinitionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<RunAgentResponse> RunAgent(Expression<Func<string>> application, Expression<Func<string>> agentID, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/agents/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(agentID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<RunAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<QueryItemsResponse> QueryItems(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string[]>> bodyfields = null, Expression<Func<ListDataWhereRequest[]>> bodyfilters = null, Expression<Func<bodysortsInputItem[]>> bodysorts = null, Expression<Func<int>> bodypageNumber = null, Expression<Func<int>> bodypageSize = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items/query", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfields != null)
            {
                body["Fields"] = ExpressionConverter.ConvertO(bodyfields);
                bodypropCount++;
            }

            if (bodyfilters != null)
            {
                body["Filters"] = ExpressionConverter.ConvertO(bodyfilters);
                bodypropCount++;
            }

            if (bodysorts != null)
            {
                body["Sorts"] = ExpressionConverter.ConvertO(bodysorts);
                bodypropCount++;
            }

            if (bodypageNumber != null)
            {
                if (bodypageNumber != null)
                {
                    body["PageIndex"] = ExpressionConverter.ConvertO(bodypageNumber);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["PageIndex"] = 1;
                bodypropCount++;
            }

            if (bodypageSize != null)
            {
                if (bodypageSize != null)
                {
                    body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["PageSize"] = 10;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemFileResponse> AddItemFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id, Expression<Func<string>> fileName, Expression<Func<string>> fieldID = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/items/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (fieldID != null)
                callPayload.Queries["FieldID"] = ExpressionConverter.Convert(fieldID);
            callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<AddItemFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile(Expression<Func<string>> fileName, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<UploadFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetFilePropertyResponse> GetFileProperty(Expression<Func<string>> fieldValue = null)
        {
            var apiCallPath = "/files/properties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(fieldValue);
            return new ApiConnectionAction<GetFilePropertyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/files/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddLibraryFileResponse> AddLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> fileName, Expression<Func<string>> path = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/library", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            callPayload.Queries["FileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<AddLibraryFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string> GetLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/41/{0}/library/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(listID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class YeeflowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> OnItemCreated(Expression<Func<string>> application, Expression<Func<string>> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/hooks/1", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Queries["channel"] = Convert.ToString("ms-power");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemModified(Expression<Func<string>> application, Expression<Func<string>> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/hooks/2", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Queries["channel"] = Convert.ToString("ms-power");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemCreatedModified(Expression<Func<string>> application, Expression<Func<string>> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/hooks/3", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Queries["channel"] = Convert.ToString("ms-power");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemDeleted(Expression<Func<string>> application, Expression<Func<string>> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/lists/41/{0}/hooks/4", ExpressionConverter.ConvertWithUrlEncoding(listID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["application"] = ExpressionConverter.Convert(application);
            callPayload.Queries["channel"] = Convert.ToString("ms-power");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
    }

    public class AddItemResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
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
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateItemResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
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
        public string FieldID { get; set; }
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
        public string ApplicationID { get; set; }
        public string FlowNo { get; set; }
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

    public class ListDataWhereRequest
    {
        public string Field { get; set; }
        public string Value { get; set; }

        [JsonProperty("Type")]
        public int FilterType { get; set; }
        public ListDataWhereRequestPreType Pre { get; set; }
        public ListDataWhereRequest[] Child { get; set; }
    }

    public enum ListDataWhereRequestPreType
    {
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or
    }

    public class bodysortsInputItem
    {
        public string Field { get; set; }

        [JsonProperty("Desc")]
        public bool IsDescending { get; set; }
    }

    public class AddItemFileResponse
    {
        [JsonProperty("Data")]
        public string ItemID { get; set; }
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
        public string ItemID { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
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