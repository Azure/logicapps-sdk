//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StripeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProduct))]
        public IBodyWorkflowAction<ProductResponse> UpdateProduct([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodycaption = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimages = null, [WorkflowExpression] Func<bool> bodyshippable = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProductResponse> __BuildUpdateProduct(WorkflowExpression<string> id, WorkflowExpression<string> bodyname, WorkflowExpression<bool> bodyactive = null, WorkflowExpression<string> bodycaption = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyimages = null, WorkflowExpression<bool> bodyshippable = null, WorkflowExpression<string> bodyuRL = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            WorkflowExpression.Validate(bodycaption, nameof(bodycaption), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyimages, nameof(bodyimages), required: false);
            WorkflowExpression.Validate(bodyshippable, nameof(bodyshippable), required: false);
            WorkflowExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredBodyAction<ProductResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(bodyactive);
                    bodypropCount++;
                }

                if (bodycaption != null)
                {
                    body["caption"] = ExpressionConverter.ConvertO(bodycaption);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyimages != null)
                {
                    body["images"] = ExpressionConverter.ConvertO(bodyimages);
                    bodypropCount++;
                }

                if (bodyshippable != null)
                {
                    body["shippable"] = ExpressionConverter.ConvertO(bodyshippable);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProduct))]
        public IBodyWorkflowAction<ProductResponse> CreateProduct([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<string> bodycaption = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimages = null, [WorkflowExpression] Func<bool> bodyshippable = null, [WorkflowExpression] Func<string> bodyuRL = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProductResponse> __BuildCreateProduct(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyid = null, WorkflowExpression<bool> bodyactive = null, WorkflowExpression<string> bodycaption = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyimages = null, WorkflowExpression<bool> bodyshippable = null, WorkflowExpression<string> bodyuRL = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            WorkflowExpression.Validate(bodycaption, nameof(bodycaption), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyimages, nameof(bodyimages), required: false);
            WorkflowExpression.Validate(bodyshippable, nameof(bodyshippable), required: false);
            WorkflowExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredBodyAction<ProductResponse>(() =>
            {
                var apiCallPath = "/v1/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(bodyactive);
                    bodypropCount++;
                }

                if (bodycaption != null)
                {
                    body["caption"] = ExpressionConverter.ConvertO(bodycaption);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyimages != null)
                {
                    body["images"] = ExpressionConverter.ConvertO(bodyimages);
                    bodypropCount++;
                }

                if (bodyshippable != null)
                {
                    body["shippable"] = ExpressionConverter.ConvertO(bodyshippable);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [WorkflowExpressionFactory(nameof(__BuildGetCustomer))]
        public IBodyWorkflowAction<CustomerResponse> GetCustomer([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerResponse> __BuildGetCustomer(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCustomer))]
        public IBodyWorkflowAction<CustomerResponse> UpdateCustomer([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerResponse> __BuildUpdateCustomer(WorkflowExpression<string> id, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyemail = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCustomer))]
        public IBodyWorkflowAction<CustomerResponse> CreateCustomer([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerResponse> __BuildCreateCustomer(WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyemail = null)
        {
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = "/v1/customers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CustomerResponse>(callPayload);
            });
        }
    }

    public class StripeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListCustomersResponseItem[]> OnNewCustomer(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/customers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListCustomersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListOrdersResponseItem[]> OnNewOrder(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListOrdersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListChargesResponseItem[]> OnNewCharge(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/charges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListChargesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListInvoiceItemsResponseItem[]> OnNewInvoiceItem(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/invoiceitems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListInvoiceItemsResponseItem[]>(callPayload, triggerName, recurrence);
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