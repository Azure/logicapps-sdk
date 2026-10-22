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
        public IBodyWorkflowAction<AddItemResponse, ApiConnectionActionConfiguration> AddItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<object>> bodydata = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<AddItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydata != null)
                {
                    body["Data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetItemResponse, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<DeleteItemResponse, ApiConnectionActionConfiguration> DeleteItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<DeleteItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UpdateItemResponse, ApiConnectionActionConfiguration> UpdateItem(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id, Expression<Func<int>> bodyrowVersion = null, Expression<Func<object>> bodydata = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyrowVersion = WorkflowExpression.Compile(bodyrowVersion, nameof(bodyrowVersion), required: false);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: false);
            return new DeferredBodyAction<UpdateItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}", __workflow_listID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrowVersion != null)
                {
                    body["RowVersion"] = ExpressionConverter.ConvertO(__workflow_bodyrowVersion);
                    bodypropCount++;
                }

                if (__workflow_bodydata != null)
                {
                    body["Data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetListFieldsResponse, ApiConnectionActionConfiguration> GetListFields(Expression<Func<string>> application, Expression<Func<string>> listID)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            return new DeferredBodyAction<GetListFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/fields", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetListFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<StartWorkflowResponse, ApiConnectionActionConfiguration> StartWorkflow(Expression<Func<string>> application, Expression<Func<string>> key, Expression<Func<string>> bodyapplicantID = null, Expression<Func<object>> bodyvariables = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_bodyapplicantID = WorkflowExpression.Compile(bodyapplicantID, nameof(bodyapplicantID), required: false);
            var __workflow_bodyvariables = WorkflowExpression.Compile(bodyvariables, nameof(bodyvariables), required: false);
            return new DeferredBodyAction<StartWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflow/forms/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyapplicantID != null)
                {
                    body["ApplicantID"] = ExpressionConverter.ConvertO(__workflow_bodyapplicantID);
                    bodypropCount++;
                }

                if (__workflow_bodyvariables != null)
                {
                    body["Variables"] = ExpressionConverter.ConvertO(__workflow_bodyvariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetAgentDefinitionResponse, ApiConnectionActionConfiguration> GetAgentDefinition(Expression<Func<string>> application, Expression<Func<string>> agentID)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_agentID = WorkflowExpression.Compile(agentID, nameof(agentID), required: true);
            return new DeferredBodyAction<GetAgentDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}", __workflow_agentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<GetAgentDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<RunAgentResponse, ApiConnectionActionConfiguration> RunAgent(Expression<Func<string>> application, Expression<Func<string>> agentID, Expression<Func<object>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_agentID = WorkflowExpression.Compile(agentID, nameof(agentID), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RunAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/run", __workflow_agentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RunAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<QueryItemsResponse, ApiConnectionActionConfiguration> QueryItems(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string[]>> bodyfields = null, Expression<Func<ListDataWhereRequest[]>> bodyfilters = null, Expression<Func<bodysortsInputItem[]>> bodysorts = null, Expression<Func<int>> bodypageNumber = null, Expression<Func<int>> bodypageSize = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: false);
            var __workflow_bodysorts = WorkflowExpression.Compile(bodysorts, nameof(bodysorts), required: false);
            var __workflow_bodypageNumber = WorkflowExpression.Compile(bodypageNumber, nameof(bodypageNumber), required: false);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: false);
            return new DeferredBodyAction<QueryItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/query", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfields != null)
                {
                    body["Fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (__workflow_bodyfilters != null)
                {
                    body["Filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
                    bodypropCount++;
                }

                if (__workflow_bodysorts != null)
                {
                    body["Sorts"] = ExpressionConverter.ConvertO(__workflow_bodysorts);
                    bodypropCount++;
                }

                if (__workflow_bodypageNumber != null)
                {
                    if (__workflow_bodypageNumber != null)
                    {
                        body["PageIndex"] = ExpressionConverter.ConvertO(__workflow_bodypageNumber);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["PageIndex"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodypageSize != null)
                {
                    if (__workflow_bodypageSize != null)
                    {
                        body["PageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemFileResponse, ApiConnectionActionConfiguration> AddItemFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id, Expression<Func<string>> fileName, Expression<Func<string>> fieldID = null, Expression<Func<string>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_fieldID = WorkflowExpression.Compile(fieldID, nameof(fieldID), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddItemFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/items/{1}/files", __workflow_listID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                if (__workflow_fieldID != null)
                    callPayload.Queries["FieldID"] = ExpressionConverter.Convert(__workflow_fieldID);
                callPayload.Queries["FileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddItemFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UploadFileResponse, ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> fileName, Expression<Func<string>> body = null)
        {
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
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
        public IBodyWorkflowAction<AddLibraryFileResponse, ApiConnectionActionConfiguration> AddLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> fileName, Expression<Func<string>> path = null, Expression<Func<string>> body = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddLibraryFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/library", __workflow_listID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetLibraryFile(Expression<Func<string>> application, Expression<Func<string>> listID, Expression<Func<string>> id)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/library/{1}/content", __workflow_listID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class YeeflowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemCreated(Expression<Func<string>> application, Expression<Func<string>> listID, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/1", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemModified(Expression<Func<string>> application, Expression<Func<string>> listID, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/2", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemCreatedModified(Expression<Func<string>> application, Expression<Func<string>> listID, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/3", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnItemDeleted(Expression<Func<string>> application, Expression<Func<string>> listID, FlowRecurrence recurrence = null)
        {
            var __workflow_application = WorkflowExpression.Compile(application, nameof(application), required: true);
            var __workflow_listID = WorkflowExpression.Compile(listID, nameof(listID), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/41/{0}/hooks/4", __workflow_listID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = ExpressionConverter.Convert(__workflow_application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
