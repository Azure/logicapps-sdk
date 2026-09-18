//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Africastalkingvoice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AfricastalkingvoiceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "africastalkingvoice")]
        public IBodyWorkflowAction<CallResponse> Call([WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string[]> bodyto, [WorkflowExpression] Func<bodyactionsInputItem[]> bodyactions)
        {
            SourceExpression.Validate(bodyusername, nameof(bodyusername), required: true);
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodyactions, nameof(bodyactions), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                bodypropCount++;
                body["actions"] = SourceExpressionConverter.ConvertToken(bodyactions);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CallResponse>(BuildSourceInput);
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

    public enum bodyactionsInputItemActionTypeType
    {
        Play,
        Say
    }

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