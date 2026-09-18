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
        public IBodyWorkflowAction<ExchangeData> GetExchanges([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/exchange/v1/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<URLExchangeData> GetExchangesUsinglink([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/exchange/fake/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<URLExchangeData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesigns([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/design/v1/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<AECData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<AECData> GetAECDesignsUsinglink([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/design/v2/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<AECData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesCodeBehind([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<getlatestInput> getlatest, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(getlatest, nameof(getlatest), required: true);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: true);
            SourceExpression.Validate(filterValue, nameof(filterValue), required: false);
            SourceExpression.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            SourceExpression.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            SourceExpression.Validate(selectedUnit, nameof(selectedUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["getlatest"] = SourceExpressionConverter.Convert(getlatest);
                callPayload.Queries["filterBy"] = SourceExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = SourceExpressionConverter.ConvertO(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = SourceExpressionConverter.ConvertO(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = SourceExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = SourceExpressionConverter.ConvertO(selectedUnit);
                return callPayload;
            }

            return new ApiConnectionAction<GraphQLParametersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesUsingLink([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: true);
            SourceExpression.Validate(filterValue, nameof(filterValue), required: false);
            SourceExpression.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            SourceExpression.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            SourceExpression.Validate(selectedUnit, nameof(selectedUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/url/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["filterBy"] = SourceExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = SourceExpressionConverter.ConvertO(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = SourceExpressionConverter.ConvertO(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = SourceExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = SourceExpressionConverter.ConvertO(selectedUnit);
                return callPayload;
            }

            return new ApiConnectionAction<GraphQLParametersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesCodeBehindAEC([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: true);
            SourceExpression.Validate(filterValue, nameof(filterValue), required: false);
            SourceExpression.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            SourceExpression.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            SourceExpression.Validate(selectedUnit, nameof(selectedUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["filterBy"] = SourceExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = SourceExpressionConverter.ConvertO(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = SourceExpressionConverter.ConvertO(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = SourceExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = SourceExpressionConverter.ConvertO(selectedUnit);
                return callPayload;
            }

            return new ApiConnectionAction<GraphQLParametersResponseAEC>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesAECUsingLink([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: true);
            SourceExpression.Validate(filterValue, nameof(filterValue), required: false);
            SourceExpression.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            SourceExpression.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            SourceExpression.Validate(selectedUnit, nameof(selectedUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/URL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                callPayload.Queries["filterBy"] = SourceExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = SourceExpressionConverter.ConvertO(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = SourceExpressionConverter.ConvertO(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = SourceExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = SourceExpressionConverter.ConvertO(selectedUnit);
                return callPayload;
            }

            return new ApiConnectionAction<GraphQLParametersResponseAEC>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetAECpropertyDefinitionsUsingLink([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/url/GetAECProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<PropertyDefinitionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetDXpropertyDefinitionsUsingLink([WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fakeGraphQL/url/GetDXProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                return callPayload;
            }

            return new ApiConnectionAction<PropertyDefinitionsResponse>(BuildSourceInput);
        }
    }

    public class AutodeskforgedataexcTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RegisterWebhookExchangeModified([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> hubId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(hubId, nameof(hubId), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["hubId"] = SourceExpressionConverter.ConvertO(hubId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger RegisterWebhookExchangeAdded([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> hubId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(region, nameof(region), required: true);
            SourceExpression.Validate(hubId, nameof(hubId), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/webhookModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = SourceExpressionConverter.Convert(region);
                callPayload.Queries["hubId"] = SourceExpressionConverter.ConvertO(hubId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger RegisterWebhookExchangeModifiedUrl([WorkflowExpression] Func<string> fileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/webhookModifiedByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = SourceExpressionConverter.ConvertO(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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