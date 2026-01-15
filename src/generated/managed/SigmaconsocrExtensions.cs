//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Sigmaconsocr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigmaconsocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ProcessjobResponse> Processjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyProcess, Expression<Func<string>> bodyAction, Expression<Func<string>> bodyCustomerCode, Expression<Func<bool>> bodyWaitForResult = null)
        {
            var apiCallPath = "/api/job/process";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Process"] = ExpressionConverter.ConvertO(bodyProcess);
            bodypropCount++;
            body["Action"] = ExpressionConverter.ConvertO(bodyAction);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodyCustomerCode);
            if (bodyWaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodyWaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProcessjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ConsolidationjobResponse> Consolidationjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyConsoCode, Expression<Func<string>> bodyCustomerCode, Expression<Func<bool>> bodyWaitForResult = null)
        {
            var apiCallPath = "/api/job/consolidation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ConsoCode"] = ExpressionConverter.ConvertO(bodyConsoCode);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodyCustomerCode);
            if (bodyWaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodyWaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConsolidationjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ScheduledjobResponse> Scheduledjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyJobScheduleName, Expression<Func<string>> bodyCustomerCode, Expression<Func<bool>> bodyWaitForResult = null)
        {
            var apiCallPath = "/api/job/scheduledjob";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["JobScheduleName"] = ExpressionConverter.ConvertO(bodyJobScheduleName);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodyCustomerCode);
            if (bodyWaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodyWaitForResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ScheduledjobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ImportFileResponse> ImportFile(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyImportStructureCode, Expression<Func<string>> bodyCustomerCode, Expression<Func<string>> bodyBase64File, Expression<Func<bool>> bodyWaitForResult = null)
        {
            var apiCallPath = "/api/hub/import";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(applicationURL);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ImportStructureCode"] = ExpressionConverter.ConvertO(bodyImportStructureCode);
            bodypropCount++;
            body["CustomerCode"] = ExpressionConverter.ConvertO(bodyCustomerCode);
            bodypropCount++;
            body["Base64File"] = ExpressionConverter.ConvertO(bodyBase64File);
            if (bodyWaitForResult != null)
            {
                body["WaitForResult"] = ExpressionConverter.ConvertO(bodyWaitForResult);
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
    using Microsoft.Azure.Workflows.Sdk.Sigmaconsocr;

    public partial class WorkflowManagedActions
    {
        public SigmaconsocrActions Sigmaconsocr(string connectionId) => new SigmaconsocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigmaconsocrTriggers Sigmaconsocr(string connectionId) => new SigmaconsocrTriggers(connectionId);
    }
}