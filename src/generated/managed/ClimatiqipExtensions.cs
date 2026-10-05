//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClimatiqipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildEmissionEstimate))]
        public IBodyWorkflowAction<EmissionEstimateResponse> EmissionEstimate([WorkflowExpression] Func<string> bodyemissionFactoruuid = null, [WorkflowExpression] Func<string> bodyemissionFactoractivityId = null, [WorkflowExpression] Func<string> bodyemissionFactorsource = null, [WorkflowExpression] Func<string> bodyemissionFactorregion = null, [WorkflowExpression] Func<bool> bodyemissionFactorregionFallback = null, [WorkflowExpression] Func<string> bodyemissionFactoryear = null, [WorkflowExpression] Func<string> bodyemissionFactorlcaActivity = null, [WorkflowExpression] Func<string> bodyemissionFactorcalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmissionEstimateResponse> __BuildEmissionEstimate(WorkflowValue<string> bodyemissionFactoruuid = null, WorkflowValue<string> bodyemissionFactoractivityId = null, WorkflowValue<string> bodyemissionFactorsource = null, WorkflowValue<string> bodyemissionFactorregion = null, WorkflowValue<bool> bodyemissionFactorregionFallback = null, WorkflowValue<string> bodyemissionFactoryear = null, WorkflowValue<string> bodyemissionFactorlcaActivity = null, WorkflowValue<string> bodyemissionFactorcalculationMethod = null, WorkflowValue<int> bodyparametersenergy = null, WorkflowValue<string> bodyparametersenergyUnit = null, WorkflowValue<int> bodyparametersdata = null, WorkflowValue<string> bodyparametersdataUnit = null, WorkflowValue<int> bodyparametersdistance = null, WorkflowValue<string> bodyparametersdistanceUnit = null, WorkflowValue<int> bodyparametersmoney = null, WorkflowValue<string> bodyparametersmoneyUnit = null, WorkflowValue<int> bodyparametersnumber = null, WorkflowValue<int> bodyparameterstime = null, WorkflowValue<string> bodyparameterstimeUnit = null, WorkflowValue<int> bodyparameterspassengers = null, WorkflowValue<int> bodyparametersvolume = null, WorkflowValue<string> bodyparametersvolumeUnit = null, WorkflowValue<int> bodyparametersweight = null, WorkflowValue<string> bodyparametersweightUnit = null)
        {
            WorkflowValue.Validate(bodyemissionFactoruuid, nameof(bodyemissionFactoruuid), required: false);
            WorkflowValue.Validate(bodyemissionFactoractivityId, nameof(bodyemissionFactoractivityId), required: false);
            WorkflowValue.Validate(bodyemissionFactorsource, nameof(bodyemissionFactorsource), required: false);
            WorkflowValue.Validate(bodyemissionFactorregion, nameof(bodyemissionFactorregion), required: false);
            WorkflowValue.Validate(bodyemissionFactorregionFallback, nameof(bodyemissionFactorregionFallback), required: false);
            WorkflowValue.Validate(bodyemissionFactoryear, nameof(bodyemissionFactoryear), required: false);
            WorkflowValue.Validate(bodyemissionFactorlcaActivity, nameof(bodyemissionFactorlcaActivity), required: false);
            WorkflowValue.Validate(bodyemissionFactorcalculationMethod, nameof(bodyemissionFactorcalculationMethod), required: false);
            WorkflowValue.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowValue.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowValue.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowValue.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowValue.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowValue.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowValue.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowValue.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowValue.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowValue.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowValue.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowValue.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowValue.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowValue.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowValue.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowValue.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<EmissionEstimateResponse>(() =>
            {
                var apiCallPath = "/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var emissionFactorObject = new JObject();
                var emissionFactorObjectpropCount = 0;
                if (bodyemissionFactoruuid != null)
                {
                    emissionFactorObject["uuid"] = ExpressionConverter.ConvertO(bodyemissionFactoruuid);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactoractivityId != null)
                {
                    emissionFactorObject["activity_id"] = ExpressionConverter.ConvertO(bodyemissionFactoractivityId);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorsource != null)
                {
                    emissionFactorObject["source"] = ExpressionConverter.ConvertO(bodyemissionFactorsource);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorregion != null)
                {
                    emissionFactorObject["region"] = ExpressionConverter.ConvertO(bodyemissionFactorregion);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorregionFallback != null)
                {
                    emissionFactorObject["region_fallback"] = ExpressionConverter.ConvertO(bodyemissionFactorregionFallback);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactoryear != null)
                {
                    emissionFactorObject["year"] = ExpressionConverter.ConvertO(bodyemissionFactoryear);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorlcaActivity != null)
                {
                    emissionFactorObject["lca_activity"] = ExpressionConverter.ConvertO(bodyemissionFactorlcaActivity);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorcalculationMethod != null)
                {
                    emissionFactorObject["calculation_method"] = ExpressionConverter.ConvertO(bodyemissionFactorcalculationMethod);
                    emissionFactorObjectpropCount++;
                }

                if (emissionFactorObjectpropCount > 0)
                {
                    body["emission_factor"] = emissionFactorObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(bodyparametersweightUnit);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmissionEstimateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildEmissionEstimateBulk))]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> EmissionEstimateBulk([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> __BuildEmissionEstimateBulk(WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<EmissionEstimateBulkResponse>(() =>
            {
                var apiCallPath = "/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<EmissionEstimateBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildTravelFlight))]
        public IBodyWorkflowAction<TravelFlightResponse> TravelFlight([WorkflowExpression] Func<bodylegsInputItem[]> bodylegs)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TravelFlightResponse> __BuildTravelFlight(WorkflowValue<bodylegsInputItem[]> bodylegs)
        {
            WorkflowValue.Validate(bodylegs, nameof(bodylegs), required: true);
            return new DeferredBodyAction<TravelFlightResponse>(() =>
            {
                var apiCallPath = "/travel/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = ExpressionConverter.ConvertO(bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TravelFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildFreightFlight))]
        public IBodyWorkflowAction<FreightFlightResponse> FreightFlight([WorkflowExpression] Func<bodylegsInputItem[]> bodylegs)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FreightFlightResponse> __BuildFreightFlight(WorkflowValue<bodylegsInputItem[]> bodylegs)
        {
            WorkflowValue.Validate(bodylegs, nameof(bodylegs), required: true);
            return new DeferredBodyAction<FreightFlightResponse>(() =>
            {
                var apiCallPath = "/freight/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = ExpressionConverter.ConvertO(bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FreightFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMetadataResponse> ComputeMetadata()
        {
            var apiCallPath = "/compute";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ComputeMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildComputeCPU))]
        public IBodyWorkflowAction<ComputeCPUResponse> ComputeCPU([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<int> bodycpuCount, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<int> bodycpuLoad, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeCPUResponse> __BuildComputeCPU(WorkflowValue<string> provider, WorkflowValue<int> bodycpuCount, WorkflowValue<string> bodyregion, WorkflowValue<int> bodycpuLoad, WorkflowValue<int> bodyduration, WorkflowValue<string> bodydurationUnit = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(bodycpuCount, nameof(bodycpuCount), required: true);
            WorkflowValue.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowValue.Validate(bodycpuLoad, nameof(bodycpuLoad), required: true);
            WorkflowValue.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowValue.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeCPUResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/compute/{0}/cpu", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cpu_count"] = ExpressionConverter.ConvertO(bodycpuCount);
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
                body["cpu_load"] = ExpressionConverter.ConvertO(bodycpuLoad);
                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeCPUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildComputeStorage))]
        public IBodyWorkflowAction<ComputeStorageResponse> ComputeStorage([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<bodystorageTypeInput> bodystorageType, [WorkflowExpression] Func<int> bodydata, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydataUnit = null, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeStorageResponse> __BuildComputeStorage(WorkflowValue<string> provider, WorkflowValue<string> bodyregion, WorkflowValue<bodystorageTypeInput> bodystorageType, WorkflowValue<int> bodydata, WorkflowValue<int> bodyduration, WorkflowValue<string> bodydataUnit = null, WorkflowValue<string> bodydurationUnit = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowValue.Validate(bodystorageType, nameof(bodystorageType), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowValue.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            WorkflowValue.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeStorageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/compute/{0}/storage", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
                body["storage_type"] = ExpressionConverter.ConvertO(bodystorageType);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodydataUnit != null)
                {
                    body["data_unit"] = ExpressionConverter.ConvertO(bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeStorageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildComputeMemory))]
        public IBodyWorkflowAction<ComputeMemoryResponse> ComputeMemory([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<int> bodydata, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydataUnit = null, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeMemoryResponse> __BuildComputeMemory(WorkflowValue<string> provider, WorkflowValue<string> bodyregion, WorkflowValue<int> bodydata, WorkflowValue<int> bodyduration, WorkflowValue<string> bodydataUnit = null, WorkflowValue<string> bodydurationUnit = null)
        {
            WorkflowValue.Validate(provider, nameof(provider), required: true);
            WorkflowValue.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowValue.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowValue.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowValue.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            WorkflowValue.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeMemoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/compute/{0}/memory", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                if (bodydataUnit != null)
                {
                    body["data_unit"] = ExpressionConverter.ConvertO(bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildClassification))]
        public IBodyWorkflowAction<ClassificationResponse> Classification([WorkflowExpression] Func<string> bodyclassificationclassificationType = null, [WorkflowExpression] Func<string> bodyclassificationclassificationCode = null, [WorkflowExpression] Func<string> bodyclassificationsource = null, [WorkflowExpression] Func<string> bodyclassificationregion = null, [WorkflowExpression] Func<bool> bodyclassificationregionFallback = null, [WorkflowExpression] Func<string> bodyclassificationyear = null, [WorkflowExpression] Func<string> bodyclassificationlcaActivity = null, [WorkflowExpression] Func<string> bodyclassificationcalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassificationResponse> __BuildClassification(WorkflowValue<string> bodyclassificationclassificationType = null, WorkflowValue<string> bodyclassificationclassificationCode = null, WorkflowValue<string> bodyclassificationsource = null, WorkflowValue<string> bodyclassificationregion = null, WorkflowValue<bool> bodyclassificationregionFallback = null, WorkflowValue<string> bodyclassificationyear = null, WorkflowValue<string> bodyclassificationlcaActivity = null, WorkflowValue<string> bodyclassificationcalculationMethod = null, WorkflowValue<int> bodyparametersenergy = null, WorkflowValue<string> bodyparametersenergyUnit = null, WorkflowValue<int> bodyparametersdata = null, WorkflowValue<string> bodyparametersdataUnit = null, WorkflowValue<int> bodyparametersdistance = null, WorkflowValue<string> bodyparametersdistanceUnit = null, WorkflowValue<int> bodyparametersmoney = null, WorkflowValue<string> bodyparametersmoneyUnit = null, WorkflowValue<int> bodyparametersnumber = null, WorkflowValue<int> bodyparameterstime = null, WorkflowValue<string> bodyparameterstimeUnit = null, WorkflowValue<int> bodyparameterspassengers = null, WorkflowValue<int> bodyparametersvolume = null, WorkflowValue<string> bodyparametersvolumeUnit = null, WorkflowValue<int> bodyparametersweight = null, WorkflowValue<string> bodyparametersweightUnit = null)
        {
            WorkflowValue.Validate(bodyclassificationclassificationType, nameof(bodyclassificationclassificationType), required: false);
            WorkflowValue.Validate(bodyclassificationclassificationCode, nameof(bodyclassificationclassificationCode), required: false);
            WorkflowValue.Validate(bodyclassificationsource, nameof(bodyclassificationsource), required: false);
            WorkflowValue.Validate(bodyclassificationregion, nameof(bodyclassificationregion), required: false);
            WorkflowValue.Validate(bodyclassificationregionFallback, nameof(bodyclassificationregionFallback), required: false);
            WorkflowValue.Validate(bodyclassificationyear, nameof(bodyclassificationyear), required: false);
            WorkflowValue.Validate(bodyclassificationlcaActivity, nameof(bodyclassificationlcaActivity), required: false);
            WorkflowValue.Validate(bodyclassificationcalculationMethod, nameof(bodyclassificationcalculationMethod), required: false);
            WorkflowValue.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowValue.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowValue.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowValue.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowValue.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowValue.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowValue.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowValue.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowValue.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowValue.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowValue.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowValue.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowValue.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowValue.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowValue.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowValue.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<ClassificationResponse>(() =>
            {
                var apiCallPath = "/classifications/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var classificationObject = new JObject();
                var classificationObjectpropCount = 0;
                if (bodyclassificationclassificationType != null)
                {
                    classificationObject["classification_type"] = ExpressionConverter.ConvertO(bodyclassificationclassificationType);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationclassificationCode != null)
                {
                    classificationObject["classification_code"] = ExpressionConverter.ConvertO(bodyclassificationclassificationCode);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationsource != null)
                {
                    classificationObject["source"] = ExpressionConverter.ConvertO(bodyclassificationsource);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationregion != null)
                {
                    classificationObject["region"] = ExpressionConverter.ConvertO(bodyclassificationregion);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationregionFallback != null)
                {
                    classificationObject["region_fallback"] = ExpressionConverter.ConvertO(bodyclassificationregionFallback);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationyear != null)
                {
                    classificationObject["year"] = ExpressionConverter.ConvertO(bodyclassificationyear);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationlcaActivity != null)
                {
                    classificationObject["lca_activity"] = ExpressionConverter.ConvertO(bodyclassificationlcaActivity);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationcalculationMethod != null)
                {
                    classificationObject["calculation_method"] = ExpressionConverter.ConvertO(bodyclassificationcalculationMethod);
                    classificationObjectpropCount++;
                }

                if (classificationObjectpropCount > 0)
                {
                    body["classification"] = classificationObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(bodyparametersweightUnit);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ClassificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildCustom))]
        public IBodyWorkflowAction<CustomResponse> Custom([WorkflowExpression] Func<string> bodycustomActivitylabel = null, [WorkflowExpression] Func<string> bodycustomActivitysource = null, [WorkflowExpression] Func<string> bodycustomActivityregion = null, [WorkflowExpression] Func<bool> bodycustomActivityregionFallback = null, [WorkflowExpression] Func<string> bodycustomActivityyear = null, [WorkflowExpression] Func<string> bodycustomActivitylcaActivity = null, [WorkflowExpression] Func<string> bodycustomActivitycalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomResponse> __BuildCustom(WorkflowValue<string> bodycustomActivitylabel = null, WorkflowValue<string> bodycustomActivitysource = null, WorkflowValue<string> bodycustomActivityregion = null, WorkflowValue<bool> bodycustomActivityregionFallback = null, WorkflowValue<string> bodycustomActivityyear = null, WorkflowValue<string> bodycustomActivitylcaActivity = null, WorkflowValue<string> bodycustomActivitycalculationMethod = null, WorkflowValue<int> bodyparametersenergy = null, WorkflowValue<string> bodyparametersenergyUnit = null, WorkflowValue<int> bodyparametersdata = null, WorkflowValue<string> bodyparametersdataUnit = null, WorkflowValue<int> bodyparametersdistance = null, WorkflowValue<string> bodyparametersdistanceUnit = null, WorkflowValue<int> bodyparametersmoney = null, WorkflowValue<string> bodyparametersmoneyUnit = null, WorkflowValue<int> bodyparametersnumber = null, WorkflowValue<int> bodyparameterstime = null, WorkflowValue<string> bodyparameterstimeUnit = null, WorkflowValue<int> bodyparameterspassengers = null, WorkflowValue<int> bodyparametersvolume = null, WorkflowValue<string> bodyparametersvolumeUnit = null, WorkflowValue<int> bodyparametersweight = null, WorkflowValue<string> bodyparametersweightUnit = null)
        {
            WorkflowValue.Validate(bodycustomActivitylabel, nameof(bodycustomActivitylabel), required: false);
            WorkflowValue.Validate(bodycustomActivitysource, nameof(bodycustomActivitysource), required: false);
            WorkflowValue.Validate(bodycustomActivityregion, nameof(bodycustomActivityregion), required: false);
            WorkflowValue.Validate(bodycustomActivityregionFallback, nameof(bodycustomActivityregionFallback), required: false);
            WorkflowValue.Validate(bodycustomActivityyear, nameof(bodycustomActivityyear), required: false);
            WorkflowValue.Validate(bodycustomActivitylcaActivity, nameof(bodycustomActivitylcaActivity), required: false);
            WorkflowValue.Validate(bodycustomActivitycalculationMethod, nameof(bodycustomActivitycalculationMethod), required: false);
            WorkflowValue.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowValue.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowValue.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowValue.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowValue.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowValue.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowValue.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowValue.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowValue.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowValue.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowValue.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowValue.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowValue.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowValue.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowValue.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowValue.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<CustomResponse>(() =>
            {
                var apiCallPath = "/custom-activities/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var customActivityObject = new JObject();
                var customActivityObjectpropCount = 0;
                if (bodycustomActivitylabel != null)
                {
                    customActivityObject["label"] = ExpressionConverter.ConvertO(bodycustomActivitylabel);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitysource != null)
                {
                    customActivityObject["source"] = ExpressionConverter.ConvertO(bodycustomActivitysource);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityregion != null)
                {
                    customActivityObject["region"] = ExpressionConverter.ConvertO(bodycustomActivityregion);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityregionFallback != null)
                {
                    customActivityObject["region_fallback"] = ExpressionConverter.ConvertO(bodycustomActivityregionFallback);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityyear != null)
                {
                    customActivityObject["year"] = ExpressionConverter.ConvertO(bodycustomActivityyear);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitylcaActivity != null)
                {
                    customActivityObject["lca_activity"] = ExpressionConverter.ConvertO(bodycustomActivitylcaActivity);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitycalculationMethod != null)
                {
                    customActivityObject["calculation_method"] = ExpressionConverter.ConvertO(bodycustomActivitycalculationMethod);
                    customActivityObjectpropCount++;
                }

                if (customActivityObjectpropCount > 0)
                {
                    body["custom_activity"] = customActivityObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(bodyparametersweightUnit);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CustomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildCustomBatch))]
        public IBodyWorkflowAction<CustomBatchResponse> CustomBatch([WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomBatchResponse> __BuildCustomBatch(WorkflowValue<bodyInputItem2[]> body = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomBatchResponse>(() =>
            {
                var apiCallPath = "/custom-activities/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<CustomBatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildFactorsSearch))]
        public IBodyWorkflowAction<FactorsSearchResponse> FactorsSearch([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> uuid = null, [WorkflowExpression] Func<string> activityId = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null, [WorkflowExpression] Func<string> unitType = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> resultsPerPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FactorsSearchResponse> __BuildFactorsSearch(WorkflowValue<string> query = null, WorkflowValue<string> uuid = null, WorkflowValue<string> activityId = null, WorkflowValue<string> id = null, WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null, WorkflowValue<string> unitType = null, WorkflowValue<int> page = null, WorkflowValue<int> resultsPerPage = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: false);
            WorkflowValue.Validate(uuid, nameof(uuid), required: false);
            WorkflowValue.Validate(activityId, nameof(activityId), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            WorkflowValue.Validate(unitType, nameof(unitType), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            return new DeferredBodyAction<FactorsSearchResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (uuid != null)
                    callPayload.Queries["uuid"] = ExpressionConverter.Convert(uuid);
                if (activityId != null)
                    callPayload.Queries["activity_id"] = ExpressionConverter.Convert(activityId);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                if (unitType != null)
                    callPayload.Queries["unit_type"] = ExpressionConverter.Convert(unitType);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (resultsPerPage != null)
                    callPayload.Queries["results_per_page"] = ExpressionConverter.Convert(resultsPerPage);
                return new ApiConnectionAction<FactorsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildSources))]
        public IBodyWorkflowAction<SourcesResponse> Sources([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SourcesResponse> __BuildSources(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SourcesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<SourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildYears))]
        public IBodyWorkflowAction<YearsResponse> Years([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<YearsResponse> __BuildYears(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<YearsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/years";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<YearsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildRegions))]
        public IBodyWorkflowAction<RegionsResponse> Regions([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RegionsResponse> __BuildRegions(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<RegionsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<RegionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildCategories))]
        public IBodyWorkflowAction<CategoriesResponse> Categories([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoriesResponse> __BuildCategories(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<CategoriesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<CategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildSectors))]
        public IBodyWorkflowAction<SectorsResponse> Sectors([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SectorsResponse> __BuildSectors(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SectorsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/sectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<SectorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildLifeCycleActivities))]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> LifeCycleActivities([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> __BuildLifeCycleActivities(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<LifeCycleActivitiesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/lca-activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<LifeCycleActivitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        [WorkflowExpressionFactory(nameof(__BuildUnitTypes))]
        public IBodyWorkflowAction<UnitTypesResponse> UnitTypes([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnitTypesResponse> __BuildUnitTypes(WorkflowValue<string> sector = null, WorkflowValue<string> category = null, WorkflowValue<string> source = null, WorkflowValue<string> region = null, WorkflowValue<string> year = null, WorkflowValue<string> id = null, WorkflowValue<string> lcaActivity = null, WorkflowValue<string> calculationMethod = null)
        {
            WorkflowValue.Validate(sector, nameof(sector), required: false);
            WorkflowValue.Validate(category, nameof(category), required: false);
            WorkflowValue.Validate(source, nameof(source), required: false);
            WorkflowValue.Validate(region, nameof(region), required: false);
            WorkflowValue.Validate(year, nameof(year), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowValue.Validate(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<UnitTypesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(sector);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(region);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(calculationMethod);
                return new ApiConnectionAction<UnitTypesResponse>(callPayload);
            });
        }
    }

    public class ClimatiqipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmissionEstimateResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public EmissionEstimateResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public EmissionEstimateResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class EmissionEstimateResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class EmissionEstimateResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class EmissionEstimateBulkResponse
    {
        [JsonProperty("results")]
        public EmissionEstimateBulkResponseResultsTypeItem[] Results { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public EmissionEstimateBulkResponseResultsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public EmissionEstimateBulkResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public bodyInputItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public bodyInputItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class bodyInputItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class bodyInputItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class TravelFlightResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("legs")]
        public TravelFlightResponseLegsTypeItem[] Legs { get; set; }
    }

    public class TravelFlightResponseLegsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public TravelFlightResponseLegsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public TravelFlightResponseLegsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class TravelFlightResponseLegsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class TravelFlightResponseLegsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class bodylegsInputItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("passengers")]
        public int Passengers { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class FreightFlightResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("legs")]
        public FreightFlightResponseLegsTypeItem[] Legs { get; set; }
    }

    public class FreightFlightResponseLegsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public FreightFlightResponseLegsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public FreightFlightResponseLegsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class FreightFlightResponseLegsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class FreightFlightResponseLegsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ComputeMetadataResponse
    {
        [JsonProperty("cloud_providers")]
        public ComputeMetadataResponseCloudProvidersType CloudProviders { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersType
    {
        [JsonProperty("gcp")]
        public ComputeMetadataResponseCloudProvidersTypeGcpType Gcp { get; set; }

        [JsonProperty("aws")]
        public ComputeMetadataResponseCloudProvidersTypeAwsType Aws { get; set; }

        [JsonProperty("azure")]
        public ComputeMetadataResponseCloudProvidersTypeAzureType Azure { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeGcpType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeAwsType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeAzureType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeCPUResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeCPUResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeCPUResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeCPUResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ComputeCPUResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ComputeStorageResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeStorageResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeStorageResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeStorageResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ComputeStorageResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public enum bodystorageTypeInput
    {
        [EnumMember(Value = "ssd")]
        Ssd,
        [EnumMember(Value = "hdd")]
        Hdd
    }

    public class ComputeMemoryResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeMemoryResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeMemoryResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeMemoryResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public JToken[] DataQualityFlags { get; set; }
    }

    public class ComputeMemoryResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ClassificationResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ClassificationResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ClassificationResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ClassificationResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ClassificationResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class CustomResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public CustomResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public CustomResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class CustomResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class CustomResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class CustomBatchResponse
    {
        [JsonProperty("results")]
        public CustomBatchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CustomBatchResponseResultsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public CustomBatchResponseResultsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public CustomBatchResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class CustomBatchResponseResultsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public JToken[] DataQualityFlags { get; set; }
    }

    public class CustomBatchResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("custom_activity")]
        public bodyInputItemCustomActivityType CustomActivity { get; set; }

        [JsonProperty("parameters")]
        public bodyInputItemParametersType Parameters { get; set; }
    }

    public class bodyInputItemCustomActivityType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_fallback")]
        public bool RegionFallback { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("calculation_method")]
        public string CalculationMethod { get; set; }
    }

    public class bodyInputItemParametersType
    {
        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("data")]
        public int Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("money")]
        public int Money { get; set; }

        [JsonProperty("money_unit")]
        public string MoneyUnit { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("time_unit")]
        public string TimeUnit { get; set; }

        [JsonProperty("passengers")]
        public int Passengers { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("volume_unit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }
    }

    public class FactorsSearchResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public FactorsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("possible_filters")]
        public FactorsSearchResponsePossibleFiltersType PossibleFilters { get; set; }
    }

    public class FactorsSearchResponseResultsTypeItem
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_link")]
        public string SourceLink { get; set; }

        [JsonProperty("uncertainty")]
        public string Uncertainty { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unit_type")]
        public string[] UnitType { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("supported_calculation_methods")]
        public string[] SupportedCalculationMethods { get; set; }

        [JsonProperty("factor")]
        public double Factor { get; set; }

        [JsonProperty("factor_calculation_method")]
        public string FactorCalculationMethod { get; set; }

        [JsonProperty("factor_calculation_origin")]
        public string FactorCalculationOrigin { get; set; }

        [JsonProperty("constituent_gases")]
        public FactorsSearchResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class FactorsSearchResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public string Co2eOther { get; set; }

        [JsonProperty("co2")]
        public string Co2 { get; set; }

        [JsonProperty("ch4")]
        public string Ch4 { get; set; }

        [JsonProperty("n2o")]
        public string N2o { get; set; }
    }

    public class FactorsSearchResponsePossibleFiltersType
    {
        [JsonProperty("year")]
        public string[] Year { get; set; }

        [JsonProperty("source")]
        public string[] Source { get; set; }

        [JsonProperty("region")]
        public FactorsSearchResponsePossibleFiltersTypeRegionTypeItem[] Region { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("sector")]
        public string[] Sector { get; set; }

        [JsonProperty("unit_type")]
        public string[] UnitType { get; set; }
    }

    public class FactorsSearchResponsePossibleFiltersTypeRegionTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SourcesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class YearsResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class RegionsResponse
    {
        [JsonProperty("results")]
        public RegionsResponseResultsTypeItem[] Results { get; set; }
    }

    public class RegionsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CategoriesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class SectorsResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class LifeCycleActivitiesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class UnitTypesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip;

    public partial class WorkflowManagedActions
    {
        public ClimatiqipActions Climatiqip(string connectionId) => new ClimatiqipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClimatiqipTriggers Climatiqip(string connectionId) => new ClimatiqipTriggers(connectionId);
    }
}
