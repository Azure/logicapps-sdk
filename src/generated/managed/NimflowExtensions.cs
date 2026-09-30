//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NimflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<DispatchContextActionResult> ContextsDispatchAction([WorkflowExpression] Func<string> commandcontextTypeName, [WorkflowExpression] Func<string> commandreference, [WorkflowExpression] Func<string> commandaction, [WorkflowExpression] Func<string> commandsubject = null)
        {
            var apiCallPath = "/Contexts/DispatchAction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var command = new JObject();
            var commandpropCount = 0;
            commandpropCount++;
            command["contextTypeName"] = ExpressionConverter.ConvertO(commandcontextTypeName);
            commandpropCount++;
            command["reference"] = ExpressionConverter.ConvertO(commandreference);
            commandpropCount++;
            command["action"] = ExpressionConverter.ConvertO(commandaction);
            var payloadObject = new JObject();
            var payloadObjectpropCount = 0;
            if (payloadObjectpropCount > 0)
            {
                command["payload"] = payloadObject;
                commandpropCount++;
            }

            if (commandsubject != null)
            {
                command["subject"] = ExpressionConverter.ConvertO(commandsubject);
                commandpropCount++;
            }

            if (commandpropCount > 0)
            {
                callPayload.Body = command;
            }

            return new ApiConnectionAction<DispatchContextActionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse([WorkflowExpression] Func<string> commandcontextReference, [WorkflowExpression] Func<string> commandcontextTypeName, [WorkflowExpression] Func<string> commandtaskTypeName, [WorkflowExpression] Func<string> commandresponseTypeName, [WorkflowExpression] Func<string> commandsentBy = null, [WorkflowExpression] Func<string> commandstartedOn = null, [WorkflowExpression] Func<string> commandsentOn = null, [WorkflowExpression] Func<string> commandsubject = null, [WorkflowExpression] Func<string> commanditemKey = null)
        {
            var apiCallPath = "/Tasks/AddResponse";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var command = new JObject();
            var commandpropCount = 0;
            commandpropCount++;
            command["contextReference"] = ExpressionConverter.ConvertO(commandcontextReference);
            if (commandsentBy != null)
            {
                command["sentBy"] = ExpressionConverter.ConvertO(commandsentBy);
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
                command["startedOn"] = ExpressionConverter.ConvertO(commandstartedOn);
                commandpropCount++;
            }

            if (commandsentOn != null)
            {
                command["sentOn"] = ExpressionConverter.ConvertO(commandsentOn);
                commandpropCount++;
            }

            if (commandsubject != null)
            {
                command["subject"] = ExpressionConverter.ConvertO(commandsubject);
                commandpropCount++;
            }

            commandpropCount++;
            command["contextTypeName"] = ExpressionConverter.ConvertO(commandcontextTypeName);
            commandpropCount++;
            command["taskTypeName"] = ExpressionConverter.ConvertO(commandtaskTypeName);
            commandpropCount++;
            command["responseTypeName"] = ExpressionConverter.ConvertO(commandresponseTypeName);
            if (commanditemKey != null)
            {
                command["itemKey"] = ExpressionConverter.ConvertO(commanditemKey);
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
        public IWorkflowTrigger WhenTaskCreatedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "#{listCallbackUrl()}";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = ExpressionConverter.ConvertO(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = ExpressionConverter.ConvertO(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskUpdatedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "#{listCallbackUrl()}";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = ExpressionConverter.ConvertO(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = ExpressionConverter.ConvertO(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskArchivedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenTaskArchived";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "#{listCallbackUrl()}";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = ExpressionConverter.ConvertO(requestcontextTypeName);
                requestpropCount++;
            }

            if (requesttaskTypeName != null)
            {
                request["taskTypeName"] = ExpressionConverter.ConvertO(requesttaskTypeName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneReachedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenMilestoneReached";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "#{listCallbackUrl()}";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = ExpressionConverter.ConvertO(requestcontextTypeName);
                requestpropCount++;
            }

            if (requestmilestoneName != null)
            {
                request["milestoneName"] = ExpressionConverter.ConvertO(requestmilestoneName);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneClearedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/WhenMilestoneCleared";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "#{listCallbackUrl()}";
            requestpropCount++;
            if (requestcontextTypeName != null)
            {
                request["contextTypeName"] = ExpressionConverter.ConvertO(requestcontextTypeName);
                requestpropCount++;
            }

            if (requestmilestoneName != null)
            {
                request["milestoneName"] = ExpressionConverter.ConvertO(requestmilestoneName);
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