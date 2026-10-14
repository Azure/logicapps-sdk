//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Htmltopdfconverter
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HtmltopdfconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "htmltopdfconverter")]
        public IWorkflowAction ConvertHTMLToPDF(Expression<Func<string>> contentType = null, Expression<Func<string>> bodyhtmlBody = null, Expression<Func<string>> bodycipher = null)
        {
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            var __workflow_bodyhtmlBody = bodyhtmlBody == null ? null : WorkflowExpression.Compile(bodyhtmlBody);
            WorkflowExpression.Validate(__workflow_bodyhtmlBody, nameof(bodyhtmlBody), required: false);
            var __workflow_bodycipher = bodycipher == null ? null : WorkflowExpression.Compile(bodycipher);
            WorkflowExpression.Validate(__workflow_bodycipher, nameof(bodycipher), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyhtmlBody != null)
                {
                    if (__workflow_bodyhtmlBody != null)
                    {
                        body["HtmlBody"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBody);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["HtmlBody"] = "<html><body><h1>Hello, World!</h1></body></html>";
                    bodypropCount++;
                }

                if (__workflow_bodycipher != null)
                {
                    body["Cipher"] = ExpressionConverter.ConvertO(__workflow_bodycipher);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
