//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmbasicdata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmbasicdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse> ApiEnterpriseGetEnterprises(Expression<Func<string>> searchParam, Expression<Func<int>> take, Expression<Func<int>> skip = null)
        {
            var apiCallPath = "/ApiEnterprise/GetEnterprises";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchParam"] = CSharpExpressionConverter.ConvertO(searchParam);
            callPayload.Queries["take"] = CSharpExpressionConverter.ConvertO(take);
            callPayload.Queries["skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<ApiEnterpriseGetEnterprisesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse> SetEnterpriseStatus(Expression<Func<int>> bodyenterpriseId, Expression<Func<int>> bodystatusId)
        {
            var apiCallPath = "/ApiEnterprise/SetEnterpriseStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["enterpriseId"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseId);
            bodypropCount++;
            body["statusId"] = CSharpExpressionConverter.ConvertToken(bodystatusId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetEnterpriseStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactCreateContactResponse> ApiContactCreateContact(Expression<Func<string>> bodyenterpriseReferenceNumber, Expression<Func<string>> bodyforeName, Expression<Func<string>> bodysurName, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyformOfAddress = null, Expression<Func<string>> bodyforeName2 = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodyexternalNumber = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodyinfoOnTicketView = null, Expression<Func<string>> bodyinfoOnServiceAssignment = null, Expression<Func<string>> bodyinfoOnTicketCreate = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<bool>> bodyisVip = null, Expression<Func<int>> bodyenterpriseContactType = null, Expression<Func<bool>> bodyisAddressFromMainEnterprise = null, Expression<Func<string>> bodyaddressstreet = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddresspostcode = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddressaddress3 = null, Expression<Func<string>> bodyaddresspostbox = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddresscountyShort = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresscountryName = null, Expression<Func<bodyphoneNumbersInputItem[]>> bodyphoneNumbers = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var apiCallPath = "/ApiContact/CreateContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["EnterpriseReferenceNumber"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseReferenceNumber);
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyformOfAddress != null)
            {
                body["formOfAddress"] = CSharpExpressionConverter.ConvertToken(bodyformOfAddress);
                bodypropCount++;
            }

            bodypropCount++;
            body["foreName"] = CSharpExpressionConverter.ConvertToken(bodyforeName);
            if (bodyforeName2 != null)
            {
                body["foreName2"] = CSharpExpressionConverter.ConvertToken(bodyforeName2);
                bodypropCount++;
            }

            bodypropCount++;
            body["surName"] = CSharpExpressionConverter.ConvertToken(bodysurName);
            if (bodysearchname != null)
            {
                body["searchname"] = CSharpExpressionConverter.ConvertToken(bodysearchname);
                bodypropCount++;
            }

            if (bodyexternalNumber != null)
            {
                body["externalNumber"] = CSharpExpressionConverter.ConvertToken(bodyexternalNumber);
                bodypropCount++;
            }

            if (bodyinitials != null)
            {
                body["Initials"] = CSharpExpressionConverter.ConvertToken(bodyinitials);
                bodypropCount++;
            }

            if (bodymemo != null)
            {
                body["memo"] = CSharpExpressionConverter.ConvertToken(bodymemo);
                bodypropCount++;
            }

            if (bodyinfoOnTicketView != null)
            {
                body["InfoOnTicketView"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnTicketView);
                bodypropCount++;
            }

            if (bodyinfoOnServiceAssignment != null)
            {
                body["InfoOnServiceAssignment"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnServiceAssignment);
                bodypropCount++;
            }

            if (bodyinfoOnTicketCreate != null)
            {
                body["InfoOnTicketCreate"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnTicketCreate);
                bodypropCount++;
            }

            if (bodydepartmentName != null)
            {
                body["departmentName"] = CSharpExpressionConverter.ConvertToken(bodydepartmentName);
                bodypropCount++;
            }

            if (bodyisVip != null)
            {
                body["IsVip"] = CSharpExpressionConverter.ConvertToken(bodyisVip);
                bodypropCount++;
            }

            if (bodyenterpriseContactType != null)
            {
                body["enterpriseContactType"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseContactType);
                bodypropCount++;
            }

            if (bodyisAddressFromMainEnterprise != null)
            {
                if (bodyisAddressFromMainEnterprise != null)
                {
                    body["IsAddressFromMainEnterprise"] = CSharpExpressionConverter.ConvertToken(bodyisAddressFromMainEnterprise);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["IsAddressFromMainEnterprise"] = true;
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressstreet != null)
            {
                addressObject["street"] = CSharpExpressionConverter.ConvertToken(bodyaddressstreet);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddresspostcode != null)
            {
                addressObject["postcode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostcode);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress3 != null)
            {
                addressObject["address3"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress3);
                addressObjectpropCount++;
            }

            if (bodyaddresspostbox != null)
            {
                addressObject["postbox"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostbox);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = CSharpExpressionConverter.ConvertToken(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddresscountyShort != null)
            {
                addressObject["countyShort"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountyShort);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryName != null)
            {
                addressObject["countryName"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryName);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodyphoneNumbers != null)
            {
                body["PhoneNumbers"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumbers);
                bodypropCount++;
            }

            if (bodyemails != null)
            {
                body["Emails"] = CSharpExpressionConverter.ConvertToken(bodyemails);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiContactCreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse> ApiContactUpdateContact(Expression<Func<string>> bodyenterpriseReferenceNumber, Expression<Func<string>> bodyforeName, Expression<Func<string>> bodysurName, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyformOfAddress = null, Expression<Func<string>> bodyforeName2 = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodyexternalNumber = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodyinfoOnTicketView = null, Expression<Func<string>> bodyinfoOnServiceAssignment = null, Expression<Func<string>> bodyinfoOnTicketCreate = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<bool>> bodyisVip = null, Expression<Func<bool>> bodyisAddressFromMainEnterprise = null, Expression<Func<string>> bodyaddressstreet = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddresspostcode = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddressaddress3 = null, Expression<Func<string>> bodyaddresspostbox = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddresscountyShort = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresscountryName = null, Expression<Func<bodyphoneNumbersInputItem[]>> bodyphoneNumbers = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var apiCallPath = "/ApiContact/UpdateContact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactId != null)
            {
                body["contactId"] = CSharpExpressionConverter.ConvertToken(bodycontactId);
                bodypropCount++;
            }

            bodypropCount++;
            body["EnterpriseReferenceNumber"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseReferenceNumber);
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyformOfAddress != null)
            {
                body["formOfAddress"] = CSharpExpressionConverter.ConvertToken(bodyformOfAddress);
                bodypropCount++;
            }

            bodypropCount++;
            body["foreName"] = CSharpExpressionConverter.ConvertToken(bodyforeName);
            if (bodyforeName2 != null)
            {
                body["foreName2"] = CSharpExpressionConverter.ConvertToken(bodyforeName2);
                bodypropCount++;
            }

            bodypropCount++;
            body["surName"] = CSharpExpressionConverter.ConvertToken(bodysurName);
            if (bodysearchname != null)
            {
                body["searchname"] = CSharpExpressionConverter.ConvertToken(bodysearchname);
                bodypropCount++;
            }

            if (bodyexternalNumber != null)
            {
                body["externalNumber"] = CSharpExpressionConverter.ConvertToken(bodyexternalNumber);
                bodypropCount++;
            }

            if (bodyinitials != null)
            {
                body["Initials"] = CSharpExpressionConverter.ConvertToken(bodyinitials);
                bodypropCount++;
            }

            if (bodymemo != null)
            {
                body["memo"] = CSharpExpressionConverter.ConvertToken(bodymemo);
                bodypropCount++;
            }

            if (bodyinfoOnTicketView != null)
            {
                body["InfoOnTicketView"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnTicketView);
                bodypropCount++;
            }

            if (bodyinfoOnServiceAssignment != null)
            {
                body["InfoOnServiceAssignment"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnServiceAssignment);
                bodypropCount++;
            }

            if (bodyinfoOnTicketCreate != null)
            {
                body["InfoOnTicketCreate"] = CSharpExpressionConverter.ConvertToken(bodyinfoOnTicketCreate);
                bodypropCount++;
            }

            if (bodydepartmentName != null)
            {
                body["departmentName"] = CSharpExpressionConverter.ConvertToken(bodydepartmentName);
                bodypropCount++;
            }

            if (bodyisVip != null)
            {
                body["IsVip"] = CSharpExpressionConverter.ConvertToken(bodyisVip);
                bodypropCount++;
            }

            if (bodyisAddressFromMainEnterprise != null)
            {
                if (bodyisAddressFromMainEnterprise != null)
                {
                    body["IsAddressFromMainEnterprise"] = CSharpExpressionConverter.ConvertToken(bodyisAddressFromMainEnterprise);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["IsAddressFromMainEnterprise"] = true;
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressstreet != null)
            {
                addressObject["street"] = CSharpExpressionConverter.ConvertToken(bodyaddressstreet);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddresspostcode != null)
            {
                addressObject["postcode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostcode);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress3 != null)
            {
                addressObject["address3"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress3);
                addressObjectpropCount++;
            }

            if (bodyaddresspostbox != null)
            {
                addressObject["postbox"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostbox);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = CSharpExpressionConverter.ConvertToken(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddresscountyShort != null)
            {
                addressObject["countyShort"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountyShort);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryName != null)
            {
                addressObject["countryName"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryName);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodyphoneNumbers != null)
            {
                body["PhoneNumbers"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumbers);
                bodypropCount++;
            }

            if (bodyemails != null)
            {
                body["Emails"] = CSharpExpressionConverter.ConvertToken(bodyemails);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiContactUpdateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactGetContactsResponse> ApiContactGetContacts(Expression<Func<int>> take, Expression<Func<string>> searchParam, Expression<Func<string>> filter = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = "/ApiContact/GetContacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["Filter"] = CSharpExpressionConverter.ConvertO(filter);
            callPayload.Queries["take"] = CSharpExpressionConverter.ConvertO(take);
            callPayload.Queries["skip"] = Convert.ToString(0);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            callPayload.Queries["searchParam"] = CSharpExpressionConverter.ConvertO(searchParam);
            return new ApiConnectionAction<ApiContactGetContactsResponse>(callPayload);
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
        public int GlobalAddressID { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string CountyShort { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CountryID { get; set; }
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

    public class ApiContactCreateContactResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public int ContactId { get; set; }
    }

    public class bodyphoneNumbersInputItem
    {
        public string Number { get; set; }
        public string Name { get; set; }
    }

    public class bodyemailsInputItem
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
        public int GlobalAddressID { get; set; }
        public string Street { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string CountyShort { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CountryID { get; set; }
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