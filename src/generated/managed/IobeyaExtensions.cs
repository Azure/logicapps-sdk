//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iobeya
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IobeyaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListRoomsResponse, ApiConnectionActionConfiguration> ListRooms()
        {
            return new DeferredBodyAction<ListRoomsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/rooms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                callPayload.Queries["size"] = Convert.ToString(200);
                return new ApiConnectionAction<ListRoomsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<CreateRoomsResponse, ApiConnectionActionConfiguration> CreateRooms(Expression<Func<string>> bodyname, Expression<Func<string>> bodydomainName, Expression<Func<int>> bodymaximumBoards = null, Expression<Func<int>> bodymaximumUsers = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyadministrator = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodymaximumBoards = WorkflowExpression.Compile(bodymaximumBoards, nameof(bodymaximumBoards), required: false);
            var __workflow_bodymaximumUsers = WorkflowExpression.Compile(bodymaximumUsers, nameof(bodymaximumUsers), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyadministrator = WorkflowExpression.Compile(bodyadministrator, nameof(bodyadministrator), required: false);
            return new DeferredBodyAction<CreateRoomsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ListBoardsResponse, ApiConnectionActionConfiguration> ListBoards(Expression<Func<string>> search = null, Expression<Func<sortDirectionInput>> sortDirection = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            return new DeferredBodyAction<ListBoardsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateCardResponse, ApiConnectionActionConfiguration> CreateCard(Expression<Func<typeCardInput>> typeCard, Expression<Func<object>> dynamicSchema = null)
        {
            var __workflow_typeCard = WorkflowExpression.Compile(typeCard, nameof(typeCard), required: true);
            var __workflow_dynamicSchema = WorkflowExpression.Compile(dynamicSchema, nameof(dynamicSchema), required: false);
            return new DeferredBodyAction<CreateCardResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateQCDIndicatorsValue(Expression<Func<string>> bodyboardId, Expression<Func<JToken[]>> bodyletters)
        {
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodyletters = WorkflowExpression.Compile(bodyletters, nameof(bodyletters), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ComputeQCDIndicator(Expression<Func<string>> letterName, Expression<Func<string>> indicatorName, Expression<Func<double>> wedgeValue, Expression<Func<int>> wedgeNumber, Expression<Func<wedgeRingInput>> wedgeRing, Expression<Func<string>> period = null)
        {
            var __workflow_letterName = WorkflowExpression.Compile(letterName, nameof(letterName), required: true);
            var __workflow_indicatorName = WorkflowExpression.Compile(indicatorName, nameof(indicatorName), required: true);
            var __workflow_wedgeValue = WorkflowExpression.Compile(wedgeValue, nameof(wedgeValue), required: true);
            var __workflow_wedgeNumber = WorkflowExpression.Compile(wedgeNumber, nameof(wedgeNumber), required: true);
            var __workflow_wedgeRing = WorkflowExpression.Compile(wedgeRing, nameof(wedgeRing), required: true);
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ListCardsActivityResponse, ApiConnectionActionConfiguration> ListCardsActivity(Expression<Func<string>> boardId, Expression<Func<int>> page, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<int>> size = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<ListCardsActivityResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateGauge(Expression<Func<string>> gaugeId, Expression<Func<double>> bodyvalue, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_gaugeId = WorkflowExpression.Compile(gaugeId, nameof(gaugeId), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gauges/{0}", __workflow_gaugeId.WithUrlEncoding(1)));
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