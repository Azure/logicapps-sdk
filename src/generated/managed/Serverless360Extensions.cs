//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serverless360
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Serverless360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveActivity))]
        public IWorkflowAction ArchiveActivity([WorkflowExpression] Func<string> sL360BusinessProcess, [WorkflowExpression] Func<string> sL360BusinessTransaction, [WorkflowExpression] Func<string> sL360CurrentStage, [WorkflowExpression] Func<string> sL360StageActivityId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildArchiveActivity(WorkflowValue<string> sL360BusinessProcess, WorkflowValue<string> sL360BusinessTransaction, WorkflowValue<string> sL360CurrentStage, WorkflowValue<string> sL360StageActivityId)
        {
            WorkflowValue.Validate(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            WorkflowValue.Validate(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            WorkflowValue.Validate(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            WorkflowValue.Validate(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ArchiveActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(sL360CurrentStage);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(sL360StageActivityId);
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
        [WorkflowExpressionFactory(nameof(__BuildLogExceptionActivity))]
        public IWorkflowAction LogExceptionActivity([WorkflowExpression] Func<string> sL360StageActivityId, [WorkflowExpression] Func<string> sL360ExceptionMessage, [WorkflowExpression] Func<string> sL360ExceptionCode, [WorkflowExpression] Func<string> sL360BusinessProcess)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLogExceptionActivity(WorkflowValue<string> sL360StageActivityId, WorkflowValue<string> sL360ExceptionMessage, WorkflowValue<string> sL360ExceptionCode, WorkflowValue<string> sL360BusinessProcess)
        {
            WorkflowValue.Validate(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            WorkflowValue.Validate(sL360ExceptionMessage, nameof(sL360ExceptionMessage), required: true);
            WorkflowValue.Validate(sL360ExceptionCode, nameof(sL360ExceptionCode), required: true);
            WorkflowValue.Validate(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/LogExceptionActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(sL360StageActivityId);
                callPayload.Headers["SL360-ExceptionMessage"] = ExpressionConverter.Convert(sL360ExceptionMessage);
                callPayload.Headers["SL360-ExceptionCode"] = ExpressionConverter.Convert(sL360ExceptionCode);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(sL360BusinessProcess);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        [WorkflowExpressionFactory(nameof(__BuildStartActivity))]
        public IBodyWorkflowAction<StartActivityResponse> StartActivity([WorkflowExpression] Func<string> sL360BusinessProcess, [WorkflowExpression] Func<string> sL360BusinessTransaction, [WorkflowExpression] Func<string> sL360CurrentStage, [WorkflowExpression] Func<string> sL360MainActivityId = null, [WorkflowExpression] Func<string> sL360PreviousStage = null, [WorkflowExpression] Func<sL360ArchiveMessageInput> sL360ArchiveMessage = null, [WorkflowExpression] Func<string> sL360BatchId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartActivityResponse> __BuildStartActivity(WorkflowValue<string> sL360BusinessProcess, WorkflowValue<string> sL360BusinessTransaction, WorkflowValue<string> sL360CurrentStage, WorkflowValue<string> sL360MainActivityId = null, WorkflowValue<string> sL360PreviousStage = null, WorkflowValue<sL360ArchiveMessageInput> sL360ArchiveMessage = null, WorkflowValue<string> sL360BatchId = null)
        {
            WorkflowValue.Validate(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            WorkflowValue.Validate(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            WorkflowValue.Validate(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            WorkflowValue.Validate(sL360MainActivityId, nameof(sL360MainActivityId), required: false);
            WorkflowValue.Validate(sL360PreviousStage, nameof(sL360PreviousStage), required: false);
            WorkflowValue.Validate(sL360ArchiveMessage, nameof(sL360ArchiveMessage), required: false);
            WorkflowValue.Validate(sL360BatchId, nameof(sL360BatchId), required: false);
            return new DeferredBodyAction<StartActivityResponse>(() =>
            {
                var apiCallPath = "/api/StartActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(sL360CurrentStage);
                if (sL360MainActivityId != null)
                    callPayload.Headers["SL360-MainActivityId"] = ExpressionConverter.Convert(sL360MainActivityId);
                if (sL360PreviousStage != null)
                    callPayload.Headers["SL360-PreviousStage"] = ExpressionConverter.Convert(sL360PreviousStage);
                if (sL360ArchiveMessage != null)
                    callPayload.Headers["SL360-ArchiveMessage"] = ExpressionConverter.Convert(sL360ArchiveMessage);
                if (sL360BatchId != null)
                    callPayload.Headers["SL360-BatchId"] = ExpressionConverter.Convert(sL360BatchId);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateActivity))]
        public IWorkflowAction UpdateActivity([WorkflowExpression] Func<string> sL360MainActivityId, [WorkflowExpression] Func<string> sL360StageActivityId, [WorkflowExpression] Func<string> sL360BusinessProcess, [WorkflowExpression] Func<string> sL360BusinessTransaction, [WorkflowExpression] Func<string> sL360CurrentStage, [WorkflowExpression] Func<sL360StatusInput> sL360Status = null, [WorkflowExpression] Func<sL360ArchiveMessageInput> sL360ArchiveMessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateActivity(WorkflowValue<string> sL360MainActivityId, WorkflowValue<string> sL360StageActivityId, WorkflowValue<string> sL360BusinessProcess, WorkflowValue<string> sL360BusinessTransaction, WorkflowValue<string> sL360CurrentStage, WorkflowValue<sL360StatusInput> sL360Status = null, WorkflowValue<sL360ArchiveMessageInput> sL360ArchiveMessage = null)
        {
            WorkflowValue.Validate(sL360MainActivityId, nameof(sL360MainActivityId), required: true);
            WorkflowValue.Validate(sL360StageActivityId, nameof(sL360StageActivityId), required: true);
            WorkflowValue.Validate(sL360BusinessProcess, nameof(sL360BusinessProcess), required: true);
            WorkflowValue.Validate(sL360BusinessTransaction, nameof(sL360BusinessTransaction), required: true);
            WorkflowValue.Validate(sL360CurrentStage, nameof(sL360CurrentStage), required: true);
            WorkflowValue.Validate(sL360Status, nameof(sL360Status), required: false);
            WorkflowValue.Validate(sL360ArchiveMessage, nameof(sL360ArchiveMessage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/UpdateActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["SL360-MainActivityId"] = ExpressionConverter.Convert(sL360MainActivityId);
                callPayload.Headers["SL360-StageActivityId"] = ExpressionConverter.Convert(sL360StageActivityId);
                callPayload.Headers["SL360-Status"] = Convert.ToString("Success");
                if (sL360Status != null)
                    callPayload.Headers["SL360-Status"] = ExpressionConverter.Convert(sL360Status);
                callPayload.Headers["SL360-BusinessProcess"] = ExpressionConverter.Convert(sL360BusinessProcess);
                callPayload.Headers["SL360-BusinessTransaction"] = ExpressionConverter.Convert(sL360BusinessTransaction);
                callPayload.Headers["SL360-CurrentStage"] = ExpressionConverter.Convert(sL360CurrentStage);
                if (sL360ArchiveMessage != null)
                    callPayload.Headers["SL360-ArchiveMessage"] = ExpressionConverter.Convert(sL360ArchiveMessage);
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

    public enum sL360ArchiveMessageInput
    {
        True,
        False
    }

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
