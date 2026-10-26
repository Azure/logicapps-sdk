//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloverlyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloverlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<DirectCarbonResponse, ApiConnectionActionConfiguration> DirectCarbon(Expression<Func<transactionInput>> transaction, Expression<Func<DirectCarbonInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DirectCarbonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/carbon", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DirectCarbonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<DirectTransactionResponse, ApiConnectionActionConfiguration> DirectTransaction(Expression<Func<transactionInput>> transaction, Expression<Func<DirectTransactionInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DirectTransactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/currency", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DirectTransactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculatePackageResponse, ApiConnectionActionConfiguration> CalculatePackage(Expression<Func<string>> transaction, Expression<Func<CalculatePackageInput>> body = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CalculatePackageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/shipping", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculatePackageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateMCCResponse, ApiConnectionActionConfiguration> CalculateMCC(Expression<Func<string>> transaction, Expression<Func<CalculateMCCInput>> body = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CalculateMCCResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/mcc", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateMCCResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFreightResponse, ApiConnectionActionConfiguration> CalculateFreight(Expression<Func<string>> transaction, Expression<Func<CalculateFreightInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CalculateFreightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/freight", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateFreightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFlightResponse, ApiConnectionActionConfiguration> CalculateFlight(Expression<Func<transactionInput>> transaction, Expression<Func<CalculateFlightInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CalculateFlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/flight", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateVehicleResponse, ApiConnectionActionConfiguration> CalculateVehicle(Expression<Func<transactionInput>> transaction, Expression<Func<CalculateVehicleInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CalculateVehicleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/vehicle", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateVehicleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateElectricityResponse, ApiConnectionActionConfiguration> CalculateElectricity(Expression<Func<transactionInput>> transaction, Expression<Func<CalculateElectricityInput>> body)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CalculateElectricityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/electricity", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateElectricityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectDetailsResponse, ApiConnectionActionConfiguration> ProjectDetails(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/project/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<PortfolioDetailsResponse, ApiConnectionActionConfiguration> PortfolioDetails(Expression<Func<string>> portfolioId)
        {
            var __workflow_portfolioId = WorkflowExpression.Compile(portfolioId, nameof(portfolioId), required: true);
            return new DeferredBodyAction<PortfolioDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portfolio/{0}", __workflow_portfolioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PortfolioDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectTypesResponseItem[], ApiConnectionActionConfiguration> ProjectTypes()
        {
            return new DeferredBodyAction<ProjectTypesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/project-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectTypesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<AccountResponse, ApiConnectionActionConfiguration> Account()
        {
            return new DeferredBodyAction<AccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ConvertEstimateResponse, ApiConnectionActionConfiguration> ConvertEstimate(Expression<Func<ConvertEstimateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConvertEstimateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConvertEstimateResponse>(callPayload);
            });
        }
    }

    public class CloverlyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DirectCarbonResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public DirectCarbonResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public DirectCarbonResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class DirectCarbonResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public DirectCarbonResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public DirectCarbonResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class DirectCarbonResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class DirectCarbonResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class DirectCarbonResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum transactionInput
    {
        [EnumMember(Value = "estimates")]
        Estimates,
        [EnumMember(Value = "purchases")]
        Purchases
    }

    public class DirectCarbonInput
    {
        [JsonProperty("weight", DefaultValueHandling = DefaultValueHandling.Include)]
        public DirectCarbonInputWeightType Weight { get; set; }

        [JsonProperty("project_match")]
        public DirectCarbonInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class DirectCarbonInputWeightType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public DirectCarbonInputWeightTypeUnitsType Units { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DirectCarbonInputWeightTypeUnitsType
    {
        [EnumMember(Value = "kg")]
        Kg,
        [EnumMember(Value = "lbs")]
        Lbs,
        [EnumMember(Value = "grams")]
        Grams,
        [EnumMember(Value = "ounces")]
        Ounces,
        [EnumMember(Value = "tons")]
        Tons
    }

    public class DirectCarbonInputProjectMatchType
    {
        [JsonProperty("location")]
        public DirectCarbonInputProjectMatchTypeLocationType Location { get; set; }
    }

    public class DirectCarbonInputProjectMatchTypeLocationType
    {
        [JsonProperty("latlng")]
        public string[] Latlng { get; set; }
    }

    public class DirectTransactionResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public DirectTransactionResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public DirectTransactionResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class DirectTransactionResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public DirectTransactionResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public DirectTransactionResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class DirectTransactionResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class DirectTransactionResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class DirectTransactionResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class DirectTransactionInput
    {
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        public DirectTransactionInputCurrencyType Currency { get; set; }

        [JsonProperty("project_match")]
        public DirectTransactionInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("unit_cost_usd_cents")]
        public int? UnitCostUsdCents { get; set; }
    }

    public class DirectTransactionInputCurrencyType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Units { get; set; }
    }

    public class DirectTransactionInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CalculatePackageResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculatePackageResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculatePackageResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculatePackageResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculatePackageResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculatePackageResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculatePackageResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculatePackageResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculatePackageResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculatePackageInput
    {
        [JsonProperty("weight")]
        public CalculatePackageInputWeightType Weight { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("distance")]
        public CalculatePackageInputDistanceType Distance { get; set; }

        [JsonProperty("from")]
        public CalculatePackageInputFromType From { get; set; }

        [JsonProperty("to")]
        public CalculatePackageInputToType To { get; set; }

        [JsonProperty("project_match")]
        public CalculatePackageInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculatePackageInputWeightType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class CalculatePackageInputDistanceType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class CalculatePackageInputFromType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculatePackageInputToType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculatePackageInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculatePackageInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculatePackageInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculateMCCResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculateMCCResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculateMCCResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculateMCCResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculateMCCResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculateMCCResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculateMCCResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculateMCCResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculateMCCResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculateMCCInput
    {
        [JsonProperty("mcc_code")]
        public int? MccCode { get; set; }

        [JsonProperty("currency")]
        public CalculateMCCInputCurrencyType Currency { get; set; }

        [JsonProperty("project_match")]
        public CalculateMCCInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateMCCInputCurrencyType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class CalculateMCCInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculateMCCInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateMCCInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculateFreightResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculateFreightResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculateFreightResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculateFreightResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculateFreightResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculateFreightResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculateFreightResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculateFreightResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculateFreightResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculateFreightInput
    {
        [JsonProperty("weight")]
        public CalculateFreightInputWeightType Weight { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("distance")]
        public CalculateFreightInputDistanceType Distance { get; set; }

        [JsonProperty("project_match")]
        public CalculateFreightInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateFreightInputWeightType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Units { get; set; }
    }

    public class CalculateFreightInputDistanceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class CalculateFreightInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculateFreightInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateFreightInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculateFlightResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public int TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculateFlightResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculateFlightResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculateFlightResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculateFlightResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculateFlightResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculateFlightResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculateFlightResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculateFlightResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculateFlightInput
    {
        [JsonProperty("airports", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Airports { get; set; }

        [JsonProperty("project_match")]
        public CalculateFlightInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateFlightInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculateFlightInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateFlightInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculateVehicleResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculateVehicleResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculateVehicleResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculateVehicleResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculateVehicleResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculateVehicleResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculateVehicleResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculateVehicleResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculateVehicleResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculateVehicleInput
    {
        [JsonProperty("distance", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateVehicleInputDistanceType Distance { get; set; }

        [JsonProperty("fuel_efficiency", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateVehicleInputFuelEfficiencyType FuelEfficiency { get; set; }

        [JsonProperty("project_match")]
        public CalculateVehicleInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateVehicleInputDistanceType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Units { get; set; }
    }

    public class CalculateVehicleInputFuelEfficiencyType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Units { get; set; }

        [JsonProperty("of", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Of { get; set; }
    }

    public class CalculateVehicleInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculateVehicleInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateVehicleInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CalculateElectricityResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public CalculateElectricityResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public CalculateElectricityResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class CalculateElectricityResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public CalculateElectricityResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public CalculateElectricityResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class CalculateElectricityResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class CalculateElectricityResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class CalculateElectricityResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class CalculateElectricityInput
    {
        [JsonProperty("energy", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateElectricityInputEnergyType Energy { get; set; }

        [JsonProperty("project_match")]
        public CalculateElectricityInputProjectMatchType ProjectMatch { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateElectricityInputEnergyType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Value { get; set; }

        [JsonProperty("units", DefaultValueHandling = DefaultValueHandling.Include)]
        public CalculateElectricityInputEnergyTypeUnitsType Units { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CalculateElectricityInputEnergyTypeUnitsType
    {
        Wh,
        [EnumMember(Value = "kWh")]
        KWh,
        [EnumMember(Value = "mWh")]
        MWh
    }

    public class CalculateElectricityInputProjectMatchType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public CalculateElectricityInputProjectMatchTypeLocationType Location { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CalculateElectricityInputProjectMatchTypeLocationType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class ProjectDetailsResponse
    {
        [JsonProperty("project")]
        public ProjectDetailsResponseProjectType Project { get; set; }
    }

    public class ProjectDetailsResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }

        [JsonProperty("cost_per_kg_carbon_in_usd_cents")]
        public string CostPerKgCarbonInUsdCents { get; set; }

        [JsonProperty("available_carbon_in_kg")]
        public string AvailableCarbonInKg { get; set; }
    }

    public class PortfolioDetailsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("blended_unit_cost_usd_cents")]
        public double BlendedUnitCostUsdCents { get; set; }

        [JsonProperty("total_remaining_units")]
        public int TotalRemainingUnits { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("offset_sources")]
        public PortfolioDetailsResponseOffsetSourcesTypeItem[] OffsetSources { get; set; }
    }

    public class PortfolioDetailsResponseOffsetSourcesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("available_carbon_in_kg")]
        public int AvailableCarbonInKg { get; set; }
    }

    public class ProjectTypesResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type_id")]
        public string TypeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class AccountResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("balance_in_usd_cents")]
        public int BalanceInUsdCents { get; set; }

        [JsonProperty("production_enabled?")]
        public bool ProductionEnabled { get; set; }
    }

    public class ConvertEstimateResponse
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("transaction_state")]
        public string TransactionState { get; set; }

        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("total_co2e_in_kg")]
        public double TotalCo2eInKg { get; set; }

        [JsonProperty("total_micro_units")]
        public double TotalMicroUnits { get; set; }

        [JsonProperty("cost")]
        public ConvertEstimateResponseCostType Cost { get; set; }

        [JsonProperty("project")]
        public ConvertEstimateResponseProjectType Project { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }
    }

    public class ConvertEstimateResponseCostType
    {
        [JsonProperty("in_usd_cents")]
        public ConvertEstimateResponseCostTypeInUsdCentsType InUsdCents { get; set; }

        [JsonProperty("requested_currency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("in_requested_currency")]
        public ConvertEstimateResponseCostTypeInRequestedCurrencyType InRequestedCurrency { get; set; }
    }

    public class ConvertEstimateResponseCostTypeInUsdCentsType
    {
        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public int TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public int CarbonCost { get; set; }
    }

    public class ConvertEstimateResponseCostTypeInRequestedCurrencyType
    {
        [JsonProperty("total_cost")]
        public double TotalCost { get; set; }

        [JsonProperty("transaction_cost")]
        public double TransactionCost { get; set; }

        [JsonProperty("carbon_cost")]
        public double CarbonCost { get; set; }
    }

    public class ConvertEstimateResponseProjectType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registry_serial_number_range")]
        public string RegistrySerialNumberRange { get; set; }

        [JsonProperty("registry_link")]
        public string RegistryLink { get; set; }

        [JsonProperty("project_url")]
        public string ProjectUrl { get; set; }
    }

    public class ConvertEstimateInput
    {
        [JsonProperty("transaction_ID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloverlyip;

    public partial class WorkflowManagedActions
    {
        public CloverlyipActions Cloverlyip(string connectionId) => new CloverlyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloverlyipTriggers Cloverlyip(string connectionId) => new CloverlyipTriggers(connectionId);
    }
}