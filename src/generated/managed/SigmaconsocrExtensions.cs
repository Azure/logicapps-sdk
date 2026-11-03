//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sigmaconsocr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigmaconsocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ProcessjobResponse, ApiConnectionActionConfiguration> Processjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyprocess, Expression<Func<string>> bodyaction, Expression<Func<string>> bodycustomerCode, Expression<Func<bool>> bodywaitForResult = null)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_bodyprocess = WorkflowExpression.Compile(bodyprocess, nameof(bodyprocess), required: true);
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: true);
            var __workflow_bodycustomerCode = WorkflowExpression.Compile(bodycustomerCode, nameof(bodycustomerCode), required: true);
            var __workflow_bodywaitForResult = WorkflowExpression.Compile(bodywaitForResult, nameof(bodywaitForResult), required: false);
            return new DeferredBodyAction<ProcessjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Process"] = ExpressionConverter.ConvertO(__workflow_bodyprocess);
                bodypropCount++;
                body["Action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                bodypropCount++;
                body["CustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodycustomerCode);
                if (__workflow_bodywaitForResult != null)
                {
                    body["WaitForResult"] = ExpressionConverter.ConvertO(__workflow_bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProcessjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ConsolidationjobResponse, ApiConnectionActionConfiguration> Consolidationjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyconsoCode, Expression<Func<string>> bodycustomerCode, Expression<Func<bool>> bodywaitForResult = null)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_bodyconsoCode = WorkflowExpression.Compile(bodyconsoCode, nameof(bodyconsoCode), required: true);
            var __workflow_bodycustomerCode = WorkflowExpression.Compile(bodycustomerCode, nameof(bodycustomerCode), required: true);
            var __workflow_bodywaitForResult = WorkflowExpression.Compile(bodywaitForResult, nameof(bodywaitForResult), required: false);
            return new DeferredBodyAction<ConsolidationjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/consolidation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ConsoCode"] = ExpressionConverter.ConvertO(__workflow_bodyconsoCode);
                bodypropCount++;
                body["CustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodycustomerCode);
                if (__workflow_bodywaitForResult != null)
                {
                    body["WaitForResult"] = ExpressionConverter.ConvertO(__workflow_bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConsolidationjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ScheduledjobResponse, ApiConnectionActionConfiguration> Scheduledjob(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyjobScheduleName, Expression<Func<string>> bodycustomerCode, Expression<Func<bool>> bodywaitForResult = null)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_bodyjobScheduleName = WorkflowExpression.Compile(bodyjobScheduleName, nameof(bodyjobScheduleName), required: true);
            var __workflow_bodycustomerCode = WorkflowExpression.Compile(bodycustomerCode, nameof(bodycustomerCode), required: true);
            var __workflow_bodywaitForResult = WorkflowExpression.Compile(bodywaitForResult, nameof(bodywaitForResult), required: false);
            return new DeferredBodyAction<ScheduledjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/scheduledjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["JobScheduleName"] = ExpressionConverter.ConvertO(__workflow_bodyjobScheduleName);
                bodypropCount++;
                body["CustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodycustomerCode);
                if (__workflow_bodywaitForResult != null)
                {
                    body["WaitForResult"] = ExpressionConverter.ConvertO(__workflow_bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScheduledjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ImportFileResponse, ApiConnectionActionConfiguration> ImportFile(Expression<Func<string>> applicationURL, Expression<Func<string>> bodyimportStructureCode, Expression<Func<string>> bodycustomerCode, Expression<Func<string>> bodybase64File, Expression<Func<bool>> bodywaitForResult = null)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_bodyimportStructureCode = WorkflowExpression.Compile(bodyimportStructureCode, nameof(bodyimportStructureCode), required: true);
            var __workflow_bodycustomerCode = WorkflowExpression.Compile(bodycustomerCode, nameof(bodycustomerCode), required: true);
            var __workflow_bodybase64File = WorkflowExpression.Compile(bodybase64File, nameof(bodybase64File), required: true);
            var __workflow_bodywaitForResult = WorkflowExpression.Compile(bodywaitForResult, nameof(bodywaitForResult), required: false);
            return new DeferredBodyAction<ImportFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/hub/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ImportStructureCode"] = ExpressionConverter.ConvertO(__workflow_bodyimportStructureCode);
                bodypropCount++;
                body["CustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodycustomerCode);
                bodypropCount++;
                body["Base64File"] = ExpressionConverter.ConvertO(__workflow_bodybase64File);
                if (__workflow_bodywaitForResult != null)
                {
                    body["WaitForResult"] = ExpressionConverter.ConvertO(__workflow_bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImportFileResponse>(callPayload);
            });
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