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
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse(Expression<Func<string>> commandcontextReference, Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandtaskTypeName, Expression<Func<string>> commandresponseTypeName, Expression<Func<string>> commandsentBy = null, Expression<Func<string>> commandstartedOn = null, Expression<Func<string>> commandsentOn = null, Expression<Func<string>> commandsubject = null, Expression<Func<string>> commanditemKey = null)
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
        public IWorkflowTrigger WhenTaskCreatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null)
        {
            var apiCallPath = "/WhenTaskCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WhenTaskUpdatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null)
        {
            var apiCallPath = "/WhenTaskUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WhenTaskArchivedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, string triggerName = null)
        {
            var apiCallPath = "/WhenTaskArchived";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WhenMilestoneReachedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, string triggerName = null)
        {
            var apiCallPath = "/WhenMilestoneReached";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger WhenMilestoneClearedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, string triggerName = null)
        {
            var apiCallPath = "/WhenMilestoneCleared";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
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