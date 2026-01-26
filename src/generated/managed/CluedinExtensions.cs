//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cluedin
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CluedinActions([ConnectionName] string connectionId)
    {
    }

    public class CluedinTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RequestRACIRuleApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/419f013d-61fe-4f3b-b52e-8069811e6c94";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RequestBatchedCluesApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/227C247E-7495-49DB-B1AD-486B99B43E2D";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RequestRACIVocabularyApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/641f26b6-1285-4fbc-8990-10da9010700b";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RequestRACIVocabularyKeyApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/26b92c0c-fc04-4db5-beda-31f8435a6445";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RequestRACIEntityTypeApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/6fb298be-bfc5-4d97-ba6a-66e4651578e5";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RequestRACIUserInviteApproval(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/a021ce72-c00c-43f3-9a6a-c856e6f5b005";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger Notification(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/af67f6ab-5ce6-4d04-8a16-6f90ecf9a502";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger StreamIdleEvent(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/4a1ff455-ce3e-47f3-a3cc-07dbdd3b2bdd";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
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