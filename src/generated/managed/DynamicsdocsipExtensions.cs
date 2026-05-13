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
        public IBodyWorkflowAction<CompileTemplateResponse> CompileTemplate(Expression<Func<string>> templateToken, Expression<Func<string>> docDeliveryType = null, Expression<Func<int>> docUrlExpiresIn = null, Expression<Func<string>> latexCompiler = null, Expression<Func<int>> latexRuns = null, Expression<Func<string>> mainFileName = null, Expression<Func<string>> docFileName = null, Expression<Func<string>> encryptType = null)
        {
            var apiCallPath = String.Format("/templates/{0}/compile", ExpressionConverter.ConvertWithUrlEncoding(templateToken, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["doc-delivery-type"] = Convert.ToString("url");
            if (docDeliveryType != null)
                callPayload.Queries["doc-delivery-type"] = ExpressionConverter.Convert(docDeliveryType);
            if (docUrlExpiresIn != null)
                callPayload.Queries["doc-url-expires-in"] = ExpressionConverter.Convert(docUrlExpiresIn);
            callPayload.Queries["latex-compiler"] = Convert.ToString("pdflatex");
            if (latexCompiler != null)
                callPayload.Queries["latex-compiler"] = ExpressionConverter.Convert(latexCompiler);
            callPayload.Queries["latex-runs"] = Convert.ToString(1);
            if (latexRuns != null)
                callPayload.Queries["latex-runs"] = ExpressionConverter.Convert(latexRuns);
            if (mainFileName != null)
                callPayload.Queries["main-file-name"] = ExpressionConverter.Convert(mainFileName);
            if (docFileName != null)
                callPayload.Queries["doc-file-name"] = ExpressionConverter.Convert(docFileName);
            callPayload.Queries["encrypt-type"] = Convert.ToString("na");
            if (encryptType != null)
                callPayload.Queries["encrypt-type"] = ExpressionConverter.Convert(encryptType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CompileTemplateResponse>(callPayload);
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