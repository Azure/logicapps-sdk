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
        public IBodyWorkflowAction<CreateTicketResponse, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<CreateTicketBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketPositionResponse, ApiConnectionActionConfiguration> CreateTicketPosition(Expression<Func<CreateTicketPositionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTicketPositionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateTicketPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTicketPositionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<AddAssetRelationResponse, ApiConnectionActionConfiguration> AddAssetRelation(Expression<Func<AddAssetRelationBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddAssetRelationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddAssetRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddAssetRelationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketResponse, ApiConnectionActionConfiguration> GetTicket(Expression<Func<GetTicketBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketResponse, ApiConnectionActionConfiguration> SearchTicket(Expression<Func<SearchTicketBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse, ApiConnectionActionConfiguration> SearchTicketbyParameter(Expression<Func<SearchTicketbyParameterBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchTicketbyParameterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SearchTicketByParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchTicketbyParameterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse, ApiConnectionActionConfiguration> GetTicketFieldGroupConfig(Expression<Func<GetTicketFieldGroupConfigBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTicketFieldGroupConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTicketFieldGroupConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTicketFieldGroupConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllTicketTypesResponse, ApiConnectionActionConfiguration> GetAllTicketTypes(Expression<Func<GetAllAreasBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAllTicketTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetAllTicketTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAllTicketTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllAreasResponse, ApiConnectionActionConfiguration> GetAllAreas(Expression<Func<GetAllAreasBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAllAreasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetAllAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAllAreasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllStartingAreasResponse, ApiConnectionActionConfiguration> GetAllStartingAreas(Expression<Func<GetAllAreasBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAllStartingAreasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetAllStartAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateTicketBodyInput
    {
        [JsonProperty("ticketType", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TicketType { get; set; } = 1;

        [JsonProperty("ticketHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketHeader { get; set; }

        [JsonProperty("ticketText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketText { get; set; }

        [JsonProperty("enterpriseId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EnterpriseId { get; set; }

        [JsonProperty("contactId")]
        public int? ContactId { get; set; }
        public int[] RelatedAssetIds { get; set; }
        public CreateTicketBodyInputFieldGroupsTypeItem[] FieldGroups { get; set; }

        [JsonProperty("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("entranceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntranceType { get; set; }

        [JsonProperty("areaId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int AreaId { get; set; }

        [JsonProperty("releasedOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ReleasedOption { get; set; } = true;

        [JsonProperty("privateOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PrivateOption { get; set; } = false;

        [JsonProperty("internalOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool InternalOption { get; set; } = false;

        [JsonProperty("urgencyType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputUrgencyTypeType UrgencyType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket.BodyInputUrgencyTypeType._1;

        [JsonProperty("effectsType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEffectsTypeType EffectsType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket.BodyInputEffectsTypeType._1;

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("serviceContractId")]
        public int? ServiceContractId { get; set; }

        [JsonProperty("delegatedTicketEditor")]
        public int? DelegatedTicketEditor { get; set; }
    }

    public class CreateTicketBodyInputFieldGroupsTypeItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public CreateTicketBodyInputFieldGroupsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateTicketBodyInputFieldGroupsTypeItemPropertiesTypeItem
    {
        public string TicketFieldSettingsId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum BodyInputUrgencyTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum BodyInputEffectsTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
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

    public class CreateTicketPositionBodyInput
    {
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceNumber { get; set; }

        [JsonProperty("ticketPositionText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketPositionText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTicketPositionTypeType TicketPositionType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket.BodyInputTicketPositionTypeType._0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTicketPositionVisibilityType TicketPositionVisibility { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmticket.BodyInputTicketPositionVisibilityType._0;
        public CreateTicketPositionBodyInputFieldGroupsTypeItem[] FieldGroups { get; set; }
        public BodyInputParkTicketType ParkTicket { get; set; }
    }

    public enum BodyInputTicketPositionTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum BodyInputTicketPositionVisibilityType
    {
        _0 = 0,
        _1 = 1
    }

    public class CreateTicketPositionBodyInputFieldGroupsTypeItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public CreateTicketPositionBodyInputFieldGroupsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateTicketPositionBodyInputFieldGroupsTypeItemPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputParkTicketType
    {
        public string ParkUntil { get; set; }
        public BodyInputParkTicketTypeParkingReasonType? ParkingReason { get; set; }
        public string ParkingPositionText { get; set; }
        public BodyInputParkTicketTypeAfterParkingActionType? AfterParkingAction { get; set; }
    }

    public enum BodyInputParkTicketTypeParkingReasonType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum BodyInputParkTicketTypeAfterParkingActionType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class AddAssetRelationResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
    }

    public class AddAssetRelationBodyInput
    {
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] RelatedAssetIds { get; set; }
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

    public class GetTicketBodyInput
    {
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceNumber { get; set; }
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

    public class SearchTicketBodyInput
    {
        [JsonProperty("referencenumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Referencenumber { get; set; }
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

    public class SearchTicketbyParameterBodyInput
    {
        [JsonProperty("searchParam", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchParam { get; set; }

        [JsonProperty("take", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Take { get; set; }

        [JsonProperty("skip", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Skip { get; set; }
    }

    public class GetTicketFieldGroupConfigResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string TicketFieldGroupSettingsId { get; set; }

        [JsonProperty("Group ID")]
        public string GroupId { get; set; }
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

    public class GetTicketFieldGroupConfigBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TicketTypeId { get; set; }
        public string TicketId { get; set; }
        public string FieldGroupSettingsId { get; set; }
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

    public class GetAllAreasBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ResponseType { get; set; }
        public string Search { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Skip { get; set; }
        public bool? OrderByAsc { get; set; }
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