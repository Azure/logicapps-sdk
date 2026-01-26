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
        public IWorkflowAction SendMessage(Expression<Func<string>> version, Expression<Func<int>> phoneNumberID, Expression<Func<string>> bodymessagingProduct = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodytemplatename = null, Expression<Func<string>> bodytemplatelanguagecode = null, Expression<Func<bodytemplatecomponentsInputItem[]>> bodytemplatecomponents = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/messages", ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(phoneNumberID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessagingProduct != null)
            {
                body["messaging_product"] = ExpressionConverter.ConvertO(bodymessagingProduct);
                bodypropCount++;
            }

            if (bodyto != null)
            {
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var templateObject = new JObject();
            var templateObjectpropCount = 0;
            if (bodytemplatename != null)
            {
                templateObject["name"] = ExpressionConverter.ConvertO(bodytemplatename);
                templateObjectpropCount++;
            }

            var languageObject = new JObject();
            var languageObjectpropCount = 0;
            if (bodytemplatelanguagecode != null)
            {
                languageObject["code"] = ExpressionConverter.ConvertO(bodytemplatelanguagecode);
                languageObjectpropCount++;
            }

            if (languageObjectpropCount > 0)
            {
                templateObject["language"] = languageObject;
                templateObjectpropCount++;
            }

            if (bodytemplatecomponents != null)
            {
                templateObject["components"] = ExpressionConverter.ConvertO(bodytemplatecomponents);
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

            return new ApiConnectionAction(callPayload);
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