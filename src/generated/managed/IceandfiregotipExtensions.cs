//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iceandfiregotip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IceandfiregotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetResponseItem[]> BookGet(Expression<Func<string>> name = null, Expression<Func<string>> fromReleaseDate = null, Expression<Func<string>> toReleaseDate = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_fromReleaseDate = fromReleaseDate == null ? null : WorkflowExpression.Compile(fromReleaseDate);
            WorkflowExpression.Validate(__workflow_fromReleaseDate, nameof(fromReleaseDate), required: false);
            var __workflow_toReleaseDate = toReleaseDate == null ? null : WorkflowExpression.Compile(toReleaseDate);
            WorkflowExpression.Validate(__workflow_toReleaseDate, nameof(toReleaseDate), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<BookGetResponseItem[]>(() =>
            {
                var apiCallPath = "/api/books";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_fromReleaseDate != null)
                    callPayload.Queries["fromReleaseDate"] = ExpressionConverter.Convert(__workflow_fromReleaseDate);
                if (__workflow_toReleaseDate != null)
                    callPayload.Queries["toReleaseDate"] = ExpressionConverter.Convert(__workflow_toReleaseDate);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<BookGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetAResponse> BookGetA(Expression<Func<string>> number)
        {
            var __workflow_number = number == null ? null : WorkflowExpression.Compile(number);
            WorkflowExpression.Validate(__workflow_number, nameof(number), required: true);
            return new DeferredBodyAction<BookGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/books/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BookGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetResponseItem[]> CharacterGet(Expression<Func<string>> name = null, Expression<Func<string>> gender = null, Expression<Func<string>> culture = null, Expression<Func<string>> born = null, Expression<Func<string>> died = null, Expression<Func<bool>> isAlive = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_gender = gender == null ? null : WorkflowExpression.Compile(gender);
            WorkflowExpression.Validate(__workflow_gender, nameof(gender), required: false);
            var __workflow_culture = culture == null ? null : WorkflowExpression.Compile(culture);
            WorkflowExpression.Validate(__workflow_culture, nameof(culture), required: false);
            var __workflow_born = born == null ? null : WorkflowExpression.Compile(born);
            WorkflowExpression.Validate(__workflow_born, nameof(born), required: false);
            var __workflow_died = died == null ? null : WorkflowExpression.Compile(died);
            WorkflowExpression.Validate(__workflow_died, nameof(died), required: false);
            var __workflow_isAlive = isAlive == null ? null : WorkflowExpression.Compile(isAlive);
            WorkflowExpression.Validate(__workflow_isAlive, nameof(isAlive), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CharacterGetResponseItem[]>(() =>
            {
                var apiCallPath = "/api/characters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_gender != null)
                    callPayload.Queries["gender"] = ExpressionConverter.Convert(__workflow_gender);
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
                if (__workflow_born != null)
                    callPayload.Queries["born"] = ExpressionConverter.Convert(__workflow_born);
                if (__workflow_died != null)
                    callPayload.Queries["died"] = ExpressionConverter.Convert(__workflow_died);
                callPayload.Queries["isAlive"] = Convert.ToString(true);
                if (__workflow_isAlive != null)
                    callPayload.Queries["isAlive"] = ExpressionConverter.Convert(__workflow_isAlive);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<CharacterGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetAResponse> CharacterGetA(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<CharacterGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/characters/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CharacterGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetResponseItem[]> HouseGet(Expression<Func<string>> name = null, Expression<Func<string>> region = null, Expression<Func<string>> words = null, Expression<Func<bool>> hasWords = null, Expression<Func<bool>> hasTitles = null, Expression<Func<bool>> hasSeats = null, Expression<Func<bool>> hasDiedOut = null, Expression<Func<bool>> hasAncestralWeapons = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: false);
            var __workflow_words = words == null ? null : WorkflowExpression.Compile(words);
            WorkflowExpression.Validate(__workflow_words, nameof(words), required: false);
            var __workflow_hasWords = hasWords == null ? null : WorkflowExpression.Compile(hasWords);
            WorkflowExpression.Validate(__workflow_hasWords, nameof(hasWords), required: false);
            var __workflow_hasTitles = hasTitles == null ? null : WorkflowExpression.Compile(hasTitles);
            WorkflowExpression.Validate(__workflow_hasTitles, nameof(hasTitles), required: false);
            var __workflow_hasSeats = hasSeats == null ? null : WorkflowExpression.Compile(hasSeats);
            WorkflowExpression.Validate(__workflow_hasSeats, nameof(hasSeats), required: false);
            var __workflow_hasDiedOut = hasDiedOut == null ? null : WorkflowExpression.Compile(hasDiedOut);
            WorkflowExpression.Validate(__workflow_hasDiedOut, nameof(hasDiedOut), required: false);
            var __workflow_hasAncestralWeapons = hasAncestralWeapons == null ? null : WorkflowExpression.Compile(hasAncestralWeapons);
            WorkflowExpression.Validate(__workflow_hasAncestralWeapons, nameof(hasAncestralWeapons), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<HouseGetResponseItem[]>(() =>
            {
                var apiCallPath = "/api/houses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_words != null)
                    callPayload.Queries["words"] = ExpressionConverter.Convert(__workflow_words);
                if (__workflow_hasWords != null)
                    callPayload.Queries["hasWords"] = ExpressionConverter.Convert(__workflow_hasWords);
                if (__workflow_hasTitles != null)
                    callPayload.Queries["hasTitles"] = ExpressionConverter.Convert(__workflow_hasTitles);
                if (__workflow_hasSeats != null)
                    callPayload.Queries["hasSeats"] = ExpressionConverter.Convert(__workflow_hasSeats);
                if (__workflow_hasDiedOut != null)
                    callPayload.Queries["hasDiedOut"] = ExpressionConverter.Convert(__workflow_hasDiedOut);
                if (__workflow_hasAncestralWeapons != null)
                    callPayload.Queries["hasAncestralWeapons"] = ExpressionConverter.Convert(__workflow_hasAncestralWeapons);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<HouseGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetAResponse> HouseGetA(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<HouseGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/houses/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HouseGetAResponse>(callPayload);
            });
        }
    }

    public class IceandfiregotipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BookGetResponseItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        [JsonProperty("authors")]
        public string[] Authors { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }

        [JsonProperty("povCharacters")]
        public string[] PovCharacters { get; set; }
    }

    public class BookGetAResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isbn")]
        public string Isbn { get; set; }

        [JsonProperty("authors")]
        public string[] Authors { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("released")]
        public string Released { get; set; }

        [JsonProperty("characters")]
        public string[] Characters { get; set; }

        [JsonProperty("povCharacters")]
        public string[] PovCharacters { get; set; }
    }

    public class CharacterGetResponseItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("born")]
        public string Born { get; set; }

        [JsonProperty("died")]
        public string Died { get; set; }

        [JsonProperty("titles")]
        public string[] Titles { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }

        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("spouse")]
        public string Spouse { get; set; }

        [JsonProperty("allegiances")]
        public string[] Allegiances { get; set; }

        [JsonProperty("books")]
        public string[] Books { get; set; }

        [JsonProperty("povBooks")]
        public JToken[] PovBooks { get; set; }

        [JsonProperty("tvSeries")]
        public string[] TvSeries { get; set; }

        [JsonProperty("playedBy")]
        public string[] PlayedBy { get; set; }
    }

    public class CharacterGetAResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("born")]
        public string Born { get; set; }

        [JsonProperty("died")]
        public string Died { get; set; }

        [JsonProperty("titles")]
        public string[] Titles { get; set; }

        [JsonProperty("aliases")]
        public string[] Aliases { get; set; }

        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("spouse")]
        public string Spouse { get; set; }

        [JsonProperty("allegiances")]
        public string[] Allegiances { get; set; }

        [JsonProperty("books")]
        public string[] Books { get; set; }

        [JsonProperty("povBooks")]
        public JToken[] PovBooks { get; set; }

        [JsonProperty("tvSeries")]
        public string[] TvSeries { get; set; }

        [JsonProperty("playedBy")]
        public string[] PlayedBy { get; set; }
    }

    public class HouseGetResponseItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("coatOfArms")]
        public string CoatOfArms { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

        [JsonProperty("titles")]
        public string[] Titles { get; set; }

        [JsonProperty("seats")]
        public string[] Seats { get; set; }

        [JsonProperty("currentLord")]
        public string CurrentLord { get; set; }

        [JsonProperty("heir")]
        public string Heir { get; set; }

        [JsonProperty("overlord")]
        public string Overlord { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("diedOut")]
        public string DiedOut { get; set; }

        [JsonProperty("ancestralWeapons")]
        public string[] AncestralWeapons { get; set; }

        [JsonProperty("cadetBranches")]
        public string[] CadetBranches { get; set; }

        [JsonProperty("swornMembers")]
        public string[] SwornMembers { get; set; }
    }

    public class HouseGetAResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("coatOfArms")]
        public string CoatOfArms { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }

        [JsonProperty("titles")]
        public string[] Titles { get; set; }

        [JsonProperty("seats")]
        public string[] Seats { get; set; }

        [JsonProperty("currentLord")]
        public string CurrentLord { get; set; }

        [JsonProperty("heir")]
        public string Heir { get; set; }

        [JsonProperty("overlord")]
        public string Overlord { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("diedOut")]
        public string DiedOut { get; set; }

        [JsonProperty("ancestralWeapons")]
        public string[] AncestralWeapons { get; set; }

        [JsonProperty("cadetBranches")]
        public string[] CadetBranches { get; set; }

        [JsonProperty("swornMembers")]
        public string[] SwornMembers { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iceandfiregotip;

    public partial class WorkflowManagedActions
    {
        public IceandfiregotipActions Iceandfiregotip(string connectionId) => new IceandfiregotipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IceandfiregotipTriggers Iceandfiregotip(string connectionId) => new IceandfiregotipTriggers(connectionId);
    }
}
