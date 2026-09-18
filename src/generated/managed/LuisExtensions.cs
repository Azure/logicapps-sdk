//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Luis
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LuisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luis")]
        public IBodyWorkflowAction<PredictResponse> GetPredictions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> appId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> desiredIntent = null, [WorkflowExpression] Func<string> versionId = null)
        {
            var apiCallPath = String.Format("/luis/v2.0/apps/{0}/", ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (desiredIntent != null)
                callPayload.Queries["desiredIntent"] = ExpressionConverter.Convert(desiredIntent);
            callPayload.Queries["versionId"] = Convert.ToString("0.1");
            if (versionId != null)
                callPayload.Queries["versionId"] = ExpressionConverter.Convert(versionId);
            callPayload.Queries["verbose"] = Convert.ToString(true);
            return new ApiConnectionAction<PredictResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luis")]
        public IBodyWorkflowAction<GetTopScoringMatchingEntityResponse> GetTopScoringMatchingEntity([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> desiredEntity, [WorkflowExpression] Func<string> versionId = null, [WorkflowExpression] Func<string> luisPredictionObject = null)
        {
            var apiCallPath = "/noApiCall/GetTopScoringMatchingEntity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["app-id"] = ExpressionConverter.Convert(appId);
            callPayload.Queries["desiredEntity"] = ExpressionConverter.Convert(desiredEntity);
            callPayload.Queries["versionId"] = Convert.ToString("0.1");
            if (versionId != null)
                callPayload.Queries["versionId"] = ExpressionConverter.Convert(versionId);
            callPayload.Body = ExpressionConverter.ConvertO(luisPredictionObject);
            return new ApiConnectionAction<GetTopScoringMatchingEntityResponse>(callPayload);
        }
    }

    public class LuisTriggers([ConnectionName] string connectionId)
    {
    }

    public class PredictResponse
    {
        [JsonProperty("luisPrediciton")]
        public string LUISPrediction { get; set; }

        [JsonProperty("isDesiredIntent")]
        public bool IsDesiredIntent { get; set; }

        [JsonProperty("desiredIntent")]
        public string DesiredIntent { get; set; }

        [JsonProperty("query")]
        public string UtteranceText { get; set; }

        [JsonProperty("topScoringIntent")]
        public PredictResponseTopScoringIntentType TopScoringIntent { get; set; }

        [JsonProperty("intents")]
        public PredictResponseIntentsArrayTypeItem[] IntentsArray { get; set; }

        [JsonProperty("entities")]
        public LuisPredictResponseEntity[] EntitiesArray { get; set; }
    }

    public class PredictResponseTopScoringIntentType
    {
        [JsonProperty("intent")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class PredictResponseIntentsArrayTypeItem
    {
        [JsonProperty("intent")]
        public string IntentName { get; set; }

        [JsonProperty("score")]
        public double IntentScore { get; set; }
    }

    public class LuisPredictResponseEntity
    {
        [JsonProperty("entity")]
        public string EntityValue { get; set; }

        [JsonProperty("type")]
        public string EntityType { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        [JsonProperty("score")]
        public double EntityScore { get; set; }
    }

    public class GetTopScoringMatchingEntityResponse
    {
        [JsonProperty("entity")]
        public LuisPredictResponseEntityMinusType Entity { get; set; }

        [JsonProperty("entityMatchInfo")]
        public EntityMatchInfo EntityMatchInfo { get; set; }
    }

    public class LuisPredictResponseEntityMinusType
    {
        [JsonProperty("entity")]
        public string EntityValue { get; set; }

        [JsonProperty("score")]
        public double EntityScore { get; set; }

        [JsonProperty("resolution")]
        public string EntityResolution { get; set; }
    }

    public class EntityMatchInfo
    {
        [JsonProperty("desiredEntity")]
        public string DesiredEntity { get; set; }

        [JsonProperty("isEntityMatch")]
        public bool IsEntityMatch { get; set; }

        [JsonProperty("entityMatchCount")]
        public int EntityMatchCount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Luis;

    public partial class WorkflowManagedActions
    {
        public LuisActions Luis(string connectionId) => new LuisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LuisTriggers Luis(string connectionId) => new LuisTriggers(connectionId);
    }
}