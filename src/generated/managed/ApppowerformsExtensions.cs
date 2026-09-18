//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apppowerforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApppowerformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddForm([WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyformDescription = null, [WorkflowExpression] Func<string> bodythankYouText = null)
        {
            var apiCallPath = "/AddNewForm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["formTitle"] = ExpressionConverter.ConvertO(bodyformName);
            if (bodyformDescription != null)
            {
                body["welcomeText"] = ExpressionConverter.ConvertO(bodyformDescription);
                bodypropCount++;
            }

            if (bodythankYouText != null)
            {
                body["thankYouText"] = ExpressionConverter.ConvertO(bodythankYouText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddFormField([WorkflowExpression] Func<string> bodyformID, [WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyfieldName, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<object> bodyfieldConfiguration = null)
        {
            var apiCallPath = "/AddFormField";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["instanceId"] = ExpressionConverter.ConvertO(bodyformID);
            bodypropCount++;
            body["formName"] = ExpressionConverter.ConvertO(bodyformName);
            bodypropCount++;
            body["fieldName"] = ExpressionConverter.ConvertO(bodyfieldName);
            bodypropCount++;
            body["fieldType"] = ExpressionConverter.ConvertO(bodyfieldType);
            if (bodyfieldConfiguration != null)
            {
                body["fieldConfiguration"] = ExpressionConverter.ConvertO(bodyfieldConfiguration);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycard, [WorkflowExpression] Func<string> bodycardAfterSubmit = null)
        {
            var apiCallPath = "/AddAdaptiveCard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["card"] = ExpressionConverter.ConvertO(bodycard);
            if (bodycardAfterSubmit != null)
            {
                body["cardAfterSubmit"] = ExpressionConverter.ConvertO(bodycardAfterSubmit);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> GetCardResponse([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> instanceId, [WorkflowExpression] Func<string> name)
        {
            var apiCallPath = String.Format("/GetCardResponse/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> instanceId)
        {
            var apiCallPath = String.Format("/GetFormAdaptiveCardJson/{0}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> name, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/TriggerGetCardResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["timestamp"] = Convert.ToString("2021-12-31");
            return new ApiConnectionTrigger<TriggerGetCardResponseResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class TriggerGetCardResponseResponse
    {
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("submissions")]
        public TriggerGetCardResponseResponseSubmissionsTypeItem[] Submissions { get; set; }
    }

    public class TriggerGetCardResponseResponseSubmissionsTypeItem
    {
        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("formId")]
        public string FormID { get; set; }

        [JsonProperty("submitted")]
        public string Submitted { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apppowerforms;

    public partial class WorkflowManagedActions
    {
        public ApppowerformsActions Apppowerforms(string connectionId) => new ApppowerformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApppowerformsTriggers Apppowerforms(string connectionId) => new ApppowerformsTriggers(connectionId);
    }
}