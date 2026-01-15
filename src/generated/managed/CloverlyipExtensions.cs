//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cloverlyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloverlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculatePackageResponse> CalculatePackage(Expression<Func<string>> transaction, Expression<Func<double>> bodyweightvalue = null, Expression<Func<string>> bodyweightunits = null, Expression<Func<string>> bodymode = null, Expression<Func<double>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<string>> bodyfrompostalCode = null, Expression<Func<string>> bodyfromcountry = null, Expression<Func<string>> bodytopostalCode = null, Expression<Func<string>> bodytocountry = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/{0}/shipping", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var weightObject = new JObject();
            var weightObjectpropCount = 0;
            if (bodyweightvalue != null)
            {
                weightObject["value"] = ExpressionConverter.ConvertO(bodyweightvalue);
                weightObjectpropCount++;
            }

            if (bodyweightunits != null)
            {
                weightObject["units"] = ExpressionConverter.ConvertO(bodyweightunits);
                weightObjectpropCount++;
            }

            if (weightObjectpropCount > 0)
            {
                body["weight"] = weightObject;
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            var distanceObject = new JObject();
            var distanceObjectpropCount = 0;
            if (bodydistancevalue != null)
            {
                distanceObject["value"] = ExpressionConverter.ConvertO(bodydistancevalue);
                distanceObjectpropCount++;
            }

            if (bodydistanceunits != null)
            {
                distanceObject["units"] = ExpressionConverter.ConvertO(bodydistanceunits);
                distanceObjectpropCount++;
            }

            if (distanceObjectpropCount > 0)
            {
                body["distance"] = distanceObject;
                bodypropCount++;
            }

            var fromObject = new JObject();
            var fromObjectpropCount = 0;
            if (bodyfrompostalCode != null)
            {
                fromObject["postal_code"] = ExpressionConverter.ConvertO(bodyfrompostalCode);
                fromObjectpropCount++;
            }

            if (bodyfromcountry != null)
            {
                fromObject["country"] = ExpressionConverter.ConvertO(bodyfromcountry);
                fromObjectpropCount++;
            }

            if (fromObjectpropCount > 0)
            {
                body["from"] = fromObject;
                bodypropCount++;
            }

            var toObject = new JObject();
            var toObjectpropCount = 0;
            if (bodytopostalCode != null)
            {
                toObject["postal_code"] = ExpressionConverter.ConvertO(bodytopostalCode);
                toObjectpropCount++;
            }

            if (bodytocountry != null)
            {
                toObject["country"] = ExpressionConverter.ConvertO(bodytocountry);
                toObjectpropCount++;
            }

            if (toObjectpropCount > 0)
            {
                body["to"] = toObject;
                bodypropCount++;
            }

            var project_matchObject = new JObject();
            var project_matchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                project_matchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                project_matchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                project_matchObject["location"] = locationObject;
                project_matchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                project_matchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                project_matchObjectpropCount++;
            }

            if (project_matchObjectpropCount > 0)
            {
                body["project_match"] = project_matchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculatePackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateMCCResponse> CalculateMCC(Expression<Func<string>> transaction, Expression<Func<int>> bodymccCode = null, Expression<Func<double>> bodycurrencyvalue = null, Expression<Func<string>> bodycurrencyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/{0}/mcc", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymccCode != null)
            {
                body["mcc_code"] = ExpressionConverter.ConvertO(bodymccCode);
                bodypropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (bodycurrencyvalue != null)
            {
                currencyObject["value"] = ExpressionConverter.ConvertO(bodycurrencyvalue);
                currencyObjectpropCount++;
            }

            if (bodycurrencyunits != null)
            {
                currencyObject["units"] = ExpressionConverter.ConvertO(bodycurrencyunits);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                body["currency"] = currencyObject;
                bodypropCount++;
            }

            var project_matchObject = new JObject();
            var project_matchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                project_matchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                project_matchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                project_matchObject["location"] = locationObject;
                project_matchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                project_matchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                project_matchObjectpropCount++;
            }

            if (project_matchObjectpropCount > 0)
            {
                body["project_match"] = project_matchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateMCCResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFreightResponse> CalculateFreight(Expression<Func<string>> transaction, Expression<Func<double>> bodyweightvalue, Expression<Func<string>> bodyweightunits, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/{0}/freight", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var weightObject = new JObject();
            var weightObjectpropCount = 0;
            weightObjectpropCount++;
            weightObject["value"] = ExpressionConverter.ConvertO(bodyweightvalue);
            weightObjectpropCount++;
            weightObject["units"] = ExpressionConverter.ConvertO(bodyweightunits);
            if (weightObjectpropCount > 0)
            {
                body["weight"] = weightObject;
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = ExpressionConverter.ConvertO(bodymode);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var distanceObject = new JObject();
            var distanceObjectpropCount = 0;
            if (bodydistancevalue != null)
            {
                distanceObject["value"] = ExpressionConverter.ConvertO(bodydistancevalue);
                distanceObjectpropCount++;
            }

            if (bodydistanceunits != null)
            {
                distanceObject["units"] = ExpressionConverter.ConvertO(bodydistanceunits);
                distanceObjectpropCount++;
            }

            if (distanceObjectpropCount > 0)
            {
                body["distance"] = distanceObject;
                bodypropCount++;
            }

            var project_matchObject = new JObject();
            var project_matchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                project_matchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                project_matchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                project_matchObject["location"] = locationObject;
                project_matchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                project_matchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                project_matchObjectpropCount++;
            }

            if (project_matchObjectpropCount > 0)
            {
                body["project_match"] = project_matchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateFreightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFlightResponse> CalculateFlight(Expression<Func<transactionInput>> transaction, Expression<Func<string[]>> bodyairports, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/{0}/flight", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["airports"] = ExpressionConverter.ConvertO(bodyairports);
            var project_matchObject = new JObject();
            var project_matchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                project_matchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                project_matchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                project_matchObject["location"] = locationObject;
                project_matchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                project_matchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                project_matchObjectpropCount++;
            }

            if (project_matchObjectpropCount > 0)
            {
                body["project_match"] = project_matchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateFlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<PortfolioDetailsResponse> PortfolioDetails(Expression<Func<string>> portfolioId)
        {
            var apiCallPath = String.Format("/portfolio/{0}", ExpressionConverter.ConvertWithUrlEncoding(portfolioId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PortfolioDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectTypesResponseItem[]> ProjectTypes()
        {
            var apiCallPath = "/project-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectTypesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<AccountResponse> Account()
        {
            var apiCallPath = "/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ConvertEstimateResponse> ConvertEstimate(Expression<Func<string>> bodytransactionID)
        {
            var apiCallPath = "/purchases";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["transaction_ID"] = ExpressionConverter.ConvertO(bodytransactionID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConvertEstimateResponse>(callPayload);
        }
    }

    public class CloverlyipTriggers([ConnectionName] string connectionId)
    {
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

    public enum transactionInput
    {
        [EnumMember(Value = "estimates")]
        Estimates,
        [EnumMember(Value = "purchases")]
        Purchases
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Cloverlyip;

    public partial class WorkflowManagedActions
    {
        public CloverlyipActions Cloverlyip(string connectionId) => new CloverlyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloverlyipTriggers Cloverlyip(string connectionId) => new CloverlyipTriggers(connectionId);
    }
}