//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitoforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitoformsActions([ConnectionName] string connectionId)
    {
    }

    public class CognitoformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> NewEntry(Expression<Func<string>> publisher)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribenewentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                callPayload.Body = new EndpointInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UpdateEntry(Expression<Func<string>> publisher)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeupdateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                callPayload.Body = new EndpointInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> EntryDeleted(Expression<Func<string>> publisher)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeentrydeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                callPayload.Body = new EndpointInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class EndpointInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitoforms;

    public partial class WorkflowManagedActions
    {
        public CognitoformsActions Cognitoforms(string connectionId) => new CognitoformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitoformsTriggers Cognitoforms(string connectionId) => new CognitoformsTriggers(connectionId);
    }
}