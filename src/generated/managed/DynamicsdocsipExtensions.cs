//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsdocsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsdocsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsdocsip")]
        public IBodyWorkflowAction<CompileTemplateResponse> CompileTemplate([WorkflowExpression] Func<string> templateToken, [WorkflowExpression] Func<string> docDeliveryType = null, [WorkflowExpression] Func<int> docUrlExpiresIn = null, [WorkflowExpression] Func<string> latexCompiler = null, [WorkflowExpression] Func<int> latexRuns = null, [WorkflowExpression] Func<string> mainFileName = null, [WorkflowExpression] Func<string> docFileName = null, [WorkflowExpression] Func<string> encryptType = null)
        {
            SourceExpression.Validate(templateToken, nameof(templateToken), required: true);
            SourceExpression.Validate(docDeliveryType, nameof(docDeliveryType), required: false);
            SourceExpression.Validate(docUrlExpiresIn, nameof(docUrlExpiresIn), required: false);
            SourceExpression.Validate(latexCompiler, nameof(latexCompiler), required: false);
            SourceExpression.Validate(latexRuns, nameof(latexRuns), required: false);
            SourceExpression.Validate(mainFileName, nameof(mainFileName), required: false);
            SourceExpression.Validate(docFileName, nameof(docFileName), required: false);
            SourceExpression.Validate(encryptType, nameof(encryptType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templates/{0}/compile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateToken, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["doc-delivery-type"] = Convert.ToString("url");
                if (docDeliveryType != null)
                    callPayload.Queries["doc-delivery-type"] = SourceExpressionConverter.ConvertO(docDeliveryType);
                if (docUrlExpiresIn != null)
                    callPayload.Queries["doc-url-expires-in"] = SourceExpressionConverter.ConvertO(docUrlExpiresIn);
                callPayload.Queries["latex-compiler"] = Convert.ToString("pdflatex");
                if (latexCompiler != null)
                    callPayload.Queries["latex-compiler"] = SourceExpressionConverter.ConvertO(latexCompiler);
                callPayload.Queries["latex-runs"] = Convert.ToString(1);
                if (latexRuns != null)
                    callPayload.Queries["latex-runs"] = SourceExpressionConverter.ConvertO(latexRuns);
                if (mainFileName != null)
                    callPayload.Queries["main-file-name"] = SourceExpressionConverter.ConvertO(mainFileName);
                if (docFileName != null)
                    callPayload.Queries["doc-file-name"] = SourceExpressionConverter.ConvertO(docFileName);
                callPayload.Queries["encrypt-type"] = Convert.ToString("na");
                if (encryptType != null)
                    callPayload.Queries["encrypt-type"] = SourceExpressionConverter.ConvertO(encryptType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompileTemplateResponse>(BuildSourceInput);
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