//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Htmltopdfconverter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HtmltopdfconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "htmltopdfconverter")]
        public IWorkflowAction ConvertHTMLToPDF(Expression<Func<string>> contentType = null, Expression<Func<string>> bodyhtmlBody = null, Expression<Func<string>> bodycipher = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyhtmlBody != null)
            {
                body["HtmlBody"] = ExpressionConverter.ConvertO(bodyhtmlBody);
                bodypropCount++;
            }

            if (bodycipher != null)
            {
                body["Cipher"] = ExpressionConverter.ConvertO(bodycipher);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class HtmltopdfconverterTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Htmltopdfconverter;

    public partial class WorkflowManagedActions
    {
        public HtmltopdfconverterActions Htmltopdfconverter(string connectionId) => new HtmltopdfconverterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HtmltopdfconverterTriggers Htmltopdfconverter(string connectionId) => new HtmltopdfconverterTriggers(connectionId);
    }
}