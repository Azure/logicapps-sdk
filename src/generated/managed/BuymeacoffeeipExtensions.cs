//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Buymeacoffeeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BuymeacoffeeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<MemberGetResponse> MemberGet([WorkflowExpression] Func<statusInput> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("all");
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                return callPayload;
            }

            return new ApiConnectionAction<MemberGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<MemberGetAResponse> MemberGetA([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/subscriptions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<SupporterGetResponse> SupporterGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/supporters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SupporterGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<SupporterGetAResponse> SupporterGetA([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/supporters/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SupporterGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<ExtraGetResponse> ExtraGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/extras";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExtraGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buymeacoffeeip")]
        public IBodyWorkflowAction<ExtraGetAResponse> ExtraGetA([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/extras/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExtraGetAResponse>(BuildSourceInput);
        }
    }

    public class BuymeacoffeeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MemberGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public MemberGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class MemberGetResponseDataTypeItem
    {
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonProperty("subscription_cancelled_on")]
        public string SubscriptionCancelledOn { get; set; }

        [JsonProperty("subscription_created_on")]
        public string SubscriptionCreatedOn { get; set; }

        [JsonProperty("subscription_updated_on")]
        public string SubscriptionUpdatedOn { get; set; }

        [JsonProperty("subscription_current_period_start")]
        public string SubscriptionCurrentPeriodStart { get; set; }

        [JsonProperty("subscription_current_period_end")]
        public string SubscriptionCurrentPeriodEnd { get; set; }

        [JsonProperty("subscription_coffee_price")]
        public string SubscriptionCoffeePrice { get; set; }

        [JsonProperty("subscription_coffee_num")]
        public int SubscriptionCoffeeNum { get; set; }

        [JsonProperty("subscription_is_cancelled")]
        public string SubscriptionIsCancelled { get; set; }

        [JsonProperty("subscription_is_cancelled_at_period_end")]
        public string SubscriptionIsCancelledAtPeriodEnd { get; set; }

        [JsonProperty("subscription_currency")]
        public string SubscriptionCurrency { get; set; }

        [JsonProperty("subscription_message")]
        public string SubscriptionMessage { get; set; }

        [JsonProperty("message_visibility")]
        public int MessageVisibility { get; set; }

        [JsonProperty("subscription_duration_type")]
        public string SubscriptionDurationType { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }
    }

    public enum statusInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class MemberGetAResponse
    {
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        [JsonProperty("subscription_cancelled_on")]
        public string SubscriptionCancelledOn { get; set; }

        [JsonProperty("subscription_created_on")]
        public string SubscriptionCreatedOn { get; set; }

        [JsonProperty("subscription_updated_on")]
        public string SubscriptionUpdatedOn { get; set; }

        [JsonProperty("subscription_current_period_start")]
        public string SubscriptionCurrentPeriodStart { get; set; }

        [JsonProperty("subscription_current_period_end")]
        public string SubscriptionCurrentPeriodEnd { get; set; }

        [JsonProperty("subscription_coffee_price")]
        public string SubscriptionCoffeePrice { get; set; }

        [JsonProperty("subscription_coffee_num")]
        public int SubscriptionCoffeeNum { get; set; }

        [JsonProperty("subscription_is_cancelled")]
        public string SubscriptionIsCancelled { get; set; }

        [JsonProperty("subscription_is_cancelled_at_period_end")]
        public string SubscriptionIsCancelledAtPeriodEnd { get; set; }

        [JsonProperty("subscription_currency")]
        public string SubscriptionCurrency { get; set; }

        [JsonProperty("subscription_message")]
        public string SubscriptionMessage { get; set; }

        [JsonProperty("message_visibility")]
        public int MessageVisibility { get; set; }

        [JsonProperty("subscription_duration_type")]
        public string SubscriptionDurationType { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }
    }

    public class SupporterGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public SupporterGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class SupporterGetResponseDataTypeItem
    {
        [JsonProperty("support_id")]
        public int SupportId { get; set; }

        [JsonProperty("support_note")]
        public string SupportNote { get; set; }

        [JsonProperty("support_coffees")]
        public int SupportCoffees { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("support_visibility")]
        public int SupportVisibility { get; set; }

        [JsonProperty("support_created_on")]
        public string SupportCreatedOn { get; set; }

        [JsonProperty("support_updated_on")]
        public string SupportUpdatedOn { get; set; }

        [JsonProperty("transfer_id")]
        public string TransferId { get; set; }

        [JsonProperty("supporter_name")]
        public string SupporterName { get; set; }

        [JsonProperty("support_coffee_price")]
        public string SupportCoffeePrice { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("is_refunded")]
        public string IsRefunded { get; set; }

        [JsonProperty("support_currency")]
        public string SupportCurrency { get; set; }

        [JsonProperty("support_note_pinned")]
        public int SupportNotePinned { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payment_platform")]
        public string PaymentPlatform { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }
    }

    public class SupporterGetAResponse
    {
        [JsonProperty("support_id")]
        public int SupportId { get; set; }

        [JsonProperty("support_note")]
        public string SupportNote { get; set; }

        [JsonProperty("support_coffees")]
        public int SupportCoffees { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("support_visibility")]
        public int SupportVisibility { get; set; }

        [JsonProperty("support_created_on")]
        public string SupportCreatedOn { get; set; }

        [JsonProperty("support_updated_on")]
        public string SupportUpdatedOn { get; set; }

        [JsonProperty("transfer_id")]
        public string TransferId { get; set; }

        [JsonProperty("supporter_name")]
        public string SupporterName { get; set; }

        [JsonProperty("support_coffee_price")]
        public string SupportCoffeePrice { get; set; }

        [JsonProperty("support_email")]
        public string SupportEmail { get; set; }

        [JsonProperty("is_refunded")]
        public string IsRefunded { get; set; }

        [JsonProperty("support_currency")]
        public string SupportCurrency { get; set; }

        [JsonProperty("support_note_pinned")]
        public int SupportNotePinned { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payment_platform")]
        public string PaymentPlatform { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }
    }

    public class ExtraGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public ExtraGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("first_page_url")]
        public string FirstPageUrl { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("last_page_url")]
        public string LastPageUrl { get; set; }

        [JsonProperty("next_page_url")]
        public string NextPageUrl { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("prev_page_url")]
        public string PrevPageUrl { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ExtraGetResponseDataTypeItem
    {
        [JsonProperty("purchase_id")]
        public int PurchaseId { get; set; }

        [JsonProperty("purchased_on")]
        public string PurchasedOn { get; set; }

        [JsonProperty("purchase_updated_on")]
        public string PurchaseUpdatedOn { get; set; }

        [JsonProperty("purchase_is_revoked")]
        public int PurchaseIsRevoked { get; set; }

        [JsonProperty("purchase_amount")]
        public string PurchaseAmount { get; set; }

        [JsonProperty("purchase_currency")]
        public string PurchaseCurrency { get; set; }

        [JsonProperty("purchase_question")]
        public string PurchaseQuestion { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        [JsonProperty("extra")]
        public ExtraGetResponseDataTypeItemExtraType Extra { get; set; }
    }

    public class ExtraGetResponseDataTypeItemExtraType
    {
        [JsonProperty("reward_id")]
        public int RewardId { get; set; }

        [JsonProperty("reward_title")]
        public string RewardTitle { get; set; }

        [JsonProperty("reward_description")]
        public string RewardDescription { get; set; }

        [JsonProperty("reward_confirmation_message")]
        public string RewardConfirmationMessage { get; set; }

        [JsonProperty("reward_question")]
        public string RewardQuestion { get; set; }

        [JsonProperty("reward_used")]
        public int RewardUsed { get; set; }

        [JsonProperty("reward_created_on")]
        public string RewardCreatedOn { get; set; }

        [JsonProperty("reward_updated_on")]
        public string RewardUpdatedOn { get; set; }

        [JsonProperty("reward_deleted_on")]
        public string RewardDeletedOn { get; set; }

        [JsonProperty("reward_is_active")]
        public int RewardIsActive { get; set; }

        [JsonProperty("reward_image")]
        public string RewardImage { get; set; }

        [JsonProperty("reward_slots")]
        public int RewardSlots { get; set; }

        [JsonProperty("reward_coffee_price")]
        public string RewardCoffeePrice { get; set; }

        [JsonProperty("reward_order")]
        public int RewardOrder { get; set; }
    }

    public class ExtraGetAResponse
    {
        [JsonProperty("purchase_id")]
        public int PurchaseId { get; set; }

        [JsonProperty("purchased_on")]
        public string PurchasedOn { get; set; }

        [JsonProperty("purchase_updated_on")]
        public string PurchaseUpdatedOn { get; set; }

        [JsonProperty("purchase_is_revoked")]
        public int PurchaseIsRevoked { get; set; }

        [JsonProperty("purchase_amount")]
        public string PurchaseAmount { get; set; }

        [JsonProperty("purchase_currency")]
        public string PurchaseCurrency { get; set; }

        [JsonProperty("purchase_question")]
        public string PurchaseQuestion { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        [JsonProperty("extra")]
        public ExtraGetAResponseExtraType Extra { get; set; }
    }

    public class ExtraGetAResponseExtraType
    {
        [JsonProperty("reward_id")]
        public int RewardId { get; set; }

        [JsonProperty("reward_title")]
        public string RewardTitle { get; set; }

        [JsonProperty("reward_description")]
        public string RewardDescription { get; set; }

        [JsonProperty("reward_confirmation_message")]
        public string RewardConfirmationMessage { get; set; }

        [JsonProperty("reward_question")]
        public string RewardQuestion { get; set; }

        [JsonProperty("reward_used")]
        public int RewardUsed { get; set; }

        [JsonProperty("reward_created_on")]
        public string RewardCreatedOn { get; set; }

        [JsonProperty("reward_updated_on")]
        public string RewardUpdatedOn { get; set; }

        [JsonProperty("reward_deleted_on")]
        public string RewardDeletedOn { get; set; }

        [JsonProperty("reward_is_active")]
        public int RewardIsActive { get; set; }

        [JsonProperty("reward_image")]
        public string RewardImage { get; set; }

        [JsonProperty("reward_slots")]
        public int RewardSlots { get; set; }

        [JsonProperty("reward_coffee_price")]
        public string RewardCoffeePrice { get; set; }

        [JsonProperty("reward_order")]
        public int RewardOrder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Buymeacoffeeip;

    public partial class WorkflowManagedActions
    {
        public BuymeacoffeeipActions Buymeacoffeeip(string connectionId) => new BuymeacoffeeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BuymeacoffeeipTriggers Buymeacoffeeip(string connectionId) => new BuymeacoffeeipTriggers(connectionId);
    }
}