//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.VideoindexerV2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VideoindexerV2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<string> GetAccountAccessToken(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<bool>> allowEdit)
        {
            var apiCallPath = String.Format("/auth/{0}/Accounts/{1}/AccessToken", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["allowEdit"] = ExpressionConverter.Convert(allowEdit);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<MicrosoftVideoIndexerCommonContractsV2AccountContractSlim[]> GetAccounts()
        {
            var apiCallPath = "/auth/Trial/Accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MicrosoftVideoIndexerCommonContractsV2AccountContractSlim[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<MicrosoftVideoIndexerCommonContractsV2PlaylistSearchResultV2> ListVideos(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> accessToken, Expression<Func<int>> pageSize = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionAction<MicrosoftVideoIndexerCommonContractsV2PlaylistSearchResultV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<UploadResponse> UploadVideo(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> accessToken, Expression<Func<string>> name, Expression<Func<string>> description = null, Expression<Func<string>> partition = null, Expression<Func<string>> externalId = null, Expression<Func<string>> callbackUrl = null, Expression<Func<string>> metadata = null, Expression<Func<languageInput>> language = null, Expression<Func<string>> videoUrl = null, Expression<Func<string>> fileName = null, Expression<Func<indexingPresetInput>> indexingPreset = null, Expression<Func<streamingPresetInput>> streamingPreset = null, Expression<Func<string>> linguisticModelId = null, Expression<Func<privacyInput>> privacy = null, Expression<Func<string>> externalUrl = null, Expression<Func<object>> body = null, Expression<Func<string>> assetId = null, Expression<Func<priorityInput>> priority = null, Expression<Func<string>> brandsCategories = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (description != null)
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            if (partition != null)
                callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
            if (externalId != null)
                callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
            if (metadata != null)
                callPayload.Queries["metadata"] = ExpressionConverter.Convert(metadata);
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            if (videoUrl != null)
                callPayload.Queries["videoUrl"] = ExpressionConverter.Convert(videoUrl);
            if (fileName != null)
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            if (indexingPreset != null)
                callPayload.Queries["indexingPreset"] = ExpressionConverter.Convert(indexingPreset);
            if (streamingPreset != null)
                callPayload.Queries["streamingPreset"] = ExpressionConverter.Convert(streamingPreset);
            if (linguisticModelId != null)
                callPayload.Queries["linguisticModelId"] = ExpressionConverter.Convert(linguisticModelId);
            if (privacy != null)
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(privacy);
            if (externalUrl != null)
                callPayload.Queries["externalUrl"] = ExpressionConverter.Convert(externalUrl);
            if (assetId != null)
                callPayload.Queries["assetId"] = ExpressionConverter.Convert(assetId);
            if (priority != null)
                callPayload.Queries["priority"] = ExpressionConverter.Convert(priority);
            if (brandsCategories != null)
                callPayload.Queries["brandsCategories"] = ExpressionConverter.Convert(brandsCategories);
            return new ApiConnectionAction<UploadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<GetIndexResponse> GetVideoIndex(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/Index", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            callPayload.Queries["language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<GetIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<MicrosoftVideoIndexerCommonContractsV2PlaylistSearchResultV2> SearchVideos(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> accessToken, Expression<Func<string>> query = null, Expression<Func<textScopeInput>> textScope = null, Expression<Func<privacyInput>> privacy = null, Expression<Func<string>> id = null, Expression<Func<string>> partition = null, Expression<Func<string>> owner = null, Expression<Func<string>> face = null, Expression<Func<string>> externalId = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> skip = null, Expression<Func<sourceLanguageInput>> sourceLanguage = null, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/Search", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (textScope != null)
                callPayload.Queries["textScope"] = ExpressionConverter.Convert(textScope);
            if (privacy != null)
                callPayload.Queries["privacy"] = ExpressionConverter.Convert(privacy);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (partition != null)
                callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
            if (owner != null)
                callPayload.Queries["owner"] = ExpressionConverter.Convert(owner);
            if (face != null)
                callPayload.Queries["face"] = ExpressionConverter.Convert(face);
            if (externalId != null)
                callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["sourceLanguage"] = Convert.ToString("English");
            if (sourceLanguage != null)
                callPayload.Queries["sourceLanguage"] = ExpressionConverter.Convert(sourceLanguage);
            callPayload.Queries["language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction<MicrosoftVideoIndexerCommonContractsV2PlaylistSearchResultV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IWorkflowAction DeleteVideo(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IWorkflowAction DeleteVideoSourceFile(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/SourceFile", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<MicrosoftVideoIndexerCommonContractsV2AccountContractSlim> GetAccount(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction<MicrosoftVideoIndexerCommonContractsV2AccountContractSlim>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IWorkflowAction ReIndexVideo(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken, Expression<Func<indexingPresetInput>> indexingPreset = null, Expression<Func<streamingPresetInput>> streamingPreset = null, Expression<Func<string>> callbackUrl = null, Expression<Func<priorityInput>> priority = null, Expression<Func<string>> brandsCategories = null, Expression<Func<sourceLanguageInput>> sourceLanguage = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/ReIndex", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            if (indexingPreset != null)
                callPayload.Queries["indexingPreset"] = ExpressionConverter.Convert(indexingPreset);
            if (streamingPreset != null)
                callPayload.Queries["streamingPreset"] = ExpressionConverter.Convert(streamingPreset);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
            if (priority != null)
                callPayload.Queries["priority"] = ExpressionConverter.Convert(priority);
            if (brandsCategories != null)
                callPayload.Queries["brandsCategories"] = ExpressionConverter.Convert(brandsCategories);
            callPayload.Queries["sourceLanguage"] = Convert.ToString("English");
            if (sourceLanguage != null)
                callPayload.Queries["sourceLanguage"] = ExpressionConverter.Convert(sourceLanguage);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<string> GetVideoIdByExternalId(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> externalId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/GetIdByExternalId", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IWorkflowAction UpdateFace(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<int>> faceId, Expression<Func<string>> accessToken, Expression<Func<string>> newName)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/Index/Faces/{3}", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1), ExpressionConverter.ConvertWithUrlEncoding(faceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            callPayload.Queries["newName"] = ExpressionConverter.Convert(newName);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<string> GetVideoCaptions(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken, Expression<Func<formatInput>> format, Expression<Func<languageInput>> language = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/Captions", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Queries["language"] = Convert.ToString("English");
            if (language != null)
                callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IBodyWorkflowAction<MicrosoftVideoIndexerCommonContractsV2ThumbNail> GetThumbnail(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> thumbnailId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/Thumbnails/{3}", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1), ExpressionConverter.ConvertWithUrlEncoding(thumbnailId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction<MicrosoftVideoIndexerCommonContractsV2ThumbNail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "videoindexer-v2")]
        public IWorkflowAction UpdateTranscript(Expression<Func<locationInput>> location, Expression<Func<string>> accountId, Expression<Func<string>> videoId, Expression<Func<string>> accessToken, Expression<Func<languageInput>> language, Expression<Func<string>> content = null, Expression<Func<string>> callbackUrl = null, Expression<Func<bool>> setAsSourceLanguage = null, Expression<Func<bool>> sendSuccessEmail = null)
        {
            var apiCallPath = String.Format("/{0}/Accounts/{1}/Videos/{2}/Index/Transcript", ExpressionConverter.ConvertWithUrlEncoding(location, 1), ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(videoId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accessToken"] = ExpressionConverter.Convert(accessToken);
            callPayload.Queries["language"] = ExpressionConverter.Convert(language);
            if (callbackUrl != null)
                callPayload.Queries["callbackUrl"] = ExpressionConverter.Convert(callbackUrl);
            callPayload.Queries["setAsSourceLanguage"] = Convert.ToString(false);
            if (setAsSourceLanguage != null)
                callPayload.Queries["setAsSourceLanguage"] = ExpressionConverter.Convert(setAsSourceLanguage);
            callPayload.Queries["sendSuccessEmail"] = Convert.ToString(false);
            if (sendSuccessEmail != null)
                callPayload.Queries["sendSuccessEmail"] = ExpressionConverter.Convert(sendSuccessEmail);
            callPayload.Body = ExpressionConverter.ConvertO(content);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class VideoindexerV2Triggers([ConnectionName] string connectionId)
    {
    }

    public enum locationInput
    {
        [EnumMember(Value = "trial")]
        Trial,
        [EnumMember(Value = "eastus")]
        Eastus,
        [EnumMember(Value = "westus2")]
        Westus2,
        [EnumMember(Value = "eastasia")]
        Eastasia,
        [EnumMember(Value = "northeurope")]
        Northeurope,
        [EnumMember(Value = "westeurope")]
        Westeurope,
        [EnumMember(Value = "southeastasia")]
        Southeastasia,
        [EnumMember(Value = "eastus2")]
        Eastus2,
        [EnumMember(Value = "australiaeast")]
        Australiaeast,
        [EnumMember(Value = "southcentralus")]
        Southcentralus,
        [EnumMember(Value = "japaneast")]
        Japaneast,
        [EnumMember(Value = "uksouth")]
        Uksouth,
        [EnumMember(Value = "switzerlandnorth")]
        Switzerlandnorth,
        [EnumMember(Value = "switzerlandwest")]
        Switzerlandwest,
        [EnumMember(Value = "centralindia")]
        Centralindia,
        [EnumMember(Value = "canadacentral")]
        Canadacentral,
        [EnumMember(Value = "westus")]
        Westus,
        [EnumMember(Value = "northcentralus")]
        Northcentralus,
        [EnumMember(Value = "francecentral")]
        Francecentral,
        [EnumMember(Value = "centralus")]
        Centralus,
        [EnumMember(Value = "koreacentral")]
        Koreacentral,
        [EnumMember(Value = "brazilsouth")]
        Brazilsouth,
        [EnumMember(Value = "japanwest")]
        Japanwest,
        [EnumMember(Value = "westcentralus")]
        Westcentralus
    }

    public class MicrosoftVideoIndexerCommonContractsV2AccountContractSlim
    {
        [JsonProperty("id")]
        public string AccountID { get; set; }

        [JsonProperty("name")]
        public string AccountName { get; set; }

        [JsonProperty("location")]
        public string AccountLocation { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }

        [JsonProperty("url")]
        public string AccountURL { get; set; }
    }

    public class MicrosoftVideoIndexerCommonContractsV2PlaylistSearchResultV2
    {
        [JsonProperty("results")]
        public MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2[] Results { get; set; }

        [JsonProperty("nextPage")]
        public MicrosoftVideoIndexerCommonContractsV2SearchPage NextPage { get; set; }
    }

    public class MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2
    {
        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("id")]
        public string VideoID { get; set; }

        [JsonProperty("partition")]
        public string Partition { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("lastIndexed")]
        public string LastIndexed { get; set; }

        [JsonProperty("privacyMode")]
        public MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2PrivacyType Privacy { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("isOwned")]
        public bool IsOwned { get; set; }

        [JsonProperty("isBase")]
        public bool IsBase { get; set; }

        [JsonProperty("state")]
        public MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2StateType State { get; set; }

        [JsonProperty("processingProgress")]
        public string ProcessingProgress { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("thumbnailVideoId")]
        public string ThumbnailVideoID { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailID { get; set; }

        [JsonProperty("searchMatches")]
        public JToken SearchMatches { get; set; }

        [JsonProperty("indexingPreset")]
        public string IndexingPreset { get; set; }

        [JsonProperty("streamingPreset")]
        public string StreamingPreset { get; set; }

        [JsonProperty("sourceLanguage")]
        public string SourceLanguage { get; set; }
    }

    public enum MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2PrivacyType
    {
        Private,
        Public
    }

    public enum MicrosoftVideoIndexerCommonContractsV2SinglePlaylistSearchResultV2StateType
    {
        Uploaded,
        Processing,
        Processed,
        Failed,
        Quarantined
    }

    public class MicrosoftVideoIndexerCommonContractsV2SearchPage
    {
        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }
    }

    public class UploadResponse
    {
        [JsonProperty("id")]
        public string VideoID { get; set; }
    }

    public enum languageInput
    {
        English,
        Spanish,
        Russian,
        Japanese,
        German,
        French,
        Portuguese,
        Italian,
        Chinese,
        Filipino,
        Arabic,
        [EnumMember(Value = "ar-EG")]
        ArEG,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "zh-Hans")]
        ZhHans,
        [EnumMember(Value = "fil-PH")]
        FilPH,
        [EnumMember(Value = "Af-ZA")]
        AfZA,
        [EnumMember(Value = "Bn-BD")]
        BnBD,
        [EnumMember(Value = "Bs-Latn")]
        BsLatn,
        [EnumMember(Value = "Bg-BG")]
        BgBG,
        [EnumMember(Value = "Ca-ES")]
        CaES,
        [EnumMember(Value = "Hr-HR")]
        HrHR,
        [EnumMember(Value = "Cs-CZ")]
        CsCZ,
        [EnumMember(Value = "Da-DK")]
        DaDK,
        [EnumMember(Value = "Nl-NL")]
        NlNL,
        [EnumMember(Value = "En-FJ")]
        EnFJ,
        [EnumMember(Value = "En-GB")]
        EnGB,
        [EnumMember(Value = "En-WS")]
        EnWS,
        [EnumMember(Value = "Es-MX")]
        EsMX,
        [EnumMember(Value = "Et-EE")]
        EtEE,
        [EnumMember(Value = "Fi-FI")]
        FiFI,
        [EnumMember(Value = "El-GR")]
        ElGR,
        [EnumMember(Value = "Fr-HT")]
        FrHT,
        [EnumMember(Value = "He-IL")]
        HeIL,
        [EnumMember(Value = "Hi-IN")]
        HiIN,
        [EnumMember(Value = "Hu-HU")]
        HuHU,
        [EnumMember(Value = "Id-ID")]
        IdID,
        [EnumMember(Value = "Sw-KE")]
        SwKE,
        [EnumMember(Value = "Ko-KR")]
        KoKR,
        [EnumMember(Value = "Lv-LV")]
        LvLV,
        [EnumMember(Value = "Lt-LT")]
        LtLT,
        [EnumMember(Value = "Mg-MG")]
        MgMG,
        [EnumMember(Value = "Ms-MY")]
        MsMY,
        [EnumMember(Value = "Mt-MT")]
        MtMT,
        [EnumMember(Value = "Nb-NO")]
        NbNO,
        [EnumMember(Value = "Fa-IR")]
        FaIR,
        [EnumMember(Value = "Pl-PL")]
        PlPL,
        [EnumMember(Value = "Ro-RO")]
        RoRO,
        [EnumMember(Value = "Sr-Cyrl-RS")]
        SrCyrlRS,
        [EnumMember(Value = "Sr-Latn-RS")]
        SrLatnRS,
        [EnumMember(Value = "Sk-SK")]
        SkSK,
        [EnumMember(Value = "Sl-SI")]
        SlSI,
        [EnumMember(Value = "Sv-SE")]
        SvSE,
        [EnumMember(Value = "Ta-IN")]
        TaIN,
        [EnumMember(Value = "Th-TH")]
        ThTH,
        [EnumMember(Value = "To-TO")]
        ToTO,
        [EnumMember(Value = "Tr-TR")]
        TrTR,
        [EnumMember(Value = "Uk-UA")]
        UkUA,
        [EnumMember(Value = "Ur-PK")]
        UrPK,
        [EnumMember(Value = "Vi-VN")]
        ViVN,
        [EnumMember(Value = "Zh-Hant")]
        ZhHant
    }

    public enum indexingPresetInput
    {
        Default,
        AudioOnly,
        DefaultWithNoiseReduction,
        VideoOnly
    }

    public enum streamingPresetInput
    {
        Default,
        SingleBitrate,
        AdaptiveBitrate,
        NoStreaming
    }

    public enum privacyInput
    {
        Private,
        Public
    }

    public enum priorityInput
    {
        Low,
        Normal,
        High
    }

    public class GetIndexResponse
    {
        [JsonProperty("accountId")]
        public string AccountID { get; set; }

        [JsonProperty("id")]
        public string VideoID { get; set; }

        [JsonProperty("partition")]
        public string VideoPartition { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("privacyMode")]
        public GetIndexResponsePrivacyType Privacy { get; set; }

        [JsonProperty("state")]
        public GetIndexResponseStateType State { get; set; }

        [JsonProperty("isOwned")]
        public bool IsOwned { get; set; }

        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }

        [JsonProperty("isBase")]
        public bool IsBase { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("summarizedInsights")]
        public JToken SummarizedInsights { get; set; }

        [JsonProperty("videos")]
        public JToken[] VideosInsights { get; set; }

        [JsonProperty("videosRanges")]
        public JToken VideoRanges { get; set; }
    }

    public enum GetIndexResponsePrivacyType
    {
        Private,
        Public
    }

    public enum GetIndexResponseStateType
    {
        Uploaded,
        Processing,
        Processed,
        Failed,
        Quarantined
    }

    public enum textScopeInput
    {
        Transcript,
        Ocr
    }

    public enum sourceLanguageInput
    {
        Auto,
        English,
        Spanish,
        Russian,
        Japanese,
        German,
        French,
        Portuguese,
        Italian,
        Chinese,
        [EnumMember(Value = "ar-EG")]
        ArEG,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "zh-CN")]
        ZhCN,
        [EnumMember(Value = "hi-IN")]
        HiIN,
        [EnumMember(Value = "ko-KR")]
        KoKR
    }

    public enum formatInput
    {
        [EnumMember(Value = "vtt")]
        Vtt
    }

    public class MicrosoftVideoIndexerCommonContractsV2ThumbNail
    {
        [JsonProperty("$content-type")]
        public string TheContentType { get; set; }

        [JsonProperty("$content")]
        public string TheContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.VideoindexerV2;

    public partial class WorkflowManagedActions
    {
        public VideoindexerV2Actions VideoindexerV2(string connectionId) => new VideoindexerV2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VideoindexerV2Triggers VideoindexerV2(string connectionId) => new VideoindexerV2Triggers(connectionId);
    }
}