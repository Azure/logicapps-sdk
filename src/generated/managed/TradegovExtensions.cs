//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tradegov
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TradegovActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<BSPResponse> BusinessServiceProvidersSearch([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> itaOffices = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> size = null)
        {
            var apiCallPath = "/business_service_providers/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (categories != null)
                callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
            if (itaOffices != null)
                callPayload.Queries["ita_offices"] = ExpressionConverter.Convert(itaOffices);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<BSPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<BSPCountResponse> BusinessServiceProvidersCount()
        {
            var apiCallPath = "/business_service_providers/v1/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BSPCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<ScreeningListSearchResponse> ConsolidatedScreeningListSearch([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<fuzzyNameInput> fuzzyName = null, [WorkflowExpression] Func<string> sources = null, [WorkflowExpression] Func<string> types = null, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> fullAddress = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> size = null)
        {
            var apiCallPath = "/consolidated_screening_list/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (fuzzyName != null)
                callPayload.Queries["fuzzy_name"] = ExpressionConverter.Convert(fuzzyName);
            if (sources != null)
                callPayload.Queries["sources"] = ExpressionConverter.Convert(sources);
            if (types != null)
                callPayload.Queries["types"] = ExpressionConverter.Convert(types);
            if (countries != null)
                callPayload.Queries["countries"] = ExpressionConverter.Convert(countries);
            if (address != null)
                callPayload.Queries["address"] = ExpressionConverter.Convert(address);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (postalCode != null)
                callPayload.Queries["postal_code"] = ExpressionConverter.Convert(postalCode);
            if (fullAddress != null)
                callPayload.Queries["full_address"] = ExpressionConverter.Convert(fullAddress);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ScreeningListSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<ScreeningSourcesResponse> ConsolidatedScreeningListSources()
        {
            var apiCallPath = "/consolidated_screening_list/v1/sources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ScreeningSourcesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<DeMinimisListResponse> DeMinimisList([WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/de_minimis/v1/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<DeMinimisListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<DeMinimisListResponse> DeMinimisSearch([WorkflowExpression] Func<string> countryCodes = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/de_minimis/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (countryCodes != null)
                callPayload.Queries["country_codes"] = ExpressionConverter.Convert(countryCodes);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<DeMinimisListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<ITAOfficeSearchResponse> ITAOfficeLocationsSearch([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> countryCodes = null, [WorkflowExpression] Func<string> states = null, [WorkflowExpression] Func<string> assignedZipCodes = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> size = null)
        {
            var apiCallPath = "/ita_office_locations/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (countryCodes != null)
                callPayload.Queries["country_codes"] = ExpressionConverter.Convert(countryCodes);
            if (states != null)
                callPayload.Queries["states"] = ExpressionConverter.Convert(states);
            if (assignedZipCodes != null)
                callPayload.Queries["assigned_zip_codes"] = ExpressionConverter.Convert(assignedZipCodes);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ITAOfficeSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<ITAOfficeCountResponse> ITAOfficeLocationsCount()
        {
            var apiCallPath = "/ita_office_locations/v1/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ITAOfficeCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<TradeEventSearchResponse> TradeEventsSearch([WorkflowExpression] Func<string> sources = null, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> eventTypes = null, [WorkflowExpression] Func<string> industries = null, [WorkflowExpression] Func<string> states = null, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> startDateRangeFrom = null, [WorkflowExpression] Func<string> startDateRangeTo = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/trade_events/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sources != null)
                callPayload.Queries["sources"] = ExpressionConverter.Convert(sources);
            if (countries != null)
                callPayload.Queries["countries"] = ExpressionConverter.Convert(countries);
            if (eventTypes != null)
                callPayload.Queries["event_types"] = ExpressionConverter.Convert(eventTypes);
            if (industries != null)
                callPayload.Queries["industries"] = ExpressionConverter.Convert(industries);
            if (states != null)
                callPayload.Queries["states"] = ExpressionConverter.Convert(states);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (startDateRangeFrom != null)
                callPayload.Queries["start_date_range[from]"] = ExpressionConverter.Convert(startDateRangeFrom);
            if (startDateRangeTo != null)
                callPayload.Queries["start_date_range[to]"] = ExpressionConverter.Convert(startDateRangeTo);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<TradeEventSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<TradeEventCountResponse> TradeEventsCount()
        {
            var apiCallPath = "/trade_events/v1/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TradeEventCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<TradeLeadsSearchResponse> SearchTradeLeads([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> countryCodes = null, [WorkflowExpression] Func<string> tenderStartDateRangeFrom = null, [WorkflowExpression] Func<string> tenderStartDateRangeTo = null, [WorkflowExpression] Func<string> contractStartDateRangeFrom = null, [WorkflowExpression] Func<string> contractStartDateRangeTo = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<int> offset = null)
        {
            var apiCallPath = "/trade_leads/v1/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (countryCodes != null)
                callPayload.Queries["country_codes"] = ExpressionConverter.Convert(countryCodes);
            if (tenderStartDateRangeFrom != null)
                callPayload.Queries["tender_start_date_range[from]"] = ExpressionConverter.Convert(tenderStartDateRangeFrom);
            if (tenderStartDateRangeTo != null)
                callPayload.Queries["tender_start_date_range[to]"] = ExpressionConverter.Convert(tenderStartDateRangeTo);
            if (contractStartDateRangeFrom != null)
                callPayload.Queries["contract_start_date_range[from]"] = ExpressionConverter.Convert(contractStartDateRangeFrom);
            if (contractStartDateRangeTo != null)
                callPayload.Queries["contract_start_date_range[to]"] = ExpressionConverter.Convert(contractStartDateRangeTo);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<TradeLeadsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<TradeLeadsCountResponse> GetTradeLeadsCount()
        {
            var apiCallPath = "/trade_leads/v1/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TradeLeadsCountResponse>(callPayload);
        }
    }

    public class TradegovTriggers([ConnectionName] string connectionId)
    {
    }

    public class BSPResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }

        [JsonProperty("results")]
        public BSPItem[] Results { get; set; }

        [JsonProperty("aggregations")]
        public BSPResponseAggregationsType Aggregations { get; set; }
    }

    public class BSPItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("ita_office")]
        public string ItaOffice { get; set; }

        [JsonProperty("ita_contact_email")]
        public string ItaContactEmail { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_address")]
        public string CompanyAddress { get; set; }

        [JsonProperty("company_description")]
        public string CompanyDescription { get; set; }

        [JsonProperty("company_email")]
        public string CompanyEmail { get; set; }

        [JsonProperty("company_phone")]
        public string CompanyPhone { get; set; }

        [JsonProperty("company_website")]
        public string CompanyWebsite { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("contact_title")]
        public string ContactTitle { get; set; }
    }

    public class BSPResponseAggregationsType
    {
        [JsonProperty("categories")]
        public AggregationItem[] Categories { get; set; }

        [JsonProperty("ita_offices")]
        public AggregationItem[] ItaOffices { get; set; }
    }

    public class AggregationItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BSPCountResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("aggregations")]
        public BSPCountResponseAggregationsType Aggregations { get; set; }
    }

    public class BSPCountResponseAggregationsType
    {
        [JsonProperty("categories")]
        public AggregationItem[] Categories { get; set; }

        [JsonProperty("ita_offices")]
        public AggregationItem[] ItaOffices { get; set; }
    }

    public class ScreeningListSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("sources")]
        public SourceAggregation[] Sources { get; set; }

        [JsonProperty("results")]
        public ScreeningEntity[] Results { get; set; }
    }

    public class SourceAggregation
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class ScreeningEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alt_names")]
        public string[] AltNames { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("entity_number")]
        public string EntityNumber { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("programs")]
        public string[] Programs { get; set; }

        [JsonProperty("addresses")]
        public AddressInfo[] Addresses { get; set; }

        [JsonProperty("ids")]
        public Identifier[] Ids { get; set; }

        [JsonProperty("source_information_url")]
        public string SourceInformationUrl { get; set; }

        [JsonProperty("source_list_url")]
        public string SourceListUrl { get; set; }
    }

    public class AddressInfo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class Identifier
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("issue_date")]
        public string IssueDate { get; set; }
    }

    public enum fuzzyNameInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True
    }

    public class ScreeningSourcesResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("results")]
        public ScreeningSource[] Results { get; set; }
    }

    public class ScreeningSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("import_rate")]
        public string ImportRate { get; set; }

        [JsonProperty("last_imported")]
        public string LastImported { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_last_updated")]
        public string SourceLastUpdated { get; set; }
    }

    public class DeMinimisListResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }

        [JsonProperty("results")]
        public DeMinimisRecord[] Results { get; set; }
    }

    public class DeMinimisRecord
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("de_minimis_currency")]
        public string DeMinimisCurrency { get; set; }

        [JsonProperty("de_minimis_value")]
        public double DeMinimisValue { get; set; }

        [JsonProperty("vat_currency")]
        public string VatCurrency { get; set; }

        [JsonProperty("vat_amount")]
        public double VatAmount { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class ITAOfficeSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }

        [JsonProperty("results")]
        public ITAOffice[] Results { get; set; }

        [JsonProperty("aggregations")]
        public ITAOfficeSearchResponseAggregationsType Aggregations { get; set; }
    }

    public class ITAOffice
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("office_name")]
        public string OfficeName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address")]
        public string[] Address { get; set; }

        [JsonProperty("apo_address")]
        public string[] ApoAddress { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("mail_instructions")]
        public string MailInstructions { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("post_type")]
        public string PostType { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("assigned_zip_codes")]
        public string[] AssignedZipCodes { get; set; }
    }

    public class ITAOfficeSearchResponseAggregationsType
    {
        [JsonProperty("country_codes")]
        public AggregationItem[] CountryCodes { get; set; }

        [JsonProperty("states")]
        public AggregationItem[] States { get; set; }
    }

    public class ITAOfficeCountResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("aggregations")]
        public ITAOfficeCountResponseAggregationsType Aggregations { get; set; }
    }

    public class ITAOfficeCountResponseAggregationsType
    {
        [JsonProperty("country_codes")]
        public AggregationItem[] CountryCodes { get; set; }

        [JsonProperty("states")]
        public AggregationItem[] States { get; set; }
    }

    public class TradeEventSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }

        [JsonProperty("results")]
        public TradeEvent[] Results { get; set; }

        [JsonProperty("aggregations")]
        public TradeEventSearchResponseAggregationsType Aggregations { get; set; }
    }

    public class TradeEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("registration_title")]
        public string RegistrationTitle { get; set; }

        [JsonProperty("registration_url")]
        public string RegistrationUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("industries")]
        public string[] Industries { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("venues")]
        public Venue[] Venues { get; set; }
    }

    public class Contact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("person_title")]
        public string PersonTitle { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }
    }

    public class Venue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class TradeEventSearchResponseAggregationsType
    {
        [JsonProperty("sources")]
        public AggregationItem[] Sources { get; set; }

        [JsonProperty("countries")]
        public AggregationItem[] Countries { get; set; }

        [JsonProperty("states")]
        public AggregationItem[] States { get; set; }

        [JsonProperty("event_types")]
        public AggregationItem[] EventTypes { get; set; }

        [JsonProperty("industries")]
        public AggregationItem[] Industries { get; set; }
    }

    public class TradeEventCountResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("aggregations")]
        public TradeEventCountResponseAggregationsType Aggregations { get; set; }
    }

    public class TradeEventCountResponseAggregationsType
    {
        [JsonProperty("sources")]
        public AggregationItem[] Sources { get; set; }

        [JsonProperty("countries")]
        public AggregationItem[] Countries { get; set; }

        [JsonProperty("states")]
        public AggregationItem[] States { get; set; }

        [JsonProperty("event_types")]
        public AggregationItem[] EventTypes { get; set; }

        [JsonProperty("industries")]
        public AggregationItem[] Industries { get; set; }
    }

    public class TradeLeadsSearchResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("next_offset")]
        public int NextOffset { get; set; }

        [JsonProperty("results")]
        public TradeLead[] Results { get; set; }

        [JsonProperty("aggregations")]
        public TradeLeadsSearchResponseAggregationsType Aggregations { get; set; }
    }

    public class TradeLead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("tender_start_date")]
        public string TenderStartDate { get; set; }

        [JsonProperty("tender_end_date")]
        public string TenderEndDate { get; set; }

        [JsonProperty("contract_start_date")]
        public string ContractStartDate { get; set; }

        [JsonProperty("contract_end_date")]
        public string ContractEndDate { get; set; }
    }

    public class TradeLeadsSearchResponseAggregationsType
    {
        [JsonProperty("country_codes")]
        public AggregationItem[] CountryCodes { get; set; }
    }

    public class TradeLeadsCountResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("aggregations")]
        public TradeLeadsCountResponseAggregationsType Aggregations { get; set; }
    }

    public class TradeLeadsCountResponseAggregationsType
    {
        [JsonProperty("country_codes")]
        public AggregationItem[] CountryCodes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tradegov;

    public partial class WorkflowManagedActions
    {
        public TradegovActions Tradegov(string connectionId) => new TradegovActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TradegovTriggers Tradegov(string connectionId) => new TradegovTriggers(connectionId);
    }
}