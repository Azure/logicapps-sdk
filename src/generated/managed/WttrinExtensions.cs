//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wttrin
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WttrinActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wttrin")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> WeatherGet(Expression<Func<string>> location, Expression<Func<viewInput>> view = null, Expression<Func<langInput>> lang = null)
        {
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_location.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Queries["lang"] = Convert.ToString("en");
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WttrinTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        QuietVersionNoWeatherReportText,
        [EnumMember(Value = "Q")]
        SuperquietVersionNoWeatherReportNoCityName,
        [EnumMember(Value = "T")]
        SwitchTerminalSequencesOffNoColors
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
