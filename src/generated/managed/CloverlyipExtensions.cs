//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloverlyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloverlyipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildDirectCarbon))]
        public IBodyWorkflowAction<DirectCarbonResponse> DirectCarbon([WorkflowExpression] Func<transactionInput> transaction, [WorkflowExpression] Func<double> bodyweightvalue = null, [WorkflowExpression] Func<bodyweightunitsInput> bodyweightunits = null, [WorkflowExpression] Func<string[]> bodyprojectMatchlocationlatlng = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectCarbonResponse> __BuildDirectCarbon(WorkflowExpression<transactionInput> transaction, WorkflowExpression<double> bodyweightvalue = null, WorkflowExpression<bodyweightunitsInput> bodyweightunits = null, WorkflowExpression<string[]> bodyprojectMatchlocationlatlng = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodyweightvalue, nameof(bodyweightvalue), required: false);
            WorkflowExpression.Validate(bodyweightunits, nameof(bodyweightunits), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationlatlng, nameof(bodyprojectMatchlocationlatlng), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DirectCarbonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/carbon", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
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

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodyprojectMatchlocationlatlng != null)
                {
                    locationObject["latlng"] = ExpressionConverter.ConvertO(bodyprojectMatchlocationlatlng);
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
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
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
        [WorkflowExpressionFactory(nameof(__BuildDirectTransaction))]
        public IBodyWorkflowAction<DirectTransactionResponse> DirectTransaction([WorkflowExpression] Func<transactionInput> transaction, [WorkflowExpression] Func<double> bodycurrencyvalue = null, [WorkflowExpression] Func<string> bodycurrencyunits = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodyunitCostUsdCents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DirectTransactionResponse> __BuildDirectTransaction(WorkflowExpression<transactionInput> transaction, WorkflowExpression<double> bodycurrencyvalue = null, WorkflowExpression<string> bodycurrencyunits = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodynote = null, WorkflowExpression<int> bodyunitCostUsdCents = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodycurrencyvalue, nameof(bodycurrencyvalue), required: false);
            WorkflowExpression.Validate(bodycurrencyunits, nameof(bodycurrencyunits), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodyunitCostUsdCents, nameof(bodyunitCostUsdCents), required: false);
            return new DeferredBodyAction<DirectTransactionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/currency", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodyunitCostUsdCents != null)
                {
                    body["unit_cost_usd_cents"] = ExpressionConverter.ConvertO(bodyunitCostUsdCents);
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
        [WorkflowExpressionFactory(nameof(__BuildCalculatePackage))]
        public IBodyWorkflowAction<CalculatePackageResponse> CalculatePackage([WorkflowExpression] Func<string> transaction, [WorkflowExpression] Func<double> bodyweightvalue = null, [WorkflowExpression] Func<string> bodyweightunits = null, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<double> bodydistancevalue = null, [WorkflowExpression] Func<string> bodydistanceunits = null, [WorkflowExpression] Func<string> bodyfrompostalCode = null, [WorkflowExpression] Func<string> bodyfromcountry = null, [WorkflowExpression] Func<string> bodytopostalCode = null, [WorkflowExpression] Func<string> bodytocountry = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculatePackageResponse> __BuildCalculatePackage(WorkflowExpression<string> transaction, WorkflowExpression<double> bodyweightvalue = null, WorkflowExpression<string> bodyweightunits = null, WorkflowExpression<string> bodymode = null, WorkflowExpression<double> bodydistancevalue = null, WorkflowExpression<string> bodydistanceunits = null, WorkflowExpression<string> bodyfrompostalCode = null, WorkflowExpression<string> bodyfromcountry = null, WorkflowExpression<string> bodytopostalCode = null, WorkflowExpression<string> bodytocountry = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodyweightvalue, nameof(bodyweightvalue), required: false);
            WorkflowExpression.Validate(bodyweightunits, nameof(bodyweightunits), required: false);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodydistancevalue, nameof(bodydistancevalue), required: false);
            WorkflowExpression.Validate(bodydistanceunits, nameof(bodydistanceunits), required: false);
            WorkflowExpression.Validate(bodyfrompostalCode, nameof(bodyfrompostalCode), required: false);
            WorkflowExpression.Validate(bodyfromcountry, nameof(bodyfromcountry), required: false);
            WorkflowExpression.Validate(bodytopostalCode, nameof(bodytopostalCode), required: false);
            WorkflowExpression.Validate(bodytocountry, nameof(bodytocountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculatePackageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/shipping", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
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

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateMCC))]
        public IBodyWorkflowAction<CalculateMCCResponse> CalculateMCC([WorkflowExpression] Func<string> transaction, [WorkflowExpression] Func<int> bodymccCode = null, [WorkflowExpression] Func<double> bodycurrencyvalue = null, [WorkflowExpression] Func<string> bodycurrencyunits = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateMCCResponse> __BuildCalculateMCC(WorkflowExpression<string> transaction, WorkflowExpression<int> bodymccCode = null, WorkflowExpression<double> bodycurrencyvalue = null, WorkflowExpression<string> bodycurrencyunits = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodymccCode, nameof(bodymccCode), required: false);
            WorkflowExpression.Validate(bodycurrencyvalue, nameof(bodycurrencyvalue), required: false);
            WorkflowExpression.Validate(bodycurrencyunits, nameof(bodycurrencyunits), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateMCCResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/mcc", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
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

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateFreight))]
        public IBodyWorkflowAction<CalculateFreightResponse> CalculateFreight([WorkflowExpression] Func<string> transaction, [WorkflowExpression] Func<double> bodyweightvalue, [WorkflowExpression] Func<string> bodyweightunits, [WorkflowExpression] Func<string> bodymode = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydistancevalue = null, [WorkflowExpression] Func<string> bodydistanceunits = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateFreightResponse> __BuildCalculateFreight(WorkflowExpression<string> transaction, WorkflowExpression<double> bodyweightvalue, WorkflowExpression<string> bodyweightunits, WorkflowExpression<string> bodymode = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodydistancevalue = null, WorkflowExpression<string> bodydistanceunits = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodyweightvalue, nameof(bodyweightvalue), required: true);
            WorkflowExpression.Validate(bodyweightunits, nameof(bodyweightunits), required: true);
            WorkflowExpression.Validate(bodymode, nameof(bodymode), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodydistancevalue, nameof(bodydistancevalue), required: false);
            WorkflowExpression.Validate(bodydistanceunits, nameof(bodydistanceunits), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateFreightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/freight", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
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

                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateFlight))]
        public IBodyWorkflowAction<CalculateFlightResponse> CalculateFlight([WorkflowExpression] Func<transactionInput> transaction, [WorkflowExpression] Func<string[]> bodyairports, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateFlightResponse> __BuildCalculateFlight(WorkflowExpression<transactionInput> transaction, WorkflowExpression<string[]> bodyairports, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodyairports, nameof(bodyairports), required: true);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateFlightResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/flight", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["airports"] = ExpressionConverter.ConvertO(bodyairports);
                var projectMatchObject = new JObject();
                var projectMatchObjectpropCount = 0;
                if (bodyprojectMatchtype != null)
                {
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateVehicle))]
        public IBodyWorkflowAction<CalculateVehicleResponse> CalculateVehicle([WorkflowExpression] Func<transactionInput> transaction, [WorkflowExpression] Func<double> bodydistancevalue = null, [WorkflowExpression] Func<string> bodydistanceunits = null, [WorkflowExpression] Func<double> bodyfuelEfficiencyvalue = null, [WorkflowExpression] Func<string> bodyfuelEfficiencyunits = null, [WorkflowExpression] Func<string> bodyfuelEfficiencyof = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateVehicleResponse> __BuildCalculateVehicle(WorkflowExpression<transactionInput> transaction, WorkflowExpression<double> bodydistancevalue = null, WorkflowExpression<string> bodydistanceunits = null, WorkflowExpression<double> bodyfuelEfficiencyvalue = null, WorkflowExpression<string> bodyfuelEfficiencyunits = null, WorkflowExpression<string> bodyfuelEfficiencyof = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodydistancevalue, nameof(bodydistancevalue), required: false);
            WorkflowExpression.Validate(bodydistanceunits, nameof(bodydistanceunits), required: false);
            WorkflowExpression.Validate(bodyfuelEfficiencyvalue, nameof(bodyfuelEfficiencyvalue), required: false);
            WorkflowExpression.Validate(bodyfuelEfficiencyunits, nameof(bodyfuelEfficiencyunits), required: false);
            WorkflowExpression.Validate(bodyfuelEfficiencyof, nameof(bodyfuelEfficiencyof), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateVehicleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/vehicle", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
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

                var fuelEfficiencyObject = new JObject();
                var fuelEfficiencyObjectpropCount = 0;
                if (bodyfuelEfficiencyvalue != null)
                {
                    fuelEfficiencyObject["value"] = ExpressionConverter.ConvertO(bodyfuelEfficiencyvalue);
                    fuelEfficiencyObjectpropCount++;
                }

                if (bodyfuelEfficiencyunits != null)
                {
                    fuelEfficiencyObject["units"] = ExpressionConverter.ConvertO(bodyfuelEfficiencyunits);
                    fuelEfficiencyObjectpropCount++;
                }

                if (bodyfuelEfficiencyof != null)
                {
                    fuelEfficiencyObject["of"] = ExpressionConverter.ConvertO(bodyfuelEfficiencyof);
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
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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

                return new ApiConnectionAction<CalculateVehicleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildCalculateElectricity))]
        public IBodyWorkflowAction<CalculateElectricityResponse> CalculateElectricity([WorkflowExpression] Func<transactionInput> transaction, [WorkflowExpression] Func<double> bodyenergyvalue = null, [WorkflowExpression] Func<bodyenergyunitsInput> bodyenergyunits = null, [WorkflowExpression] Func<string> bodyprojectMatchtype = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationpostalCode = null, [WorkflowExpression] Func<string> bodyprojectMatchlocationcountry = null, [WorkflowExpression] Func<string> bodyprojectMatchnote = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CalculateElectricityResponse> __BuildCalculateElectricity(WorkflowExpression<transactionInput> transaction, WorkflowExpression<double> bodyenergyvalue = null, WorkflowExpression<bodyenergyunitsInput> bodyenergyunits = null, WorkflowExpression<string> bodyprojectMatchtype = null, WorkflowExpression<string> bodyprojectMatchlocationpostalCode = null, WorkflowExpression<string> bodyprojectMatchlocationcountry = null, WorkflowExpression<string> bodyprojectMatchnote = null, WorkflowExpression<string> bodynote = null)
        {
            WorkflowExpression.Validate(transaction, nameof(transaction), required: true);
            WorkflowExpression.Validate(bodyenergyvalue, nameof(bodyenergyvalue), required: false);
            WorkflowExpression.Validate(bodyenergyunits, nameof(bodyenergyunits), required: false);
            WorkflowExpression.Validate(bodyprojectMatchtype, nameof(bodyprojectMatchtype), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationpostalCode, nameof(bodyprojectMatchlocationpostalCode), required: false);
            WorkflowExpression.Validate(bodyprojectMatchlocationcountry, nameof(bodyprojectMatchlocationcountry), required: false);
            WorkflowExpression.Validate(bodyprojectMatchnote, nameof(bodyprojectMatchnote), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<CalculateElectricityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/electricity", ExpressionConverter.ConvertWithUrlEncoding(transaction, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var energyObject = new JObject();
                var energyObjectpropCount = 0;
                if (bodyenergyvalue != null)
                {
                    energyObject["value"] = ExpressionConverter.ConvertO(bodyenergyvalue);
                    energyObjectpropCount++;
                }

                if (bodyenergyunits != null)
                {
                    energyObject["units"] = ExpressionConverter.ConvertO(bodyenergyunits);
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
                    projectMatchObject["type"] = ExpressionConverter.ConvertO(bodyprojectMatchtype);
                    projectMatchObjectpropCount++;
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
                    projectMatchObject["location"] = locationObject;
                    projectMatchObjectpropCount++;
                }

                if (bodyprojectMatchnote != null)
                {
                    projectMatchObject["note"] = ExpressionConverter.ConvertO(bodyprojectMatchnote);
                    projectMatchObjectpropCount++;
                }

                if (projectMatchObjectpropCount > 0)
                {
                    body["project_match"] = projectMatchObject;
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

                return new ApiConnectionAction<CalculateElectricityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildProjectDetails))]
        public IBodyWorkflowAction<ProjectDetailsResponse> ProjectDetails([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProjectDetailsResponse> __BuildProjectDetails(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [WorkflowExpressionFactory(nameof(__BuildPortfolioDetails))]
        public IBodyWorkflowAction<PortfolioDetailsResponse> PortfolioDetails([WorkflowExpression] Func<string> portfolioId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PortfolioDetailsResponse> __BuildPortfolioDetails(WorkflowExpression<string> portfolioId)
        {
            WorkflowExpression.Validate(portfolioId, nameof(portfolioId), required: true);
            return new DeferredBodyAction<PortfolioDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/portfolio/{0}", ExpressionConverter.ConvertWithUrlEncoding(portfolioId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildConvertEstimate))]
        public IBodyWorkflowAction<ConvertEstimateResponse> ConvertEstimate([WorkflowExpression] Func<string> bodytransactionID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloverlyip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConvertEstimateResponse> __BuildConvertEstimate(WorkflowExpression<string> bodytransactionID)
        {
            WorkflowExpression.Validate(bodytransactionID, nameof(bodytransactionID), required: true);
            return new DeferredBodyAction<ConvertEstimateResponse>(() =>
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