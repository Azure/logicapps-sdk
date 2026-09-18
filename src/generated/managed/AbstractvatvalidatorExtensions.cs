//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractvatvalidator
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractvatvalidatorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<ValidateResponse> Validate([WorkflowExpression] Func<string> vatNumber)
        {
            SourceExpression.Validate(vatNumber, nameof(vatNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/validate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["vat_number"] = SourceExpressionConverter.ConvertO(vatNumber);
                return callPayload;
            }

            return new ApiConnectionAction<ValidateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<CalculateResponse> Calculate([WorkflowExpression] Func<string> amount, [WorkflowExpression] Func<string> countryCode, [WorkflowExpression] Func<bool> isVatIncl = null, [WorkflowExpression] Func<string> vatCategory = null)
        {
            SourceExpression.Validate(amount, nameof(amount), required: true);
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            SourceExpression.Validate(isVatIncl, nameof(isVatIncl), required: false);
            SourceExpression.Validate(vatCategory, nameof(vatCategory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/calculate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["amount"] = SourceExpressionConverter.ConvertO(amount);
                callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                if (isVatIncl != null)
                    callPayload.Queries["is_vat_incl"] = SourceExpressionConverter.ConvertO(isVatIncl);
                if (vatCategory != null)
                    callPayload.Queries["vat_category"] = SourceExpressionConverter.ConvertO(vatCategory);
                return callPayload;
            }

            return new ApiConnectionAction<CalculateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractvatvalidator")]
        public IBodyWorkflowAction<ListCategoriesResponseItem[]> ListCategories([WorkflowExpression] Func<string> countryCode)
        {
            SourceExpression.Validate(countryCode, nameof(countryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                return callPayload;
            }

            return new ApiConnectionAction<ListCategoriesResponseItem[]>(BuildSourceInput);
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