//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelencounterip
{
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
        [WorkflowExpressionFactory(nameof(__BuildGetMonsterJson))]
        public IBodyWorkflowAction<MonsterResponse> GetMonsterJson([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MonsterResponse> __BuildGetMonsterJson(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<MonsterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/basic/monsters/{0}/json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MonsterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        [WorkflowExpressionFactory(nameof(__BuildListMonsters))]
        public IBodyWorkflowAction<ListMonstersResponse> ListMonsters([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> startRange = null, [WorkflowExpression] Func<int> endRange = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMonstersResponse> __BuildListMonsters(WorkflowValue<int> page = null, WorkflowValue<int> startRange = null, WorkflowValue<int> endRange = null)
        {
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(startRange, nameof(startRange), required: false);
            WorkflowValue.Validate(endRange, nameof(endRange), required: false);
            return new DeferredBodyAction<ListMonstersResponse>(() =>
            {
                var apiCallPath = "/basic/monsters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (startRange != null)
                    callPayload.Queries["startRange"] = ExpressionConverter.Convert(startRange);
                if (endRange != null)
                    callPayload.Queries["endRange"] = ExpressionConverter.Convert(endRange);
                return new ApiConnectionAction<ListMonstersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRandomSvgMonster))]
        public IBodyWorkflowAction<MonsterResponse> GetRandomSvgMonster([WorkflowExpression] Func<string> primaryColor = null, [WorkflowExpression] Func<fillTypeInput> fillType = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<string> secondaryColor = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MonsterResponse> __BuildGetRandomSvgMonster(WorkflowValue<string> primaryColor = null, WorkflowValue<fillTypeInput> fillType = null, WorkflowValue<string> backgroundColor = null, WorkflowValue<string> secondaryColor = null)
        {
            WorkflowValue.Validate(primaryColor, nameof(primaryColor), required: false);
            WorkflowValue.Validate(fillType, nameof(fillType), required: false);
            WorkflowValue.Validate(backgroundColor, nameof(backgroundColor), required: false);
            WorkflowValue.Validate(secondaryColor, nameof(secondaryColor), required: false);
            return new DeferredBodyAction<MonsterResponse>(() =>
            {
                var apiCallPath = "/basic/svgmonsters/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (primaryColor != null)
                    callPayload.Queries["primaryColor"] = ExpressionConverter.Convert(primaryColor);
                if (fillType != null)
                    callPayload.Queries["fillType"] = ExpressionConverter.Convert(fillType);
                if (backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = ExpressionConverter.Convert(backgroundColor);
                if (secondaryColor != null)
                    callPayload.Queries["secondaryColor"] = ExpressionConverter.Convert(secondaryColor);
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
