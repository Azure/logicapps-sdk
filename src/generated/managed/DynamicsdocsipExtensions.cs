//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsdocsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsdocsip")]
        public IBodyWorkflowAction<CompileTemplateResponse, ApiConnectionActionConfiguration> CompileTemplate(Expression<Func<string>> templateToken, Expression<Func<string>> docDeliveryType = null, Expression<Func<int>> docUrlExpiresIn = null, Expression<Func<string>> latexCompiler = null, Expression<Func<int>> latexRuns = null, Expression<Func<string>> mainFileName = null, Expression<Func<string>> docFileName = null, Expression<Func<string>> encryptType = null, Expression<Func<object>> body = null)
        {
            var __workflow_templateToken = WorkflowExpression.Compile(templateToken, nameof(templateToken), required: true);
            var __workflow_docDeliveryType = WorkflowExpression.Compile(docDeliveryType, nameof(docDeliveryType), required: false);
            var __workflow_docUrlExpiresIn = WorkflowExpression.Compile(docUrlExpiresIn, nameof(docUrlExpiresIn), required: false);
            var __workflow_latexCompiler = WorkflowExpression.Compile(latexCompiler, nameof(latexCompiler), required: false);
            var __workflow_latexRuns = WorkflowExpression.Compile(latexRuns, nameof(latexRuns), required: false);
            var __workflow_mainFileName = WorkflowExpression.Compile(mainFileName, nameof(mainFileName), required: false);
            var __workflow_docFileName = WorkflowExpression.Compile(docFileName, nameof(docFileName), required: false);
            var __workflow_encryptType = WorkflowExpression.Compile(encryptType, nameof(encryptType), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CompileTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templates/{0}/compile", __workflow_templateToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["doc-delivery-type"] = Convert.ToString("url");
                if (__workflow_docDeliveryType != null)
                    callPayload.Queries["doc-delivery-type"] = ExpressionConverter.Convert(__workflow_docDeliveryType);
                if (__workflow_docUrlExpiresIn != null)
                    callPayload.Queries["doc-url-expires-in"] = ExpressionConverter.Convert(__workflow_docUrlExpiresIn);
                callPayload.Queries["latex-compiler"] = Convert.ToString("pdflatex");
                if (__workflow_latexCompiler != null)
                    callPayload.Queries["latex-compiler"] = ExpressionConverter.Convert(__workflow_latexCompiler);
                callPayload.Queries["latex-runs"] = Convert.ToString(1);
                if (__workflow_latexRuns != null)
                    callPayload.Queries["latex-runs"] = ExpressionConverter.Convert(__workflow_latexRuns);
                if (__workflow_mainFileName != null)
                    callPayload.Queries["main-file-name"] = ExpressionConverter.Convert(__workflow_mainFileName);
                if (__workflow_docFileName != null)
                    callPayload.Queries["doc-file-name"] = ExpressionConverter.Convert(__workflow_docFileName);
                callPayload.Queries["encrypt-type"] = Convert.ToString("na");
                if (__workflow_encryptType != null)
                    callPayload.Queries["encrypt-type"] = ExpressionConverter.Convert(__workflow_encryptType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompileTemplateResponse>(callPayload);
            });
        }
    }

    public class DynamicsdocsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompileTemplateResponse
    {
        [JsonProperty("documentStatusUrl")]
        public string DocumentStatusUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip;

    public partial class WorkflowManagedActions
    {
        public DynamicsdocsipActions Dynamicsdocsip(string connectionId) => new DynamicsdocsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicsdocsipTriggers Dynamicsdocsip(string connectionId) => new DynamicsdocsipTriggers(connectionId);
    }
}