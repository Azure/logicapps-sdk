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
        public IBodyWorkflowAction<JToken> AddForm([WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyformDescription = null, [WorkflowExpression] Func<string> bodythankYouText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddNewForm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["formTitle"] = SourceExpressionConverter.ConvertToken(bodyformName);
                if (bodyformDescription != null)
                {
                    body["welcomeText"] = SourceExpressionConverter.ConvertToken(bodyformDescription);
                    bodypropCount++;
                }

                if (bodythankYouText != null)
                {
                    body["thankYouText"] = SourceExpressionConverter.ConvertToken(bodythankYouText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddFormField([WorkflowExpression] Func<string> bodyformId, [WorkflowExpression] Func<string> bodyformName, [WorkflowExpression] Func<string> bodyfieldName, [WorkflowExpression] Func<string> bodyfieldType, [WorkflowExpression] Func<object> bodyfieldConfiguration = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddFormField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["instanceId"] = SourceExpressionConverter.ConvertToken(bodyformId);
                bodypropCount++;
                body["formName"] = SourceExpressionConverter.ConvertToken(bodyformName);
                bodypropCount++;
                body["fieldName"] = SourceExpressionConverter.ConvertToken(bodyfieldName);
                bodypropCount++;
                body["fieldType"] = SourceExpressionConverter.ConvertToken(bodyfieldType);
                if (bodyfieldConfiguration != null)
                {
                    body["fieldConfiguration"] = SourceExpressionConverter.ConvertToken(bodyfieldConfiguration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> AddAdaptiveCard([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycard, [WorkflowExpression] Func<string> bodycardAfterSubmit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddAdaptiveCard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["card"] = SourceExpressionConverter.ConvertToken(bodycard);
                if (bodycardAfterSubmit != null)
                {
                    body["cardAfterSubmit"] = SourceExpressionConverter.ConvertToken(bodycardAfterSubmit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<JToken> GetCardResponse([WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> name)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/GetCardResponse/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apppowerforms")]
        public IBodyWorkflowAction<string> GetFormAdaptiveCardJson([WorkflowExpression] Func<string> instanceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/GetFormAdaptiveCardJson/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class ApppowerformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerGetCardResponseResponse> TriggerGetCardResponse([WorkflowExpression] Func<string> name, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/TriggerGetCardResponse/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timestamp"] = Convert.ToString("2021-12-31");
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerGetCardResponseResponse>(BuildSourceInput, triggerName, recurrence);
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