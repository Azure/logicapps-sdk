//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmbasicdata
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmbasicdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse, ApiConnectionActionConfiguration> ApiEnterpriseGetEnterprises(Expression<Func<string>> searchParam, Expression<Func<int>> take, Expression<Func<int>> skip = null)
        {
            var __workflow_searchParam = WorkflowExpression.Compile(searchParam, nameof(searchParam), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ApiEnterpriseGetEnterprisesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiEnterprise/GetEnterprises";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchParam"] = ExpressionConverter.Convert(__workflow_searchParam);
                callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<ApiEnterpriseGetEnterprisesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse, ApiConnectionActionConfiguration> SetEnterpriseStatus(Expression<Func<SetEnterpriseStatusInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetEnterpriseStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiEnterprise/SetEnterpriseStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetEnterpriseStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactCreateContactResponse, ApiConnectionActionConfiguration> ApiContactCreateContact(Expression<Func<ApiContactCreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ApiContactCreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiContact/CreateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiContactCreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse, ApiConnectionActionConfiguration> ApiContactUpdateContact(Expression<Func<ApiContactUpdateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ApiContactUpdateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiContact/UpdateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiContactUpdateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactGetContactsResponse, ApiConnectionActionConfiguration> ApiContactGetContacts(Expression<Func<int>> take, Expression<Func<string>> searchParam, Expression<Func<string>> filter = null, Expression<Func<int>> skip = null)
        {
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: true);
            var __workflow_searchParam = WorkflowExpression.Compile(searchParam, nameof(searchParam), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ApiContactGetContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiContact/GetContacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["Filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["searchParam"] = ExpressionConverter.Convert(__workflow_searchParam);
                return new ApiConnectionAction<ApiContactGetContactsResponse>(callPayload);
            });
        }
    }

    public class TesseronasmbasicdataTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiEnterpriseGetEnterprisesResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public int Count { get; set; }
        public int Filtered { get; set; }
        public ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItem[] Enterprises { get; set; }
    }

    public class ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItem
    {
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public string EnterpriseName2 { get; set; }

        [JsonProperty("businessPartnerId")]
        public string BusinessPartnerId { get; set; }
        public string MailDomain { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string EnterpriseAbbreviation { get; set; }
        public string EnterpriseGroup { get; set; }
        public string CreationDate { get; set; }
        public string AlterationDate { get; set; }
        public string FreeTextFieldSearch1 { get; set; }
        public string MemoField { get; set; }
        public string TicketWizardInfo { get; set; }
        public string TicketInfo { get; set; }
        public string TicketInvoiceInfo { get; set; }
        public int UserCreator { get; set; }
        public string UserNameCreator { get; set; }
        public int UserEditor { get; set; }
        public string UserNameEditor { get; set; }
        public string Webpage { get; set; }
        public int Priority { get; set; }
        public string UstIdNr { get; set; }
        public string TradingRegistryNr { get; set; }
        public string ExternalNumber { get; set; }
        public int ResponsibleUserFirst { get; set; }
        public string ResponsibleUserFirstName { get; set; }
        public int ResponsibleUserSecond { get; set; }
        public string ResponsibleUserSecondName { get; set; }
        public string EnterpriseBranchName { get; set; }
        public int EnterpriseBranchTypeId { get; set; }
        public ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemPhoneNumbersTypeItem[] PhoneNumbers { get; set; }
        public ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemEmailsTypeItem[] Emails { get; set; }
        public ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemAddressesTypeItem[] Addresses { get; set; }
    }

    public class ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemPhoneNumbersTypeItem
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
    }

    public class ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemEmailsTypeItem
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class ApiEnterpriseGetEnterprisesResponseEnterprisesTypeItemAddressesTypeItem
    {
        [JsonProperty("GlobalAddressID")]
        public int GlobalAddressId { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string CountyShort { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postbox { get; set; }
    }

    public class SetEnterpriseStatusResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int[] EnterpriseId { get; set; }
    }

    public class SetEnterpriseStatusInput
    {
        [JsonProperty("enterpriseId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EnterpriseId { get; set; }

        [JsonProperty("statusId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int StatusId { get; set; }
    }

    public class ApiContactCreateContactResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public int ContactId { get; set; }
    }

    public class ApiContactCreateContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnterpriseReferenceNumber { get; set; }
        public string Title { get; set; }

        [JsonProperty("formOfAddress")]
        public string FormOfAddress { get; set; }

        [JsonProperty("foreName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ForeName { get; set; }

        [JsonProperty("foreName2")]
        public string ForeName2 { get; set; }

        [JsonProperty("surName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SurName { get; set; }

        [JsonProperty("searchname")]
        public string Searchname { get; set; }

        [JsonProperty("externalNumber")]
        public string ExternalNumber { get; set; }
        public string Initials { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }
        public string InfoOnTicketView { get; set; }
        public string InfoOnServiceAssignment { get; set; }
        public string InfoOnTicketCreate { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }
        public bool? IsVip { get; set; }

        [JsonProperty("enterpriseContactType")]
        public int? EnterpriseContactType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAddressFromMainEnterprise { get; set; } = true;

        [JsonProperty("address")]
        public ApiContactCreateContactInputAddressType Address { get; set; }
        public ApiContactCreateContactInputPhoneNumbersTypeItem[] PhoneNumbers { get; set; }
        public ApiContactCreateContactInputEmailsTypeItem[] Emails { get; set; }
    }

    public class ApiContactCreateContactInputAddressType
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("postbox")]
        public string Postbox { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("countyShort")]
        public string CountyShort { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    public class ApiContactCreateContactInputPhoneNumbersTypeItem
    {
        public string Number { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactCreateContactInputEmailsTypeItem
    {
        public string EMail { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactUpdateContactResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public int ContactId { get; set; }
    }

    public class ApiContactUpdateContactInput
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnterpriseReferenceNumber { get; set; }
        public string Title { get; set; }

        [JsonProperty("formOfAddress")]
        public string FormOfAddress { get; set; }

        [JsonProperty("foreName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ForeName { get; set; }

        [JsonProperty("foreName2")]
        public string ForeName2 { get; set; }

        [JsonProperty("surName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SurName { get; set; }

        [JsonProperty("searchname")]
        public string Searchname { get; set; }

        [JsonProperty("externalNumber")]
        public string ExternalNumber { get; set; }
        public string Initials { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }
        public string InfoOnTicketView { get; set; }
        public string InfoOnServiceAssignment { get; set; }
        public string InfoOnTicketCreate { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }
        public bool? IsVip { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAddressFromMainEnterprise { get; set; } = true;

        [JsonProperty("address")]
        public ApiContactUpdateContactInputAddressType Address { get; set; }
        public ApiContactUpdateContactInputPhoneNumbersTypeItem[] PhoneNumbers { get; set; }
        public ApiContactUpdateContactInputEmailsTypeItem[] Emails { get; set; }
    }

    public class ApiContactUpdateContactInputAddressType
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("postbox")]
        public string Postbox { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("countyShort")]
        public string CountyShort { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    public class ApiContactUpdateContactInputPhoneNumbersTypeItem
    {
        public string Number { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactUpdateContactInputEmailsTypeItem
    {
        public string EMail { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactGetContactsResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }
        public int Filtered { get; set; }
        public int StatusCode { get; set; }
        public ApiContactGetContactsResponseContactsTypeItem[] Contacts { get; set; }
    }

    public class ApiContactGetContactsResponseContactsTypeItem
    {
        public int ContactId { get; set; }
        public string FormOfAddress { get; set; }
        public string ForeName { get; set; }
        public string ForeName2 { get; set; }
        public string SureName { get; set; }
        public string SearchName { get; set; }
        public string Status { get; set; }
        public string Initials { get; set; }
        public string Title { get; set; }
        public bool IsVIP { get; set; }
        public string Memo { get; set; }
        public string Responsibilities { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public string BusinessPartnerId { get; set; }
        public string ExternalNumber { get; set; }
        public ApiContactGetContactsResponseContactsTypeItemPhoneNumbersTypeItem[] PhoneNumbers { get; set; }
        public ApiContactGetContactsResponseContactsTypeItemEmailsTypeItem[] Emails { get; set; }
        public ApiContactGetContactsResponseContactsTypeItemAddressesTypeItem[] Addresses { get; set; }
        public bool IsAddressFromMainEnterprise { get; set; }
    }

    public class ApiContactGetContactsResponseContactsTypeItemPhoneNumbersTypeItem
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactGetContactsResponseContactsTypeItemEmailsTypeItem
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }

    public class ApiContactGetContactsResponseContactsTypeItemAddressesTypeItem
    {
        [JsonProperty("GlobalAddressID")]
        public int GlobalAddressId { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string CountyShort { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postbox { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmbasicdata;

    public partial class WorkflowManagedActions
    {
        public TesseronasmbasicdataActions Tesseronasmbasicdata(string connectionId) => new TesseronasmbasicdataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TesseronasmbasicdataTriggers Tesseronasmbasicdata(string connectionId) => new TesseronasmbasicdataTriggers(connectionId);
    }
}