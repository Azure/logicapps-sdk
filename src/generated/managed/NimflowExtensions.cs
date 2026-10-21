//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NimflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<DispatchContextActionResult> ContextsDispatchAction(Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandreference, Expression<Func<string>> commandaction, Expression<Func<string>> commandsubject = null)
        {
            var __workflow_commandcontextTypeName = WorkflowExpression.Compile(commandcontextTypeName, nameof(commandcontextTypeName), required: true);
            var __workflow_commandreference = WorkflowExpression.Compile(commandreference, nameof(commandreference), required: true);
            var __workflow_commandaction = WorkflowExpression.Compile(commandaction, nameof(commandaction), required: true);
            var __workflow_commandsubject = WorkflowExpression.Compile(commandsubject, nameof(commandsubject), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse(Expression<Func<string>> commandcontextReference, Expression<Func<string>> commandcontextTypeName, Expression<Func<string>> commandtaskTypeName, Expression<Func<string>> commandresponseTypeName, Expression<Func<string>> commandsentBy = null, Expression<Func<string>> commandstartedOn = null, Expression<Func<string>> commandsentOn = null, Expression<Func<string>> commandsubject = null, Expression<Func<string>> commanditemKey = null)
        {
            var __workflow_commandcontextReference = WorkflowExpression.Compile(commandcontextReference, nameof(commandcontextReference), required: true);
            var __workflow_commandcontextTypeName = WorkflowExpression.Compile(commandcontextTypeName, nameof(commandcontextTypeName), required: true);
            var __workflow_commandtaskTypeName = WorkflowExpression.Compile(commandtaskTypeName, nameof(commandtaskTypeName), required: true);
            var __workflow_commandresponseTypeName = WorkflowExpression.Compile(commandresponseTypeName, nameof(commandresponseTypeName), required: true);
            var __workflow_commandsentBy = WorkflowExpression.Compile(commandsentBy, nameof(commandsentBy), required: false);
            var __workflow_commandstartedOn = WorkflowExpression.Compile(commandstartedOn, nameof(commandstartedOn), required: false);
            var __workflow_commandsentOn = WorkflowExpression.Compile(commandsentOn, nameof(commandsentOn), required: false);
            var __workflow_commandsubject = WorkflowExpression.Compile(commandsubject, nameof(commandsubject), required: false);
            var __workflow_commanditemKey = WorkflowExpression.Compile(commanditemKey, nameof(commanditemKey), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class NimflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenTaskCreatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = WorkflowExpression.Compile(requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = WorkflowExpression.Compile(requesttaskTypeName, nameof(requesttaskTypeName), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger WhenTaskUpdatedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = WorkflowExpression.Compile(requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = WorkflowExpression.Compile(requesttaskTypeName, nameof(requesttaskTypeName), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger WhenTaskArchivedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requesttaskTypeName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = WorkflowExpression.Compile(requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requesttaskTypeName = WorkflowExpression.Compile(requesttaskTypeName, nameof(requesttaskTypeName), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger WhenMilestoneReachedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = WorkflowExpression.Compile(requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requestmilestoneName = WorkflowExpression.Compile(requestmilestoneName, nameof(requestmilestoneName), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger WhenMilestoneClearedPost(Expression<Func<string>> requestcontextTypeName = null, Expression<Func<string>> requestmilestoneName = null, FlowRecurrence recurrence = null)
        {
            var __workflow_requestcontextTypeName = WorkflowExpression.Compile(requestcontextTypeName, nameof(requestcontextTypeName), required: false);
            var __workflow_requestmilestoneName = WorkflowExpression.Compile(requestmilestoneName, nameof(requestmilestoneName), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
