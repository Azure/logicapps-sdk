//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cornerstonelearningv
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CornerstonelearningvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildAddInstructorResponse))]
        public IWorkflowAction AddInstructorResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddInstructorResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/addInstuctor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttendanceResponse))]
        public IWorkflowAction GetAttendanceResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<Attendees[]> bodyattendees = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAttendanceResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null, WorkflowValue<Attendees[]> bodyattendees = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodyattendees, nameof(bodyattendees), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodyattendees != null)
                {
                    body["attendees"] = ExpressionConverter.ConvertO(bodyattendees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildLaunchSessionResponse))]
        public IWorkflowAction LaunchSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyjoinUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLaunchSessionResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string> bodyjoinUrl = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodyjoinUrl, nameof(bodyjoinUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodyjoinUrl != null)
                {
                    body["joinUrl"] = ExpressionConverter.ConvertO(bodyjoinUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSessionResponse))]
        public IWorkflowAction CreateSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodycorpId = null, [WorkflowExpression] Func<string> bodymeetingId = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodyjoinURL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateSessionResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string> bodycorpId = null, WorkflowValue<string> bodymeetingId = null, WorkflowValue<string> bodystart = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodyhostEmail = null, WorkflowValue<string> bodyjoinURL = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycorpId, nameof(bodycorpId), required: false);
            WorkflowValue.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            WorkflowValue.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowValue.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodycorpId != null)
                {
                    body["corpId"] = ExpressionConverter.ConvertO(bodycorpId);
                    bodypropCount++;
                }

                if (bodymeetingId != null)
                {
                    body["meetingId"] = ExpressionConverter.ConvertO(bodymeetingId);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(bodyend);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodyjoinURL != null)
                {
                    body["joinURL"] = ExpressionConverter.ConvertO(bodyjoinURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSessionResponse))]
        public IWorkflowAction UpdateSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodycorpId = null, [WorkflowExpression] Func<string> bodymeetingId = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodyjoinURL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateSessionResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string> bodycorpId = null, WorkflowValue<string> bodymeetingId = null, WorkflowValue<string> bodystart = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodyhostEmail = null, WorkflowValue<string> bodyjoinURL = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycorpId, nameof(bodycorpId), required: false);
            WorkflowValue.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            WorkflowValue.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowValue.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodycorpId != null)
                {
                    body["corpId"] = ExpressionConverter.ConvertO(bodycorpId);
                    bodypropCount++;
                }

                if (bodymeetingId != null)
                {
                    body["meetingId"] = ExpressionConverter.ConvertO(bodymeetingId);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(bodyend);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodyjoinURL != null)
                {
                    body["joinURL"] = ExpressionConverter.ConvertO(bodyjoinURL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSessionResponse))]
        public IWorkflowAction DeleteSessionResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSessionResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateInstructorResponse))]
        public IWorkflowAction UpdateInstructorResponse([WorkflowExpression] Func<string> bodycorrelationId, [WorkflowExpression] Func<bool> bodyisSuccessful = null, [WorkflowExpression] Func<string> bodymessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateInstructorResponse(WorkflowValue<string> bodycorrelationId, WorkflowValue<bool> bodyisSuccessful = null, WorkflowValue<string> bodymessage = null)
        {
            WorkflowValue.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowValue.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(bodyisSuccessful);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CornerstonelearningvTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateInstructorSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateInstructorSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger UpdateSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger DeleteSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger LaunchSessionSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GetAttendanceSubscribe(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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
