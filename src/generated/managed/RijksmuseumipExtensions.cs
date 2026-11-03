//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rijksmuseumip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RijksmuseumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksmuseumip")]
        public IBodyWorkflowAction<GetCollectionResponse, ApiConnectionActionConfiguration> GetCollection(Expression<Func<cultureInput>> culture, Expression<Func<string>> objectnumber = null, Expression<Func<string>> involvedMaker = null, Expression<Func<int>> p = null, Expression<Func<int>> ps = null, Expression<Func<sInput>> s = null, Expression<Func<bool>> toppieces = null, Expression<Func<bool>> imgoly = null, Expression<Func<int>> fDatingPeriod = null, Expression<Func<string>> title = null, Expression<Func<string>> technique = null, Expression<Func<string>> material = null, Expression<Func<string>> type = null, Expression<Func<string>> place = null)
        {
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: true);
            var __workflow_objectnumber = WorkflowExpression.Compile(objectnumber, nameof(objectnumber), required: false);
            var __workflow_involvedMaker = WorkflowExpression.Compile(involvedMaker, nameof(involvedMaker), required: false);
            var __workflow_p = WorkflowExpression.Compile(p, nameof(p), required: false);
            var __workflow_ps = WorkflowExpression.Compile(ps, nameof(ps), required: false);
            var __workflow_s = WorkflowExpression.Compile(s, nameof(s), required: false);
            var __workflow_toppieces = WorkflowExpression.Compile(toppieces, nameof(toppieces), required: false);
            var __workflow_imgoly = WorkflowExpression.Compile(imgoly, nameof(imgoly), required: false);
            var __workflow_fDatingPeriod = WorkflowExpression.Compile(fDatingPeriod, nameof(fDatingPeriod), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_technique = WorkflowExpression.Compile(technique, nameof(technique), required: false);
            var __workflow_material = WorkflowExpression.Compile(material, nameof(material), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_place = WorkflowExpression.Compile(place, nameof(place), required: false);
            return new DeferredBodyAction<GetCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/{0}/collection/", __workflow_culture.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_objectnumber != null)
                    callPayload.Queries["objectnumber"] = ExpressionConverter.Convert(__workflow_objectnumber);
                if (__workflow_involvedMaker != null)
                    callPayload.Queries["involvedMaker"] = ExpressionConverter.Convert(__workflow_involvedMaker);
                callPayload.Queries["p"] = Convert.ToString(0);
                if (__workflow_p != null)
                    callPayload.Queries["p"] = ExpressionConverter.Convert(__workflow_p);
                callPayload.Queries["ps"] = Convert.ToString(10);
                if (__workflow_ps != null)
                    callPayload.Queries["ps"] = ExpressionConverter.Convert(__workflow_ps);
                if (__workflow_s != null)
                    callPayload.Queries["s"] = ExpressionConverter.Convert(__workflow_s);
                callPayload.Queries["toppieces"] = Convert.ToString(false);
                if (__workflow_toppieces != null)
                    callPayload.Queries["toppieces"] = ExpressionConverter.Convert(__workflow_toppieces);
                callPayload.Queries["imgoly"] = Convert.ToString(false);
                if (__workflow_imgoly != null)
                    callPayload.Queries["imgoly"] = ExpressionConverter.Convert(__workflow_imgoly);
                if (__workflow_fDatingPeriod != null)
                    callPayload.Queries["f.dating.period"] = ExpressionConverter.Convert(__workflow_fDatingPeriod);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_technique != null)
                    callPayload.Queries["technique"] = ExpressionConverter.Convert(__workflow_technique);
                if (__workflow_material != null)
                    callPayload.Queries["material"] = ExpressionConverter.Convert(__workflow_material);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_place != null)
                    callPayload.Queries["place"] = ExpressionConverter.Convert(__workflow_place);
                return new ApiConnectionAction<GetCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksmuseumip")]
        public IBodyWorkflowAction<GetUsersetsResponse, ApiConnectionActionConfiguration> GetUsersets(Expression<Func<cultureInput>> culture, Expression<Func<int>> userId, Expression<Func<string>> collectionName, Expression<Func<formatInput>> format = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_collectionName = WorkflowExpression.Compile(collectionName, nameof(collectionName), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetUsersetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/{0}/usersets/{1}-{2}", __workflow_culture.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1), __workflow_collectionName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(25);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetUsersetsResponse>(callPayload);
            });
        }
    }

    public class RijksmuseumipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCollectionResponse
    {
        [JsonProperty("elapsedMilliseconds")]
        public int ElapsedMilliseconds { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("countFacets")]
        public GetCollectionResponseCountFacetsType CountFacets { get; set; }

        [JsonProperty("artObjects")]
        public GetCollectionResponseArtObjectsTypeItem[] ArtObjects { get; set; }

        [JsonProperty("facets")]
        public GetCollectionResponseFacetsTypeItem[] Facets { get; set; }
    }

    public class GetCollectionResponseCountFacetsType
    {
        [JsonProperty("hasimage")]
        public int Hasimage { get; set; }

        [JsonProperty("ondisplay")]
        public int Ondisplay { get; set; }
    }

    public class GetCollectionResponseArtObjectsTypeItem
    {
        [JsonProperty("links")]
        public GetCollectionResponseArtObjectsTypeItemLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectNumber")]
        public string ObjectNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hasImage")]
        public bool HasImage { get; set; }

        [JsonProperty("principalOrFirstMaker")]
        public string PrincipalOrFirstMaker { get; set; }

        [JsonProperty("longTitle")]
        public string LongTitle { get; set; }

        [JsonProperty("showImage")]
        public bool ShowImage { get; set; }

        [JsonProperty("permitDownload")]
        public bool PermitDownload { get; set; }

        [JsonProperty("webImage")]
        public GetCollectionResponseArtObjectsTypeItemWebImageType WebImage { get; set; }

        [JsonProperty("headerImage")]
        public GetCollectionResponseArtObjectsTypeItemHeaderImageType HeaderImage { get; set; }

        [JsonProperty("productionPlaces")]
        public string[] ProductionPlaces { get; set; }
    }

    public class GetCollectionResponseArtObjectsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }

    public class GetCollectionResponseArtObjectsTypeItemWebImageType
    {
        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("offsetPercentageX")]
        public int OffsetPercentageX { get; set; }

        [JsonProperty("offsetPercentageY")]
        public int OffsetPercentageY { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCollectionResponseArtObjectsTypeItemHeaderImageType
    {
        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("offsetPercentageX")]
        public int OffsetPercentageX { get; set; }

        [JsonProperty("offsetPercentageY")]
        public int OffsetPercentageY { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCollectionResponseFacetsTypeItem
    {
        [JsonProperty("facets")]
        public GetCollectionResponseFacetsTypeItemFacetsTypeItem[] Facets { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("otherTerms")]
        public int OtherTerms { get; set; }

        [JsonProperty("prettyName")]
        public int PrettyName { get; set; }
    }

    public class GetCollectionResponseFacetsTypeItemFacetsTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum cultureInput
    {
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sInput
    {
        [EnumMember(Value = "relevance")]
        Relevance,
        [EnumMember(Value = "objecttype")]
        Objecttype,
        [EnumMember(Value = "chronologic")]
        Chronologic,
        [EnumMember(Value = "achronologic")]
        Achronologic,
        [EnumMember(Value = "artist")]
        Artist,
        [EnumMember(Value = "artistdesc")]
        Artistdesc
    }

    public class GetUsersetsResponse
    {
        [JsonProperty("elapsedMilliseconds")]
        public int ElapsedMilliseconds { get; set; }

        [JsonProperty("userSet")]
        public GetUsersetsResponseUserSetType UserSet { get; set; }
    }

    public class GetUsersetsResponseUserSetType
    {
        [JsonProperty("links")]
        public GetUsersetsResponseUserSetTypeLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public GetUsersetsResponseUserSetTypeUserType User { get; set; }

        [JsonProperty("setItems")]
        public GetUsersetsResponseUserSetTypeSetItemsTypeItem[] SetItems { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("updatedOn")]
        public string UpdatedOn { get; set; }
    }

    public class GetUsersetsResponseUserSetTypeLinksType
    {
        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }

    public class GetUsersetsResponseUserSetTypeUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("headerUrl")]
        public string HeaderUrl { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }
    }

    public class GetUsersetsResponseUserSetTypeSetItemsTypeItem
    {
        [JsonProperty("links")]
        public GetUsersetsResponseUserSetTypeSetItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectNumber")]
        public string ObjectNumber { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("relationDescription")]
        public string RelationDescription { get; set; }

        [JsonProperty("cropped")]
        public bool Cropped { get; set; }

        [JsonProperty("cropX")]
        public int CropX { get; set; }

        [JsonProperty("cropY")]
        public int CropY { get; set; }

        [JsonProperty("cropWidth")]
        public int CropWidth { get; set; }

        [JsonProperty("cropHeight")]
        public int CropHeight { get; set; }

        [JsonProperty("origWidth")]
        public int OrigWidth { get; set; }

        [JsonProperty("origHeight")]
        public int OrigHeight { get; set; }

        [JsonProperty("image")]
        public GetUsersetsResponseUserSetTypeSetItemsTypeItemImageType Image { get; set; }
    }

    public class GetUsersetsResponseUserSetTypeSetItemsTypeItemLinksType
    {
        [JsonProperty("artobject")]
        public string Artobject { get; set; }

        [JsonProperty("web")]
        public string Web { get; set; }
    }

    public class GetUsersetsResponseUserSetTypeSetItemsTypeItemImageType
    {
        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("parentObjectNumber")]
        public string ParentObjectNumber { get; set; }

        [JsonProperty("cdnUrl")]
        public string CdnUrl { get; set; }

        [JsonProperty("cropX")]
        public string CropX { get; set; }

        [JsonProperty("cropY")]
        public string CropY { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("offsetPercentageX")]
        public int OffsetPercentageX { get; set; }

        [JsonProperty("offsetPercentageY")]
        public int OffsetPercentageY { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "jsonp")]
        Jsonp,
        [EnumMember(Value = "xml")]
        Xml
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rijksmuseumip;

    public partial class WorkflowManagedActions
    {
        public RijksmuseumipActions Rijksmuseumip(string connectionId) => new RijksmuseumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RijksmuseumipTriggers Rijksmuseumip(string connectionId) => new RijksmuseumipTriggers(connectionId);
    }
}