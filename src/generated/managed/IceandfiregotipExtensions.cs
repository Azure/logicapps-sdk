//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iceandfiregotip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IceandfiregotipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildBookGet))]
        public IBodyWorkflowAction<BookGetResponseItem[]> BookGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> fromReleaseDate = null, [WorkflowExpression] Func<string> toReleaseDate = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookGetResponseItem[]> __BuildBookGet(WorkflowExpression<string> name = null, WorkflowExpression<string> fromReleaseDate = null, WorkflowExpression<string> toReleaseDate = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(fromReleaseDate, nameof(fromReleaseDate), required: false);
            WorkflowExpression.Validate(toReleaseDate, nameof(toReleaseDate), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<BookGetResponseItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildBookGetA))]
        public IBodyWorkflowAction<BookGetAResponse> BookGetA([WorkflowExpression] Func<string> number)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BookGetAResponse> __BuildBookGetA(WorkflowExpression<string> number)
        {
            WorkflowExpression.Validate(number, nameof(number), required: true);
            return new DeferredBodyAction<BookGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/books/{0}", ExpressionConverter.ConvertWithUrlEncoding(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BookGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildCharacterGet))]
        public IBodyWorkflowAction<CharacterGetResponseItem[]> CharacterGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> culture = null, [WorkflowExpression] Func<string> born = null, [WorkflowExpression] Func<string> died = null, [WorkflowExpression] Func<bool> isAlive = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CharacterGetResponseItem[]> __BuildCharacterGet(WorkflowExpression<string> name = null, WorkflowExpression<string> gender = null, WorkflowExpression<string> culture = null, WorkflowExpression<string> born = null, WorkflowExpression<string> died = null, WorkflowExpression<bool> isAlive = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(gender, nameof(gender), required: false);
            WorkflowExpression.Validate(culture, nameof(culture), required: false);
            WorkflowExpression.Validate(born, nameof(born), required: false);
            WorkflowExpression.Validate(died, nameof(died), required: false);
            WorkflowExpression.Validate(isAlive, nameof(isAlive), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CharacterGetResponseItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildCharacterGetA))]
        public IBodyWorkflowAction<CharacterGetAResponse> CharacterGetA([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CharacterGetAResponse> __BuildCharacterGetA(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CharacterGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/characters/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CharacterGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildHouseGet))]
        public IBodyWorkflowAction<HouseGetResponseItem[]> HouseGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> words = null, [WorkflowExpression] Func<bool> hasWords = null, [WorkflowExpression] Func<bool> hasTitles = null, [WorkflowExpression] Func<bool> hasSeats = null, [WorkflowExpression] Func<bool> hasDiedOut = null, [WorkflowExpression] Func<bool> hasAncestralWeapons = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HouseGetResponseItem[]> __BuildHouseGet(WorkflowExpression<string> name = null, WorkflowExpression<string> region = null, WorkflowExpression<string> words = null, WorkflowExpression<bool> hasWords = null, WorkflowExpression<bool> hasTitles = null, WorkflowExpression<bool> hasSeats = null, WorkflowExpression<bool> hasDiedOut = null, WorkflowExpression<bool> hasAncestralWeapons = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(words, nameof(words), required: false);
            WorkflowExpression.Validate(hasWords, nameof(hasWords), required: false);
            WorkflowExpression.Validate(hasTitles, nameof(hasTitles), required: false);
            WorkflowExpression.Validate(hasSeats, nameof(hasSeats), required: false);
            WorkflowExpression.Validate(hasDiedOut, nameof(hasDiedOut), required: false);
            WorkflowExpression.Validate(hasAncestralWeapons, nameof(hasAncestralWeapons), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<HouseGetResponseItem[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        [WorkflowExpressionFactory(nameof(__BuildHouseGetA))]
        public IBodyWorkflowAction<HouseGetAResponse> HouseGetA([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HouseGetAResponse> __BuildHouseGetA(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<HouseGetAResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/houses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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