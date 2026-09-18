//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theeventscalendar
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheeventscalendarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theeventscalendar")]
        public IBodyWorkflowAction<CreateEventsResponse> CreateEvents([WorkflowExpression] Func<int> bodyauthor = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyexcerpt = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<bool> bodyallDay = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<string> bodycost = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bool> bodyshowMap = null, [WorkflowExpression] Func<bool> bodyshowMapLink = null, [WorkflowExpression] Func<bool> bodyhideFromListings = null, [WorkflowExpression] Func<bool> bodysticky = null, [WorkflowExpression] Func<bool> bodyfeatured = null, [WorkflowExpression] Func<string> bodycategories = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyvenue = null, [WorkflowExpression] Func<string> bodyorganizer = null)
        {
            var apiCallPath = "/wp-json/tribe/power-automate/v1/create-events/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyauthor != null)
            {
                body["author"] = ExpressionConverter.ConvertO(bodyauthor);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyslug != null)
            {
                body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                bodypropCount++;
            }

            if (bodyexcerpt != null)
            {
                body["excerpt"] = ExpressionConverter.ConvertO(bodyexcerpt);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodyallDay != null)
            {
                body["all_day"] = ExpressionConverter.ConvertO(bodyallDay);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodycost != null)
            {
                body["cost"] = ExpressionConverter.ConvertO(bodycost);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodyshowMap != null)
            {
                body["show_map"] = ExpressionConverter.ConvertO(bodyshowMap);
                bodypropCount++;
            }

            if (bodyshowMapLink != null)
            {
                body["show_map_link"] = ExpressionConverter.ConvertO(bodyshowMapLink);
                bodypropCount++;
            }

            if (bodyhideFromListings != null)
            {
                body["hide_from_listings"] = ExpressionConverter.ConvertO(bodyhideFromListings);
                bodypropCount++;
            }

            if (bodysticky != null)
            {
                body["sticky"] = ExpressionConverter.ConvertO(bodysticky);
                bodypropCount++;
            }

            if (bodyfeatured != null)
            {
                body["featured"] = ExpressionConverter.ConvertO(bodyfeatured);
                bodypropCount++;
            }

            if (bodycategories != null)
            {
                body["categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodyvenue != null)
            {
                body["venue"] = ExpressionConverter.ConvertO(bodyvenue);
                bodypropCount++;
            }

            if (bodyorganizer != null)
            {
                body["organizer"] = ExpressionConverter.ConvertO(bodyorganizer);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEventsResponse>(callPayload);
        }
    }

    public class TheeventscalendarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewEventTriggerResponse> NewEventTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/new-events/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<NewEventTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UpdatedEventTriggerResponse> UpdatedEventTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/updated-events/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<UpdatedEventTriggerResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CanceledEventTriggerResponse> CanceledEventTrigger(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/wp-json/tribe/power-automate/v1/canceled-events/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CanceledEventTriggerResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class CreateEventsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("global_id")]
        public string GlobalId { get; set; }

        [JsonProperty("global_id_lineage")]
        public string[] GlobalIdLineage { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("modified_utc")]
        public string ModifiedUtc { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rest_url")]
        public string RestUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("image")]
        public bool Image { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_date_details")]
        public CreateEventsResponseStartDateDetailsType StartDateDetails { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_date_details")]
        public CreateEventsResponseEndDateDetailsType EndDateDetails { get; set; }

        [JsonProperty("utc_start_date")]
        public string UtcStartDate { get; set; }

        [JsonProperty("utc_start_date_details")]
        public CreateEventsResponseUtcStartDateDetailsType UtcStartDateDetails { get; set; }

        [JsonProperty("utc_end_date")]
        public string UtcEndDate { get; set; }

        [JsonProperty("utc_end_date_details")]
        public CreateEventsResponseUtcEndDateDetailsType UtcEndDateDetails { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbr")]
        public string TimezoneAbbr { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("cost_details")]
        public CreateEventsResponseCostDetailsType CostDetails { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("show_map")]
        public bool ShowMap { get; set; }

        [JsonProperty("show_map_link")]
        public bool ShowMapLink { get; set; }

        [JsonProperty("hide_from_listings")]
        public bool HideFromListings { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("venue")]
        public JToken[] Venue { get; set; }

        [JsonProperty("organizer")]
        public JToken[] Organizer { get; set; }

        [JsonProperty("attendance")]
        public CreateEventsResponseAttendanceType Attendance { get; set; }

        [JsonProperty("ticketed")]
        public bool Ticketed { get; set; }
    }

    public class CreateEventsResponseStartDateDetailsType
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("minutes")]
        public string Minutes { get; set; }

        [JsonProperty("seconds")]
        public string Seconds { get; set; }
    }

    public class CreateEventsResponseEndDateDetailsType
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("minutes")]
        public string Minutes { get; set; }

        [JsonProperty("seconds")]
        public string Seconds { get; set; }
    }

    public class CreateEventsResponseUtcStartDateDetailsType
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("minutes")]
        public string Minutes { get; set; }

        [JsonProperty("seconds")]
        public string Seconds { get; set; }
    }

    public class CreateEventsResponseUtcEndDateDetailsType
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("minutes")]
        public string Minutes { get; set; }

        [JsonProperty("seconds")]
        public string Seconds { get; set; }
    }

    public class CreateEventsResponseCostDetailsType
    {
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_position")]
        public string CurrencyPosition { get; set; }

        [JsonProperty("values")]
        public JToken[] Values { get; set; }
    }

    public class CreateEventsResponseAttendanceType
    {
        [JsonProperty("total_attendees")]
        public int TotalAttendees { get; set; }

        [JsonProperty("checked_in")]
        public int CheckedIn { get; set; }

        [JsonProperty("not_checked_in")]
        public int NotCheckedIn { get; set; }
    }

    public class NewEventTriggerResponse
    {
        [JsonProperty("events")]
        public NewEventTriggerResponseEventsTypeItem[] Events { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("event_status")]
        public string EventStatus { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("organizers")]
        public NewEventTriggerResponseEventsTypeItemOrganizersTypeItem[] Organizers { get; set; }

        [JsonProperty("venue")]
        public NewEventTriggerResponseEventsTypeItemVenueTypeItem[] Venue { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("category")]
        public NewEventTriggerResponseEventsTypeItemCategoryTypeItem[] Category { get; set; }

        [JsonProperty("tag")]
        public NewEventTriggerResponseEventsTypeItemTagTypeItem[] Tag { get; set; }

        [JsonProperty("tickets")]
        public NewEventTriggerResponseEventsTypeItemTicketsType Tickets { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbr")]
        public string TimezoneAbbr { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("multi_day")]
        public int MultiDay { get; set; }

        [JsonProperty("is_past")]
        public bool IsPast { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        [JsonProperty("virtual_video_source")]
        public string VirtualVideoSource { get; set; }

        [JsonProperty("virtual_event_type")]
        public string VirtualEventType { get; set; }

        [JsonProperty("virtual_autodetect_source")]
        public string VirtualAutodetectSource { get; set; }

        [JsonProperty("virtual_url")]
        public string VirtualUrl { get; set; }

        [JsonProperty("virtual_meeting_provider")]
        public string VirtualMeetingProvider { get; set; }

        [JsonProperty("virtual_provider_details")]
        public JToken[] VirtualProviderDetails { get; set; }

        [JsonProperty("virtual_embed_video")]
        public bool VirtualEmbedVideo { get; set; }

        [JsonProperty("virtual_linked_button")]
        public bool VirtualLinkedButton { get; set; }

        [JsonProperty("virtual_linked_button_text")]
        public string VirtualLinkedButtonText { get; set; }

        [JsonProperty("virtual_show_embed_at")]
        public string VirtualShowEmbedAt { get; set; }

        [JsonProperty("virtual_show_embed_to")]
        public JToken[] VirtualShowEmbedTo { get; set; }

        [JsonProperty("virtual_show_on_event")]
        public bool VirtualShowOnEvent { get; set; }

        [JsonProperty("virtual_show_on_views")]
        public bool VirtualShowOnViews { get; set; }

        [JsonProperty("virtual_show_lead_up")]
        public int VirtualShowLeadUp { get; set; }

        [JsonProperty("virtual_rsvp_email_link")]
        public bool VirtualRsvpEmailLink { get; set; }

        [JsonProperty("virtual_ticket_email_link")]
        public bool VirtualTicketEmailLink { get; set; }

        [JsonProperty("virtual_is_immediate")]
        public bool VirtualIsImmediate { get; set; }

        [JsonProperty("virtual_is_linkable")]
        public bool VirtualIsLinkable { get; set; }

        [JsonProperty("virtual_should_show_embed")]
        public bool VirtualShouldShowEmbed { get; set; }

        [JsonProperty("virtual_should_show_link")]
        public bool VirtualShouldShowLink { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recurring_meta")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaType RecurringMeta { get; set; }

        [JsonProperty("rrule")]
        public string[] Rrule { get; set; }

        [JsonProperty("exclusions")]
        public string[] Exclusions { get; set; }

        [JsonProperty("additional_fields")]
        public NewEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemOrganizersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemVenueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("directions_link")]
        public string DirectionsLink { get; set; }

        [JsonProperty("geolocation")]
        public NewEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType Geolocation { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType
    {
        [JsonProperty("overwrite_coordinates")]
        public bool OverwriteCoordinates { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("distance")]
        public bool Distance { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemCategoryTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parent")]
        public NewEventTriggerResponseEventsTypeItemCategoryTypeItemParentType Parent { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemCategoryTypeItemParentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemTagTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemTicketsType
    {
        [JsonProperty("has_ticket")]
        public bool HasTicket { get; set; }

        [JsonProperty("has_rsvp")]
        public bool HasRsvp { get; set; }

        [JsonProperty("in_date_range")]
        public bool InDateRange { get; set; }

        [JsonProperty("sold_out")]
        public bool SoldOut { get; set; }

        [JsonProperty("tickets")]
        public NewEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem[] Tickets { get; set; }

        [JsonProperty("rsvps")]
        public NewEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem[] Rsvps { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaType
    {
        [JsonProperty("rules")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem[] Rules { get; set; }

        [JsonProperty("exclusions")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem[] Exclusions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }

        [JsonProperty("end-count")]
        public string EndCount { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class NewEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem
    {
        [JsonProperty("additional_field_label")]
        public string AdditionalFieldLabel { get; set; }

        [JsonProperty("additional_field_value")]
        public string AdditionalFieldValue { get; set; }
    }

    public class UpdatedEventTriggerResponse
    {
        [JsonProperty("events")]
        public UpdatedEventTriggerResponseEventsTypeItem[] Events { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("event_status")]
        public string EventStatus { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("organizers")]
        public UpdatedEventTriggerResponseEventsTypeItemOrganizersTypeItem[] Organizers { get; set; }

        [JsonProperty("venue")]
        public UpdatedEventTriggerResponseEventsTypeItemVenueTypeItem[] Venue { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("category")]
        public UpdatedEventTriggerResponseEventsTypeItemCategoryTypeItem[] Category { get; set; }

        [JsonProperty("tag")]
        public UpdatedEventTriggerResponseEventsTypeItemTagTypeItem[] Tag { get; set; }

        [JsonProperty("tickets")]
        public UpdatedEventTriggerResponseEventsTypeItemTicketsType Tickets { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbr")]
        public string TimezoneAbbr { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("multi_day")]
        public int MultiDay { get; set; }

        [JsonProperty("is_past")]
        public bool IsPast { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        [JsonProperty("virtual_video_source")]
        public string VirtualVideoSource { get; set; }

        [JsonProperty("virtual_event_type")]
        public string VirtualEventType { get; set; }

        [JsonProperty("virtual_autodetect_source")]
        public string VirtualAutodetectSource { get; set; }

        [JsonProperty("virtual_url")]
        public string VirtualUrl { get; set; }

        [JsonProperty("virtual_meeting_provider")]
        public string VirtualMeetingProvider { get; set; }

        [JsonProperty("virtual_provider_details")]
        public JToken[] VirtualProviderDetails { get; set; }

        [JsonProperty("virtual_embed_video")]
        public bool VirtualEmbedVideo { get; set; }

        [JsonProperty("virtual_linked_button")]
        public bool VirtualLinkedButton { get; set; }

        [JsonProperty("virtual_linked_button_text")]
        public string VirtualLinkedButtonText { get; set; }

        [JsonProperty("virtual_show_embed_at")]
        public string VirtualShowEmbedAt { get; set; }

        [JsonProperty("virtual_show_embed_to")]
        public JToken[] VirtualShowEmbedTo { get; set; }

        [JsonProperty("virtual_show_on_event")]
        public bool VirtualShowOnEvent { get; set; }

        [JsonProperty("virtual_show_on_views")]
        public bool VirtualShowOnViews { get; set; }

        [JsonProperty("virtual_show_lead_up")]
        public int VirtualShowLeadUp { get; set; }

        [JsonProperty("virtual_rsvp_email_link")]
        public bool VirtualRsvpEmailLink { get; set; }

        [JsonProperty("virtual_ticket_email_link")]
        public bool VirtualTicketEmailLink { get; set; }

        [JsonProperty("virtual_is_immediate")]
        public bool VirtualIsImmediate { get; set; }

        [JsonProperty("virtual_is_linkable")]
        public bool VirtualIsLinkable { get; set; }

        [JsonProperty("virtual_should_show_embed")]
        public bool VirtualShouldShowEmbed { get; set; }

        [JsonProperty("virtual_should_show_link")]
        public bool VirtualShouldShowLink { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recurring_meta")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaType RecurringMeta { get; set; }

        [JsonProperty("rrule")]
        public string[] Rrule { get; set; }

        [JsonProperty("exclusions")]
        public string[] Exclusions { get; set; }

        [JsonProperty("additional_fields")]
        public UpdatedEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemOrganizersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemVenueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("directions_link")]
        public string DirectionsLink { get; set; }

        [JsonProperty("geolocation")]
        public UpdatedEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType Geolocation { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType
    {
        [JsonProperty("overwrite_coordinates")]
        public bool OverwriteCoordinates { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("distance")]
        public bool Distance { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemCategoryTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parent")]
        public UpdatedEventTriggerResponseEventsTypeItemCategoryTypeItemParentType Parent { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemCategoryTypeItemParentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemTagTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemTicketsType
    {
        [JsonProperty("has_ticket")]
        public bool HasTicket { get; set; }

        [JsonProperty("has_rsvp")]
        public bool HasRsvp { get; set; }

        [JsonProperty("in_date_range")]
        public bool InDateRange { get; set; }

        [JsonProperty("sold_out")]
        public bool SoldOut { get; set; }

        [JsonProperty("tickets")]
        public UpdatedEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem[] Tickets { get; set; }

        [JsonProperty("rsvps")]
        public UpdatedEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem[] Rsvps { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaType
    {
        [JsonProperty("rules")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem[] Rules { get; set; }

        [JsonProperty("exclusions")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem[] Exclusions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }

        [JsonProperty("end-count")]
        public string EndCount { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class UpdatedEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem
    {
        [JsonProperty("additional_field_label")]
        public string AdditionalFieldLabel { get; set; }

        [JsonProperty("additional_field_value")]
        public string AdditionalFieldValue { get; set; }
    }

    public class CanceledEventTriggerResponse
    {
        [JsonProperty("events")]
        public CanceledEventTriggerResponseEventsTypeItem[] Events { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("event_status")]
        public string EventStatus { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        [JsonProperty("organizers")]
        public CanceledEventTriggerResponseEventsTypeItemOrganizersTypeItem[] Organizers { get; set; }

        [JsonProperty("venue")]
        public CanceledEventTriggerResponseEventsTypeItemVenueTypeItem[] Venue { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("category")]
        public CanceledEventTriggerResponseEventsTypeItemCategoryTypeItem[] Category { get; set; }

        [JsonProperty("tag")]
        public CanceledEventTriggerResponseEventsTypeItemTagTypeItem[] Tag { get; set; }

        [JsonProperty("tickets")]
        public CanceledEventTriggerResponseEventsTypeItemTicketsType Tickets { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbr")]
        public string TimezoneAbbr { get; set; }

        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("multi_day")]
        public int MultiDay { get; set; }

        [JsonProperty("is_past")]
        public bool IsPast { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        [JsonProperty("virtual_video_source")]
        public string VirtualVideoSource { get; set; }

        [JsonProperty("virtual_event_type")]
        public string VirtualEventType { get; set; }

        [JsonProperty("virtual_autodetect_source")]
        public string VirtualAutodetectSource { get; set; }

        [JsonProperty("virtual_url")]
        public string VirtualUrl { get; set; }

        [JsonProperty("virtual_meeting_provider")]
        public string VirtualMeetingProvider { get; set; }

        [JsonProperty("virtual_provider_details")]
        public JToken[] VirtualProviderDetails { get; set; }

        [JsonProperty("virtual_embed_video")]
        public bool VirtualEmbedVideo { get; set; }

        [JsonProperty("virtual_linked_button")]
        public bool VirtualLinkedButton { get; set; }

        [JsonProperty("virtual_linked_button_text")]
        public string VirtualLinkedButtonText { get; set; }

        [JsonProperty("virtual_show_embed_at")]
        public string VirtualShowEmbedAt { get; set; }

        [JsonProperty("virtual_show_embed_to")]
        public JToken[] VirtualShowEmbedTo { get; set; }

        [JsonProperty("virtual_show_on_event")]
        public bool VirtualShowOnEvent { get; set; }

        [JsonProperty("virtual_show_on_views")]
        public bool VirtualShowOnViews { get; set; }

        [JsonProperty("virtual_show_lead_up")]
        public int VirtualShowLeadUp { get; set; }

        [JsonProperty("virtual_rsvp_email_link")]
        public bool VirtualRsvpEmailLink { get; set; }

        [JsonProperty("virtual_ticket_email_link")]
        public bool VirtualTicketEmailLink { get; set; }

        [JsonProperty("virtual_is_immediate")]
        public bool VirtualIsImmediate { get; set; }

        [JsonProperty("virtual_is_linkable")]
        public bool VirtualIsLinkable { get; set; }

        [JsonProperty("virtual_should_show_embed")]
        public bool VirtualShouldShowEmbed { get; set; }

        [JsonProperty("virtual_should_show_link")]
        public bool VirtualShouldShowLink { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recurring_meta")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaType RecurringMeta { get; set; }

        [JsonProperty("rrule")]
        public string[] Rrule { get; set; }

        [JsonProperty("exclusions")]
        public string[] Exclusions { get; set; }

        [JsonProperty("additional_fields")]
        public CanceledEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem[] AdditionalFields { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemOrganizersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemVenueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("featured_image_url")]
        public string FeaturedImageUrl { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("directions_link")]
        public string DirectionsLink { get; set; }

        [JsonProperty("geolocation")]
        public CanceledEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType Geolocation { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemVenueTypeItemGeolocationType
    {
        [JsonProperty("overwrite_coordinates")]
        public bool OverwriteCoordinates { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("distance")]
        public bool Distance { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemCategoryTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parent")]
        public CanceledEventTriggerResponseEventsTypeItemCategoryTypeItemParentType Parent { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemCategoryTypeItemParentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemTagTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemTicketsType
    {
        [JsonProperty("has_ticket")]
        public bool HasTicket { get; set; }

        [JsonProperty("has_rsvp")]
        public bool HasRsvp { get; set; }

        [JsonProperty("in_date_range")]
        public bool InDateRange { get; set; }

        [JsonProperty("sold_out")]
        public bool SoldOut { get; set; }

        [JsonProperty("tickets")]
        public CanceledEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem[] Tickets { get; set; }

        [JsonProperty("rsvps")]
        public CanceledEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem[] Rsvps { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemTicketsTypeTicketsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemTicketsTypeRsvpsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("provider_class")]
        public string ProviderClass { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaType
    {
        [JsonProperty("rules")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem[] Rules { get; set; }

        [JsonProperty("exclusions")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem[] Exclusions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }

        [JsonProperty("end-count")]
        public string EndCount { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeRulesTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType Custom { get; set; }
        public string EventStartDate { get; set; }
        public string EventEndDate { get; set; }

        [JsonProperty("end-type")]
        public string EndType { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomType
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("week")]
        public CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType Week { get; set; }

        [JsonProperty("same-time")]
        public string SameTime { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemRecurringMetaTypeExclusionsTypeItemCustomTypeWeekType
    {
        [JsonProperty("day")]
        public string[] Day { get; set; }
    }

    public class CanceledEventTriggerResponseEventsTypeItemAdditionalFieldsTypeItem
    {
        [JsonProperty("additional_field_label")]
        public string AdditionalFieldLabel { get; set; }

        [JsonProperty("additional_field_value")]
        public string AdditionalFieldValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Theeventscalendar;

    public partial class WorkflowManagedActions
    {
        public TheeventscalendarActions Theeventscalendar(string connectionId) => new TheeventscalendarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TheeventscalendarTriggers Theeventscalendar(string connectionId) => new TheeventscalendarTriggers(connectionId);
    }
}