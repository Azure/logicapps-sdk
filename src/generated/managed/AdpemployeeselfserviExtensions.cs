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
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodycontactName, Expression<Func<bodyrelationInput>> bodyrelation, Expression<Func<bool>> bodyisPrimary, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodyaddressLine3 = null, Expression<Func<string>> bodyaddressCity = null, Expression<Func<string>> bodyaddressState = null, Expression<Func<string>> bodyaddressCountry = null, Expression<Func<string>> bodyaddressPostalCode = null, Expression<Func<bodyphonesInputItem[]>> bodyphones = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodyrelation = WorkflowExpression.Compile(bodyrelation, nameof(bodyrelation), required: true);
            var __workflow_bodyisPrimary = WorkflowExpression.Compile(bodyisPrimary, nameof(bodyisPrimary), required: true);
            var __workflow_bodyaddressLine1 = WorkflowExpression.Compile(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = WorkflowExpression.Compile(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodyaddressLine3 = WorkflowExpression.Compile(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            var __workflow_bodyaddressCity = WorkflowExpression.Compile(bodyaddressCity, nameof(bodyaddressCity), required: false);
            var __workflow_bodyaddressState = WorkflowExpression.Compile(bodyaddressState, nameof(bodyaddressState), required: false);
            var __workflow_bodyaddressCountry = WorkflowExpression.Compile(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            var __workflow_bodyaddressPostalCode = WorkflowExpression.Compile(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            var __workflow_bodyphones = WorkflowExpression.Compile(bodyphones, nameof(bodyphones), required: false);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = "/api/create-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contactName"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                if (__workflow_bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine3 != null)
                {
                    body["addressLine3"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine3);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCity != null)
                {
                    body["addressCity"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressState != null)
                {
                    body["addressState"] = ExpressionConverter.ConvertO(__workflow_bodyaddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCountry != null)
                {
                    body["addressCountry"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressPostalCode != null)
                {
                    body["addressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyphones != null)
                {
                    body["phones"] = ExpressionConverter.ConvertO(__workflow_bodyphones);
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relation"] = ExpressionConverter.ConvertO(__workflow_bodyrelation);
                bodypropCount++;
                body["isPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<DeleteContactsResponse> DeleteContacts(Expression<Func<string[]>> bodyitemIds)
        {
            var __workflow_bodyitemIds = WorkflowExpression.Compile(bodyitemIds, nameof(bodyitemIds), required: true);
            return new DeferredBodyAction<DeleteContactsResponse>(() =>
            {
                var apiCallPath = "/api/delete-emergency-contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["itemIds"] = ExpressionConverter.ConvertO(__workflow_bodyitemIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteContactsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts()
        {
            var apiCallPath = "/api/get-emergency-contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetPayDistributionsResponse> GetPayDistributions()
        {
            var apiCallPath = "/api/get-pay-distributions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPayDistributionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetPayStatementsResponse> GetPayStatements()
        {
            var apiCallPath = "/api/get-pay-statements";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPayStatementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<GetUserResponse> GetUser()
        {
            var apiCallPath = "/api/get-worker";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact(Expression<Func<string>> bodyitemId, Expression<Func<string>> bodycontactName, Expression<Func<bodyrelationInput>> bodyrelation, Expression<Func<bool>> bodyisPrimary, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodyaddressLine3 = null, Expression<Func<string>> bodyaddressCity = null, Expression<Func<string>> bodyaddressState = null, Expression<Func<string>> bodyaddressCountry = null, Expression<Func<string>> bodyaddressPostalCode = null, Expression<Func<bodyphonesInputItem2[]>> bodyphones = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var __workflow_bodyitemId = WorkflowExpression.Compile(bodyitemId, nameof(bodyitemId), required: true);
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodyrelation = WorkflowExpression.Compile(bodyrelation, nameof(bodyrelation), required: true);
            var __workflow_bodyisPrimary = WorkflowExpression.Compile(bodyisPrimary, nameof(bodyisPrimary), required: true);
            var __workflow_bodyaddressLine1 = WorkflowExpression.Compile(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = WorkflowExpression.Compile(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodyaddressLine3 = WorkflowExpression.Compile(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            var __workflow_bodyaddressCity = WorkflowExpression.Compile(bodyaddressCity, nameof(bodyaddressCity), required: false);
            var __workflow_bodyaddressState = WorkflowExpression.Compile(bodyaddressState, nameof(bodyaddressState), required: false);
            var __workflow_bodyaddressCountry = WorkflowExpression.Compile(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            var __workflow_bodyaddressPostalCode = WorkflowExpression.Compile(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            var __workflow_bodyphones = WorkflowExpression.Compile(bodyphones, nameof(bodyphones), required: false);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<UpdateContactResponse>(() =>
            {
                var apiCallPath = "/api/update-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(__workflow_bodyitemId);
                bodypropCount++;
                body["contactName"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                if (__workflow_bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine3 != null)
                {
                    body["addressLine3"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine3);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCity != null)
                {
                    body["addressCity"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressState != null)
                {
                    body["addressState"] = ExpressionConverter.ConvertO(__workflow_bodyaddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressCountry != null)
                {
                    body["addressCountry"] = ExpressionConverter.ConvertO(__workflow_bodyaddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressPostalCode != null)
                {
                    body["addressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyphones != null)
                {
                    body["phones"] = ExpressionConverter.ConvertO(__workflow_bodyphones);
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relation"] = ExpressionConverter.ConvertO(__workflow_bodyrelation);
                bodypropCount++;
                body["isPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        public IBodyWorkflowAction<UpdateUserResponse> UpdateUser(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodymobileCountry = null, Expression<Func<string>> bodymobileArea = null, Expression<Func<string>> bodymobileNumber = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodymobileCountry = WorkflowExpression.Compile(bodymobileCountry, nameof(bodymobileCountry), required: false);
            var __workflow_bodymobileArea = WorkflowExpression.Compile(bodymobileArea, nameof(bodymobileArea), required: false);
            var __workflow_bodymobileNumber = WorkflowExpression.Compile(bodymobileNumber, nameof(bodymobileNumber), required: false);
            return new DeferredBodyAction<UpdateUserResponse>(() =>
            {
                var apiCallPath = "/api/update-profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodymobileCountry != null)
                {
                    body["mobileCountry"] = ExpressionConverter.ConvertO(__workflow_bodymobileCountry);
                    bodypropCount++;
                }

                if (__workflow_bodymobileArea != null)
                {
                    body["mobileArea"] = ExpressionConverter.ConvertO(__workflow_bodymobileArea);
                    bodypropCount++;
                }

                if (__workflow_bodymobileNumber != null)
                {
                    body["mobileNumber"] = ExpressionConverter.ConvertO(__workflow_bodymobileNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateUserResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrelationInput
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

    public class bodyphonesInputItem
    {
        [JsonProperty("phoneType")]
        public bodyphonesInputItemPhoneTypeType PhoneType { get; set; }

        [JsonProperty("countryCode")]
        public int CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public int AreaCode { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("extension")]
        public int Extension { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyphonesInputItemPhoneTypeType
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

    public class bodyemailsInputItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
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

    public class bodyphonesInputItem2
    {
        [JsonProperty("phoneType")]
        public bodyphonesInputItemPhoneTypeType PhoneType { get; set; }

        [JsonProperty("countryCode")]
        public int CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public int AreaCode { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("extension")]
        public int Extension { get; set; }
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
