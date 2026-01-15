//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Climatiqip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClimatiqipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateResponse> EmissionEstimate(Expression<Func<string>> bodyemissionFactoruuid = null, Expression<Func<string>> bodyemissionFactoractivityId = null, Expression<Func<string>> bodyemissionFactorsource = null, Expression<Func<string>> bodyemissionFactorregion = null, Expression<Func<bool>> bodyemissionFactorregionFallback = null, Expression<Func<string>> bodyemissionFactoryear = null, Expression<Func<string>> bodyemissionFactorlcaActivity = null, Expression<Func<string>> bodyemissionFactorcalculationMethod = null, Expression<Func<int>> bodyparametersenergy = null, Expression<Func<string>> bodyparametersenergyUnit = null, Expression<Func<int>> bodyparametersdata = null, Expression<Func<string>> bodyparametersdataUnit = null, Expression<Func<int>> bodyparametersdistance = null, Expression<Func<string>> bodyparametersdistanceUnit = null, Expression<Func<int>> bodyparametersmoney = null, Expression<Func<string>> bodyparametersmoneyUnit = null, Expression<Func<int>> bodyparametersnumber = null, Expression<Func<int>> bodyparameterstime = null, Expression<Func<string>> bodyparameterstimeUnit = null, Expression<Func<int>> bodyparameterspassengers = null, Expression<Func<int>> bodyparametersvolume = null, Expression<Func<string>> bodyparametersvolumeUnit = null, Expression<Func<int>> bodyparametersweight = null, Expression<Func<string>> bodyparametersweightUnit = null)
        {
            var apiCallPath = "/estimate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var emission_factorObject = new JObject();
            var emission_factorObjectpropCount = 0;
            if (bodyemissionFactoruuid != null)
            {
                emission_factorObject["uuid"] = ExpressionConverter.ConvertO(bodyemissionFactoruuid);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactoractivityId != null)
            {
                emission_factorObject["activity_id"] = ExpressionConverter.ConvertO(bodyemissionFactoractivityId);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactorsource != null)
            {
                emission_factorObject["source"] = ExpressionConverter.ConvertO(bodyemissionFactorsource);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactorregion != null)
            {
                emission_factorObject["region"] = ExpressionConverter.ConvertO(bodyemissionFactorregion);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactorregionFallback != null)
            {
                emission_factorObject["region_fallback"] = ExpressionConverter.ConvertO(bodyemissionFactorregionFallback);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactoryear != null)
            {
                emission_factorObject["year"] = ExpressionConverter.ConvertO(bodyemissionFactoryear);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactorlcaActivity != null)
            {
                emission_factorObject["lca_activity"] = ExpressionConverter.ConvertO(bodyemissionFactorlcaActivity);
                emission_factorObjectpropCount++;
            }

            if (bodyemissionFactorcalculationMethod != null)
            {
                emission_factorObject["calculation_method"] = ExpressionConverter.ConvertO(bodyemissionFactorcalculationMethod);
                emission_factorObjectpropCount++;
            }

            if (emission_factorObjectpropCount > 0)
            {
                body["emission_factor"] = emission_factorObject;
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse> EmissionEstimateBulk(Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = "/batch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<EmissionEstimateBulkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<TravelFlightResponse> TravelFlight(Expression<Func<bodylegsInputItem[]>> bodylegs)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FreightFlightResponse> FreightFlight(Expression<Func<bodylegsInputItem[]>> bodylegs)
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
            var apiCallPath = String.Format("/compute/{0}/cpu", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeStorageResponse> ComputeStorage(Expression<Func<string>> provider, Expression<Func<string>> bodyregion, Expression<Func<bodystorageTypeInput>> bodystorageType, Expression<Func<int>> bodydata, Expression<Func<int>> bodyduration, Expression<Func<string>> bodydataUnit = null, Expression<Func<string>> bodydurationUnit = null)
        {
            var apiCallPath = String.Format("/compute/{0}/storage", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMemoryResponse> ComputeMemory(Expression<Func<string>> provider, Expression<Func<string>> bodyregion, Expression<Func<int>> bodydata, Expression<Func<int>> bodyduration, Expression<Func<string>> bodydataUnit = null, Expression<Func<string>> bodydurationUnit = null)
        {
            var apiCallPath = String.Format("/compute/{0}/memory", ExpressionConverter.ConvertWithUrlEncoding(provider, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ClassificationResponse> Classification(Expression<Func<string>> bodyclassificationclassificationType = null, Expression<Func<string>> bodyclassificationclassificationCode = null, Expression<Func<string>> bodyclassificationsource = null, Expression<Func<string>> bodyclassificationregion = null, Expression<Func<bool>> bodyclassificationregionFallback = null, Expression<Func<string>> bodyclassificationyear = null, Expression<Func<string>> bodyclassificationlcaActivity = null, Expression<Func<string>> bodyclassificationcalculationMethod = null, Expression<Func<int>> bodyparametersenergy = null, Expression<Func<string>> bodyparametersenergyUnit = null, Expression<Func<int>> bodyparametersdata = null, Expression<Func<string>> bodyparametersdataUnit = null, Expression<Func<int>> bodyparametersdistance = null, Expression<Func<string>> bodyparametersdistanceUnit = null, Expression<Func<int>> bodyparametersmoney = null, Expression<Func<string>> bodyparametersmoneyUnit = null, Expression<Func<int>> bodyparametersnumber = null, Expression<Func<int>> bodyparameterstime = null, Expression<Func<string>> bodyparameterstimeUnit = null, Expression<Func<int>> bodyparameterspassengers = null, Expression<Func<int>> bodyparametersvolume = null, Expression<Func<string>> bodyparametersvolumeUnit = null, Expression<Func<int>> bodyparametersweight = null, Expression<Func<string>> bodyparametersweightUnit = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FactorsSearchResponse> FactorsSearch(Expression<Func<string>> query = null, Expression<Func<string>> uuid = null, Expression<Func<string>> activityId = null, Expression<Func<string>> id = null, Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null, Expression<Func<string>> unitType = null, Expression<Func<int>> page = null, Expression<Func<int>> resultsPerPage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SourcesResponse> Sources(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<YearsResponse> Years(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<RegionsResponse> Regions(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CategoriesResponse> Categories(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SectorsResponse> Sectors(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse> LifeCycleActivities(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<UnitTypesResponse> UnitTypes(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
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
    using Microsoft.Azure.Workflows.Sdk.Climatiqip;

    public partial class WorkflowManagedActions
    {
        public ClimatiqipActions Climatiqip(string connectionId) => new ClimatiqipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClimatiqipTriggers Climatiqip(string connectionId) => new ClimatiqipTriggers(connectionId);
    }
}