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
        public IBodyWorkflowAction<ClientReceiveMessage> GetEmail(Expression<Func<string>> messageId, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> internetMessageId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (internetMessageId != null)
                callPayload.Queries["internetMessageId"] = CSharpExpressionConverter.ConvertO(internetMessageId);
            return new ApiConnectionAction<ClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ClientReceiveMessageStringEnums> Move(Expression<Func<string>> messageId, Expression<Func<string>> folderPath)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/Move/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            return new ApiConnectionAction<ClientReceiveMessageStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction Flag(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/Flag/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction MarkAsRead(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/MarkAsRead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<string> GetAttachment(Expression<Func<string>> messageId, Expression<Func<string>> attachmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}/Attachments/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendMailWithOptions(Expression<Func<string>> optionsEmailSubscriptionmessageto, Expression<Func<string>> optionsEmailSubscriptionmessagesubject = null, Expression<Func<string>> optionsEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> optionsEmailSubscriptionmessageheaderText = null, Expression<Func<string>> optionsEmailSubscriptionmessageselectionText = null, Expression<Func<string>> optionsEmailSubscriptionmessagebody = null, Expression<Func<optionsEmailSubscriptionmessageimportanceInput>> optionsEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> optionsEmailSubscriptionmessageattachments = null, Expression<Func<bool>> optionsEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> optionsEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/mailwithoptions/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var optionsEmailSubscription = new JObject();
            var optionsEmailSubscriptionpropCount = 0;
            optionsEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            optionsEmailSubscriptionpropCount++;
            var messageObject = new JObject();
            var messageObjectpropCount = 0;
            messageObjectpropCount++;
            messageObject["To"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageto);
            if (optionsEmailSubscriptionmessagesubject != null)
            {
                if (optionsEmailSubscriptionmessagesubject != null)
                {
                    messageObject["Subject"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagesubject);
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
                    messageObject["Options"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuserOptions);
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
                messageObject["HeaderText"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageheaderText);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageselectionText != null)
            {
                messageObject["SelectionText"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageselectionText);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessagebody != null)
            {
                messageObject["Body"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagebody);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageimportance != null)
            {
                if (optionsEmailSubscriptionmessageimportance != null)
                {
                    messageObject["Importance"] = CSharpExpressionConverter.Convert(optionsEmailSubscriptionmessageimportance);
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
                messageObject["Attachments"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageattachments);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessageuseOnlyHTMLMessage != null)
            {
                messageObject["UseOnlyHTMLMessage"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageuseOnlyHTMLMessage);
                messageObjectpropCount++;
            }

            if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
            {
                if (optionsEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    messageObject["HideHTMLMessage"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessagehideHTMLMessage);
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
                    messageObject["ShowHTMLConfirmationDialog"] = CSharpExpressionConverter.ConvertToken(optionsEmailSubscriptionmessageshowHTMLConfirmationDialog);
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

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<SubscriptionResponse> SendApprovalMail(Expression<Func<string>> approvalEmailSubscriptionmessageto, Expression<Func<string>> approvalEmailSubscriptionmessagesubject = null, Expression<Func<string>> approvalEmailSubscriptionmessageuserOptions = null, Expression<Func<string>> approvalEmailSubscriptionmessageheaderText = null, Expression<Func<string>> approvalEmailSubscriptionmessageselectionText = null, Expression<Func<string>> approvalEmailSubscriptionmessagebody = null, Expression<Func<approvalEmailSubscriptionmessageimportanceInput>> approvalEmailSubscriptionmessageimportance = null, Expression<Func<ClientSendAttachment[]>> approvalEmailSubscriptionmessageattachments = null, Expression<Func<bool>> approvalEmailSubscriptionmessageuseOnlyHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessagehideHTMLMessage = null, Expression<Func<bool>> approvalEmailSubscriptionmessageshowHTMLConfirmationDialog = null)
        {
            var apiCallPath = "/approvalmail/$subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var approvalEmailSubscription = new JObject();
            var approvalEmailSubscriptionpropCount = 0;
            approvalEmailSubscription["NotificationUrl"] = "@listCallbackUrl()";
            approvalEmailSubscriptionpropCount++;
            var messageObject = new JObject();
            var messageObjectpropCount = 0;
            messageObjectpropCount++;
            messageObject["To"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageto);
            if (approvalEmailSubscriptionmessagesubject != null)
            {
                if (approvalEmailSubscriptionmessagesubject != null)
                {
                    messageObject["Subject"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagesubject);
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
                    messageObject["Options"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuserOptions);
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
                messageObject["HeaderText"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageheaderText);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageselectionText != null)
            {
                messageObject["SelectionText"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageselectionText);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessagebody != null)
            {
                messageObject["Body"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagebody);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageimportance != null)
            {
                if (approvalEmailSubscriptionmessageimportance != null)
                {
                    messageObject["Importance"] = CSharpExpressionConverter.Convert(approvalEmailSubscriptionmessageimportance);
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
                messageObject["Attachments"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageattachments);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessageuseOnlyHTMLMessage != null)
            {
                messageObject["UseOnlyHTMLMessage"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageuseOnlyHTMLMessage);
                messageObjectpropCount++;
            }

            if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
            {
                if (approvalEmailSubscriptionmessagehideHTMLMessage != null)
                {
                    messageObject["HideHTMLMessage"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessagehideHTMLMessage);
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
                    messageObject["ShowHTMLConfirmationDialog"] = CSharpExpressionConverter.ConvertToken(approvalEmailSubscriptionmessageshowHTMLConfirmationDialog);
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

            return new ApiConnectionAction<SubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> CalendarGetTables()
        {
            var apiCallPath = "/datasets/calendars/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction CalendarDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseTable> ContactGetTables()
        {
            var apiCallPath = "/datasets/contacts/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntityListResponseTable>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseContactResponse> ContactGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<EntityListResponseContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPostItem(Expression<Func<string>> table, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemid != null)
            {
                item["Id"] = CSharpExpressionConverter.ConvertToken(itemid);
                itempropCount++;
            }

            if (itemparentFolderId != null)
            {
                item["ParentFolderId"] = CSharpExpressionConverter.ConvertToken(itemparentFolderId);
                itempropCount++;
            }

            if (itembirthday != null)
            {
                item["Birthday"] = CSharpExpressionConverter.ConvertToken(itembirthday);
                itempropCount++;
            }

            if (itemfileAs != null)
            {
                item["FileAs"] = CSharpExpressionConverter.ConvertToken(itemfileAs);
                itempropCount++;
            }

            if (itemdisplayName != null)
            {
                item["DisplayName"] = CSharpExpressionConverter.ConvertToken(itemdisplayName);
                itempropCount++;
            }

            itempropCount++;
            item["GivenName"] = CSharpExpressionConverter.ConvertToken(itemgivenName);
            if (iteminitials != null)
            {
                item["Initials"] = CSharpExpressionConverter.ConvertToken(iteminitials);
                itempropCount++;
            }

            if (itemmiddleName != null)
            {
                item["MiddleName"] = CSharpExpressionConverter.ConvertToken(itemmiddleName);
                itempropCount++;
            }

            if (itemnickname != null)
            {
                item["NickName"] = CSharpExpressionConverter.ConvertToken(itemnickname);
                itempropCount++;
            }

            if (itemsurname != null)
            {
                item["Surname"] = CSharpExpressionConverter.ConvertToken(itemsurname);
                itempropCount++;
            }

            if (itemtitle != null)
            {
                item["Title"] = CSharpExpressionConverter.ConvertToken(itemtitle);
                itempropCount++;
            }

            if (itemgeneration != null)
            {
                item["Generation"] = CSharpExpressionConverter.ConvertToken(itemgeneration);
                itempropCount++;
            }

            if (itememailAddresses != null)
            {
                item["EmailAddresses"] = CSharpExpressionConverter.ConvertToken(itememailAddresses);
                itempropCount++;
            }

            if (itemiMAddresses != null)
            {
                item["ImAddresses"] = CSharpExpressionConverter.ConvertToken(itemiMAddresses);
                itempropCount++;
            }

            if (itemjobTitle != null)
            {
                item["JobTitle"] = CSharpExpressionConverter.ConvertToken(itemjobTitle);
                itempropCount++;
            }

            if (itemcompanyName != null)
            {
                item["CompanyName"] = CSharpExpressionConverter.ConvertToken(itemcompanyName);
                itempropCount++;
            }

            if (itemdepartment != null)
            {
                item["Department"] = CSharpExpressionConverter.ConvertToken(itemdepartment);
                itempropCount++;
            }

            if (itemofficeLocation != null)
            {
                item["OfficeLocation"] = CSharpExpressionConverter.ConvertToken(itemofficeLocation);
                itempropCount++;
            }

            if (itemprofession != null)
            {
                item["Profession"] = CSharpExpressionConverter.ConvertToken(itemprofession);
                itempropCount++;
            }

            if (itembusinessHomePage != null)
            {
                item["BusinessHomePage"] = CSharpExpressionConverter.ConvertToken(itembusinessHomePage);
                itempropCount++;
            }

            if (itemassistantName != null)
            {
                item["AssistantName"] = CSharpExpressionConverter.ConvertToken(itemassistantName);
                itempropCount++;
            }

            if (itemmanager != null)
            {
                item["Manager"] = CSharpExpressionConverter.ConvertToken(itemmanager);
                itempropCount++;
            }

            itempropCount++;
            item["HomePhones"] = CSharpExpressionConverter.ConvertToken(itemhomePhones);
            if (itembusinessPhones != null)
            {
                item["BusinessPhones"] = CSharpExpressionConverter.ConvertToken(itembusinessPhones);
                itempropCount++;
            }

            if (itemmobilePhone != null)
            {
                item["MobilePhone1"] = CSharpExpressionConverter.ConvertToken(itemmobilePhone);
                itempropCount++;
            }

            var homeAddressObject = new JObject();
            var homeAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                homeAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                homeAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                homeAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                homeAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                homeAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                businessAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                businessAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                businessAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                businessAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                businessAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                otherAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                otherAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                otherAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                otherAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                otherAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                otherAddressObjectpropCount++;
            }

            if (otherAddressObjectpropCount > 0)
            {
                item["OtherAddress"] = otherAddressObject;
                itempropCount++;
            }

            if (itemyomiCompanyName != null)
            {
                item["YomiCompanyName"] = CSharpExpressionConverter.ConvertToken(itemyomiCompanyName);
                itempropCount++;
            }

            if (itemyomiGivenName != null)
            {
                item["YomiGivenName"] = CSharpExpressionConverter.ConvertToken(itemyomiGivenName);
                itempropCount++;
            }

            if (itemyomiSurname != null)
            {
                item["YomiSurname"] = CSharpExpressionConverter.ConvertToken(itemyomiSurname);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["Categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemchangeKey != null)
            {
                item["ChangeKey"] = CSharpExpressionConverter.ConvertToken(itemchangeKey);
                itempropCount++;
            }

            if (itemcreatedTime != null)
            {
                item["DateTimeCreated"] = CSharpExpressionConverter.ConvertToken(itemcreatedTime);
                itempropCount++;
            }

            if (itemlastModifiedTime != null)
            {
                item["DateTimeLastModified"] = CSharpExpressionConverter.ConvertToken(itemlastModifiedTime);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ContactDeleteItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<ContactResponse> ContactPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemgivenName, Expression<Func<string[]>> itemhomePhones, Expression<Func<string>> itemid = null, Expression<Func<string>> itemparentFolderId = null, Expression<Func<string>> itembirthday = null, Expression<Func<string>> itemfileAs = null, Expression<Func<string>> itemdisplayName = null, Expression<Func<string>> iteminitials = null, Expression<Func<string>> itemmiddleName = null, Expression<Func<string>> itemnickname = null, Expression<Func<string>> itemsurname = null, Expression<Func<string>> itemtitle = null, Expression<Func<string>> itemgeneration = null, Expression<Func<EmailAddress[]>> itememailAddresses = null, Expression<Func<string[]>> itemiMAddresses = null, Expression<Func<string>> itemjobTitle = null, Expression<Func<string>> itemcompanyName = null, Expression<Func<string>> itemdepartment = null, Expression<Func<string>> itemofficeLocation = null, Expression<Func<string>> itemprofession = null, Expression<Func<string>> itembusinessHomePage = null, Expression<Func<string>> itemassistantName = null, Expression<Func<string>> itemmanager = null, Expression<Func<string[]>> itembusinessPhones = null, Expression<Func<string>> itemmobilePhone = null, Expression<Func<string>> itemhomeAddressstreet = null, Expression<Func<string>> itemhomeAddresscity = null, Expression<Func<string>> itemhomeAddressstate = null, Expression<Func<string>> itemhomeAddresscountryOrRegion = null, Expression<Func<string>> itemhomeAddresspostalCode = null, Expression<Func<string>> itembusinessAddressstreet = null, Expression<Func<string>> itembusinessAddresscity = null, Expression<Func<string>> itembusinessAddressstate = null, Expression<Func<string>> itembusinessAddresscountryOrRegion = null, Expression<Func<string>> itembusinessAddresspostalCode = null, Expression<Func<string>> itemotherAddressstreet = null, Expression<Func<string>> itemotherAddresscity = null, Expression<Func<string>> itemotherAddressstate = null, Expression<Func<string>> itemotherAddresscountryOrRegion = null, Expression<Func<string>> itemotherAddresspostalCode = null, Expression<Func<string>> itemyomiCompanyName = null, Expression<Func<string>> itemyomiGivenName = null, Expression<Func<string>> itemyomiSurname = null, Expression<Func<string[]>> itemcategories = null, Expression<Func<string>> itemchangeKey = null, Expression<Func<string>> itemcreatedTime = null, Expression<Func<string>> itemlastModifiedTime = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/contacts/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            if (itemid != null)
            {
                item["Id"] = CSharpExpressionConverter.ConvertToken(itemid);
                itempropCount++;
            }

            if (itemparentFolderId != null)
            {
                item["ParentFolderId"] = CSharpExpressionConverter.ConvertToken(itemparentFolderId);
                itempropCount++;
            }

            if (itembirthday != null)
            {
                item["Birthday"] = CSharpExpressionConverter.ConvertToken(itembirthday);
                itempropCount++;
            }

            if (itemfileAs != null)
            {
                item["FileAs"] = CSharpExpressionConverter.ConvertToken(itemfileAs);
                itempropCount++;
            }

            if (itemdisplayName != null)
            {
                item["DisplayName"] = CSharpExpressionConverter.ConvertToken(itemdisplayName);
                itempropCount++;
            }

            itempropCount++;
            item["GivenName"] = CSharpExpressionConverter.ConvertToken(itemgivenName);
            if (iteminitials != null)
            {
                item["Initials"] = CSharpExpressionConverter.ConvertToken(iteminitials);
                itempropCount++;
            }

            if (itemmiddleName != null)
            {
                item["MiddleName"] = CSharpExpressionConverter.ConvertToken(itemmiddleName);
                itempropCount++;
            }

            if (itemnickname != null)
            {
                item["NickName"] = CSharpExpressionConverter.ConvertToken(itemnickname);
                itempropCount++;
            }

            if (itemsurname != null)
            {
                item["Surname"] = CSharpExpressionConverter.ConvertToken(itemsurname);
                itempropCount++;
            }

            if (itemtitle != null)
            {
                item["Title"] = CSharpExpressionConverter.ConvertToken(itemtitle);
                itempropCount++;
            }

            if (itemgeneration != null)
            {
                item["Generation"] = CSharpExpressionConverter.ConvertToken(itemgeneration);
                itempropCount++;
            }

            if (itememailAddresses != null)
            {
                item["EmailAddresses"] = CSharpExpressionConverter.ConvertToken(itememailAddresses);
                itempropCount++;
            }

            if (itemiMAddresses != null)
            {
                item["ImAddresses"] = CSharpExpressionConverter.ConvertToken(itemiMAddresses);
                itempropCount++;
            }

            if (itemjobTitle != null)
            {
                item["JobTitle"] = CSharpExpressionConverter.ConvertToken(itemjobTitle);
                itempropCount++;
            }

            if (itemcompanyName != null)
            {
                item["CompanyName"] = CSharpExpressionConverter.ConvertToken(itemcompanyName);
                itempropCount++;
            }

            if (itemdepartment != null)
            {
                item["Department"] = CSharpExpressionConverter.ConvertToken(itemdepartment);
                itempropCount++;
            }

            if (itemofficeLocation != null)
            {
                item["OfficeLocation"] = CSharpExpressionConverter.ConvertToken(itemofficeLocation);
                itempropCount++;
            }

            if (itemprofession != null)
            {
                item["Profession"] = CSharpExpressionConverter.ConvertToken(itemprofession);
                itempropCount++;
            }

            if (itembusinessHomePage != null)
            {
                item["BusinessHomePage"] = CSharpExpressionConverter.ConvertToken(itembusinessHomePage);
                itempropCount++;
            }

            if (itemassistantName != null)
            {
                item["AssistantName"] = CSharpExpressionConverter.ConvertToken(itemassistantName);
                itempropCount++;
            }

            if (itemmanager != null)
            {
                item["Manager"] = CSharpExpressionConverter.ConvertToken(itemmanager);
                itempropCount++;
            }

            itempropCount++;
            item["HomePhones"] = CSharpExpressionConverter.ConvertToken(itemhomePhones);
            if (itembusinessPhones != null)
            {
                item["BusinessPhones"] = CSharpExpressionConverter.ConvertToken(itembusinessPhones);
                itempropCount++;
            }

            if (itemmobilePhone != null)
            {
                item["MobilePhone1"] = CSharpExpressionConverter.ConvertToken(itemmobilePhone);
                itempropCount++;
            }

            var homeAddressObject = new JObject();
            var homeAddressObjectpropCount = 0;
            if (itemhomeAddressstreet != null)
            {
                homeAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                homeAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                homeAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                homeAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                homeAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                homeAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                businessAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                businessAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                businessAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                businessAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                businessAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                businessAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
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
                otherAddressObject["Street"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstreet);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscity != null)
            {
                otherAddressObject["City"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscity);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddressstate != null)
            {
                otherAddressObject["State"] = CSharpExpressionConverter.ConvertToken(itemhomeAddressstate);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresscountryOrRegion != null)
            {
                otherAddressObject["CountryOrRegion"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresscountryOrRegion);
                otherAddressObjectpropCount++;
            }

            if (itemhomeAddresspostalCode != null)
            {
                otherAddressObject["PostalCode"] = CSharpExpressionConverter.ConvertToken(itemhomeAddresspostalCode);
                otherAddressObjectpropCount++;
            }

            if (otherAddressObjectpropCount > 0)
            {
                item["OtherAddress"] = otherAddressObject;
                itempropCount++;
            }

            if (itemyomiCompanyName != null)
            {
                item["YomiCompanyName"] = CSharpExpressionConverter.ConvertToken(itemyomiCompanyName);
                itempropCount++;
            }

            if (itemyomiGivenName != null)
            {
                item["YomiGivenName"] = CSharpExpressionConverter.ConvertToken(itemyomiGivenName);
                itempropCount++;
            }

            if (itemyomiSurname != null)
            {
                item["YomiSurname"] = CSharpExpressionConverter.ConvertToken(itemyomiSurname);
                itempropCount++;
            }

            if (itemcategories != null)
            {
                item["Categories"] = CSharpExpressionConverter.ConvertToken(itemcategories);
                itempropCount++;
            }

            if (itemchangeKey != null)
            {
                item["ChangeKey"] = CSharpExpressionConverter.ConvertToken(itemchangeKey);
                itempropCount++;
            }

            if (itemcreatedTime != null)
            {
                item["DateTimeCreated"] = CSharpExpressionConverter.ConvertToken(itemcreatedTime);
                itempropCount++;
            }

            if (itemlastModifiedTime != null)
            {
                item["DateTimeLastModified"] = CSharpExpressionConverter.ConvertToken(itemlastModifiedTime);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction RespondToEvent(Expression<Func<string>> eventId, Expression<Func<responseInput>> response, Expression<Func<string>> bodycomment = null, Expression<Func<bool>> bodysendResponse = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/events/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(response, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodysendResponse != null)
            {
                if (bodysendResponse != null)
                {
                    body["SendResponse"] = CSharpExpressionConverter.ConvertToken(bodysendResponse);
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

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ForwardEmail(Expression<Func<string>> messageId, Expression<Func<string>> bodyto, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/codeless/api/v2.0/me/messages/{0}/forward", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            bodypropCount++;
            body["ToRecipients"] = CSharpExpressionConverter.ConvertToken(bodyto);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarGetItem(Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventListClientReceive> CalendarGetItems(Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<CalendarEventListClientReceive>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPatchItem(Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["Subject"] = CSharpExpressionConverter.ConvertToken(itemsubject);
            itempropCount++;
            item["Start"] = CSharpExpressionConverter.ConvertToken(itemstartTime);
            itempropCount++;
            item["End"] = CSharpExpressionConverter.ConvertToken(itemendTime);
            if (itemtimeZone != null)
            {
                item["TimeZone"] = CSharpExpressionConverter.Convert(itemtimeZone);
                itempropCount++;
            }

            if (itemrequiredAttendees != null)
            {
                item["RequiredAttendees"] = CSharpExpressionConverter.ConvertToken(itemrequiredAttendees);
                itempropCount++;
            }

            if (itemoptionalAttendees != null)
            {
                item["OptionalAttendees"] = CSharpExpressionConverter.ConvertToken(itemoptionalAttendees);
                itempropCount++;
            }

            if (itemresourceAttendees != null)
            {
                item["ResourceAttendees"] = CSharpExpressionConverter.ConvertToken(itemresourceAttendees);
                itempropCount++;
            }

            if (itembody != null)
            {
                item["Body"] = CSharpExpressionConverter.ConvertToken(itembody);
                itempropCount++;
            }

            if (itemlocation != null)
            {
                item["Location"] = CSharpExpressionConverter.ConvertToken(itemlocation);
                itempropCount++;
            }

            if (itemimportance != null)
            {
                item["Importance"] = CSharpExpressionConverter.Convert(itemimportance);
                itempropCount++;
            }

            if (itemisAllDayEvent != null)
            {
                item["IsAllDay"] = CSharpExpressionConverter.ConvertToken(itemisAllDayEvent);
                itempropCount++;
            }

            if (itemrecurrence != null)
            {
                item["Recurrence"] = CSharpExpressionConverter.Convert(itemrecurrence);
                itempropCount++;
            }

            if (itemrecurrenceEndTime != null)
            {
                item["RecurrenceEnd"] = CSharpExpressionConverter.ConvertToken(itemrecurrenceEndTime);
                itempropCount++;
            }

            if (itemnumberOfOccurrences != null)
            {
                item["NumberOfOccurrences"] = CSharpExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                itempropCount++;
            }

            if (itemreminder != null)
            {
                item["Reminder"] = CSharpExpressionConverter.ConvertToken(itemreminder);
                itempropCount++;
            }

            if (itemshowAs != null)
            {
                item["ShowAs"] = CSharpExpressionConverter.Convert(itemshowAs);
                itempropCount++;
            }

            if (itemresponseRequested != null)
            {
                item["ResponseRequested"] = CSharpExpressionConverter.ConvertToken(itemresponseRequested);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<CalendarEventClientReceiveStringEnums> CalendarPostItem(Expression<Func<string>> table, Expression<Func<string>> itemsubject, Expression<Func<string>> itemstartTime, Expression<Func<string>> itemendTime, Expression<Func<itemtimeZoneInput>> itemtimeZone = null, Expression<Func<string>> itemrequiredAttendees = null, Expression<Func<string>> itemoptionalAttendees = null, Expression<Func<string>> itemresourceAttendees = null, Expression<Func<string>> itembody = null, Expression<Func<string>> itemlocation = null, Expression<Func<itemimportanceInput>> itemimportance = null, Expression<Func<bool>> itemisAllDayEvent = null, Expression<Func<itemrecurrenceInput>> itemrecurrence = null, Expression<Func<string>> itemrecurrenceEndTime = null, Expression<Func<int>> itemnumberOfOccurrences = null, Expression<Func<int>> itemreminder = null, Expression<Func<itemshowAsInput>> itemshowAs = null, Expression<Func<bool>> itemresponseRequested = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v3/tables/{0}/items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["Subject"] = CSharpExpressionConverter.ConvertToken(itemsubject);
            itempropCount++;
            item["Start"] = CSharpExpressionConverter.ConvertToken(itemstartTime);
            itempropCount++;
            item["End"] = CSharpExpressionConverter.ConvertToken(itemendTime);
            if (itemtimeZone != null)
            {
                item["TimeZone"] = CSharpExpressionConverter.Convert(itemtimeZone);
                itempropCount++;
            }

            if (itemrequiredAttendees != null)
            {
                item["RequiredAttendees"] = CSharpExpressionConverter.ConvertToken(itemrequiredAttendees);
                itempropCount++;
            }

            if (itemoptionalAttendees != null)
            {
                item["OptionalAttendees"] = CSharpExpressionConverter.ConvertToken(itemoptionalAttendees);
                itempropCount++;
            }

            if (itemresourceAttendees != null)
            {
                item["ResourceAttendees"] = CSharpExpressionConverter.ConvertToken(itemresourceAttendees);
                itempropCount++;
            }

            if (itembody != null)
            {
                item["Body"] = CSharpExpressionConverter.ConvertToken(itembody);
                itempropCount++;
            }

            if (itemlocation != null)
            {
                item["Location"] = CSharpExpressionConverter.ConvertToken(itemlocation);
                itempropCount++;
            }

            if (itemimportance != null)
            {
                item["Importance"] = CSharpExpressionConverter.Convert(itemimportance);
                itempropCount++;
            }

            if (itemisAllDayEvent != null)
            {
                item["IsAllDay"] = CSharpExpressionConverter.ConvertToken(itemisAllDayEvent);
                itempropCount++;
            }

            if (itemrecurrence != null)
            {
                item["Recurrence"] = CSharpExpressionConverter.Convert(itemrecurrence);
                itempropCount++;
            }

            if (itemrecurrenceEndTime != null)
            {
                item["RecurrenceEnd"] = CSharpExpressionConverter.ConvertToken(itemrecurrenceEndTime);
                itempropCount++;
            }

            if (itemnumberOfOccurrences != null)
            {
                item["NumberOfOccurrences"] = CSharpExpressionConverter.ConvertToken(itemnumberOfOccurrences);
                itempropCount++;
            }

            if (itemreminder != null)
            {
                item["Reminder"] = CSharpExpressionConverter.ConvertToken(itemreminder);
                itempropCount++;
            }

            if (itemshowAs != null)
            {
                item["ShowAs"] = CSharpExpressionConverter.Convert(itemshowAs);
                itempropCount++;
            }

            if (itemresponseRequested != null)
            {
                item["ResponseRequested"] = CSharpExpressionConverter.ConvertToken(itemresponseRequested);
                itempropCount++;
            }

            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction<CalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<BatchResponseClientReceiveMessage> GetEmails(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<string>> subjectFilter = null, Expression<Func<bool>> fetchOnlyUnread = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> searchQuery = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderPath"] = Convert.ToString("Inbox");
            if (folderPath != null)
                callPayload.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                callPayload.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                callPayload.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            callPayload.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                callPayload.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            callPayload.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                callPayload.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            if (subjectFilter != null)
                callPayload.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
            callPayload.Queries["fetchOnlyUnread"] = Convert.ToString(true);
            if (fetchOnlyUnread != null)
                callPayload.Queries["fetchOnlyUnread"] = CSharpExpressionConverter.ConvertO(fetchOnlyUnread);
            callPayload.Queries["fetchOnlyFlagged"] = Convert.ToString(false);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (searchQuery != null)
                callPayload.Queries["searchQuery"] = CSharpExpressionConverter.ConvertO(searchQuery);
            callPayload.Queries["top"] = Convert.ToString(10);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            return new ApiConnectionAction<BatchResponseClientReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IBodyWorkflowAction<EntityListResponseCalendarEventClientReceiveStringEnums> GetEventsCalendarView(Expression<Func<string>> calendarId, Expression<Func<string>> startDateTimeOffset, Expression<Func<string>> endDateTimeOffset, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = "/datasets/calendars/v2/tables/items/calendarview";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["calendarId"] = CSharpExpressionConverter.ConvertO(calendarId);
            callPayload.Queries["startDateTimeOffset"] = CSharpExpressionConverter.ConvertO(startDateTimeOffset);
            callPayload.Queries["endDateTimeOffset"] = CSharpExpressionConverter.ConvertO(endDateTimeOffset);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            return new ApiConnectionAction<EntityListResponseCalendarEventClientReceiveStringEnums>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> messageId, Expression<Func<string>> replyParametersto = null, Expression<Func<string>> replyParameterscC = null, Expression<Func<string>> replyParametersbCC = null, Expression<Func<string>> replyParameterssubject = null, Expression<Func<string>> replyParametersbody = null, Expression<Func<bool>> replyParametersreplyAll = null, Expression<Func<replyParametersimportanceInput>> replyParametersimportance = null, Expression<Func<ClientSendAttachment[]>> replyParametersattachments = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v3/Mail/ReplyTo/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replyParameters = new JObject();
            var replyParameterspropCount = 0;
            if (replyParametersto != null)
            {
                replyParameters["To"] = CSharpExpressionConverter.ConvertToken(replyParametersto);
                replyParameterspropCount++;
            }

            if (replyParameterscC != null)
            {
                replyParameters["Cc"] = CSharpExpressionConverter.ConvertToken(replyParameterscC);
                replyParameterspropCount++;
            }

            if (replyParametersbCC != null)
            {
                replyParameters["Bcc"] = CSharpExpressionConverter.ConvertToken(replyParametersbCC);
                replyParameterspropCount++;
            }

            if (replyParameterssubject != null)
            {
                replyParameters["Subject"] = CSharpExpressionConverter.ConvertToken(replyParameterssubject);
                replyParameterspropCount++;
            }

            if (replyParametersbody != null)
            {
                replyParameters["Body"] = CSharpExpressionConverter.ConvertToken(replyParametersbody);
                replyParameterspropCount++;
            }

            if (replyParametersreplyAll != null)
            {
                replyParameters["ReplyAll"] = CSharpExpressionConverter.ConvertToken(replyParametersreplyAll);
                replyParameterspropCount++;
            }

            if (replyParametersimportance != null)
            {
                replyParameters["Importance"] = CSharpExpressionConverter.Convert(replyParametersimportance);
                replyParameterspropCount++;
            }

            if (replyParametersattachments != null)
            {
                replyParameters["Attachments"] = CSharpExpressionConverter.ConvertToken(replyParametersattachments);
                replyParameterspropCount++;
            }

            if (replyParameterspropCount > 0)
            {
                callPayload.Body = replyParameters;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "outlook")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagesubject, Expression<Func<string>> emailMessagebody, Expression<Func<string>> emailMessagefromSendAs = null, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<ClientSendAttachment[]>> emailMessageattachments = null, Expression<Func<string>> emailMessagereplyTo = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            emailMessagepropCount++;
            emailMessage["To"] = CSharpExpressionConverter.ConvertToken(emailMessageto);
            emailMessagepropCount++;
            emailMessage["Subject"] = CSharpExpressionConverter.ConvertToken(emailMessagesubject);
            emailMessagepropCount++;
            emailMessage["Body"] = CSharpExpressionConverter.ConvertToken(emailMessagebody);
            if (emailMessagefromSendAs != null)
            {
                emailMessage["From"] = CSharpExpressionConverter.ConvertToken(emailMessagefromSendAs);
                emailMessagepropCount++;
            }

            if (emailMessagecC != null)
            {
                emailMessage["Cc"] = CSharpExpressionConverter.ConvertToken(emailMessagecC);
                emailMessagepropCount++;
            }

            if (emailMessagebCC != null)
            {
                emailMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(emailMessagebCC);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessagereplyTo != null)
            {
                emailMessage["ReplyTo"] = CSharpExpressionConverter.ConvertToken(emailMessagereplyTo);
                emailMessagepropCount++;
            }

            if (emailMessageimportance != null)
            {
                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = CSharpExpressionConverter.Convert(emailMessageimportance);
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

            return new ApiConnectionAction(callPayload);
        }
    }

    public class OutlookTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CalendarEventListWithActionType> CalendarGetOnChangedItems(Expression<Func<string>> table, Expression<Func<int>> incomingDays = null, Expression<Func<int>> pastDays = null, string triggerName = null)
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
                input.Fetch.Queries["incomingDays"] = CSharpExpressionConverter.ConvertO(incomingDays);
            input.Fetch.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Fetch.Queries["pastDays"] = CSharpExpressionConverter.ConvertO(pastDays);
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
                input.Subscribe.Queries["incomingDays"] = CSharpExpressionConverter.ConvertO(incomingDays);
            input.Subscribe.Queries["pastDays"] = Convert.ToString(50);
            if (pastDays != null)
                input.Subscribe.Queries["pastDays"] = CSharpExpressionConverter.ConvertO(pastDays);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<CalendarEventListWithActionType>(input);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnNewItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onnewitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> CalendarGetOnUpdatedItems(Expression<Func<string>> table, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/datasets/calendars/v2/tables/{0}/onupdateditems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnFlaggedEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
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
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
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
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<TriggerBatchResponseClientReceiveMessage> OnNewMentionMeEmail(Expression<Func<string>> folderPath = null, Expression<Func<string>> to = null, Expression<Func<string>> cc = null, Expression<Func<string>> toOrCc = null, Expression<Func<string>> from = null, Expression<Func<importanceInput>> importance = null, Expression<Func<bool>> fetchOnlyWithAttachment = null, Expression<Func<bool>> includeAttachments = null, Expression<Func<string>> subjectFilter = null, string triggerName = null)
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
                input.Fetch.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            if (to != null)
                input.Fetch.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (cc != null)
                input.Fetch.Queries["cc"] = CSharpExpressionConverter.ConvertO(cc);
            if (toOrCc != null)
                input.Fetch.Queries["toOrCc"] = CSharpExpressionConverter.ConvertO(toOrCc);
            if (from != null)
                input.Fetch.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            input.Fetch.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Fetch.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Fetch.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Fetch.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            input.Fetch.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                input.Fetch.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            if (subjectFilter != null)
                input.Fetch.Queries["subjectFilter"] = CSharpExpressionConverter.ConvertO(subjectFilter);
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
                input.Subscribe.Queries["folderPath"] = CSharpExpressionConverter.ConvertO(folderPath);
            input.Subscribe.Queries["importance"] = Convert.ToString("Any");
            if (importance != null)
                input.Subscribe.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            input.Subscribe.Queries["fetchOnlyWithAttachment"] = Convert.ToString(false);
            if (fetchOnlyWithAttachment != null)
                input.Subscribe.Queries["fetchOnlyWithAttachment"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachment);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<TriggerBatchResponseClientReceiveMessage>(input);
        }

        public IBodyWorkflowTrigger<CalendarEventListClientReceive> OnUpcomingEvents(Expression<Func<string>> table, Expression<Func<int>> lookAheadTimeInMinutes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/Events/OnUpcomingEvents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table"] = CSharpExpressionConverter.ConvertO(table);
            callPayload.Queries["lookAheadTimeInMinutes"] = Convert.ToString(15);
            if (lookAheadTimeInMinutes != null)
                callPayload.Queries["lookAheadTimeInMinutes"] = CSharpExpressionConverter.ConvertO(lookAheadTimeInMinutes);
            return new ApiConnectionTrigger<CalendarEventListClientReceive>(callPayload, triggerName, recurrence);
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