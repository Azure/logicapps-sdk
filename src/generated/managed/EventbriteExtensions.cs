//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Eventbrite
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EventbriteActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEvent))]
        public IBodyWorkflowAction<CreateEventResponse> CreateEvent([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> eventNameHtml, [WorkflowExpression] Func<string> eventDescriptionHtml, [WorkflowExpression] Func<string> eventStartUtc, [WorkflowExpression] Func<string> eventEndUtc, [WorkflowExpression] Func<eventStartTimezoneInput> eventStartTimezone, [WorkflowExpression] Func<eventEndTimezoneInput> eventEndTimezone, [WorkflowExpression] Func<eventCurrencyInput> eventCurrency, [WorkflowExpression] Func<string> eventOrganizerId = null, [WorkflowExpression] Func<string> eventVenueId = null, [WorkflowExpression] Func<string> eventCategoryId = null, [WorkflowExpression] Func<string> eventPassword = null, [WorkflowExpression] Func<string> eventCapacity = null, [WorkflowExpression] Func<bool> eventShareable = null, [WorkflowExpression] Func<bool> eventInviteOnly = null, [WorkflowExpression] Func<bool> eventOnlineEvent = null, [WorkflowExpression] Func<bool> eventListed = null, [WorkflowExpression] Func<bool> eventHideStartDate = null, [WorkflowExpression] Func<bool> eventHideEndDate = null, [WorkflowExpression] Func<bool> eventShowRemaining = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEventResponse> __BuildCreateEvent(WorkflowExpression<string> organizationId, WorkflowExpression<string> eventNameHtml, WorkflowExpression<string> eventDescriptionHtml, WorkflowExpression<string> eventStartUtc, WorkflowExpression<string> eventEndUtc, WorkflowExpression<eventStartTimezoneInput> eventStartTimezone, WorkflowExpression<eventEndTimezoneInput> eventEndTimezone, WorkflowExpression<eventCurrencyInput> eventCurrency, WorkflowExpression<string> eventOrganizerId = null, WorkflowExpression<string> eventVenueId = null, WorkflowExpression<string> eventCategoryId = null, WorkflowExpression<string> eventPassword = null, WorkflowExpression<string> eventCapacity = null, WorkflowExpression<bool> eventShareable = null, WorkflowExpression<bool> eventInviteOnly = null, WorkflowExpression<bool> eventOnlineEvent = null, WorkflowExpression<bool> eventListed = null, WorkflowExpression<bool> eventHideStartDate = null, WorkflowExpression<bool> eventHideEndDate = null, WorkflowExpression<bool> eventShowRemaining = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(eventNameHtml, nameof(eventNameHtml), required: true);
            WorkflowExpression.Validate(eventDescriptionHtml, nameof(eventDescriptionHtml), required: true);
            WorkflowExpression.Validate(eventStartUtc, nameof(eventStartUtc), required: true);
            WorkflowExpression.Validate(eventEndUtc, nameof(eventEndUtc), required: true);
            WorkflowExpression.Validate(eventStartTimezone, nameof(eventStartTimezone), required: true);
            WorkflowExpression.Validate(eventEndTimezone, nameof(eventEndTimezone), required: true);
            WorkflowExpression.Validate(eventCurrency, nameof(eventCurrency), required: true);
            WorkflowExpression.Validate(eventOrganizerId, nameof(eventOrganizerId), required: false);
            WorkflowExpression.Validate(eventVenueId, nameof(eventVenueId), required: false);
            WorkflowExpression.Validate(eventCategoryId, nameof(eventCategoryId), required: false);
            WorkflowExpression.Validate(eventPassword, nameof(eventPassword), required: false);
            WorkflowExpression.Validate(eventCapacity, nameof(eventCapacity), required: false);
            WorkflowExpression.Validate(eventShareable, nameof(eventShareable), required: false);
            WorkflowExpression.Validate(eventInviteOnly, nameof(eventInviteOnly), required: false);
            WorkflowExpression.Validate(eventOnlineEvent, nameof(eventOnlineEvent), required: false);
            WorkflowExpression.Validate(eventListed, nameof(eventListed), required: false);
            WorkflowExpression.Validate(eventHideStartDate, nameof(eventHideStartDate), required: false);
            WorkflowExpression.Validate(eventHideEndDate, nameof(eventHideEndDate), required: false);
            WorkflowExpression.Validate(eventShowRemaining, nameof(eventShowRemaining), required: false);
            return new DeferredBodyAction<CreateEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEvent))]
        public IBodyWorkflowAction<CreateEventResponse> UpdateEvent([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<eventStartTimezoneInput> eventStartTimezone, [WorkflowExpression] Func<eventEndTimezoneInput> eventEndTimezone, [WorkflowExpression] Func<eventCurrencyInput> eventCurrency, [WorkflowExpression] Func<string> eventNameHtml = null, [WorkflowExpression] Func<string> eventDescriptionHtml = null, [WorkflowExpression] Func<string> eventStartUtc = null, [WorkflowExpression] Func<string> eventEndUtc = null, [WorkflowExpression] Func<string> eventOrganizerId = null, [WorkflowExpression] Func<string> eventVenueId = null, [WorkflowExpression] Func<string> eventCategoryId = null, [WorkflowExpression] Func<string> eventPassword = null, [WorkflowExpression] Func<string> eventCapacity = null, [WorkflowExpression] Func<bool> eventShareable = null, [WorkflowExpression] Func<bool> eventInviteOnly = null, [WorkflowExpression] Func<bool> eventOnlineEvent = null, [WorkflowExpression] Func<bool> eventListed = null, [WorkflowExpression] Func<bool> eventHideStartDate = null, [WorkflowExpression] Func<bool> eventHideEndDate = null, [WorkflowExpression] Func<bool> eventShowRemaining = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "eventbrite")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEventResponse> __BuildUpdateEvent(WorkflowExpression<string> organizationId, WorkflowExpression<string> id, WorkflowExpression<eventStartTimezoneInput> eventStartTimezone, WorkflowExpression<eventEndTimezoneInput> eventEndTimezone, WorkflowExpression<eventCurrencyInput> eventCurrency, WorkflowExpression<string> eventNameHtml = null, WorkflowExpression<string> eventDescriptionHtml = null, WorkflowExpression<string> eventStartUtc = null, WorkflowExpression<string> eventEndUtc = null, WorkflowExpression<string> eventOrganizerId = null, WorkflowExpression<string> eventVenueId = null, WorkflowExpression<string> eventCategoryId = null, WorkflowExpression<string> eventPassword = null, WorkflowExpression<string> eventCapacity = null, WorkflowExpression<bool> eventShareable = null, WorkflowExpression<bool> eventInviteOnly = null, WorkflowExpression<bool> eventOnlineEvent = null, WorkflowExpression<bool> eventListed = null, WorkflowExpression<bool> eventHideStartDate = null, WorkflowExpression<bool> eventHideEndDate = null, WorkflowExpression<bool> eventShowRemaining = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(eventStartTimezone, nameof(eventStartTimezone), required: true);
            WorkflowExpression.Validate(eventEndTimezone, nameof(eventEndTimezone), required: true);
            WorkflowExpression.Validate(eventCurrency, nameof(eventCurrency), required: true);
            WorkflowExpression.Validate(eventNameHtml, nameof(eventNameHtml), required: false);
            WorkflowExpression.Validate(eventDescriptionHtml, nameof(eventDescriptionHtml), required: false);
            WorkflowExpression.Validate(eventStartUtc, nameof(eventStartUtc), required: false);
            WorkflowExpression.Validate(eventEndUtc, nameof(eventEndUtc), required: false);
            WorkflowExpression.Validate(eventOrganizerId, nameof(eventOrganizerId), required: false);
            WorkflowExpression.Validate(eventVenueId, nameof(eventVenueId), required: false);
            WorkflowExpression.Validate(eventCategoryId, nameof(eventCategoryId), required: false);
            WorkflowExpression.Validate(eventPassword, nameof(eventPassword), required: false);
            WorkflowExpression.Validate(eventCapacity, nameof(eventCapacity), required: false);
            WorkflowExpression.Validate(eventShareable, nameof(eventShareable), required: false);
            WorkflowExpression.Validate(eventInviteOnly, nameof(eventInviteOnly), required: false);
            WorkflowExpression.Validate(eventOnlineEvent, nameof(eventOnlineEvent), required: false);
            WorkflowExpression.Validate(eventListed, nameof(eventListed), required: false);
            WorkflowExpression.Validate(eventHideStartDate, nameof(eventHideStartDate), required: false);
            WorkflowExpression.Validate(eventHideEndDate, nameof(eventHideEndDate), required: false);
            WorkflowExpression.Validate(eventShowRemaining, nameof(eventShowRemaining), required: false);
            return new DeferredBodyAction<CreateEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v3/events/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }
    }

    public class EventbriteTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewEvent))]
        public IBodyWorkflowTrigger<GetEventsForOrganizationResponseItem[]> OnNewEvent([WorkflowExpression] Func<string> organizationId,[WorkflowExpression] Func<string> organizerFilter,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetEventsForOrganizationResponseItem[]> __BuildOnNewEvent(WorkflowExpression<string> organizationId,WorkflowExpression<string> organizerFilter,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(organizerFilter, nameof(organizerFilter), required: true);
            return new DeferredBodyTrigger<GetEventsForOrganizationResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/trigger/v3/organizations/{0}/events/", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["organizer_filter"] = ExpressionConverter.Convert(organizerFilter);
                callPayload.Queries["order_by"] = Convert.ToString("created_desc");
                return new ApiConnectionTrigger<GetEventsForOrganizationResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnOrderChanged))]
        public IBodyWorkflowTrigger<GetOrdersResponseItem[]> OnOrderChanged([WorkflowExpression] Func<string> organizationId,[WorkflowExpression] Func<string> id,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetOrdersResponseItem[]> __BuildOnOrderChanged(WorkflowExpression<string> organizationId,WorkflowExpression<string> id,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyTrigger<GetOrdersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/trigger/v3/events/{0}/orders/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["organization_id"] = ExpressionConverter.Convert(organizationId);
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