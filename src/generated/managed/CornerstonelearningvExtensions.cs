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
        public IWorkflowAction<ApiConnectionActionConfiguration> AddInstructorResponse(Expression<Func<AddInstructorResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/addInstuctor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAttendanceResponse(Expression<Func<GetAttendanceResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LaunchSessionResponse(Expression<Func<LaunchSessionResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateSessionResponse(Expression<Func<CreateSessionResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateSessionResponse(Expression<Func<CreateSessionResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSessionResponse(Expression<Func<AddInstructorResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cornerstonelearningv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateInstructorResponse(Expression<Func<AddInstructorResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/response/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CornerstonelearningvTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateInstructorSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/addInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UpdateInstructorSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/updateInstructor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateSessionSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/createSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UpdateSessionSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/updateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DeleteSessionSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/deleteSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> LaunchSessionSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/launchSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GetAttendanceSubscribe()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/getAttendance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateInstructorSubscribeBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class AddInstructorResponseBodyInput
    {
        public AddInstructorResponseBodyInput(string correlationId)
        {
            this.CorrelationId = correlationId;
        }

        [JsonProperty("isSuccessful")]
        public bool? IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }
    }

    public class GetAttendanceResponseBodyInput
    {
        public GetAttendanceResponseBodyInput(string correlationId)
        {
            this.CorrelationId = correlationId;
        }

        [JsonProperty("isSuccessful")]
        public bool? IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }

        [JsonProperty("attendees")]
        public Attendees[] Attendees { get; set; }
    }

    public class Attendees
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class LaunchSessionResponseBodyInput
    {
        public LaunchSessionResponseBodyInput(string correlationId)
        {
            this.CorrelationId = correlationId;
        }

        [JsonProperty("isSuccessful")]
        public bool? IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }

        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }
    }

    public class CreateSessionResponseBodyInput
    {
        public CreateSessionResponseBodyInput(string correlationId)
        {
            this.CorrelationId = correlationId;
        }

        [JsonProperty("isSuccessful")]
        public bool? IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }

        [JsonProperty("corpId")]
        public string CorpId { get; set; }

        [JsonProperty("meetingId")]
        public string MeetingId { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("joinURL")]
        public string JoinUrl { get; set; }
    }

    public class CreateInstructorSubscribeBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
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