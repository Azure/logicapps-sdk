//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Outlook
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OutlookActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessage> GetEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> internetMessageId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (internetMessageId != null)
                    callPayload.Queries["internetMessageId"] = SourceExpressionConverter.ConvertO(internetMessageId);
                return callPayload;
            }

            return new ApiConnectionAction<ClientReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> Move([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> folderPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/Move/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionAction<ClientReceiveMessageStringEnums>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction Flag([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/Flag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction MarkAsRead([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/MarkAsRead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<string> GetAttachment([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> attachmentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}/Attachments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions([WorkflowExpression] Func<string> optionsEmailSubscriptionmessageto, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> optionsEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<optionsEmailSubscriptionmessageimportanceInput> optionsEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> optionsEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mailwithoptions/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var optionsEmailSubscription = new JObject();
                var optionsEmailSubscriptionpropCount = 0;
                optionsEmailSubscription["NotificationUrl"] = "#{listCallbackUrl()}";
                optionsEmailSubscriptionpropCount++;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                messageObjectpropCount++;
                messageObject["To"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageto);
                if (optionsEmailSubscriptionmessagesubject != null)
                {
                    if (optionsEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagesubject);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Subject"] = "Your input is required";
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageuserOptions != null)
                {
                    if (optionsEmailSubscriptionmessageuserOptions != null)
                    {
                        messageObject["Options"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuserOptions);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Options"] = "Choice1, Choice2, Choice3";
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageheaderText != null)
                {
                    messageObject["HeaderText"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageimportance != null)
                {
                    if (optionsEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = SourceExpressionConverter.Convert(optionsEmailSubscriptionmessageimportance);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Importance"] = "Normal";
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageattachments != null)
                {
                    messageObject["Attachments"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideHTMLMessage);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["HideHTMLMessage"] = false;
                    messageObjectpropCount++;
                }

                if (optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    if (optionsEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                    {
                        messageObject["ShowHTMLConfirmationDialog"] = SourceExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["ShowHTMLConfirmationDialog"] = false;
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    optionsEmailSubscription["Message"] = messageObject;
                    optionsEmailSubscriptionpropCount++;
                }

                if (optionsEmailSubscriptionpropCount > 0)
                {
                    callPayload.Body = optionsEmailSubscription;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail([WorkflowExpression] Func<string> approvalEmailSubscriptionmessageto, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagesubject = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageuserOptions = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageheaderText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessageselectionText = null, [WorkflowExpression] Func<string> approvalEmailSubscriptionmessagebody = null, [WorkflowExpression] Func<approvalEmailSubscriptionmessageimportanceInput> approvalEmailSubscriptionmessageimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> approvalEmailSubscriptionmessageattachments = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessagehideHTMLMessage = null, [WorkflowExpression] Func<bool> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/approvalmail/$subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var approvalEmailSubscription = new JObject();
                var approvalEmailSubscriptionpropCount = 0;
                approvalEmailSubscription["NotificationUrl"] = "#{listCallbackUrl()}";
                approvalEmailSubscriptionpropCount++;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                messageObjectpropCount++;
                messageObject["To"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageto);
                if (approvalEmailSubscriptionmessagesubject != null)
                {
                    if (approvalEmailSubscriptionmessagesubject != null)
                    {
                        messageObject["Subject"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagesubject);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Subject"] = "Approval Request";
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageuserOptions != null)
                {
                    if (approvalEmailSubscriptionmessageuserOptions != null)
                    {
                        messageObject["Options"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuserOptions);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Options"] = "Approve, Reject";
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageheaderText != null)
                {
                    messageObject["HeaderText"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageheaderText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageselectionText != null)
                {
                    messageObject["SelectionText"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageselectionText);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagebody != null)
                {
                    messageObject["Body"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagebody);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageimportance != null)
                {
                    if (approvalEmailSubscriptionmessageimportance != null)
                    {
                        messageObject["Importance"] = SourceExpressionConverter.Convert(approvalEmailSubscriptionmessageimportance);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["Importance"] = "Normal";
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageattachments != null)
                {
                    messageObject["Attachments"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageattachments);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
                {
                    messageObject["UseOnlyHTMLMessage"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                    {
                        messageObject["HideHTMLMessage"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagehideHTMLMessage);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["HideHTMLMessage"] = false;
                    messageObjectpropCount++;
                }

                if (approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                {
                    if (approvalEmailSubscriptionmessageshowHTMLConfirmationDialog != null)
                    {
                        messageObject["ShowHTMLConfirmationDialog"] = SourceExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
                        messageObjectpropCount++;
                    }

                    messageObjectpropCount++;
                }
                else
                {
                    messageObject["ShowHTMLConfirmationDialog"] = false;
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    approvalEmailSubscription["Message"] = messageObject;
                    approvalEmailSubscriptionpropCount++;
                }

                if (approvalEmailSubscriptionpropCount > 0)
                {
                    callPayload.Body = approvalEmailSubscription;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> CalendarGetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/calendars/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseTable>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction CalendarDeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> ContactGetTables()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/contacts/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseTable>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseContactResponse> ContactGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddress[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["Id"] = SourceExpressionConverter.ConvertToken(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["ParentFolderId"] = SourceExpressionConverter.ConvertToken(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["Birthday"] = SourceExpressionConverter.ConvertToken(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["FileAs"] = SourceExpressionConverter.ConvertToken(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["DisplayName"] = SourceExpressionConverter.ConvertToken(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = SourceExpressionConverter.ConvertToken(itemgivenName);
                if (iteminitials != null)
                {
                    item["Initials"] = SourceExpressionConverter.ConvertToken(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["MiddleName"] = SourceExpressionConverter.ConvertToken(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["NickName"] = SourceExpressionConverter.ConvertToken(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["Surname"] = SourceExpressionConverter.ConvertToken(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["Title"] = SourceExpressionConverter.ConvertToken(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["Generation"] = SourceExpressionConverter.ConvertToken(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["EmailAddresses"] = SourceExpressionConverter.ConvertToken(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["ImAddresses"] = SourceExpressionConverter.ConvertToken(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["JobTitle"] = SourceExpressionConverter.ConvertToken(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["CompanyName"] = SourceExpressionConverter.ConvertToken(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["Department"] = SourceExpressionConverter.ConvertToken(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["OfficeLocation"] = SourceExpressionConverter.ConvertToken(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["Profession"] = SourceExpressionConverter.ConvertToken(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = SourceExpressionConverter.ConvertToken(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["AssistantName"] = SourceExpressionConverter.ConvertToken(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["Manager"] = SourceExpressionConverter.ConvertToken(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = SourceExpressionConverter.ConvertToken(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["BusinessPhones"] = SourceExpressionConverter.ConvertToken(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["MobilePhone1"] = SourceExpressionConverter.ConvertToken(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = SourceExpressionConverter.ConvertToken(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = SourceExpressionConverter.ConvertToken(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["YomiSurname"] = SourceExpressionConverter.ConvertToken(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["Categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["ChangeKey"] = SourceExpressionConverter.ConvertToken(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = SourceExpressionConverter.ConvertToken(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = SourceExpressionConverter.ConvertToken(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ContactDeleteItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemgivenName, [WorkflowExpression] Func<string[]> itemhomePhones, [WorkflowExpression] Func<string> itemid = null, [WorkflowExpression] Func<string> itemparentFolderId = null, [WorkflowExpression] Func<string> itembirthday = null, [WorkflowExpression] Func<string> itemfileAs = null, [WorkflowExpression] Func<string> itemdisplayName = null, [WorkflowExpression] Func<string> iteminitials = null, [WorkflowExpression] Func<string> itemmiddleName = null, [WorkflowExpression] Func<string> itemnickname = null, [WorkflowExpression] Func<string> itemsurname = null, [WorkflowExpression] Func<string> itemtitle = null, [WorkflowExpression] Func<string> itemgeneration = null, [WorkflowExpression] Func<EmailAddress[]> itememailAddresses = null, [WorkflowExpression] Func<string[]> itemiMAddresses = null, [WorkflowExpression] Func<string> itemjobTitle = null, [WorkflowExpression] Func<string> itemcompanyName = null, [WorkflowExpression] Func<string> itemdepartment = null, [WorkflowExpression] Func<string> itemofficeLocation = null, [WorkflowExpression] Func<string> itemprofession = null, [WorkflowExpression] Func<string> itembusinessHomePage = null, [WorkflowExpression] Func<string> itemassistantName = null, [WorkflowExpression] Func<string> itemmanager = null, [WorkflowExpression] Func<string[]> itembusinessPhones = null, [WorkflowExpression] Func<string> itemmobilePhone = null, [WorkflowExpression] Func<string> itemhomeAddressstreet = null, [WorkflowExpression] Func<string> itemhomeAddresscity = null, [WorkflowExpression] Func<string> itemhomeAddressstate = null, [WorkflowExpression] Func<string> itemhomeAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemhomeAddresspostalCode = null, [WorkflowExpression] Func<string> itembusinessAddressstreet = null, [WorkflowExpression] Func<string> itembusinessAddresscity = null, [WorkflowExpression] Func<string> itembusinessAddressstate = null, [WorkflowExpression] Func<string> itembusinessAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itembusinessAddresspostalCode = null, [WorkflowExpression] Func<string> itemotherAddressstreet = null, [WorkflowExpression] Func<string> itemotherAddresscity = null, [WorkflowExpression] Func<string> itemotherAddressstate = null, [WorkflowExpression] Func<string> itemotherAddresscountryOrRegion = null, [WorkflowExpression] Func<string> itemotherAddresspostalCode = null, [WorkflowExpression] Func<string> itemyomiCompanyName = null, [WorkflowExpression] Func<string> itemyomiGivenName = null, [WorkflowExpression] Func<string> itemyomiSurname = null, [WorkflowExpression] Func<string[]> itemcategories = null, [WorkflowExpression] Func<string> itemchangeKey = null, [WorkflowExpression] Func<string> itemcreatedTime = null, [WorkflowExpression] Func<string> itemlastModifiedTime = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                if (itemid != null)
                {
                    item["Id"] = SourceExpressionConverter.ConvertToken(itemid);
                    itempropCount++;
                }

                if (itemparentFolderId != null)
                {
                    item["ParentFolderId"] = SourceExpressionConverter.ConvertToken(itemparentFolderId);
                    itempropCount++;
                }

                if (itembirthday != null)
                {
                    item["Birthday"] = SourceExpressionConverter.ConvertToken(itembirthday);
                    itempropCount++;
                }

                if (itemfileAs != null)
                {
                    item["FileAs"] = SourceExpressionConverter.ConvertToken(itemfileAs);
                    itempropCount++;
                }

                if (itemdisplayName != null)
                {
                    item["DisplayName"] = SourceExpressionConverter.ConvertToken(itemdisplayName);
                    itempropCount++;
                }

                itempropCount++;
                item["GivenName"] = SourceExpressionConverter.ConvertToken(itemgivenName);
                if (iteminitials != null)
                {
                    item["Initials"] = SourceExpressionConverter.ConvertToken(iteminitials);
                    itempropCount++;
                }

                if (itemmiddleName != null)
                {
                    item["MiddleName"] = SourceExpressionConverter.ConvertToken(itemmiddleName);
                    itempropCount++;
                }

                if (itemnickname != null)
                {
                    item["NickName"] = SourceExpressionConverter.ConvertToken(itemnickname);
                    itempropCount++;
                }

                if (itemsurname != null)
                {
                    item["Surname"] = SourceExpressionConverter.ConvertToken(itemsurname);
                    itempropCount++;
                }

                if (itemtitle != null)
                {
                    item["Title"] = SourceExpressionConverter.ConvertToken(itemtitle);
                    itempropCount++;
                }

                if (itemgeneration != null)
                {
                    item["Generation"] = SourceExpressionConverter.ConvertToken(itemgeneration);
                    itempropCount++;
                }

                if (itememailAddresses != null)
                {
                    item["EmailAddresses"] = SourceExpressionConverter.ConvertToken(itememailAddresses);
                    itempropCount++;
                }

                if (itemiMAddresses != null)
                {
                    item["ImAddresses"] = SourceExpressionConverter.ConvertToken(itemiMAddresses);
                    itempropCount++;
                }

                if (itemjobTitle != null)
                {
                    item["JobTitle"] = SourceExpressionConverter.ConvertToken(itemjobTitle);
                    itempropCount++;
                }

                if (itemcompanyName != null)
                {
                    item["CompanyName"] = SourceExpressionConverter.ConvertToken(itemcompanyName);
                    itempropCount++;
                }

                if (itemdepartment != null)
                {
                    item["Department"] = SourceExpressionConverter.ConvertToken(itemdepartment);
                    itempropCount++;
                }

                if (itemofficeLocation != null)
                {
                    item["OfficeLocation"] = SourceExpressionConverter.ConvertToken(itemofficeLocation);
                    itempropCount++;
                }

                if (itemprofession != null)
                {
                    item["Profession"] = SourceExpressionConverter.ConvertToken(itemprofession);
                    itempropCount++;
                }

                if (itembusinessHomePage != null)
                {
                    item["BusinessHomePage"] = SourceExpressionConverter.ConvertToken(itembusinessHomePage);
                    itempropCount++;
                }

                if (itemassistantName != null)
                {
                    item["AssistantName"] = SourceExpressionConverter.ConvertToken(itemassistantName);
                    itempropCount++;
                }

                if (itemmanager != null)
                {
                    item["Manager"] = SourceExpressionConverter.ConvertToken(itemmanager);
                    itempropCount++;
                }

                itempropCount++;
                item["HomePhones"] = SourceExpressionConverter.ConvertToken(itemhomePhones);
                if (itembusinessPhones != null)
                {
                    item["BusinessPhones"] = SourceExpressionConverter.ConvertToken(itembusinessPhones);
                    itempropCount++;
                }

                if (itemmobilePhone != null)
                {
                    item["MobilePhone1"] = SourceExpressionConverter.ConvertToken(itemmobilePhone);
                    itempropCount++;
                }

                var homeAddressObject = new JObject();
                var homeAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    homeAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    homeAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    homeAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    homeAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    homeAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    homeAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    homeAddressObjectpropCount++;
                }

                if (homeAddressObjectpropCount > 0)
                {
                    item["HomeAddress"] = homeAddressObject;
                    itempropCount++;
                }

                var businessAddressObject = new JObject();
                var businessAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    businessAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    businessAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    businessAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    businessAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    businessAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    businessAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    businessAddressObjectpropCount++;
                }

                if (businessAddressObjectpropCount > 0)
                {
                    item["BusinessAddress"] = businessAddressObject;
                    itempropCount++;
                }

                var otherAddressObject = new JObject();
                var otherAddressObjectpropCount = 0;
                if (itemhomeAddressstreet != null)
                {
                    otherAddressObject["Street"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstreet);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscity != null)
                {
                    otherAddressObject["City"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscity);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddressstate != null)
                {
                    otherAddressObject["State"] = SourceExpressionConverter.ConvertToken(itemhomeAddressstate);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresscountryOrRegion != null)
                {
                    otherAddressObject["CountryOrRegion"] = SourceExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                    otherAddressObjectpropCount++;
                }

                if (itemhomeAddresspostalCode != null)
                {
                    otherAddressObject["PostalCode"] = SourceExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                    otherAddressObjectpropCount++;
                }

                if (otherAddressObjectpropCount > 0)
                {
                    item["OtherAddress"] = otherAddressObject;
                    itempropCount++;
                }

                if (itemyomiCompanyName != null)
                {
                    item["YomiCompanyName"] = SourceExpressionConverter.ConvertToken(itemyomiCompanyName);
                    itempropCount++;
                }

                if (itemyomiGivenName != null)
                {
                    item["YomiGivenName"] = SourceExpressionConverter.ConvertToken(itemyomiGivenName);
                    itempropCount++;
                }

                if (itemyomiSurname != null)
                {
                    item["YomiSurname"] = SourceExpressionConverter.ConvertToken(itemyomiSurname);
                    itempropCount++;
                }

                if (itemcategories != null)
                {
                    item["Categories"] = SourceExpressionConverter.ConvertToken(itemcategories);
                    itempropCount++;
                }

                if (itemchangeKey != null)
                {
                    item["ChangeKey"] = SourceExpressionConverter.ConvertToken(itemchangeKey);
                    itempropCount++;
                }

                if (itemcreatedTime != null)
                {
                    item["DateTimeCreated"] = SourceExpressionConverter.ConvertToken(itemcreatedTime);
                    itempropCount++;
                }

                if (itemlastModifiedTime != null)
                {
                    item["DateTimeLastModified"] = SourceExpressionConverter.ConvertToken(itemlastModifiedTime);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction RespondToEvent([WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<responseInput> response, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bool> bodysendResponse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/events/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(response, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodysendResponse != null)
                {
                    if (bodysendResponse != null)
                    {
                        body["SendResponse"] = SourceExpressionConverter.ConvertToken(bodysendResponse);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["SendResponse"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ForwardEmail([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/messages/{0}/forward", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ToRecipients"] = SourceExpressionConverter.ConvertToken(bodyto);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarGetItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventListClientReceive> CalendarGetItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<CalendarEventListClientReceive>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPatchItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<string> itemrecurrenceEndTime = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = SourceExpressionConverter.ConvertToken(itemsubject);
                itempropCount++;
                item["Start"] = SourceExpressionConverter.ConvertToken(itemstartTime);
                itempropCount++;
                item["End"] = SourceExpressionConverter.ConvertToken(itemendTime);
                if (itemtimeZone != null)
                {
                    item["TimeZone"] = SourceExpressionConverter.Convert(itemtimeZone);
                    itempropCount++;
                }

                if (itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = SourceExpressionConverter.ConvertToken(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = SourceExpressionConverter.ConvertToken(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = SourceExpressionConverter.ConvertToken(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["Body"] = SourceExpressionConverter.ConvertToken(itembody);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["Location"] = SourceExpressionConverter.ConvertToken(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["Importance"] = SourceExpressionConverter.Convert(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = SourceExpressionConverter.ConvertToken(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["Recurrence"] = SourceExpressionConverter.Convert(itemrecurrence);
                    itempropCount++;
                }

                if (itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = SourceExpressionConverter.ConvertToken(itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = SourceExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["Reminder"] = SourceExpressionConverter.ConvertToken(itemreminder);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["ShowAs"] = SourceExpressionConverter.Convert(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["ResponseRequested"] = SourceExpressionConverter.ConvertToken(itemresponseRequested);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPostItem([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemsubject, [WorkflowExpression] Func<string> itemstartTime, [WorkflowExpression] Func<string> itemendTime, [WorkflowExpression] Func<itemtimeZoneInput> itemtimeZone = null, [WorkflowExpression] Func<string> itemrequiredAttendees = null, [WorkflowExpression] Func<string> itemoptionalAttendees = null, [WorkflowExpression] Func<string> itemresourceAttendees = null, [WorkflowExpression] Func<string> itembody = null, [WorkflowExpression] Func<string> itemlocation = null, [WorkflowExpression] Func<itemimportanceInput> itemimportance = null, [WorkflowExpression] Func<bool> itemisAllDayEvent = null, [WorkflowExpression] Func<itemrecurrenceInput> itemrecurrence = null, [WorkflowExpression] Func<string> itemrecurrenceEndTime = null, [WorkflowExpression] Func<int> itemnumberOfOccurrences = null, [WorkflowExpression] Func<int> itemreminder = null, [WorkflowExpression] Func<itemshowAsInput> itemshowAs = null, [WorkflowExpression] Func<bool> itemresponseRequested = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["Subject"] = SourceExpressionConverter.ConvertToken(itemsubject);
                itempropCount++;
                item["Start"] = SourceExpressionConverter.ConvertToken(itemstartTime);
                itempropCount++;
                item["End"] = SourceExpressionConverter.ConvertToken(itemendTime);
                if (itemtimeZone != null)
                {
                    item["TimeZone"] = SourceExpressionConverter.Convert(itemtimeZone);
                    itempropCount++;
                }

                if (itemrequiredAttendees != null)
                {
                    item["RequiredAttendees"] = SourceExpressionConverter.ConvertToken(itemrequiredAttendees);
                    itempropCount++;
                }

                if (itemoptionalAttendees != null)
                {
                    item["OptionalAttendees"] = SourceExpressionConverter.ConvertToken(itemoptionalAttendees);
                    itempropCount++;
                }

                if (itemresourceAttendees != null)
                {
                    item["ResourceAttendees"] = SourceExpressionConverter.ConvertToken(itemresourceAttendees);
                    itempropCount++;
                }

                if (itembody != null)
                {
                    item["Body"] = SourceExpressionConverter.ConvertToken(itembody);
                    itempropCount++;
                }

                if (itemlocation != null)
                {
                    item["Location"] = SourceExpressionConverter.ConvertToken(itemlocation);
                    itempropCount++;
                }

                if (itemimportance != null)
                {
                    item["Importance"] = SourceExpressionConverter.Convert(itemimportance);
                    itempropCount++;
                }

                if (itemisAllDayEvent != null)
                {
                    item["IsAllDay"] = SourceExpressionConverter.ConvertToken(itemisAllDayEvent);
                    itempropCount++;
                }

                if (itemrecurrence != null)
                {
                    item["Recurrence"] = SourceExpressionConverter.Convert(itemrecurrence);
                    itempropCount++;
                }

                if (itemrecurrenceEndTime != null)
                {
                    item["RecurrenceEnd"] = SourceExpressionConverter.ConvertToken(itemrecurrenceEndTime);
                    itempropCount++;
                }

                if (itemnumberOfOccurrences != null)
                {
                    item["NumberOfOccurrences"] = SourceExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                    itempropCount++;
                }

                if (itemreminder != null)
                {
                    item["Reminder"] = SourceExpressionConverter.ConvertToken(itemreminder);
                    itempropCount++;
                }

                if (itemshowAs != null)
                {
                    item["ShowAs"] = SourceExpressionConverter.Convert(itemshowAs);
                    itempropCount++;
                }

                if (itemresponseRequested != null)
                {
                    item["ResponseRequested"] = SourceExpressionConverter.ConvertToken(itemresponseRequested);
                    itempropCount++;
                }

                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> GetEmails([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<string> subjectFilter = null, [WorkflowExpression] Func<bool> fetchOnlyUnread = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> searchQuery = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    callPayload.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    callPayload.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                callPayload.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    callPayload.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    callPayload.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                if (subjectFilter != null)
                    callPayload.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
                if (fetchOnlyUnread != null)
                    callPayload.Queries["fetchOnlyUnread"] = SourceExpressionConverter.ConvertO(fetchOnlyUnread);
                callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (searchQuery != null)
                    callPayload.Queries["searchQuery"] = SourceExpressionConverter.ConvertO(searchQuery);
                callPayload.Queries["top"] = Convert.ToString(10);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<BatchResponseClientReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarView([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> startDateTimeOffset, [WorkflowExpression] Func<string> endDateTimeOffset, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> search = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets/calendars/v2/tables/items/calendarview";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["calendarId"] = SourceExpressionConverter.ConvertO(calendarId);
                callPayload.Queries["startDateTimeOffset"] = SourceExpressionConverter.ConvertO(startDateTimeOffset);
                callPayload.Queries["endDateTimeOffset"] = SourceExpressionConverter.ConvertO(endDateTimeOffset);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<EntityListResponseCalendarEventClientReceiveStringEnums>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> replyParametersto = null, [WorkflowExpression] Func<string> replyParameterscC = null, [WorkflowExpression] Func<string> replyParametersbCC = null, [WorkflowExpression] Func<string> replyParameterssubject = null, [WorkflowExpression] Func<string> replyParametersbody = null, [WorkflowExpression] Func<bool> replyParametersreplyAll = null, [WorkflowExpression] Func<replyParametersimportanceInput> replyParametersimportance = null, [WorkflowExpression] Func<ClientSendAttachment[]> replyParametersattachments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replyParameters = new JObject();
                var replyParameterspropCount = 0;
                if (replyParametersto != null)
                {
                    replyParameters["To"] = SourceExpressionConverter.ConvertToken(replyParametersto);
                    replyParameterspropCount++;
                }

                if (replyParameterscC != null)
                {
                    replyParameters["Cc"] = SourceExpressionConverter.ConvertToken(replyParameterscC);
                    replyParameterspropCount++;
                }

                if (replyParametersbCC != null)
                {
                    replyParameters["Bcc"] = SourceExpressionConverter.ConvertToken(replyParametersbCC);
                    replyParameterspropCount++;
                }

                if (replyParameterssubject != null)
                {
                    replyParameters["Subject"] = SourceExpressionConverter.ConvertToken(replyParameterssubject);
                    replyParameterspropCount++;
                }

                if (replyParametersbody != null)
                {
                    replyParameters["Body"] = SourceExpressionConverter.ConvertToken(replyParametersbody);
                    replyParameterspropCount++;
                }

                if (replyParametersreplyAll != null)
                {
                    replyParameters["ReplyAll"] = SourceExpressionConverter.ConvertToken(replyParametersreplyAll);
                    replyParameterspropCount++;
                }

                if (replyParametersimportance != null)
                {
                    replyParameters["Importance"] = SourceExpressionConverter.Convert(replyParametersimportance);
                    replyParameterspropCount++;
                }

                if (replyParametersattachments != null)
                {
                    replyParameters["Attachments"] = SourceExpressionConverter.ConvertToken(replyParametersattachments);
                    replyParameterspropCount++;
                }

                if (replyParameterspropCount > 0)
                {
                    callPayload.Body = replyParameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagesubject, [WorkflowExpression] Func<string> emailMessagebody, [WorkflowExpression] Func<string> emailMessagefromSendAs = null, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<ClientSendAttachment[]> emailMessageattachments = null, [WorkflowExpression] Func<string> emailMessagereplyTo = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = SourceExpressionConverter.ConvertToken(emailMessageto);
                emailMessagepropCount++;
                emailMessage["Subject"] = SourceExpressionConverter.ConvertToken(emailMessagesubject);
                emailMessagepropCount++;
                emailMessage["Body"] = SourceExpressionConverter.ConvertToken(emailMessagebody);
                if (emailMessagefromSendAs != null)
                {
                    emailMessage["From"] = SourceExpressionConverter.ConvertToken(emailMessagefromSendAs);
                    emailMessagepropCount++;
                }

                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = SourceExpressionConverter.ConvertToken(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = SourceExpressionConverter.ConvertToken(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = SourceExpressionConverter.ConvertToken(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagereplyTo != null)
                {
                    emailMessage["ReplyTo"] = SourceExpressionConverter.ConvertToken(emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    if (emailMessageimportance != null)
                    {
                        emailMessage["Importance"] = SourceExpressionConverter.Convert(emailMessageimportance);
                        emailMessagepropCount++;
                    }

                    emailMessagepropCount++;
                }
                else
                {
                    emailMessage["Importance"] = "Normal";
                    emailMessagepropCount++;
                }

                if (emailMessagepropCount > 0)
                {
                    callPayload.Body = emailMessage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventListWithActionType> CalendarGetOnChangedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> incomingDays = null, [WorkflowExpression] Func<int> pastDays = null, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/datasets/calendars/v2/tables/{0}/onchangeditems"
                    },
                    Method = "get",
                };
                input.Fetch.Queries["incomingDays"] = Convert.ToString(300);
                if (incomingDays != null)
                    input.Fetch.Queries["incomingDays"] = SourceExpressionConverter.ConvertO(incomingDays);
                input.Fetch.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Fetch.Queries["pastDays"] = SourceExpressionConverter.ConvertO(pastDays);
                input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/{0}/EventSubscriptionPoke/$subscriptions"
                    },
                    Method = "post",
                };
                input.Subscribe.Queries["incomingDays"] = Convert.ToString(300);
                if (incomingDays != null)
                    input.Subscribe.Queries["incomingDays"] = SourceExpressionConverter.ConvertO(incomingDays);
                input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
                if (pastDays != null)
                    input.Subscribe.Queries["pastDays"] = SourceExpressionConverter.ConvertO(pastDays);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<CalendarEventListWithActionType>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnNewItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnUpdatedItems([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnFlaggedEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnFlaggedEmail"
                    },
                    Method = "get",
                };
                input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/FlaggedMailSubscriptionPoke/$subscriptions"
                    },
                    Method = "post",
                };
                input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewEmail"
                    },
                    Method = "get",
                };
                input.Fetch.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/MailSubscriptionPoke/$subscriptions"
                    },
                    Method = "post",
                };
                input.Subscribe.Queries["folderPath"] = Convert.ToString("Inbox");
                if (folderPath != null)
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewMentionMeEmail([WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> toOrCc = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachment = null, [WorkflowExpression] Func<bool> includeAttachments = null, [WorkflowExpression] Func<string> subjectFilter = null, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
            {
                var input = new ApiConnectionNotificationActionInput(connectionId);
                input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/v2/Mail/OnNewMentionMeEmail"
                    },
                    Method = "get",
                };
                if (folderPath != null)
                    input.Fetch.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (to != null)
                    input.Fetch.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (cc != null)
                    input.Fetch.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (toOrCc != null)
                    input.Fetch.Queries["toOrCc"] = SourceExpressionConverter.ConvertO(toOrCc);
                if (from != null)
                    input.Fetch.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                input.Fetch.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Fetch.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Fetch.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    input.Fetch.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                if (subjectFilter != null)
                    input.Fetch.Queries["subjectFilter"] = SourceExpressionConverter.ConvertO(subjectFilter);
                input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
                {
                    Queries = new Dictionary<string, string>(),
                    Headers = new Dictionary<string, string>(),
                    PathTemplate = new PathTemplate
                    {
                        Template = "/MentionMeMailSubscriptionPoke/$subscriptions"
                    },
                    Method = "post",
                };
                if (folderPath != null)
                    input.Subscribe.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                input.Subscribe.Queries["importance"] = Convert.ToString("Any");
                if (importance != null)
                    input.Subscribe.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
                if (fetchOnlyWithAttachment != null)
                    input.Subscribe.Queries["fetchOnlyWithAttachment"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachment);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> OnUpcomingEvents([WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Events/OnUpcomingEvents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table"] = SourceExpressionConverter.ConvertO(table);
                callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
                if (lookAheadTimeInMinutes != null)
                    callPayload.Queries["lookAheadTimeInMinutes"] = SourceExpressionConverter.ConvertO(lookAheadTimeInMinutes);
                return callPayload;
            }

            return new ApiConnectionTrigger<CalendarEventListClientReceive>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ClientReceiveMessage
    {
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Importance { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }

        [JsonProperty("Id")]
        public string MessageId { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }

        [JsonProperty("DateTimeReceived")]
        public string ReceivedTime { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
    }

    public class ClientReceiveFileAttachment
    {
        [JsonProperty("Id")]
        public string AttachmentId { get; set; }
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public bool IsInline { get; set; }
        public string LastModifiedDateTime { get; set; }
        public string ContentId { get; set; }
    }

    public class ClientReceiveMessageStringEnums
    {
        public ClientReceiveMessageStringEnumsImportanceType Importance { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string ReplyTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyPreview { get; set; }
        public bool HasAttachment { get; set; }

        [JsonProperty("Id")]
        public string MessageId { get; set; }
        public string InternetMessageId { get; set; }
        public string ConversationId { get; set; }

        [JsonProperty("DateTimeReceived")]
        public string ReceivedTime { get; set; }
        public bool IsRead { get; set; }
        public ClientReceiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
    }

    public enum ClientReceiveMessageStringEnumsImportanceType
    {
        Low,
        Normal,
        High
    }

    public class SubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }
    }

    public enum optionsEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class ClientSendAttachment
    {
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
    }

    public enum approvalEmailSubscriptionmessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class EntityListResponseTable
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class EntityListResponseContactResponse
    {
        [JsonProperty("value")]
        public ContactResponse[] Value { get; set; }
    }

    public class ContactResponse
    {
        public string GivenName { get; set; }
        public string[] HomePhones { get; set; }
        public string Id { get; set; }
        public string ParentFolderId { get; set; }
        public string Birthday { get; set; }
        public string FileAs { get; set; }
        public string DisplayName { get; set; }
        public string Initials { get; set; }
        public string MiddleName { get; set; }

        [JsonProperty("NickName")]
        public string Nickname { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string Generation { get; set; }
        public EmailAddress[] EmailAddresses { get; set; }

        [JsonProperty("ImAddresses")]
        public string[] IMAddresses { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string OfficeLocation { get; set; }
        public string Profession { get; set; }
        public string BusinessHomePage { get; set; }
        public string AssistantName { get; set; }
        public string Manager { get; set; }
        public string[] BusinessPhones { get; set; }

        [JsonProperty("MobilePhone1")]
        public string MobilePhone { get; set; }
        public PhysicalAddress HomeAddress { get; set; }
        public PhysicalAddress BusinessAddress { get; set; }
        public PhysicalAddress OtherAddress { get; set; }
        public string YomiCompanyName { get; set; }
        public string YomiGivenName { get; set; }
        public string YomiSurname { get; set; }
        public string[] Categories { get; set; }
        public string ChangeKey { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
    }

    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class PhysicalAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryOrRegion { get; set; }
        public string PostalCode { get; set; }
    }

    public enum responseInput
    {
        Accept,
        [EnumMember(Value = "Tentatively Accept")]
        TentativelyAccept,
        Decline
    }

    public class CalendarEventClientReceiveStringEnums
    {
        public CalendarEventClientReceiveStringEnumsImportanceType Importance { get; set; }
        public CalendarEventClientReceiveStringEnumsResponseTypeType ResponseType { get; set; }
        public CalendarEventClientReceiveStringEnumsRecurrenceType Recurrence { get; set; }
        public CalendarEventClientReceiveStringEnumsShowAsType ShowAs { get; set; }
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public enum CalendarEventClientReceiveStringEnumsImportanceType
    {
        Low,
        Normal,
        High
    }

    public enum CalendarEventClientReceiveStringEnumsResponseTypeType
    {
        None,
        Organizer,
        TentativelyAccepted,
        Accepted,
        Declined,
        NotResponded
    }

    public enum CalendarEventClientReceiveStringEnumsRecurrenceType
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum CalendarEventClientReceiveStringEnumsShowAsType
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public class CalendarEventListClientReceive
    {
        [JsonProperty("value")]
        public CalendarEventClientReceive[] Value { get; set; }
    }

    public class CalendarEventClientReceive
    {
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public enum itemtimeZoneInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "(UTC-12:00) International Date Line West")]
        UTC1200InternationalDateLineWest,
        [EnumMember(Value = "(UTC-11:00) Coordinated Universal Time-11")]
        UTC1100CoordinatedUniversalTime11,
        [EnumMember(Value = "(UTC-10:00) Aleutian Islands")]
        UTC1000AleutianIslands,
        [EnumMember(Value = "(UTC-10:00) Hawaii")]
        UTC1000Hawaii,
        [EnumMember(Value = "(UTC-09:30) Marquesas Islands")]
        UTC0930MarquesasIslands,
        [EnumMember(Value = "(UTC-09:00) Alaska")]
        UTC0900Alaska,
        [EnumMember(Value = "(UTC-09:00) Coordinated Universal Time-09")]
        UTC0900CoordinatedUniversalTime09,
        [EnumMember(Value = "(UTC-08:00) Baja California")]
        UTC0800BajaCalifornia,
        [EnumMember(Value = "(UTC-08:00) Coordinated Universal Time-08")]
        UTC0800CoordinatedUniversalTime08,
        [EnumMember(Value = "(UTC-08:00) Pacific Time (US & Canada)")]
        UTC0800PacificTimeUSCanada,
        [EnumMember(Value = "(UTC-07:00) Arizona")]
        UTC0700Arizona,
        [EnumMember(Value = "(UTC-07:00) Chihuahua, La Paz, Mazatlan")]
        UTC0700ChihuahuaLaPazMazatlan,
        [EnumMember(Value = "(UTC-07:00) Mountain Time (US & Canada)")]
        UTC0700MountainTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Central America")]
        UTC0600CentralAmerica,
        [EnumMember(Value = "(UTC-06:00) Central Time (US & Canada)")]
        UTC0600CentralTimeUSCanada,
        [EnumMember(Value = "(UTC-06:00) Easter Island")]
        UTC0600EasterIsland,
        [EnumMember(Value = "(UTC-06:00) Guadalajara, Mexico City, Monterrey")]
        UTC0600GuadalajaraMexicoCityMonterrey,
        [EnumMember(Value = "(UTC-06:00) Saskatchewan")]
        UTC0600Saskatchewan,
        [EnumMember(Value = "(UTC-05:00) Bogota, Lima, Quito, Rio Branco")]
        UTC0500BogotaLimaQuitoRioBranco,
        [EnumMember(Value = "(UTC-05:00) Chetumal")]
        UTC0500Chetumal,
        [EnumMember(Value = "(UTC-05:00) Eastern Time (US & Canada)")]
        UTC0500EasternTimeUSCanada,
        [EnumMember(Value = "(UTC-05:00) Haiti")]
        UTC0500Haiti,
        [EnumMember(Value = "(UTC-05:00) Havana")]
        UTC0500Havana,
        [EnumMember(Value = "(UTC-05:00) Indiana (East)")]
        UTC0500IndianaEast,
        [EnumMember(Value = "(UTC-04:00) Asuncion")]
        UTC0400Asuncion,
        [EnumMember(Value = "(UTC-04:00) Atlantic Time (Canada)")]
        UTC0400AtlanticTimeCanada,
        [EnumMember(Value = "(UTC-04:00) Caracas")]
        UTC0400Caracas,
        [EnumMember(Value = "(UTC-04:00) Cuiaba")]
        UTC0400Cuiaba,
        [EnumMember(Value = "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan")]
        UTC0400GeorgetownLaPazManausSanJuan,
        [EnumMember(Value = "(UTC-04:00) Santiago")]
        UTC0400Santiago,
        [EnumMember(Value = "(UTC-04:00) Turks and Caicos")]
        UTC0400TurksAndCaicos,
        [EnumMember(Value = "(UTC-03:30) Newfoundland")]
        UTC0330Newfoundland,
        [EnumMember(Value = "(UTC-03:00) Araguaina")]
        UTC0300Araguaina,
        [EnumMember(Value = "(UTC-03:00) Brasilia")]
        UTC0300Brasilia,
        [EnumMember(Value = "(UTC-03:00) Cayenne, Fortaleza")]
        UTC0300CayenneFortaleza,
        [EnumMember(Value = "(UTC-03:00) City of Buenos Aires")]
        UTC0300CityOfBuenosAires,
        [EnumMember(Value = "(UTC-03:00) Greenland")]
        UTC0300Greenland,
        [EnumMember(Value = "(UTC-03:00) Montevideo")]
        UTC0300Montevideo,
        [EnumMember(Value = "(UTC-03:00) Punta Arenas")]
        UTC0300PuntaArenas,
        [EnumMember(Value = "(UTC-03:00) Saint Pierre and Miquelon")]
        UTC0300SaintPierreAndMiquelon,
        [EnumMember(Value = "(UTC-03:00) Salvador")]
        UTC0300Salvador,
        [EnumMember(Value = "(UTC-02:00) Coordinated Universal Time-02")]
        UTC0200CoordinatedUniversalTime02,
        [EnumMember(Value = "(UTC-02:00) Mid-Atlantic - Old")]
        UTC0200MidAtlanticOld,
        [EnumMember(Value = "(UTC-01:00) Azores")]
        UTC0100Azores,
        [EnumMember(Value = "(UTC-01:00) Cabo Verde Is.")]
        UTC0100CaboVerdeIs,
        [EnumMember(Value = "(UTC) Coordinated Universal Time")]
        UTCCoordinatedUniversalTime,
        [EnumMember(Value = "(UTC+00:00) Casablanca")]
        UTC0000Casablanca,
        [EnumMember(Value = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London")]
        UTC0000DublinEdinburghLisbonLondon,
        [EnumMember(Value = "(UTC+00:00) Monrovia, Reykjavik")]
        UTC0000MonroviaReykjavik,
        [EnumMember(Value = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna")]
        UTC0100AmsterdamBerlinBernRomeStockholmVienna,
        [EnumMember(Value = "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague")]
        UTC0100BelgradeBratislavaBudapestLjubljanaPrague,
        [EnumMember(Value = "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris")]
        UTC0100BrusselsCopenhagenMadridParis,
        [EnumMember(Value = "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb")]
        UTC0100SarajevoSkopjeWarsawZagreb,
        [EnumMember(Value = "(UTC+01:00) West Central Africa")]
        UTC0100WestCentralAfrica,
        [EnumMember(Value = "(UTC+01:00) Windhoek")]
        UTC0100Windhoek,
        [EnumMember(Value = "(UTC+02:00) Amman")]
        UTC0200Amman,
        [EnumMember(Value = "(UTC+02:00) Athens, Bucharest")]
        UTC0200AthensBucharest,
        [EnumMember(Value = "(UTC+02:00) Beirut")]
        UTC0200Beirut,
        [EnumMember(Value = "(UTC+02:00) Cairo")]
        UTC0200Cairo,
        [EnumMember(Value = "(UTC+02:00) Chisinau")]
        UTC0200Chisinau,
        [EnumMember(Value = "(UTC+02:00) Damascus")]
        UTC0200Damascus,
        [EnumMember(Value = "(UTC+02:00) Gaza, Hebron")]
        UTC0200GazaHebron,
        [EnumMember(Value = "(UTC+02:00) Harare, Pretoria")]
        UTC0200HararePretoria,
        [EnumMember(Value = "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius")]
        UTC0200HelsinkiKyivRigaSofiaTallinnVilnius,
        [EnumMember(Value = "(UTC+02:00) Jerusalem")]
        UTC0200Jerusalem,
        [EnumMember(Value = "(UTC+02:00) Kaliningrad")]
        UTC0200Kaliningrad,
        [EnumMember(Value = "(UTC+02:00) Tripoli")]
        UTC0200Tripoli,
        [EnumMember(Value = "(UTC+03:00) Baghdad")]
        UTC0300Baghdad,
        [EnumMember(Value = "(UTC+03:00) Istanbul")]
        UTC0300Istanbul,
        [EnumMember(Value = "(UTC+03:00) Kuwait, Riyadh")]
        UTC0300KuwaitRiyadh,
        [EnumMember(Value = "(UTC+03:00) Minsk")]
        UTC0300Minsk,
        [EnumMember(Value = "(UTC+03:00) Moscow, St. Petersburg")]
        UTC0300MoscowStPetersburg,
        [EnumMember(Value = "(UTC+03:00) Nairobi")]
        UTC0300Nairobi,
        [EnumMember(Value = "(UTC+03:30) Tehran")]
        UTC0330Tehran,
        [EnumMember(Value = "(UTC+04:00) Abu Dhabi, Muscat")]
        UTC0400AbuDhabiMuscat,
        [EnumMember(Value = "(UTC+04:00) Astrakhan, Ulyanovsk")]
        UTC0400AstrakhanUlyanovsk,
        [EnumMember(Value = "(UTC+04:00) Baku")]
        UTC0400Baku,
        [EnumMember(Value = "(UTC+04:00) Izhevsk, Samara")]
        UTC0400IzhevskSamara,
        [EnumMember(Value = "(UTC+04:00) Port Louis")]
        UTC0400PortLouis,
        [EnumMember(Value = "(UTC+04:00) Saratov")]
        UTC0400Saratov,
        [EnumMember(Value = "(UTC+04:00) Tbilisi")]
        UTC0400Tbilisi,
        [EnumMember(Value = "(UTC+04:00) Volgograd")]
        UTC0400Volgograd,
        [EnumMember(Value = "(UTC+04:00) Yerevan")]
        UTC0400Yerevan,
        [EnumMember(Value = "(UTC+04:30) Kabul")]
        UTC0430Kabul,
        [EnumMember(Value = "(UTC+05:00) Ashgabat, Tashkent")]
        UTC0500AshgabatTashkent,
        [EnumMember(Value = "(UTC+05:00) Ekaterinburg")]
        UTC0500Ekaterinburg,
        [EnumMember(Value = "(UTC+05:00) Islamabad, Karachi")]
        UTC0500IslamabadKarachi,
        [EnumMember(Value = "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi")]
        UTC0530ChennaiKolkataMumbaiNewDelhi,
        [EnumMember(Value = "(UTC+05:30) Sri Jayawardenepura")]
        UTC0530SriJayawardenepura,
        [EnumMember(Value = "(UTC+05:45) Kathmandu")]
        UTC0545Kathmandu,
        [EnumMember(Value = "(UTC+06:00) Astana")]
        UTC0600Astana,
        [EnumMember(Value = "(UTC+06:00) Dhaka")]
        UTC0600Dhaka,
        [EnumMember(Value = "(UTC+06:00) Omsk")]
        UTC0600Omsk,
        [EnumMember(Value = "(UTC+06:30) Yangon (Rangoon)")]
        UTC0630YangonRangoon,
        [EnumMember(Value = "(UTC+07:00) Bangkok, Hanoi, Jakarta")]
        UTC0700BangkokHanoiJakarta,
        [EnumMember(Value = "(UTC+07:00) Barnaul, Gorno-Altaysk")]
        UTC0700BarnaulGornoAltaysk,
        [EnumMember(Value = "(UTC+07:00) Hovd")]
        UTC0700Hovd,
        [EnumMember(Value = "(UTC+07:00) Krasnoyarsk")]
        UTC0700Krasnoyarsk,
        [EnumMember(Value = "(UTC+07:00) Novosibirsk")]
        UTC0700Novosibirsk,
        [EnumMember(Value = "(UTC+07:00) Tomsk")]
        UTC0700Tomsk,
        [EnumMember(Value = "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi")]
        UTC0800BeijingChongqingHongKongUrumqi,
        [EnumMember(Value = "(UTC+08:00) Irkutsk")]
        UTC0800Irkutsk,
        [EnumMember(Value = "(UTC+08:00) Kuala Lumpur, Singapore")]
        UTC0800KualaLumpurSingapore,
        [EnumMember(Value = "(UTC+08:00) Perth")]
        UTC0800Perth,
        [EnumMember(Value = "(UTC+08:00) Taipei")]
        UTC0800Taipei,
        [EnumMember(Value = "(UTC+08:00) Ulaanbaatar")]
        UTC0800Ulaanbaatar,
        [EnumMember(Value = "(UTC+08:30) Pyongyang")]
        UTC0830Pyongyang,
        [EnumMember(Value = "(UTC+08:45) Eucla")]
        UTC0845Eucla,
        [EnumMember(Value = "(UTC+09:00) Chita")]
        UTC0900Chita,
        [EnumMember(Value = "(UTC+09:00) Osaka, Sapporo, Tokyo")]
        UTC0900OsakaSapporoTokyo,
        [EnumMember(Value = "(UTC+09:00) Seoul")]
        UTC0900Seoul,
        [EnumMember(Value = "(UTC+09:00) Yakutsk")]
        UTC0900Yakutsk,
        [EnumMember(Value = "(UTC+09:30) Adelaide")]
        UTC0930Adelaide,
        [EnumMember(Value = "(UTC+09:30) Darwin")]
        UTC0930Darwin,
        [EnumMember(Value = "(UTC+10:00) Brisbane")]
        UTC1000Brisbane,
        [EnumMember(Value = "(UTC+10:00) Canberra, Melbourne, Sydney")]
        UTC1000CanberraMelbourneSydney,
        [EnumMember(Value = "(UTC+10:00) Guam, Port Moresby")]
        UTC1000GuamPortMoresby,
        [EnumMember(Value = "(UTC+10:00) Hobart")]
        UTC1000Hobart,
        [EnumMember(Value = "(UTC+10:00) Vladivostok")]
        UTC1000Vladivostok,
        [EnumMember(Value = "(UTC+10:30) Lord Howe Island")]
        UTC1030LordHoweIsland,
        [EnumMember(Value = "(UTC+11:00) Bougainville Island")]
        UTC1100BougainvilleIsland,
        [EnumMember(Value = "(UTC+11:00) Chokurdakh")]
        UTC1100Chokurdakh,
        [EnumMember(Value = "(UTC+11:00) Magadan")]
        UTC1100Magadan,
        [EnumMember(Value = "(UTC+11:00) Norfolk Island")]
        UTC1100NorfolkIsland,
        [EnumMember(Value = "(UTC+11:00) Sakhalin")]
        UTC1100Sakhalin,
        [EnumMember(Value = "(UTC+11:00) Solomon Is., New Caledonia")]
        UTC1100SolomonIsNewCaledonia,
        [EnumMember(Value = "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky")]
        UTC1200AnadyrPetropavlovskKamchatsky,
        [EnumMember(Value = "(UTC+12:00) Auckland, Wellington")]
        UTC1200AucklandWellington,
        [EnumMember(Value = "(UTC+12:00) Coordinated Universal Time+12")]
        UTC1200CoordinatedUniversalTime12,
        [EnumMember(Value = "(UTC+12:00) Fiji")]
        UTC1200Fiji,
        [EnumMember(Value = "(UTC+12:00) Petropavlovsk-Kamchatsky - Old")]
        UTC1200PetropavlovskKamchatskyOld,
        [EnumMember(Value = "(UTC+12:45) Chatham Islands")]
        UTC1245ChathamIslands,
        [EnumMember(Value = "(UTC+13:00) Coordinated Universal Time+13")]
        UTC1300CoordinatedUniversalTime13,
        [EnumMember(Value = "(UTC+13:00) Nuku'alofa")]
        UTC1300NukuAlofa,
        [EnumMember(Value = "(UTC+13:00) Samoa")]
        UTC1300Samoa,
        [EnumMember(Value = "(UTC+14:00) Kiritimati Island")]
        UTC1400KiritimatiIsland
    }

    public enum itemimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum itemrecurrenceInput
    {
        None,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum itemshowAsInput
    {
        Free,
        Tentative,
        Busy,
        Oof,
        WorkingElsewhere,
        Unknown
    }

    public class BatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }

    public enum importanceInput
    {
        Any,
        Low,
        Normal,
        High
    }

    public class EntityListResponseCalendarEventClientReceiveStringEnums
    {
        [JsonProperty("value")]
        public CalendarEventClientReceiveStringEnums[] Value { get; set; }
    }

    public enum replyParametersimportanceInput
    {
        Low,
        Normal,
        High
    }

    public enum emailMessageimportanceInput
    {
        Low,
        Normal,
        High
    }

    public class CalendarEventListWithActionType
    {
        [JsonProperty("value")]
        public CalendarEventClientWithActionType[] Value { get; set; }
    }

    public class CalendarEventClientWithActionType
    {
        public CalendarEventClientWithActionTypeActionTypeType ActionType { get; set; }
        public bool IsAdded { get; set; }
        public bool IsUpdated { get; set; }
        public string Subject { get; set; }

        [JsonProperty("Start")]
        public string StartTime { get; set; }

        [JsonProperty("End")]
        public string EndTime { get; set; }
        public int ShowAs { get; set; }
        public int Recurrence { get; set; }
        public int ResponseType { get; set; }
        public string ResponseTime { get; set; }

        [JsonProperty("ICalUId")]
        public string EventUniqueID { get; set; }
        public int Importance { get; set; }
        public string Id { get; set; }

        [JsonProperty("DateTimeCreated")]
        public string CreatedTime { get; set; }

        [JsonProperty("DateTimeLastModified")]
        public string LastModifiedTime { get; set; }
        public string Organizer { get; set; }
        public string TimeZone { get; set; }
        public string SeriesMasterId { get; set; }
        public string[] Categories { get; set; }
        public string WebLink { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }
        public string ResourceAttendees { get; set; }
        public string Body { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public string Location { get; set; }

        [JsonProperty("IsAllDay")]
        public bool IsAllDayEvent { get; set; }

        [JsonProperty("RecurrenceEnd")]
        public string RecurrenceEndTime { get; set; }
        public int NumberOfOccurrences { get; set; }
        public int Reminder { get; set; }
        public bool ResponseRequested { get; set; }
    }

    public enum CalendarEventClientWithActionTypeActionTypeType
    {
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    public class TriggerBatchResponseClientReceiveMessage
    {
        [JsonProperty("value")]
        public ClientReceiveMessage[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Outlook;

    public partial class WorkflowManagedActions
    {
        public OutlookActions Outlook(string connectionId) => new OutlookActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OutlookTriggers Outlook(string connectionId) => new OutlookTriggers(connectionId);
    }
}