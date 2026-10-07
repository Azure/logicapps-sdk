//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telephonyxtendedsrv
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelephonyxtendedsrvActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildRaw))]
        public IWorkflowAction Raw([WorkflowExpression] Func<string> bodyuserID, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodypayload = null, [WorkflowExpression] Func<acceptInput> accept = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRaw(WorkflowExpression<string> bodyuserID, WorkflowExpression<string> bodypath, WorkflowExpression<string> bodypayload = null, WorkflowExpression<acceptInput> accept = null)
        {
            WorkflowExpression.Validate(bodyuserID, nameof(bodyuserID), required: true);
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: true);
            WorkflowExpression.Validate(bodypayload, nameof(bodypayload), required: false);
            WorkflowExpression.Validate(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/XSI-Action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodyuserID);
                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(bodypath);
                if (bodypayload != null)
                {
                    body["payload"] = ExpressionConverter.ConvertO(bodypayload);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildUserCalls))]
        public IBodyWorkflowAction<UserCallsResponseItem[]> UserCalls([WorkflowExpression] Func<string> bodyuserId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserCallsResponseItem[]> __BuildUserCalls(WorkflowExpression<string> bodyuserId)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<UserCallsResponseItem[]>(() =>
            {
                var apiCallPath = "/api/User-Calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserCallsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildUserProfile))]
        public IBodyWorkflowAction<UserProfileResponse> UserProfile([WorkflowExpression] Func<string> bodyuserId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserProfileResponse> __BuildUserProfile(WorkflowExpression<string> bodyuserId)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<UserProfileResponse>(() =>
            {
                var apiCallPath = "/api/User-Profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserProfileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallRecording))]
        public IBodyWorkflowAction<JToken> CallRecording([WorkflowExpression] Func<string> bodyaction, [WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCallRecording(WorkflowExpression<string> bodyaction, WorkflowExpression<string> bodycallId, WorkflowExpression<string> bodyuserId)
        {
            WorkflowExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Toogle-Call-Recording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = ExpressionConverter.ConvertO(bodyaction);
                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildToggleAgentACDState))]
        public IWorkflowAction ToggleAgentACDState([WorkflowExpression] Func<string> bodyagentACDState, [WorkflowExpression] Func<string> bodyuserID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildToggleAgentACDState(WorkflowExpression<string> bodyagentACDState, WorkflowExpression<string> bodyuserID = null)
        {
            WorkflowExpression.Validate(bodyagentACDState, nameof(bodyagentACDState), required: true);
            WorkflowExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ACD-Toggle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["agentACDState"] = ExpressionConverter.ConvertO(bodyagentACDState);
                if (bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(bodyuserID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallNew))]
        public IWorkflowAction CallNew([WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<string> bodyuserID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallNew(WorkflowExpression<string> bodyaddress, WorkflowExpression<string> bodyuserID = null)
        {
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(bodyuserID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallHold))]
        public IWorkflowAction CallHold([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallHold(WorkflowExpression<string> bodycallId, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Hold";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallEnd))]
        public IWorkflowAction CallEnd([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallEnd(WorkflowExpression<string> bodycallId, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallTransfertoVoicemail))]
        public IWorkflowAction CallTransfertoVoicemail([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallTransfertoVoicemail(WorkflowExpression<string> bodycallId, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Transfer-to-Voicemail";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallTransfer))]
        public IWorkflowAction CallTransfer([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallTransfer(WorkflowExpression<string> bodycallId, WorkflowExpression<string> bodyaddress, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Transfer-to-Another-User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [WorkflowExpressionFactory(nameof(__BuildCallAnswer))]
        public IWorkflowAction CallAnswer([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodycallId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallAnswer(WorkflowExpression<string> bodyuserId = null, WorkflowExpression<string> bodycallId = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodycallId, nameof(bodycallId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodycallId != null)
                {
                    body["callId"] = ExpressionConverter.ConvertO(bodycallId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TelephonyxtendedsrvTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildEvents))]
        public IWorkflowTrigger Events([WorkflowExpression] Func<string> bodyEvent,[WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,[WorkflowExpression] Func<string> bodytype = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEvents(WorkflowExpression<string> bodyEvent,WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,WorkflowExpression<string> bodytype = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(bodyEvent);
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsDoNotDisturb))]
        public IWorkflowTrigger EventsDoNotDisturb([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsDoNotDisturb(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Do-Not-Disturb";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Do Not Disturb";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterMonitoring))]
        public IWorkflowTrigger EventsCallCenterMonitoring([WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterMonitoring(WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Monitoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Monitoring";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterQueue))]
        public IWorkflowTrigger EventsCallCenterQueue([WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterQueue(WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Queue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Queue";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterAgent))]
        public IWorkflowTrigger EventsCallCenterAgent([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterAgent(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Agent";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsVoicemail))]
        public IWorkflowTrigger EventsVoicemail([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsVoicemail(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Voicemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Voice Mail Message Summary";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCall))]
        public IWorkflowTrigger EventsCall([WorkflowExpression] Func<string> bodyuserId = null,[WorkflowExpression] Func<string> bodygroupId = null,[WorkflowExpression] Func<string> bodyenterpriseId = null,[WorkflowExpression] Func<string> bodytype = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCall(WorkflowExpression<string> bodyuserId = null,WorkflowExpression<string> bodygroupId = null,WorkflowExpression<string> bodyenterpriseId = null,WorkflowExpression<string> bodytype = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Advanced Call";
                bodypropCount++;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum acceptInput
    {
        [EnumMember(Value = "application/json")]
        ApplicationJson,
        [EnumMember(Value = "application/xml")]
        ApplicationXml
    }

    public class UserCallsResponseItem
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class UserProfileResponse
    {
        [JsonProperty("details")]
        public UserProfileResponseDetailsType Details { get; set; }

        [JsonProperty("additionalDetails")]
        public UserProfileResponseAdditionalDetailsType AdditionalDetails { get; set; }

        [JsonProperty("passwordExpiresDays")]
        public int PasswordExpiresDays { get; set; }

        [JsonProperty("fac")]
        public string Fac { get; set; }

        [JsonProperty("registrations")]
        public string Registrations { get; set; }

        [JsonProperty("scheduleList")]
        public string ScheduleList { get; set; }

        [JsonProperty("portalPasswordChange")]
        public string PortalPasswordChange { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class UserProfileResponseDetailsType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("hiranganaLastName")]
        public string HiranganaLastName { get; set; }

        [JsonProperty("hiranganaFirstName")]
        public string HiranganaFirstName { get; set; }

        [JsonProperty("nameDialingName")]
        public UserProfileResponseDetailsTypeNameDialingNameType NameDialingName { get; set; }

        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("serviceProvider")]
        public string ServiceProvider { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("extension")]
        public int Extension { get; set; }
    }

    public class UserProfileResponseDetailsTypeNameDialingNameType
    {
        [JsonProperty("nameDialingLastName")]
        public string NameDialingLastName { get; set; }

        [JsonProperty("nameDialingFirstName")]
        public string NameDialingFirstName { get; set; }
    }

    public class UserProfileResponseAdditionalDetailsType
    {
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("yahooId")]
        public string YahooId { get; set; }

        [JsonProperty("pager")]
        public string Pager { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("impId")]
        public string ImpId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Telephonyxtendedsrv;

    public partial class WorkflowManagedActions
    {
        public TelephonyxtendedsrvActions Telephonyxtendedsrv(string connectionId) => new TelephonyxtendedsrvActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TelephonyxtendedsrvTriggers Telephonyxtendedsrv(string connectionId) => new TelephonyxtendedsrvTriggers(connectionId);
    }
}