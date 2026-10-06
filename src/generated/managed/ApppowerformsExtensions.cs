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
        [WorkflowExpressionFactory(nameof(__BuildAddForm))]
        public IBodyWorkflowAction<JToken> AddForm([WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyformDescription = null, [WorkflowExpression] Func<string> bodythankYouText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAddForm(WorkflowExpression<string> bodyformName, WorkflowExpression<string> bodyformDescription = null, WorkflowExpression<string> bodythankYouText = null)
        {
            WorkflowExpression.Validate(bodyformName, nameof(bodyformName), required: true);
            WorkflowExpression.Validate(bodyformDescription, nameof(bodyformDescription), required: false);
            WorkflowExpression.Validate(bodythankYouText, nameof(bodythankYouText), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [WorkflowExpressionFactory(nameof(__BuildAddFormField))]
        public IBodyWorkflowAction<JToken> AddFormField([WorkflowExpression] Func<string> bodyformID, [WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyfieldName, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<object> bodyfieldConfiguration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAddFormField(WorkflowExpression<string> bodyformID, WorkflowExpression<string> bodyformName, WorkflowExpression<string> bodyfieldName, WorkflowExpression<string> bodyfieldType, WorkflowExpression<object> bodyfieldConfiguration = null)
        {
            WorkflowExpression.Validate(bodyformID, nameof(bodyformID), required: true);
            WorkflowExpression.Validate(bodyformName, nameof(bodyformName), required: true);
            WorkflowExpression.Validate(bodyfieldName, nameof(bodyfieldName), required: true);
            WorkflowExpression.Validate(bodyfieldType, nameof(bodyfieldType), required: true);
            WorkflowExpression.Validate(bodyfieldConfiguration, nameof(bodyfieldConfiguration), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [WorkflowExpressionFactory(nameof(__BuildAddAdaptiveCard))]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycard, [WorkflowExpression] Func<string> bodycardAfterSubmit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAddAdaptiveCard(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycard, WorkflowExpression<string> bodycardAfterSubmit = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycard, nameof(bodycard), required: true);
            WorkflowExpression.Validate(bodycardAfterSubmit, nameof(bodycardAfterSubmit), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [WorkflowExpressionFactory(nameof(__BuildGetCardResponse))]
        public IBodyWorkflowAction<JToken> GetCardResponse([WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetCardResponse(WorkflowExpression<string> instanceId, WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/GetCardResponse/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [WorkflowExpressionFactory(nameof(__BuildGetFormAdaptiveCardJson))]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson([WorkflowExpression] Func<string> instanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFormAdaptiveCardJson(WorkflowExpression<string> instanceId)
        {
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/GetFormAdaptiveCardJson/{0}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTriggerGetCardResponse))]
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse([WorkflowExpression] Func<string> name, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> __BuildTriggerGetCardResponse(WorkflowExpression<string> name, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyTrigger<TriggerGetCardResponseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/TriggerGetCardResponse/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timestamp"] = Convert.ToString("2021-12-31");
                return new ApiConnectionTrigger<TriggerGetCardResponseResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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