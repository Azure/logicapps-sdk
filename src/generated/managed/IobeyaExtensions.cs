//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iobeya
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IobeyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListRoomsResponse> ListRooms()
        {
            var apiCallPath = "/rooms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            callPayload.Queries["size"] = Convert.ToString(200);
            return new ApiConnectionAction<ListRoomsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<CreateRoomsResponse> CreateRooms(Expression<Func<string>> bodyname, Expression<Func<string>> bodydomainName, Expression<Func<int>> bodymaximumBoards = null, Expression<Func<int>> bodymaximumUsers = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyadministrator = null)
        {
            var apiCallPath = "/rooms";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["domainName"] = CSharpExpressionConverter.ConvertToken(bodydomainName);
            if (bodymaximumBoards != null)
            {
                body["maximumBoards"] = CSharpExpressionConverter.ConvertToken(bodymaximumBoards);
                bodypropCount++;
            }

            if (bodymaximumUsers != null)
            {
                body["maximumUsers"] = CSharpExpressionConverter.ConvertToken(bodymaximumUsers);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyadministrator != null)
            {
                body["administrator"] = CSharpExpressionConverter.ConvertToken(bodyadministrator);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRoomsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListBoardsResponse> ListBoards(Expression<Func<string>> search = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var apiCallPath = "/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            callPayload.Queries["sortDirection"] = Convert.ToString("asc");
            if (sortDirection != null)
                callPayload.Queries["sortDirection"] = CSharpExpressionConverter.Convert(sortDirection);
            callPayload.Queries["page"] = Convert.ToString(1);
            callPayload.Queries["size"] = Convert.ToString(200);
            return new ApiConnectionAction<ListBoardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard(Expression<Func<typeCardInput>> typeCard, Expression<Func<object>> dynamicSchema = null)
        {
            var apiCallPath = "/cards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Type Card"] = CSharpExpressionConverter.Convert(typeCard);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(dynamicSchema);
            return new ApiConnectionAction<CreateCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateQCDIndicatorsValue(Expression<Func<string>> bodyboardId, Expression<Func<JToken[]>> bodyletters)
        {
            var apiCallPath = "/qcd/indicators-values";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["boardId"] = CSharpExpressionConverter.ConvertToken(bodyboardId);
            bodypropCount++;
            body["letters"] = CSharpExpressionConverter.ConvertToken(bodyletters);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> ComputeQCDIndicator(Expression<Func<string>> letterName, Expression<Func<string>> indicatorName, Expression<Func<double>> wedgeValue, Expression<Func<int>> wedgeNumber, Expression<Func<wedgeRingInput>> wedgeRing, Expression<Func<string>> period = null)
        {
            var apiCallPath = "/qcd/compute-indicator";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["letterName"] = CSharpExpressionConverter.ConvertO(letterName);
            callPayload.Queries["indicatorName"] = CSharpExpressionConverter.ConvertO(indicatorName);
            callPayload.Queries["wedgeValue"] = CSharpExpressionConverter.ConvertO(wedgeValue);
            callPayload.Queries["wedgeNumber"] = CSharpExpressionConverter.ConvertO(wedgeNumber);
            callPayload.Queries["wedgeRing"] = CSharpExpressionConverter.Convert(wedgeRing);
            if (period != null)
                callPayload.Queries["period"] = CSharpExpressionConverter.ConvertO(period);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListCardsActivityResponse> ListCardsActivity(Expression<Func<string>> boardId, Expression<Func<int>> page, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/cards/activity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boardId"] = CSharpExpressionConverter.ConvertO(boardId);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            callPayload.Queries["size"] = Convert.ToString(200);
            if (size != null)
                callPayload.Queries["size"] = CSharpExpressionConverter.ConvertO(size);
            return new ApiConnectionAction<ListCardsActivityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateAssetBoardImage(Expression<Func<string>> boardImageId, Expression<Func<object>> file, Expression<Func<fileContentTypeInput>> fileContentType)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/board-images/{0}/asset", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardImageId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateGauge(Expression<Func<string>> gaugeId, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/gauges/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(gaugeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class IobeyaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListRoomsResponse
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public ListRoomsResponseDataTypeItem[] Data { get; set; }
    }

    public class ListRoomsResponseDataTypeItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRoomsResponse
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("domainId")]
        public string DomainId { get; set; }
    }

    public class ListBoardsResponse
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("data")]
        public ListBoardsResponseDataTypeItem[] Data { get; set; }
    }

    public class ListBoardsResponseDataTypeItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("room")]
        public ListBoardsResponseDataTypeItemRoomType Room { get; set; }
    }

    public class ListBoardsResponseDataTypeItemRoomType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum sortDirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CreateCardResponse
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum typeCardInput
    {
        Standard,
        Activity,
        Story,
        Feature,
        [EnumMember(Value = "Problem Solving")]
        ProblemSolving,
        [EnumMember(Value = "QCD Action")]
        QCDAction
    }

    public enum wedgeRingInput
    {
        [EnumMember(Value = "inner")]
        Inner,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "outer")]
        Outer
    }

    public class ListCardsActivityResponse
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("data")]
        public ListCardsActivityResponseDataTypeItem[] Data { get; set; }
    }

    public class ListCardsActivityResponseDataTypeItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public enum fileContentTypeInput
    {
        [EnumMember(Value = "image/png")]
        ImagePng,
        [EnumMember(Value = "image/jpg")]
        ImageJpg
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iobeya;

    public partial class WorkflowManagedActions
    {
        public IobeyaActions Iobeya(string connectionId) => new IobeyaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IobeyaTriggers Iobeya(string connectionId) => new IobeyaTriggers(connectionId);
    }
}