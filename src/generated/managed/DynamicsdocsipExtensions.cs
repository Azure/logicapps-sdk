//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DynamicsdocsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsdocsip")]
        public IBodyWorkflowAction<CompileTemplateResponse> CompileTemplate(Expression<Func<string>> templateToken, Expression<Func<string>> docDeliveryType = null, Expression<Func<int>> docUrlExpiresIn = null, Expression<Func<string>> latexCompiler = null, Expression<Func<int>> latexRuns = null, Expression<Func<string>> mainFileName = null, Expression<Func<string>> docFileName = null, Expression<Func<string>> encryptType = null)
        {
            var __workflow_templateToken = templateToken == null ? null : WorkflowExpression.Compile(templateToken);
            WorkflowExpression.Validate(__workflow_templateToken, nameof(templateToken), required: true);
            var __workflow_docDeliveryType = docDeliveryType == null ? null : WorkflowExpression.Compile(docDeliveryType);
            WorkflowExpression.Validate(__workflow_docDeliveryType, nameof(docDeliveryType), required: false);
            var __workflow_docUrlExpiresIn = docUrlExpiresIn == null ? null : WorkflowExpression.Compile(docUrlExpiresIn);
            WorkflowExpression.Validate(__workflow_docUrlExpiresIn, nameof(docUrlExpiresIn), required: false);
            var __workflow_latexCompiler = latexCompiler == null ? null : WorkflowExpression.Compile(latexCompiler);
            WorkflowExpression.Validate(__workflow_latexCompiler, nameof(latexCompiler), required: false);
            var __workflow_latexRuns = latexRuns == null ? null : WorkflowExpression.Compile(latexRuns);
            WorkflowExpression.Validate(__workflow_latexRuns, nameof(latexRuns), required: false);
            var __workflow_mainFileName = mainFileName == null ? null : WorkflowExpression.Compile(mainFileName);
            WorkflowExpression.Validate(__workflow_mainFileName, nameof(mainFileName), required: false);
            var __workflow_docFileName = docFileName == null ? null : WorkflowExpression.Compile(docFileName);
            WorkflowExpression.Validate(__workflow_docFileName, nameof(docFileName), required: false);
            var __workflow_encryptType = encryptType == null ? null : WorkflowExpression.Compile(encryptType);
            WorkflowExpression.Validate(__workflow_encryptType, nameof(encryptType), required: false);
            return new DeferredBodyAction<CompileTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templates/{0}/compile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateToken, 1));
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
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
