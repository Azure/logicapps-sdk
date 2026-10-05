//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autodeskforgedataexc
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutodeskforgedataexcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchanges))]
        public IBodyWorkflowAction<ExchangeData> GetExchanges([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExchangeData> __BuildGetExchanges(WorkflowValue<regionInput> region, WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<ExchangeData>(() =>
            {
                var apiCallPath = "/exchange/v1/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<ExchangeData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetExchangesUsinglink))]
        public IBodyWorkflowAction<URLExchangeData> GetExchangesUsinglink([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<URLExchangeData> __BuildGetExchangesUsinglink(WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<URLExchangeData>(() =>
            {
                var apiCallPath = "/exchange/fake/exchanges";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<URLExchangeData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetAECDesigns))]
        public IBodyWorkflowAction<AECData> GetAECDesigns([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AECData> __BuildGetAECDesigns(WorkflowValue<regionInput> region, WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<AECData>(() =>
            {
                var apiCallPath = "/design/v1/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<AECData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetAECDesignsUsinglink))]
        public IBodyWorkflowAction<AECData> GetAECDesignsUsinglink([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AECData> __BuildGetAECDesignsUsinglink(WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<AECData>(() =>
            {
                var apiCallPath = "/design/v2/designs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<AECData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilteredPropertiesCodeBehind))]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesCodeBehind([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<getlatestInput> getlatest, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphQLParametersResponse> __BuildGetFilteredPropertiesCodeBehind(WorkflowValue<regionInput> region, WorkflowValue<string> fileId, WorkflowValue<getlatestInput> getlatest, WorkflowValue<filterByInput> filterBy, WorkflowValue<string> filterValue = null, WorkflowValue<string> parameterfilterValue = null, WorkflowValue<selectedUnitTypeInput> selectedUnitType = null, WorkflowValue<string> selectedUnit = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(getlatest, nameof(getlatest), required: true);
            WorkflowValue.Validate(filterBy, nameof(filterBy), required: true);
            WorkflowValue.Validate(filterValue, nameof(filterValue), required: false);
            WorkflowValue.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            WorkflowValue.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            WorkflowValue.Validate(selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                callPayload.Queries["getlatest"] = ExpressionConverter.Convert(getlatest);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilteredPropertiesUsingLink))]
        public IBodyWorkflowAction<GraphQLParametersResponse> GetFilteredPropertiesUsingLink([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphQLParametersResponse> __BuildGetFilteredPropertiesUsingLink(WorkflowValue<string> fileId, WorkflowValue<filterByInput> filterBy, WorkflowValue<string> filterValue = null, WorkflowValue<string> parameterfilterValue = null, WorkflowValue<selectedUnitTypeInput> selectedUnitType = null, WorkflowValue<string> selectedUnit = null)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(filterBy, nameof(filterBy), required: true);
            WorkflowValue.Validate(filterValue, nameof(filterValue), required: false);
            WorkflowValue.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            WorkflowValue.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            WorkflowValue.Validate(selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetFilteredParameters";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilteredPropertiesCodeBehindAEC))]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesCodeBehindAEC([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> __BuildGetFilteredPropertiesCodeBehindAEC(WorkflowValue<regionInput> region, WorkflowValue<string> fileId, WorkflowValue<filterByInput> filterBy, WorkflowValue<string> filterValue = null, WorkflowValue<string> parameterfilterValue = null, WorkflowValue<selectedUnitTypeInput> selectedUnitType = null, WorkflowValue<string> selectedUnit = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(filterBy, nameof(filterBy), required: true);
            WorkflowValue.Validate(filterValue, nameof(filterValue), required: false);
            WorkflowValue.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            WorkflowValue.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            WorkflowValue.Validate(selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponseAEC>(() =>
            {
                var apiCallPath = "/fakeGraphQL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilteredPropertiesAECUsingLink))]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> GetFilteredPropertiesAECUsingLink([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<filterByInput> filterBy, [WorkflowExpression] Func<string> filterValue = null, [WorkflowExpression] Func<string> parameterfilterValue = null, [WorkflowExpression] Func<selectedUnitTypeInput> selectedUnitType = null, [WorkflowExpression] Func<string> selectedUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GraphQLParametersResponseAEC> __BuildGetFilteredPropertiesAECUsingLink(WorkflowValue<string> fileId, WorkflowValue<filterByInput> filterBy, WorkflowValue<string> filterValue = null, WorkflowValue<string> parameterfilterValue = null, WorkflowValue<selectedUnitTypeInput> selectedUnitType = null, WorkflowValue<string> selectedUnit = null)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(filterBy, nameof(filterBy), required: true);
            WorkflowValue.Validate(filterValue, nameof(filterValue), required: false);
            WorkflowValue.Validate(parameterfilterValue, nameof(parameterfilterValue), required: false);
            WorkflowValue.Validate(selectedUnitType, nameof(selectedUnitType), required: false);
            WorkflowValue.Validate(selectedUnit, nameof(selectedUnit), required: false);
            return new DeferredBodyAction<GraphQLParametersResponseAEC>(() =>
            {
                var apiCallPath = "/fakeGraphQL/URL/GetFilteredParametersAEC";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                callPayload.Queries["filterBy"] = ExpressionConverter.Convert(filterBy);
                if (filterValue != null)
                    callPayload.Queries["filterValue"] = ExpressionConverter.Convert(filterValue);
                if (parameterfilterValue != null)
                    callPayload.Queries["ParameterfilterValue"] = ExpressionConverter.Convert(parameterfilterValue);
                callPayload.Queries["selectedUnitType"] = Convert.ToString("imperial");
                if (selectedUnitType != null)
                    callPayload.Queries["selectedUnitType"] = ExpressionConverter.Convert(selectedUnitType);
                if (selectedUnit != null)
                    callPayload.Queries["selectedUnit"] = ExpressionConverter.Convert(selectedUnit);
                return new ApiConnectionAction<GraphQLParametersResponseAEC>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetAECpropertyDefinitionsUsingLink))]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetAECpropertyDefinitionsUsingLink([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> __BuildGetAECpropertyDefinitionsUsingLink(WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<PropertyDefinitionsResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetAECProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autodeskforgedataexc")]
        [WorkflowExpressionFactory(nameof(__BuildGetDXpropertyDefinitionsUsingLink))]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> GetDXpropertyDefinitionsUsingLink([WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyDefinitionsResponse> __BuildGetDXpropertyDefinitionsUsingLink(WorkflowValue<string> fileId)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<PropertyDefinitionsResponse>(() =>
            {
                var apiCallPath = "/fakeGraphQL/url/GetDXProperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                return new ApiConnectionAction<PropertyDefinitionsResponse>(callPayload);
            });
        }
    }

    public class AutodeskforgedataexcTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildRegisterWebhookExchangeModified))]
        public IWorkflowTrigger RegisterWebhookExchangeModified([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> hubId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildRegisterWebhookExchangeModified(WorkflowValue<regionInput> region, WorkflowValue<string> hubId, WorkflowValue<string> projectId, WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(hubId, nameof(hubId), required: true);
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["hubId"] = ExpressionConverter.Convert(hubId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildRegisterWebhookExchangeAdded))]
        public IWorkflowTrigger RegisterWebhookExchangeAdded([WorkflowExpression] Func<regionInput> region, [WorkflowExpression] Func<string> hubId, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildRegisterWebhookExchangeAdded(WorkflowValue<regionInput> region, WorkflowValue<string> hubId, WorkflowValue<string> projectId, WorkflowValue<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(region, nameof(region), required: true);
            WorkflowValue.Validate(hubId, nameof(hubId), required: true);
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhookModified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                callPayload.Queries["hubId"] = ExpressionConverter.Convert(hubId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildRegisterWebhookExchangeModifiedUrl))]
        public IWorkflowTrigger RegisterWebhookExchangeModifiedUrl([WorkflowExpression] Func<string> fileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildRegisterWebhookExchangeModifiedUrl(WorkflowValue<string> fileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/connector/webhookModifiedByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileId"] = ExpressionConverter.Convert(fileId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
