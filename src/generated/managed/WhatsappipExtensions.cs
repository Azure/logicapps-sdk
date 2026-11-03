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
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> version, Expression<Func<int>> phoneNumberId, Expression<Func<string>> bodymessagingProduct = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodytemplatename = null, Expression<Func<string>> bodytemplatelanguagecode = null, Expression<Func<bodytemplatecomponentsInputItem[]>> bodytemplatecomponents = null)
        {
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_phoneNumberId = WorkflowExpression.Compile(phoneNumberId, nameof(phoneNumberId), required: true);
            var __workflow_bodymessagingProduct = WorkflowExpression.Compile(bodymessagingProduct, nameof(bodymessagingProduct), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodytemplatename = WorkflowExpression.Compile(bodytemplatename, nameof(bodytemplatename), required: false);
            var __workflow_bodytemplatelanguagecode = WorkflowExpression.Compile(bodytemplatelanguagecode, nameof(bodytemplatelanguagecode), required: false);
            var __workflow_bodytemplatecomponents = WorkflowExpression.Compile(bodytemplatecomponents, nameof(bodytemplatecomponents), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/messages", __workflow_version.WithUrlEncoding(1), __workflow_phoneNumberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessagingProduct != null)
                {
                    body["messaging_product"] = ExpressionConverter.ConvertO(__workflow_bodymessagingProduct);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (__workflow_bodytemplatename != null)
                {
                    templateObject["name"] = ExpressionConverter.ConvertO(__workflow_bodytemplatename);
                    templateObjectpropCount++;
                }

                var languageObject = new JObject();
                var languageObjectpropCount = 0;
                if (__workflow_bodytemplatelanguagecode != null)
                {
                    languageObject["code"] = ExpressionConverter.ConvertO(__workflow_bodytemplatelanguagecode);
                    languageObjectpropCount++;
                }

                if (languageObjectpropCount > 0)
                {
                    templateObject["language"] = languageObject;
                    templateObjectpropCount++;
                }

                if (__workflow_bodytemplatecomponents != null)
                {
                    templateObject["components"] = ExpressionConverter.ConvertO(__workflow_bodytemplatecomponents);
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
            });
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