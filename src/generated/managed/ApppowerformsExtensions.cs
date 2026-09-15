//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apppowerforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApppowerformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddForm(Expression<Func<string>> bodyformName, Expression<Func<string>> bodyformDescription = null, Expression<Func<string>> bodythankYouText = null)
        {
            var apiCallPath = "/AddNewForm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["formTitle"] = CSharpExpressionConverter.ConvertToken(bodyformName);
            if (bodyformDescription != null)
            {
                body["welcomeText"] = CSharpExpressionConverter.ConvertToken(bodyformDescription);
                bodypropCount++;
            }

            if (bodythankYouText != null)
            {
                body["thankYouText"] = CSharpExpressionConverter.ConvertToken(bodythankYouText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddFormField(Expression<Func<string>> bodyformID, Expression<Func<string>> bodyformName, Expression<Func<string>> bodyfieldName, Expression<Func<string>> bodyfieldType, Expression<Func<object>> bodyfieldConfiguration = null)
        {
            var apiCallPath = "/AddFormField";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["instanceId"] = CSharpExpressionConverter.ConvertToken(bodyformID);
            bodypropCount++;
            body["formName"] = CSharpExpressionConverter.ConvertToken(bodyformName);
            bodypropCount++;
            body["fieldName"] = CSharpExpressionConverter.ConvertToken(bodyfieldName);
            bodypropCount++;
            body["fieldType"] = CSharpExpressionConverter.ConvertToken(bodyfieldType);
            if (bodyfieldConfiguration != null)
            {
                body["fieldConfiguration"] = CSharpExpressionConverter.ConvertToken(bodyfieldConfiguration);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard(Expression<Func<string>> bodyname, Expression<Func<string>> bodycard, Expression<Func<string>> bodycardAfterSubmit = null)
        {
            var apiCallPath = "/AddAdaptiveCard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["card"] = CSharpExpressionConverter.ConvertToken(bodycard);
            if (bodycardAfterSubmit != null)
            {
                body["cardAfterSubmit"] = CSharpExpressionConverter.ConvertToken(bodycardAfterSubmit);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> GetCardResponse(Expression<Func<string>> instanceId, Expression<Func<string>> name)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/GetCardResponse/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson(Expression<Func<string>> instanceId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/GetFormAdaptiveCardJson/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse(Expression<Func<string>> name, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/trigger/TriggerGetCardResponse/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
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