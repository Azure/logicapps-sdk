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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse> __BuildApiEnterpriseGetEnterprises(WorkflowValue<string> searchParam, WorkflowValue<int> take, WorkflowValue<int> skip = null)
        {
            WorkflowValue.Validate(searchParam, nameof(searchParam), required: true);
            WorkflowValue.Validate(take, nameof(take), required: true);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse> __BuildSetEnterpriseStatus(WorkflowValue<int> bodyenterpriseId, WorkflowValue<int> bodystatusId)
        {
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            WorkflowValue.Validate(bodystatusId, nameof(bodystatusId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactCreateContactResponse> __BuildApiContactCreateContact(WorkflowValue<string> bodyenterpriseReferenceNumber, WorkflowValue<string> bodyforeName, WorkflowValue<string> bodysurName, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyformOfAddress = null, WorkflowValue<string> bodyforeName2 = null, WorkflowValue<string> bodysearchname = null, WorkflowValue<string> bodyexternalNumber = null, WorkflowValue<string> bodyinitials = null, WorkflowValue<string> bodymemo = null, WorkflowValue<string> bodyinfoOnTicketView = null, WorkflowValue<string> bodyinfoOnServiceAssignment = null, WorkflowValue<string> bodyinfoOnTicketCreate = null, WorkflowValue<string> bodydepartmentName = null, WorkflowValue<bool> bodyisVip = null, WorkflowValue<int> bodyenterpriseContactType = null, WorkflowValue<bool> bodyisAddressFromMainEnterprise = null, WorkflowValue<string> bodyaddressstreet = null, WorkflowValue<string> bodyaddresscity = null, WorkflowValue<string> bodyaddresspostcode = null, WorkflowValue<string> bodyaddressaddress1 = null, WorkflowValue<string> bodyaddressaddress2 = null, WorkflowValue<string> bodyaddressaddress3 = null, WorkflowValue<string> bodyaddresspostbox = null, WorkflowValue<string> bodyaddresscounty = null, WorkflowValue<string> bodyaddresscountyShort = null, WorkflowValue<string> bodyaddresscountryCode = null, WorkflowValue<string> bodyaddresscountryName = null, WorkflowValue<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, WorkflowValue<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowValue.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            WorkflowValue.Validate(bodyforeName, nameof(bodyforeName), required: true);
            WorkflowValue.Validate(bodysurName, nameof(bodysurName), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            WorkflowValue.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            WorkflowValue.Validate(bodysearchname, nameof(bodysearchname), required: false);
            WorkflowValue.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            WorkflowValue.Validate(bodyinitials, nameof(bodyinitials), required: false);
            WorkflowValue.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowValue.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            WorkflowValue.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            WorkflowValue.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            WorkflowValue.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowValue.Validate(bodyisVip, nameof(bodyisVip), required: false);
            WorkflowValue.Validate(bodyenterpriseContactType, nameof(bodyenterpriseContactType), required: false);
            WorkflowValue.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            WorkflowValue.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            WorkflowValue.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowValue.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            WorkflowValue.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowValue.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowValue.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            WorkflowValue.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            WorkflowValue.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            WorkflowValue.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            WorkflowValue.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowValue.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            WorkflowValue.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            WorkflowValue.Validate(bodyemails, nameof(bodyemails), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse> __BuildApiContactUpdateContact(WorkflowValue<string> bodyenterpriseReferenceNumber, WorkflowValue<string> bodyforeName, WorkflowValue<string> bodysurName, WorkflowValue<string> bodycontactId = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyformOfAddress = null, WorkflowValue<string> bodyforeName2 = null, WorkflowValue<string> bodysearchname = null, WorkflowValue<string> bodyexternalNumber = null, WorkflowValue<string> bodyinitials = null, WorkflowValue<string> bodymemo = null, WorkflowValue<string> bodyinfoOnTicketView = null, WorkflowValue<string> bodyinfoOnServiceAssignment = null, WorkflowValue<string> bodyinfoOnTicketCreate = null, WorkflowValue<string> bodydepartmentName = null, WorkflowValue<bool> bodyisVip = null, WorkflowValue<bool> bodyisAddressFromMainEnterprise = null, WorkflowValue<string> bodyaddressstreet = null, WorkflowValue<string> bodyaddresscity = null, WorkflowValue<string> bodyaddresspostcode = null, WorkflowValue<string> bodyaddressaddress1 = null, WorkflowValue<string> bodyaddressaddress2 = null, WorkflowValue<string> bodyaddressaddress3 = null, WorkflowValue<string> bodyaddresspostbox = null, WorkflowValue<string> bodyaddresscounty = null, WorkflowValue<string> bodyaddresscountyShort = null, WorkflowValue<string> bodyaddresscountryCode = null, WorkflowValue<string> bodyaddresscountryName = null, WorkflowValue<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, WorkflowValue<bodyemailsInputItem[]> bodyemails = null)
        {
            WorkflowValue.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            WorkflowValue.Validate(bodyforeName, nameof(bodyforeName), required: true);
            WorkflowValue.Validate(bodysurName, nameof(bodysurName), required: true);
            WorkflowValue.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            WorkflowValue.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            WorkflowValue.Validate(bodysearchname, nameof(bodysearchname), required: false);
            WorkflowValue.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            WorkflowValue.Validate(bodyinitials, nameof(bodyinitials), required: false);
            WorkflowValue.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowValue.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            WorkflowValue.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            WorkflowValue.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            WorkflowValue.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowValue.Validate(bodyisVip, nameof(bodyisVip), required: false);
            WorkflowValue.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            WorkflowValue.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            WorkflowValue.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowValue.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            WorkflowValue.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowValue.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowValue.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            WorkflowValue.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            WorkflowValue.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            WorkflowValue.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            WorkflowValue.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowValue.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            WorkflowValue.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            WorkflowValue.Validate(bodyemails, nameof(bodyemails), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiContactGetContactsResponse> __BuildApiContactGetContacts(WorkflowValue<int> take, WorkflowValue<string> searchParam, WorkflowValue<string> filter = null, WorkflowValue<int> skip = null)
        {
            WorkflowValue.Validate(take, nameof(take), required: true);
            WorkflowValue.Validate(searchParam, nameof(searchParam), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
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
