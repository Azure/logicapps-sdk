//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NimflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<DispatchContextActionResult> ContextsDispatchAction(Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandreference, Expression<Func<string>> commandaction, Expression<Func<string>> commandsubject = null)
        {
            var apiCallPath = "/Contexts/DispatchAction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var command = new JObject();
            var commandpropCount = 0;
            commandpropCount++;
            command["contextTypeName"] = CSharpExpressionConverter.ConvertToken(commandcontextTypeName);
            commandpropCount++;
            command["reference"] = CSharpExpressionConverter.ConvertToken(commandreference);
            commandpropCount++;
            command["action"] = CSharpExpressionConverter.ConvertToken(commandaction);
            var payloadObject = new JObject();
            var payloadObjectpropCount = 0;
            if (payloadObjectpropCount > 0)
            {
                command["payload"] = payloadObject;
                commandpropCount++;
            }

            if (commandsubject != null)
            {
                command["subject"] = CSharpExpressionConverter.ConvertToken(commandsubject);
                commandpropCount++;
            }

            if (commandpropCount > 0)
            {
                callPayload.Body = command;
            }

            return new ApiConnectionAction<DispatchContextActionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse(Expression<Func<string>> commandcontextReference, Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandtaskTypeName, Expression<Func<string>> commandresponseTypeName, Expression<Func<string>> commandsentBy = null, Expression<Func<string>> commandstartedOn = null, Expression<Func<string>> commandsentOn = null, Expression<Func<string>> commandsubject = null, Expression<Func<string>> commanditemKey = null)
        {
            var apiCallPath = "/Tasks/AddResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var command = new JObject();
            var commandpropCount = 0;
            commandpropCount++;
            command["contextReference"] = CSharpExpressionConverter.ConvertToken(commandcontextReference);
            if (commandsentBy != null)
            {
                command["sentBy"] = CSharpExpressionConverter.ConvertToken(commandsentBy);
                commandpropCount++;
            }

            var payloadObject = new JObject();
            var payloadObjectpropCount = 0;
            if (payloadObjectpropCount > 0)
            {
                command["payload"] = payloadObject;
                commandpropCount++;
            }

            if (commandstartedOn != null)
            {
                command["startedOn"] = CSharpExpressionConverter.ConvertToken(commandstartedOn);
                commandpropCount++;
            }

            if (commandsentOn != null)
            {
                command["sentOn"] = CSharpExpressionConverter.ConvertToken(commandsentOn);
                commandpropCount++;
            }

            if (commandsubject != null)
            {
                command["subject"] = CSharpExpressionConverter.ConvertToken(commandsubject);
                commandpropCount++;
            }

            commandpropCount++;
            command["contextTypeName"] = CSharpExpressionConverter.ConvertToken(commandcontextTypeName);
            commandpropCount++;
            command["taskTypeName"] = CSharpExpressionConverter.ConvertToken(commandtaskTypeName);
            commandpropCount++;
            command["responseTypeName"] = CSharpExpressionConverter.ConvertToken(commandresponseTypeName);
            if (commanditemKey != null)
            {
                command["itemKey"] = CSharpExpressionConverter.ConvertToken(commanditemKey);
                commandpropCount++;
            }

            if (commandpropCount > 0)
            {
                callPayload.Body = command;
            }

            return new ApiConnectionAction<AddTaskResponseResult>(callPayload);
        }
    }

    public class NimflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenTaskCreatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = CSharpExpressionConverter.ConvertToken(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = CSharpExpressionConverter.ConvertToken(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskUpdatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = CSharpExpressionConverter.ConvertToken(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = CSharpExpressionConverter.ConvertToken(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskArchivedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskArchived";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = CSharpExpressionConverter.ConvertToken(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = CSharpExpressionConverter.ConvertToken(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneReachedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenMilestoneReached";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = CSharpExpressionConverter.ConvertToken(requestcontextTypeName);
                requestpropCount++;
            }

            if (requestmilestoneName != null)
            {
                request["milestoneName"] = CSharpExpressionConverter.ConvertToken(requestmilestoneName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneClearedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenMilestoneCleared";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listCallbackUrl()";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = CSharpExpressionConverter.ConvertToken(requestcontextTypeName);
                requestpropCount++;
            }

            if (requestmilestoneName != null)
            {
                request["milestoneName"] = CSharpExpressionConverter.ConvertToken(requestmilestoneName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class DispatchContextActionResult
    {
        [JsonProperty("contextId")]
        public string ContextId { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }
    }

    public class AddTaskResponseResult
    {
        [JsonProperty("responseId")]
        public string ResponseId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow;

    public partial class WorkflowManagedActions
    {
        public NimflowActions Nimflow(string connectionId) => new NimflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NimflowTriggers Nimflow(string connectionId) => new NimflowTriggers(connectionId);
    }
}