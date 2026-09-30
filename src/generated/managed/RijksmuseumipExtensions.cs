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
        public IBodyWorkflowAction<GetCollectionResponse> GetCollection([WorkflowExpression] Func<cultureInput> culture, [WorkflowExpression] Func<string> objectnumber = null, [WorkflowExpression] Func<string> involvedMaker = null, [WorkflowExpression] Func<int> p = null, [WorkflowExpression] Func<int> ps = null, [WorkflowExpression] Func<sInput> s = null, [WorkflowExpression] Func<bool> toppieces = null, [WorkflowExpression] Func<bool> imgoly = null, [WorkflowExpression] Func<int> fDatingPeriod = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> technique = null, [WorkflowExpression] Func<string> material = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> place = null)
        {
            SourceExpression.Validate(culture, nameof(culture), required: true);
            SourceExpression.Validate(objectnumber, nameof(objectnumber), required: false);
            SourceExpression.Validate(involvedMaker, nameof(involvedMaker), required: false);
            SourceExpression.Validate(p, nameof(p), required: false);
            SourceExpression.Validate(ps, nameof(ps), required: false);
            SourceExpression.Validate(s, nameof(s), required: false);
            SourceExpression.Validate(toppieces, nameof(toppieces), required: false);
            SourceExpression.Validate(imgoly, nameof(imgoly), required: false);
            SourceExpression.Validate(fDatingPeriod, nameof(fDatingPeriod), required: false);
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(technique, nameof(technique), required: false);
            SourceExpression.Validate(material, nameof(material), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(place, nameof(place), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/{0}/collection/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(culture, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (objectnumber != null)
                    callPayload.Queries["objectnumber"] = SourceExpressionConverter.ConvertO(objectnumber);
                if (involvedMaker != null)
                    callPayload.Queries["involvedMaker"] = SourceExpressionConverter.ConvertO(involvedMaker);
                callPayload.Queries["p"] = Convert.ToString(0);
                if (p != null)
                    callPayload.Queries["p"] = SourceExpressionConverter.ConvertO(p);
                callPayload.Queries["ps"] = Convert.ToString(10);
                if (ps != null)
                    callPayload.Queries["ps"] = SourceExpressionConverter.ConvertO(ps);
                if (s != null)
                    callPayload.Queries["s"] = SourceExpressionConverter.Convert(s);
                callPayload.Queries["toppieces"] = Convert.ToString(false);
                if (toppieces != null)
                    callPayload.Queries["toppieces"] = SourceExpressionConverter.ConvertO(toppieces);
                callPayload.Queries["imgoly"] = Convert.ToString(false);
                if (imgoly != null)
                    callPayload.Queries["imgoly"] = SourceExpressionConverter.ConvertO(imgoly);
                if (fDatingPeriod != null)
                    callPayload.Queries["f.dating.period"] = SourceExpressionConverter.ConvertO(fDatingPeriod);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (technique != null)
                    callPayload.Queries["technique"] = SourceExpressionConverter.ConvertO(technique);
                if (material != null)
                    callPayload.Queries["material"] = SourceExpressionConverter.ConvertO(material);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (place != null)
                    callPayload.Queries["place"] = SourceExpressionConverter.ConvertO(place);
                return callPayload;
            }

            return new ApiConnectionAction<GetCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksmuseumip")]
        public IBodyWorkflowAction<GetUsersetsResponse> GetUsersets([WorkflowExpression] Func<cultureInput> culture, [WorkflowExpression] Func<int> userId, [WorkflowExpression] Func<string> collectionName, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(culture, nameof(culture), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(collectionName, nameof(collectionName), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/{0}/usersets/{1}-{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(culture, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["pageSize"] = Convert.ToString(25);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetUsersetsResponse>(BuildSourceInput);
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