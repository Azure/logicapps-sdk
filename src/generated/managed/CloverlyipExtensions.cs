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
        public IBodyWorkflowAction<DirectCarbonResponse> DirectCarbon(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodyweightvalue = null, Expression<Func<bodyweightunitsInput>> bodyweightunits = null, Expression<Func<string[]>> bodyprojectMatchlocationlatlng = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodyweightvalue = WorkflowExpression.Compile(bodyweightvalue, nameof(bodyweightvalue), required: false);
            var __workflow_bodyweightunits = WorkflowExpression.Compile(bodyweightunits, nameof(bodyweightunits), required: false);
            var __workflow_bodyprojectMatchlocationlatlng = WorkflowExpression.Compile(bodyprojectMatchlocationlatlng, nameof(bodyprojectMatchlocationlatlng), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DirectCarbonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/carbon", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var weightObject = new JObject();
                var weightObjectpropCount = 0;
                if (__workflow_bodyweightvalue != null)
                {
                    weightObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyweightvalue);
                    weightObjectpropCount++;
                }

                if (__workflow_bodyweightunits != null)
                {
                    weightObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyweightunits);
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
                if (__workflow_bodyprojectMatchlocationlatlng != null)
                {
                    locationObject["latlng"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationlatlng);
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

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DirectCarbonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<DirectTransactionResponse> DirectTransaction(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodycurrencyvalue = null, Expression<Func<string>> bodycurrencyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodynote = null, Expression<Func<int>> bodyunitCostUsdCents = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodycurrencyvalue = WorkflowExpression.Compile(bodycurrencyvalue, nameof(bodycurrencyvalue), required: false);
            var __workflow_bodycurrencyunits = WorkflowExpression.Compile(bodycurrencyunits, nameof(bodycurrencyunits), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyunitCostUsdCents = WorkflowExpression.Compile(bodyunitCostUsdCents, nameof(bodyunitCostUsdCents), required: false);
            return new DeferredBodyAction<DirectTransactionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/currency", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var currencyObject = new JObject();
                var currencyObjectpropCount = 0;
                if (__workflow_bodycurrencyvalue != null)
                {
                    currencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyvalue);
                    currencyObjectpropCount++;
                }

                if (__workflow_bodycurrencyunits != null)
                {
                    currencyObject["units"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyunits);
                    currencyObjectpropCount++;
                }

                if (currencyObjectpropCount > 0)
                {
                    body["currency"] = currencyObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyunitCostUsdCents != null)
                {
                    body["unit_cost_usd_cents"] = ExpressionConverter.ConvertO(__workflow_bodyunitCostUsdCents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DirectTransactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculatePackageResponse> CalculatePackage(Expression<Func<string>> transaction, Expression<Func<double>> bodyweightvalue = null, Expression<Func<string>> bodyweightunits = null, Expression<Func<string>> bodymode = null, Expression<Func<double>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<string>> bodyfrompostalCode = null, Expression<Func<string>> bodyfromcountry = null, Expression<Func<string>> bodytopostalCode = null, Expression<Func<string>> bodytocountry = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodyweightvalue = WorkflowExpression.Compile(bodyweightvalue, nameof(bodyweightvalue), required: false);
            var __workflow_bodyweightunits = WorkflowExpression.Compile(bodyweightunits, nameof(bodyweightunits), required: false);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: false);
            var __workflow_bodydistancevalue = WorkflowExpression.Compile(bodydistancevalue, nameof(bodydistancevalue), required: false);
            var __workflow_bodydistanceunits = WorkflowExpression.Compile(bodydistanceunits, nameof(bodydistanceunits), required: false);
            var __workflow_bodyfrompostalCode = WorkflowExpression.Compile(bodyfrompostalCode, nameof(bodyfrompostalCode), required: false);
            var __workflow_bodyfromcountry = WorkflowExpression.Compile(bodyfromcountry, nameof(bodyfromcountry), required: false);
            var __workflow_bodytopostalCode = WorkflowExpression.Compile(bodytopostalCode, nameof(bodytopostalCode), required: false);
            var __workflow_bodytocountry = WorkflowExpression.Compile(bodytocountry, nameof(bodytocountry), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculatePackageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/shipping", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var weightObject = new JObject();
                var weightObjectpropCount = 0;
                if (__workflow_bodyweightvalue != null)
                {
                    weightObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyweightvalue);
                    weightObjectpropCount++;
                }

                if (__workflow_bodyweightunits != null)
                {
                    weightObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyweightunits);
                    weightObjectpropCount++;
                }

                if (weightObjectpropCount > 0)
                {
                    body["weight"] = weightObject;
                    bodypropCount++;
                }

                if (__workflow_bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                    bodypropCount++;
                }

                var distanceObject = new JObject();
                var distanceObjectpropCount = 0;
                if (__workflow_bodydistancevalue != null)
                {
                    distanceObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydistancevalue);
                    distanceObjectpropCount++;
                }

                if (__workflow_bodydistanceunits != null)
                {
                    distanceObject["units"] = ExpressionConverter.ConvertO(__workflow_bodydistanceunits);
                    distanceObjectpropCount++;
                }

                if (distanceObjectpropCount > 0)
                {
                    body["distance"] = distanceObject;
                    bodypropCount++;
                }

                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                if (__workflow_bodyfrompostalCode != null)
                {
                    fromObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyfrompostalCode);
                    fromObjectpropCount++;
                }

                if (__workflow_bodyfromcountry != null)
                {
                    fromObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyfromcountry);
                    fromObjectpropCount++;
                }

                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (__workflow_bodytopostalCode != null)
                {
                    toObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodytopostalCode);
                    toObjectpropCount++;
                }

                if (__workflow_bodytocountry != null)
                {
                    toObject["country"] = ExpressionConverter.ConvertO(__workflow_bodytocountry);
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    body["to"] = toObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculatePackageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateMCCResponse> CalculateMCC(Expression<Func<string>> transaction, Expression<Func<int>> bodymccCode = null, Expression<Func<double>> bodycurrencyvalue = null, Expression<Func<string>> bodycurrencyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodymccCode = WorkflowExpression.Compile(bodymccCode, nameof(bodymccCode), required: false);
            var __workflow_bodycurrencyvalue = WorkflowExpression.Compile(bodycurrencyvalue, nameof(bodycurrencyvalue), required: false);
            var __workflow_bodycurrencyunits = WorkflowExpression.Compile(bodycurrencyunits, nameof(bodycurrencyunits), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateMCCResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/mcc", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymccCode != null)
                {
                    body["mcc_code"] = ExpressionConverter.ConvertO(__workflow_bodymccCode);
                    bodypropCount++;
                }

                var currencyObject = new JObject();
                var currencyObjectpropCount = 0;
                if (__workflow_bodycurrencyvalue != null)
                {
                    currencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyvalue);
                    currencyObjectpropCount++;
                }

                if (__workflow_bodycurrencyunits != null)
                {
                    currencyObject["units"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyunits);
                    currencyObjectpropCount++;
                }

                if (currencyObjectpropCount > 0)
                {
                    body["currency"] = currencyObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateMCCResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFreightResponse> CalculateFreight(Expression<Func<string>> transaction, Expression<Func<double>> bodyweightvalue, Expression<Func<string>> bodyweightunits, Expression<Func<string>> bodymode = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodyweightvalue = WorkflowExpression.Compile(bodyweightvalue, nameof(bodyweightvalue), required: true);
            var __workflow_bodyweightunits = WorkflowExpression.Compile(bodyweightunits, nameof(bodyweightunits), required: true);
            var __workflow_bodymode = WorkflowExpression.Compile(bodymode, nameof(bodymode), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydistancevalue = WorkflowExpression.Compile(bodydistancevalue, nameof(bodydistancevalue), required: false);
            var __workflow_bodydistanceunits = WorkflowExpression.Compile(bodydistanceunits, nameof(bodydistanceunits), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateFreightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/freight", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var weightObject = new JObject();
                var weightObjectpropCount = 0;
                weightObjectpropCount++;
                weightObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyweightvalue);
                weightObjectpropCount++;
                weightObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyweightunits);
                if (weightObjectpropCount > 0)
                {
                    body["weight"] = weightObject;
                    bodypropCount++;
                }

                if (__workflow_bodymode != null)
                {
                    body["mode"] = ExpressionConverter.ConvertO(__workflow_bodymode);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                var distanceObject = new JObject();
                var distanceObjectpropCount = 0;
                if (__workflow_bodydistancevalue != null)
                {
                    distanceObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydistancevalue);
                    distanceObjectpropCount++;
                }

                if (__workflow_bodydistanceunits != null)
                {
                    distanceObject["units"] = ExpressionConverter.ConvertO(__workflow_bodydistanceunits);
                    distanceObjectpropCount++;
                }

                if (distanceObjectpropCount > 0)
                {
                    body["distance"] = distanceObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateFreightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateFlightResponse> CalculateFlight(Expression<Func<transactionInput>> transaction, Expression<Func<string[]>> bodyairports, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodyairports = WorkflowExpression.Compile(bodyairports, nameof(bodyairports), required: true);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateFlightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/flight", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["airports"] = ExpressionConverter.ConvertO(__workflow_bodyairports);
                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateVehicleResponse> CalculateVehicle(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodydistancevalue = null, Expression<Func<string>> bodydistanceunits = null, Expression<Func<double>> bodyfuelEfficiencyvalue = null, Expression<Func<string>> bodyfuelEfficiencyunits = null, Expression<Func<string>> bodyfuelEfficiencyof = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodydistancevalue = WorkflowExpression.Compile(bodydistancevalue, nameof(bodydistancevalue), required: false);
            var __workflow_bodydistanceunits = WorkflowExpression.Compile(bodydistanceunits, nameof(bodydistanceunits), required: false);
            var __workflow_bodyfuelEfficiencyvalue = WorkflowExpression.Compile(bodyfuelEfficiencyvalue, nameof(bodyfuelEfficiencyvalue), required: false);
            var __workflow_bodyfuelEfficiencyunits = WorkflowExpression.Compile(bodyfuelEfficiencyunits, nameof(bodyfuelEfficiencyunits), required: false);
            var __workflow_bodyfuelEfficiencyof = WorkflowExpression.Compile(bodyfuelEfficiencyof, nameof(bodyfuelEfficiencyof), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateVehicleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/vehicle", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var distanceObject = new JObject();
                var distanceObjectpropCount = 0;
                if (__workflow_bodydistancevalue != null)
                {
                    distanceObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydistancevalue);
                    distanceObjectpropCount++;
                }

                if (__workflow_bodydistanceunits != null)
                {
                    distanceObject["units"] = ExpressionConverter.ConvertO(__workflow_bodydistanceunits);
                    distanceObjectpropCount++;
                }

                if (distanceObjectpropCount > 0)
                {
                    body["distance"] = distanceObject;
                    bodypropCount++;
                }

                var fuelEfficiencyObject = new JObject();
                var fuelEfficiencyObjectpropCount = 0;
                if (__workflow_bodyfuelEfficiencyvalue != null)
                {
                    fuelEfficiencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfuelEfficiencyvalue);
                    fuelEfficiencyObjectpropCount++;
                }

                if (__workflow_bodyfuelEfficiencyunits != null)
                {
                    fuelEfficiencyObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyfuelEfficiencyunits);
                    fuelEfficiencyObjectpropCount++;
                }

                if (__workflow_bodyfuelEfficiencyof != null)
                {
                    fuelEfficiencyObject["of"] = ExpressionConverter.ConvertO(__workflow_bodyfuelEfficiencyof);
                    fuelEfficiencyObjectpropCount++;
                }

                if (fuelEfficiencyObjectpropCount > 0)
                {
                    body["fuel_efficiency"] = fuelEfficiencyObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateVehicleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<CalculateElectricityResponse> CalculateElectricity(Expression<Func<transactionInput>> transaction, Expression<Func<double>> bodyenergyvalue = null, Expression<Func<bodyenergyunitsInput>> bodyenergyunits = null, Expression<Func<string>> bodyprojectMatchtype = null, Expression<Func<string>> bodyprojectMatchlocationpostalCode = null, Expression<Func<string>> bodyprojectMatchlocationcountry = null, Expression<Func<string>> bodyprojectMatchnote = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_transaction = WorkflowExpression.Compile(transaction, nameof(transaction), required: true);
            var __workflow_bodyenergyvalue = WorkflowExpression.Compile(bodyenergyvalue, nameof(bodyenergyvalue), required: false);
            var __workflow_bodyenergyunits = WorkflowExpression.Compile(bodyenergyunits, nameof(bodyenergyunits), required: false);
            var __workflow_bodyprojectMatchtype = WorkflowExpression.Compile(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            var __workflow_bodyprojectMatchlocationpostalCode = WorkflowExpression.Compile(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            var __workflow_bodyprojectMatchlocationcountry = WorkflowExpression.Compile(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            var __workflow_bodyprojectMatchnote = WorkflowExpression.Compile(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateElectricityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/electricity", __workflow_transaction.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var energyObject = new JObject();
                var energyObjectpropCount = 0;
                if (__workflow_bodyenergyvalue != null)
                {
                    energyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyenergyvalue);
                    energyObjectpropCount++;
                }

                if (__workflow_bodyenergyunits != null)
                {
                    energyObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyenergyunits);
                    energyObjectpropCount++;
                }

                if (energyObjectpropCount > 0)
                {
                    body["energy"] = energyObject;
                    bodypropCount++;
                }

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (__workflow_bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodyprojectMatchlocationpostalCode != null)
                {
                    locationObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationpostalCode);
                    locationObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchlocationcountry != null)
                {
                    locationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchlocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (__workflow_bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(__workflow_bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateElectricityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/project/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        public IBodyWorkflowAction<PortfolioDetailsResponse> PortfolioDetails(Expression<Func<string>> portfolioId)
        {
            var __workflow_portfolioId = WorkflowExpression.Compile(portfolioId, nameof(portfolioId), required: true);
            return new DeferredBodyAction<PortfolioDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/portfolio/{0}", __workflow_portfolioId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PortfolioDetailsResponse>(callPayload);
            });
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
            var __workflow_bodytransactionID = WorkflowExpression.Compile(bodytransactionID, nameof(bodytransactionID), required: true);
            return new DeferredBodyAction<ConvertEstimateResponse>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["transaction_ID"] = ExpressionConverter.ConvertO(__workflow_bodytransactionID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
