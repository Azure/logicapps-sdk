//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adpemployeeselfservi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdpemployeeselfserviActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> bodycontactName, [WorkflowExpression] Func<bodyrelationInput> bodyrelation, [WorkflowExpression] Func<bool> bodyisPrimary, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodyaddressLine3 = null, [WorkflowExpression] Func<string> bodyaddressCity = null, [WorkflowExpression] Func<string> bodyaddressState = null, [WorkflowExpression] Func<string> bodyaddressCountry = null, [WorkflowExpression] Func<string> bodyaddressPostalCode = null, [WorkflowExpression] Func<bodyphonesInputItem[]> bodyphones = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowValue<string> bodycontactName, WorkflowValue<bodyrelationInput> bodyrelation, WorkflowValue<bool> bodyisPrimary, WorkflowValue<string> bodyaddressLine1 = null, WorkflowValue<string> bodyaddressLine2 = null, WorkflowValue<string> bodyaddressLine3 = null, WorkflowValue<string> bodyaddressCity = null, WorkflowValue<string> bodyaddressState = null, WorkflowValue<string> bodyaddressCountry = null, WorkflowValue<string> bodyaddressPostalCode = null, WorkflowValue<bodyphonesInputItem[]> bodyphones = null, WorkflowValue<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowValue.Validate(bodycontactName, nameof(bodycontactName), required: true);
            WorkflowValue.Validate(bodyrelation, nameof(bodyrelation), required: true);
            WorkflowValue.Validate(bodyisPrimary, nameof(bodyisPrimary), required: true);
            WorkflowValue.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowValue.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowValue.Validate(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            WorkflowValue.Validate(bodyaddressCity, nameof(bodyaddressCity), required: false);
            WorkflowValue.Validate(bodyaddressState, nameof(bodyaddressState), required: false);
            WorkflowValue.Validate(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            WorkflowValue.Validate(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            WorkflowValue.Validate(bodyphones, nameof(bodyphones), required: false);
            WorkflowValue.Validate(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = "/api/create-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contactName"] = ExpressionConverter.ConvertO(bodycontactName);
                if (bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodyaddressLine3 != null)
                {
                    body["addressLine3"] = ExpressionConverter.ConvertO(bodyaddressLine3);
                    bodypropCount++;
                }

                if (bodyaddressCity != null)
                {
                    body["addressCity"] = ExpressionConverter.ConvertO(bodyaddressCity);
                    bodypropCount++;
                }

                if (bodyaddressState != null)
                {
                    body["addressState"] = ExpressionConverter.ConvertO(bodyaddressState);
                    bodypropCount++;
                }

                if (bodyaddressCountry != null)
                {
                    body["addressCountry"] = ExpressionConverter.ConvertO(bodyaddressCountry);
                    bodypropCount++;
                }

                if (bodyaddressPostalCode != null)
                {
                    body["addressPostalCode"] = ExpressionConverter.ConvertO(bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (bodyphones != null)
                {
                    body["phones"] = ExpressionConverter.ConvertO(bodyphones);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relation"] = ExpressionConverter.ConvertO(bodyrelation);
                bodypropCount++;
                body["isPrimary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteContacts))]
        public IBodyWorkflowAction<DeleteContactsResponse> DeleteContacts([WorkflowExpression] Func<string[]> bodyitemIds)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteContactsResponse> __BuildDeleteContacts(WorkflowValue<string[]> bodyitemIds)
        {
            WorkflowValue.Validate(bodyitemIds, nameof(bodyitemIds), required: true);
            return new DeferredBodyAction<DeleteContactsResponse>(() =>
            {
                var apiCallPath = "/api/delete-emergency-contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["itemIds"] = ExpressionConverter.ConvertO(bodyitemIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteContactsResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateContact))]
        public IBodyWorkflowAction<UpdateContactResponse> UpdateContact([WorkflowExpression] Func<string> bodyitemId, [WorkflowExpression] Func<string> bodycontactName, [WorkflowExpression] Func<bodyrelationInput> bodyrelation, [WorkflowExpression] Func<bool> bodyisPrimary, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodyaddressLine3 = null, [WorkflowExpression] Func<string> bodyaddressCity = null, [WorkflowExpression] Func<string> bodyaddressState = null, [WorkflowExpression] Func<string> bodyaddressCountry = null, [WorkflowExpression] Func<string> bodyaddressPostalCode = null, [WorkflowExpression] Func<bodyphonesInputItem2[]> bodyphones = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateContactResponse> __BuildUpdateContact(WorkflowValue<string> bodyitemId, WorkflowValue<string> bodycontactName, WorkflowValue<bodyrelationInput> bodyrelation, WorkflowValue<bool> bodyisPrimary, WorkflowValue<string> bodyaddressLine1 = null, WorkflowValue<string> bodyaddressLine2 = null, WorkflowValue<string> bodyaddressLine3 = null, WorkflowValue<string> bodyaddressCity = null, WorkflowValue<string> bodyaddressState = null, WorkflowValue<string> bodyaddressCountry = null, WorkflowValue<string> bodyaddressPostalCode = null, WorkflowValue<bodyphonesInputItem2[]> bodyphones = null, WorkflowValue<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowValue.Validate(bodyitemId, nameof(bodyitemId), required: true);
            WorkflowValue.Validate(bodycontactName, nameof(bodycontactName), required: true);
            WorkflowValue.Validate(bodyrelation, nameof(bodyrelation), required: true);
            WorkflowValue.Validate(bodyisPrimary, nameof(bodyisPrimary), required: true);
            WorkflowValue.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowValue.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowValue.Validate(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            WorkflowValue.Validate(bodyaddressCity, nameof(bodyaddressCity), required: false);
            WorkflowValue.Validate(bodyaddressState, nameof(bodyaddressState), required: false);
            WorkflowValue.Validate(bodyaddressCountry, nameof(bodyaddressCountry), required: false);
            WorkflowValue.Validate(bodyaddressPostalCode, nameof(bodyaddressPostalCode), required: false);
            WorkflowValue.Validate(bodyphones, nameof(bodyphones), required: false);
            WorkflowValue.Validate(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<UpdateContactResponse>(() =>
            {
                var apiCallPath = "/api/update-emergency-contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["itemId"] = ExpressionConverter.ConvertO(bodyitemId);
                bodypropCount++;
                body["contactName"] = ExpressionConverter.ConvertO(bodycontactName);
                if (bodyaddressLine1 != null)
                {
                    body["addressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["addressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodyaddressLine3 != null)
                {
                    body["addressLine3"] = ExpressionConverter.ConvertO(bodyaddressLine3);
                    bodypropCount++;
                }

                if (bodyaddressCity != null)
                {
                    body["addressCity"] = ExpressionConverter.ConvertO(bodyaddressCity);
                    bodypropCount++;
                }

                if (bodyaddressState != null)
                {
                    body["addressState"] = ExpressionConverter.ConvertO(bodyaddressState);
                    bodypropCount++;
                }

                if (bodyaddressCountry != null)
                {
                    body["addressCountry"] = ExpressionConverter.ConvertO(bodyaddressCountry);
                    bodypropCount++;
                }

                if (bodyaddressPostalCode != null)
                {
                    body["addressPostalCode"] = ExpressionConverter.ConvertO(bodyaddressPostalCode);
                    bodypropCount++;
                }

                if (bodyphones != null)
                {
                    body["phones"] = ExpressionConverter.ConvertO(bodyphones);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relation"] = ExpressionConverter.ConvertO(bodyrelation);
                bodypropCount++;
                body["isPrimary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adpemployeeselfservi")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateUser))]
        public IBodyWorkflowAction<UpdateUserResponse> UpdateUser([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodymobileCountry = null, [WorkflowExpression] Func<string> bodymobileArea = null, [WorkflowExpression] Func<string> bodymobileNumber = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateUserResponse> __BuildUpdateUser(WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodymobileCountry = null, WorkflowValue<string> bodymobileArea = null, WorkflowValue<string> bodymobileNumber = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodymobileCountry, nameof(bodymobileCountry), required: false);
            WorkflowValue.Validate(bodymobileArea, nameof(bodymobileArea), required: false);
            WorkflowValue.Validate(bodymobileNumber, nameof(bodymobileNumber), required: false);
            return new DeferredBodyAction<UpdateUserResponse>(() =>
            {
                var apiCallPath = "/api/update-profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodymobileCountry != null)
                {
                    body["mobileCountry"] = ExpressionConverter.ConvertO(bodymobileCountry);
                    bodypropCount++;
                }

                if (bodymobileArea != null)
                {
                    body["mobileArea"] = ExpressionConverter.ConvertO(bodymobileArea);
                    bodypropCount++;
                }

                if (bodymobileNumber != null)
                {
                    body["mobileNumber"] = ExpressionConverter.ConvertO(bodymobileNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
