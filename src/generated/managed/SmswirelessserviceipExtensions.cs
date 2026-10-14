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
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: true);
            var __workflow_bodyrecipients = bodyrecipients == null ? null : WorkflowExpression.Compile(bodyrecipients);
            WorkflowExpression.Validate(__workflow_bodyrecipients, nameof(bodyrecipients), required: false);
            var __workflow_bodyconcatenation = bodyconcatenation == null ? null : WorkflowExpression.Compile(bodyconcatenation);
            WorkflowExpression.Validate(__workflow_bodyconcatenation, nameof(bodyconcatenation), required: false);
            var __workflow_bodyoriginator = bodyoriginator == null ? null : WorkflowExpression.Compile(bodyoriginator);
            WorkflowExpression.Validate(__workflow_bodyoriginator, nameof(bodyoriginator), required: false);
            var __workflow_bodytest = bodytest == null ? null : WorkflowExpression.Compile(bodytest);
            WorkflowExpression.Validate(__workflow_bodytest, nameof(bodytest), required: false);
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
