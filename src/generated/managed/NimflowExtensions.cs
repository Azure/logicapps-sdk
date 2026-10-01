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
        public IBodyWorkflowAction<DispatchContextActionResult> ContextsDispatchAction([WorkflowExpression] Func<string> commandcontextTypeName, [WorkflowExpression] Func<string> commandreference, [WorkflowExpression] Func<string> commandaction, [WorkflowExpression] Func<string> commandsubject = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contexts/DispatchAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["contextTypeName"] = SourceExpressionConverter.ConvertToken(commandcontextTypeName);
                commandpropCount++;
                command["reference"] = SourceExpressionConverter.ConvertToken(commandreference);
                commandpropCount++;
                command["action"] = SourceExpressionConverter.ConvertToken(commandaction);
                var payloadObject = new JObject();
                var payloadObjectpropCount = 0;
                if (payloadObjectpropCount > 0)
                {
                    command["payload"] = payloadObject;
                    commandpropCount++;
                }

                if (commandsubject != null)
                {
                    command["subject"] = SourceExpressionConverter.ConvertToken(commandsubject);
                    commandpropCount++;
                }

                if (commandpropCount > 0)
                {
                    callPayload.Body = command;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DispatchContextActionResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult> TasksAddResponse([WorkflowExpression] Func<string> commandcontextReference, [WorkflowExpression] Func<string> commandcontextTypeName, [WorkflowExpression] Func<string> commandtaskTypeName, [WorkflowExpression] Func<string> commandresponseTypeName, [WorkflowExpression] Func<string> commandsentBy = null, [WorkflowExpression] Func<string> commandstartedOn = null, [WorkflowExpression] Func<string> commandsentOn = null, [WorkflowExpression] Func<string> commandsubject = null, [WorkflowExpression] Func<string> commanditemKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Tasks/AddResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var command = new JObject();
                var commandpropCount = 0;
                commandpropCount++;
                command["contextReference"] = SourceExpressionConverter.ConvertToken(commandcontextReference);
                if (commandsentBy != null)
                {
                    command["sentBy"] = SourceExpressionConverter.ConvertToken(commandsentBy);
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
                    command["startedOn"] = SourceExpressionConverter.ConvertToken(commandstartedOn);
                    commandpropCount++;
                }

                if (commandsentOn != null)
                {
                    command["sentOn"] = SourceExpressionConverter.ConvertToken(commandsentOn);
                    commandpropCount++;
                }

                if (commandsubject != null)
                {
                    command["subject"] = SourceExpressionConverter.ConvertToken(commandsubject);
                    commandpropCount++;
                }

                commandpropCount++;
                command["contextTypeName"] = SourceExpressionConverter.ConvertToken(commandcontextTypeName);
                commandpropCount++;
                command["taskTypeName"] = SourceExpressionConverter.ConvertToken(commandtaskTypeName);
                commandpropCount++;
                command["responseTypeName"] = SourceExpressionConverter.ConvertToken(commandresponseTypeName);
                if (commanditemKey != null)
                {
                    command["itemKey"] = SourceExpressionConverter.ConvertToken(commanditemKey);
                    commandpropCount++;
                }

                if (commandpropCount > 0)
                {
                    callPayload.Body = command;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddTaskResponseResult>(BuildSourceInput);
        }
    }

    public class NimflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenTaskCreatedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    request["contextTypeName"] = SourceExpressionConverter.ConvertToken(requestcontextTypeName);
                    requestpropCount++;
                }

                if (requesttaskTypeName != null)
                {
                    request["taskTypeName"] = SourceExpressionConverter.ConvertToken(requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskUpdatedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    request["contextTypeName"] = SourceExpressionConverter.ConvertToken(requestcontextTypeName);
                    requestpropCount++;
                }

                if (requesttaskTypeName != null)
                {
                    request["taskTypeName"] = SourceExpressionConverter.ConvertToken(requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTaskArchivedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requesttaskTypeName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    request["contextTypeName"] = SourceExpressionConverter.ConvertToken(requestcontextTypeName);
                    requestpropCount++;
                }

                if (requesttaskTypeName != null)
                {
                    request["taskTypeName"] = SourceExpressionConverter.ConvertToken(requesttaskTypeName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneReachedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    request["contextTypeName"] = SourceExpressionConverter.ConvertToken(requestcontextTypeName);
                    requestpropCount++;
                }

                if (requestmilestoneName != null)
                {
                    request["milestoneName"] = SourceExpressionConverter.ConvertToken(requestmilestoneName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMilestoneClearedPost([WorkflowExpression] Func<string> requestcontextTypeName = null, [WorkflowExpression] Func<string> requestmilestoneName = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    request["contextTypeName"] = SourceExpressionConverter.ConvertToken(requestcontextTypeName);
                    requestpropCount++;
                }

                if (requestmilestoneName != null)
                {
                    request["milestoneName"] = SourceExpressionConverter.ConvertToken(requestmilestoneName);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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