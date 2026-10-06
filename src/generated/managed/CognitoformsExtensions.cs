//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitoforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitoformsActions([ConnectionName] string connectionId)
    {
    }

    public class CognitoformsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewEntry))]
        public IWorkflowTrigger NewEntry([WorkflowExpression] Func<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNewEntry(WorkflowExpression<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/integration/oauth/subscribenewentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildUpdateEntry))]
        public IWorkflowTrigger UpdateEntry([WorkflowExpression] Func<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUpdateEntry(WorkflowExpression<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeupdateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEntryDeleted))]
        public IWorkflowTrigger EntryDeleted([WorkflowExpression] Func<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEntryDeleted(WorkflowExpression<string> publisher, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(publisher, nameof(publisher), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/integration/oauth/subscribeentrydeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["module"] = Convert.ToString("forms");
                callPayload.Queries["publisher"] = ExpressionConverter.Convert(publisher);
                var endpoint = new JObject();
                var endpointpropCount = 0;
                endpoint["notificationUrl"] = "#{listCallbackUrl()}";
                endpointpropCount++;
                if (endpointpropCount > 0)
                {
                    callPayload.Body = endpoint;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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