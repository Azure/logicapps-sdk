//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Funtranslationsip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FuntranslationsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "funtranslationsip")]
        [WorkflowExpressionFactory(nameof(__BuildTranslate))]
        public IBodyWorkflowAction<TranslatePostResponse> Translate([WorkflowExpression] Func<languageInput> language, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranslatePostResponse> __BuildTranslate(WorkflowValue<languageInput> language, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(language, nameof(language), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<TranslatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(language, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TranslatePostResponse>(callPayload);
            });
        }
    }

    public class FuntranslationsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TranslatePostResponse
    {
        [JsonProperty("success")]
        public TranslatePostResponseSuccessType Success { get; set; }

        [JsonProperty("contents")]
        public TranslatePostResponseContentsType Contents { get; set; }
    }

    public class TranslatePostResponseSuccessType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TranslatePostResponseContentsType
    {
        [JsonProperty("translation")]
        public string Translation { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("translated")]
        public string Translated { get; set; }
    }

    public enum languageInput
    {
        [EnumMember(Value = "aldmeris")]
        Aldmeris,
        [EnumMember(Value = "ayleidoon")]
        Ayleidoon,
        [EnumMember(Value = "chef")]
        Chef,
        [EnumMember(Value = "cheunh")]
        Cheunh,
        [EnumMember(Value = "doge")]
        Doge,
        [EnumMember(Value = "dolan")]
        Dolan,
        [EnumMember(Value = "dothraki")]
        Dothraki,
        [EnumMember(Value = "dovahzul")]
        Dovahzul,
        [EnumMember(Value = "draconic")]
        Draconic,
        [EnumMember(Value = "emoji")]
        Emoji,
        [EnumMember(Value = "enderman")]
        Enderman,
        [EnumMember(Value = "english-contraction")]
        EnglishContraction,
        [EnumMember(Value = "ermahgerd")]
        Ermahgerd,
        [EnumMember(Value = "ferb-latin")]
        FerbLatin,
        [EnumMember(Value = "fudd")]
        Fudd,
        [EnumMember(Value = "groot")]
        Groot,
        [EnumMember(Value = "gungan")]
        Gungan,
        [EnumMember(Value = "hodor")]
        Hodor,
        [EnumMember(Value = "huttese")]
        Huttese,
        [EnumMember(Value = "inflationary-english")]
        InflationaryEnglish,
        [EnumMember(Value = "klingon")]
        Klingon,
        [EnumMember(Value = "leetspeak")]
        Leetspeak,
        [EnumMember(Value = "mandalorian")]
        Mandalorian,
        [EnumMember(Value = "minion")]
        Minion,
        [EnumMember(Value = "morse")]
        MorseCode,
        [EnumMember(Value = "navi")]
        Navi,
        [EnumMember(Value = "numbers")]
        EnglishToNumbers,
        [EnumMember(Value = "oldenglish")]
        OldEnglish,
        [EnumMember(Value = "orcish")]
        Orcish,
        [EnumMember(Value = "pig-latin")]
        PigLatin,
        [EnumMember(Value = "pirate")]
        Pirate,
        [EnumMember(Value = "post-modern")]
        PostmodernEnglish,
        [EnumMember(Value = "quenya")]
        Quenya,
        [EnumMember(Value = "roman-numerals")]
        RomanNumerals,
        [EnumMember(Value = "romulan")]
        Romulan,
        [EnumMember(Value = "shakespeare")]
        Shakespearean,
        [EnumMember(Value = "sindarin")]
        Sindarin,
        [EnumMember(Value = "sith")]
        Sith,
        [EnumMember(Value = "thuum")]
        Thuum,
        [EnumMember(Value = "ubbi-dubbi")]
        UbbiDubbi,
        [EnumMember(Value = "valspeak")]
        Valleyspeak,
        [EnumMember(Value = "valyrian")]
        Valyrian,
        [EnumMember(Value = "vulcan")]
        Vulcan,
        [EnumMember(Value = "wheel-of-time-old-tongue")]
        AWheelOfTimeOldEnglish,
        [EnumMember(Value = "wow")]
        Wow,
        [EnumMember(Value = "yoda")]
        Yoda
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Funtranslationsip;

    public partial class WorkflowManagedActions
    {
        public FuntranslationsipActions Funtranslationsip(string connectionId) => new FuntranslationsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FuntranslationsipTriggers Funtranslationsip(string connectionId) => new FuntranslationsipTriggers(connectionId);
    }
}
