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
        public IWorkflowAction ConvertHTMLToPDF([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodyhtmlBody = null, [WorkflowExpression] Func<string> bodycipher = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodyhtmlBody, nameof(bodyhtmlBody), required: false);
            SourceExpression.Validate(bodycipher, nameof(bodycipher), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyhtmlBody != null)
                {
                    if (bodyhtmlBody != null)
                    {
                        body["HtmlBody"] = SourceExpressionConverter.ConvertToken(bodyhtmlBody);
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
                    body["Cipher"] = SourceExpressionConverter.ConvertToken(bodycipher);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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