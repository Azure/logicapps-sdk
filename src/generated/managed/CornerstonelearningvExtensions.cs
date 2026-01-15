//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cornerstonelearningv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CornerstonelearningvActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction AddInstructorResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction GetAttendanceResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<Attendees[]>> bodyattendees = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction LaunchSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyjoinUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction CreateSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodycorpId = null, Expression<Func<string>> bodymeetingId = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodyjoinURL = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction UpdateSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodycorpId = null, Expression<Func<string>> bodymeetingId = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodyjoinURL = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction DeleteSessionResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction UpdateInstructorResponse(Expression<Func<string>> bodycorrelationId, Expression<Func<bool>> bodyisSuccessful = null, Expression<Func<string>> bodymessage = null)
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
        }
    }

    public class CornerstonelearningvTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateInstructorSubscribe()
        {
            var apiCallPath = "/subscribe/addInstructor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UpdateInstructorSubscribe()
        {
            var apiCallPath = "/subscribe/updateInstructor";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CreateSessionSubscribe()
        {
            var apiCallPath = "/subscribe/createSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger UpdateSessionSubscribe()
        {
            var apiCallPath = "/subscribe/updateSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger DeleteSessionSubscribe()
        {
            var apiCallPath = "/subscribe/deleteSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger LaunchSessionSubscribe()
        {
            var apiCallPath = "/subscribe/launchSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GetAttendanceSubscribe()
        {
            var apiCallPath = "/subscribe/getAttendance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Cornerstonelearningv;

    public partial class WorkflowManagedActions
    {
        public CornerstonelearningvActions Cornerstonelearningv(string connectionId) => new CornerstonelearningvActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CornerstonelearningvTriggers Cornerstonelearningv(string connectionId) => new CornerstonelearningvTriggers(connectionId);
    }
}