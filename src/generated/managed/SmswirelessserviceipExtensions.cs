//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smswirelessserviceip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmswirelessserviceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smswirelessserviceip")]
        public IBodyWorkflowAction<SendSMSResponse, ApiConnectionActionConfiguration> SendSMS(Expression<Func<SendSMSInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendSMSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/message.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class SendSMSInput
    {
        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("recipients")]
        public string Recipients { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("concatenation")]
        public string Concatenation { get; set; }

        [JsonProperty("info", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Info { get; set; } = "\"1\"";

        [JsonProperty("originator")]
        public string Originator { get; set; }

        [JsonProperty("test")]
        public string Test { get; set; }
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