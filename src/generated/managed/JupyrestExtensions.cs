//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jupyrest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JupyrestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<NotebookResponse, ApiConnectionActionConfiguration> GetNotebookExecution(Expression<Func<string>> executionId, Expression<Func<bool>> output, Expression<Func<bool>> html, Expression<Func<bool>> report = null)
        {
            var __workflow_executionId = WorkflowExpression.Compile(executionId, nameof(executionId), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: true);
            var __workflow_html = WorkflowExpression.Compile(html, nameof(html), required: true);
            var __workflow_report = WorkflowExpression.Compile(report, nameof(report), required: false);
            return new DeferredBodyAction<NotebookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/NotebookExecutions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["executionId"] = ExpressionConverter.Convert(__workflow_executionId);
                callPayload.Queries["disableRedirect"] = Convert.ToString(true);
                callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                callPayload.Queries["html"] = ExpressionConverter.Convert(__workflow_html);
                callPayload.Queries["report"] = Convert.ToString(false);
                if (__workflow_report != null)
                    callPayload.Queries["report"] = ExpressionConverter.Convert(__workflow_report);
                return new ApiConnectionAction<NotebookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<NotebookResponse, ApiConnectionActionConfiguration> NotebookExecution(Expression<Func<NotebookExecutionInput>> parameters, Expression<Func<bool>> report = null)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            var __workflow_report = WorkflowExpression.Compile(report, nameof(report), required: false);
            return new DeferredBodyAction<NotebookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/NotebookExecutions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["disableRedirect"] = Convert.ToString(true);
                callPayload.Queries["output"] = Convert.ToString(true);
                callPayload.Queries["html"] = Convert.ToString(true);
                callPayload.Queries["report"] = Convert.ToString(false);
                if (__workflow_report != null)
                    callPayload.Queries["report"] = ExpressionConverter.Convert(__workflow_report);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<NotebookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<SynapseResponse, ApiConnectionActionConfiguration> UploadToSynapse(Expression<Func<UploadToSynapseInput>> parameters = null)
        {
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<SynapseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Synapse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parameters != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<SynapseResponse>(callPayload);
            });
        }
    }

    public class JupyrestTriggers([ConnectionName] string connectionId)
    {
    }

    public class NotebookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notebook")]
        public string Notebook { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("output")]
        public JToken[] Output { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
    }

    public class NotebookExecutionInput
    {
        [JsonProperty("notebook")]
        public string Notebook { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }
    }

    public class SynapseResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UploadToSynapseInput
    {
        [JsonProperty("notebook")]
        public string Notebook { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jupyrest;

    public partial class WorkflowManagedActions
    {
        public JupyrestActions Jupyrest(string connectionId) => new JupyrestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JupyrestTriggers Jupyrest(string connectionId) => new JupyrestTriggers(connectionId);
    }
}