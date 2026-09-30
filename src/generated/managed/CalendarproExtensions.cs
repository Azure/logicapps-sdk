//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Calendarpro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CalendarproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarpro")]
        public IBodyWorkflowAction<Event> GetEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Event>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarpro")]
        public IWorkflowAction DeleteEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarpro")]
        public IBodyWorkflowAction<Event> UpdateEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> eventId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<bodytimeZoneInput> bodytimeZone, [WorkflowExpression] Func<string> bodyaddressfullAddress, [WorkflowExpression] Func<double> bodyaddresslat, [WorkflowExpression] Func<double> bodyaddresslng, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycolor = null, [WorkflowExpression] Func<string> bodyresourceId = null, [WorkflowExpression] Func<bodymodeRecurrenceInput> bodymodeRecurrence = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            SourceExpression.Validate(eventId, nameof(eventId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            SourceExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: true);
            SourceExpression.Validate(bodyaddressfullAddress, nameof(bodyaddressfullAddress), required: true);
            SourceExpression.Validate(bodyaddresslat, nameof(bodyaddresslat), required: true);
            SourceExpression.Validate(bodyaddresslng, nameof(bodyaddresslng), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            SourceExpression.Validate(bodyresourceId, nameof(bodyresourceId), required: false);
            SourceExpression.Validate(bodymodeRecurrence, nameof(bodymodeRecurrence), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
                body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                if (bodycolor != null)
                {
                    body["color"] = SourceExpressionConverter.ConvertToken(bodycolor);
                    bodypropCount++;
                }

                if (bodyresourceId != null)
                {
                    body["resourceId"] = SourceExpressionConverter.ConvertToken(bodyresourceId);
                    bodypropCount++;
                }

                if (bodymodeRecurrence != null)
                {
                    body["modeRecurrence"] = SourceExpressionConverter.Convert(bodymodeRecurrence);
                    bodypropCount++;
                }

                bodypropCount++;
                body["timeZone"] = SourceExpressionConverter.Convert(bodytimeZone);
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["fullAddress"] = SourceExpressionConverter.ConvertToken(bodyaddressfullAddress);
                addressObjectpropCount++;
                addressObject["lat"] = SourceExpressionConverter.ConvertToken(bodyaddresslat);
                addressObjectpropCount++;
                addressObject["lng"] = SourceExpressionConverter.ConvertToken(bodyaddresslng);
                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Event>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarpro")]
        public IBodyWorkflowAction<Event[]> GetAllEvents([WorkflowExpression] Func<string> calendarId)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Event[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "calendarpro")]
        public IBodyWorkflowAction<Event> CreateNewEvent([WorkflowExpression] Func<string> calendarId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodyendDate, [WorkflowExpression] Func<bodytimeZoneInput> bodytimeZone, [WorkflowExpression] Func<string> bodyaddressfullAddress, [WorkflowExpression] Func<double> bodyaddresslat, [WorkflowExpression] Func<double> bodyaddresslng, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycolor = null, [WorkflowExpression] Func<string> bodyresourceId = null, [WorkflowExpression] Func<bodymodeRecurrenceInput> bodymodeRecurrence = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            SourceExpression.Validate(calendarId, nameof(calendarId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: true);
            SourceExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: true);
            SourceExpression.Validate(bodyaddressfullAddress, nameof(bodyaddressfullAddress), required: true);
            SourceExpression.Validate(bodyaddresslat, nameof(bodyaddresslat), required: true);
            SourceExpression.Validate(bodyaddresslng, nameof(bodyaddresslng), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            SourceExpression.Validate(bodyresourceId, nameof(bodyresourceId), required: false);
            SourceExpression.Validate(bodymodeRecurrence, nameof(bodymodeRecurrence), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(calendarId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
                body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                if (bodycolor != null)
                {
                    body["color"] = SourceExpressionConverter.ConvertToken(bodycolor);
                    bodypropCount++;
                }

                if (bodyresourceId != null)
                {
                    body["resourceId"] = SourceExpressionConverter.ConvertToken(bodyresourceId);
                    bodypropCount++;
                }

                if (bodymodeRecurrence != null)
                {
                    body["modeRecurrence"] = SourceExpressionConverter.Convert(bodymodeRecurrence);
                    bodypropCount++;
                }

                bodypropCount++;
                body["timeZone"] = SourceExpressionConverter.Convert(bodytimeZone);
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["fullAddress"] = SourceExpressionConverter.ConvertToken(bodyaddressfullAddress);
                addressObjectpropCount++;
                addressObject["lat"] = SourceExpressionConverter.ConvertToken(bodyaddresslat);
                addressObjectpropCount++;
                addressObject["lng"] = SourceExpressionConverter.ConvertToken(bodyaddresslng);
                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Event>(BuildSourceInput);
        }
    }

    public class CalendarproTriggers([ConnectionName] string connectionId)
    {
    }

    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("calendarId")]
        public string CalendarId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("allDay")]
        public bool AllDay { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("resourceName")]
        public string ResourceName { get; set; }

        [JsonProperty("rrule")]
        public RecurrenceRule Rrule { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("modeRecurrence")]
        public OptionRecurrence ModeRecurrence { get; set; }

        [JsonProperty("timeZone")]
        public EventTimeZoneType TimeZone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class RecurrenceRule
    {
        [JsonProperty("freq")]
        public string Freq { get; set; }

        [JsonProperty("dtstart")]
        public string Dtstart { get; set; }

        [JsonProperty("until")]
        public string Until { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("wkst")]
        public WeekDay Wkst { get; set; }

        [JsonProperty("byweekday")]
        public WeekDay[] Byweekday { get; set; }

        [JsonProperty("bymonth")]
        public int[] Bymonth { get; set; }

        [JsonProperty("bysetpos")]
        public int[] Bysetpos { get; set; }

        [JsonProperty("bymonthday")]
        public int[] Bymonthday { get; set; }

        [JsonProperty("byyearday")]
        public int[] Byyearday { get; set; }

        [JsonProperty("byweekno")]
        public int[] Byweekno { get; set; }

        [JsonProperty("byhour")]
        public int[] Byhour { get; set; }

        [JsonProperty("byminute")]
        public int[] Byminute { get; set; }

        [JsonProperty("bysecond")]
        public int[] Bysecond { get; set; }
    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum OptionRecurrence
    {
        NotRepeat,
        Workweek,
        Daily,
        Weekly,
        Monthly,
        Yearly,
        Custom
    }

    public enum EventTimeZoneType
    {
        [EnumMember(Value = "Africa/Abidjan")]
        AfricaAbidjan,
        [EnumMember(Value = "Africa/Accra")]
        AfricaAccra,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Bissau")]
        AfricaBissau,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Ceuta")]
        AfricaCeuta,
        [EnumMember(Value = "Africa/El_Aaiun")]
        AfricaElAaiun,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Juba")]
        AfricaJuba,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Maputo")]
        AfricaMaputo,
        [EnumMember(Value = "Africa/Monrovia")]
        AfricaMonrovia,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Ndjamena")]
        AfricaNdjamena,
        [EnumMember(Value = "Africa/Sao_Tome")]
        AfricaSaoTome,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Windhoek")]
        AfricaWindhoek,
        [EnumMember(Value = "America/Adak")]
        AmericaAdak,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Araguaina")]
        AmericaAraguaina,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca,
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
        [EnumMember(Value = "America/Argentina/Salta")]
        AmericaArgentinaSalta,
        [EnumMember(Value = "America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan,
        [EnumMember(Value = "America/Argentina/San_Luis")]
        AmericaArgentinaSanLuis,
        [EnumMember(Value = "America/Argentina/Tucuman")]
        AmericaArgentinaTucuman,
        [EnumMember(Value = "America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia,
        [EnumMember(Value = "America/Asuncion")]
        AmericaAsuncion,
        [EnumMember(Value = "America/Atikokan")]
        AmericaAtikokan,
        [EnumMember(Value = "America/Bahia")]
        AmericaBahia,
        [EnumMember(Value = "America/Bahia_Banderas")]
        AmericaBahiaBanderas,
        [EnumMember(Value = "America/Barbados")]
        AmericaBarbados,
        [EnumMember(Value = "America/Belem")]
        AmericaBelem,
        [EnumMember(Value = "America/Belize")]
        AmericaBelize,
        [EnumMember(Value = "America/Blanc-Sablon")]
        AmericaBlancSablon,
        [EnumMember(Value = "America/Boa_Vista")]
        AmericaBoaVista,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Boise")]
        AmericaBoise,
        [EnumMember(Value = "America/Cambridge_Bay")]
        AmericaCambridgeBay,
        [EnumMember(Value = "America/Campo_Grande")]
        AmericaCampoGrande,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Cayenne")]
        AmericaCayenne,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Chihuahua")]
        AmericaChihuahua,
        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica,
        [EnumMember(Value = "America/Creston")]
        AmericaCreston,
        [EnumMember(Value = "America/Cuiaba")]
        AmericaCuiaba,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/Danmarkshavn")]
        AmericaDanmarkshavn,
        [EnumMember(Value = "America/Dawson")]
        AmericaDawson,
        [EnumMember(Value = "America/Dawson_Creek")]
        AmericaDawsonCreek,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Detroit")]
        AmericaDetroit,
        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton,
        [EnumMember(Value = "America/Eirunepe")]
        AmericaEirunepe,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Fort_Nelson")]
        AmericaFortNelson,
        [EnumMember(Value = "America/Fortaleza")]
        AmericaFortaleza,
        [EnumMember(Value = "America/Glace_Bay")]
        AmericaGlaceBay,
        [EnumMember(Value = "America/Goose_Bay")]
        AmericaGooseBay,
        [EnumMember(Value = "America/Grand_Turk")]
        AmericaGrandTurk,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil,
        [EnumMember(Value = "America/Guyana")]
        AmericaGuyana,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Havana")]
        AmericaHavana,
        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Indiana/Knox")]
        AmericaIndianaKnox,
        [EnumMember(Value = "America/Indiana/Marengo")]
        AmericaIndianaMarengo,
        [EnumMember(Value = "America/Indiana/Petersburg")]
        AmericaIndianaPetersburg,
        [EnumMember(Value = "America/Indiana/Tell_City")]
        AmericaIndianaTellCity,
        [EnumMember(Value = "America/Indiana/Vevay")]
        AmericaIndianaVevay,
        [EnumMember(Value = "America/Indiana/Vincennes")]
        AmericaIndianaVincennes,
        [EnumMember(Value = "America/Indiana/Winamac")]
        AmericaIndianaWinamac,
        [EnumMember(Value = "America/Inuvik")]
        AmericaInuvik,
        [EnumMember(Value = "America/Iqaluit")]
        AmericaIqaluit,
        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica,
        [EnumMember(Value = "America/Juneau")]
        AmericaJuneau,
        [EnumMember(Value = "America/Kentucky/Louisville")]
        AmericaKentuckyLouisville,
        [EnumMember(Value = "America/Kentucky/Monticello")]
        AmericaKentuckyMonticello,
        [EnumMember(Value = "America/La_Paz")]
        AmericaLaPaz,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Maceio")]
        AmericaMaceio,
        [EnumMember(Value = "America/Managua")]
        AmericaManagua,
        [EnumMember(Value = "America/Manaus")]
        AmericaManaus,
        [EnumMember(Value = "America/Martinique")]
        AmericaMartinique,
        [EnumMember(Value = "America/Matamoros")]
        AmericaMatamoros,
        [EnumMember(Value = "America/Mazatlan")]
        AmericaMazatlan,
        [EnumMember(Value = "America/Menominee")]
        AmericaMenominee,
        [EnumMember(Value = "America/Merida")]
        AmericaMerida,
        [EnumMember(Value = "America/Metlakatla")]
        AmericaMetlakatla,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Miquelon")]
        AmericaMiquelon,
        [EnumMember(Value = "America/Moncton")]
        AmericaMoncton,
        [EnumMember(Value = "America/Monterrey")]
        AmericaMonterrey,
        [EnumMember(Value = "America/Montevideo")]
        AmericaMontevideo,
        [EnumMember(Value = "America/Nassau")]
        AmericaNassau,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Nipigon")]
        AmericaNipigon,
        [EnumMember(Value = "America/Nome")]
        AmericaNome,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "America/North_Dakota/Beulah")]
        AmericaNorthDakotaBeulah,
        [EnumMember(Value = "America/North_Dakota/Center")]
        AmericaNorthDakotaCenter,
        [EnumMember(Value = "America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "America/Nuuk")]
        AmericaNuuk,
        [EnumMember(Value = "America/Ojinaga")]
        AmericaOjinaga,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Pangnirtung")]
        AmericaPangnirtung,
        [EnumMember(Value = "America/Paramaribo")]
        AmericaParamaribo,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince,
        [EnumMember(Value = "America/Port_of_Spain")]
        AmericaPortOfSpain,
        [EnumMember(Value = "America/Porto_Velho")]
        AmericaPortoVelho,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "America/Punta_Arenas")]
        AmericaPuntaArenas,
        [EnumMember(Value = "America/Rainy_River")]
        AmericaRainyRiver,
        [EnumMember(Value = "America/Rankin_Inlet")]
        AmericaRankinInlet,
        [EnumMember(Value = "America/Recife")]
        AmericaRecife,
        [EnumMember(Value = "America/Regina")]
        AmericaRegina,
        [EnumMember(Value = "America/Resolute")]
        AmericaResolute,
        [EnumMember(Value = "America/Rio_Branco")]
        AmericaRioBranco,
        [EnumMember(Value = "America/Santarem")]
        AmericaSantarem,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Santo_Domingo")]
        AmericaSantoDomingo,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Scoresbysund")]
        AmericaScoresbysund,
        [EnumMember(Value = "America/Sitka")]
        AmericaSitka,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Swift_Current")]
        AmericaSwiftCurrent,
        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa,
        [EnumMember(Value = "America/Thule")]
        AmericaThule,
        [EnumMember(Value = "America/Thunder_Bay")]
        AmericaThunderBay,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Whitehorse")]
        AmericaWhitehorse,
        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg,
        [EnumMember(Value = "America/Yakutat")]
        AmericaYakutat,
        [EnumMember(Value = "America/Yellowknife")]
        AmericaYellowknife,
        [EnumMember(Value = "Antarctica/Casey")]
        AntarcticaCasey,
        [EnumMember(Value = "Antarctica/Davis")]
        AntarcticaDavis,
        [EnumMember(Value = "Antarctica/DumontDUrville")]
        AntarcticaDumontDUrville,
        [EnumMember(Value = "Antarctica/Macquarie")]
        AntarcticaMacquarie,
        [EnumMember(Value = "Antarctica/Mawson")]
        AntarcticaMawson,
        [EnumMember(Value = "Antarctica/Palmer")]
        AntarcticaPalmer,
        [EnumMember(Value = "Antarctica/Rothera")]
        AntarcticaRothera,
        [EnumMember(Value = "Antarctica/Syowa")]
        AntarcticaSyowa,
        [EnumMember(Value = "Antarctica/Troll")]
        AntarcticaTroll,
        [EnumMember(Value = "Antarctica/Vostok")]
        AntarcticaVostok,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Anadyr")]
        AsiaAnadyr,
        [EnumMember(Value = "Asia/Aqtau")]
        AsiaAqtau,
        [EnumMember(Value = "Asia/Aqtobe")]
        AsiaAqtobe,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Atyrau")]
        AsiaAtyrau,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Baku")]
        AsiaBaku,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Barnaul")]
        AsiaBarnaul,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Bishkek")]
        AsiaBishkek,
        [EnumMember(Value = "Asia/Brunei")]
        AsiaBrunei,
        [EnumMember(Value = "Asia/Chita")]
        AsiaChita,
        [EnumMember(Value = "Asia/Choibalsan")]
        AsiaChoibalsan,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Dili")]
        AsiaDili,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Dushanbe")]
        AsiaDushanbe,
        [EnumMember(Value = "Asia/Famagusta")]
        AsiaFamagusta,
        [EnumMember(Value = "Asia/Gaza")]
        AsiaGaza,
        [EnumMember(Value = "Asia/Hebron")]
        AsiaHebron,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Hovd")]
        AsiaHovd,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Jayapura")]
        AsiaJayapura,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Khandyga")]
        AsiaKhandyga,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Kuching")]
        AsiaKuching,
        [EnumMember(Value = "Asia/Macau")]
        AsiaMacau,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Asia/Makassar")]
        AsiaMakassar,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Nicosia")]
        AsiaNicosia,
        [EnumMember(Value = "Asia/Novokuznetsk")]
        AsiaNovokuznetsk,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Omsk")]
        AsiaOmsk,
        [EnumMember(Value = "Asia/Oral")]
        AsiaOral,
        [EnumMember(Value = "Asia/Pontianak")]
        AsiaPontianak,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Qatar")]
        AsiaQatar,
        [EnumMember(Value = "Asia/Qostanay")]
        AsiaQostanay,
        [EnumMember(Value = "Asia/Qyzylorda")]
        AsiaQyzylorda,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Sakhalin")]
        AsiaSakhalin,
        [EnumMember(Value = "Asia/Samarkand")]
        AsiaSamarkand,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Srednekolymsk")]
        AsiaSrednekolymsk,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Thimphu")]
        AsiaThimphu,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Tomsk")]
        AsiaTomsk,
        [EnumMember(Value = "Asia/Ulaanbaatar")]
        AsiaUlaanbaatar,
        [EnumMember(Value = "Asia/Urumqi")]
        AsiaUrumqi,
        [EnumMember(Value = "Asia/Ust-Nera")]
        AsiaUstNera,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Yakutsk")]
        AsiaYakutsk,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Yerevan")]
        AsiaYerevan,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "Atlantic/Canary")]
        AtlanticCanary,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Atlantic/Faroe")]
        AtlanticFaroe,
        [EnumMember(Value = "Atlantic/Madeira")]
        AtlanticMadeira,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "Atlantic/Stanley")]
        AtlanticStanley,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Broken_Hill")]
        AustraliaBrokenHill,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Eucla")]
        AustraliaEucla,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Australia/Lindeman")]
        AustraliaLindeman,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        CET,
        CST6CDT,
        EET,
        EST,
        EST5EDT,
        [EnumMember(Value = "Etc/GMT")]
        EtcGMT,
        [EnumMember(Value = "Etc/GMT+1")]
        EtcGMT1,
        [EnumMember(Value = "Etc/GMT+10")]
        EtcGMT10,
        [EnumMember(Value = "Etc/GMT+11")]
        EtcGMT11,
        [EnumMember(Value = "Etc/GMT+12")]
        EtcGMT12,
        [EnumMember(Value = "Etc/GMT+2")]
        EtcGMT2,
        [EnumMember(Value = "Etc/GMT+3")]
        EtcGMT3,
        [EnumMember(Value = "Etc/GMT+4")]
        EtcGMT4,
        [EnumMember(Value = "Etc/GMT+5")]
        EtcGMT5,
        [EnumMember(Value = "Etc/GMT+6")]
        EtcGMT6,
        [EnumMember(Value = "Etc/GMT+7")]
        EtcGMT7,
        [EnumMember(Value = "Etc/GMT+8")]
        EtcGMT8,
        [EnumMember(Value = "Etc/GMT+9")]
        EtcGMT9,
        [EnumMember(Value = "Etc/GMT-1")]
        EtcGMT15,
        [EnumMember(Value = "Etc/GMT-10")]
        EtcGMT102,
        [EnumMember(Value = "Etc/GMT-11")]
        EtcGMT112,
        [EnumMember(Value = "Etc/GMT-12")]
        EtcGMT122,
        [EnumMember(Value = "Etc/GMT-13")]
        EtcGMT13,
        [EnumMember(Value = "Etc/GMT-14")]
        EtcGMT14,
        [EnumMember(Value = "Etc/GMT-2")]
        EtcGMT22,
        [EnumMember(Value = "Etc/GMT-3")]
        EtcGMT32,
        [EnumMember(Value = "Etc/GMT-4")]
        EtcGMT42,
        [EnumMember(Value = "Etc/GMT-5")]
        EtcGMT52,
        [EnumMember(Value = "Etc/GMT-6")]
        EtcGMT62,
        [EnumMember(Value = "Etc/GMT-7")]
        EtcGMT72,
        [EnumMember(Value = "Etc/GMT-8")]
        EtcGMT82,
        [EnumMember(Value = "Etc/GMT-9")]
        EtcGMT92,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Andorra")]
        EuropeAndorra,
        [EnumMember(Value = "Europe/Astrakhan")]
        EuropeAstrakhan,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Belgrade")]
        EuropeBelgrade,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Chisinau")]
        EuropeChisinau,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Gibraltar")]
        EuropeGibraltar,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Kaliningrad")]
        EuropeKaliningrad,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Kirov")]
        EuropeKirov,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Luxembourg")]
        EuropeLuxembourg,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Malta")]
        EuropeMalta,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Monaco")]
        EuropeMonaco,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Riga")]
        EuropeRiga,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Samara")]
        EuropeSamara,
        [EnumMember(Value = "Europe/Saratov")]
        EuropeSaratov,
        [EnumMember(Value = "Europe/Simferopol")]
        EuropeSimferopol,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Tallinn")]
        EuropeTallinn,
        [EnumMember(Value = "Europe/Tirane")]
        EuropeTirane,
        [EnumMember(Value = "Europe/Ulyanovsk")]
        EuropeUlyanovsk,
        [EnumMember(Value = "Europe/Uzhgorod")]
        EuropeUzhgorod,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Vilnius")]
        EuropeVilnius,
        [EnumMember(Value = "Europe/Volgograd")]
        EuropeVolgograd,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Zaporozhye")]
        EuropeZaporozhye,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        HST,
        [EnumMember(Value = "Indian/Chagos")]
        IndianChagos,
        [EnumMember(Value = "Indian/Christmas")]
        IndianChristmas,
        [EnumMember(Value = "Indian/Cocos")]
        IndianCocos,
        [EnumMember(Value = "Indian/Kerguelen")]
        IndianKerguelen,
        [EnumMember(Value = "Indian/Mahe")]
        IndianMahe,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius,
        [EnumMember(Value = "Indian/Reunion")]
        IndianReunion,
        MET,
        MST,
        MST7MDT,
        PST8PDT,
        [EnumMember(Value = "Pacific/Apia")]
        PacificApia,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Bougainville")]
        PacificBougainville,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Chuuk")]
        PacificChuuk,
        [EnumMember(Value = "Pacific/Easter")]
        PacificEaster,
        [EnumMember(Value = "Pacific/Efate")]
        PacificEfate,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fakaofo")]
        PacificFakaofo,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Funafuti")]
        PacificFunafuti,
        [EnumMember(Value = "Pacific/Galapagos")]
        PacificGalapagos,
        [EnumMember(Value = "Pacific/Gambier")]
        PacificGambier,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Kosrae")]
        PacificKosrae,
        [EnumMember(Value = "Pacific/Kwajalein")]
        PacificKwajalein,
        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Pacific/Nauru")]
        PacificNauru,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago,
        [EnumMember(Value = "Pacific/Palau")]
        PacificPalau,
        [EnumMember(Value = "Pacific/Pitcairn")]
        PacificPitcairn,
        [EnumMember(Value = "Pacific/Pohnpei")]
        PacificPohnpei,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Rarotonga")]
        PacificRarotonga,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Tarawa")]
        PacificTarawa,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Wake")]
        PacificWake,
        [EnumMember(Value = "Pacific/Wallis")]
        PacificWallis,
        WET
    }

    public class Address
    {
        [JsonProperty("fullAddress")]
        public string FullAddress { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public enum bodytimeZoneInput
    {
        [EnumMember(Value = "Africa/Abidjan")]
        AfricaAbidjan,
        [EnumMember(Value = "Africa/Accra")]
        AfricaAccra,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Bissau")]
        AfricaBissau,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/Ceuta")]
        AfricaCeuta,
        [EnumMember(Value = "Africa/El_Aaiun")]
        AfricaElAaiun,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Juba")]
        AfricaJuba,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Maputo")]
        AfricaMaputo,
        [EnumMember(Value = "Africa/Monrovia")]
        AfricaMonrovia,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Africa/Ndjamena")]
        AfricaNdjamena,
        [EnumMember(Value = "Africa/Sao_Tome")]
        AfricaSaoTome,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Africa/Windhoek")]
        AfricaWindhoek,
        [EnumMember(Value = "America/Adak")]
        AmericaAdak,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Araguaina")]
        AmericaAraguaina,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca,
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
        [EnumMember(Value = "America/Argentina/Salta")]
        AmericaArgentinaSalta,
        [EnumMember(Value = "America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan,
        [EnumMember(Value = "America/Argentina/San_Luis")]
        AmericaArgentinaSanLuis,
        [EnumMember(Value = "America/Argentina/Tucuman")]
        AmericaArgentinaTucuman,
        [EnumMember(Value = "America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia,
        [EnumMember(Value = "America/Asuncion")]
        AmericaAsuncion,
        [EnumMember(Value = "America/Atikokan")]
        AmericaAtikokan,
        [EnumMember(Value = "America/Bahia")]
        AmericaBahia,
        [EnumMember(Value = "America/Bahia_Banderas")]
        AmericaBahiaBanderas,
        [EnumMember(Value = "America/Barbados")]
        AmericaBarbados,
        [EnumMember(Value = "America/Belem")]
        AmericaBelem,
        [EnumMember(Value = "America/Belize")]
        AmericaBelize,
        [EnumMember(Value = "America/Blanc-Sablon")]
        AmericaBlancSablon,
        [EnumMember(Value = "America/Boa_Vista")]
        AmericaBoaVista,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Boise")]
        AmericaBoise,
        [EnumMember(Value = "America/Cambridge_Bay")]
        AmericaCambridgeBay,
        [EnumMember(Value = "America/Campo_Grande")]
        AmericaCampoGrande,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "America/Cayenne")]
        AmericaCayenne,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Chihuahua")]
        AmericaChihuahua,
        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica,
        [EnumMember(Value = "America/Creston")]
        AmericaCreston,
        [EnumMember(Value = "America/Cuiaba")]
        AmericaCuiaba,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/Danmarkshavn")]
        AmericaDanmarkshavn,
        [EnumMember(Value = "America/Dawson")]
        AmericaDawson,
        [EnumMember(Value = "America/Dawson_Creek")]
        AmericaDawsonCreek,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Detroit")]
        AmericaDetroit,
        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton,
        [EnumMember(Value = "America/Eirunepe")]
        AmericaEirunepe,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Fort_Nelson")]
        AmericaFortNelson,
        [EnumMember(Value = "America/Fortaleza")]
        AmericaFortaleza,
        [EnumMember(Value = "America/Glace_Bay")]
        AmericaGlaceBay,
        [EnumMember(Value = "America/Goose_Bay")]
        AmericaGooseBay,
        [EnumMember(Value = "America/Grand_Turk")]
        AmericaGrandTurk,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil,
        [EnumMember(Value = "America/Guyana")]
        AmericaGuyana,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "America/Havana")]
        AmericaHavana,
        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "America/Indiana/Knox")]
        AmericaIndianaKnox,
        [EnumMember(Value = "America/Indiana/Marengo")]
        AmericaIndianaMarengo,
        [EnumMember(Value = "America/Indiana/Petersburg")]
        AmericaIndianaPetersburg,
        [EnumMember(Value = "America/Indiana/Tell_City")]
        AmericaIndianaTellCity,
        [EnumMember(Value = "America/Indiana/Vevay")]
        AmericaIndianaVevay,
        [EnumMember(Value = "America/Indiana/Vincennes")]
        AmericaIndianaVincennes,
        [EnumMember(Value = "America/Indiana/Winamac")]
        AmericaIndianaWinamac,
        [EnumMember(Value = "America/Inuvik")]
        AmericaInuvik,
        [EnumMember(Value = "America/Iqaluit")]
        AmericaIqaluit,
        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica,
        [EnumMember(Value = "America/Juneau")]
        AmericaJuneau,
        [EnumMember(Value = "America/Kentucky/Louisville")]
        AmericaKentuckyLouisville,
        [EnumMember(Value = "America/Kentucky/Monticello")]
        AmericaKentuckyMonticello,
        [EnumMember(Value = "America/La_Paz")]
        AmericaLaPaz,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Maceio")]
        AmericaMaceio,
        [EnumMember(Value = "America/Managua")]
        AmericaManagua,
        [EnumMember(Value = "America/Manaus")]
        AmericaManaus,
        [EnumMember(Value = "America/Martinique")]
        AmericaMartinique,
        [EnumMember(Value = "America/Matamoros")]
        AmericaMatamoros,
        [EnumMember(Value = "America/Mazatlan")]
        AmericaMazatlan,
        [EnumMember(Value = "America/Menominee")]
        AmericaMenominee,
        [EnumMember(Value = "America/Merida")]
        AmericaMerida,
        [EnumMember(Value = "America/Metlakatla")]
        AmericaMetlakatla,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Miquelon")]
        AmericaMiquelon,
        [EnumMember(Value = "America/Moncton")]
        AmericaMoncton,
        [EnumMember(Value = "America/Monterrey")]
        AmericaMonterrey,
        [EnumMember(Value = "America/Montevideo")]
        AmericaMontevideo,
        [EnumMember(Value = "America/Nassau")]
        AmericaNassau,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Nipigon")]
        AmericaNipigon,
        [EnumMember(Value = "America/Nome")]
        AmericaNome,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "America/North_Dakota/Beulah")]
        AmericaNorthDakotaBeulah,
        [EnumMember(Value = "America/North_Dakota/Center")]
        AmericaNorthDakotaCenter,
        [EnumMember(Value = "America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "America/Nuuk")]
        AmericaNuuk,
        [EnumMember(Value = "America/Ojinaga")]
        AmericaOjinaga,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Pangnirtung")]
        AmericaPangnirtung,
        [EnumMember(Value = "America/Paramaribo")]
        AmericaParamaribo,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince,
        [EnumMember(Value = "America/Port_of_Spain")]
        AmericaPortOfSpain,
        [EnumMember(Value = "America/Porto_Velho")]
        AmericaPortoVelho,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "America/Punta_Arenas")]
        AmericaPuntaArenas,
        [EnumMember(Value = "America/Rainy_River")]
        AmericaRainyRiver,
        [EnumMember(Value = "America/Rankin_Inlet")]
        AmericaRankinInlet,
        [EnumMember(Value = "America/Recife")]
        AmericaRecife,
        [EnumMember(Value = "America/Regina")]
        AmericaRegina,
        [EnumMember(Value = "America/Resolute")]
        AmericaResolute,
        [EnumMember(Value = "America/Rio_Branco")]
        AmericaRioBranco,
        [EnumMember(Value = "America/Santarem")]
        AmericaSantarem,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Santo_Domingo")]
        AmericaSantoDomingo,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "America/Scoresbysund")]
        AmericaScoresbysund,
        [EnumMember(Value = "America/Sitka")]
        AmericaSitka,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Swift_Current")]
        AmericaSwiftCurrent,
        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa,
        [EnumMember(Value = "America/Thule")]
        AmericaThule,
        [EnumMember(Value = "America/Thunder_Bay")]
        AmericaThunderBay,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Whitehorse")]
        AmericaWhitehorse,
        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg,
        [EnumMember(Value = "America/Yakutat")]
        AmericaYakutat,
        [EnumMember(Value = "America/Yellowknife")]
        AmericaYellowknife,
        [EnumMember(Value = "Antarctica/Casey")]
        AntarcticaCasey,
        [EnumMember(Value = "Antarctica/Davis")]
        AntarcticaDavis,
        [EnumMember(Value = "Antarctica/DumontDUrville")]
        AntarcticaDumontDUrville,
        [EnumMember(Value = "Antarctica/Macquarie")]
        AntarcticaMacquarie,
        [EnumMember(Value = "Antarctica/Mawson")]
        AntarcticaMawson,
        [EnumMember(Value = "Antarctica/Palmer")]
        AntarcticaPalmer,
        [EnumMember(Value = "Antarctica/Rothera")]
        AntarcticaRothera,
        [EnumMember(Value = "Antarctica/Syowa")]
        AntarcticaSyowa,
        [EnumMember(Value = "Antarctica/Troll")]
        AntarcticaTroll,
        [EnumMember(Value = "Antarctica/Vostok")]
        AntarcticaVostok,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Asia/Anadyr")]
        AsiaAnadyr,
        [EnumMember(Value = "Asia/Aqtau")]
        AsiaAqtau,
        [EnumMember(Value = "Asia/Aqtobe")]
        AsiaAqtobe,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Atyrau")]
        AsiaAtyrau,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "Asia/Baku")]
        AsiaBaku,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Asia/Barnaul")]
        AsiaBarnaul,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "Asia/Bishkek")]
        AsiaBishkek,
        [EnumMember(Value = "Asia/Brunei")]
        AsiaBrunei,
        [EnumMember(Value = "Asia/Chita")]
        AsiaChita,
        [EnumMember(Value = "Asia/Choibalsan")]
        AsiaChoibalsan,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Dili")]
        AsiaDili,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Dushanbe")]
        AsiaDushanbe,
        [EnumMember(Value = "Asia/Famagusta")]
        AsiaFamagusta,
        [EnumMember(Value = "Asia/Gaza")]
        AsiaGaza,
        [EnumMember(Value = "Asia/Hebron")]
        AsiaHebron,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Hovd")]
        AsiaHovd,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Jayapura")]
        AsiaJayapura,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Khandyga")]
        AsiaKhandyga,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Kuching")]
        AsiaKuching,
        [EnumMember(Value = "Asia/Macau")]
        AsiaMacau,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "Asia/Makassar")]
        AsiaMakassar,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Asia/Nicosia")]
        AsiaNicosia,
        [EnumMember(Value = "Asia/Novokuznetsk")]
        AsiaNovokuznetsk,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Asia/Omsk")]
        AsiaOmsk,
        [EnumMember(Value = "Asia/Oral")]
        AsiaOral,
        [EnumMember(Value = "Asia/Pontianak")]
        AsiaPontianak,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Qatar")]
        AsiaQatar,
        [EnumMember(Value = "Asia/Qostanay")]
        AsiaQostanay,
        [EnumMember(Value = "Asia/Qyzylorda")]
        AsiaQyzylorda,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Sakhalin")]
        AsiaSakhalin,
        [EnumMember(Value = "Asia/Samarkand")]
        AsiaSamarkand,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Srednekolymsk")]
        AsiaSrednekolymsk,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Thimphu")]
        AsiaThimphu,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Tomsk")]
        AsiaTomsk,
        [EnumMember(Value = "Asia/Ulaanbaatar")]
        AsiaUlaanbaatar,
        [EnumMember(Value = "Asia/Urumqi")]
        AsiaUrumqi,
        [EnumMember(Value = "Asia/Ust-Nera")]
        AsiaUstNera,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Yakutsk")]
        AsiaYakutsk,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Asia/Yerevan")]
        AsiaYerevan,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "Atlantic/Canary")]
        AtlanticCanary,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Atlantic/Faroe")]
        AtlanticFaroe,
        [EnumMember(Value = "Atlantic/Madeira")]
        AtlanticMadeira,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "Atlantic/Stanley")]
        AtlanticStanley,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Broken_Hill")]
        AustraliaBrokenHill,
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Eucla")]
        AustraliaEucla,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Australia/Lindeman")]
        AustraliaLindeman,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        CET,
        CST6CDT,
        EET,
        EST,
        EST5EDT,
        [EnumMember(Value = "Etc/GMT")]
        EtcGMT,
        [EnumMember(Value = "Etc/GMT+1")]
        EtcGMT1,
        [EnumMember(Value = "Etc/GMT+10")]
        EtcGMT10,
        [EnumMember(Value = "Etc/GMT+11")]
        EtcGMT11,
        [EnumMember(Value = "Etc/GMT+12")]
        EtcGMT12,
        [EnumMember(Value = "Etc/GMT+2")]
        EtcGMT2,
        [EnumMember(Value = "Etc/GMT+3")]
        EtcGMT3,
        [EnumMember(Value = "Etc/GMT+4")]
        EtcGMT4,
        [EnumMember(Value = "Etc/GMT+5")]
        EtcGMT5,
        [EnumMember(Value = "Etc/GMT+6")]
        EtcGMT6,
        [EnumMember(Value = "Etc/GMT+7")]
        EtcGMT7,
        [EnumMember(Value = "Etc/GMT+8")]
        EtcGMT8,
        [EnumMember(Value = "Etc/GMT+9")]
        EtcGMT9,
        [EnumMember(Value = "Etc/GMT-1")]
        EtcGMT15,
        [EnumMember(Value = "Etc/GMT-10")]
        EtcGMT102,
        [EnumMember(Value = "Etc/GMT-11")]
        EtcGMT112,
        [EnumMember(Value = "Etc/GMT-12")]
        EtcGMT122,
        [EnumMember(Value = "Etc/GMT-13")]
        EtcGMT13,
        [EnumMember(Value = "Etc/GMT-14")]
        EtcGMT14,
        [EnumMember(Value = "Etc/GMT-2")]
        EtcGMT22,
        [EnumMember(Value = "Etc/GMT-3")]
        EtcGMT32,
        [EnumMember(Value = "Etc/GMT-4")]
        EtcGMT42,
        [EnumMember(Value = "Etc/GMT-5")]
        EtcGMT52,
        [EnumMember(Value = "Etc/GMT-6")]
        EtcGMT62,
        [EnumMember(Value = "Etc/GMT-7")]
        EtcGMT72,
        [EnumMember(Value = "Etc/GMT-8")]
        EtcGMT82,
        [EnumMember(Value = "Etc/GMT-9")]
        EtcGMT92,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Andorra")]
        EuropeAndorra,
        [EnumMember(Value = "Europe/Astrakhan")]
        EuropeAstrakhan,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Europe/Belgrade")]
        EuropeBelgrade,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Chisinau")]
        EuropeChisinau,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Gibraltar")]
        EuropeGibraltar,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "Europe/Kaliningrad")]
        EuropeKaliningrad,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Kirov")]
        EuropeKirov,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Luxembourg")]
        EuropeLuxembourg,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Europe/Malta")]
        EuropeMalta,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Europe/Monaco")]
        EuropeMonaco,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Riga")]
        EuropeRiga,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Samara")]
        EuropeSamara,
        [EnumMember(Value = "Europe/Saratov")]
        EuropeSaratov,
        [EnumMember(Value = "Europe/Simferopol")]
        EuropeSimferopol,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Europe/Tallinn")]
        EuropeTallinn,
        [EnumMember(Value = "Europe/Tirane")]
        EuropeTirane,
        [EnumMember(Value = "Europe/Ulyanovsk")]
        EuropeUlyanovsk,
        [EnumMember(Value = "Europe/Uzhgorod")]
        EuropeUzhgorod,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Vilnius")]
        EuropeVilnius,
        [EnumMember(Value = "Europe/Volgograd")]
        EuropeVolgograd,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Zaporozhye")]
        EuropeZaporozhye,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        HST,
        [EnumMember(Value = "Indian/Chagos")]
        IndianChagos,
        [EnumMember(Value = "Indian/Christmas")]
        IndianChristmas,
        [EnumMember(Value = "Indian/Cocos")]
        IndianCocos,
        [EnumMember(Value = "Indian/Kerguelen")]
        IndianKerguelen,
        [EnumMember(Value = "Indian/Mahe")]
        IndianMahe,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius,
        [EnumMember(Value = "Indian/Reunion")]
        IndianReunion,
        MET,
        MST,
        MST7MDT,
        PST8PDT,
        [EnumMember(Value = "Pacific/Apia")]
        PacificApia,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Bougainville")]
        PacificBougainville,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Pacific/Chuuk")]
        PacificChuuk,
        [EnumMember(Value = "Pacific/Easter")]
        PacificEaster,
        [EnumMember(Value = "Pacific/Efate")]
        PacificEfate,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fakaofo")]
        PacificFakaofo,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Pacific/Funafuti")]
        PacificFunafuti,
        [EnumMember(Value = "Pacific/Galapagos")]
        PacificGalapagos,
        [EnumMember(Value = "Pacific/Gambier")]
        PacificGambier,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Pacific/Kosrae")]
        PacificKosrae,
        [EnumMember(Value = "Pacific/Kwajalein")]
        PacificKwajalein,
        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Pacific/Nauru")]
        PacificNauru,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago,
        [EnumMember(Value = "Pacific/Palau")]
        PacificPalau,
        [EnumMember(Value = "Pacific/Pitcairn")]
        PacificPitcairn,
        [EnumMember(Value = "Pacific/Pohnpei")]
        PacificPohnpei,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Pacific/Rarotonga")]
        PacificRarotonga,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Pacific/Tarawa")]
        PacificTarawa,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Pacific/Wake")]
        PacificWake,
        [EnumMember(Value = "Pacific/Wallis")]
        PacificWallis,
        WET
    }

    public enum bodymodeRecurrenceInput
    {
        Workweek,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Calendarpro;

    public partial class WorkflowManagedActions
    {
        public CalendarproActions Calendarpro(string connectionId) => new CalendarproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CalendarproTriggers Calendarpro(string connectionId) => new CalendarproTriggers(connectionId);
    }
}