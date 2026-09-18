//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventtickets
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventticketsActions([ConnectionName] string connectionId)
    {
    }

    public class EventticketsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AttendeeTriggerResponse> AttendeeTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/attendees/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<AttendeeTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UpdatedAttendeeTriggerResponse> UpdatedAttendeeTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/updated-attendees/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<UpdatedAttendeeTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CheckinTriggerResponse> CheckinTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/checkin/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CheckinTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewOrderTriggerResponse> NewOrderTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/orders/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewOrderTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RefundedOrderTriggerResponse> RefundedOrderTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/refunded-orders/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RefundedOrderTriggerResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class AttendeeTriggerResponse
    {
        [JsonProperty("attendees")]
        public AttendeeTriggerResponseAttendeesTypeItem[] Attendees { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class AttendeeTriggerResponseAttendeesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("holder_email")]
        public string HolderEmail { get; set; }

        [JsonProperty("ticket_id")]
        public string TicketId { get; set; }

        [JsonProperty("security_code")]
        public string SecurityCode { get; set; }

        [JsonProperty("attendee_meta")]
        public AttendeeTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem[] AttendeeMeta { get; set; }

        [JsonProperty("check_in")]
        public string CheckIn { get; set; }

        [JsonProperty("optout")]
        public bool Optout { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("is_subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("is_purchaser")]
        public bool IsPurchaser { get; set; }

        [JsonProperty("purchaser_name")]
        public string PurchaserName { get; set; }

        [JsonProperty("purchaser_email")]
        public string PurchaserEmail { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("ticket_product_id")]
        public string TicketProductId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_title")]
        public string EventTitle { get; set; }
    }

    public class AttendeeTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem
    {
        [JsonProperty("attendee_meta_id")]
        public string AttendeeMetaId { get; set; }

        [JsonProperty("attendee_meta_name")]
        public string AttendeeMetaName { get; set; }

        [JsonProperty("attendee_meta_value")]
        public string[] AttendeeMetaValue { get; set; }
    }

    public class UpdatedAttendeeTriggerResponse
    {
        [JsonProperty("attendees")]
        public UpdatedAttendeeTriggerResponseAttendeesTypeItem[] Attendees { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class UpdatedAttendeeTriggerResponseAttendeesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("holder_email")]
        public string HolderEmail { get; set; }

        [JsonProperty("ticket_id")]
        public string TicketId { get; set; }

        [JsonProperty("security_code")]
        public string SecurityCode { get; set; }

        [JsonProperty("attendee_meta")]
        public UpdatedAttendeeTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem[] AttendeeMeta { get; set; }

        [JsonProperty("check_in")]
        public string CheckIn { get; set; }

        [JsonProperty("optout")]
        public bool Optout { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("is_subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("is_purchaser")]
        public bool IsPurchaser { get; set; }

        [JsonProperty("purchaser_name")]
        public string PurchaserName { get; set; }

        [JsonProperty("purchaser_email")]
        public string PurchaserEmail { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("ticket_product_id")]
        public string TicketProductId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_title")]
        public string EventTitle { get; set; }
    }

    public class UpdatedAttendeeTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem
    {
        [JsonProperty("attendee_meta_id")]
        public string AttendeeMetaId { get; set; }

        [JsonProperty("attendee_meta_name")]
        public string AttendeeMetaName { get; set; }

        [JsonProperty("attendee_meta_value")]
        public string[] AttendeeMetaValue { get; set; }
    }

    public class CheckinTriggerResponse
    {
        [JsonProperty("attendees")]
        public CheckinTriggerResponseAttendeesTypeItem[] Attendees { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class CheckinTriggerResponseAttendeesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("holder_email")]
        public string HolderEmail { get; set; }

        [JsonProperty("ticket_id")]
        public string TicketId { get; set; }

        [JsonProperty("security_code")]
        public string SecurityCode { get; set; }

        [JsonProperty("attendee_meta")]
        public CheckinTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem[] AttendeeMeta { get; set; }

        [JsonProperty("check_in")]
        public string CheckIn { get; set; }

        [JsonProperty("optout")]
        public bool Optout { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("is_subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("is_purchaser")]
        public bool IsPurchaser { get; set; }

        [JsonProperty("purchaser_name")]
        public string PurchaserName { get; set; }

        [JsonProperty("purchaser_email")]
        public string PurchaserEmail { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("ticket_product_id")]
        public string TicketProductId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_title")]
        public string EventTitle { get; set; }
    }

    public class CheckinTriggerResponseAttendeesTypeItemAttendeeMetaTypeItem
    {
        [JsonProperty("attendee_meta_id")]
        public string AttendeeMetaId { get; set; }

        [JsonProperty("attendee_meta_name")]
        public string AttendeeMetaName { get; set; }

        [JsonProperty("attendee_meta_value")]
        public string[] AttendeeMetaValue { get; set; }
    }

    public class NewOrderTriggerResponse
    {
        [JsonProperty("orders")]
        public NewOrderTriggerResponseOrdersTypeItem[] Orders { get; set; }
    }

    public class NewOrderTriggerResponseOrdersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipping_total")]
        public string ShippingTotal { get; set; }

        [JsonProperty("shipping_tax_total")]
        public string ShippingTaxTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("discount_total")]
        public double DiscountTotal { get; set; }

        [JsonProperty("order_total")]
        public double OrderTotal { get; set; }

        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("customer_user")]
        public int CustomerUser { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("billing_first_name")]
        public string BillingFirstName { get; set; }

        [JsonProperty("billing_last_name")]
        public string BillingLastName { get; set; }

        [JsonProperty("billing_company")]
        public string BillingCompany { get; set; }

        [JsonProperty("billing_email")]
        public string BillingEmail { get; set; }

        [JsonProperty("billing_phone")]
        public string BillingPhone { get; set; }

        [JsonProperty("billing_address_1")]
        public string BillingAddress1 { get; set; }

        [JsonProperty("billing_address_2")]
        public string BillingAddress2 { get; set; }

        [JsonProperty("billing_postcode")]
        public string BillingPostcode { get; set; }

        [JsonProperty("billing_city")]
        public string BillingCity { get; set; }

        [JsonProperty("billing_state")]
        public string BillingState { get; set; }

        [JsonProperty("billing_country")]
        public string BillingCountry { get; set; }

        [JsonProperty("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        [JsonProperty("shipping_last_name")]
        public string ShippingLastName { get; set; }

        [JsonProperty("shipping_company")]
        public string ShippingCompany { get; set; }

        [JsonProperty("shipping_address_1")]
        public string ShippingAddress1 { get; set; }

        [JsonProperty("shipping_address_2")]
        public string ShippingAddress2 { get; set; }

        [JsonProperty("shipping_postcode")]
        public string ShippingPostcode { get; set; }

        [JsonProperty("shipping_city")]
        public string ShippingCity { get; set; }

        [JsonProperty("shipping_state")]
        public string ShippingState { get; set; }

        [JsonProperty("shipping_country")]
        public string ShippingCountry { get; set; }

        [JsonProperty("customer_note")]
        public NewOrderTriggerResponseOrdersTypeItemCustomerNoteTypeItem[] CustomerNote { get; set; }

        [JsonProperty("items")]
        public NewOrderTriggerResponseOrdersTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class NewOrderTriggerResponseOrdersTypeItemCustomerNoteTypeItem
    {
        [JsonProperty("order_note_content")]
        public string OrderNoteContent { get; set; }

        [JsonProperty("order_note_object_type")]
        public string OrderNoteObjectType { get; set; }

        [JsonProperty("order_note_date_created")]
        public string OrderNoteDateCreated { get; set; }
    }

    public class NewOrderTriggerResponseOrdersTypeItemItemsTypeItem
    {
        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        [JsonProperty("ticket_name")]
        public string TicketName { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("meta")]
        public NewOrderTriggerResponseOrdersTypeItemItemsTypeItemMetaTypeItem[] Meta { get; set; }

        [JsonProperty("variation_id")]
        public int VariationId { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("tax_status")]
        public string TaxStatus { get; set; }
    }

    public class NewOrderTriggerResponseOrdersTypeItemItemsTypeItemMetaTypeItem
    {
        [JsonProperty("ticket_meta_id")]
        public int TicketMetaId { get; set; }

        [JsonProperty("ticket_meta_name")]
        public string TicketMetaName { get; set; }

        [JsonProperty("ticket_meta_value")]
        public JToken[] TicketMetaValue { get; set; }
    }

    public class RefundedOrderTriggerResponse
    {
        [JsonProperty("orders")]
        public RefundedOrderTriggerResponseOrdersTypeItem[] Orders { get; set; }
    }

    public class RefundedOrderTriggerResponseOrdersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shipping_total")]
        public string ShippingTotal { get; set; }

        [JsonProperty("shipping_tax_total")]
        public string ShippingTaxTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("discount_total")]
        public double DiscountTotal { get; set; }

        [JsonProperty("order_total")]
        public double OrderTotal { get; set; }

        [JsonProperty("order_currency")]
        public string OrderCurrency { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("customer_user")]
        public int CustomerUser { get; set; }

        [JsonProperty("customer_email")]
        public string CustomerEmail { get; set; }

        [JsonProperty("billing_first_name")]
        public string BillingFirstName { get; set; }

        [JsonProperty("billing_last_name")]
        public string BillingLastName { get; set; }

        [JsonProperty("billing_company")]
        public string BillingCompany { get; set; }

        [JsonProperty("billing_email")]
        public string BillingEmail { get; set; }

        [JsonProperty("billing_phone")]
        public string BillingPhone { get; set; }

        [JsonProperty("billing_address_1")]
        public string BillingAddress1 { get; set; }

        [JsonProperty("billing_address_2")]
        public string BillingAddress2 { get; set; }

        [JsonProperty("billing_postcode")]
        public string BillingPostcode { get; set; }

        [JsonProperty("billing_city")]
        public string BillingCity { get; set; }

        [JsonProperty("billing_state")]
        public string BillingState { get; set; }

        [JsonProperty("billing_country")]
        public string BillingCountry { get; set; }

        [JsonProperty("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        [JsonProperty("shipping_last_name")]
        public string ShippingLastName { get; set; }

        [JsonProperty("shipping_company")]
        public string ShippingCompany { get; set; }

        [JsonProperty("shipping_address_1")]
        public string ShippingAddress1 { get; set; }

        [JsonProperty("shipping_address_2")]
        public string ShippingAddress2 { get; set; }

        [JsonProperty("shipping_postcode")]
        public string ShippingPostcode { get; set; }

        [JsonProperty("shipping_city")]
        public string ShippingCity { get; set; }

        [JsonProperty("shipping_state")]
        public string ShippingState { get; set; }

        [JsonProperty("shipping_country")]
        public string ShippingCountry { get; set; }

        [JsonProperty("customer_note")]
        public RefundedOrderTriggerResponseOrdersTypeItemCustomerNoteTypeItem[] CustomerNote { get; set; }

        [JsonProperty("items")]
        public RefundedOrderTriggerResponseOrdersTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class RefundedOrderTriggerResponseOrdersTypeItemCustomerNoteTypeItem
    {
        [JsonProperty("order_note_content")]
        public string OrderNoteContent { get; set; }

        [JsonProperty("order_note_object_type")]
        public string OrderNoteObjectType { get; set; }

        [JsonProperty("order_note_date_created")]
        public string OrderNoteDateCreated { get; set; }
    }

    public class RefundedOrderTriggerResponseOrdersTypeItemItemsTypeItem
    {
        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        [JsonProperty("ticket_name")]
        public string TicketName { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("subtotal")]
        public double Subtotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("meta")]
        public RefundedOrderTriggerResponseOrdersTypeItemItemsTypeItemMetaTypeItem[] Meta { get; set; }

        [JsonProperty("variation_id")]
        public int VariationId { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("tax_status")]
        public string TaxStatus { get; set; }
    }

    public class RefundedOrderTriggerResponseOrdersTypeItemItemsTypeItemMetaTypeItem
    {
        [JsonProperty("ticket_meta_id")]
        public int TicketMetaId { get; set; }

        [JsonProperty("ticket_meta_name")]
        public string TicketMetaName { get; set; }

        [JsonProperty("ticket_meta_value")]
        public JToken[] TicketMetaValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eventtickets;

    public partial class WorkflowManagedActions
    {
        public EventticketsActions Eventtickets(string connectionId) => new EventticketsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EventticketsTriggers Eventtickets(string connectionId) => new EventticketsTriggers(connectionId);
    }
}