//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powertextor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowertextorActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageToMultipleContacts))]
        public IBodyWorkflowAction<SendTextMessageToMultipleContactsResponse> SendTextMessageToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageToMultipleContactsResponse> __BuildSendTextMessageToMultipleContacts(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageToMultipleContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewTextMessageForContacts))]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForContactsResponse> ScheduleReviewTextMessageForContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForContactsResponse> __BuildScheduleReviewTextMessageForContacts(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygooglePlaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewTextMessageForContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewcontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["GooglePlaceId"] = ExpressionConverter.ConvertO(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewTextMessageForContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageToMultipleGroups))]
        public IBodyWorkflowAction<SendTextMessageToMultipleGroupsResponse> SendTextMessageToMultipleGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageToMultipleGroupsResponse> __BuildSendTextMessageToMultipleGroups(WorkflowExpression<string[]> bodygroupName, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageToMultipleGroupsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageToMultipleGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewTextGroups))]
        public IBodyWorkflowAction<SendReviewTextGroupsResponse> SendReviewTextGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewTextGroupsResponse> __BuildSendReviewTextGroups(WorkflowExpression<string[]> bodygroupName, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyplaceId, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewTextGroupsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewTextGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleMessageForAContact))]
        public IBodyWorkflowAction<ScheduleMessageForAContactResponse> ScheduleMessageForAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleMessageForAContactResponse> __BuildScheduleMessageForAContact(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleMessageForAContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleMessageForAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleMessageForGroups))]
        public IBodyWorkflowAction<ScheduleMessageForGroupsResponse> ScheduleMessageForGroups([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleMessageForGroupsResponse> __BuildScheduleMessageForGroups(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleMessageForGroupsResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextbulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleMessageForGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewMessageForAContact))]
        public IBodyWorkflowAction<ScheduleReviewMessageForAContactResponse> ScheduleReviewMessageForAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewMessageForAContactResponse> __BuildScheduleReviewMessageForAContact(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygooglePlaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewMessageForAContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewtext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = ExpressionConverter.ConvertO(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewMessageForAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewGroups))]
        public IBodyWorkflowAction<ScheduleReviewGroupsResponse> ScheduleReviewGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewGroupsResponse> __BuildScheduleReviewGroups(WorkflowExpression<string[]> bodygroupName, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyplaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewGroupsResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduledbulkreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextToAContact))]
        public IBodyWorkflowAction<SendTextToAContactResponse> SendTextToAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextToAContactResponse> __BuildSendTextToAContact(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextToAContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendmessagesinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextToAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleTextToMultipleContacts))]
        public IBodyWorkflowAction<ScheduleTextToMultipleContactsResponse> ScheduleTextToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleTextToMultipleContactsResponse> __BuildScheduleTextToMultipleContacts(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleTextToMultipleContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextmulticontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleTextToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewSingleContact))]
        public IBodyWorkflowAction<SendReviewSingleContactResponse> SendReviewSingleContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewSingleContactResponse> __BuildSendReviewSingleContact(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygooglePlaceId, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewSingleContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendereviewsinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = ExpressionConverter.ConvertO(bodygooglePlaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewSingleContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewTextMultipleContacts))]
        public IBodyWorkflowAction<SendReviewTextMultipleContactsResponse> SendReviewTextMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewTextMultipleContactsResponse> __BuildSendReviewTextMultipleContacts(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygooglePlaceId, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewTextMultipleContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendereviewmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["GooglePlaceId"] = ExpressionConverter.ConvertO(bodygooglePlaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewTextMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageEventReminderToAContact))]
        public IBodyWorkflowAction<SendTextMessageEventReminderToAContactResponse> SendTextMessageEventReminderToAContact([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageEventReminderToAContactResponse> __BuildSendTextMessageEventReminderToAContact(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageEventReminderToAContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendreminderssinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageEventReminderToAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageEventReminderToMultipleContacts))]
        public IBodyWorkflowAction<SendTextMessageEventReminderToMultipleContactsResponse> SendTextMessageEventReminderToMultipleContacts([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageEventReminderToMultipleContactsResponse> __BuildSendTextMessageEventReminderToMultipleContacts(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageEventReminderToMultipleContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendremindersmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageEventReminderToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageEventReminderToGroups))]
        public IBodyWorkflowAction<SendTextMessageEventReminderToGroupsResponse> SendTextMessageEventReminderToGroups([WorkflowExpression] Func<string[]> bodygroupName, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageEventReminderToGroupsResponse> __BuildSendTextMessageEventReminderToGroups(WorkflowExpression<string[]> bodygroupName, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageEventReminderToGroupsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendremindertogroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageEventReminderToGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageToANumber))]
        public IBodyWorkflowAction<SendTextMessageToANumberResponse> SendTextMessageToANumber([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageToANumberResponse> __BuildSendTextMessageToANumber(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageToANumberResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendsimple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageToANumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewTextMessageForAGroup))]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForAGroupResponse> ScheduleReviewTextMessageForAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForAGroupResponse> __BuildScheduleReviewTextMessageForAGroup(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyplaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewTextMessageForAGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduledsingleGroupreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewTextMessageForAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleTextMessagesForAGroup))]
        public IBodyWorkflowAction<ScheduleTextMessagesForAGroupResponse> ScheduleTextMessagesForAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleTextMessagesForAGroupResponse> __BuildScheduleTextMessagesForAGroup(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleTextMessagesForAGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextsingleGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleTextMessagesForAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextEventReminderToAGroup))]
        public IBodyWorkflowAction<SendTextEventReminderToAGroupResponse> SendTextEventReminderToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextEventReminderToAGroupResponse> __BuildSendTextEventReminderToAGroup(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextEventReminderToAGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendremindertosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextEventReminderToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewTextMessageToAGroup))]
        public IBodyWorkflowAction<SendReviewTextMessageToAGroupResponse> SendReviewTextMessageToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewTextMessageToAGroupResponse> __BuildSendReviewTextMessageToAGroup(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodyplaceId, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewTextMessageToAGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendreviewtosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewTextMessageToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessageToAGroup))]
        public IBodyWorkflowAction<SendTextMessageToAGroupResponse> SendTextMessageToAGroup([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageToAGroupResponse> __BuildSendTextMessageToAGroup(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageToAGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendsinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextToANewGroup))]
        public IBodyWorkflowAction<SendTextToANewGroupResponse> SendTextToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextToANewGroupResponse> __BuildSendTextToANewGroup(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygroupName, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextToANewGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/creategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleTextForANewGroup))]
        public IBodyWorkflowAction<ScheduleTextForANewGroupResponse> ScheduleTextForANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleTextForANewGroupResponse> __BuildScheduleTextForANewGroup(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<string> bodygroupName, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleTextForANewGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduledcreategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleTextForANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextEventReminderToNewGroup))]
        public IBodyWorkflowAction<SendTextEventReminderToNewGroupResponse> SendTextEventReminderToNewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextEventReminderToNewGroupResponse> __BuildSendTextEventReminderToNewGroup(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodygroupName, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextEventReminderToNewGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/creategroupremindersend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextEventReminderToNewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageToANewContact))]
        public IBodyWorkflowAction<SendMessageToANewContactResponse> SendMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageToANewContactResponse> __BuildSendMessageToANewContact(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMessageToANewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendsimplewithName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewTextMessageToANewContact))]
        public IBodyWorkflowAction<ScheduleReviewTextMessageToANewContactResponse> ScheduleReviewTextMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygooglePlaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewTextMessageToANewContactResponse> __BuildScheduleReviewTextMessageToANewContact(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodyreviewText, WorkflowExpression<string> bodygooglePlaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            WorkflowExpression.Validate(bodygooglePlaceId, nameof(bodygooglePlaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewTextMessageToANewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewtextwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["ReviewText"] = ExpressionConverter.ConvertO(bodyreviewText);
                bodypropCount++;
                body["GooglePlaceId"] = ExpressionConverter.ConvertO(bodygooglePlaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewTextMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewTextMessageToANewContact))]
        public IBodyWorkflowAction<SendReviewTextMessageToANewContactResponse> SendReviewTextMessageToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewTextMessageToANewContactResponse> __BuildSendReviewTextMessageToANewContact(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodyreviewText, WorkflowExpression<string> bodyplaceId, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewTextMessageToANewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/createcontactreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["ReviewText"] = ExpressionConverter.ConvertO(bodyreviewText);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewTextMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleReviewToANewGroup))]
        public IBodyWorkflowAction<ScheduleReviewToANewGroupResponse> ScheduleReviewToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleReviewToANewGroupResponse> __BuildScheduleReviewToANewGroup(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodyreviewText, WorkflowExpression<string> bodygroupName, WorkflowExpression<string> bodyplaceId, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleReviewToANewGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/creategroupschedulereview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReviewText"] = ExpressionConverter.ConvertO(bodyreviewText);
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleReviewToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendReviewToANewGroup))]
        public IBodyWorkflowAction<SendReviewToANewGroupResponse> SendReviewToANewGroup([WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<string> bodyreviewText, [WorkflowExpression] Func<string> bodygroupName, [WorkflowExpression] Func<string> bodyplaceId, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendReviewToANewGroupResponse> __BuildSendReviewToANewGroup(WorkflowExpression<string[]> bodyto, WorkflowExpression<string> bodyreviewText, WorkflowExpression<string> bodygroupName, WorkflowExpression<string> bodyplaceId, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyreviewText, nameof(bodyreviewText), required: true);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: true);
            WorkflowExpression.Validate(bodyplaceId, nameof(bodyplaceId), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendReviewToANewGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/creategroupreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["ReviewText"] = ExpressionConverter.ConvertO(bodyreviewText);
                bodypropCount++;
                body["GroupName"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
                body["PlaceId"] = ExpressionConverter.ConvertO(bodyplaceId);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendReviewToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildScheduleTextForANewContact))]
        public IBodyWorkflowAction<ScheduleTextForANewContactResponse> ScheduleTextForANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodyscheduledDate, [WorkflowExpression] Func<string> bodyscheduledTime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleTextForANewContactResponse> __BuildScheduleTextForANewContact(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodyscheduledDate, WorkflowExpression<string> bodyscheduledTime, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodyscheduledDate, nameof(bodyscheduledDate), required: true);
            WorkflowExpression.Validate(bodyscheduledTime, nameof(bodyscheduledTime), required: true);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<ScheduleTextForANewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextwithname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
                body["ScheduledDate"] = ExpressionConverter.ConvertO(bodyscheduledDate);
                bodypropCount++;
                body["ScheduledTime"] = ExpressionConverter.ConvertO(bodyscheduledTime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduleTextForANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAContact))]
        public IBodyWorkflowAction<CreateAContactResponse> CreateAContact([WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAContactResponse> __BuildCreateAContact(WorkflowExpression<string> bodyphone, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodylastName = null)
        {
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<CreateAContactResponse>(() =>
            {
                var apiCallPath = "/api/contacts/contactnew";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Phone"] = ExpressionConverter.ConvertO(bodyphone);
                if (bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageEventReminderToANewContact))]
        public IBodyWorkflowAction<SendMessageEventReminderToANewContactResponse> SendMessageEventReminderToANewContact([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodyreminderText, [WorkflowExpression] Func<string> bodyeventDate, [WorkflowExpression] Func<int> bodyday, [WorkflowExpression] Func<string> bodytime, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageEventReminderToANewContactResponse> __BuildSendMessageEventReminderToANewContact(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodyreminderText, WorkflowExpression<string> bodyeventDate, WorkflowExpression<int> bodyday, WorkflowExpression<string> bodytime, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodyreminderText, nameof(bodyreminderText), required: true);
            WorkflowExpression.Validate(bodyeventDate, nameof(bodyeventDate), required: true);
            WorkflowExpression.Validate(bodyday, nameof(bodyday), required: true);
            WorkflowExpression.Validate(bodytime, nameof(bodytime), required: true);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMessageEventReminderToANewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendreminderwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["ContactLastName"] = ExpressionConverter.ConvertO(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["ReminderText"] = ExpressionConverter.ConvertO(bodyreminderText);
                bodypropCount++;
                body["EventDate"] = ExpressionConverter.ConvertO(bodyeventDate);
                bodypropCount++;
                body["Day"] = ExpressionConverter.ConvertO(bodyday);
                bodypropCount++;
                body["Time"] = ExpressionConverter.ConvertO(bodytime);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageEventReminderToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAPowerTextorContact))]
        public IBodyWorkflowAction<UpdateAPowerTextorContactResponse> UpdateAPowerTextorContact([WorkflowExpression] Func<string> bodycontact, [WorkflowExpression] Func<string> bodyupdatedContactName = null, [WorkflowExpression] Func<string> bodyupdatedContactLastName = null, [WorkflowExpression] Func<string> bodyupdatedContactNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAPowerTextorContactResponse> __BuildUpdateAPowerTextorContact(WorkflowExpression<string> bodycontact, WorkflowExpression<string> bodyupdatedContactName = null, WorkflowExpression<string> bodyupdatedContactLastName = null, WorkflowExpression<string> bodyupdatedContactNumber = null)
        {
            WorkflowExpression.Validate(bodycontact, nameof(bodycontact), required: true);
            WorkflowExpression.Validate(bodyupdatedContactName, nameof(bodyupdatedContactName), required: false);
            WorkflowExpression.Validate(bodyupdatedContactLastName, nameof(bodyupdatedContactLastName), required: false);
            WorkflowExpression.Validate(bodyupdatedContactNumber, nameof(bodyupdatedContactNumber), required: false);
            return new DeferredBodyAction<UpdateAPowerTextorContactResponse>(() =>
            {
                var apiCallPath = "/api/contacts/contactupdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Contact"] = ExpressionConverter.ConvertO(bodycontact);
                if (bodyupdatedContactName != null)
                {
                    body["UpdatedContactName"] = ExpressionConverter.ConvertO(bodyupdatedContactName);
                    bodypropCount++;
                }

                if (bodyupdatedContactLastName != null)
                {
                    body["UpdatedContactLastName"] = ExpressionConverter.ConvertO(bodyupdatedContactLastName);
                    bodypropCount++;
                }

                if (bodyupdatedContactNumber != null)
                {
                    body["UpdatedContactNumber"] = ExpressionConverter.ConvertO(bodyupdatedContactNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAPowerTextorContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessageToMultipleNumbers))]
        public IBodyWorkflowAction<SendMessageToMultipleNumbersResponse> SendMessageToMultipleNumbers([WorkflowExpression] Func<string> bodycontactNumber, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageToMultipleNumbersResponse> __BuildSendMessageToMultipleNumbers(WorkflowExpression<string> bodycontactNumber, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodycontactNumber, nameof(bodycontactNumber), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMessageToMultipleNumbersResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendtomulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ContactNumber"] = ExpressionConverter.ConvertO(bodycontactNumber);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendMessageToMultipleNumbersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendTextMessage))]
        public IBodyWorkflowAction<SendTextMessageResponse> SendTextMessage([WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<bool> bodyreplySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendTextMessageResponse> __BuildSendTextMessage(WorkflowExpression<string> bodyto, WorkflowExpression<string> bodybody, WorkflowExpression<bool> bodyreplySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: true);
            WorkflowExpression.Validate(bodyreplySTOPToOptOut, nameof(bodyreplySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendTextMessageResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendsimpletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["To"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["Body"] = ExpressionConverter.ConvertO(bodybody);
                if (bodyreplySTOPToOptOut != null)
                {
                    body["ReplySTOPToOptOut"] = ExpressionConverter.ConvertO(bodyreplySTOPToOptOut);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendTextMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMMSGroup))]
        public IBodyWorkflowAction<SendMMSGroupResponse> SendMMSGroup([WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMMSGroupResponse> __BuildSendMMSGroup(WorkflowExpression<string> groupName, WorkflowExpression<string> message, WorkflowExpression<object> attachment, WorkflowExpression<bool> replySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(groupName, nameof(groupName), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(attachment, nameof(attachment), required: true);
            WorkflowExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMMSGroupResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendmmsgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SendMMSGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMMSNewContact))]
        public IBodyWorkflowAction<SendMMSNewContactResponse> SendMMSNewContact([WorkflowExpression] Func<string> contactNumber, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> contactName = null, [WorkflowExpression] Func<string> contactLastName = null, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMMSNewContactResponse> __BuildSendMMSNewContact(WorkflowExpression<string> contactNumber, WorkflowExpression<object> attachment, WorkflowExpression<string> message, WorkflowExpression<string> contactName = null, WorkflowExpression<string> contactLastName = null, WorkflowExpression<bool> replySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(contactNumber, nameof(contactNumber), required: true);
            WorkflowExpression.Validate(attachment, nameof(attachment), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(contactName, nameof(contactName), required: false);
            WorkflowExpression.Validate(contactLastName, nameof(contactLastName), required: false);
            WorkflowExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMMSNewContactResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendmmsnewcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SendMMSNewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        [WorkflowExpressionFactory(nameof(__BuildSendMMSContacts))]
        public IBodyWorkflowAction<SendMMSContactsResponse> SendMMSContacts([WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<object> attachment, [WorkflowExpression] Func<bool> replySTOPToOptOut = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMMSContactsResponse> __BuildSendMMSContacts(WorkflowExpression<string> to, WorkflowExpression<string> message, WorkflowExpression<object> attachment, WorkflowExpression<bool> replySTOPToOptOut = null)
        {
            WorkflowExpression.Validate(to, nameof(to), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(attachment, nameof(attachment), required: true);
            WorkflowExpression.Validate(replySTOPToOptOut, nameof(replySTOPToOptOut), required: false);
            return new DeferredBodyAction<SendMMSContactsResponse>(() =>
            {
                var apiCallPath = "/api/messages/sendmmscontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SendMMSContactsResponse>(callPayload);
            });
        }
    }

    public class PowertextorTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductionWebhook(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/twilio/registration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger MMSWebhook(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/twilio/MMSregistration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["WebHookUri"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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