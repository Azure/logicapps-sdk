//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rijksmuseumip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RijksmuseumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksmuseumip")]
        public IBodyWorkflowAction<GetCollectionResponse> GetCollection(Expression<Func<cultureInput>> culture, Expression<Func<string>> objectnumber = null, Expression<Func<string>> involvedMaker = null, Expression<Func<int>> p = null, Expression<Func<int>> ps = null, Expression<Func<sInput>> s = null, Expression<Func<bool>> toppieces = null, Expression<Func<bool>> imgoly = null, Expression<Func<int>> fDatingPeriod = null, Expression<Func<string>> title = null, Expression<Func<string>> technique = null, Expression<Func<string>> material = null, Expression<Func<string>> type = null, Expression<Func<string>> place = null)
        {
            var apiCallPath = String.Format("/api/{0}/collection/", ExpressionConverter.ConvertWithUrlEncoding(culture, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (objectnumber != null)
                callPayload.Queries["objectnumber"] = ExpressionConverter.Convert(objectnumber);
            if (involvedMaker != null)
                callPayload.Queries["involvedMaker"] = ExpressionConverter.Convert(involvedMaker);
            callPayload.Queries["p"] = Convert.ToString(0);
            if (p != null)
                callPayload.Queries["p"] = ExpressionConverter.Convert(p);
            callPayload.Queries["ps"] = Convert.ToString(10);
            if (ps != null)
                callPayload.Queries["ps"] = ExpressionConverter.Convert(ps);
            if (s != null)
                callPayload.Queries["s"] = ExpressionConverter.Convert(s);
            callPayload.Queries["toppieces"] = Convert.ToString(false);
            if (toppieces != null)
                callPayload.Queries["toppieces"] = ExpressionConverter.Convert(toppieces);
            callPayload.Queries["imgoly"] = Convert.ToString(false);
            if (imgoly != null)
                callPayload.Queries["imgoly"] = ExpressionConverter.Convert(imgoly);
            if (fDatingPeriod != null)
                callPayload.Queries["f.dating.period"] = ExpressionConverter.Convert(fDatingPeriod);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (technique != null)
                callPayload.Queries["technique"] = ExpressionConverter.Convert(technique);
            if (material != null)
                callPayload.Queries["material"] = ExpressionConverter.Convert(material);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (place != null)
                callPayload.Queries["place"] = ExpressionConverter.Convert(place);
            return new ApiConnectionAction<GetCollectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksmuseumip")]
        public IBodyWorkflowAction<GetUsersetsResponse> GetUsersets(Expression<Func<cultureInput>> culture, Expression<Func<int>> userId, Expression<Func<string>> collectionName, Expression<Func<formatInput>> format = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = String.Format("/api/{0}/usersets/{1}-{2}", ExpressionConverter.ConvertWithUrlEncoding(culture, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1), ExpressionConverter.ConvertWithUrlEncoding(collectionName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = Convert.ToString("json");
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["pageSize"] = Convert.ToString(25);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GetUsersetsResponse>(callPayload);
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

    public enum cultureInput
    {
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En
    }

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