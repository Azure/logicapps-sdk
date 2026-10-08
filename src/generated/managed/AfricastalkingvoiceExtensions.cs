//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingvoice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingvoiceActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingvoice")]
        [WorkflowExpressionFactory(nameof(__BuildCall))]
        public IBodyWorkflowAction<CallResponse> Call([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<bodyactionsInputItem[]> bodyactions)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResponse> __BuildCall(WorkflowExpression<string> bodyusername, WorkflowExpression<string> bodyfrom, WorkflowExpression<string[]> bodyto, WorkflowExpression<bodyactionsInputItem[]> bodyactions)
        {
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodyactions, nameof(bodyactions), required: true);
            return new DeferredBodyAction<CallResponse>(() =>
            {
                var apiCallPath = "/call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
                body["actions"] = ExpressionConverter.ConvertO(bodyactions);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CallResponse>(callPayload);
            });
        }
    }

    public class AfricastalkingvoiceTriggers([ConnectionName] string connectionId)
    {
    }

    public class CallResponse
    {
        [JsonProperty("entries")]
        public CallResponseEntriesTypeItem[] Entries { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class CallResponseEntriesTypeItem
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class bodyactionsInputItem
    {
        [JsonProperty("actionType")]
        public bodyactionsInputItemActionTypeType ActionType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("voice")]
        public bodyactionsInputItemVoiceType Voice { get; set; }

        [JsonProperty("playBeep")]
        public bool PlayBeep { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactionsInputItemActionTypeType
    {
        Play,
        Say
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactionsInputItemVoiceType
    {
        [EnumMember(Value = "man")]
        Man,
        [EnumMember(Value = "woman")]
        Woman
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingvoice;

    public partial class WorkflowManagedActions
    {
        public AfricastalkingvoiceActions Africastalkingvoice(string connectionId) => new AfricastalkingvoiceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AfricastalkingvoiceTriggers Africastalkingvoice(string connectionId) => new AfricastalkingvoiceTriggers(connectionId);
    }
}