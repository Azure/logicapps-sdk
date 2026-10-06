//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Whatsappip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WhatsappipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whatsappip")]
        public IWorkflowAction SendMessage([WorkflowExpression] Func<string> version, [WorkflowExpression] Func<int> phoneNumberId, [WorkflowExpression] Func<string> bodymessagingProduct = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodytemplatename = null, [WorkflowExpression] Func<string> bodytemplatelanguagecode = null, [WorkflowExpression] Func<bodytemplatecomponentsInputItem[]> bodytemplatecomponents = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(phoneNumberId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessagingProduct != null)
                {
                    body["messaging_product"] = SourceExpressionConverter.ConvertToken(bodymessagingProduct);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodytemplatename != null)
                {
                    templateObject["name"] = SourceExpressionConverter.ConvertToken(bodytemplatename);
                    templateObjectpropCount++;
                }

                var languageObject = new JObject();
                var languageObjectpropCount = 0;
                if (bodytemplatelanguagecode != null)
                {
                    languageObject["code"] = SourceExpressionConverter.ConvertToken(bodytemplatelanguagecode);
                    languageObjectpropCount++;
                }

                if (languageObjectpropCount > 0)
                {
                    templateObject["language"] = languageObject;
                    templateObjectpropCount++;
                }

                if (bodytemplatecomponents != null)
                {
                    templateObject["components"] = SourceExpressionConverter.ConvertToken(bodytemplatecomponents);
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    body["template"] = templateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class WhatsappipTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodytemplatecomponentsInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parameters")]
        public bodytemplatecomponentsInputItemParametersTypeItem[] Parameters { get; set; }
    }

    public class bodytemplatecomponentsInputItemParametersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public bodytemplatecomponentsInputItemParametersTypeItemImageType Image { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodytemplatecomponentsInputItemParametersTypeItemImageType
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