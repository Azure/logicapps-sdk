//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdayhcmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateAddressInformation(Expression<Func<AddOrUpdateAddressInformationForPersonEventRequestInput>> addOrUpdateAddressInformationForPersonEventRequest = null)
        {
            var __workflow_addOrUpdateAddressInformationForPersonEventRequest = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequest, nameof(addOrUpdateAddressInformationForPersonEventRequest), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequest);
                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdatePhoneInformation(Expression<Func<AddOrUpdatePhoneInformationForPersonEventRequestInput>> addOrUpdatePhoneInformationForPersonEventRequest = null)
        {
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequest = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequest, nameof(addOrUpdatePhoneInformationForPersonEventRequest), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Phone_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequest);
                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateEmailAddressInformation(Expression<Func<AddOrUpdateEmailAddressInformationForPersonEventRequestInput>> addOrUpdateEmailAddressInformationForPersonEventRequest = null)
        {
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequest = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequest, nameof(addOrUpdateEmailAddressInformationForPersonEventRequest), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Email_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateEmailAddressInformationForPersonEventRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequest);
                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateInstantMessengerInformation(Expression<Func<AddOrUpdateInstantMessengerInformationForPersonEventRequestInput>> addOrUpdateInstantMessengerInformationForPersonEventRequest = null)
        {
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequest = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequest, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequest), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Instant_Messenger_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequest);
                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateWebAddressInformation(Expression<Func<AddOrUpdateWebAddressInformationForPersonEventRequestInput>> addOrUpdateWebAddressInformationForPersonEventRequest = null)
        {
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequest = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequest, nameof(addOrUpdateWebAddressInformationForPersonEventRequest), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Web_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_addOrUpdateWebAddressInformationForPersonEventRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequest);
                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeePersonalInfoInfo, ApiConnectionActionConfiguration> GetEmployeePersonalInfo(Expression<Func<SystemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeePersonalInfoInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Personal_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeePersonalInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeIdentityInfo, ApiConnectionActionConfiguration> GetEmployeeIdentityInfo(Expression<Func<SystemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeIdentityInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Identity_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeIdentityInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeQualificationInfo, ApiConnectionActionConfiguration> GetEmployeeQualificationInfo(Expression<Func<SystemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeQualificationInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Qualification_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeQualificationInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo, ApiConnectionActionConfiguration> GetEmployeeEmploymentInfo(Expression<Func<SystemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeEmploymentInfoInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Employment_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeEmploymentInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SoapOperation(Expression<Func<string>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SOAP_Operation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WorkdayhcmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EmployeeInfo, ApiConnectionPollingTriggerConfiguration> WhenAnEmployeeIsAddedOrUpdated(Expression<Func<DateCriteriaInput>> dateCriteria, Expression<Func<BusinessProcessTypeInput>> businessProcessType = null)
        {
            var __workflow_dateCriteria = WorkflowExpression.Compile(dateCriteria, nameof(dateCriteria), required: true);
            var __workflow_businessProcessType = WorkflowExpression.Compile(businessProcessType, nameof(businessProcessType), required: false);
            return new DeferredBodyTrigger<EmployeeInfo, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/When_an_Employee_is_Added_or_Updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateCriteria"] = ExpressionConverter.Convert(__workflow_dateCriteria);
                if (__workflow_businessProcessType != null)
                    callPayload.Queries["businessProcessType"] = ExpressionConverter.Convert(__workflow_businessProcessType);
                return new ApiConnectionPollingTrigger<EmployeeInfo>(callPayload);
            });
        }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseInfo
    {
        [JsonProperty("add_or_Update_Contact_Information_for_Person_Event_Response")]
        public AddOrUpdateContactInformationForPersonEventResponseInfoAddOrUpdateContactInformationForPersonEventResponseType AddOrUpdateContactInformationForPersonEventResponse { get; set; }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseInfoAddOrUpdateContactInformationForPersonEventResponseType
    {
        [JsonProperty("Contact_Information_for_Person_Event_Reference")]
        public AddOrUpdateContactInformationForPersonEventResponseInfoAddOrUpdateContactInformationForPersonEventResponseTypeContactInformationForPersonEventReferenceType ContactInformationForPersonEventReference { get; set; }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseInfoAddOrUpdateContactInformationForPersonEventResponseTypeContactInformationForPersonEventReferenceType
    {
        [JsonProperty("PersonIDType")]
        public string PersonIdType { get; set; }

        [JsonProperty("PersonID")]
        public string PersonId { get; set; }
    }

    public class AddOrUpdateAddressInformationForPersonEventRequestInput
    {
        [JsonProperty("add_or_Update_Address_Information_for_Person_Event_Request")]
        public AddOrUpdateAddressInformationForPersonEventRequestInputAddOrUpdateAddressInformationForPersonEventRequestType AddOrUpdateAddressInformationForPersonEventRequest { get; set; }
    }

    public class AddOrUpdateAddressInformationForPersonEventRequestInputAddOrUpdateAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Address_Information_Data")]
        public AddOrUpdateAddressInformationForPersonEventRequestInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType AddOrUpdateAddressInformationData { get; set; }
    }

    public class AddOrUpdateAddressInformationForPersonEventRequestInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType
    {
        public AddOrUpdateAddressInformationForPersonEventRequestInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType(string effectiveDate)
        {
            this.EffectiveDate = effectiveDate;
        }

        [JsonProperty("worker_Reference")]
        public WorkerReference WorkerReference { get; set; }

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationData AddressInformationData { get; set; } = new AddOrUpdateAddressInformationAddressInformationData();
    }

    public class WorkerReference
    {
        public WorkerReference(string workerId)
        {
            this.WorkerId = workerId;
        }

        [JsonProperty("WorkerIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReferenceWorkerIdTypeType WorkerIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.WorkerReferenceWorkerIdTypeType.EmployeeId;

        [JsonProperty("WorkerID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkerId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkerReferenceWorkerIdTypeType
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    public class AddOrUpdateAddressInformationAddressInformationData
    {
        [JsonProperty("country_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationDataCountryReferenceType CountryReference { get; set; } = new AddOrUpdateAddressInformationAddressInformationDataCountryReferenceType();

        [JsonProperty("address_Line_Data")]
        public AddOrUpdateAddressInformationAddressInformationDataAddressLineDataTypeItem[] AddressLineData { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("country_Region_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceType CountryRegionReference { get; set; } = new AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceType();

        [JsonProperty("postal_Code")]
        public string PostalCode { get; set; }

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationDataUsageDataType UsageData { get; set; } = new AddOrUpdateAddressInformationAddressInformationDataUsageDataType();
    }

    public class AddOrUpdateAddressInformationAddressInformationDataCountryReferenceType
    {
        [JsonProperty("CountryIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdateAddressInformationAddressInformationDataCountryReferenceTypeCountryIdTypeType CountryIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdateAddressInformationAddressInformationDataCountryReferenceTypeCountryIdTypeType.Iso31661Alpha3Code;

        [JsonProperty("CountryID")]
        public AddOrUpdateAddressInformationAddressInformationDataCountryReferenceTypeCountryIdType? CountryId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataCountryReferenceTypeCountryIdTypeType
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        Iso31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        Iso31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        Iso31661Numeric3Code
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataCountryReferenceTypeCountryIdType
    {
        [EnumMember(Value = "USA")]
        Usa,
        [EnumMember(Value = "GBR")]
        Gbr,
        [EnumMember(Value = "CAN")]
        Can,
        [EnumMember(Value = "CHN")]
        Chn,
        [EnumMember(Value = "IND")]
        Ind,
        [EnumMember(Value = "MEX")]
        Mex,
        [EnumMember(Value = "JPN")]
        Jpn
    }

    public class AddOrUpdateAddressInformationAddressInformationDataAddressLineDataTypeItem
    {
        public AddOrUpdateAddressInformationAddressInformationDataAddressLineDataTypeItemAddessLineTypeType? AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataAddressLineDataTypeItemAddessLineTypeType
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        AddressLine1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        AddressLine2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        AddressLine3
    }

    public class AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceType
    {
        [JsonProperty("CountryRegionIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType CountryRegionIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType.Iso31662Code;

        [JsonProperty("CountryRegionID")]
        public string CountryRegionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType
    {
        [EnumMember(Value = "Country Region ID")]
        CountryRegionId,
        [EnumMember(Value = "ISO 3166-2 Code")]
        Iso31662Code
    }

    public class AddOrUpdateAddressInformationAddressInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataType TypeData { get; set; } = new AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataType();
    }

    public class AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; } = new AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType();
    }

    public class AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateAddressInformationAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdatePhoneInformationForPersonEventRequestInput
    {
        [JsonProperty("add_or_Update_Phone_Information_for_Person_Event_Request")]
        public AddOrUpdatePhoneInformationForPersonEventRequestInputAddOrUpdatePhoneInformationForPersonEventRequestType AddOrUpdatePhoneInformationForPersonEventRequest { get; set; }
    }

    public class AddOrUpdatePhoneInformationForPersonEventRequestInputAddOrUpdatePhoneInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Phone_Information_Data")]
        public AddOrUpdatePhoneInformationForPersonEventRequestInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType AddOrUpdatePhoneInformationData { get; set; }
    }

    public class AddOrUpdatePhoneInformationForPersonEventRequestInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType
    {
        public AddOrUpdatePhoneInformationForPersonEventRequestInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType(string effectiveDate)
        {
            this.EffectiveDate = effectiveDate;
        }

        [JsonProperty("worker_Reference")]
        public WorkerReference WorkerReference { get; set; }

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("phone_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationPhoneInformationData PhoneInformationData { get; set; } = new AddOrUpdatePhoneInformationPhoneInformationData();
    }

    public class AddOrUpdatePhoneInformationPhoneInformationData
    {
        [JsonProperty("country_ISO_Code")]
        public AddOrUpdatePhoneInformationPhoneInformationDataCountryIsoCodeType? CountryIsoCode { get; set; }

        [JsonProperty("area_Code")]
        public string AreaCode { get; set; }

        [JsonProperty("phone_Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("phone_Device_Type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceType PhoneDeviceTypeReference { get; set; } = new AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceType();

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationPhoneInformationDataUsageDataType UsageData { get; set; } = new AddOrUpdatePhoneInformationPhoneInformationDataUsageDataType();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdatePhoneInformationPhoneInformationDataCountryIsoCodeType
    {
        [EnumMember(Value = "USA")]
        Usa,
        [EnumMember(Value = "GBR")]
        Gbr,
        [EnumMember(Value = "CAN")]
        Can,
        [EnumMember(Value = "CHN")]
        Chn,
        [EnumMember(Value = "IND")]
        Ind,
        [EnumMember(Value = "MEX")]
        Mex,
        [EnumMember(Value = "JPN")]
        Jpn
    }

    public class AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceType
    {
        [JsonProperty("PhoneDeviceTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType PhoneDeviceTypeIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType.PhoneDeviceTypeId;

        [JsonProperty("PhoneDeviceTypeID")]
        public AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType? PhoneDeviceTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdatePhoneInformationPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    public class AddOrUpdatePhoneInformationPhoneInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataType TypeData { get; set; } = new AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataType();
    }

    public class AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; } = new AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType();
    }

    public class AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdatePhoneInformationPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdateEmailAddressInformationForPersonEventRequestInput
    {
        [JsonProperty("add_or_Update_Email_Address_Information_for_Person_Event_Request")]
        public AddOrUpdateEmailAddressInformationForPersonEventRequestInputAddOrUpdateEmailAddressInformationForPersonEventRequestType AddOrUpdateEmailAddressInformationForPersonEventRequest { get; set; }
    }

    public class AddOrUpdateEmailAddressInformationForPersonEventRequestInputAddOrUpdateEmailAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Email_Address_Information_Data")]
        public AddOrUpdateEmailAddressInformationForPersonEventRequestInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType AddOrUpdateEmailAddressInformationData { get; set; }
    }

    public class AddOrUpdateEmailAddressInformationForPersonEventRequestInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType
    {
        public AddOrUpdateEmailAddressInformationForPersonEventRequestInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType(string effectiveDate)
        {
            this.EffectiveDate = effectiveDate;
        }

        [JsonProperty("worker_Reference")]
        public WorkerReference WorkerReference { get; set; }

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("email_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailAddressInformationData EmailAddressInformationData { get; set; } = new EmailAddressInformationData();
    }

    public class EmailAddressInformationData
    {
        [JsonProperty("email_Address")]
        public string EmailAddress { get; set; }

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData UsageData { get; set; } = new AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData();
    }

    public class AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataType TypeData { get; set; } = new AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataType();
    }

    public class AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType TypeReference { get; set; } = new AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType();
    }

    public class AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdateInstantMessengerInformationForPersonEventRequestInput
    {
        [JsonProperty("add_or_Update_Instant_Messenger_Information_for_Person_Event_Request")]
        public AddOrUpdateInstantMessengerInformationForPersonEventRequestInputAddOrUpdateInstantMessengerInformationForPersonEventRequestType AddOrUpdateInstantMessengerInformationForPersonEventRequest { get; set; }
    }

    public class AddOrUpdateInstantMessengerInformationForPersonEventRequestInputAddOrUpdateInstantMessengerInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Instant_Messenger_Information_Data")]
        public AddOrUpdateInstantMessengerInformationForPersonEventRequestInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType AddOrUpdateInstantMessengerInformationData { get; set; }
    }

    public class AddOrUpdateInstantMessengerInformationForPersonEventRequestInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType
    {
        public AddOrUpdateInstantMessengerInformationForPersonEventRequestInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType(string effectiveDate)
        {
            this.EffectiveDate = effectiveDate;
        }

        [JsonProperty("worker_Reference")]
        public WorkerReference WorkerReference { get; set; }

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("instant_Messenger_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateInstantMessengerInformationInstantMessengerInformationData InstantMessengerInformationData { get; set; } = new AddOrUpdateInstantMessengerInformationInstantMessengerInformationData();
    }

    public class AddOrUpdateInstantMessengerInformationInstantMessengerInformationData
    {
        [JsonProperty("instant_Messenger_Address")]
        public string InstantMessengerAddress { get; set; }

        [JsonProperty("instant_Messenger_Type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceType InstantMessengerTypeReference { get; set; } = new AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceType();

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData UsageData { get; set; } = new AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData();
    }

    public class AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceType
    {
        [JsonProperty("InstantMessengerTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType InstantMessengerTypeIdType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm.AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType.InstantMessengerTypeId;

        [JsonProperty("InstantMessengerTypeID")]
        public AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType? InstantMessengerTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrUpdateInstantMessengerInformationInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType
    {
        [EnumMember(Value = "AIM")]
        Aim,
        [EnumMember(Value = "Google Talk")]
        GoogleTalk,
        Lync,
        Meebo,
        [EnumMember(Value = "MSN")]
        Msn,
        Skype,
        Yahoo
    }

    public class AddOrUpdateWebAddressInformationForPersonEventRequestInput
    {
        [JsonProperty("add_or_Update_Web_Address_Information_for_Person_Event_Request")]
        public AddOrUpdateWebAddressInformationForPersonEventRequestInputAddOrUpdateWebAddressInformationForPersonEventRequestType AddOrUpdateWebAddressInformationForPersonEventRequest { get; set; }
    }

    public class AddOrUpdateWebAddressInformationForPersonEventRequestInputAddOrUpdateWebAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Web_Address_Information_Data")]
        public AddOrUpdateWebAddressInformationForPersonEventRequestInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType AddOrUpdateWebAddressInformationData { get; set; }
    }

    public class AddOrUpdateWebAddressInformationForPersonEventRequestInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType
    {
        public AddOrUpdateWebAddressInformationForPersonEventRequestInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType(string effectiveDate)
        {
            this.EffectiveDate = effectiveDate;
        }

        [JsonProperty("worker_Reference")]
        public WorkerReference WorkerReference { get; set; }

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("web_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateWebAddressInformationWebAddressInformationData WebAddressInformationData { get; set; } = new AddOrUpdateWebAddressInformationWebAddressInformationData();
    }

    public class AddOrUpdateWebAddressInformationWebAddressInformationData
    {
        [JsonProperty("web_Address")]
        public string WebAddress { get; set; }

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData UsageData { get; set; } = new AddOrUpdateEmailAddressInformationCommunicationMethodUsageInformationData();
    }

    public class EmployeePersonalInfoInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("business_Title")]
        public string BusinessTitle { get; set; }

        [JsonProperty("person_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType PersonData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType
    {
        [JsonProperty("name_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItem[] NameData { get; set; }

        [JsonProperty("contact_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataType ContactData { get; set; }

        [JsonProperty("demographic_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataType DemographicData { get; set; }

        [JsonProperty("biographic_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataType BiographicData { get; set; }

        [JsonProperty("personal_Preferences_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePersonalPreferencesDataType PersonalPreferencesData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItem
    {
        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("first_Name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_Name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_Name")]
        public string LastName { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataType
    {
        [JsonProperty("internet_Email_Address_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInternetEmailAddressDataTypeItem[] InternetEmailAddressData { get; set; }

        [JsonProperty("phone_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypePhoneDataTypeItem[] PhoneData { get; set; }

        [JsonProperty("address_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeAddressDataTypeItem[] AddressData { get; set; }

        [JsonProperty("instant_Messenger_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInstantMessengerDataTypeItem[] InstantMessengerData { get; set; }

        [JsonProperty("web_Address_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeWebAddressDataTypeItem[] WebAddressData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInternetEmailAddressDataTypeItem
    {
        [JsonProperty("email_Address")]
        public string EmailAddress { get; set; }

        [JsonProperty("usage_Data")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataResponse UsageData { get; set; }
    }

    public class GetEmployeePersonalInfoCommunicationMethodUsageInformationDataResponse
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeResponse TypeData { get; set; }
    }

    public class GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeResponse
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeResponse TypeReference { get; set; }
    }

    public class GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeResponse
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoCommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypePhoneDataTypeItem
    {
        [JsonProperty("phone_Information_Data")]
        public GetEmployeePersonalInfoPhoneInformationDataResponse PhoneInformationData { get; set; }
    }

    public class GetEmployeePersonalInfoPhoneInformationDataResponse
    {
        [JsonProperty("country_ISO_Code")]
        public GetEmployeePersonalInfoPhoneInformationDataCountryIsoCodeTypeResponse CountryIsoCode { get; set; }

        [JsonProperty("area_Code")]
        public string AreaCode { get; set; }

        [JsonProperty("phone_Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("phone_Device_Type_Reference")]
        public GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypeResponse PhoneDeviceTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeResponse UsageData { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoPhoneInformationDataCountryIsoCodeTypeResponse
    {
        [EnumMember(Value = "USA")]
        Usa,
        [EnumMember(Value = "GBR")]
        Gbr,
        [EnumMember(Value = "CAN")]
        Can,
        [EnumMember(Value = "CHN")]
        Chn,
        [EnumMember(Value = "IND")]
        Ind,
        [EnumMember(Value = "MEX")]
        Mex,
        [EnumMember(Value = "JPN")]
        Jpn
    }

    public class GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypeResponse
    {
        [JsonProperty("PhoneDeviceTypeIDType")]
        public GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeTypeResponse PhoneDeviceTypeIdType { get; set; }

        [JsonProperty("PhoneDeviceTypeID")]
        public GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeResponse PhoneDeviceTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeTypeResponse
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoPhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeResponse
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    public class GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeResponse
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeResponse TypeData { get; set; }
    }

    public class GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeResponse
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeResponse TypeReference { get; set; }
    }

    public class GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeResponse
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoPhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeAddressDataTypeItem
    {
        [JsonProperty("address_Information_Data")]
        public GetEmployeePersonalInfoAddressInformationDataResponse AddressInformationData { get; set; }
    }

    public class GetEmployeePersonalInfoAddressInformationDataResponse
    {
        [JsonProperty("country_Reference")]
        public GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeResponse CountryReference { get; set; }

        [JsonProperty("address_Line_Data")]
        public GetEmployeePersonalInfoAddressInformationDataAddressLineDataTypeItemResponse[] AddressLineData { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("country_Region_Reference")]
        public GetEmployeePersonalInfoAddressInformationDataCountryRegionReferenceTypeResponse CountryRegionReference { get; set; }

        [JsonProperty("postal_Code")]
        public string PostalCode { get; set; }

        [JsonProperty("usage_Data")]
        public GetEmployeePersonalInfoAddressInformationDataUsageDataTypeResponse UsageData { get; set; }
    }

    public class GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeResponse
    {
        [JsonProperty("CountryIDType")]
        public GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeCountryIdTypeTypeResponse CountryIdType { get; set; }

        [JsonProperty("CountryID")]
        public GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeCountryIdTypeResponse CountryId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeCountryIdTypeTypeResponse
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        Iso31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        Iso31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        Iso31661Numeric3Code
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataCountryReferenceTypeCountryIdTypeResponse
    {
        [EnumMember(Value = "USA")]
        Usa,
        [EnumMember(Value = "GBR")]
        Gbr,
        [EnumMember(Value = "CAN")]
        Can,
        [EnumMember(Value = "CHN")]
        Chn,
        [EnumMember(Value = "IND")]
        Ind,
        [EnumMember(Value = "MEX")]
        Mex,
        [EnumMember(Value = "JPN")]
        Jpn
    }

    public class GetEmployeePersonalInfoAddressInformationDataAddressLineDataTypeItemResponse
    {
        public GetEmployeePersonalInfoAddressInformationDataAddressLineDataTypeItemAddessLineTypeTypeResponse AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataAddressLineDataTypeItemAddessLineTypeTypeResponse
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        AddressLine1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        AddressLine2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        AddressLine3
    }

    public class GetEmployeePersonalInfoAddressInformationDataCountryRegionReferenceTypeResponse
    {
        [JsonProperty("CountryRegionIDType")]
        public GetEmployeePersonalInfoAddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeTypeResponse CountryRegionIdType { get; set; }

        [JsonProperty("CountryRegionID")]
        public string CountryRegionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeTypeResponse
    {
        [EnumMember(Value = "Country Region ID")]
        CountryRegionId,
        [EnumMember(Value = "ISO 3166-2 Code")]
        Iso31662Code
    }

    public class GetEmployeePersonalInfoAddressInformationDataUsageDataTypeResponse
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeResponse TypeData { get; set; }
    }

    public class GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeResponse
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeResponse TypeReference { get; set; }
    }

    public class GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeResponse
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeTypeResponse
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoAddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeResponse
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInstantMessengerDataTypeItem
    {
        [JsonProperty("instant_Messenger_Information_Data")]
        public GetEmployeePersonalInfoInstantMessengerInformationDataResponse InstantMessengerInformationData { get; set; }
    }

    public class GetEmployeePersonalInfoInstantMessengerInformationDataResponse
    {
        [JsonProperty("instant_Messenger_Address")]
        public string InstantMessengerAddress { get; set; }

        [JsonProperty("instant_Messenger_Type_Reference")]
        public GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeResponse InstantMessengerTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataResponse UsageData { get; set; }
    }

    public class GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeResponse
    {
        [JsonProperty("InstantMessengerTypeIDType")]
        public GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeTypeResponse InstantMessengerTypeIdType { get; set; }

        [JsonProperty("InstantMessengerTypeID")]
        public GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeResponse InstantMessengerTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeTypeResponse
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeId,
        [EnumMember(Value = "WID")]
        Wid
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetEmployeePersonalInfoInstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeResponse
    {
        [EnumMember(Value = "AIM")]
        Aim,
        [EnumMember(Value = "Google Talk")]
        GoogleTalk,
        Lync,
        Meebo,
        [EnumMember(Value = "MSN")]
        Msn,
        Skype,
        Yahoo
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeWebAddressDataTypeItem
    {
        [JsonProperty("web_Address_Information_Data")]
        public GetEmployeePersonalInfoWebAddressInformationDataResponse WebAddressInformationData { get; set; }
    }

    public class GetEmployeePersonalInfoWebAddressInformationDataResponse
    {
        [JsonProperty("web_Address")]
        public string WebAddress { get; set; }

        [JsonProperty("usage_Data")]
        public GetEmployeePersonalInfoCommunicationMethodUsageInformationDataResponse UsageData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataType
    {
        [JsonProperty("marital_Status_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMaritalStatusReferenceType MaritalStatusReference { get; set; }

        [JsonProperty("hispanic_or_Latino")]
        public bool HispanicOrLatino { get; set; }

        [JsonProperty("ethnicity_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeEthnicityReferenceTypeItem[] EthnicityReference { get; set; }

        [JsonProperty("citizenship_Status_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItem[] CitizenshipStatusReference { get; set; }

        [JsonProperty("nationality_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeNationalityReferenceTypeItem[] NationalityReference { get; set; }

        [JsonProperty("personnel_File_Agency")]
        public string PersonnelFileAgency { get; set; }

        [JsonProperty("military_Service_Data")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItem[] MilitaryServiceData { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMaritalStatusReferenceType
    {
        [JsonProperty("marital_Status_Description")]
        public string MaritalStatusDescription { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeEthnicityReferenceTypeItem
    {
        [JsonProperty("ethnicity_Name")]
        public string EthnicityName { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItem
    {
        [JsonProperty("citizenship_Status_Description")]
        public string CitizenshipStatusDescription { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItemCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeNationalityReferenceTypeItem
    {
        [JsonProperty("CountryIDType")]
        public string CountryIdType { get; set; }

        [JsonProperty("CountryID")]
        public string CountryId { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItem
    {
        [JsonProperty("military_Status_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceType MilitaryStatusReference { get; set; }

        [JsonProperty("military_Discharge_Date")]
        public string MilitaryDischargeDate { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceType
    {
        [JsonProperty("military_Status_Name")]
        public string MilitaryStatusName { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceTypeCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceTypeCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataType
    {
        [JsonProperty("country_Of_Birth_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceType CountryOfBirthReference { get; set; }

        [JsonProperty("place_Of_Birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("date_Of_Birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("gender_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeGenderReferenceType GenderReference { get; set; }

        [JsonProperty("disability_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeDisabilityReferenceTypeItem[] DisabilityReference { get; set; }

        [JsonProperty("uses_Tobacco")]
        public bool UsesTobacco { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceType
    {
        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceTypeCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceTypeCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeGenderReferenceType
    {
        [JsonProperty("gender_Description")]
        public string GenderDescription { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeDisabilityReferenceTypeItem
    {
        [JsonProperty("disability_Name")]
        public string DisabilityName { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePersonalPreferencesDataType
    {
        [JsonProperty("receive_Email_Notifications")]
        public bool ReceiveEmailNotifications { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SystemIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    public class EmployeeIdentityInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeeIdentityInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("person_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType PersonData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType
    {
        [JsonProperty("visa_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItem[] VisaIdData { get; set; }

        [JsonProperty("custom_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItem[] CustomIdData { get; set; }

        [JsonProperty("government_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItem[] GovernmentIdData { get; set; }

        [JsonProperty("license_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItem[] LicenseIdData { get; set; }

        [JsonProperty("passport_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItem[] PassportIdData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItem
    {
        [JsonProperty("visa_ID")]
        public string VisaId { get; set; }

        [JsonProperty("visa_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemVisaTypeReferenceType VisaTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemVisaTypeReferenceType
    {
        [JsonProperty("visa_Type_Name")]
        public string VisaTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItem
    {
        [JsonProperty("custom_ID")]
        public string CustomId { get; set; }

        [JsonProperty("custom_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItemCustomIdTypeReferenceType CustomIdTypeReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItemCustomIdTypeReferenceType
    {
        [JsonProperty("custom_ID_Type_Name")]
        public string CustomIdTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItem
    {
        [JsonProperty("government_ID")]
        public string GovernmentId { get; set; }

        [JsonProperty("government_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemGovernmentIdTypeReferenceType GovernmentIdTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemGovernmentIdTypeReferenceType
    {
        [JsonProperty("government_ID_Type_Name")]
        public string GovernmentIdTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItem
    {
        [JsonProperty("license_ID")]
        public string LicenseId { get; set; }

        [JsonProperty("license_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItemLicenseTypeReferenceType LicenseTypeReference { get; set; }

        [JsonProperty("license_Class")]
        public string LicenseClass { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItemLicenseTypeReferenceType
    {
        [JsonProperty("license_Type_Name")]
        public string LicenseTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItem
    {
        [JsonProperty("passport_Number")]
        public string PassportNumber { get; set; }

        [JsonProperty("passport_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemPassportTypeReferenceType PassportTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemPassportTypeReferenceType
    {
        [JsonProperty("passport_Type_Name")]
        public string PassportTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryIsoCode { get; set; }
    }

    public class EmployeeQualificationInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeeQualificationInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("qualification_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataType QualificationData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataType
    {
        [JsonProperty("education_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItem[] EducationData { get; set; }

        [JsonProperty("professional_Experience_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItem[] ProfessionalExperienceData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItem
    {
        [JsonProperty("education_Institution")]
        public string EducationInstitution { get; set; }

        [JsonProperty("educational_Institution_Type_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemEducationalInstitutionTypeReferenceType EducationalInstitutionTypeReference { get; set; }

        [JsonProperty("degree_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemDegreeReferenceType DegreeReference { get; set; }

        [JsonProperty("field_Of_Study_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemFieldOfStudyReferenceType FieldOfStudyReference { get; set; }

        [JsonProperty("education_Institution_Location")]
        public string EducationInstitutionLocation { get; set; }

        [JsonProperty("education_Grade_Average")]
        public string EducationGradeAverage { get; set; }

        [JsonProperty("first_Year_Attended")]
        public string FirstYearAttended { get; set; }

        [JsonProperty("last_Year_Attended")]
        public string LastYearAttended { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemEducationalInstitutionTypeReferenceType
    {
        [JsonProperty("institution_Type_Name")]
        public string InstitutionTypeName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemDegreeReferenceType
    {
        [JsonProperty("degree_Name")]
        public string DegreeName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemFieldOfStudyReferenceType
    {
        [JsonProperty("field_Of_Study_Name")]
        public string FieldOfStudyName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItem
    {
        [JsonProperty("professional_Experience")]
        public string ProfessionalExperience { get; set; }

        [JsonProperty("professional_Experience_Rating_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItemProfessionalExperienceRatingReferenceType ProfessionalExperienceRatingReference { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItemProfessionalExperienceRatingReferenceType
    {
        [JsonProperty("rating_Description")]
        public string RatingDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfo
    {
        [JsonProperty("employee_Employment_Info")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoType EmployeeEmploymentInfo { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoType
    {
        [JsonProperty("employee_Employment_Info_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataType EmployeeEmploymentInfoData { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataType
    {
        [JsonProperty("worker_Status_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataType WorkerStatusData { get; set; }

        [JsonProperty("worker_Position_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataType WorkerPositionData { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("hire_Date")]
        public string HireDate { get; set; }

        [JsonProperty("original_Hire_Date")]
        public string OriginalHireDate { get; set; }

        [JsonProperty("end_Employment_Date")]
        public string EndEmploymentDate { get; set; }

        [JsonProperty("hire_Reason")]
        public string HireReason { get; set; }

        [JsonProperty("continuous_Service_Date")]
        public string ContinuousServiceDate { get; set; }

        [JsonProperty("first_Day_of_Work")]
        public string FirstDayOfWork { get; set; }

        [JsonProperty("expected_Retirement_Date")]
        public string ExpectedRetirementDate { get; set; }

        [JsonProperty("retirement_Eligibility_Date")]
        public string RetirementEligibilityDate { get; set; }

        [JsonProperty("retired")]
        public bool Retired { get; set; }

        [JsonProperty("retirement_Date")]
        public string RetirementDate { get; set; }

        [JsonProperty("seniority_Date")]
        public string SeniorityDate { get; set; }

        [JsonProperty("severance_Date")]
        public string SeveranceDate { get; set; }

        [JsonProperty("benefits_Service_Date")]
        public string BenefitsServiceDate { get; set; }

        [JsonProperty("company_Service_Date")]
        public string CompanyServiceDate { get; set; }

        [JsonProperty("time_Off_Service_Date")]
        public string TimeOffServiceDate { get; set; }

        [JsonProperty("vesting_Date")]
        public string VestingDate { get; set; }

        [JsonProperty("date_Entered_Workforce")]
        public string DateEnteredWorkforce { get; set; }

        [JsonProperty("days_Unemployed")]
        public double DaysUnemployed { get; set; }

        [JsonProperty("months_Continuous_Prior_Employment")]
        public double MonthsContinuousPriorEmployment { get; set; }

        [JsonProperty("leave_Status_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItem[] LeaveStatusData { get; set; }

        [JsonProperty("termination_Status_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeTerminationStatusDataTypeItem[] TerminationStatusData { get; set; }

        [JsonProperty("probation_Status_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeProbationStatusDataTypeItem[] ProbationStatusData { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItem
    {
        [JsonProperty("on_Leave")]
        public bool OnLeave { get; set; }

        [JsonProperty("leave_Start_Date")]
        public string LeaveStartDate { get; set; }

        [JsonProperty("estimated_Leave_End_Date")]
        public string EstimatedLeaveEndDate { get; set; }

        [JsonProperty("leave_End_Date")]
        public string LeaveEndDate { get; set; }

        [JsonProperty("first_Day_Of_Work")]
        public string FirstDayOfWork { get; set; }

        [JsonProperty("leave_of_Absence_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItemLeaveOfAbsenceTypeReferenceType LeaveOfAbsenceTypeReference { get; set; }

        [JsonProperty("benefits_Effect")]
        public bool BenefitsEffect { get; set; }

        [JsonProperty("payroll_Effect")]
        public bool PayrollEffect { get; set; }

        [JsonProperty("paid_Time_Off_Accrual_Effect")]
        public bool PaidTimeOffAccrualEffect { get; set; }

        [JsonProperty("continuous_Service_Accrual_Effect")]
        public bool ContinuousServiceAccrualEffect { get; set; }

        [JsonProperty("stock_Vesting_Effect")]
        public bool StockVestingEffect { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItemLeaveOfAbsenceTypeReferenceType
    {
        [JsonProperty("leave_Type_Name")]
        public string LeaveTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeTerminationStatusDataTypeItem
    {
        [JsonProperty("terminated")]
        public bool Terminated { get; set; }

        [JsonProperty("termination_Date")]
        public string TerminationDate { get; set; }

        [JsonProperty("termination_Category")]
        public string TerminationCategory { get; set; }

        [JsonProperty("termination_Reason")]
        public string TerminationReason { get; set; }

        [JsonProperty("involuntary_Termination")]
        public bool InvoluntaryTermination { get; set; }

        [JsonProperty("not_Eligible_For_Hire")]
        public bool NotEligibleForHire { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeProbationStatusDataTypeItem
    {
        [JsonProperty("probation_Start_Date")]
        public string ProbationStartDate { get; set; }

        [JsonProperty("probation_End_Date")]
        public string ProbationEndDate { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataType
    {
        [JsonProperty("position_ID")]
        public string PositionId { get; set; }

        [JsonProperty("position_Title")]
        public string PositionTitle { get; set; }

        [JsonProperty("business_Title")]
        public string BusinessTitle { get; set; }

        [JsonProperty("employee_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeEmployeeTypeReferenceTypeItem[] EmployeeTypeReference { get; set; }

        [JsonProperty("position_Time_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePositionTimeTypeReferenceTypeItem[] PositionTimeTypeReference { get; set; }

        [JsonProperty("job_Exempt")]
        public bool JobExempt { get; set; }

        [JsonProperty("scheduled_Weekly_Hours")]
        public double ScheduledWeeklyHours { get; set; }

        [JsonProperty("default_Weekly_Hours")]
        public double DefaultWeeklyHours { get; set; }

        [JsonProperty("full_Time_Equivalent_Percentage")]
        public double FullTimeEquivalentPercentage { get; set; }

        [JsonProperty("pay_Rate_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayRateTypeReferenceTypeItem[] PayRateTypeReference { get; set; }

        [JsonProperty("job_Classification_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobClassificationReferenceTypeItem[] JobClassificationReference { get; set; }

        [JsonProperty("company_Insider_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeCompanyInsiderReferenceTypeItem[] CompanyInsiderReference { get; set; }

        [JsonProperty("job_Profile_Summary_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItem[] JobProfileSummaryData { get; set; }

        [JsonProperty("organization_Content_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItem[] OrganizationContentData { get; set; }

        [JsonProperty("business_Site_Content_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItem[] BusinessSiteContentData { get; set; }

        [JsonProperty("payroll_Processing_Data")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItem[] PayrollProcessingData { get; set; }

        [JsonProperty("supervisor_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceType SupervisorReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeEmployeeTypeReferenceTypeItem
    {
        [JsonProperty("employee_Type_Description")]
        public string EmployeeTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePositionTimeTypeReferenceTypeItem
    {
        [JsonProperty("time_Type_Description")]
        public string TimeTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayRateTypeReferenceTypeItem
    {
        [JsonProperty("pay_Type_Name")]
        public string PayTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobClassificationReferenceTypeItem
    {
        [JsonProperty("job_Classification_Group_Name")]
        public string JobClassificationGroupName { get; set; }

        [JsonProperty("job_Classification_Name")]
        public string JobClassificationName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeCompanyInsiderReferenceTypeItem
    {
        [JsonProperty("company_Insider_Type_Name")]
        public string CompanyInsiderTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItem
    {
        [JsonProperty("job_Profile_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobProfileReferenceType JobProfileReference { get; set; }

        [JsonProperty("job_Exempt")]
        public bool JobExempt { get; set; }

        [JsonProperty("management_Level_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemManagementLevelReferenceType ManagementLevelReference { get; set; }

        [JsonProperty("job_Category_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobCategoryReferenceType JobCategoryReference { get; set; }

        [JsonProperty("job_Profile_Name")]
        public string JobProfileName { get; set; }

        [JsonProperty("work_Shift_Required")]
        public bool WorkShiftRequired { get; set; }

        [JsonProperty("critical_Job")]
        public bool CriticalJob { get; set; }

        [JsonProperty("difficulty_to_Fill_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemDifficultyToFillReferenceType DifficultyToFillReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobProfileReferenceType
    {
        [JsonProperty("JobProfileIDType")]
        public string JobProfileIdType { get; set; }

        [JsonProperty("JobProfileID")]
        public string JobProfileId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemManagementLevelReferenceType
    {
        [JsonProperty("ManagementLevelIDType")]
        public string ManagementLevelIdType { get; set; }

        [JsonProperty("ManagementLevelID")]
        public string ManagementLevelId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobCategoryReferenceType
    {
        [JsonProperty("JobCategoryIDType")]
        public string JobCategoryIdType { get; set; }

        [JsonProperty("JobCategoryID")]
        public string JobCategoryId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemDifficultyToFillReferenceType
    {
        [JsonProperty("DifficultyToFillIDType")]
        public string DifficultyToFillIdType { get; set; }

        [JsonProperty("DifficultyToFillID")]
        public string DifficultyToFillId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItem
    {
        [JsonProperty("organization_ID")]
        public string OrganizationId { get; set; }

        [JsonProperty("organization_Name")]
        public string OrganizationName { get; set; }

        [JsonProperty("organization_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationTypeReferenceTypeItem[] OrganizationTypeReference { get; set; }

        [JsonProperty("organization_Subtype_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationSubtypeReferenceTypeItem[] OrganizationSubtypeReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationTypeReferenceTypeItem
    {
        [JsonProperty("organization_Type_Name")]
        public string OrganizationTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationSubtypeReferenceTypeItem
    {
        [JsonProperty("organization_Subtype_Name")]
        public string OrganizationSubtypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItem
    {
        [JsonProperty("location_Name")]
        public string LocationName { get; set; }

        [JsonProperty("location_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemLocationTypeReferenceTypeItem[] LocationTypeReference { get; set; }

        [JsonProperty("time_Profile_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemTimeProfileReferenceTypeItem[] TimeProfileReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemLocationTypeReferenceTypeItem
    {
        [JsonProperty("location_Type_Description")]
        public string LocationTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemTimeProfileReferenceTypeItem
    {
        [JsonProperty("time_Profile_Description")]
        public string TimeProfileDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItem
    {
        [JsonProperty("pay_Rate_Type_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayRateTypeReferenceType PayRateTypeReference { get; set; }

        [JsonProperty("frequency_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemFrequencyReferenceType FrequencyReference { get; set; }

        [JsonProperty("pay_Group_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayGroupReferenceType PayGroupReference { get; set; }

        [JsonProperty("payroll_Entity_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayrollEntityReferenceTypeItem[] PayrollEntityReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayRateTypeReferenceType
    {
        [JsonProperty("pay_Type_Name")]
        public string PayTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemFrequencyReferenceType
    {
        [JsonProperty("frequency_Name")]
        public string FrequencyName { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayGroupReferenceType
    {
        [JsonProperty("pay_Group_ID")]
        public string PayGroupId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayrollEntityReferenceTypeItem
    {
        [JsonProperty("payroll_Entity_ID")]
        public string PayrollEntityId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceType
    {
        [JsonProperty("employee_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceType EmployeeReference { get; set; }

        [JsonProperty("contingent_Worker_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceType ContingentWorkerReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceType
    {
        [JsonProperty("integration_ID_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIdReferenceType IntegrationIdReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIdReferenceType
    {
        [JsonProperty("IntegrationID")]
        public string IntegrationId { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceType
    {
        [JsonProperty("integration_ID_Reference")]
        public EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIdReferenceType IntegrationIdReference { get; set; }
    }

    public class EmployeeEmploymentInfoInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIdReferenceType
    {
        [JsonProperty("IntegrationID")]
        public string IntegrationId { get; set; }
    }

    public class EmployeeInfo
    {
        public EmployeeInfoWorkersTypeItem[] Workers { get; set; }
    }

    public class EmployeeInfoWorkersTypeItem
    {
        [JsonProperty("Worker_Data")]
        public EmployeeInfoWorkersTypeItemWorkerDataType WorkerData { get; set; }
    }

    public class EmployeeInfoWorkersTypeItemWorkerDataType
    {
        [JsonProperty("Worker_ID")]
        public int WorkerId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DateCriteriaInput
    {
        [EnumMember(Value = "Effective Date")]
        EffectiveDate,
        [EnumMember(Value = "Updated Date")]
        UpdatedDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BusinessProcessTypeInput
    {
        [EnumMember(Value = "Hire Employee")]
        HireEmployee,
        [EnumMember(Value = "Terminate Employee")]
        TerminateEmployee
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm;

    public partial class WorkflowManagedActions
    {
        public WorkdayhcmActions Workdayhcm(string connectionId) => new WorkdayhcmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkdayhcmTriggers Workdayhcm(string connectionId) => new WorkdayhcmTriggers(connectionId);
    }
}