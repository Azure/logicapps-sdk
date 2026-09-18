//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClimatiqipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateResponse> EmissionEstimate([WorkflowExpression] Func<string> bodyemissionFactoruuid = null, [WorkflowExpression] Func<string> bodyemissionFactoractivityId = null, [WorkflowExpression] Func<string> bodyemissionFactorsource = null, [WorkflowExpression] Func<string> bodyemissionFactorregion = null, [WorkflowExpression] Func<bool> bodyemissionFactorregionFallback = null, [WorkflowExpression] Func<string> bodyemissionFactoryear = null, [WorkflowExpression] Func<string> bodyemissionFactorlcaActivity = null, [WorkflowExpression] Func<string> bodyemissionFactorcalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            SourceExpression.Validate(bodyemissionFactoruuid, nameof(bodyemissionFactoruuid), required: false);
            SourceExpression.Validate(bodyemissionFactoractivityId, nameof(bodyemissionFactoractivityId), required: false);
            SourceExpression.Validate(bodyemissionFactorsource, nameof(bodyemissionFactorsource), required: false);
            SourceExpression.Validate(bodyemissionFactorregion, nameof(bodyemissionFactorregion), required: false);
            SourceExpression.Validate(bodyemissionFactorregionFallback, nameof(bodyemissionFactorregionFallback), required: false);
            SourceExpression.Validate(bodyemissionFactoryear, nameof(bodyemissionFactoryear), required: false);
            SourceExpression.Validate(bodyemissionFactorlcaActivity, nameof(bodyemissionFactorlcaActivity), required: false);
            SourceExpression.Validate(bodyemissionFactorcalculationMethod, nameof(bodyemissionFactorcalculationMethod), required: false);
            SourceExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            SourceExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            SourceExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            SourceExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            SourceExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            SourceExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            SourceExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            SourceExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            SourceExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            SourceExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            SourceExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            SourceExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            SourceExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            SourceExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            SourceExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            SourceExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    emissionFactorObject["uuid"] = SourceExpressionConverter.ConvertToken(bodyemissionFactoruuid);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactoractivityId != null)
                {
                    emissionFactorObject["activity_id"] = SourceExpressionConverter.ConvertToken(bodyemissionFactoractivityId);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorsource != null)
                {
                    emissionFactorObject["source"] = SourceExpressionConverter.ConvertToken(bodyemissionFactorsource);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorregion != null)
                {
                    emissionFactorObject["region"] = SourceExpressionConverter.ConvertToken(bodyemissionFactorregion);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorregionFallback != null)
                {
                    emissionFactorObject["region_fallback"] = SourceExpressionConverter.ConvertToken(bodyemissionFactorregionFallback);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactoryear != null)
                {
                    emissionFactorObject["year"] = SourceExpressionConverter.ConvertToken(bodyemissionFactoryear);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorlcaActivity != null)
                {
                    emissionFactorObject["lca_activity"] = SourceExpressionConverter.ConvertToken(bodyemissionFactorlcaActivity);
                    emissionFactorObjectpropCount++;
                }

                if (bodyemissionFactorcalculationMethod != null)
                {
                    emissionFactorObject["calculation_method"] = SourceExpressionConverter.ConvertToken(bodyemissionFactorcalculationMethod);
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
                    parametersObject["energy"] = SourceExpressionConverter.ConvertToken(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = SourceExpressionConverter.ConvertToken(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = SourceExpressionConverter.ConvertToken(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = SourceExpressionConverter.ConvertToken(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = SourceExpressionConverter.ConvertToken(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = SourceExpressionConverter.ConvertToken(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = SourceExpressionConverter.ConvertToken(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = SourceExpressionConverter.ConvertToken(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = SourceExpressionConverter.ConvertToken(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = SourceExpressionConverter.ConvertToken(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersweightUnit);
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
                return callPayload;
            }

            return new ApiConnectionAction<EmissionEstimateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> EmissionEstimateBulk([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<EmissionEstimateBulkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<TravelFlightResponse> TravelFlight([WorkflowExpression] Func<bodylegsInputItem[]> bodylegs)
        {
            SourceExpression.Validate(bodylegs, nameof(bodylegs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/travel/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = SourceExpressionConverter.ConvertToken(bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TravelFlightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FreightFlightResponse> FreightFlight([WorkflowExpression] Func<bodylegsInputItem[]> bodylegs)
        {
            SourceExpression.Validate(bodylegs, nameof(bodylegs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/freight/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["legs"] = SourceExpressionConverter.ConvertToken(bodylegs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FreightFlightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMetadataResponse> ComputeMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/compute";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComputeMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeCPUResponse> ComputeCPU([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<int> bodycpuCount, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<int> bodycpuLoad, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            SourceExpression.Validate(provider, nameof(provider), required: true);
            SourceExpression.Validate(bodycpuCount, nameof(bodycpuCount), required: true);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            SourceExpression.Validate(bodycpuLoad, nameof(bodycpuLoad), required: true);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            SourceExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/compute/{0}/cpu", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["cpu_count"] = SourceExpressionConverter.ConvertToken(bodycpuCount);
                bodypropCount++;
                body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
                body["cpu_load"] = SourceExpressionConverter.ConvertToken(bodycpuLoad);
                bodypropCount++;
                body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = SourceExpressionConverter.ConvertToken(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComputeCPUResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeStorageResponse> ComputeStorage([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<bodystorageTypeInput> bodystorageType, [WorkflowExpression] Func<int> bodydata, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydataUnit = null, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            SourceExpression.Validate(provider, nameof(provider), required: true);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            SourceExpression.Validate(bodystorageType, nameof(bodystorageType), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            SourceExpression.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            SourceExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/compute/{0}/storage", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
                body["storage_type"] = SourceExpressionConverter.Convert(bodystorageType);
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodydataUnit != null)
                {
                    body["data_unit"] = SourceExpressionConverter.ConvertToken(bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = SourceExpressionConverter.ConvertToken(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComputeStorageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMemoryResponse> ComputeMemory([WorkflowExpression] Func<string> provider, [WorkflowExpression] Func<string> bodyregion, [WorkflowExpression] Func<int> bodydata, [WorkflowExpression] Func<int> bodyduration, [WorkflowExpression] Func<string> bodydataUnit = null, [WorkflowExpression] Func<string> bodydurationUnit = null)
        {
            SourceExpression.Validate(provider, nameof(provider), required: true);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: true);
            SourceExpression.Validate(bodydataUnit, nameof(bodydataUnit), required: false);
            SourceExpression.Validate(bodydurationUnit, nameof(bodydurationUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/compute/{0}/memory", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(provider, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodydataUnit != null)
                {
                    body["data_unit"] = SourceExpressionConverter.ConvertToken(bodydataUnit);
                    bodypropCount++;
                }

                bodypropCount++;
                body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                if (bodydurationUnit != null)
                {
                    body["duration_unit"] = SourceExpressionConverter.ConvertToken(bodydurationUnit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComputeMemoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ClassificationResponse> Classification([WorkflowExpression] Func<string> bodyclassificationclassificationType = null, [WorkflowExpression] Func<string> bodyclassificationclassificationCode = null, [WorkflowExpression] Func<string> bodyclassificationsource = null, [WorkflowExpression] Func<string> bodyclassificationregion = null, [WorkflowExpression] Func<bool> bodyclassificationregionFallback = null, [WorkflowExpression] Func<string> bodyclassificationyear = null, [WorkflowExpression] Func<string> bodyclassificationlcaActivity = null, [WorkflowExpression] Func<string> bodyclassificationcalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            SourceExpression.Validate(bodyclassificationclassificationType, nameof(bodyclassificationclassificationType), required: false);
            SourceExpression.Validate(bodyclassificationclassificationCode, nameof(bodyclassificationclassificationCode), required: false);
            SourceExpression.Validate(bodyclassificationsource, nameof(bodyclassificationsource), required: false);
            SourceExpression.Validate(bodyclassificationregion, nameof(bodyclassificationregion), required: false);
            SourceExpression.Validate(bodyclassificationregionFallback, nameof(bodyclassificationregionFallback), required: false);
            SourceExpression.Validate(bodyclassificationyear, nameof(bodyclassificationyear), required: false);
            SourceExpression.Validate(bodyclassificationlcaActivity, nameof(bodyclassificationlcaActivity), required: false);
            SourceExpression.Validate(bodyclassificationcalculationMethod, nameof(bodyclassificationcalculationMethod), required: false);
            SourceExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            SourceExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            SourceExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            SourceExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            SourceExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            SourceExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            SourceExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            SourceExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            SourceExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            SourceExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            SourceExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            SourceExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            SourceExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            SourceExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            SourceExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            SourceExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    classificationObject["classification_type"] = SourceExpressionConverter.ConvertToken(bodyclassificationclassificationType);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationclassificationCode != null)
                {
                    classificationObject["classification_code"] = SourceExpressionConverter.ConvertToken(bodyclassificationclassificationCode);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationsource != null)
                {
                    classificationObject["source"] = SourceExpressionConverter.ConvertToken(bodyclassificationsource);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationregion != null)
                {
                    classificationObject["region"] = SourceExpressionConverter.ConvertToken(bodyclassificationregion);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationregionFallback != null)
                {
                    classificationObject["region_fallback"] = SourceExpressionConverter.ConvertToken(bodyclassificationregionFallback);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationyear != null)
                {
                    classificationObject["year"] = SourceExpressionConverter.ConvertToken(bodyclassificationyear);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationlcaActivity != null)
                {
                    classificationObject["lca_activity"] = SourceExpressionConverter.ConvertToken(bodyclassificationlcaActivity);
                    classificationObjectpropCount++;
                }

                if (bodyclassificationcalculationMethod != null)
                {
                    classificationObject["calculation_method"] = SourceExpressionConverter.ConvertToken(bodyclassificationcalculationMethod);
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
                    parametersObject["energy"] = SourceExpressionConverter.ConvertToken(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = SourceExpressionConverter.ConvertToken(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = SourceExpressionConverter.ConvertToken(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = SourceExpressionConverter.ConvertToken(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = SourceExpressionConverter.ConvertToken(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = SourceExpressionConverter.ConvertToken(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = SourceExpressionConverter.ConvertToken(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = SourceExpressionConverter.ConvertToken(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = SourceExpressionConverter.ConvertToken(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = SourceExpressionConverter.ConvertToken(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersweightUnit);
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
                return callPayload;
            }

            return new ApiConnectionAction<ClassificationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomResponse> Custom([WorkflowExpression] Func<string> bodycustomActivitylabel = null, [WorkflowExpression] Func<string> bodycustomActivitysource = null, [WorkflowExpression] Func<string> bodycustomActivityregion = null, [WorkflowExpression] Func<bool> bodycustomActivityregionFallback = null, [WorkflowExpression] Func<string> bodycustomActivityyear = null, [WorkflowExpression] Func<string> bodycustomActivitylcaActivity = null, [WorkflowExpression] Func<string> bodycustomActivitycalculationMethod = null, [WorkflowExpression] Func<int> bodyparametersenergy = null, [WorkflowExpression] Func<string> bodyparametersenergyUnit = null, [WorkflowExpression] Func<int> bodyparametersdata = null, [WorkflowExpression] Func<string> bodyparametersdataUnit = null, [WorkflowExpression] Func<int> bodyparametersdistance = null, [WorkflowExpression] Func<string> bodyparametersdistanceUnit = null, [WorkflowExpression] Func<int> bodyparametersmoney = null, [WorkflowExpression] Func<string> bodyparametersmoneyUnit = null, [WorkflowExpression] Func<int> bodyparametersnumber = null, [WorkflowExpression] Func<int> bodyparameterstime = null, [WorkflowExpression] Func<string> bodyparameterstimeUnit = null, [WorkflowExpression] Func<int> bodyparameterspassengers = null, [WorkflowExpression] Func<int> bodyparametersvolume = null, [WorkflowExpression] Func<string> bodyparametersvolumeUnit = null, [WorkflowExpression] Func<int> bodyparametersweight = null, [WorkflowExpression] Func<string> bodyparametersweightUnit = null)
        {
            SourceExpression.Validate(bodycustomActivitylabel, nameof(bodycustomActivitylabel), required: false);
            SourceExpression.Validate(bodycustomActivitysource, nameof(bodycustomActivitysource), required: false);
            SourceExpression.Validate(bodycustomActivityregion, nameof(bodycustomActivityregion), required: false);
            SourceExpression.Validate(bodycustomActivityregionFallback, nameof(bodycustomActivityregionFallback), required: false);
            SourceExpression.Validate(bodycustomActivityyear, nameof(bodycustomActivityyear), required: false);
            SourceExpression.Validate(bodycustomActivitylcaActivity, nameof(bodycustomActivitylcaActivity), required: false);
            SourceExpression.Validate(bodycustomActivitycalculationMethod, nameof(bodycustomActivitycalculationMethod), required: false);
            SourceExpression.Validate(bodyparametersenergy, nameof(bodyparametersenergy), required: false);
            SourceExpression.Validate(bodyparametersenergyUnit, nameof(bodyparametersenergyUnit), required: false);
            SourceExpression.Validate(bodyparametersdata, nameof(bodyparametersdata), required: false);
            SourceExpression.Validate(bodyparametersdataUnit, nameof(bodyparametersdataUnit), required: false);
            SourceExpression.Validate(bodyparametersdistance, nameof(bodyparametersdistance), required: false);
            SourceExpression.Validate(bodyparametersdistanceUnit, nameof(bodyparametersdistanceUnit), required: false);
            SourceExpression.Validate(bodyparametersmoney, nameof(bodyparametersmoney), required: false);
            SourceExpression.Validate(bodyparametersmoneyUnit, nameof(bodyparametersmoneyUnit), required: false);
            SourceExpression.Validate(bodyparametersnumber, nameof(bodyparametersnumber), required: false);
            SourceExpression.Validate(bodyparameterstime, nameof(bodyparameterstime), required: false);
            SourceExpression.Validate(bodyparameterstimeUnit, nameof(bodyparameterstimeUnit), required: false);
            SourceExpression.Validate(bodyparameterspassengers, nameof(bodyparameterspassengers), required: false);
            SourceExpression.Validate(bodyparametersvolume, nameof(bodyparametersvolume), required: false);
            SourceExpression.Validate(bodyparametersvolumeUnit, nameof(bodyparametersvolumeUnit), required: false);
            SourceExpression.Validate(bodyparametersweight, nameof(bodyparametersweight), required: false);
            SourceExpression.Validate(bodyparametersweightUnit, nameof(bodyparametersweightUnit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    customActivityObject["label"] = SourceExpressionConverter.ConvertToken(bodycustomActivitylabel);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitysource != null)
                {
                    customActivityObject["source"] = SourceExpressionConverter.ConvertToken(bodycustomActivitysource);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityregion != null)
                {
                    customActivityObject["region"] = SourceExpressionConverter.ConvertToken(bodycustomActivityregion);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityregionFallback != null)
                {
                    customActivityObject["region_fallback"] = SourceExpressionConverter.ConvertToken(bodycustomActivityregionFallback);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivityyear != null)
                {
                    customActivityObject["year"] = SourceExpressionConverter.ConvertToken(bodycustomActivityyear);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitylcaActivity != null)
                {
                    customActivityObject["lca_activity"] = SourceExpressionConverter.ConvertToken(bodycustomActivitylcaActivity);
                    customActivityObjectpropCount++;
                }

                if (bodycustomActivitycalculationMethod != null)
                {
                    customActivityObject["calculation_method"] = SourceExpressionConverter.ConvertToken(bodycustomActivitycalculationMethod);
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
                    parametersObject["energy"] = SourceExpressionConverter.ConvertToken(bodyparametersenergy);
                    parametersObjectpropCount++;
                }

                if (bodyparametersenergyUnit != null)
                {
                    parametersObject["energy_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersenergyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdata != null)
                {
                    parametersObject["data"] = SourceExpressionConverter.ConvertToken(bodyparametersdata);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdataUnit != null)
                {
                    parametersObject["data_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdataUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistance != null)
                {
                    parametersObject["distance"] = SourceExpressionConverter.ConvertToken(bodyparametersdistance);
                    parametersObjectpropCount++;
                }

                if (bodyparametersdistanceUnit != null)
                {
                    parametersObject["distance_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersdistanceUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoney != null)
                {
                    parametersObject["money"] = SourceExpressionConverter.ConvertToken(bodyparametersmoney);
                    parametersObjectpropCount++;
                }

                if (bodyparametersmoneyUnit != null)
                {
                    parametersObject["money_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersmoneyUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersnumber != null)
                {
                    parametersObject["number"] = SourceExpressionConverter.ConvertToken(bodyparametersnumber);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstime != null)
                {
                    parametersObject["time"] = SourceExpressionConverter.ConvertToken(bodyparameterstime);
                    parametersObjectpropCount++;
                }

                if (bodyparameterstimeUnit != null)
                {
                    parametersObject["time_unit"] = SourceExpressionConverter.ConvertToken(bodyparameterstimeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspassengers != null)
                {
                    parametersObject["passengers"] = SourceExpressionConverter.ConvertToken(bodyparameterspassengers);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolume != null)
                {
                    parametersObject["volume"] = SourceExpressionConverter.ConvertToken(bodyparametersvolume);
                    parametersObjectpropCount++;
                }

                if (bodyparametersvolumeUnit != null)
                {
                    parametersObject["volume_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersvolumeUnit);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweight != null)
                {
                    parametersObject["weight"] = SourceExpressionConverter.ConvertToken(bodyparametersweight);
                    parametersObjectpropCount++;
                }

                if (bodyparametersweightUnit != null)
                {
                    parametersObject["weight_unit"] = SourceExpressionConverter.ConvertToken(bodyparametersweightUnit);
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
                return callPayload;
            }

            return new ApiConnectionAction<CustomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomBatchResponse> CustomBatch([WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/custom-activities/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CustomBatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FactorsSearchResponse> FactorsSearch([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<string> uuid = null, [WorkflowExpression] Func<string> activityId = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null, [WorkflowExpression] Func<string> unitType = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> resultsPerPage = null)
        {
            SourceExpression.Validate(query, nameof(query), required: false);
            SourceExpression.Validate(uuid, nameof(uuid), required: false);
            SourceExpression.Validate(activityId, nameof(activityId), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            SourceExpression.Validate(unitType, nameof(unitType), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(resultsPerPage, nameof(resultsPerPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (uuid != null)
                    callPayload.Queries["uuid"] = SourceExpressionConverter.ConvertO(uuid);
                if (activityId != null)
                    callPayload.Queries["activity_id"] = SourceExpressionConverter.ConvertO(activityId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                if (unitType != null)
                    callPayload.Queries["unit_type"] = SourceExpressionConverter.ConvertO(unitType);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (resultsPerPage != null)
                    callPayload.Queries["results_per_page"] = SourceExpressionConverter.ConvertO(resultsPerPage);
                return callPayload;
            }

            return new ApiConnectionAction<FactorsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SourcesResponse> Sources([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<SourcesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<YearsResponse> Years([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/years";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<YearsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<RegionsResponse> Regions([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<RegionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CategoriesResponse> Categories([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<CategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SectorsResponse> Sectors([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/sectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<SectorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> LifeCycleActivities([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/lca-activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<LifeCycleActivitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<UnitTypesResponse> UnitTypes([WorkflowExpression] Func<string> sector = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> year = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> lcaActivity = null, [WorkflowExpression] Func<string> calculationMethod = null)
        {
            SourceExpression.Validate(sector, nameof(sector), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(region, nameof(region), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(lcaActivity, nameof(lcaActivity), required: false);
            SourceExpression.Validate(calculationMethod, nameof(calculationMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emission-factors/unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sector != null)
                    callPayload.Queries["sector"] = SourceExpressionConverter.ConvertO(sector);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (lcaActivity != null)
                    callPayload.Queries["lca_activity"] = SourceExpressionConverter.ConvertO(lcaActivity);
                if (calculationMethod != null)
                    callPayload.Queries["calculation_method"] = SourceExpressionConverter.ConvertO(calculationMethod);
                return callPayload;
            }

            return new ApiConnectionAction<UnitTypesResponse>(BuildSourceInput);
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