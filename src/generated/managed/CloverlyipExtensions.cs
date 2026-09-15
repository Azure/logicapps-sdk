//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloverlyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloverlyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<DirectCarbonResponse> DirectCarbon(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodyweightvalue = null, Expression<Func<bodyweightunitsInput>> bodyweightunits = null, Expression<Func<string[]>> bodyprojectMatchlocationlatlng = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/carbon", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var weightObject = new JObject();
            var weightObjectpropCount = 0;
            if (bodyweightvalue != null)
            {
                weightObject["value"] = CSharpExpressionConverter.ConvertToken(bodyweightvalue);
                weightObjectpropCount++;
            }

            if (bodyweightunits != null)
            {
                weightObject["units"] = CSharpExpressionConverter.Convert(bodyweightunits);
                weightObjectpropCount++;
            }

            if (weightObjectpropCount > 0)
            {
                body["weight"] = weightObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationlatlng != null)
            {
                locationObject["latlng"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationlatlng);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DirectCarbonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<DirectTransactionResponse> DirectTransaction(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodycurrencyvalue = null, Expression<Func<string>> bodycurrencyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodynote = null, Expression<Func<int>> bodyunitCostUsdCents = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/currency", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (bodycurrencyvalue != null)
            {
                currencyObject["value"] = CSharpExpressionConverter.ConvertToken(bodycurrencyvalue);
                currencyObjectpropCount++;
            }

            if (bodycurrencyunits != null)
            {
                currencyObject["units"] = CSharpExpressionConverter.ConvertToken(bodycurrencyunits);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                body["currency"] = currencyObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodyunitCostUsdCents != null)
            {
                body["unit_cost_usd_cents"] = CSharpExpressionConverter.ConvertToken(bodyunitCostUsdCents);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DirectTransactionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculatePackageResponse> CalculatePackage(Expression<Func<string>> transaction, Expression<Func<double>> bodyweightvalue = null, Expression<Func<string>> bodyweightunits = null, Expression<Func<string>> bodymode = null, Expression<Func<double>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<string>> bodyfrompostalCode = null, Expression<Func<string>> bodyfromcountry = null, Expression<Func<string>> bodytopostalCode = null, Expression<Func<string>> bodytocountry = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/shipping", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var weightObject = new JObject();
            var weightObjectpropCount = 0;
            if (bodyweightvalue != null)
            {
                weightObject["value"] = CSharpExpressionConverter.ConvertToken(bodyweightvalue);
                weightObjectpropCount++;
            }

            if (bodyweightunits != null)
            {
                weightObject["units"] = CSharpExpressionConverter.ConvertToken(bodyweightunits);
                weightObjectpropCount++;
            }

            if (weightObjectpropCount > 0)
            {
                body["weight"] = weightObject;
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = CSharpExpressionConverter.ConvertToken(bodymode);
                bodypropCount++;
            }

            var distanceObject = new JObject();
            var distanceObjectpropCount = 0;
            if (bodydistancevalue != null)
            {
                distanceObject["value"] = CSharpExpressionConverter.ConvertToken(bodydistancevalue);
                distanceObjectpropCount++;
            }

            if (bodydistanceunits != null)
            {
                distanceObject["units"] = CSharpExpressionConverter.ConvertToken(bodydistanceunits);
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
                fromObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyfrompostalCode);
                fromObjectpropCount++;
            }

            if (bodyfromcountry != null)
            {
                fromObject["country"] = CSharpExpressionConverter.ConvertToken(bodyfromcountry);
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
                toObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodytopostalCode);
                toObjectpropCount++;
            }

            if (bodytocountry != null)
            {
                toObject["country"] = CSharpExpressionConverter.ConvertToken(bodytocountry);
                toObjectpropCount++;
            }

            if (toObjectpropCount > 0)
            {
                body["to"] = toObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/mcc", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymccCode != null)
            {
                body["mcc_code"] = CSharpExpressionConverter.ConvertToken(bodymccCode);
                bodypropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (bodycurrencyvalue != null)
            {
                currencyObject["value"] = CSharpExpressionConverter.ConvertToken(bodycurrencyvalue);
                currencyObjectpropCount++;
            }

            if (bodycurrencyunits != null)
            {
                currencyObject["units"] = CSharpExpressionConverter.ConvertToken(bodycurrencyunits);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                body["currency"] = currencyObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/freight", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var weightObject = new JObject();
            var weightObjectpropCount = 0;
            weightObjectpropCount++;
            weightObject["value"] = CSharpExpressionConverter.ConvertToken(bodyweightvalue);
            weightObjectpropCount++;
            weightObject["units"] = CSharpExpressionConverter.ConvertToken(bodyweightunits);
            if (weightObjectpropCount > 0)
            {
                body["weight"] = weightObject;
                bodypropCount++;
            }

            if (bodymode != null)
            {
                body["mode"] = CSharpExpressionConverter.ConvertToken(bodymode);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            var distanceObject = new JObject();
            var distanceObjectpropCount = 0;
            if (bodydistancevalue != null)
            {
                distanceObject["value"] = CSharpExpressionConverter.ConvertToken(bodydistancevalue);
                distanceObjectpropCount++;
            }

            if (bodydistanceunits != null)
            {
                distanceObject["units"] = CSharpExpressionConverter.ConvertToken(bodydistanceunits);
                distanceObjectpropCount++;
            }

            if (distanceObjectpropCount > 0)
            {
                body["distance"] = distanceObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/flight", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["airports"] = CSharpExpressionConverter.ConvertToken(bodyairports);
            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateFlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateVehicleResponse> CalculateVehicle(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<double>> bodyfuelEfficiencyvalue = null, Expression<Func<string>> bodyfuelEfficiencyunits = null, Expression<Func<string>> bodyfuelEfficiencyof = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/vehicle", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var distanceObject = new JObject();
            var distanceObjectpropCount = 0;
            if (bodydistancevalue != null)
            {
                distanceObject["value"] = CSharpExpressionConverter.ConvertToken(bodydistancevalue);
                distanceObjectpropCount++;
            }

            if (bodydistanceunits != null)
            {
                distanceObject["units"] = CSharpExpressionConverter.ConvertToken(bodydistanceunits);
                distanceObjectpropCount++;
            }

            if (distanceObjectpropCount > 0)
            {
                body["distance"] = distanceObject;
                bodypropCount++;
            }

            var fuelEfficiencyObject = new JObject();
            var fuelEfficiencyObjectpropCount = 0;
            if (bodyfuelEfficiencyvalue != null)
            {
                fuelEfficiencyObject["value"] = CSharpExpressionConverter.ConvertToken(bodyfuelEfficiencyvalue);
                fuelEfficiencyObjectpropCount++;
            }

            if (bodyfuelEfficiencyunits != null)
            {
                fuelEfficiencyObject["units"] = CSharpExpressionConverter.ConvertToken(bodyfuelEfficiencyunits);
                fuelEfficiencyObjectpropCount++;
            }

            if (bodyfuelEfficiencyof != null)
            {
                fuelEfficiencyObject["of"] = CSharpExpressionConverter.ConvertToken(bodyfuelEfficiencyof);
                fuelEfficiencyObjectpropCount++;
            }

            if (fuelEfficiencyObjectpropCount > 0)
            {
                body["fuel_efficiency"] = fuelEfficiencyObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateVehicleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateElectricityResponse> CalculateElectricity(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodyenergyvalue = null, Expression<Func<bodyenergyunitsInput>> bodyenergyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/electricity", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(transaction, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var energyObject = new JObject();
            var energyObjectpropCount = 0;
            if (bodyenergyvalue != null)
            {
                energyObject["value"] = CSharpExpressionConverter.ConvertToken(bodyenergyvalue);
                energyObjectpropCount++;
            }

            if (bodyenergyunits != null)
            {
                energyObject["units"] = CSharpExpressionConverter.Convert(bodyenergyunits);
                energyObjectpropCount++;
            }

            if (energyObjectpropCount > 0)
            {
                body["energy"] = energyObject;
                bodypropCount++;
            }

            var projectMatchObject = new JObject();
            var projectMatchObjectpropCount = 0;
            if (bodyprojectMatchtype != null)
            {
                projectMatchObject["type"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchtype);
                projectMatchObjectpropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodyprojectMatchlocationpostalCode != null)
            {
                locationObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodyprojectMatchlocationcountry != null)
            {
                locationObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchlocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                projectMatchObject["location"] = locationObject;
                projectMatchObjectpropCount++;
            }

            if (bodyprojectMatchnote != null)
            {
                projectMatchObject["note"] = CSharpExpressionConverter.ConvertToken(bodyprojectMatchnote);
                projectMatchObjectpropCount++;
            }

            if (projectMatchObjectpropCount > 0)
            {
                body["project_match"] = projectMatchObject;
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateElectricityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails(Expression<Func<string>> projectId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/project/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<PortfolioDetailsResponse> PortfolioDetails(Expression<Func<string>> portfolioId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/portfolio/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(portfolioId, 1));
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
            body["transaction_ID"] = CSharpExpressionConverter.ConvertToken(bodytransactionID);
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

    public enum transactionInput
    {
        [EnumMember(Value = "estimates")]
        Estimates,
        [EnumMember(Value = "purchases")]
        Purchases
    }

    public enum bodyweightunitsInput
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

    public enum bodyenergyunitsInput
    {
        Wh,
        [EnumMember(Value = "kWh")]
        KWh,
        [EnumMember(Value = "mWh")]
        MWh
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