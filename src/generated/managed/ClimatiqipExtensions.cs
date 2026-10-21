//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClimatiqipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateResponse> EmissionEstimate(Expression<Func<string>> bodyemissionFactoruuid = null, Expression<Func<string>> bodyemissionFactoractivityId = null, Expression<Func<string>> bodyemissionFactorsource = null, Expression<Func<string>> bodyemissionFactorregion = null, Expression<Func<bool>> bodyemissionFactorregionFallback = null, Expression<Func<string>> bodyemissionFactoryear = null, Expression<Func<string>> bodyemissionFactorlcaActivity = null, Expression<Func<string>> bodyemissionFactorcalculationMethod = null, Expression<Func<int>> bodyparametersenergy = null, Expression<Func<string>> bodyparametersenergyUnit = null, Expression<Func<int>> bodyparametersdata = null, Expression<Func<string>> bodyparametersdataUnit = null, Expression<Func<int>> bodyparametersdistance = null, Expression<Func<string>> bodyparametersdistanceUnit = null, Expression<Func<int>> bodyparametersmoney = null, Expression<Func<string>> bodyparametersmoneyUnit = null, Expression<Func<int>> bodyparametersnumber = null, Expression<Func<int>> bodyparameterstime = null, Expression<Func<string>> bodyparameterstimeUnit = null, Expression<Func<int>> bodyparameterspassengers = null, Expression<Func<int>> bodyparametersvolume = null, Expression<Func<string>> bodyparametersvolumeUnit = null, Expression<Func<int>> bodyparametersweight = null, Expression<Func<string>> bodyparametersweightUnit = null)
        {
            var __workflow_bodyemissionFactoruuid = WorkflowExpression.Compile(bodyemissionFactoruuid, nameof(bodyemissionFactoruuid), required: false);
            var __workflow_bodyemissionFactoractivityId = WorkflowExpression.Compile(bodyemissionFactoractivityId, nameof(bodyemissionFactoractivityId), required: false);
            var __workflow_bodyemissionFactorsource = WorkflowExpression.Compile(bodyemissionFactorsource, nameof(bodyemissionFactorsource), required: false);
            var __workflow_bodyemissionFactorregion = WorkflowExpression.Compile(bodyemissionFactorregion, nameof(bodyemissionFactorregion), required: false);
            var __workflow_bodyemissionFactorregionFallback = WorkflowExpression.Compile(bodyemissionFactorregionFallback, nameof(bodyemissionFactorregionFallback), required: false);
            var __workflow_bodyemissionFactoryear = WorkflowExpression.Compile(bodyemissionFactoryear, nameof(bodyemissionFactoryear), required: false);
            var __workflow_bodyemissionFactorlcaActivity = WorkflowExpression.Compile(bodyemissionFactorlcaActivity, nameof(bodyemissionFactorlcaActivity), required: false);
            var __workflow_bodyemissionFactorcalculationMethod = WorkflowExpression.Compile(bodyemissionFactorcalculationMethod, nameof(bodyemissionFactorcalculationMethod), required: false);
            var __workflow_bodyparametersenergy = WorkflowExpression.Compile(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            var __workflow_bodyparametersenergyUnit = WorkflowExpression.Compile(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            var __workflow_bodyparametersdata = WorkflowExpression.Compile(bodyparametersdata, nameof(bodyparametersdata), required: false);
            var __workflow_bodyparametersdataUnit = WorkflowExpression.Compile(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            var __workflow_bodyparametersdistance = WorkflowExpression.Compile(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            var __workflow_bodyparametersdistanceUnit = WorkflowExpression.Compile(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            var __workflow_bodyparametersmoney = WorkflowExpression.Compile(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            var __workflow_bodyparametersmoneyUnit = WorkflowExpression.Compile(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            var __workflow_bodyparametersnumber = WorkflowExpression.Compile(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            var __workflow_bodyparameterstime = WorkflowExpression.Compile(bodyparameterstime, nameof(bodyparameterstime), required: false);
            var __workflow_bodyparameterstimeUnit = WorkflowExpression.Compile(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            var __workflow_bodyparameterspassengers = WorkflowExpression.Compile(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            var __workflow_bodyparametersvolume = WorkflowExpression.Compile(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            var __workflow_bodyparametersvolumeUnit = WorkflowExpression.Compile(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            var __workflow_bodyparametersweight = WorkflowExpression.Compile(bodyparametersweight, nameof(bodyparametersweight), required: false);
            var __workflow_bodyparametersweightUnit = WorkflowExpression.Compile(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<EmissionEstimateResponse>(() =>
            {
                var apiCallPath = "/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var emissionFactorObject = new JObject();
                var emissionFactorObjectpropCount = 0;
                if (__workflow_bodyemissionFactoruuid != null)
                {
                    emissionFactorObject["uuid"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactoruuid);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactoractivityId != null)
                {
                    emissionFactorObject["activity_id"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactoractivityId);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactorsource != null)
                {
                    emissionFactorObject["source"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactorsource);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactorregion != null)
                {
                    emissionFactorObject["region"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactorregion);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactorregionFallback != null)
                {
                    emissionFactorObject["region_fallback"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactorregionFallback);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactoryear != null)
                {
                    emissionFactorObject["year"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactoryear);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactorlcaActivity != null)
                {
                    emissionFactorObject["lca_activity"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactorlcaActivity);
                    emissionFactorObjectpropCount++;
                }

                if (__workflow_bodyemissionFactorcalculationMethod != null)
                {
                    emissionFactorObject["calculation_method"] = ExpressionConverter.ConvertO(__workflow_bodyemissionFactorcalculationMethod);
                    emissionFactorObjectpropCount++;
                }

                if (emissionFactorObjectpropCount > 0)
                {
                    body["emission_factor"] = emissionFactorObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(__workflow_bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweightUnit);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> EmissionEstimateBulk(Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmissionEstimateBulkResponse>(() =>
            {
                var apiCallPath = "/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmissionEstimateBulkResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<TravelFlightResponse> TravelFlight(Expression<Func<bodylegsInputItem[]>> bodylegs)
        {
            var __workflow_bodylegs = WorkflowExpression.Compile(bodylegs, nameof(bodylegs), required: true);
            return new DeferredBodyAction<TravelFlightResponse>(() =>
            {
                var apiCallPath = "/travel/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = ExpressionConverter.ConvertO(__workflow_bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TravelFlightResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FreightFlightResponse> FreightFlight(Expression<Func<bodylegsInputItem[]>> bodylegs)
        {
            var __workflow_bodylegs = WorkflowExpression.Compile(bodylegs, nameof(bodylegs), required: true);
            return new DeferredBodyAction<FreightFlightResponse>(() =>
            {
                var apiCallPath = "/freight/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = ExpressionConverter.ConvertO(__workflow_bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FreightFlightResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
        public IBodyWorkflowAction<ComputeCPUResponse> ComputeCPU(Expression<Func<string>> provider, Expression<Func<int>> bodycpuCount, Expression<Func<string>> bodyregion, Expression<Func<int>> bodycpuLoad, Expression<Func<int>> bodyduration, Expression<Func<string>> bodydurationUnit = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_bodycpuCount = WorkflowExpression.Compile(bodycpuCount, nameof(bodycpuCount), required: true);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: true);
            var __workflow_bodycpuLoad = WorkflowExpression.Compile(bodycpuLoad, nameof(bodycpuLoad), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: true);
            var __workflow_bodydurationUnit = WorkflowExpression.Compile(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeCPUResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/cpu", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cpu_count"] = ExpressionConverter.ConvertO(__workflow_bodycpuCount);
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                bodypropCount++;
                body["cpu_load"] = ExpressionConverter.ConvertO(__workflow_bodycpuLoad);
                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                if (__workflow_bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(__workflow_bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeCPUResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeStorageResponse> ComputeStorage(Expression<Func<string>> provider, Expression<Func<string>> bodyregion, Expression<Func<bodystorageTypeInput>> bodystorageType, Expression<Func<int>> bodydata, Expression<Func<int>> bodyduration, Expression<Func<string>> bodydataUnit = null, Expression<Func<string>> bodydurationUnit = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: true);
            var __workflow_bodystorageType = WorkflowExpression.Compile(bodystorageType, nameof(bodystorageType), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: true);
            var __workflow_bodydataUnit = WorkflowExpression.Compile(bodydataUnit, nameof(bodydataUnit), required: false);
            var __workflow_bodydurationUnit = WorkflowExpression.Compile(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeStorageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/storage", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                bodypropCount++;
                body["storage_type"] = ExpressionConverter.ConvertO(__workflow_bodystorageType);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (__workflow_bodydataUnit != null)
                {
                    body["data_unit"] = ExpressionConverter.ConvertO(__workflow_bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                if (__workflow_bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(__workflow_bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeStorageResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMemoryResponse> ComputeMemory(Expression<Func<string>> provider, Expression<Func<string>> bodyregion, Expression<Func<int>> bodydata, Expression<Func<int>> bodyduration, Expression<Func<string>> bodydataUnit = null, Expression<Func<string>> bodydurationUnit = null)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: true);
            var __workflow_bodydata = WorkflowExpression.Compile(bodydata, nameof(bodydata), required: true);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: true);
            var __workflow_bodydataUnit = WorkflowExpression.Compile(bodydataUnit, nameof(bodydataUnit), required: false);
            var __workflow_bodydurationUnit = WorkflowExpression.Compile(bodydurationUnit, nameof(bodydurationUnit), required: false);
            return new DeferredBodyAction<ComputeMemoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/memory", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                if (__workflow_bodydataUnit != null)
                {
                    body["data_unit"] = ExpressionConverter.ConvertO(__workflow_bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                if (__workflow_bodydurationUnit != null)
                {
                    body["duration_unit"] = ExpressionConverter.ConvertO(__workflow_bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComputeMemoryResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ClassificationResponse> Classification(Expression<Func<string>> bodyclassificationclassificationType = null, Expression<Func<string>> bodyclassificationclassificationCode = null, Expression<Func<string>> bodyclassificationsource = null, Expression<Func<string>> bodyclassificationregion = null, Expression<Func<bool>> bodyclassificationregionFallback = null, Expression<Func<string>> bodyclassificationyear = null, Expression<Func<string>> bodyclassificationlcaActivity = null, Expression<Func<string>> bodyclassificationcalculationMethod = null, Expression<Func<int>> bodyparametersenergy = null, Expression<Func<string>> bodyparametersenergyUnit = null, Expression<Func<int>> bodyparametersdata = null, Expression<Func<string>> bodyparametersdataUnit = null, Expression<Func<int>> bodyparametersdistance = null, Expression<Func<string>> bodyparametersdistanceUnit = null, Expression<Func<int>> bodyparametersmoney = null, Expression<Func<string>> bodyparametersmoneyUnit = null, Expression<Func<int>> bodyparametersnumber = null, Expression<Func<int>> bodyparameterstime = null, Expression<Func<string>> bodyparameterstimeUnit = null, Expression<Func<int>> bodyparameterspassengers = null, Expression<Func<int>> bodyparametersvolume = null, Expression<Func<string>> bodyparametersvolumeUnit = null, Expression<Func<int>> bodyparametersweight = null, Expression<Func<string>> bodyparametersweightUnit = null)
        {
            var __workflow_bodyclassificationclassificationType = WorkflowExpression.Compile(bodyclassificationclassificationType, nameof(bodyclassificationclassificationType), required: false);
            var __workflow_bodyclassificationclassificationCode = WorkflowExpression.Compile(bodyclassificationclassificationCode, nameof(bodyclassificationclassificationCode), required: false);
            var __workflow_bodyclassificationsource = WorkflowExpression.Compile(bodyclassificationsource, nameof(bodyclassificationsource), required: false);
            var __workflow_bodyclassificationregion = WorkflowExpression.Compile(bodyclassificationregion, nameof(bodyclassificationregion), required: false);
            var __workflow_bodyclassificationregionFallback = WorkflowExpression.Compile(bodyclassificationregionFallback, nameof(bodyclassificationregionFallback), required: false);
            var __workflow_bodyclassificationyear = WorkflowExpression.Compile(bodyclassificationyear, nameof(bodyclassificationyear), required: false);
            var __workflow_bodyclassificationlcaActivity = WorkflowExpression.Compile(bodyclassificationlcaActivity, nameof(bodyclassificationlcaActivity), required: false);
            var __workflow_bodyclassificationcalculationMethod = WorkflowExpression.Compile(bodyclassificationcalculationMethod, nameof(bodyclassificationcalculationMethod), required: false);
            var __workflow_bodyparametersenergy = WorkflowExpression.Compile(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            var __workflow_bodyparametersenergyUnit = WorkflowExpression.Compile(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            var __workflow_bodyparametersdata = WorkflowExpression.Compile(bodyparametersdata, nameof(bodyparametersdata), required: false);
            var __workflow_bodyparametersdataUnit = WorkflowExpression.Compile(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            var __workflow_bodyparametersdistance = WorkflowExpression.Compile(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            var __workflow_bodyparametersdistanceUnit = WorkflowExpression.Compile(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            var __workflow_bodyparametersmoney = WorkflowExpression.Compile(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            var __workflow_bodyparametersmoneyUnit = WorkflowExpression.Compile(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            var __workflow_bodyparametersnumber = WorkflowExpression.Compile(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            var __workflow_bodyparameterstime = WorkflowExpression.Compile(bodyparameterstime, nameof(bodyparameterstime), required: false);
            var __workflow_bodyparameterstimeUnit = WorkflowExpression.Compile(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            var __workflow_bodyparameterspassengers = WorkflowExpression.Compile(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            var __workflow_bodyparametersvolume = WorkflowExpression.Compile(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            var __workflow_bodyparametersvolumeUnit = WorkflowExpression.Compile(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            var __workflow_bodyparametersweight = WorkflowExpression.Compile(bodyparametersweight, nameof(bodyparametersweight), required: false);
            var __workflow_bodyparametersweightUnit = WorkflowExpression.Compile(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<ClassificationResponse>(() =>
            {
                var apiCallPath = "/classifications/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var classificationObject = new JObject();
                var classificationObjectpropCount = 0;
                if (__workflow_bodyclassificationclassificationType != null)
                {
                    classificationObject["classification_type"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationclassificationType);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationclassificationCode != null)
                {
                    classificationObject["classification_code"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationclassificationCode);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationsource != null)
                {
                    classificationObject["source"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationsource);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationregion != null)
                {
                    classificationObject["region"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationregion);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationregionFallback != null)
                {
                    classificationObject["region_fallback"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationregionFallback);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationyear != null)
                {
                    classificationObject["year"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationyear);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationlcaActivity != null)
                {
                    classificationObject["lca_activity"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationlcaActivity);
                    classificationObjectpropCount++;
                }

                if (__workflow_bodyclassificationcalculationMethod != null)
                {
                    classificationObject["calculation_method"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationcalculationMethod);
                    classificationObjectpropCount++;
                }

                if (classificationObjectpropCount > 0)
                {
                    body["classification"] = classificationObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(__workflow_bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweightUnit);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomResponse> Custom(Expression<Func<string>> bodycustomActivitylabel = null, Expression<Func<string>> bodycustomActivitysource = null, Expression<Func<string>> bodycustomActivityregion = null, Expression<Func<bool>> bodycustomActivityregionFallback = null, Expression<Func<string>> bodycustomActivityyear = null, Expression<Func<string>> bodycustomActivitylcaActivity = null, Expression<Func<string>> bodycustomActivitycalculationMethod = null, Expression<Func<int>> bodyparametersenergy = null, Expression<Func<string>> bodyparametersenergyUnit = null, Expression<Func<int>> bodyparametersdata = null, Expression<Func<string>> bodyparametersdataUnit = null, Expression<Func<int>> bodyparametersdistance = null, Expression<Func<string>> bodyparametersdistanceUnit = null, Expression<Func<int>> bodyparametersmoney = null, Expression<Func<string>> bodyparametersmoneyUnit = null, Expression<Func<int>> bodyparametersnumber = null, Expression<Func<int>> bodyparameterstime = null, Expression<Func<string>> bodyparameterstimeUnit = null, Expression<Func<int>> bodyparameterspassengers = null, Expression<Func<int>> bodyparametersvolume = null, Expression<Func<string>> bodyparametersvolumeUnit = null, Expression<Func<int>> bodyparametersweight = null, Expression<Func<string>> bodyparametersweightUnit = null)
        {
            var __workflow_bodycustomActivitylabel = WorkflowExpression.Compile(bodycustomActivitylabel, nameof(bodycustomActivitylabel), required: false);
            var __workflow_bodycustomActivitysource = WorkflowExpression.Compile(bodycustomActivitysource, nameof(bodycustomActivitysource), required: false);
            var __workflow_bodycustomActivityregion = WorkflowExpression.Compile(bodycustomActivityregion, nameof(bodycustomActivityregion), required: false);
            var __workflow_bodycustomActivityregionFallback = WorkflowExpression.Compile(bodycustomActivityregionFallback, nameof(bodycustomActivityregionFallback), required: false);
            var __workflow_bodycustomActivityyear = WorkflowExpression.Compile(bodycustomActivityyear, nameof(bodycustomActivityyear), required: false);
            var __workflow_bodycustomActivitylcaActivity = WorkflowExpression.Compile(bodycustomActivitylcaActivity, nameof(bodycustomActivitylcaActivity), required: false);
            var __workflow_bodycustomActivitycalculationMethod = WorkflowExpression.Compile(bodycustomActivitycalculationMethod, nameof(bodycustomActivitycalculationMethod), required: false);
            var __workflow_bodyparametersenergy = WorkflowExpression.Compile(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            var __workflow_bodyparametersenergyUnit = WorkflowExpression.Compile(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            var __workflow_bodyparametersdata = WorkflowExpression.Compile(bodyparametersdata, nameof(bodyparametersdata), required: false);
            var __workflow_bodyparametersdataUnit = WorkflowExpression.Compile(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            var __workflow_bodyparametersdistance = WorkflowExpression.Compile(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            var __workflow_bodyparametersdistanceUnit = WorkflowExpression.Compile(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            var __workflow_bodyparametersmoney = WorkflowExpression.Compile(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            var __workflow_bodyparametersmoneyUnit = WorkflowExpression.Compile(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            var __workflow_bodyparametersnumber = WorkflowExpression.Compile(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            var __workflow_bodyparameterstime = WorkflowExpression.Compile(bodyparameterstime, nameof(bodyparameterstime), required: false);
            var __workflow_bodyparameterstimeUnit = WorkflowExpression.Compile(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            var __workflow_bodyparameterspassengers = WorkflowExpression.Compile(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            var __workflow_bodyparametersvolume = WorkflowExpression.Compile(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            var __workflow_bodyparametersvolumeUnit = WorkflowExpression.Compile(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            var __workflow_bodyparametersweight = WorkflowExpression.Compile(bodyparametersweight, nameof(bodyparametersweight), required: false);
            var __workflow_bodyparametersweightUnit = WorkflowExpression.Compile(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            return new DeferredBodyAction<CustomResponse>(() =>
            {
                var apiCallPath = "/custom-activities/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var customActivityObject = new JObject();
                var customActivityObjectpropCount = 0;
                if (__workflow_bodycustomActivitylabel != null)
                {
                    customActivityObject["label"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivitylabel);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivitysource != null)
                {
                    customActivityObject["source"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivitysource);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivityregion != null)
                {
                    customActivityObject["region"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivityregion);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivityregionFallback != null)
                {
                    customActivityObject["region_fallback"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivityregionFallback);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivityyear != null)
                {
                    customActivityObject["year"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivityyear);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivitylcaActivity != null)
                {
                    customActivityObject["lca_activity"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivitylcaActivity);
                    customActivityObjectpropCount++;
                }

                if (__workflow_bodycustomActivitycalculationMethod != null)
                {
                    customActivityObject["calculation_method"] = ExpressionConverter.ConvertO(__workflow_bodycustomActivitycalculationMethod);
                    customActivityObjectpropCount++;
                }

                if (customActivityObjectpropCount > 0)
                {
                    body["custom_activity"] = customActivityObject;
                    bodypropCount++;
                }

                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (__workflow_bodyparametersenergy != null)
                {
                    parametersObject["energy"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdata != null)
                {
                    parametersObject["data"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistance != null)
                {
                    parametersObject["distance"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoney != null)
                {
                    parametersObject["money"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersnumber != null)
                {
                    parametersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstime != null)
                {
                    parametersObject["time"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = ExpressionConverter.ConvertO(__workflow_bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolume != null)
                {
                    parametersObject["volume"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweight != null)
                {
                    parametersObject["weight"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = ExpressionConverter.ConvertO(__workflow_bodyparametersweightUnit);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomBatchResponse> CustomBatch(Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomBatchResponse>(() =>
            {
                var apiCallPath = "/custom-activities/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomBatchResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FactorsSearchResponse> FactorsSearch(Expression<Func<string>> query = null, Expression<Func<string>> uuid = null, Expression<Func<string>> activityId = null, Expression<Func<string>> id = null, Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null, Expression<Func<string>> unitType = null, Expression<Func<int>> page = null, Expression<Func<int>> resultsPerPage = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: false);
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            var __workflow_unitType = WorkflowExpression.Compile(unitType, nameof(unitType), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_resultsPerPage = WorkflowExpression.Compile(resultsPerPage, nameof(resultsPerPage), required: false);
            return new DeferredBodyAction<FactorsSearchResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_uuid != null)
                    callPayload.Queries["uuid"] = ExpressionConverter.Convert(__workflow_uuid);
                if (__workflow_activityId != null)
                    callPayload.Queries["activity_id"] = ExpressionConverter.Convert(__workflow_activityId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                if (__workflow_unitType != null)
                    callPayload.Queries["unit_type"] = ExpressionConverter.Convert(__workflow_unitType);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_resultsPerPage != null)
                    callPayload.Queries["results_per_page"] = ExpressionConverter.Convert(__workflow_resultsPerPage);
                return new ApiConnectionAction<FactorsSearchResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SourcesResponse> Sources(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SourcesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<SourcesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<YearsResponse> Years(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<YearsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/years";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<YearsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<RegionsResponse> Regions(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<RegionsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<RegionsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CategoriesResponse> Categories(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<CategoriesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<CategoriesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SectorsResponse> Sectors(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SectorsResponse>(() =>
            {
                var apiCallPath = "/emission-factors/sectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<SectorsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> LifeCycleActivities(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<LifeCycleActivitiesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/lca-activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<LifeCycleActivitiesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<UnitTypesResponse> UnitTypes(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<UnitTypesResponse>(() =>
            {
                var apiCallPath = "/emission-factors/unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<UnitTypesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
