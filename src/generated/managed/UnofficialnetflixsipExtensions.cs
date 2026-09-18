//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unofficialnetflixsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnofficialnetflixsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleSearchResponse> TitleSearch([WorkflowExpression] Func<int> query = null, [WorkflowExpression] Func<int> type = null, [WorkflowExpression] Func<int> genrelist = null, [WorkflowExpression] Func<string> countrylist = null, [WorkflowExpression] Func<int> startYear = null, [WorkflowExpression] Func<int> endYear = null, [WorkflowExpression] Func<string> audio = null, [WorkflowExpression] Func<string> audiosubtitleAndor = null, [WorkflowExpression] Func<string> subtitle = null, [WorkflowExpression] Func<string> countryAndorunique = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(genrelist, nameof(genrelist), required: false);
            SourceExpression.Validate(countrylist, nameof(countrylist), required: false);
            SourceExpression.Validate(startYear, nameof(startYear), required: false);
            SourceExpression.Validate(endYear, nameof(endYear), required: false);
            SourceExpression.Validate(audio, nameof(audio), required: false);
            SourceExpression.Validate(audiosubtitleAndor, nameof(audiosubtitleAndor), required: false);
            SourceExpression.Validate(subtitle, nameof(subtitle), required: false);
            SourceExpression.Validate(countryAndorunique, nameof(countryAndorunique), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (genrelist != null)
                    callPayload.Queries["genrelist"] = SourceExpressionConverter.ConvertO(genrelist);
                if (countrylist != null)
                    callPayload.Queries["countrylist"] = SourceExpressionConverter.ConvertO(countrylist);
                if (startYear != null)
                    callPayload.Queries["start_year"] = SourceExpressionConverter.ConvertO(startYear);
                if (endYear != null)
                    callPayload.Queries["end_year"] = SourceExpressionConverter.ConvertO(endYear);
                if (audio != null)
                    callPayload.Queries["audio"] = SourceExpressionConverter.ConvertO(audio);
                if (audiosubtitleAndor != null)
                    callPayload.Queries["audiosubtitle_andor"] = SourceExpressionConverter.ConvertO(audiosubtitleAndor);
                if (subtitle != null)
                    callPayload.Queries["subtitle"] = SourceExpressionConverter.ConvertO(subtitle);
                if (countryAndorunique != null)
                    callPayload.Queries["country_andorunique"] = SourceExpressionConverter.ConvertO(countryAndorunique);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TitleSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<PeopleSearchResponse> PeopleSearch([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> netflixId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(netflixId, nameof(netflixId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/people";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (netflixId != null)
                    callPayload.Queries["netflix_id"] = SourceExpressionConverter.ConvertO(netflixId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<PeopleSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<DeletedSearchResponse> DeletedSearch([WorkflowExpression] Func<int> netflixId = null, [WorkflowExpression] Func<string> countryList = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(netflixId, nameof(netflixId), required: false);
            SourceExpression.Validate(countryList, nameof(countryList), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/titlesdel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (netflixId != null)
                    callPayload.Queries["netflix_id"] = SourceExpressionConverter.ConvertO(netflixId);
                if (countryList != null)
                    callPayload.Queries["country_list"] = SourceExpressionConverter.ConvertO(countryList);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<DeletedSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<GenresResponse> Genres()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/genres";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GenresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<CountriesResponse> Countries()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CountriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleDetailResponse> TitleDetail([WorkflowExpression] Func<int> netflixid, [WorkflowExpression] Func<int> imdbid)
        {
            SourceExpression.Validate(netflixid, nameof(netflixid), required: true);
            SourceExpression.Validate(imdbid, nameof(imdbid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/title";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["netflixid"] = SourceExpressionConverter.ConvertO(netflixid);
                callPayload.Queries["imdbid"] = SourceExpressionConverter.ConvertO(imdbid);
                return callPayload;
            }

            return new ApiConnectionAction<TitleDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleCountryResponse> TitleCountry([WorkflowExpression] Func<int> netflixid)
        {
            SourceExpression.Validate(netflixid, nameof(netflixid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/titlecountries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["netflixid"] = SourceExpressionConverter.ConvertO(netflixid);
                return callPayload;
            }

            return new ApiConnectionAction<TitleCountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleGenreResponse> TitleGenre([WorkflowExpression] Func<int> netflixid)
        {
            SourceExpression.Validate(netflixid, nameof(netflixid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/titlegenres";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["netflixid"] = SourceExpressionConverter.ConvertO(netflixid);
                return callPayload;
            }

            return new ApiConnectionAction<TitleGenreResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleEpisodeResponse> TitleEpisode([WorkflowExpression] Func<int> netflixid, [WorkflowExpression] Func<int> seasonid, [WorkflowExpression] Func<int> episodeid = null)
        {
            SourceExpression.Validate(netflixid, nameof(netflixid), required: true);
            SourceExpression.Validate(seasonid, nameof(seasonid), required: true);
            SourceExpression.Validate(episodeid, nameof(episodeid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/episodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["netflixid"] = SourceExpressionConverter.ConvertO(netflixid);
                callPayload.Queries["seasonid"] = SourceExpressionConverter.ConvertO(seasonid);
                if (episodeid != null)
                    callPayload.Queries["episodeid"] = SourceExpressionConverter.ConvertO(episodeid);
                return callPayload;
            }

            return new ApiConnectionAction<TitleEpisodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleImageResponse> TitleImage([WorkflowExpression] Func<int> netflixid, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(netflixid, nameof(netflixid), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/images";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["netflixid"] = SourceExpressionConverter.ConvertO(netflixid);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TitleImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unofficialnetflixsip")]
        public IBodyWorkflowAction<TitleExpiringResponse> TitleExpiring([WorkflowExpression] Func<int> countrylist, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(countrylist, nameof(countrylist), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/expiring";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["countrylist"] = SourceExpressionConverter.ConvertO(countrylist);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TitleExpiringResponse>(BuildSourceInput);
        }
    }

    public class UnofficialnetflixsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TitleSearchResponse
    {
        [JsonProperty("results")]
        public TitleSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("elapse")]
        public double Elapse { get; set; }
    }

    public class TitleSearchResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("vtype")]
        public string Vtype { get; set; }

        [JsonProperty("nfid")]
        public int Nfid { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("avgrating")]
        public double Avgrating { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("imdbid")]
        public string Imdbid { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("imdbrating")]
        public double Imdbrating { get; set; }

        [JsonProperty("top250")]
        public int Top250 { get; set; }

        [JsonProperty("top250tv")]
        public int Top250tv { get; set; }

        [JsonProperty("clist")]
        public string Clist { get; set; }

        [JsonProperty("titledate")]
        public string Titledate { get; set; }
    }

    public class PeopleSearchResponse
    {
        [JsonProperty("Object")]
        public PeopleSearchResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public PeopleSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class PeopleSearchResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class PeopleSearchResponseResultsTypeItem
    {
        [JsonProperty("netflix_id")]
        public int NetflixId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("person_type")]
        public string PersonType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class DeletedSearchResponse
    {
        [JsonProperty("Object")]
        public DeletedSearchResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public DeletedSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class DeletedSearchResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class DeletedSearchResponseResultsTypeItem
    {
        [JsonProperty("netflix_id")]
        public int NetflixId { get; set; }

        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("delete_date")]
        public string DeleteDate { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }

    public class GenresResponse
    {
        [JsonProperty("results")]
        public GenresResponseResultsTypeItem[] Results { get; set; }
    }

    public class GenresResponseResultsTypeItem
    {
        [JsonProperty("netflix_id")]
        public int NetflixId { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }
    }

    public class CountriesResponse
    {
        [JsonProperty("results")]
        public CountriesResponseResultsTypeItem[] Results { get; set; }
    }

    public class CountriesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countrycode")]
        public string Countrycode { get; set; }

        [JsonProperty("expiring")]
        public int Expiring { get; set; }

        [JsonProperty("nl7")]
        public int Nl7 { get; set; }

        [JsonProperty("tvids")]
        public int Tvids { get; set; }

        [JsonProperty("tmovs")]
        public int Tmovs { get; set; }

        [JsonProperty("tseries")]
        public int Tseries { get; set; }
    }

    public class TitleDetailResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("maturity_label")]
        public string MaturityLabel { get; set; }

        [JsonProperty("maturity_level")]
        public string MaturityLevel { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("title_type")]
        public string TitleType { get; set; }

        [JsonProperty("default_image")]
        public string DefaultImage { get; set; }

        [JsonProperty("large_image")]
        public string LargeImage { get; set; }

        [JsonProperty("netflix_id")]
        public string NetflixId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("latest_date")]
        public string LatestDate { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("awards")]
        public string Awards { get; set; }

        [JsonProperty("origin_country")]
        public string OriginCountry { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("alt_id")]
        public string AltId { get; set; }

        [JsonProperty("alt_plot")]
        public string AltPlot { get; set; }

        [JsonProperty("alt_metascore")]
        public string AltMetascore { get; set; }

        [JsonProperty("alt_votes")]
        public string AltVotes { get; set; }

        [JsonProperty("alt_runtime")]
        public string AltRuntime { get; set; }

        [JsonProperty("alt_image")]
        public string AltImage { get; set; }
    }

    public class TitleCountryResponse
    {
        [JsonProperty("Object")]
        public TitleCountryResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public TitleCountryResponseResultsTypeItem[] Results { get; set; }
    }

    public class TitleCountryResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class TitleCountryResponseResultsTypeItem
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("season_detail")]
        public string SeasonDetail { get; set; }

        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        [JsonProperty("new_date")]
        public string NewDate { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
    }

    public class TitleGenreResponse
    {
        [JsonProperty("Object")]
        public TitleGenreResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public TitleGenreResponseResultsTypeItem[] Results { get; set; }
    }

    public class TitleGenreResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class TitleGenreResponseResultsTypeItem
    {
        [JsonProperty("genre_id")]
        public int GenreId { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }
    }

    public class TitleEpisodeResponse
    {
        [JsonProperty("Object")]
        public TitleEpisodeResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public TitleEpisodeResponseResultsTypeItem[] Results { get; set; }
    }

    public class TitleEpisodeResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class TitleEpisodeResponseResultsTypeItem
    {
        [JsonProperty("netflix_id")]
        public int NetflixId { get; set; }

        [JsonProperty("episode_id")]
        public int EpisodeId { get; set; }

        [JsonProperty("season_id")]
        public int SeasonId { get; set; }

        [JsonProperty("episode_number")]
        public string EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public string SeasonNumber { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class TitleImageResponse
    {
        [JsonProperty("Object")]
        public TitleImageResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("results")]
        public TitleImageResponseResultsTypeItem[] Results { get; set; }
    }

    public class TitleImageResponseObjectEntityType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class TitleImageResponseResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image_type")]
        public string ImageType { get; set; }
    }

    public class TitleExpiringResponse
    {
        [JsonProperty("results")]
        public TitleExpiringResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("elapse")]
        public double Elapse { get; set; }
    }

    public class TitleExpiringResponseResultsTypeItem
    {
        [JsonProperty("netflixid")]
        public int Netflixid { get; set; }

        [JsonProperty("expiredate")]
        public string Expiredate { get; set; }

        [JsonProperty("countrycode")]
        public string Countrycode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Unofficialnetflixsip;

    public partial class WorkflowManagedActions
    {
        public UnofficialnetflixsipActions Unofficialnetflixsip(string connectionId) => new UnofficialnetflixsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UnofficialnetflixsipTriggers Unofficialnetflixsip(string connectionId) => new UnofficialnetflixsipTriggers(connectionId);
    }
}