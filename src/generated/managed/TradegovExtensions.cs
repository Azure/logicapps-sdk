//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tradegov
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TradegovActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<BSPResponse> BusinessServiceProvidersSearch(Expression<Func<string>> q = null, Expression<Func<string>> categories = null, Expression<Func<string>> itaOffices = null, Expression<Func<int>> offset = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            var __workflow_itaOffices = WorkflowExpression.Compile(itaOffices, nameof(itaOffices), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<BSPResponse>(() =>
            {
                var apiCallPath = "/business_service_providers/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                if (__workflow_itaOffices != null)
                    callPayload.Queries["ita_offices"] = ExpressionConverter.Convert(__workflow_itaOffices);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<BSPResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<ScreeningListSearchResponse> ConsolidatedScreeningListSearch(Expression<Func<string>> name = null, Expression<Func<fuzzyNameInput>> fuzzyName = null, Expression<Func<string>> sources = null, Expression<Func<string>> types = null, Expression<Func<string>> countries = null, Expression<Func<string>> address = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> fullAddress = null, Expression<Func<int>> offset = null, Expression<Func<int>> size = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_fuzzyName = WorkflowExpression.Compile(fuzzyName, nameof(fuzzyName), required: false);
            var __workflow_sources = WorkflowExpression.Compile(sources, nameof(sources), required: false);
            var __workflow_types = WorkflowExpression.Compile(types, nameof(types), required: false);
            var __workflow_countries = WorkflowExpression.Compile(countries, nameof(countries), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_fullAddress = WorkflowExpression.Compile(fullAddress, nameof(fullAddress), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ScreeningListSearchResponse>(() =>
            {
                var apiCallPath = "/consolidated_screening_list/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_fuzzyName != null)
                    callPayload.Queries["fuzzy_name"] = ExpressionConverter.Convert(__workflow_fuzzyName);
                if (__workflow_sources != null)
                    callPayload.Queries["sources"] = ExpressionConverter.Convert(__workflow_sources);
                if (__workflow_types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(__workflow_types);
                if (__workflow_countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(__workflow_countries);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postal_code"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_fullAddress != null)
                    callPayload.Queries["full_address"] = ExpressionConverter.Convert(__workflow_fullAddress);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ScreeningListSearchResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<DeMinimisListResponse> DeMinimisList(Expression<Func<int>> size = null, Expression<Func<int>> offset = null)
        {
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DeMinimisListResponse>(() =>
            {
                var apiCallPath = "/de_minimis/v1/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DeMinimisListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<DeMinimisListResponse> DeMinimisSearch(Expression<Func<string>> countryCodes = null, Expression<Func<int>> size = null, Expression<Func<int>> offset = null)
        {
            var __workflow_countryCodes = WorkflowExpression.Compile(countryCodes, nameof(countryCodes), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DeMinimisListResponse>(() =>
            {
                var apiCallPath = "/de_minimis/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_countryCodes != null)
                    callPayload.Queries["country_codes"] = ExpressionConverter.Convert(__workflow_countryCodes);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DeMinimisListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tradegov")]
        public IBodyWorkflowAction<ITAOfficeSearchResponse> ITAOfficeLocationsSearch(Expression<Func<string>> q = null, Expression<Func<string>> countryCodes = null, Expression<Func<string>> states = null, Expression<Func<string>> assignedZipCodes = null, Expression<Func<int>> offset = null, Expression<Func<int>> size = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_countryCodes = WorkflowExpression.Compile(countryCodes, nameof(countryCodes), required: false);
            var __workflow_states = WorkflowExpression.Compile(states, nameof(states), required: false);
            var __workflow_assignedZipCodes = WorkflowExpression.Compile(assignedZipCodes, nameof(assignedZipCodes), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ITAOfficeSearchResponse>(() =>
            {
                var apiCallPath = "/ita_office_locations/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_countryCodes != null)
                    callPayload.Queries["country_codes"] = ExpressionConverter.Convert(__workflow_countryCodes);
                if (__workflow_states != null)
                    callPayload.Queries["states"] = ExpressionConverter.Convert(__workflow_states);
                if (__workflow_assignedZipCodes != null)
                    callPayload.Queries["assigned_zip_codes"] = ExpressionConverter.Convert(__workflow_assignedZipCodes);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ITAOfficeSearchResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<TradeEventSearchResponse> TradeEventsSearch(Expression<Func<string>> sources = null, Expression<Func<string>> countries = null, Expression<Func<string>> eventTypes = null, Expression<Func<string>> industries = null, Expression<Func<string>> states = null, Expression<Func<string>> q = null, Expression<Func<string>> startDateRangeFrom = null, Expression<Func<string>> startDateRangeTo = null, Expression<Func<int>> size = null, Expression<Func<int>> offset = null)
        {
            var __workflow_sources = WorkflowExpression.Compile(sources, nameof(sources), required: false);
            var __workflow_countries = WorkflowExpression.Compile(countries, nameof(countries), required: false);
            var __workflow_eventTypes = WorkflowExpression.Compile(eventTypes, nameof(eventTypes), required: false);
            var __workflow_industries = WorkflowExpression.Compile(industries, nameof(industries), required: false);
            var __workflow_states = WorkflowExpression.Compile(states, nameof(states), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_startDateRangeFrom = WorkflowExpression.Compile(startDateRangeFrom, nameof(startDateRangeFrom), required: false);
            var __workflow_startDateRangeTo = WorkflowExpression.Compile(startDateRangeTo, nameof(startDateRangeTo), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TradeEventSearchResponse>(() =>
            {
                var apiCallPath = "/trade_events/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sources != null)
                    callPayload.Queries["sources"] = ExpressionConverter.Convert(__workflow_sources);
                if (__workflow_countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(__workflow_countries);
                if (__workflow_eventTypes != null)
                    callPayload.Queries["event_types"] = ExpressionConverter.Convert(__workflow_eventTypes);
                if (__workflow_industries != null)
                    callPayload.Queries["industries"] = ExpressionConverter.Convert(__workflow_industries);
                if (__workflow_states != null)
                    callPayload.Queries["states"] = ExpressionConverter.Convert(__workflow_states);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_startDateRangeFrom != null)
                    callPayload.Queries["start_date_range[from]"] = ExpressionConverter.Convert(__workflow_startDateRangeFrom);
                if (__workflow_startDateRangeTo != null)
                    callPayload.Queries["start_date_range[to]"] = ExpressionConverter.Convert(__workflow_startDateRangeTo);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TradeEventSearchResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<TradeLeadsSearchResponse> SearchTradeLeads(Expression<Func<string>> q = null, Expression<Func<string>> countryCodes = null, Expression<Func<string>> tenderStartDateRangeFrom = null, Expression<Func<string>> tenderStartDateRangeTo = null, Expression<Func<string>> contractStartDateRangeFrom = null, Expression<Func<string>> contractStartDateRangeTo = null, Expression<Func<int>> size = null, Expression<Func<int>> offset = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_countryCodes = WorkflowExpression.Compile(countryCodes, nameof(countryCodes), required: false);
            var __workflow_tenderStartDateRangeFrom = WorkflowExpression.Compile(tenderStartDateRangeFrom, nameof(tenderStartDateRangeFrom), required: false);
            var __workflow_tenderStartDateRangeTo = WorkflowExpression.Compile(tenderStartDateRangeTo, nameof(tenderStartDateRangeTo), required: false);
            var __workflow_contractStartDateRangeFrom = WorkflowExpression.Compile(contractStartDateRangeFrom, nameof(contractStartDateRangeFrom), required: false);
            var __workflow_contractStartDateRangeTo = WorkflowExpression.Compile(contractStartDateRangeTo, nameof(contractStartDateRangeTo), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TradeLeadsSearchResponse>(() =>
            {
                var apiCallPath = "/trade_leads/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_countryCodes != null)
                    callPayload.Queries["country_codes"] = ExpressionConverter.Convert(__workflow_countryCodes);
                if (__workflow_tenderStartDateRangeFrom != null)
                    callPayload.Queries["tender_start_date_range[from]"] = ExpressionConverter.Convert(__workflow_tenderStartDateRangeFrom);
                if (__workflow_tenderStartDateRangeTo != null)
                    callPayload.Queries["tender_start_date_range[to]"] = ExpressionConverter.Convert(__workflow_tenderStartDateRangeTo);
                if (__workflow_contractStartDateRangeFrom != null)
                    callPayload.Queries["contract_start_date_range[from]"] = ExpressionConverter.Convert(__workflow_contractStartDateRangeFrom);
                if (__workflow_contractStartDateRangeTo != null)
                    callPayload.Queries["contract_start_date_range[to]"] = ExpressionConverter.Convert(__workflow_contractStartDateRangeTo);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TradeLeadsSearchResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
