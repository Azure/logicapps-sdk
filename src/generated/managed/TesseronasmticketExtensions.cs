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
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket(Expression<Func<int>> bodyticketType, Expression<Func<string>> bodyticketHeader, Expression<Func<string>> bodyticketText, Expression<Func<int>> bodyenterpriseId, Expression<Func<int>> bodyentranceType, Expression<Func<int>> bodyareaId, Expression<Func<bool>> bodyreleasedOption, Expression<Func<bool>> bodyprivateOption, Expression<Func<bool>> bodyinternalOption, Expression<Func<bodyurgencyTypeInput>> bodyurgencyType, Expression<Func<bodyeffectsTypeInput>> bodyeffectsType, Expression<Func<int>> bodycontactId = null, Expression<Func<int[]>> bodyRelatedAssetIds = null, Expression<Func<bodyFieldGroupsInputItem[]>> bodyFieldGroups = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<int>> bodyserviceContractId = null, Expression<Func<int>> bodydelegatedTicketEditor = null)
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

            if (bodyRelatedAssetIds != null)
            {
                body["RelatedAssetIds"] = ExpressionConverter.ConvertO(bodyRelatedAssetIds);
                bodypropCount++;
            }

            if (bodyFieldGroups != null)
            {
                body["FieldGroups"] = ExpressionConverter.ConvertO(bodyFieldGroups);
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
        public IBodyWorkflowAction<CreateTicketPositionResponse> CreateTicketPosition(Expression<Func<string>> bodyreferenceNumber, Expression<Func<string>> bodyticketPositionText, Expression<Func<bodyTicketPositionTypeInput>> bodyTicketPositionType, Expression<Func<bodyTicketPositionVisibilityInput>> bodyTicketPositionVisibility, Expression<Func<bodyFieldGroupsInputItem2[]>> bodyFieldGroups = null, Expression<Func<string>> bodyParkTicketParkUntil = null, Expression<Func<bodyParkTicketParkingReasonInput>> bodyParkTicketParkingReason = null, Expression<Func<string>> bodyParkTicketParkingPositionText = null, Expression<Func<bodyParkTicketAfterParkingActionInput>> bodyParkTicketAfterParkingAction = null)
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
            body["TicketPositionType"] = ExpressionConverter.ConvertO(bodyTicketPositionType);
            bodypropCount++;
            body["TicketPositionVisibility"] = ExpressionConverter.ConvertO(bodyTicketPositionVisibility);
            if (bodyFieldGroups != null)
            {
                body["FieldGroups"] = ExpressionConverter.ConvertO(bodyFieldGroups);
                bodypropCount++;
            }

            var ParkTicketObject = new JObject();
            var ParkTicketObjectpropCount = 0;
            if (bodyParkTicketParkUntil != null)
            {
                ParkTicketObject["ParkUntil"] = ExpressionConverter.ConvertO(bodyParkTicketParkUntil);
                ParkTicketObjectpropCount++;
            }

            if (bodyParkTicketParkingReason != null)
            {
                ParkTicketObject["ParkingReason"] = ExpressionConverter.ConvertO(bodyParkTicketParkingReason);
                ParkTicketObjectpropCount++;
            }

            if (bodyParkTicketParkingPositionText != null)
            {
                ParkTicketObject["ParkingPositionText"] = ExpressionConverter.ConvertO(bodyParkTicketParkingPositionText);
                ParkTicketObjectpropCount++;
            }

            if (bodyParkTicketAfterParkingAction != null)
            {
                ParkTicketObject["AfterParkingAction"] = ExpressionConverter.ConvertO(bodyParkTicketAfterParkingAction);
                ParkTicketObjectpropCount++;
            }

            if (ParkTicketObjectpropCount > 0)
            {
                body["ParkTicket"] = ParkTicketObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTicketPositionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<AddAssetRelationResponse> AddAssetRelation(Expression<Func<string>> bodyreferenceNumber, Expression<Func<int[]>> bodyRelatedAssetIds)
        {
            var apiCallPath = "/AddAssetRelation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["referenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
            bodypropCount++;
            body["RelatedAssetIds"] = ExpressionConverter.ConvertO(bodyRelatedAssetIds);
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
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> GetTicketFieldGroupConfig(Expression<Func<int>> bodyTicketTypeId, Expression<Func<string>> bodyTicketId = null, Expression<Func<string>> bodyFieldGroupSettingsId = null)
        {
            var apiCallPath = "/GetTicketFieldGroupConfig";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["TicketTypeId"] = ExpressionConverter.ConvertO(bodyTicketTypeId);
            if (bodyTicketId != null)
            {
                body["TicketId"] = ExpressionConverter.ConvertO(bodyTicketId);
                bodypropCount++;
            }

            if (bodyFieldGroupSettingsId != null)
            {
                body["FieldGroupSettingsId"] = ExpressionConverter.ConvertO(bodyFieldGroupSettingsId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetTicketFieldGroupConfigResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> GetAllTicketTypes(Expression<Func<int>> bodyResponseType, Expression<Func<int>> bodyPageSize, Expression<Func<int>> bodySkip, Expression<Func<string>> bodySearch = null, Expression<Func<bool>> bodyOrderByAsc = null)
        {
            var apiCallPath = "/GetAllTicketTypes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
            if (bodySearch != null)
            {
                body["Search"] = ExpressionConverter.ConvertO(bodySearch);
                bodypropCount++;
            }

            bodypropCount++;
            body["PageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["Skip"] = ExpressionConverter.ConvertO(bodySkip);
            if (bodyOrderByAsc != null)
            {
                body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyOrderByAsc);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAllTicketTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllAreasResponse> GetAllAreas(Expression<Func<int>> bodyResponseType, Expression<Func<int>> bodyPageSize, Expression<Func<int>> bodySkip, Expression<Func<string>> bodySearch = null, Expression<Func<bool>> bodyOrderByAsc = null)
        {
            var apiCallPath = "/GetAllAreas";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
            if (bodySearch != null)
            {
                body["Search"] = ExpressionConverter.ConvertO(bodySearch);
                bodypropCount++;
            }

            bodypropCount++;
            body["PageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["Skip"] = ExpressionConverter.ConvertO(bodySkip);
            if (bodyOrderByAsc != null)
            {
                body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyOrderByAsc);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAllAreasResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> GetAllStartingAreas(Expression<Func<int>> bodyResponseType, Expression<Func<int>> bodyPageSize, Expression<Func<int>> bodySkip, Expression<Func<string>> bodySearch = null, Expression<Func<bool>> bodyOrderByAsc = null)
        {
            var apiCallPath = "/GetAllStartAreas";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
            if (bodySearch != null)
            {
                body["Search"] = ExpressionConverter.ConvertO(bodySearch);
                bodypropCount++;
            }

            bodypropCount++;
            body["PageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            bodypropCount++;
            body["Skip"] = ExpressionConverter.ConvertO(bodySkip);
            if (bodyOrderByAsc != null)
            {
                body["OrderByAsc"] = ExpressionConverter.ConvertO(bodyOrderByAsc);
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

    public class bodyFieldGroupsInputItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public bodyFieldGroupsInputItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class bodyFieldGroupsInputItemPropertiesTypeItem
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

    public enum bodyTicketPositionTypeInput
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

    public enum bodyTicketPositionVisibilityInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class bodyFieldGroupsInputItem2
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public bodyFieldGroupsInputItemPropertiesTypeItem2[] Properties { get; set; }
    }

    public class bodyFieldGroupsInputItemPropertiesTypeItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyParkTicketParkingReasonInput
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

    public enum bodyParkTicketAfterParkingActionInput
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