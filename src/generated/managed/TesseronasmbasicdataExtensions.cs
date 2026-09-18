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
        public IBodyWorkflowAction<ApiEnterpriseGetEnterprisesResponse> ApiEnterpriseGetEnterprises([WorkflowExpression] Func<string> searchParam, [WorkflowExpression] Func<int> take, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(searchParam, nameof(searchParam), required: true);
            SourceExpression.Validate(take, nameof(take), required: true);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ApiEnterprise/GetEnterprises";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchParam"] = SourceExpressionConverter.ConvertO(searchParam);
                callPayload.Queries["take"] = SourceExpressionConverter.ConvertO(take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<ApiEnterpriseGetEnterprisesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<SetEnterpriseStatusResponse> SetEnterpriseStatus([WorkflowExpression] Func<int> bodyenterpriseId, [WorkflowExpression] Func<int> bodystatusId)
        {
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: true);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ApiEnterprise/SetEnterpriseStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                bodypropCount++;
                body["statusId"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetEnterpriseStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactCreateContactResponse> ApiContactCreateContact([WorkflowExpression] Func<string> bodyenterpriseReferenceNumber, [WorkflowExpression] Func<string> bodyforeName, [WorkflowExpression] Func<string> bodysurName, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyformOfAddress = null, [WorkflowExpression] Func<string> bodyforeName2 = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodyexternalNumber = null, [WorkflowExpression] Func<string> bodyinitials = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodyinfoOnTicketView = null, [WorkflowExpression] Func<string> bodyinfoOnServiceAssignment = null, [WorkflowExpression] Func<string> bodyinfoOnTicketCreate = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<bool> bodyisVip = null, [WorkflowExpression] Func<int> bodyenterpriseContactType = null, [WorkflowExpression] Func<bool> bodyisAddressFromMainEnterprise = null, [WorkflowExpression] Func<string> bodyaddressstreet = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddresspostcode = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddressaddress3 = null, [WorkflowExpression] Func<string> bodyaddresspostbox = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddresscountyShort = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresscountryName = null, [WorkflowExpression] Func<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            SourceExpression.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            SourceExpression.Validate(bodyforeName, nameof(bodyforeName), required: true);
            SourceExpression.Validate(bodysurName, nameof(bodysurName), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            SourceExpression.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            SourceExpression.Validate(bodysearchname, nameof(bodysearchname), required: false);
            SourceExpression.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            SourceExpression.Validate(bodyinitials, nameof(bodyinitials), required: false);
            SourceExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            SourceExpression.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            SourceExpression.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            SourceExpression.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            SourceExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            SourceExpression.Validate(bodyisVip, nameof(bodyisVip), required: false);
            SourceExpression.Validate(bodyenterpriseContactType, nameof(bodyenterpriseContactType), required: false);
            SourceExpression.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            SourceExpression.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            SourceExpression.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            SourceExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            SourceExpression.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            SourceExpression.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            SourceExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ApiContact/CreateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["EnterpriseReferenceNumber"] = SourceExpressionConverter.ConvertToken(bodyenterpriseReferenceNumber);
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyformOfAddress != null)
                {
                    body["formOfAddress"] = SourceExpressionConverter.ConvertToken(bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = SourceExpressionConverter.ConvertToken(bodyforeName);
                if (bodyforeName2 != null)
                {
                    body["foreName2"] = SourceExpressionConverter.ConvertToken(bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = SourceExpressionConverter.ConvertToken(bodysurName);
                if (bodysearchname != null)
                {
                    body["searchname"] = SourceExpressionConverter.ConvertToken(bodysearchname);
                    bodypropCount++;
                }

                if (bodyexternalNumber != null)
                {
                    body["externalNumber"] = SourceExpressionConverter.ConvertToken(bodyexternalNumber);
                    bodypropCount++;
                }

                if (bodyinitials != null)
                {
                    body["Initials"] = SourceExpressionConverter.ConvertToken(bodyinitials);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = SourceExpressionConverter.ConvertToken(bodymemo);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = SourceExpressionConverter.ConvertToken(bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = SourceExpressionConverter.ConvertToken(bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = SourceExpressionConverter.ConvertToken(bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = SourceExpressionConverter.ConvertToken(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodyisVip != null)
                {
                    body["IsVip"] = SourceExpressionConverter.ConvertToken(bodyisVip);
                    bodypropCount++;
                }

                if (bodyenterpriseContactType != null)
                {
                    body["enterpriseContactType"] = SourceExpressionConverter.ConvertToken(bodyenterpriseContactType);
                    bodypropCount++;
                }

                if (bodyisAddressFromMainEnterprise != null)
                {
                    if (bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = SourceExpressionConverter.ConvertToken(bodyisAddressFromMainEnterprise);
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
                    addressObject["street"] = SourceExpressionConverter.ConvertToken(bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = SourceExpressionConverter.ConvertToken(bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = SourceExpressionConverter.ConvertToken(bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = SourceExpressionConverter.ConvertToken(bodyphoneNumbers);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["Emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiContactCreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactUpdateContactResponse> ApiContactUpdateContact([WorkflowExpression] Func<string> bodyenterpriseReferenceNumber, [WorkflowExpression] Func<string> bodyforeName, [WorkflowExpression] Func<string> bodysurName, [WorkflowExpression] Func<string> bodycontactId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyformOfAddress = null, [WorkflowExpression] Func<string> bodyforeName2 = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodyexternalNumber = null, [WorkflowExpression] Func<string> bodyinitials = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodyinfoOnTicketView = null, [WorkflowExpression] Func<string> bodyinfoOnServiceAssignment = null, [WorkflowExpression] Func<string> bodyinfoOnTicketCreate = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<bool> bodyisVip = null, [WorkflowExpression] Func<bool> bodyisAddressFromMainEnterprise = null, [WorkflowExpression] Func<string> bodyaddressstreet = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddresspostcode = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddressaddress3 = null, [WorkflowExpression] Func<string> bodyaddresspostbox = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddresscountyShort = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresscountryName = null, [WorkflowExpression] Func<bodyphoneNumbersInputItem[]> bodyphoneNumbers = null, [WorkflowExpression] Func<bodyemailsInputItem[]> bodyemails = null)
        {
            SourceExpression.Validate(bodyenterpriseReferenceNumber, nameof(bodyenterpriseReferenceNumber), required: true);
            SourceExpression.Validate(bodyforeName, nameof(bodyforeName), required: true);
            SourceExpression.Validate(bodysurName, nameof(bodysurName), required: true);
            SourceExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyformOfAddress, nameof(bodyformOfAddress), required: false);
            SourceExpression.Validate(bodyforeName2, nameof(bodyforeName2), required: false);
            SourceExpression.Validate(bodysearchname, nameof(bodysearchname), required: false);
            SourceExpression.Validate(bodyexternalNumber, nameof(bodyexternalNumber), required: false);
            SourceExpression.Validate(bodyinitials, nameof(bodyinitials), required: false);
            SourceExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            SourceExpression.Validate(bodyinfoOnTicketView, nameof(bodyinfoOnTicketView), required: false);
            SourceExpression.Validate(bodyinfoOnServiceAssignment, nameof(bodyinfoOnServiceAssignment), required: false);
            SourceExpression.Validate(bodyinfoOnTicketCreate, nameof(bodyinfoOnTicketCreate), required: false);
            SourceExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            SourceExpression.Validate(bodyisVip, nameof(bodyisVip), required: false);
            SourceExpression.Validate(bodyisAddressFromMainEnterprise, nameof(bodyisAddressFromMainEnterprise), required: false);
            SourceExpression.Validate(bodyaddressstreet, nameof(bodyaddressstreet), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddresspostcode, nameof(bodyaddresspostcode), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddressaddress3, nameof(bodyaddressaddress3), required: false);
            SourceExpression.Validate(bodyaddresspostbox, nameof(bodyaddresspostbox), required: false);
            SourceExpression.Validate(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            SourceExpression.Validate(bodyaddresscountyShort, nameof(bodyaddresscountyShort), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresscountryName, nameof(bodyaddresscountryName), required: false);
            SourceExpression.Validate(bodyphoneNumbers, nameof(bodyphoneNumbers), required: false);
            SourceExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ApiContact/UpdateContact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactId != null)
                {
                    body["contactId"] = SourceExpressionConverter.ConvertToken(bodycontactId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["EnterpriseReferenceNumber"] = SourceExpressionConverter.ConvertToken(bodyenterpriseReferenceNumber);
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyformOfAddress != null)
                {
                    body["formOfAddress"] = SourceExpressionConverter.ConvertToken(bodyformOfAddress);
                    bodypropCount++;
                }

                bodypropCount++;
                body["foreName"] = SourceExpressionConverter.ConvertToken(bodyforeName);
                if (bodyforeName2 != null)
                {
                    body["foreName2"] = SourceExpressionConverter.ConvertToken(bodyforeName2);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surName"] = SourceExpressionConverter.ConvertToken(bodysurName);
                if (bodysearchname != null)
                {
                    body["searchname"] = SourceExpressionConverter.ConvertToken(bodysearchname);
                    bodypropCount++;
                }

                if (bodyexternalNumber != null)
                {
                    body["externalNumber"] = SourceExpressionConverter.ConvertToken(bodyexternalNumber);
                    bodypropCount++;
                }

                if (bodyinitials != null)
                {
                    body["Initials"] = SourceExpressionConverter.ConvertToken(bodyinitials);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["memo"] = SourceExpressionConverter.ConvertToken(bodymemo);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketView != null)
                {
                    body["InfoOnTicketView"] = SourceExpressionConverter.ConvertToken(bodyinfoOnTicketView);
                    bodypropCount++;
                }

                if (bodyinfoOnServiceAssignment != null)
                {
                    body["InfoOnServiceAssignment"] = SourceExpressionConverter.ConvertToken(bodyinfoOnServiceAssignment);
                    bodypropCount++;
                }

                if (bodyinfoOnTicketCreate != null)
                {
                    body["InfoOnTicketCreate"] = SourceExpressionConverter.ConvertToken(bodyinfoOnTicketCreate);
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["departmentName"] = SourceExpressionConverter.ConvertToken(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodyisVip != null)
                {
                    body["IsVip"] = SourceExpressionConverter.ConvertToken(bodyisVip);
                    bodypropCount++;
                }

                if (bodyisAddressFromMainEnterprise != null)
                {
                    if (bodyisAddressFromMainEnterprise != null)
                    {
                        body["IsAddressFromMainEnterprise"] = SourceExpressionConverter.ConvertToken(bodyisAddressFromMainEnterprise);
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
                    addressObject["street"] = SourceExpressionConverter.ConvertToken(bodyaddressstreet);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostcode != null)
                {
                    addressObject["postcode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostcode);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress3 != null)
                {
                    addressObject["address3"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress3);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostbox != null)
                {
                    addressObject["postbox"] = SourceExpressionConverter.ConvertToken(bodyaddresspostbox);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountyShort != null)
                {
                    addressObject["countyShort"] = SourceExpressionConverter.ConvertToken(bodyaddresscountyShort);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryName != null)
                {
                    addressObject["countryName"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryName);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyphoneNumbers != null)
                {
                    body["PhoneNumbers"] = SourceExpressionConverter.ConvertToken(bodyphoneNumbers);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["Emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiContactUpdateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasmbasicdata")]
        public IBodyWorkflowAction<ApiContactGetContactsResponse> ApiContactGetContacts([WorkflowExpression] Func<int> take, [WorkflowExpression] Func<string> searchParam, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(take, nameof(take), required: true);
            SourceExpression.Validate(searchParam, nameof(searchParam), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ApiContact/GetContacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["Filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["take"] = SourceExpressionConverter.ConvertO(take);
                callPayload.Queries["skip"] = Convert.ToString(0);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["searchParam"] = SourceExpressionConverter.ConvertO(searchParam);
                return callPayload;
            }

            return new ApiConnectionAction<ApiContactGetContactsResponse>(BuildSourceInput);
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