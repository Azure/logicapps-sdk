//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelencounterip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelencounteripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetRandomMonsterJson()
        {
            var apiCallPath = "/basic/monsters/random/json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MonsterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetMonsterJson(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MonsterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/basic/monsters/{0}/json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MonsterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<ListMonstersResponse> ListMonsters(Expression<Func<int>> page = null, Expression<Func<int>> startRange = null, Expression<Func<int>> endRange = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_startRange = WorkflowExpression.Compile(startRange, nameof(startRange), required: false);
            var __workflow_endRange = WorkflowExpression.Compile(endRange, nameof(endRange), required: false);
            return new DeferredBodyAction<ListMonstersResponse>(() =>
            {
                var apiCallPath = "/basic/monsters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_startRange != null)
                    callPayload.Queries["startRange"] = ExpressionConverter.Convert(__workflow_startRange);
                if (__workflow_endRange != null)
                    callPayload.Queries["endRange"] = ExpressionConverter.Convert(__workflow_endRange);
                return new ApiConnectionAction<ListMonstersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetRandomSvgMonster(Expression<Func<string>> primaryColor = null, Expression<Func<fillTypeInput>> fillType = null, Expression<Func<string>> backgroundColor = null, Expression<Func<string>> secondaryColor = null)
        {
            var __workflow_primaryColor = WorkflowExpression.Compile(primaryColor, nameof(primaryColor), required: false);
            var __workflow_fillType = WorkflowExpression.Compile(fillType, nameof(fillType), required: false);
            var __workflow_backgroundColor = WorkflowExpression.Compile(backgroundColor, nameof(backgroundColor), required: false);
            var __workflow_secondaryColor = WorkflowExpression.Compile(secondaryColor, nameof(secondaryColor), required: false);
            return new DeferredBodyAction<MonsterResponse>(() =>
            {
                var apiCallPath = "/basic/svgmonsters/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_primaryColor != null)
                    callPayload.Queries["primaryColor"] = ExpressionConverter.Convert(__workflow_primaryColor);
                if (__workflow_fillType != null)
                    callPayload.Queries["fillType"] = ExpressionConverter.Convert(__workflow_fillType);
                if (__workflow_backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(__workflow_backgroundColor);
                if (__workflow_secondaryColor != null)
                    callPayload.Queries["secondaryColor"] = ExpressionConverter.Convert(__workflow_secondaryColor);
                return new ApiConnectionAction<MonsterResponse>(callPayload);
            });
        }
    }

    public class PixelencounteripTriggers([ConnectionName] string connectionId)
    {
    }

    public class MonsterResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dataId")]
        public string DataId { get; set; }

        [JsonProperty("colors")]
        public JToken Colors { get; set; }

        [JsonProperty("pattern")]
        public int[][] Pattern { get; set; }

        [JsonProperty("fillType")]
        public int FillType { get; set; }
    }

    public class ListMonstersResponse
    {
        [JsonProperty("results")]
        public ListMonstersResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("firstRowOnPage")]
        public int FirstRowOnPage { get; set; }

        [JsonProperty("rowCountOnLastPage")]
        public int RowCountOnLastPage { get; set; }

        [JsonProperty("lastRowOnPage")]
        public int LastRowOnPage { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("rowCount")]
        public int RowCount { get; set; }
    }

    public class ListMonstersResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("svgContent")]
        public string SvgContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fillTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pixelencounterip;

    public partial class WorkflowManagedActions
    {
        public PixelencounteripActions Pixelencounterip(string connectionId) => new PixelencounteripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelencounteripTriggers Pixelencounterip(string connectionId) => new PixelencounteripTriggers(connectionId);
    }
}
