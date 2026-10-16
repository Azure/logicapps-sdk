//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smswirelessserviceip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SmswirelessserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smswirelessserviceip")]
        public IBodyWorkflowAction<SendSMSResponse> SendSMS(Expression<Func<string>> bodyusername, Expression<Func<string>> bodypassword, Expression<Func<string>> bodybody, Expression<Func<string>> bodyrecipients = null, Expression<Func<string>> bodyconcatenation = null, Expression<Func<string>> bodyoriginator = null, Expression<Func<string>> bodytest = null)
        {
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: true);
            var __workflow_bodyrecipients = WorkflowExpression.Compile(bodyrecipients, nameof(bodyrecipients), required: false);
            var __workflow_bodyconcatenation = WorkflowExpression.Compile(bodyconcatenation, nameof(bodyconcatenation), required: false);
            var __workflow_bodyoriginator = WorkflowExpression.Compile(bodyoriginator, nameof(bodyoriginator), required: false);
            var __workflow_bodytest = WorkflowExpression.Compile(bodytest, nameof(bodytest), required: false);
            return new DeferredBodyAction<SendSMSResponse>(() =>
            {
                var apiCallPath = "/message.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                if (__workflow_bodyrecipients != null)
                {
                    body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
                    bodypropCount++;
                }

                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                if (__workflow_bodyconcatenation != null)
                {
                    body["concatenation"] = ExpressionConverter.ConvertO(__workflow_bodyconcatenation);
                    bodypropCount++;
                }

                body["info"] = "\"1\"";
                bodypropCount++;
                if (__workflow_bodyoriginator != null)
                {
                    body["originator"] = ExpressionConverter.ConvertO(__workflow_bodyoriginator);
                    bodypropCount++;
                }

                if (__workflow_bodytest != null)
                {
                    body["test"] = ExpressionConverter.ConvertO(__workflow_bodytest);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSMSResponse>(callPayload);
            });
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
