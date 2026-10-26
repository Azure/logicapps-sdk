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
        public IBodyWorkflowAction<ProcessjobResponse, ApiConnectionActionConfiguration> Processjob(Expression<Func<string>> applicationURL, Expression<Func<ProcessjobInput>> body)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProcessjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProcessjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ConsolidationjobResponse, ApiConnectionActionConfiguration> Consolidationjob(Expression<Func<string>> applicationURL, Expression<Func<ConsolidationjobInput>> body)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConsolidationjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/consolidation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConsolidationjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ScheduledjobResponse, ApiConnectionActionConfiguration> Scheduledjob(Expression<Func<string>> applicationURL, Expression<Func<ScheduledjobInput>> body)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduledjobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/job/scheduledjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduledjobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ImportFileResponse, ApiConnectionActionConfiguration> ImportFile(Expression<Func<string>> applicationURL, Expression<Func<ImportFileInput>> body)
        {
            var __workflow_applicationURL = WorkflowExpression.Compile(applicationURL, nameof(applicationURL), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ImportFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/hub/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = ExpressionConverter.Convert(__workflow_applicationURL);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class ProcessjobInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Process { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerCode { get; set; }
        public bool? WaitForResult { get; set; }
    }

    public class ConsolidationjobResponse
    {
        public string Message { get; set; }
    }

    public class ConsolidationjobInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConsoCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerCode { get; set; }
        public bool? WaitForResult { get; set; }
    }

    public class ScheduledjobResponse
    {
        public string Message { get; set; }
    }

    public class ScheduledjobInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string JobScheduleName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerCode { get; set; }
        public bool? WaitForResult { get; set; }
    }

    public class ImportFileResponse
    {
        public string Message { get; set; }
    }

    public class ImportFileInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImportStructureCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64File { get; set; }
        public bool? WaitForResult { get; set; }
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