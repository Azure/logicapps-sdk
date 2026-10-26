//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BulksmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bulksms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendSmsMessage(Expression<Func<bool>> autoUnicode, Expression<Func<SendSmsMessageInput>> body)
        {
            var __workflow_autoUnicode = WorkflowExpression.Compile(autoUnicode, nameof(autoUnicode), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["auto-unicode"] = ExpressionConverter.Convert(__workflow_autoUnicode);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BulksmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSmsMessageInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("userSuppliedId", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string UserSuppliedId { get; set; } = "BLKTM.GWPF.01.00.00";

        [JsonProperty("longMessageMaxParts", DefaultValueHandling = DefaultValueHandling.Include)]
        public int LongMessageMaxParts { get; set; } = 10;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bulksms;

    public partial class WorkflowManagedActions
    {
        public BulksmsActions Bulksms(string connectionId) => new BulksmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BulksmsTriggers Bulksms(string connectionId) => new BulksmsTriggers(connectionId);
    }
}