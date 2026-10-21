//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmticketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<int>> bodyticketType, Expression<Func<string>> bodyticketHeader, Expression<Func<string>> bodyticketText, Expression<Func<int>> bodyenterpriseId, Expression<Func<int>> bodyentranceType, Expression<Func<int>> bodyareaId, Expression<Func<bool>> bodyreleasedOption, Expression<Func<bool>> bodyprivateOption, Expression<Func<bool>> bodyinternalOption, Expression<Func<bodyurgencyTypeInput>> bodyurgencyType, Expression<Func<bodyeffectsTypeInput>> bodyeffectsType, Expression<Func<int>> bodycontactId = null, Expression<Func<int[]>> bodyrelatedAssetIds = null, Expression<Func<bodyfieldGroupsInputItem[]>> bodyfieldGroups = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodyserviceContractId = null, Expression<Func<int>> bodydelegatedTicketEditor = null)
        {
            var __workflow_bodyticketType = WorkflowExpression.Compile(bodyticketType, nameof(bodyticketType), required: true);
            var __workflow_bodyticketHeader = WorkflowExpression.Compile(bodyticketHeader, nameof(bodyticketHeader), required: true);
            var __workflow_bodyticketText = WorkflowExpression.Compile(bodyticketText, nameof(bodyticketText), required: true);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            var __workflow_bodyentranceType = WorkflowExpression.Compile(bodyentranceType, nameof(bodyentranceType), required: true);
            var __workflow_bodyareaId = WorkflowExpression.Compile(bodyareaId, nameof(bodyareaId), required: true);
            var __workflow_bodyreleasedOption = WorkflowExpression.Compile(bodyreleasedOption, nameof(bodyreleasedOption), required: true);
            var __workflow_bodyprivateOption = WorkflowExpression.Compile(bodyprivateOption, nameof(bodyprivateOption), required: true);
            var __workflow_bodyinternalOption = WorkflowExpression.Compile(bodyinternalOption, nameof(bodyinternalOption), required: true);
            var __workflow_bodyurgencyType = WorkflowExpression.Compile(bodyurgencyType, nameof(bodyurgencyType), required: true);
            var __workflow_bodyeffectsType = WorkflowExpression.Compile(bodyeffectsType, nameof(bodyeffectsType), required: true);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodyrelatedAssetIds = WorkflowExpression.Compile(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: false);
            var __workflow_bodyfieldGroups = WorkflowExpression.Compile(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodyserviceContractId = WorkflowExpression.Compile(bodyserviceContractId, nameof(bodyserviceContractId), required: false);
            var __workflow_bodydelegatedTicketEditor = WorkflowExpression.Compile(bodydelegatedTicketEditor, nameof(bodydelegatedTicketEditor), required: false);
            return new DeferredBodyAction<CreateTicketResponse>(() =>
            {
                var apiCallPath = "/CreateTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ticketType"] = ExpressionConverter.ConvertO(__workflow_bodyticketType);
                bodypropCount++;
                body["ticketHeader"] = ExpressionConverter.ConvertO(__workflow_bodyticketHeader);
                bodypropCount++;
                body["ticketText"] = ExpressionConverter.ConvertO(__workflow_bodyticketText);
                bodypropCount++;
                body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                if (__workflow_bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedAssetIds != null)
                {
                    body["RelatedAssetIds"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedAssetIds);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldGroups != null)
                {
                    body["FieldGroups"] = ExpressionConverter.ConvertO(__workflow_bodyfieldGroups);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceNumber != null)
                {
                    body["referenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                bodypropCount++;
                body["entranceType"] = ExpressionConverter.ConvertO(__workflow_bodyentranceType);
                bodypropCount++;
                body["areaId"] = ExpressionConverter.ConvertO(__workflow_bodyareaId);
                bodypropCount++;
                body["releasedOption"] = ExpressionConverter.ConvertO(__workflow_bodyreleasedOption);
                bodypropCount++;
                body["privateOption"] = ExpressionConverter.ConvertO(__workflow_bodyprivateOption);
                bodypropCount++;
                body["internalOption"] = ExpressionConverter.ConvertO(__workflow_bodyinternalOption);
                bodypropCount++;
                body["urgencyType"] = ExpressionConverter.ConvertO(__workflow_bodyurgencyType);
                bodypropCount++;
                body["effectsType"] = ExpressionConverter.ConvertO(__workflow_bodyeffectsType);
                if (__workflow_bodyprojectId != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceContractId != null)
                {
                    body["serviceContractId"] = ExpressionConverter.ConvertO(__workflow_bodyserviceContractId);
                    bodypropCount++;
                }

                if (__workflow_bodydelegatedTicketEditor != null)
                {
                    body["delegatedTicketEditor"] = ExpressionConverter.ConvertO(__workflow_bodydelegatedTicketEditor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTicketResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketPositionResponse> CreateTicketPosition(Expression<Func<string>> bodyreferenceNumber, Expression<Func<string>> bodyticketPositionText, Expression<Func<bodyticketPositionTypeInput>> bodyticketPositionType, Expression<Func<bodyticketPositionVisibilityInput>> bodyticketPositionVisibility, Expression<Func<bodyfieldGroupsInputItem2[]>> bodyfieldGroups = null, Expression<Func<string>> bodyparkTicketparkUntil = null, Expression<Func<bodyparkTicketparkingReasonInput>> bodyparkTicketparkingReason = null, Expression<Func<string>> bodyparkTicketparkingPositionText = null, Expression<Func<bodyparkTicketafterParkingActionInput>> bodyparkTicketafterParkingAction = null)
        {
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            var __workflow_bodyticketPositionText = WorkflowExpression.Compile(bodyticketPositionText, nameof(bodyticketPositionText), required: true);
            var __workflow_bodyticketPositionType = WorkflowExpression.Compile(bodyticketPositionType, nameof(bodyticketPositionType), required: true);
            var __workflow_bodyticketPositionVisibility = WorkflowExpression.Compile(bodyticketPositionVisibility, nameof(bodyticketPositionVisibility), required: true);
            var __workflow_bodyfieldGroups = WorkflowExpression.Compile(bodyfieldGroups, nameof(bodyfieldGroups), required: false);
            var __workflow_bodyparkTicketparkUntil = WorkflowExpression.Compile(bodyparkTicketparkUntil, nameof(bodyparkTicketparkUntil), required: false);
            var __workflow_bodyparkTicketparkingReason = WorkflowExpression.Compile(bodyparkTicketparkingReason, nameof(bodyparkTicketparkingReason), required: false);
            var __workflow_bodyparkTicketparkingPositionText = WorkflowExpression.Compile(bodyparkTicketparkingPositionText, nameof(bodyparkTicketparkingPositionText), required: false);
            var __workflow_bodyparkTicketafterParkingAction = WorkflowExpression.Compile(bodyparkTicketafterParkingAction, nameof(bodyparkTicketafterParkingAction), required: false);
            return new DeferredBodyAction<CreateTicketPositionResponse>(() =>
            {
                var apiCallPath = "/CreateTicketPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                bodypropCount++;
                body["ticketPositionText"] = ExpressionConverter.ConvertO(__workflow_bodyticketPositionText);
                bodypropCount++;
                body["TicketPositionType"] = ExpressionConverter.ConvertO(__workflow_bodyticketPositionType);
                bodypropCount++;
                body["TicketPositionVisibility"] = ExpressionConverter.ConvertO(__workflow_bodyticketPositionVisibility);
                if (__workflow_bodyfieldGroups != null)
                {
                    body["FieldGroups"] = ExpressionConverter.ConvertO(__workflow_bodyfieldGroups);
                    bodypropCount++;
                }

                var parkTicketObject = new JObject();
                var parkTicketObjectpropCount = 0;
                if (__workflow_bodyparkTicketparkUntil != null)
                {
                    parkTicketObject["ParkUntil"] = ExpressionConverter.ConvertO(__workflow_bodyparkTicketparkUntil);
                    parkTicketObjectpropCount++;
                }

                if (__workflow_bodyparkTicketparkingReason != null)
                {
                    parkTicketObject["ParkingReason"] = ExpressionConverter.ConvertO(__workflow_bodyparkTicketparkingReason);
                    parkTicketObjectpropCount++;
                }

                if (__workflow_bodyparkTicketparkingPositionText != null)
                {
                    parkTicketObject["ParkingPositionText"] = ExpressionConverter.ConvertO(__workflow_bodyparkTicketparkingPositionText);
                    parkTicketObjectpropCount++;
                }

                if (__workflow_bodyparkTicketafterParkingAction != null)
                {
                    parkTicketObject["AfterParkingAction"] = ExpressionConverter.ConvertO(__workflow_bodyparkTicketafterParkingAction);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<AddAssetRelationResponse> AddAssetRelation(Expression<Func<string>> bodyreferenceNumber, Expression<Func<int[]>> bodyrelatedAssetIds)
        {
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            var __workflow_bodyrelatedAssetIds = WorkflowExpression.Compile(bodyrelatedAssetIds, nameof(bodyrelatedAssetIds), required: true);
            return new DeferredBodyAction<AddAssetRelationResponse>(() =>
            {
                var apiCallPath = "/AddAssetRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                bodypropCount++;
                body["RelatedAssetIds"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedAssetIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddAssetRelationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket(Expression<Func<string>> bodyreferenceNumber)
        {
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: true);
            return new DeferredBodyAction<GetTicketResponse>(() =>
            {
                var apiCallPath = "/GetTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTicketResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketResponse> SearchTicket(Expression<Func<string>> bodyreferencenumber)
        {
            var __workflow_bodyreferencenumber = WorkflowExpression.Compile(bodyreferencenumber, nameof(bodyreferencenumber), required: true);
            return new DeferredBodyAction<SearchTicketResponse>(() =>
            {
                var apiCallPath = "/SearchTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referencenumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferencenumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchTicketResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> SearchTicketbyParameter(Expression<Func<string>> bodysearchParam, Expression<Func<int>> bodytake, Expression<Func<int>> bodyskip)
        {
            var __workflow_bodysearchParam = WorkflowExpression.Compile(bodysearchParam, nameof(bodysearchParam), required: true);
            var __workflow_bodytake = WorkflowExpression.Compile(bodytake, nameof(bodytake), required: true);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            return new DeferredBodyAction<SearchTicketbyParameterResponse>(() =>
            {
                var apiCallPath = "/SearchTicketByParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["searchParam"] = ExpressionConverter.ConvertO(__workflow_bodysearchParam);
                bodypropCount++;
                body["take"] = ExpressionConverter.ConvertO(__workflow_bodytake);
                bodypropCount++;
                body["skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchTicketbyParameterResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> GetTicketFieldGroupConfig(Expression<Func<int>> bodyticketTypeId, Expression<Func<string>> bodyticketId = null, Expression<Func<string>> bodyfieldGroupSettingsId = null)
        {
            var __workflow_bodyticketTypeId = WorkflowExpression.Compile(bodyticketTypeId, nameof(bodyticketTypeId), required: true);
            var __workflow_bodyticketId = WorkflowExpression.Compile(bodyticketId, nameof(bodyticketId), required: false);
            var __workflow_bodyfieldGroupSettingsId = WorkflowExpression.Compile(bodyfieldGroupSettingsId, nameof(bodyfieldGroupSettingsId), required: false);
            return new DeferredBodyAction<GetTicketFieldGroupConfigResponse>(() =>
            {
                var apiCallPath = "/GetTicketFieldGroupConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TicketTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyticketTypeId);
                if (__workflow_bodyticketId != null)
                {
                    body["TicketId"] = ExpressionConverter.ConvertO(__workflow_bodyticketId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldGroupSettingsId != null)
                {
                    body["FieldGroupSettingsId"] = ExpressionConverter.ConvertO(__workflow_bodyfieldGroupSettingsId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTicketFieldGroupConfigResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> GetAllTicketTypes(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
        {
            var __workflow_bodyresponseType = WorkflowExpression.Compile(bodyresponseType, nameof(bodyresponseType), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: false);
            var __workflow_bodyorderByAsc = WorkflowExpression.Compile(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllTicketTypesResponse>(() =>
            {
                var apiCallPath = "/GetAllTicketTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
                if (__workflow_bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                if (__workflow_bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(__workflow_bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllTicketTypesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllAreasResponse> GetAllAreas(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
        {
            var __workflow_bodyresponseType = WorkflowExpression.Compile(bodyresponseType, nameof(bodyresponseType), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: false);
            var __workflow_bodyorderByAsc = WorkflowExpression.Compile(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllAreasResponse>(() =>
            {
                var apiCallPath = "/GetAllAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
                if (__workflow_bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                if (__workflow_bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(__workflow_bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllAreasResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> GetAllStartingAreas(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
        {
            var __workflow_bodyresponseType = WorkflowExpression.Compile(bodyresponseType, nameof(bodyresponseType), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: false);
            var __workflow_bodyorderByAsc = WorkflowExpression.Compile(bodyorderByAsc, nameof(bodyorderByAsc), required: false);
            return new DeferredBodyAction<GetAllStartingAreasResponse>(() =>
            {
                var apiCallPath = "/GetAllStartAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
                if (__workflow_bodysearch != null)
                {
                    body["Search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                if (__workflow_bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = ExpressionConverter.ConvertO(__workflow_bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAllStartingAreasResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
