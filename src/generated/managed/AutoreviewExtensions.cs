//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutoreviewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<GetInfoResponse, ApiConnectionActionConfiguration> GetInfo()
        {
            return new DeferredBodyAction<GetInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostHttp(Expression<Func<string>> path = null, Expression<Func<PostHttpBodyInput>> body = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<PostJsonResponse, ApiConnectionActionConfiguration> PostJson(Expression<Func<PostJsonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<PostDiagramResponse, ApiConnectionActionConfiguration> PostDiagram(Expression<Func<PostDiagramBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostDiagramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/diagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostDiagramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<PostFileResponse, ApiConnectionActionConfiguration> PostFile(Expression<Func<PostFileBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostFileResponse>(callPayload);
            });
        }
    }

    public class AutoreviewTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetInfoResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }

        [JsonProperty("diagram")]
        public string Diagram { get; set; }
    }

    public class PostHttpBodyInput
    {
        [JsonProperty("configs")]
        public JToken Config { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class PostJsonResponse
    {
        [JsonProperty("data")]
        public PostJsonResponseDataType Data { get; set; }
    }

    public class PostJsonResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("triggerParam")]
        public string TriggerParam { get; set; }

        [JsonProperty("triggerData")]
        public string TriggerData { get; set; }

        [JsonProperty("triggerConfig")]
        public string TriggerConfig { get; set; }

        [JsonProperty("triggerExpress")]
        public string TriggerExpress { get; set; }

        [JsonProperty("triggerInputs")]
        public string TriggerInputs { get; set; }

        [JsonProperty("triggerRecur")]
        public string TriggerRecur { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }

        [JsonProperty("connectionRefs")]
        public int ConnectionRefs { get; set; }

        [JsonProperty("connectors")]
        public int Connectors { get; set; }

        [JsonProperty("steps")]
        public int Steps { get; set; }

        [JsonProperty("variables")]
        public int Variables { get; set; }

        [JsonProperty("complexity")]
        public int Complexity { get; set; }

        [JsonProperty("varNaming")]
        public bool VarNaming { get; set; }

        [JsonProperty("varNameConsts")]
        public bool VarNameConsts { get; set; }

        [JsonProperty("varNameUse")]
        public bool VarNameUse { get; set; }

        [JsonProperty("composes")]
        public int Composes { get; set; }

        [JsonProperty("exception")]
        public int Exception { get; set; }

        [JsonProperty("exceptionHandleScope")]
        public bool ExceptionHandleScope { get; set; }

        [JsonProperty("exceptionScope")]
        public bool ExceptionScope { get; set; }

        [JsonProperty("exceptionTerminate")]
        public bool ExceptionTerminate { get; set; }

        [JsonProperty("exceptionLink")]
        public bool ExceptionLink { get; set; }

        [JsonProperty("mainScope")]
        public bool MainScope { get; set; }

        [JsonProperty("variableArray")]
        public PostJsonResponseDataTypeVariableArrayTypeItem[] VariableArray { get; set; }

        [JsonProperty("actionArray")]
        public PostJsonResponseDataTypeActionArrayTypeItem[] ActionArray { get; set; }

        [JsonProperty("apiActionArray")]
        public PostJsonResponseDataTypeApiActionArrayTypeItem[] ApiActionArray { get; set; }

        [JsonProperty("exceptionArray")]
        public PostJsonResponseDataTypeExceptionArrayTypeItem[] ExceptionArray { get; set; }

        [JsonProperty("connectionArray")]
        public PostJsonResponseDataTypeConnectionArrayTypeItem[] ConnectionArray { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("actionObjectArray")]
        public PostJsonResponseDataTypeActionObjectArrayTypeItem[] ActionObjectArray { get; set; }
    }

    public class PostJsonResponseDataTypeVariableArrayTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("used")]
        public bool Used { get; set; }

        [JsonProperty("named")]
        public bool Named { get; set; }
    }

    public class PostJsonResponseDataTypeActionArrayTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hashId")]
        public string HashId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("connector")]
        public string Connector { get; set; }

        [JsonProperty("imgURL")]
        public string ImgUrl { get; set; }

        [JsonProperty("runAfter")]
        public string RunAfter { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("complexity")]
        public int Complexity { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("pagination")]
        public string Pagination { get; set; }

        [JsonProperty("secure")]
        public string Secure { get; set; }

        [JsonProperty("retry")]
        public string Retry { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionInfo")]
        public string PositionInfo { get; set; }

        [JsonProperty("environmentVariables")]
        public string EnvironmentVariables { get; set; }

        [JsonProperty("environmentB")]
        public bool EnvironmentB { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("positionIndex")]
        public string PositionIndex { get; set; }

        [JsonProperty("positionType")]
        public string PositionType { get; set; }

        [JsonProperty("nested")]
        public string Nested { get; set; }
    }

    public class PostJsonResponseDataTypeApiActionArrayTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hashId")]
        public string HashId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("connector")]
        public string Connector { get; set; }

        [JsonProperty("imgURL")]
        public string ImgUrl { get; set; }

        [JsonProperty("runAfter")]
        public string RunAfter { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("complexity")]
        public int Complexity { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("pagination")]
        public string Pagination { get; set; }

        [JsonProperty("secure")]
        public string Secure { get; set; }

        [JsonProperty("retry")]
        public string Retry { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionInfo")]
        public string PositionInfo { get; set; }

        [JsonProperty("environmentVariables")]
        public string EnvironmentVariables { get; set; }

        [JsonProperty("environmentB")]
        public bool EnvironmentB { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("positionIndex")]
        public string PositionIndex { get; set; }

        [JsonProperty("positionType")]
        public string PositionType { get; set; }

        [JsonProperty("nested")]
        public string Nested { get; set; }
    }

    public class PostJsonResponseDataTypeExceptionArrayTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hashId")]
        public string HashId { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("connector")]
        public string Connector { get; set; }

        [JsonProperty("imgURL")]
        public string ImgUrl { get; set; }

        [JsonProperty("runAfter")]
        public string RunAfter { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("complexity")]
        public int Complexity { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("pagination")]
        public string Pagination { get; set; }

        [JsonProperty("secure")]
        public string Secure { get; set; }

        [JsonProperty("retry")]
        public string Retry { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionInfo")]
        public string PositionInfo { get; set; }

        [JsonProperty("environmentVariables")]
        public string EnvironmentVariables { get; set; }

        [JsonProperty("environmentB")]
        public bool EnvironmentB { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("positionIndex")]
        public string PositionIndex { get; set; }

        [JsonProperty("positionType")]
        public string PositionType { get; set; }

        [JsonProperty("nested")]
        public string Nested { get; set; }
    }

    public class PostJsonResponseDataTypeConnectionArrayTypeItem
    {
        [JsonProperty("conName")]
        public string ConName { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("opId")]
        public string OpId { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PostJsonResponseDataTypeActionObjectArrayTypeItem
    {
        [JsonProperty("step")]
        public string Step { get; set; }

        [JsonProperty("connector")]
        public string Connector { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hashId")]
        public string HashId { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class PostJsonBodyInput
    {
        public PostJsonBodyInput(BodyInputFlowPropertiesType flowProperties)
        {
            this.FlowProperties = flowProperties;
        }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFlowPropertiesType FlowProperties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigsType Configs { get; set; } = new BodyInputConfigsType();
    }

    public class BodyInputFlowPropertiesType
    {
        public BodyInputFlowPropertiesType(string displayName, string flowId, string owner, string environment, JToken definition)
        {
            this.DisplayName = displayName;
            this.FlowId = flowId;
            this.Owner = owner;
            this.Environment = environment;
            this.Definition = definition;
        }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowId { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Owner { get; set; }

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Environment { get; set; }

        [JsonProperty("definition", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Definition { get; set; }
    }

    public class BodyInputConfigsType
    {
        [JsonProperty("naming")]
        public JToken NamingConvention { get; set; }

        [JsonProperty("complexity")]
        public string[] Complexity { get; set; }

        [JsonProperty("ratings")]
        public JToken ReviewRatings { get; set; }

        [JsonProperty("scoring")]
        public string[] Scoring { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ResponseType { get; set; } = "json";
    }

    public class PostDiagramResponse
    {
        [JsonProperty("data")]
        public PostDiagramResponseDataType Data { get; set; }
    }

    public class PostDiagramResponseDataType
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class PostDiagramBodyInput
    {
        public PostDiagramBodyInput(BodyInputPropertiesType properties)
        {
            this.Properties = properties;
        }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPropertiesType Properties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostDiagramBodyInputConfigType Config { get; set; } = new PostDiagramBodyInputConfigType();
    }

    public class BodyInputPropertiesType
    {
        public BodyInputPropertiesType(string displayName, string flowId, string owner, string environment, JToken definition)
        {
            this.DisplayName = displayName;
            this.FlowId = flowId;
            this.Owner = owner;
            this.Environment = environment;
            this.Definition = definition;
        }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FlowId { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Owner { get; set; }

        [JsonProperty("environment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Environment { get; set; }

        [JsonProperty("definition", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Definition { get; set; }
    }

    public class PostDiagramBodyInputConfigType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputConfigTypeImageTypeType ImageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview.BodyInputConfigTypeImageTypeType.Svg;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputConfigTypeImageTypeType
    {
        [EnumMember(Value = "SVG")]
        Svg,
        [EnumMember(Value = "PNG")]
        Png
    }

    public class PostFileResponse
    {
        [JsonProperty("data")]
        public PostFileResponseDataType Data { get; set; }
    }

    public class PostFileResponseDataType
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class PostFileBodyInput
    {
        public PostFileBodyInput(BodyInputFlowPropertiesType flowProperties)
        {
            this.FlowProperties = flowProperties;
        }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFlowPropertiesType FlowProperties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostFileBodyInputConfigType Config { get; set; } = new PostFileBodyInputConfigType();
    }

    public class PostFileBodyInputConfigType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfigTypeFileTypeType FileType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview.BodyInputConfigTypeFileTypeType.Review;

        [JsonProperty("naming")]
        public JToken NamingConvention { get; set; }

        [JsonProperty("complexity")]
        public string[] Complexity { get; set; }

        [JsonProperty("ratings")]
        public JToken ReviewRatings { get; set; }

        [JsonProperty("scoring")]
        public string[] Scoring { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputConfigTypeFileTypeType
    {
        [EnumMember(Value = "review")]
        Review,
        [EnumMember(Value = "report")]
        Report,
        [EnumMember(Value = "diagram")]
        Diagram,
        [EnumMember(Value = "exception")]
        Exception
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview;

    public partial class WorkflowManagedActions
    {
        public AutoreviewActions Autoreview(string connectionId) => new AutoreviewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AutoreviewTriggers Autoreview(string connectionId) => new AutoreviewTriggers(connectionId);
    }
}