//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Voxaide
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoxaideActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<Ping, ApiConnectionActionConfiguration> TestConnection()
        {
            return new DeferredBodyAction<Ping, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Ping>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListReasonsResponse, ApiConnectionActionConfiguration> ListReasons()
        {
            return new DeferredBodyAction<ListReasonsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListReasonsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<CreateReasonResponse, ApiConnectionActionConfiguration> CreateReason(Expression<Func<CreateReasonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateReasonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reasons";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateReasonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetReasonResponse, ApiConnectionActionConfiguration> GetReason(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetReasonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reasons/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetReasonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateReason(Expression<Func<string>> id, Expression<Func<UpdateReasonInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reasons/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<ListCallsResponse, ApiConnectionActionConfiguration> ListCalls(Expression<Func<string>> since = null, Expression<Func<string>> status = null, Expression<Func<string>> reasonId = null, Expression<Func<int>> limit = null)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_reasonId = WorkflowExpression.Compile(reasonId, nameof(reasonId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListCallsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_reasonId != null)
                    callPayload.Queries["reasonId"] = ExpressionConverter.Convert(__workflow_reasonId);
                callPayload.Queries["limit"] = Convert.ToString(50);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListCallsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<PlaceCallResponse, ApiConnectionActionConfiguration> PlaceCall(Expression<Func<PlaceCallInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaceCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/calls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlaceCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "voxaide")]
        public IBodyWorkflowAction<GetCallResponse, ApiConnectionActionConfiguration> GetCall(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/calls/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCallResponse>(callPayload);
            });
        }
    }

    public class VoxaideTriggers([ConnectionName] string connectionId)
    {
    }

    public class Ping
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        [JsonProperty("org")]
        public string Org { get; set; }
    }

    public class ListReasonsResponse
    {
        [JsonProperty("reasons")]
        public Reason[] Reasons { get; set; }
    }

    public class Reason
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dayOfWeek")]
        public int DayOfWeek { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }

        [JsonProperty("smsOnNoAnswer")]
        public bool SmsOnNoAnswer { get; set; }

        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        [JsonProperty("contactCount")]
        public int ContactCount { get; set; }
    }

    public class CreateReasonResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateReasonInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dayOfWeek", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DayOfWeek { get; set; } = 1;

        [JsonProperty("questions", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Questions { get; set; }

        [JsonProperty("smsOnNoAnswer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SmsOnNoAnswer { get; set; } = true;

        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetReasonResponse
    {
        [JsonProperty("reason")]
        public Reason Reason { get; set; }
    }

    public class UpdateReasonInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dayOfWeek", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DayOfWeek { get; set; } = 1;

        [JsonProperty("questions", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Questions { get; set; }

        [JsonProperty("smsOnNoAnswer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SmsOnNoAnswer { get; set; } = true;

        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ListCallsResponse
    {
        [JsonProperty("calls")]
        public Call[] Calls { get; set; }
    }

    public class Call
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("reasonId")]
        public string ReasonId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        [JsonProperty("contact")]
        public CallContactType Contact { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("issueRaised")]
        public bool IssueRaised { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("durationSec")]
        public int DurationSec { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class CallContactType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class PlaceCallResponse
    {
        [JsonProperty("callId")]
        public string CallId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PlaceCallInput
    {
        [JsonProperty("reasonId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReasonId { get; set; }

        [JsonProperty("contact", DefaultValueHandling = DefaultValueHandling.Include)]
        public Contact Contact { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("content")]
        public CallContent Content { get; set; }
    }

    public class Contact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class CallContent
    {
        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("goodbye")]
        public string Goodbye { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }
    }

    public class GetCallResponse
    {
        [JsonProperty("call")]
        public Call Call { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Voxaide;

    public partial class WorkflowManagedActions
    {
        public VoxaideActions Voxaide(string connectionId) => new VoxaideActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VoxaideTriggers Voxaide(string connectionId) => new VoxaideTriggers(connectionId);
    }
}