//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobsimsendsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobsimsendsms")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SMS(Expression<Func<SMSInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MobsimsendsmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SMSInput
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupMsg")]
        public string GroupMsg { get; set; }

        [JsonProperty("messages")]
        public SMSInputMessagesTypeItem[] Messages { get; set; }
    }

    public class SMSInputMessagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("key1")]
        public string Key1 { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobsimsendsms;

    public partial class WorkflowManagedActions
    {
        public MobsimsendsmsActions Mobsimsendsms(string connectionId) => new MobsimsendsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobsimsendsmsTriggers Mobsimsendsms(string connectionId) => new MobsimsendsmsTriggers(connectionId);
    }
}