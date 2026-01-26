//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vatcheckapiip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VatcheckapiipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vatcheckapiip")]
        public IBodyWorkflowAction<StatusResponse> Status()
        {
            var apiCallPath = "/v2/status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vatcheckapiip")]
        public IBodyWorkflowAction<ValidateResponse> Validate(Expression<Func<int>> vatNumber = null, Expression<Func<string>> countryCode = null)
        {
            var apiCallPath = "/v2/check";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (vatNumber != null)
                callPayload.Queries["vat_number"] = ExpressionConverter.Convert(vatNumber);
            if (countryCode != null)
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            return new ApiConnectionAction<ValidateResponse>(callPayload);
        }
    }

    public class VatcheckapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class StatusResponse
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("quotas")]
        public StatusResponseQuotasType Quotas { get; set; }
    }

    public class StatusResponseQuotasType
    {
        [JsonProperty("month")]
        public StatusResponseQuotasTypeMonthType Month { get; set; }

        [JsonProperty("grace")]
        public StatusResponseQuotasTypeGraceType Grace { get; set; }
    }

    public class StatusResponseQuotasTypeMonthType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class StatusResponseQuotasTypeGraceType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class ValidateResponse
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("format_valid")]
        public bool FormatValid { get; set; }

        [JsonProperty("checksum_valid")]
        public bool ChecksumValid { get; set; }

        [JsonProperty("registration_info")]
        public ValidateResponseRegistrationInfoType RegistrationInfo { get; set; }

        [JsonProperty("registration_info_history")]
        public JToken[] RegistrationInfoHistory { get; set; }
    }

    public class ValidateResponseRegistrationInfoType
    {
        [JsonProperty("is_registered")]
        public bool IsRegistered { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address_parts")]
        public string AddressParts { get; set; }

        [JsonProperty("checked_at")]
        public string CheckedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vatcheckapiip;

    public partial class WorkflowManagedActions
    {
        public VatcheckapiipActions Vatcheckapiip(string connectionId) => new VatcheckapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VatcheckapiipTriggers Vatcheckapiip(string connectionId) => new VatcheckapiipTriggers(connectionId);
    }
}