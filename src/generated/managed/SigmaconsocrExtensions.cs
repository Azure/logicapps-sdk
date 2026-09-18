//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sigmaconsocr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigmaconsocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ProcessjobResponse> Processjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyprocess, [WorkflowExpression] Func<string> bodyaction, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            var apiCallPath = "/api/job/process";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Process"] = ExpressionConverter.ConvertO(bodyprocess);
            bodypropCount++;
            body["Action"] = ExpressionConverter.ConvertO(bodyaction);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodycustomerCode);
            if (bodywaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodywaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProcessjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ConsolidationjobResponse> Consolidationjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyconsoCode, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            var apiCallPath = "/api/job/consolidation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ConsoCode"] = ExpressionConverter.ConvertO(bodyconsoCode);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodycustomerCode);
            if (bodywaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodywaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConsolidationjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ScheduledjobResponse> Scheduledjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyjobScheduleName, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            var apiCallPath = "/api/job/scheduledjob";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["JobScheduleName"] = ExpressionConverter.ConvertO(bodyjobScheduleName);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodycustomerCode);
            if (bodywaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodywaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ScheduledjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ImportFileResponse> ImportFile([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyimportStructureCode, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<string> bodybase64File, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            var apiCallPath = "/api/hub/import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ImportStructureCode"] = ExpressionConverter.ConvertO(bodyimportStructureCode);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodycustomerCode);
            bodypropCount++;
            body["Base64File"] = ExpressionConverter.ConvertO(bodybase64File);
            if (bodywaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodywaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ImportFileResponse>(callPayload);
        }
    }

    public class SigmaconsocrTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProcessjobResponse
    {
        public string Message { get; set; }
    }

    public class ConsolidationjobResponse
    {
        public string Message { get; set; }
    }

    public class ScheduledjobResponse
    {
        public string Message { get; set; }
    }

    public class ImportFileResponse
    {
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sigmaconsocr;

    public partial class WorkflowManagedActions
    {
        public SigmaconsocrActions Sigmaconsocr(string connectionId) => new SigmaconsocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigmaconsocrTriggers Sigmaconsocr(string connectionId) => new SigmaconsocrTriggers(connectionId);
    }
}