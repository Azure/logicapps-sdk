//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitiveservicescustomvision
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitiveservicescustomvisionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImage(Expression<Func<string>> projectId, Expression<Func<string>> publishedName, Expression<Func<string>> image = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_publishedName = WorkflowExpression.Compile(publishedName, nameof(publishedName), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/image", __workflow_projectId.WithUrlEncoding(1), __workflow_publishedName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> ClassifyImageUrl(Expression<Func<string>> projectId, Expression<Func<string>> publishedName, Expression<Func<string>> bodyimageURL)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_publishedName = WorkflowExpression.Compile(publishedName, nameof(publishedName), required: true);
            var __workflow_bodyimageURL = WorkflowExpression.Compile(bodyimageURL, nameof(bodyimageURL), required: true);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/customvision/v3.0/Prediction/{0}/classify/iterations/{1}/url", __workflow_projectId.WithUrlEncoding(1), __workflow_publishedName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(__workflow_bodyimageURL);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImage(Expression<Func<string>> projectId, Expression<Func<string>> publishedName, Expression<Func<string>> image = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_publishedName = WorkflowExpression.Compile(publishedName, nameof(publishedName), required: true);
            var __workflow_image = WorkflowExpression.Compile(image, nameof(image), required: false);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/image", __workflow_projectId.WithUrlEncoding(1), __workflow_publishedName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_image);
                return new ApiConnectionAction<PredictImageResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitiveservicescustomvision")]
        public IBodyWorkflowAction<PredictImageResponseV3> DetectImageUrl(Expression<Func<string>> projectId, Expression<Func<string>> publishedName, Expression<Func<string>> bodyimageURL)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_publishedName = WorkflowExpression.Compile(publishedName, nameof(publishedName), required: true);
            var __workflow_bodyimageURL = WorkflowExpression.Compile(bodyimageURL, nameof(bodyimageURL), required: true);
            return new DeferredBodyAction<PredictImageResponseV3>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/customvision/v3.0/Prediction/{0}/detect/iterations/{1}/url", __workflow_projectId.WithUrlEncoding(1), __workflow_publishedName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Url"] = ExpressionConverter.ConvertO(__workflow_bodyimageURL);
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
