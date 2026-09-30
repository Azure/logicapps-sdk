//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iobeya
{
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
        public IBodyWorkflowAction<CreateRoomsResponse> CreateRooms([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<int> bodymaximumBoards = null, [WorkflowExpression] Func<int> bodymaximumUsers = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyadministrator = null)
        {
            var apiCallPath = "/rooms";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["domainName"] = ExpressionConverter.ConvertO(bodydomainName);
            if (bodymaximumBoards != null)
            {
                body["maximumBoards"] = ExpressionConverter.ConvertO(bodymaximumBoards);
                bodypropCount++;
            }

            if (bodymaximumUsers != null)
            {
                body["maximumUsers"] = ExpressionConverter.ConvertO(bodymaximumUsers);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyadministrator != null)
            {
                body["administrator"] = ExpressionConverter.ConvertO(bodyadministrator);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRoomsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListBoardsResponse> ListBoards([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null)
        {
            var apiCallPath = "/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            callPayload.Queries["sortDirection"] = Convert.ToString("asc");
            if (sortDirection != null)
                callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(sortDirection);
            callPayload.Queries["page"] = Convert.ToString(1);
            callPayload.Queries["size"] = Convert.ToString(200);
            return new ApiConnectionAction<ListBoardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard([WorkflowExpression] Func<typeCardInput> typeCard, [WorkflowExpression] Func<object> dynamicSchema = null)
        {
            var apiCallPath = "/cards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Type Card"] = ExpressionConverter.Convert(typeCard);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicSchema);
            return new ApiConnectionAction<CreateCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateQCDIndicatorsValue([WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<JToken[]> bodyletters)
        {
            var apiCallPath = "/qcd/indicators-values";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
            bodypropCount++;
            body["letters"] = ExpressionConverter.ConvertO(bodyletters);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> ComputeQCDIndicator([WorkflowExpression] Func<string> letterName, [WorkflowExpression] Func<string> indicatorName, [WorkflowExpression] Func<double> wedgeValue, [WorkflowExpression] Func<int> wedgeNumber, [WorkflowExpression] Func<wedgeRingInput> wedgeRing, [WorkflowExpression] Func<string> period = null)
        {
            var apiCallPath = "/qcd/compute-indicator";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["letterName"] = ExpressionConverter.Convert(letterName);
            callPayload.Queries["indicatorName"] = ExpressionConverter.Convert(indicatorName);
            callPayload.Queries["wedgeValue"] = ExpressionConverter.Convert(wedgeValue);
            callPayload.Queries["wedgeNumber"] = ExpressionConverter.Convert(wedgeNumber);
            callPayload.Queries["wedgeRing"] = ExpressionConverter.Convert(wedgeRing);
            if (period != null)
                callPayload.Queries["period"] = ExpressionConverter.Convert(period);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<ListCardsActivityResponse> ListCardsActivity([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<int> page, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<int> size = null)
        {
            var apiCallPath = "/cards/activity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boardId"] = ExpressionConverter.Convert(boardId);
            if (from != null)
                callPayload.Queries["from"] = ExpressionConverter.Convert(from);
            if (to != null)
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
            callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["size"] = Convert.ToString(200);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ListCardsActivityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateAssetBoardImage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> boardImageId, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<fileContentTypeInput> fileContentType)
        {
            var apiCallPath = String.Format("/board-images/{0}/asset", ExpressionConverter.ConvertWithUrlEncoding(boardImageId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iobeya")]
        public IBodyWorkflowAction<JToken> UpdateGauge([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> gaugeId, [WorkflowExpression] Func<double> bodyvalue, [WorkflowExpression] Func<string> bodytitle = null)
        {
            var apiCallPath = String.Format("/gauges/{0}", ExpressionConverter.ConvertWithUrlEncoding(gaugeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
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