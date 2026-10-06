//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Numlookupapiip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NumlookupapiipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "numlookupapiip")]
        [WorkflowExpressionFactory(nameof(__BuildNumberGet))]
        public IBodyWorkflowAction<NumberGetResponse> NumberGet([WorkflowExpression] Func<string> phoneNumber, [WorkflowExpression] Func<string> countryCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "numlookupapiip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NumberGetResponse> __BuildNumberGet(WorkflowExpression<string> phoneNumber, WorkflowExpression<string> countryCode = null)
        {
            WorkflowExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: false);
            return new DeferredBodyAction<NumberGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/validate/{0}", ExpressionConverter.ConvertWithUrlEncoding(phoneNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                return new ApiConnectionAction<NumberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "numlookupapiip")]
        public IBodyWorkflowAction<StatusGetResponse> StatusGet()
        {
            var apiCallPath = "/status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusGetResponse>(callPayload);
        }
    }

    public class NumlookupapiipTriggers([ConnectionName] string connectionId)
    {
    }

    public class NumberGetResponse
    {
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("local_format")]
        public string LocalFormat { get; set; }

        [JsonProperty("international_format")]
        public string InternationalFormat { get; set; }

        [JsonProperty("country_prefix")]
        public string CountryPrefix { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("line_type")]
        public string LineType { get; set; }
    }

    public class StatusGetResponse
    {
        [JsonProperty("quotas")]
        public StatusGetResponseQuotasType Quotas { get; set; }
    }

    public class StatusGetResponseQuotasType
    {
        [JsonProperty("month")]
        public StatusGetResponseQuotasTypeMonthType Month { get; set; }
    }

    public class StatusGetResponseQuotasTypeMonthType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Numlookupapiip;

    public partial class WorkflowManagedActions
    {
        public NumlookupapiipActions Numlookupapiip(string connectionId) => new NumlookupapiipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NumlookupapiipTriggers Numlookupapiip(string connectionId) => new NumlookupapiipTriggers(connectionId);
    }
}