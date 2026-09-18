//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Luis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LuisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luis")]
        public IBodyWorkflowAction<PredictResponse> GetPredictions([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> desiredIntent = null, [WorkflowExpression] Func<string> versionId = null)
        {
            SourceExpression.Validate(appId, nameof(appId), required: true);
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(desiredIntent, nameof(desiredIntent), required: false);
            SourceExpression.Validate(versionId, nameof(versionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/luis/v2.0/apps/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (desiredIntent != null)
                    callPayload.Queries["desiredIntent"] = SourceExpressionConverter.ConvertO(desiredIntent);
                callPayload.Queries["versionId"] = Convert.ToString("0.1");
                if (versionId != null)
                    callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                callPayload.Queries["verbose"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<PredictResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "luis")]
        public IBodyWorkflowAction<GetTopScoringMatchingEntityResponse> GetTopScoringMatchingEntity([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> desiredEntity, [WorkflowExpression] Func<string> versionId = null, [WorkflowExpression] Func<string> luisPredictionObject = null)
        {
            SourceExpression.Validate(appId, nameof(appId), required: true);
            SourceExpression.Validate(desiredEntity, nameof(desiredEntity), required: true);
            SourceExpression.Validate(versionId, nameof(versionId), required: false);
            SourceExpression.Validate(luisPredictionObject, nameof(luisPredictionObject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/noApiCall/GetTopScoringMatchingEntity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["app-id"] = SourceExpressionConverter.ConvertO(appId);
                callPayload.Queries["desiredEntity"] = SourceExpressionConverter.ConvertO(desiredEntity);
                callPayload.Queries["versionId"] = Convert.ToString("0.1");
                if (versionId != null)
                    callPayload.Queries["versionId"] = SourceExpressionConverter.ConvertO(versionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(luisPredictionObject);
                return callPayload;
            }

            return new ApiConnectionAction<GetTopScoringMatchingEntityResponse>(BuildSourceInput);
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