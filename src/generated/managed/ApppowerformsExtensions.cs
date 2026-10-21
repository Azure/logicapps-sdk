//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apppowerforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApppowerformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddForm(Expression<Func<string>> bodyformName, Expression<Func<string>> bodyformDescription = null, Expression<Func<string>> bodythankYouText = null)
        {
            var __workflow_bodyformName = WorkflowExpression.Compile(bodyformName, nameof(bodyformName), required: true);
            var __workflow_bodyformDescription = WorkflowExpression.Compile(bodyformDescription, nameof(bodyformDescription), required: false);
            var __workflow_bodythankYouText = WorkflowExpression.Compile(bodythankYouText, nameof(bodythankYouText), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/AddNewForm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["formTitle"] = ExpressionConverter.ConvertO(__workflow_bodyformName);
                if (__workflow_bodyformDescription != null)
                {
                    body["welcomeText"] = ExpressionConverter.ConvertO(__workflow_bodyformDescription);
                    bodypropCount++;
                }

                if (__workflow_bodythankYouText != null)
                {
                    body["thankYouText"] = ExpressionConverter.ConvertO(__workflow_bodythankYouText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddFormField(Expression<Func<string>> bodyformID, Expression<Func<string>> bodyformName, Expression<Func<string>> bodyfieldName, Expression<Func<string>> bodyfieldType, Expression<Func<object>> bodyfieldConfiguration = null)
        {
            var __workflow_bodyformID = WorkflowExpression.Compile(bodyformID, nameof(bodyformID), required: true);
            var __workflow_bodyformName = WorkflowExpression.Compile(bodyformName, nameof(bodyformName), required: true);
            var __workflow_bodyfieldName = WorkflowExpression.Compile(bodyfieldName, nameof(bodyfieldName), required: true);
            var __workflow_bodyfieldType = WorkflowExpression.Compile(bodyfieldType, nameof(bodyfieldType), required: true);
            var __workflow_bodyfieldConfiguration = WorkflowExpression.Compile(bodyfieldConfiguration, nameof(bodyfieldConfiguration), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/AddFormField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["instanceId"] = ExpressionConverter.ConvertO(__workflow_bodyformID);
                bodypropCount++;
                body["formName"] = ExpressionConverter.ConvertO(__workflow_bodyformName);
                bodypropCount++;
                body["fieldName"] = ExpressionConverter.ConvertO(__workflow_bodyfieldName);
                bodypropCount++;
                body["fieldType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldType);
                if (__workflow_bodyfieldConfiguration != null)
                {
                    body["fieldConfiguration"] = ExpressionConverter.ConvertO(__workflow_bodyfieldConfiguration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard(Expression<Func<string>> bodyname, Expression<Func<string>> bodycard, Expression<Func<string>> bodycardAfterSubmit = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycard = WorkflowExpression.Compile(bodycard, nameof(bodycard), required: true);
            var __workflow_bodycardAfterSubmit = WorkflowExpression.Compile(bodycardAfterSubmit, nameof(bodycardAfterSubmit), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/AddAdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["card"] = ExpressionConverter.ConvertO(__workflow_bodycard);
                if (__workflow_bodycardAfterSubmit != null)
                {
                    body["cardAfterSubmit"] = ExpressionConverter.ConvertO(__workflow_bodycardAfterSubmit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> GetCardResponse(Expression<Func<string>> instanceId, Expression<Func<string>> name)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/GetCardResponse/{0}/{1}", __workflow_instanceId.WithUrlEncoding(1), __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson(Expression<Func<string>> instanceId)
        {
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/GetFormAdaptiveCardJson/{0}", __workflow_instanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse(Expression<Func<string>> name, FlowRecurrence recurrence = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyTrigger<TriggerGetCardResponseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/TriggerGetCardResponse/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timestamp"] = Convert.ToString("2021-12-31");
                return new ApiConnectionTrigger<TriggerGetCardResponseResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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
