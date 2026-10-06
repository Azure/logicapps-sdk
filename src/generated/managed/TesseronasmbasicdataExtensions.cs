//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasmbasicdata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronasmbasicdataActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [WorkflowExpressionFactory(nameof(__BuildApiEnterpriseGetEnterprises))]
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse> ApiEnterpriseGetEnterprises([WorkflowExpression] Func<string> searchParam, [WorkflowExpression] Func<int> take, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse> __BuildApiEnterpriseGetEnterprises(WorkflowExpression<string> searchParam, WorkflowExpression<int> take, WorkflowExpression<int> skip = null)
        {
            WorkflowExpression.Validate(searchParam, nameof(searchParam), required: true);
            WorkflowExpression.Validate(take, nameof(take), required: true);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ApiEnterpriseGetEnterprisesResponse>(() =>
            {
                var apiCallPath = "/ApiEnterprise/GetEnterprises";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchParam"] = ExpressionConverter.Convert(searchParam);
                callPayload.Queries["take"] = ExpressionConverter.Convert(take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionAction<ApiEnterpriseGetEnterprisesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [WorkflowExpressionFactory(nameof(__BuildSetEnterpriseStatus))]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse> SetEnterpriseStatus([WorkflowExpression] Func<int> bodyenterpriseId, [WorkflowExpression] Func<int> bodystatusId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse> __BuildSetEnterpriseStatus(WorkflowExpression<int> bodyenterpriseId, WorkflowExpression<int> bodystatusId)
        {
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            WorkflowExpression.Validate(bodystatusId, nameof(bodystatusId), required: true);
            return new DeferredBodyAction<SetEnterpriseStatusResponse>(() =>
            {
                var apiCallPath = "/ApiEnterprise/SetEnterpriseStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                bodypropCount++;
                body["statusId"] = ExpressionConverter.ConvertO(bodystatusId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetEnterpriseStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [WorkflowExpressionFactory(nameof(__BuildApiContactCreateContact))]
        public IBodyWorkflowAction<ApiContactCreateContactResponse> ApiContactCreateContact([WorkflowExpression] Func<string> bodyenterpriseReferenceNumber, [WorkflowExpression] Func<string> bodyforeName, [WorkflowExpression] Func<string> bodysurName, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyformOfAddress = null, [WorkflowExpression] Func<string> bodyforeName2 = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodyexternalNumber = null, [WorkflowExpression] Func<string> bodyinitials = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodyinfoOnTicketView = null, [WorkflowExpression] Func<string> bodyinfoOnServiceAssignment = null, [WorkflowExpression] Func<string> bodyinfoOnTicketCreate = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<bool> bodyisVip = null, [WorkflowExpression] Func<int> bodyenterpriseContactType = null, [WorkflowExpression] Func<bool> bodyisAddressFromMainEnterprise = null, [WorkflowExpression] Func<string> bodyaddressstreet = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddresspostcode = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddressaddress3 = null, [WorkflowExpression] Func<string> bodyaddresspostbox = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddresscountyShort = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresscountryName = null, [WorkflowExpression] Func<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactCreateContactResponse> __BuildApiContactCreateContact(WorkflowExpression<string> bodyenterpriseReferenceNumber, WorkflowExpression<string> bodyforeName, WorkflowExpression<string> bodysurName, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyformOfAddress = null, WorkflowExpression<string> bodyforeName2 = null, WorkflowExpression<string> bodysearchname = null, WorkflowExpression<string> bodyexternalNumber = null, WorkflowExpression<string> bodyinitials = null, WorkflowExpression<string> bodymemo = null, WorkflowExpression<string> bodyinfoOnTicketView = null, WorkflowExpression<string> bodyinfoOnServiceAssignment = null, WorkflowExpression<string> bodyinfoOnTicketCreate = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<bool> bodyisVip = null, WorkflowExpression<int> bodyenterpriseContactType = null, WorkflowExpression<bool> bodyisAddressFromMainEnterprise = null, WorkflowExpression<string> bodyaddressstreet = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddresspostcode = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddressaddress3 = null, WorkflowExpression<string> bodyaddresspostbox = null, WorkflowExpression<string> bodyaddresscounty = null, WorkflowExpression<string> bodyaddresscountyShort = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresscountryName = null, WorkflowExpression<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, WorkflowExpression<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowExpression.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            WorkflowExpression.Validate(bodyforeName, nameof(bodyforeName), required: true);
            WorkflowExpression.Validate(bodysurName, nameof(bodysurName), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            WorkflowExpression.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            WorkflowExpression.Validate(bodysearchname, nameof(bodysearchname), required: false);
            WorkflowExpression.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            WorkflowExpression.Validate(bodyinitials, nameof(bodyinitials), required: false);
            WorkflowExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowExpression.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            WorkflowExpression.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            WorkflowExpression.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodyisVip, nameof(bodyisVip), required: false);
            WorkflowExpression.Validate(bodyenterpriseContactType, nameof(bodyenterpriseContactType), required: false);
            WorkflowExpression.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            WorkflowExpression.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            WorkflowExpression.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            WorkflowExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            WorkflowExpression.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            WorkflowExpression.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            WorkflowExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<ApiContactCreateContactResponse>(() =>
            {
                var apiCallPath = "/ApiContact/CreateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["EnterpriseReferenceNumber"] = ExpressionConverter.ConvertO(bodyenterpriseReferenceNumber);
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyformOfAddress != null)
                {
                    body["formOfAddress"] = ExpressionConverter.ConvertO(bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = ExpressionConverter.ConvertO(bodyforeName);
                if (bodyforeName2 != null)
                {
                    body["foreName2"] = ExpressionConverter.ConvertO(bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = ExpressionConverter.ConvertO(bodysurName);
                if (bodysearchname != null)
                {
                    body["searchname"] = ExpressionConverter.ConvertO(bodysearchname);
                    bodypropCount++;
                }

                if (bodyexternalNumber != null)
                {
                    body["externalNumber"] = ExpressionConverter.ConvertO(bodyexternalNumber);
                    bodypropCount++;
                }

                if (bodyinitials != null)
                {
                    body["Initials"] = ExpressionConverter.ConvertO(bodyinitials);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(bodymemo);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = ExpressionConverter.ConvertO(bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = ExpressionConverter.ConvertO(bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = ExpressionConverter.ConvertO(bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodyisVip != null)
                {
                    body["IsVip"] = ExpressionConverter.ConvertO(bodyisVip);
                    bodypropCount++;
                }

                if (bodyenterpriseContactType != null)
                {
                    body["enterpriseContactType"] = ExpressionConverter.ConvertO(bodyenterpriseContactType);
                    bodypropCount++;
                }

                if (bodyisAddressFromMainEnterprise != null)
                {
                    if (bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = ExpressionConverter.ConvertO(bodyisAddressFromMainEnterprise);
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
                    addressObject["street"] = ExpressionConverter.ConvertO(bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = ExpressionConverter.ConvertO(bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = ExpressionConverter.ConvertO(bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = ExpressionConverter.ConvertO(bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = ExpressionConverter.ConvertO(bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = ExpressionConverter.ConvertO(bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = ExpressionConverter.ConvertO(bodyphoneNumbers);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["Emails"] = ExpressionConverter.ConvertO(bodyemails);
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
        [WorkflowExpressionFactory(nameof(__BuildApiContactUpdateContact))]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse> ApiContactUpdateContact([WorkflowExpression] Func<string> bodyenterpriseReferenceNumber, [WorkflowExpression] Func<string> bodyforeName, [WorkflowExpression] Func<string> bodysurName, [WorkflowExpression] Func<string> bodycontactId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyformOfAddress = null, [WorkflowExpression] Func<string> bodyforeName2 = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodyexternalNumber = null, [WorkflowExpression] Func<string> bodyinitials = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodyinfoOnTicketView = null, [WorkflowExpression] Func<string> bodyinfoOnServiceAssignment = null, [WorkflowExpression] Func<string> bodyinfoOnTicketCreate = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<bool> bodyisVip = null, [WorkflowExpression] Func<bool> bodyisAddressFromMainEnterprise = null, [WorkflowExpression] Func<string> bodyaddressstreet = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddresspostcode = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddressaddress3 = null, [WorkflowExpression] Func<string> bodyaddresspostbox = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddresscountyShort = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresscountryName = null, [WorkflowExpression] Func<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse> __BuildApiContactUpdateContact(WorkflowExpression<string> bodyenterpriseReferenceNumber, WorkflowExpression<string> bodyforeName, WorkflowExpression<string> bodysurName, WorkflowExpression<string> bodycontactId = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyformOfAddress = null, WorkflowExpression<string> bodyforeName2 = null, WorkflowExpression<string> bodysearchname = null, WorkflowExpression<string> bodyexternalNumber = null, WorkflowExpression<string> bodyinitials = null, WorkflowExpression<string> bodymemo = null, WorkflowExpression<string> bodyinfoOnTicketView = null, WorkflowExpression<string> bodyinfoOnServiceAssignment = null, WorkflowExpression<string> bodyinfoOnTicketCreate = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<bool> bodyisVip = null, WorkflowExpression<bool> bodyisAddressFromMainEnterprise = null, WorkflowExpression<string> bodyaddressstreet = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddresspostcode = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddressaddress3 = null, WorkflowExpression<string> bodyaddresspostbox = null, WorkflowExpression<string> bodyaddresscounty = null, WorkflowExpression<string> bodyaddresscountyShort = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresscountryName = null, WorkflowExpression<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, WorkflowExpression<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowExpression.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            WorkflowExpression.Validate(bodyforeName, nameof(bodyforeName), required: true);
            WorkflowExpression.Validate(bodysurName, nameof(bodysurName), required: true);
            WorkflowExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            WorkflowExpression.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            WorkflowExpression.Validate(bodysearchname, nameof(bodysearchname), required: false);
            WorkflowExpression.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            WorkflowExpression.Validate(bodyinitials, nameof(bodyinitials), required: false);
            WorkflowExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowExpression.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            WorkflowExpression.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            WorkflowExpression.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodyisVip, nameof(bodyisVip), required: false);
            WorkflowExpression.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            WorkflowExpression.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            WorkflowExpression.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            WorkflowExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            WorkflowExpression.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            WorkflowExpression.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            WorkflowExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            return new DeferredBodyAction<ApiContactUpdateContactResponse>(() =>
            {
                var apiCallPath = "/ApiContact/UpdateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(bodycontactId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EnterpriseReferenceNumber"] = ExpressionConverter.ConvertO(bodyenterpriseReferenceNumber);
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyformOfAddress != null)
                {
                    body["formOfAddress"] = ExpressionConverter.ConvertO(bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = ExpressionConverter.ConvertO(bodyforeName);
                if (bodyforeName2 != null)
                {
                    body["foreName2"] = ExpressionConverter.ConvertO(bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = ExpressionConverter.ConvertO(bodysurName);
                if (bodysearchname != null)
                {
                    body["searchname"] = ExpressionConverter.ConvertO(bodysearchname);
                    bodypropCount++;
                }

                if (bodyexternalNumber != null)
                {
                    body["externalNumber"] = ExpressionConverter.ConvertO(bodyexternalNumber);
                    bodypropCount++;
                }

                if (bodyinitials != null)
                {
                    body["Initials"] = ExpressionConverter.ConvertO(bodyinitials);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = ExpressionConverter.ConvertO(bodymemo);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = ExpressionConverter.ConvertO(bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = ExpressionConverter.ConvertO(bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = ExpressionConverter.ConvertO(bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodyisVip != null)
                {
                    body["IsVip"] = ExpressionConverter.ConvertO(bodyisVip);
                    bodypropCount++;
                }

                if (bodyisAddressFromMainEnterprise != null)
                {
                    if (bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = ExpressionConverter.ConvertO(bodyisAddressFromMainEnterprise);
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
                    addressObject["street"] = ExpressionConverter.ConvertO(bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = ExpressionConverter.ConvertO(bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = ExpressionConverter.ConvertO(bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = ExpressionConverter.ConvertO(bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = ExpressionConverter.ConvertO(bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = ExpressionConverter.ConvertO(bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = ExpressionConverter.ConvertO(bodyphoneNumbers);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["Emails"] = ExpressionConverter.ConvertO(bodyemails);
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
        [WorkflowExpressionFactory(nameof(__BuildApiContactGetContacts))]
        public IBodyWorkflowAction<ApiContactGetContactsResponse> ApiContactGetContacts([WorkflowExpression] Func<int> take, [WorkflowExpression] Func<string> searchParam, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> skip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactGetContactsResponse> __BuildApiContactGetContacts(WorkflowExpression<int> take, WorkflowExpression<string> searchParam, WorkflowExpression<string> filter = null, WorkflowExpression<int> skip = null)
        {
            WorkflowExpression.Validate(take, nameof(take), required: true);
            WorkflowExpression.Validate(searchParam, nameof(searchParam), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredBodyAction<ApiContactGetContactsResponse>(() =>
            {
                var apiCallPath = "/ApiContact/GetContacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["Filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["take"] = ExpressionConverter.Convert(take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                callPayload.Queries["searchParam"] = ExpressionConverter.Convert(searchParam);
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