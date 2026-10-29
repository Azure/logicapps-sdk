//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Textrequest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TextrequestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetMessagesByContactPhoneResponse, ApiConnectionActionConfiguration> GetMessagesByContactPhone(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<GetMessagesByContactPhoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}/messages", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetMessagesByContactPhoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendMessageByPhoneNumberResponse, ApiConnectionActionConfiguration> SendMessageByPhoneNumber(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber, Expression<Func<SendMessageByPhoneNumberInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageByPhoneNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}/messages", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageByPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ArchiveConversation(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}/conversations/archive", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UnarchiveConversation(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}/conversations/unarchive", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactByPhoneNumberResponse, ApiConnectionActionConfiguration> GetContactByPhoneNumber(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<GetContactByPhoneNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactByPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteContact(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<int>> dashboardId, Expression<Func<string>> phoneNumber, Expression<Func<CreateContactInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_phoneNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactsResponse, ApiConnectionActionConfiguration> GetContacts(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> contactPhoneNumber = null, Expression<Func<string>> lastMessageTimestampBeforeUtc = null, Expression<Func<string>> lastMessageTimestampAfterUtc = null, Expression<Func<string>> contactCreatedBefore = null, Expression<Func<string>> contactCreatedAfter = null, Expression<Func<bool>> isResolved = null, Expression<Func<bool>> isBlocked = null, Expression<Func<bool>> isArchived = null, Expression<Func<bool>> isSuppressed = null, Expression<Func<bool>> hasOptedOut = null, Expression<Func<string>> lastMessageSentBefore = null, Expression<Func<string>> lastMessageSentAfter = null, Expression<Func<string>> lastMessageReceivedBefore = null, Expression<Func<string>> lastMessageReceivedAfter = null, Expression<Func<string>> tags = null, Expression<Func<string>> groups = null, Expression<Func<string>> customFieldId1 = null, Expression<Func<string>> customFieldValue1 = null, Expression<Func<string>> customFieldId2 = null, Expression<Func<string>> customFieldValue2 = null, Expression<Func<string>> customFieldId3 = null, Expression<Func<string>> customFieldValue3 = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_contactPhoneNumber = WorkflowExpression.Compile(contactPhoneNumber, nameof(contactPhoneNumber), required: false);
            var __workflow_lastMessageTimestampBeforeUtc = WorkflowExpression.Compile(lastMessageTimestampBeforeUtc, nameof(lastMessageTimestampBeforeUtc), required: false);
            var __workflow_lastMessageTimestampAfterUtc = WorkflowExpression.Compile(lastMessageTimestampAfterUtc, nameof(lastMessageTimestampAfterUtc), required: false);
            var __workflow_contactCreatedBefore = WorkflowExpression.Compile(contactCreatedBefore, nameof(contactCreatedBefore), required: false);
            var __workflow_contactCreatedAfter = WorkflowExpression.Compile(contactCreatedAfter, nameof(contactCreatedAfter), required: false);
            var __workflow_isResolved = WorkflowExpression.Compile(isResolved, nameof(isResolved), required: false);
            var __workflow_isBlocked = WorkflowExpression.Compile(isBlocked, nameof(isBlocked), required: false);
            var __workflow_isArchived = WorkflowExpression.Compile(isArchived, nameof(isArchived), required: false);
            var __workflow_isSuppressed = WorkflowExpression.Compile(isSuppressed, nameof(isSuppressed), required: false);
            var __workflow_hasOptedOut = WorkflowExpression.Compile(hasOptedOut, nameof(hasOptedOut), required: false);
            var __workflow_lastMessageSentBefore = WorkflowExpression.Compile(lastMessageSentBefore, nameof(lastMessageSentBefore), required: false);
            var __workflow_lastMessageSentAfter = WorkflowExpression.Compile(lastMessageSentAfter, nameof(lastMessageSentAfter), required: false);
            var __workflow_lastMessageReceivedBefore = WorkflowExpression.Compile(lastMessageReceivedBefore, nameof(lastMessageReceivedBefore), required: false);
            var __workflow_lastMessageReceivedAfter = WorkflowExpression.Compile(lastMessageReceivedAfter, nameof(lastMessageReceivedAfter), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_groups = WorkflowExpression.Compile(groups, nameof(groups), required: false);
            var __workflow_customFieldId1 = WorkflowExpression.Compile(customFieldId1, nameof(customFieldId1), required: false);
            var __workflow_customFieldValue1 = WorkflowExpression.Compile(customFieldValue1, nameof(customFieldValue1), required: false);
            var __workflow_customFieldId2 = WorkflowExpression.Compile(customFieldId2, nameof(customFieldId2), required: false);
            var __workflow_customFieldValue2 = WorkflowExpression.Compile(customFieldValue2, nameof(customFieldValue2), required: false);
            var __workflow_customFieldId3 = WorkflowExpression.Compile(customFieldId3, nameof(customFieldId3), required: false);
            var __workflow_customFieldValue3 = WorkflowExpression.Compile(customFieldValue3, nameof(customFieldValue3), required: false);
            return new DeferredBodyAction<GetContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contact_phone_number"] = Convert.ToString("4239876543");
                if (__workflow_contactPhoneNumber != null)
                    callPayload.Queries["contact_phone_number"] = ExpressionConverter.Convert(__workflow_contactPhoneNumber);
                if (__workflow_lastMessageTimestampBeforeUtc != null)
                    callPayload.Queries["last_message_timestamp_before_utc"] = ExpressionConverter.Convert(__workflow_lastMessageTimestampBeforeUtc);
                if (__workflow_lastMessageTimestampAfterUtc != null)
                    callPayload.Queries["last_message_timestamp_after_utc"] = ExpressionConverter.Convert(__workflow_lastMessageTimestampAfterUtc);
                if (__workflow_contactCreatedBefore != null)
                    callPayload.Queries["contact_created_before"] = ExpressionConverter.Convert(__workflow_contactCreatedBefore);
                if (__workflow_contactCreatedAfter != null)
                    callPayload.Queries["contact_created_after"] = ExpressionConverter.Convert(__workflow_contactCreatedAfter);
                callPayload.Queries["is_resolved"] = Convert.ToString(false);
                if (__workflow_isResolved != null)
                    callPayload.Queries["is_resolved"] = ExpressionConverter.Convert(__workflow_isResolved);
                callPayload.Queries["is_blocked"] = Convert.ToString(false);
                if (__workflow_isBlocked != null)
                    callPayload.Queries["is_blocked"] = ExpressionConverter.Convert(__workflow_isBlocked);
                callPayload.Queries["is_archived"] = Convert.ToString(false);
                if (__workflow_isArchived != null)
                    callPayload.Queries["is_archived"] = ExpressionConverter.Convert(__workflow_isArchived);
                callPayload.Queries["is_suppressed"] = Convert.ToString(false);
                if (__workflow_isSuppressed != null)
                    callPayload.Queries["is_suppressed"] = ExpressionConverter.Convert(__workflow_isSuppressed);
                callPayload.Queries["has_opted_out"] = Convert.ToString(false);
                if (__workflow_hasOptedOut != null)
                    callPayload.Queries["has_opted_out"] = ExpressionConverter.Convert(__workflow_hasOptedOut);
                if (__workflow_lastMessageSentBefore != null)
                    callPayload.Queries["last_message_sent_before"] = ExpressionConverter.Convert(__workflow_lastMessageSentBefore);
                if (__workflow_lastMessageSentAfter != null)
                    callPayload.Queries["last_message_sent_after"] = ExpressionConverter.Convert(__workflow_lastMessageSentAfter);
                if (__workflow_lastMessageReceivedBefore != null)
                    callPayload.Queries["last_message_received_before"] = ExpressionConverter.Convert(__workflow_lastMessageReceivedBefore);
                if (__workflow_lastMessageReceivedAfter != null)
                    callPayload.Queries["last_message_received_after"] = ExpressionConverter.Convert(__workflow_lastMessageReceivedAfter);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_groups != null)
                    callPayload.Queries["groups"] = ExpressionConverter.Convert(__workflow_groups);
                if (__workflow_customFieldId1 != null)
                    callPayload.Queries["custom_field_id_1"] = ExpressionConverter.Convert(__workflow_customFieldId1);
                if (__workflow_customFieldValue1 != null)
                    callPayload.Queries["custom_field_value_1"] = ExpressionConverter.Convert(__workflow_customFieldValue1);
                if (__workflow_customFieldId2 != null)
                    callPayload.Queries["custom_field_id_2"] = ExpressionConverter.Convert(__workflow_customFieldId2);
                if (__workflow_customFieldValue2 != null)
                    callPayload.Queries["custom_field_value_2"] = ExpressionConverter.Convert(__workflow_customFieldValue2);
                if (__workflow_customFieldId3 != null)
                    callPayload.Queries["custom_field_id_3"] = ExpressionConverter.Convert(__workflow_customFieldId3);
                if (__workflow_customFieldValue3 != null)
                    callPayload.Queries["custom_field_value_3"] = ExpressionConverter.Convert(__workflow_customFieldValue3);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<BulkUpdateContactsResponseItem[], ApiConnectionActionConfiguration> BulkUpdateContacts(Expression<Func<int>> dashboardId, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BulkUpdateContactsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/contacts", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BulkUpdateContactsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupByIdResponse, ApiConnectionActionConfiguration> GetGroupById(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetGroupByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/groups/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteGroup(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/groups/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateGroupResponse, ApiConnectionActionConfiguration> UpdateGroup(Expression<Func<int>> dashboardId, Expression<Func<int>> groupId, Expression<Func<UpdateGroupInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/groups/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupsResponse, ApiConnectionActionConfiguration> GetGroups(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            return new DeferredBodyAction<GetGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/groups", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<int>> dashboardId, Expression<Func<CreateGroupInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/groups", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetTagsResponse, ApiConnectionActionConfiguration> GetTags(Expression<Func<int>> dashboardId, Expression<Func<int>> page, Expression<Func<int>> pageSize)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            return new DeferredBodyAction<GetTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/tags", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetCustomFieldsResponseItem[], ApiConnectionActionConfiguration> GetCustomFields(Expression<Func<int>> dashboardId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            return new DeferredBodyAction<GetCustomFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/fields", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCustomFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentResponse, ApiConnectionActionConfiguration> GetPayment(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<GetPaymentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments/{1}", __workflow_dashboardId.WithUrlEncoding(1), __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPaymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<MarkPaymentPaidResponse, ApiConnectionActionConfiguration> MarkPaymentPaid(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<MarkPaymentPaidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments/{1}/mark_as_paid", __workflow_dashboardId.WithUrlEncoding(1), __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MarkPaymentPaidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendPaymentReminderResponse, ApiConnectionActionConfiguration> SendPaymentReminder(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<SendPaymentReminderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments/{1}/resend", __workflow_dashboardId.WithUrlEncoding(1), __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SendPaymentReminderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CancelPaymentResponse, ApiConnectionActionConfiguration> CancelPayment(Expression<Func<int>> dashboardId, Expression<Func<int>> paymentId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<CancelPaymentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments/{1}/cancel", __workflow_dashboardId.WithUrlEncoding(1), __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CancelPaymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentsResponse, ApiConnectionActionConfiguration> GetPayments(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<int>> dashboardId, Expression<Func<string>> referenceNumber = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> sortType = null, Expression<Func<string>> sortDirection = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_referenceNumber = WorkflowExpression.Compile(referenceNumber, nameof(referenceNumber), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_sortType = WorkflowExpression.Compile(sortType, nameof(sortType), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<GetPaymentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reference_number"] = Convert.ToString("receipt-chicago");
                if (__workflow_referenceNumber != null)
                    callPayload.Queries["reference_number"] = ExpressionConverter.Convert(__workflow_referenceNumber);
                callPayload.Queries["phone_number"] = Convert.ToString("anim nostrud");
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                callPayload.Queries["sort_type"] = Convert.ToString("date");
                if (__workflow_sortType != null)
                    callPayload.Queries["sort_type"] = ExpressionConverter.Convert(__workflow_sortType);
                callPayload.Queries["sort_direction"] = Convert.ToString("desc");
                if (__workflow_sortDirection != null)
                    callPayload.Queries["sort_direction"] = ExpressionConverter.Convert(__workflow_sortDirection);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetPaymentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreatePaymentResponse, ApiConnectionActionConfiguration> CreatePayment(Expression<Func<int>> dashboardId, Expression<Func<CreatePaymentInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatePaymentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/payments", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePaymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardResponse, ApiConnectionActionConfiguration> GetDashboard(Expression<Func<int>> dashboardId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            return new DeferredBodyAction<GetDashboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDashboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteDashboard(Expression<Func<int>> dashboardId)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateDashboardsNameResponse, ApiConnectionActionConfiguration> UpdateDashboardsName(Expression<Func<int>> dashboardId, Expression<Func<UpdateDashboardsNameInput>> body)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateDashboardsNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateDashboardsNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetConversationsResponse, ApiConnectionActionConfiguration> GetConversations(Expression<Func<int>> dashboardId, Expression<Func<string>> tags = null, Expression<Func<string>> showUnresolvedOnly = null, Expression<Func<string>> includeArchived = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_showUnresolvedOnly = WorkflowExpression.Compile(showUnresolvedOnly, nameof(showUnresolvedOnly), required: false);
            var __workflow_includeArchived = WorkflowExpression.Compile(includeArchived, nameof(includeArchived), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetConversationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/conversations", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                callPayload.Queries["show_unresolved_only"] = Convert.ToString("true");
                if (__workflow_showUnresolvedOnly != null)
                    callPayload.Queries["show_unresolved_only"] = ExpressionConverter.Convert(__workflow_showUnresolvedOnly);
                callPayload.Queries["include_archived"] = Convert.ToString("true");
                if (__workflow_includeArchived != null)
                    callPayload.Queries["include_archived"] = ExpressionConverter.Convert(__workflow_includeArchived);
                callPayload.Queries["search"] = Convert.ToString("321-654-7890");
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetConversationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardsResponse, ApiConnectionActionConfiguration> GetDashboards(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetDashboardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dashboards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetDashboardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateDashboardResponse, ApiConnectionActionConfiguration> CreateDashboard(Expression<Func<CreateDashboardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDashboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dashboards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDashboardResponse>(callPayload);
            });
        }
    }

    public class TextrequestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TextingWebhookResponse, ApiConnectionTriggerConfiguration> TextingWebhook(Expression<Func<string>> dashboardId, Expression<Func<TextingWebhookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_dashboardId = WorkflowExpression.Compile(dashboardId, nameof(dashboardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<TextingWebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dashboards/{0}/hooks", __workflow_dashboardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<TextingWebhookResponse>(callPayload, recurrence: recurrence);
            });
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

    public class SendMessageByPhoneNumberInput
    {
        [JsonProperty("body")]
        public string MessageBody { get; set; }

        [JsonProperty("sender_name")]
        public string NameOfTheSender { get; set; }

        [JsonProperty("status_callback")]
        public string CallbackUrlForWhenTheMessageStatusUpdates { get; set; }

        [JsonProperty("location_callback")]
        public string LocationCallback { get; set; }

        [JsonProperty("mms_media")]
        public string[] MMSMediaAttachmentsForThisMessage { get; set; }
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

    public class CreateContactInput
    {
        [JsonProperty("first_name")]
        public string FirstNameOfContact { get; set; }

        [JsonProperty("last_name")]
        public string LastNameOfContact { get; set; }

        [JsonProperty("display_name")]
        public string FullNameOfContact { get; set; }

        [JsonProperty("is_suppressed")]
        public bool? WhetherMessagesFromThisContactAreSuppressed { get; set; }

        [JsonProperty("is_archived")]
        public bool? WhetherMessagesFromThisContactAreArchived { get; set; }

        [JsonProperty("is_blocked")]
        public bool? WhetherMessagesFromThisContactAreBlocked { get; set; }

        [JsonProperty("suppressed_reason")]
        public string ReasonForSuppressingThisContact { get; set; }

        [JsonProperty("note")]
        public string ContactNote { get; set; }

        [JsonProperty("groups")]
        public int[] ContactGroups { get; set; }

        [JsonProperty("contact_tags")]
        public string[] ContactTags { get; set; }

        [JsonProperty("custom_fields")]
        public CreateContactInputContactCustomFieldsTypeItem[] ContactCustomFields { get; set; }

        [JsonProperty("is_resolved")]
        public bool? IsResolved { get; set; }
    }

    public class CreateContactInputContactCustomFieldsTypeItem
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
        public bool IsResolved { get; set; }
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

    public class UpdateGroupInput
    {
        [JsonProperty("name")]
        public string GroupName { get; set; }

        [JsonProperty("notes")]
        public string GroupNote { get; set; }
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

    public class CreateGroupInput
    {
        [JsonProperty("name")]
        public string GroupName { get; set; }

        [JsonProperty("notes")]
        public string GroupNote { get; set; }
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

    public class CreatePaymentInput
    {
        [JsonProperty("description")]
        public string PaymentDescription { get; set; }

        [JsonProperty("customer_phone")]
        public string RecipientPhoneNumber { get; set; }

        [JsonProperty("amount_requested")]
        public double? AmountRequestedInDollars { get; set; }

        [JsonProperty("message")]
        public string PaymentMessageTextBody { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceStringOfThePayment { get; set; }
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

    public class UpdateDashboardsNameInput
    {
        [JsonProperty("name")]
        public string DashboardName { get; set; }
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

    public class CreateDashboardInput
    {
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

    public class TextingWebhookInput
    {
        [JsonProperty("target_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextingWebhookInputEventType Event { get; set; }

        [JsonProperty("httpVerb", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string HttpVerb { get; set; } = "POST";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TextingWebhookInputEventType
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