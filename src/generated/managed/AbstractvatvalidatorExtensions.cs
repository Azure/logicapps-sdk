//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractvatvalidator
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractvatvalidatorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<ValidateResponse, ApiConnectionActionConfiguration> Validate(Expression<Func<string>> vatNumber)
        {
            var __workflow_vatNumber = WorkflowExpression.Compile(vatNumber, nameof(vatNumber), required: true);
            return new DeferredBodyAction<ValidateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/validate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vat_number"] = ExpressionConverter.Convert(__workflow_vatNumber);
                return new ApiConnectionAction<ValidateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<CalculateResponse, ApiConnectionActionConfiguration> Calculate(Expression<Func<string>> amount, Expression<Func<string>> countryCode, Expression<Func<bool>> isVatIncl = null, Expression<Func<string>> vatCategory = null)
        {
            var __workflow_amount = WorkflowExpression.Compile(amount, nameof(amount), required: true);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            var __workflow_isVatIncl = WorkflowExpression.Compile(isVatIncl, nameof(isVatIncl), required: false);
            var __workflow_vatCategory = WorkflowExpression.Compile(vatCategory, nameof(vatCategory), required: false);
            return new DeferredBodyAction<CalculateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/calculate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["amount"] = ExpressionConverter.Convert(__workflow_amount);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_isVatIncl != null)
                    callPayload.Queries["is_vat_incl"] = ExpressionConverter.Convert(__workflow_isVatIncl);
                if (__workflow_vatCategory != null)
                    callPayload.Queries["vat_category"] = ExpressionConverter.Convert(__workflow_vatCategory);
                return new ApiConnectionAction<CalculateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<ListCategoriesResponseItem[], ApiConnectionActionConfiguration> ListCategories(Expression<Func<string>> countryCode)
        {
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: true);
            return new DeferredBodyAction<ListCategoriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
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
