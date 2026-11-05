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
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateAddressInformation(Expression<Func<AddOrUpdateAddressInformationInput>> addOrUpdateAddressInformationForPersonEventRequest = null)
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
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdatePhoneInformation(Expression<Func<AddOrUpdatePhoneInformationInput>> addOrUpdatePhoneInformationForPersonEventRequest = null)
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
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateEmailAddressInformation(Expression<Func<AddOrUpdateEmailAddressInformationInput>> addOrUpdateEmailAddressInformationForPersonEventRequest = null)
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
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateInstantMessengerInformation(Expression<Func<AddOrUpdateInstantMessengerInformationInput>> addOrUpdateInstantMessengerInformationForPersonEventRequest = null)
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
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateWebAddressInformation(Expression<Func<AddOrUpdateWebAddressInformationInput>> addOrUpdateWebAddressInformationForPersonEventRequest = null)
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
        public IBodyWorkflowAction<EmployeePersonalInfoInfo, ApiConnectionActionConfiguration> GetEmployeePersonalInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
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
        public IBodyWorkflowAction<EmployeeIdentityInfo, ApiConnectionActionConfiguration> GetEmployeeIdentityInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
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
        public IBodyWorkflowAction<EmployeeQualificationInfo, ApiConnectionActionConfiguration> GetEmployeeQualificationInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
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
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo, ApiConnectionActionConfiguration> GetEmployeeEmploymentInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SOAPOperation(Expression<Func<string>> body)
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
        public IBodyWorkflowTrigger<EmployeeInfo, ApiConnectionTriggerConfiguration> WhenAnEmployeeIsAddedOrUpdated(Expression<Func<dateCriteriaInput>> dateCriteria, Expression<Func<businessProcessTypeInput>> businessProcessType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dateCriteria = WorkflowExpression.Compile(dateCriteria, nameof(dateCriteria), required: true);
            var __workflow_businessProcessType = WorkflowExpression.Compile(businessProcessType, nameof(businessProcessType), required: false);
            return new DeferredBodyTrigger<EmployeeInfo, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/When_an_Employee_is_Added_or_Updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateCriteria"] = ExpressionConverter.Convert(__workflow_dateCriteria);
                if (__workflow_businessProcessType != null)
                    callPayload.Queries["businessProcessType"] = ExpressionConverter.Convert(__workflow_businessProcessType);
                return new ApiConnectionTrigger<EmployeeInfo>(callPayload, recurrence: recurrence);
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

    public class AddOrUpdateAddressInformationInput
    {
        [JsonProperty("add_or_Update_Address_Information_for_Person_Event_Request", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestType AddOrUpdateAddressInformationForPersonEventRequest { get; set; } = new AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestType();
    }

    public class AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType AddOrUpdateAddressInformationData { get; set; } = new AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType();
    }

    public class AddOrUpdateAddressInformationInputAddOrUpdateAddressInformationForPersonEventRequestTypeAddOrUpdateAddressInformationDataType
    {
        [JsonProperty("worker_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReference WorkerReference { get; set; } = new WorkerReference();

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationData2 AddressInformationData { get; set; } = new AddressInformationData2();
    }

    public class WorkerReference
    {
        [JsonProperty("WorkerIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReferenceWorkerIdTypeType WorkerIdType { get; set; } = WorkerReferenceWorkerIdTypeType.EmployeeId;

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

    public class AddressInformationData2
    {
        [JsonProperty("country_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationDataCountryReferenceType2 CountryReference { get; set; } = new AddressInformationDataCountryReferenceType2();

        [JsonProperty("address_Line_Data")]
        public AddressInformationDataAddressLineDataTypeItem2[] AddressLineData { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("country_Region_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationDataCountryRegionReferenceType2 CountryRegionReference { get; set; } = new AddressInformationDataCountryRegionReferenceType2();

        [JsonProperty("postal_Code")]
        public string PostalCode { get; set; }

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationDataUsageDataType2 UsageData { get; set; } = new AddressInformationDataUsageDataType2();
    }

    public class AddressInformationDataCountryReferenceType2
    {
        [JsonProperty("CountryIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddressInformationDataCountryReferenceTypeCountryIdTypeType CountryIdType { get; set; } = AddressInformationDataCountryReferenceTypeCountryIdTypeType.ISO31661Alpha3Code;

        [JsonProperty("CountryID")]
        public AddressInformationDataCountryReferenceTypeCountryIdType? CountryId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryReferenceTypeCountryIdTypeType
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        ISO31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        ISO31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        ISO31661Numeric3Code
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryReferenceTypeCountryIdType
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    public class AddressInformationDataAddressLineDataTypeItem2
    {
        public AddressInformationDataAddressLineDataTypeItemAddessLineTypeType? AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataAddressLineDataTypeItemAddessLineTypeType
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        ADDRESSLINE1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        ADDRESSLINE2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        ADDRESSLINE3
    }

    public class AddressInformationDataCountryRegionReferenceType2
    {
        [JsonProperty("CountryRegionIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType CountryRegionIdType { get; set; } = AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType.ISO31662Code;

        [JsonProperty("CountryRegionID")]
        public string CountryRegionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType
    {
        [EnumMember(Value = "Country Region ID")]
        CountryRegionId,
        [EnumMember(Value = "ISO 3166-2 Code")]
        ISO31662Code
    }

    public class AddressInformationDataUsageDataType2
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationDataUsageDataTypeTypeDataType2 TypeData { get; set; } = new AddressInformationDataUsageDataTypeTypeDataType2();
    }

    public class AddressInformationDataUsageDataTypeTypeDataType2
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2 TypeReference { get; set; } = new AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2();
    }

    public class AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdatePhoneInformationInput
    {
        [JsonProperty("add_or_Update_Phone_Information_for_Person_Event_Request", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestType AddOrUpdatePhoneInformationForPersonEventRequest { get; set; } = new AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestType();
    }

    public class AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Phone_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType AddOrUpdatePhoneInformationData { get; set; } = new AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType();
    }

    public class AddOrUpdatePhoneInformationInputAddOrUpdatePhoneInformationForPersonEventRequestTypeAddOrUpdatePhoneInformationDataType
    {
        [JsonProperty("worker_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReference WorkerReference { get; set; } = new WorkerReference();

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("phone_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public PhoneInformationData2 PhoneInformationData { get; set; } = new PhoneInformationData2();
    }

    public class PhoneInformationData2
    {
        [JsonProperty("country_ISO_Code")]
        public PhoneInformationDataCountryISOCodeType? CountryISOCode { get; set; }

        [JsonProperty("area_Code")]
        public string AreaCode { get; set; }

        [JsonProperty("phone_Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("phone_Device_Type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public PhoneInformationDataPhoneDeviceTypeReferenceType2 PhoneDeviceTypeReference { get; set; } = new PhoneInformationDataPhoneDeviceTypeReferenceType2();

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public PhoneInformationDataUsageDataType2 UsageData { get; set; } = new PhoneInformationDataUsageDataType2();
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataCountryISOCodeType
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    public class PhoneInformationDataPhoneDeviceTypeReferenceType2
    {
        [JsonProperty("PhoneDeviceTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType PhoneDeviceTypeIdType { get; set; } = PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType.PhoneDeviceTypeId;

        [JsonProperty("PhoneDeviceTypeID")]
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType? PhoneDeviceTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    public class PhoneInformationDataUsageDataType2
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public PhoneInformationDataUsageDataTypeTypeDataType2 TypeData { get; set; } = new PhoneInformationDataUsageDataTypeTypeDataType2();
    }

    public class PhoneInformationDataUsageDataTypeTypeDataType2
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2 TypeReference { get; set; } = new PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2();
    }

    public class PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType2
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdateEmailAddressInformationInput
    {
        [JsonProperty("add_or_Update_Email_Address_Information_for_Person_Event_Request", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestType AddOrUpdateEmailAddressInformationForPersonEventRequest { get; set; } = new AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestType();
    }

    public class AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Email_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType AddOrUpdateEmailAddressInformationData { get; set; } = new AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType();
    }

    public class AddOrUpdateEmailAddressInformationInputAddOrUpdateEmailAddressInformationForPersonEventRequestTypeAddOrUpdateEmailAddressInformationDataType
    {
        [JsonProperty("worker_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReference WorkerReference { get; set; } = new WorkerReference();

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
        public CommunicationMethodUsageInformationData2 UsageData { get; set; } = new CommunicationMethodUsageInformationData2();
    }

    public class CommunicationMethodUsageInformationData2
    {
        [JsonProperty("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonProperty("type_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommunicationMethodUsageInformationDataTypeDataType2 TypeData { get; set; } = new CommunicationMethodUsageInformationDataTypeDataType2();
    }

    public class CommunicationMethodUsageInformationDataTypeDataType2
    {
        [JsonProperty("isPrimary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType2 TypeReference { get; set; } = new CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType2();
    }

    public class CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType2
    {
        [JsonProperty("communicationUsageTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; } = CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType.CommunicationUsageTypeId;

        [JsonProperty("communicationUsageTypeID")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType? CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class AddOrUpdateInstantMessengerInformationInput
    {
        [JsonProperty("add_or_Update_Instant_Messenger_Information_for_Person_Event_Request", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestType AddOrUpdateInstantMessengerInformationForPersonEventRequest { get; set; } = new AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestType();
    }

    public class AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Instant_Messenger_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType AddOrUpdateInstantMessengerInformationData { get; set; } = new AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType();
    }

    public class AddOrUpdateInstantMessengerInformationInputAddOrUpdateInstantMessengerInformationForPersonEventRequestTypeAddOrUpdateInstantMessengerInformationDataType
    {
        [JsonProperty("worker_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReference WorkerReference { get; set; } = new WorkerReference();

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("instant_Messenger_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public InstantMessengerInformationData2 InstantMessengerInformationData { get; set; } = new InstantMessengerInformationData2();
    }

    public class InstantMessengerInformationData2
    {
        [JsonProperty("instant_Messenger_Address")]
        public string InstantMessengerAddress { get; set; }

        [JsonProperty("instant_Messenger_Type_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceType2 InstantMessengerTypeReference { get; set; } = new InstantMessengerInformationDataInstantMessengerTypeReferenceType2();

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommunicationMethodUsageInformationData2 UsageData { get; set; } = new CommunicationMethodUsageInformationData2();
    }

    public class InstantMessengerInformationDataInstantMessengerTypeReferenceType2
    {
        [JsonProperty("InstantMessengerTypeIDType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType InstantMessengerTypeIdType { get; set; } = InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType.InstantMessengerTypeId;

        [JsonProperty("InstantMessengerTypeID")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType? InstantMessengerTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType
    {
        AIM,
        [EnumMember(Value = "Google Talk")]
        GoogleTalk,
        Lync,
        Meebo,
        MSN,
        Skype,
        Yahoo
    }

    public class AddOrUpdateWebAddressInformationInput
    {
        [JsonProperty("add_or_Update_Web_Address_Information_for_Person_Event_Request", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestType AddOrUpdateWebAddressInformationForPersonEventRequest { get; set; } = new AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestType();
    }

    public class AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestType
    {
        [JsonProperty("add_or_Update_Web_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType AddOrUpdateWebAddressInformationData { get; set; } = new AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType();
    }

    public class AddOrUpdateWebAddressInformationInputAddOrUpdateWebAddressInformationForPersonEventRequestTypeAddOrUpdateWebAddressInformationDataType
    {
        [JsonProperty("worker_Reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkerReference WorkerReference { get; set; } = new WorkerReference();

        [JsonProperty("effective_Date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EffectiveDate { get; set; }

        [JsonProperty("web_Address_Information_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public WebAddressInformationData2 WebAddressInformationData { get; set; } = new WebAddressInformationData2();
    }

    public class WebAddressInformationData2
    {
        [JsonProperty("web_Address")]
        public string WebAddress { get; set; }

        [JsonProperty("usage_Data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CommunicationMethodUsageInformationData2 UsageData { get; set; } = new CommunicationMethodUsageInformationData2();
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
        public string CountryISOCode { get; set; }
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
        public CommunicationMethodUsageInformationData UsageData { get; set; }
    }

    public class CommunicationMethodUsageInformationData
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public CommunicationMethodUsageInformationDataTypeDataType TypeData { get; set; }
    }

    public class CommunicationMethodUsageInformationDataTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypePhoneDataTypeItem
    {
        [JsonProperty("phone_Information_Data")]
        public PhoneInformationData PhoneInformationData { get; set; }
    }

    public class PhoneInformationData
    {
        [JsonProperty("country_ISO_Code")]
        public PhoneInformationDataCountryISOCodeType CountryISOCode { get; set; }

        [JsonProperty("area_Code")]
        public string AreaCode { get; set; }

        [JsonProperty("phone_Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("phone_Device_Type_Reference")]
        public PhoneInformationDataPhoneDeviceTypeReferenceType PhoneDeviceTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public PhoneInformationDataUsageDataType UsageData { get; set; }
    }

    public class PhoneInformationDataPhoneDeviceTypeReferenceType
    {
        [JsonProperty("PhoneDeviceTypeIDType")]
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType PhoneDeviceTypeIdType { get; set; }

        [JsonProperty("PhoneDeviceTypeID")]
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType PhoneDeviceTypeId { get; set; }
    }

    public class PhoneInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public PhoneInformationDataUsageDataTypeTypeDataType TypeData { get; set; }
    }

    public class PhoneInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeAddressDataTypeItem
    {
        [JsonProperty("address_Information_Data")]
        public AddressInformationData AddressInformationData { get; set; }
    }

    public class AddressInformationData
    {
        [JsonProperty("country_Reference")]
        public AddressInformationDataCountryReferenceType CountryReference { get; set; }

        [JsonProperty("address_Line_Data")]
        public AddressInformationDataAddressLineDataTypeItem[] AddressLineData { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("country_Region_Reference")]
        public AddressInformationDataCountryRegionReferenceType CountryRegionReference { get; set; }

        [JsonProperty("postal_Code")]
        public string PostalCode { get; set; }

        [JsonProperty("usage_Data")]
        public AddressInformationDataUsageDataType UsageData { get; set; }
    }

    public class AddressInformationDataCountryReferenceType
    {
        [JsonProperty("CountryIDType")]
        public AddressInformationDataCountryReferenceTypeCountryIdTypeType CountryIdType { get; set; }

        [JsonProperty("CountryID")]
        public AddressInformationDataCountryReferenceTypeCountryIdType CountryId { get; set; }
    }

    public class AddressInformationDataAddressLineDataTypeItem
    {
        public AddressInformationDataAddressLineDataTypeItemAddessLineTypeType AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    public class AddressInformationDataCountryRegionReferenceType
    {
        [JsonProperty("CountryRegionIDType")]
        public AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType CountryRegionIdType { get; set; }

        [JsonProperty("CountryRegionID")]
        public string CountryRegionId { get; set; }
    }

    public class AddressInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public AddressInformationDataUsageDataTypeTypeDataType TypeData { get; set; }
    }

    public class AddressInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInstantMessengerDataTypeItem
    {
        [JsonProperty("instant_Messenger_Information_Data")]
        public InstantMessengerInformationData InstantMessengerInformationData { get; set; }
    }

    public class InstantMessengerInformationData
    {
        [JsonProperty("instant_Messenger_Address")]
        public string InstantMessengerAddress { get; set; }

        [JsonProperty("instant_Messenger_Type_Reference")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceType InstantMessengerTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public CommunicationMethodUsageInformationData UsageData { get; set; }
    }

    public class InstantMessengerInformationDataInstantMessengerTypeReferenceType
    {
        [JsonProperty("InstantMessengerTypeIDType")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType InstantMessengerTypeIdType { get; set; }

        [JsonProperty("InstantMessengerTypeID")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType InstantMessengerTypeId { get; set; }
    }

    public class EmployeePersonalInfoInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeWebAddressDataTypeItem
    {
        [JsonProperty("web_Address_Information_Data")]
        public WebAddressInformationData WebAddressInformationData { get; set; }
    }

    public class WebAddressInformationData
    {
        [JsonProperty("web_Address")]
        public string WebAddress { get; set; }

        [JsonProperty("usage_Data")]
        public CommunicationMethodUsageInformationData UsageData { get; set; }
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
        public string CountryISOCode { get; set; }
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
        public string CountryISOCode { get; set; }
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
        public string CountryISOCode { get; set; }
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
    public enum systemIdTypeInput
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
        public string CountryISOCode { get; set; }
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
        public string CountryISOCode { get; set; }
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
        public string CountryISOCode { get; set; }
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
    public enum dateCriteriaInput
    {
        [EnumMember(Value = "Effective Date")]
        EffectiveDate,
        [EnumMember(Value = "Updated Date")]
        UpdatedDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum businessProcessTypeInput
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