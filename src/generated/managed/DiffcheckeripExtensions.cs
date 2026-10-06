//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Diffcheckerip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DiffcheckeripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        [WorkflowExpressionFactory(nameof(__BuildCheckText))]
        public IBodyWorkflowAction<CheckTextResponse> CheckText([WorkflowExpression] Func<string> bodyleft, [WorkflowExpression] Func<string> bodyright, [WorkflowExpression] Func<diffLevelInput> diffLevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckTextResponse> __BuildCheckText(WorkflowExpression<string> bodyleft, WorkflowExpression<string> bodyright, WorkflowExpression<diffLevelInput> diffLevel = null)
        {
            WorkflowExpression.Validate(bodyleft, nameof(bodyleft), required: true);
            WorkflowExpression.Validate(bodyright, nameof(bodyright), required: true);
            WorkflowExpression.Validate(diffLevel, nameof(diffLevel), required: false);
            return new DeferredBodyAction<CheckTextResponse>(() =>
            {
                var apiCallPath = "/public/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output_type"] = Convert.ToString("json");
                callPayload.Queries["diff_level"] = Convert.ToString("word");
                if (diffLevel != null)
                    callPayload.Queries["diff_level"] = ExpressionConverter.Convert(diffLevel);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["left"] = ExpressionConverter.ConvertO(bodyleft);
                bodypropCount++;
                body["right"] = ExpressionConverter.ConvertO(bodyright);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        [WorkflowExpressionFactory(nameof(__BuildCheckImage))]
        public IBodyWorkflowAction<CheckImageResponse> CheckImage([WorkflowExpression] Func<string> bodyleftImage, [WorkflowExpression] Func<string> bodyrightImage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckImageResponse> __BuildCheckImage(WorkflowExpression<string> bodyleftImage, WorkflowExpression<string> bodyrightImage)
        {
            WorkflowExpression.Validate(bodyleftImage, nameof(bodyleftImage), required: true);
            WorkflowExpression.Validate(bodyrightImage, nameof(bodyrightImage), required: true);
            return new DeferredBodyAction<CheckImageResponse>(() =>
            {
                var apiCallPath = "/public/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["input_type"] = Convert.ToString("json");
                callPayload.Queries["output_type"] = Convert.ToString("json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["left_image"] = ExpressionConverter.ConvertO(bodyleftImage);
                bodypropCount++;
                body["right_image"] = ExpressionConverter.ConvertO(bodyrightImage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckImageResponse>(callPayload);
            });
        }
    }

    public class DiffcheckeripTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckTextResponse
    {
        [JsonProperty("rows")]
        public CheckTextResponseRowsTypeItem[] Rows { get; set; }

        [JsonProperty("added")]
        public int Added { get; set; }

        [JsonProperty("removed")]
        public int Removed { get; set; }
    }

    public class CheckTextResponseRowsTypeItem
    {
        [JsonProperty("end")]
        public bool End { get; set; }

        [JsonProperty("left")]
        public CheckTextResponseRowsTypeItemLeftType Left { get; set; }

        [JsonProperty("right")]
        public CheckTextResponseRowsTypeItemRightType Right { get; set; }

        [JsonProperty("insideChanged")]
        public bool InsideChanged { get; set; }

        [JsonProperty("start")]
        public bool Start { get; set; }
    }

    public class CheckTextResponseRowsTypeItemLeftType
    {
        [JsonProperty("chunks")]
        public CheckTextResponseRowsTypeItemLeftTypeChunksTypeItem[] Chunks { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }
    }

    public class CheckTextResponseRowsTypeItemLeftTypeChunksTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CheckTextResponseRowsTypeItemRightType
    {
        [JsonProperty("chunks")]
        public CheckTextResponseRowsTypeItemRightTypeChunksTypeItem[] Chunks { get; set; }

        [JsonProperty("line")]
        public int Line { get; set; }
    }

    public class CheckTextResponseRowsTypeItemRightTypeChunksTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum diffLevelInput
    {
        [EnumMember(Value = "character")]
        Character,
        [EnumMember(Value = "word")]
        Word
    }

    public class CheckImageResponse
    {
        [JsonProperty("dataUrl")]
        public string DataUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Diffcheckerip;

    public partial class WorkflowManagedActions
    {
        public DiffcheckeripActions Diffcheckerip(string connectionId) => new DiffcheckeripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DiffcheckeripTriggers Diffcheckerip(string connectionId) => new DiffcheckeripTriggers(connectionId);
    }
}