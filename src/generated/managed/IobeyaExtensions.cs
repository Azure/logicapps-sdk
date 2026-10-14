//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iobeya
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodydomainName = bodydomainName == null ? null : WorkflowExpression.Compile(bodydomainName);
            WorkflowExpression.Validate(__workflow_bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodymaximumBoards = bodymaximumBoards == null ? null : WorkflowExpression.Compile(bodymaximumBoards);
            WorkflowExpression.Validate(__workflow_bodymaximumBoards, nameof(bodymaximumBoards), required: false);
            var __workflow_bodymaximumUsers = bodymaximumUsers == null ? null : WorkflowExpression.Compile(bodymaximumUsers);
            WorkflowExpression.Validate(__workflow_bodymaximumUsers, nameof(bodymaximumUsers), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyadministrator = bodyadministrator == null ? null : WorkflowExpression.Compile(bodyadministrator);
            WorkflowExpression.Validate(__workflow_bodyadministrator, nameof(bodyadministrator), required: false);
            return new DeferredBodyAction<CreateRoomsResponse>(() =>
            {
                var apiCallPath = "/rooms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["domainName"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                if (__workflow_bodymaximumBoards != null)
                {
                    body["maximumBoards"] = ExpressionConverter.ConvertO(__workflow_bodymaximumBoards);
                    bodypropCount++;
                }

                if (__workflow_bodymaximumUsers != null)
                {
                    body["maximumUsers"] = ExpressionConverter.ConvertO(__workflow_bodymaximumUsers);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyadministrator != null)
                {
                    body["administrator"] = ExpressionConverter.ConvertO(__workflow_bodyadministrator);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateRoomsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListBoardsResponse> ListBoards(Expression<Func<string>> search = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_sortDirection = sortDirection == null ? null : WorkflowExpression.Compile(sortDirection);
            WorkflowExpression.Validate(__workflow_sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ListBoardsResponse>(() =>
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Queries["sortDirection"] = Convert.ToString("asc");
                if (__workflow_sortDirection != null)
                    callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(__workflow_sortDirection);
                callPayload.Queries["page"] = Convert.ToString(1);
                callPayload.Queries["size"] = Convert.ToString(200);
                return new ApiConnectionAction<ListBoardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard(Expression<Func<typeCardInput>> typeCard, Expression<Func<object>> dynamicSchema = null)
        {
            var __workflow_typeCard = typeCard == null ? null : WorkflowExpression.Compile(typeCard);
            WorkflowExpression.Validate(__workflow_typeCard, nameof(typeCard), required: true);
            var __workflow_dynamicSchema = dynamicSchema == null ? null : WorkflowExpression.Compile(dynamicSchema);
            WorkflowExpression.Validate(__workflow_dynamicSchema, nameof(dynamicSchema), required: false);
            return new DeferredBodyAction<CreateCardResponse>(() =>
            {
                var apiCallPath = "/cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Type Card"] = ExpressionConverter.Convert(__workflow_typeCard);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicSchema);
                return new ApiConnectionAction<CreateCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateQCDIndicatorsValue(Expression<Func<string>> bodyboardId, Expression<Func<JToken[]>> bodyletters)
        {
            var __workflow_bodyboardId = bodyboardId == null ? null : WorkflowExpression.Compile(bodyboardId);
            WorkflowExpression.Validate(__workflow_bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodyletters = bodyletters == null ? null : WorkflowExpression.Compile(bodyletters);
            WorkflowExpression.Validate(__workflow_bodyletters, nameof(bodyletters), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/qcd/indicators-values";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                bodypropCount++;
                body["letters"] = ExpressionConverter.ConvertO(__workflow_bodyletters);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> ComputeQCDIndicator(Expression<Func<string>> letterName, Expression<Func<string>> indicatorName, Expression<Func<double>> wedgeValue, Expression<Func<int>> wedgeNumber, Expression<Func<wedgeRingInput>> wedgeRing, Expression<Func<string>> period = null)
        {
            var __workflow_letterName = letterName == null ? null : WorkflowExpression.Compile(letterName);
            WorkflowExpression.Validate(__workflow_letterName, nameof(letterName), required: true);
            var __workflow_indicatorName = indicatorName == null ? null : WorkflowExpression.Compile(indicatorName);
            WorkflowExpression.Validate(__workflow_indicatorName, nameof(indicatorName), required: true);
            var __workflow_wedgeValue = wedgeValue == null ? null : WorkflowExpression.Compile(wedgeValue);
            WorkflowExpression.Validate(__workflow_wedgeValue, nameof(wedgeValue), required: true);
            var __workflow_wedgeNumber = wedgeNumber == null ? null : WorkflowExpression.Compile(wedgeNumber);
            WorkflowExpression.Validate(__workflow_wedgeNumber, nameof(wedgeNumber), required: true);
            var __workflow_wedgeRing = wedgeRing == null ? null : WorkflowExpression.Compile(wedgeRing);
            WorkflowExpression.Validate(__workflow_wedgeRing, nameof(wedgeRing), required: true);
            var __workflow_period = period == null ? null : WorkflowExpression.Compile(period);
            WorkflowExpression.Validate(__workflow_period, nameof(period), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/qcd/compute-indicator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["letterName"] = ExpressionConverter.Convert(__workflow_letterName);
                callPayload.Queries["indicatorName"] = ExpressionConverter.Convert(__workflow_indicatorName);
                callPayload.Queries["wedgeValue"] = ExpressionConverter.Convert(__workflow_wedgeValue);
                callPayload.Queries["wedgeNumber"] = ExpressionConverter.Convert(__workflow_wedgeNumber);
                callPayload.Queries["wedgeRing"] = ExpressionConverter.Convert(__workflow_wedgeRing);
                if (__workflow_period != null)
                    callPayload.Queries["period"] = ExpressionConverter.Convert(__workflow_period);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListCardsActivityResponse> ListCardsActivity(Expression<Func<string>> boardId, Expression<Func<int>> page, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<int>> size = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: true);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: false);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: false);
            return new DeferredBodyAction<ListCardsActivityResponse>(() =>
            {
                var apiCallPath = "/cards/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boardId"] = ExpressionConverter.Convert(__workflow_boardId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["size"] = Convert.ToString(200);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<ListCardsActivityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateAssetBoardImage(Expression<Func<string>> boardImageId, Expression<Func<object>> file, Expression<Func<fileContentTypeInput>> fileContentType)
        {
            var __workflow_boardImageId = boardImageId == null ? null : WorkflowExpression.Compile(boardImageId);
            WorkflowExpression.Validate(__workflow_boardImageId, nameof(boardImageId), required: true);
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: true);
            var __workflow_fileContentType = fileContentType == null ? null : WorkflowExpression.Compile(fileContentType);
            WorkflowExpression.Validate(__workflow_fileContentType, nameof(fileContentType), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board-images/{0}/asset", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardImageId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateGauge(Expression<Func<string>> gaugeId, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_gaugeId = gaugeId == null ? null : WorkflowExpression.Compile(gaugeId);
            WorkflowExpression.Validate(__workflow_gaugeId, nameof(gaugeId), required: true);
            var __workflow_bodyvalue = bodyvalue == null ? null : WorkflowExpression.Compile(bodyvalue);
            WorkflowExpression.Validate(__workflow_bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/gauges/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_gaugeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
