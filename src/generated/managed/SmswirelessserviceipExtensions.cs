//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smswirelessserviceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmswirelessserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smswirelessserviceip")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyrecipients = null, [WorkflowExpression] Func<string> bodyconcatenation = null, [WorkflowExpression] Func<string> bodyoriginator = null, [WorkflowExpression] Func<string> bodytest = null)
        {
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: true);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: false);
            SourceExpression.Validate(bodyconcatenation, nameof(bodyconcatenation), required: false);
            SourceExpression.Validate(bodyoriginator, nameof(bodyoriginator), required: false);
            SourceExpression.Validate(bodytest, nameof(bodytest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/message.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                if (bodyrecipients != null)
                {
                    body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                    bodypropCount++;
                }

                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                if (bodyconcatenation != null)
                {
                    body["concatenation"] = SourceExpressionConverter.ConvertToken(bodyconcatenation);
                    bodypropCount++;
                }

                body["info"] = "\"1\"";
                bodypropCount++;
                if (bodyoriginator != null)
                {
                    body["originator"] = SourceExpressionConverter.ConvertToken(bodyoriginator);
                    bodypropCount++;
                }

                if (bodytest != null)
                {
                    body["test"] = SourceExpressionConverter.ConvertToken(bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSMSResponse>(BuildSourceInput);
        }
    }

    public class SmswirelessserviceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSMSResponse
    {
        [JsonProperty("response")]
        public string Response { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smswirelessserviceip;

    public partial class WorkflowManagedActions
    {
        public SmswirelessserviceipActions Smswirelessserviceip(string connectionId) => new SmswirelessserviceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmswirelessserviceipTriggers Smswirelessserviceip(string connectionId) => new SmswirelessserviceipTriggers(connectionId);
    }
}