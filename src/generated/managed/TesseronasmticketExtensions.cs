//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmticketActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<int>> bodyticketType, Expression<Func<string>> bodyticketHeader, Expression<Func<string>> bodyticketText, Expression<Func<int>> bodyenterpriseId, Expression<Func<int>> bodyentranceType, Expression<Func<int>> bodyareaId, Expression<Func<bool>> bodyreleasedOption, Expression<Func<bool>> bodyprivateOption, Expression<Func<bool>> bodyinternalOption, Expression<Func<bodyurgencyTypeInput>> bodyurgencyType, Expression<Func<bodyeffectsTypeInput>> bodyeffectsType, Expression<Func<int>> bodycontactId = null, Expression<Func<int[]>> bodyrelatedAssetIds = null, Expression<Func<bodyfieldGroupsInputItem[]>> bodyfieldGroups = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodyserviceContractId = null, Expression<Func<int>> bodydelegatedTicketEditor = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketPositionResponse> CreateTicketPosition(Expression<Func<string>> bodyreferenceNumber, Expression<Func<string>> bodyticketPositionText, Expression<Func<bodyticketPositionTypeInput>> bodyticketPositionType, Expression<Func<bodyticketPositionVisibilityInput>> bodyticketPositionVisibility, Expression<Func<bodyfieldGroupsInputItem2[]>> bodyfieldGroups = null, Expression<Func<string>> bodyparkTicketparkUntil = null, Expression<Func<bodyparkTicketparkingReasonInput>> bodyparkTicketparkingReason = null, Expression<Func<string>> bodyparkTicketparkingPositionText = null, Expression<Func<bodyparkTicketafterParkingActionInput>> bodyparkTicketafterParkingAction = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<AddAssetRelationResponse> AddAssetRelation(Expression<Func<string>> bodyreferenceNumber, Expression<Func<int[]>> bodyrelatedAssetIds)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket(Expression<Func<string>> bodyreferenceNumber)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketResponse> SearchTicket(Expression<Func<string>> bodyreferencenumber)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> SearchTicketbyParameter(Expression<Func<string>> bodysearchParam, Expression<Func<int>> bodytake, Expression<Func<int>> bodyskip)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> GetTicketFieldGroupConfig(Expression<Func<int>> bodyticketTypeId, Expression<Func<string>> bodyticketId = null, Expression<Func<string>> bodyfieldGroupSettingsId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> GetAllTicketTypes(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllAreasResponse> GetAllAreas(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> GetAllStartingAreas(Expression<Func<int>> bodyresponseType, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyskip, Expression<Func<string>> bodysearch = null, Expression<Func<bool>> bodyorderByAsc = null)
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