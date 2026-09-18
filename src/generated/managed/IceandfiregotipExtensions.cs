//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iceandfiregotip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IceandfiregotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetResponseItem[]> BookGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> fromReleaseDate = null, [WorkflowExpression] Func<string> toReleaseDate = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(fromReleaseDate, nameof(fromReleaseDate), required: false);
            SourceExpression.Validate(toReleaseDate, nameof(toReleaseDate), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/books";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (fromReleaseDate != null)
                    callPayload.Queries["fromReleaseDate"] = SourceExpressionConverter.ConvertO(fromReleaseDate);
                if (toReleaseDate != null)
                    callPayload.Queries["toReleaseDate"] = SourceExpressionConverter.ConvertO(toReleaseDate);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<BookGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<BookGetAResponse> BookGetA([WorkflowExpression] Func<string> number)
        {
            SourceExpression.Validate(number, nameof(number), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/books/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BookGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetResponseItem[]> CharacterGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> culture = null, [WorkflowExpression] Func<string> born = null, [WorkflowExpression] Func<string> died = null, [WorkflowExpression] Func<bool> isAlive = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(gender, nameof(gender), required: false);
            SourceExpression.Validate(culture, nameof(culture), required: false);
            SourceExpression.Validate(born, nameof(born), required: false);
            SourceExpression.Validate(died, nameof(died), required: false);
            SourceExpression.Validate(isAlive, nameof(isAlive), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/characters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (gender != null)
                    callPayload.Queries["gender"] = SourceExpressionConverter.ConvertO(gender);
                if (culture != null)
                    callPayload.Queries["culture"] = SourceExpressionConverter.ConvertO(culture);
                if (born != null)
                    callPayload.Queries["born"] = SourceExpressionConverter.ConvertO(born);
                if (died != null)
                    callPayload.Queries["died"] = SourceExpressionConverter.ConvertO(died);
                callPayload.Queries["isAlive"] = Convert.ToString(true);
                if (isAlive != null)
                    callPayload.Queries["isAlive"] = SourceExpressionConverter.ConvertO(isAlive);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<CharacterGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<CharacterGetAResponse> CharacterGetA([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/characters/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CharacterGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetResponseItem[]> HouseGet([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> words = null, [WorkflowExpression] Func<bool> hasWords = null, [WorkflowExpression] Func<bool> hasTitles = null, [WorkflowExpression] Func<bool> hasSeats = null, [WorkflowExpression] Func<bool> hasDiedOut = null, [WorkflowExpression] Func<bool> hasAncestralWeapons = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(words, nameof(words), required: false);
            SourceExpression.Validate(hasWords, nameof(hasWords), required: false);
            SourceExpression.Validate(hasTitles, nameof(hasTitles), required: false);
            SourceExpression.Validate(hasSeats, nameof(hasSeats), required: false);
            SourceExpression.Validate(hasDiedOut, nameof(hasDiedOut), required: false);
            SourceExpression.Validate(hasAncestralWeapons, nameof(hasAncestralWeapons), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/houses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (words != null)
                    callPayload.Queries["words"] = SourceExpressionConverter.ConvertO(words);
                if (hasWords != null)
                    callPayload.Queries["hasWords"] = SourceExpressionConverter.ConvertO(hasWords);
                if (hasTitles != null)
                    callPayload.Queries["hasTitles"] = SourceExpressionConverter.ConvertO(hasTitles);
                if (hasSeats != null)
                    callPayload.Queries["hasSeats"] = SourceExpressionConverter.ConvertO(hasSeats);
                if (hasDiedOut != null)
                    callPayload.Queries["hasDiedOut"] = SourceExpressionConverter.ConvertO(hasDiedOut);
                if (hasAncestralWeapons != null)
                    callPayload.Queries["hasAncestralWeapons"] = SourceExpressionConverter.ConvertO(hasAncestralWeapons);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["pageSize"] = Convert.ToString(10);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<HouseGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iceandfiregotip")]
        public IBodyWorkflowAction<HouseGetAResponse> HouseGetA([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/houses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HouseGetAResponse>(BuildSourceInput);
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