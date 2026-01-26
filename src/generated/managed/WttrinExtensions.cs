//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wttrin
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WttrinActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wttrin")]
        public IBodyWorkflowAction<string> WeatherGet(Expression<Func<string>> location, Expression<Func<viewInput>> view = null, Expression<Func<langInput>> lang = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(location, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            callPayload.Queries["lang"] = Convert.ToString("en");
            if (lang != null)
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class WttrinTriggers([ConnectionName] string connectionId)
    {
    }

    public enum viewInput
    {
        [EnumMember(Value = "1")]
        CurrentWeatherAndTodaySForecast,
        [EnumMember(Value = "2")]
        CurrentWeatherAndTodayAndTomorrowSForecast,
        [EnumMember(Value = "A")]
        IgnoreUserAgentAndForceANSIOutputFormat,
        [EnumMember(Value = "d")]
        RestrictOutputToStandardConsoleFontGlyphs,
        [EnumMember(Value = "n")]
        NarrowVersionOnlyDayAndNight,
        [EnumMember(Value = "q")]
        QuietVersionNo"WeatherReport"Text,
        [EnumMember(Value = "Q")]
        SuperquietVersionNo"WeatherReport"NoCityName,
        [EnumMember(Value = "T")]
        SwitchTerminalSequencesOffNoColors
    }

    public enum langInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "am")]
        Am,
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "af")]
        Af,
        [EnumMember(Value = "be")]
        Be,
        [EnumMember(Value = "bn")]
        Bn,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "fa")]
        Fa,
        [EnumMember(Value = "gl")]
        Gl,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "ia")]
        Ia,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "mg")]
        Mg,
        [EnumMember(Value = "nb")]
        Nb,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "oc")]
        Oc,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi,
        [EnumMember(Value = "zh-cn")]
        ZhCn,
        [EnumMember(Value = "zh-tw")]
        ZhTw
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wttrin;

    public partial class WorkflowManagedActions
    {
        public WttrinActions Wttrin(string connectionId) => new WttrinActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WttrinTriggers Wttrin(string connectionId) => new WttrinTriggers(connectionId);
    }
}