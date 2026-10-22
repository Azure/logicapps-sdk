//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttn
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnListData[], ApiConnectionActionConfiguration> ListBttns()
        {
            var apiCallPath = "/bttns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fields"] = Convert.ToString("bid,name_id");
            callPayload.Queries["filter"] = Convert.ToString("all");
            return new ApiConnectionAction<BttnListData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnFlowResult(Expression<Func<string>> callbackId, Expression<Func<callbackBodyflowResultInput>> callbackBodyflowResult = null)
        {
            var __workflow_callbackId = WorkflowExpression.Compile(callbackId, nameof(callbackId), required: true);
            var __workflow_callbackBodyflowResult = WorkflowExpression.Compile(callbackBodyflowResult, nameof(callbackBodyflowResult), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/callback/{0}", __workflow_callbackId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var callbackBody = new JObject();
                var callbackBodypropCount = 0;
                if (__workflow_callbackBodyflowResult != null)
                {
                    callbackBody["result"] = ExpressionConverter.ConvertO(__workflow_callbackBodyflowResult);
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
        public IBodyWorkflowAction<BttnApiInfo, ApiConnectionActionConfiguration> GetBttnInfo(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BttnApiInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BttnApiInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnApiCounter, ApiConnectionActionConfiguration> GetBttnCounter(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BttnApiCounter, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/counter", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BttnApiCounter>(callPayload);
            });
        }
    }

    public class BttnTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> RegisterWebhook(Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                var webhookRequestBody = new JObject();
                var webhookRequestBodypropCount = 0;
                webhookRequestBody["url"] = "#{listCallbackUrl()}";
                webhookRequestBodypropCount++;
                if (webhookRequestBodypropCount > 0)
                {
                    callPayload.Body = webhookRequestBody;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class BttnListData
    {
        [JsonProperty("bid")]
        public int Bid { get; set; }

        [JsonProperty("name_id")]
        public string NameId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
