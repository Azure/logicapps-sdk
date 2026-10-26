//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fraudlabsproip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FraudlabsproipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<ScreenPostResponse, ApiConnectionActionConfiguration> Screen(Expression<Func<ScreenPostInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScreenPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/screen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScreenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<FeedbackPostResponse, ApiConnectionActionConfiguration> Feedback(Expression<Func<FeedbackPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FeedbackPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FeedbackPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<ResultGetResponse, ApiConnectionActionConfiguration> ResultGet(Expression<Func<string>> id = null, Expression<Func<idTypeInput>> idType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_idType = WorkflowExpression.Compile(idType, nameof(idType), required: false);
            return new DeferredBodyAction<ResultGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/result";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["id_type"] = Convert.ToString("fraudlabspro_id");
                if (__workflow_idType != null)
                    callPayload.Queries["id_type"] = ExpressionConverter.Convert(__workflow_idType);
                return new ApiConnectionAction<ResultGetResponse>(callPayload);
            });
        }
    }

    public class FraudlabsproipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ScreenPostResponse
    {
        [JsonProperty("is_country_match")]
        public string IsCountryMatch { get; set; }

        [JsonProperty("is_high_risk_country")]
        public string IsHighRiskCountry { get; set; }

        [JsonProperty("ip_country")]
        public string IpCountry { get; set; }

        [JsonProperty("ip_region")]
        public string IpRegion { get; set; }

        [JsonProperty("ip_city")]
        public string IpCity { get; set; }

        [JsonProperty("ip_continent")]
        public string IpContinent { get; set; }

        [JsonProperty("ip_latitude")]
        public string IpLatitude { get; set; }

        [JsonProperty("ip_longitude")]
        public string IpLongitude { get; set; }

        [JsonProperty("ip_timezone")]
        public string IpTimezone { get; set; }

        [JsonProperty("ip_elevation")]
        public string IpElevation { get; set; }

        [JsonProperty("ip_domain")]
        public string IpDomain { get; set; }

        [JsonProperty("ip_mobile_mnc")]
        public string IpMobileMnc { get; set; }

        [JsonProperty("ip_mobile_mcc")]
        public string IpMobileMcc { get; set; }

        [JsonProperty("ip_mobile_brand")]
        public string IpMobileBrand { get; set; }

        [JsonProperty("ip_netspeed")]
        public string IpNetspeed { get; set; }

        [JsonProperty("ip_isp_name")]
        public string IpIspName { get; set; }

        [JsonProperty("ip_usage_type")]
        public string IpUsageType { get; set; }

        [JsonProperty("is_free_email")]
        public string IsFreeEmail { get; set; }

        [JsonProperty("is_disposable_email")]
        public string IsDisposableEmail { get; set; }

        [JsonProperty("is_new_domain_name")]
        public string IsNewDomainName { get; set; }

        [JsonProperty("is_domain_exists")]
        public string IsDomainExists { get; set; }

        [JsonProperty("is_proxy_ip_address")]
        public string IsProxyIpAddress { get; set; }

        [JsonProperty("is_bin_found")]
        public string IsBinFound { get; set; }

        [JsonProperty("is_bin_country_match")]
        public string IsBinCountryMatch { get; set; }

        [JsonProperty("is_bin_prepaid")]
        public string IsBinPrepaid { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("card_issuing_bank")]
        public string CardIssuingBank { get; set; }

        [JsonProperty("card_issuing_country")]
        public string CardIssuingCountry { get; set; }

        [JsonProperty("is_address_ship_forward")]
        public string IsAddressShipForward { get; set; }

        [JsonProperty("is_bill_ship_city_match")]
        public string IsBillShipCityMatch { get; set; }

        [JsonProperty("is_bill_ship_state_match")]
        public string IsBillShipStateMatch { get; set; }

        [JsonProperty("is_bill_ship_country_match")]
        public string IsBillShipCountryMatch { get; set; }

        [JsonProperty("is_bill_ship_postal_match")]
        public string IsBillShipPostalMatch { get; set; }

        [JsonProperty("is_ip_blacklist")]
        public string IsIpBlacklist { get; set; }

        [JsonProperty("is_email_blacklist")]
        public string IsEmailBlacklist { get; set; }

        [JsonProperty("is_credit_card_blacklist")]
        public string IsCreditCardBlacklist { get; set; }

        [JsonProperty("is_device_blacklist")]
        public string IsDeviceBlacklist { get; set; }

        [JsonProperty("is_user_blacklist")]
        public string IsUserBlacklist { get; set; }

        [JsonProperty("is_ship_address_blacklist")]
        public string IsShipAddressBlacklist { get; set; }

        [JsonProperty("is_phone_blacklist")]
        public string IsPhoneBlacklist { get; set; }

        [JsonProperty("is_disposable_phone_number")]
        public string IsDisposablePhoneNumber { get; set; }

        [JsonProperty("is_high_risk_username")]
        public string IsHighRiskUsername { get; set; }

        [JsonProperty("is_malware_exploit")]
        public string IsMalwareExploit { get; set; }

        [JsonProperty("is_export_controlled_country")]
        public string IsExportControlledCountry { get; set; }

        [JsonProperty("user_order_id")]
        public string UserOrderId { get; set; }

        [JsonProperty("user_order_memo")]
        public string UserOrderMemo { get; set; }

        [JsonProperty("fraudlabspro_score")]
        public int FraudlabsproScore { get; set; }

        [JsonProperty("fraudlabspro_status")]
        public string FraudlabsproStatus { get; set; }

        [JsonProperty("fraudlabspro_id")]
        public string FraudlabsproId { get; set; }

        [JsonProperty("fraudlabspro_rules")]
        public string FraudlabsproRules { get; set; }

        [JsonProperty("fraudlabspro_version")]
        public string FraudlabsproVersion { get; set; }

        [JsonProperty("fraudlabspro_error_code")]
        public string FraudlabsproErrorCode { get; set; }

        [JsonProperty("fraudlabspro_message")]
        public string FraudlabsproMessage { get; set; }

        [JsonProperty("fraudlabspro_credits")]
        public int FraudlabsproCredits { get; set; }
    }

    public class ScreenPostInput
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("bill_addr")]
        public string BillAddr { get; set; }

        [JsonProperty("bill_city")]
        public string BillCity { get; set; }

        [JsonProperty("bill_state")]
        public string BillState { get; set; }

        [JsonProperty("bill_country")]
        public string BillCountry { get; set; }

        [JsonProperty("bill_zip_code")]
        public string BillZipCode { get; set; }

        [JsonProperty("ship_last_name")]
        public string ShipLastName { get; set; }

        [JsonProperty("ship_first_name")]
        public string ShipFirstName { get; set; }

        [JsonProperty("ship_addr")]
        public string ShipAddr { get; set; }

        [JsonProperty("ship_city")]
        public string ShipCity { get; set; }

        [JsonProperty("ship_state")]
        public string ShipState { get; set; }

        [JsonProperty("ship_country")]
        public string ShipCountry { get; set; }

        [JsonProperty("ship_zip_code")]
        public string ShipZipCode { get; set; }

        [JsonProperty("user_phone")]
        public string UserPhone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_hash")]
        public string EmailHash { get; set; }

        [JsonProperty("email_domain")]
        public string EmailDomain { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("bin_no")]
        public string BinNo { get; set; }

        [JsonProperty("card_hash")]
        public string CardHash { get; set; }

        [JsonProperty("avs_result")]
        public string AvsResult { get; set; }

        [JsonProperty("cvv_result")]
        public string CvvResult { get; set; }

        [JsonProperty("user_order_id")]
        public string UserOrderId { get; set; }

        [JsonProperty("user_order_memo")]
        public string UserOrderMemo { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("payment_gateway")]
        public string PaymentGateway { get; set; }

        [JsonProperty("payment_mode")]
        public ScreenPostInputPaymentModeType? PaymentMode { get; set; }

        [JsonProperty("flp_checksum")]
        public string FlpChecksum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScreenPostInputPaymentModeType
    {
        [EnumMember(Value = "creditcard")]
        Creditcard,
        [EnumMember(Value = "affirm")]
        Affirm,
        [EnumMember(Value = "paypal")]
        Paypal,
        [EnumMember(Value = "googlecheckout")]
        Googlecheckout,
        [EnumMember(Value = "bitcoin")]
        Bitcoin,
        [EnumMember(Value = "cod")]
        Cod,
        [EnumMember(Value = "moneyorder")]
        Moneyorder,
        [EnumMember(Value = "wired")]
        Wired,
        [EnumMember(Value = "bankdeposit")]
        Bankdeposit,
        [EnumMember(Value = "elviauthorized")]
        Elviauthorized,
        [EnumMember(Value = "paymitco")]
        Paymitco,
        [EnumMember(Value = "cybersource")]
        Cybersource,
        [EnumMember(Value = "sezzle")]
        Sezzle,
        [EnumMember(Value = "viabill")]
        Viabill,
        [EnumMember(Value = "amazonpay")]
        Amazonpay,
        [EnumMember(Value = "pmnts_gateway")]
        PmntsGateway,
        [EnumMember(Value = "giftcard")]
        Giftcard,
        [EnumMember(Value = "ewayrapid")]
        Ewayrapid,
        [EnumMember(Value = "others")]
        Others
    }

    public class FeedbackPostResponse
    {
        [JsonProperty("fraudlabspro_error_code")]
        public string FraudlabsproErrorCode { get; set; }

        [JsonProperty("fraudlabspro_message")]
        public string FraudlabsproMessage { get; set; }
    }

    public class FeedbackPostInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public FeedbackPostInputActionType? Action { get; set; } = FeedbackPostInputActionType.APPROVE;

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FeedbackPostInputActionType
    {
        APPROVE,
        REJECT,
        [EnumMember(Value = "REJECT_BLACKLIST")]
        REJECTBLACKLIST
    }

    public class ResultGetResponse
    {
        [JsonProperty("is_country_match")]
        public string IsCountryMatch { get; set; }

        [JsonProperty("is_high_risk_country")]
        public string IsHighRiskCountry { get; set; }

        [JsonProperty("ip_country")]
        public string IpCountry { get; set; }

        [JsonProperty("ip_region")]
        public string IpRegion { get; set; }

        [JsonProperty("ip_city")]
        public string IpCity { get; set; }

        [JsonProperty("ip_continent")]
        public string IpContinent { get; set; }

        [JsonProperty("ip_latitude")]
        public string IpLatitude { get; set; }

        [JsonProperty("ip_longitude")]
        public string IpLongitude { get; set; }

        [JsonProperty("ip_timezone")]
        public string IpTimezone { get; set; }

        [JsonProperty("ip_elevation")]
        public string IpElevation { get; set; }

        [JsonProperty("ip_domain")]
        public string IpDomain { get; set; }

        [JsonProperty("ip_mobile_mnc")]
        public string IpMobileMnc { get; set; }

        [JsonProperty("ip_mobile_mcc")]
        public string IpMobileMcc { get; set; }

        [JsonProperty("ip_mobile_brand")]
        public string IpMobileBrand { get; set; }

        [JsonProperty("ip_netspeed")]
        public string IpNetspeed { get; set; }

        [JsonProperty("ip_isp_name")]
        public string IpIspName { get; set; }

        [JsonProperty("ip_usage_type")]
        public string IpUsageType { get; set; }

        [JsonProperty("is_free_email")]
        public string IsFreeEmail { get; set; }

        [JsonProperty("is_disposable_email")]
        public string IsDisposableEmail { get; set; }

        [JsonProperty("is_new_domain_name")]
        public string IsNewDomainName { get; set; }

        [JsonProperty("is_domain_exists")]
        public string IsDomainExists { get; set; }

        [JsonProperty("is_proxy_ip_address")]
        public string IsProxyIpAddress { get; set; }

        [JsonProperty("is_bin_found")]
        public string IsBinFound { get; set; }

        [JsonProperty("is_bin_country_match")]
        public string IsBinCountryMatch { get; set; }

        [JsonProperty("is_bin_name_match")]
        public string IsBinNameMatch { get; set; }

        [JsonProperty("is_bin_phone_match")]
        public string IsBinPhoneMatch { get; set; }

        [JsonProperty("is_bin_prepaid")]
        public string IsBinPrepaid { get; set; }

        [JsonProperty("is_address_ship_forward")]
        public string IsAddressShipForward { get; set; }

        [JsonProperty("is_bill_ship_city_match")]
        public string IsBillShipCityMatch { get; set; }

        [JsonProperty("is_bill_ship_state_match")]
        public string IsBillShipStateMatch { get; set; }

        [JsonProperty("is_bill_ship_country_match")]
        public string IsBillShipCountryMatch { get; set; }

        [JsonProperty("is_bill_ship_postal_match")]
        public string IsBillShipPostalMatch { get; set; }

        [JsonProperty("is_ip_blacklist")]
        public string IsIpBlacklist { get; set; }

        [JsonProperty("is_email_blacklist")]
        public string IsEmailBlacklist { get; set; }

        [JsonProperty("is_credit_card_blacklist")]
        public string IsCreditCardBlacklist { get; set; }

        [JsonProperty("is_device_blacklist")]
        public string IsDeviceBlacklist { get; set; }

        [JsonProperty("is_user_blacklist")]
        public string IsUserBlacklist { get; set; }

        [JsonProperty("is_ship_address_blacklist")]
        public string IsShipAddressBlacklist { get; set; }

        [JsonProperty("is_phone_blacklist")]
        public string IsPhoneBlacklist { get; set; }

        [JsonProperty("is_high_risk_username_password")]
        public string IsHighRiskUsernamePassword { get; set; }

        [JsonProperty("is_malware_exploit")]
        public string IsMalwareExploit { get; set; }

        [JsonProperty("is_export_controlled_country")]
        public string IsExportControlledCountry { get; set; }

        [JsonProperty("user_order_id")]
        public string UserOrderId { get; set; }

        [JsonProperty("user_order_memo")]
        public string UserOrderMemo { get; set; }

        [JsonProperty("fraudlabspro_score")]
        public int FraudlabsproScore { get; set; }

        [JsonProperty("fraudlabspro_distribution")]
        public int FraudlabsproDistribution { get; set; }

        [JsonProperty("fraudlabspro_status")]
        public string FraudlabsproStatus { get; set; }

        [JsonProperty("fraudlabspro_id")]
        public string FraudlabsproId { get; set; }

        [JsonProperty("fraudlabspro_message")]
        public string FraudlabsproMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum idTypeInput
    {
        [EnumMember(Value = "fraudlabspro_id")]
        FraudlabsproId,
        [EnumMember(Value = "user_order_id")]
        UserOrderId
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fraudlabsproip;

    public partial class WorkflowManagedActions
    {
        public FraudlabsproipActions Fraudlabsproip(string connectionId) => new FraudlabsproipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FraudlabsproipTriggers Fraudlabsproip(string connectionId) => new FraudlabsproipTriggers(connectionId);
    }
}