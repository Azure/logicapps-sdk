//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttn
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnListData[]> ListBttns()
        {
            var apiCallPath = "/bttns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fields"] = Convert.ToString("bid,name_id");
            callPayload.Queries["filter"] = Convert.ToString("all");
            return new ApiConnectionAction<BttnListData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        [WorkflowExpressionFactory(nameof(__BuildReturnFlowResult))]
        public IWorkflowAction ReturnFlowResult([WorkflowExpression] Func<string> callbackId, [WorkflowExpression] Func<callbackBodyflowResultInput> callbackBodyflowResult = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReturnFlowResult(WorkflowValue<string> callbackId, WorkflowValue<callbackBodyflowResultInput> callbackBodyflowResult = null)
        {
            WorkflowValue.Validate(callbackId, nameof(callbackId), required: true);
            WorkflowValue.Validate(callbackBodyflowResult, nameof(callbackBodyflowResult), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/callback/{0}", ExpressionConverter.ConvertWithUrlEncoding(callbackId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var callbackBody = new JObject();
                var callbackBodypropCount = 0;
                if (callbackBodyflowResult != null)
                {
                    callbackBody["result"] = ExpressionConverter.ConvertO(callbackBodyflowResult);
                    callbackBodypropCount++;
                }

                if (callbackBodypropCount > 0)
                {
                    callPayload.Body = callbackBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        [WorkflowExpressionFactory(nameof(__BuildGetBttnInfo))]
        public IBodyWorkflowAction<BttnApiInfo> GetBttnInfo([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BttnApiInfo> __BuildGetBttnInfo(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BttnApiInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BttnApiInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        [WorkflowExpressionFactory(nameof(__BuildGetBttnCounter))]
        public IBodyWorkflowAction<BttnApiCounter> GetBttnCounter([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BttnApiCounter> __BuildGetBttnCounter(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<BttnApiCounter>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/counter", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BttnApiCounter>(callPayload);
            });
        }
    }

    public class BttnTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildRegisterWebhook))]
        public IWorkflowTrigger RegisterWebhook([WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildRegisterWebhook(WorkflowValue<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                var webhookRequestBody = new JObject();
                var webhookRequestBodypropCount = 0;
                webhookRequestBody["url"] = "#{listCallbackUrl()}";
                webhookRequestBodypropCount++;
                if (webhookRequestBodypropCount > 0)
                {
                    callPayload.Body = webhookRequestBody;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class BttnListData
    {
        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("name_id")]
        public string NameId { get; set; }
    }

    public enum callbackBodyflowResultInput
    {
        Positive,
        Negative,
        Wait
    }

    public class BttnApiInfo
    {
        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailaddress")]
        public string Emailaddress { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class BttnApiCounter
    {
        [JsonProperty("counter")]
        public int Counter { get; set; }

        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailaddress")]
        public string Emailaddress { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bttn;

    public partial class WorkflowManagedActions
    {
        public BttnActions Bttn(string connectionId) => new BttnActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BttnTriggers Bttn(string connectionId) => new BttnTriggers(connectionId);
    }
}
