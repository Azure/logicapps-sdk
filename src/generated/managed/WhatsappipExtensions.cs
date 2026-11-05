//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Whatsappip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WhatsappipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whatsappip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> version, Expression<Func<int>> phoneNumberId, Expression<Func<BodyInput>> body = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_phoneNumberId = WorkflowExpression.Compile(phoneNumberId, nameof(phoneNumberId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/messages", __workflow_version.WithUrlEncoding(1), __workflow_phoneNumberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WhatsappipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BodyInput
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("template")]
        public BodyInputTemplateType Template { get; set; }
    }

    public class BodyInputTemplateType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public BodyInputTemplateTypeLanguageType Language { get; set; }

        [JsonProperty("components")]
        public BodyInputTemplateTypeComponentsTypeItem[] Components { get; set; }
    }

    public class BodyInputTemplateTypeLanguageType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputTemplateTypeComponentsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parameters")]
        public BodyInputTemplateTypeComponentsTypeItemParametersTypeItem[] Parameters { get; set; }
    }

    public class BodyInputTemplateTypeComponentsTypeItemParametersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public BodyInputTemplateTypeComponentsTypeItemParametersTypeItemImageType Image { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputTemplateTypeComponentsTypeItemParametersTypeItemImageType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Whatsappip;

    public partial class WorkflowManagedActions
    {
        public WhatsappipActions Whatsappip(string connectionId) => new WhatsappipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WhatsappipTriggers Whatsappip(string connectionId) => new WhatsappipTriggers(connectionId);
    }
}