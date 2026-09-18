//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Telephonyxtendedsrv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelephonyxtendedsrvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction Raw([WorkflowExpression] Func<string> bodyuserID, [WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodypayload = null, [WorkflowExpression] Func<acceptInput> accept = null)
        {
            SourceExpression.Validate(bodyuserID, nameof(bodyuserID), required: true);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: true);
            SourceExpression.Validate(bodypayload, nameof(bodypayload), required: false);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/XSI-Action";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserID);
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypayload != null)
                {
                    body["payload"] = SourceExpressionConverter.ConvertToken(bodypayload);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IBodyWorkflowAction<UserCallsResponseItem[]> UserCalls([WorkflowExpression] Func<string> bodyuserId)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/User-Calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserCallsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IBodyWorkflowAction<UserProfileResponse> UserProfile([WorkflowExpression] Func<string> bodyuserId)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/User-Profile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IBodyWorkflowAction<JToken> CallRecording([WorkflowExpression] Func<string> bodyaction, [WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId)
        {
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Toogle-Call-Recording";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = SourceExpressionConverter.ConvertToken(bodyaction);
                bodypropCount++;
                body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
                bodypropCount++;
                body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction ToggleAgentACDState([WorkflowExpression] Func<string> bodyagentACDState, [WorkflowExpression] Func<string> bodyuserID = null)
        {
            SourceExpression.Validate(bodyagentACDState, nameof(bodyagentACDState), required: true);
            SourceExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ACD-Toggle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["agentACDState"] = SourceExpressionConverter.ConvertToken(bodyagentACDState);
                if (bodyuserID != null)
                {
                    body["userID"] = SourceExpressionConverter.ConvertToken(bodyuserID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallNew([WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<string> bodyuserID = null)
        {
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: true);
            SourceExpression.Validate(bodyuserID, nameof(bodyuserID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-New";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserID != null)
                {
                    body["userID"] = SourceExpressionConverter.ConvertToken(bodyuserID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallHold([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-Hold";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallEnd([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-End";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallTransfertoVoicemail([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-Transfer-to-Voicemail";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallTransfer([WorkflowExpression] Func<string> bodycallId, [WorkflowExpression] Func<string> bodyaddress, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: true);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-Transfer-to-Another-User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "telephonyxtendedsrv")]
        public IWorkflowAction CallAnswer([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodycallId = null)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodycallId, nameof(bodycallId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Call-Answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodycallId != null)
                {
                    body["callId"] = SourceExpressionConverter.ConvertToken(bodycallId);
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
    }

    public class TelephonyxtendedsrvTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Events([WorkflowExpression] Func<string> bodyEvent, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, [WorkflowExpression] Func<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["event"] = SourceExpressionConverter.ConvertToken(bodyEvent);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsDoNotDisturb([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Do-Not-Disturb";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Do Not Disturb";
                bodypropCount++;
                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsCallCenterMonitoring([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Monitoring";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Monitoring";
                bodypropCount++;
                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsCallCenterQueue([WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Queue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Queue";
                bodypropCount++;
                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsCallCenterAgent([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Call-Center-Agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Call Center Agent";
                bodypropCount++;
                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsVoicemail([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Voicemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Voice Mail Message Summary";
                bodypropCount++;
                body["notificationUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventsCall([WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyenterpriseId = null, [WorkflowExpression] Func<string> bodytype = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            SourceExpression.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Events-Subscribe-Calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["enterpriseId"] = SourceExpressionConverter.ConvertToken(bodyenterpriseId);
                    bodypropCount++;
                }

                body["event"] = "Advanced Call";
                bodypropCount++;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                body["notificationUrl"] = "@listCallbackUrl()";
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