//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smswirelessserviceip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmswirelessserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smswirelessserviceip")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodybody, [WorkflowExpression] Func<string> bodyrecipients = null, [WorkflowExpression] Func<string> bodyconcatenation = null, [WorkflowExpression] Func<string> bodyoriginator = null, [WorkflowExpression] Func<string> bodytest = null)
        {
            var apiCallPath = "/message.php";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = ExpressionConverter.ConvertO(bodyusername);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            if (bodyrecipients != null)
            {
                body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                bodypropCount++;
            }

            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodybody);
            if (bodyconcatenation != null)
            {
                body["concatenation"] = ExpressionConverter.ConvertO(bodyconcatenation);
                bodypropCount++;
            }

            body["info"] = "\"1\"";
            bodypropCount++;
            if (bodyoriginator != null)
            {
                body["originator"] = ExpressionConverter.ConvertO(bodyoriginator);
                bodypropCount++;
            }

            if (bodytest != null)
            {
                body["test"] = ExpressionConverter.ConvertO(bodytest);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSMSResponse>(callPayload);
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