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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddInstructorResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetAttendanceResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null, WorkflowExpression<Attendees[]> bodyattendees = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodyattendees, nameof(bodyattendees), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLaunchSessionResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> bodyjoinUrl = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodyjoinUrl, nameof(bodyjoinUrl), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateSessionResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> bodycorpId = null, WorkflowExpression<string> bodymeetingId = null, WorkflowExpression<string> bodystart = null, WorkflowExpression<string> bodyend = null, WorkflowExpression<string> bodyhostEmail = null, WorkflowExpression<string> bodyjoinURL = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodycorpId, nameof(bodycorpId), required: false);
            WorkflowExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            WorkflowExpression.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowExpression.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowExpression.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateSessionResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> bodycorpId = null, WorkflowExpression<string> bodymeetingId = null, WorkflowExpression<string> bodystart = null, WorkflowExpression<string> bodyend = null, WorkflowExpression<string> bodyhostEmail = null, WorkflowExpression<string> bodyjoinURL = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodycorpId, nameof(bodycorpId), required: false);
            WorkflowExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: false);
            WorkflowExpression.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowExpression.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowExpression.Validate(bodyjoinURL, nameof(bodyjoinURL), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteSessionResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateInstructorResponse(WorkflowExpression<string> bodycorrelationId, WorkflowExpression<bool> bodyisSuccessful = null, WorkflowExpression<string> bodymessage = null)
        {
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: true);
            WorkflowExpression.Validate(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
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
        public IWorkflowTrigger CreateInstructorSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/addInstructor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UpdateInstructorSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/updateInstructor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CreateSessionSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/createSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger UpdateSessionSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/updateSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger DeleteSessionSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/deleteSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger LaunchSessionSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/launchSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger GetAttendanceSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/subscribe/getAttendance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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