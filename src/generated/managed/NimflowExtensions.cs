//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NimflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<DispatchContextActionResult> ContextsDispatchAction(Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandreference, Expression<Func<string>> commandaction, Expression<Func<string>> commandsubject = null)
        {
            var __workflow_commandcontextTypeName = commandcontextTypeName == null ? null : WorkflowExpression.Compile(commandcontextTypeName);
            WorkflowExpression.Validate(__workflow_commandcontextTypeName, nameof(commandcontextTypeName), required: true);
            var __workflow_commandreference = commandreference == null ? null : WorkflowExpression.Compile(commandreference);
            WorkflowExpression.Validate(__workflow_commandreference, nameof(commandreference), required: true);
            var __workflow_commandaction = commandaction == null ? null : WorkflowExpression.Compile(commandaction);
            WorkflowExpression.Validate(__workflow_commandaction, nameof(commandaction), required: true);
            var __workflow_commandsubject = commandsubject == null ? null : WorkflowExpression.Compile(commandsubject);
            WorkflowExpression.Validate(__workflow_commandsubject, nameof(commandsubject), required: false);
            return new DeferredBodyAction<DispatchContextActionResult>(() =>
            {
                var apiCallPath = "/Contexts/DispatchAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_commandcontextTypeName);
                commandpropCount++;
                command["reference"] = ExpressionConverter.ConvertO(__workflow_commandreference);
                commandpropCount++;
                command["action"] = ExpressionConverter.ConvertO(__workflow_commandaction);
                var payloadObject = new JObject();
                var payloadObjectpropCount = 0;
                if (payloadObjectpropCount > 0)
                {
                    command["payload"] = payloadObject;
                    commandpropCount++;
                }

                if (__workflow_commandsubject != null)
                {
                    command["subject"] = ExpressionConverter.ConvertO(__workflow_commandsubject);
                    commandpropCount++;
                }

                if (commandpropCount > 0)
                {
                    callPayload.Body = command;
                }

                return new ApiConnectionAction<DispatchContextActionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse(Expression<Func<string>> commandcontextReference, Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandtaskTypeName, Expression<Func<string>> commandresponseTypeName, Expression<Func<string>> commandsentBy = null, Expression<Func<string>> commandstartedOn = null, Expression<Func<string>> commandsentOn = null, Expression<Func<string>> commandsubject = null, Expression<Func<string>> commanditemKey = null)
        {
            var __workflow_commandcontextReference = commandcontextReference == null ? null : WorkflowExpression.Compile(commandcontextReference);
            WorkflowExpression.Validate(__workflow_commandcontextReference, nameof(commandcontextReference), required: true);
            var __workflow_commandcontextTypeName = commandcontextTypeName == null ? null : WorkflowExpression.Compile(commandcontextTypeName);
            WorkflowExpression.Validate(__workflow_commandcontextTypeName, nameof(commandcontextTypeName), required: true);
            var __workflow_commandtaskTypeName = commandtaskTypeName == null ? null : WorkflowExpression.Compile(commandtaskTypeName);
            WorkflowExpression.Validate(__workflow_commandtaskTypeName, nameof(commandtaskTypeName), required: true);
            var __workflow_commandresponseTypeName = commandresponseTypeName == null ? null : WorkflowExpression.Compile(commandresponseTypeName);
            WorkflowExpression.Validate(__workflow_commandresponseTypeName, nameof(commandresponseTypeName), required: true);
            var __workflow_commandsentBy = commandsentBy == null ? null : WorkflowExpression.Compile(commandsentBy);
            WorkflowExpression.Validate(__workflow_commandsentBy, nameof(commandsentBy), required: false);
            var __workflow_commandstartedOn = commandstartedOn == null ? null : WorkflowExpression.Compile(commandstartedOn);
            WorkflowExpression.Validate(__workflow_commandstartedOn, nameof(commandstartedOn), required: false);
            var __workflow_commandsentOn = commandsentOn == null ? null : WorkflowExpression.Compile(commandsentOn);
            WorkflowExpression.Validate(__workflow_commandsentOn, nameof(commandsentOn), required: false);
            var __workflow_commandsubject = commandsubject == null ? null : WorkflowExpression.Compile(commandsubject);
            WorkflowExpression.Validate(__workflow_commandsubject, nameof(commandsubject), required: false);
            var __workflow_commanditemKey = commanditemKey == null ? null : WorkflowExpression.Compile(commanditemKey);
            WorkflowExpression.Validate(__workflow_commanditemKey, nameof(commanditemKey), required: false);
            return new DeferredBodyAction<AddTaskResponseResult>(() =>
            {
                var apiCallPath = "/Tasks/AddResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["contextReference"] = ExpressionConverter.ConvertO(__workflow_commandcontextReference);
                if (__workflow_commandsentBy != null)
                {
                    command["sentBy"] = ExpressionConverter.ConvertO(__workflow_commandsentBy);
                    commandpropCount++;
                }

                var payloadObject = new JObject();
                var payloadObjectpropCount = 0;
                if (payloadObjectpropCount > 0)
                {
                    command["payload"] = payloadObject;
                    commandpropCount++;
                }

                if (__workflow_commandstartedOn != null)
                {
                    command["startedOn"] = ExpressionConverter.ConvertO(__workflow_commandstartedOn);
                    commandpropCount++;
                }

                if (__workflow_commandsentOn != null)
                {
                    command["sentOn"] = ExpressionConverter.ConvertO(__workflow_commandsentOn);
                    commandpropCount++;
                }

                if (__workflow_commandsubject != null)
                {
                    command["subject"] = ExpressionConverter.ConvertO(__workflow_commandsubject);
                    commandpropCount++;
                }

                commandpropCount++;
                command["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_commandcontextTypeName);
                commandpropCount++;
                command["taskTypeName"] = ExpressionConverter.ConvertO(__workflow_commandtaskTypeName);
                commandpropCount++;
                command["responseTypeName"] = ExpressionConverter.ConvertO(__workflow_commandresponseTypeName);
                if (__workflow_commanditemKey != null)
                {
                    command["itemKey"] = ExpressionConverter.ConvertO(__workflow_commanditemKey);
                    commandpropCount++;
                }

                if (commandpropCount > 0)
                {
                    callPayload.Body = command;
                }

                return new ApiConnectionAction<AddTaskResponseResult>(callPayload);
            });
        }
    }

    public class NimflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenTaskCreatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = requestcontextTypeName == null ? null : WorkflowExpression.Compile(requestcontextTypeName);
            WorkflowExpression.Validate(__workflow_requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = requesttaskTypeName == null ? null : WorkflowExpression.Compile(requesttaskTypeName);
            WorkflowExpression.Validate(__workflow_requesttaskTypeName, nameof(requesttaskTypeName), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/WhenTaskCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (__workflow_requestcontextTypeName != null)
                {
                    request["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_requestcontextTypeName);
                    requestpropCount++;
                }

                if (__workflow_requesttaskTypeName != null)
                {
                    request["taskTypeName"] = ExpressionConverter.ConvertO(__workflow_requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WhenTaskUpdatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = requestcontextTypeName == null ? null : WorkflowExpression.Compile(requestcontextTypeName);
            WorkflowExpression.Validate(__workflow_requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = requesttaskTypeName == null ? null : WorkflowExpression.Compile(requesttaskTypeName);
            WorkflowExpression.Validate(__workflow_requesttaskTypeName, nameof(requesttaskTypeName), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/WhenTaskUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (__workflow_requestcontextTypeName != null)
                {
                    request["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_requestcontextTypeName);
                    requestpropCount++;
                }

                if (__workflow_requesttaskTypeName != null)
                {
                    request["taskTypeName"] = ExpressionConverter.ConvertO(__workflow_requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WhenTaskArchivedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = requestcontextTypeName == null ? null : WorkflowExpression.Compile(requestcontextTypeName);
            WorkflowExpression.Validate(__workflow_requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = requesttaskTypeName == null ? null : WorkflowExpression.Compile(requesttaskTypeName);
            WorkflowExpression.Validate(__workflow_requesttaskTypeName, nameof(requesttaskTypeName), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/WhenTaskArchived";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (__workflow_requestcontextTypeName != null)
                {
                    request["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_requestcontextTypeName);
                    requestpropCount++;
                }

                if (__workflow_requesttaskTypeName != null)
                {
                    request["taskTypeName"] = ExpressionConverter.ConvertO(__workflow_requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WhenMilestoneReachedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = requestcontextTypeName == null ? null : WorkflowExpression.Compile(requestcontextTypeName);
            WorkflowExpression.Validate(__workflow_requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requestmilestoneName = requestmilestoneName == null ? null : WorkflowExpression.Compile(requestmilestoneName);
            WorkflowExpression.Validate(__workflow_requestmilestoneName, nameof(requestmilestoneName), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/WhenMilestoneReached";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (__workflow_requestcontextTypeName != null)
                {
                    request["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_requestcontextTypeName);
                    requestpropCount++;
                }

                if (__workflow_requestmilestoneName != null)
                {
                    request["milestoneName"] = ExpressionConverter.ConvertO(__workflow_requestmilestoneName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger WhenMilestoneClearedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = requestcontextTypeName == null ? null : WorkflowExpression.Compile(requestcontextTypeName);
            WorkflowExpression.Validate(__workflow_requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requestmilestoneName = requestmilestoneName == null ? null : WorkflowExpression.Compile(requestmilestoneName);
            WorkflowExpression.Validate(__workflow_requestmilestoneName, nameof(requestmilestoneName), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/WhenMilestoneCleared";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (__workflow_requestcontextTypeName != null)
                {
                    request["contextTypeName"] = ExpressionConverter.ConvertO(__workflow_requestcontextTypeName);
                    requestpropCount++;
                }

                if (__workflow_requestmilestoneName != null)
                {
                    request["milestoneName"] = ExpressionConverter.ConvertO(__workflow_requestmilestoneName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
