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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewEntry(Expression<Func<string>> publisher, FlowRecurrence recurrence = null)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribenewentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UpdateEntry(Expression<Func<string>> publisher, FlowRecurrence recurrence = null)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeupdateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> EntryDeleted(Expression<Func<string>> publisher, FlowRecurrence recurrence = null)
        {
            var __workflow_publisher = WorkflowExpression.Compile(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeentrydeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(__workflow_publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
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