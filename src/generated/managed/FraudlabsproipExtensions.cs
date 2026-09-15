//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fraudlabsproip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FraudlabsproipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<ScreenPostResponse> Screen(Expression<Func<string>> bodyip = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodybillAddr = null, Expression<Func<string>> bodybillCity = null, Expression<Func<string>> bodybillState = null, Expression<Func<string>> bodybillCountry = null, Expression<Func<string>> bodybillZipCode = null, Expression<Func<string>> bodyshipLastName = null, Expression<Func<string>> bodyshipFirstName = null, Expression<Func<string>> bodyshipAddr = null, Expression<Func<string>> bodyshipCity = null, Expression<Func<string>> bodyshipState = null, Expression<Func<string>> bodyshipCountry = null, Expression<Func<string>> bodyshipZipCode = null, Expression<Func<string>> bodyuserPhone = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyemailHash = null, Expression<Func<string>> bodyemailDomain = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodybinNo = null, Expression<Func<string>> bodycardHash = null, Expression<Func<string>> bodyavsResult = null, Expression<Func<string>> bodycvvResult = null, Expression<Func<string>> bodyuserOrderId = null, Expression<Func<string>> bodyuserOrderMemo = null, Expression<Func<double>> bodyamount = null, Expression<Func<int>> bodyquantity = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodypaymentGateway = null, Expression<Func<bodypaymentModeInput>> bodypaymentMode = null, Expression<Func<string>> bodyflpChecksum = null)
        {
            var apiCallPath = "/screen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyip != null)
            {
                body["ip"] = CSharpExpressionConverter.ConvertToken(bodyip);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodybillAddr != null)
            {
                body["bill_addr"] = CSharpExpressionConverter.ConvertToken(bodybillAddr);
                bodypropCount++;
            }

            if (bodybillCity != null)
            {
                body["bill_city"] = CSharpExpressionConverter.ConvertToken(bodybillCity);
                bodypropCount++;
            }

            if (bodybillState != null)
            {
                body["bill_state"] = CSharpExpressionConverter.ConvertToken(bodybillState);
                bodypropCount++;
            }

            if (bodybillCountry != null)
            {
                body["bill_country"] = CSharpExpressionConverter.ConvertToken(bodybillCountry);
                bodypropCount++;
            }

            if (bodybillZipCode != null)
            {
                body["bill_zip_code"] = CSharpExpressionConverter.ConvertToken(bodybillZipCode);
                bodypropCount++;
            }

            if (bodyshipLastName != null)
            {
                body["ship_last_name"] = CSharpExpressionConverter.ConvertToken(bodyshipLastName);
                bodypropCount++;
            }

            if (bodyshipFirstName != null)
            {
                body["ship_first_name"] = CSharpExpressionConverter.ConvertToken(bodyshipFirstName);
                bodypropCount++;
            }

            if (bodyshipAddr != null)
            {
                body["ship_addr"] = CSharpExpressionConverter.ConvertToken(bodyshipAddr);
                bodypropCount++;
            }

            if (bodyshipCity != null)
            {
                body["ship_city"] = CSharpExpressionConverter.ConvertToken(bodyshipCity);
                bodypropCount++;
            }

            if (bodyshipState != null)
            {
                body["ship_state"] = CSharpExpressionConverter.ConvertToken(bodyshipState);
                bodypropCount++;
            }

            if (bodyshipCountry != null)
            {
                body["ship_country"] = CSharpExpressionConverter.ConvertToken(bodyshipCountry);
                bodypropCount++;
            }

            if (bodyshipZipCode != null)
            {
                body["ship_zip_code"] = CSharpExpressionConverter.ConvertToken(bodyshipZipCode);
                bodypropCount++;
            }

            if (bodyuserPhone != null)
            {
                body["user_phone"] = CSharpExpressionConverter.ConvertToken(bodyuserPhone);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyemailHash != null)
            {
                body["email_hash"] = CSharpExpressionConverter.ConvertToken(bodyemailHash);
                bodypropCount++;
            }

            if (bodyemailDomain != null)
            {
                body["email_domain"] = CSharpExpressionConverter.ConvertToken(bodyemailDomain);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
            }

            if (bodybinNo != null)
            {
                body["bin_no"] = CSharpExpressionConverter.ConvertToken(bodybinNo);
                bodypropCount++;
            }

            if (bodycardHash != null)
            {
                body["card_hash"] = CSharpExpressionConverter.ConvertToken(bodycardHash);
                bodypropCount++;
            }

            if (bodyavsResult != null)
            {
                body["avs_result"] = CSharpExpressionConverter.ConvertToken(bodyavsResult);
                bodypropCount++;
            }

            if (bodycvvResult != null)
            {
                body["cvv_result"] = CSharpExpressionConverter.ConvertToken(bodycvvResult);
                bodypropCount++;
            }

            if (bodyuserOrderId != null)
            {
                body["user_order_id"] = CSharpExpressionConverter.ConvertToken(bodyuserOrderId);
                bodypropCount++;
            }

            if (bodyuserOrderMemo != null)
            {
                body["user_order_memo"] = CSharpExpressionConverter.ConvertToken(bodyuserOrderMemo);
                bodypropCount++;
            }

            if (bodyamount != null)
            {
                body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
                bodypropCount++;
            }

            if (bodyquantity != null)
            {
                body["quantity"] = CSharpExpressionConverter.ConvertToken(bodyquantity);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["currency"] = CSharpExpressionConverter.ConvertToken(bodycurrency);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodypaymentGateway != null)
            {
                body["payment_gateway"] = CSharpExpressionConverter.ConvertToken(bodypaymentGateway);
                bodypropCount++;
            }

            if (bodypaymentMode != null)
            {
                body["payment_mode"] = CSharpExpressionConverter.Convert(bodypaymentMode);
                bodypropCount++;
            }

            if (bodyflpChecksum != null)
            {
                body["flp_checksum"] = CSharpExpressionConverter.ConvertToken(bodyflpChecksum);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ScreenPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<FeedbackPostResponse> Feedback(Expression<Func<string>> bodyid = null, Expression<Func<bodyactionInput>> bodyaction = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = "/feedback";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodyaction != null)
            {
                if (bodyaction != null)
                {
                    body["action"] = CSharpExpressionConverter.Convert(bodyaction);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["action"] = "APPROVE";
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FeedbackPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<ResultGetResponse> ResultGet(Expression<Func<string>> id = null, Expression<Func<idTypeInput>> idType = null)
        {
            var apiCallPath = "/result";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["id_type"] = Convert.ToString("fraudlabspro_id");
            if (idType != null)
                callPayload.Queries["id_type"] = CSharpExpressionConverter.Convert(idType);
            return new ApiConnectionAction<ResultGetResponse>(callPayload);
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

    public enum bodypaymentModeInput
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

    public enum bodyactionInput
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