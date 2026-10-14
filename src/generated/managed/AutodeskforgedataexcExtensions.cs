//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autodeskforgedataexc
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AutodeskforgedataexcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<ExchangeData> GetExchanges(Expression<Func<regionInput>> region, Expression<Func<string>> fileId)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<ExchangeData>(() =>
            {
                var apiCallPath = "/exchange/v1/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<ExchangeData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<URLExchangeData> GetExchangesUsinglink(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<URLExchangeData>(() =>
            {
                var apiCallPath = "/exchange/fake/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<URLExchangeData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesigns(Expression<Func<regionInput>> region, Expression<Func<string>> fileId)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<AECData>(() =>
            {
                var apiCallPath = "/design/v1/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<AECData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesignsUsinglink(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<AECData>(() =>
            {
                var apiCallPath = "/design/v2/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<AECData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesCodeBehind(Expression<Func<regionInput>> region, Expression<Func<string>> fileId, Expression<Func<getlatestInput>> getlatest, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_getlatest = getlatest == null ? null : WorkflowExpression.Compile(getlatest);
            WorkflowExpression.Validate(__workflow_getlatest, nameof(getlatest), required: true);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: true);
            var __workflow_filterValue = filterValue == null ? null : WorkflowExpression.Compile(filterValue);
            WorkflowExpression.Validate(__workflow_filterValue, nameof(filterValue), required: false);
            var __workflow_parameterfilterValue = parameterfilterValue == null ? null : WorkflowExpression.Compile(parameterfilterValue);
            WorkflowExpression.Validate(__workflow_parameterfilterValue, nameof(parameterfilterValue), required: false);
            var __workflow_selectedUnitType = selectedUnitType == null ? null : WorkflowExpression.Compile(selectedUnitType);
            WorkflowExpression.Validate(__workflow_selectedUnitType, nameof(selectedUnitType), required: false);
            var __workflow_selectedUnit = selectedUnit == null ? null : WorkflowExpression.Compile(selectedUnit);
            WorkflowExpression.Validate(__workflow_selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["getlatest"] = ExpressionConverter.Convert(__workflow_getlatest);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                if (__workflow_parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(__workflow_parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (__workflow_selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(__workflow_selectedUnitType);
                if (__workflow_selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(__workflow_selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesUsingLink(Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: true);
            var __workflow_filterValue = filterValue == null ? null : WorkflowExpression.Compile(filterValue);
            WorkflowExpression.Validate(__workflow_filterValue, nameof(filterValue), required: false);
            var __workflow_parameterfilterValue = parameterfilterValue == null ? null : WorkflowExpression.Compile(parameterfilterValue);
            WorkflowExpression.Validate(__workflow_parameterfilterValue, nameof(parameterfilterValue), required: false);
            var __workflow_selectedUnitType = selectedUnitType == null ? null : WorkflowExpression.Compile(selectedUnitType);
            WorkflowExpression.Validate(__workflow_selectedUnitType, nameof(selectedUnitType), required: false);
            var __workflow_selectedUnit = selectedUnit == null ? null : WorkflowExpression.Compile(selectedUnit);
            WorkflowExpression.Validate(__workflow_selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                if (__workflow_parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(__workflow_parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (__workflow_selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(__workflow_selectedUnitType);
                if (__workflow_selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(__workflow_selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesCodeBehindAEC(Expression<Func<regionInput>> region, Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: true);
            var __workflow_filterValue = filterValue == null ? null : WorkflowExpression.Compile(filterValue);
            WorkflowExpression.Validate(__workflow_filterValue, nameof(filterValue), required: false);
            var __workflow_parameterfilterValue = parameterfilterValue == null ? null : WorkflowExpression.Compile(parameterfilterValue);
            WorkflowExpression.Validate(__workflow_parameterfilterValue, nameof(parameterfilterValue), required: false);
            var __workflow_selectedUnitType = selectedUnitType == null ? null : WorkflowExpression.Compile(selectedUnitType);
            WorkflowExpression.Validate(__workflow_selectedUnitType, nameof(selectedUnitType), required: false);
            var __workflow_selectedUnit = selectedUnit == null ? null : WorkflowExpression.Compile(selectedUnit);
            WorkflowExpression.Validate(__workflow_selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponseAEC>(() =>
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                if (__workflow_parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(__workflow_parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (__workflow_selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(__workflow_selectedUnitType);
                if (__workflow_selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(__workflow_selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesAECUsingLink(Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: true);
            var __workflow_filterValue = filterValue == null ? null : WorkflowExpression.Compile(filterValue);
            WorkflowExpression.Validate(__workflow_filterValue, nameof(filterValue), required: false);
            var __workflow_parameterfilterValue = parameterfilterValue == null ? null : WorkflowExpression.Compile(parameterfilterValue);
            WorkflowExpression.Validate(__workflow_parameterfilterValue, nameof(parameterfilterValue), required: false);
            var __workflow_selectedUnitType = selectedUnitType == null ? null : WorkflowExpression.Compile(selectedUnitType);
            WorkflowExpression.Validate(__workflow_selectedUnitType, nameof(selectedUnitType), required: false);
            var __workflow_selectedUnit = selectedUnit == null ? null : WorkflowExpression.Compile(selectedUnit);
            WorkflowExpression.Validate(__workflow_selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponseAEC>(() =>
            {
                var apiCallPath = "/fakeGraphQL/URL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(__workflow_filterValue);
                if (__workflow_parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(__workflow_parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (__workflow_selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(__workflow_selectedUnitType);
                if (__workflow_selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(__workflow_selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetAECpropertyDefinitionsUsingLink(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<PropertyDefinitionsResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetAECProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetDXpropertyDefinitionsUsingLink(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<PropertyDefinitionsResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetDXProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
            });
        }
    }

    public class AutodeskforgedataexcTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RegisterWebhookExchangeModified(Expression<Func<regionInput>> region, Expression<Func<string>> hubId, Expression<Func<string>> projectId, Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_hubId = hubId == null ? null : WorkflowExpression.Compile(hubId);
            WorkflowExpression.Validate(__workflow_hubId, nameof(hubId), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["hubId"] = ExpressionConverter.Convert(__workflow_hubId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger RegisterWebhookExchangeAdded(Expression<Func<regionInput>> region, Expression<Func<string>> hubId, Expression<Func<string>> projectId, Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_region = region == null ? null : WorkflowExpression.Compile(region);
            WorkflowExpression.Validate(__workflow_region, nameof(region), required: true);
            var __workflow_hubId = hubId == null ? null : WorkflowExpression.Compile(hubId);
            WorkflowExpression.Validate(__workflow_hubId, nameof(hubId), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhookModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                callPayload.Queries["hubId"] = ExpressionConverter.Convert(__workflow_hubId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger RegisterWebhookExchangeModifiedUrl(Expression<Func<string>> fileId, FlowRecurrence recurrence = null)
        {
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhookModifiedByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(__workflow_fileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ExchangeData
    {
        [JsonProperty("hubName")]
        public string HubName { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("folderName")]
        public string FolderName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("exchangeFileName")]
        public string ExchangeFileName { get; set; }

        [JsonProperty("exchangeFileUrn")]
        public string ExchangeFileUrn { get; set; }

        [JsonProperty("exchangeFileVersionUrn")]
        public string ExchangeFileVersionUrn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum regionInput
    {
        US,
        EMEA,
        AUS
    }

    public class URLExchangeData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("exchangeFileName")]
        public string ExchangeFileName { get; set; }

        [JsonProperty("exchangeFileUrn")]
        public string ExchangeFileUrn { get; set; }

        [JsonProperty("exchangeFileVersionUrn")]
        public string ExchangeFileVersionUrn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class AECData
    {
        [JsonProperty("hubName")]
        public string HubName { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("folderName")]
        public string FolderName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("aecdmFileName")]
        public string AecdmFileName { get; set; }

        [JsonProperty("aecdmFileUrn")]
        public string AecdmFileUrn { get; set; }

        [JsonProperty("aecdmFileVersionUrn")]
        public string AecdmFileVersionUrn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class GraphQLParametersResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum getlatestInput
    {
        [EnumMember(Value = "all")]
        AllProperties,
        [EnumMember(Value = "latest")]
        LatestProperties
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterByInput
    {
        [EnumMember(Value = "category")]
        Category,
        [EnumMember(Value = "family")]
        Family,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "NA")]
        NoFilter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum selectedUnitTypeInput
    {
        [EnumMember(Value = "imperial")]
        Imperial,
        [EnumMember(Value = "metric")]
        Metric
    }

    public class GraphQLParametersResponseAEC
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class PropertyDefinitionsResponse
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Autodeskforgedataexc;

    public partial class WorkflowManagedActions
    {
        public AutodeskforgedataexcActions Autodeskforgedataexc(string connectionId) => new AutodeskforgedataexcActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AutodeskforgedataexcTriggers Autodeskforgedataexc(string connectionId) => new AutodeskforgedataexcTriggers(connectionId);
    }
}
