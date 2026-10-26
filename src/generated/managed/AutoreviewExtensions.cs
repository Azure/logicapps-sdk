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
        public IBodyWorkflowAction<GETInfoResponse, ApiConnectionActionConfiguration> GETInfo()
        {
            return new DeferredBodyAction<GETInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IWorkflowAction<ApiConnectionActionConfiguration> POSTHttp(Expression<Func<string>> path = null, Expression<Func<POSTHttpInput>> body = null)
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
        public IBodyWorkflowAction<POSTJsonResponse, ApiConnectionActionConfiguration> POSTJson(Expression<Func<POSTJsonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<POSTJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<POSTDiagramResponse, ApiConnectionActionConfiguration> POSTDiagram(Expression<Func<POSTDiagramInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTDiagramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/diagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTDiagramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<POSTFileV2Response, ApiConnectionActionConfiguration> POSTFile(Expression<Func<POSTFileV2Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTFileV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/autoreview/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTFileV2Response>(callPayload);
            });
        }
    }

    public class AutoreviewTriggers([ConnectionName] string connectionId)
    {
    }

    public class GETInfoResponse
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

    public class POSTHttpInput
    {
        [JsonProperty("configs")]
        public JToken Config { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    public class POSTJsonResponse
    {
        [JsonProperty("data")]
        public POSTJsonResponseDataType Data { get; set; }
    }

    public class POSTJsonResponseDataType
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
        public POSTJsonResponseDataTypeVariableArrayTypeItem[] VariableArray { get; set; }

        [JsonProperty("actionArray")]
        public POSTJsonResponseDataTypeActionArrayTypeItem[] ActionArray { get; set; }

        [JsonProperty("apiActionArray")]
        public POSTJsonResponseDataTypeApiActionArrayTypeItem[] ApiActionArray { get; set; }

        [JsonProperty("exceptionArray")]
        public POSTJsonResponseDataTypeExceptionArrayTypeItem[] ExceptionArray { get; set; }

        [JsonProperty("connectionArray")]
        public POSTJsonResponseDataTypeConnectionArrayTypeItem[] ConnectionArray { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("actionObjectArray")]
        public POSTJsonResponseDataTypeActionObjectArrayTypeItem[] ActionObjectArray { get; set; }
    }

    public class POSTJsonResponseDataTypeVariableArrayTypeItem
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

    public class POSTJsonResponseDataTypeActionArrayTypeItem
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
        public string ImgURL { get; set; }

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

    public class POSTJsonResponseDataTypeApiActionArrayTypeItem
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
        public string ImgURL { get; set; }

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

    public class POSTJsonResponseDataTypeExceptionArrayTypeItem
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
        public string ImgURL { get; set; }

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

    public class POSTJsonResponseDataTypeConnectionArrayTypeItem
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

    public class POSTJsonResponseDataTypeActionObjectArrayTypeItem
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

    public class POSTJsonInput
    {
        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTJsonInputFlowPropertiesType FlowProperties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTJsonInputConfigsType Configs { get; set; }
    }

    public class POSTJsonInputFlowPropertiesType
    {
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

    public class POSTJsonInputConfigsType
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

    public class POSTDiagramResponse
    {
        [JsonProperty("data")]
        public POSTDiagramResponseDataType Data { get; set; }
    }

    public class POSTDiagramResponseDataType
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class POSTDiagramInput
    {
        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTDiagramInputPropertiesType Properties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTDiagramInputConfigType Config { get; set; }
    }

    public class POSTDiagramInputPropertiesType
    {
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

    public class POSTDiagramInputConfigType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal POSTDiagramInputConfigTypeImageTypeType ImageType { get; set; } = POSTDiagramInputConfigTypeImageTypeType.SVG;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum POSTDiagramInputConfigTypeImageTypeType
    {
        SVG,
        PNG
    }

    public class POSTFileV2Response
    {
        [JsonProperty("data")]
        public POSTFileV2ResponseDataType Data { get; set; }
    }

    public class POSTFileV2ResponseDataType
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class POSTFileV2Input
    {
        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTFileV2InputFlowPropertiesType FlowProperties { get; set; }

        [JsonProperty("configs", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTFileV2InputConfigType Config { get; set; }
    }

    public class POSTFileV2InputFlowPropertiesType
    {
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

    public class POSTFileV2InputConfigType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public POSTFileV2InputConfigTypeFileTypeType FileType { get; set; } = POSTFileV2InputConfigTypeFileTypeType.Review;

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
    public enum POSTFileV2InputConfigTypeFileTypeType
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