//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventbrite
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventbriteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        public IBodyWorkflowAction<CreateEventResponse> CreateEventV2(Expression<Func<string>> organizationId, Expression<Func<string>> eventNameHtml, Expression<Func<string>> eventDescriptionHtml, Expression<Func<string>> eventStartUtc, Expression<Func<string>> eventEndUtc, Expression<Func<eventStartTimezoneInput>> eventStartTimezone, Expression<Func<eventEndTimezoneInput>> eventEndTimezone, Expression<Func<eventCurrencyInput>> eventCurrency, Expression<Func<string>> eventOrganizerId = null, Expression<Func<string>> eventVenueId = null, Expression<Func<string>> eventCategoryId = null, Expression<Func<string>> eventPassword = null, Expression<Func<string>> eventCapacity = null, Expression<Func<bool>> eventShareable = null, Expression<Func<bool>> eventInviteOnly = null, Expression<Func<bool>> eventOnlineEvent = null, Expression<Func<bool>> eventListed = null, Expression<Func<bool>> eventHideStartDate = null, Expression<Func<bool>> eventHideEndDate = null, Expression<Func<bool>> eventShowRemaining = null)
        {
            var apiCallPath = String.Format("/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["event.name.html"] = ExpressionConverter.Convert(eventNameHtml);
            callPayload.Queries["event.description.html"] = ExpressionConverter.Convert(eventDescriptionHtml);
            callPayload.Queries["event.start.utc"] = ExpressionConverter.Convert(eventStartUtc);
            callPayload.Queries["event.end.utc"] = ExpressionConverter.Convert(eventEndUtc);
            callPayload.Queries["event.start.timezone"] = ExpressionConverter.Convert(eventStartTimezone);
            callPayload.Queries["event.end.timezone"] = ExpressionConverter.Convert(eventEndTimezone);
            callPayload.Queries["event.currency"] = ExpressionConverter.Convert(eventCurrency);
            if (eventOrganizerId != null)
                callPayload.Queries["event.organizer_id"] = ExpressionConverter.Convert(eventOrganizerId);
            if (eventVenueId != null)
                callPayload.Queries["event.venue_id"] = ExpressionConverter.Convert(eventVenueId);
            if (eventCategoryId != null)
                callPayload.Queries["event.category_id"] = ExpressionConverter.Convert(eventCategoryId);
            if (eventPassword != null)
                callPayload.Queries["event.password"] = ExpressionConverter.Convert(eventPassword);
            if (eventCapacity != null)
                callPayload.Queries["event.capacity"] = ExpressionConverter.Convert(eventCapacity);
            if (eventShareable != null)
                callPayload.Queries["event.shareable"] = ExpressionConverter.Convert(eventShareable);
            if (eventInviteOnly != null)
                callPayload.Queries["event.invite_only"] = ExpressionConverter.Convert(eventInviteOnly);
            if (eventOnlineEvent != null)
                callPayload.Queries["event.online_event"] = ExpressionConverter.Convert(eventOnlineEvent);
            if (eventListed != null)
                callPayload.Queries["event.listed"] = ExpressionConverter.Convert(eventListed);
            if (eventHideStartDate != null)
                callPayload.Queries["event.hide_start_date"] = ExpressionConverter.Convert(eventHideStartDate);
            if (eventHideEndDate != null)
                callPayload.Queries["event.hide_end_date"] = ExpressionConverter.Convert(eventHideEndDate);
            if (eventShowRemaining != null)
                callPayload.Queries["event.show_remaining"] = ExpressionConverter.Convert(eventShowRemaining);
            return new ApiConnectionAction<CreateEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        public IBodyWorkflowAction<CreateEventResponse> UpdateEventV2(Expression<Func<string>> organizationId, Expression<Func<string>> id, Expression<Func<eventStartTimezoneInput>> eventStartTimezone, Expression<Func<eventEndTimezoneInput>> eventEndTimezone, Expression<Func<eventCurrencyInput>> eventCurrency, Expression<Func<string>> eventNameHtml = null, Expression<Func<string>> eventDescriptionHtml = null, Expression<Func<string>> eventStartUtc = null, Expression<Func<string>> eventEndUtc = null, Expression<Func<string>> eventOrganizerId = null, Expression<Func<string>> eventVenueId = null, Expression<Func<string>> eventCategoryId = null, Expression<Func<string>> eventPassword = null, Expression<Func<string>> eventCapacity = null, Expression<Func<bool>> eventShareable = null, Expression<Func<bool>> eventInviteOnly = null, Expression<Func<bool>> eventOnlineEvent = null, Expression<Func<bool>> eventListed = null, Expression<Func<bool>> eventHideStartDate = null, Expression<Func<bool>> eventHideEndDate = null, Expression<Func<bool>> eventShowRemaining = null)
        {
            var apiCallPath = String.Format("/v2/v3/events/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
            if (eventNameHtml != null)
                callPayload.Queries["event.name.html"] = ExpressionConverter.Convert(eventNameHtml);
            if (eventDescriptionHtml != null)
                callPayload.Queries["event.description.html"] = ExpressionConverter.Convert(eventDescriptionHtml);
            if (eventStartUtc != null)
                callPayload.Queries["event.start.utc"] = ExpressionConverter.Convert(eventStartUtc);
            if (eventEndUtc != null)
                callPayload.Queries["event.end.utc"] = ExpressionConverter.Convert(eventEndUtc);
            callPayload.Queries["event.start.timezone"] = ExpressionConverter.Convert(eventStartTimezone);
            callPayload.Queries["event.end.timezone"] = ExpressionConverter.Convert(eventEndTimezone);
            callPayload.Queries["event.currency"] = ExpressionConverter.Convert(eventCurrency);
            if (eventOrganizerId != null)
                callPayload.Queries["event.organizer_id"] = ExpressionConverter.Convert(eventOrganizerId);
            if (eventVenueId != null)
                callPayload.Queries["event.venue_id"] = ExpressionConverter.Convert(eventVenueId);
            if (eventCategoryId != null)
                callPayload.Queries["event.category_id"] = ExpressionConverter.Convert(eventCategoryId);
            if (eventPassword != null)
                callPayload.Queries["event.password"] = ExpressionConverter.Convert(eventPassword);
            if (eventCapacity != null)
                callPayload.Queries["event.capacity"] = ExpressionConverter.Convert(eventCapacity);
            if (eventShareable != null)
                callPayload.Queries["event.shareable"] = ExpressionConverter.Convert(eventShareable);
            if (eventInviteOnly != null)
                callPayload.Queries["event.invite_only"] = ExpressionConverter.Convert(eventInviteOnly);
            if (eventOnlineEvent != null)
                callPayload.Queries["event.online_event"] = ExpressionConverter.Convert(eventOnlineEvent);
            if (eventListed != null)
                callPayload.Queries["event.listed"] = ExpressionConverter.Convert(eventListed);
            if (eventHideStartDate != null)
                callPayload.Queries["event.hide_start_date"] = ExpressionConverter.Convert(eventHideStartDate);
            if (eventHideEndDate != null)
                callPayload.Queries["event.hide_end_date"] = ExpressionConverter.Convert(eventHideEndDate);
            if (eventShowRemaining != null)
                callPayload.Queries["event.show_remaining"] = ExpressionConverter.Convert(eventShowRemaining);
            return new ApiConnectionAction<CreateEventResponse>(callPayload);
        }
    }

    public class EventbriteTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetEventsForOrganizationResponseItem[]> OnNewEventV2(Expression<Func<string>> organizationId, Expression<Func<string>> organizerFilter, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v2/trigger/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["organizer_filter"] = ExpressionConverter.Convert(organizerFilter);
            callPayload.Queries["order_by"] = Convert.ToString("created_desc");
            return new ApiConnectionTrigger<GetEventsForOrganizationResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetOrdersResponseItem[]> OnOrderChangedV2(Expression<Func<string>> organizationId, Expression<Func<string>> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v2/trigger/v3/events/{0}/orders/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
            return new ApiConnectionTrigger<GetOrdersResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class CreateEventResponse
    {
        [JsonProperty("name")]
        public CreateEventResponseNameType Name { get; set; }

        [JsonProperty("description")]
        public CreateEventResponseDescriptionType Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("start")]
        public CreateEventResponseStartType Start { get; set; }

        [JsonProperty("end")]
        public CreateEventResponseEndType End { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("changed")]
        public string ChagedDateTime { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("online_event")]
        public bool IsOnlineEvent { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("venue_id")]
        public string VenueId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
    }

    public class CreateEventResponseNameType
    {
        [JsonProperty("text")]
        public string Name { get; set; }
    }

    public class CreateEventResponseDescriptionType
    {
        [JsonProperty("text")]
        public string Description { get; set; }
    }

    public class CreateEventResponseStartType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("utc")]
        public string UTC { get; set; }
    }

    public class CreateEventResponseEndType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("utc")]
        public string UTC { get; set; }
    }

    public enum eventStartTimezoneInput
    {
        [EnumMember(Value = "Pacific/Midway")]
        PacificMidway,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland
    }

    public enum eventEndTimezoneInput
    {
        [EnumMember(Value = "Pacific/Midway")]
        PacificMidway,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland
    }

    public enum eventCurrencyInput
    {
        USD,
        AUD,
        CAD,
        CHF,
        DKK,
        EUR,
        GBP,
        HKD,
        IDR,
        INR,
        JPY,
        KRW,
        MXN,
        MYR,
        NOK,
        NZD,
        RUB,
        SAR,
        SEK,
        TRY,
        TWD,
        ZAR
    }

    public class GetEventsForOrganizationResponseItem
    {
        [JsonProperty("name")]
        public GetEventsForOrganizationResponseItemNameType Name { get; set; }

        [JsonProperty("description")]
        public GetEventsForOrganizationResponseItemDescriptionType Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("start")]
        public GetEventsForOrganizationResponseItemStartType Start { get; set; }

        [JsonProperty("end")]
        public GetEventsForOrganizationResponseItemEndType End { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("changed")]
        public string ChagedDateTime { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("online_event")]
        public bool IsOnlineEvent { get; set; }

        [JsonProperty("organizer_id")]
        public string OrganizerId { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("venue_id")]
        public string VenueId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
    }

    public class GetEventsForOrganizationResponseItemNameType
    {
        [JsonProperty("text")]
        public string Name { get; set; }
    }

    public class GetEventsForOrganizationResponseItemDescriptionType
    {
        [JsonProperty("text")]
        public string Description { get; set; }
    }

    public class GetEventsForOrganizationResponseItemStartType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("utc")]
        public string UTC { get; set; }
    }

    public class GetEventsForOrganizationResponseItemEndType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("utc")]
        public string UTC { get; set; }
    }

    public class GetOrdersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Eventbrite;

    public partial class WorkflowManagedActions
    {
        public EventbriteActions Eventbrite(string connectionId) => new EventbriteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EventbriteTriggers Eventbrite(string connectionId) => new EventbriteTriggers(connectionId);
    }
}