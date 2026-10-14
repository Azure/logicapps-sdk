//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stripe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class StripeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<ProductResponse> UpdateProduct(Expression<Func<string>> id, Expression<Func<string>> bodyname, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodycaption = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyimages = null, Expression<Func<bool>> bodyshippable = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyactive = bodyactive == null ? null : WorkflowExpression.Compile(bodyactive);
            WorkflowExpression.Validate(__workflow_bodyactive, nameof(bodyactive), required: false);
            var __workflow_bodycaption = bodycaption == null ? null : WorkflowExpression.Compile(bodycaption);
            WorkflowExpression.Validate(__workflow_bodycaption, nameof(bodycaption), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyimages = bodyimages == null ? null : WorkflowExpression.Compile(bodyimages);
            WorkflowExpression.Validate(__workflow_bodyimages, nameof(bodyimages), required: false);
            var __workflow_bodyshippable = bodyshippable == null ? null : WorkflowExpression.Compile(bodyshippable);
            WorkflowExpression.Validate(__workflow_bodyshippable, nameof(bodyshippable), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredBodyAction<ProductResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                if (__workflow_bodycaption != null)
                {
                    body["caption"] = ExpressionConverter.ConvertO(__workflow_bodycaption);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyimages != null)
                {
                    body["images"] = ExpressionConverter.ConvertO(__workflow_bodyimages);
                    bodypropCount++;
                }

                if (__workflow_bodyshippable != null)
                {
                    body["shippable"] = ExpressionConverter.ConvertO(__workflow_bodyshippable);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
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
        public IBodyWorkflowAction<ProductResponse> CreateProduct(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyactive = null, Expression<Func<string>> bodycaption = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyimages = null, Expression<Func<bool>> bodyshippable = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: false);
            var __workflow_bodyactive = bodyactive == null ? null : WorkflowExpression.Compile(bodyactive);
            WorkflowExpression.Validate(__workflow_bodyactive, nameof(bodyactive), required: false);
            var __workflow_bodycaption = bodycaption == null ? null : WorkflowExpression.Compile(bodycaption);
            WorkflowExpression.Validate(__workflow_bodycaption, nameof(bodycaption), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyimages = bodyimages == null ? null : WorkflowExpression.Compile(bodyimages);
            WorkflowExpression.Validate(__workflow_bodyimages, nameof(bodyimages), required: false);
            var __workflow_bodyshippable = bodyshippable == null ? null : WorkflowExpression.Compile(bodyshippable);
            WorkflowExpression.Validate(__workflow_bodyshippable, nameof(bodyshippable), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredBodyAction<ProductResponse>(() =>
            {
                var apiCallPath = "/v1/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                if (__workflow_bodycaption != null)
                {
                    body["caption"] = ExpressionConverter.ConvertO(__workflow_bodycaption);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyimages != null)
                {
                    body["images"] = ExpressionConverter.ConvertO(__workflow_bodyimages);
                    bodypropCount++;
                }

                if (__workflow_bodyshippable != null)
                {
                    body["shippable"] = ExpressionConverter.ConvertO(__workflow_bodyshippable);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
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
        public IBodyWorkflowAction<CustomerResponse> GetCustomer(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stripe")]
        public IBodyWorkflowAction<CustomerResponse> UpdateCustomer(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/customers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
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
        public IBodyWorkflowAction<CustomerResponse> CreateCustomer(Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<CustomerResponse>(() =>
            {
                var apiCallPath = "/v1/customers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
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
        public IBodyWorkflowTrigger<ListCustomersResponseItem[]> OnNewCustomer(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/customers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListCustomersResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListOrdersResponseItem[]> OnNewOrder(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListOrdersResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListChargesResponseItem[]> OnNewCharge(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/charges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListChargesResponseItem[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<ListInvoiceItemsResponseItem[]> OnNewInvoiceItem(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/v1/invoiceitems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListInvoiceItemsResponseItem[]>(callPayload, recurrence: recurrence);
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
