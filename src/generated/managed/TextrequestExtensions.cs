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
        public IBodyWorkflowAction<GetMessagesByContactPhoneResponse> GetMessagesByContactPhone([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize, [WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetMessagesByContactPhoneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendMessageByPhoneNumberResponse> SendMessageByPhoneNumber([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber, [WorkflowExpression] Func<string> bodymessageBody = null, [WorkflowExpression] Func<string> bodynameOfTheSender = null, [WorkflowExpression] Func<string> bodycallbackUrlForWhenTheMessageStatusUpdates = null, [WorkflowExpression] Func<string> bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne = null, [WorkflowExpression] Func<string[]> bodymMSMediaAttachmentsForThisMessage = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            SourceExpression.Validate(bodymessageBody, nameof(bodymessageBody), required: false);
            SourceExpression.Validate(bodynameOfTheSender, nameof(bodynameOfTheSender), required: false);
            SourceExpression.Validate(bodycallbackUrlForWhenTheMessageStatusUpdates, nameof(bodycallbackUrlForWhenTheMessageStatusUpdates), required: false);
            SourceExpression.Validate(bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne, nameof(bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne), required: false);
            SourceExpression.Validate(bodymMSMediaAttachmentsForThisMessage, nameof(bodymMSMediaAttachmentsForThisMessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessageBody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodymessageBody);
                    bodypropCount++;
                }

                if (bodynameOfTheSender != null)
                {
                    body["sender_name"] = SourceExpressionConverter.ConvertToken(bodynameOfTheSender);
                    bodypropCount++;
                }

                if (bodycallbackUrlForWhenTheMessageStatusUpdates != null)
                {
                    body["status_callback"] = SourceExpressionConverter.ConvertToken(bodycallbackUrlForWhenTheMessageStatusUpdates);
                    bodypropCount++;
                }

                if (bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne != null)
                {
                    body["location_callback"] = SourceExpressionConverter.ConvertToken(bodycallbackUrlForLocationRequestsIfThisMessageIncludesOne);
                    bodypropCount++;
                }

                if (bodymMSMediaAttachmentsForThisMessage != null)
                {
                    body["mms_media"] = SourceExpressionConverter.ConvertToken(bodymMSMediaAttachmentsForThisMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageByPhoneNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> ArchiveConversation([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}/conversations/archive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> UnarchiveConversation([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}/conversations/unarchive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactByPhoneNumberResponse> GetContactByPhoneNumber([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactByPhoneNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteContact([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> phoneNumber, [WorkflowExpression] Func<string> bodyfirstNameOfContact = null, [WorkflowExpression] Func<string> bodylastNameOfContact = null, [WorkflowExpression] Func<string> bodyfullNameOfContact = null, [WorkflowExpression] Func<bool> bodywhetherMessagesFromThisContactAreSuppressed = null, [WorkflowExpression] Func<bool> bodywhetherMessagesFromThisContactAreArchived = null, [WorkflowExpression] Func<bool> bodywhetherMessagesFromThisContactAreBlocked = null, [WorkflowExpression] Func<string> bodyreasonForSuppressingThisContact = null, [WorkflowExpression] Func<string> bodycontactNote = null, [WorkflowExpression] Func<int[]> bodycontactGroups = null, [WorkflowExpression] Func<string[]> bodycontactTags = null, [WorkflowExpression] Func<bodycontactCustomFieldsInputItem[]> bodycontactCustomFields = null, [WorkflowExpression] Func<bool> bodywhetherTheCurrentConversationWithThisContactHasBeenResolved = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            SourceExpression.Validate(bodyfirstNameOfContact, nameof(bodyfirstNameOfContact), required: false);
            SourceExpression.Validate(bodylastNameOfContact, nameof(bodylastNameOfContact), required: false);
            SourceExpression.Validate(bodyfullNameOfContact, nameof(bodyfullNameOfContact), required: false);
            SourceExpression.Validate(bodywhetherMessagesFromThisContactAreSuppressed, nameof(bodywhetherMessagesFromThisContactAreSuppressed), required: false);
            SourceExpression.Validate(bodywhetherMessagesFromThisContactAreArchived, nameof(bodywhetherMessagesFromThisContactAreArchived), required: false);
            SourceExpression.Validate(bodywhetherMessagesFromThisContactAreBlocked, nameof(bodywhetherMessagesFromThisContactAreBlocked), required: false);
            SourceExpression.Validate(bodyreasonForSuppressingThisContact, nameof(bodyreasonForSuppressingThisContact), required: false);
            SourceExpression.Validate(bodycontactNote, nameof(bodycontactNote), required: false);
            SourceExpression.Validate(bodycontactGroups, nameof(bodycontactGroups), required: false);
            SourceExpression.Validate(bodycontactTags, nameof(bodycontactTags), required: false);
            SourceExpression.Validate(bodycontactCustomFields, nameof(bodycontactCustomFields), required: false);
            SourceExpression.Validate(bodywhetherTheCurrentConversationWithThisContactHasBeenResolved, nameof(bodywhetherTheCurrentConversationWithThisContactHasBeenResolved), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstNameOfContact != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstNameOfContact);
                    bodypropCount++;
                }

                if (bodylastNameOfContact != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastNameOfContact);
                    bodypropCount++;
                }

                if (bodyfullNameOfContact != null)
                {
                    body["display_name"] = SourceExpressionConverter.ConvertToken(bodyfullNameOfContact);
                    bodypropCount++;
                }

                if (bodywhetherMessagesFromThisContactAreSuppressed != null)
                {
                    body["is_suppressed"] = SourceExpressionConverter.ConvertToken(bodywhetherMessagesFromThisContactAreSuppressed);
                    bodypropCount++;
                }

                if (bodywhetherMessagesFromThisContactAreArchived != null)
                {
                    body["is_archived"] = SourceExpressionConverter.ConvertToken(bodywhetherMessagesFromThisContactAreArchived);
                    bodypropCount++;
                }

                if (bodywhetherMessagesFromThisContactAreBlocked != null)
                {
                    body["is_blocked"] = SourceExpressionConverter.ConvertToken(bodywhetherMessagesFromThisContactAreBlocked);
                    bodypropCount++;
                }

                if (bodyreasonForSuppressingThisContact != null)
                {
                    body["suppressed_reason"] = SourceExpressionConverter.ConvertToken(bodyreasonForSuppressingThisContact);
                    bodypropCount++;
                }

                if (bodycontactNote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodycontactNote);
                    bodypropCount++;
                }

                if (bodycontactGroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodycontactGroups);
                    bodypropCount++;
                }

                if (bodycontactTags != null)
                {
                    body["contact_tags"] = SourceExpressionConverter.ConvertToken(bodycontactTags);
                    bodypropCount++;
                }

                if (bodycontactCustomFields != null)
                {
                    body["custom_fields"] = SourceExpressionConverter.ConvertToken(bodycontactCustomFields);
                    bodypropCount++;
                }

                if (bodywhetherTheCurrentConversationWithThisContactHasBeenResolved != null)
                {
                    body["is_resolved"] = SourceExpressionConverter.ConvertToken(bodywhetherTheCurrentConversationWithThisContactHasBeenResolved);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize, [WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> contactPhoneNumber = null, [WorkflowExpression] Func<string> lastMessageTimestampBeforeUtc = null, [WorkflowExpression] Func<string> lastMessageTimestampAfterUtc = null, [WorkflowExpression] Func<string> contactCreatedBefore = null, [WorkflowExpression] Func<string> contactCreatedAfter = null, [WorkflowExpression] Func<bool> isResolved = null, [WorkflowExpression] Func<bool> isBlocked = null, [WorkflowExpression] Func<bool> isArchived = null, [WorkflowExpression] Func<bool> isSuppressed = null, [WorkflowExpression] Func<bool> hasOptedOut = null, [WorkflowExpression] Func<string> lastMessageSentBefore = null, [WorkflowExpression] Func<string> lastMessageSentAfter = null, [WorkflowExpression] Func<string> lastMessageReceivedBefore = null, [WorkflowExpression] Func<string> lastMessageReceivedAfter = null, [WorkflowExpression] Func<string> tags = null, [WorkflowExpression] Func<string> groups = null, [WorkflowExpression] Func<string> customFieldId1 = null, [WorkflowExpression] Func<string> customFieldValue1 = null, [WorkflowExpression] Func<string> customFieldId2 = null, [WorkflowExpression] Func<string> customFieldValue2 = null, [WorkflowExpression] Func<string> customFieldId3 = null, [WorkflowExpression] Func<string> customFieldValue3 = null)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(contactPhoneNumber, nameof(contactPhoneNumber), required: false);
            SourceExpression.Validate(lastMessageTimestampBeforeUtc, nameof(lastMessageTimestampBeforeUtc), required: false);
            SourceExpression.Validate(lastMessageTimestampAfterUtc, nameof(lastMessageTimestampAfterUtc), required: false);
            SourceExpression.Validate(contactCreatedBefore, nameof(contactCreatedBefore), required: false);
            SourceExpression.Validate(contactCreatedAfter, nameof(contactCreatedAfter), required: false);
            SourceExpression.Validate(isResolved, nameof(isResolved), required: false);
            SourceExpression.Validate(isBlocked, nameof(isBlocked), required: false);
            SourceExpression.Validate(isArchived, nameof(isArchived), required: false);
            SourceExpression.Validate(isSuppressed, nameof(isSuppressed), required: false);
            SourceExpression.Validate(hasOptedOut, nameof(hasOptedOut), required: false);
            SourceExpression.Validate(lastMessageSentBefore, nameof(lastMessageSentBefore), required: false);
            SourceExpression.Validate(lastMessageSentAfter, nameof(lastMessageSentAfter), required: false);
            SourceExpression.Validate(lastMessageReceivedBefore, nameof(lastMessageReceivedBefore), required: false);
            SourceExpression.Validate(lastMessageReceivedAfter, nameof(lastMessageReceivedAfter), required: false);
            SourceExpression.Validate(tags, nameof(tags), required: false);
            SourceExpression.Validate(groups, nameof(groups), required: false);
            SourceExpression.Validate(customFieldId1, nameof(customFieldId1), required: false);
            SourceExpression.Validate(customFieldValue1, nameof(customFieldValue1), required: false);
            SourceExpression.Validate(customFieldId2, nameof(customFieldId2), required: false);
            SourceExpression.Validate(customFieldValue2, nameof(customFieldValue2), required: false);
            SourceExpression.Validate(customFieldId3, nameof(customFieldId3), required: false);
            SourceExpression.Validate(customFieldValue3, nameof(customFieldValue3), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contact_phone_number"] = Convert.ToString("4239876543");
                if (contactPhoneNumber != null)
                    callPayload.Queries["contact_phone_number"] = SourceExpressionConverter.ConvertO(contactPhoneNumber);
                if (lastMessageTimestampBeforeUtc != null)
                    callPayload.Queries["last_message_timestamp_before_utc"] = SourceExpressionConverter.ConvertO(lastMessageTimestampBeforeUtc);
                if (lastMessageTimestampAfterUtc != null)
                    callPayload.Queries["last_message_timestamp_after_utc"] = SourceExpressionConverter.ConvertO(lastMessageTimestampAfterUtc);
                if (contactCreatedBefore != null)
                    callPayload.Queries["contact_created_before"] = SourceExpressionConverter.ConvertO(contactCreatedBefore);
                if (contactCreatedAfter != null)
                    callPayload.Queries["contact_created_after"] = SourceExpressionConverter.ConvertO(contactCreatedAfter);
                callPayload.Queries["is_resolved"] = Convert.ToString(false);
                if (isResolved != null)
                    callPayload.Queries["is_resolved"] = SourceExpressionConverter.ConvertO(isResolved);
                callPayload.Queries["is_blocked"] = Convert.ToString(false);
                if (isBlocked != null)
                    callPayload.Queries["is_blocked"] = SourceExpressionConverter.ConvertO(isBlocked);
                callPayload.Queries["is_archived"] = Convert.ToString(false);
                if (isArchived != null)
                    callPayload.Queries["is_archived"] = SourceExpressionConverter.ConvertO(isArchived);
                callPayload.Queries["is_suppressed"] = Convert.ToString(false);
                if (isSuppressed != null)
                    callPayload.Queries["is_suppressed"] = SourceExpressionConverter.ConvertO(isSuppressed);
                callPayload.Queries["has_opted_out"] = Convert.ToString(false);
                if (hasOptedOut != null)
                    callPayload.Queries["has_opted_out"] = SourceExpressionConverter.ConvertO(hasOptedOut);
                if (lastMessageSentBefore != null)
                    callPayload.Queries["last_message_sent_before"] = SourceExpressionConverter.ConvertO(lastMessageSentBefore);
                if (lastMessageSentAfter != null)
                    callPayload.Queries["last_message_sent_after"] = SourceExpressionConverter.ConvertO(lastMessageSentAfter);
                if (lastMessageReceivedBefore != null)
                    callPayload.Queries["last_message_received_before"] = SourceExpressionConverter.ConvertO(lastMessageReceivedBefore);
                if (lastMessageReceivedAfter != null)
                    callPayload.Queries["last_message_received_after"] = SourceExpressionConverter.ConvertO(lastMessageReceivedAfter);
                if (tags != null)
                    callPayload.Queries["tags"] = SourceExpressionConverter.ConvertO(tags);
                if (groups != null)
                    callPayload.Queries["groups"] = SourceExpressionConverter.ConvertO(groups);
                if (customFieldId1 != null)
                    callPayload.Queries["custom_field_id_1"] = SourceExpressionConverter.ConvertO(customFieldId1);
                if (customFieldValue1 != null)
                    callPayload.Queries["custom_field_value_1"] = SourceExpressionConverter.ConvertO(customFieldValue1);
                if (customFieldId2 != null)
                    callPayload.Queries["custom_field_id_2"] = SourceExpressionConverter.ConvertO(customFieldId2);
                if (customFieldValue2 != null)
                    callPayload.Queries["custom_field_value_2"] = SourceExpressionConverter.ConvertO(customFieldValue2);
                if (customFieldId3 != null)
                    callPayload.Queries["custom_field_id_3"] = SourceExpressionConverter.ConvertO(customFieldId3);
                if (customFieldValue3 != null)
                    callPayload.Queries["custom_field_value_3"] = SourceExpressionConverter.ConvertO(customFieldValue3);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<BulkUpdateContactsResponseItem[]> BulkUpdateContacts([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/contacts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BulkUpdateContactsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupByIdResponse> GetGroupById([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> groupId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/groups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteGroup([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> groupId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/groups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateGroupResponse> UpdateGroup([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> groupId, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodygroupNote = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            SourceExpression.Validate(bodygroupNote, nameof(bodygroupNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/groups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                    bodypropCount++;
                }

                if (bodygroupNote != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodygroupNote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetGroupsResponse> GetGroups([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize, [WorkflowExpression] Func<int> dashboardId)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodygroupNote = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            SourceExpression.Validate(bodygroupNote, nameof(bodygroupNote), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                    bodypropCount++;
                }

                if (bodygroupNote != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodygroupNote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetTagsResponse> GetTags([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetCustomFieldsResponseItem[]> GetCustomFields([WorkflowExpression] Func<int> dashboardId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCustomFieldsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentResponse> GetPayment([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> paymentId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(paymentId, nameof(paymentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(paymentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPaymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<MarkPaymentPaidResponse> MarkPaymentPaid([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> paymentId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(paymentId, nameof(paymentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments/{1}/mark_as_paid", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(paymentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MarkPaymentPaidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<SendPaymentReminderResponse> SendPaymentReminder([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> paymentId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(paymentId, nameof(paymentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments/{1}/resend", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(paymentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SendPaymentReminderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CancelPaymentResponse> CancelPayment([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<int> paymentId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(paymentId, nameof(paymentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments/{1}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(paymentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CancelPaymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetPaymentsResponse> GetPayments([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize, [WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> referenceNumber = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> sortType = null, [WorkflowExpression] Func<string> sortDirection = null)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(referenceNumber, nameof(referenceNumber), required: false);
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: false);
            SourceExpression.Validate(sortType, nameof(sortType), required: false);
            SourceExpression.Validate(sortDirection, nameof(sortDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reference_number"] = Convert.ToString("receipt-chicago");
                if (referenceNumber != null)
                    callPayload.Queries["reference_number"] = SourceExpressionConverter.ConvertO(referenceNumber);
                callPayload.Queries["phone_number"] = Convert.ToString("anim nostrud");
                if (phoneNumber != null)
                    callPayload.Queries["phone_number"] = SourceExpressionConverter.ConvertO(phoneNumber);
                callPayload.Queries["sort_type"] = Convert.ToString("date");
                if (sortType != null)
                    callPayload.Queries["sort_type"] = SourceExpressionConverter.ConvertO(sortType);
                callPayload.Queries["sort_direction"] = Convert.ToString("desc");
                if (sortDirection != null)
                    callPayload.Queries["sort_direction"] = SourceExpressionConverter.ConvertO(sortDirection);
                callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetPaymentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreatePaymentResponse> CreatePayment([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> bodypaymentDescription = null, [WorkflowExpression] Func<string> bodyrecipientPhoneNumber = null, [WorkflowExpression] Func<double> bodyamountRequestedInDollars = null, [WorkflowExpression] Func<string> bodypaymentMessageTextBody = null, [WorkflowExpression] Func<string> bodyreferenceStringOfThePayment = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(bodypaymentDescription, nameof(bodypaymentDescription), required: false);
            SourceExpression.Validate(bodyrecipientPhoneNumber, nameof(bodyrecipientPhoneNumber), required: false);
            SourceExpression.Validate(bodyamountRequestedInDollars, nameof(bodyamountRequestedInDollars), required: false);
            SourceExpression.Validate(bodypaymentMessageTextBody, nameof(bodypaymentMessageTextBody), required: false);
            SourceExpression.Validate(bodyreferenceStringOfThePayment, nameof(bodyreferenceStringOfThePayment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/payments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypaymentDescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodypaymentDescription);
                    bodypropCount++;
                }

                if (bodyrecipientPhoneNumber != null)
                {
                    body["customer_phone"] = SourceExpressionConverter.ConvertToken(bodyrecipientPhoneNumber);
                    bodypropCount++;
                }

                if (bodyamountRequestedInDollars != null)
                {
                    body["amount_requested"] = SourceExpressionConverter.ConvertToken(bodyamountRequestedInDollars);
                    bodypropCount++;
                }

                if (bodypaymentMessageTextBody != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodypaymentMessageTextBody);
                    bodypropCount++;
                }

                if (bodyreferenceStringOfThePayment != null)
                {
                    body["reference_number"] = SourceExpressionConverter.ConvertToken(bodyreferenceStringOfThePayment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePaymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardResponse> GetDashboard([WorkflowExpression] Func<int> dashboardId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDashboardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<string> DeleteDashboard([WorkflowExpression] Func<int> dashboardId)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<UpdateDashboardsNameResponse> UpdateDashboardsName([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> bodydashboardName = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(bodydashboardName, nameof(bodydashboardName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydashboardName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodydashboardName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDashboardsNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetConversationsResponse> GetConversations([WorkflowExpression] Func<int> dashboardId, [WorkflowExpression] Func<string> tags = null, [WorkflowExpression] Func<string> showUnresolvedOnly = null, [WorkflowExpression] Func<string> includeArchived = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(tags, nameof(tags), required: false);
            SourceExpression.Validate(showUnresolvedOnly, nameof(showUnresolvedOnly), required: false);
            SourceExpression.Validate(includeArchived, nameof(includeArchived), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/conversations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(dashboardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tags != null)
                    callPayload.Queries["tags"] = SourceExpressionConverter.ConvertO(tags);
                callPayload.Queries["show_unresolved_only"] = Convert.ToString("true");
                if (showUnresolvedOnly != null)
                    callPayload.Queries["show_unresolved_only"] = SourceExpressionConverter.ConvertO(showUnresolvedOnly);
                callPayload.Queries["include_archived"] = Convert.ToString("true");
                if (includeArchived != null)
                    callPayload.Queries["include_archived"] = SourceExpressionConverter.ConvertO(includeArchived);
                callPayload.Queries["search"] = Convert.ToString("321-654-7890");
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetConversationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<GetDashboardsResponse> GetDashboards([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dashboards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetDashboardsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "textrequest")]
        public IBodyWorkflowAction<CreateDashboardResponse> CreateDashboard([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphone = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dashboards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDashboardResponse>(BuildSourceInput);
        }
    }

    public class TextrequestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TextingWebhookResponse> TextingWebhook([WorkflowExpression] Func<string> dashboardId, [WorkflowExpression] Func<bodyEventInput> bodyEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dashboardId, nameof(dashboardId), required: true);
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dashboards/{0}/hooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dashboardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["target_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.Convert(bodyEvent);
                body["httpVerb"] = "POST";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<TextingWebhookResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum bodyEventInput
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