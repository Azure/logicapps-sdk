//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Alembaitsm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlembaitsmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SearchResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<string>> partition, Expression<Func<string>> select, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> skip = null, Expression<Func<int>> leftjoin = null, Expression<Func<int>> innerjoin = null, Expression<Func<bool>> inlinecount = null)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_partition = WorkflowExpression.Compile(partition, nameof(partition), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_leftjoin = WorkflowExpression.Compile(leftjoin, nameof(leftjoin), required: false);
            var __workflow_innerjoin = WorkflowExpression.Compile(innerjoin, nameof(innerjoin), required: false);
            var __workflow_inlinecount = WorkflowExpression.Compile(inlinecount, nameof(inlinecount), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/execute/{0}", __workflow_resource.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["$partition"] = ExpressionConverter.Convert(__workflow_partition);
                callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_leftjoin != null)
                    callPayload.Queries["$leftjoin"] = ExpressionConverter.Convert(__workflow_leftjoin);
                if (__workflow_innerjoin != null)
                    callPayload.Queries["$innerjoin"] = ExpressionConverter.Convert(__workflow_innerjoin);
                if (__workflow_inlinecount != null)
                    callPayload.Queries["$inlinecount"] = ExpressionConverter.Convert(__workflow_inlinecount);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<object>> body)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/execute/{0}", __workflow_resource.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateResource(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<int>> id, Expression<Func<object>> body)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/execute/{0}/{1}", __workflow_resource.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "alembaitsm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ResourceInteractions(Expression<Func<string>> categoryId, Expression<Func<string>> resource, Expression<Func<string>> interaction, Expression<Func<int>> id, Expression<Func<object>> body)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_interaction = WorkflowExpression.Compile(interaction, nameof(interaction), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/execute/{0}/{1}/{2}", __workflow_resource.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1), __workflow_interaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["categoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AlembaitsmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WebhookTrigger(Expression<Func<WebhookTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class WebhookTriggerInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string PayloadUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("Events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventHandling { get; set; }

        [JsonProperty("Active", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool TriggerActive { get; set; } = true;

        [JsonProperty("EntityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Entity { get; set; }

        [JsonProperty("PayloadSelect", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PayloadColumns { get; set; }

        [JsonProperty("Secret")]
        public string TriggerSecret { get; set; }

        [JsonProperty("PayloadFilter")]
        public string TriggerFilter { get; set; }

        [JsonProperty("IndividualTriggers")]
        public string[] IndividualTrigger { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Alembaitsm;

    public partial class WorkflowManagedActions
    {
        public AlembaitsmActions Alembaitsm(string connectionId) => new AlembaitsmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlembaitsmTriggers Alembaitsm(string connectionId) => new AlembaitsmTriggers(connectionId);
    }
}