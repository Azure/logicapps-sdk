//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartdialogActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodysender, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<requestBodyprotocolInput> requestBodyprotocol, [WorkflowExpression] Func<requestBodyrecipientsInputItem[]> requestBodyrecipients, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<bool> requestBodyadMessage = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            SourceExpression.Validate(customerId, nameof(customerId), required: true);
            SourceExpression.Validate(serviceId, nameof(serviceId), required: true);
            SourceExpression.Validate(requestBodysender, nameof(requestBodysender), required: true);
            SourceExpression.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            SourceExpression.Validate(requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            SourceExpression.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            SourceExpression.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            SourceExpression.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            SourceExpression.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            SourceExpression.Validate(requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            SourceExpression.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            SourceExpression.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = SourceExpressionConverter.ConvertO(customerId);
                callPayload.Headers["Service-Id"] = SourceExpressionConverter.ConvertO(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = SourceExpressionConverter.ConvertToken(requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = SourceExpressionConverter.ConvertToken(requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = SourceExpressionConverter.Convert(requestBodyprotocol);
                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = SourceExpressionConverter.ConvertToken(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = SourceExpressionConverter.ConvertToken(requestBodyrecipients);
                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = SourceExpressionConverter.ConvertToken(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = SourceExpressionConverter.ConvertToken(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = SourceExpressionConverter.ConvertToken(requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = SourceExpressionConverter.ConvertToken(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = SourceExpressionConverter.ConvertToken(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendReplyMessageResponse> SendReplyMessage([WorkflowExpression] Func<string> parentMessageId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodysender, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<requestBodyprotocolInput> requestBodyprotocol, [WorkflowExpression] Func<requestBodyrecipientsInputItem[]> requestBodyrecipients, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<bool> requestBodyadMessage = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            SourceExpression.Validate(parentMessageId, nameof(parentMessageId), required: true);
            SourceExpression.Validate(customerId, nameof(customerId), required: true);
            SourceExpression.Validate(serviceId, nameof(serviceId), required: true);
            SourceExpression.Validate(requestBodysender, nameof(requestBodysender), required: true);
            SourceExpression.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            SourceExpression.Validate(requestBodyprotocol, nameof(requestBodyprotocol), required: true);
            SourceExpression.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            SourceExpression.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            SourceExpression.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            SourceExpression.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            SourceExpression.Validate(requestBodyadMessage, nameof(requestBodyadMessage), required: false);
            SourceExpression.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            SourceExpression.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/messages/reply/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentMessageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = SourceExpressionConverter.ConvertO(customerId);
                callPayload.Headers["Service-Id"] = SourceExpressionConverter.ConvertO(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["Sender"] = SourceExpressionConverter.ConvertToken(requestBodysender);
                requestBodypropCount++;
                requestBody["Content"] = SourceExpressionConverter.ConvertToken(requestBodycontent);
                requestBodypropCount++;
                requestBody["Protocol"] = SourceExpressionConverter.Convert(requestBodyprotocol);
                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = SourceExpressionConverter.ConvertToken(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["Recipients"] = SourceExpressionConverter.ConvertToken(requestBodyrecipients);
                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = SourceExpressionConverter.ConvertToken(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = SourceExpressionConverter.ConvertToken(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyadMessage != null)
                {
                    requestBody["AdMessage"] = SourceExpressionConverter.ConvertToken(requestBodyadMessage);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = SourceExpressionConverter.ConvertToken(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = SourceExpressionConverter.ConvertToken(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReplyMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendDiscussionReplyMessageResponse> SendDiscussionReplyMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> requestBodythreadId, [WorkflowExpression] Func<string> requestBodycontent, [WorkflowExpression] Func<string> requestBodycustomerData = null)
        {
            SourceExpression.Validate(customerId, nameof(customerId), required: true);
            SourceExpression.Validate(requestBodythreadId, nameof(requestBodythreadId), required: true);
            SourceExpression.Validate(requestBodycontent, nameof(requestBodycontent), required: true);
            SourceExpression.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/discussion/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["CustomerId"] = SourceExpressionConverter.ConvertO(customerId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["ThreadId"] = SourceExpressionConverter.ConvertToken(requestBodythreadId);
                requestBodypropCount++;
                requestBody["Content"] = SourceExpressionConverter.ConvertToken(requestBodycontent);
                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = SourceExpressionConverter.ConvertToken(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendDiscussionReplyMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IWorkflowAction CreateWhatsappTemplate([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> identityNumber, [WorkflowExpression] Func<string> requestBodydisplayName, [WorkflowExpression] Func<string> requestBodyrawContent, [WorkflowExpression] Func<string> requestBodycategory, [WorkflowExpression] Func<string> requestBodylanguage, [WorkflowExpression] Func<requestBodybuttonsInputItem[]> requestBodybuttons = null, [WorkflowExpression] Func<string> requestBodyattachmentUrl = null)
        {
            SourceExpression.Validate(customerId, nameof(customerId), required: true);
            SourceExpression.Validate(identityNumber, nameof(identityNumber), required: true);
            SourceExpression.Validate(requestBodydisplayName, nameof(requestBodydisplayName), required: true);
            SourceExpression.Validate(requestBodyrawContent, nameof(requestBodyrawContent), required: true);
            SourceExpression.Validate(requestBodycategory, nameof(requestBodycategory), required: true);
            SourceExpression.Validate(requestBodylanguage, nameof(requestBodylanguage), required: true);
            SourceExpression.Validate(requestBodybuttons, nameof(requestBodybuttons), required: false);
            SourceExpression.Validate(requestBodyattachmentUrl, nameof(requestBodyattachmentUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/whatsapp/templates/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(identityNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["DisplayName"] = SourceExpressionConverter.ConvertToken(requestBodydisplayName);
                requestBodypropCount++;
                requestBody["RawContent"] = SourceExpressionConverter.ConvertToken(requestBodyrawContent);
                requestBodypropCount++;
                requestBody["Category"] = SourceExpressionConverter.ConvertToken(requestBodycategory);
                requestBodypropCount++;
                requestBody["Language"] = SourceExpressionConverter.ConvertToken(requestBodylanguage);
                if (requestBodybuttons != null)
                {
                    requestBody["Buttons"] = SourceExpressionConverter.ConvertToken(requestBodybuttons);
                    requestBodypropCount++;
                }

                if (requestBodyattachmentUrl != null)
                {
                    requestBody["AttachmentUrl"] = SourceExpressionConverter.ConvertToken(requestBodyattachmentUrl);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<SendWhatsappTemplateMessageResponse> SendWhatsappTemplateMessage([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestBodytemplateName, [WorkflowExpression] Func<requestBodyrecipientsInputItem2[]> requestBodyrecipients, [WorkflowExpression] Func<string[]> requestBodybodyParameters = null, [WorkflowExpression] Func<string[]> requestBodyheaderParameters = null, [WorkflowExpression] Func<requestBodybuttonsInputItem2[]> requestBodybuttons = null, [WorkflowExpression] Func<string> requestBodysendDateTime = null, [WorkflowExpression] Func<string> requestBodyattachmentUri = null, [WorkflowExpression] Func<bool> requestBodyuseSmsFallback = null, [WorkflowExpression] Func<string> requestBodydlrUrl = null, [WorkflowExpression] Func<string> requestBodycustomerData = null, [WorkflowExpression] Func<string> requestBodyrequestId = null)
        {
            SourceExpression.Validate(customerId, nameof(customerId), required: true);
            SourceExpression.Validate(serviceId, nameof(serviceId), required: true);
            SourceExpression.Validate(requestBodytemplateName, nameof(requestBodytemplateName), required: true);
            SourceExpression.Validate(requestBodyrecipients, nameof(requestBodyrecipients), required: true);
            SourceExpression.Validate(requestBodybodyParameters, nameof(requestBodybodyParameters), required: false);
            SourceExpression.Validate(requestBodyheaderParameters, nameof(requestBodyheaderParameters), required: false);
            SourceExpression.Validate(requestBodybuttons, nameof(requestBodybuttons), required: false);
            SourceExpression.Validate(requestBodysendDateTime, nameof(requestBodysendDateTime), required: false);
            SourceExpression.Validate(requestBodyattachmentUri, nameof(requestBodyattachmentUri), required: false);
            SourceExpression.Validate(requestBodyuseSmsFallback, nameof(requestBodyuseSmsFallback), required: false);
            SourceExpression.Validate(requestBodydlrUrl, nameof(requestBodydlrUrl), required: false);
            SourceExpression.Validate(requestBodycustomerData, nameof(requestBodycustomerData), required: false);
            SourceExpression.Validate(requestBodyrequestId, nameof(requestBodyrequestId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/templates/whatsapp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer-Id"] = SourceExpressionConverter.ConvertO(customerId);
                callPayload.Headers["Service-Id"] = SourceExpressionConverter.ConvertO(serviceId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                requestBodypropCount++;
                requestBody["TemplateName"] = SourceExpressionConverter.ConvertToken(requestBodytemplateName);
                requestBodypropCount++;
                requestBody["Recipients"] = SourceExpressionConverter.ConvertToken(requestBodyrecipients);
                if (requestBodybodyParameters != null)
                {
                    requestBody["BodyParameters"] = SourceExpressionConverter.ConvertToken(requestBodybodyParameters);
                    requestBodypropCount++;
                }

                if (requestBodyheaderParameters != null)
                {
                    requestBody["HeaderParameters"] = SourceExpressionConverter.ConvertToken(requestBodyheaderParameters);
                    requestBodypropCount++;
                }

                if (requestBodybuttons != null)
                {
                    requestBody["Buttons"] = SourceExpressionConverter.ConvertToken(requestBodybuttons);
                    requestBodypropCount++;
                }

                if (requestBodysendDateTime != null)
                {
                    requestBody["SendDateTime"] = SourceExpressionConverter.ConvertToken(requestBodysendDateTime);
                    requestBodypropCount++;
                }

                if (requestBodyattachmentUri != null)
                {
                    requestBody["AttachmentUri"] = SourceExpressionConverter.ConvertToken(requestBodyattachmentUri);
                    requestBodypropCount++;
                }

                if (requestBodyuseSmsFallback != null)
                {
                    requestBody["UseSmsFallback"] = SourceExpressionConverter.ConvertToken(requestBodyuseSmsFallback);
                    requestBodypropCount++;
                }

                if (requestBodydlrUrl != null)
                {
                    requestBody["DlrUrl"] = SourceExpressionConverter.ConvertToken(requestBodydlrUrl);
                    requestBodypropCount++;
                }

                if (requestBodycustomerData != null)
                {
                    requestBody["CustomerData"] = SourceExpressionConverter.ConvertToken(requestBodycustomerData);
                    requestBodypropCount++;
                }

                if (requestBodyrequestId != null)
                {
                    requestBody["RequestId"] = SourceExpressionConverter.ConvertToken(requestBodyrequestId);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsappTemplateMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<GetGroupContactResponse> GetGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> region = null)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(groupService, nameof(groupService), required: true);
            SourceExpression.Validate(phone, nameof(phone), required: true);
            SourceExpression.Validate(region, nameof(region), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (region != null)
                    callPayload.Queries["Region"] = SourceExpressionConverter.ConvertO(region);
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(groupService, nameof(groupService), required: true);
            SourceExpression.Validate(phone, nameof(phone), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> UpdateGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<bool> requestBodyactive = null, [WorkflowExpression] Func<string> requestBodyemail = null, [WorkflowExpression] Func<string> requestBodyfirstName = null, [WorkflowExpression] Func<string> requestBodylastName = null, [WorkflowExpression] Func<requestBodygenderInput> requestBodygender = null, [WorkflowExpression] Func<int> requestBodybirthYear = null, [WorkflowExpression] Func<string> requestBodystreetAddress = null, [WorkflowExpression] Func<string> requestBodyzipCode = null, [WorkflowExpression] Func<string> requestBodycity = null, [WorkflowExpression] Func<string> requestBodycountryCode = null, [WorkflowExpression] Func<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, [WorkflowExpression] Func<string[]> requestBodyphoneNumberRegions = null)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(groupService, nameof(groupService), required: true);
            SourceExpression.Validate(phone, nameof(phone), required: true);
            SourceExpression.Validate(requestBodyactive, nameof(requestBodyactive), required: false);
            SourceExpression.Validate(requestBodyemail, nameof(requestBodyemail), required: false);
            SourceExpression.Validate(requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            SourceExpression.Validate(requestBodylastName, nameof(requestBodylastName), required: false);
            SourceExpression.Validate(requestBodygender, nameof(requestBodygender), required: false);
            SourceExpression.Validate(requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            SourceExpression.Validate(requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            SourceExpression.Validate(requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            SourceExpression.Validate(requestBodycity, nameof(requestBodycity), required: false);
            SourceExpression.Validate(requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            SourceExpression.Validate(requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            SourceExpression.Validate(requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyactive != null)
                {
                    if (requestBodyactive != null)
                    {
                        requestBody["active"] = SourceExpressionConverter.ConvertToken(requestBodyactive);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["active"] = true;
                    requestBodypropCount++;
                }

                if (requestBodyemail != null)
                {
                    requestBody["email"] = SourceExpressionConverter.ConvertToken(requestBodyemail);
                    requestBodypropCount++;
                }

                if (requestBodyfirstName != null)
                {
                    requestBody["firstName"] = SourceExpressionConverter.ConvertToken(requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (requestBodylastName != null)
                {
                    requestBody["lastName"] = SourceExpressionConverter.ConvertToken(requestBodylastName);
                    requestBodypropCount++;
                }

                if (requestBodygender != null)
                {
                    requestBody["gender"] = SourceExpressionConverter.Convert(requestBodygender);
                    requestBodypropCount++;
                }

                if (requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = SourceExpressionConverter.ConvertToken(requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = SourceExpressionConverter.ConvertToken(requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = SourceExpressionConverter.ConvertToken(requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (requestBodycity != null)
                {
                    requestBody["city"] = SourceExpressionConverter.ConvertToken(requestBodycity);
                    requestBodypropCount++;
                }

                if (requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = SourceExpressionConverter.ConvertToken(requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = SourceExpressionConverter.ConvertToken(requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = SourceExpressionConverter.ConvertToken(requestBodyphoneNumberRegions);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<bool> DeleteAllGroupContacts([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(groupService, nameof(groupService), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartdialog")]
        public IBodyWorkflowAction<string> CreateGroupContact([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> groupService, [WorkflowExpression] Func<string> requestBodyphone, [WorkflowExpression] Func<bool> requestBodyactive = null, [WorkflowExpression] Func<string> requestBodyemail = null, [WorkflowExpression] Func<string> requestBodyfirstName = null, [WorkflowExpression] Func<string> requestBodylastName = null, [WorkflowExpression] Func<requestBodygenderInput> requestBodygender = null, [WorkflowExpression] Func<int> requestBodybirthYear = null, [WorkflowExpression] Func<string> requestBodystreetAddress = null, [WorkflowExpression] Func<string> requestBodyzipCode = null, [WorkflowExpression] Func<string> requestBodycity = null, [WorkflowExpression] Func<string> requestBodycountryCode = null, [WorkflowExpression] Func<requestBodycustomContactPropertiesInputItem[]> requestBodycustomContactProperties = null, [WorkflowExpression] Func<string[]> requestBodyphoneNumberRegions = null)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(groupService, nameof(groupService), required: true);
            SourceExpression.Validate(requestBodyphone, nameof(requestBodyphone), required: true);
            SourceExpression.Validate(requestBodyactive, nameof(requestBodyactive), required: false);
            SourceExpression.Validate(requestBodyemail, nameof(requestBodyemail), required: false);
            SourceExpression.Validate(requestBodyfirstName, nameof(requestBodyfirstName), required: false);
            SourceExpression.Validate(requestBodylastName, nameof(requestBodylastName), required: false);
            SourceExpression.Validate(requestBodygender, nameof(requestBodygender), required: false);
            SourceExpression.Validate(requestBodybirthYear, nameof(requestBodybirthYear), required: false);
            SourceExpression.Validate(requestBodystreetAddress, nameof(requestBodystreetAddress), required: false);
            SourceExpression.Validate(requestBodyzipCode, nameof(requestBodyzipCode), required: false);
            SourceExpression.Validate(requestBodycity, nameof(requestBodycity), required: false);
            SourceExpression.Validate(requestBodycountryCode, nameof(requestBodycountryCode), required: false);
            SourceExpression.Validate(requestBodycustomContactProperties, nameof(requestBodycustomContactProperties), required: false);
            SourceExpression.Validate(requestBodyphoneNumberRegions, nameof(requestBodyphoneNumberRegions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groupcontact/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customer, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupService, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodyactive != null)
                {
                    if (requestBodyactive != null)
                    {
                        requestBody["active"] = SourceExpressionConverter.ConvertToken(requestBodyactive);
                        requestBodypropCount++;
                    }

                    requestBodypropCount++;
                }
                else
                {
                    requestBody["active"] = true;
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["phone"] = SourceExpressionConverter.ConvertToken(requestBodyphone);
                if (requestBodyemail != null)
                {
                    requestBody["email"] = SourceExpressionConverter.ConvertToken(requestBodyemail);
                    requestBodypropCount++;
                }

                if (requestBodyfirstName != null)
                {
                    requestBody["firstName"] = SourceExpressionConverter.ConvertToken(requestBodyfirstName);
                    requestBodypropCount++;
                }

                if (requestBodylastName != null)
                {
                    requestBody["lastName"] = SourceExpressionConverter.ConvertToken(requestBodylastName);
                    requestBodypropCount++;
                }

                if (requestBodygender != null)
                {
                    requestBody["gender"] = SourceExpressionConverter.Convert(requestBodygender);
                    requestBodypropCount++;
                }

                if (requestBodybirthYear != null)
                {
                    requestBody["birthYear"] = SourceExpressionConverter.ConvertToken(requestBodybirthYear);
                    requestBodypropCount++;
                }

                if (requestBodystreetAddress != null)
                {
                    requestBody["streetAddress"] = SourceExpressionConverter.ConvertToken(requestBodystreetAddress);
                    requestBodypropCount++;
                }

                if (requestBodyzipCode != null)
                {
                    requestBody["zipCode"] = SourceExpressionConverter.ConvertToken(requestBodyzipCode);
                    requestBodypropCount++;
                }

                if (requestBodycity != null)
                {
                    requestBody["city"] = SourceExpressionConverter.ConvertToken(requestBodycity);
                    requestBodypropCount++;
                }

                if (requestBodycountryCode != null)
                {
                    requestBody["countryCode"] = SourceExpressionConverter.ConvertToken(requestBodycountryCode);
                    requestBodypropCount++;
                }

                if (requestBodycustomContactProperties != null)
                {
                    requestBody["customContactProperties"] = SourceExpressionConverter.ConvertToken(requestBodycustomContactProperties);
                    requestBodypropCount++;
                }

                if (requestBodyphoneNumberRegions != null)
                {
                    requestBody["phoneNumberRegions"] = SourceExpressionConverter.ConvertToken(requestBodyphoneNumberRegions);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class SmartdialogTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewMessageResponse> NewMessage([WorkflowExpression] Func<string> customer, [WorkflowExpression] Func<string> service, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(customer, nameof(customer), required: true);
            SourceExpression.Validate(service, nameof(service), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/service/{0}/pipelines/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Customer"] = SourceExpressionConverter.ConvertO(customer);
                var createWebhookRequestBody = new JObject();
                var createWebhookRequestBodypropCount = 0;
                createWebhookRequestBody["name"] = "PowerAutomate (Auto Created Webhook)";
                createWebhookRequestBodypropCount++;
                createWebhookRequestBody["actionType"] = "HttpRequest";
                createWebhookRequestBodypropCount++;
                createWebhookRequestBody["description"] = "PowerAutomate auto-created webhook. Please don't modify. Will be removed by PowerAutomate , when the Flow/Logic App is disabled or removed";
                createWebhookRequestBodypropCount++;
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                optionsObject["endpointUrl"] = "#{listCallbackUrl()}";
                optionsObjectpropCount++;
                optionsObject["httpVerb"] = "POST";
                optionsObjectpropCount++;
                if (optionsObjectpropCount > 0)
                {
                    createWebhookRequestBody["options"] = optionsObject;
                    createWebhookRequestBodypropCount++;
                }

                if (createWebhookRequestBodypropCount > 0)
                {
                    callPayload.Body = createWebhookRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<NewMessageResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class SendMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public enum requestBodyprotocolInput
    {
        SMS
    }

    public class requestBodyrecipientsInputItem
    {
        public string Address { get; set; }
        public JToken Personalization { get; set; }
    }

    public class SendReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class SendDiscussionReplyMessageResponse
    {
        public string MessageId { get; set; }
        public int MessagePartCount { get; set; }
        public SendDiscussionReplyMessageResponseRecipientsTypeItem[] Recipients { get; set; }
        public string ThreadId { get; set; }
    }

    public class SendDiscussionReplyMessageResponseRecipientsTypeItem
    {
        public string Address { get; set; }
        public string Id { get; set; }
    }

    public class requestBodybuttonsInputItem
    {
        public requestBodybuttonsInputItemTypeType Type { get; set; }
        public string Label { get; set; }
        public string Data { get; set; }
    }

    public enum requestBodybuttonsInputItemTypeType
    {
        Call,
        QuickReply,
        Url
    }

    public class SendWhatsappTemplateMessageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("messagePartCount")]
        public int MessagePartCount { get; set; }

        [JsonProperty("recipients")]
        public SendWhatsappTemplateMessageResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class SendWhatsappTemplateMessageResponseRecipientsTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class requestBodyrecipientsInputItem2
    {
        public string Address { get; set; }
    }

    public class requestBodybuttonsInputItem2
    {
        public requestBodybuttonsInputItemTypeType Type { get; set; }
        public string Data { get; set; }
    }

    public class GetGroupContactResponse
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public GetGroupContactResponseGenderType Gender { get; set; }

        [JsonProperty("birthYear")]
        public int BirthYear { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("failedMessages")]
        public int FailedMessages { get; set; }

        [JsonProperty("customContactProperties")]
        public GetGroupContactResponseCustomContactPropertiesTypeItem[] CustomContactProperties { get; set; }
    }

    public enum GetGroupContactResponseGenderType
    {
        Male,
        Female,
        Other
    }

    public class GetGroupContactResponseCustomContactPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum requestBodygenderInput
    {
        Male,
        Female,
        Other
    }

    public class requestBodycustomContactPropertiesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class NewMessageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smartdialog;

    public partial class WorkflowManagedActions
    {
        public SmartdialogActions Smartdialog(string connectionId) => new SmartdialogActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmartdialogTriggers Smartdialog(string connectionId) => new SmartdialogTriggers(connectionId);
    }
}