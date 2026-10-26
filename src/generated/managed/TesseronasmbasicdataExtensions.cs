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
        public IBodyWorkflowAction<SetEnterpriseStatusResponse, ApiConnectionActionConfiguration> SetEnterpriseStatus(Expression<Func<int>> bodyenterpriseId, Expression<Func<int>> bodystatusId)
        {
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: true);
            return new DeferredBodyAction<SetEnterpriseStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiEnterprise/SetEnterpriseStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                bodypropCount++;
                body["statusId"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetEnterpriseStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactCreateContactResponse, ApiConnectionActionConfiguration> ApiContactCreateContact(Expression<Func<string>> bodyenterpriseReferenceNumber, Expression<Func<string>> bodyforeName, Expression<Func<string>> bodysurName, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyformOfAddress = null, Expression<Func<string>> bodyforeName2 = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodyexternalNumber = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodyinfoOnTicketView = null, Expression<Func<string>> bodyinfoOnServiceAssignment = null, Expression<Func<string>> bodyinfoOnTicketCreate = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<bool>> bodyisVip = null, Expression<Func<int>> bodyenterpriseContactType = null, Expression<Func<bool>> bodyisAddressFromMainEnterprise = null, Expression<Func<string>> bodyaddressstreet = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddresspostcode = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddressaddress3 = null, Expression<Func<string>> bodyaddresspostbox = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddresscountyShort = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresscountryName = null, Expression<Func<bodyphoneNumbersInputItem[]>> bodyphoneNumbers = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var __workflow_bodyenterpriseReferenceNumber = WorkflowExpression.Compile(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            var __workflow_bodyforeName = WorkflowExpression.Compile(bodyforeName, nameof(bodyforeName), required: true);
            var __workflow_bodysurName = WorkflowExpression.Compile(bodysurName, nameof(bodysurName), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyformOfAddress = WorkflowExpression.Compile(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            var __workflow_bodyforeName2 = WorkflowExpression.Compile(bodyforeName2, nameof(bodyforeName2), required: false);
            var __workflow_bodysearchname = WorkflowExpression.Compile(bodysearchname, nameof(bodysearchname), required: false);
            var __workflow_bodyexternalNumber = WorkflowExpression.Compile(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            var __workflow_bodyinitials = WorkflowExpression.Compile(bodyinitials, nameof(bodyinitials), required: false);
            var __workflow_bodymemo = WorkflowExpression.Compile(bodymemo, nameof(bodymemo), required: false);
            var __workflow_bodyinfoOnTicketView = WorkflowExpression.Compile(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            var __workflow_bodyinfoOnServiceAssignment = WorkflowExpression.Compile(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            var __workflow_bodyinfoOnTicketCreate = WorkflowExpression.Compile(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodyisVip = WorkflowExpression.Compile(bodyisVip, nameof(bodyisVip), required: false);
            var __workflow_bodyenterpriseContactType = WorkflowExpression.Compile(bodyenterpriseContactType, nameof(bodyenterpriseContactType), required: false);
            var __workflow_bodyisAddressFromMainEnterprise = WorkflowExpression.Compile(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            var __workflow_bodyaddressstreet = WorkflowExpression.Compile(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddresspostcode = WorkflowExpression.Compile(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddressaddress3 = WorkflowExpression.Compile(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            var __workflow_bodyaddresspostbox = WorkflowExpression.Compile(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddresscountyShort = WorkflowExpression.Compile(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresscountryName = WorkflowExpression.Compile(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            var __workflow_bodyphoneNumbers = WorkflowExpression.Compile(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<ApiContactCreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiContact/CreateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["EnterpriseReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseReferenceNumber);
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyformOfAddress != null)
                {
                    body["formOfAddress"] = ExpressionConverter.ConvertO(__workflow_bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = ExpressionConverter.ConvertO(__workflow_bodyforeName);
                if (__workflow_bodyforeName2 != null)
                {
                    body["foreName2"] = ExpressionConverter.ConvertO(__workflow_bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = ExpressionConverter.ConvertO(__workflow_bodysurName);
                if (__workflow_bodysearchname != null)
                {
                    body["searchname"] = ExpressionConverter.ConvertO(__workflow_bodysearchname);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalNumber != null)
                {
                    body["externalNumber"] = ExpressionConverter.ConvertO(__workflow_bodyexternalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyinitials != null)
                {
                    body["Initials"] = ExpressionConverter.ConvertO(__workflow_bodyinitials);
                    bodypropCount++;
                }

                if (__workflow_bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(__workflow_bodymemo);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodyisVip != null)
                {
                    body["IsVip"] = ExpressionConverter.ConvertO(__workflow_bodyisVip);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseContactType != null)
                {
                    body["enterpriseContactType"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseContactType);
                    bodypropCount++;
                }

                if (__workflow_bodyisAddressFromMainEnterprise != null)
                {
                    if (__workflow_bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = ExpressionConverter.ConvertO(__workflow_bodyisAddressFromMainEnterprise);
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
                if (__workflow_bodyaddressstreet != null)
                {
                    addressObject["street"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumbers);
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["Emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiContactCreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse, ApiConnectionActionConfiguration> ApiContactUpdateContact(Expression<Func<string>> bodyenterpriseReferenceNumber, Expression<Func<string>> bodyforeName, Expression<Func<string>> bodysurName, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyformOfAddress = null, Expression<Func<string>> bodyforeName2 = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodyexternalNumber = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodyinfoOnTicketView = null, Expression<Func<string>> bodyinfoOnServiceAssignment = null, Expression<Func<string>> bodyinfoOnTicketCreate = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<bool>> bodyisVip = null, Expression<Func<bool>> bodyisAddressFromMainEnterprise = null, Expression<Func<string>> bodyaddressstreet = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddresspostcode = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddressaddress3 = null, Expression<Func<string>> bodyaddresspostbox = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddresscountyShort = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresscountryName = null, Expression<Func<bodyphoneNumbersInputItem[]>> bodyphoneNumbers = null, Expression<Func<bodyemailsInputItem[]>> bodyemails = null)
        {
            var __workflow_bodyenterpriseReferenceNumber = WorkflowExpression.Compile(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            var __workflow_bodyforeName = WorkflowExpression.Compile(bodyforeName, nameof(bodyforeName), required: true);
            var __workflow_bodysurName = WorkflowExpression.Compile(bodysurName, nameof(bodysurName), required: true);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyformOfAddress = WorkflowExpression.Compile(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            var __workflow_bodyforeName2 = WorkflowExpression.Compile(bodyforeName2, nameof(bodyforeName2), required: false);
            var __workflow_bodysearchname = WorkflowExpression.Compile(bodysearchname, nameof(bodysearchname), required: false);
            var __workflow_bodyexternalNumber = WorkflowExpression.Compile(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            var __workflow_bodyinitials = WorkflowExpression.Compile(bodyinitials, nameof(bodyinitials), required: false);
            var __workflow_bodymemo = WorkflowExpression.Compile(bodymemo, nameof(bodymemo), required: false);
            var __workflow_bodyinfoOnTicketView = WorkflowExpression.Compile(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            var __workflow_bodyinfoOnServiceAssignment = WorkflowExpression.Compile(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            var __workflow_bodyinfoOnTicketCreate = WorkflowExpression.Compile(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodyisVip = WorkflowExpression.Compile(bodyisVip, nameof(bodyisVip), required: false);
            var __workflow_bodyisAddressFromMainEnterprise = WorkflowExpression.Compile(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            var __workflow_bodyaddressstreet = WorkflowExpression.Compile(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddresspostcode = WorkflowExpression.Compile(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddressaddress3 = WorkflowExpression.Compile(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            var __workflow_bodyaddresspostbox = WorkflowExpression.Compile(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddresscountyShort = WorkflowExpression.Compile(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresscountryName = WorkflowExpression.Compile(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            var __workflow_bodyphoneNumbers = WorkflowExpression.Compile(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<ApiContactUpdateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ApiContact/UpdateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EnterpriseReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseReferenceNumber);
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyformOfAddress != null)
                {
                    body["formOfAddress"] = ExpressionConverter.ConvertO(__workflow_bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = ExpressionConverter.ConvertO(__workflow_bodyforeName);
                if (__workflow_bodyforeName2 != null)
                {
                    body["foreName2"] = ExpressionConverter.ConvertO(__workflow_bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = ExpressionConverter.ConvertO(__workflow_bodysurName);
                if (__workflow_bodysearchname != null)
                {
                    body["searchname"] = ExpressionConverter.ConvertO(__workflow_bodysearchname);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalNumber != null)
                {
                    body["externalNumber"] = ExpressionConverter.ConvertO(__workflow_bodyexternalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyinitials != null)
                {
                    body["Initials"] = ExpressionConverter.ConvertO(__workflow_bodyinitials);
                    bodypropCount++;
                }

                if (__workflow_bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(__workflow_bodymemo);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = ExpressionConverter.ConvertO(__workflow_bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodyisVip != null)
                {
                    body["IsVip"] = ExpressionConverter.ConvertO(__workflow_bodyisVip);
                    bodypropCount++;
                }

                if (__workflow_bodyisAddressFromMainEnterprise != null)
                {
                    if (__workflow_bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = ExpressionConverter.ConvertO(__workflow_bodyisAddressFromMainEnterprise);
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
                if (__workflow_bodyaddressstreet != null)
                {
                    addressObject["street"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumbers);
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["Emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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