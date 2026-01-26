//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flexe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlexeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction GetInboundShipmentsContainingNonPalletizedProducts(Expression<Func<string>> continuationToken, Expression<Func<string>> pageSize, Expression<Func<string>> state, Expression<Func<string>> createdAtFrom, Expression<Func<string>> createdAtTo, Expression<Func<string>> updatedAtFrom, Expression<Func<string>> updatedAtTo, Expression<Func<string>> customerUUID, Expression<Func<string>> purchaseOrder, Expression<Func<string>> reservations)
        {
            var apiCallPath = "/api/v1/shipper/dropoff/containers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
            callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(createdAtFrom);
            callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(createdAtTo);
            callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(updatedAtFrom);
            callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(updatedAtTo);
            callPayload.Queries["customerUUID"] = ExpressionConverter.Convert(customerUUID);
            callPayload.Queries["purchaseOrder"] = ExpressionConverter.Convert(purchaseOrder);
            callPayload.Queries["reservations"] = ExpressionConverter.Convert(reservations);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction RequestACountOfInventoryBySkuFromFlexe(Expression<Func<string>> reservationId = null, Expression<Func<string>> clientRequestId = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> everInUse = null, Expression<Func<string>> inUseSince = null, Expression<Func<string>> itemIds = null, Expression<Func<string>> skus = null)
        {
            var apiCallPath = "/api/v1/shipper/inventory";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (reservationId != null)
                callPayload.Queries["reservation_id"] = ExpressionConverter.Convert(reservationId);
            if (clientRequestId != null)
                callPayload.Queries["client_request_id"] = ExpressionConverter.Convert(clientRequestId);
            if (continuationToken != null)
                callPayload.Queries["continuation_token"] = ExpressionConverter.Convert(continuationToken);
            if (everInUse != null)
                callPayload.Queries["ever_in_use"] = ExpressionConverter.Convert(everInUse);
            if (inUseSince != null)
                callPayload.Queries["in_use_since"] = ExpressionConverter.Convert(inUseSince);
            if (itemIds != null)
                callPayload.Queries["item_ids[]"] = ExpressionConverter.Convert(itemIds);
            if (skus != null)
                callPayload.Queries["skus[]"] = ExpressionConverter.Convert(skus);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction UpdateExistingRetailFulfillmentOrder(Expression<Func<string>> shipmentId, Expression<Func<string>> bodydatastate = null, Expression<Func<string>> bodydatascac = null, Expression<Func<string>> bodydatabolNumber = null, Expression<Func<string>> bodymeta = null)
        {
            var apiCallPath = String.Format("/api/v2/shipper/fulfillment/retail/{0}", ExpressionConverter.ConvertWithUrlEncoding(shipmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodydatastate != null)
            {
                dataObject["state"] = ExpressionConverter.ConvertO(bodydatastate);
                dataObjectpropCount++;
            }

            if (bodydatascac != null)
            {
                dataObject["scac"] = ExpressionConverter.ConvertO(bodydatascac);
                dataObjectpropCount++;
            }

            if (bodydatabolNumber != null)
            {
                dataObject["bolNumber"] = ExpressionConverter.ConvertO(bodydatabolNumber);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            if (bodymeta != null)
            {
                body["meta"] = ExpressionConverter.ConvertO(bodymeta);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class FlexeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse> Webhook(Expression<Func<string>> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v2/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class WebhookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signingKey")]
        public string SigningKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flexe;

    public partial class WorkflowManagedActions
    {
        public FlexeActions Flexe(string connectionId) => new FlexeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlexeTriggers Flexe(string connectionId) => new FlexeTriggers(connectionId);
    }
}