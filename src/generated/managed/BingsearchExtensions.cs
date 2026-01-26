//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bingsearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BingsearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bingsearch")]
        public IBodyWorkflowAction<NewsArticle[]> GetNews(Expression<Func<string>> q, Expression<Func<mktInput>> mkt = null, Expression<Func<safeSearchInput>> safeSearch = null, Expression<Func<string>> count = null, Expression<Func<string>> offset = null)
        {
            var apiCallPath = "/news/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["mkt"] = Convert.ToString("en-US");
            if (mkt != null)
                callPayload.Queries["mkt"] = ExpressionConverter.Convert(mkt);
            callPayload.Queries["safeSearch"] = Convert.ToString("Moderate");
            if (safeSearch != null)
                callPayload.Queries["safeSearch"] = ExpressionConverter.Convert(safeSearch);
            callPayload.Queries["count"] = Convert.ToString("20");
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NewsArticle[]>(callPayload);
        }
    }

    public class BingsearchTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewsArticle[]> TrigNewNews(Expression<Func<string>> q, Expression<Func<mktInput>> mkt = null, Expression<Func<safeSearchInput>> safeSearch = null, Expression<Func<string>> count = null, Expression<Func<string>> offset = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/news/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["mkt"] = Convert.ToString("en-US");
            if (mkt != null)
                callPayload.Queries["mkt"] = ExpressionConverter.Convert(mkt);
            callPayload.Queries["safeSearch"] = Convert.ToString("Moderate");
            if (safeSearch != null)
                callPayload.Queries["safeSearch"] = ExpressionConverter.Convert(safeSearch);
            callPayload.Queries["count"] = Convert.ToString("20");
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionTrigger<NewsArticle[]>(callPayload, triggerName, recurrence);
        }
    }

    public class NewsArticle
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public enum mktInput
    {
        [EnumMember(Value = "es-AR")]
        EsAR,
        [EnumMember(Value = "en-AU")]
        EnAU,
        [EnumMember(Value = "de-AT")]
        DeAT,
        [EnumMember(Value = "nl-BE")]
        NlBE,
        [EnumMember(Value = "fr-BE")]
        FrBE,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "en-CA")]
        EnCA,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "es-CL")]
        EsCL,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "zh-HK")]
        ZhHK,
        [EnumMember(Value = "en-IN")]
        EnIN,
        [EnumMember(Value = "en-ID")]
        EnID,
        [EnumMember(Value = "en-IE")]
        EnIE,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "ko-KR")]
        KoKR,
        [EnumMember(Value = "en-MY")]
        EnMY,
        [EnumMember(Value = "es-MX")]
        EsMX,
        [EnumMember(Value = "nl-NL")]
        NlNL,
        [EnumMember(Value = "en-NZ")]
        EnNZ,
        [EnumMember(Value = "no-NO")]
        NoNO,
        [EnumMember(Value = "zh-CN")]
        ZhCN,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "pt-PT")]
        PtPT,
        [EnumMember(Value = "en-PH")]
        EnPH,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "ar-SA")]
        ArSA,
        [EnumMember(Value = "en-ZA")]
        EnZA,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "fr-CH")]
        FrCH,
        [EnumMember(Value = "de-CH")]
        DeCH,
        [EnumMember(Value = "zh-TW")]
        ZhTW,
        [EnumMember(Value = "tr-TR")]
        TrTR,
        [EnumMember(Value = "en-GB")]
        EnGB,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-US")]
        EsUS
    }

    public enum safeSearchInput
    {
        Moderate,
        Off,
        Strict
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bingsearch;

    public partial class WorkflowManagedActions
    {
        public BingsearchActions Bingsearch(string connectionId) => new BingsearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BingsearchTriggers Bingsearch(string connectionId) => new BingsearchTriggers(connectionId);
    }
}