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
        public IBodyWorkflowAction<AddItemResponse> AddItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<object> bodydata = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydata != null)
                {
                    body["Data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<DeleteItemResponse> DeleteItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UpdateItemResponse> UpdateItem([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyrowVersion = null, [WorkflowExpression] Func<object> bodydata = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyrowVersion, nameof(bodyrowVersion), required: false);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrowVersion != null)
                {
                    body["RowVersion"] = SourceExpressionConverter.ConvertToken(bodyrowVersion);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["Data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetListFieldsResponse> GetListFields([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                return callPayload;
            }

            return new ApiConnectionAction<GetListFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<StartWorkflowResponse> StartWorkflow([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> bodyapplicantID = null, [WorkflowExpression] Func<object> bodyvariables = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(bodyapplicantID, nameof(bodyapplicantID), required: false);
            SourceExpression.Validate(bodyvariables, nameof(bodyvariables), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflow/forms/start";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantID != null)
                {
                    body["ApplicantID"] = SourceExpressionConverter.ConvertToken(bodyapplicantID);
                    bodypropCount++;
                }

                if (bodyvariables != null)
                {
                    body["Variables"] = SourceExpressionConverter.ConvertToken(bodyvariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StartWorkflowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetAgentDefinitionResponse> GetAgentDefinition([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> agentID)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(agentID, nameof(agentID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/agents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(agentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                return callPayload;
            }

            return new ApiConnectionAction<GetAgentDefinitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<RunAgentResponse> RunAgent([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> agentID, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(agentID, nameof(agentID), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/agents/{0}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(agentID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<RunAgentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<QueryItemsResponse> QueryItems([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string[]> bodyfields = null, [WorkflowExpression] Func<ListDataWhereRequest[]> bodyfilters = null, [WorkflowExpression] Func<bodysortsInputItem[]> bodysorts = null, [WorkflowExpression] Func<int> bodypageNumber = null, [WorkflowExpression] Func<int> bodypageSize = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: false);
            SourceExpression.Validate(bodysorts, nameof(bodysorts), required: false);
            SourceExpression.Validate(bodypageNumber, nameof(bodypageNumber), required: false);
            SourceExpression.Validate(bodypageSize, nameof(bodypageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/query", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfields != null)
                {
                    body["Fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodyfilters != null)
                {
                    body["Filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                    bodypropCount++;
                }

                if (bodysorts != null)
                {
                    body["Sorts"] = SourceExpressionConverter.ConvertToken(bodysorts);
                    bodypropCount++;
                }

                if (bodypageNumber != null)
                {
                    if (bodypageNumber != null)
                    {
                        body["PageIndex"] = SourceExpressionConverter.ConvertToken(bodypageNumber);
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
                        body["PageSize"] = SourceExpressionConverter.ConvertToken(bodypageSize);
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
                return callPayload;
            }

            return new ApiConnectionAction<QueryItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddItemFileResponse> AddItemFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fieldID = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(fieldID, nameof(fieldID), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/items/{1}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                if (fieldID != null)
                    callPayload.Queries["FieldID"] = SourceExpressionConverter.ConvertO(fieldID);
                callPayload.Queries["FileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<AddItemFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<UploadFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<GetFilePropertyResponse> GetFileProperty([WorkflowExpression] Func<string> fieldValue = null)
        {
            SourceExpression.Validate(fieldValue, nameof(fieldValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/files/properties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fieldValue);
                return callPayload;
            }

            return new ApiConnectionAction<GetFilePropertyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<AddLibraryFileResponse> AddLibraryFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> path = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(path, nameof(path), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/library", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                if (path != null)
                    callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["FileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<AddLibraryFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yeeflow")]
        public IBodyWorkflowAction<string> GetLibraryFile([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/library/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class YeeflowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> OnItemCreated([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/1", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemModified([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemCreatedModified([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/3", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> OnItemDeleted([WorkflowExpression] Func<string> application, [WorkflowExpression] Func<string> listID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(application, nameof(application), required: true);
            SourceExpression.Validate(listID, nameof(listID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/41/{0}/hooks/4", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["application"] = SourceExpressionConverter.ConvertO(application);
                callPayload.Queries["channel"] = Convert.ToString("ms-power");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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