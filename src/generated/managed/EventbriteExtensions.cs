//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventbrite
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EventbriteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        public IBodyWorkflowAction<CreateEventResponse> CreateEvent(Expression<Func<string>> organizationId, Expression<Func<string>> eventNameHtml, Expression<Func<string>> eventDescriptionHtml, Expression<Func<string>> eventStartUtc, Expression<Func<string>> eventEndUtc, Expression<Func<eventStartTimezoneInput>> eventStartTimezone, Expression<Func<eventEndTimezoneInput>> eventEndTimezone, Expression<Func<eventCurrencyInput>> eventCurrency, Expression<Func<string>> eventOrganizerId = null, Expression<Func<string>> eventVenueId = null, Expression<Func<string>> eventCategoryId = null, Expression<Func<string>> eventPassword = null, Expression<Func<string>> eventCapacity = null, Expression<Func<bool>> eventShareable = null, Expression<Func<bool>> eventInviteOnly = null, Expression<Func<bool>> eventOnlineEvent = null, Expression<Func<bool>> eventListed = null, Expression<Func<bool>> eventHideStartDate = null, Expression<Func<bool>> eventHideEndDate = null, Expression<Func<bool>> eventShowRemaining = null)
        {
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: true);
            var __workflow_eventNameHtml = eventNameHtml == null ? null : WorkflowExpression.Compile(eventNameHtml);
            WorkflowExpression.Validate(__workflow_eventNameHtml, nameof(eventNameHtml), required: true);
            var __workflow_eventDescriptionHtml = eventDescriptionHtml == null ? null : WorkflowExpression.Compile(eventDescriptionHtml);
            WorkflowExpression.Validate(__workflow_eventDescriptionHtml, nameof(eventDescriptionHtml), required: true);
            var __workflow_eventStartUtc = eventStartUtc == null ? null : WorkflowExpression.Compile(eventStartUtc);
            WorkflowExpression.Validate(__workflow_eventStartUtc, nameof(eventStartUtc), required: true);
            var __workflow_eventEndUtc = eventEndUtc == null ? null : WorkflowExpression.Compile(eventEndUtc);
            WorkflowExpression.Validate(__workflow_eventEndUtc, nameof(eventEndUtc), required: true);
            var __workflow_eventStartTimezone = eventStartTimezone == null ? null : WorkflowExpression.Compile(eventStartTimezone);
            WorkflowExpression.Validate(__workflow_eventStartTimezone, nameof(eventStartTimezone), required: true);
            var __workflow_eventEndTimezone = eventEndTimezone == null ? null : WorkflowExpression.Compile(eventEndTimezone);
            WorkflowExpression.Validate(__workflow_eventEndTimezone, nameof(eventEndTimezone), required: true);
            var __workflow_eventCurrency = eventCurrency == null ? null : WorkflowExpression.Compile(eventCurrency);
            WorkflowExpression.Validate(__workflow_eventCurrency, nameof(eventCurrency), required: true);
            var __workflow_eventOrganizerId = eventOrganizerId == null ? null : WorkflowExpression.Compile(eventOrganizerId);
            WorkflowExpression.Validate(__workflow_eventOrganizerId, nameof(eventOrganizerId), required: false);
            var __workflow_eventVenueId = eventVenueId == null ? null : WorkflowExpression.Compile(eventVenueId);
            WorkflowExpression.Validate(__workflow_eventVenueId, nameof(eventVenueId), required: false);
            var __workflow_eventCategoryId = eventCategoryId == null ? null : WorkflowExpression.Compile(eventCategoryId);
            WorkflowExpression.Validate(__workflow_eventCategoryId, nameof(eventCategoryId), required: false);
            var __workflow_eventPassword = eventPassword == null ? null : WorkflowExpression.Compile(eventPassword);
            WorkflowExpression.Validate(__workflow_eventPassword, nameof(eventPassword), required: false);
            var __workflow_eventCapacity = eventCapacity == null ? null : WorkflowExpression.Compile(eventCapacity);
            WorkflowExpression.Validate(__workflow_eventCapacity, nameof(eventCapacity), required: false);
            var __workflow_eventShareable = eventShareable == null ? null : WorkflowExpression.Compile(eventShareable);
            WorkflowExpression.Validate(__workflow_eventShareable, nameof(eventShareable), required: false);
            var __workflow_eventInviteOnly = eventInviteOnly == null ? null : WorkflowExpression.Compile(eventInviteOnly);
            WorkflowExpression.Validate(__workflow_eventInviteOnly, nameof(eventInviteOnly), required: false);
            var __workflow_eventOnlineEvent = eventOnlineEvent == null ? null : WorkflowExpression.Compile(eventOnlineEvent);
            WorkflowExpression.Validate(__workflow_eventOnlineEvent, nameof(eventOnlineEvent), required: false);
            var __workflow_eventListed = eventListed == null ? null : WorkflowExpression.Compile(eventListed);
            WorkflowExpression.Validate(__workflow_eventListed, nameof(eventListed), required: false);
            var __workflow_eventHideStartDate = eventHideStartDate == null ? null : WorkflowExpression.Compile(eventHideStartDate);
            WorkflowExpression.Validate(__workflow_eventHideStartDate, nameof(eventHideStartDate), required: false);
            var __workflow_eventHideEndDate = eventHideEndDate == null ? null : WorkflowExpression.Compile(eventHideEndDate);
            WorkflowExpression.Validate(__workflow_eventHideEndDate, nameof(eventHideEndDate), required: false);
            var __workflow_eventShowRemaining = eventShowRemaining == null ? null : WorkflowExpression.Compile(eventShowRemaining);
            WorkflowExpression.Validate(__workflow_eventShowRemaining, nameof(eventShowRemaining), required: false);
            return new DeferredBodyAction<CreateEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["event.name.html"] = ExpressionConverter.Convert(__workflow_eventNameHtml);
                callPayload.Queries["event.description.html"] = ExpressionConverter.Convert(__workflow_eventDescriptionHtml);
                callPayload.Queries["event.start.utc"] = ExpressionConverter.Convert(__workflow_eventStartUtc);
                callPayload.Queries["event.end.utc"] = ExpressionConverter.Convert(__workflow_eventEndUtc);
                callPayload.Queries["event.start.timezone"] = ExpressionConverter.Convert(__workflow_eventStartTimezone);
                callPayload.Queries["event.end.timezone"] = ExpressionConverter.Convert(__workflow_eventEndTimezone);
                callPayload.Queries["event.currency"] = ExpressionConverter.Convert(__workflow_eventCurrency);
                if (__workflow_eventOrganizerId != null)
                    callPayload.Queries["event.organizer_id"] = ExpressionConverter.Convert(__workflow_eventOrganizerId);
                if (__workflow_eventVenueId != null)
                    callPayload.Queries["event.venue_id"] = ExpressionConverter.Convert(__workflow_eventVenueId);
                if (__workflow_eventCategoryId != null)
                    callPayload.Queries["event.category_id"] = ExpressionConverter.Convert(__workflow_eventCategoryId);
                if (__workflow_eventPassword != null)
                    callPayload.Queries["event.password"] = ExpressionConverter.Convert(__workflow_eventPassword);
                if (__workflow_eventCapacity != null)
                    callPayload.Queries["event.capacity"] = ExpressionConverter.Convert(__workflow_eventCapacity);
                if (__workflow_eventShareable != null)
                    callPayload.Queries["event.shareable"] = ExpressionConverter.Convert(__workflow_eventShareable);
                if (__workflow_eventInviteOnly != null)
                    callPayload.Queries["event.invite_only"] = ExpressionConverter.Convert(__workflow_eventInviteOnly);
                if (__workflow_eventOnlineEvent != null)
                    callPayload.Queries["event.online_event"] = ExpressionConverter.Convert(__workflow_eventOnlineEvent);
                if (__workflow_eventListed != null)
                    callPayload.Queries["event.listed"] = ExpressionConverter.Convert(__workflow_eventListed);
                if (__workflow_eventHideStartDate != null)
                    callPayload.Queries["event.hide_start_date"] = ExpressionConverter.Convert(__workflow_eventHideStartDate);
                if (__workflow_eventHideEndDate != null)
                    callPayload.Queries["event.hide_end_date"] = ExpressionConverter.Convert(__workflow_eventHideEndDate);
                if (__workflow_eventShowRemaining != null)
                    callPayload.Queries["event.show_remaining"] = ExpressionConverter.Convert(__workflow_eventShowRemaining);
                return new ApiConnectionAction<CreateEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        public IBodyWorkflowAction<CreateEventResponse> UpdateEvent(Expression<Func<string>> organizationId, Expression<Func<string>> id, Expression<Func<eventStartTimezoneInput>> eventStartTimezone, Expression<Func<eventEndTimezoneInput>> eventEndTimezone, Expression<Func<eventCurrencyInput>> eventCurrency, Expression<Func<string>> eventNameHtml = null, Expression<Func<string>> eventDescriptionHtml = null, Expression<Func<string>> eventStartUtc = null, Expression<Func<string>> eventEndUtc = null, Expression<Func<string>> eventOrganizerId = null, Expression<Func<string>> eventVenueId = null, Expression<Func<string>> eventCategoryId = null, Expression<Func<string>> eventPassword = null, Expression<Func<string>> eventCapacity = null, Expression<Func<bool>> eventShareable = null, Expression<Func<bool>> eventInviteOnly = null, Expression<Func<bool>> eventOnlineEvent = null, Expression<Func<bool>> eventListed = null, Expression<Func<bool>> eventHideStartDate = null, Expression<Func<bool>> eventHideEndDate = null, Expression<Func<bool>> eventShowRemaining = null)
        {
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_eventStartTimezone = eventStartTimezone == null ? null : WorkflowExpression.Compile(eventStartTimezone);
            WorkflowExpression.Validate(__workflow_eventStartTimezone, nameof(eventStartTimezone), required: true);
            var __workflow_eventEndTimezone = eventEndTimezone == null ? null : WorkflowExpression.Compile(eventEndTimezone);
            WorkflowExpression.Validate(__workflow_eventEndTimezone, nameof(eventEndTimezone), required: true);
            var __workflow_eventCurrency = eventCurrency == null ? null : WorkflowExpression.Compile(eventCurrency);
            WorkflowExpression.Validate(__workflow_eventCurrency, nameof(eventCurrency), required: true);
            var __workflow_eventNameHtml = eventNameHtml == null ? null : WorkflowExpression.Compile(eventNameHtml);
            WorkflowExpression.Validate(__workflow_eventNameHtml, nameof(eventNameHtml), required: false);
            var __workflow_eventDescriptionHtml = eventDescriptionHtml == null ? null : WorkflowExpression.Compile(eventDescriptionHtml);
            WorkflowExpression.Validate(__workflow_eventDescriptionHtml, nameof(eventDescriptionHtml), required: false);
            var __workflow_eventStartUtc = eventStartUtc == null ? null : WorkflowExpression.Compile(eventStartUtc);
            WorkflowExpression.Validate(__workflow_eventStartUtc, nameof(eventStartUtc), required: false);
            var __workflow_eventEndUtc = eventEndUtc == null ? null : WorkflowExpression.Compile(eventEndUtc);
            WorkflowExpression.Validate(__workflow_eventEndUtc, nameof(eventEndUtc), required: false);
            var __workflow_eventOrganizerId = eventOrganizerId == null ? null : WorkflowExpression.Compile(eventOrganizerId);
            WorkflowExpression.Validate(__workflow_eventOrganizerId, nameof(eventOrganizerId), required: false);
            var __workflow_eventVenueId = eventVenueId == null ? null : WorkflowExpression.Compile(eventVenueId);
            WorkflowExpression.Validate(__workflow_eventVenueId, nameof(eventVenueId), required: false);
            var __workflow_eventCategoryId = eventCategoryId == null ? null : WorkflowExpression.Compile(eventCategoryId);
            WorkflowExpression.Validate(__workflow_eventCategoryId, nameof(eventCategoryId), required: false);
            var __workflow_eventPassword = eventPassword == null ? null : WorkflowExpression.Compile(eventPassword);
            WorkflowExpression.Validate(__workflow_eventPassword, nameof(eventPassword), required: false);
            var __workflow_eventCapacity = eventCapacity == null ? null : WorkflowExpression.Compile(eventCapacity);
            WorkflowExpression.Validate(__workflow_eventCapacity, nameof(eventCapacity), required: false);
            var __workflow_eventShareable = eventShareable == null ? null : WorkflowExpression.Compile(eventShareable);
            WorkflowExpression.Validate(__workflow_eventShareable, nameof(eventShareable), required: false);
            var __workflow_eventInviteOnly = eventInviteOnly == null ? null : WorkflowExpression.Compile(eventInviteOnly);
            WorkflowExpression.Validate(__workflow_eventInviteOnly, nameof(eventInviteOnly), required: false);
            var __workflow_eventOnlineEvent = eventOnlineEvent == null ? null : WorkflowExpression.Compile(eventOnlineEvent);
            WorkflowExpression.Validate(__workflow_eventOnlineEvent, nameof(eventOnlineEvent), required: false);
            var __workflow_eventListed = eventListed == null ? null : WorkflowExpression.Compile(eventListed);
            WorkflowExpression.Validate(__workflow_eventListed, nameof(eventListed), required: false);
            var __workflow_eventHideStartDate = eventHideStartDate == null ? null : WorkflowExpression.Compile(eventHideStartDate);
            WorkflowExpression.Validate(__workflow_eventHideStartDate, nameof(eventHideStartDate), required: false);
            var __workflow_eventHideEndDate = eventHideEndDate == null ? null : WorkflowExpression.Compile(eventHideEndDate);
            WorkflowExpression.Validate(__workflow_eventHideEndDate, nameof(eventHideEndDate), required: false);
            var __workflow_eventShowRemaining = eventShowRemaining == null ? null : WorkflowExpression.Compile(eventShowRemaining);
            WorkflowExpression.Validate(__workflow_eventShowRemaining, nameof(eventShowRemaining), required: false);
            return new DeferredBodyAction<CreateEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v3/events/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                if (__workflow_eventNameHtml != null)
                    callPayload.Queries["event.name.html"] = ExpressionConverter.Convert(__workflow_eventNameHtml);
                if (__workflow_eventDescriptionHtml != null)
                    callPayload.Queries["event.description.html"] = ExpressionConverter.Convert(__workflow_eventDescriptionHtml);
                if (__workflow_eventStartUtc != null)
                    callPayload.Queries["event.start.utc"] = ExpressionConverter.Convert(__workflow_eventStartUtc);
                if (__workflow_eventEndUtc != null)
                    callPayload.Queries["event.end.utc"] = ExpressionConverter.Convert(__workflow_eventEndUtc);
                callPayload.Queries["event.start.timezone"] = ExpressionConverter.Convert(__workflow_eventStartTimezone);
                callPayload.Queries["event.end.timezone"] = ExpressionConverter.Convert(__workflow_eventEndTimezone);
                callPayload.Queries["event.currency"] = ExpressionConverter.Convert(__workflow_eventCurrency);
                if (__workflow_eventOrganizerId != null)
                    callPayload.Queries["event.organizer_id"] = ExpressionConverter.Convert(__workflow_eventOrganizerId);
                if (__workflow_eventVenueId != null)
                    callPayload.Queries["event.venue_id"] = ExpressionConverter.Convert(__workflow_eventVenueId);
                if (__workflow_eventCategoryId != null)
                    callPayload.Queries["event.category_id"] = ExpressionConverter.Convert(__workflow_eventCategoryId);
                if (__workflow_eventPassword != null)
                    callPayload.Queries["event.password"] = ExpressionConverter.Convert(__workflow_eventPassword);
                if (__workflow_eventCapacity != null)
                    callPayload.Queries["event.capacity"] = ExpressionConverter.Convert(__workflow_eventCapacity);
                if (__workflow_eventShareable != null)
                    callPayload.Queries["event.shareable"] = ExpressionConverter.Convert(__workflow_eventShareable);
                if (__workflow_eventInviteOnly != null)
                    callPayload.Queries["event.invite_only"] = ExpressionConverter.Convert(__workflow_eventInviteOnly);
                if (__workflow_eventOnlineEvent != null)
                    callPayload.Queries["event.online_event"] = ExpressionConverter.Convert(__workflow_eventOnlineEvent);
                if (__workflow_eventListed != null)
                    callPayload.Queries["event.listed"] = ExpressionConverter.Convert(__workflow_eventListed);
                if (__workflow_eventHideStartDate != null)
                    callPayload.Queries["event.hide_start_date"] = ExpressionConverter.Convert(__workflow_eventHideStartDate);
                if (__workflow_eventHideEndDate != null)
                    callPayload.Queries["event.hide_end_date"] = ExpressionConverter.Convert(__workflow_eventHideEndDate);
                if (__workflow_eventShowRemaining != null)
                    callPayload.Queries["event.show_remaining"] = ExpressionConverter.Convert(__workflow_eventShowRemaining);
                return new ApiConnectionAction<CreateEventResponse>(callPayload);
            });
        }
    }

    public class EventbriteTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetEventsForOrganizationResponseItem[]> OnNewEvent(Expression<Func<string>> organizationId, Expression<Func<string>> organizerFilter, FlowRecurrence recurrence = null)
        {
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: true);
            var __workflow_organizerFilter = organizerFilter == null ? null : WorkflowExpression.Compile(organizerFilter);
            WorkflowExpression.Validate(__workflow_organizerFilter, nameof(organizerFilter), required: true);
            return new DeferredBodyTrigger<GetEventsForOrganizationResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/trigger/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["organizer_filter"] = ExpressionConverter.Convert(__workflow_organizerFilter);
                callPayload.Queries["order_by"] = Convert.ToString("created_desc");
                return new ApiConnectionTrigger<GetEventsForOrganizationResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetOrdersResponseItem[]> OnOrderChanged(Expression<Func<string>> organizationId, Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_organizationId = organizationId == null ? null : WorkflowExpression.Compile(organizationId);
            WorkflowExpression.Validate(__workflow_organizationId, nameof(organizationId), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyTrigger<GetOrdersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/trigger/v3/events/{0}/orders/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["organization_id"] = ExpressionConverter.Convert(__workflow_organizationId);
                return new ApiConnectionTrigger<GetOrdersResponseItem[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
