//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tago
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TagoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tago")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetData(Expression<Func<string>> device, Expression<Func<string>> variable, Expression<Func<QueryInput>> query = null, Expression<Func<int>> qty = null, Expression<Func<TimezoneInput>> timezone = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> serie = null)
        {
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: true);
            var __workflow_variable = WorkflowExpression.Compile(variable, nameof(variable), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_qty = WorkflowExpression.Compile(qty, nameof(qty), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_serie = WorkflowExpression.Compile(serie, nameof(serie), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/prod/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["device"] = ExpressionConverter.Convert(__workflow_device);
                callPayload.Queries["variable"] = ExpressionConverter.Convert(__workflow_variable);
                callPayload.Queries["query"] = Convert.ToString("last_item");
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_qty != null)
                    callPayload.Queries["qty"] = ExpressionConverter.Convert(__workflow_qty);
                callPayload.Queries["timezone"] = Convert.ToString("(GMT+00:00) UTC");
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_serie != null)
                    callPayload.Queries["serie"] = ExpressionConverter.Convert(__workflow_serie);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tago")]
        public IBodyWorkflowAction<PostDataResponse, ApiConnectionActionConfiguration> PostData(Expression<Func<PostDataBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/prod/data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostDataResponse>(callPayload);
            });
        }
    }

    public class TagoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PostDataResponse, ApiConnectionPollingTriggerConfiguration> DataTrigger(Expression<Func<string>> device, Expression<Func<string>> variable, Expression<Func<ConditionInput>> condition, Expression<Func<string>> value = null)
        {
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: true);
            var __workflow_variable = WorkflowExpression.Compile(variable, nameof(variable), required: true);
            var __workflow_condition = WorkflowExpression.Compile(condition, nameof(condition), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: false);
            return new DeferredBodyTrigger<PostDataResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/prod/flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["device"] = ExpressionConverter.Convert(__workflow_device);
                callPayload.Queries["variable"] = ExpressionConverter.Convert(__workflow_variable);
                callPayload.Queries["condition"] = ExpressionConverter.Convert(__workflow_condition);
                if (__workflow_value != null)
                    callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = new DataTriggerBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<PostDataResponse>(callPayload);
            });
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "last_item")]
        LastItem,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimezoneInput
    {
        [EnumMember(Value = "(GMT+00:00) UTC")]
        Gmt0000Utc,
        [EnumMember(Value = "(GMT-11:00) Pacific/Pago_Pago")]
        Gmt1100PacificPagoPago,
        [EnumMember(Value = "(GMT-11:00) Pacific/Niue")]
        Gmt1100PacificNiue,
        [EnumMember(Value = "(GMT-11:00) Pacific/Midway")]
        Gmt1100PacificMidway,
        [EnumMember(Value = "(GMT-10:00) Pacific/Rarotonga")]
        Gmt1000PacificRarotonga,
        [EnumMember(Value = "(GMT-10:00) Pacific/Tahiti")]
        Gmt1000PacificTahiti,
        [EnumMember(Value = "(GMT-10:00) Pacific/Honolulu")]
        Gmt1000PacificHonolulu,
        [EnumMember(Value = "(GMT-10:00) Pacific/Johnston")]
        Gmt1000PacificJohnston,
        [EnumMember(Value = "(GMT-09:30) Pacific/Marquesas")]
        Gmt0930PacificMarquesas,
        [EnumMember(Value = "(GMT-09:00) Pacific/Gambier")]
        Gmt0900PacificGambier,
        [EnumMember(Value = "(GMT-09:00) America/Adak")]
        Gmt0900AmericaAdak,
        [EnumMember(Value = "(GMT-08:00) America/Santa_Isabel")]
        Gmt0800AmericaSantaIsabel,
        [EnumMember(Value = "(GMT-08:00) Pacific/Pitcairn")]
        Gmt0800PacificPitcairn,
        [EnumMember(Value = "(GMT-08:00) America/Anchorage")]
        Gmt0800AmericaAnchorage,
        [EnumMember(Value = "(GMT-08:00) America/Juneau")]
        Gmt0800AmericaJuneau,
        [EnumMember(Value = "(GMT-08:00) America/Metlakatla")]
        Gmt0800AmericaMetlakatla,
        [EnumMember(Value = "(GMT-08:00) America/Nome")]
        Gmt0800AmericaNome,
        [EnumMember(Value = "(GMT-08:00) America/Sitka")]
        Gmt0800AmericaSitka,
        [EnumMember(Value = "(GMT-08:00) America/Yakutat")]
        Gmt0800AmericaYakutat,
        [EnumMember(Value = "(GMT-07:00) America/Creston")]
        Gmt0700AmericaCreston,
        [EnumMember(Value = "(GMT-07:00) America/Dawson")]
        Gmt0700AmericaDawson,
        [EnumMember(Value = "(GMT-07:00) America/Dawson_Creek")]
        Gmt0700AmericaDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) America/Vancouver")]
        Gmt0700AmericaVancouver,
        [EnumMember(Value = "(GMT-07:00) America/Whitehorse")]
        Gmt0700AmericaWhitehorse,
        [EnumMember(Value = "(GMT-07:00) America/Chihuahua")]
        Gmt0700AmericaChihuahua,
        [EnumMember(Value = "(GMT-07:00) America/Hermosillo")]
        Gmt0700AmericaHermosillo,
        [EnumMember(Value = "(GMT-07:00) America/Mazatlan")]
        Gmt0700AmericaMazatlan,
        [EnumMember(Value = "(GMT-07:00) America/Tijuana")]
        Gmt0700AmericaTijuana,
        [EnumMember(Value = "(GMT-07:00) America/Los_Angeles")]
        Gmt0700AmericaLosAngeles,
        [EnumMember(Value = "(GMT-07:00) America/Phoenix")]
        Gmt0700AmericaPhoenix,
        [EnumMember(Value = "(GMT-06:00) America/Belize")]
        Gmt0600AmericaBelize,
        [EnumMember(Value = "(GMT-06:00) America/Cambridge_Bay")]
        Gmt0600AmericaCambridgeBay,
        [EnumMember(Value = "(GMT-06:00) America/Edmonton")]
        Gmt0600AmericaEdmonton,
        [EnumMember(Value = "(GMT-06:00) America/Inuvik")]
        Gmt0600AmericaInuvik,
        [EnumMember(Value = "(GMT-06:00) America/Regina")]
        Gmt0600AmericaRegina,
        [EnumMember(Value = "(GMT-06:00) America/Swift_Current")]
        Gmt0600AmericaSwiftCurrent,
        [EnumMember(Value = "(GMT-06:00) America/Yellowknife")]
        Gmt0600AmericaYellowknife,
        [EnumMember(Value = "(GMT-06:00) America/Costa_Rica")]
        Gmt0600AmericaCostaRica,
        [EnumMember(Value = "(GMT-06:00) Pacific/Galapagos")]
        Gmt0600PacificGalapagos,
        [EnumMember(Value = "(GMT-06:00) America/El_Salvador")]
        Gmt0600AmericaElSalvador,
        [EnumMember(Value = "(GMT-06:00) America/Guatemala")]
        Gmt0600AmericaGuatemala,
        [EnumMember(Value = "(GMT-06:00) America/Tegucigalpa")]
        Gmt0600AmericaTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) America/Bahia_Banderas")]
        Gmt0600AmericaBahiaBanderas,
        [EnumMember(Value = "(GMT-06:00) America/Cancun")]
        Gmt0600AmericaCancun,
        [EnumMember(Value = "(GMT-06:00) America/Merida")]
        Gmt0600AmericaMerida,
        [EnumMember(Value = "(GMT-06:00) America/Mexico_City")]
        Gmt0600AmericaMexicoCity,
        [EnumMember(Value = "(GMT-06:00) America/Monterrey")]
        Gmt0600AmericaMonterrey,
        [EnumMember(Value = "(GMT-06:00) America/Ojinaga")]
        Gmt0600AmericaOjinaga,
        [EnumMember(Value = "(GMT-06:00) America/Managua")]
        Gmt0600AmericaManagua,
        [EnumMember(Value = "(GMT-06:00) America/Boise")]
        Gmt0600AmericaBoise,
        [EnumMember(Value = "(GMT-06:00) America/Denver")]
        Gmt0600AmericaDenver,
        [EnumMember(Value = "(GMT-05:00) America/Eirunepe")]
        Gmt0500AmericaEirunepe,
        [EnumMember(Value = "(GMT-05:00) America/Rio_Branco")]
        Gmt0500AmericaRioBranco,
        [EnumMember(Value = "(GMT-05:00) America/Atikokan")]
        Gmt0500AmericaAtikokan,
        [EnumMember(Value = "(GMT-05:00) America/Rainy_River")]
        Gmt0500AmericaRainyRiver,
        [EnumMember(Value = "(GMT-05:00) America/Rankin_Inlet")]
        Gmt0500AmericaRankinInlet,
        [EnumMember(Value = "(GMT-05:00) America/Resolute")]
        Gmt0500AmericaResolute,
        [EnumMember(Value = "(GMT-05:00) America/Winnipeg")]
        Gmt0500AmericaWinnipeg,
        [EnumMember(Value = "(GMT-05:00) America/Cayman")]
        Gmt0500AmericaCayman,
        [EnumMember(Value = "(GMT-05:00) Pacific/Easter")]
        Gmt0500PacificEaster,
        [EnumMember(Value = "(GMT-05:00) America/Bogota")]
        Gmt0500AmericaBogota,
        [EnumMember(Value = "(GMT-05:00) America/Guayaquil")]
        Gmt0500AmericaGuayaquil,
        [EnumMember(Value = "(GMT-05:00) America/Jamaica")]
        Gmt0500AmericaJamaica,
        [EnumMember(Value = "(GMT-05:00) America/Matamoros")]
        Gmt0500AmericaMatamoros,
        [EnumMember(Value = "(GMT-05:00) America/Panama")]
        Gmt0500AmericaPanama,
        [EnumMember(Value = "(GMT-05:00) America/Lima")]
        Gmt0500AmericaLima,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Beulah")]
        Gmt0500AmericaNorthDakotaBeulah,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Center")]
        Gmt0500AmericaNorthDakotaCenter,
        [EnumMember(Value = "(GMT-05:00) America/Chicago")]
        Gmt0500AmericaChicago,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Knox")]
        Gmt0500AmericaIndianaKnox,
        [EnumMember(Value = "(GMT-05:00) America/Menominee")]
        Gmt0500AmericaMenominee,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/New_Salem")]
        Gmt0500AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Tell_City")]
        Gmt0500AmericaIndianaTellCity,
        [EnumMember(Value = "(GMT-04:30) America/Caracas")]
        Gmt0430AmericaCaracas,
        [EnumMember(Value = "(GMT-04:00) America/Anguilla")]
        Gmt0400AmericaAnguilla,
        [EnumMember(Value = "(GMT-04:00) America/Antigua")]
        Gmt0400AmericaAntigua,
        [EnumMember(Value = "(GMT-04:00) America/Aruba")]
        Gmt0400AmericaAruba,
        [EnumMember(Value = "(GMT-04:00) America/Nassau")]
        Gmt0400AmericaNassau,
        [EnumMember(Value = "(GMT-04:00) America/Barbados")]
        Gmt0400AmericaBarbados,
        [EnumMember(Value = "(GMT-04:00) America/La_Paz")]
        Gmt0400AmericaLaPaz,
        [EnumMember(Value = "(GMT-04:00) America/Kralendijk")]
        Gmt0400AmericaKralendijk,
        [EnumMember(Value = "(GMT-04:00) America/Boa_Vista")]
        Gmt0400AmericaBoaVista,
        [EnumMember(Value = "(GMT-04:00) America/Campo_Grande")]
        Gmt0400AmericaCampoGrande,
        [EnumMember(Value = "(GMT-04:00) America/Cuiaba")]
        Gmt0400AmericaCuiaba,
        [EnumMember(Value = "(GMT-04:00) America/Manaus")]
        Gmt0400AmericaManaus,
        [EnumMember(Value = "(GMT-04:00) America/Porto_Velho")]
        Gmt0400AmericaPortoVelho,
        [EnumMember(Value = "(GMT-04:00) America/Blanc-Sablon")]
        Gmt0400AmericaBlancSablon,
        [EnumMember(Value = "(GMT-04:00) America/Iqaluit")]
        Gmt0400AmericaIqaluit,
        [EnumMember(Value = "(GMT-04:00) America/Nipigon")]
        Gmt0400AmericaNipigon,
        [EnumMember(Value = "(GMT-04:00) America/Pangnirtung")]
        Gmt0400AmericaPangnirtung,
        [EnumMember(Value = "(GMT-04:00) America/Thunder_Bay")]
        Gmt0400AmericaThunderBay,
        [EnumMember(Value = "(GMT-04:00) America/Toronto")]
        Gmt0400AmericaToronto,
        [EnumMember(Value = "(GMT-04:00) America/Havana")]
        Gmt0400AmericaHavana,
        [EnumMember(Value = "(GMT-04:00) America/Curacao")]
        Gmt0400AmericaCuracao,
        [EnumMember(Value = "(GMT-04:00) America/Dominica")]
        Gmt0400AmericaDominica,
        [EnumMember(Value = "(GMT-04:00) America/Santo_Domingo")]
        Gmt0400AmericaSantoDomingo,
        [EnumMember(Value = "(GMT-04:00) America/Grenada")]
        Gmt0400AmericaGrenada,
        [EnumMember(Value = "(GMT-04:00) America/Guadeloupe")]
        Gmt0400AmericaGuadeloupe,
        [EnumMember(Value = "(GMT-04:00) America/Guyana")]
        Gmt0400AmericaGuyana,
        [EnumMember(Value = "(GMT-04:00) America/Port-au-Prince")]
        Gmt0400AmericaPortAuPrince,
        [EnumMember(Value = "(GMT-04:00) America/Martinique")]
        Gmt0400AmericaMartinique,
        [EnumMember(Value = "(GMT-04:00) America/Montserrat")]
        Gmt0400AmericaMontserrat,
        [EnumMember(Value = "(GMT-04:00) America/Asuncion")]
        Gmt0400AmericaAsuncion,
        [EnumMember(Value = "(GMT-04:00) America/Puerto_Rico")]
        Gmt0400AmericaPuertoRico,
        [EnumMember(Value = "(GMT-04:00) America/St_Barthelemy")]
        Gmt0400AmericaStBarthelemy,
        [EnumMember(Value = "(GMT-04:00) America/St_Kitts")]
        Gmt0400AmericaStKitts,
        [EnumMember(Value = "(GMT-04:00) America/St_Lucia")]
        Gmt0400AmericaStLucia,
        [EnumMember(Value = "(GMT-04:00) America/Marigot")]
        Gmt0400AmericaMarigot,
        [EnumMember(Value = "(GMT-04:00) America/St_Vincent")]
        Gmt0400AmericaStVincent,
        [EnumMember(Value = "(GMT-04:00) America/Lower_Princes")]
        Gmt0400AmericaLowerPrinces,
        [EnumMember(Value = "(GMT-04:00) America/Port_of_Spain")]
        Gmt0400AmericaPortOfSpain,
        [EnumMember(Value = "(GMT-04:00) America/Grand_Turk")]
        Gmt0400AmericaGrandTurk,
        [EnumMember(Value = "(GMT-04:00) America/Detroit")]
        Gmt0400AmericaDetroit,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Indianapolis")]
        Gmt0400AmericaIndianaIndianapolis,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Louisville")]
        Gmt0400AmericaKentuckyLouisville,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Marengo")]
        Gmt0400AmericaIndianaMarengo,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Monticello")]
        Gmt0400AmericaKentuckyMonticello,
        [EnumMember(Value = "(GMT-04:00) America/New_York")]
        Gmt0400AmericaNewYork,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Petersburg")]
        Gmt0400AmericaIndianaPetersburg,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vevay")]
        Gmt0400AmericaIndianaVevay,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vincennes")]
        Gmt0400AmericaIndianaVincennes,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Winamac")]
        Gmt0400AmericaIndianaWinamac,
        [EnumMember(Value = "(GMT-04:00) America/Tortola")]
        Gmt0400AmericaTortola,
        [EnumMember(Value = "(GMT-04:00) America/St_Thomas")]
        Gmt0400AmericaStThomas,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Palmer")]
        Gmt0300AntarcticaPalmer,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Rothera")]
        Gmt0300AntarcticaRothera,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Buenos_Aires")]
        Gmt0300AmericaArgentinaBuenosAires,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Catamarca")]
        Gmt0300AmericaArgentinaCatamarca,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Cordoba")]
        Gmt0300AmericaArgentinaCordoba,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Jujuy")]
        Gmt0300AmericaArgentinaJujuy,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/La_Rioja")]
        Gmt0300AmericaArgentinaLaRioja,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Mendoza")]
        Gmt0300AmericaArgentinaMendoza,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Rio_Gallegos")]
        Gmt0300AmericaArgentinaRioGallegos,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Salta")]
        Gmt0300AmericaArgentinaSalta,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Juan")]
        Gmt0300AmericaArgentinaSanJuan,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Luis")]
        Gmt0300AmericaArgentinaSanLuis,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Tucuman")]
        Gmt0300AmericaArgentinaTucuman,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Ushuaia")]
        Gmt0300AmericaArgentinaUshuaia,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Bermuda")]
        Gmt0300AtlanticBermuda,
        [EnumMember(Value = "(GMT-03:00) America/Araguaina")]
        Gmt0300AmericaAraguaina,
        [EnumMember(Value = "(GMT-03:00) America/Bahia")]
        Gmt0300AmericaBahia,
        [EnumMember(Value = "(GMT-03:00) America/Belem")]
        Gmt0300AmericaBelem,
        [EnumMember(Value = "(GMT-03:00) America/Fortaleza")]
        Gmt0300AmericaFortaleza,
        [EnumMember(Value = "(GMT-03:00) America/Maceio")]
        Gmt0300AmericaMaceio,
        [EnumMember(Value = "(GMT-03:00) America/Recife")]
        Gmt0300AmericaRecife,
        [EnumMember(Value = "(GMT-03:00) America/Santarem")]
        Gmt0300AmericaSantarem,
        [EnumMember(Value = "(GMT-03:00) America/Sao_Paulo")]
        Gmt0300AmericaSaoPaulo,
        [EnumMember(Value = "(GMT-03:00) America/Glace_Bay")]
        Gmt0300AmericaGlaceBay,
        [EnumMember(Value = "(GMT-03:00) America/Goose_Bay")]
        Gmt0300AmericaGooseBay,
        [EnumMember(Value = "(GMT-03:00) America/Halifax")]
        Gmt0300AmericaHalifax,
        [EnumMember(Value = "(GMT-03:00) America/Moncton")]
        Gmt0300AmericaMoncton,
        [EnumMember(Value = "(GMT-03:00) America/Santiago")]
        Gmt0300AmericaSantiago,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Stanley")]
        Gmt0300AtlanticStanley,
        [EnumMember(Value = "(GMT-03:00) America/Cayenne")]
        Gmt0300AmericaCayenne,
        [EnumMember(Value = "(GMT-03:00) America/Godthab")]
        Gmt0300AmericaGodthab,
        [EnumMember(Value = "(GMT-03:00) America/Thule")]
        Gmt0300AmericaThule,
        [EnumMember(Value = "(GMT-03:00) America/Paramaribo")]
        Gmt0300AmericaParamaribo,
        [EnumMember(Value = "(GMT-03:00) America/Montevideo")]
        Gmt0300AmericaMontevideo,
        [EnumMember(Value = "(GMT-02:30) America/St_Johns")]
        Gmt0230AmericaStJohns,
        [EnumMember(Value = "(GMT-02:00) America/Noronha")]
        Gmt0200AmericaNoronha,
        [EnumMember(Value = "(GMT-02:00) America/Miquelon")]
        Gmt0200AmericaMiquelon,
        [EnumMember(Value = "(GMT-02:00) Atlantic/South_Georgia")]
        Gmt0200AtlanticSouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Cape_Verde")]
        Gmt0100AtlanticCapeVerde,
        [EnumMember(Value = "(GMT-01:00) America/Scoresbysund")]
        Gmt0100AmericaScoresbysund,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Azores")]
        Gmt0100AtlanticAzores,
        [EnumMember(Value = "(GMT+00:00) Antarctica/Troll")]
        Gmt0000AntarcticaTroll,
        [EnumMember(Value = "(GMT+00:00) Africa/Ouagadougou")]
        Gmt0000AfricaOuagadougou,
        [EnumMember(Value = "(GMT+00:00) Africa/Abidjan")]
        Gmt0000AfricaAbidjan,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Faroe")]
        Gmt0000AtlanticFaroe,
        [EnumMember(Value = "(GMT+00:00) Africa/Banjul")]
        Gmt0000AfricaBanjul,
        [EnumMember(Value = "(GMT+00:00) Africa/Accra")]
        Gmt0000AfricaAccra,
        [EnumMember(Value = "(GMT+00:00) America/Danmarkshavn")]
        Gmt0000AmericaDanmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Europe/Guernsey")]
        Gmt0000EuropeGuernsey,
        [EnumMember(Value = "(GMT+00:00) Africa/Conakry")]
        Gmt0000AfricaConakry,
        [EnumMember(Value = "(GMT+00:00) Africa/Bissau")]
        Gmt0000AfricaBissau,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Reykjavik")]
        Gmt0000AtlanticReykjavik,
        [EnumMember(Value = "(GMT+00:00) Europe/Dublin")]
        Gmt0000EuropeDublin,
        [EnumMember(Value = "(GMT+00:00) Europe/Isle_of_Man")]
        Gmt0000EuropeIsleOfMan,
        [EnumMember(Value = "(GMT+00:00) Europe/Jersey")]
        Gmt0000EuropeJersey,
        [EnumMember(Value = "(GMT+00:00) Africa/Monrovia")]
        Gmt0000AfricaMonrovia,
        [EnumMember(Value = "(GMT+00:00) Africa/Bamako")]
        Gmt0000AfricaBamako,
        [EnumMember(Value = "(GMT+00:00) Africa/Nouakchott")]
        Gmt0000AfricaNouakchott,
        [EnumMember(Value = "(GMT+00:00) Africa/Casablanca")]
        Gmt0000AfricaCasablanca,
        [EnumMember(Value = "(GMT+00:00) Europe/Lisbon")]
        Gmt0000EuropeLisbon,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Madeira")]
        Gmt0000AtlanticMadeira,
        [EnumMember(Value = "(GMT+00:00) Atlantic/St_Helena")]
        Gmt0000AtlanticStHelena,
        [EnumMember(Value = "(GMT+00:00) Africa/Sao_Tome")]
        Gmt0000AfricaSaoTome,
        [EnumMember(Value = "(GMT+00:00) Africa/Dakar")]
        Gmt0000AfricaDakar,
        [EnumMember(Value = "(GMT+00:00) Africa/Freetown")]
        Gmt0000AfricaFreetown,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Canary")]
        Gmt0000AtlanticCanary,
        [EnumMember(Value = "(GMT+00:00) Africa/Lome")]
        Gmt0000AfricaLome,
        [EnumMember(Value = "(GMT+00:00) Europe/London")]
        Gmt0000EuropeLondon,
        [EnumMember(Value = "(GMT+00:00) Africa/El_Aaiun")]
        Gmt0000AfricaElAaiun,
        [EnumMember(Value = "(GMT+01:00) Europe/Tirane")]
        Gmt0100EuropeTirane,
        [EnumMember(Value = "(GMT+01:00) Africa/Algiers")]
        Gmt0100AfricaAlgiers,
        [EnumMember(Value = "(GMT+01:00) Europe/Andorra")]
        Gmt0100EuropeAndorra,
        [EnumMember(Value = "(GMT+01:00) Africa/Luanda")]
        Gmt0100AfricaLuanda,
        [EnumMember(Value = "(GMT+01:00) Europe/Vienna")]
        Gmt0100EuropeVienna,
        [EnumMember(Value = "(GMT+01:00) Europe/Brussels")]
        Gmt0100EuropeBrussels,
        [EnumMember(Value = "(GMT+01:00) Africa/Porto-Novo")]
        Gmt0100AfricaPortoNovo,
        [EnumMember(Value = "(GMT+01:00) Europe/Sarajevo")]
        Gmt0100EuropeSarajevo,
        [EnumMember(Value = "(GMT+01:00) Africa/Douala")]
        Gmt0100AfricaDouala,
        [EnumMember(Value = "(GMT+01:00) Africa/Bangui")]
        Gmt0100AfricaBangui,
        [EnumMember(Value = "(GMT+01:00) Africa/Ndjamena")]
        Gmt0100AfricaNdjamena,
        [EnumMember(Value = "(GMT+01:00) Africa/Brazzaville")]
        Gmt0100AfricaBrazzaville,
        [EnumMember(Value = "(GMT+01:00) Africa/Kinshasa")]
        Gmt0100AfricaKinshasa,
        [EnumMember(Value = "(GMT+01:00) Europe/Zagreb")]
        Gmt0100EuropeZagreb,
        [EnumMember(Value = "(GMT+01:00) Europe/Prague")]
        Gmt0100EuropePrague,
        [EnumMember(Value = "(GMT+01:00) Europe/Copenhagen")]
        Gmt0100EuropeCopenhagen,
        [EnumMember(Value = "(GMT+01:00) Africa/Malabo")]
        Gmt0100AfricaMalabo,
        [EnumMember(Value = "(GMT+01:00) Europe/Paris")]
        Gmt0100EuropeParis,
        [EnumMember(Value = "(GMT+01:00) Africa/Libreville")]
        Gmt0100AfricaLibreville,
        [EnumMember(Value = "(GMT+01:00) Europe/Berlin")]
        Gmt0100EuropeBerlin,
        [EnumMember(Value = "(GMT+01:00) Europe/Busingen")]
        Gmt0100EuropeBusingen,
        [EnumMember(Value = "(GMT+01:00) Europe/Gibraltar")]
        Gmt0100EuropeGibraltar,
        [EnumMember(Value = "(GMT+01:00) Europe/Vatican")]
        Gmt0100EuropeVatican,
        [EnumMember(Value = "(GMT+01:00) Europe/Budapest")]
        Gmt0100EuropeBudapest,
        [EnumMember(Value = "(GMT+01:00) Europe/Rome")]
        Gmt0100EuropeRome,
        [EnumMember(Value = "(GMT+01:00) Europe/Vaduz")]
        Gmt0100EuropeVaduz,
        [EnumMember(Value = "(GMT+01:00) Europe/Luxembourg")]
        Gmt0100EuropeLuxembourg,
        [EnumMember(Value = "(GMT+01:00) Europe/Skopje")]
        Gmt0100EuropeSkopje,
        [EnumMember(Value = "(GMT+01:00) Europe/Malta")]
        Gmt0100EuropeMalta,
        [EnumMember(Value = "(GMT+01:00) Europe/Monaco")]
        Gmt0100EuropeMonaco,
        [EnumMember(Value = "(GMT+01:00) Europe/Podgorica")]
        Gmt0100EuropePodgorica,
        [EnumMember(Value = "(GMT+01:00) Europe/Amsterdam")]
        Gmt0100EuropeAmsterdam,
        [EnumMember(Value = "(GMT+01:00) Africa/Niamey")]
        Gmt0100AfricaNiamey,
        [EnumMember(Value = "(GMT+01:00) Africa/Lagos")]
        Gmt0100AfricaLagos,
        [EnumMember(Value = "(GMT+01:00) Europe/Oslo")]
        Gmt0100EuropeOslo,
        [EnumMember(Value = "(GMT+01:00) Europe/Warsaw")]
        Gmt0100EuropeWarsaw,
        [EnumMember(Value = "(GMT+01:00) Europe/San_Marino")]
        Gmt0100EuropeSanMarino,
        [EnumMember(Value = "(GMT+01:00) Europe/Belgrade")]
        Gmt0100EuropeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Europe/Bratislava")]
        Gmt0100EuropeBratislava,
        [EnumMember(Value = "(GMT+01:00) Europe/Ljubljana")]
        Gmt0100EuropeLjubljana,
        [EnumMember(Value = "(GMT+01:00) Africa/Ceuta")]
        Gmt0100AfricaCeuta,
        [EnumMember(Value = "(GMT+01:00) Europe/Madrid")]
        Gmt0100EuropeMadrid,
        [EnumMember(Value = "(GMT+01:00) Arctic/Longyearbyen")]
        Gmt0100ArcticLongyearbyen,
        [EnumMember(Value = "(GMT+01:00) Europe/Stockholm")]
        Gmt0100EuropeStockholm,
        [EnumMember(Value = "(GMT+01:00) Europe/Zurich")]
        Gmt0100EuropeZurich,
        [EnumMember(Value = "(GMT+01:00) Africa/Tunis")]
        Gmt0100AfricaTunis,
        [EnumMember(Value = "(GMT+02:00) Africa/Gaborone")]
        Gmt0200AfricaGaborone,
        [EnumMember(Value = "(GMT+02:00) Europe/Sofia")]
        Gmt0200EuropeSofia,
        [EnumMember(Value = "(GMT+02:00) Africa/Bujumbura")]
        Gmt0200AfricaBujumbura,
        [EnumMember(Value = "(GMT+02:00) Africa/Lubumbashi")]
        Gmt0200AfricaLubumbashi,
        [EnumMember(Value = "(GMT+02:00) Asia/Nicosia")]
        Gmt0200AsiaNicosia,
        [EnumMember(Value = "(GMT+02:00) Africa/Cairo")]
        Gmt0200AfricaCairo,
        [EnumMember(Value = "(GMT+02:00) Europe/Tallinn")]
        Gmt0200EuropeTallinn,
        [EnumMember(Value = "(GMT+02:00) Europe/Helsinki")]
        Gmt0200EuropeHelsinki,
        [EnumMember(Value = "(GMT+02:00) Europe/Athens")]
        Gmt0200EuropeAthens,
        [EnumMember(Value = "(GMT+02:00) Asia/Jerusalem")]
        Gmt0200AsiaJerusalem,
        [EnumMember(Value = "(GMT+02:00) Asia/Amman")]
        Gmt0200AsiaAmman,
        [EnumMember(Value = "(GMT+02:00) Europe/Riga")]
        Gmt0200EuropeRiga,
        [EnumMember(Value = "(GMT+02:00) Asia/Beirut")]
        Gmt0200AsiaBeirut,
        [EnumMember(Value = "(GMT+02:00) Africa/Maseru")]
        Gmt0200AfricaMaseru,
        [EnumMember(Value = "(GMT+02:00) Africa/Tripoli")]
        Gmt0200AfricaTripoli,
        [EnumMember(Value = "(GMT+02:00) Europe/Vilnius")]
        Gmt0200EuropeVilnius,
        [EnumMember(Value = "(GMT+02:00) Africa/Blantyre")]
        Gmt0200AfricaBlantyre,
        [EnumMember(Value = "(GMT+02:00) Europe/Chisinau")]
        Gmt0200EuropeChisinau,
        [EnumMember(Value = "(GMT+02:00) Africa/Maputo")]
        Gmt0200AfricaMaputo,
        [EnumMember(Value = "(GMT+02:00) Africa/Windhoek")]
        Gmt0200AfricaWindhoek,
        [EnumMember(Value = "(GMT+02:00) Asia/Gaza")]
        Gmt0200AsiaGaza,
        [EnumMember(Value = "(GMT+02:00) Asia/Hebron")]
        Gmt0200AsiaHebron,
        [EnumMember(Value = "(GMT+02:00) Europe/Bucharest")]
        Gmt0200EuropeBucharest,
        [EnumMember(Value = "(GMT+02:00) Europe/Kaliningrad")]
        Gmt0200EuropeKaliningrad,
        [EnumMember(Value = "(GMT+02:00) Africa/Kigali")]
        Gmt0200AfricaKigali,
        [EnumMember(Value = "(GMT+02:00) Africa/Johannesburg")]
        Gmt0200AfricaJohannesburg,
        [EnumMember(Value = "(GMT+02:00) Africa/Mbabane")]
        Gmt0200AfricaMbabane,
        [EnumMember(Value = "(GMT+02:00) Asia/Damascus")]
        Gmt0200AsiaDamascus,
        [EnumMember(Value = "(GMT+02:00) Europe/Istanbul")]
        Gmt0200EuropeIstanbul,
        [EnumMember(Value = "(GMT+02:00) Europe/Kiev")]
        Gmt0200EuropeKiev,
        [EnumMember(Value = "(GMT+02:00) Europe/Uzhgorod")]
        Gmt0200EuropeUzhgorod,
        [EnumMember(Value = "(GMT+02:00) Europe/Zaporozhye")]
        Gmt0200EuropeZaporozhye,
        [EnumMember(Value = "(GMT+02:00) Africa/Lusaka")]
        Gmt0200AfricaLusaka,
        [EnumMember(Value = "(GMT+02:00) Africa/Harare")]
        Gmt0200AfricaHarare,
        [EnumMember(Value = "(GMT+02:00) Europe/Mariehamn")]
        Gmt0200EuropeMariehamn,
        [EnumMember(Value = "(GMT+03:00) Antarctica/Syowa")]
        Gmt0300AntarcticaSyowa,
        [EnumMember(Value = "(GMT+03:00) Asia/Bahrain")]
        Gmt0300AsiaBahrain,
        [EnumMember(Value = "(GMT+03:00) Europe/Minsk")]
        Gmt0300EuropeMinsk,
        [EnumMember(Value = "(GMT+03:00) Indian/Comoro")]
        Gmt0300IndianComoro,
        [EnumMember(Value = "(GMT+03:00) Africa/Djibouti")]
        Gmt0300AfricaDjibouti,
        [EnumMember(Value = "(GMT+03:00) Africa/Asmara")]
        Gmt0300AfricaAsmara,
        [EnumMember(Value = "(GMT+03:00) Africa/Addis_Ababa")]
        Gmt0300AfricaAddisAbaba,
        [EnumMember(Value = "(GMT+03:00) Asia/Baghdad")]
        Gmt0300AsiaBaghdad,
        [EnumMember(Value = "(GMT+03:00) Africa/Nairobi")]
        Gmt0300AfricaNairobi,
        [EnumMember(Value = "(GMT+03:00) Asia/Kuwait")]
        Gmt0300AsiaKuwait,
        [EnumMember(Value = "(GMT+03:00) Indian/Antananarivo")]
        Gmt0300IndianAntananarivo,
        [EnumMember(Value = "(GMT+03:00) Indian/Mayotte")]
        Gmt0300IndianMayotte,
        [EnumMember(Value = "(GMT+03:00) Asia/Qatar")]
        Gmt0300AsiaQatar,
        [EnumMember(Value = "(GMT+03:00) Europe/Moscow")]
        Gmt0300EuropeMoscow,
        [EnumMember(Value = "(GMT+03:00) Europe/Simferopol")]
        Gmt0300EuropeSimferopol,
        [EnumMember(Value = "(GMT+03:00) Europe/Volgograd")]
        Gmt0300EuropeVolgograd,
        [EnumMember(Value = "(GMT+03:00) Asia/Riyadh")]
        Gmt0300AsiaRiyadh,
        [EnumMember(Value = "(GMT+03:00) Africa/Mogadishu")]
        Gmt0300AfricaMogadishu,
        [EnumMember(Value = "(GMT+03:00) Africa/Juba")]
        Gmt0300AfricaJuba,
        [EnumMember(Value = "(GMT+03:00) Africa/Khartoum")]
        Gmt0300AfricaKhartoum,
        [EnumMember(Value = "(GMT+03:00) Africa/Dar_es_Salaam")]
        Gmt0300AfricaDarEsSalaam,
        [EnumMember(Value = "(GMT+03:00) Africa/Kampala")]
        Gmt0300AfricaKampala,
        [EnumMember(Value = "(GMT+03:00) Asia/Aden")]
        Gmt0300AsiaAden,
        [EnumMember(Value = "(GMT+04:00) Asia/Yerevan")]
        Gmt0400AsiaYerevan,
        [EnumMember(Value = "(GMT+04:00) Asia/Baku")]
        Gmt0400AsiaBaku,
        [EnumMember(Value = "(GMT+04:00) Asia/Tbilisi")]
        Gmt0400AsiaTbilisi,
        [EnumMember(Value = "(GMT+04:00) Indian/Mauritius")]
        Gmt0400IndianMauritius,
        [EnumMember(Value = "(GMT+04:00) Asia/Muscat")]
        Gmt0400AsiaMuscat,
        [EnumMember(Value = "(GMT+04:00) Europe/Samara")]
        Gmt0400EuropeSamara,
        [EnumMember(Value = "(GMT+04:00) Indian/Reunion")]
        Gmt0400IndianReunion,
        [EnumMember(Value = "(GMT+04:00) Indian/Mahe")]
        Gmt0400IndianMahe,
        [EnumMember(Value = "(GMT+04:00) Asia/Dubai")]
        Gmt0400AsiaDubai,
        [EnumMember(Value = "(GMT+04:30) Asia/Kabul")]
        Gmt0430AsiaKabul,
        [EnumMember(Value = "(GMT+04:30) Asia/Tehran")]
        Gmt0430AsiaTehran,
        [EnumMember(Value = "(GMT+05:00) Antarctica/Mawson")]
        Gmt0500AntarcticaMawson,
        [EnumMember(Value = "(GMT+05:00) Indian/Kerguelen")]
        Gmt0500IndianKerguelen,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtau")]
        Gmt0500AsiaAqtau,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtobe")]
        Gmt0500AsiaAqtobe,
        [EnumMember(Value = "(GMT+05:00) Asia/Oral")]
        Gmt0500AsiaOral,
        [EnumMember(Value = "(GMT+05:00) Indian/Maldives")]
        Gmt0500IndianMaldives,
        [EnumMember(Value = "(GMT+05:00) Asia/Karachi")]
        Gmt0500AsiaKarachi,
        [EnumMember(Value = "(GMT+05:00) Asia/Yekaterinburg")]
        Gmt0500AsiaYekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Asia/Dushanbe")]
        Gmt0500AsiaDushanbe,
        [EnumMember(Value = "(GMT+05:00) Asia/Ashgabat")]
        Gmt0500AsiaAshgabat,
        [EnumMember(Value = "(GMT+05:00) Asia/Samarkand")]
        Gmt0500AsiaSamarkand,
        [EnumMember(Value = "(GMT+05:00) Asia/Tashkent")]
        Gmt0500AsiaTashkent,
        [EnumMember(Value = "(GMT+05:30) Asia/Kolkata")]
        Gmt0530AsiaKolkata,
        [EnumMember(Value = "(GMT+05:30) Asia/Colombo")]
        Gmt0530AsiaColombo,
        [EnumMember(Value = "(GMT+05:45) Asia/Kathmandu")]
        Gmt0545AsiaKathmandu,
        [EnumMember(Value = "(GMT+06:00) Antarctica/Vostok")]
        Gmt0600AntarcticaVostok,
        [EnumMember(Value = "(GMT+06:00) Asia/Dhaka")]
        Gmt0600AsiaDhaka,
        [EnumMember(Value = "(GMT+06:00) Asia/Thimphu")]
        Gmt0600AsiaThimphu,
        [EnumMember(Value = "(GMT+06:00) Indian/Chagos")]
        Gmt0600IndianChagos,
        [EnumMember(Value = "(GMT+06:00) Asia/Urumqi")]
        Gmt0600AsiaUrumqi,
        [EnumMember(Value = "(GMT+06:00) Asia/Almaty")]
        Gmt0600AsiaAlmaty,
        [EnumMember(Value = "(GMT+06:00) Asia/Qyzylorda")]
        Gmt0600AsiaQyzylorda,
        [EnumMember(Value = "(GMT+06:00) Asia/Bishkek")]
        Gmt0600AsiaBishkek,
        [EnumMember(Value = "(GMT+06:00) Asia/Novosibirsk")]
        Gmt0600AsiaNovosibirsk,
        [EnumMember(Value = "(GMT+06:00) Asia/Omsk")]
        Gmt0600AsiaOmsk,
        [EnumMember(Value = "(GMT+06:30) Indian/Cocos")]
        Gmt0630IndianCocos,
        [EnumMember(Value = "(GMT+06:30) Asia/Rangoon")]
        Gmt0630AsiaRangoon,
        [EnumMember(Value = "(GMT+07:00) Antarctica/Davis")]
        Gmt0700AntarcticaDavis,
        [EnumMember(Value = "(GMT+07:00) Asia/Phnom_Penh")]
        Gmt0700AsiaPhnomPenh,
        [EnumMember(Value = "(GMT+07:00) Indian/Christmas")]
        Gmt0700IndianChristmas,
        [EnumMember(Value = "(GMT+07:00) Asia/Jakarta")]
        Gmt0700AsiaJakarta,
        [EnumMember(Value = "(GMT+07:00) Asia/Pontianak")]
        Gmt0700AsiaPontianak,
        [EnumMember(Value = "(GMT+07:00) Asia/Vientiane")]
        Gmt0700AsiaVientiane,
        [EnumMember(Value = "(GMT+07:00) Asia/Hovd")]
        Gmt0700AsiaHovd,
        [EnumMember(Value = "(GMT+07:00) Asia/Krasnoyarsk")]
        Gmt0700AsiaKrasnoyarsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Novokuznetsk")]
        Gmt0700AsiaNovokuznetsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Bangkok")]
        Gmt0700AsiaBangkok,
        [EnumMember(Value = "(GMT+07:00) Asia/Ho_Chi_Minh")]
        Gmt0700AsiaHoChiMinh,
        [EnumMember(Value = "(GMT+08:00) Antarctica/Casey")]
        Gmt0800AntarcticaCasey,
        [EnumMember(Value = "(GMT+08:00) Australia/Perth")]
        Gmt0800AustraliaPerth,
        [EnumMember(Value = "(GMT+08:00) Asia/Brunei")]
        Gmt0800AsiaBrunei,
        [EnumMember(Value = "(GMT+08:00) Asia/Shanghai")]
        Gmt0800AsiaShanghai,
        [EnumMember(Value = "(GMT+08:00) Asia/Hong_Kong")]
        Gmt0800AsiaHongKong,
        [EnumMember(Value = "(GMT+08:00) Asia/Makassar")]
        Gmt0800AsiaMakassar,
        [EnumMember(Value = "(GMT+08:00) Asia/Macau")]
        Gmt0800AsiaMacau,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuala_Lumpur")]
        Gmt0800AsiaKualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuching")]
        Gmt0800AsiaKuching,
        [EnumMember(Value = "(GMT+08:00) Asia/Choibalsan")]
        Gmt0800AsiaChoibalsan,
        [EnumMember(Value = "(GMT+08:00) Asia/Ulaanbaatar")]
        Gmt0800AsiaUlaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Asia/Manila")]
        Gmt0800AsiaManila,
        [EnumMember(Value = "(GMT+08:00) Asia/Chita")]
        Gmt0800AsiaChita,
        [EnumMember(Value = "(GMT+08:00) Asia/Irkutsk")]
        Gmt0800AsiaIrkutsk,
        [EnumMember(Value = "(GMT+08:00) Asia/Singapore")]
        Gmt0800AsiaSingapore,
        [EnumMember(Value = "(GMT+08:00) Asia/Taipei")]
        Gmt0800AsiaTaipei,
        [EnumMember(Value = "(GMT+08:45) Australia/Eucla")]
        Gmt0845AustraliaEucla,
        [EnumMember(Value = "(GMT+09:00) Asia/Jayapura")]
        Gmt0900AsiaJayapura,
        [EnumMember(Value = "(GMT+09:00) Asia/Tokyo")]
        Gmt0900AsiaTokyo,
        [EnumMember(Value = "(GMT+09:00) Asia/Pyongyang")]
        Gmt0900AsiaPyongyang,
        [EnumMember(Value = "(GMT+09:00) Asia/Seoul")]
        Gmt0900AsiaSeoul,
        [EnumMember(Value = "(GMT+09:00) Pacific/Palau")]
        Gmt0900PacificPalau,
        [EnumMember(Value = "(GMT+09:00) Asia/Khandyga")]
        Gmt0900AsiaKhandyga,
        [EnumMember(Value = "(GMT+09:00) Asia/Yakutsk")]
        Gmt0900AsiaYakutsk,
        [EnumMember(Value = "(GMT+09:00) Asia/Dili")]
        Gmt0900AsiaDili,
        [EnumMember(Value = "(GMT+09:30) Australia/Darwin")]
        Gmt0930AustraliaDarwin,
        [EnumMember(Value = "(GMT+10:00) Antarctica/DumontDUrville")]
        Gmt1000AntarcticaDumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Australia/Brisbane")]
        Gmt1000AustraliaBrisbane,
        [EnumMember(Value = "(GMT+10:00) Australia/Lindeman")]
        Gmt1000AustraliaLindeman,
        [EnumMember(Value = "(GMT+10:00) Pacific/Guam")]
        Gmt1000PacificGuam,
        [EnumMember(Value = "(GMT+10:00) Pacific/Chuuk")]
        Gmt1000PacificChuuk,
        [EnumMember(Value = "(GMT+10:00) Pacific/Saipan")]
        Gmt1000PacificSaipan,
        [EnumMember(Value = "(GMT+10:00) Pacific/Port_Moresby")]
        Gmt1000PacificPortMoresby,
        [EnumMember(Value = "(GMT+10:00) Asia/Magadan")]
        Gmt1000AsiaMagadan,
        [EnumMember(Value = "(GMT+10:00) Asia/Sakhalin")]
        Gmt1000AsiaSakhalin,
        [EnumMember(Value = "(GMT+10:00) Asia/Ust-Nera")]
        Gmt1000AsiaUstNera,
        [EnumMember(Value = "(GMT+10:00) Asia/Vladivostok")]
        Gmt1000AsiaVladivostok,
        [EnumMember(Value = "(GMT+10:30) Australia/Adelaide")]
        Gmt1030AustraliaAdelaide,
        [EnumMember(Value = "(GMT+10:30) Australia/Broken_Hill")]
        Gmt1030AustraliaBrokenHill,
        [EnumMember(Value = "(GMT+11:00) Australia/Currie")]
        Gmt1100AustraliaCurrie,
        [EnumMember(Value = "(GMT+11:00) Australia/Hobart")]
        Gmt1100AustraliaHobart,
        [EnumMember(Value = "(GMT+11:00) Australia/Lord_Howe")]
        Gmt1100AustraliaLordHowe,
        [EnumMember(Value = "(GMT+11:00) Antarctica/Macquarie")]
        Gmt1100AntarcticaMacquarie,
        [EnumMember(Value = "(GMT+11:00) Australia/Melbourne")]
        Gmt1100AustraliaMelbourne,
        [EnumMember(Value = "(GMT+11:00) Australia/Sydney")]
        Gmt1100AustraliaSydney,
        [EnumMember(Value = "(GMT+11:00) Pacific/Kosrae")]
        Gmt1100PacificKosrae,
        [EnumMember(Value = "(GMT+11:00) Pacific/Pohnpei")]
        Gmt1100PacificPohnpei,
        [EnumMember(Value = "(GMT+11:00) Pacific/Noumea")]
        Gmt1100PacificNoumea,
        [EnumMember(Value = "(GMT+11:00) Pacific/Bougainville")]
        Gmt1100PacificBougainville,
        [EnumMember(Value = "(GMT+11:00) Asia/Srednekolymsk")]
        Gmt1100AsiaSrednekolymsk,
        [EnumMember(Value = "(GMT+11:00) Pacific/Guadalcanal")]
        Gmt1100PacificGuadalcanal,
        [EnumMember(Value = "(GMT+11:00) Pacific/Efate")]
        Gmt1100PacificEfate,
        [EnumMember(Value = "(GMT+11:30) Pacific/Norfolk")]
        Gmt1130PacificNorfolk,
        [EnumMember(Value = "(GMT+12:00) Pacific/Fiji")]
        Gmt1200PacificFiji,
        [EnumMember(Value = "(GMT+12:00) Pacific/Tarawa")]
        Gmt1200PacificTarawa,
        [EnumMember(Value = "(GMT+12:00) Pacific/Kwajalein")]
        Gmt1200PacificKwajalein,
        [EnumMember(Value = "(GMT+12:00) Pacific/Majuro")]
        Gmt1200PacificMajuro,
        [EnumMember(Value = "(GMT+12:00) Pacific/Nauru")]
        Gmt1200PacificNauru,
        [EnumMember(Value = "(GMT+12:00) Asia/Anadyr")]
        Gmt1200AsiaAnadyr,
        [EnumMember(Value = "(GMT+12:00) Asia/Kamchatka")]
        Gmt1200AsiaKamchatka,
        [EnumMember(Value = "(GMT+12:00) Pacific/Funafuti")]
        Gmt1200PacificFunafuti,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wake")]
        Gmt1200PacificWake,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wallis")]
        Gmt1200PacificWallis,
        [EnumMember(Value = "(GMT+13:00) Antarctica/McMurdo")]
        Gmt1300AntarcticaMcMurdo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Enderbury")]
        Gmt1300PacificEnderbury,
        [EnumMember(Value = "(GMT+13:00) Pacific/Auckland")]
        Gmt1300PacificAuckland,
        [EnumMember(Value = "(GMT+13:00) Pacific/Fakaofo")]
        Gmt1300PacificFakaofo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Tongatapu")]
        Gmt1300PacificTongatapu,
        [EnumMember(Value = "(GMT+13:45) Pacific/Chatham")]
        Gmt1345PacificChatham,
        [EnumMember(Value = "(GMT+14:00) Pacific/Kiritimati")]
        Gmt1400PacificKiritimati,
        [EnumMember(Value = "(GMT+14:00) Pacific/Apia")]
        Gmt1400PacificApia
    }

    public class PostDataResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class PostDataBodyInput
    {
        public PostDataBodyInput(string deviceId, string variable, string value)
        {
            this.DeviceId = deviceId;
            this.Variable = variable;
            this.Value = value;
        }

        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceId { get; set; }

        [JsonProperty("variable", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Variable { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTimezoneType? Timezone { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tago.BodyInputTimezoneType.Gmt0000Utc;

        [JsonProperty("time")]
        public string Timestamp { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTimezoneType
    {
        [EnumMember(Value = "(GMT+00:00) UTC")]
        Gmt0000Utc,
        [EnumMember(Value = "(GMT-11:00) Pacific/Pago_Pago")]
        Gmt1100PacificPagoPago,
        [EnumMember(Value = "(GMT-11:00) Pacific/Niue")]
        Gmt1100PacificNiue,
        [EnumMember(Value = "(GMT-11:00) Pacific/Midway")]
        Gmt1100PacificMidway,
        [EnumMember(Value = "(GMT-10:00) Pacific/Rarotonga")]
        Gmt1000PacificRarotonga,
        [EnumMember(Value = "(GMT-10:00) Pacific/Tahiti")]
        Gmt1000PacificTahiti,
        [EnumMember(Value = "(GMT-10:00) Pacific/Honolulu")]
        Gmt1000PacificHonolulu,
        [EnumMember(Value = "(GMT-10:00) Pacific/Johnston")]
        Gmt1000PacificJohnston,
        [EnumMember(Value = "(GMT-09:30) Pacific/Marquesas")]
        Gmt0930PacificMarquesas,
        [EnumMember(Value = "(GMT-09:00) Pacific/Gambier")]
        Gmt0900PacificGambier,
        [EnumMember(Value = "(GMT-09:00) America/Adak")]
        Gmt0900AmericaAdak,
        [EnumMember(Value = "(GMT-08:00) America/Santa_Isabel")]
        Gmt0800AmericaSantaIsabel,
        [EnumMember(Value = "(GMT-08:00) Pacific/Pitcairn")]
        Gmt0800PacificPitcairn,
        [EnumMember(Value = "(GMT-08:00) America/Anchorage")]
        Gmt0800AmericaAnchorage,
        [EnumMember(Value = "(GMT-08:00) America/Juneau")]
        Gmt0800AmericaJuneau,
        [EnumMember(Value = "(GMT-08:00) America/Metlakatla")]
        Gmt0800AmericaMetlakatla,
        [EnumMember(Value = "(GMT-08:00) America/Nome")]
        Gmt0800AmericaNome,
        [EnumMember(Value = "(GMT-08:00) America/Sitka")]
        Gmt0800AmericaSitka,
        [EnumMember(Value = "(GMT-08:00) America/Yakutat")]
        Gmt0800AmericaYakutat,
        [EnumMember(Value = "(GMT-07:00) America/Creston")]
        Gmt0700AmericaCreston,
        [EnumMember(Value = "(GMT-07:00) America/Dawson")]
        Gmt0700AmericaDawson,
        [EnumMember(Value = "(GMT-07:00) America/Dawson_Creek")]
        Gmt0700AmericaDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) America/Vancouver")]
        Gmt0700AmericaVancouver,
        [EnumMember(Value = "(GMT-07:00) America/Whitehorse")]
        Gmt0700AmericaWhitehorse,
        [EnumMember(Value = "(GMT-07:00) America/Chihuahua")]
        Gmt0700AmericaChihuahua,
        [EnumMember(Value = "(GMT-07:00) America/Hermosillo")]
        Gmt0700AmericaHermosillo,
        [EnumMember(Value = "(GMT-07:00) America/Mazatlan")]
        Gmt0700AmericaMazatlan,
        [EnumMember(Value = "(GMT-07:00) America/Tijuana")]
        Gmt0700AmericaTijuana,
        [EnumMember(Value = "(GMT-07:00) America/Los_Angeles")]
        Gmt0700AmericaLosAngeles,
        [EnumMember(Value = "(GMT-07:00) America/Phoenix")]
        Gmt0700AmericaPhoenix,
        [EnumMember(Value = "(GMT-06:00) America/Belize")]
        Gmt0600AmericaBelize,
        [EnumMember(Value = "(GMT-06:00) America/Cambridge_Bay")]
        Gmt0600AmericaCambridgeBay,
        [EnumMember(Value = "(GMT-06:00) America/Edmonton")]
        Gmt0600AmericaEdmonton,
        [EnumMember(Value = "(GMT-06:00) America/Inuvik")]
        Gmt0600AmericaInuvik,
        [EnumMember(Value = "(GMT-06:00) America/Regina")]
        Gmt0600AmericaRegina,
        [EnumMember(Value = "(GMT-06:00) America/Swift_Current")]
        Gmt0600AmericaSwiftCurrent,
        [EnumMember(Value = "(GMT-06:00) America/Yellowknife")]
        Gmt0600AmericaYellowknife,
        [EnumMember(Value = "(GMT-06:00) America/Costa_Rica")]
        Gmt0600AmericaCostaRica,
        [EnumMember(Value = "(GMT-06:00) Pacific/Galapagos")]
        Gmt0600PacificGalapagos,
        [EnumMember(Value = "(GMT-06:00) America/El_Salvador")]
        Gmt0600AmericaElSalvador,
        [EnumMember(Value = "(GMT-06:00) America/Guatemala")]
        Gmt0600AmericaGuatemala,
        [EnumMember(Value = "(GMT-06:00) America/Tegucigalpa")]
        Gmt0600AmericaTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) America/Bahia_Banderas")]
        Gmt0600AmericaBahiaBanderas,
        [EnumMember(Value = "(GMT-06:00) America/Cancun")]
        Gmt0600AmericaCancun,
        [EnumMember(Value = "(GMT-06:00) America/Merida")]
        Gmt0600AmericaMerida,
        [EnumMember(Value = "(GMT-06:00) America/Mexico_City")]
        Gmt0600AmericaMexicoCity,
        [EnumMember(Value = "(GMT-06:00) America/Monterrey")]
        Gmt0600AmericaMonterrey,
        [EnumMember(Value = "(GMT-06:00) America/Ojinaga")]
        Gmt0600AmericaOjinaga,
        [EnumMember(Value = "(GMT-06:00) America/Managua")]
        Gmt0600AmericaManagua,
        [EnumMember(Value = "(GMT-06:00) America/Boise")]
        Gmt0600AmericaBoise,
        [EnumMember(Value = "(GMT-06:00) America/Denver")]
        Gmt0600AmericaDenver,
        [EnumMember(Value = "(GMT-05:00) America/Eirunepe")]
        Gmt0500AmericaEirunepe,
        [EnumMember(Value = "(GMT-05:00) America/Rio_Branco")]
        Gmt0500AmericaRioBranco,
        [EnumMember(Value = "(GMT-05:00) America/Atikokan")]
        Gmt0500AmericaAtikokan,
        [EnumMember(Value = "(GMT-05:00) America/Rainy_River")]
        Gmt0500AmericaRainyRiver,
        [EnumMember(Value = "(GMT-05:00) America/Rankin_Inlet")]
        Gmt0500AmericaRankinInlet,
        [EnumMember(Value = "(GMT-05:00) America/Resolute")]
        Gmt0500AmericaResolute,
        [EnumMember(Value = "(GMT-05:00) America/Winnipeg")]
        Gmt0500AmericaWinnipeg,
        [EnumMember(Value = "(GMT-05:00) America/Cayman")]
        Gmt0500AmericaCayman,
        [EnumMember(Value = "(GMT-05:00) Pacific/Easter")]
        Gmt0500PacificEaster,
        [EnumMember(Value = "(GMT-05:00) America/Bogota")]
        Gmt0500AmericaBogota,
        [EnumMember(Value = "(GMT-05:00) America/Guayaquil")]
        Gmt0500AmericaGuayaquil,
        [EnumMember(Value = "(GMT-05:00) America/Jamaica")]
        Gmt0500AmericaJamaica,
        [EnumMember(Value = "(GMT-05:00) America/Matamoros")]
        Gmt0500AmericaMatamoros,
        [EnumMember(Value = "(GMT-05:00) America/Panama")]
        Gmt0500AmericaPanama,
        [EnumMember(Value = "(GMT-05:00) America/Lima")]
        Gmt0500AmericaLima,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Beulah")]
        Gmt0500AmericaNorthDakotaBeulah,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Center")]
        Gmt0500AmericaNorthDakotaCenter,
        [EnumMember(Value = "(GMT-05:00) America/Chicago")]
        Gmt0500AmericaChicago,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Knox")]
        Gmt0500AmericaIndianaKnox,
        [EnumMember(Value = "(GMT-05:00) America/Menominee")]
        Gmt0500AmericaMenominee,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/New_Salem")]
        Gmt0500AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Tell_City")]
        Gmt0500AmericaIndianaTellCity,
        [EnumMember(Value = "(GMT-04:30) America/Caracas")]
        Gmt0430AmericaCaracas,
        [EnumMember(Value = "(GMT-04:00) America/Anguilla")]
        Gmt0400AmericaAnguilla,
        [EnumMember(Value = "(GMT-04:00) America/Antigua")]
        Gmt0400AmericaAntigua,
        [EnumMember(Value = "(GMT-04:00) America/Aruba")]
        Gmt0400AmericaAruba,
        [EnumMember(Value = "(GMT-04:00) America/Nassau")]
        Gmt0400AmericaNassau,
        [EnumMember(Value = "(GMT-04:00) America/Barbados")]
        Gmt0400AmericaBarbados,
        [EnumMember(Value = "(GMT-04:00) America/La_Paz")]
        Gmt0400AmericaLaPaz,
        [EnumMember(Value = "(GMT-04:00) America/Kralendijk")]
        Gmt0400AmericaKralendijk,
        [EnumMember(Value = "(GMT-04:00) America/Boa_Vista")]
        Gmt0400AmericaBoaVista,
        [EnumMember(Value = "(GMT-04:00) America/Campo_Grande")]
        Gmt0400AmericaCampoGrande,
        [EnumMember(Value = "(GMT-04:00) America/Cuiaba")]
        Gmt0400AmericaCuiaba,
        [EnumMember(Value = "(GMT-04:00) America/Manaus")]
        Gmt0400AmericaManaus,
        [EnumMember(Value = "(GMT-04:00) America/Porto_Velho")]
        Gmt0400AmericaPortoVelho,
        [EnumMember(Value = "(GMT-04:00) America/Blanc-Sablon")]
        Gmt0400AmericaBlancSablon,
        [EnumMember(Value = "(GMT-04:00) America/Iqaluit")]
        Gmt0400AmericaIqaluit,
        [EnumMember(Value = "(GMT-04:00) America/Nipigon")]
        Gmt0400AmericaNipigon,
        [EnumMember(Value = "(GMT-04:00) America/Pangnirtung")]
        Gmt0400AmericaPangnirtung,
        [EnumMember(Value = "(GMT-04:00) America/Thunder_Bay")]
        Gmt0400AmericaThunderBay,
        [EnumMember(Value = "(GMT-04:00) America/Toronto")]
        Gmt0400AmericaToronto,
        [EnumMember(Value = "(GMT-04:00) America/Havana")]
        Gmt0400AmericaHavana,
        [EnumMember(Value = "(GMT-04:00) America/Curacao")]
        Gmt0400AmericaCuracao,
        [EnumMember(Value = "(GMT-04:00) America/Dominica")]
        Gmt0400AmericaDominica,
        [EnumMember(Value = "(GMT-04:00) America/Santo_Domingo")]
        Gmt0400AmericaSantoDomingo,
        [EnumMember(Value = "(GMT-04:00) America/Grenada")]
        Gmt0400AmericaGrenada,
        [EnumMember(Value = "(GMT-04:00) America/Guadeloupe")]
        Gmt0400AmericaGuadeloupe,
        [EnumMember(Value = "(GMT-04:00) America/Guyana")]
        Gmt0400AmericaGuyana,
        [EnumMember(Value = "(GMT-04:00) America/Port-au-Prince")]
        Gmt0400AmericaPortAuPrince,
        [EnumMember(Value = "(GMT-04:00) America/Martinique")]
        Gmt0400AmericaMartinique,
        [EnumMember(Value = "(GMT-04:00) America/Montserrat")]
        Gmt0400AmericaMontserrat,
        [EnumMember(Value = "(GMT-04:00) America/Asuncion")]
        Gmt0400AmericaAsuncion,
        [EnumMember(Value = "(GMT-04:00) America/Puerto_Rico")]
        Gmt0400AmericaPuertoRico,
        [EnumMember(Value = "(GMT-04:00) America/St_Barthelemy")]
        Gmt0400AmericaStBarthelemy,
        [EnumMember(Value = "(GMT-04:00) America/St_Kitts")]
        Gmt0400AmericaStKitts,
        [EnumMember(Value = "(GMT-04:00) America/St_Lucia")]
        Gmt0400AmericaStLucia,
        [EnumMember(Value = "(GMT-04:00) America/Marigot")]
        Gmt0400AmericaMarigot,
        [EnumMember(Value = "(GMT-04:00) America/St_Vincent")]
        Gmt0400AmericaStVincent,
        [EnumMember(Value = "(GMT-04:00) America/Lower_Princes")]
        Gmt0400AmericaLowerPrinces,
        [EnumMember(Value = "(GMT-04:00) America/Port_of_Spain")]
        Gmt0400AmericaPortOfSpain,
        [EnumMember(Value = "(GMT-04:00) America/Grand_Turk")]
        Gmt0400AmericaGrandTurk,
        [EnumMember(Value = "(GMT-04:00) America/Detroit")]
        Gmt0400AmericaDetroit,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Indianapolis")]
        Gmt0400AmericaIndianaIndianapolis,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Louisville")]
        Gmt0400AmericaKentuckyLouisville,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Marengo")]
        Gmt0400AmericaIndianaMarengo,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Monticello")]
        Gmt0400AmericaKentuckyMonticello,
        [EnumMember(Value = "(GMT-04:00) America/New_York")]
        Gmt0400AmericaNewYork,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Petersburg")]
        Gmt0400AmericaIndianaPetersburg,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vevay")]
        Gmt0400AmericaIndianaVevay,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vincennes")]
        Gmt0400AmericaIndianaVincennes,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Winamac")]
        Gmt0400AmericaIndianaWinamac,
        [EnumMember(Value = "(GMT-04:00) America/Tortola")]
        Gmt0400AmericaTortola,
        [EnumMember(Value = "(GMT-04:00) America/St_Thomas")]
        Gmt0400AmericaStThomas,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Palmer")]
        Gmt0300AntarcticaPalmer,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Rothera")]
        Gmt0300AntarcticaRothera,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Buenos_Aires")]
        Gmt0300AmericaArgentinaBuenosAires,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Catamarca")]
        Gmt0300AmericaArgentinaCatamarca,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Cordoba")]
        Gmt0300AmericaArgentinaCordoba,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Jujuy")]
        Gmt0300AmericaArgentinaJujuy,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/La_Rioja")]
        Gmt0300AmericaArgentinaLaRioja,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Mendoza")]
        Gmt0300AmericaArgentinaMendoza,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Rio_Gallegos")]
        Gmt0300AmericaArgentinaRioGallegos,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Salta")]
        Gmt0300AmericaArgentinaSalta,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Juan")]
        Gmt0300AmericaArgentinaSanJuan,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Luis")]
        Gmt0300AmericaArgentinaSanLuis,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Tucuman")]
        Gmt0300AmericaArgentinaTucuman,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Ushuaia")]
        Gmt0300AmericaArgentinaUshuaia,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Bermuda")]
        Gmt0300AtlanticBermuda,
        [EnumMember(Value = "(GMT-03:00) America/Araguaina")]
        Gmt0300AmericaAraguaina,
        [EnumMember(Value = "(GMT-03:00) America/Bahia")]
        Gmt0300AmericaBahia,
        [EnumMember(Value = "(GMT-03:00) America/Belem")]
        Gmt0300AmericaBelem,
        [EnumMember(Value = "(GMT-03:00) America/Fortaleza")]
        Gmt0300AmericaFortaleza,
        [EnumMember(Value = "(GMT-03:00) America/Maceio")]
        Gmt0300AmericaMaceio,
        [EnumMember(Value = "(GMT-03:00) America/Recife")]
        Gmt0300AmericaRecife,
        [EnumMember(Value = "(GMT-03:00) America/Santarem")]
        Gmt0300AmericaSantarem,
        [EnumMember(Value = "(GMT-03:00) America/Sao_Paulo")]
        Gmt0300AmericaSaoPaulo,
        [EnumMember(Value = "(GMT-03:00) America/Glace_Bay")]
        Gmt0300AmericaGlaceBay,
        [EnumMember(Value = "(GMT-03:00) America/Goose_Bay")]
        Gmt0300AmericaGooseBay,
        [EnumMember(Value = "(GMT-03:00) America/Halifax")]
        Gmt0300AmericaHalifax,
        [EnumMember(Value = "(GMT-03:00) America/Moncton")]
        Gmt0300AmericaMoncton,
        [EnumMember(Value = "(GMT-03:00) America/Santiago")]
        Gmt0300AmericaSantiago,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Stanley")]
        Gmt0300AtlanticStanley,
        [EnumMember(Value = "(GMT-03:00) America/Cayenne")]
        Gmt0300AmericaCayenne,
        [EnumMember(Value = "(GMT-03:00) America/Godthab")]
        Gmt0300AmericaGodthab,
        [EnumMember(Value = "(GMT-03:00) America/Thule")]
        Gmt0300AmericaThule,
        [EnumMember(Value = "(GMT-03:00) America/Paramaribo")]
        Gmt0300AmericaParamaribo,
        [EnumMember(Value = "(GMT-03:00) America/Montevideo")]
        Gmt0300AmericaMontevideo,
        [EnumMember(Value = "(GMT-02:30) America/St_Johns")]
        Gmt0230AmericaStJohns,
        [EnumMember(Value = "(GMT-02:00) America/Noronha")]
        Gmt0200AmericaNoronha,
        [EnumMember(Value = "(GMT-02:00) America/Miquelon")]
        Gmt0200AmericaMiquelon,
        [EnumMember(Value = "(GMT-02:00) Atlantic/South_Georgia")]
        Gmt0200AtlanticSouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Cape_Verde")]
        Gmt0100AtlanticCapeVerde,
        [EnumMember(Value = "(GMT-01:00) America/Scoresbysund")]
        Gmt0100AmericaScoresbysund,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Azores")]
        Gmt0100AtlanticAzores,
        [EnumMember(Value = "(GMT+00:00) Antarctica/Troll")]
        Gmt0000AntarcticaTroll,
        [EnumMember(Value = "(GMT+00:00) Africa/Ouagadougou")]
        Gmt0000AfricaOuagadougou,
        [EnumMember(Value = "(GMT+00:00) Africa/Abidjan")]
        Gmt0000AfricaAbidjan,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Faroe")]
        Gmt0000AtlanticFaroe,
        [EnumMember(Value = "(GMT+00:00) Africa/Banjul")]
        Gmt0000AfricaBanjul,
        [EnumMember(Value = "(GMT+00:00) Africa/Accra")]
        Gmt0000AfricaAccra,
        [EnumMember(Value = "(GMT+00:00) America/Danmarkshavn")]
        Gmt0000AmericaDanmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Europe/Guernsey")]
        Gmt0000EuropeGuernsey,
        [EnumMember(Value = "(GMT+00:00) Africa/Conakry")]
        Gmt0000AfricaConakry,
        [EnumMember(Value = "(GMT+00:00) Africa/Bissau")]
        Gmt0000AfricaBissau,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Reykjavik")]
        Gmt0000AtlanticReykjavik,
        [EnumMember(Value = "(GMT+00:00) Europe/Dublin")]
        Gmt0000EuropeDublin,
        [EnumMember(Value = "(GMT+00:00) Europe/Isle_of_Man")]
        Gmt0000EuropeIsleOfMan,
        [EnumMember(Value = "(GMT+00:00) Europe/Jersey")]
        Gmt0000EuropeJersey,
        [EnumMember(Value = "(GMT+00:00) Africa/Monrovia")]
        Gmt0000AfricaMonrovia,
        [EnumMember(Value = "(GMT+00:00) Africa/Bamako")]
        Gmt0000AfricaBamako,
        [EnumMember(Value = "(GMT+00:00) Africa/Nouakchott")]
        Gmt0000AfricaNouakchott,
        [EnumMember(Value = "(GMT+00:00) Africa/Casablanca")]
        Gmt0000AfricaCasablanca,
        [EnumMember(Value = "(GMT+00:00) Europe/Lisbon")]
        Gmt0000EuropeLisbon,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Madeira")]
        Gmt0000AtlanticMadeira,
        [EnumMember(Value = "(GMT+00:00) Atlantic/St_Helena")]
        Gmt0000AtlanticStHelena,
        [EnumMember(Value = "(GMT+00:00) Africa/Sao_Tome")]
        Gmt0000AfricaSaoTome,
        [EnumMember(Value = "(GMT+00:00) Africa/Dakar")]
        Gmt0000AfricaDakar,
        [EnumMember(Value = "(GMT+00:00) Africa/Freetown")]
        Gmt0000AfricaFreetown,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Canary")]
        Gmt0000AtlanticCanary,
        [EnumMember(Value = "(GMT+00:00) Africa/Lome")]
        Gmt0000AfricaLome,
        [EnumMember(Value = "(GMT+00:00) Europe/London")]
        Gmt0000EuropeLondon,
        [EnumMember(Value = "(GMT+00:00) Africa/El_Aaiun")]
        Gmt0000AfricaElAaiun,
        [EnumMember(Value = "(GMT+01:00) Europe/Tirane")]
        Gmt0100EuropeTirane,
        [EnumMember(Value = "(GMT+01:00) Africa/Algiers")]
        Gmt0100AfricaAlgiers,
        [EnumMember(Value = "(GMT+01:00) Europe/Andorra")]
        Gmt0100EuropeAndorra,
        [EnumMember(Value = "(GMT+01:00) Africa/Luanda")]
        Gmt0100AfricaLuanda,
        [EnumMember(Value = "(GMT+01:00) Europe/Vienna")]
        Gmt0100EuropeVienna,
        [EnumMember(Value = "(GMT+01:00) Europe/Brussels")]
        Gmt0100EuropeBrussels,
        [EnumMember(Value = "(GMT+01:00) Africa/Porto-Novo")]
        Gmt0100AfricaPortoNovo,
        [EnumMember(Value = "(GMT+01:00) Europe/Sarajevo")]
        Gmt0100EuropeSarajevo,
        [EnumMember(Value = "(GMT+01:00) Africa/Douala")]
        Gmt0100AfricaDouala,
        [EnumMember(Value = "(GMT+01:00) Africa/Bangui")]
        Gmt0100AfricaBangui,
        [EnumMember(Value = "(GMT+01:00) Africa/Ndjamena")]
        Gmt0100AfricaNdjamena,
        [EnumMember(Value = "(GMT+01:00) Africa/Brazzaville")]
        Gmt0100AfricaBrazzaville,
        [EnumMember(Value = "(GMT+01:00) Africa/Kinshasa")]
        Gmt0100AfricaKinshasa,
        [EnumMember(Value = "(GMT+01:00) Europe/Zagreb")]
        Gmt0100EuropeZagreb,
        [EnumMember(Value = "(GMT+01:00) Europe/Prague")]
        Gmt0100EuropePrague,
        [EnumMember(Value = "(GMT+01:00) Europe/Copenhagen")]
        Gmt0100EuropeCopenhagen,
        [EnumMember(Value = "(GMT+01:00) Africa/Malabo")]
        Gmt0100AfricaMalabo,
        [EnumMember(Value = "(GMT+01:00) Europe/Paris")]
        Gmt0100EuropeParis,
        [EnumMember(Value = "(GMT+01:00) Africa/Libreville")]
        Gmt0100AfricaLibreville,
        [EnumMember(Value = "(GMT+01:00) Europe/Berlin")]
        Gmt0100EuropeBerlin,
        [EnumMember(Value = "(GMT+01:00) Europe/Busingen")]
        Gmt0100EuropeBusingen,
        [EnumMember(Value = "(GMT+01:00) Europe/Gibraltar")]
        Gmt0100EuropeGibraltar,
        [EnumMember(Value = "(GMT+01:00) Europe/Vatican")]
        Gmt0100EuropeVatican,
        [EnumMember(Value = "(GMT+01:00) Europe/Budapest")]
        Gmt0100EuropeBudapest,
        [EnumMember(Value = "(GMT+01:00) Europe/Rome")]
        Gmt0100EuropeRome,
        [EnumMember(Value = "(GMT+01:00) Europe/Vaduz")]
        Gmt0100EuropeVaduz,
        [EnumMember(Value = "(GMT+01:00) Europe/Luxembourg")]
        Gmt0100EuropeLuxembourg,
        [EnumMember(Value = "(GMT+01:00) Europe/Skopje")]
        Gmt0100EuropeSkopje,
        [EnumMember(Value = "(GMT+01:00) Europe/Malta")]
        Gmt0100EuropeMalta,
        [EnumMember(Value = "(GMT+01:00) Europe/Monaco")]
        Gmt0100EuropeMonaco,
        [EnumMember(Value = "(GMT+01:00) Europe/Podgorica")]
        Gmt0100EuropePodgorica,
        [EnumMember(Value = "(GMT+01:00) Europe/Amsterdam")]
        Gmt0100EuropeAmsterdam,
        [EnumMember(Value = "(GMT+01:00) Africa/Niamey")]
        Gmt0100AfricaNiamey,
        [EnumMember(Value = "(GMT+01:00) Africa/Lagos")]
        Gmt0100AfricaLagos,
        [EnumMember(Value = "(GMT+01:00) Europe/Oslo")]
        Gmt0100EuropeOslo,
        [EnumMember(Value = "(GMT+01:00) Europe/Warsaw")]
        Gmt0100EuropeWarsaw,
        [EnumMember(Value = "(GMT+01:00) Europe/San_Marino")]
        Gmt0100EuropeSanMarino,
        [EnumMember(Value = "(GMT+01:00) Europe/Belgrade")]
        Gmt0100EuropeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Europe/Bratislava")]
        Gmt0100EuropeBratislava,
        [EnumMember(Value = "(GMT+01:00) Europe/Ljubljana")]
        Gmt0100EuropeLjubljana,
        [EnumMember(Value = "(GMT+01:00) Africa/Ceuta")]
        Gmt0100AfricaCeuta,
        [EnumMember(Value = "(GMT+01:00) Europe/Madrid")]
        Gmt0100EuropeMadrid,
        [EnumMember(Value = "(GMT+01:00) Arctic/Longyearbyen")]
        Gmt0100ArcticLongyearbyen,
        [EnumMember(Value = "(GMT+01:00) Europe/Stockholm")]
        Gmt0100EuropeStockholm,
        [EnumMember(Value = "(GMT+01:00) Europe/Zurich")]
        Gmt0100EuropeZurich,
        [EnumMember(Value = "(GMT+01:00) Africa/Tunis")]
        Gmt0100AfricaTunis,
        [EnumMember(Value = "(GMT+02:00) Africa/Gaborone")]
        Gmt0200AfricaGaborone,
        [EnumMember(Value = "(GMT+02:00) Europe/Sofia")]
        Gmt0200EuropeSofia,
        [EnumMember(Value = "(GMT+02:00) Africa/Bujumbura")]
        Gmt0200AfricaBujumbura,
        [EnumMember(Value = "(GMT+02:00) Africa/Lubumbashi")]
        Gmt0200AfricaLubumbashi,
        [EnumMember(Value = "(GMT+02:00) Asia/Nicosia")]
        Gmt0200AsiaNicosia,
        [EnumMember(Value = "(GMT+02:00) Africa/Cairo")]
        Gmt0200AfricaCairo,
        [EnumMember(Value = "(GMT+02:00) Europe/Tallinn")]
        Gmt0200EuropeTallinn,
        [EnumMember(Value = "(GMT+02:00) Europe/Helsinki")]
        Gmt0200EuropeHelsinki,
        [EnumMember(Value = "(GMT+02:00) Europe/Athens")]
        Gmt0200EuropeAthens,
        [EnumMember(Value = "(GMT+02:00) Asia/Jerusalem")]
        Gmt0200AsiaJerusalem,
        [EnumMember(Value = "(GMT+02:00) Asia/Amman")]
        Gmt0200AsiaAmman,
        [EnumMember(Value = "(GMT+02:00) Europe/Riga")]
        Gmt0200EuropeRiga,
        [EnumMember(Value = "(GMT+02:00) Asia/Beirut")]
        Gmt0200AsiaBeirut,
        [EnumMember(Value = "(GMT+02:00) Africa/Maseru")]
        Gmt0200AfricaMaseru,
        [EnumMember(Value = "(GMT+02:00) Africa/Tripoli")]
        Gmt0200AfricaTripoli,
        [EnumMember(Value = "(GMT+02:00) Europe/Vilnius")]
        Gmt0200EuropeVilnius,
        [EnumMember(Value = "(GMT+02:00) Africa/Blantyre")]
        Gmt0200AfricaBlantyre,
        [EnumMember(Value = "(GMT+02:00) Europe/Chisinau")]
        Gmt0200EuropeChisinau,
        [EnumMember(Value = "(GMT+02:00) Africa/Maputo")]
        Gmt0200AfricaMaputo,
        [EnumMember(Value = "(GMT+02:00) Africa/Windhoek")]
        Gmt0200AfricaWindhoek,
        [EnumMember(Value = "(GMT+02:00) Asia/Gaza")]
        Gmt0200AsiaGaza,
        [EnumMember(Value = "(GMT+02:00) Asia/Hebron")]
        Gmt0200AsiaHebron,
        [EnumMember(Value = "(GMT+02:00) Europe/Bucharest")]
        Gmt0200EuropeBucharest,
        [EnumMember(Value = "(GMT+02:00) Europe/Kaliningrad")]
        Gmt0200EuropeKaliningrad,
        [EnumMember(Value = "(GMT+02:00) Africa/Kigali")]
        Gmt0200AfricaKigali,
        [EnumMember(Value = "(GMT+02:00) Africa/Johannesburg")]
        Gmt0200AfricaJohannesburg,
        [EnumMember(Value = "(GMT+02:00) Africa/Mbabane")]
        Gmt0200AfricaMbabane,
        [EnumMember(Value = "(GMT+02:00) Asia/Damascus")]
        Gmt0200AsiaDamascus,
        [EnumMember(Value = "(GMT+02:00) Europe/Istanbul")]
        Gmt0200EuropeIstanbul,
        [EnumMember(Value = "(GMT+02:00) Europe/Kiev")]
        Gmt0200EuropeKiev,
        [EnumMember(Value = "(GMT+02:00) Europe/Uzhgorod")]
        Gmt0200EuropeUzhgorod,
        [EnumMember(Value = "(GMT+02:00) Europe/Zaporozhye")]
        Gmt0200EuropeZaporozhye,
        [EnumMember(Value = "(GMT+02:00) Africa/Lusaka")]
        Gmt0200AfricaLusaka,
        [EnumMember(Value = "(GMT+02:00) Africa/Harare")]
        Gmt0200AfricaHarare,
        [EnumMember(Value = "(GMT+02:00) Europe/Mariehamn")]
        Gmt0200EuropeMariehamn,
        [EnumMember(Value = "(GMT+03:00) Antarctica/Syowa")]
        Gmt0300AntarcticaSyowa,
        [EnumMember(Value = "(GMT+03:00) Asia/Bahrain")]
        Gmt0300AsiaBahrain,
        [EnumMember(Value = "(GMT+03:00) Europe/Minsk")]
        Gmt0300EuropeMinsk,
        [EnumMember(Value = "(GMT+03:00) Indian/Comoro")]
        Gmt0300IndianComoro,
        [EnumMember(Value = "(GMT+03:00) Africa/Djibouti")]
        Gmt0300AfricaDjibouti,
        [EnumMember(Value = "(GMT+03:00) Africa/Asmara")]
        Gmt0300AfricaAsmara,
        [EnumMember(Value = "(GMT+03:00) Africa/Addis_Ababa")]
        Gmt0300AfricaAddisAbaba,
        [EnumMember(Value = "(GMT+03:00) Asia/Baghdad")]
        Gmt0300AsiaBaghdad,
        [EnumMember(Value = "(GMT+03:00) Africa/Nairobi")]
        Gmt0300AfricaNairobi,
        [EnumMember(Value = "(GMT+03:00) Asia/Kuwait")]
        Gmt0300AsiaKuwait,
        [EnumMember(Value = "(GMT+03:00) Indian/Antananarivo")]
        Gmt0300IndianAntananarivo,
        [EnumMember(Value = "(GMT+03:00) Indian/Mayotte")]
        Gmt0300IndianMayotte,
        [EnumMember(Value = "(GMT+03:00) Asia/Qatar")]
        Gmt0300AsiaQatar,
        [EnumMember(Value = "(GMT+03:00) Europe/Moscow")]
        Gmt0300EuropeMoscow,
        [EnumMember(Value = "(GMT+03:00) Europe/Simferopol")]
        Gmt0300EuropeSimferopol,
        [EnumMember(Value = "(GMT+03:00) Europe/Volgograd")]
        Gmt0300EuropeVolgograd,
        [EnumMember(Value = "(GMT+03:00) Asia/Riyadh")]
        Gmt0300AsiaRiyadh,
        [EnumMember(Value = "(GMT+03:00) Africa/Mogadishu")]
        Gmt0300AfricaMogadishu,
        [EnumMember(Value = "(GMT+03:00) Africa/Juba")]
        Gmt0300AfricaJuba,
        [EnumMember(Value = "(GMT+03:00) Africa/Khartoum")]
        Gmt0300AfricaKhartoum,
        [EnumMember(Value = "(GMT+03:00) Africa/Dar_es_Salaam")]
        Gmt0300AfricaDarEsSalaam,
        [EnumMember(Value = "(GMT+03:00) Africa/Kampala")]
        Gmt0300AfricaKampala,
        [EnumMember(Value = "(GMT+03:00) Asia/Aden")]
        Gmt0300AsiaAden,
        [EnumMember(Value = "(GMT+04:00) Asia/Yerevan")]
        Gmt0400AsiaYerevan,
        [EnumMember(Value = "(GMT+04:00) Asia/Baku")]
        Gmt0400AsiaBaku,
        [EnumMember(Value = "(GMT+04:00) Asia/Tbilisi")]
        Gmt0400AsiaTbilisi,
        [EnumMember(Value = "(GMT+04:00) Indian/Mauritius")]
        Gmt0400IndianMauritius,
        [EnumMember(Value = "(GMT+04:00) Asia/Muscat")]
        Gmt0400AsiaMuscat,
        [EnumMember(Value = "(GMT+04:00) Europe/Samara")]
        Gmt0400EuropeSamara,
        [EnumMember(Value = "(GMT+04:00) Indian/Reunion")]
        Gmt0400IndianReunion,
        [EnumMember(Value = "(GMT+04:00) Indian/Mahe")]
        Gmt0400IndianMahe,
        [EnumMember(Value = "(GMT+04:00) Asia/Dubai")]
        Gmt0400AsiaDubai,
        [EnumMember(Value = "(GMT+04:30) Asia/Kabul")]
        Gmt0430AsiaKabul,
        [EnumMember(Value = "(GMT+04:30) Asia/Tehran")]
        Gmt0430AsiaTehran,
        [EnumMember(Value = "(GMT+05:00) Antarctica/Mawson")]
        Gmt0500AntarcticaMawson,
        [EnumMember(Value = "(GMT+05:00) Indian/Kerguelen")]
        Gmt0500IndianKerguelen,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtau")]
        Gmt0500AsiaAqtau,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtobe")]
        Gmt0500AsiaAqtobe,
        [EnumMember(Value = "(GMT+05:00) Asia/Oral")]
        Gmt0500AsiaOral,
        [EnumMember(Value = "(GMT+05:00) Indian/Maldives")]
        Gmt0500IndianMaldives,
        [EnumMember(Value = "(GMT+05:00) Asia/Karachi")]
        Gmt0500AsiaKarachi,
        [EnumMember(Value = "(GMT+05:00) Asia/Yekaterinburg")]
        Gmt0500AsiaYekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Asia/Dushanbe")]
        Gmt0500AsiaDushanbe,
        [EnumMember(Value = "(GMT+05:00) Asia/Ashgabat")]
        Gmt0500AsiaAshgabat,
        [EnumMember(Value = "(GMT+05:00) Asia/Samarkand")]
        Gmt0500AsiaSamarkand,
        [EnumMember(Value = "(GMT+05:00) Asia/Tashkent")]
        Gmt0500AsiaTashkent,
        [EnumMember(Value = "(GMT+05:30) Asia/Kolkata")]
        Gmt0530AsiaKolkata,
        [EnumMember(Value = "(GMT+05:30) Asia/Colombo")]
        Gmt0530AsiaColombo,
        [EnumMember(Value = "(GMT+05:45) Asia/Kathmandu")]
        Gmt0545AsiaKathmandu,
        [EnumMember(Value = "(GMT+06:00) Antarctica/Vostok")]
        Gmt0600AntarcticaVostok,
        [EnumMember(Value = "(GMT+06:00) Asia/Dhaka")]
        Gmt0600AsiaDhaka,
        [EnumMember(Value = "(GMT+06:00) Asia/Thimphu")]
        Gmt0600AsiaThimphu,
        [EnumMember(Value = "(GMT+06:00) Indian/Chagos")]
        Gmt0600IndianChagos,
        [EnumMember(Value = "(GMT+06:00) Asia/Urumqi")]
        Gmt0600AsiaUrumqi,
        [EnumMember(Value = "(GMT+06:00) Asia/Almaty")]
        Gmt0600AsiaAlmaty,
        [EnumMember(Value = "(GMT+06:00) Asia/Qyzylorda")]
        Gmt0600AsiaQyzylorda,
        [EnumMember(Value = "(GMT+06:00) Asia/Bishkek")]
        Gmt0600AsiaBishkek,
        [EnumMember(Value = "(GMT+06:00) Asia/Novosibirsk")]
        Gmt0600AsiaNovosibirsk,
        [EnumMember(Value = "(GMT+06:00) Asia/Omsk")]
        Gmt0600AsiaOmsk,
        [EnumMember(Value = "(GMT+06:30) Indian/Cocos")]
        Gmt0630IndianCocos,
        [EnumMember(Value = "(GMT+06:30) Asia/Rangoon")]
        Gmt0630AsiaRangoon,
        [EnumMember(Value = "(GMT+07:00) Antarctica/Davis")]
        Gmt0700AntarcticaDavis,
        [EnumMember(Value = "(GMT+07:00) Asia/Phnom_Penh")]
        Gmt0700AsiaPhnomPenh,
        [EnumMember(Value = "(GMT+07:00) Indian/Christmas")]
        Gmt0700IndianChristmas,
        [EnumMember(Value = "(GMT+07:00) Asia/Jakarta")]
        Gmt0700AsiaJakarta,
        [EnumMember(Value = "(GMT+07:00) Asia/Pontianak")]
        Gmt0700AsiaPontianak,
        [EnumMember(Value = "(GMT+07:00) Asia/Vientiane")]
        Gmt0700AsiaVientiane,
        [EnumMember(Value = "(GMT+07:00) Asia/Hovd")]
        Gmt0700AsiaHovd,
        [EnumMember(Value = "(GMT+07:00) Asia/Krasnoyarsk")]
        Gmt0700AsiaKrasnoyarsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Novokuznetsk")]
        Gmt0700AsiaNovokuznetsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Bangkok")]
        Gmt0700AsiaBangkok,
        [EnumMember(Value = "(GMT+07:00) Asia/Ho_Chi_Minh")]
        Gmt0700AsiaHoChiMinh,
        [EnumMember(Value = "(GMT+08:00) Antarctica/Casey")]
        Gmt0800AntarcticaCasey,
        [EnumMember(Value = "(GMT+08:00) Australia/Perth")]
        Gmt0800AustraliaPerth,
        [EnumMember(Value = "(GMT+08:00) Asia/Brunei")]
        Gmt0800AsiaBrunei,
        [EnumMember(Value = "(GMT+08:00) Asia/Shanghai")]
        Gmt0800AsiaShanghai,
        [EnumMember(Value = "(GMT+08:00) Asia/Hong_Kong")]
        Gmt0800AsiaHongKong,
        [EnumMember(Value = "(GMT+08:00) Asia/Makassar")]
        Gmt0800AsiaMakassar,
        [EnumMember(Value = "(GMT+08:00) Asia/Macau")]
        Gmt0800AsiaMacau,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuala_Lumpur")]
        Gmt0800AsiaKualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuching")]
        Gmt0800AsiaKuching,
        [EnumMember(Value = "(GMT+08:00) Asia/Choibalsan")]
        Gmt0800AsiaChoibalsan,
        [EnumMember(Value = "(GMT+08:00) Asia/Ulaanbaatar")]
        Gmt0800AsiaUlaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Asia/Manila")]
        Gmt0800AsiaManila,
        [EnumMember(Value = "(GMT+08:00) Asia/Chita")]
        Gmt0800AsiaChita,
        [EnumMember(Value = "(GMT+08:00) Asia/Irkutsk")]
        Gmt0800AsiaIrkutsk,
        [EnumMember(Value = "(GMT+08:00) Asia/Singapore")]
        Gmt0800AsiaSingapore,
        [EnumMember(Value = "(GMT+08:00) Asia/Taipei")]
        Gmt0800AsiaTaipei,
        [EnumMember(Value = "(GMT+08:45) Australia/Eucla")]
        Gmt0845AustraliaEucla,
        [EnumMember(Value = "(GMT+09:00) Asia/Jayapura")]
        Gmt0900AsiaJayapura,
        [EnumMember(Value = "(GMT+09:00) Asia/Tokyo")]
        Gmt0900AsiaTokyo,
        [EnumMember(Value = "(GMT+09:00) Asia/Pyongyang")]
        Gmt0900AsiaPyongyang,
        [EnumMember(Value = "(GMT+09:00) Asia/Seoul")]
        Gmt0900AsiaSeoul,
        [EnumMember(Value = "(GMT+09:00) Pacific/Palau")]
        Gmt0900PacificPalau,
        [EnumMember(Value = "(GMT+09:00) Asia/Khandyga")]
        Gmt0900AsiaKhandyga,
        [EnumMember(Value = "(GMT+09:00) Asia/Yakutsk")]
        Gmt0900AsiaYakutsk,
        [EnumMember(Value = "(GMT+09:00) Asia/Dili")]
        Gmt0900AsiaDili,
        [EnumMember(Value = "(GMT+09:30) Australia/Darwin")]
        Gmt0930AustraliaDarwin,
        [EnumMember(Value = "(GMT+10:00) Antarctica/DumontDUrville")]
        Gmt1000AntarcticaDumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Australia/Brisbane")]
        Gmt1000AustraliaBrisbane,
        [EnumMember(Value = "(GMT+10:00) Australia/Lindeman")]
        Gmt1000AustraliaLindeman,
        [EnumMember(Value = "(GMT+10:00) Pacific/Guam")]
        Gmt1000PacificGuam,
        [EnumMember(Value = "(GMT+10:00) Pacific/Chuuk")]
        Gmt1000PacificChuuk,
        [EnumMember(Value = "(GMT+10:00) Pacific/Saipan")]
        Gmt1000PacificSaipan,
        [EnumMember(Value = "(GMT+10:00) Pacific/Port_Moresby")]
        Gmt1000PacificPortMoresby,
        [EnumMember(Value = "(GMT+10:00) Asia/Magadan")]
        Gmt1000AsiaMagadan,
        [EnumMember(Value = "(GMT+10:00) Asia/Sakhalin")]
        Gmt1000AsiaSakhalin,
        [EnumMember(Value = "(GMT+10:00) Asia/Ust-Nera")]
        Gmt1000AsiaUstNera,
        [EnumMember(Value = "(GMT+10:00) Asia/Vladivostok")]
        Gmt1000AsiaVladivostok,
        [EnumMember(Value = "(GMT+10:30) Australia/Adelaide")]
        Gmt1030AustraliaAdelaide,
        [EnumMember(Value = "(GMT+10:30) Australia/Broken_Hill")]
        Gmt1030AustraliaBrokenHill,
        [EnumMember(Value = "(GMT+11:00) Australia/Currie")]
        Gmt1100AustraliaCurrie,
        [EnumMember(Value = "(GMT+11:00) Australia/Hobart")]
        Gmt1100AustraliaHobart,
        [EnumMember(Value = "(GMT+11:00) Australia/Lord_Howe")]
        Gmt1100AustraliaLordHowe,
        [EnumMember(Value = "(GMT+11:00) Antarctica/Macquarie")]
        Gmt1100AntarcticaMacquarie,
        [EnumMember(Value = "(GMT+11:00) Australia/Melbourne")]
        Gmt1100AustraliaMelbourne,
        [EnumMember(Value = "(GMT+11:00) Australia/Sydney")]
        Gmt1100AustraliaSydney,
        [EnumMember(Value = "(GMT+11:00) Pacific/Kosrae")]
        Gmt1100PacificKosrae,
        [EnumMember(Value = "(GMT+11:00) Pacific/Pohnpei")]
        Gmt1100PacificPohnpei,
        [EnumMember(Value = "(GMT+11:00) Pacific/Noumea")]
        Gmt1100PacificNoumea,
        [EnumMember(Value = "(GMT+11:00) Pacific/Bougainville")]
        Gmt1100PacificBougainville,
        [EnumMember(Value = "(GMT+11:00) Asia/Srednekolymsk")]
        Gmt1100AsiaSrednekolymsk,
        [EnumMember(Value = "(GMT+11:00) Pacific/Guadalcanal")]
        Gmt1100PacificGuadalcanal,
        [EnumMember(Value = "(GMT+11:00) Pacific/Efate")]
        Gmt1100PacificEfate,
        [EnumMember(Value = "(GMT+11:30) Pacific/Norfolk")]
        Gmt1130PacificNorfolk,
        [EnumMember(Value = "(GMT+12:00) Pacific/Fiji")]
        Gmt1200PacificFiji,
        [EnumMember(Value = "(GMT+12:00) Pacific/Tarawa")]
        Gmt1200PacificTarawa,
        [EnumMember(Value = "(GMT+12:00) Pacific/Kwajalein")]
        Gmt1200PacificKwajalein,
        [EnumMember(Value = "(GMT+12:00) Pacific/Majuro")]
        Gmt1200PacificMajuro,
        [EnumMember(Value = "(GMT+12:00) Pacific/Nauru")]
        Gmt1200PacificNauru,
        [EnumMember(Value = "(GMT+12:00) Asia/Anadyr")]
        Gmt1200AsiaAnadyr,
        [EnumMember(Value = "(GMT+12:00) Asia/Kamchatka")]
        Gmt1200AsiaKamchatka,
        [EnumMember(Value = "(GMT+12:00) Pacific/Funafuti")]
        Gmt1200PacificFunafuti,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wake")]
        Gmt1200PacificWake,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wallis")]
        Gmt1200PacificWallis,
        [EnumMember(Value = "(GMT+13:00) Antarctica/McMurdo")]
        Gmt1300AntarcticaMcMurdo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Enderbury")]
        Gmt1300PacificEnderbury,
        [EnumMember(Value = "(GMT+13:00) Pacific/Auckland")]
        Gmt1300PacificAuckland,
        [EnumMember(Value = "(GMT+13:00) Pacific/Fakaofo")]
        Gmt1300PacificFakaofo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Tongatapu")]
        Gmt1300PacificTongatapu,
        [EnumMember(Value = "(GMT+13:45) Pacific/Chatham")]
        Gmt1345PacificChatham,
        [EnumMember(Value = "(GMT+14:00) Pacific/Kiritimati")]
        Gmt1400PacificKiritimati,
        [EnumMember(Value = "(GMT+14:00) Pacific/Apia")]
        Gmt1400PacificApia
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConditionInput
    {
        Any,
        [EnumMember(Value = "Greater than")]
        GreaterThan,
        [EnumMember(Value = "Less than")]
        LessThan,
        [EnumMember(Value = "Equal to")]
        EqualTo,
        [EnumMember(Value = "Different from")]
        DifferentFrom
    }

    public class DataTriggerBodyInput
    {
        [JsonProperty("config", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigType Config { get; set; } = new BodyInputConfigType();
    }

    public class BodyInputConfigType
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tago;

    public partial class WorkflowManagedActions
    {
        public TagoActions Tago(string connectionId) => new TagoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TagoTriggers Tago(string connectionId) => new TagoTriggers(connectionId);
    }
}