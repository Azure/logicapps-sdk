//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linemessageip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinemessageipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linemessageip")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IWorkflowAction SendMessage([WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<bodymessagesInputItem[]> bodymessages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linemessageip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMessage(WorkflowExpression<string> bodyto = null, WorkflowExpression<bodymessagesInputItem[]> bodymessages = null)
        {
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodymessages, nameof(bodymessages), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/bot/message/push";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                if (bodymessages != null)
                {
                    body["messages"] = ExpressionConverter.ConvertO(bodymessages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LinemessageipTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodymessagesInputItem
    {
        [JsonProperty("type")]
        public bodymessagesInputItemTypeType Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("stickerId")]
        public string StickerId { get; set; }

        [JsonProperty("originalContentUrl")]
        public string OriginalContentUrl { get; set; }

        [JsonProperty("previewImageUrl")]
        public string PreviewImageUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymessagesInputItemTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "sticker")]
        Sticker,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "location")]
        Location
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linemessageip;

    public partial class WorkflowManagedActions
    {
        public LinemessageipActions Linemessageip(string connectionId) => new LinemessageipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LinemessageipTriggers Linemessageip(string connectionId) => new LinemessageipTriggers(connectionId);
    }
}