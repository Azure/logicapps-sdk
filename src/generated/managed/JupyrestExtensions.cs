//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jupyrest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JupyrestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<NotebookResponse> GetNotebookExecution([WorkflowExpression] Func<string> executionId, [WorkflowExpression] Func<bool> output, [WorkflowExpression] Func<bool> html, [WorkflowExpression] Func<bool> report = null)
        {
            SourceExpression.Validate(executionId, nameof(executionId), required: true);
            SourceExpression.Validate(output, nameof(output), required: true);
            SourceExpression.Validate(html, nameof(html), required: true);
            SourceExpression.Validate(report, nameof(report), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/NotebookExecutions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["executionId"] = SourceExpressionConverter.ConvertO(executionId);
                callPayload.Queries["disableRedirect"] = Convert.ToString(true);
                callPayload.Queries["output"] = SourceExpressionConverter.ConvertO(output);
                callPayload.Queries["html"] = SourceExpressionConverter.ConvertO(html);
                callPayload.Queries["report"] = Convert.ToString(false);
                if (report != null)
                    callPayload.Queries["report"] = SourceExpressionConverter.ConvertO(report);
                return callPayload;
            }

            return new ApiConnectionAction<NotebookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<NotebookResponse> NotebookExecution([WorkflowExpression] Func<bool> report = null, [WorkflowExpression] Func<string> parametersnotebook = null, [WorkflowExpression] Func<object> parametersparameters = null)
        {
            SourceExpression.Validate(report, nameof(report), required: false);
            SourceExpression.Validate(parametersnotebook, nameof(parametersnotebook), required: false);
            SourceExpression.Validate(parametersparameters, nameof(parametersparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/NotebookExecutions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["disableRedirect"] = Convert.ToString(true);
                callPayload.Queries["output"] = Convert.ToString(true);
                callPayload.Queries["html"] = Convert.ToString(true);
                callPayload.Queries["report"] = Convert.ToString(false);
                if (report != null)
                    callPayload.Queries["report"] = SourceExpressionConverter.ConvertO(report);
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (parametersnotebook != null)
                {
                    parameters["notebook"] = SourceExpressionConverter.ConvertToken(parametersnotebook);
                    parameterspropCount++;
                }

                if (parametersparameters != null)
                {
                    parameters["parameters"] = SourceExpressionConverter.ConvertToken(parametersparameters);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NotebookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jupyrest")]
        public IBodyWorkflowAction<SynapseResponse> UploadToSynapse([WorkflowExpression] Func<string> parametersnotebook = null, [WorkflowExpression] Func<object> parametersparameters = null)
        {
            SourceExpression.Validate(parametersnotebook, nameof(parametersnotebook), required: false);
            SourceExpression.Validate(parametersparameters, nameof(parametersparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Synapse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (parametersnotebook != null)
                {
                    parameters["notebook"] = SourceExpressionConverter.ConvertToken(parametersnotebook);
                    parameterspropCount++;
                }

                if (parametersparameters != null)
                {
                    parameters["parameters"] = SourceExpressionConverter.ConvertToken(parametersparameters);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SynapseResponse>(BuildSourceInput);
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

    public class SynapseResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
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