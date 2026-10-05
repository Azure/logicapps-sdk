//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Htmltopdfconverter
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HtmltopdfconverterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "htmltopdfconverter")]
        [WorkflowExpressionFactory(nameof(__BuildConvertHTMLToPDF))]
        public IWorkflowAction ConvertHTMLToPDF([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodyhtmlBody = null, [WorkflowExpression] Func<string> bodycipher = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConvertHTMLToPDF(WorkflowValue<string> contentType = null, WorkflowValue<string> bodyhtmlBody = null, WorkflowValue<string> bodycipher = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(bodyhtmlBody, nameof(bodyhtmlBody), required: false);
            WorkflowValue.Validate(bodycipher, nameof(bodycipher), required: false);
            return new DeferredWorkflowAction(() =>
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
                    if (bodyhtmlBody != null)
                    {
                        body["HtmlBody"] = ExpressionConverter.ConvertO(bodyhtmlBody);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["HtmlBody"] = "<html><body><h1>Hello, World!</h1></body></html>";
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
