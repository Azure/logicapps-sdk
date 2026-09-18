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
        public IWorkflowAction ReturnFlowResult([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> callbackId, [WorkflowExpression] Func<callbackBodyflowResultInput> callbackBodyflowResult = null)
        {
            var apiCallPath = String.Format("/callback/{0}", ExpressionConverter.ConvertWithUrlEncoding(callbackId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnApiInfo> GetBttnInfo([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BttnApiInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnApiCounter> GetBttnCounter([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/{0}/counter", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BttnApiCounter>(callPayload);
        }
    }

    public class BttnTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RegisterWebhook([WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var webhookRequestBody = new JObject();
            var webhookRequestBodypropCount = 0;
            webhookRequestBody["url"] = "@listCallbackUrl()";
            webhookRequestBodypropCount++;
            if (webhookRequestBodypropCount > 0)
            {
                callPayload.Body = webhookRequestBody;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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