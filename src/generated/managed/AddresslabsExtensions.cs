//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Addresslabs
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AddresslabsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "addresslabs")]
        [WorkflowExpressionFactory(nameof(__BuildParseAddress))]
        public IBodyWorkflowAction<ParseAddressResponse> ParseAddress([WorkflowExpression] Func<string> bodyaddress)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ParseAddressResponse> __BuildParseAddress(WorkflowValue<string> bodyaddress)
        {
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: true);
            return new DeferredBodyAction<ParseAddressResponse>(() =>
            {
                var apiCallPath = "/parsed-address";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ParseAddressResponse>(callPayload);
            });
        }
    }

    public class AddresslabsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ParseAddressResponse
    {
        [JsonProperty("number")]
        public string StreetNumber { get; set; }

        [JsonProperty("street")]
        public string StreetName { get; set; }

        [JsonProperty("street_suffix")]
        public string StreetSuffix { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unit_designator")]
        public string UnitDesignator { get; set; }

        [JsonProperty("street_pre_direction")]
        public string StreetPreDirection { get; set; }

        [JsonProperty("street_post_direction")]
        public string StreetPostDirection { get; set; }

        [JsonProperty("street2")]
        public string SecondStreetName { get; set; }

        [JsonProperty("street2_suffix")]
        public string SecondStreetSuffix { get; set; }

        [JsonProperty("street2_pre_direction")]
        public string SecondStreetPreDirection { get; set; }

        [JsonProperty("street2_post_direction")]
        public string SecondStreetPostDirection { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_fips")]
        public string StateFIPSCode { get; set; }

        [JsonProperty("zip")]
        public string ZIPCode { get; set; }

        [JsonProperty("zip4")]
        public string ZIP4Code { get; set; }

        [JsonProperty("intersection")]
        public bool IsIntersection { get; set; }

        [JsonProperty("delivery")]
        public ParseAddressResponseDeliveryType Delivery { get; set; }

        [JsonProperty("input")]
        public string InputAddress { get; set; }
    }

    public class ParseAddressResponseDeliveryType
    {
        [JsonProperty("address_line")]
        public string DeliveryAddressLine { get; set; }

        [JsonProperty("last_line")]
        public string DeliveryLastLine { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Addresslabs;

    public partial class WorkflowManagedActions
    {
        public AddresslabsActions Addresslabs(string connectionId) => new AddresslabsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AddresslabsTriggers Addresslabs(string connectionId) => new AddresslabsTriggers(connectionId);
    }
}
