//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmticketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTicket))]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket([WorkflowExpression] Func<int> bodyticketType, [WorkflowExpression] Func<string> bodyticketHeader, [WorkflowExpression] Func<string> bodyticketText, [WorkflowExpression] Func<int> bodyenterpriseId, [WorkflowExpression] Func<int> bodyentranceType, [WorkflowExpression] Func<int> bodyareaId, [WorkflowExpression] Func<bool> bodyreleasedOption, [WorkflowExpression] Func<bool> bodyprivateOption, [WorkflowExpression] Func<bool> bodyinternalOption, [WorkflowExpression] Func<bodyurgencyTypeInput> bodyurgencyType, [WorkflowExpression] Func<bodyeffectsTypeInput> bodyeffectsType, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<int[]> bodyrelatedAssetIds = null, [WorkflowExpression] Func<bodyfieldGroupsInputItem[]> bodyfieldGroups = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodyserviceContractId = null, [WorkflowExpression] Func<int> bodydelegatedTicketEditor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTicketResponse> __BuildCreateTicket(WorkflowValue<int> bodyticketType, WorkflowValue<string> bodyticketHeader, WorkflowValue<string> bodyticketText, WorkflowValue<int> bodyenterpriseId, WorkflowValue<int> bodyentranceType, WorkflowValue<int> bodyareaId, WorkflowValue<bool> bodyreleasedOption, WorkflowValue<bool> bodyprivateOption, WorkflowValue<bool> bodyinternalOption, WorkflowValue<bodyurgencyTypeInput> bodyurgencyType, WorkflowValue<bodyeffectsTypeInput> bodyeffectsType, WorkflowValue<int> bodycontactId = null, WorkflowValue<int[]> bodyrelatedAssetIds = null, WorkflowValue<bodyfieldGroupsInputItem[]> bodyfieldGroups = null, WorkflowValue<string> bodyreferenceNumber = null, WorkflowValue<string> bodytags = null, WorkflowValue<string> bodyprojectId = null, WorkflowValue<int> bodyserviceContractId = null, WorkflowValue<int> bodydelegatedTicketEditor = null)
        {
            WorkflowValue.Validate(bodyticketType, nameof(bodyticketType), required: true);
            WorkflowValue.Validate(bodyticketHeader, nameof(bodyticketHeader), required: true);
            WorkflowValue.Validate(bodyticketText, nameof(bodyticketText), required: true);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            WorkflowValue.Validate(bodyentranceType, nameof(bodyentranceType), required: true);
            WorkflowValue.Validate(bodyareaId, nameof(bodyareaId), required: true);
            WorkflowValue.Validate(bodyreleasedOption, nameof(bodyreleasedOption), required: true);
            WorkflowValue.Validate(bodyprivateOption, nameof(bodyprivateOption), required: true);
            WorkflowValue.Validate(bodyinternalOption, nameof(bodyinternalOption), required: true);
            WorkflowValue.Validate(bodyurgencyType, nameof(bodyurgencyType), required: true);
            WorkflowValue.Validate(bodyeffectsType, nameof(bodyeffectsType), required: true);
            WorkflowValue.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowValue.Validate(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: false);
            WorkflowValue.Validate(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowValue.Validate(bodyserviceContractId, nameof(bodyserviceContractId), required: false);
            WorkflowValue.Validate(bodydelegatedTicketEditor, nameof(bodydelegatedTicketEditor), required: false);
            return new DeferredBodyAction<CreateTicketResponse>(() =>
            {
                var apiCallPath = "/CreateTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ticketType"] = ExpressionConverter.ConvertO(bodyticketType);
                bodypropCount++;
                body["ticketHeader"] = ExpressionConverter.ConvertO(bodyticketHeader);
                bodypropCount++;
                body["ticketText"] = ExpressionConverter.ConvertO(bodyticketText);
                bodypropCount++;
                body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                if (bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(bodycontactId);
                    bodypropCount++;
                }

                if (bodyrelatedAssetIds != null)
                {
                    body["RelatedAssetIds"] = ExpressionConverter.ConvertO(bodyrelatedAssetIds);
                    bodypropCount++;
                }

                if (bodyfieldGroups != null)
                {
                    body["FieldGroups"] = ExpressionConverter.ConvertO(bodyfieldGroups);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["referenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                bodypropCount++;
                body["entranceType"] = ExpressionConverter.ConvertO(bodyentranceType);
                bodypropCount++;
                body["areaId"] = ExpressionConverter.ConvertO(bodyareaId);
                bodypropCount++;
                body["releasedOption"] = ExpressionConverter.ConvertO(bodyreleasedOption);
                bodypropCount++;
                body["privateOption"] = ExpressionConverter.ConvertO(bodyprivateOption);
                bodypropCount++;
                body["internalOption"] = ExpressionConverter.ConvertO(bodyinternalOption);
                bodypropCount++;
                body["urgencyType"] = ExpressionConverter.ConvertO(bodyurgencyType);
                bodypropCount++;
                body["effectsType"] = ExpressionConverter.ConvertO(bodyeffectsType);
                if (bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyserviceContractId != null)
                {
                    body["serviceContractId"] = ExpressionConverter.ConvertO(bodyserviceContractId);
                    bodypropCount++;
                }

                if (bodydelegatedTicketEditor != null)
                {
                    body["delegatedTicketEditor"] = ExpressionConverter.ConvertO(bodydelegatedTicketEditor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTicketPosition))]
        public IBodyWorkflowAction<CreateTicketPositionResponse> CreateTicketPosition([WorkflowExpression] Func<string> bodyreferenceNumber, [WorkflowExpression] Func<string> bodyticketPositionText, [WorkflowExpression] Func<bodyticketPositionTypeInput> bodyticketPositionType, [WorkflowExpression] Func<bodyticketPositionVisibilityInput> bodyticketPositionVisibility, [WorkflowExpression] Func<bodyfieldGroupsInputItem2[]> bodyfieldGroups = null, [WorkflowExpression] Func<string> bodyparkTicketparkUntil = null, [WorkflowExpression] Func<bodyparkTicketparkingReasonInput> bodyparkTicketparkingReason = null, [WorkflowExpression] Func<string> bodyparkTicketparkingPositionText = null, [WorkflowExpression] Func<bodyparkTicketafterParkingActionInput> bodyparkTicketafterParkingAction = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTicketPositionResponse> __BuildCreateTicketPosition(WorkflowValue<string> bodyreferenceNumber, WorkflowValue<string> bodyticketPositionText, WorkflowValue<bodyticketPositionTypeInput> bodyticketPositionType, WorkflowValue<bodyticketPositionVisibilityInput> bodyticketPositionVisibility, WorkflowValue<bodyfieldGroupsInputItem2[]> bodyfieldGroups = null, WorkflowValue<string> bodyparkTicketparkUntil = null, WorkflowValue<bodyparkTicketparkingReasonInput> bodyparkTicketparkingReason = null, WorkflowValue<string> bodyparkTicketparkingPositionText = null, WorkflowValue<bodyparkTicketafterParkingActionInput> bodyparkTicketafterParkingAction = null)
        {
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            WorkflowValue.Validate(bodyticketPositionText, nameof(bodyticketPositionText), required: true);
            WorkflowValue.Validate(bodyticketPositionType, nameof(bodyticketPositionType), required: true);
            WorkflowValue.Validate(bodyticketPositionVisibility, nameof(bodyticketPositionVisibility), required: true);
            WorkflowValue.Validate(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            WorkflowValue.Validate(bodyparkTicketparkUntil, nameof(bodyparkTicketparkUntil), required: false);
            WorkflowValue.Validate(bodyparkTicketparkingReason, nameof(bodyparkTicketparkingReason), required: false);
            WorkflowValue.Validate(bodyparkTicketparkingPositionText, nameof(bodyparkTicketparkingPositionText), required: false);
            WorkflowValue.Validate(bodyparkTicketafterParkingAction, nameof(bodyparkTicketafterParkingAction), required: false);
            return new DeferredBodyAction<CreateTicketPositionResponse>(() =>
            {
                var apiCallPath = "/CreateTicketPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                bodypropCount++;
                body["ticketPositionText"] = ExpressionConverter.ConvertO(bodyticketPositionText);
                bodypropCount++;
                body["TicketPositionType"] = ExpressionConverter.ConvertO(bodyticketPositionType);
                bodypropCount++;
                body["TicketPositionVisibility"] = ExpressionConverter.ConvertO(bodyticketPositionVisibility);
                if (bodyfieldGroups != null)
                {
                    body["FieldGroups"] = ExpressionConverter.ConvertO(bodyfieldGroups);
                    bodypropCount++;
                }

                var parkTicketObject = new JObject();
                var parkTicketObjectpropCount = 0;
                if (bodyparkTicketparkUntil != null)
                {
                    parkTicketObject["ParkUntil"] = ExpressionConverter.ConvertO(bodyparkTicketparkUntil);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketparkingReason != null)
                {
                    parkTicketObject["ParkingReason"] = ExpressionConverter.ConvertO(bodyparkTicketparkingReason);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketparkingPositionText != null)
                {
                    parkTicketObject["ParkingPositionText"] = ExpressionConverter.ConvertO(bodyparkTicketparkingPositionText);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketafterParkingAction != null)
                {
                    parkTicketObject["AfterParkingAction"] = ExpressionConverter.ConvertO(bodyparkTicketafterParkingAction);
                    parkTicketObjectpropCount++;
                }

                if (parkTicketObjectpropCount > 0)
                {
                    body["ParkTicket"] = parkTicketObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTicketPositionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildAddAssetRelation))]
        public IBodyWorkflowAction<AddAssetRelationResponse> AddAssetRelation([WorkflowExpression] Func<string> bodyreferenceNumber, [WorkflowExpression] Func<int[]> bodyrelatedAssetIds)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddAssetRelationResponse> __BuildAddAssetRelation(WorkflowValue<string> bodyreferenceNumber, WorkflowValue<int[]> bodyrelatedAssetIds)
        {
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            WorkflowValue.Validate(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: true);
            return new DeferredBodyAction<AddAssetRelationResponse>(() =>
            {
                var apiCallPath = "/AddAssetRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                bodypropCount++;
                body["RelatedAssetIds"] = ExpressionConverter.ConvertO(bodyrelatedAssetIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddAssetRelationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildGetTicket))]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket([WorkflowExpression] Func<string> bodyreferenceNumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTicketResponse> __BuildGetTicket(WorkflowValue<string> bodyreferenceNumber)
        {
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            return new DeferredBodyAction<GetTicketResponse>(() =>
            {
                var apiCallPath = "/GetTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildSearchTicket))]
        public IBodyWorkflowAction<SearchTicketResponse> SearchTicket([WorkflowExpression] Func<string> bodyreferencenumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchTicketResponse> __BuildSearchTicket(WorkflowValue<string> bodyreferencenumber)
        {
            WorkflowValue.Validate(bodyreferencenumber, nameof(bodyreferencenumber), required: true);
            return new DeferredBodyAction<SearchTicketResponse>(() =>
            {
                var apiCallPath = "/SearchTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referencenumber"] = ExpressionConverter.ConvertO(bodyreferencenumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildSearchTicketbyParameter))]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> SearchTicketbyParameter([WorkflowExpression] Func<string> bodysearchParam, [WorkflowExpression] Func<int> bodytake, [WorkflowExpression] Func<int> bodyskip)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> __BuildSearchTicketbyParameter(WorkflowValue<string> bodysearchParam, WorkflowValue<int> bodytake, WorkflowValue<int> bodyskip)
        {
            WorkflowValue.Validate(bodysearchParam, nameof(bodysearchParam), required: true);
            WorkflowValue.Validate(bodytake, nameof(bodytake), required: true);
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: true);
            return new DeferredBodyAction<SearchTicketbyParameterResponse>(() =>
            {
                var apiCallPath = "/SearchTicketByParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["searchParam"] = ExpressionConverter.ConvertO(bodysearchParam);
                bodypropCount++;
                body["take"] = ExpressionConverter.ConvertO(bodytake);
                bodypropCount++;
                body["skip"] = ExpressionConverter.ConvertO(bodyskip);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchTicketbyParameterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildGetTicketFieldGroupConfig))]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> GetTicketFieldGroupConfig([WorkflowExpression] Func<int> bodyticketTypeId, [WorkflowExpression] Func<string> bodyticketId = null, [WorkflowExpression] Func<string> bodyfieldGroupSettingsId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> __BuildGetTicketFieldGroupConfig(WorkflowValue<int> bodyticketTypeId, WorkflowValue<string> bodyticketId = null, WorkflowValue<string> bodyfieldGroupSettingsId = null)
        {
            WorkflowValue.Validate(bodyticketTypeId, nameof(bodyticketTypeId), required: true);
            WorkflowValue.Validate(bodyticketId, nameof(bodyticketId), required: false);
            WorkflowValue.Validate(bodyfieldGroupSettingsId, nameof(bodyfieldGroupSettingsId), required: false);
            return new DeferredBodyAction<GetTicketFieldGroupConfigResponse>(() =>
            {
                var apiCallPath = "/GetTicketFieldGroupConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TicketTypeId"] = ExpressionConverter.ConvertO(bodyticketTypeId);
                if (bodyticketId != null)
                {
                    body["TicketId"] = ExpressionConverter.ConvertO(bodyticketId);
                    bodypropCount++;
                }

                if (bodyfieldGroupSettingsId != null)
                {
                    body["FieldGroupSettingsId"] = ExpressionConverter.ConvertO(bodyfieldGroupSettingsId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTicketFieldGroupConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllTicketTypes))]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> GetAllTicketTypes([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> __BuildGetAllTicketTypes(WorkflowValue<int> bodyresponseType, WorkflowValue<int> bodypageSize, WorkflowValue<int> bodyskip, WorkflowValue<string> bodysearch = null, WorkflowValue<bool> bodyorderByAsc = null)
        {
            WorkflowValue.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowValue.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowValue.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllTicketTypesResponse>(() =>
            {
                var apiCallPath = "/GetAllTicketTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllTicketTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllAreas))]
        public IBodyWorkflowAction<GetAllAreasResponse> GetAllAreas([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllAreasResponse> __BuildGetAllAreas(WorkflowValue<int> bodyresponseType, WorkflowValue<int> bodypageSize, WorkflowValue<int> bodyskip, WorkflowValue<string> bodysearch = null, WorkflowValue<bool> bodyorderByAsc = null)
        {
            WorkflowValue.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowValue.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowValue.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllAreasResponse>(() =>
            {
                var apiCallPath = "/GetAllAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllAreasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllStartingAreas))]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> GetAllStartingAreas([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> __BuildGetAllStartingAreas(WorkflowValue<int> bodyresponseType, WorkflowValue<int> bodypageSize, WorkflowValue<int> bodyskip, WorkflowValue<string> bodysearch = null, WorkflowValue<bool> bodyorderByAsc = null)
        {
            WorkflowValue.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowValue.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowValue.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllStartingAreasResponse>(() =>
            {
                var apiCallPath = "/GetAllStartAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllStartingAreasResponse>(callPayload);
            });
        }
    }

    public class TesseronasmticketTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateTicketResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string[] TicketNumber { get; set; }
        public string TicketPositionNumber { get; set; }
        public string TicketPositionTextPlain { get; set; }
        public CreateTicketResponseTicketStatusTypeItem[] TicketStatus { get; set; }
    }

    public class CreateTicketResponseTicketStatusTypeItem
    {
        public bool IsParked { get; set; }
        public string ParkedFrom { get; set; }
        public string ParkedUntil { get; set; }
        public string ParkStatusText { get; set; }
    }

    public enum bodyurgencyTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public enum bodyeffectsTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class bodyfieldGroupsInputItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public bodyfieldGroupsInputItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class bodyfieldGroupsInputItemPropertiesTypeItem
    {
        public string TicketFieldSettingsId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTicketPositionResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string[] TicketNumber { get; set; }
        public string TicketPositionNumber { get; set; }
        public CreateTicketPositionResponseTicketStatusTypeItem[] TicketStatus { get; set; }
    }

    public class CreateTicketPositionResponseTicketStatusTypeItem
    {
        public string TicketNumber { get; set; }
        public bool IsParked { get; set; }
        public string ParkedFrom { get; set; }
        public string ParkedUntil { get; set; }
        public string ParkStatusText { get; set; }
    }

    public enum bodyticketPositionTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public enum bodyticketPositionVisibilityInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class bodyfieldGroupsInputItem2
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public bodyfieldGroupsInputItemPropertiesTypeItem2[] Properties { get; set; }
    }

    public class bodyfieldGroupsInputItemPropertiesTypeItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyparkTicketparkingReasonInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public enum bodyparkTicketafterParkingActionInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class AddAssetRelationResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
    }

    public class GetTicketResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string TicketNumber { get; set; }
        public int TicketType { get; set; }
        public string TicketTypeName { get; set; }
        public string TicketHeader { get; set; }
        public string TicketText { get; set; }
        public string ReferenceNumber { get; set; }
        public int EntranceType { get; set; }
        public string EntranceTypeName { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string ProjectId { get; set; }
        public string ProjectPhaseId { get; set; }
        public string ProjectPhaseTaskId { get; set; }
        public string[] Tags { get; set; }
        public bool ReleasedOption { get; set; }
        public bool PrivateOption { get; set; }
        public bool InternalOption { get; set; }
        public int UrgencyType { get; set; }
        public string UrgencyTypeName { get; set; }
        public int EffectsType { get; set; }
        public string EffectsTypeName { get; set; }
        public int ServiceContractId { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public GetTicketResponseFieldGroupsTypeItem[] FieldGroups { get; set; }
    }

    public class GetTicketResponseFieldGroupsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("properties")]
        public GetTicketResponseFieldGroupsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class GetTicketResponseFieldGroupsTypeItemPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchTicketResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string[] TicketNumber { get; set; }
        public string TicketPositionNumber { get; set; }
        public string TicketPositionTextPlain { get; set; }
        public SearchTicketResponseTicketStatusTypeItem[] TicketStatus { get; set; }
    }

    public class SearchTicketResponseTicketStatusTypeItem
    {
        public bool IsParked { get; set; }
        public string ParkedFrom { get; set; }
        public string ParkedUntil { get; set; }
        public string ParkStatusText { get; set; }
    }

    public class SearchTicketbyParameterResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int TicketId { get; set; }
        public string TicketNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string TicketHeader { get; set; }
        public string TicketText { get; set; }
        public string TicketTextPlain { get; set; }
        public string CreationDate { get; set; }
        public string CreationDateText { get; set; }
        public string TicketStatus { get; set; }
    }

    public class GetTicketFieldGroupConfigResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string TicketFieldGroupSettingsId { get; set; }

        [JsonProperty("Group ID")]
        public string GroupID { get; set; }
        public string Name { get; set; }
        public GetTicketFieldGroupConfigResponseFieldsTypeItem[] Fields { get; set; }
    }

    public class GetTicketFieldGroupConfigResponseFieldsTypeItem
    {
        public string TicketFieldSettingsId { get; set; }
        public string Name { get; set; }
        public int FieldType { get; set; }
        public string Value { get; set; }
        public GetTicketFieldGroupConfigResponseFieldsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetTicketFieldGroupConfigResponseFieldsTypeItemOptionsTypeItem
    {
        public string OptionName { get; set; }
        public string Value { get; set; }
    }

    public class GetAllTicketTypesResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public GetAllTicketTypesResponseTicketTypesTypeItem[] TicketTypes { get; set; }
    }

    public class GetAllTicketTypesResponseTicketTypesTypeItem
    {
        public int TicketTypeId { get; set; }

        [JsonProperty("TicketTypeName_en")]
        public string TicketTypeNameEn { get; set; }

        [JsonProperty("TicketTypeName_de")]
        public string TicketTypeNameDe { get; set; }

        [JsonProperty("TicketDescrpition_en")]
        public string TicketDescrpitionEn { get; set; }

        [JsonProperty("TicketDescrpition_de")]
        public string TicketDescrpitionDe { get; set; }
    }

    public class GetAllAreasResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public GetAllAreasResponseAreasTypeItem[] Areas { get; set; }
    }

    public class GetAllAreasResponseAreasTypeItem
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public GetAllAreasResponseAreasTypeItemAreaOptionsTypeItem[] AreaOptions { get; set; }
    }

    public class GetAllAreasResponseAreasTypeItemAreaOptionsTypeItem
    {
        [JsonProperty("TicketTypeName_en")]
        public string TicketTypeNameEn { get; set; }

        [JsonProperty("TicketTypeName_de")]
        public string TicketTypeNameDe { get; set; }

        [JsonProperty("TicketDescrpition_en")]
        public string TicketDescrpitionEn { get; set; }

        [JsonProperty("TicketDescrpition_de")]
        public string TicketDescrpitionDe { get; set; }
    }

    public class GetAllStartingAreasResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public GetAllStartingAreasResponseAreasTypeItem[] Areas { get; set; }
    }

    public class GetAllStartingAreasResponseAreasTypeItem
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public GetAllStartingAreasResponseAreasTypeItemTicketTypesTypeItem[] TicketTypes { get; set; }
    }

    public class GetAllStartingAreasResponseAreasTypeItemTicketTypesTypeItem
    {
        public int TicketTypeId { get; set; }

        [JsonProperty("TicketTypeName_en")]
        public string TicketTypeNameEn { get; set; }

        [JsonProperty("TicketTypeName_de")]
        public string TicketTypeNameDe { get; set; }

        [JsonProperty("TicketDescrpition_en")]
        public string TicketDescrpitionEn { get; set; }

        [JsonProperty("TicketDescrpition_de")]
        public string TicketDescrpitionDe { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket;

    public partial class WorkflowManagedActions
    {
        public TesseronasmticketActions Tesseronasmticket(string connectionId) => new TesseronasmticketActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TesseronasmticketTriggers Tesseronasmticket(string connectionId) => new TesseronasmticketTriggers(connectionId);
    }
}
