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
        public IBodyWorkflowAction<ScreenPostResponse, ApiConnectionActionConfiguration> Screen(Expression<Func<string>> bodyip = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodybillAddr = null, Expression<Func<string>> bodybillCity = null, Expression<Func<string>> bodybillState = null, Expression<Func<string>> bodybillCountry = null, Expression<Func<string>> bodybillZipCode = null, Expression<Func<string>> bodyshipLastName = null, Expression<Func<string>> bodyshipFirstName = null, Expression<Func<string>> bodyshipAddr = null, Expression<Func<string>> bodyshipCity = null, Expression<Func<string>> bodyshipState = null, Expression<Func<string>> bodyshipCountry = null, Expression<Func<string>> bodyshipZipCode = null, Expression<Func<string>> bodyuserPhone = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyemailHash = null, Expression<Func<string>> bodyemailDomain = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodybinNo = null, Expression<Func<string>> bodycardHash = null, Expression<Func<string>> bodyavsResult = null, Expression<Func<string>> bodycvvResult = null, Expression<Func<string>> bodyuserOrderId = null, Expression<Func<string>> bodyuserOrderMemo = null, Expression<Func<double>> bodyamount = null, Expression<Func<int>> bodyquantity = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodypaymentGateway = null, Expression<Func<bodypaymentModeInput>> bodypaymentMode = null, Expression<Func<string>> bodyflpChecksum = null)
        {
            var __workflow_bodyip = WorkflowExpression.Compile(bodyip, nameof(bodyip), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodybillAddr = WorkflowExpression.Compile(bodybillAddr, nameof(bodybillAddr), required: false);
            var __workflow_bodybillCity = WorkflowExpression.Compile(bodybillCity, nameof(bodybillCity), required: false);
            var __workflow_bodybillState = WorkflowExpression.Compile(bodybillState, nameof(bodybillState), required: false);
            var __workflow_bodybillCountry = WorkflowExpression.Compile(bodybillCountry, nameof(bodybillCountry), required: false);
            var __workflow_bodybillZipCode = WorkflowExpression.Compile(bodybillZipCode, nameof(bodybillZipCode), required: false);
            var __workflow_bodyshipLastName = WorkflowExpression.Compile(bodyshipLastName, nameof(bodyshipLastName), required: false);
            var __workflow_bodyshipFirstName = WorkflowExpression.Compile(bodyshipFirstName, nameof(bodyshipFirstName), required: false);
            var __workflow_bodyshipAddr = WorkflowExpression.Compile(bodyshipAddr, nameof(bodyshipAddr), required: false);
            var __workflow_bodyshipCity = WorkflowExpression.Compile(bodyshipCity, nameof(bodyshipCity), required: false);
            var __workflow_bodyshipState = WorkflowExpression.Compile(bodyshipState, nameof(bodyshipState), required: false);
            var __workflow_bodyshipCountry = WorkflowExpression.Compile(bodyshipCountry, nameof(bodyshipCountry), required: false);
            var __workflow_bodyshipZipCode = WorkflowExpression.Compile(bodyshipZipCode, nameof(bodyshipZipCode), required: false);
            var __workflow_bodyuserPhone = WorkflowExpression.Compile(bodyuserPhone, nameof(bodyuserPhone), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyemailHash = WorkflowExpression.Compile(bodyemailHash, nameof(bodyemailHash), required: false);
            var __workflow_bodyemailDomain = WorkflowExpression.Compile(bodyemailDomain, nameof(bodyemailDomain), required: false);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodybinNo = WorkflowExpression.Compile(bodybinNo, nameof(bodybinNo), required: false);
            var __workflow_bodycardHash = WorkflowExpression.Compile(bodycardHash, nameof(bodycardHash), required: false);
            var __workflow_bodyavsResult = WorkflowExpression.Compile(bodyavsResult, nameof(bodyavsResult), required: false);
            var __workflow_bodycvvResult = WorkflowExpression.Compile(bodycvvResult, nameof(bodycvvResult), required: false);
            var __workflow_bodyuserOrderId = WorkflowExpression.Compile(bodyuserOrderId, nameof(bodyuserOrderId), required: false);
            var __workflow_bodyuserOrderMemo = WorkflowExpression.Compile(bodyuserOrderMemo, nameof(bodyuserOrderMemo), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodypaymentGateway = WorkflowExpression.Compile(bodypaymentGateway, nameof(bodypaymentGateway), required: false);
            var __workflow_bodypaymentMode = WorkflowExpression.Compile(bodypaymentMode, nameof(bodypaymentMode), required: false);
            var __workflow_bodyflpChecksum = WorkflowExpression.Compile(bodyflpChecksum, nameof(bodyflpChecksum), required: false);
            return new DeferredBodyAction<ScreenPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/screen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyip != null)
                {
                    body["ip"] = ExpressionConverter.ConvertO(__workflow_bodyip);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddr != null)
                {
                    body["bill_addr"] = ExpressionConverter.ConvertO(__workflow_bodybillAddr);
                    bodypropCount++;
                }

                if (__workflow_bodybillCity != null)
                {
                    body["bill_city"] = ExpressionConverter.ConvertO(__workflow_bodybillCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillState != null)
                {
                    body["bill_state"] = ExpressionConverter.ConvertO(__workflow_bodybillState);
                    bodypropCount++;
                }

                if (__workflow_bodybillCountry != null)
                {
                    body["bill_country"] = ExpressionConverter.ConvertO(__workflow_bodybillCountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillZipCode != null)
                {
                    body["bill_zip_code"] = ExpressionConverter.ConvertO(__workflow_bodybillZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipLastName != null)
                {
                    body["ship_last_name"] = ExpressionConverter.ConvertO(__workflow_bodyshipLastName);
                    bodypropCount++;
                }

                if (__workflow_bodyshipFirstName != null)
                {
                    body["ship_first_name"] = ExpressionConverter.ConvertO(__workflow_bodyshipFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddr != null)
                {
                    body["ship_addr"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddr);
                    bodypropCount++;
                }

                if (__workflow_bodyshipCity != null)
                {
                    body["ship_city"] = ExpressionConverter.ConvertO(__workflow_bodyshipCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipState != null)
                {
                    body["ship_state"] = ExpressionConverter.ConvertO(__workflow_bodyshipState);
                    bodypropCount++;
                }

                if (__workflow_bodyshipCountry != null)
                {
                    body["ship_country"] = ExpressionConverter.ConvertO(__workflow_bodyshipCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshipZipCode != null)
                {
                    body["ship_zip_code"] = ExpressionConverter.ConvertO(__workflow_bodyshipZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyuserPhone != null)
                {
                    body["user_phone"] = ExpressionConverter.ConvertO(__workflow_bodyuserPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyemailHash != null)
                {
                    body["email_hash"] = ExpressionConverter.ConvertO(__workflow_bodyemailHash);
                    bodypropCount++;
                }

                if (__workflow_bodyemailDomain != null)
                {
                    body["email_domain"] = ExpressionConverter.ConvertO(__workflow_bodyemailDomain);
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodybinNo != null)
                {
                    body["bin_no"] = ExpressionConverter.ConvertO(__workflow_bodybinNo);
                    bodypropCount++;
                }

                if (__workflow_bodycardHash != null)
                {
                    body["card_hash"] = ExpressionConverter.ConvertO(__workflow_bodycardHash);
                    bodypropCount++;
                }

                if (__workflow_bodyavsResult != null)
                {
                    body["avs_result"] = ExpressionConverter.ConvertO(__workflow_bodyavsResult);
                    bodypropCount++;
                }

                if (__workflow_bodycvvResult != null)
                {
                    body["cvv_result"] = ExpressionConverter.ConvertO(__workflow_bodycvvResult);
                    bodypropCount++;
                }

                if (__workflow_bodyuserOrderId != null)
                {
                    body["user_order_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserOrderId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserOrderMemo != null)
                {
                    body["user_order_memo"] = ExpressionConverter.ConvertO(__workflow_bodyuserOrderMemo);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentGateway != null)
                {
                    body["payment_gateway"] = ExpressionConverter.ConvertO(__workflow_bodypaymentGateway);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentMode != null)
                {
                    body["payment_mode"] = ExpressionConverter.ConvertO(__workflow_bodypaymentMode);
                    bodypropCount++;
                }

                if (__workflow_bodyflpChecksum != null)
                {
                    body["flp_checksum"] = ExpressionConverter.ConvertO(__workflow_bodyflpChecksum);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ScreenPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        public IBodyWorkflowAction<FeedbackPostResponse, ApiConnectionActionConfiguration> Feedback(Expression<Func<string>> bodyid = null, Expression<Func<bodyactionInput>> bodyaction = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<FeedbackPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyaction != null)
                {
                    if (__workflow_bodyaction != null)
                    {
                        body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["action"] = "APPROVE";
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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