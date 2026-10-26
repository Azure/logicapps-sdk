//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adpemployeeselfservi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdpemployeeselfserviActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<CreateContactInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/create-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<DeleteContactsResponse, ApiConnectionActionConfiguration> DeleteContacts(Expression<Func<DeleteContactsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/delete-emergency-contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetContactsResponse, ApiConnectionActionConfiguration> GetContacts()
        {
            return new DeferredBodyAction<GetContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/get-emergency-contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetPayDistributionsResponse, ApiConnectionActionConfiguration> GetPayDistributions()
        {
            return new DeferredBodyAction<GetPayDistributionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/get-pay-distributions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPayDistributionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetPayStatementsResponse, ApiConnectionActionConfiguration> GetPayStatements()
        {
            return new DeferredBodyAction<GetPayStatementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/get-pay-statements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPayStatementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetUserResponse, ApiConnectionActionConfiguration> GetUser()
        {
            return new DeferredBodyAction<GetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/get-worker";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<UpdateContactResponse, ApiConnectionActionConfiguration> UpdateContact(Expression<Func<UpdateContactInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/update-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<UpdateUserResponse, ApiConnectionActionConfiguration> UpdateUser(Expression<Func<UpdateUserInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/update-profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateUserResponse>(callPayload);
            });
        }
    }

    public class AdpemployeeselfserviTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateContactResponse
    {
        [JsonProperty("result")]
        public CreateContactResponseResultType Result { get; set; }
    }

    public class CreateContactResponseResultType
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }
    }

    public class CreateContactInput
    {
        [JsonProperty("contactName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("addressCity")]
        public string AddressCity { get; set; }

        [JsonProperty("addressState")]
        public string AddressState { get; set; }

        [JsonProperty("addressCountry")]
        public string AddressCountry { get; set; }

        [JsonProperty("addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("phones")]
        public CreateContactInputPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public CreateContactInputEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("relation", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateContactInputRelationType Relation { get; set; }

        [JsonProperty("isPrimary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPrimary { get; set; }
    }

    public class CreateContactInputPhonesTypeItem
    {
        [JsonProperty("phoneType")]
        public CreateContactInputPhonesTypeItemPhoneTypeType? PhoneType { get; set; }

        [JsonProperty("countryCode")]
        public int? CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public int? AreaCode { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("extension")]
        public int? Extension { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputPhonesTypeItemPhoneTypeType
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "alternate")]
        Alternate,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public class CreateContactInputEmailsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateContactInputRelationType
    {
        [EnumMember(Value = "spouse")]
        Spouse,
        [EnumMember(Value = "partner")]
        Partner,
        [EnumMember(Value = "child")]
        Child,
        [EnumMember(Value = "sibling")]
        Sibling,
        [EnumMember(Value = "parent")]
        Parent,
        [EnumMember(Value = "other")]
        Other
    }

    public class DeleteContactsResponse
    {
        [JsonProperty("result")]
        public DeleteContactsResponseResultTypeItem[] Result { get; set; }
    }

    public class DeleteContactsResponseResultTypeItem
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class DeleteContactsInput
    {
        [JsonProperty("itemIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ItemIds { get; set; }
    }

    public class GetContactsResponse
    {
        [JsonProperty("result")]
        public GetContactsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetContactsResponseResultTypeItem
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("addressCity")]
        public string AddressCity { get; set; }

        [JsonProperty("addressState")]
        public string AddressState { get; set; }

        [JsonProperty("addressCountry")]
        public string AddressCountry { get; set; }

        [JsonProperty("addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("phones")]
        public GetContactsResponseResultTypeItemPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public GetContactsResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class GetContactsResponseResultTypeItemPhonesTypeItem
    {
        [JsonProperty("phoneType")]
        public string PhoneType { get; set; }

        [JsonProperty("countryCode")]
        public int CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public int AreaCode { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("extension")]
        public int Extension { get; set; }
    }

    public class GetContactsResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class GetPayDistributionsResponse
    {
        [JsonProperty("result")]
        public GetPayDistributionsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetPayDistributionsResponseResultTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("routingNumber")]
        public string RoutingNumber { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("isBonusOnly")]
        public bool IsBonusOnly { get; set; }
    }

    public class GetPayStatementsResponse
    {
        [JsonProperty("result")]
        public GetPayStatementsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetPayStatementsResponseResultTypeItem
    {
        [JsonProperty("payDate")]
        public string PayDate { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("netPayAmount")]
        public double NetPayAmount { get; set; }

        [JsonProperty("grossPayAmount")]
        public double GrossPayAmount { get; set; }

        [JsonProperty("totalHours")]
        public double TotalHours { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("result")]
        public GetUserResponseResultType Result { get; set; }
    }

    public class GetUserResponseResultType
    {
        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("legalName")]
        public string LegalName { get; set; }

        [JsonProperty("personalEmail")]
        public string PersonalEmail { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("businessEmail")]
        public string BusinessEmail { get; set; }
    }

    public class UpdateContactResponse
    {
        [JsonProperty("result")]
        public UpdateContactResponseResultType Result { get; set; }
    }

    public class UpdateContactResponseResultType
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateContactInput
    {
        [JsonProperty("itemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemId { get; set; }

        [JsonProperty("contactName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("addressCity")]
        public string AddressCity { get; set; }

        [JsonProperty("addressState")]
        public string AddressState { get; set; }

        [JsonProperty("addressCountry")]
        public string AddressCountry { get; set; }

        [JsonProperty("addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [JsonProperty("phones")]
        public UpdateContactInputPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public UpdateContactInputEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("relation", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateContactInputRelationType Relation { get; set; }

        [JsonProperty("isPrimary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPrimary { get; set; }
    }

    public class UpdateContactInputPhonesTypeItem
    {
        [JsonProperty("phoneType")]
        public UpdateContactInputPhonesTypeItemPhoneTypeType? PhoneType { get; set; }

        [JsonProperty("countryCode")]
        public int? CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public int? AreaCode { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("extension")]
        public int? Extension { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateContactInputPhonesTypeItemPhoneTypeType
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "alternate")]
        Alternate,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public class UpdateContactInputEmailsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateContactInputRelationType
    {
        [EnumMember(Value = "spouse")]
        Spouse,
        [EnumMember(Value = "partner")]
        Partner,
        [EnumMember(Value = "child")]
        Child,
        [EnumMember(Value = "sibling")]
        Sibling,
        [EnumMember(Value = "parent")]
        Parent,
        [EnumMember(Value = "other")]
        Other
    }

    public class UpdateUserResponse
    {
        [JsonProperty("result")]
        public UpdateUserResponseResultTypeItem[] Result { get; set; }
    }

    public class UpdateUserResponseResultTypeItem
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class UpdateUserInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobileCountry")]
        public string MobileCountry { get; set; }

        [JsonProperty("mobileArea")]
        public string MobileArea { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adpemployeeselfservi;

    public partial class WorkflowManagedActions
    {
        public AdpemployeeselfserviActions Adpemployeeselfservi(string connectionId) => new AdpemployeeselfserviActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdpemployeeselfserviTriggers Adpemployeeselfservi(string connectionId) => new AdpemployeeselfserviTriggers(connectionId);
    }
}