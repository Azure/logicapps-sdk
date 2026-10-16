//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telephonyxtendedsrv
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelephonyxtendedsrvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction Raw(Expression<Func<string>> bodyuserID, Expression<Func<string>> bodypath, Expression<Func<string>> bodypayload = null, Expression<Func<acceptInput>> accept = null)
        {
            var __workflow_bodyuserID = WorkflowExpression.Compile(bodyuserID, nameof(bodyuserID), required: true);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: true);
            var __workflow_bodypayload = WorkflowExpression.Compile(bodypayload, nameof(bodypayload), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/XSI-Action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserID);
                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                if (__workflow_bodypayload != null)
                {
                    body["payload"] = ExpressionConverter.ConvertO(__workflow_bodypayload);
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
        public IBodyWorkflowAction<UserCallsResponseItem[]> UserCalls(Expression<Func<string>> bodyuserId)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
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
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserCallsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IBodyWorkflowAction<UserProfileResponse> UserProfile(Expression<Func<string>> bodyuserId)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<UserProfileResponse>(() =>
            {
                var apiCallPath = "/api/User-Profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserProfileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IBodyWorkflowAction<JToken> CallRecording(Expression<Func<string>> bodyaction, Expression<Func<string>> bodycallId, Expression<Func<string>> bodyuserId)
        {
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: true);
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/Toogle-Call-Recording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction ToggleAgentACDState(Expression<Func<string>> bodyagentACDState, Expression<Func<string>> bodyuserID = null)
        {
            var __workflow_bodyagentACDState = WorkflowExpression.Compile(bodyagentACDState, nameof(bodyagentACDState), required: true);
            var __workflow_bodyuserID = WorkflowExpression.Compile(bodyuserID, nameof(bodyuserID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ACD-Toggle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["agentACDState"] = ExpressionConverter.ConvertO(__workflow_bodyagentACDState);
                if (__workflow_bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(__workflow_bodyuserID);
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
        public IWorkflowAction CallNew(Expression<Func<string>> bodyaddress, Expression<Func<string>> bodyuserID = null)
        {
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: true);
            var __workflow_bodyuserID = WorkflowExpression.Compile(bodyuserID, nameof(bodyuserID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserID != null)
                {
                    body["userID"] = ExpressionConverter.ConvertO(__workflow_bodyuserID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallHold(Expression<Func<string>> bodycallId, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Hold";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallEnd(Expression<Func<string>> bodycallId, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallTransfertoVoicemail(Expression<Func<string>> bodycallId, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Transfer-to-Voicemail";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallTransfer(Expression<Func<string>> bodycallId, Expression<Func<string>> bodyaddress, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Transfer-to-Another-User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallAnswer(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodycallId = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodycallId = WorkflowExpression.Compile(bodycallId, nameof(bodycallId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/Call-Answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodycallId != null)
                {
                    body["callId"] = ExpressionConverter.ConvertO(__workflow_bodycallId);
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
        public IWorkflowTrigger Events(Expression<Func<string>> bodyEvent, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, Expression<Func<string>> bodytype = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyEvent = WorkflowExpression.Compile(bodyEvent, nameof(bodyEvent), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyEvent);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
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

        public IWorkflowTrigger EventsDoNotDisturb(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Do-Not-Disturb";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
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

        public IWorkflowTrigger EventsCallCenterMonitoring(Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Monitoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
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

        public IWorkflowTrigger EventsCallCenterQueue(Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Queue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
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

        public IWorkflowTrigger EventsCallCenterAgent(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
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

        public IWorkflowTrigger EventsVoicemail(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Voicemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
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

        public IWorkflowTrigger EventsCall(Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyenterpriseId = null, Expression<Func<string>> bodytype = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/Events-Subscribe-Calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["enterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Advanced Call";
                bodypropCount++;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
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
