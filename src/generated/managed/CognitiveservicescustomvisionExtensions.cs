//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescustomvision
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescustomvisionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImage([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> image = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<PredictImageResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImageUrl([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> bodyimageURL)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/url", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = SourceExpressionConverter.ConvertToken(bodyimageURL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PredictImageResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImage([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> image = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(image);
                return callPayload;
            }

            return new ApiConnectionAction<PredictImageResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImageUrl([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> bodyimageURL)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/url", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = SourceExpressionConverter.ConvertToken(bodyimageURL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PredictImageResponseV3>(BuildSourceInput);
        }
    }

    public class CognitiveservicescustomvisionTriggers([ConnectionName] string connectionId)
    {
    }

    public class PredictImageResponseV3
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("iteration")]
        public string Iteration { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("predictions")]
        public PredictImageResponseV3PredictionsTypeItem[] Predictions { get; set; }
    }

    public class PredictImageResponseV3PredictionsTypeItem
    {
        [JsonProperty("probability")]
        public double Probability { get; set; }

        [JsonProperty("tagName")]
        public string Tag { get; set; }

        [JsonProperty("tagId")]
        public string TagId { get; set; }

        [JsonProperty("boundingBox")]
        public PredictImageResponseV3PredictionsTypeItemBoundingBoxType BoundingBox { get; set; }
    }

    public class PredictImageResponseV3PredictionsTypeItemBoundingBoxType
    {
        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescustomvision;

    public partial class WorkflowManagedActions
    {
        public CognitiveservicescustomvisionActions Cognitiveservicescustomvision(string connectionId) => new CognitiveservicescustomvisionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitiveservicescustomvisionTriggers Cognitiveservicescustomvision(string connectionId) => new CognitiveservicescustomvisionTriggers(connectionId);
    }
}