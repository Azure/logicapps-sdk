//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autodeskforgedataexc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutodeskforgedataexcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<ExchangeData> GetExchanges(Expression<Func<regionInput>> region, Expression<Func<string>> fileId)
        {
            var apiCallPath = "/exchange/v1/exchanges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<ExchangeData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<URLExchangeData> GetExchangesUsinglink(Expression<Func<string>> fileId)
        {
            var apiCallPath = "/exchange/fake/exchanges";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<URLExchangeData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesigns(Expression<Func<regionInput>> region, Expression<Func<string>> fileId)
        {
            var apiCallPath = "/design/v1/designs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<AECData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesignsUsinglink(Expression<Func<string>> fileId)
        {
            var apiCallPath = "/design/v2/designs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<AECData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesCodeBehind(Expression<Func<regionInput>> region, Expression<Func<string>> fileId, Expression<Func<getlatestInput>> getlatest, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var apiCallPath = "/fakeGraphQL/GetFilteredParameters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            callPayload.Queries["getlatest"] = CSharpExpressionConverter.Convert(getlatest);
            callPayload.Queries["filterBy"] = CSharpExpressionConverter.Convert(filterBy);
            if (filterValue != null)
                callPayload.Queries["filterValue"] = CSharpExpressionConverter.ConvertO(filterValue);
            if (parameterfilterValue != null)
                callPayload.Queries["ParameterfilterValue"] = CSharpExpressionConverter.ConvertO(parameterfilterValue);
            callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
            if (selectedUnitType != null)
                callPayload.Queries["selectedUnitType"] = CSharpExpressionConverter.Convert(selectedUnitType);
            if (selectedUnit != null)
                callPayload.Queries["selectedUnit"] = CSharpExpressionConverter.ConvertO(selectedUnit);
            return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesUsingLink(Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var apiCallPath = "/fakeGraphQL/url/GetFilteredParameters";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            callPayload.Queries["filterBy"] = CSharpExpressionConverter.Convert(filterBy);
            if (filterValue != null)
                callPayload.Queries["filterValue"] = CSharpExpressionConverter.ConvertO(filterValue);
            if (parameterfilterValue != null)
                callPayload.Queries["ParameterfilterValue"] = CSharpExpressionConverter.ConvertO(parameterfilterValue);
            callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
            if (selectedUnitType != null)
                callPayload.Queries["selectedUnitType"] = CSharpExpressionConverter.Convert(selectedUnitType);
            if (selectedUnit != null)
                callPayload.Queries["selectedUnit"] = CSharpExpressionConverter.ConvertO(selectedUnit);
            return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesCodeBehindAEC(Expression<Func<regionInput>> region, Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var apiCallPath = "/fakeGraphQL/GetFilteredParametersAEC";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            callPayload.Queries["filterBy"] = CSharpExpressionConverter.Convert(filterBy);
            if (filterValue != null)
                callPayload.Queries["filterValue"] = CSharpExpressionConverter.ConvertO(filterValue);
            if (parameterfilterValue != null)
                callPayload.Queries["ParameterfilterValue"] = CSharpExpressionConverter.ConvertO(parameterfilterValue);
            callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
            if (selectedUnitType != null)
                callPayload.Queries["selectedUnitType"] = CSharpExpressionConverter.Convert(selectedUnitType);
            if (selectedUnit != null)
                callPayload.Queries["selectedUnit"] = CSharpExpressionConverter.ConvertO(selectedUnit);
            return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesAECUsingLink(Expression<Func<string>> fileId, Expression<Func<filterByInput>> filterBy, Expression<Func<string>> filterValue = null, Expression<Func<string>> parameterfilterValue = null, Expression<Func<selectedUnitTypeInput>> selectedUnitType = null, Expression<Func<string>> selectedUnit = null)
        {
            var apiCallPath = "/fakeGraphQL/URL/GetFilteredParametersAEC";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            callPayload.Queries["filterBy"] = CSharpExpressionConverter.Convert(filterBy);
            if (filterValue != null)
                callPayload.Queries["filterValue"] = CSharpExpressionConverter.ConvertO(filterValue);
            if (parameterfilterValue != null)
                callPayload.Queries["ParameterfilterValue"] = CSharpExpressionConverter.ConvertO(parameterfilterValue);
            callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
            if (selectedUnitType != null)
                callPayload.Queries["selectedUnitType"] = CSharpExpressionConverter.Convert(selectedUnitType);
            if (selectedUnit != null)
                callPayload.Queries["selectedUnit"] = CSharpExpressionConverter.ConvertO(selectedUnit);
            return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetAECpropertyDefinitionsUsingLink(Expression<Func<string>> fileId)
        {
            var apiCallPath = "/fakeGraphQL/url/GetAECProperties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetDXpropertyDefinitionsUsingLink(Expression<Func<string>> fileId)
        {
            var apiCallPath = "/fakeGraphQL/url/GetDXProperties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
        }
    }

    public class AutodeskforgedataexcTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RegisterWebhookExchangeModified(Expression<Func<regionInput>> region, Expression<Func<string>> hubId, Expression<Func<string>> projectId, Expression<Func<string>> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/connector/webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["hubId"] = CSharpExpressionConverter.ConvertO(hubId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RegisterWebhookExchangeAdded(Expression<Func<regionInput>> region, Expression<Func<string>> hubId, Expression<Func<string>> projectId, Expression<Func<string>> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/connector/webhookModified";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["region"] = CSharpExpressionConverter.Convert(region);
            callPayload.Queries["hubId"] = CSharpExpressionConverter.ConvertO(hubId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger RegisterWebhookExchangeModifiedUrl(Expression<Func<string>> fileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/connector/webhookModifiedByUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileId"] = CSharpExpressionConverter.ConvertO(fileId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum getlatestInput
    {
        [EnumMember(Value = "all")]
        AllProperties,
        [EnumMember(Value = "latest")]
        LatestProperties
    }

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