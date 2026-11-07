//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datascopeforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatascopeformsActions([ConnectionName] string connectionId)
    {
    }

    public class DatascopeformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionPollingTriggerConfiguration> FormAnswer(Expression<Func<string>> formId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hooks_flow/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<JToken>(callPayload);
            });
        }
    }

    public class BodyInput
    {
        [JsonProperty("subscription_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string SubscriptionUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Datascopeforms;

    public partial class WorkflowManagedActions
    {
        public DatascopeformsActions Datascopeforms(string connectionId) => new DatascopeformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatascopeformsTriggers Datascopeforms(string connectionId) => new DatascopeformsTriggers(connectionId);
    }
}