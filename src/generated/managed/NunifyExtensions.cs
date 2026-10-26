//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nunify
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NunifyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nunify")]
        public IBodyWorkflowAction<ADDREGISTRANTResponse, ApiConnectionActionConfiguration> ADDREGISTRANT(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, Expression<Func<ADDREGISTRANTInput>> body = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ADDREGISTRANTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/tickets.json", __workflow_platformId.WithUrlEncoding(1), __workflow_domainId.WithUrlEncoding(1), __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["map_by_labels"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ADDREGISTRANTResponse>(callPayload);
            });
        }
    }

    public class NunifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NEWREGISTRATION(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, Expression<Func<NEWREGISTRATIONInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/ticket_create.json", __workflow_platformId.WithUrlEncoding(1), __workflow_domainId.WithUrlEncoding(1), __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NEWCHECKIN(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, Expression<Func<NEWCHECKINInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/checkin.json", __workflow_platformId.WithUrlEncoding(1), __workflow_domainId.WithUrlEncoding(1), __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ADDREGISTRANTResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ADDREGISTRANTInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("ticket_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketTypeId { get; set; } = "Default";
    }

    public class NEWREGISTRATIONInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "ticket_create";
    }

    public class NEWCHECKINInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Kind { get; set; } = "checkin";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nunify;

    public partial class WorkflowManagedActions
    {
        public NunifyActions Nunify(string connectionId) => new NunifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NunifyTriggers Nunify(string connectionId) => new NunifyTriggers(connectionId);
    }
}