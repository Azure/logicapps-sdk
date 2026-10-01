//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutoreviewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<GETInfoResponse> GETInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/autoreview/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GETInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IWorkflowAction POSTHttp([WorkflowExpression] Func<string> path = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/autoreview/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (path != null)
                    callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                var body = new JObject();
                var bodypropCount = 0;
                var configsObject = new JObject();
                var configsObjectpropCount = 0;
                if (configsObjectpropCount > 0)
                {
                    body["configs"] = configsObject;
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<POSTJsonResponse> POSTJson([WorkflowExpression] Func<string> bodyflowPropertiesdisplayName = null, [WorkflowExpression] Func<string> bodyflowPropertiesflowId = null, [WorkflowExpression] Func<string> bodyflowPropertiesowner = null, [WorkflowExpression] Func<string> bodyflowPropertiesenvironment = null, [WorkflowExpression] Func<string[]> bodyconfigscomplexity = null, [WorkflowExpression] Func<string[]> bodyconfigsscoring = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/autoreview/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodyflowPropertiesdisplayName != null)
                {
                    propertiesObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesdisplayName);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesflowId != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesflowId);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesowner != null)
                {
                    propertiesObject["owner"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesowner);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesenvironment != null)
                {
                    propertiesObject["environment"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesenvironment);
                    propertiesObjectpropCount++;
                }

                var definitionObject = new JObject();
                var definitionObjectpropCount = 0;
                if (definitionObjectpropCount > 0)
                {
                    propertiesObject["definition"] = definitionObject;
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                var configsObject = new JObject();
                var configsObjectpropCount = 0;
                var namingObject = new JObject();
                var namingObjectpropCount = 0;
                if (namingObjectpropCount > 0)
                {
                    configsObject["naming"] = namingObject;
                    configsObjectpropCount++;
                }

                if (bodyconfigscomplexity != null)
                {
                    configsObject["complexity"] = SourceExpressionConverter.ConvertToken(bodyconfigscomplexity);
                    configsObjectpropCount++;
                }

                var ratingsObject = new JObject();
                var ratingsObjectpropCount = 0;
                if (ratingsObjectpropCount > 0)
                {
                    configsObject["ratings"] = ratingsObject;
                    configsObjectpropCount++;
                }

                if (bodyconfigsscoring != null)
                {
                    configsObject["scoring"] = SourceExpressionConverter.ConvertToken(bodyconfigsscoring);
                    configsObjectpropCount++;
                }

                configsObject["type"] = "json";
                configsObjectpropCount++;
                if (configsObjectpropCount > 0)
                {
                    body["configs"] = configsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTJsonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<POSTDiagramResponse> POSTDiagram([WorkflowExpression] Func<string> bodypropertiesdisplayName = null, [WorkflowExpression] Func<string> bodypropertiesflowId = null, [WorkflowExpression] Func<string> bodypropertiesowner = null, [WorkflowExpression] Func<string> bodypropertiesenvironment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/autoreview/diagram";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesdisplayName != null)
                {
                    propertiesObject["displayName"] = SourceExpressionConverter.ConvertToken(bodypropertiesdisplayName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesflowId != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodypropertiesflowId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesowner != null)
                {
                    propertiesObject["owner"] = SourceExpressionConverter.ConvertToken(bodypropertiesowner);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesenvironment != null)
                {
                    propertiesObject["environment"] = SourceExpressionConverter.ConvertToken(bodypropertiesenvironment);
                    propertiesObjectpropCount++;
                }

                var definitionObject = new JObject();
                var definitionObjectpropCount = 0;
                if (definitionObjectpropCount > 0)
                {
                    propertiesObject["definition"] = definitionObject;
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                var configsObject = new JObject();
                var configsObjectpropCount = 0;
                configsObject["type"] = "SVG";
                configsObjectpropCount++;
                if (configsObjectpropCount > 0)
                {
                    body["configs"] = configsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTDiagramResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<POSTFileV2Response> POSTFile([WorkflowExpression] Func<string> bodyflowPropertiesdisplayName = null, [WorkflowExpression] Func<string> bodyflowPropertiesflowId = null, [WorkflowExpression] Func<string> bodyflowPropertiesowner = null, [WorkflowExpression] Func<string> bodyflowPropertiesenvironment = null, [WorkflowExpression] Func<bodyconfigfileTypeInput> bodyconfigfileType = null, [WorkflowExpression] Func<string[]> bodyconfigcomplexity = null, [WorkflowExpression] Func<string[]> bodyconfigscoring = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/autoreview/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodyflowPropertiesdisplayName != null)
                {
                    propertiesObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesdisplayName);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesflowId != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesflowId);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesowner != null)
                {
                    propertiesObject["owner"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesowner);
                    propertiesObjectpropCount++;
                }

                if (bodyflowPropertiesenvironment != null)
                {
                    propertiesObject["environment"] = SourceExpressionConverter.ConvertToken(bodyflowPropertiesenvironment);
                    propertiesObjectpropCount++;
                }

                var definitionObject = new JObject();
                var definitionObjectpropCount = 0;
                if (definitionObjectpropCount > 0)
                {
                    propertiesObject["definition"] = definitionObject;
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                var configsObject = new JObject();
                var configsObjectpropCount = 0;
                if (bodyconfigfileType != null)
                {
                    if (bodyconfigfileType != null)
                    {
                        configsObject["type"] = SourceExpressionConverter.Convert(bodyconfigfileType);
                        configsObjectpropCount++;
                    }

                    configsObjectpropCount++;
                }
                else
                {
                    configsObject["type"] = "review";
                    configsObjectpropCount++;
                }

                var namingObject = new JObject();
                var namingObjectpropCount = 0;
                if (namingObjectpropCount > 0)
                {
                    configsObject["naming"] = namingObject;
                    configsObjectpropCount++;
                }

                if (bodyconfigcomplexity != null)
                {
                    configsObject["complexity"] = SourceExpressionConverter.ConvertToken(bodyconfigcomplexity);
                    configsObjectpropCount++;
                }

                var ratingsObject = new JObject();
                var ratingsObjectpropCount = 0;
                if (ratingsObjectpropCount > 0)
                {
                    configsObject["ratings"] = ratingsObject;
                    configsObjectpropCount++;
                }

                if (bodyconfigscoring != null)
                {
                    configsObject["scoring"] = SourceExpressionConverter.ConvertToken(bodyconfigscoring);
                    configsObjectpropCount++;
                }

                if (configsObjectpropCount > 0)
                {
                    body["configs"] = configsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<POSTFileV2Response>(BuildSourceInput);
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

    public enum bodyconfigfileTypeInput
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