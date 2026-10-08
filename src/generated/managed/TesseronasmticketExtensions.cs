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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTicketResponse> __BuildCreateTicket(WorkflowExpression<int> bodyticketType, WorkflowExpression<string> bodyticketHeader, WorkflowExpression<string> bodyticketText, WorkflowExpression<int> bodyenterpriseId, WorkflowExpression<int> bodyentranceType, WorkflowExpression<int> bodyareaId, WorkflowExpression<bool> bodyreleasedOption, WorkflowExpression<bool> bodyprivateOption, WorkflowExpression<bool> bodyinternalOption, WorkflowExpression<bodyurgencyTypeInput> bodyurgencyType, WorkflowExpression<bodyeffectsTypeInput> bodyeffectsType, WorkflowExpression<int> bodycontactId = null, WorkflowExpression<int[]> bodyrelatedAssetIds = null, WorkflowExpression<bodyfieldGroupsInputItem[]> bodyfieldGroups = null, WorkflowExpression<string> bodyreferenceNumber = null, WorkflowExpression<string> bodytags = null, WorkflowExpression<string> bodyprojectId = null, WorkflowExpression<int> bodyserviceContractId = null, WorkflowExpression<int> bodydelegatedTicketEditor = null)
        {
            WorkflowExpression.Validate(bodyticketType, nameof(bodyticketType), required: true);
            WorkflowExpression.Validate(bodyticketHeader, nameof(bodyticketHeader), required: true);
            WorkflowExpression.Validate(bodyticketText, nameof(bodyticketText), required: true);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            WorkflowExpression.Validate(bodyentranceType, nameof(bodyentranceType), required: true);
            WorkflowExpression.Validate(bodyareaId, nameof(bodyareaId), required: true);
            WorkflowExpression.Validate(bodyreleasedOption, nameof(bodyreleasedOption), required: true);
            WorkflowExpression.Validate(bodyprivateOption, nameof(bodyprivateOption), required: true);
            WorkflowExpression.Validate(bodyinternalOption, nameof(bodyinternalOption), required: true);
            WorkflowExpression.Validate(bodyurgencyType, nameof(bodyurgencyType), required: true);
            WorkflowExpression.Validate(bodyeffectsType, nameof(bodyeffectsType), required: true);
            WorkflowExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowExpression.Validate(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: false);
            WorkflowExpression.Validate(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            WorkflowExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowExpression.Validate(bodyserviceContractId, nameof(bodyserviceContractId), required: false);
            WorkflowExpression.Validate(bodydelegatedTicketEditor, nameof(bodydelegatedTicketEditor), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTicketPositionResponse> __BuildCreateTicketPosition(WorkflowExpression<string> bodyreferenceNumber, WorkflowExpression<string> bodyticketPositionText, WorkflowExpression<bodyticketPositionTypeInput> bodyticketPositionType, WorkflowExpression<bodyticketPositionVisibilityInput> bodyticketPositionVisibility, WorkflowExpression<bodyfieldGroupsInputItem2[]> bodyfieldGroups = null, WorkflowExpression<string> bodyparkTicketparkUntil = null, WorkflowExpression<bodyparkTicketparkingReasonInput> bodyparkTicketparkingReason = null, WorkflowExpression<string> bodyparkTicketparkingPositionText = null, WorkflowExpression<bodyparkTicketafterParkingActionInput> bodyparkTicketafterParkingAction = null)
        {
            WorkflowExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            WorkflowExpression.Validate(bodyticketPositionText, nameof(bodyticketPositionText), required: true);
            WorkflowExpression.Validate(bodyticketPositionType, nameof(bodyticketPositionType), required: true);
            WorkflowExpression.Validate(bodyticketPositionVisibility, nameof(bodyticketPositionVisibility), required: true);
            WorkflowExpression.Validate(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            WorkflowExpression.Validate(bodyparkTicketparkUntil, nameof(bodyparkTicketparkUntil), required: false);
            WorkflowExpression.Validate(bodyparkTicketparkingReason, nameof(bodyparkTicketparkingReason), required: false);
            WorkflowExpression.Validate(bodyparkTicketparkingPositionText, nameof(bodyparkTicketparkingPositionText), required: false);
            WorkflowExpression.Validate(bodyparkTicketafterParkingAction, nameof(bodyparkTicketafterParkingAction), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddAssetRelationResponse> __BuildAddAssetRelation(WorkflowExpression<string> bodyreferenceNumber, WorkflowExpression<int[]> bodyrelatedAssetIds)
        {
            WorkflowExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            WorkflowExpression.Validate(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTicketResponse> __BuildGetTicket(WorkflowExpression<string> bodyreferenceNumber)
        {
            WorkflowExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchTicketResponse> __BuildSearchTicket(WorkflowExpression<string> bodyreferencenumber)
        {
            WorkflowExpression.Validate(bodyreferencenumber, nameof(bodyreferencenumber), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> __BuildSearchTicketbyParameter(WorkflowExpression<string> bodysearchParam, WorkflowExpression<int> bodytake, WorkflowExpression<int> bodyskip)
        {
            WorkflowExpression.Validate(bodysearchParam, nameof(bodysearchParam), required: true);
            WorkflowExpression.Validate(bodytake, nameof(bodytake), required: true);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> __BuildGetTicketFieldGroupConfig(WorkflowExpression<int> bodyticketTypeId, WorkflowExpression<string> bodyticketId = null, WorkflowExpression<string> bodyfieldGroupSettingsId = null)
        {
            WorkflowExpression.Validate(bodyticketTypeId, nameof(bodyticketTypeId), required: true);
            WorkflowExpression.Validate(bodyticketId, nameof(bodyticketId), required: false);
            WorkflowExpression.Validate(bodyfieldGroupSettingsId, nameof(bodyfieldGroupSettingsId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> __BuildGetAllTicketTypes(WorkflowExpression<int> bodyresponseType, WorkflowExpression<int> bodypageSize, WorkflowExpression<int> bodyskip, WorkflowExpression<string> bodysearch = null, WorkflowExpression<bool> bodyorderByAsc = null)
        {
            WorkflowExpression.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowExpression.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowExpression.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllAreasResponse> __BuildGetAllAreas(WorkflowExpression<int> bodyresponseType, WorkflowExpression<int> bodypageSize, WorkflowExpression<int> bodyskip, WorkflowExpression<string> bodysearch = null, WorkflowExpression<bool> bodyorderByAsc = null)
        {
            WorkflowExpression.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowExpression.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowExpression.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> __BuildGetAllStartingAreas(WorkflowExpression<int> bodyresponseType, WorkflowExpression<int> bodypageSize, WorkflowExpression<int> bodyskip, WorkflowExpression<string> bodysearch = null, WorkflowExpression<bool> bodyorderByAsc = null)
        {
            WorkflowExpression.Validate(bodyresponseType, nameof(bodyresponseType), required: true);
            WorkflowExpression.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowExpression.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowExpression.Validate(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyurgencyTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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