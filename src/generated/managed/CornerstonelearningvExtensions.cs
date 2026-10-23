//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cornerstonelearningv
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CornerstonelearningvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction AddInstructorResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/addInstuctor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction GetAttendanceResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<Attendees[]>> bodyattendees = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyattendees = WorkflowExpression.Compile(bodyattendees, nameof(bodyattendees), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (__workflow_bodyattendees != null)
                {
                    body["attendees"] = ExpressionConverter.ConvertO(__workflow_bodyattendees);
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
        public IWorkflowAction LaunchSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyjoinUrl = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyjoinUrl = WorkflowExpression.Compile(bodyjoinUrl, nameof(bodyjoinUrl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (__workflow_bodyjoinUrl != null)
                {
                    body["joinUrl"] = ExpressionConverter.ConvertO(__workflow_bodyjoinUrl);
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
        public IWorkflowAction CreateSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodycorpId = null, Expression<Func<string>> bodymeetingId = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodyjoinURL = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycorpId = WorkflowExpression.Compile(bodycorpId, nameof(bodycorpId), required: false);
            var __workflow_bodymeetingId = WorkflowExpression.Compile(bodymeetingId, nameof(bodymeetingId), required: false);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: false);
            var __workflow_bodyjoinURL = WorkflowExpression.Compile(bodyjoinURL, nameof(bodyjoinURL), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (__workflow_bodycorpId != null)
                {
                    body["corpId"] = ExpressionConverter.ConvertO(__workflow_bodycorpId);
                    bodypropCount++;
                }

                if (__workflow_bodymeetingId != null)
                {
                    body["meetingId"] = ExpressionConverter.ConvertO(__workflow_bodymeetingId);
                    bodypropCount++;
                }

                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyjoinURL != null)
                {
                    body["joinURL"] = ExpressionConverter.ConvertO(__workflow_bodyjoinURL);
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
        public IWorkflowAction UpdateSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodycorpId = null, Expression<Func<string>> bodymeetingId = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodyjoinURL = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycorpId = WorkflowExpression.Compile(bodycorpId, nameof(bodycorpId), required: false);
            var __workflow_bodymeetingId = WorkflowExpression.Compile(bodymeetingId, nameof(bodymeetingId), required: false);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: false);
            var __workflow_bodyjoinURL = WorkflowExpression.Compile(bodyjoinURL, nameof(bodyjoinURL), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (__workflow_bodycorpId != null)
                {
                    body["corpId"] = ExpressionConverter.ConvertO(__workflow_bodycorpId);
                    bodypropCount++;
                }

                if (__workflow_bodymeetingId != null)
                {
                    body["meetingId"] = ExpressionConverter.ConvertO(__workflow_bodymeetingId);
                    bodypropCount++;
                }

                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyjoinURL != null)
                {
                    body["joinURL"] = ExpressionConverter.ConvertO(__workflow_bodyjoinURL);
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
        public IWorkflowAction DeleteSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction UpdateInstructorResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
        {
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: true);
            var __workflow_bodyisSuccessful = WorkflowExpression.Compile(bodyisSuccessful, nameof(bodyisSuccessful), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/response/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisSuccessful != null)
                {
                    body["isSuccessful"] = ExpressionConverter.ConvertO(__workflow_bodyisSuccessful);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
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
