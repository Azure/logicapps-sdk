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
        public IBodyWorkflowAction<CreateTicketResponse> CreateTicket([WorkflowExpression] Func<int> bodyticketType, [WorkflowExpression] Func<string> bodyticketHeader, [WorkflowExpression] Func<string> bodyticketText, [WorkflowExpression] Func<int> bodyenterpriseId, [WorkflowExpression] Func<int> bodyentranceType, [WorkflowExpression] Func<int> bodyareaId, [WorkflowExpression] Func<bool> bodyreleasedOption, [WorkflowExpression] Func<bool> bodyprivateOption, [WorkflowExpression] Func<bool> bodyinternalOption, [WorkflowExpression] Func<bodyurgencyTypeInput> bodyurgencyType, [WorkflowExpression] Func<bodyeffectsTypeInput> bodyeffectsType, [WorkflowExpression] Func<int> bodycontactId = null, [WorkflowExpression] Func<int[]> bodyrelatedAssetIds = null, [WorkflowExpression] Func<bodyfieldGroupsInputItem[]> bodyfieldGroups = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<int> bodyserviceContractId = null, [WorkflowExpression] Func<int> bodydelegatedTicketEditor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ticketType"] = SourceExpressionConverter.ConvertToken(bodyticketType);
                bodypropCount++;
                body["ticketHeader"] = SourceExpressionConverter.ConvertToken(bodyticketHeader);
                bodypropCount++;
                body["ticketText"] = SourceExpressionConverter.ConvertToken(bodyticketText);
                bodypropCount++;
                body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                if (bodycontactId != null)
                {
                    body["contactId"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                if (bodyrelatedAssetIds != null)
                {
                    body["RelatedAssetIds"] = SourceExpressionConverter.ConvertToken(bodyrelatedAssetIds);
                    bodypropCount++;
                }

                if (bodyfieldGroups != null)
                {
                    body["FieldGroups"] = SourceExpressionConverter.ConvertToken(bodyfieldGroups);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["referenceNumber"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                bodypropCount++;
                body["entranceType"] = SourceExpressionConverter.ConvertToken(bodyentranceType);
                bodypropCount++;
                body["areaId"] = SourceExpressionConverter.ConvertToken(bodyareaId);
                bodypropCount++;
                body["releasedOption"] = SourceExpressionConverter.ConvertToken(bodyreleasedOption);
                bodypropCount++;
                body["privateOption"] = SourceExpressionConverter.ConvertToken(bodyprivateOption);
                bodypropCount++;
                body["internalOption"] = SourceExpressionConverter.ConvertToken(bodyinternalOption);
                bodypropCount++;
                body["urgencyType"] = SourceExpressionConverter.Convert(bodyurgencyType);
                bodypropCount++;
                body["effectsType"] = SourceExpressionConverter.Convert(bodyeffectsType);
                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyserviceContractId != null)
                {
                    body["serviceContractId"] = SourceExpressionConverter.ConvertToken(bodyserviceContractId);
                    bodypropCount++;
                }

                if (bodydelegatedTicketEditor != null)
                {
                    body["delegatedTicketEditor"] = SourceExpressionConverter.ConvertToken(bodydelegatedTicketEditor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<CreateTicketPositionResponse> CreateTicketPosition([WorkflowExpression] Func<string> bodyreferenceNumber, [WorkflowExpression] Func<string> bodyticketPositionText, [WorkflowExpression] Func<bodyticketPositionTypeInput> bodyticketPositionType, [WorkflowExpression] Func<bodyticketPositionVisibilityInput> bodyticketPositionVisibility, [WorkflowExpression] Func<bodyfieldGroupsInputItem2[]> bodyfieldGroups = null, [WorkflowExpression] Func<string> bodyparkTicketparkUntil = null, [WorkflowExpression] Func<bodyparkTicketparkingReasonInput> bodyparkTicketparkingReason = null, [WorkflowExpression] Func<string> bodyparkTicketparkingPositionText = null, [WorkflowExpression] Func<bodyparkTicketafterParkingActionInput> bodyparkTicketafterParkingAction = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateTicketPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                bodypropCount++;
                body["ticketPositionText"] = SourceExpressionConverter.ConvertToken(bodyticketPositionText);
                bodypropCount++;
                body["TicketPositionType"] = SourceExpressionConverter.Convert(bodyticketPositionType);
                bodypropCount++;
                body["TicketPositionVisibility"] = SourceExpressionConverter.Convert(bodyticketPositionVisibility);
                if (bodyfieldGroups != null)
                {
                    body["FieldGroups"] = SourceExpressionConverter.ConvertToken(bodyfieldGroups);
                    bodypropCount++;
                }

                var parkTicketObject = new JObject();
                var parkTicketObjectpropCount = 0;
                if (bodyparkTicketparkUntil != null)
                {
                    parkTicketObject["ParkUntil"] = SourceExpressionConverter.ConvertToken(bodyparkTicketparkUntil);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketparkingReason != null)
                {
                    parkTicketObject["ParkingReason"] = SourceExpressionConverter.Convert(bodyparkTicketparkingReason);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketparkingPositionText != null)
                {
                    parkTicketObject["ParkingPositionText"] = SourceExpressionConverter.ConvertToken(bodyparkTicketparkingPositionText);
                    parkTicketObjectpropCount++;
                }

                if (bodyparkTicketafterParkingAction != null)
                {
                    parkTicketObject["AfterParkingAction"] = SourceExpressionConverter.Convert(bodyparkTicketafterParkingAction);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateTicketPositionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<AddAssetRelationResponse> AddAssetRelation([WorkflowExpression] Func<string> bodyreferenceNumber, [WorkflowExpression] Func<int[]> bodyrelatedAssetIds)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddAssetRelation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                bodypropCount++;
                body["RelatedAssetIds"] = SourceExpressionConverter.ConvertToken(bodyrelatedAssetIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddAssetRelationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketResponse> GetTicket([WorkflowExpression] Func<string> bodyreferenceNumber)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referenceNumber"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketResponse> SearchTicket([WorkflowExpression] Func<string> bodyreferencenumber)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SearchTicket";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["referencenumber"] = SourceExpressionConverter.ConvertToken(bodyreferencenumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<SearchTicketbyParameterResponse> SearchTicketbyParameter([WorkflowExpression] Func<string> bodysearchParam, [WorkflowExpression] Func<int> bodytake, [WorkflowExpression] Func<int> bodyskip)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SearchTicketByParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["searchParam"] = SourceExpressionConverter.ConvertToken(bodysearchParam);
                bodypropCount++;
                body["take"] = SourceExpressionConverter.ConvertToken(bodytake);
                bodypropCount++;
                body["skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchTicketbyParameterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetTicketFieldGroupConfigResponse> GetTicketFieldGroupConfig([WorkflowExpression] Func<int> bodyticketTypeId, [WorkflowExpression] Func<string> bodyticketId = null, [WorkflowExpression] Func<string> bodyfieldGroupSettingsId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTicketFieldGroupConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TicketTypeId"] = SourceExpressionConverter.ConvertToken(bodyticketTypeId);
                if (bodyticketId != null)
                {
                    body["TicketId"] = SourceExpressionConverter.ConvertToken(bodyticketId);
                    bodypropCount++;
                }

                if (bodyfieldGroupSettingsId != null)
                {
                    body["FieldGroupSettingsId"] = SourceExpressionConverter.ConvertToken(bodyfieldGroupSettingsId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTicketFieldGroupConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllTicketTypesResponse> GetAllTicketTypes([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetAllTicketTypes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = SourceExpressionConverter.ConvertToken(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                bodypropCount++;
                body["Skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = SourceExpressionConverter.ConvertToken(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAllTicketTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllAreasResponse> GetAllAreas([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetAllAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = SourceExpressionConverter.ConvertToken(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                bodypropCount++;
                body["Skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = SourceExpressionConverter.ConvertToken(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAllAreasResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmticket")]
        public IBodyWorkflowAction<GetAllStartingAreasResponse> GetAllStartingAreas([WorkflowExpression] Func<int> bodyresponseType, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<bool> bodyorderByAsc = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetAllStartAreas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ResponseType"] = SourceExpressionConverter.ConvertToken(bodyresponseType);
                if (bodysearch != null)
                {
                    body["Search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["PageSize"] = SourceExpressionConverter.ConvertToken(bodypageSize);
                bodypropCount++;
                body["Skip"] = SourceExpressionConverter.ConvertToken(bodyskip);
                if (bodyorderByAsc != null)
                {
                    body["OrderByAsc"] = SourceExpressionConverter.ConvertToken(bodyorderByAsc);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAllStartingAreasResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum bodyeffectsTypeInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum bodyticketPositionVisibilityInput
    {
        _0 = 0,
        _1 = 1
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum bodyparkTicketafterParkingActionInput
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