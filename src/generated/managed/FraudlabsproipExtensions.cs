//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fraudlabsproip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FraudlabsproipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fraudlabsproip")]
        [WorkflowExpressionFactory(nameof(__BuildScreen))]
        public IBodyWorkflowAction<ScreenPostResponse> Screen([WorkflowExpression] Func<string> bodyip = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodybillAddr = null, [WorkflowExpression] Func<string> bodybillCity = null, [WorkflowExpression] Func<string> bodybillState = null, [WorkflowExpression] Func<string> bodybillCountry = null, [WorkflowExpression] Func<string> bodybillZipCode = null, [WorkflowExpression] Func<string> bodyshipLastName = null, [WorkflowExpression] Func<string> bodyshipFirstName = null, [WorkflowExpression] Func<string> bodyshipAddr = null, [WorkflowExpression] Func<string> bodyshipCity = null, [WorkflowExpression] Func<string> bodyshipState = null, [WorkflowExpression] Func<string> bodyshipCountry = null, [WorkflowExpression] Func<string> bodyshipZipCode = null, [WorkflowExpression] Func<string> bodyuserPhone = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyemailHash = null, [WorkflowExpression] Func<string> bodyemailDomain = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodybinNo = null, [WorkflowExpression] Func<string> bodycardHash = null, [WorkflowExpression] Func<string> bodyavsResult = null, [WorkflowExpression] Func<string> bodycvvResult = null, [WorkflowExpression] Func<string> bodyuserOrderId = null, [WorkflowExpression] Func<string> bodyuserOrderMemo = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<int> bodyquantity = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodypaymentGateway = null, [WorkflowExpression] Func<bodypaymentModeInput> bodypaymentMode = null, [WorkflowExpression] Func<string> bodyflpChecksum = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScreenPostResponse> __BuildScreen(WorkflowExpression<string> bodyip = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodybillAddr = null, WorkflowExpression<string> bodybillCity = null, WorkflowExpression<string> bodybillState = null, WorkflowExpression<string> bodybillCountry = null, WorkflowExpression<string> bodybillZipCode = null, WorkflowExpression<string> bodyshipLastName = null, WorkflowExpression<string> bodyshipFirstName = null, WorkflowExpression<string> bodyshipAddr = null, WorkflowExpression<string> bodyshipCity = null, WorkflowExpression<string> bodyshipState = null, WorkflowExpression<string> bodyshipCountry = null, WorkflowExpression<string> bodyshipZipCode = null, WorkflowExpression<string> bodyuserPhone = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyemailHash = null, WorkflowExpression<string> bodyemailDomain = null, WorkflowExpression<string> bodyusername = null, WorkflowExpression<string> bodybinNo = null, WorkflowExpression<string> bodycardHash = null, WorkflowExpression<string> bodyavsResult = null, WorkflowExpression<string> bodycvvResult = null, WorkflowExpression<string> bodyuserOrderId = null, WorkflowExpression<string> bodyuserOrderMemo = null, WorkflowExpression<double> bodyamount = null, WorkflowExpression<int> bodyquantity = null, WorkflowExpression<string> bodycurrency = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodypaymentGateway = null, WorkflowExpression<bodypaymentModeInput> bodypaymentMode = null, WorkflowExpression<string> bodyflpChecksum = null)
        {
            WorkflowExpression.Validate(bodyip, nameof(bodyip), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodybillAddr, nameof(bodybillAddr), required: false);
            WorkflowExpression.Validate(bodybillCity, nameof(bodybillCity), required: false);
            WorkflowExpression.Validate(bodybillState, nameof(bodybillState), required: false);
            WorkflowExpression.Validate(bodybillCountry, nameof(bodybillCountry), required: false);
            WorkflowExpression.Validate(bodybillZipCode, nameof(bodybillZipCode), required: false);
            WorkflowExpression.Validate(bodyshipLastName, nameof(bodyshipLastName), required: false);
            WorkflowExpression.Validate(bodyshipFirstName, nameof(bodyshipFirstName), required: false);
            WorkflowExpression.Validate(bodyshipAddr, nameof(bodyshipAddr), required: false);
            WorkflowExpression.Validate(bodyshipCity, nameof(bodyshipCity), required: false);
            WorkflowExpression.Validate(bodyshipState, nameof(bodyshipState), required: false);
            WorkflowExpression.Validate(bodyshipCountry, nameof(bodyshipCountry), required: false);
            WorkflowExpression.Validate(bodyshipZipCode, nameof(bodyshipZipCode), required: false);
            WorkflowExpression.Validate(bodyuserPhone, nameof(bodyuserPhone), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyemailHash, nameof(bodyemailHash), required: false);
            WorkflowExpression.Validate(bodyemailDomain, nameof(bodyemailDomain), required: false);
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            WorkflowExpression.Validate(bodybinNo, nameof(bodybinNo), required: false);
            WorkflowExpression.Validate(bodycardHash, nameof(bodycardHash), required: false);
            WorkflowExpression.Validate(bodyavsResult, nameof(bodyavsResult), required: false);
            WorkflowExpression.Validate(bodycvvResult, nameof(bodycvvResult), required: false);
            WorkflowExpression.Validate(bodyuserOrderId, nameof(bodyuserOrderId), required: false);
            WorkflowExpression.Validate(bodyuserOrderMemo, nameof(bodyuserOrderMemo), required: false);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyquantity, nameof(bodyquantity), required: false);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodypaymentGateway, nameof(bodypaymentGateway), required: false);
            WorkflowExpression.Validate(bodypaymentMode, nameof(bodypaymentMode), required: false);
            WorkflowExpression.Validate(bodyflpChecksum, nameof(bodyflpChecksum), required: false);
            return new DeferredBodyAction<ScreenPostResponse>(() =>
            {
                var apiCallPath = "/screen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyip != null)
                {
                    body["ip"] = ExpressionConverter.ConvertO(bodyip);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodybillAddr != null)
                {
                    body["bill_addr"] = ExpressionConverter.ConvertO(bodybillAddr);
                    bodypropCount++;
                }

                if (bodybillCity != null)
                {
                    body["bill_city"] = ExpressionConverter.ConvertO(bodybillCity);
                    bodypropCount++;
                }

                if (bodybillState != null)
                {
                    body["bill_state"] = ExpressionConverter.ConvertO(bodybillState);
                    bodypropCount++;
                }

                if (bodybillCountry != null)
                {
                    body["bill_country"] = ExpressionConverter.ConvertO(bodybillCountry);
                    bodypropCount++;
                }

                if (bodybillZipCode != null)
                {
                    body["bill_zip_code"] = ExpressionConverter.ConvertO(bodybillZipCode);
                    bodypropCount++;
                }

                if (bodyshipLastName != null)
                {
                    body["ship_last_name"] = ExpressionConverter.ConvertO(bodyshipLastName);
                    bodypropCount++;
                }

                if (bodyshipFirstName != null)
                {
                    body["ship_first_name"] = ExpressionConverter.ConvertO(bodyshipFirstName);
                    bodypropCount++;
                }

                if (bodyshipAddr != null)
                {
                    body["ship_addr"] = ExpressionConverter.ConvertO(bodyshipAddr);
                    bodypropCount++;
                }

                if (bodyshipCity != null)
                {
                    body["ship_city"] = ExpressionConverter.ConvertO(bodyshipCity);
                    bodypropCount++;
                }

                if (bodyshipState != null)
                {
                    body["ship_state"] = ExpressionConverter.ConvertO(bodyshipState);
                    bodypropCount++;
                }

                if (bodyshipCountry != null)
                {
                    body["ship_country"] = ExpressionConverter.ConvertO(bodyshipCountry);
                    bodypropCount++;
                }

                if (bodyshipZipCode != null)
                {
                    body["ship_zip_code"] = ExpressionConverter.ConvertO(bodyshipZipCode);
                    bodypropCount++;
                }

                if (bodyuserPhone != null)
                {
                    body["user_phone"] = ExpressionConverter.ConvertO(bodyuserPhone);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyemailHash != null)
                {
                    body["email_hash"] = ExpressionConverter.ConvertO(bodyemailHash);
                    bodypropCount++;
                }

                if (bodyemailDomain != null)
                {
                    body["email_domain"] = ExpressionConverter.ConvertO(bodyemailDomain);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(bodyusername);
                    bodypropCount++;
                }

                if (bodybinNo != null)
                {
                    body["bin_no"] = ExpressionConverter.ConvertO(bodybinNo);
                    bodypropCount++;
                }

                if (bodycardHash != null)
                {
                    body["card_hash"] = ExpressionConverter.ConvertO(bodycardHash);
                    bodypropCount++;
                }

                if (bodyavsResult != null)
                {
                    body["avs_result"] = ExpressionConverter.ConvertO(bodyavsResult);
                    bodypropCount++;
                }

                if (bodycvvResult != null)
                {
                    body["cvv_result"] = ExpressionConverter.ConvertO(bodycvvResult);
                    bodypropCount++;
                }

                if (bodyuserOrderId != null)
                {
                    body["user_order_id"] = ExpressionConverter.ConvertO(bodyuserOrderId);
                    bodypropCount++;
                }

                if (bodyuserOrderMemo != null)
                {
                    body["user_order_memo"] = ExpressionConverter.ConvertO(bodyuserOrderMemo);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                    bodypropCount++;
                }

                if (bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                    bodypropCount++;
                }

                if (bodypaymentGateway != null)
                {
                    body["payment_gateway"] = ExpressionConverter.ConvertO(bodypaymentGateway);
                    bodypropCount++;
                }

                if (bodypaymentMode != null)
                {
                    body["payment_mode"] = ExpressionConverter.ConvertO(bodypaymentMode);
                    bodypropCount++;
                }

                if (bodyflpChecksum != null)
                {
                    body["flp_checksum"] = ExpressionConverter.ConvertO(bodyflpChecksum);
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
        [WorkflowExpressionFactory(nameof(__BuildFeedback))]
        public IBodyWorkflowAction<FeedbackPostResponse> Feedback([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bodyactionInput> bodyaction = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FeedbackPostResponse> __BuildFeedback(WorkflowExpression<string> bodyid = null, WorkflowExpression<bodyactionInput> bodyaction = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyaction, nameof(bodyaction), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<FeedbackPostResponse>(() =>
            {
                var apiCallPath = "/feedback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyaction != null)
                {
                    if (bodyaction != null)
                    {
                        body["action"] = ExpressionConverter.ConvertO(bodyaction);
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
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
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
        [WorkflowExpressionFactory(nameof(__BuildResultGet))]
        public IBodyWorkflowAction<ResultGetResponse> ResultGet([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<idTypeInput> idType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResultGetResponse> __BuildResultGet(WorkflowExpression<string> id = null, WorkflowExpression<idTypeInput> idType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(idType, nameof(idType), required: false);
            return new DeferredBodyAction<ResultGetResponse>(() =>
            {
                var apiCallPath = "/result";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["id_type"] = Convert.ToString("fraudlabspro_id");
                if (idType != null)
                    callPayload.Queries["id_type"] = ExpressionConverter.Convert(idType);
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