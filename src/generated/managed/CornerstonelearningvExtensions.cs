//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cornerstonelearningv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CornerstonelearningvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction AddInstructorResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/addInstuctor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction GetAttendanceResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<Attendees[]> bodyattendees = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodyattendees, nameof(bodyattendees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodyattendees != null)
                {
                    body["attendees"] = SourceExpressionConverter.ConvertToken(bodyattendees);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction LaunchSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyjoinUrl = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodyjoinUrl, nameof(bodyjoinUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodyjoinUrl != null)
                {
                    body["joinUrl"] = SourceExpressionConverter.ConvertToken(bodyjoinUrl);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction CreateSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodycorpId = null, [WorkflowExpression] Func<string> bodymeetingId = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodyjoinURL = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycorpId, nameof(bodycorpId), required: false);
            SourceExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            SourceExpression.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodycorpId != null)
                {
                    body["corpId"] = SourceExpressionConverter.ConvertToken(bodycorpId);
                    bodypropCount++;
                }

                if (bodymeetingId != null)
                {
                    body["meetingId"] = SourceExpressionConverter.ConvertToken(bodymeetingId);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodyjoinURL != null)
                {
                    body["joinURL"] = SourceExpressionConverter.ConvertToken(bodyjoinURL);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction UpdateSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodycorpId = null, [WorkflowExpression] Func<string> bodymeetingId = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodyjoinURL = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycorpId, nameof(bodycorpId), required: false);
            SourceExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            SourceExpression.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodycorpId != null)
                {
                    body["corpId"] = SourceExpressionConverter.ConvertToken(bodycorpId);
                    bodypropCount++;
                }

                if (bodymeetingId != null)
                {
                    body["meetingId"] = SourceExpressionConverter.ConvertToken(bodymeetingId);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodyjoinURL != null)
                {
                    body["joinURL"] = SourceExpressionConverter.ConvertToken(bodyjoinURL);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction DeleteSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction UpdateInstructorResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            SourceExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/response/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = SourceExpressionConverter.ConvertToken(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CornerstonelearningvTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateInstructorSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/addInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateInstructorSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger DeleteSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger LaunchSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GetAttendanceSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
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

    public class Attendees
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cornerstonelearningv;

    public partial class WorkflowManagedActions
    {
        public CornerstonelearningvActions Cornerstonelearningv(string connectionId) => new CornerstonelearningvActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CornerstonelearningvTriggers Cornerstonelearningv(string connectionId) => new CornerstonelearningvTriggers(connectionId);
    }
}