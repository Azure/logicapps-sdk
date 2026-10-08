//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractvatvalidator
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractvatvalidatorActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        [WorkflowExpressionFactory(nameof(__BuildValidate))]
        public IBodyWorkflowAction<ValidateResponse> Validate([WorkflowExpression] Func<string> vatNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateResponse> __BuildValidate(WorkflowExpression<string> vatNumber)
        {
            WorkflowExpression.Validate(vatNumber, nameof(vatNumber), required: true);
            return new DeferredBodyAction<ValidateResponse>(() =>
            {
                var apiCallPath = "/v1/validate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vat_number"] = ExpressionConverter.Convert(vatNumber);
                return new ApiConnectionAction<ValidateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        [WorkflowExpressionFactory(nameof(__BuildCalculate))]
        public IBodyWorkflowAction<CalculateResponse> Calculate([WorkflowExpression] Func<string> amount, [WorkflowExpression] Func<string> countryCode, [WorkflowExpression] Func<bool> isVatIncl = null, [WorkflowExpression] Func<string> vatCategory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateResponse> __BuildCalculate(WorkflowExpression<string> amount, WorkflowExpression<string> countryCode, WorkflowExpression<bool> isVatIncl = null, WorkflowExpression<string> vatCategory = null)
        {
            WorkflowExpression.Validate(amount, nameof(amount), required: true);
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            WorkflowExpression.Validate(isVatIncl, nameof(isVatIncl), required: false);
            WorkflowExpression.Validate(vatCategory, nameof(vatCategory), required: false);
            return new DeferredBodyAction<CalculateResponse>(() =>
            {
                var apiCallPath = "/v1/calculate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["amount"] = ExpressionConverter.Convert(amount);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                if (isVatIncl != null)
                    callPayload.Queries["is_vat_incl"] = ExpressionConverter.Convert(isVatIncl);
                if (vatCategory != null)
                    callPayload.Queries["vat_category"] = ExpressionConverter.Convert(vatCategory);
                return new ApiConnectionAction<CalculateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        [WorkflowExpressionFactory(nameof(__BuildListCategories))]
        public IBodyWorkflowAction<ListCategoriesResponseItem[]> ListCategories([WorkflowExpression] Func<string> countryCode)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCategoriesResponseItem[]> __BuildListCategories(WorkflowExpression<string> countryCode)
        {
            WorkflowExpression.Validate(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<ListCategoriesResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
                return new ApiConnectionAction<ListCategoriesResponseItem[]>(callPayload);
            });
        }
    }

    public class AbstractvatvalidatorTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateResponse
    {
        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("company")]
        public ValidateResponseCompanyType Company { get; set; }

        [JsonProperty("country")]
        public ValidateResponseCountryType Country { get; set; }
    }

    public class ValidateResponseCompanyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class ValidateResponseCountryType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CalculateResponse
    {
        [JsonProperty("amount_excluding_vat")]
        public double AmountExcludingVat { get; set; }

        [JsonProperty("amount_including_vat")]
        public double AmountIncludingVat { get; set; }

        [JsonProperty("vat_amount")]
        public double VatAmount { get; set; }

        [JsonProperty("vat_category")]
        public string VatCategory { get; set; }

        [JsonProperty("vat_rate")]
        public double VatRate { get; set; }

        [JsonProperty("country")]
        public CalculateResponseCountryType Country { get; set; }
    }

    public class CalculateResponseCountryType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListCategoriesResponseItem
    {
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("rate")]
        public string Rate { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractvatvalidator;

    public partial class WorkflowManagedActions
    {
        public AbstractvatvalidatorActions Abstractvatvalidator(string connectionId) => new AbstractvatvalidatorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractvatvalidatorTriggers Abstractvatvalidator(string connectionId) => new AbstractvatvalidatorTriggers(connectionId);
    }
}