//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ukbankholidays
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UkbankholidaysActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ukbankholidays")]
        public IBodyWorkflowAction<AllKingdomHolidaysResponse> AllKingdomHolidays()
        {
            var apiCallPath = "/bank-holidays.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AllKingdomHolidaysResponse>(callPayload);
        }
    }

    public class UkbankholidaysTriggers([ConnectionName] string connectionId)
    {
    }

    public class AllKingdomHolidaysResponse
    {
        [JsonProperty("england-and-wales")]
        public AllKingdomHolidaysResponseEnglandAndWalesType EnglandAndWales { get; set; }

        [JsonProperty("scotland")]
        public AllKingdomHolidaysResponseScotlandType Scotland { get; set; }

        [JsonProperty("northern-ireland")]
        public AllKingdomHolidaysResponseNorthernIrelandType NorthernIreland { get; set; }
    }

    public class AllKingdomHolidaysResponseEnglandAndWalesType
    {
        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("events")]
        public AllKingdomHolidaysResponseEnglandAndWalesTypeEventsTypeItem[] Events { get; set; }
    }

    public class AllKingdomHolidaysResponseEnglandAndWalesTypeEventsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("bunting")]
        public bool Bunting { get; set; }
    }

    public class AllKingdomHolidaysResponseScotlandType
    {
        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("events")]
        public AllKingdomHolidaysResponseScotlandTypeEventsTypeItem[] Events { get; set; }
    }

    public class AllKingdomHolidaysResponseScotlandTypeEventsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("bunting")]
        public bool Bunting { get; set; }
    }

    public class AllKingdomHolidaysResponseNorthernIrelandType
    {
        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("events")]
        public AllKingdomHolidaysResponseNorthernIrelandTypeEventsTypeItem[] Events { get; set; }
    }

    public class AllKingdomHolidaysResponseNorthernIrelandTypeEventsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("bunting")]
        public bool Bunting { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Ukbankholidays;

    public partial class WorkflowManagedActions
    {
        public UkbankholidaysActions Ukbankholidays(string connectionId) => new UkbankholidaysActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UkbankholidaysTriggers Ukbankholidays(string connectionId) => new UkbankholidaysTriggers(connectionId);
    }
}