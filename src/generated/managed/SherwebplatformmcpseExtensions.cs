//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sherwebplatformmcpse
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SherwebplatformmcpseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetGraphQLSchema()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/graphql/schema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ConnectionOfProjectedOrganization, ApiConnectionActionConfiguration> QueryOrganizations(Expression<Func<QueryAuditLogsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConnectionOfProjectedOrganization, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/organizations/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConnectionOfProjectedOrganization>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ConnectionOfProjectedCatalogItem, ApiConnectionActionConfiguration> QueryCatalog(Expression<Func<QueryAuditLogsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConnectionOfProjectedCatalogItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/catalog/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConnectionOfProjectedCatalogItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ConnectionOfProjectedSubscription, ApiConnectionActionConfiguration> QuerySubscriptions(Expression<Func<QueryAuditLogsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConnectionOfProjectedSubscription, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/subscriptions/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConnectionOfProjectedSubscription>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ConnectionOfProjectedConsumptionItem, ApiConnectionActionConfiguration> QueryOrganizationConsumptions(Expression<Func<QueryAuditLogsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConnectionOfProjectedConsumptionItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/consumptions/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConnectionOfProjectedConsumptionItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ConnectionOfProjectedAuditLog, ApiConnectionActionConfiguration> QueryAuditLogs(Expression<Func<QueryAuditLogsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConnectionOfProjectedAuditLog, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/audit-logs/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConnectionOfProjectedAuditLog>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<SkuDetail[], ApiConnectionActionConfiguration> GetCopilotSkus()
        {
            return new DeferredBodyAction<SkuDetail[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/copilot-skus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SkuDetail[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<ValidateOrderResult, ApiConnectionActionConfiguration> ValidateQuote(Expression<Func<PlaceOrderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ValidateOrderResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/quotes/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidateOrderResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<PlaceOrderResponse, ApiConnectionActionConfiguration> PlaceOrder(Expression<Func<PlaceOrderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PlaceOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PlaceOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<SubscriptionsAmendment, ApiConnectionActionConfiguration> CreateSubscriptionsAmendment(Expression<Func<CreateSubscriptionsAmendmentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriptionsAmendment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/subscriptions/amendments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionsAmendment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<SubscriptionsCancellation, ApiConnectionActionConfiguration> CancelSubscriptions(Expression<Func<CancelSubscriptionsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriptionsCancellation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/subscriptions/cancellations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionsCancellation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sherwebplatformmcpse")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConfigurePlatform(Expression<Func<ConfigurePlatformBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tools/platforms/configure";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class SherwebplatformmcpseTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConnectionOfProjectedOrganization
    {
        [JsonProperty("edges")]
        public EdgeOfProjectedOrganization[] Edges { get; set; }

        [JsonProperty("nodes")]
        public ProjectedOrganization[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }

    public class EdgeOfProjectedOrganization
    {
        [JsonProperty("node")]
        public ProjectedOrganization Node { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class ProjectedOrganization
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("parentName")]
        public string ParentName { get; set; }

        [JsonProperty("suspendedOn")]
        public string SuspendedOn { get; set; }

        [JsonProperty("isSuspended")]
        public bool IsSuspended { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("daysSinceSuspension")]
        public JToken DaysSinceSuspension { get; set; }

        [JsonProperty("totalSubscriptionCount")]
        public JToken TotalSubscriptionCount { get; set; }

        [JsonProperty("uniqueSkus")]
        public string[] UniqueSkus { get; set; }

        [JsonProperty("totalMonthlyRecurringFee")]
        public JToken TotalMonthlyRecurringFee { get; set; }

        [JsonProperty("totalMonthlyCostRecurringFee")]
        public JToken TotalMonthlyCostRecurringFee { get; set; }

        [JsonProperty("totalYearlyRecurringFee")]
        public JToken TotalYearlyRecurringFee { get; set; }

        [JsonProperty("totalYearlyCostRecurringFee")]
        public JToken TotalYearlyCostRecurringFee { get; set; }

        [JsonProperty("totalOtherRecurringFee")]
        public JToken TotalOtherRecurringFee { get; set; }

        [JsonProperty("totalOtherCostRecurringFee")]
        public JToken TotalOtherCostRecurringFee { get; set; }

        [JsonProperty("invoiceMetrics")]
        public InvoiceMetrics InvoiceMetrics { get; set; }
    }

    public class InvoiceMetrics
    {
        [JsonProperty("periodRange")]
        public InvoicePeriodRange PeriodRange { get; set; }

        [JsonProperty("accumulatedRecurringCost")]
        public JToken AccumulatedRecurringCost { get; set; }

        [JsonProperty("invoiceCount")]
        public JToken InvoiceCount { get; set; }

        [JsonProperty("compoundMonthlyCostGrowthRate")]
        public JToken CompoundMonthlyCostGrowthRate { get; set; }

        [JsonProperty("costConcentrationRatio")]
        public JToken CostConcentrationRatio { get; set; }

        [JsonProperty("costVolatility")]
        public JToken CostVolatility { get; set; }
    }

    public class InvoicePeriodRange
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class PageInfo
    {
        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("hasPreviousPage")]
        public bool HasPreviousPage { get; set; }

        [JsonProperty("startCursor")]
        public string StartCursor { get; set; }

        [JsonProperty("endCursor")]
        public string EndCursor { get; set; }
    }

    public class QueryAuditLogsBodyInput
    {
        public QueryAuditLogsBodyInput(string graphqlQuery)
        {
            this.GraphqlQuery = graphqlQuery;
        }

        [JsonProperty("graphqlQuery", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GraphqlQuery { get; set; }
    }

    public class ConnectionOfProjectedCatalogItem
    {
        [JsonProperty("edges")]
        public EdgeOfProjectedCatalogItem[] Edges { get; set; }

        [JsonProperty("nodes")]
        public ProjectedCatalogItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }

    public class EdgeOfProjectedCatalogItem
    {
        [JsonProperty("node")]
        public ProjectedCatalogItem Node { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class ProjectedCatalogItem
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("billingCycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("commitmentTerm")]
        public string CommitmentTerm { get; set; }

        [JsonProperty("pricingInformation")]
        public ProjectedPricingInformation PricingInformation { get; set; }

        [JsonProperty("platforms")]
        public ProjectedPlatforms[] Platforms { get; set; }
    }

    public class ProjectedPricingInformation
    {
        [JsonProperty("recurringFee")]
        public JToken RecurringFee { get; set; }

        [JsonProperty("setupFee")]
        public JToken SetupFee { get; set; }

        [JsonProperty("currency")]
        public int Currency { get; set; }

        [JsonProperty("billingCycle")]
        public string BillingCycle { get; set; }
    }

    public class ProjectedPlatforms
    {
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }

        [JsonProperty("requiredParameters")]
        public PlatformRequiredParameter[] RequiredParameters { get; set; }
    }

    public class PlatformRequiredParameter
    {
        [JsonProperty("parameterDescription")]
        public string ParameterDescription { get; set; }

        [JsonProperty("parameterIdentifier")]
        public string ParameterIdentifier { get; set; }

        [JsonProperty("parameterDefaultValue")]
        public string ParameterDefaultValue { get; set; }

        [JsonProperty("parameterFormatType")]
        public string ParameterFormatType { get; set; }

        [JsonProperty("parameterFormatPattern")]
        public string ParameterFormatPattern { get; set; }

        [JsonProperty("parameterFormatChoices")]
        public Choice[] ParameterFormatChoices { get; set; }
    }

    public class Choice
    {
        [JsonProperty("parameterChoiceValue")]
        public string ParameterChoiceValue { get; set; }

        [JsonProperty("parameterChoiceDisplayName")]
        public string ParameterChoiceDisplayName { get; set; }
    }

    public class ConnectionOfProjectedSubscription
    {
        [JsonProperty("edges")]
        public EdgeOfProjectedSubscription[] Edges { get; set; }

        [JsonProperty("nodes")]
        public ProjectedSubscription[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }

    public class EdgeOfProjectedSubscription
    {
        [JsonProperty("node")]
        public ProjectedSubscription Node { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class ProjectedSubscription
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("cancelledOn")]
        public string CancelledOn { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("daysSinceCreation")]
        public JToken DaysSinceCreation { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("commitmentTerm")]
        public ProjectedCommitmentTerm CommitmentTerm { get; set; }

        [JsonProperty("daysUntilRenewal")]
        public JToken DaysUntilRenewal { get; set; }

        [JsonProperty("sherwebSku")]
        public string SherwebSku { get; set; }

        [JsonProperty("microsoftSkus")]
        public string[] MicrosoftSkus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lastRenewalDate")]
        public string LastRenewalDate { get; set; }

        [JsonProperty("fees")]
        public ProjectedFeesDto Fees { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("isCoterminated")]
        public bool IsCoterminated { get; set; }

        [JsonProperty("history")]
        public SubscriptionHistoryEvent[] History { get; set; }
    }

    public class ProjectedCommitmentTerm
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("renewalConfiguration")]
        public ProjectedRenewalConfiguration RenewalConfiguration { get; set; }
    }

    public class ProjectedRenewalConfiguration
    {
        [JsonProperty("isConfigurable")]
        public bool IsConfigurable { get; set; }

        [JsonProperty("renewSettings")]
        public ProjectedRenewSettings RenewSettings { get; set; }
    }

    public class ProjectedRenewSettings
    {
        [JsonProperty("renewalDate")]
        public string RenewalDate { get; set; }

        [JsonProperty("scheduledQuantity")]
        public JToken ScheduledQuantity { get; set; }

        [JsonProperty("coTerminationEndDate")]
        public string CoTerminationEndDate { get; set; }
    }

    public class ProjectedFeesDto
    {
        [JsonProperty("recurringFee")]
        public ProjectedMoney RecurringFee { get; set; }

        [JsonProperty("setupFee")]
        public ProjectedMoney SetupFee { get; set; }

        [JsonProperty("costRecurringFee")]
        public ProjectedMoney CostRecurringFee { get; set; }

        [JsonProperty("billingCycle")]
        public string BillingCycle { get; set; }
    }

    public class ProjectedMoney
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("currency")]
        public int Currency { get; set; }

        [JsonProperty("rounding")]
        public JToken Rounding { get; set; }
    }

    public class SubscriptionHistoryEvent
    {
        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("licenseCount")]
        public JToken LicenseCount { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("offerName")]
        public string OfferName { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("coTerminationDate")]
        public string CoTerminationDate { get; set; }

        [JsonProperty("eventSource")]
        public int EventSource { get; set; }

        [JsonProperty("termEndDateDetail")]
        public RenewedTermEndDateDetail TermEndDateDetail { get; set; }

        [JsonProperty("termStartDateDetail")]
        public RenewedTermStartDateDetail TermStartDateDetail { get; set; }
    }

    public class RenewedTermEndDateDetail
    {
        [JsonProperty("previousDate")]
        public string PreviousDate { get; set; }

        [JsonProperty("newDate")]
        public string NewDate { get; set; }
    }

    public class RenewedTermStartDateDetail
    {
        [JsonProperty("previousDate")]
        public string PreviousDate { get; set; }

        [JsonProperty("newDate")]
        public string NewDate { get; set; }
    }

    public class ConnectionOfProjectedConsumptionItem
    {
        [JsonProperty("edges")]
        public EdgeOfProjectedConsumptionItem[] Edges { get; set; }

        [JsonProperty("nodes")]
        public ProjectedConsumptionItem[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }

    public class EdgeOfProjectedConsumptionItem
    {
        [JsonProperty("node")]
        public ProjectedConsumptionItem Node { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class ProjectedConsumptionItem
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("vendorName")]
        public string VendorName { get; set; }

        [JsonProperty("totalQuantities")]
        public JToken TotalQuantities { get; set; }

        [JsonProperty("consumedQuantities")]
        public JToken ConsumedQuantities { get; set; }

        [JsonProperty("availableQuantities")]
        public JToken AvailableQuantities { get; set; }
    }

    public class ConnectionOfProjectedAuditLog
    {
        [JsonProperty("edges")]
        public EdgeOfProjectedAuditLog[] Edges { get; set; }

        [JsonProperty("nodes")]
        public ProjectedAuditLog[] Nodes { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }

        [JsonProperty("pageInfo")]
        public PageInfo PageInfo { get; set; }
    }

    public class EdgeOfProjectedAuditLog
    {
        [JsonProperty("node")]
        public ProjectedAuditLog Node { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class ProjectedAuditLog
    {
        [JsonProperty("id")]
        public JToken Id { get; set; }

        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("userDisplayName")]
        public string UserDisplayName { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("details")]
        public ProjectedAuditLogDetail[] Details { get; set; }
    }

    public class ProjectedAuditLogDetail
    {
        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }
    }

    public class SkuDetail
    {
        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("skuName")]
        public string SkuName { get; set; }
    }

    public class ValidateOrderResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("lineItems")]
        public ValidateOrderLineItem[] LineItems { get; set; }

        [JsonProperty("subtotal")]
        public JToken Subtotal { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class ValidateOrderLineItem
    {
        [JsonProperty("lineNumber")]
        public JToken LineNumber { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billingCycle")]
        public string BillingCycle { get; set; }

        [JsonProperty("commitmentTerm")]
        public string CommitmentTerm { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("unitPrice")]
        public JToken UnitPrice { get; set; }

        [JsonProperty("extendedPrice")]
        public JToken ExtendedPrice { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PlaceOrderBodyInput
    {
        public PlaceOrderBodyInput(string customerId, CartItem[] cartItems, string orderedBy)
        {
            this.CustomerId = customerId;
            this.CartItems = cartItems;
            this.OrderedBy = orderedBy;
        }

        [JsonProperty("customerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerId { get; set; }

        [JsonProperty("cartItems", DefaultValueHandling = DefaultValueHandling.Include)]
        public CartItem[] CartItems { get; set; }

        [JsonProperty("orderedBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrderedBy { get; set; }
    }

    public class CartItem
    {
        public CartItem(string sku)
        {
            this.Sku = sku;
        }

        [JsonProperty("sku", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public JToken Quantity { get; set; }

        [JsonProperty("purchaseOrderNumber")]
        public string PurchaseOrderNumber { get; set; }
    }

    public class PlaceOrderResponse
    {
        [JsonProperty("requestTrackingId")]
        public string RequestTrackingId { get; set; }

        [JsonProperty("subscriptionIds")]
        public string[] SubscriptionIds { get; set; }
    }

    public class SubscriptionsAmendment
    {
        [JsonProperty("subscriptionsAmendmentId")]
        public string SubscriptionsAmendmentId { get; set; }

        [JsonProperty("trackingId")]
        public TrackingId TrackingId { get; set; }
    }

    public class TrackingId
    {
        [JsonProperty("requestTrackingId")]
        public string RequestTrackingId { get; set; }
    }

    public class CreateSubscriptionsAmendmentBodyInput
    {
        public CreateSubscriptionsAmendmentBodyInput(string organizationId, SubscriptionsAmendmentParameter[] subscriptionAmendments)
        {
            this.OrganizationId = organizationId;
            this.SubscriptionAmendments = subscriptionAmendments;
        }

        [JsonProperty("organizationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("subscriptionAmendments", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscriptionsAmendmentParameter[] SubscriptionAmendments { get; set; }
    }

    public class SubscriptionsAmendmentParameter
    {
        public SubscriptionsAmendmentParameter(string subscriptionId)
        {
            this.SubscriptionId = subscriptionId;
        }

        [JsonProperty("subscriptionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SubscriptionId { get; set; }

        [JsonProperty("newQuantity")]
        public JToken NewQuantity { get; set; }
    }

    public class SubscriptionsCancellation
    {
        [JsonProperty("subscriptionsCancellationId")]
        public string SubscriptionsCancellationId { get; set; }

        [JsonProperty("trackingId")]
        public TrackingId TrackingId { get; set; }
    }

    public class CancelSubscriptionsBodyInput
    {
        public CancelSubscriptionsBodyInput(string organizationId, string[] subscriptionIds)
        {
            this.OrganizationId = organizationId;
            this.SubscriptionIds = subscriptionIds;
        }

        [JsonProperty("organizationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationId { get; set; }

        [JsonProperty("subscriptionIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] SubscriptionIds { get; set; }
    }

    public class ConfigurePlatformBodyInput
    {
        public ConfigurePlatformBodyInput(string customerId, string platformId, RequiredParameter[] parameters)
        {
            this.CustomerId = customerId;
            this.PlatformId = platformId;
            this.Parameters = parameters;
        }

        [JsonProperty("customerId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerId { get; set; }

        [JsonProperty("platformId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlatformId { get; set; }

        [JsonProperty("parameters", DefaultValueHandling = DefaultValueHandling.Include)]
        public RequiredParameter[] Parameters { get; set; }
    }

    public class RequiredParameter
    {
        public RequiredParameter(string identifier)
        {
            this.Identifier = identifier;
        }

        [JsonProperty("identifier", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identifier { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sherwebplatformmcpse;

    public partial class WorkflowManagedActions
    {
        public SherwebplatformmcpseActions Sherwebplatformmcpse(string connectionId) => new SherwebplatformmcpseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SherwebplatformmcpseTriggers Sherwebplatformmcpse(string connectionId) => new SherwebplatformmcpseTriggers(connectionId);
    }
}