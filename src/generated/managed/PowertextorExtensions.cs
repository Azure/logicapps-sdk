//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powertextor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowertextorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToMultipleContactsResponse> SendTextMessageToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageToMultipleContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForContactsResponse> ScheduleReviewTextMessageForContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/schedulereviewcontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["GooglePlaceId"] = SourceExpressionConverter.ConvertToken(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewTextMessageForContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToMultipleGroupsResponse> SendTextMessageToMultipleGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageToMultipleGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextGroupsResponse> SendReviewTextGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewTextGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleMessageForAContactResponse> ScheduleMessageForAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleMessageForAContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleMessageForGroupsResponse> ScheduleMessageForGroups([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduletextbulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleMessageForGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewMessageForAContactResponse> ScheduleReviewMessageForAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/schedulereviewtext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = SourceExpressionConverter.ConvertToken(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewMessageForAContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewGroupsResponse> ScheduleReviewGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduledbulkreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextToAContactResponse> SendTextToAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendmessagesinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextToAContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextToMultipleContactsResponse> ScheduleTextToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduletextmulticontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleTextToMultipleContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewSingleContactResponse> SendReviewSingleContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendereviewsinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = SourceExpressionConverter.ConvertToken(bodygooglePlaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewSingleContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMultipleContactsResponse> SendReviewTextMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendereviewmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = SourceExpressionConverter.ConvertToken(bodygooglePlaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewTextMultipleContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToAContactResponse> SendTextMessageEventReminderToAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendreminderssinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageEventReminderToAContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToMultipleContactsResponse> SendTextMessageEventReminderToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendremindersmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageEventReminderToMultipleContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToGroupsResponse> SendTextMessageEventReminderToGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendremindertogroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageEventReminderToGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToANumberResponse> SendTextMessageToANumber([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendsimple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageToANumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForAGroupResponse> ScheduleReviewTextMessageForAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduledsingleGroupreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewTextMessageForAGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextMessagesForAGroupResponse> ScheduleTextMessagesForAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduletextsingleGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleTextMessagesForAGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextEventReminderToAGroupResponse> SendTextEventReminderToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendremindertosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextEventReminderToAGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMessageToAGroupResponse> SendReviewTextMessageToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendreviewtosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewTextMessageToAGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToAGroupResponse> SendTextMessageToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendsinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageToAGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextToANewGroupResponse> SendTextToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/creategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextToANewGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextForANewGroupResponse> ScheduleTextForANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduledcreategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleTextForANewGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextEventReminderToNewGroupResponse> SendTextEventReminderToNewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/creategroupremindersend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextEventReminderToNewGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageToANewContactResponse> SendMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendsimplewithName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageToANewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageToANewContactResponse> ScheduleReviewTextMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            SourceExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/schedulereviewtextwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["ReviewText"] = SourceExpressionConverter.ConvertToken(bodyreviewText);
                bodypropCount++;
                body["GooglePlaceId"] = SourceExpressionConverter.ConvertToken(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewTextMessageToANewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMessageToANewContactResponse> SendReviewTextMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/createcontactreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["ReviewText"] = SourceExpressionConverter.ConvertToken(bodyreviewText);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewTextMessageToANewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewToANewGroupResponse> ScheduleReviewToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/creategroupschedulereview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReviewText"] = SourceExpressionConverter.ConvertToken(bodyreviewText);
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleReviewToANewGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewToANewGroupResponse> SendReviewToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            SourceExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/creategroupreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["ReviewText"] = SourceExpressionConverter.ConvertToken(bodyreviewText);
                bodypropCount++;
                body["GroupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
                body["PlaceId"] = SourceExpressionConverter.ConvertToken(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendReviewToANewGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextForANewContactResponse> ScheduleTextForANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            SourceExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/scheduletextwithname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                bodypropCount++;
                body["ScheduledDate"] = SourceExpressionConverter.ConvertToken(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = SourceExpressionConverter.ConvertToken(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleTextForANewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<CreateAContactResponse> CreateAContact([WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/contacts/contactnew";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageEventReminderToANewContactResponse> SendMessageEventReminderToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            SourceExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            SourceExpression.Validate(bodyday, nameof(bodyday), required: true);
            SourceExpression.Validate(bodytime, nameof(bodytime), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendreminderwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["ReminderText"] = SourceExpressionConverter.ConvertToken(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = SourceExpressionConverter.ConvertToken(bodyeventDate);
                bodypropCount++;
                body["Day"] = SourceExpressionConverter.ConvertToken(bodyday);
                bodypropCount++;
                body["Time"] = SourceExpressionConverter.ConvertToken(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageEventReminderToANewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<UpdateAPowerTextorContactResponse> UpdateAPowerTextorContact([WorkflowExpression] Func<string> bodycontact, [WorkflowExpression] Func<string> bodyupdatedContactName = null, [WorkflowExpression] Func<string> bodyupdatedContactLastName = null, [WorkflowExpression] Func<string> bodyupdatedContactNumber = null)
        {
            SourceExpression.Validate(bodycontact, nameof(bodycontact), required: true);
            SourceExpression.Validate(bodyupdatedContactName, nameof(bodyupdatedContactName), required: false);
            SourceExpression.Validate(bodyupdatedContactLastName, nameof(bodyupdatedContactLastName), required: false);
            SourceExpression.Validate(bodyupdatedContactNumber, nameof(bodyupdatedContactNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/contacts/contactupdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Contact"] = SourceExpressionConverter.ConvertToken(bodycontact);
                if (bodyupdatedContactName != null)
                {
                    body["UpdatedContactName"] = SourceExpressionConverter.ConvertToken(bodyupdatedContactName);
                    bodypropCount++;
                }

                if (bodyupdatedContactLastName != null)
                {
                    body["UpdatedContactLastName"] = SourceExpressionConverter.ConvertToken(bodyupdatedContactLastName);
                    bodypropCount++;
                }

                if (bodyupdatedContactNumber != null)
                {
                    body["UpdatedContactNumber"] = SourceExpressionConverter.ConvertToken(bodyupdatedContactNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAPowerTextorContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageToMultipleNumbersResponse> SendMessageToMultipleNumbers([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendtomulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ContactNumber"] = SourceExpressionConverter.ConvertToken(bodycontactNumber);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageToMultipleNumbersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageResponse> SendTextMessage([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendsimpletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["Body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = SourceExpressionConverter.ConvertToken(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendTextMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMMSGroupResponse> SendMMSGroup([WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            SourceExpression.Validate(groupName, nameof(groupName), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            SourceExpression.Validate(attachment, nameof(attachment), required: true);
            SourceExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendmmsgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SendMMSGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMMSNewContactResponse> SendMMSNewContact([WorkflowExpression] Func<string> contactNumber, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> contactName = null, [WorkflowExpression] Func<string> contactLastName = null, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            SourceExpression.Validate(contactNumber, nameof(contactNumber), required: true);
            SourceExpression.Validate(attachment, nameof(attachment), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            SourceExpression.Validate(contactName, nameof(contactName), required: false);
            SourceExpression.Validate(contactLastName, nameof(contactLastName), required: false);
            SourceExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendmmsnewcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SendMMSNewContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMMSContactsResponse> SendMMSContacts([WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            SourceExpression.Validate(to, nameof(to), required: true);
            SourceExpression.Validate(message, nameof(message), required: true);
            SourceExpression.Validate(attachment, nameof(attachment), required: true);
            SourceExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/messages/sendmmscontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SendMMSContactsResponse>(BuildSourceInput);
        }
    }

    public class PowertextorTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductionWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/twilio/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger MMSWebhook(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/twilio/MMSregistration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["WebHookUri"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class SendTextMessageToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageToMultipleContactsResponseErrorType Error { get; set; }
        public SendTextMessageToMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponse
    {
        public ScheduleReviewTextMessageForContactsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public ScheduleReviewTextMessageForContactsResponseErrorType Error { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToMultipleGroupsResponse
    {
        public SendTextMessageToMultipleGroupsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class SendTextMessageToMultipleGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextGroupsResponse
    {
        public SendReviewTextGroupsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class SendReviewTextGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleMessageForAContactResponse
    {
        public bool Success { get; set; }
        public ScheduleMessageForAContactResponseErrorType Error { get; set; }
        public ScheduleMessageForAContactResponseDataType Data { get; set; }
    }

    public class ScheduleMessageForAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleMessageForAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleMessageForAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleMessageForAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleMessageForGroupsResponse
    {
        public bool Success { get; set; }
        public ScheduleMessageForGroupsResponseErrorType Error { get; set; }
        public ScheduleMessageForGroupsResponseDataType Data { get; set; }
    }

    public class ScheduleMessageForGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleMessageForGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleMessageForGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleMessageForGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewMessageForAContactResponseErrorType Error { get; set; }
        public ScheduleReviewMessageForAContactResponseDataType Data { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewMessageForAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewGroupsResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewGroupsResponseErrorType Error { get; set; }
        public ScheduleReviewGroupsResponseDataType Data { get; set; }
    }

    public class ScheduleReviewGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextToAContactResponse
    {
        public SendTextToAContactResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextToAContactResponseErrorType Error { get; set; }
    }

    public class SendTextToAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextToAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public ScheduleTextToMultipleContactsResponseErrorType Error { get; set; }
        public ScheduleTextToMultipleContactsResponseDataType Data { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleTextToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewSingleContactResponse
    {
        public bool Success { get; set; }
        public SendReviewSingleContactResponseErrorType Error { get; set; }
        public SendReviewSingleContactResponseDataType Data { get; set; }
    }

    public class SendReviewSingleContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewSingleContactResponseDataType
    {
        public string MessageId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string ReferenceId { get; set; }
        public string Direction { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string CampaignId { get; set; }
        public int Rating { get; set; }
        public int Segments { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedAt { get; set; }
        public SendReviewSingleContactResponseDataTypeAccountType Account { get; set; }
        public SendReviewSingleContactResponseDataTypeContactType Contact { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeAccountType
    {
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string ServicePhone { get; set; }
        public string StripeCustomerId { get; set; }
        public string StripeSubscriptionId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeContactType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public SendReviewSingleContactResponseDataTypeContactTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeContactTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMultipleContactsResponseErrorType Error { get; set; }
        public SendReviewTextMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToAContactResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToAContactResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToGroupsResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToGroupsResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageToANumberResponse
    {
        public SendTextMessageToANumberResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextMessageToANumberResponseErrorType Error { get; set; }
    }

    public class SendTextMessageToANumberResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToANumberResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseErrorType Error { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseDataType Data { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleTextMessagesForAGroupResponse
    {
        public ScheduleTextMessagesForAGroupResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class ScheduleTextMessagesForAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextEventReminderToAGroupResponse
    {
        public bool Success { get; set; }
        public SendTextEventReminderToAGroupResponseErrorType Error { get; set; }
        public SendTextEventReminderToAGroupResponseDataType Data { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextEventReminderToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMessageToAGroupResponseErrorType Error { get; set; }
        public SendReviewTextMessageToAGroupResponseDataType Data { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMessageToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageToAGroupResponse
    {
        public bool Success { get; set; }
        public SendTextMessageToAGroupResponseErrorType Error { get; set; }
        public SendTextMessageToAGroupResponseDataType Data { get; set; }
    }

    public class SendTextMessageToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextToANewGroupResponse
    {
        public bool Success { get; set; }
        public SendTextToANewGroupResponseErrorType Error { get; set; }
        public SendTextToANewGroupResponseDataType Data { get; set; }
    }

    public class SendTextToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextForANewGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleTextForANewGroupResponseErrorType Error { get; set; }
        public ScheduleTextForANewGroupResponseDataType Data { get; set; }
    }

    public class ScheduleTextForANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextForANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponse
    {
        public bool Success { get; set; }
        public SendTextEventReminderToNewGroupResponseErrorType Error { get; set; }
        public SendTextEventReminderToNewGroupResponseDataType Data { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public SendMessageToANewContactResponseErrorType Error { get; set; }
        public SendMessageToANewContactResponseDataType Data { get; set; }
    }

    public class SendMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseErrorType Error { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseDataType Data { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMessageToANewContactResponseErrorType Error { get; set; }
        public SendReviewTextMessageToANewContactResponseDataType Data { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewToANewGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewToANewGroupResponseErrorType Error { get; set; }
        public ScheduleReviewToANewGroupResponseDataType Data { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewToANewGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewToANewGroupResponse
    {
        public bool Success { get; set; }
        public SendReviewToANewGroupResponseErrorType Error { get; set; }
        public SendReviewToANewGroupResponseDataType Data { get; set; }
    }

    public class SendReviewToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewToANewGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewToANewGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleTextForANewContactResponse
    {
        public bool Success { get; set; }
        public ScheduleTextForANewContactResponseErrorType Error { get; set; }
        public ScheduleTextForANewContactResponseDataType Data { get; set; }
    }

    public class ScheduleTextForANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextForANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleTextForANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextForANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class CreateAContactResponse
    {
        public bool Success { get; set; }
        public CreateAContactResponseErrorType Error { get; set; }
        public CreateAContactResponseDataType Data { get; set; }
    }

    public class CreateAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class CreateAContactResponseDataType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public CreateAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class CreateAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponse
    {
        public bool Success { get; set; }
        public SendMessageEventReminderToANewContactResponseErrorType Error { get; set; }
        public SendMessageEventReminderToANewContactResponseDataType Data { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendMessageEventReminderToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class UpdateAPowerTextorContactResponse
    {
        public bool Success { get; set; }
        public UpdateAPowerTextorContactResponseErrorType Error { get; set; }
        public UpdateAPowerTextorContactResponseDataType Data { get; set; }
    }

    public class UpdateAPowerTextorContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateAPowerTextorContactResponseDataType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public UpdateAPowerTextorContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class UpdateAPowerTextorContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendMessageToMultipleNumbersResponse
    {
        public bool Success { get; set; }
        public SendMessageToMultipleNumbersResponseErrorType Error { get; set; }
        public SendMessageToMultipleNumbersResponseDataType Data { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public SendMessageToMultipleNumbersResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageResponse
    {
        public SendTextMessageResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextMessageResponseErrorType Error { get; set; }
    }

    public class SendTextMessageResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMMSGroupResponse
    {
        public bool Success { get; set; }
        public SendMMSGroupResponseErrorType Error { get; set; }
        public SendMMSGroupResponseDataType Data { get; set; }
    }

    public class SendMMSGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMMSGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
    }

    public class SendMMSNewContactResponse
    {
        public bool Success { get; set; }
        public SendMMSNewContactResponseErrorType Error { get; set; }
        public SendMMSNewContactResponseDataType Data { get; set; }
    }

    public class SendMMSNewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMMSNewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
    }

    public class SendMMSContactsResponse
    {
        public bool Success { get; set; }
        public SendMMSContactsResponseErrorType Error { get; set; }
        public SendMMSContactsResponseDataType Data { get; set; }
    }

    public class SendMMSContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMMSContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powertextor;

    public partial class WorkflowManagedActions
    {
        public PowertextorActions Powertextor(string connectionId) => new PowertextorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowertextorTriggers Powertextor(string connectionId) => new PowertextorTriggers(connectionId);
    }
}