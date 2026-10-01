//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shipstationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShipstationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstationip")]
        public IBodyWorkflowAction<StoresResponseItem[]> StoresGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stores";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StoresResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstationip")]
        public IBodyWorkflowAction<MarketplacesResponseItem[]> StoresMarketplacesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stores/marketplaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MarketplacesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstationip")]
        public IBodyWorkflowAction<RefreshStoreResponse> StoresRefreshStore([WorkflowExpression] Func<int> bodystoreId = null, [WorkflowExpression] Func<string> bodyrefreshDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/stores/refreshstore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystoreId != null)
                {
                    body["storeId"] = SourceExpressionConverter.ConvertToken(bodystoreId);
                    bodypropCount++;
                }

                if (bodyrefreshDate != null)
                {
                    body["refreshDate"] = SourceExpressionConverter.ConvertToken(bodyrefreshDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RefreshStoreResponse>(BuildSourceInput);
        }
    }

    public class ShipstationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class StoresResponseItem
    {
        [JsonProperty("storeId")]
        public int StoreId { get; set; }

        [JsonProperty("storeName")]
        public string StoreName { get; set; }

        [JsonProperty("marketplaceId")]
        public int MarketplaceId { get; set; }

        [JsonProperty("marketplaceName")]
        public string MarketplaceName { get; set; }

        [JsonProperty("accountName")]
        public JToken AccountName { get; set; }

        [JsonProperty("email")]
        public JToken Email { get; set; }

        [JsonProperty("integrationUrl")]
        public JToken IntegrationUrl { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("refreshDate")]
        public JToken RefreshDate { get; set; }

        [JsonProperty("lastRefreshAttempt")]
        public JToken LastRefreshAttempt { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("modifyDate")]
        public string ModifyDate { get; set; }

        [JsonProperty("autoRefresh")]
        public bool AutoRefresh { get; set; }
    }

    public class MarketplacesResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("marketplaceId")]
        public int MarketplaceId { get; set; }

        [JsonProperty("canRefresh")]
        public bool CanRefresh { get; set; }

        [JsonProperty("supportsCustomMappings")]
        public bool SupportsCustomMappings { get; set; }

        [JsonProperty("supportsCustomStatuses")]
        public bool SupportsCustomStatuses { get; set; }

        [JsonProperty("canConfirmShipments")]
        public bool CanConfirmShipments { get; set; }
    }

    public class RefreshStoreResponse
    {
        [JsonProperty("success")]
        public JToken Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shipstationip;

    public partial class WorkflowManagedActions
    {
        public ShipstationipActions Shipstationip(string connectionId) => new ShipstationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShipstationipTriggers Shipstationip(string connectionId) => new ShipstationipTriggers(connectionId);
    }
}