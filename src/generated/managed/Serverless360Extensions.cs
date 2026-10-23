//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serverless360
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Serverless360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ArchiveActivity(Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<string>> sL360StageActivityId)
        {
            var __workflow_sL360BusinessProcess = WorkflowExpression.Compile(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            var __workflow_sL360BusinessTransaction = WorkflowExpression.Compile(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            var __workflow_sL360CurrentStage = WorkflowExpression.Compile(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            var __workflow_sL360StageActivityId = WorkflowExpression.Compile(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ArchiveActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(__workflow_sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(__workflow_sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(__workflow_sL360CurrentStage);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(__workflow_sL360StageActivityId);
                var body = new JObject();
                var bodypropCount = 0;
                var messageBodyObject = new JObject();
                var messageBodyObjectpropCount = 0;
                if (messageBodyObjectpropCount > 0)
                {
                    body["MessageBody"] = messageBodyObject;
                    bodypropCount++;
                }

                var messageHeaderObject = new JObject();
                var messageHeaderObjectpropCount = 0;
                if (messageHeaderObjectpropCount > 0)
                {
                    body["MessageHeader"] = messageHeaderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LogExceptionActivity(Expression<Func<string>> sL360StageActivityId, Expression<Func<string>> sL360ExceptionMessage, Expression<Func<string>> sL360ExceptionCode, Expression<Func<string>> sL360BusinessProcess)
        {
            var __workflow_sL360StageActivityId = WorkflowExpression.Compile(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            var __workflow_sL360ExceptionMessage = WorkflowExpression.Compile(sL360ExceptionMessage, nameof(sL360ExceptionMessage), required: true);
            var __workflow_sL360ExceptionCode = WorkflowExpression.Compile(sL360ExceptionCode, nameof(sL360ExceptionCode), required: true);
            var __workflow_sL360BusinessProcess = WorkflowExpression.Compile(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/LogExceptionActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(__workflow_sL360StageActivityId);
                callPayload.Headers["SL360-ExceptionMessage"] = ExpressionConverter.Convert(__workflow_sL360ExceptionMessage);
                callPayload.Headers["SL360-ExceptionCode"] = ExpressionConverter.Convert(__workflow_sL360ExceptionCode);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(__workflow_sL360BusinessProcess);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IBodyWorkflowAction<StartActivityResponse, ApiConnectionActionConfiguration> StartActivity(Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<string>> sL360MainActivityId = null, Expression<Func<string>> sL360PreviousStage = null, Expression<Func<sL360ArchiveMessageInput>> sL360ArchiveMessage = null, Expression<Func<string>> sL360BatchId = null)
        {
            var __workflow_sL360BusinessProcess = WorkflowExpression.Compile(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            var __workflow_sL360BusinessTransaction = WorkflowExpression.Compile(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            var __workflow_sL360CurrentStage = WorkflowExpression.Compile(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            var __workflow_sL360MainActivityId = WorkflowExpression.Compile(sL360MainActivityId, nameof(sL360MainActivityId), required: false);
            var __workflow_sL360PreviousStage = WorkflowExpression.Compile(sL360PreviousStage, nameof(sL360PreviousStage), required: false);
            var __workflow_sL360ArchiveMessage = WorkflowExpression.Compile(sL360ArchiveMessage, nameof(sL360ArchiveMessage), required: false);
            var __workflow_sL360BatchId = WorkflowExpression.Compile(sL360BatchId, nameof(sL360BatchId), required: false);
            return new DeferredBodyAction<StartActivityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/StartActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(__workflow_sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(__workflow_sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(__workflow_sL360CurrentStage);
                if (__workflow_sL360MainActivityId != null)
                    callPayload.Headers["SL360-MainActivityId"] = ExpressionConverter.Convert(__workflow_sL360MainActivityId);
                if (__workflow_sL360PreviousStage != null)
                    callPayload.Headers["SL360-PreviousStage"] = ExpressionConverter.Convert(__workflow_sL360PreviousStage);
                if (__workflow_sL360ArchiveMessage != null)
                    callPayload.Headers["SL360-ArchiveMessage"] = ExpressionConverter.Convert(__workflow_sL360ArchiveMessage);
                if (__workflow_sL360BatchId != null)
                    callPayload.Headers["SL360-BatchId"] = ExpressionConverter.Convert(__workflow_sL360BatchId);
                var body = new JObject();
                var bodypropCount = 0;
                var messageBodyObject = new JObject();
                var messageBodyObjectpropCount = 0;
                if (messageBodyObjectpropCount > 0)
                {
                    body["MessageBody"] = messageBodyObject;
                    bodypropCount++;
                }

                var messageHeaderObject = new JObject();
                var messageHeaderObjectpropCount = 0;
                if (messageHeaderObjectpropCount > 0)
                {
                    body["MessageHeader"] = messageHeaderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StartActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateActivity(Expression<Func<string>> sL360MainActivityId, Expression<Func<string>> sL360StageActivityId, Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<sL360StatusInput>> sL360Status = null, Expression<Func<sL360ArchiveMessageInput>> sL360ArchiveMessage = null)
        {
            var __workflow_sL360MainActivityId = WorkflowExpression.Compile(sL360MainActivityId, nameof(sL360MainActivityId), required: true);
            var __workflow_sL360StageActivityId = WorkflowExpression.Compile(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            var __workflow_sL360BusinessProcess = WorkflowExpression.Compile(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            var __workflow_sL360BusinessTransaction = WorkflowExpression.Compile(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            var __workflow_sL360CurrentStage = WorkflowExpression.Compile(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            var __workflow_sL360Status = WorkflowExpression.Compile(sL360Status, nameof(sL360Status), required: false);
            var __workflow_sL360ArchiveMessage = WorkflowExpression.Compile(sL360ArchiveMessage, nameof(sL360ArchiveMessage), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-MainActivityId"] = ExpressionConverter.Convert(__workflow_sL360MainActivityId);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(__workflow_sL360StageActivityId);
                callPayload.Headers["SL360-Status"] = Convert.ToString("Success");
                if (__workflow_sL360Status != null)
                    callPayload.Headers["SL360-Status"] = ExpressionConverter.Convert(__workflow_sL360Status);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(__workflow_sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(__workflow_sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(__workflow_sL360CurrentStage);
                if (__workflow_sL360ArchiveMessage != null)
                    callPayload.Headers["SL360-ArchiveMessage"] = ExpressionConverter.Convert(__workflow_sL360ArchiveMessage);
                var body = new JObject();
                var bodypropCount = 0;
                var messageBodyObject = new JObject();
                var messageBodyObjectpropCount = 0;
                if (messageBodyObjectpropCount > 0)
                {
                    body["MessageBody"] = messageBodyObject;
                    bodypropCount++;
                }

                var messageHeaderObject = new JObject();
                var messageHeaderObjectpropCount = 0;
                if (messageHeaderObjectpropCount > 0)
                {
                    body["MessageHeader"] = messageHeaderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Serverless360Triggers([ConnectionName] string connectionId)
    {
    }

    public class StartActivityResponse
    {
        public string MainActivityId { get; set; }
        public string StageActivityId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sL360ArchiveMessageInput
    {
        True,
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sL360StatusInput
    {
        Success,
        Failure,
        InProgress
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Serverless360;

    public partial class WorkflowManagedActions
    {
        public Serverless360Actions Serverless360(string connectionId) => new Serverless360Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Serverless360Triggers Serverless360(string connectionId) => new Serverless360Triggers(connectionId);
    }
}
