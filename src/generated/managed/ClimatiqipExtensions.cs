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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmissionEstimateResponse> __BuildEmissionEstimate(WorkflowExpression<string> bodyemissionFactoruuid = null, WorkflowExpression<string> bodyemissionFactoractivityId = null, WorkflowExpression<string> bodyemissionFactorsource = null, WorkflowExpression<string> bodyemissionFactorregion = null, WorkflowExpression<bool> bodyemissionFactorregionFallback = null, WorkflowExpression<string> bodyemissionFactoryear = null, WorkflowExpression<string> bodyemissionFactorlcaActivity = null, WorkflowExpression<string> bodyemissionFactorcalculationMethod = null, WorkflowExpression<int> bodyparametersenergy = null, WorkflowExpression<string> bodyparametersenergyUnit = null, WorkflowExpression<int> bodyparametersdata = null, WorkflowExpression<string> bodyparametersdataUnit = null, WorkflowExpression<int> bodyparametersdistance = null, WorkflowExpression<string> bodyparametersdistanceUnit = null, WorkflowExpression<int> bodyparametersmoney = null, WorkflowExpression<string> bodyparametersmoneyUnit = null, WorkflowExpression<int> bodyparametersnumber = null, WorkflowExpression<int> bodyparameterstime = null, WorkflowExpression<string> bodyparameterstimeUnit = null, WorkflowExpression<int> bodyparameterspassengers = null, WorkflowExpression<int> bodyparametersvolume = null, WorkflowExpression<string> bodyparametersvolumeUnit = null, WorkflowExpression<int> bodyparametersweight = null, WorkflowExpression<string> bodyparametersweightUnit = null)
        {
            WorkflowExpression.Validate(bodyemissionFactoruuid, nameof(bodyemissionFactoruuid), required: false);
            WorkflowExpression.Validate(bodyemissionFactoractivityId, nameof(bodyemissionFactoractivityId), required: false);
            WorkflowExpression.Validate(bodyemissionFactorsource, nameof(bodyemissionFactorsource), required: false);
            WorkflowExpression.Validate(bodyemissionFactorregion, nameof(bodyemissionFactorregion), required: false);
            WorkflowExpression.Validate(bodyemissionFactorregionFallback, nameof(bodyemissionFactorregionFallback), required: false);
            WorkflowExpression.Validate(bodyemissionFactoryear, nameof(bodyemissionFactoryear), required: false);
            WorkflowExpression.Validate(bodyemissionFactorlcaActivity, nameof(bodyemissionFactorlcaActivity), required: false);
            WorkflowExpression.Validate(bodyemissionFactorcalculationMethod, nameof(bodyemissionFactorcalculationMethod), required: false);
            WorkflowExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> __BuildEmissionEstimateBulk(WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TravelFlightResponse> __BuildTravelFlight(WorkflowExpression<bodylegsInputItem[]> bodylegs)
        {
            WorkflowExpression.Validate(bodylegs, nameof(bodylegs), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FreightFlightResponse> __BuildFreightFlight(WorkflowExpression<bodylegsInputItem[]> bodylegs)
        {
            WorkflowExpression.Validate(bodylegs, nameof(bodylegs), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeCPUResponse> __BuildComputeCPU(WorkflowExpression<string> provider, WorkflowExpression<int> bodycpuCount, WorkflowExpression<string> bodyregion, WorkflowExpression<int> bodycpuLoad, WorkflowExpression<int> bodyduration, WorkflowExpression<string> bodydurationUnit = null)
        {
            WorkflowExpression.Validate(provider, nameof(provider), required: true);
            WorkflowExpression.Validate(bodycpuCount, nameof(bodycpuCount), required: true);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowExpression.Validate(bodycpuLoad, nameof(bodycpuLoad), required: true);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeStorageResponse> __BuildComputeStorage(WorkflowExpression<string> provider, WorkflowExpression<string> bodyregion, WorkflowExpression<bodystorageTypeInput> bodystorageType, WorkflowExpression<int> bodydata, WorkflowExpression<int> bodyduration, WorkflowExpression<string> bodydataUnit = null, WorkflowExpression<string> bodydurationUnit = null)
        {
            WorkflowExpression.Validate(provider, nameof(provider), required: true);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowExpression.Validate(bodystorageType, nameof(bodystorageType), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowExpression.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            WorkflowExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComputeMemoryResponse> __BuildComputeMemory(WorkflowExpression<string> provider, WorkflowExpression<string> bodyregion, WorkflowExpression<int> bodydata, WorkflowExpression<int> bodyduration, WorkflowExpression<string> bodydataUnit = null, WorkflowExpression<string> bodydurationUnit = null)
        {
            WorkflowExpression.Validate(provider, nameof(provider), required: true);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            WorkflowExpression.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            WorkflowExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ClassificationResponse> __BuildClassification(WorkflowExpression<string> bodyclassificationclassificationType = null, WorkflowExpression<string> bodyclassificationclassificationCode = null, WorkflowExpression<string> bodyclassificationsource = null, WorkflowExpression<string> bodyclassificationregion = null, WorkflowExpression<bool> bodyclassificationregionFallback = null, WorkflowExpression<string> bodyclassificationyear = null, WorkflowExpression<string> bodyclassificationlcaActivity = null, WorkflowExpression<string> bodyclassificationcalculationMethod = null, WorkflowExpression<int> bodyparametersenergy = null, WorkflowExpression<string> bodyparametersenergyUnit = null, WorkflowExpression<int> bodyparametersdata = null, WorkflowExpression<string> bodyparametersdataUnit = null, WorkflowExpression<int> bodyparametersdistance = null, WorkflowExpression<string> bodyparametersdistanceUnit = null, WorkflowExpression<int> bodyparametersmoney = null, WorkflowExpression<string> bodyparametersmoneyUnit = null, WorkflowExpression<int> bodyparametersnumber = null, WorkflowExpression<int> bodyparameterstime = null, WorkflowExpression<string> bodyparameterstimeUnit = null, WorkflowExpression<int> bodyparameterspassengers = null, WorkflowExpression<int> bodyparametersvolume = null, WorkflowExpression<string> bodyparametersvolumeUnit = null, WorkflowExpression<int> bodyparametersweight = null, WorkflowExpression<string> bodyparametersweightUnit = null)
        {
            WorkflowExpression.Validate(bodyclassificationclassificationType, nameof(bodyclassificationclassificationType), required: false);
            WorkflowExpression.Validate(bodyclassificationclassificationCode, nameof(bodyclassificationclassificationCode), required: false);
            WorkflowExpression.Validate(bodyclassificationsource, nameof(bodyclassificationsource), required: false);
            WorkflowExpression.Validate(bodyclassificationregion, nameof(bodyclassificationregion), required: false);
            WorkflowExpression.Validate(bodyclassificationregionFallback, nameof(bodyclassificationregionFallback), required: false);
            WorkflowExpression.Validate(bodyclassificationyear, nameof(bodyclassificationyear), required: false);
            WorkflowExpression.Validate(bodyclassificationlcaActivity, nameof(bodyclassificationlcaActivity), required: false);
            WorkflowExpression.Validate(bodyclassificationcalculationMethod, nameof(bodyclassificationcalculationMethod), required: false);
            WorkflowExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomResponse> __BuildCustom(WorkflowExpression<string> bodycustomActivitylabel = null, WorkflowExpression<string> bodycustomActivitysource = null, WorkflowExpression<string> bodycustomActivityregion = null, WorkflowExpression<bool> bodycustomActivityregionFallback = null, WorkflowExpression<string> bodycustomActivityyear = null, WorkflowExpression<string> bodycustomActivitylcaActivity = null, WorkflowExpression<string> bodycustomActivitycalculationMethod = null, WorkflowExpression<int> bodyparametersenergy = null, WorkflowExpression<string> bodyparametersenergyUnit = null, WorkflowExpression<int> bodyparametersdata = null, WorkflowExpression<string> bodyparametersdataUnit = null, WorkflowExpression<int> bodyparametersdistance = null, WorkflowExpression<string> bodyparametersdistanceUnit = null, WorkflowExpression<int> bodyparametersmoney = null, WorkflowExpression<string> bodyparametersmoneyUnit = null, WorkflowExpression<int> bodyparametersnumber = null, WorkflowExpression<int> bodyparameterstime = null, WorkflowExpression<string> bodyparameterstimeUnit = null, WorkflowExpression<int> bodyparameterspassengers = null, WorkflowExpression<int> bodyparametersvolume = null, WorkflowExpression<string> bodyparametersvolumeUnit = null, WorkflowExpression<int> bodyparametersweight = null, WorkflowExpression<string> bodyparametersweightUnit = null)
        {
            WorkflowExpression.Validate(bodycustomActivitylabel, nameof(bodycustomActivitylabel), required: false);
            WorkflowExpression.Validate(bodycustomActivitysource, nameof(bodycustomActivitysource), required: false);
            WorkflowExpression.Validate(bodycustomActivityregion, nameof(bodycustomActivityregion), required: false);
            WorkflowExpression.Validate(bodycustomActivityregionFallback, nameof(bodycustomActivityregionFallback), required: false);
            WorkflowExpression.Validate(bodycustomActivityyear, nameof(bodycustomActivityyear), required: false);
            WorkflowExpression.Validate(bodycustomActivitylcaActivity, nameof(bodycustomActivitylcaActivity), required: false);
            WorkflowExpression.Validate(bodycustomActivitycalculationMethod, nameof(bodycustomActivitycalculationMethod), required: false);
            WorkflowExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            WorkflowExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            WorkflowExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            WorkflowExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            WorkflowExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            WorkflowExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            WorkflowExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            WorkflowExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            WorkflowExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            WorkflowExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            WorkflowExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            WorkflowExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            WorkflowExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            WorkflowExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            WorkflowExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomBatchResponse> __BuildCustomBatch(WorkflowExpression<bodyInputItem2[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FactorsSearchResponse> __BuildFactorsSearch(WorkflowExpression<string> query = null, WorkflowExpression<string> uuid = null, WorkflowExpression<string> activityId = null, WorkflowExpression<string> id = null, WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null, WorkflowExpression<string> unitType = null, WorkflowExpression<int> page = null, WorkflowExpression<int> resultsPerPage = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: false);
            WorkflowExpression.Validate(uuid, nameof(uuid), required: false);
            WorkflowExpression.Validate(activityId, nameof(activityId), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            WorkflowExpression.Validate(unitType, nameof(unitType), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SourcesResponse> __BuildSources(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<YearsResponse> __BuildYears(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RegionsResponse> __BuildRegions(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoriesResponse> __BuildCategories(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SectorsResponse> __BuildSectors(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> __BuildLifeCycleActivities(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnitTypesResponse> __BuildUnitTypes(WorkflowExpression<string> sector = null, WorkflowExpression<string> category = null, WorkflowExpression<string> source = null, WorkflowExpression<string> region = null, WorkflowExpression<string> year = null, WorkflowExpression<string> id = null, WorkflowExpression<string> lcaActivity = null, WorkflowExpression<string> calculationMethod = null)
        {
            WorkflowExpression.Validate(sector, nameof(sector), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(region, nameof(region), required: false);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            WorkflowExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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