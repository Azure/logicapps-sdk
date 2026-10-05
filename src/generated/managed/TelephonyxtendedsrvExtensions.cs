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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRaw(WorkflowValue<string> bodyuserID, WorkflowValue<string> bodypath, WorkflowValue<string> bodypayload = null, WorkflowValue<acceptInput> accept = null)
        {
            WorkflowValue.Validate(bodyuserID, nameof(bodyuserID), required: true);
            WorkflowValue.Validate(bodypath, nameof(bodypath), required: true);
            WorkflowValue.Validate(bodypayload, nameof(bodypayload), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserCallsResponseItem[]> __BuildUserCalls(WorkflowValue<string> bodyuserId)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserProfileResponse> __BuildUserProfile(WorkflowValue<string> bodyuserId)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCallRecording(WorkflowValue<string> bodyaction, WorkflowValue<string> bodycallId, WorkflowValue<string> bodyuserId)
        {
            WorkflowValue.Validate(bodyaction, nameof(bodyaction), required: true);
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildToggleAgentACDState(WorkflowValue<string> bodyagentACDState, WorkflowValue<string> bodyuserID = null)
        {
            WorkflowValue.Validate(bodyagentACDState, nameof(bodyagentACDState), required: true);
            WorkflowValue.Validate(bodyuserID, nameof(bodyuserID), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallNew(WorkflowValue<string> bodyaddress, WorkflowValue<string> bodyuserID = null)
        {
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowValue.Validate(bodyuserID, nameof(bodyuserID), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallHold(WorkflowValue<string> bodycallId, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallEnd(WorkflowValue<string> bodycallId, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallTransfertoVoicemail(WorkflowValue<string> bodycallId, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallTransfer(WorkflowValue<string> bodycallId, WorkflowValue<string> bodyaddress, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: true);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallAnswer(WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodycallId = null)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodycallId, nameof(bodycallId), required: false);
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
        public IWorkflowTrigger Events([WorkflowExpression] Func<string> bodyEvent, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, [WorkflowExpression] Func<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEvents(WorkflowValue<string> bodyEvent, WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, WorkflowValue<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyEvent, nameof(bodyEvent), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsDoNotDisturb))]
        public IWorkflowTrigger EventsDoNotDisturb([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsDoNotDisturb(WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterMonitoring))]
        public IWorkflowTrigger EventsCallCenterMonitoring([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterMonitoring(WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterQueue))]
        public IWorkflowTrigger EventsCallCenterQueue([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterQueue(WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCallCenterAgent))]
        public IWorkflowTrigger EventsCallCenterAgent([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCallCenterAgent(WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsVoicemail))]
        public IWorkflowTrigger EventsVoicemail([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsVoicemail(WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsCall))]
        public IWorkflowTrigger EventsCall([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, [WorkflowExpression] Func<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventsCall(WorkflowValue<string> bodyuserId = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyenterpriseId = null, WorkflowValue<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

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
