//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Iceandfiregotip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IceandfiregotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetResponseItem[]> BookGet(Expression<Func<string>> name = null, Expression<Func<string>> fromReleaseDate = null, Expression<Func<string>> toReleaseDate = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/api/books";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (fromReleaseDate != null)
                callPayload.Queries["fromReleaseDate"] = ExpressionConverter.Convert(fromReleaseDate);
            if (toReleaseDate != null)
                callPayload.Queries["toReleaseDate"] = ExpressionConverter.Convert(toReleaseDate);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["pageSize"] = Convert.ToString(10);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<BookGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetAResponse> BookGetA(Expression<Func<string>> number)
        {
            var apiCallPath = String.Format("/api/books/{0}", ExpressionConverter.ConvertWithUrlEncoding(number, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BookGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetResponseItem[]> CharacterGet(Expression<Func<string>> name = null, Expression<Func<string>> gender = null, Expression<Func<string>> culture = null, Expression<Func<string>> born = null, Expression<Func<string>> died = null, Expression<Func<bool>> isAlive = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/api/characters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (gender != null)
                callPayload.Queries["gender"] = ExpressionConverter.Convert(gender);
            if (culture != null)
                callPayload.Queries["culture"] = ExpressionConverter.Convert(culture);
            if (born != null)
                callPayload.Queries["born"] = ExpressionConverter.Convert(born);
            if (died != null)
                callPayload.Queries["died"] = ExpressionConverter.Convert(died);
            callPayload.Queries["isAlive"] = Convert.ToString(true);
            if (isAlive != null)
                callPayload.Queries["isAlive"] = ExpressionConverter.Convert(isAlive);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["pageSize"] = Convert.ToString(10);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<CharacterGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetAResponse> CharacterGetA(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/characters/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CharacterGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetResponseItem[]> HouseGet(Expression<Func<string>> name = null, Expression<Func<string>> region = null, Expression<Func<string>> words = null, Expression<Func<bool>> hasWords = null, Expression<Func<bool>> hasTitles = null, Expression<Func<bool>> hasSeats = null, Expression<Func<bool>> hasDiedOut = null, Expression<Func<bool>> hasAncestralWeapons = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var apiCallPath = "/api/houses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (region != null)
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
            if (words != null)
                callPayload.Queries["words"] = ExpressionConverter.Convert(words);
            if (hasWords != null)
                callPayload.Queries["hasWords"] = ExpressionConverter.Convert(hasWords);
            if (hasTitles != null)
                callPayload.Queries["hasTitles"] = ExpressionConverter.Convert(hasTitles);
            if (hasSeats != null)
                callPayload.Queries["hasSeats"] = ExpressionConverter.Convert(hasSeats);
            if (hasDiedOut != null)
                callPayload.Queries["hasDiedOut"] = ExpressionConverter.Convert(hasDiedOut);
            if (hasAncestralWeapons != null)
                callPayload.Queries["hasAncestralWeapons"] = ExpressionConverter.Convert(hasAncestralWeapons);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["pageSize"] = Convert.ToString(10);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<HouseGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetAResponse> HouseGetA(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/houses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HouseGetAResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Iceandfiregotip;

    public partial class WorkflowManagedActions
    {
        public IceandfiregotipActions Iceandfiregotip(string connectionId) => new IceandfiregotipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IceandfiregotipTriggers Iceandfiregotip(string connectionId) => new IceandfiregotipTriggers(connectionId);
    }
}