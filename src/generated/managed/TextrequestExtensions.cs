//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Textrequest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TextrequestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetMessagesByContactPhoneResponse> GetMessagesByContactPhone(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetMessagesByContactPhoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendMessageByPhoneNumberResponse> SendMessageByPhoneNumber(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber, Expression<Func<string>> bodymessageBody = null, Expression<Func<string>> bodynameOfTheSender = null, Expression<Func<string>> bodycallbackUrlForWhenTheMessageStatusUpdates = null, Expression<Func<string>> bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne = null, Expression<Func<string[]>> bodymMSMediaAttachmentsForThisMessage = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessageBody != null)
            {
                body["body"] = ExpressionConverter.ConvertO(bodymessageBody);
                bodypropCount++;
            }

            if (bodynameOfTheSender != null)
            {
                body["sender_name"] = ExpressionConverter.ConvertO(bodynameOfTheSender);
                bodypropCount++;
            }

            if (bodycallbackUrlForWhenTheMessageStatusUpdates != null)
            {
                body["status_callback"] = ExpressionConverter.ConvertO(bodycallbackUrlForWhenTheMessageStatusUpdates);
                bodypropCount++;
            }

            if (bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne != null)
            {
                body["location_callback"] = ExpressionConverter.ConvertO(bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne);
                bodypropCount++;
            }

            if (bodymMSMediaAttachmentsForThisMessage != null)
            {
                body["mms_media"] = ExpressionConverter.ConvertO(bodymMSMediaAttachmentsForThisMessage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendMessageByPhoneNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> ArchiveConversation(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}/conversations/archive", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> UnarchiveConversation(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}/conversations/unarchive", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactByPhoneNumberResponse> GetContactByPhoneNumber(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactByPhoneNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteContact(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber, Expression<Func<string>> bodyfirstNameOfContact = null, Expression<Func<string>> bodylastNameOfContact = null, Expression<Func<string>> bodyfullNameOfContact = null, Expression<Func<bool>> bodywhetherMessagesFromThisContactAreSuppressed = null, Expression<Func<bool>> bodywhetherMessagesFromThisContactAreArchived = null, Expression<Func<bool>> bodywhetherMessagesFromThisContactAreBlocked = null, Expression<Func<string>> bodyreasonForSuppressingThisContact = null, Expression<Func<string>> bodycontactNote = null, Expression<Func<int[]>> bodycontactGroups = null, Expression<Func<string[]>> bodycontactTags = null, Expression<Func<bodycontactCustomFieldsInputItem[]>> bodycontactCustomFields = null, Expression<Func<bool>> bodywhetherTheCurrentConversationWithThisContactHasBeenResolved = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstNameOfContact != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstNameOfContact);
                bodypropCount++;
            }

            if (bodylastNameOfContact != null)
            {
                body["last_name"] = ExpressionConverter.ConvertO(bodylastNameOfContact);
                bodypropCount++;
            }

            if (bodyfullNameOfContact != null)
            {
                body["display_name"] = ExpressionConverter.ConvertO(bodyfullNameOfContact);
                bodypropCount++;
            }

            if (bodywhetherMessagesFromThisContactAreSuppressed != null)
            {
                body["is_suppressed"] = ExpressionConverter.ConvertO(bodywhetherMessagesFromThisContactAreSuppressed);
                bodypropCount++;
            }

            if (bodywhetherMessagesFromThisContactAreArchived != null)
            {
                body["is_archived"] = ExpressionConverter.ConvertO(bodywhetherMessagesFromThisContactAreArchived);
                bodypropCount++;
            }

            if (bodywhetherMessagesFromThisContactAreBlocked != null)
            {
                body["is_blocked"] = ExpressionConverter.ConvertO(bodywhetherMessagesFromThisContactAreBlocked);
                bodypropCount++;
            }

            if (bodyreasonForSuppressingThisContact != null)
            {
                body["suppressed_reason"] = ExpressionConverter.ConvertO(bodyreasonForSuppressingThisContact);
                bodypropCount++;
            }

            if (bodycontactNote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodycontactNote);
                bodypropCount++;
            }

            if (bodycontactGroups != null)
            {
                body["groups"] = ExpressionConverter.ConvertO(bodycontactGroups);
                bodypropCount++;
            }

            if (bodycontactTags != null)
            {
                body["contact_tags"] = ExpressionConverter.ConvertO(bodycontactTags);
                bodypropCount++;
            }

            if (bodycontactCustomFields != null)
            {
                body["custom_fields"] = ExpressionConverter.ConvertO(bodycontactCustomFields);
                bodypropCount++;
            }

            if (bodywhetherTheCurrentConversationWithThisContactHasBeenResolved != null)
            {
                body["is_resolved"] = ExpressionConverter.ConvertO(bodywhetherTheCurrentConversationWithThisContactHasBeenResolved);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> contactPhoneNumber = null, Expression<Func<string>> lastMessageTimestampBeforeUtc = null, Expression<Func<string>> lastMessageTimestampAfterUtc = null, Expression<Func<string>> contactCreatedBefore = null, Expression<Func<string>> contactCreatedAfter = null, Expression<Func<bool>> isResolved = null, Expression<Func<bool>> isBlocked = null, Expression<Func<bool>> isArchived = null, Expression<Func<bool>> isSuppressed = null, Expression<Func<bool>> hasOptedOut = null, Expression<Func<string>> lastMessageSentBefore = null, Expression<Func<string>> lastMessageSentAfter = null, Expression<Func<string>> lastMessageReceivedBefore = null, Expression<Func<string>> lastMessageReceivedAfter = null, Expression<Func<string>> tags = null, Expression<Func<string>> groups = null, Expression<Func<string>> customFieldId1 = null, Expression<Func<string>> customFieldValue1 = null, Expression<Func<string>> customFieldId2 = null, Expression<Func<string>> customFieldValue2 = null, Expression<Func<string>> customFieldId3 = null, Expression<Func<string>> customFieldValue3 = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contact_phone_number"] = Convert.ToString("4239876543");
            if (contactPhoneNumber != null)
                callPayload.Queries["contact_phone_number"] = ExpressionConverter.Convert(contactPhoneNumber);
            if (lastMessageTimestampBeforeUtc != null)
                callPayload.Queries["last_message_timestamp_before_utc"] = ExpressionConverter.Convert(lastMessageTimestampBeforeUtc);
            if (lastMessageTimestampAfterUtc != null)
                callPayload.Queries["last_message_timestamp_after_utc"] = ExpressionConverter.Convert(lastMessageTimestampAfterUtc);
            if (contactCreatedBefore != null)
                callPayload.Queries["contact_created_before"] = ExpressionConverter.Convert(contactCreatedBefore);
            if (contactCreatedAfter != null)
                callPayload.Queries["contact_created_after"] = ExpressionConverter.Convert(contactCreatedAfter);
            callPayload.Queries["is_resolved"] = Convert.ToString(false);
            if (isResolved != null)
                callPayload.Queries["is_resolved"] = ExpressionConverter.Convert(isResolved);
            callPayload.Queries["is_blocked"] = Convert.ToString(false);
            if (isBlocked != null)
                callPayload.Queries["is_blocked"] = ExpressionConverter.Convert(isBlocked);
            callPayload.Queries["is_archived"] = Convert.ToString(false);
            if (isArchived != null)
                callPayload.Queries["is_archived"] = ExpressionConverter.Convert(isArchived);
            callPayload.Queries["is_suppressed"] = Convert.ToString(false);
            if (isSuppressed != null)
                callPayload.Queries["is_suppressed"] = ExpressionConverter.Convert(isSuppressed);
            callPayload.Queries["has_opted_out"] = Convert.ToString(false);
            if (hasOptedOut != null)
                callPayload.Queries["has_opted_out"] = ExpressionConverter.Convert(hasOptedOut);
            if (lastMessageSentBefore != null)
                callPayload.Queries["last_message_sent_before"] = ExpressionConverter.Convert(lastMessageSentBefore);
            if (lastMessageSentAfter != null)
                callPayload.Queries["last_message_sent_after"] = ExpressionConverter.Convert(lastMessageSentAfter);
            if (lastMessageReceivedBefore != null)
                callPayload.Queries["last_message_received_before"] = ExpressionConverter.Convert(lastMessageReceivedBefore);
            if (lastMessageReceivedAfter != null)
                callPayload.Queries["last_message_received_after"] = ExpressionConverter.Convert(lastMessageReceivedAfter);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (groups != null)
                callPayload.Queries["groups"] = ExpressionConverter.Convert(groups);
            if (customFieldId1 != null)
                callPayload.Queries["custom_field_id_1"] = ExpressionConverter.Convert(customFieldId1);
            if (customFieldValue1 != null)
                callPayload.Queries["custom_field_value_1"] = ExpressionConverter.Convert(customFieldValue1);
            if (customFieldId2 != null)
                callPayload.Queries["custom_field_id_2"] = ExpressionConverter.Convert(customFieldId2);
            if (customFieldValue2 != null)
                callPayload.Queries["custom_field_value_2"] = ExpressionConverter.Convert(customFieldValue2);
            if (customFieldId3 != null)
                callPayload.Queries["custom_field_id_3"] = ExpressionConverter.Convert(customFieldId3);
            if (customFieldValue3 != null)
                callPayload.Queries["custom_field_value_3"] = ExpressionConverter.Convert(customFieldValue3);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<BulkUpdateContactsResponseItem[]> BulkUpdateContacts(Expression<Func<int>> dashboardId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BulkUpdateContactsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupByIdResponse> GetGroupById(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGroupByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteGroup(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateGroupResponse> UpdateGroup(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodygroupNote = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodygroupName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
            }

            if (bodygroupNote != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodygroupNote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupsResponse> GetGroups(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup(Expression<Func<int>> dashboardId, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodygroupNote = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodygroupName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
            }

            if (bodygroupNote != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodygroupNote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetTagsResponse> GetTags(Expression<Func<int>> dashboardId, Expression<Func<int>> page, Expression<Func<int>> pageSize)
        {
            var apiCallPath = String.Format("/dashboards/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetTagsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetCustomFieldsResponseItem[]> GetCustomFields(Expression<Func<int>> dashboardId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCustomFieldsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentResponse> GetPayment(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments/{1}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(paymentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPaymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<MarkPaymentPaidResponse> MarkPaymentPaid(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments/{1}/mark_as_paid", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(paymentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MarkPaymentPaidResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendPaymentReminderResponse> SendPaymentReminder(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments/{1}/resend", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(paymentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SendPaymentReminderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CancelPaymentResponse> CancelPayment(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments/{1}/cancel", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1), ExpressionConverter.ConvertWithUrlEncoding(paymentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CancelPaymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentsResponse> GetPayments(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> referenceNumber = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> sortType = null, Expression<Func<string>> sortDirection = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["reference_number"] = Convert.ToString("receipt-chicago");
            if (referenceNumber != null)
                callPayload.Queries["reference_number"] = ExpressionConverter.Convert(referenceNumber);
            callPayload.Queries["phone_number"] = Convert.ToString("anim nostrud");
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = ExpressionConverter.Convert(phoneNumber);
            callPayload.Queries["sort_type"] = Convert.ToString("date");
            if (sortType != null)
                callPayload.Queries["sort_type"] = ExpressionConverter.Convert(sortType);
            callPayload.Queries["sort_direction"] = Convert.ToString("desc");
            if (sortDirection != null)
                callPayload.Queries["sort_direction"] = ExpressionConverter.Convert(sortDirection);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetPaymentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreatePaymentResponse> CreatePayment(Expression<Func<int>> dashboardId, Expression<Func<string>> bodypaymentDescription = null, Expression<Func<string>> bodyrecipientPhoneNumber = null, Expression<Func<double>> bodyamountRequestedInDollars = null, Expression<Func<string>> bodypaymentMessageTextBody = null, Expression<Func<string>> bodyreferenceStringOfThePayment = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/payments", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypaymentDescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodypaymentDescription);
                bodypropCount++;
            }

            if (bodyrecipientPhoneNumber != null)
            {
                body["customer_phone"] = ExpressionConverter.ConvertO(bodyrecipientPhoneNumber);
                bodypropCount++;
            }

            if (bodyamountRequestedInDollars != null)
            {
                body["amount_requested"] = ExpressionConverter.ConvertO(bodyamountRequestedInDollars);
                bodypropCount++;
            }

            if (bodypaymentMessageTextBody != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodypaymentMessageTextBody);
                bodypropCount++;
            }

            if (bodyreferenceStringOfThePayment != null)
            {
                body["reference_number"] = ExpressionConverter.ConvertO(bodyreferenceStringOfThePayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePaymentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardResponse> GetDashboard(Expression<Func<int>> dashboardId)
        {
            var apiCallPath = String.Format("/dashboards/{0}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDashboardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteDashboard(Expression<Func<int>> dashboardId)
        {
            var apiCallPath = String.Format("/dashboards/{0}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateDashboardsNameResponse> UpdateDashboardsName(Expression<Func<int>> dashboardId, Expression<Func<string>> bodydashboardName = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydashboardName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodydashboardName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateDashboardsNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetConversationsResponse> GetConversations(Expression<Func<int>> dashboardId, Expression<Func<string>> tags = null, Expression<Func<string>> showUnresolvedOnly = null, Expression<Func<string>> includeArchived = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/conversations", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            callPayload.Queries["show_unresolved_only"] = Convert.ToString("true");
            if (showUnresolvedOnly != null)
                callPayload.Queries["show_unresolved_only"] = ExpressionConverter.Convert(showUnresolvedOnly);
            callPayload.Queries["include_archived"] = Convert.ToString("true");
            if (includeArchived != null)
                callPayload.Queries["include_archived"] = ExpressionConverter.Convert(includeArchived);
            callPayload.Queries["search"] = Convert.ToString("321-654-7890");
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = Convert.ToString(50);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetConversationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardsResponse> GetDashboards(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/dashboards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["page_size"] = Convert.ToString(50);
            if (pageSize != null)
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetDashboardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateDashboardResponse> CreateDashboard(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphone = null)
        {
            var apiCallPath = "/dashboards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDashboardResponse>(callPayload);
        }
    }

    public class TextrequestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TextingWebhookResponse> TextingWebhook(Expression<Func<string>> dashboardId, Expression<Func<bodyeventInput>> bodyevent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/dashboards/{0}/hooks", ExpressionConverter.ConvertWithUrlEncoding(dashboardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target_url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["event"] = ExpressionConverter.ConvertO(bodyevent);
            body["httpVerb"] = "POST";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<TextingWebhookResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class GetMessagesByContactPhoneResponse
    {
        [JsonProperty("meta")]
        public GetMessagesByContactPhoneResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetMessagesByContactPhoneResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetMessagesByContactPhoneResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetMessagesByContactPhoneResponseItemsTypeItem
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class SendMessageByPhoneNumberResponse
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class GetContactByPhoneNumberResponse
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_suppressed")]
        public bool IsSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string SuppressedReason { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("groups")]
        public int[] Groups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public GetContactByPhoneNumberResponseCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("first_contact_utc")]
        public string FirstContactUtc { get; set; }

        [JsonProperty("opted_out_utc")]
        public string OptedOutUtc { get; set; }

        [JsonProperty("last_msg_sent_utc")]
        public string LastMsgSentUtc { get; set; }

        [JsonProperty("last_msg_received_utc")]
        public string LastMsgReceivedUtc { get; set; }

        [JsonProperty("total_msgs_sent")]
        public int TotalMsgsSent { get; set; }

        [JsonProperty("total_msgs_received")]
        public int TotalMsgsReceived { get; set; }

        [JsonProperty("response_count")]
        public int ResponseCount { get; set; }

        [JsonProperty("date_created_utc")]
        public string DateCreatedUtc { get; set; }

        [JsonProperty("last_contact_date_utc")]
        public string LastContactDateUtc { get; set; }

        [JsonProperty("last_message")]
        public GetContactByPhoneNumberResponseLastMessageType LastMessage { get; set; }
    }

    public class GetContactByPhoneNumberResponseCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetContactByPhoneNumberResponseLastMessageType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class CreateContactResponse
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_suppressed")]
        public bool IsSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string SuppressedReason { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("groups")]
        public int[] Groups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public CreateContactResponseCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("first_contact_utc")]
        public string FirstContactUtc { get; set; }

        [JsonProperty("opted_out_utc")]
        public string OptedOutUtc { get; set; }

        [JsonProperty("last_msg_sent_utc")]
        public string LastMsgSentUtc { get; set; }

        [JsonProperty("last_msg_received_utc")]
        public string LastMsgReceivedUtc { get; set; }

        [JsonProperty("total_msgs_sent")]
        public int TotalMsgsSent { get; set; }

        [JsonProperty("total_msgs_received")]
        public int TotalMsgsReceived { get; set; }

        [JsonProperty("response_count")]
        public int ResponseCount { get; set; }

        [JsonProperty("date_created_utc")]
        public string DateCreatedUtc { get; set; }

        [JsonProperty("last_contact_date_utc")]
        public string LastContactDateUtc { get; set; }

        [JsonProperty("last_message")]
        public CreateContactResponseLastMessageType LastMessage { get; set; }
    }

    public class CreateContactResponseCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateContactResponseLastMessageType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class bodycontactCustomFieldsInputItem
    {
        [JsonProperty("id")]
        public string CustomFieldId { get; set; }

        [JsonProperty("value")]
        public string CustomFieldValue { get; set; }
    }

    public class GetContactsResponse
    {
        [JsonProperty("meta")]
        public GetContactsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetContactsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetContactsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetContactsResponseItemsTypeItem
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_suppressed")]
        public bool IsSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string SuppressedReason { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("groups")]
        public int[] Groups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public GetContactsResponseItemsTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("first_contact_utc")]
        public string FirstContactUtc { get; set; }

        [JsonProperty("opted_out_utc")]
        public string OptedOutUtc { get; set; }

        [JsonProperty("last_msg_sent_utc")]
        public string LastMsgSentUtc { get; set; }

        [JsonProperty("last_msg_received_utc")]
        public string LastMsgReceivedUtc { get; set; }

        [JsonProperty("total_msgs_sent")]
        public int TotalMsgsSent { get; set; }

        [JsonProperty("total_msgs_received")]
        public int TotalMsgsReceived { get; set; }

        [JsonProperty("response_count")]
        public int ResponseCount { get; set; }

        [JsonProperty("date_created_utc")]
        public string DateCreatedUtc { get; set; }

        [JsonProperty("last_contact_date_utc")]
        public string LastContactDateUtc { get; set; }

        [JsonProperty("last_message")]
        public GetContactsResponseItemsTypeItemLastMessageType LastMessage { get; set; }
    }

    public class GetContactsResponseItemsTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetContactsResponseItemsTypeItemLastMessageType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class BulkUpdateContactsResponseItem
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_suppressed")]
        public bool IsSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string SuppressedReason { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("groups")]
        public int[] Groups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public BulkUpdateContactsResponseItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool IsResolved { get; set; }

        [JsonProperty("first_contact_utc")]
        public string FirstContactUtc { get; set; }

        [JsonProperty("opted_out_utc")]
        public string OptedOutUtc { get; set; }

        [JsonProperty("last_msg_sent_utc")]
        public string LastMsgSentUtc { get; set; }

        [JsonProperty("last_msg_received_utc")]
        public string LastMsgReceivedUtc { get; set; }

        [JsonProperty("total_msgs_sent")]
        public int TotalMsgsSent { get; set; }

        [JsonProperty("total_msgs_received")]
        public int TotalMsgsReceived { get; set; }

        [JsonProperty("response_count")]
        public int ResponseCount { get; set; }

        [JsonProperty("date_created_utc")]
        public string DateCreatedUtc { get; set; }

        [JsonProperty("last_contact_date_utc")]
        public string LastContactDateUtc { get; set; }

        [JsonProperty("last_message")]
        public BulkUpdateContactsResponseItemLastMessageType LastMessage { get; set; }
    }

    public class BulkUpdateContactsResponseItemCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BulkUpdateContactsResponseItemLastMessageType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("phone_number")]
        public string PhoneNumberOfContact { get; set; }

        [JsonProperty("first_name")]
        public string FirstNameOfContact { get; set; }

        [JsonProperty("last_name")]
        public string LastNameOfContact { get; set; }

        [JsonProperty("display_name")]
        public string FullNameOfContact { get; set; }

        [JsonProperty("is_suppressed")]
        public bool WhetherMessagesFromThisContactAreSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool WhetherMessagesFromThisContactAreArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool WhetherMessagesFromThisContactAreBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string ReasonForSuppressingThisContact { get; set; }

        [JsonProperty("note")]
        public string ContactNote { get; set; }

        [JsonProperty("groups")]
        public int[] ContactGroups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public bodyInputItemContactCustomFieldsTypeItem[] ContactCustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool WhetherTheCurrentConversationWithThisContactHasBeenResolved { get; set; }
    }

    public class bodyInputItemContactCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public string CustomFieldId { get; set; }

        [JsonProperty("value")]
        public string CustomFieldValue { get; set; }
    }

    public class GetGroupByIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_member_count")]
        public int GroupMemberCount { get; set; }

        [JsonProperty("is_keyword")]
        public bool IsKeyword { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("last_message_sent_utc")]
        public string LastMessageSentUtc { get; set; }
    }

    public class UpdateGroupResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_member_count")]
        public int GroupMemberCount { get; set; }

        [JsonProperty("is_keyword")]
        public bool IsKeyword { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("last_message_sent_utc")]
        public string LastMessageSentUtc { get; set; }
    }

    public class GetGroupsResponse
    {
        [JsonProperty("meta")]
        public GetGroupsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetGroupsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetGroupsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetGroupsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_member_count")]
        public int GroupMemberCount { get; set; }

        [JsonProperty("is_keyword")]
        public bool IsKeyword { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("last_message_sent_utc")]
        public string LastMessageSentUtc { get; set; }
    }

    public class CreateGroupResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("group_member_count")]
        public int GroupMemberCount { get; set; }

        [JsonProperty("is_keyword")]
        public bool IsKeyword { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("last_message_sent_utc")]
        public string LastMessageSentUtc { get; set; }
    }

    public class GetTagsResponse
    {
        [JsonProperty("meta")]
        public GetTagsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetTagsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetTagsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetTagsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag_color")]
        public string TagColor { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class GetCustomFieldsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPaymentResponse
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class MarkPaymentPaidResponse
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class SendPaymentReminderResponse
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class CancelPaymentResponse
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class GetPaymentsResponse
    {
        [JsonProperty("meta")]
        public GetPaymentsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetPaymentsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetPaymentsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetPaymentsResponseItemsTypeItem
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class CreatePaymentResponse
    {
        [JsonProperty("payment_id")]
        public int PaymentId { get; set; }

        [JsonProperty("request_date")]
        public string RequestDate { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customer_phone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("amount_requested")]
        public double AmountRequested { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("reminder_was_sent")]
        public bool ReminderWasSent { get; set; }

        [JsonProperty("transaction_status")]
        public string TransactionStatus { get; set; }

        [JsonProperty("textrequest_payment_status")]
        public string TextrequestPaymentStatus { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }
    }

    public class GetDashboardResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class UpdateDashboardsNameResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class GetConversationsResponse
    {
        [JsonProperty("meta")]
        public GetConversationsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetConversationsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetConversationsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetConversationsResponseItemsTypeItem
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("last_message")]
        public GetConversationsResponseItemsTypeItemLastMessageType LastMessage { get; set; }
    }

    public class GetConversationsResponseItemsTypeItemLastMessageType
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("message_direction")]
        public string MessageDirection { get; set; }

        [JsonProperty("response_by_username")]
        public string ResponseByUsername { get; set; }

        [JsonProperty("message_timestamp_utc")]
        public string MessageTimestampUtc { get; set; }

        [JsonProperty("delivery_status")]
        public string DeliveryStatus { get; set; }

        [JsonProperty("delivery_error")]
        public string DeliveryError { get; set; }

        [JsonProperty("mms_media")]
        public string[] MmsMedia { get; set; }
    }

    public class GetDashboardsResponse
    {
        [JsonProperty("meta")]
        public GetDashboardsResponseMetaType Meta { get; set; }

        [JsonProperty("items")]
        public GetDashboardsResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetDashboardsResponseMetaType
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }
    }

    public class GetDashboardsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class CreateDashboardResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class TextingWebhookResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("target_url")]
        public string TargetUrl { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }
    }

    public enum bodyeventInput
    {
        [EnumMember(Value = "msg_received")]
        MsgReceived,
        [EnumMember(Value = "msg_sent")]
        MsgSent
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Textrequest;

    public partial class WorkflowManagedActions
    {
        public TextrequestActions Textrequest(string connectionId) => new TextrequestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TextrequestTriggers Textrequest(string connectionId) => new TextrequestTriggers(connectionId);
    }
}