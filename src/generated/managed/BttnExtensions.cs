//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bttn
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BttnActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnListData[]> ListBttns()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bttns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("bid,name_id");
                callPayload.Queries["filter"] = Convert.ToString("all");
                return callPayload;
            }

            return new ApiConnectionAction<BttnListData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IWorkflowAction ReturnFlowResult([WorkflowExpression] Func<string> callbackId, [WorkflowExpression] Func<callbackBodyflowResultInput> callbackBodyflowResult = null)
        {
            SourceExpression.Validate(callbackId, nameof(callbackId), required: true);
            SourceExpression.Validate(callbackBodyflowResult, nameof(callbackBodyflowResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/callback/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(callbackId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var callbackBody = new JObject();
                var callbackBodypropCount = 0;
                if (callbackBodyflowResult != null)
                {
                    callbackBody["result"] = SourceExpressionConverter.Convert(callbackBodyflowResult);
                    callbackBodypropCount++;
                }

                if (callbackBodypropCount > 0)
                {
                    callPayload.Body = callbackBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnApiInfo> GetBttnInfo([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BttnApiInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bttn")]
        public IBodyWorkflowAction<BttnApiCounter> GetBttnCounter([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/counter", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BttnApiCounter>(BuildSourceInput);
        }
    }

    public class BttnTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RegisterWebhook([WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                var webhookRequestBody = new JObject();
                var webhookRequestBodypropCount = 0;
                webhookRequestBody["url"] = "@listCallbackUrl()";
                webhookRequestBodypropCount++;
                if (webhookRequestBodypropCount > 0)
                {
                    callPayload.Body = webhookRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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