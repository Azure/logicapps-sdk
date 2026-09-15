//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serverless360
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Serverless360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction ArchiveActivity(Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<string>> sL360StageActivityId)
        {
            var apiCallPath = "/api/ArchiveActivity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SL360-BusinessProcess"] = CSharpExpressionConverter.ConvertO(sL360BusinessProcess);
            callPayload.Headers["SL360-BusinessTransaction"] = CSharpExpressionConverter.ConvertO(sL360BusinessTransaction);
            callPayload.Headers["SL360-CurrentStage"] = CSharpExpressionConverter.ConvertO(sL360CurrentStage);
            callPayload.Headers["SL360-StageActivityId"] = CSharpExpressionConverter.ConvertO(sL360StageActivityId);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction LogExceptionActivity(Expression<Func<string>> sL360StageActivityId, Expression<Func<string>> sL360ExceptionMessage, Expression<Func<string>> sL360ExceptionCode, Expression<Func<string>> sL360BusinessProcess)
        {
            var apiCallPath = "/api/LogExceptionActivity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SL360-StageActivityId"] = CSharpExpressionConverter.ConvertO(sL360StageActivityId);
            callPayload.Headers["SL360-ExceptionMessage"] = CSharpExpressionConverter.ConvertO(sL360ExceptionMessage);
            callPayload.Headers["SL360-ExceptionCode"] = CSharpExpressionConverter.ConvertO(sL360ExceptionCode);
            callPayload.Headers["SL360-BusinessProcess"] = CSharpExpressionConverter.ConvertO(sL360BusinessProcess);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IBodyWorkflowAction<StartActivityResponse> StartActivity(Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<string>> sL360MainActivityId = null, Expression<Func<string>> sL360PreviousStage = null, Expression<Func<sL360ArchiveMessageInput>> sL360ArchiveMessage = null, Expression<Func<string>> sL360BatchId = null)
        {
            var apiCallPath = "/api/StartActivity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SL360-BusinessProcess"] = CSharpExpressionConverter.ConvertO(sL360BusinessProcess);
            callPayload.Headers["SL360-BusinessTransaction"] = CSharpExpressionConverter.ConvertO(sL360BusinessTransaction);
            callPayload.Headers["SL360-CurrentStage"] = CSharpExpressionConverter.ConvertO(sL360CurrentStage);
            if (sL360MainActivityId != null)
                callPayload.Headers["SL360-MainActivityId"] = CSharpExpressionConverter.ConvertO(sL360MainActivityId);
            if (sL360PreviousStage != null)
                callPayload.Headers["SL360-PreviousStage"] = CSharpExpressionConverter.ConvertO(sL360PreviousStage);
            if (sL360ArchiveMessage != null)
                callPayload.Headers["SL360-ArchiveMessage"] = CSharpExpressionConverter.Convert(sL360ArchiveMessage);
            if (sL360BatchId != null)
                callPayload.Headers["SL360-BatchId"] = CSharpExpressionConverter.ConvertO(sL360BatchId);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serverless360")]
        public IWorkflowAction UpdateActivity(Expression<Func<string>> sL360MainActivityId, Expression<Func<string>> sL360StageActivityId, Expression<Func<string>> sL360BusinessProcess, Expression<Func<string>> sL360BusinessTransaction, Expression<Func<string>> sL360CurrentStage, Expression<Func<sL360StatusInput>> sL360Status = null, Expression<Func<sL360ArchiveMessageInput>> sL360ArchiveMessage = null)
        {
            var apiCallPath = "/api/UpdateActivity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["SL360-MainActivityId"] = CSharpExpressionConverter.ConvertO(sL360MainActivityId);
            callPayload.Headers["SL360-StageActivityId"] = CSharpExpressionConverter.ConvertO(sL360StageActivityId);
            callPayload.Headers["SL360-Status"] = Convert.ToString("Success");
            if (sL360Status != null)
                callPayload.Headers["SL360-Status"] = CSharpExpressionConverter.Convert(sL360Status);
            callPayload.Headers["SL360-BusinessProcess"] = CSharpExpressionConverter.ConvertO(sL360BusinessProcess);
            callPayload.Headers["SL360-BusinessTransaction"] = CSharpExpressionConverter.ConvertO(sL360BusinessTransaction);
            callPayload.Headers["SL360-CurrentStage"] = CSharpExpressionConverter.ConvertO(sL360CurrentStage);
            if (sL360ArchiveMessage != null)
                callPayload.Headers["SL360-ArchiveMessage"] = CSharpExpressionConverter.Convert(sL360ArchiveMessage);
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