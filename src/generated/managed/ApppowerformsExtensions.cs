//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apppowerforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ApppowerformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddForm(Expression<Func<string>> bodyformName, Expression<Func<string>> bodyformDescription = null, Expression<Func<string>> bodythankYouText = null)
        {
            var __workflow_bodyformName = bodyformName == null ? null : WorkflowExpression.Compile(bodyformName);
            WorkflowExpression.Validate(__workflow_bodyformName, nameof(bodyformName), required: true);
            var __workflow_bodyformDescription = bodyformDescription == null ? null : WorkflowExpression.Compile(bodyformDescription);
            WorkflowExpression.Validate(__workflow_bodyformDescription, nameof(bodyformDescription), required: false);
            var __workflow_bodythankYouText = bodythankYouText == null ? null : WorkflowExpression.Compile(bodythankYouText);
            WorkflowExpression.Validate(__workflow_bodythankYouText, nameof(bodythankYouText), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddFormField(Expression<Func<string>> bodyformID, Expression<Func<string>> bodyformName, Expression<Func<string>> bodyfieldName, Expression<Func<string>> bodyfieldType, Expression<Func<object>> bodyfieldConfiguration = null)
        {
            var __workflow_bodyformID = bodyformID == null ? null : WorkflowExpression.Compile(bodyformID);
            WorkflowExpression.Validate(__workflow_bodyformID, nameof(bodyformID), required: true);
            var __workflow_bodyformName = bodyformName == null ? null : WorkflowExpression.Compile(bodyformName);
            WorkflowExpression.Validate(__workflow_bodyformName, nameof(bodyformName), required: true);
            var __workflow_bodyfieldName = bodyfieldName == null ? null : WorkflowExpression.Compile(bodyfieldName);
            WorkflowExpression.Validate(__workflow_bodyfieldName, nameof(bodyfieldName), required: true);
            var __workflow_bodyfieldType = bodyfieldType == null ? null : WorkflowExpression.Compile(bodyfieldType);
            WorkflowExpression.Validate(__workflow_bodyfieldType, nameof(bodyfieldType), required: true);
            var __workflow_bodyfieldConfiguration = bodyfieldConfiguration == null ? null : WorkflowExpression.Compile(bodyfieldConfiguration);
            WorkflowExpression.Validate(__workflow_bodyfieldConfiguration, nameof(bodyfieldConfiguration), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard(Expression<Func<string>> bodyname, Expression<Func<string>> bodycard, Expression<Func<string>> bodycardAfterSubmit = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodycard = bodycard == null ? null : WorkflowExpression.Compile(bodycard);
            WorkflowExpression.Validate(__workflow_bodycard, nameof(bodycard), required: true);
            var __workflow_bodycardAfterSubmit = bodycardAfterSubmit == null ? null : WorkflowExpression.Compile(bodycardAfterSubmit);
            WorkflowExpression.Validate(__workflow_bodycardAfterSubmit, nameof(bodycardAfterSubmit), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> GetCardResponse(Expression<Func<string>> instanceId, Expression<Func<string>> name)
        {
            var __workflow_instanceId = instanceId == null ? null : WorkflowExpression.Compile(instanceId);
            WorkflowExpression.Validate(__workflow_instanceId, nameof(instanceId), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/GetCardResponse/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson(Expression<Func<string>> instanceId)
        {
            var __workflow_instanceId = instanceId == null ? null : WorkflowExpression.Compile(instanceId);
            WorkflowExpression.Validate(__workflow_instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/GetFormAdaptiveCardJson/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse(Expression<Func<string>> name, FlowRecurrence recurrence = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: true);
            return new DeferredBodyTrigger<TriggerGetCardResponseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/TriggerGetCardResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timestamp"] = Convert.ToString("2021-12-31");
                return new ApiConnectionTrigger<TriggerGetCardResponseResponse>(callPayload, recurrence: recurrence);
            });
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
