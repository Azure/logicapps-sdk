//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stripe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StripeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<ProductResponse> UpdateProduct([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodycaption = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimages = null, [WorkflowExpression] Func<bool> bodyshippable = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/products/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodycaption != null)
                {
                    body["caption"] = SourceExpressionConverter.ConvertToken(bodycaption);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyimages != null)
                {
                    body["images"] = SourceExpressionConverter.ConvertToken(bodyimages);
                    bodypropCount++;
                }

                if (bodyshippable != null)
                {
                    body["shippable"] = SourceExpressionConverter.ConvertToken(bodyshippable);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProductResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<ProductResponse> CreateProduct([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodycaption = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimages = null, [WorkflowExpression] Func<bool> bodyshippable = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodycaption != null)
                {
                    body["caption"] = SourceExpressionConverter.ConvertToken(bodycaption);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyimages != null)
                {
                    body["images"] = SourceExpressionConverter.ConvertToken(bodyimages);
                    bodypropCount++;
                }

                if (bodyshippable != null)
                {
                    body["shippable"] = SourceExpressionConverter.ConvertToken(bodyshippable);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProductResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<CustomerResponse> GetCustomer([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<CustomerResponse> UpdateCustomer([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<CustomerResponse> CreateCustomer([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/customers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerResponse>(BuildSourceInput);
        }
    }

    public class StripeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListCustomersResponseItem[]> OnNewCustomer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1/customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListCustomersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListOrdersResponseItem[]> OnNewOrder(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1/orders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListOrdersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListChargesResponseItem[]> OnNewCharge(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1/charges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListChargesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListInvoiceItemsResponseItem[]> OnNewInvoiceItem(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/v1/invoiceitems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListInvoiceItemsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ProductResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shippable")]
        public bool Shippable { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class CustomerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account_balance")]
        public int AccountBalance { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Discount
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("coupon")]
        public Coupon Coupon { get; set; }
    }

    public class Coupon
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("percent_off")]
        public double PercentOff { get; set; }

        [JsonProperty("amount_off")]
        public double AmountOff { get; set; }
    }

    public class ListCustomersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account_balance")]
        public int AccountBalance { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("delinquent")]
        public bool Delinquent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ListOrdersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_returned")]
        public int AmountReturned { get; set; }

        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("selected_shipping_method")]
        public string SelectedShippingMethod { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class ListChargesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }

        [JsonProperty("captured")]
        public bool Captured { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("outcome")]
        public ListChargesResponseItemOutcomeType Outcome { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ListChargesResponseItemOutcomeType
    {
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }

        [JsonProperty("seller_message")]
        public string SellerMessage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ListInvoiceItemsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountable")]
        public bool Discountable { get; set; }

        [JsonProperty("invoice")]
        public string Invoice { get; set; }

        [JsonProperty("plan")]
        public JToken Plan { get; set; }

        [JsonProperty("proration")]
        public bool Proration { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Stripe;

    public partial class WorkflowManagedActions
    {
        public StripeActions Stripe(string connectionId) => new StripeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StripeTriggers Stripe(string connectionId) => new StripeTriggers(connectionId);
    }
}