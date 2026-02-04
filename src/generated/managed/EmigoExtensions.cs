//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emigo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmigoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> type)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(type, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<FeedList> GetFeeds(Expression<Func<string>> endpoint)
        {
            var apiCallPath = String.Format("/datasets/{0}/feeds", ExpressionConverter.ConvertWithUrlEncoding(endpoint, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FeedList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> type, Expression<Func<string>> table)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(type, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<FeedList> GetODataItems(Expression<Func<string>> endpoint, Expression<Func<string>> feed)
        {
            var apiCallPath = String.Format("/datasets/{0}/feeds/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(endpoint, 2), ExpressionConverter.ConvertWithUrlEncoding(feed, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FeedList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<GetProductList> GetProductList(Expression<Func<string>> idList = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/Product/GetList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idList != null)
                callPayload.Queries["IdList"] = ExpressionConverter.Convert(idList);
            if (select != null)
                callPayload.Queries["Select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetProductList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<GetProduct> GetProductItem(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/Product/GetItem";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            if (select != null)
                callPayload.Queries["Select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetProduct>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<GetOperationalUnitList> GetOperationalUnitList(Expression<Func<string>> idList = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/OperationalUnit/GetList";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idList != null)
                callPayload.Queries["IdList"] = ExpressionConverter.Convert(idList);
            if (select != null)
                callPayload.Queries["Select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetOperationalUnitList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<GetOperationalUnit> GetOperationalUnitItem(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/OperationalUnit/GetItem";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            if (select != null)
                callPayload.Queries["Select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetOperationalUnit>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emigo")]
        public IBodyWorkflowAction<JToken> SendMessageOperationalUnit(Expression<Func<int>> sendMessageidOperationalUnit, Expression<Func<string>> sendMessagemessage)
        {
            var apiCallPath = "/OperationalUnit/SendMessage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sendMessage = new JObject();
            var sendMessagepropCount = 0;
            sendMessagepropCount++;
            sendMessage["IdOperationalUnit"] = ExpressionConverter.ConvertO(sendMessageidOperationalUnit);
            sendMessagepropCount++;
            sendMessage["Message"] = ExpressionConverter.ConvertO(sendMessagemessage);
            if (sendMessagepropCount > 0)
            {
                callPayload.Body = sendMessage;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class EmigoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookCreationResponse> NewODataItem(Expression<Func<string>> endpoint, Expression<Func<string>> feed, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/feeds/{1}/newItem", ExpressionConverter.ConvertWithUrlEncoding(endpoint, 2), ExpressionConverter.ConvertWithUrlEncoding(feed, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            var configObject = new JObject();
            var configObjectpropCount = 0;
            configObject["url"] = "@listCallbackUrl()";
            configObjectpropCount++;
            if (configObjectpropCount > 0)
            {
                requestBodyOfWebhook["config"] = configObject;
                requestBodyOfWebhookpropCount++;
            }

            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger<WebhookCreationResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class FeedList
    {
        [JsonProperty("value")]
        public Feed[] Value { get; set; }
    }

    public class Feed
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class GetProductList
    {
        [JsonProperty("value")]
        public GetProduct[] Value { get; set; }
    }

    public class GetProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductName2 { get; set; }
        public string ProductDescription { get; set; }
        public string ProductIndex { get; set; }
        public string ProductIndex2 { get; set; }
        public int VAT { get; set; }
        public string UoM { get; set; }
        public string UoM2 { get; set; }
        public double ConversionUoM2 { get; set; }
        public string EanCode { get; set; }
        public double Price { get; set; }
        public double MinimalPrice { get; set; }
        public double ExFactoryPrice { get; set; }
        public double ProductCost { get; set; }
        public int IsCommercial { get; set; }
        public int IsTrade { get; set; }
        public int IsListPriceOnly { get; set; }
        public int IsRefunded { get; set; }
        public int IsGift { get; set; }
        public int IsPrescription { get; set; }
        public int IsHidden { get; set; }
        public bool IsProductSet { get; set; }
        public string CombinedNomenclature { get; set; }
        public int DefinedBrandId { get; set; }
        public string DefinedBrand { get; set; }
        public int DefinedProductGroupId { get; set; }
        public string DefinedProductGroup { get; set; }
        public int DefinedProducerId { get; set; }
        public string DefinedProducer { get; set; }
        public int ProductAttribute1Id { get; set; }
        public string ProductAttribute1 { get; set; }
        public int ProductAttribute2Id { get; set; }
        public string ProductAttribute2 { get; set; }
        public int ProductAttribute3Id { get; set; }
        public string ProductAttribute3 { get; set; }
        public int ProductAttribute4Id { get; set; }
        public string ProductAttribute4 { get; set; }
        public int ProductAttribute5Id { get; set; }
        public string ProductAttribute5 { get; set; }
        public int ProductAttribute6Id { get; set; }
        public string ProductAttribute6 { get; set; }
        public int ProductAttribute7Id { get; set; }
        public string ProductAttribute7 { get; set; }
        public int ProductAttribute8Id { get; set; }
        public string ProductAttribute8 { get; set; }
        public int ProductAttribute9Id { get; set; }
        public string ProductAttribute9 { get; set; }
        public int ProductAttribute10Id { get; set; }
        public string ProductAttribute10 { get; set; }
        public int ProducerId { get; set; }
        public string Producer { get; set; }
        public string DefinedColumn1 { get; set; }
        public string DefinedColumn2 { get; set; }
        public string DefinedColumn3 { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedTime { get; set; }
    }

    public class GetOperationalUnitList
    {
        [JsonProperty("value")]
        public GetOperationalUnit[] Value { get; set; }
    }

    public class GetOperationalUnit
    {
        public int OpuId { get; set; }
        public string OpuCode { get; set; }
        public string OpuSystemCode { get; set; }
        public int OpuAttribute1Id { get; set; }
        public string OpuAttribute1 { get; set; }
        public int OpuAttribute2Id { get; set; }
        public string OpuAttribute2 { get; set; }
        public int OpuAttribute3Id { get; set; }
        public string OpuAttribute3 { get; set; }
        public int OpuAttribute4Id { get; set; }
        public string OpuAttribute4 { get; set; }
        public int OpuAttribute5Id { get; set; }
        public string OpuAttribute5 { get; set; }
        public int OpuCategory1Id { get; set; }
        public string OpuCategory1 { get; set; }
        public int OpuCategory2Id { get; set; }
        public string OpuCategory2 { get; set; }
        public int OpuCategory3Id { get; set; }
        public string OpuCategory3 { get; set; }
        public string Hierarchy { get; set; }
        public string EmigoVersion { get; set; }
        public int DistrictTypeId { get; set; }
        public string DistrictType { get; set; }
        public int LicenceTypeId { get; set; }
        public string LicenceType { get; set; }
        public int IsSagraOpu { get; set; }
        public int TimeShift { get; set; }
        public string ServerTimeZone { get; set; }
        public string UserNameAssigned { get; set; }
        public string UserDescriptionAssigned { get; set; }
        public int UserIdAssigned { get; set; }
        public string UserEmailAssigned { get; set; }
        public string UserPhoneNumberAssigned { get; set; }
        public string UserMobilePhoneNumberAssigned { get; set; }
        public int OpuASMId { get; set; }

        [JsonProperty("Id Status")]
        public int IdStatus { get; set; }
        public string OpuStatus { get; set; }
    }

    public class WebhookCreationResponse
    {
        [JsonProperty("config")]
        public WebhookCreationResponseConfigType Config { get; set; }
    }

    public class WebhookCreationResponseConfigType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emigo;

    public partial class WorkflowManagedActions
    {
        public EmigoActions Emigo(string connectionId) => new EmigoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmigoTriggers Emigo(string connectionId) => new EmigoTriggers(connectionId);
    }
}