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
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> bodyusername, Expression<Func<string>> bodypassword, Expression<Func<string>> bodybody, Expression<Func<string>> bodyrecipients = null, Expression<Func<string>> bodyconcatenation = null, Expression<Func<string>> bodyoriginator = null, Expression<Func<string>> bodytest = null)
        {
            var apiCallPath = "/message.php";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
            bodypropCount++;
            body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
            if (bodyrecipients != null)
            {
                body["recipients"] = CSharpExpressionConverter.ConvertToken(bodyrecipients);
                bodypropCount++;
            }

            bodypropCount++;
            body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
            if (bodyconcatenation != null)
            {
                body["concatenation"] = CSharpExpressionConverter.ConvertToken(bodyconcatenation);
                bodypropCount++;
            }

            body["info"] = "\"1\"";
            bodypropCount++;
            if (bodyoriginator != null)
            {
                body["originator"] = CSharpExpressionConverter.ConvertToken(bodyoriginator);
                bodypropCount++;
            }

            if (bodytest != null)
            {
                body["test"] = CSharpExpressionConverter.ConvertToken(bodytest);
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