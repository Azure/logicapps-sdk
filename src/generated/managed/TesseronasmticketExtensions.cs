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
        public IBodyWorkflowAction<CreateTicketResponse, ApiConnectionActionConfiguration> CreateTicket(Expression<Func<CreateTicketInput>> body)
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
        public IBodyWorkflowAction<CreateTicketPositionResponse, ApiConnectionActionConfiguration> CreateTicketPosition(Expression<Func<CreateTicketPositionInput>> body)
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
        public IBodyWorkflowAction<AddAssetRelationResponse, ApiConnectionActionConfiguration> AddAssetRelation(Expression<Func<AddAssetRelationInput>> body)
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
        public IBodyWorkflowAction<GetTicketResponse, ApiConnectionActionConfiguration> GetTicket(Expression<Func<GetTicketInput>> body)
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
        public IBodyWorkflowAction<SearchTicketResponse, ApiConnectionActionConfiguration> SearchTicket(Expression<Func<SearchTicketInput>> body)
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
        public IBodyWorkflowAction<SearchTicketbyParameterResponse, ApiConnectionActionConfiguration> SearchTicketbyParameter(Expression<Func<SearchTicketbyParameterInput>> body)
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
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse, ApiConnectionActionConfiguration> GetTicketFieldGroupConfig(Expression<Func<GetTicketFieldGroupConfigInput>> body)
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
        public IBodyWorkflowAction<GetAllTicketTypesResponse, ApiConnectionActionConfiguration> GetAllTicketTypes(Expression<Func<GetAllTicketTypesInput>> body)
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
        public IBodyWorkflowAction<GetAllAreasResponse, ApiConnectionActionConfiguration> GetAllAreas(Expression<Func<GetAllAreasInput>> body)
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
        public IBodyWorkflowAction<GetAllStartingAreasResponse, ApiConnectionActionConfiguration> GetAllStartingAreas(Expression<Func<GetAllStartingAreasInput>> body)
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

    public class CreateTicketInput
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
        public CreateTicketInputFieldGroupsTypeItem[] FieldGroups { get; set; }

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
        public CreateTicketInputUrgencyTypeType UrgencyType { get; set; } = CreateTicketInputUrgencyTypeType._1;

        [JsonProperty("effectsType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTicketInputEffectsTypeType EffectsType { get; set; } = CreateTicketInputEffectsTypeType._1;

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("serviceContractId")]
        public int? ServiceContractId { get; set; }

        [JsonProperty("delegatedTicketEditor")]
        public int? DelegatedTicketEditor { get; set; }
    }

    public class CreateTicketInputFieldGroupsTypeItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public CreateTicketInputFieldGroupsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateTicketInputFieldGroupsTypeItemPropertiesTypeItem
    {
        public string TicketFieldSettingsId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum CreateTicketInputUrgencyTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum CreateTicketInputEffectsTypeType
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

    public class CreateTicketPositionInput
    {
        [JsonProperty("referenceNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReferenceNumber { get; set; }

        [JsonProperty("ticketPositionText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketPositionText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTicketPositionInputTicketPositionTypeType TicketPositionType { get; set; } = CreateTicketPositionInputTicketPositionTypeType._0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTicketPositionInputTicketPositionVisibilityType TicketPositionVisibility { get; set; } = CreateTicketPositionInputTicketPositionVisibilityType._0;
        public CreateTicketPositionInputFieldGroupsTypeItem[] FieldGroups { get; set; }
        public CreateTicketPositionInputParkTicketType ParkTicket { get; set; }
    }

    public enum CreateTicketPositionInputTicketPositionTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum CreateTicketPositionInputTicketPositionVisibilityType
    {
        _0 = 0,
        _1 = 1
    }

    public class CreateTicketPositionInputFieldGroupsTypeItem
    {
        public string TicketFieldGroupSettingsId { get; set; }
        public string TicketFieldGroupId { get; set; }

        [JsonProperty("properties")]
        public CreateTicketPositionInputFieldGroupsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class CreateTicketPositionInputFieldGroupsTypeItemPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateTicketPositionInputParkTicketType
    {
        public string ParkUntil { get; set; }
        public CreateTicketPositionInputParkTicketTypeParkingReasonType? ParkingReason { get; set; }
        public string ParkingPositionText { get; set; }
        public CreateTicketPositionInputParkTicketTypeAfterParkingActionType? AfterParkingAction { get; set; }
    }

    public enum CreateTicketPositionInputParkTicketTypeParkingReasonType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum CreateTicketPositionInputParkTicketTypeAfterParkingActionType
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

    public class AddAssetRelationInput
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

    public class GetTicketInput
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

    public class SearchTicketInput
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

    public class SearchTicketbyParameterInput
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

    public class GetTicketFieldGroupConfigInput
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

    public class GetAllTicketTypesInput
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

    public class GetAllAreasInput
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

    public class GetAllStartingAreasInput
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