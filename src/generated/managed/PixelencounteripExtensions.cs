//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelencounterip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelencounteripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetRandomMonsterJson()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/basic/monsters/random/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MonsterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetMonsterJson([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/basic/monsters/{0}/json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MonsterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<ListMonstersResponse> ListMonsters([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> startRange = null, [WorkflowExpression] Func<int> endRange = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(startRange, nameof(startRange), required: false);
            SourceExpression.Validate(endRange, nameof(endRange), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/basic/monsters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (startRange != null)
                    callPayload.Queries["startRange"] = SourceExpressionConverter.ConvertO(startRange);
                if (endRange != null)
                    callPayload.Queries["endRange"] = SourceExpressionConverter.ConvertO(endRange);
                return callPayload;
            }

            return new ApiConnectionAction<ListMonstersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelencounterip")]
        public IBodyWorkflowAction<MonsterResponse> GetRandomSvgMonster([WorkflowExpression] Func<string> primaryColor = null, [WorkflowExpression] Func<fillTypeInput> fillType = null, [WorkflowExpression] Func<string> backgroundColor = null, [WorkflowExpression] Func<string> secondaryColor = null)
        {
            SourceExpression.Validate(primaryColor, nameof(primaryColor), required: false);
            SourceExpression.Validate(fillType, nameof(fillType), required: false);
            SourceExpression.Validate(backgroundColor, nameof(backgroundColor), required: false);
            SourceExpression.Validate(secondaryColor, nameof(secondaryColor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/basic/svgmonsters/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (primaryColor != null)
                    callPayload.Queries["primaryColor"] = SourceExpressionConverter.ConvertO(primaryColor);
                if (fillType != null)
                    callPayload.Queries["fillType"] = SourceExpressionConverter.Convert(fillType);
                if (backgroundColor != null)
                    callPayload.Queries["backgroundColor"] = SourceExpressionConverter.ConvertO(backgroundColor);
                if (secondaryColor != null)
                    callPayload.Queries["secondaryColor"] = SourceExpressionConverter.ConvertO(secondaryColor);
                return callPayload;
            }

            return new ApiConnectionAction<MonsterResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
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