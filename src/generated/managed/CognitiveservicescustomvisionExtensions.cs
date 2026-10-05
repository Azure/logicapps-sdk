//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescustomvision
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescustomvisionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        [WorkflowExpressionFactory(nameof(__BuildClassifyImage))]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImage([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> image = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PredictImageResponseV3> __BuildClassifyImage(WorkflowValue<string> projectId, WorkflowValue<string> publishedName, WorkflowValue<string> image = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(publishedName, nameof(publishedName), required: true);
            WorkflowValue.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        [WorkflowExpressionFactory(nameof(__BuildClassifyImageUrl))]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImageUrl([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> bodyimageURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PredictImageResponseV3> __BuildClassifyImageUrl(WorkflowValue<string> projectId, WorkflowValue<string> publishedName, WorkflowValue<string> bodyimageURL)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(publishedName, nameof(publishedName), required: true);
            WorkflowValue.Validate(bodyimageURL, nameof(bodyimageURL), required: true);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/url", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(bodyimageURL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        [WorkflowExpressionFactory(nameof(__BuildDetectImage))]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImage([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> image = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PredictImageResponseV3> __BuildDetectImage(WorkflowValue<string> projectId, WorkflowValue<string> publishedName, WorkflowValue<string> image = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(publishedName, nameof(publishedName), required: true);
            WorkflowValue.Validate(image, nameof(image), required: false);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(image);
                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        [WorkflowExpressionFactory(nameof(__BuildDetectImageUrl))]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImageUrl([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> publishedName, [WorkflowExpression] Func<string> bodyimageURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PredictImageResponseV3> __BuildDetectImageUrl(WorkflowValue<string> projectId, WorkflowValue<string> publishedName, WorkflowValue<string> bodyimageURL)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(publishedName, nameof(publishedName), required: true);
            WorkflowValue.Validate(bodyimageURL, nameof(bodyimageURL), required: true);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/url", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(publishedName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(bodyimageURL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
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
