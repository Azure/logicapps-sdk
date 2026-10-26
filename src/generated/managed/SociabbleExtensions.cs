//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SociabbleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendAlertRequest(Expression<Func<SendAlertRequestInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alerts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAudiencesResponseItem[], ApiConnectionActionConfiguration> GetAudiences()
        {
            return new DeferredBodyAction<GetAudiencesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/companies/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAudiencesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetChannelsResponseItem[], ApiConnectionActionConfiguration> GetChannels()
        {
            return new DeferredBodyAction<GetChannelsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/channels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetChannelsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetCategoriesResponseItem[], ApiConnectionActionConfiguration> GetCategories()
        {
            return new DeferredBodyAction<GetCategoriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCategoriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<InternalContent, ApiConnectionActionConfiguration> CreateInternalNews(Expression<Func<CreateInternalNewsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InternalContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/internalnews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InternalContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<ExternalContent, ApiConnectionActionConfiguration> CreateExternalContent(Expression<Func<CreateExternalContentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExternalContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExternalContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaSuggestContent, ApiConnectionActionConfiguration> CtaSuggestContentCreation(Expression<Func<CtaSuggestContentCreationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CtaSuggestContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/Cta/Suggest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CtaSuggestContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaInvitationContent, ApiConnectionActionConfiguration> CtaInvitationContentCreation(Expression<Func<CtaInvitationContentCreationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CtaInvitationContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/Cta/Invitation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CtaInvitationContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaMobileContent, ApiConnectionActionConfiguration> CtaMobileContentCreation(Expression<Func<CtaMobileContentCreationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CtaMobileContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/Cta/Mobile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CtaMobileContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<CtaEventContent, ApiConnectionActionConfiguration> CtaEventCreation(Expression<Func<CtaEventCreationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CtaEventContent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/Cta/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CtaEventContent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignBadgeToUser(Expression<Func<string>> username, Expression<Func<AssignBadgeToUserInput>> body)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/badges/", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignCustomActionToUser(Expression<Func<string>> username, Expression<Func<AssignCustomActionToUserInput>> body)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}/customactions/", __workflow_username.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetAllBadgesResponseItem[], ApiConnectionActionConfiguration> GetAllBadges()
        {
            return new DeferredBodyAction<GetAllBadgesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/badges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAllBadgesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetBadgeLevelsResponseItem[], ApiConnectionActionConfiguration> GetBadgeLevels(Expression<Func<string>> badgeId)
        {
            var __workflow_badgeId = WorkflowExpression.Compile(badgeId, nameof(badgeId), required: true);
            return new DeferredBodyAction<GetBadgeLevelsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/badges/{0}/levels", __workflow_badgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBadgeLevelsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sociabble")]
        public IBodyWorkflowAction<GetFoldersResponse, ApiConnectionActionConfiguration> GetMediaDriveFolders(Expression<Func<string>> culture = null)
        {
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: false);
            return new DeferredBodyAction<GetFoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mediadrive";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["culture"] = Convert.ToString("en");
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
                return new ApiConnectionAction<GetFoldersResponse>(callPayload);
            });
        }
    }

    public class SociabbleTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendAlertRequestInput
    {
        [JsonProperty("alertText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlertText { get; set; }

        [JsonProperty("alertTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AlertTitle { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonProperty("sendSMS")]
        public bool? SendSMS { get; set; }
    }

    public class GetAudiencesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetChannelsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetCategoriesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("shouldFillBackground")]
        public bool ShouldFillBackground { get; set; }
    }

    public class InternalContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedInternalContent[] Contents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContentTypeDiscriminator
    {
        None,
        InternalNews,
        Quiz,
        Survey,
        ContentForSharing,
        Cta,
        Live,
        SocialNetworkContent,
        AdminExternalContent,
        PersonalisedTile,
        Poll,
        UserContent,
        SupportMyCause
    }

    public class ContentChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class ContentCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("shouldFillBackground")]
        public bool ShouldFillBackground { get; set; }
    }

    public class LocalizedInternalContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaIds")]
        public string[] MediaIds { get; set; }

        [JsonProperty("medias")]
        public ContentImage[] Medias { get; set; }
    }

    public class ContentImage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CreateInternalNewsInput
    {
        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedInternalContentCreation[] Contents { get; set; }

        [JsonProperty("areCommentsAuthorized")]
        public bool? AreCommentsAuthorized { get; set; }

        [JsonProperty("shouldNotifyUsers")]
        public bool? ShouldNotifyUsers { get; set; }

        [JsonProperty("isMustReadContent")]
        public bool? IsMustReadContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MyNewsDisplayBehavior
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "never")]
        Never
    }

    public class LocalizedInternalContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaIds")]
        public string[] MediaIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LanguageBehavior
    {
        [EnumMember(Value = "af")]
        Afrikaans,
        [EnumMember(Value = "ar")]
        Arabic,
        [EnumMember(Value = "bn")]
        Bengali,
        [EnumMember(Value = "bs")]
        Bosnian,
        [EnumMember(Value = "pt-BR")]
        BrazilianPortuguese,
        [EnumMember(Value = "bg")]
        Bulgarian,
        [EnumMember(Value = "ca")]
        Catalan,
        [EnumMember(Value = "zh-Hans")]
        ChineseSimplified,
        [EnumMember(Value = "zh-Hant")]
        ChineseTraditional,
        [EnumMember(Value = "hr")]
        Croatian,
        [EnumMember(Value = "cs")]
        Czech,
        [EnumMember(Value = "da")]
        Danish,
        [EnumMember(Value = "nl")]
        Dutch,
        [EnumMember(Value = "en")]
        English,
        [EnumMember(Value = "et")]
        Estonian,
        [EnumMember(Value = "fil")]
        Filipino,
        [EnumMember(Value = "fi")]
        Finnish,
        [EnumMember(Value = "fr")]
        French,
        [EnumMember(Value = "de")]
        German,
        [EnumMember(Value = "el")]
        Greek,
        [EnumMember(Value = "he")]
        Hebrew,
        [EnumMember(Value = "hi")]
        Hindi,
        [EnumMember(Value = "hu")]
        Hungarian,
        [EnumMember(Value = "is")]
        Icelandic,
        [EnumMember(Value = "id")]
        Indonesian,
        [EnumMember(Value = "it")]
        Italian,
        [EnumMember(Value = "ja")]
        Japanese,
        [EnumMember(Value = "sw")]
        Kiswahili,
        [EnumMember(Value = "ko")]
        Korean,
        [EnumMember(Value = "lv")]
        Latvian,
        [EnumMember(Value = "lt")]
        Lithuanian,
        [EnumMember(Value = "ms")]
        Malay,
        [EnumMember(Value = "mt")]
        Maltese,
        [EnumMember(Value = "nb")]
        Norwegian,
        [EnumMember(Value = "fa")]
        Persian,
        [EnumMember(Value = "pl")]
        Polish,
        [EnumMember(Value = "pt")]
        Portuguese,
        [EnumMember(Value = "ro")]
        Romanian,
        [EnumMember(Value = "ru")]
        Russian,
        [EnumMember(Value = "sr")]
        Serbian,
        [EnumMember(Value = "sk")]
        Slovak,
        [EnumMember(Value = "sl")]
        Slovenian,
        [EnumMember(Value = "es")]
        Spanish,
        [EnumMember(Value = "sv")]
        Swedish,
        [EnumMember(Value = "ta")]
        Tamil,
        [EnumMember(Value = "th")]
        Thai,
        [EnumMember(Value = "tr")]
        Turkish,
        [EnumMember(Value = "uk")]
        Ukrainian,
        [EnumMember(Value = "ur")]
        Urdu,
        [EnumMember(Value = "vi")]
        Vietnamese,
        [EnumMember(Value = "cy")]
        Welsh
    }

    public class ExternalContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedExternalContent[] Contents { get; set; }

        [JsonProperty("contentUrl")]
        public string ContentUrl { get; set; }

        [JsonProperty("isShareable")]
        public bool IsShareable { get; set; }

        [JsonProperty("isOfficialContent")]
        public bool IsOfficialContent { get; set; }

        [JsonProperty("areCommentsAuthorized")]
        public bool AreCommentsAuthorized { get; set; }
    }

    public class LocalizedExternalContent
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("proposedCommentForSharing")]
        public string ProposedCommentForSharing { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }
    }

    public class CreateExternalContentInput
    {
        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedExternalContentCreation[] Contents { get; set; }

        [JsonProperty("contentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentUrl { get; set; }

        [JsonProperty("isShareable")]
        public bool? IsShareable { get; set; }

        [JsonProperty("isOfficialContent")]
        public bool? IsOfficialContent { get; set; }

        [JsonProperty("areCommentsAuthorized")]
        public bool? AreCommentsAuthorized { get; set; }

        [JsonProperty("shouldNotifyUsers")]
        public bool? ShouldNotifyUsers { get; set; }

        [JsonProperty("isMustReadContent")]
        public bool? IsMustReadContent { get; set; }
    }

    public class LocalizedExternalContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("proposedCommentForSharing")]
        public string ProposedCommentForSharing { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }
    }

    public class CtaSuggestContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CtaContentTypeDiscriminator
    {
        None,
        SuggestContent,
        Mobile,
        Invitation,
        Event
    }

    public class LocalizedBaseCtaContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class CtaSuggestContentCreationInput
    {
        [JsonProperty("discriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Discriminator { get; set; } = "Cta";

        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }

        [JsonProperty("ctaDiscriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CtaDiscriminator { get; set; } = "SuggestContent";

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedBaseCtaContentCreation[] Contents { get; set; }
    }

    public class LocalizedBaseCtaContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }
    }

    public class CtaInvitationContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    public class CtaInvitationContentCreationInput
    {
        [JsonProperty("discriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Discriminator { get; set; } = "Cta";

        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }

        [JsonProperty("ctaDiscriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CtaDiscriminator { get; set; } = "Invitation";

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedBaseCtaContentCreation[] Contents { get; set; }
    }

    public class CtaMobileContent
    {
        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("contents")]
        public LocalizedBaseCtaContent[] Contents { get; set; }
    }

    public class CtaMobileContentCreationInput
    {
        [JsonProperty("discriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Discriminator { get; set; } = "Cta";

        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }

        [JsonProperty("ctaDiscriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CtaDiscriminator { get; set; } = "Mobile";

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedBaseCtaContentCreation[] Contents { get; set; }
    }

    public class CtaEventContent
    {
        [JsonProperty("discriminator")]
        public ContentTypeDiscriminator Discriminator { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("internalUrl")]
        public string InternalUrl { get; set; }

        [JsonProperty("channelIds")]
        public string[] ChannelIds { get; set; }

        [JsonProperty("channels")]
        public ContentChannel[] Channels { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categories")]
        public ContentCategory[] Categories { get; set; }

        [JsonProperty("likeNumber")]
        public int LikeNumber { get; set; }

        [JsonProperty("commentNumber")]
        public int CommentNumber { get; set; }

        [JsonProperty("clickNumber")]
        public int ClickNumber { get; set; }

        [JsonProperty("hasBeenRead")]
        public bool HasBeenRead { get; set; }

        [JsonProperty("awardedBonus")]
        public int AwardedBonus { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("shouldDisplayButton")]
        public bool ShouldDisplayButton { get; set; }

        [JsonProperty("shouldDisplayTitle")]
        public bool ShouldDisplayTitle { get; set; }

        [JsonProperty("ctaDiscriminator")]
        public CtaContentTypeDiscriminator CtaDiscriminator { get; set; }

        [JsonProperty("contents")]
        public LocalizedCtaEventContent[] Contents { get; set; }
    }

    public class LocalizedCtaEventContent
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("image")]
        public ContentImage Image { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("headerText")]
        public string HeaderText { get; set; }

        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }

        [JsonProperty("headerForegroundColor")]
        public string HeaderForegroundColor { get; set; }

        [JsonProperty("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("buttonForegroundColor")]
        public string ButtonForegroundColor { get; set; }

        [JsonProperty("buttonBackgroundColor")]
        public string ButtonBackgroundColor { get; set; }

        [JsonProperty("summaryForegroundColor")]
        public string SummaryForegroundColor { get; set; }
    }

    public class CtaEventCreationInput
    {
        [JsonProperty("discriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Discriminator { get; set; } = "Cta";

        [JsonProperty("ctaDiscriminator", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CtaDiscriminator { get; set; } = "Event";

        [JsonProperty("channelIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ChannelIds { get; set; }

        [JsonProperty("audienceId")]
        public string AudienceId { get; set; }

        [JsonProperty("categoryIds")]
        public string[] CategoryIds { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("awardedBonus")]
        public int? AwardedBonus { get; set; }

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public LocalizedCtaEventContentCreation[] Contents { get; set; }

        [JsonProperty("shouldDisplayTitle")]
        public bool? ShouldDisplayTitle { get; set; }

        [JsonProperty("shouldDisplayButton")]
        public bool? ShouldDisplayButton { get; set; }

        [JsonProperty("publicationStartDate")]
        public string PublicationStartDate { get; set; }

        [JsonProperty("publicationEndDate")]
        public string PublicationEndDate { get; set; }

        [JsonProperty("myNewsDisplay")]
        public MyNewsDisplayBehavior? MyNewsDisplay { get; set; }

        [JsonProperty("shouldPinTopOfMyNews")]
        public bool? ShouldPinTopOfMyNews { get; set; }

        [JsonProperty("pinOfMyNewsStartDate")]
        public string PinOfMyNewsStartDate { get; set; }

        [JsonProperty("pinOfMyNewsEndDate")]
        public string PinOfMyNewsEndDate { get; set; }

        [JsonProperty("shouldPinTopOfSelectedChannels")]
        public bool? ShouldPinTopOfSelectedChannels { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsStartDate")]
        public string PinTopOfSelectedChannelsStartDate { get; set; }

        [JsonProperty("pinTopOfSelectedChannelsEndDate")]
        public string PinTopOfSelectedChannelsEndDate { get; set; }
    }

    public class LocalizedCtaEventContentCreation
    {
        [JsonProperty("language")]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("headerText")]
        public string HeaderText { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("buttonText")]
        public string ButtonText { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("headerForegroundColor")]
        public string HeaderForegroundColor { get; set; }

        [JsonProperty("headerBackgroundColor")]
        public string HeaderBackgroundColor { get; set; }

        [JsonProperty("titleForegroundColor")]
        public string TitleForegroundColor { get; set; }

        [JsonProperty("summaryForegroundColor")]
        public string SummaryForegroundColor { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("buttonForegroundColor")]
        public string ButtonForegroundColor { get; set; }

        [JsonProperty("buttonBackgroundColor")]
        public string ButtonBackgroundColor { get; set; }
    }

    public class AssignBadgeToUserInput
    {
        [JsonProperty("badgeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BadgeId { get; set; }

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Level { get; set; }
    }

    public class AssignCustomActionToUserInput
    {
        [JsonProperty("isEngaging")]
        public bool? IsEngaging { get; set; }

        [JsonProperty("isInternal")]
        public bool? IsInternal { get; set; }

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("contents", DefaultValueHandling = DefaultValueHandling.Include)]
        public AssignCustomActionToUserInputContentsTypeItem[] Contents { get; set; }
    }

    public class AssignCustomActionToUserInputContentsTypeItem
    {
        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public LanguageBehavior Language { get; set; }

        [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsDefault { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notificationText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NotificationText { get; set; }
    }

    public class GetAllBadgesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetBadgeLevelsResponseItem
    {
        [JsonProperty("badgeId")]
        public string BadgeId { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFoldersResponse
    {
        [JsonProperty("folders")]
        public MediaFolder[] Folders { get; set; }
    }

    public class MediaFolder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("canUploadInto")]
        public bool CanUploadInto { get; set; }

        [JsonProperty("isGeneratedFolder")]
        public bool IsGeneratedFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sociabble;

    public partial class WorkflowManagedActions
    {
        public SociabbleActions Sociabble(string connectionId) => new SociabbleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SociabbleTriggers Sociabble(string connectionId) => new SociabbleTriggers(connectionId);
    }
}