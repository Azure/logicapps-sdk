//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinalcadoneconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[], ApiConnectionActionConfiguration> GetOrganizations(Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> xTimeZone = null)
        {
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_xTimeZone = WorkflowExpression.Compile(xTimeZone, nameof(xTimeZone), required: false);
            return new DeferredBodyAction<GetOrganizationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (__workflow_acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["X-TimeZone"] = Convert.ToString("");
                if (__workflow_xTimeZone != null)
                    callPayload.Headers["X-TimeZone"] = ExpressionConverter.Convert(__workflow_xTimeZone);
                return new ApiConnectionAction<GetOrganizationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitParametersResponse, ApiConnectionActionConfiguration> InitParameters(Expression<Func<InitParametersInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InitParametersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/InitParameters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InitParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitResponse, ApiConnectionActionConfiguration> Init(Expression<Func<InitInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/init";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InitResponse>(callPayload);
            });
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenObsCreated(Expression<Func<ThenObsCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/201";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenObsUpdated(Expression<Func<ThenObsUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/202";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenFormCreated(Expression<Func<ThenFormCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/301";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenFormUpdated(Expression<Func<ThenFormUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/302";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ThenDocumentCreated(Expression<Func<ThenDocumentCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/ev/401";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetOrganizationsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InitParametersResponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class InitParametersInput
    {
        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; } = "fr";

        [JsonProperty("timezone")]
        public string TheUserSTimeZoneInIANAFormat { get; set; }
    }

    public class InitResponse
    {
        [JsonProperty("business_organization_id")]
        public string BusinessOrganizationId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }

    public class InitInput
    {
        [JsonProperty("business_organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }

    public class ThenObsCreatedInput
    {
        [JsonProperty("business_organization_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("client_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ThenObsUpdatedInput
    {
        [JsonProperty("business_organization_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("client_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ThenFormCreatedInput
    {
        [JsonProperty("business_organization_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("client_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ThenFormUpdatedInput
    {
        [JsonProperty("business_organization_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("client_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class ThenDocumentCreatedInput
    {
        [JsonProperty("business_organization_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("project_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProjectId { get; set; }

        [JsonProperty("client_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ClientUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect;

    public partial class WorkflowManagedActions
    {
        public FinalcadoneconnectActions Finalcadoneconnect(string connectionId) => new FinalcadoneconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinalcadoneconnectTriggers Finalcadoneconnect(string connectionId) => new FinalcadoneconnectTriggers(connectionId);
    }
}