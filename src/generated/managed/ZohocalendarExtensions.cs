//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohocalendar
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohocalendarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<GetCalendarListResponse> GetCalendarList()
        {
            var apiCallPath = "/api/v1/calendars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCalendarListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<GetEventListResponse> GetEventList(Expression<Func<string>> cuid, Expression<Func<bool>> byinstance, Expression<Func<string>> start, Expression<Func<string>> end, Expression<Func<timezoneInput>> timezone = null)
        {
            var apiCallPath = "/api/v1/calendars/getevents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            callPayload.Queries["byinstance"] = ExpressionConverter.Convert(byinstance);
            callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (timezone != null)
                callPayload.Queries["timezone"] = ExpressionConverter.Convert(timezone);
            return new ApiConnectionAction<GetEventListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<DeleteEventResponse> DeleteEvent(Expression<Func<string>> cuid, Expression<Func<string>> euid)
        {
            var apiCallPath = "/api/v1/calendars/event";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            callPayload.Queries["euid"] = ExpressionConverter.Convert(euid);
            return new ApiConnectionAction<DeleteEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<SingleEventRes> UpdateEvent(Expression<Func<string>> cuid, Expression<Func<string>> euid, Expression<Func<string>> bodytitle)
        {
            var apiCallPath = "/api/v1/calendars/event";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            callPayload.Queries["euid"] = ExpressionConverter.Convert(euid);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SingleEventRes>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<SingleEventRes> GetEvent(Expression<Func<string>> cuid, Expression<Func<string>> euid)
        {
            var apiCallPath = "/api/v1/calendars/getEvent";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            callPayload.Queries["euid"] = ExpressionConverter.Convert(euid);
            return new ApiConnectionAction<SingleEventRes>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<SearchEventsResponse> SearchEvents(Expression<Func<string>> cuid, Expression<Func<string>> start, Expression<Func<string>> end = null, Expression<Func<string>> searchtext = null)
        {
            var apiCallPath = "/api/v1/calendars/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (searchtext != null)
                callPayload.Queries["searchtext"] = ExpressionConverter.Convert(searchtext);
            return new ApiConnectionAction<SearchEventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohocalendar")]
        public IBodyWorkflowAction<SingleCalendarRes> GetCalendarDetails(Expression<Func<string>> cuid)
        {
            var apiCallPath = "/api/v1/calendardetail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cuid"] = ExpressionConverter.Convert(cuid);
            return new ApiConnectionAction<SingleCalendarRes>(callPayload);
        }
    }

    public class ZohocalendarTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewEventNotification(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v1/webHooksPresence/external/newevent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["notifyUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["serviceId"] = 5;
            bodypropCount++;
            body["name"] = "newEvent";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger DeleteEventNotification(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v1/webHooksPresence/external/deleteEvent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["notifyUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["serviceId"] = 5;
            bodypropCount++;
            body["name"] = "deleteEvent";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger EditEventNotification(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v1/webHooksPresence/external/editEvent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["notifyUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["serviceId"] = 5;
            bodypropCount++;
            body["name"] = "editEvent";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class GetCalendarListResponse
    {
        [JsonProperty("calendars")]
        public SingleCalendarRes[] Calendars { get; set; }
    }

    public class SingleCalendarRes
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("textcolor")]
        public string Textcolor { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("isdefault")]
        public bool Isdefault { get; set; }

        [JsonProperty("include_infreebusy")]
        public bool IncludeInfreebusy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }
    }

    public class GetEventListResponse
    {
        [JsonProperty("events")]
        public SingleEventRes[] Events { get; set; }
    }

    public class SingleEventRes
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("createdby")]
        public string Createdby { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("viewEventURL")]
        public string ViewEventURL { get; set; }

        [JsonProperty("dateandtime")]
        public SingleEventResDateandtimeType Dateandtime { get; set; }

        [JsonProperty("lastmodifiedtime")]
        public string Lastmodifiedtime { get; set; }

        [JsonProperty("isprivate")]
        public bool Isprivate { get; set; }

        [JsonProperty("attendees")]
        public SingleEventResAttendeesTypeItem[] Attendees { get; set; }

        [JsonProperty("createdtime_millis")]
        public string CreatedtimeMillis { get; set; }

        [JsonProperty("notifyType")]
        public int NotifyType { get; set; }

        [JsonProperty("organizer")]
        public string Organizer { get; set; }

        [JsonProperty("isallday")]
        public bool Isallday { get; set; }

        [JsonProperty("transparency")]
        public int Transparency { get; set; }

        [JsonProperty("modifiedby")]
        public string Modifiedby { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("caluid")]
        public string Caluid { get; set; }

        [JsonProperty("allowForwarding")]
        public bool AllowForwarding { get; set; }

        [JsonProperty("reminders")]
        public SingleEventResRemindersTypeItem[] Reminders { get; set; }
    }

    public class SingleEventResDateandtimeType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class SingleEventResAttendeesTypeItem
    {
        [JsonProperty("dName")]
        public string DName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("attendance")]
        public int Attendance { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class SingleEventResRemindersTypeItem
    {
        [JsonProperty("action")]
        public SingleEventResRemindersTypeItemReminderTypeType ReminderType { get; set; }

        [JsonProperty("minutes")]
        public string RemindMeIn { get; set; }
    }

    public enum SingleEventResRemindersTypeItemReminderTypeType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "popup")]
        Popup,
        [EnumMember(Value = "notification")]
        Notification
    }

    public enum timezoneInput
    {
        [EnumMember(Value = "Etc/GMT+12")]
        EtcGMT12,
        [EnumMember(Value = "Etc/GMT+11")]
        EtcGMT11,
        MIT,
        [EnumMember(Value = "Pacific/Apia")]
        PacificApia,
        [EnumMember(Value = "Pacific/Midway")]
        PacificMidway,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago,
        [EnumMember(Value = "Pacific/Samoa")]
        PacificSamoa,
        [EnumMember(Value = "US/Samoa")]
        USSamoa,
        [EnumMember(Value = "America/Adak")]
        AmericaAdak,
        [EnumMember(Value = "America/Atka")]
        AmericaAtka,
        [EnumMember(Value = "Etc/GMT+10")]
        EtcGMT10,
        HST,
        [EnumMember(Value = "Pacific/Fakaofo")]
        PacificFakaofo,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Johnston")]
        PacificJohnston,
        [EnumMember(Value = "Pacific/Rarotonga")]
        PacificRarotonga,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "SystemV/HST10")]
        SystemVHST10,
        [EnumMember(Value = "US/Aleutian")]
        USAleutian,
        [EnumMember(Value = "US/Hawaii")]
        USHawaii,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        AST,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Juneau")]
        AmericaJuneau,
        [EnumMember(Value = "America/Nome")]
        AmericaNome,
        [EnumMember(Value = "America/Yakutat")]
        AmericaYakutat,
        [EnumMember(Value = "Etc/GMT+9")]
        EtcGMT9,
        [EnumMember(Value = "Pacific/Gambier")]
        PacificGambier,
        [EnumMember(Value = "SystemV/YST9")]
        SystemVYST9,
        [EnumMember(Value = "SystemV/YST9YDT")]
        SystemVYST9YDT,
        [EnumMember(Value = "US/Alaska")]
        USAlaska,
        [EnumMember(Value = "America/Dawson")]
        AmericaDawson,
        [EnumMember(Value = "America/Ensenada")]
        AmericaEnsenada,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Whitehorse")]
        AmericaWhitehorse,
        [EnumMember(Value = "Canada/Pacific")]
        CanadaPacific,
        [EnumMember(Value = "Canada/Yukon")]
        CanadaYukon,
        [EnumMember(Value = "Etc/GMT+8")]
        EtcGMT8,
        [EnumMember(Value = "Mexico/BajaNorte")]
        MexicoBajaNorte,
        PST,
        PST8PDT,
        [EnumMember(Value = "Pacific/Pitcairn")]
        PacificPitcairn,
        [EnumMember(Value = "SystemV/PST8")]
        SystemVPST8,
        [EnumMember(Value = "SystemV/PST8PDT")]
        SystemVPST8PDT,
        [EnumMember(Value = "US/Pacific")]
        USPacific,
        [EnumMember(Value = "America/Boise")]
        AmericaBoise,
        [EnumMember(Value = "America/Cambridge_Bay")]
        AmericaCambridgeBay,
        [EnumMember(Value = "America/Chihuahua")]
        AmericaChihuahua,
        [EnumMember(Value = "America/Dawson_Creek")]
        AmericaDawsonCreek,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton,
        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo,
        [EnumMember(Value = "America/Inuvik")]
        AmericaInuvik,
        [EnumMember(Value = "America/Mazatlan")]
        AmericaMazatlan,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Shiprock")]
        AmericaShiprock,
        [EnumMember(Value = "America/Yellowknife")]
        AmericaYellowknife,
        [EnumMember(Value = "Canada/Mountain")]
        CanadaMountain,
        [EnumMember(Value = "Etc/GMT+7")]
        EtcGMT7,
        MST,
        MST7MDT,
        [EnumMember(Value = "Mexico/BajaSur")]
        MexicoBajaSur,
        Navajo,
        PNT,
        [EnumMember(Value = "SystemV/MST7")]
        SystemVMST7,
        [EnumMember(Value = "SystemV/MST7MDT")]
        SystemVMST7MDT,
        [EnumMember(Value = "US/Arizona")]
        USArizona,
        [EnumMember(Value = "US/Mountain")]
        USMountain,
        [EnumMember(Value = "America/Belize")]
        AmericaBelize,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "America/Indiana/Knox")]
        AmericaIndianaKnox,
        [EnumMember(Value = "America/Indiana/Petersburg")]
        AmericaIndianaPetersburg,
        [EnumMember(Value = "America/Indiana/Vincennes")]
        AmericaIndianaVincennes,
        [EnumMember(Value = "America/Knox_IN")]
        AmericaKnoxIN,
        [EnumMember(Value = "America/Managua")]
        AmericaManagua,
        [EnumMember(Value = "America/Menominee")]
        AmericaMenominee,
        [EnumMember(Value = "America/Merida")]
        AmericaMerida,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Monterrey")]
        AmericaMonterrey,
        [EnumMember(Value = "America/North_Dakota/Center")]
        AmericaNorthDakotaCenter,
        [EnumMember(Value = "America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "America/Rainy_River")]
        AmericaRainyRiver,
        [EnumMember(Value = "America/Rankin_Inlet")]
        AmericaRankinInlet,
        [EnumMember(Value = "America/Regina")]
        AmericaRegina,
        [EnumMember(Value = "America/Swift_Current")]
        AmericaSwiftCurrent,
        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa,
        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg,
        CST,
        CST6CDT,
        [EnumMember(Value = "Canada/Central")]
        CanadaCentral,
        [EnumMember(Value = "Canada/East-Saskatchewan")]
        CanadaEastSaskatchewan,
        [EnumMember(Value = "Canada/Saskatchewan")]
        CanadaSaskatchewan,
        [EnumMember(Value = "Chile/EasterIsland")]
        ChileEasterIsland,
        [EnumMember(Value = "Etc/GMT+6")]
        EtcGMT6,
        [EnumMember(Value = "Mexico/General")]
        MexicoGeneral,
        [EnumMember(Value = "Pacific/Easter")]
        PacificEaster,
        [EnumMember(Value = "Pacific/Galapagos")]
        PacificGalapagos,
        [EnumMember(Value = "SystemV/CST6")]
        SystemVCST6,
        [EnumMember(Value = "SystemV/CST6CDT")]
        SystemVCST6CDT,
        [EnumMember(Value = "US/Central")]
        USCentral,
        [EnumMember(Value = "US/Indiana-Starke")]
        USIndianaStarke,
        [EnumMember(Value = "America/Atikokan")]
        AmericaAtikokan,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Cayman")]
        AmericaCayman,
        [EnumMember(Value = "America/Coral_Harbour")]
        AmericaCoralHarbour,
        [EnumMember(Value = "America/Detroit")]
        AmericaDetroit,
        [EnumMember(Value = "America/Eirunepe")]
        AmericaEirunepe,
        [EnumMember(Value = "America/Fort_Wayne")]
        AmericaFortWayne,
        [EnumMember(Value = "America/Grand_Turk")]
        AmericaGrandTurk,
        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil,
        [EnumMember(Value = "America/Havana")]
        AmericaHavana,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Indiana/Marengo")]
        AmericaIndianaMarengo,
        [EnumMember(Value = "America/Indiana/Vevay")]
        AmericaIndianaVevay,
        [EnumMember(Value = "America/Indianapolis")]
        AmericaIndianapolis,
        [EnumMember(Value = "America/Iqaluit")]
        AmericaIqaluit,
        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica,
        [EnumMember(Value = "America/Kentucky/Louisville")]
        AmericaKentuckyLouisville,
        [EnumMember(Value = "America/Kentucky/Monticello")]
        AmericaKentuckyMonticello,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Louisville")]
        AmericaLouisville,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "America/Nassau")]
        AmericaNassau,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Nipigon")]
        AmericaNipigon,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Pangnirtung")]
        AmericaPangnirtung,
        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince,
        [EnumMember(Value = "America/Porto_Acre")]
        AmericaPortoAcre,
        [EnumMember(Value = "America/Rio_Branco")]
        AmericaRioBranco,
        [EnumMember(Value = "America/Thunder_Bay")]
        AmericaThunderBay,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "Brazil/Acre")]
        BrazilAcre,
        [EnumMember(Value = "Canada/Eastern")]
        CanadaEastern,
        Cuba,
        EST,
        EST5EDT,
        [EnumMember(Value = "Etc/GMT+5")]
        EtcGMT5,
        IET,
        Jamaica,
        [EnumMember(Value = "SystemV/EST5")]
        SystemVEST5,
        [EnumMember(Value = "SystemV/EST5EDT")]
        SystemVEST5EDT,
        [EnumMember(Value = "US/East-Indiana")]
        USEastIndiana,
        [EnumMember(Value = "US/Eastern")]
        USEastern,
        [EnumMember(Value = "US/Michigan")]
        USMichigan,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Anguilla")]
        AmericaAnguilla,
        [EnumMember(Value = "America/Antigua")]
        AmericaAntigua,
        [EnumMember(Value = "America/Aruba")]
        AmericaAruba,
        [EnumMember(Value = "America/Asuncion")]
        AmericaAsuncion,
        [EnumMember(Value = "America/Barbados")]
        AmericaBarbados,
        [EnumMember(Value = "America/Blanc-Sablon")]
        AmericaBlancSablon,
        [EnumMember(Value = "America/Boa_Vista")]
        AmericaBoaVista,
        [EnumMember(Value = "America/Campo_Grande")]
        AmericaCampoGrande,
        [EnumMember(Value = "America/Cuiaba")]
        AmericaCuiaba,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/Dominica")]
        AmericaDominica,
        [EnumMember(Value = "America/Glace_Bay")]
        AmericaGlaceBay,
        [EnumMember(Value = "America/Goose_Bay")]
        AmericaGooseBay,
        [EnumMember(Value = "America/Grenada")]
        AmericaGrenada,
        [EnumMember(Value = "America/Guadeloupe")]
        AmericaGuadeloupe,
        [EnumMember(Value = "America/Guyana")]
        AmericaGuyana,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/La_Paz")]
        AmericaLaPaz,
        [EnumMember(Value = "America/Manaus")]
        AmericaManaus,
        [EnumMember(Value = "America/Martinique")]
        AmericaMartinique,
        [EnumMember(Value = "America/Moncton")]
        AmericaMoncton,
        [EnumMember(Value = "America/Montserrat")]
        AmericaMontserrat,
        [EnumMember(Value = "America/Port_of_Spain")]
        AmericaPortOfSpain,
        [EnumMember(Value = "America/Porto_Velho")]
        AmericaPortoVelho,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Santo_Domingo")]
        AmericaSantoDomingo,
        [EnumMember(Value = "America/St_Kitts")]
        AmericaStKitts,
        [EnumMember(Value = "America/St_Lucia")]
        AmericaStLucia,
        [EnumMember(Value = "America/St_Thomas")]
        AmericaStThomas,
        [EnumMember(Value = "America/St_Vincent")]
        AmericaStVincent,
        [EnumMember(Value = "America/Thule")]
        AmericaThule,
        [EnumMember(Value = "America/Tortola")]
        AmericaTortola,
        [EnumMember(Value = "America/Virgin")]
        AmericaVirgin,
        [EnumMember(Value = "Antarctica/Palmer")]
        AntarcticaPalmer,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "Atlantic/Stanley")]
        AtlanticStanley,
        [EnumMember(Value = "Brazil/West")]
        BrazilWest,
        [EnumMember(Value = "Canada/Atlantic")]
        CanadaAtlantic,
        [EnumMember(Value = "Chile/Continental")]
        ChileContinental,
        [EnumMember(Value = "Etc/GMT+4")]
        EtcGMT4,
        PRT,
        [EnumMember(Value = "SystemV/AST4")]
        SystemVAST4,
        [EnumMember(Value = "SystemV/AST4ADT")]
        SystemVAST4ADT,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        CNT,
        [EnumMember(Value = "Canada/Newfoundland")]
        CanadaNewfoundland,
        AGT,
        [EnumMember(Value = "America/Araguaina")]
        AmericaAraguaina,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca,
        [EnumMember(Value = "America/Argentina/ComodRivadavia")]
        AmericaArgentinaComodRivadavia,
        [EnumMember(Value = "America/Argentina/Cordoba")]
        AmericaArgentinaCordoba,
        [EnumMember(Value = "America/Argentina/Jujuy")]
        AmericaArgentinaJujuy,
        [EnumMember(Value = "America/Argentina/La_Rioja")]
        AmericaArgentinaLaRioja,
        [EnumMember(Value = "America/Argentina/Mendoza")]
        AmericaArgentinaMendoza,
        [EnumMember(Value = "America/Argentina/Rio_Gallegos")]
        AmericaArgentinaRioGallegos,
        [EnumMember(Value = "America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan,
        [EnumMember(Value = "America/Argentina/Tucuman")]
        AmericaArgentinaTucuman,
        [EnumMember(Value = "America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia,
        [EnumMember(Value = "America/Bahia")]
        AmericaBahia,
        [EnumMember(Value = "America/Belem")]
        AmericaBelem,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Catamarca")]
        AmericaCatamarca,
        [EnumMember(Value = "America/Cayenne")]
        AmericaCayenne,
        [EnumMember(Value = "America/Cordoba")]
        AmericaCordoba,
        [EnumMember(Value = "America/Fortaleza")]
        AmericaFortaleza,
        [EnumMember(Value = "America/Godthab")]
        AmericaGodthab,
        [EnumMember(Value = "America/Jujuy")]
        AmericaJujuy,
        [EnumMember(Value = "America/Maceio")]
        AmericaMaceio,
        [EnumMember(Value = "America/Mendoza")]
        AmericaMendoza,
        [EnumMember(Value = "America/Miquelon")]
        AmericaMiquelon,
        [EnumMember(Value = "America/Montevideo")]
        AmericaMontevideo,
        [EnumMember(Value = "America/Paramaribo")]
        AmericaParamaribo,
        [EnumMember(Value = "America/Recife")]
        AmericaRecife,
        [EnumMember(Value = "America/Rosario")]
        AmericaRosario,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Antarctica/Rothera")]
        AntarcticaRothera,
        BET,
        [EnumMember(Value = "Brazil/East")]
        BrazilEast,
        [EnumMember(Value = "Etc/GMT+3")]
        EtcGMT3,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "Brazil/DeNoronha")]
        BrazilDeNoronha,
        [EnumMember(Value = "Etc/GMT+2")]
        EtcGMT2,
        [EnumMember(Value = "America/Scoresbysund")]
        AmericaScoresbysund,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Etc/GMT+1")]
        EtcGMT1,
        [EnumMember(Value = "Africa/Abidjan")]
        AfricaAbidjan,
        [EnumMember(Value = "Africa/Accra")]
        AfricaAccra,
        [EnumMember(Value = "Africa/Bamako")]
        AfricaBamako,
        [EnumMember(Value = "Africa/Banjul")]
        AfricaBanjul,
        [EnumMember(Value = "Africa/Bissau")]
        AfricaBissau,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Conakry")]
        AfricaConakry,
        [EnumMember(Value = "Africa/Dakar")]
        AfricaDakar,
        [EnumMember(Value = "Africa/El_Aaiun")]
        AfricaElAaiun,
        [EnumMember(Value = "Africa/Freetown")]
        AfricaFreetown,
        [EnumMember(Value = "Africa/Lome")]
        AfricaLome,
        [EnumMember(Value = "Africa/Monrovia")]
        AfricaMonrovia,
        [EnumMember(Value = "Africa/Nouakchott")]
        AfricaNouakchott,
        [EnumMember(Value = "Africa/Ouagadougou")]
        AfricaOuagadougou,
        [EnumMember(Value = "Africa/Sao_Tome")]
        AfricaSaoTome,
        [EnumMember(Value = "Africa/Timbuktu")]
        AfricaTimbuktu,
        [EnumMember(Value = "America/Danmarkshavn")]
        AmericaDanmarkshavn,
        [EnumMember(Value = "Atlantic/Canary")]
        AtlanticCanary,
        [EnumMember(Value = "Atlantic/Faeroe")]
        AtlanticFaeroe,
        [EnumMember(Value = "Atlantic/Madeira")]
        AtlanticMadeira,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/St_Helena")]
        AtlanticStHelena,
        Eire,
        [EnumMember(Value = "Etc/GMT")]
        EtcGMT,
        [EnumMember(Value = "Etc/GMT+0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/GMT-0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/GMT0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/Greenwich")]
        EtcGreenwich,
        [EnumMember(Value = "Etc/UCT")]
        EtcUCT,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC,
        [EnumMember(Value = "Etc/Universal")]
        EtcUniversal,
        [EnumMember(Value = "Etc/Zulu")]
        EtcZulu,
        [EnumMember(Value = "Europe/Belfast")]
        EuropeBelfast,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Guernsey")]
        EuropeGuernsey,
        [EnumMember(Value = "Europe/Isle_of_Man")]
        EuropeIsleOfMan,
        [EnumMember(Value = "Europe/Jersey")]
        EuropeJersey,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        GB,
        [EnumMember(Value = "GB-Eire")]
        GBEire,
        GMT,
        GMT0,
        Greenwich,
        Iceland,
        Portugal,
        UCT,
        UTC,
        Universal,
        WET,
        Zulu,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Bangui")]
        AfricaBangui,
        [EnumMember(Value = "Africa/Brazzaville")]
        AfricaBrazzaville,
        [EnumMember(Value = "Africa/Ceuta")]
        AfricaCeuta,
        [EnumMember(Value = "Africa/Douala")]
        AfricaDouala,
        [EnumMember(Value = "Africa/Kinshasa")]
        AfricaKinshasa,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Libreville")]
        AfricaLibreville,
        [EnumMember(Value = "Africa/Luanda")]
        AfricaLuanda,
        [EnumMember(Value = "Africa/Malabo")]
        AfricaMalabo,
        [EnumMember(Value = "Africa/Ndjamena")]
        AfricaNdjamena,
        [EnumMember(Value = "Africa/Niamey")]
        AfricaNiamey,
        [EnumMember(Value = "Africa/Porto-Novo")]
        AfricaPortoNovo,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Windhoek")]
        AfricaWindhoek,
        [EnumMember(Value = "Arctic/Longyearbyen")]
        ArcticLongyearbyen,
        [EnumMember(Value = "Atlantic/Jan_Mayen")]
        AtlanticJanMayen,
        CET,
        ECT,
        [EnumMember(Value = "Etc/GMT-1")]
        EtcGMT1,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Andorra")]
        EuropeAndorra,
        [EnumMember(Value = "Europe/Belgrade")]
        EuropeBelgrade,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Bratislava")]
        EuropeBratislava,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Gibraltar")]
        EuropeGibraltar,
        [EnumMember(Value = "Europe/Ljubljana")]
        EuropeLjubljana,
        [EnumMember(Value = "Europe/Luxembourg")]
        EuropeLuxembourg,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Malta")]
        EuropeMalta,
        [EnumMember(Value = "Europe/Monaco")]
        EuropeMonaco,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Podgorica")]
        EuropePodgorica,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/San_Marino")]
        EuropeSanMarino,
        [EnumMember(Value = "Europe/Sarajevo")]
        EuropeSarajevo,
        [EnumMember(Value = "Europe/Skopje")]
        EuropeSkopje,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Tirane")]
        EuropeTirane,
        [EnumMember(Value = "Europe/Vaduz")]
        EuropeVaduz,
        [EnumMember(Value = "Europe/Vatican")]
        EuropeVatican,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Zagreb")]
        EuropeZagreb,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        MET,
        Poland,
        ART,
        [EnumMember(Value = "Africa/Blantyre")]
        AfricaBlantyre,
        [EnumMember(Value = "Africa/Bujumbura")]
        AfricaBujumbura,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Gaborone")]
        AfricaGaborone,
        [EnumMember(Value = "Africa/Harare")]
        AfricaHarare,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Kigali")]
        AfricaKigali,
        [EnumMember(Value = "Africa/Lubumbashi")]
        AfricaLubumbashi,
        [EnumMember(Value = "Africa/Lusaka")]
        AfricaLusaka,
        [EnumMember(Value = "Africa/Maputo")]
        AfricaMaputo,
        [EnumMember(Value = "Africa/Maseru")]
        AfricaMaseru,
        [EnumMember(Value = "Africa/Mbabane")]
        AfricaMbabane,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Gaza")]
        AsiaGaza,
        [EnumMember(Value = "Asia/Istanbul")]
        AsiaIstanbul,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Nicosia")]
        AsiaNicosia,
        [EnumMember(Value = "Asia/Tel_Aviv")]
        AsiaTelAviv,
        CAT,
        EET,
        Egypt,
        [EnumMember(Value = "Etc/GMT-2")]
        EtcGMT2,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Chisinau")]
        EuropeChisinau,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Kaliningrad")]
        EuropeKaliningrad,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Mariehamn")]
        EuropeMariehamn,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Nicosia")]
        EuropeNicosia,
        [EnumMember(Value = "Europe/Riga")]
        EuropeRiga,
        [EnumMember(Value = "Europe/Simferopol")]
        EuropeSimferopol,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Europe/Tallinn")]
        EuropeTallinn,
        [EnumMember(Value = "Europe/Tiraspol")]
        EuropeTiraspol,
        [EnumMember(Value = "Europe/Uzhgorod")]
        EuropeUzhgorod,
        [EnumMember(Value = "Europe/Vilnius")]
        EuropeVilnius,
        [EnumMember(Value = "Europe/Zaporozhye")]
        EuropeZaporozhye,
        Israel,
        Libya,
        Turkey,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Africa/Asmera")]
        AfricaAsmera,
        [EnumMember(Value = "Africa/Dar_es_Salaam")]
        AfricaDarEsSalaam,
        [EnumMember(Value = "Africa/Djibouti")]
        AfricaDjibouti,
        [EnumMember(Value = "Africa/Kampala")]
        AfricaKampala,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Mogadishu")]
        AfricaMogadishu,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Antarctica/Syowa")]
        AntarcticaSyowa,
        [EnumMember(Value = "Asia/Aden")]
        AsiaAden,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Bahrain")]
        AsiaBahrain,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Qatar")]
        AsiaQatar,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        EAT,
        [EnumMember(Value = "Etc/GMT-3")]
        EtcGMT3,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Volgograd")]
        EuropeVolgograd,
        [EnumMember(Value = "Indian/Antananarivo")]
        IndianAntananarivo,
        [EnumMember(Value = "Indian/Comoro")]
        IndianComoro,
        [EnumMember(Value = "Indian/Mayotte")]
        IndianMayotte,
        [EnumMember(Value = "W-SU")]
        WSU,
        [EnumMember(Value = "Asia/Riyadh87")]
        AsiaRiyadh87,
        [EnumMember(Value = "Asia/Riyadh88")]
        AsiaRiyadh88,
        [EnumMember(Value = "Asia/Riyadh89")]
        AsiaRiyadh89,
        [EnumMember(Value = "Mideast/Riyadh87")]
        MideastRiyadh87,
        [EnumMember(Value = "Mideast/Riyadh88")]
        MideastRiyadh88,
        [EnumMember(Value = "Mideast/Riyadh89")]
        MideastRiyadh89,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        Iran,
        [EnumMember(Value = "Asia/Baku")]
        AsiaBaku,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Muscat")]
        AsiaMuscat,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Yerevan")]
        AsiaYerevan,
        [EnumMember(Value = "Etc/GMT-4")]
        EtcGMT4,
        [EnumMember(Value = "Europe/Samara")]
        EuropeSamara,
        [EnumMember(Value = "Indian/Mahe")]
        IndianMahe,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius,
        [EnumMember(Value = "Indian/Reunion")]
        IndianReunion,
        NET,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Aqtau")]
        AsiaAqtau,
        [EnumMember(Value = "Asia/Aqtobe")]
        AsiaAqtobe,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Ashkhabad")]
        AsiaAshkhabad,
        [EnumMember(Value = "Asia/Dushanbe")]
        AsiaDushanbe,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Oral")]
        AsiaOral,
        [EnumMember(Value = "Asia/Samarkand")]
        AsiaSamarkand,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Etc/GMT-5")]
        EtcGMT5,
        [EnumMember(Value = "Indian/Kerguelen")]
        IndianKerguelen,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        PLT,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Calcutta")]
        AsiaCalcutta,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        IST,
        [EnumMember(Value = "Asia/Katmandu")]
        AsiaKatmandu,
        [EnumMember(Value = "Antarctica/Mawson")]
        AntarcticaMawson,
        [EnumMember(Value = "Antarctica/Vostok")]
        AntarcticaVostok,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Bishkek")]
        AsiaBishkek,
        [EnumMember(Value = "Asia/Dacca")]
        AsiaDacca,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Omsk")]
        AsiaOmsk,
        [EnumMember(Value = "Asia/Qyzylorda")]
        AsiaQyzylorda,
        [EnumMember(Value = "Asia/Thimbu")]
        AsiaThimbu,
        [EnumMember(Value = "Asia/Thimphu")]
        AsiaThimphu,
        BST,
        [EnumMember(Value = "Etc/GMT-6")]
        EtcGMT6,
        [EnumMember(Value = "Indian/Chagos")]
        IndianChagos,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Indian/Cocos")]
        IndianCocos,
        [EnumMember(Value = "Antarctica/Davis")]
        AntarcticaDavis,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Hovd")]
        AsiaHovd,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Pontianak")]
        AsiaPontianak,
        [EnumMember(Value = "Asia/Saigon")]
        AsiaSaigon,
        [EnumMember(Value = "Asia/Vientiane")]
        AsiaVientiane,
        [EnumMember(Value = "Etc/GMT-7")]
        EtcGMT7,
        [EnumMember(Value = "Indian/Christmas")]
        IndianChristmas,
        VST,
        [EnumMember(Value = "Antarctica/Casey")]
        AntarcticaCasey,
        [EnumMember(Value = "Asia/Brunei")]
        AsiaBrunei,
        [EnumMember(Value = "Asia/Chongqing")]
        AsiaChongqing,
        [EnumMember(Value = "Asia/Harbin")]
        AsiaHarbin,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Kashgar")]
        AsiaKashgar,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Kuching")]
        AsiaKuching,
        [EnumMember(Value = "Asia/Macao")]
        AsiaMacao,
        [EnumMember(Value = "Asia/Makassar")]
        AsiaMakassar,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Ujung_Pandang")]
        AsiaUjungPandang,
        [EnumMember(Value = "Asia/Ulaanbaatar")]
        AsiaUlaanbaatar,
        [EnumMember(Value = "Asia/Ulan_Bator")]
        AsiaUlanBator,
        [EnumMember(Value = "Asia/Urumqi")]
        AsiaUrumqi,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/West")]
        AustraliaWest,
        CTT,
        [EnumMember(Value = "Etc/GMT-8")]
        EtcGMT8,
        PRC,
        Singapore,
        [EnumMember(Value = "Asia/Choibalsan")]
        AsiaChoibalsan,
        [EnumMember(Value = "Asia/Dili")]
        AsiaDili,
        [EnumMember(Value = "Asia/Jayapura")]
        AsiaJayapura,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Yakutsk")]
        AsiaYakutsk,
        [EnumMember(Value = "Etc/GMT-9")]
        EtcGMT9,
        JST,
        Japan,
        [EnumMember(Value = "Pacific/Palau")]
        PacificPalau,
        ROK,
        ACT,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Broken_Hill")]
        AustraliaBrokenHill,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/North")]
        AustraliaNorth,
        [EnumMember(Value = "Australia/South")]
        AustraliaSouth,
        [EnumMember(Value = "Australia/Yancowinna")]
        AustraliaYancowinna,
        AET,
        [EnumMember(Value = "Antarctica/DumontDUrville")]
        AntarcticaDumontDUrville,
        [EnumMember(Value = "Asia/Sakhalin")]
        AsiaSakhalin,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Australia/ACT")]
        AustraliaACT,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Canberra")]
        AustraliaCanberra,
        [EnumMember(Value = "Australia/Currie")]
        AustraliaCurrie,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Australia/Lindeman")]
        AustraliaLindeman,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/NSW")]
        AustraliaNSW,
        [EnumMember(Value = "Australia/Queensland")]
        AustraliaQueensland,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Tasmania")]
        AustraliaTasmania,
        [EnumMember(Value = "Australia/Victoria")]
        AustraliaVictoria,
        [EnumMember(Value = "Etc/GMT-10")]
        EtcGMT10,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Saipan")]
        PacificSaipan,
        [EnumMember(Value = "Pacific/Truk")]
        PacificTruk,
        [EnumMember(Value = "Pacific/Yap")]
        PacificYap,
        [EnumMember(Value = "Australia/LHI")]
        AustraliaLHI,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Etc/GMT-11")]
        EtcGMT11,
        [EnumMember(Value = "Pacific/Efate")]
        PacificEfate,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Kosrae")]
        PacificKosrae,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Ponape")]
        PacificPonape,
        SST,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Antarctica/McMurdo")]
        AntarcticaMcMurdo,
        [EnumMember(Value = "Antarctica/South_Pole")]
        AntarcticaSouthPole,
        [EnumMember(Value = "Asia/Anadyr")]
        AsiaAnadyr,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Etc/GMT-12")]
        EtcGMT12,
        Kwajalein,
        NST,
        NZ,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Funafuti")]
        PacificFunafuti,
        [EnumMember(Value = "Pacific/Kwajalein")]
        PacificKwajalein,
        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro,
        [EnumMember(Value = "Pacific/Nauru")]
        PacificNauru,
        [EnumMember(Value = "Pacific/Tarawa")]
        PacificTarawa,
        [EnumMember(Value = "Pacific/Wake")]
        PacificWake,
        [EnumMember(Value = "Pacific/Wallis")]
        PacificWallis,
        [EnumMember(Value = "NZ-CHAT")]
        NZCHAT,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Etc/GMT-13")]
        EtcGMT13,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Etc/GMT-14")]
        EtcGMT14,
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "America/Punta_Arenas")]
        AmericaPuntaArenas,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Macau")]
        AsiaMacau,
        [EnumMember(Value = "Pacific/Chuuk")]
        PacificChuuk,
        [EnumMember(Value = "Pacific/Pohnpei")]
        PacificPohnpei,
        [EnumMember(Value = "Atlantic/Faroe")]
        AtlanticFaroe
    }

    public class DeleteEventResponse
    {
        [JsonProperty("events")]
        public DeleteEventResponseEventsTypeItem[] Events { get; set; }
    }

    public class DeleteEventResponseEventsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("recurrenceid")]
        public string Recurrenceid { get; set; }
    }

    public class SearchEventsResponse
    {
        [JsonProperty("search")]
        public SearchEventsResponseSearchTypeItem[] Search { get; set; }
    }

    public class SearchEventsResponseSearchTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("isallday")]
        public bool Isallday { get; set; }

        [JsonProperty("caluid")]
        public string Caluid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("dateandtime")]
        public SearchEventsResponseSearchTypeItemDateandtimeType Dateandtime { get; set; }
    }

    public class SearchEventsResponseSearchTypeItemDateandtimeType
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zohocalendar;

    public partial class WorkflowManagedActions
    {
        public ZohocalendarActions Zohocalendar(string connectionId) => new ZohocalendarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZohocalendarTriggers Zohocalendar(string connectionId) => new ZohocalendarTriggers(connectionId);
    }
}