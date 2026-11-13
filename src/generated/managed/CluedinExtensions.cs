//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cluedin
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CluedinActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cluedin")]
        public IBodyWorkflowAction<ApprovalResponseResponse, ApiConnectionActionConfiguration> ApprovalResponse(Expression<Func<ApprovalResponseBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ApprovalResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/callback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApprovalResponseResponse>(callPayload);
            });
        }
    }

    public class CluedinTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestRaciRuleApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/419f013d-61fe-4f3b-b52e-8069811e6c94";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestBatchedCluesApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/227C247E-7495-49DB-B1AD-486B99B43E2D";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestRaciVocabularyApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/641f26b6-1285-4fbc-8990-10da9010700b";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestRaciVocabularyKeyApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/26b92c0c-fc04-4db5-beda-31f8435a6445";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestRaciEntityTypeApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/6fb298be-bfc5-4d97-ba6a-66e4651578e5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> RequestRaciUserInviteApproval()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/a021ce72-c00c-43f3-9a6a-c856e6f5b005";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> Notification()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/af67f6ab-5ce6-4d04-8a16-6f90ecf9a502";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> StreamIdleEvent()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/4a1ff455-ce3e-47f3-a3cc-07dbdd3b2bdd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new NotificationBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class ApprovalResponseResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ApprovalResponseBodyInput
    {
        public ApprovalResponseBodyInput(BodyInputResultType result)
        {
            this.Result = result;
        }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("workflowMetadata")]
        public JToken WorkflowMetadata { get; set; }

        [JsonProperty("result", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputResultType Result { get; set; }
    }

    public class BodyInputResultType
    {
        public BodyInputResultType(string approval, string reason, string reviewedBy)
        {
            this.Approval = approval;
            this.Reason = reason;
            this.ReviewedBy = reviewedBy;
        }

        [JsonProperty("approval", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Approval { get; set; }

        [JsonProperty("reason", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Reason { get; set; }

        [JsonProperty("reviewedBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewedBy { get; set; }
    }

    public class NotificationBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cluedin;

    public partial class WorkflowManagedActions
    {
        public CluedinActions Cluedin(string connectionId) => new CluedinActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CluedinTriggers Cluedin(string connectionId) => new CluedinTriggers(connectionId);
    }
}