//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tago
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TagoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tago")]
        [WorkflowExpressionFactory(nameof(__BuildGetData))]
        public IBodyWorkflowAction<JToken> GetData([WorkflowExpression] Func<string> device, [WorkflowExpression] Func<string> variable, [WorkflowExpression] Func<queryInput> query = null, [WorkflowExpression] Func<int> qty = null, [WorkflowExpression] Func<timezoneInput> timezone = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> serie = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetData(WorkflowValue<string> device, WorkflowValue<string> variable, WorkflowValue<queryInput> query = null, WorkflowValue<int> qty = null, WorkflowValue<timezoneInput> timezone = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> serie = null)
        {
            WorkflowValue.Validate(device, nameof(device), required: true);
            WorkflowValue.Validate(variable, nameof(variable), required: true);
            WorkflowValue.Validate(query, nameof(query), required: false);
            WorkflowValue.Validate(qty, nameof(qty), required: false);
            WorkflowValue.Validate(timezone, nameof(timezone), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(serie, nameof(serie), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/prod/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["device"] = ExpressionConverter.Convert(device);
                callPayload.Queries["variable"] = ExpressionConverter.Convert(variable);
                callPayload.Queries["query"] = Convert.ToString("last_item");
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (qty != null)
                    callPayload.Queries["qty"] = ExpressionConverter.Convert(qty);
                callPayload.Queries["timezone"] = Convert.ToString("(GMT+00:00) UTC");
                if (timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(timezone);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (serie != null)
                    callPayload.Queries["serie"] = ExpressionConverter.Convert(serie);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tago")]
        [WorkflowExpressionFactory(nameof(__BuildPostData))]
        public IBodyWorkflowAction<PostDataResponse> PostData([WorkflowExpression] Func<string> bodydeviceId, [WorkflowExpression] Func<string> bodyvariable, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodytimezoneInput> bodytimezone = null, [WorkflowExpression] Func<string> bodytimestamp = null, [WorkflowExpression] Func<string> bodyserie = null, [WorkflowExpression] Func<string> bodyunit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostDataResponse> __BuildPostData(WorkflowValue<string> bodydeviceId, WorkflowValue<string> bodyvariable, WorkflowValue<string> bodyvalue, WorkflowValue<bodytimezoneInput> bodytimezone = null, WorkflowValue<string> bodytimestamp = null, WorkflowValue<string> bodyserie = null, WorkflowValue<string> bodyunit = null)
        {
            WorkflowValue.Validate(bodydeviceId, nameof(bodydeviceId), required: true);
            WorkflowValue.Validate(bodyvariable, nameof(bodyvariable), required: true);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowValue.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowValue.Validate(bodytimestamp, nameof(bodytimestamp), required: false);
            WorkflowValue.Validate(bodyserie, nameof(bodyserie), required: false);
            WorkflowValue.Validate(bodyunit, nameof(bodyunit), required: false);
            return new DeferredBodyAction<PostDataResponse>(() =>
            {
                var apiCallPath = "/prod/data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["device"] = ExpressionConverter.ConvertO(bodydeviceId);
                bodypropCount++;
                body["variable"] = ExpressionConverter.ConvertO(bodyvariable);
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                if (bodytimezone != null)
                {
                    if (bodytimezone != null)
                    {
                        body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["timezone"] = "(GMT+00:00) UTC";
                    bodypropCount++;
                }

                if (bodytimestamp != null)
                {
                    body["time"] = ExpressionConverter.ConvertO(bodytimestamp);
                    bodypropCount++;
                }

                if (bodyserie != null)
                {
                    body["serie"] = ExpressionConverter.ConvertO(bodyserie);
                    bodypropCount++;
                }

                if (bodyunit != null)
                {
                    body["unit"] = ExpressionConverter.ConvertO(bodyunit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostDataResponse>(callPayload);
            });
        }
    }

    public class TagoTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildDataTrigger))]
        public IBodyWorkflowTrigger<PostDataResponse> DataTrigger([WorkflowExpression] Func<string> device, [WorkflowExpression] Func<string> variable, [WorkflowExpression] Func<conditionInput> condition, [WorkflowExpression] Func<string> value = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PostDataResponse> __BuildDataTrigger(WorkflowValue<string> device, WorkflowValue<string> variable, WorkflowValue<conditionInput> condition, WorkflowValue<string> value = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(device, nameof(device), required: true);
            WorkflowValue.Validate(variable, nameof(variable), required: true);
            WorkflowValue.Validate(condition, nameof(condition), required: true);
            WorkflowValue.Validate(value, nameof(value), required: false);
            return new DeferredBodyTrigger<PostDataResponse>(() =>
            {
                var apiCallPath = "/prod/flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["device"] = ExpressionConverter.Convert(device);
                callPayload.Queries["variable"] = ExpressionConverter.Convert(variable);
                callPayload.Queries["condition"] = ExpressionConverter.Convert(condition);
                if (value != null)
                    callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                var body = new JObject();
                var bodypropCount = 0;
                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["callback"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    body["config"] = configObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<PostDataResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public enum queryInput
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

    public enum timezoneInput
    {
        [EnumMember(Value = "(GMT+00:00) UTC")]
        GMT0000UTC,
        [EnumMember(Value = "(GMT-11:00) Pacific/Pago_Pago")]
        GMT1100PacificPagoPago,
        [EnumMember(Value = "(GMT-11:00) Pacific/Niue")]
        GMT1100PacificNiue,
        [EnumMember(Value = "(GMT-11:00) Pacific/Midway")]
        GMT1100PacificMidway,
        [EnumMember(Value = "(GMT-10:00) Pacific/Rarotonga")]
        GMT1000PacificRarotonga,
        [EnumMember(Value = "(GMT-10:00) Pacific/Tahiti")]
        GMT1000PacificTahiti,
        [EnumMember(Value = "(GMT-10:00) Pacific/Honolulu")]
        GMT1000PacificHonolulu,
        [EnumMember(Value = "(GMT-10:00) Pacific/Johnston")]
        GMT1000PacificJohnston,
        [EnumMember(Value = "(GMT-09:30) Pacific/Marquesas")]
        GMT0930PacificMarquesas,
        [EnumMember(Value = "(GMT-09:00) Pacific/Gambier")]
        GMT0900PacificGambier,
        [EnumMember(Value = "(GMT-09:00) America/Adak")]
        GMT0900AmericaAdak,
        [EnumMember(Value = "(GMT-08:00) America/Santa_Isabel")]
        GMT0800AmericaSantaIsabel,
        [EnumMember(Value = "(GMT-08:00) Pacific/Pitcairn")]
        GMT0800PacificPitcairn,
        [EnumMember(Value = "(GMT-08:00) America/Anchorage")]
        GMT0800AmericaAnchorage,
        [EnumMember(Value = "(GMT-08:00) America/Juneau")]
        GMT0800AmericaJuneau,
        [EnumMember(Value = "(GMT-08:00) America/Metlakatla")]
        GMT0800AmericaMetlakatla,
        [EnumMember(Value = "(GMT-08:00) America/Nome")]
        GMT0800AmericaNome,
        [EnumMember(Value = "(GMT-08:00) America/Sitka")]
        GMT0800AmericaSitka,
        [EnumMember(Value = "(GMT-08:00) America/Yakutat")]
        GMT0800AmericaYakutat,
        [EnumMember(Value = "(GMT-07:00) America/Creston")]
        GMT0700AmericaCreston,
        [EnumMember(Value = "(GMT-07:00) America/Dawson")]
        GMT0700AmericaDawson,
        [EnumMember(Value = "(GMT-07:00) America/Dawson_Creek")]
        GMT0700AmericaDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) America/Vancouver")]
        GMT0700AmericaVancouver,
        [EnumMember(Value = "(GMT-07:00) America/Whitehorse")]
        GMT0700AmericaWhitehorse,
        [EnumMember(Value = "(GMT-07:00) America/Chihuahua")]
        GMT0700AmericaChihuahua,
        [EnumMember(Value = "(GMT-07:00) America/Hermosillo")]
        GMT0700AmericaHermosillo,
        [EnumMember(Value = "(GMT-07:00) America/Mazatlan")]
        GMT0700AmericaMazatlan,
        [EnumMember(Value = "(GMT-07:00) America/Tijuana")]
        GMT0700AmericaTijuana,
        [EnumMember(Value = "(GMT-07:00) America/Los_Angeles")]
        GMT0700AmericaLosAngeles,
        [EnumMember(Value = "(GMT-07:00) America/Phoenix")]
        GMT0700AmericaPhoenix,
        [EnumMember(Value = "(GMT-06:00) America/Belize")]
        GMT0600AmericaBelize,
        [EnumMember(Value = "(GMT-06:00) America/Cambridge_Bay")]
        GMT0600AmericaCambridgeBay,
        [EnumMember(Value = "(GMT-06:00) America/Edmonton")]
        GMT0600AmericaEdmonton,
        [EnumMember(Value = "(GMT-06:00) America/Inuvik")]
        GMT0600AmericaInuvik,
        [EnumMember(Value = "(GMT-06:00) America/Regina")]
        GMT0600AmericaRegina,
        [EnumMember(Value = "(GMT-06:00) America/Swift_Current")]
        GMT0600AmericaSwiftCurrent,
        [EnumMember(Value = "(GMT-06:00) America/Yellowknife")]
        GMT0600AmericaYellowknife,
        [EnumMember(Value = "(GMT-06:00) America/Costa_Rica")]
        GMT0600AmericaCostaRica,
        [EnumMember(Value = "(GMT-06:00) Pacific/Galapagos")]
        GMT0600PacificGalapagos,
        [EnumMember(Value = "(GMT-06:00) America/El_Salvador")]
        GMT0600AmericaElSalvador,
        [EnumMember(Value = "(GMT-06:00) America/Guatemala")]
        GMT0600AmericaGuatemala,
        [EnumMember(Value = "(GMT-06:00) America/Tegucigalpa")]
        GMT0600AmericaTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) America/Bahia_Banderas")]
        GMT0600AmericaBahiaBanderas,
        [EnumMember(Value = "(GMT-06:00) America/Cancun")]
        GMT0600AmericaCancun,
        [EnumMember(Value = "(GMT-06:00) America/Merida")]
        GMT0600AmericaMerida,
        [EnumMember(Value = "(GMT-06:00) America/Mexico_City")]
        GMT0600AmericaMexicoCity,
        [EnumMember(Value = "(GMT-06:00) America/Monterrey")]
        GMT0600AmericaMonterrey,
        [EnumMember(Value = "(GMT-06:00) America/Ojinaga")]
        GMT0600AmericaOjinaga,
        [EnumMember(Value = "(GMT-06:00) America/Managua")]
        GMT0600AmericaManagua,
        [EnumMember(Value = "(GMT-06:00) America/Boise")]
        GMT0600AmericaBoise,
        [EnumMember(Value = "(GMT-06:00) America/Denver")]
        GMT0600AmericaDenver,
        [EnumMember(Value = "(GMT-05:00) America/Eirunepe")]
        GMT0500AmericaEirunepe,
        [EnumMember(Value = "(GMT-05:00) America/Rio_Branco")]
        GMT0500AmericaRioBranco,
        [EnumMember(Value = "(GMT-05:00) America/Atikokan")]
        GMT0500AmericaAtikokan,
        [EnumMember(Value = "(GMT-05:00) America/Rainy_River")]
        GMT0500AmericaRainyRiver,
        [EnumMember(Value = "(GMT-05:00) America/Rankin_Inlet")]
        GMT0500AmericaRankinInlet,
        [EnumMember(Value = "(GMT-05:00) America/Resolute")]
        GMT0500AmericaResolute,
        [EnumMember(Value = "(GMT-05:00) America/Winnipeg")]
        GMT0500AmericaWinnipeg,
        [EnumMember(Value = "(GMT-05:00) America/Cayman")]
        GMT0500AmericaCayman,
        [EnumMember(Value = "(GMT-05:00) Pacific/Easter")]
        GMT0500PacificEaster,
        [EnumMember(Value = "(GMT-05:00) America/Bogota")]
        GMT0500AmericaBogota,
        [EnumMember(Value = "(GMT-05:00) America/Guayaquil")]
        GMT0500AmericaGuayaquil,
        [EnumMember(Value = "(GMT-05:00) America/Jamaica")]
        GMT0500AmericaJamaica,
        [EnumMember(Value = "(GMT-05:00) America/Matamoros")]
        GMT0500AmericaMatamoros,
        [EnumMember(Value = "(GMT-05:00) America/Panama")]
        GMT0500AmericaPanama,
        [EnumMember(Value = "(GMT-05:00) America/Lima")]
        GMT0500AmericaLima,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Beulah")]
        GMT0500AmericaNorthDakotaBeulah,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Center")]
        GMT0500AmericaNorthDakotaCenter,
        [EnumMember(Value = "(GMT-05:00) America/Chicago")]
        GMT0500AmericaChicago,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Knox")]
        GMT0500AmericaIndianaKnox,
        [EnumMember(Value = "(GMT-05:00) America/Menominee")]
        GMT0500AmericaMenominee,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/New_Salem")]
        GMT0500AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Tell_City")]
        GMT0500AmericaIndianaTellCity,
        [EnumMember(Value = "(GMT-04:30) America/Caracas")]
        GMT0430AmericaCaracas,
        [EnumMember(Value = "(GMT-04:00) America/Anguilla")]
        GMT0400AmericaAnguilla,
        [EnumMember(Value = "(GMT-04:00) America/Antigua")]
        GMT0400AmericaAntigua,
        [EnumMember(Value = "(GMT-04:00) America/Aruba")]
        GMT0400AmericaAruba,
        [EnumMember(Value = "(GMT-04:00) America/Nassau")]
        GMT0400AmericaNassau,
        [EnumMember(Value = "(GMT-04:00) America/Barbados")]
        GMT0400AmericaBarbados,
        [EnumMember(Value = "(GMT-04:00) America/La_Paz")]
        GMT0400AmericaLaPaz,
        [EnumMember(Value = "(GMT-04:00) America/Kralendijk")]
        GMT0400AmericaKralendijk,
        [EnumMember(Value = "(GMT-04:00) America/Boa_Vista")]
        GMT0400AmericaBoaVista,
        [EnumMember(Value = "(GMT-04:00) America/Campo_Grande")]
        GMT0400AmericaCampoGrande,
        [EnumMember(Value = "(GMT-04:00) America/Cuiaba")]
        GMT0400AmericaCuiaba,
        [EnumMember(Value = "(GMT-04:00) America/Manaus")]
        GMT0400AmericaManaus,
        [EnumMember(Value = "(GMT-04:00) America/Porto_Velho")]
        GMT0400AmericaPortoVelho,
        [EnumMember(Value = "(GMT-04:00) America/Blanc-Sablon")]
        GMT0400AmericaBlancSablon,
        [EnumMember(Value = "(GMT-04:00) America/Iqaluit")]
        GMT0400AmericaIqaluit,
        [EnumMember(Value = "(GMT-04:00) America/Nipigon")]
        GMT0400AmericaNipigon,
        [EnumMember(Value = "(GMT-04:00) America/Pangnirtung")]
        GMT0400AmericaPangnirtung,
        [EnumMember(Value = "(GMT-04:00) America/Thunder_Bay")]
        GMT0400AmericaThunderBay,
        [EnumMember(Value = "(GMT-04:00) America/Toronto")]
        GMT0400AmericaToronto,
        [EnumMember(Value = "(GMT-04:00) America/Havana")]
        GMT0400AmericaHavana,
        [EnumMember(Value = "(GMT-04:00) America/Curacao")]
        GMT0400AmericaCuracao,
        [EnumMember(Value = "(GMT-04:00) America/Dominica")]
        GMT0400AmericaDominica,
        [EnumMember(Value = "(GMT-04:00) America/Santo_Domingo")]
        GMT0400AmericaSantoDomingo,
        [EnumMember(Value = "(GMT-04:00) America/Grenada")]
        GMT0400AmericaGrenada,
        [EnumMember(Value = "(GMT-04:00) America/Guadeloupe")]
        GMT0400AmericaGuadeloupe,
        [EnumMember(Value = "(GMT-04:00) America/Guyana")]
        GMT0400AmericaGuyana,
        [EnumMember(Value = "(GMT-04:00) America/Port-au-Prince")]
        GMT0400AmericaPortAuPrince,
        [EnumMember(Value = "(GMT-04:00) America/Martinique")]
        GMT0400AmericaMartinique,
        [EnumMember(Value = "(GMT-04:00) America/Montserrat")]
        GMT0400AmericaMontserrat,
        [EnumMember(Value = "(GMT-04:00) America/Asuncion")]
        GMT0400AmericaAsuncion,
        [EnumMember(Value = "(GMT-04:00) America/Puerto_Rico")]
        GMT0400AmericaPuertoRico,
        [EnumMember(Value = "(GMT-04:00) America/St_Barthelemy")]
        GMT0400AmericaStBarthelemy,
        [EnumMember(Value = "(GMT-04:00) America/St_Kitts")]
        GMT0400AmericaStKitts,
        [EnumMember(Value = "(GMT-04:00) America/St_Lucia")]
        GMT0400AmericaStLucia,
        [EnumMember(Value = "(GMT-04:00) America/Marigot")]
        GMT0400AmericaMarigot,
        [EnumMember(Value = "(GMT-04:00) America/St_Vincent")]
        GMT0400AmericaStVincent,
        [EnumMember(Value = "(GMT-04:00) America/Lower_Princes")]
        GMT0400AmericaLowerPrinces,
        [EnumMember(Value = "(GMT-04:00) America/Port_of_Spain")]
        GMT0400AmericaPortOfSpain,
        [EnumMember(Value = "(GMT-04:00) America/Grand_Turk")]
        GMT0400AmericaGrandTurk,
        [EnumMember(Value = "(GMT-04:00) America/Detroit")]
        GMT0400AmericaDetroit,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Indianapolis")]
        GMT0400AmericaIndianaIndianapolis,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Louisville")]
        GMT0400AmericaKentuckyLouisville,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Marengo")]
        GMT0400AmericaIndianaMarengo,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Monticello")]
        GMT0400AmericaKentuckyMonticello,
        [EnumMember(Value = "(GMT-04:00) America/New_York")]
        GMT0400AmericaNewYork,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Petersburg")]
        GMT0400AmericaIndianaPetersburg,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vevay")]
        GMT0400AmericaIndianaVevay,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vincennes")]
        GMT0400AmericaIndianaVincennes,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Winamac")]
        GMT0400AmericaIndianaWinamac,
        [EnumMember(Value = "(GMT-04:00) America/Tortola")]
        GMT0400AmericaTortola,
        [EnumMember(Value = "(GMT-04:00) America/St_Thomas")]
        GMT0400AmericaStThomas,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Palmer")]
        GMT0300AntarcticaPalmer,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Rothera")]
        GMT0300AntarcticaRothera,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Buenos_Aires")]
        GMT0300AmericaArgentinaBuenosAires,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Catamarca")]
        GMT0300AmericaArgentinaCatamarca,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Cordoba")]
        GMT0300AmericaArgentinaCordoba,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Jujuy")]
        GMT0300AmericaArgentinaJujuy,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/La_Rioja")]
        GMT0300AmericaArgentinaLaRioja,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Mendoza")]
        GMT0300AmericaArgentinaMendoza,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Rio_Gallegos")]
        GMT0300AmericaArgentinaRioGallegos,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Salta")]
        GMT0300AmericaArgentinaSalta,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Juan")]
        GMT0300AmericaArgentinaSanJuan,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Luis")]
        GMT0300AmericaArgentinaSanLuis,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Tucuman")]
        GMT0300AmericaArgentinaTucuman,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Ushuaia")]
        GMT0300AmericaArgentinaUshuaia,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Bermuda")]
        GMT0300AtlanticBermuda,
        [EnumMember(Value = "(GMT-03:00) America/Araguaina")]
        GMT0300AmericaAraguaina,
        [EnumMember(Value = "(GMT-03:00) America/Bahia")]
        GMT0300AmericaBahia,
        [EnumMember(Value = "(GMT-03:00) America/Belem")]
        GMT0300AmericaBelem,
        [EnumMember(Value = "(GMT-03:00) America/Fortaleza")]
        GMT0300AmericaFortaleza,
        [EnumMember(Value = "(GMT-03:00) America/Maceio")]
        GMT0300AmericaMaceio,
        [EnumMember(Value = "(GMT-03:00) America/Recife")]
        GMT0300AmericaRecife,
        [EnumMember(Value = "(GMT-03:00) America/Santarem")]
        GMT0300AmericaSantarem,
        [EnumMember(Value = "(GMT-03:00) America/Sao_Paulo")]
        GMT0300AmericaSaoPaulo,
        [EnumMember(Value = "(GMT-03:00) America/Glace_Bay")]
        GMT0300AmericaGlaceBay,
        [EnumMember(Value = "(GMT-03:00) America/Goose_Bay")]
        GMT0300AmericaGooseBay,
        [EnumMember(Value = "(GMT-03:00) America/Halifax")]
        GMT0300AmericaHalifax,
        [EnumMember(Value = "(GMT-03:00) America/Moncton")]
        GMT0300AmericaMoncton,
        [EnumMember(Value = "(GMT-03:00) America/Santiago")]
        GMT0300AmericaSantiago,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Stanley")]
        GMT0300AtlanticStanley,
        [EnumMember(Value = "(GMT-03:00) America/Cayenne")]
        GMT0300AmericaCayenne,
        [EnumMember(Value = "(GMT-03:00) America/Godthab")]
        GMT0300AmericaGodthab,
        [EnumMember(Value = "(GMT-03:00) America/Thule")]
        GMT0300AmericaThule,
        [EnumMember(Value = "(GMT-03:00) America/Paramaribo")]
        GMT0300AmericaParamaribo,
        [EnumMember(Value = "(GMT-03:00) America/Montevideo")]
        GMT0300AmericaMontevideo,
        [EnumMember(Value = "(GMT-02:30) America/St_Johns")]
        GMT0230AmericaStJohns,
        [EnumMember(Value = "(GMT-02:00) America/Noronha")]
        GMT0200AmericaNoronha,
        [EnumMember(Value = "(GMT-02:00) America/Miquelon")]
        GMT0200AmericaMiquelon,
        [EnumMember(Value = "(GMT-02:00) Atlantic/South_Georgia")]
        GMT0200AtlanticSouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Cape_Verde")]
        GMT0100AtlanticCapeVerde,
        [EnumMember(Value = "(GMT-01:00) America/Scoresbysund")]
        GMT0100AmericaScoresbysund,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Azores")]
        GMT0100AtlanticAzores,
        [EnumMember(Value = "(GMT+00:00) Antarctica/Troll")]
        GMT0000AntarcticaTroll,
        [EnumMember(Value = "(GMT+00:00) Africa/Ouagadougou")]
        GMT0000AfricaOuagadougou,
        [EnumMember(Value = "(GMT+00:00) Africa/Abidjan")]
        GMT0000AfricaAbidjan,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Faroe")]
        GMT0000AtlanticFaroe,
        [EnumMember(Value = "(GMT+00:00) Africa/Banjul")]
        GMT0000AfricaBanjul,
        [EnumMember(Value = "(GMT+00:00) Africa/Accra")]
        GMT0000AfricaAccra,
        [EnumMember(Value = "(GMT+00:00) America/Danmarkshavn")]
        GMT0000AmericaDanmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Europe/Guernsey")]
        GMT0000EuropeGuernsey,
        [EnumMember(Value = "(GMT+00:00) Africa/Conakry")]
        GMT0000AfricaConakry,
        [EnumMember(Value = "(GMT+00:00) Africa/Bissau")]
        GMT0000AfricaBissau,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Reykjavik")]
        GMT0000AtlanticReykjavik,
        [EnumMember(Value = "(GMT+00:00) Europe/Dublin")]
        GMT0000EuropeDublin,
        [EnumMember(Value = "(GMT+00:00) Europe/Isle_of_Man")]
        GMT0000EuropeIsleOfMan,
        [EnumMember(Value = "(GMT+00:00) Europe/Jersey")]
        GMT0000EuropeJersey,
        [EnumMember(Value = "(GMT+00:00) Africa/Monrovia")]
        GMT0000AfricaMonrovia,
        [EnumMember(Value = "(GMT+00:00) Africa/Bamako")]
        GMT0000AfricaBamako,
        [EnumMember(Value = "(GMT+00:00) Africa/Nouakchott")]
        GMT0000AfricaNouakchott,
        [EnumMember(Value = "(GMT+00:00) Africa/Casablanca")]
        GMT0000AfricaCasablanca,
        [EnumMember(Value = "(GMT+00:00) Europe/Lisbon")]
        GMT0000EuropeLisbon,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Madeira")]
        GMT0000AtlanticMadeira,
        [EnumMember(Value = "(GMT+00:00) Atlantic/St_Helena")]
        GMT0000AtlanticStHelena,
        [EnumMember(Value = "(GMT+00:00) Africa/Sao_Tome")]
        GMT0000AfricaSaoTome,
        [EnumMember(Value = "(GMT+00:00) Africa/Dakar")]
        GMT0000AfricaDakar,
        [EnumMember(Value = "(GMT+00:00) Africa/Freetown")]
        GMT0000AfricaFreetown,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Canary")]
        GMT0000AtlanticCanary,
        [EnumMember(Value = "(GMT+00:00) Africa/Lome")]
        GMT0000AfricaLome,
        [EnumMember(Value = "(GMT+00:00) Europe/London")]
        GMT0000EuropeLondon,
        [EnumMember(Value = "(GMT+00:00) Africa/El_Aaiun")]
        GMT0000AfricaElAaiun,
        [EnumMember(Value = "(GMT+01:00) Europe/Tirane")]
        GMT0100EuropeTirane,
        [EnumMember(Value = "(GMT+01:00) Africa/Algiers")]
        GMT0100AfricaAlgiers,
        [EnumMember(Value = "(GMT+01:00) Europe/Andorra")]
        GMT0100EuropeAndorra,
        [EnumMember(Value = "(GMT+01:00) Africa/Luanda")]
        GMT0100AfricaLuanda,
        [EnumMember(Value = "(GMT+01:00) Europe/Vienna")]
        GMT0100EuropeVienna,
        [EnumMember(Value = "(GMT+01:00) Europe/Brussels")]
        GMT0100EuropeBrussels,
        [EnumMember(Value = "(GMT+01:00) Africa/Porto-Novo")]
        GMT0100AfricaPortoNovo,
        [EnumMember(Value = "(GMT+01:00) Europe/Sarajevo")]
        GMT0100EuropeSarajevo,
        [EnumMember(Value = "(GMT+01:00) Africa/Douala")]
        GMT0100AfricaDouala,
        [EnumMember(Value = "(GMT+01:00) Africa/Bangui")]
        GMT0100AfricaBangui,
        [EnumMember(Value = "(GMT+01:00) Africa/Ndjamena")]
        GMT0100AfricaNdjamena,
        [EnumMember(Value = "(GMT+01:00) Africa/Brazzaville")]
        GMT0100AfricaBrazzaville,
        [EnumMember(Value = "(GMT+01:00) Africa/Kinshasa")]
        GMT0100AfricaKinshasa,
        [EnumMember(Value = "(GMT+01:00) Europe/Zagreb")]
        GMT0100EuropeZagreb,
        [EnumMember(Value = "(GMT+01:00) Europe/Prague")]
        GMT0100EuropePrague,
        [EnumMember(Value = "(GMT+01:00) Europe/Copenhagen")]
        GMT0100EuropeCopenhagen,
        [EnumMember(Value = "(GMT+01:00) Africa/Malabo")]
        GMT0100AfricaMalabo,
        [EnumMember(Value = "(GMT+01:00) Europe/Paris")]
        GMT0100EuropeParis,
        [EnumMember(Value = "(GMT+01:00) Africa/Libreville")]
        GMT0100AfricaLibreville,
        [EnumMember(Value = "(GMT+01:00) Europe/Berlin")]
        GMT0100EuropeBerlin,
        [EnumMember(Value = "(GMT+01:00) Europe/Busingen")]
        GMT0100EuropeBusingen,
        [EnumMember(Value = "(GMT+01:00) Europe/Gibraltar")]
        GMT0100EuropeGibraltar,
        [EnumMember(Value = "(GMT+01:00) Europe/Vatican")]
        GMT0100EuropeVatican,
        [EnumMember(Value = "(GMT+01:00) Europe/Budapest")]
        GMT0100EuropeBudapest,
        [EnumMember(Value = "(GMT+01:00) Europe/Rome")]
        GMT0100EuropeRome,
        [EnumMember(Value = "(GMT+01:00) Europe/Vaduz")]
        GMT0100EuropeVaduz,
        [EnumMember(Value = "(GMT+01:00) Europe/Luxembourg")]
        GMT0100EuropeLuxembourg,
        [EnumMember(Value = "(GMT+01:00) Europe/Skopje")]
        GMT0100EuropeSkopje,
        [EnumMember(Value = "(GMT+01:00) Europe/Malta")]
        GMT0100EuropeMalta,
        [EnumMember(Value = "(GMT+01:00) Europe/Monaco")]
        GMT0100EuropeMonaco,
        [EnumMember(Value = "(GMT+01:00) Europe/Podgorica")]
        GMT0100EuropePodgorica,
        [EnumMember(Value = "(GMT+01:00) Europe/Amsterdam")]
        GMT0100EuropeAmsterdam,
        [EnumMember(Value = "(GMT+01:00) Africa/Niamey")]
        GMT0100AfricaNiamey,
        [EnumMember(Value = "(GMT+01:00) Africa/Lagos")]
        GMT0100AfricaLagos,
        [EnumMember(Value = "(GMT+01:00) Europe/Oslo")]
        GMT0100EuropeOslo,
        [EnumMember(Value = "(GMT+01:00) Europe/Warsaw")]
        GMT0100EuropeWarsaw,
        [EnumMember(Value = "(GMT+01:00) Europe/San_Marino")]
        GMT0100EuropeSanMarino,
        [EnumMember(Value = "(GMT+01:00) Europe/Belgrade")]
        GMT0100EuropeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Europe/Bratislava")]
        GMT0100EuropeBratislava,
        [EnumMember(Value = "(GMT+01:00) Europe/Ljubljana")]
        GMT0100EuropeLjubljana,
        [EnumMember(Value = "(GMT+01:00) Africa/Ceuta")]
        GMT0100AfricaCeuta,
        [EnumMember(Value = "(GMT+01:00) Europe/Madrid")]
        GMT0100EuropeMadrid,
        [EnumMember(Value = "(GMT+01:00) Arctic/Longyearbyen")]
        GMT0100ArcticLongyearbyen,
        [EnumMember(Value = "(GMT+01:00) Europe/Stockholm")]
        GMT0100EuropeStockholm,
        [EnumMember(Value = "(GMT+01:00) Europe/Zurich")]
        GMT0100EuropeZurich,
        [EnumMember(Value = "(GMT+01:00) Africa/Tunis")]
        GMT0100AfricaTunis,
        [EnumMember(Value = "(GMT+02:00) Africa/Gaborone")]
        GMT0200AfricaGaborone,
        [EnumMember(Value = "(GMT+02:00) Europe/Sofia")]
        GMT0200EuropeSofia,
        [EnumMember(Value = "(GMT+02:00) Africa/Bujumbura")]
        GMT0200AfricaBujumbura,
        [EnumMember(Value = "(GMT+02:00) Africa/Lubumbashi")]
        GMT0200AfricaLubumbashi,
        [EnumMember(Value = "(GMT+02:00) Asia/Nicosia")]
        GMT0200AsiaNicosia,
        [EnumMember(Value = "(GMT+02:00) Africa/Cairo")]
        GMT0200AfricaCairo,
        [EnumMember(Value = "(GMT+02:00) Europe/Tallinn")]
        GMT0200EuropeTallinn,
        [EnumMember(Value = "(GMT+02:00) Europe/Helsinki")]
        GMT0200EuropeHelsinki,
        [EnumMember(Value = "(GMT+02:00) Europe/Athens")]
        GMT0200EuropeAthens,
        [EnumMember(Value = "(GMT+02:00) Asia/Jerusalem")]
        GMT0200AsiaJerusalem,
        [EnumMember(Value = "(GMT+02:00) Asia/Amman")]
        GMT0200AsiaAmman,
        [EnumMember(Value = "(GMT+02:00) Europe/Riga")]
        GMT0200EuropeRiga,
        [EnumMember(Value = "(GMT+02:00) Asia/Beirut")]
        GMT0200AsiaBeirut,
        [EnumMember(Value = "(GMT+02:00) Africa/Maseru")]
        GMT0200AfricaMaseru,
        [EnumMember(Value = "(GMT+02:00) Africa/Tripoli")]
        GMT0200AfricaTripoli,
        [EnumMember(Value = "(GMT+02:00) Europe/Vilnius")]
        GMT0200EuropeVilnius,
        [EnumMember(Value = "(GMT+02:00) Africa/Blantyre")]
        GMT0200AfricaBlantyre,
        [EnumMember(Value = "(GMT+02:00) Europe/Chisinau")]
        GMT0200EuropeChisinau,
        [EnumMember(Value = "(GMT+02:00) Africa/Maputo")]
        GMT0200AfricaMaputo,
        [EnumMember(Value = "(GMT+02:00) Africa/Windhoek")]
        GMT0200AfricaWindhoek,
        [EnumMember(Value = "(GMT+02:00) Asia/Gaza")]
        GMT0200AsiaGaza,
        [EnumMember(Value = "(GMT+02:00) Asia/Hebron")]
        GMT0200AsiaHebron,
        [EnumMember(Value = "(GMT+02:00) Europe/Bucharest")]
        GMT0200EuropeBucharest,
        [EnumMember(Value = "(GMT+02:00) Europe/Kaliningrad")]
        GMT0200EuropeKaliningrad,
        [EnumMember(Value = "(GMT+02:00) Africa/Kigali")]
        GMT0200AfricaKigali,
        [EnumMember(Value = "(GMT+02:00) Africa/Johannesburg")]
        GMT0200AfricaJohannesburg,
        [EnumMember(Value = "(GMT+02:00) Africa/Mbabane")]
        GMT0200AfricaMbabane,
        [EnumMember(Value = "(GMT+02:00) Asia/Damascus")]
        GMT0200AsiaDamascus,
        [EnumMember(Value = "(GMT+02:00) Europe/Istanbul")]
        GMT0200EuropeIstanbul,
        [EnumMember(Value = "(GMT+02:00) Europe/Kiev")]
        GMT0200EuropeKiev,
        [EnumMember(Value = "(GMT+02:00) Europe/Uzhgorod")]
        GMT0200EuropeUzhgorod,
        [EnumMember(Value = "(GMT+02:00) Europe/Zaporozhye")]
        GMT0200EuropeZaporozhye,
        [EnumMember(Value = "(GMT+02:00) Africa/Lusaka")]
        GMT0200AfricaLusaka,
        [EnumMember(Value = "(GMT+02:00) Africa/Harare")]
        GMT0200AfricaHarare,
        [EnumMember(Value = "(GMT+02:00) Europe/Mariehamn")]
        GMT0200EuropeMariehamn,
        [EnumMember(Value = "(GMT+03:00) Antarctica/Syowa")]
        GMT0300AntarcticaSyowa,
        [EnumMember(Value = "(GMT+03:00) Asia/Bahrain")]
        GMT0300AsiaBahrain,
        [EnumMember(Value = "(GMT+03:00) Europe/Minsk")]
        GMT0300EuropeMinsk,
        [EnumMember(Value = "(GMT+03:00) Indian/Comoro")]
        GMT0300IndianComoro,
        [EnumMember(Value = "(GMT+03:00) Africa/Djibouti")]
        GMT0300AfricaDjibouti,
        [EnumMember(Value = "(GMT+03:00) Africa/Asmara")]
        GMT0300AfricaAsmara,
        [EnumMember(Value = "(GMT+03:00) Africa/Addis_Ababa")]
        GMT0300AfricaAddisAbaba,
        [EnumMember(Value = "(GMT+03:00) Asia/Baghdad")]
        GMT0300AsiaBaghdad,
        [EnumMember(Value = "(GMT+03:00) Africa/Nairobi")]
        GMT0300AfricaNairobi,
        [EnumMember(Value = "(GMT+03:00) Asia/Kuwait")]
        GMT0300AsiaKuwait,
        [EnumMember(Value = "(GMT+03:00) Indian/Antananarivo")]
        GMT0300IndianAntananarivo,
        [EnumMember(Value = "(GMT+03:00) Indian/Mayotte")]
        GMT0300IndianMayotte,
        [EnumMember(Value = "(GMT+03:00) Asia/Qatar")]
        GMT0300AsiaQatar,
        [EnumMember(Value = "(GMT+03:00) Europe/Moscow")]
        GMT0300EuropeMoscow,
        [EnumMember(Value = "(GMT+03:00) Europe/Simferopol")]
        GMT0300EuropeSimferopol,
        [EnumMember(Value = "(GMT+03:00) Europe/Volgograd")]
        GMT0300EuropeVolgograd,
        [EnumMember(Value = "(GMT+03:00) Asia/Riyadh")]
        GMT0300AsiaRiyadh,
        [EnumMember(Value = "(GMT+03:00) Africa/Mogadishu")]
        GMT0300AfricaMogadishu,
        [EnumMember(Value = "(GMT+03:00) Africa/Juba")]
        GMT0300AfricaJuba,
        [EnumMember(Value = "(GMT+03:00) Africa/Khartoum")]
        GMT0300AfricaKhartoum,
        [EnumMember(Value = "(GMT+03:00) Africa/Dar_es_Salaam")]
        GMT0300AfricaDarEsSalaam,
        [EnumMember(Value = "(GMT+03:00) Africa/Kampala")]
        GMT0300AfricaKampala,
        [EnumMember(Value = "(GMT+03:00) Asia/Aden")]
        GMT0300AsiaAden,
        [EnumMember(Value = "(GMT+04:00) Asia/Yerevan")]
        GMT0400AsiaYerevan,
        [EnumMember(Value = "(GMT+04:00) Asia/Baku")]
        GMT0400AsiaBaku,
        [EnumMember(Value = "(GMT+04:00) Asia/Tbilisi")]
        GMT0400AsiaTbilisi,
        [EnumMember(Value = "(GMT+04:00) Indian/Mauritius")]
        GMT0400IndianMauritius,
        [EnumMember(Value = "(GMT+04:00) Asia/Muscat")]
        GMT0400AsiaMuscat,
        [EnumMember(Value = "(GMT+04:00) Europe/Samara")]
        GMT0400EuropeSamara,
        [EnumMember(Value = "(GMT+04:00) Indian/Reunion")]
        GMT0400IndianReunion,
        [EnumMember(Value = "(GMT+04:00) Indian/Mahe")]
        GMT0400IndianMahe,
        [EnumMember(Value = "(GMT+04:00) Asia/Dubai")]
        GMT0400AsiaDubai,
        [EnumMember(Value = "(GMT+04:30) Asia/Kabul")]
        GMT0430AsiaKabul,
        [EnumMember(Value = "(GMT+04:30) Asia/Tehran")]
        GMT0430AsiaTehran,
        [EnumMember(Value = "(GMT+05:00) Antarctica/Mawson")]
        GMT0500AntarcticaMawson,
        [EnumMember(Value = "(GMT+05:00) Indian/Kerguelen")]
        GMT0500IndianKerguelen,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtau")]
        GMT0500AsiaAqtau,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtobe")]
        GMT0500AsiaAqtobe,
        [EnumMember(Value = "(GMT+05:00) Asia/Oral")]
        GMT0500AsiaOral,
        [EnumMember(Value = "(GMT+05:00) Indian/Maldives")]
        GMT0500IndianMaldives,
        [EnumMember(Value = "(GMT+05:00) Asia/Karachi")]
        GMT0500AsiaKarachi,
        [EnumMember(Value = "(GMT+05:00) Asia/Yekaterinburg")]
        GMT0500AsiaYekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Asia/Dushanbe")]
        GMT0500AsiaDushanbe,
        [EnumMember(Value = "(GMT+05:00) Asia/Ashgabat")]
        GMT0500AsiaAshgabat,
        [EnumMember(Value = "(GMT+05:00) Asia/Samarkand")]
        GMT0500AsiaSamarkand,
        [EnumMember(Value = "(GMT+05:00) Asia/Tashkent")]
        GMT0500AsiaTashkent,
        [EnumMember(Value = "(GMT+05:30) Asia/Kolkata")]
        GMT0530AsiaKolkata,
        [EnumMember(Value = "(GMT+05:30) Asia/Colombo")]
        GMT0530AsiaColombo,
        [EnumMember(Value = "(GMT+05:45) Asia/Kathmandu")]
        GMT0545AsiaKathmandu,
        [EnumMember(Value = "(GMT+06:00) Antarctica/Vostok")]
        GMT0600AntarcticaVostok,
        [EnumMember(Value = "(GMT+06:00) Asia/Dhaka")]
        GMT0600AsiaDhaka,
        [EnumMember(Value = "(GMT+06:00) Asia/Thimphu")]
        GMT0600AsiaThimphu,
        [EnumMember(Value = "(GMT+06:00) Indian/Chagos")]
        GMT0600IndianChagos,
        [EnumMember(Value = "(GMT+06:00) Asia/Urumqi")]
        GMT0600AsiaUrumqi,
        [EnumMember(Value = "(GMT+06:00) Asia/Almaty")]
        GMT0600AsiaAlmaty,
        [EnumMember(Value = "(GMT+06:00) Asia/Qyzylorda")]
        GMT0600AsiaQyzylorda,
        [EnumMember(Value = "(GMT+06:00) Asia/Bishkek")]
        GMT0600AsiaBishkek,
        [EnumMember(Value = "(GMT+06:00) Asia/Novosibirsk")]
        GMT0600AsiaNovosibirsk,
        [EnumMember(Value = "(GMT+06:00) Asia/Omsk")]
        GMT0600AsiaOmsk,
        [EnumMember(Value = "(GMT+06:30) Indian/Cocos")]
        GMT0630IndianCocos,
        [EnumMember(Value = "(GMT+06:30) Asia/Rangoon")]
        GMT0630AsiaRangoon,
        [EnumMember(Value = "(GMT+07:00) Antarctica/Davis")]
        GMT0700AntarcticaDavis,
        [EnumMember(Value = "(GMT+07:00) Asia/Phnom_Penh")]
        GMT0700AsiaPhnomPenh,
        [EnumMember(Value = "(GMT+07:00) Indian/Christmas")]
        GMT0700IndianChristmas,
        [EnumMember(Value = "(GMT+07:00) Asia/Jakarta")]
        GMT0700AsiaJakarta,
        [EnumMember(Value = "(GMT+07:00) Asia/Pontianak")]
        GMT0700AsiaPontianak,
        [EnumMember(Value = "(GMT+07:00) Asia/Vientiane")]
        GMT0700AsiaVientiane,
        [EnumMember(Value = "(GMT+07:00) Asia/Hovd")]
        GMT0700AsiaHovd,
        [EnumMember(Value = "(GMT+07:00) Asia/Krasnoyarsk")]
        GMT0700AsiaKrasnoyarsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Novokuznetsk")]
        GMT0700AsiaNovokuznetsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Bangkok")]
        GMT0700AsiaBangkok,
        [EnumMember(Value = "(GMT+07:00) Asia/Ho_Chi_Minh")]
        GMT0700AsiaHoChiMinh,
        [EnumMember(Value = "(GMT+08:00) Antarctica/Casey")]
        GMT0800AntarcticaCasey,
        [EnumMember(Value = "(GMT+08:00) Australia/Perth")]
        GMT0800AustraliaPerth,
        [EnumMember(Value = "(GMT+08:00) Asia/Brunei")]
        GMT0800AsiaBrunei,
        [EnumMember(Value = "(GMT+08:00) Asia/Shanghai")]
        GMT0800AsiaShanghai,
        [EnumMember(Value = "(GMT+08:00) Asia/Hong_Kong")]
        GMT0800AsiaHongKong,
        [EnumMember(Value = "(GMT+08:00) Asia/Makassar")]
        GMT0800AsiaMakassar,
        [EnumMember(Value = "(GMT+08:00) Asia/Macau")]
        GMT0800AsiaMacau,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuala_Lumpur")]
        GMT0800AsiaKualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuching")]
        GMT0800AsiaKuching,
        [EnumMember(Value = "(GMT+08:00) Asia/Choibalsan")]
        GMT0800AsiaChoibalsan,
        [EnumMember(Value = "(GMT+08:00) Asia/Ulaanbaatar")]
        GMT0800AsiaUlaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Asia/Manila")]
        GMT0800AsiaManila,
        [EnumMember(Value = "(GMT+08:00) Asia/Chita")]
        GMT0800AsiaChita,
        [EnumMember(Value = "(GMT+08:00) Asia/Irkutsk")]
        GMT0800AsiaIrkutsk,
        [EnumMember(Value = "(GMT+08:00) Asia/Singapore")]
        GMT0800AsiaSingapore,
        [EnumMember(Value = "(GMT+08:00) Asia/Taipei")]
        GMT0800AsiaTaipei,
        [EnumMember(Value = "(GMT+08:45) Australia/Eucla")]
        GMT0845AustraliaEucla,
        [EnumMember(Value = "(GMT+09:00) Asia/Jayapura")]
        GMT0900AsiaJayapura,
        [EnumMember(Value = "(GMT+09:00) Asia/Tokyo")]
        GMT0900AsiaTokyo,
        [EnumMember(Value = "(GMT+09:00) Asia/Pyongyang")]
        GMT0900AsiaPyongyang,
        [EnumMember(Value = "(GMT+09:00) Asia/Seoul")]
        GMT0900AsiaSeoul,
        [EnumMember(Value = "(GMT+09:00) Pacific/Palau")]
        GMT0900PacificPalau,
        [EnumMember(Value = "(GMT+09:00) Asia/Khandyga")]
        GMT0900AsiaKhandyga,
        [EnumMember(Value = "(GMT+09:00) Asia/Yakutsk")]
        GMT0900AsiaYakutsk,
        [EnumMember(Value = "(GMT+09:00) Asia/Dili")]
        GMT0900AsiaDili,
        [EnumMember(Value = "(GMT+09:30) Australia/Darwin")]
        GMT0930AustraliaDarwin,
        [EnumMember(Value = "(GMT+10:00) Antarctica/DumontDUrville")]
        GMT1000AntarcticaDumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Australia/Brisbane")]
        GMT1000AustraliaBrisbane,
        [EnumMember(Value = "(GMT+10:00) Australia/Lindeman")]
        GMT1000AustraliaLindeman,
        [EnumMember(Value = "(GMT+10:00) Pacific/Guam")]
        GMT1000PacificGuam,
        [EnumMember(Value = "(GMT+10:00) Pacific/Chuuk")]
        GMT1000PacificChuuk,
        [EnumMember(Value = "(GMT+10:00) Pacific/Saipan")]
        GMT1000PacificSaipan,
        [EnumMember(Value = "(GMT+10:00) Pacific/Port_Moresby")]
        GMT1000PacificPortMoresby,
        [EnumMember(Value = "(GMT+10:00) Asia/Magadan")]
        GMT1000AsiaMagadan,
        [EnumMember(Value = "(GMT+10:00) Asia/Sakhalin")]
        GMT1000AsiaSakhalin,
        [EnumMember(Value = "(GMT+10:00) Asia/Ust-Nera")]
        GMT1000AsiaUstNera,
        [EnumMember(Value = "(GMT+10:00) Asia/Vladivostok")]
        GMT1000AsiaVladivostok,
        [EnumMember(Value = "(GMT+10:30) Australia/Adelaide")]
        GMT1030AustraliaAdelaide,
        [EnumMember(Value = "(GMT+10:30) Australia/Broken_Hill")]
        GMT1030AustraliaBrokenHill,
        [EnumMember(Value = "(GMT+11:00) Australia/Currie")]
        GMT1100AustraliaCurrie,
        [EnumMember(Value = "(GMT+11:00) Australia/Hobart")]
        GMT1100AustraliaHobart,
        [EnumMember(Value = "(GMT+11:00) Australia/Lord_Howe")]
        GMT1100AustraliaLordHowe,
        [EnumMember(Value = "(GMT+11:00) Antarctica/Macquarie")]
        GMT1100AntarcticaMacquarie,
        [EnumMember(Value = "(GMT+11:00) Australia/Melbourne")]
        GMT1100AustraliaMelbourne,
        [EnumMember(Value = "(GMT+11:00) Australia/Sydney")]
        GMT1100AustraliaSydney,
        [EnumMember(Value = "(GMT+11:00) Pacific/Kosrae")]
        GMT1100PacificKosrae,
        [EnumMember(Value = "(GMT+11:00) Pacific/Pohnpei")]
        GMT1100PacificPohnpei,
        [EnumMember(Value = "(GMT+11:00) Pacific/Noumea")]
        GMT1100PacificNoumea,
        [EnumMember(Value = "(GMT+11:00) Pacific/Bougainville")]
        GMT1100PacificBougainville,
        [EnumMember(Value = "(GMT+11:00) Asia/Srednekolymsk")]
        GMT1100AsiaSrednekolymsk,
        [EnumMember(Value = "(GMT+11:00) Pacific/Guadalcanal")]
        GMT1100PacificGuadalcanal,
        [EnumMember(Value = "(GMT+11:00) Pacific/Efate")]
        GMT1100PacificEfate,
        [EnumMember(Value = "(GMT+11:30) Pacific/Norfolk")]
        GMT1130PacificNorfolk,
        [EnumMember(Value = "(GMT+12:00) Pacific/Fiji")]
        GMT1200PacificFiji,
        [EnumMember(Value = "(GMT+12:00) Pacific/Tarawa")]
        GMT1200PacificTarawa,
        [EnumMember(Value = "(GMT+12:00) Pacific/Kwajalein")]
        GMT1200PacificKwajalein,
        [EnumMember(Value = "(GMT+12:00) Pacific/Majuro")]
        GMT1200PacificMajuro,
        [EnumMember(Value = "(GMT+12:00) Pacific/Nauru")]
        GMT1200PacificNauru,
        [EnumMember(Value = "(GMT+12:00) Asia/Anadyr")]
        GMT1200AsiaAnadyr,
        [EnumMember(Value = "(GMT+12:00) Asia/Kamchatka")]
        GMT1200AsiaKamchatka,
        [EnumMember(Value = "(GMT+12:00) Pacific/Funafuti")]
        GMT1200PacificFunafuti,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wake")]
        GMT1200PacificWake,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wallis")]
        GMT1200PacificWallis,
        [EnumMember(Value = "(GMT+13:00) Antarctica/McMurdo")]
        GMT1300AntarcticaMcMurdo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Enderbury")]
        GMT1300PacificEnderbury,
        [EnumMember(Value = "(GMT+13:00) Pacific/Auckland")]
        GMT1300PacificAuckland,
        [EnumMember(Value = "(GMT+13:00) Pacific/Fakaofo")]
        GMT1300PacificFakaofo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Tongatapu")]
        GMT1300PacificTongatapu,
        [EnumMember(Value = "(GMT+13:45) Pacific/Chatham")]
        GMT1345PacificChatham,
        [EnumMember(Value = "(GMT+14:00) Pacific/Kiritimati")]
        GMT1400PacificKiritimati,
        [EnumMember(Value = "(GMT+14:00) Pacific/Apia")]
        GMT1400PacificApia
    }

    public class PostDataResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public enum bodytimezoneInput
    {
        [EnumMember(Value = "(GMT+00:00) UTC")]
        GMT0000UTC,
        [EnumMember(Value = "(GMT-11:00) Pacific/Pago_Pago")]
        GMT1100PacificPagoPago,
        [EnumMember(Value = "(GMT-11:00) Pacific/Niue")]
        GMT1100PacificNiue,
        [EnumMember(Value = "(GMT-11:00) Pacific/Midway")]
        GMT1100PacificMidway,
        [EnumMember(Value = "(GMT-10:00) Pacific/Rarotonga")]
        GMT1000PacificRarotonga,
        [EnumMember(Value = "(GMT-10:00) Pacific/Tahiti")]
        GMT1000PacificTahiti,
        [EnumMember(Value = "(GMT-10:00) Pacific/Honolulu")]
        GMT1000PacificHonolulu,
        [EnumMember(Value = "(GMT-10:00) Pacific/Johnston")]
        GMT1000PacificJohnston,
        [EnumMember(Value = "(GMT-09:30) Pacific/Marquesas")]
        GMT0930PacificMarquesas,
        [EnumMember(Value = "(GMT-09:00) Pacific/Gambier")]
        GMT0900PacificGambier,
        [EnumMember(Value = "(GMT-09:00) America/Adak")]
        GMT0900AmericaAdak,
        [EnumMember(Value = "(GMT-08:00) America/Santa_Isabel")]
        GMT0800AmericaSantaIsabel,
        [EnumMember(Value = "(GMT-08:00) Pacific/Pitcairn")]
        GMT0800PacificPitcairn,
        [EnumMember(Value = "(GMT-08:00) America/Anchorage")]
        GMT0800AmericaAnchorage,
        [EnumMember(Value = "(GMT-08:00) America/Juneau")]
        GMT0800AmericaJuneau,
        [EnumMember(Value = "(GMT-08:00) America/Metlakatla")]
        GMT0800AmericaMetlakatla,
        [EnumMember(Value = "(GMT-08:00) America/Nome")]
        GMT0800AmericaNome,
        [EnumMember(Value = "(GMT-08:00) America/Sitka")]
        GMT0800AmericaSitka,
        [EnumMember(Value = "(GMT-08:00) America/Yakutat")]
        GMT0800AmericaYakutat,
        [EnumMember(Value = "(GMT-07:00) America/Creston")]
        GMT0700AmericaCreston,
        [EnumMember(Value = "(GMT-07:00) America/Dawson")]
        GMT0700AmericaDawson,
        [EnumMember(Value = "(GMT-07:00) America/Dawson_Creek")]
        GMT0700AmericaDawsonCreek,
        [EnumMember(Value = "(GMT-07:00) America/Vancouver")]
        GMT0700AmericaVancouver,
        [EnumMember(Value = "(GMT-07:00) America/Whitehorse")]
        GMT0700AmericaWhitehorse,
        [EnumMember(Value = "(GMT-07:00) America/Chihuahua")]
        GMT0700AmericaChihuahua,
        [EnumMember(Value = "(GMT-07:00) America/Hermosillo")]
        GMT0700AmericaHermosillo,
        [EnumMember(Value = "(GMT-07:00) America/Mazatlan")]
        GMT0700AmericaMazatlan,
        [EnumMember(Value = "(GMT-07:00) America/Tijuana")]
        GMT0700AmericaTijuana,
        [EnumMember(Value = "(GMT-07:00) America/Los_Angeles")]
        GMT0700AmericaLosAngeles,
        [EnumMember(Value = "(GMT-07:00) America/Phoenix")]
        GMT0700AmericaPhoenix,
        [EnumMember(Value = "(GMT-06:00) America/Belize")]
        GMT0600AmericaBelize,
        [EnumMember(Value = "(GMT-06:00) America/Cambridge_Bay")]
        GMT0600AmericaCambridgeBay,
        [EnumMember(Value = "(GMT-06:00) America/Edmonton")]
        GMT0600AmericaEdmonton,
        [EnumMember(Value = "(GMT-06:00) America/Inuvik")]
        GMT0600AmericaInuvik,
        [EnumMember(Value = "(GMT-06:00) America/Regina")]
        GMT0600AmericaRegina,
        [EnumMember(Value = "(GMT-06:00) America/Swift_Current")]
        GMT0600AmericaSwiftCurrent,
        [EnumMember(Value = "(GMT-06:00) America/Yellowknife")]
        GMT0600AmericaYellowknife,
        [EnumMember(Value = "(GMT-06:00) America/Costa_Rica")]
        GMT0600AmericaCostaRica,
        [EnumMember(Value = "(GMT-06:00) Pacific/Galapagos")]
        GMT0600PacificGalapagos,
        [EnumMember(Value = "(GMT-06:00) America/El_Salvador")]
        GMT0600AmericaElSalvador,
        [EnumMember(Value = "(GMT-06:00) America/Guatemala")]
        GMT0600AmericaGuatemala,
        [EnumMember(Value = "(GMT-06:00) America/Tegucigalpa")]
        GMT0600AmericaTegucigalpa,
        [EnumMember(Value = "(GMT-06:00) America/Bahia_Banderas")]
        GMT0600AmericaBahiaBanderas,
        [EnumMember(Value = "(GMT-06:00) America/Cancun")]
        GMT0600AmericaCancun,
        [EnumMember(Value = "(GMT-06:00) America/Merida")]
        GMT0600AmericaMerida,
        [EnumMember(Value = "(GMT-06:00) America/Mexico_City")]
        GMT0600AmericaMexicoCity,
        [EnumMember(Value = "(GMT-06:00) America/Monterrey")]
        GMT0600AmericaMonterrey,
        [EnumMember(Value = "(GMT-06:00) America/Ojinaga")]
        GMT0600AmericaOjinaga,
        [EnumMember(Value = "(GMT-06:00) America/Managua")]
        GMT0600AmericaManagua,
        [EnumMember(Value = "(GMT-06:00) America/Boise")]
        GMT0600AmericaBoise,
        [EnumMember(Value = "(GMT-06:00) America/Denver")]
        GMT0600AmericaDenver,
        [EnumMember(Value = "(GMT-05:00) America/Eirunepe")]
        GMT0500AmericaEirunepe,
        [EnumMember(Value = "(GMT-05:00) America/Rio_Branco")]
        GMT0500AmericaRioBranco,
        [EnumMember(Value = "(GMT-05:00) America/Atikokan")]
        GMT0500AmericaAtikokan,
        [EnumMember(Value = "(GMT-05:00) America/Rainy_River")]
        GMT0500AmericaRainyRiver,
        [EnumMember(Value = "(GMT-05:00) America/Rankin_Inlet")]
        GMT0500AmericaRankinInlet,
        [EnumMember(Value = "(GMT-05:00) America/Resolute")]
        GMT0500AmericaResolute,
        [EnumMember(Value = "(GMT-05:00) America/Winnipeg")]
        GMT0500AmericaWinnipeg,
        [EnumMember(Value = "(GMT-05:00) America/Cayman")]
        GMT0500AmericaCayman,
        [EnumMember(Value = "(GMT-05:00) Pacific/Easter")]
        GMT0500PacificEaster,
        [EnumMember(Value = "(GMT-05:00) America/Bogota")]
        GMT0500AmericaBogota,
        [EnumMember(Value = "(GMT-05:00) America/Guayaquil")]
        GMT0500AmericaGuayaquil,
        [EnumMember(Value = "(GMT-05:00) America/Jamaica")]
        GMT0500AmericaJamaica,
        [EnumMember(Value = "(GMT-05:00) America/Matamoros")]
        GMT0500AmericaMatamoros,
        [EnumMember(Value = "(GMT-05:00) America/Panama")]
        GMT0500AmericaPanama,
        [EnumMember(Value = "(GMT-05:00) America/Lima")]
        GMT0500AmericaLima,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Beulah")]
        GMT0500AmericaNorthDakotaBeulah,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/Center")]
        GMT0500AmericaNorthDakotaCenter,
        [EnumMember(Value = "(GMT-05:00) America/Chicago")]
        GMT0500AmericaChicago,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Knox")]
        GMT0500AmericaIndianaKnox,
        [EnumMember(Value = "(GMT-05:00) America/Menominee")]
        GMT0500AmericaMenominee,
        [EnumMember(Value = "(GMT-05:00) America/North_Dakota/New_Salem")]
        GMT0500AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "(GMT-05:00) America/Indiana/Tell_City")]
        GMT0500AmericaIndianaTellCity,
        [EnumMember(Value = "(GMT-04:30) America/Caracas")]
        GMT0430AmericaCaracas,
        [EnumMember(Value = "(GMT-04:00) America/Anguilla")]
        GMT0400AmericaAnguilla,
        [EnumMember(Value = "(GMT-04:00) America/Antigua")]
        GMT0400AmericaAntigua,
        [EnumMember(Value = "(GMT-04:00) America/Aruba")]
        GMT0400AmericaAruba,
        [EnumMember(Value = "(GMT-04:00) America/Nassau")]
        GMT0400AmericaNassau,
        [EnumMember(Value = "(GMT-04:00) America/Barbados")]
        GMT0400AmericaBarbados,
        [EnumMember(Value = "(GMT-04:00) America/La_Paz")]
        GMT0400AmericaLaPaz,
        [EnumMember(Value = "(GMT-04:00) America/Kralendijk")]
        GMT0400AmericaKralendijk,
        [EnumMember(Value = "(GMT-04:00) America/Boa_Vista")]
        GMT0400AmericaBoaVista,
        [EnumMember(Value = "(GMT-04:00) America/Campo_Grande")]
        GMT0400AmericaCampoGrande,
        [EnumMember(Value = "(GMT-04:00) America/Cuiaba")]
        GMT0400AmericaCuiaba,
        [EnumMember(Value = "(GMT-04:00) America/Manaus")]
        GMT0400AmericaManaus,
        [EnumMember(Value = "(GMT-04:00) America/Porto_Velho")]
        GMT0400AmericaPortoVelho,
        [EnumMember(Value = "(GMT-04:00) America/Blanc-Sablon")]
        GMT0400AmericaBlancSablon,
        [EnumMember(Value = "(GMT-04:00) America/Iqaluit")]
        GMT0400AmericaIqaluit,
        [EnumMember(Value = "(GMT-04:00) America/Nipigon")]
        GMT0400AmericaNipigon,
        [EnumMember(Value = "(GMT-04:00) America/Pangnirtung")]
        GMT0400AmericaPangnirtung,
        [EnumMember(Value = "(GMT-04:00) America/Thunder_Bay")]
        GMT0400AmericaThunderBay,
        [EnumMember(Value = "(GMT-04:00) America/Toronto")]
        GMT0400AmericaToronto,
        [EnumMember(Value = "(GMT-04:00) America/Havana")]
        GMT0400AmericaHavana,
        [EnumMember(Value = "(GMT-04:00) America/Curacao")]
        GMT0400AmericaCuracao,
        [EnumMember(Value = "(GMT-04:00) America/Dominica")]
        GMT0400AmericaDominica,
        [EnumMember(Value = "(GMT-04:00) America/Santo_Domingo")]
        GMT0400AmericaSantoDomingo,
        [EnumMember(Value = "(GMT-04:00) America/Grenada")]
        GMT0400AmericaGrenada,
        [EnumMember(Value = "(GMT-04:00) America/Guadeloupe")]
        GMT0400AmericaGuadeloupe,
        [EnumMember(Value = "(GMT-04:00) America/Guyana")]
        GMT0400AmericaGuyana,
        [EnumMember(Value = "(GMT-04:00) America/Port-au-Prince")]
        GMT0400AmericaPortAuPrince,
        [EnumMember(Value = "(GMT-04:00) America/Martinique")]
        GMT0400AmericaMartinique,
        [EnumMember(Value = "(GMT-04:00) America/Montserrat")]
        GMT0400AmericaMontserrat,
        [EnumMember(Value = "(GMT-04:00) America/Asuncion")]
        GMT0400AmericaAsuncion,
        [EnumMember(Value = "(GMT-04:00) America/Puerto_Rico")]
        GMT0400AmericaPuertoRico,
        [EnumMember(Value = "(GMT-04:00) America/St_Barthelemy")]
        GMT0400AmericaStBarthelemy,
        [EnumMember(Value = "(GMT-04:00) America/St_Kitts")]
        GMT0400AmericaStKitts,
        [EnumMember(Value = "(GMT-04:00) America/St_Lucia")]
        GMT0400AmericaStLucia,
        [EnumMember(Value = "(GMT-04:00) America/Marigot")]
        GMT0400AmericaMarigot,
        [EnumMember(Value = "(GMT-04:00) America/St_Vincent")]
        GMT0400AmericaStVincent,
        [EnumMember(Value = "(GMT-04:00) America/Lower_Princes")]
        GMT0400AmericaLowerPrinces,
        [EnumMember(Value = "(GMT-04:00) America/Port_of_Spain")]
        GMT0400AmericaPortOfSpain,
        [EnumMember(Value = "(GMT-04:00) America/Grand_Turk")]
        GMT0400AmericaGrandTurk,
        [EnumMember(Value = "(GMT-04:00) America/Detroit")]
        GMT0400AmericaDetroit,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Indianapolis")]
        GMT0400AmericaIndianaIndianapolis,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Louisville")]
        GMT0400AmericaKentuckyLouisville,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Marengo")]
        GMT0400AmericaIndianaMarengo,
        [EnumMember(Value = "(GMT-04:00) America/Kentucky/Monticello")]
        GMT0400AmericaKentuckyMonticello,
        [EnumMember(Value = "(GMT-04:00) America/New_York")]
        GMT0400AmericaNewYork,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Petersburg")]
        GMT0400AmericaIndianaPetersburg,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vevay")]
        GMT0400AmericaIndianaVevay,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Vincennes")]
        GMT0400AmericaIndianaVincennes,
        [EnumMember(Value = "(GMT-04:00) America/Indiana/Winamac")]
        GMT0400AmericaIndianaWinamac,
        [EnumMember(Value = "(GMT-04:00) America/Tortola")]
        GMT0400AmericaTortola,
        [EnumMember(Value = "(GMT-04:00) America/St_Thomas")]
        GMT0400AmericaStThomas,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Palmer")]
        GMT0300AntarcticaPalmer,
        [EnumMember(Value = "(GMT-03:00) Antarctica/Rothera")]
        GMT0300AntarcticaRothera,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Buenos_Aires")]
        GMT0300AmericaArgentinaBuenosAires,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Catamarca")]
        GMT0300AmericaArgentinaCatamarca,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Cordoba")]
        GMT0300AmericaArgentinaCordoba,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Jujuy")]
        GMT0300AmericaArgentinaJujuy,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/La_Rioja")]
        GMT0300AmericaArgentinaLaRioja,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Mendoza")]
        GMT0300AmericaArgentinaMendoza,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Rio_Gallegos")]
        GMT0300AmericaArgentinaRioGallegos,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Salta")]
        GMT0300AmericaArgentinaSalta,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Juan")]
        GMT0300AmericaArgentinaSanJuan,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/San_Luis")]
        GMT0300AmericaArgentinaSanLuis,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Tucuman")]
        GMT0300AmericaArgentinaTucuman,
        [EnumMember(Value = "(GMT-03:00) America/Argentina/Ushuaia")]
        GMT0300AmericaArgentinaUshuaia,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Bermuda")]
        GMT0300AtlanticBermuda,
        [EnumMember(Value = "(GMT-03:00) America/Araguaina")]
        GMT0300AmericaAraguaina,
        [EnumMember(Value = "(GMT-03:00) America/Bahia")]
        GMT0300AmericaBahia,
        [EnumMember(Value = "(GMT-03:00) America/Belem")]
        GMT0300AmericaBelem,
        [EnumMember(Value = "(GMT-03:00) America/Fortaleza")]
        GMT0300AmericaFortaleza,
        [EnumMember(Value = "(GMT-03:00) America/Maceio")]
        GMT0300AmericaMaceio,
        [EnumMember(Value = "(GMT-03:00) America/Recife")]
        GMT0300AmericaRecife,
        [EnumMember(Value = "(GMT-03:00) America/Santarem")]
        GMT0300AmericaSantarem,
        [EnumMember(Value = "(GMT-03:00) America/Sao_Paulo")]
        GMT0300AmericaSaoPaulo,
        [EnumMember(Value = "(GMT-03:00) America/Glace_Bay")]
        GMT0300AmericaGlaceBay,
        [EnumMember(Value = "(GMT-03:00) America/Goose_Bay")]
        GMT0300AmericaGooseBay,
        [EnumMember(Value = "(GMT-03:00) America/Halifax")]
        GMT0300AmericaHalifax,
        [EnumMember(Value = "(GMT-03:00) America/Moncton")]
        GMT0300AmericaMoncton,
        [EnumMember(Value = "(GMT-03:00) America/Santiago")]
        GMT0300AmericaSantiago,
        [EnumMember(Value = "(GMT-03:00) Atlantic/Stanley")]
        GMT0300AtlanticStanley,
        [EnumMember(Value = "(GMT-03:00) America/Cayenne")]
        GMT0300AmericaCayenne,
        [EnumMember(Value = "(GMT-03:00) America/Godthab")]
        GMT0300AmericaGodthab,
        [EnumMember(Value = "(GMT-03:00) America/Thule")]
        GMT0300AmericaThule,
        [EnumMember(Value = "(GMT-03:00) America/Paramaribo")]
        GMT0300AmericaParamaribo,
        [EnumMember(Value = "(GMT-03:00) America/Montevideo")]
        GMT0300AmericaMontevideo,
        [EnumMember(Value = "(GMT-02:30) America/St_Johns")]
        GMT0230AmericaStJohns,
        [EnumMember(Value = "(GMT-02:00) America/Noronha")]
        GMT0200AmericaNoronha,
        [EnumMember(Value = "(GMT-02:00) America/Miquelon")]
        GMT0200AmericaMiquelon,
        [EnumMember(Value = "(GMT-02:00) Atlantic/South_Georgia")]
        GMT0200AtlanticSouthGeorgia,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Cape_Verde")]
        GMT0100AtlanticCapeVerde,
        [EnumMember(Value = "(GMT-01:00) America/Scoresbysund")]
        GMT0100AmericaScoresbysund,
        [EnumMember(Value = "(GMT-01:00) Atlantic/Azores")]
        GMT0100AtlanticAzores,
        [EnumMember(Value = "(GMT+00:00) Antarctica/Troll")]
        GMT0000AntarcticaTroll,
        [EnumMember(Value = "(GMT+00:00) Africa/Ouagadougou")]
        GMT0000AfricaOuagadougou,
        [EnumMember(Value = "(GMT+00:00) Africa/Abidjan")]
        GMT0000AfricaAbidjan,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Faroe")]
        GMT0000AtlanticFaroe,
        [EnumMember(Value = "(GMT+00:00) Africa/Banjul")]
        GMT0000AfricaBanjul,
        [EnumMember(Value = "(GMT+00:00) Africa/Accra")]
        GMT0000AfricaAccra,
        [EnumMember(Value = "(GMT+00:00) America/Danmarkshavn")]
        GMT0000AmericaDanmarkshavn,
        [EnumMember(Value = "(GMT+00:00) Europe/Guernsey")]
        GMT0000EuropeGuernsey,
        [EnumMember(Value = "(GMT+00:00) Africa/Conakry")]
        GMT0000AfricaConakry,
        [EnumMember(Value = "(GMT+00:00) Africa/Bissau")]
        GMT0000AfricaBissau,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Reykjavik")]
        GMT0000AtlanticReykjavik,
        [EnumMember(Value = "(GMT+00:00) Europe/Dublin")]
        GMT0000EuropeDublin,
        [EnumMember(Value = "(GMT+00:00) Europe/Isle_of_Man")]
        GMT0000EuropeIsleOfMan,
        [EnumMember(Value = "(GMT+00:00) Europe/Jersey")]
        GMT0000EuropeJersey,
        [EnumMember(Value = "(GMT+00:00) Africa/Monrovia")]
        GMT0000AfricaMonrovia,
        [EnumMember(Value = "(GMT+00:00) Africa/Bamako")]
        GMT0000AfricaBamako,
        [EnumMember(Value = "(GMT+00:00) Africa/Nouakchott")]
        GMT0000AfricaNouakchott,
        [EnumMember(Value = "(GMT+00:00) Africa/Casablanca")]
        GMT0000AfricaCasablanca,
        [EnumMember(Value = "(GMT+00:00) Europe/Lisbon")]
        GMT0000EuropeLisbon,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Madeira")]
        GMT0000AtlanticMadeira,
        [EnumMember(Value = "(GMT+00:00) Atlantic/St_Helena")]
        GMT0000AtlanticStHelena,
        [EnumMember(Value = "(GMT+00:00) Africa/Sao_Tome")]
        GMT0000AfricaSaoTome,
        [EnumMember(Value = "(GMT+00:00) Africa/Dakar")]
        GMT0000AfricaDakar,
        [EnumMember(Value = "(GMT+00:00) Africa/Freetown")]
        GMT0000AfricaFreetown,
        [EnumMember(Value = "(GMT+00:00) Atlantic/Canary")]
        GMT0000AtlanticCanary,
        [EnumMember(Value = "(GMT+00:00) Africa/Lome")]
        GMT0000AfricaLome,
        [EnumMember(Value = "(GMT+00:00) Europe/London")]
        GMT0000EuropeLondon,
        [EnumMember(Value = "(GMT+00:00) Africa/El_Aaiun")]
        GMT0000AfricaElAaiun,
        [EnumMember(Value = "(GMT+01:00) Europe/Tirane")]
        GMT0100EuropeTirane,
        [EnumMember(Value = "(GMT+01:00) Africa/Algiers")]
        GMT0100AfricaAlgiers,
        [EnumMember(Value = "(GMT+01:00) Europe/Andorra")]
        GMT0100EuropeAndorra,
        [EnumMember(Value = "(GMT+01:00) Africa/Luanda")]
        GMT0100AfricaLuanda,
        [EnumMember(Value = "(GMT+01:00) Europe/Vienna")]
        GMT0100EuropeVienna,
        [EnumMember(Value = "(GMT+01:00) Europe/Brussels")]
        GMT0100EuropeBrussels,
        [EnumMember(Value = "(GMT+01:00) Africa/Porto-Novo")]
        GMT0100AfricaPortoNovo,
        [EnumMember(Value = "(GMT+01:00) Europe/Sarajevo")]
        GMT0100EuropeSarajevo,
        [EnumMember(Value = "(GMT+01:00) Africa/Douala")]
        GMT0100AfricaDouala,
        [EnumMember(Value = "(GMT+01:00) Africa/Bangui")]
        GMT0100AfricaBangui,
        [EnumMember(Value = "(GMT+01:00) Africa/Ndjamena")]
        GMT0100AfricaNdjamena,
        [EnumMember(Value = "(GMT+01:00) Africa/Brazzaville")]
        GMT0100AfricaBrazzaville,
        [EnumMember(Value = "(GMT+01:00) Africa/Kinshasa")]
        GMT0100AfricaKinshasa,
        [EnumMember(Value = "(GMT+01:00) Europe/Zagreb")]
        GMT0100EuropeZagreb,
        [EnumMember(Value = "(GMT+01:00) Europe/Prague")]
        GMT0100EuropePrague,
        [EnumMember(Value = "(GMT+01:00) Europe/Copenhagen")]
        GMT0100EuropeCopenhagen,
        [EnumMember(Value = "(GMT+01:00) Africa/Malabo")]
        GMT0100AfricaMalabo,
        [EnumMember(Value = "(GMT+01:00) Europe/Paris")]
        GMT0100EuropeParis,
        [EnumMember(Value = "(GMT+01:00) Africa/Libreville")]
        GMT0100AfricaLibreville,
        [EnumMember(Value = "(GMT+01:00) Europe/Berlin")]
        GMT0100EuropeBerlin,
        [EnumMember(Value = "(GMT+01:00) Europe/Busingen")]
        GMT0100EuropeBusingen,
        [EnumMember(Value = "(GMT+01:00) Europe/Gibraltar")]
        GMT0100EuropeGibraltar,
        [EnumMember(Value = "(GMT+01:00) Europe/Vatican")]
        GMT0100EuropeVatican,
        [EnumMember(Value = "(GMT+01:00) Europe/Budapest")]
        GMT0100EuropeBudapest,
        [EnumMember(Value = "(GMT+01:00) Europe/Rome")]
        GMT0100EuropeRome,
        [EnumMember(Value = "(GMT+01:00) Europe/Vaduz")]
        GMT0100EuropeVaduz,
        [EnumMember(Value = "(GMT+01:00) Europe/Luxembourg")]
        GMT0100EuropeLuxembourg,
        [EnumMember(Value = "(GMT+01:00) Europe/Skopje")]
        GMT0100EuropeSkopje,
        [EnumMember(Value = "(GMT+01:00) Europe/Malta")]
        GMT0100EuropeMalta,
        [EnumMember(Value = "(GMT+01:00) Europe/Monaco")]
        GMT0100EuropeMonaco,
        [EnumMember(Value = "(GMT+01:00) Europe/Podgorica")]
        GMT0100EuropePodgorica,
        [EnumMember(Value = "(GMT+01:00) Europe/Amsterdam")]
        GMT0100EuropeAmsterdam,
        [EnumMember(Value = "(GMT+01:00) Africa/Niamey")]
        GMT0100AfricaNiamey,
        [EnumMember(Value = "(GMT+01:00) Africa/Lagos")]
        GMT0100AfricaLagos,
        [EnumMember(Value = "(GMT+01:00) Europe/Oslo")]
        GMT0100EuropeOslo,
        [EnumMember(Value = "(GMT+01:00) Europe/Warsaw")]
        GMT0100EuropeWarsaw,
        [EnumMember(Value = "(GMT+01:00) Europe/San_Marino")]
        GMT0100EuropeSanMarino,
        [EnumMember(Value = "(GMT+01:00) Europe/Belgrade")]
        GMT0100EuropeBelgrade,
        [EnumMember(Value = "(GMT+01:00) Europe/Bratislava")]
        GMT0100EuropeBratislava,
        [EnumMember(Value = "(GMT+01:00) Europe/Ljubljana")]
        GMT0100EuropeLjubljana,
        [EnumMember(Value = "(GMT+01:00) Africa/Ceuta")]
        GMT0100AfricaCeuta,
        [EnumMember(Value = "(GMT+01:00) Europe/Madrid")]
        GMT0100EuropeMadrid,
        [EnumMember(Value = "(GMT+01:00) Arctic/Longyearbyen")]
        GMT0100ArcticLongyearbyen,
        [EnumMember(Value = "(GMT+01:00) Europe/Stockholm")]
        GMT0100EuropeStockholm,
        [EnumMember(Value = "(GMT+01:00) Europe/Zurich")]
        GMT0100EuropeZurich,
        [EnumMember(Value = "(GMT+01:00) Africa/Tunis")]
        GMT0100AfricaTunis,
        [EnumMember(Value = "(GMT+02:00) Africa/Gaborone")]
        GMT0200AfricaGaborone,
        [EnumMember(Value = "(GMT+02:00) Europe/Sofia")]
        GMT0200EuropeSofia,
        [EnumMember(Value = "(GMT+02:00) Africa/Bujumbura")]
        GMT0200AfricaBujumbura,
        [EnumMember(Value = "(GMT+02:00) Africa/Lubumbashi")]
        GMT0200AfricaLubumbashi,
        [EnumMember(Value = "(GMT+02:00) Asia/Nicosia")]
        GMT0200AsiaNicosia,
        [EnumMember(Value = "(GMT+02:00) Africa/Cairo")]
        GMT0200AfricaCairo,
        [EnumMember(Value = "(GMT+02:00) Europe/Tallinn")]
        GMT0200EuropeTallinn,
        [EnumMember(Value = "(GMT+02:00) Europe/Helsinki")]
        GMT0200EuropeHelsinki,
        [EnumMember(Value = "(GMT+02:00) Europe/Athens")]
        GMT0200EuropeAthens,
        [EnumMember(Value = "(GMT+02:00) Asia/Jerusalem")]
        GMT0200AsiaJerusalem,
        [EnumMember(Value = "(GMT+02:00) Asia/Amman")]
        GMT0200AsiaAmman,
        [EnumMember(Value = "(GMT+02:00) Europe/Riga")]
        GMT0200EuropeRiga,
        [EnumMember(Value = "(GMT+02:00) Asia/Beirut")]
        GMT0200AsiaBeirut,
        [EnumMember(Value = "(GMT+02:00) Africa/Maseru")]
        GMT0200AfricaMaseru,
        [EnumMember(Value = "(GMT+02:00) Africa/Tripoli")]
        GMT0200AfricaTripoli,
        [EnumMember(Value = "(GMT+02:00) Europe/Vilnius")]
        GMT0200EuropeVilnius,
        [EnumMember(Value = "(GMT+02:00) Africa/Blantyre")]
        GMT0200AfricaBlantyre,
        [EnumMember(Value = "(GMT+02:00) Europe/Chisinau")]
        GMT0200EuropeChisinau,
        [EnumMember(Value = "(GMT+02:00) Africa/Maputo")]
        GMT0200AfricaMaputo,
        [EnumMember(Value = "(GMT+02:00) Africa/Windhoek")]
        GMT0200AfricaWindhoek,
        [EnumMember(Value = "(GMT+02:00) Asia/Gaza")]
        GMT0200AsiaGaza,
        [EnumMember(Value = "(GMT+02:00) Asia/Hebron")]
        GMT0200AsiaHebron,
        [EnumMember(Value = "(GMT+02:00) Europe/Bucharest")]
        GMT0200EuropeBucharest,
        [EnumMember(Value = "(GMT+02:00) Europe/Kaliningrad")]
        GMT0200EuropeKaliningrad,
        [EnumMember(Value = "(GMT+02:00) Africa/Kigali")]
        GMT0200AfricaKigali,
        [EnumMember(Value = "(GMT+02:00) Africa/Johannesburg")]
        GMT0200AfricaJohannesburg,
        [EnumMember(Value = "(GMT+02:00) Africa/Mbabane")]
        GMT0200AfricaMbabane,
        [EnumMember(Value = "(GMT+02:00) Asia/Damascus")]
        GMT0200AsiaDamascus,
        [EnumMember(Value = "(GMT+02:00) Europe/Istanbul")]
        GMT0200EuropeIstanbul,
        [EnumMember(Value = "(GMT+02:00) Europe/Kiev")]
        GMT0200EuropeKiev,
        [EnumMember(Value = "(GMT+02:00) Europe/Uzhgorod")]
        GMT0200EuropeUzhgorod,
        [EnumMember(Value = "(GMT+02:00) Europe/Zaporozhye")]
        GMT0200EuropeZaporozhye,
        [EnumMember(Value = "(GMT+02:00) Africa/Lusaka")]
        GMT0200AfricaLusaka,
        [EnumMember(Value = "(GMT+02:00) Africa/Harare")]
        GMT0200AfricaHarare,
        [EnumMember(Value = "(GMT+02:00) Europe/Mariehamn")]
        GMT0200EuropeMariehamn,
        [EnumMember(Value = "(GMT+03:00) Antarctica/Syowa")]
        GMT0300AntarcticaSyowa,
        [EnumMember(Value = "(GMT+03:00) Asia/Bahrain")]
        GMT0300AsiaBahrain,
        [EnumMember(Value = "(GMT+03:00) Europe/Minsk")]
        GMT0300EuropeMinsk,
        [EnumMember(Value = "(GMT+03:00) Indian/Comoro")]
        GMT0300IndianComoro,
        [EnumMember(Value = "(GMT+03:00) Africa/Djibouti")]
        GMT0300AfricaDjibouti,
        [EnumMember(Value = "(GMT+03:00) Africa/Asmara")]
        GMT0300AfricaAsmara,
        [EnumMember(Value = "(GMT+03:00) Africa/Addis_Ababa")]
        GMT0300AfricaAddisAbaba,
        [EnumMember(Value = "(GMT+03:00) Asia/Baghdad")]
        GMT0300AsiaBaghdad,
        [EnumMember(Value = "(GMT+03:00) Africa/Nairobi")]
        GMT0300AfricaNairobi,
        [EnumMember(Value = "(GMT+03:00) Asia/Kuwait")]
        GMT0300AsiaKuwait,
        [EnumMember(Value = "(GMT+03:00) Indian/Antananarivo")]
        GMT0300IndianAntananarivo,
        [EnumMember(Value = "(GMT+03:00) Indian/Mayotte")]
        GMT0300IndianMayotte,
        [EnumMember(Value = "(GMT+03:00) Asia/Qatar")]
        GMT0300AsiaQatar,
        [EnumMember(Value = "(GMT+03:00) Europe/Moscow")]
        GMT0300EuropeMoscow,
        [EnumMember(Value = "(GMT+03:00) Europe/Simferopol")]
        GMT0300EuropeSimferopol,
        [EnumMember(Value = "(GMT+03:00) Europe/Volgograd")]
        GMT0300EuropeVolgograd,
        [EnumMember(Value = "(GMT+03:00) Asia/Riyadh")]
        GMT0300AsiaRiyadh,
        [EnumMember(Value = "(GMT+03:00) Africa/Mogadishu")]
        GMT0300AfricaMogadishu,
        [EnumMember(Value = "(GMT+03:00) Africa/Juba")]
        GMT0300AfricaJuba,
        [EnumMember(Value = "(GMT+03:00) Africa/Khartoum")]
        GMT0300AfricaKhartoum,
        [EnumMember(Value = "(GMT+03:00) Africa/Dar_es_Salaam")]
        GMT0300AfricaDarEsSalaam,
        [EnumMember(Value = "(GMT+03:00) Africa/Kampala")]
        GMT0300AfricaKampala,
        [EnumMember(Value = "(GMT+03:00) Asia/Aden")]
        GMT0300AsiaAden,
        [EnumMember(Value = "(GMT+04:00) Asia/Yerevan")]
        GMT0400AsiaYerevan,
        [EnumMember(Value = "(GMT+04:00) Asia/Baku")]
        GMT0400AsiaBaku,
        [EnumMember(Value = "(GMT+04:00) Asia/Tbilisi")]
        GMT0400AsiaTbilisi,
        [EnumMember(Value = "(GMT+04:00) Indian/Mauritius")]
        GMT0400IndianMauritius,
        [EnumMember(Value = "(GMT+04:00) Asia/Muscat")]
        GMT0400AsiaMuscat,
        [EnumMember(Value = "(GMT+04:00) Europe/Samara")]
        GMT0400EuropeSamara,
        [EnumMember(Value = "(GMT+04:00) Indian/Reunion")]
        GMT0400IndianReunion,
        [EnumMember(Value = "(GMT+04:00) Indian/Mahe")]
        GMT0400IndianMahe,
        [EnumMember(Value = "(GMT+04:00) Asia/Dubai")]
        GMT0400AsiaDubai,
        [EnumMember(Value = "(GMT+04:30) Asia/Kabul")]
        GMT0430AsiaKabul,
        [EnumMember(Value = "(GMT+04:30) Asia/Tehran")]
        GMT0430AsiaTehran,
        [EnumMember(Value = "(GMT+05:00) Antarctica/Mawson")]
        GMT0500AntarcticaMawson,
        [EnumMember(Value = "(GMT+05:00) Indian/Kerguelen")]
        GMT0500IndianKerguelen,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtau")]
        GMT0500AsiaAqtau,
        [EnumMember(Value = "(GMT+05:00) Asia/Aqtobe")]
        GMT0500AsiaAqtobe,
        [EnumMember(Value = "(GMT+05:00) Asia/Oral")]
        GMT0500AsiaOral,
        [EnumMember(Value = "(GMT+05:00) Indian/Maldives")]
        GMT0500IndianMaldives,
        [EnumMember(Value = "(GMT+05:00) Asia/Karachi")]
        GMT0500AsiaKarachi,
        [EnumMember(Value = "(GMT+05:00) Asia/Yekaterinburg")]
        GMT0500AsiaYekaterinburg,
        [EnumMember(Value = "(GMT+05:00) Asia/Dushanbe")]
        GMT0500AsiaDushanbe,
        [EnumMember(Value = "(GMT+05:00) Asia/Ashgabat")]
        GMT0500AsiaAshgabat,
        [EnumMember(Value = "(GMT+05:00) Asia/Samarkand")]
        GMT0500AsiaSamarkand,
        [EnumMember(Value = "(GMT+05:00) Asia/Tashkent")]
        GMT0500AsiaTashkent,
        [EnumMember(Value = "(GMT+05:30) Asia/Kolkata")]
        GMT0530AsiaKolkata,
        [EnumMember(Value = "(GMT+05:30) Asia/Colombo")]
        GMT0530AsiaColombo,
        [EnumMember(Value = "(GMT+05:45) Asia/Kathmandu")]
        GMT0545AsiaKathmandu,
        [EnumMember(Value = "(GMT+06:00) Antarctica/Vostok")]
        GMT0600AntarcticaVostok,
        [EnumMember(Value = "(GMT+06:00) Asia/Dhaka")]
        GMT0600AsiaDhaka,
        [EnumMember(Value = "(GMT+06:00) Asia/Thimphu")]
        GMT0600AsiaThimphu,
        [EnumMember(Value = "(GMT+06:00) Indian/Chagos")]
        GMT0600IndianChagos,
        [EnumMember(Value = "(GMT+06:00) Asia/Urumqi")]
        GMT0600AsiaUrumqi,
        [EnumMember(Value = "(GMT+06:00) Asia/Almaty")]
        GMT0600AsiaAlmaty,
        [EnumMember(Value = "(GMT+06:00) Asia/Qyzylorda")]
        GMT0600AsiaQyzylorda,
        [EnumMember(Value = "(GMT+06:00) Asia/Bishkek")]
        GMT0600AsiaBishkek,
        [EnumMember(Value = "(GMT+06:00) Asia/Novosibirsk")]
        GMT0600AsiaNovosibirsk,
        [EnumMember(Value = "(GMT+06:00) Asia/Omsk")]
        GMT0600AsiaOmsk,
        [EnumMember(Value = "(GMT+06:30) Indian/Cocos")]
        GMT0630IndianCocos,
        [EnumMember(Value = "(GMT+06:30) Asia/Rangoon")]
        GMT0630AsiaRangoon,
        [EnumMember(Value = "(GMT+07:00) Antarctica/Davis")]
        GMT0700AntarcticaDavis,
        [EnumMember(Value = "(GMT+07:00) Asia/Phnom_Penh")]
        GMT0700AsiaPhnomPenh,
        [EnumMember(Value = "(GMT+07:00) Indian/Christmas")]
        GMT0700IndianChristmas,
        [EnumMember(Value = "(GMT+07:00) Asia/Jakarta")]
        GMT0700AsiaJakarta,
        [EnumMember(Value = "(GMT+07:00) Asia/Pontianak")]
        GMT0700AsiaPontianak,
        [EnumMember(Value = "(GMT+07:00) Asia/Vientiane")]
        GMT0700AsiaVientiane,
        [EnumMember(Value = "(GMT+07:00) Asia/Hovd")]
        GMT0700AsiaHovd,
        [EnumMember(Value = "(GMT+07:00) Asia/Krasnoyarsk")]
        GMT0700AsiaKrasnoyarsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Novokuznetsk")]
        GMT0700AsiaNovokuznetsk,
        [EnumMember(Value = "(GMT+07:00) Asia/Bangkok")]
        GMT0700AsiaBangkok,
        [EnumMember(Value = "(GMT+07:00) Asia/Ho_Chi_Minh")]
        GMT0700AsiaHoChiMinh,
        [EnumMember(Value = "(GMT+08:00) Antarctica/Casey")]
        GMT0800AntarcticaCasey,
        [EnumMember(Value = "(GMT+08:00) Australia/Perth")]
        GMT0800AustraliaPerth,
        [EnumMember(Value = "(GMT+08:00) Asia/Brunei")]
        GMT0800AsiaBrunei,
        [EnumMember(Value = "(GMT+08:00) Asia/Shanghai")]
        GMT0800AsiaShanghai,
        [EnumMember(Value = "(GMT+08:00) Asia/Hong_Kong")]
        GMT0800AsiaHongKong,
        [EnumMember(Value = "(GMT+08:00) Asia/Makassar")]
        GMT0800AsiaMakassar,
        [EnumMember(Value = "(GMT+08:00) Asia/Macau")]
        GMT0800AsiaMacau,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuala_Lumpur")]
        GMT0800AsiaKualaLumpur,
        [EnumMember(Value = "(GMT+08:00) Asia/Kuching")]
        GMT0800AsiaKuching,
        [EnumMember(Value = "(GMT+08:00) Asia/Choibalsan")]
        GMT0800AsiaChoibalsan,
        [EnumMember(Value = "(GMT+08:00) Asia/Ulaanbaatar")]
        GMT0800AsiaUlaanbaatar,
        [EnumMember(Value = "(GMT+08:00) Asia/Manila")]
        GMT0800AsiaManila,
        [EnumMember(Value = "(GMT+08:00) Asia/Chita")]
        GMT0800AsiaChita,
        [EnumMember(Value = "(GMT+08:00) Asia/Irkutsk")]
        GMT0800AsiaIrkutsk,
        [EnumMember(Value = "(GMT+08:00) Asia/Singapore")]
        GMT0800AsiaSingapore,
        [EnumMember(Value = "(GMT+08:00) Asia/Taipei")]
        GMT0800AsiaTaipei,
        [EnumMember(Value = "(GMT+08:45) Australia/Eucla")]
        GMT0845AustraliaEucla,
        [EnumMember(Value = "(GMT+09:00) Asia/Jayapura")]
        GMT0900AsiaJayapura,
        [EnumMember(Value = "(GMT+09:00) Asia/Tokyo")]
        GMT0900AsiaTokyo,
        [EnumMember(Value = "(GMT+09:00) Asia/Pyongyang")]
        GMT0900AsiaPyongyang,
        [EnumMember(Value = "(GMT+09:00) Asia/Seoul")]
        GMT0900AsiaSeoul,
        [EnumMember(Value = "(GMT+09:00) Pacific/Palau")]
        GMT0900PacificPalau,
        [EnumMember(Value = "(GMT+09:00) Asia/Khandyga")]
        GMT0900AsiaKhandyga,
        [EnumMember(Value = "(GMT+09:00) Asia/Yakutsk")]
        GMT0900AsiaYakutsk,
        [EnumMember(Value = "(GMT+09:00) Asia/Dili")]
        GMT0900AsiaDili,
        [EnumMember(Value = "(GMT+09:30) Australia/Darwin")]
        GMT0930AustraliaDarwin,
        [EnumMember(Value = "(GMT+10:00) Antarctica/DumontDUrville")]
        GMT1000AntarcticaDumontDUrville,
        [EnumMember(Value = "(GMT+10:00) Australia/Brisbane")]
        GMT1000AustraliaBrisbane,
        [EnumMember(Value = "(GMT+10:00) Australia/Lindeman")]
        GMT1000AustraliaLindeman,
        [EnumMember(Value = "(GMT+10:00) Pacific/Guam")]
        GMT1000PacificGuam,
        [EnumMember(Value = "(GMT+10:00) Pacific/Chuuk")]
        GMT1000PacificChuuk,
        [EnumMember(Value = "(GMT+10:00) Pacific/Saipan")]
        GMT1000PacificSaipan,
        [EnumMember(Value = "(GMT+10:00) Pacific/Port_Moresby")]
        GMT1000PacificPortMoresby,
        [EnumMember(Value = "(GMT+10:00) Asia/Magadan")]
        GMT1000AsiaMagadan,
        [EnumMember(Value = "(GMT+10:00) Asia/Sakhalin")]
        GMT1000AsiaSakhalin,
        [EnumMember(Value = "(GMT+10:00) Asia/Ust-Nera")]
        GMT1000AsiaUstNera,
        [EnumMember(Value = "(GMT+10:00) Asia/Vladivostok")]
        GMT1000AsiaVladivostok,
        [EnumMember(Value = "(GMT+10:30) Australia/Adelaide")]
        GMT1030AustraliaAdelaide,
        [EnumMember(Value = "(GMT+10:30) Australia/Broken_Hill")]
        GMT1030AustraliaBrokenHill,
        [EnumMember(Value = "(GMT+11:00) Australia/Currie")]
        GMT1100AustraliaCurrie,
        [EnumMember(Value = "(GMT+11:00) Australia/Hobart")]
        GMT1100AustraliaHobart,
        [EnumMember(Value = "(GMT+11:00) Australia/Lord_Howe")]
        GMT1100AustraliaLordHowe,
        [EnumMember(Value = "(GMT+11:00) Antarctica/Macquarie")]
        GMT1100AntarcticaMacquarie,
        [EnumMember(Value = "(GMT+11:00) Australia/Melbourne")]
        GMT1100AustraliaMelbourne,
        [EnumMember(Value = "(GMT+11:00) Australia/Sydney")]
        GMT1100AustraliaSydney,
        [EnumMember(Value = "(GMT+11:00) Pacific/Kosrae")]
        GMT1100PacificKosrae,
        [EnumMember(Value = "(GMT+11:00) Pacific/Pohnpei")]
        GMT1100PacificPohnpei,
        [EnumMember(Value = "(GMT+11:00) Pacific/Noumea")]
        GMT1100PacificNoumea,
        [EnumMember(Value = "(GMT+11:00) Pacific/Bougainville")]
        GMT1100PacificBougainville,
        [EnumMember(Value = "(GMT+11:00) Asia/Srednekolymsk")]
        GMT1100AsiaSrednekolymsk,
        [EnumMember(Value = "(GMT+11:00) Pacific/Guadalcanal")]
        GMT1100PacificGuadalcanal,
        [EnumMember(Value = "(GMT+11:00) Pacific/Efate")]
        GMT1100PacificEfate,
        [EnumMember(Value = "(GMT+11:30) Pacific/Norfolk")]
        GMT1130PacificNorfolk,
        [EnumMember(Value = "(GMT+12:00) Pacific/Fiji")]
        GMT1200PacificFiji,
        [EnumMember(Value = "(GMT+12:00) Pacific/Tarawa")]
        GMT1200PacificTarawa,
        [EnumMember(Value = "(GMT+12:00) Pacific/Kwajalein")]
        GMT1200PacificKwajalein,
        [EnumMember(Value = "(GMT+12:00) Pacific/Majuro")]
        GMT1200PacificMajuro,
        [EnumMember(Value = "(GMT+12:00) Pacific/Nauru")]
        GMT1200PacificNauru,
        [EnumMember(Value = "(GMT+12:00) Asia/Anadyr")]
        GMT1200AsiaAnadyr,
        [EnumMember(Value = "(GMT+12:00) Asia/Kamchatka")]
        GMT1200AsiaKamchatka,
        [EnumMember(Value = "(GMT+12:00) Pacific/Funafuti")]
        GMT1200PacificFunafuti,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wake")]
        GMT1200PacificWake,
        [EnumMember(Value = "(GMT+12:00) Pacific/Wallis")]
        GMT1200PacificWallis,
        [EnumMember(Value = "(GMT+13:00) Antarctica/McMurdo")]
        GMT1300AntarcticaMcMurdo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Enderbury")]
        GMT1300PacificEnderbury,
        [EnumMember(Value = "(GMT+13:00) Pacific/Auckland")]
        GMT1300PacificAuckland,
        [EnumMember(Value = "(GMT+13:00) Pacific/Fakaofo")]
        GMT1300PacificFakaofo,
        [EnumMember(Value = "(GMT+13:00) Pacific/Tongatapu")]
        GMT1300PacificTongatapu,
        [EnumMember(Value = "(GMT+13:45) Pacific/Chatham")]
        GMT1345PacificChatham,
        [EnumMember(Value = "(GMT+14:00) Pacific/Kiritimati")]
        GMT1400PacificKiritimati,
        [EnumMember(Value = "(GMT+14:00) Pacific/Apia")]
        GMT1400PacificApia
    }

    public enum conditionInput
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
