//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Diffcheckerip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DiffcheckeripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        public IBodyWorkflowAction<CheckTextResponse, ApiConnectionActionConfiguration> CheckText(Expression<Func<CheckTextInput>> body, Expression<Func<diffLevelInput>> diffLevel = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_diffLevel = WorkflowExpression.Compile(diffLevel, nameof(diffLevel), required: false);
            return new DeferredBodyAction<CheckTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output_type"] = Convert.ToString("json");
                callPayload.Queries["diff_level"] = Convert.ToString("word");
                if (__workflow_diffLevel != null)
                    callPayload.Queries["diff_level"] = ExpressionConverter.Convert(__workflow_diffLevel);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "diffcheckerip")]
        public IBodyWorkflowAction<CheckImageResponse, ApiConnectionActionConfiguration> CheckImage(Expression<Func<CheckImageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CheckImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["input_type"] = Convert.ToString("json");
                callPayload.Queries["output_type"] = Convert.ToString("json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CheckTextInput
    {
        [JsonProperty("left", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Left { get; set; }

        [JsonProperty("right", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Right { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CheckImageInput
    {
        [JsonProperty("left_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LeftImage { get; set; }

        [JsonProperty("right_image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RightImage { get; set; }
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