//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LsegfinancialanalytiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<CreateJobResponse, ApiConnectionActionConfiguration> CreateJob(Expression<Func<string>> bodyname, Expression<Func<int>> bodypriority = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            return new DeferredBodyAction<CreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/create-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<JobStatusResponse, ApiConnectionActionConfiguration> JobStatus(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<JobStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/job-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction<JobStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkPyAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<bool>> bodyretrieveOas = null, Expression<Func<bodyoptionModelInput>> bodyoptionModel = null, Expression<Func<bodyvolatilityTypeInput>> bodyvolatilityType = null, Expression<Func<bool>> bodyprepayDuration = null, Expression<Func<bool>> bodyvolatilityDuration = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_bodyrequestId = WorkflowExpression.Compile(bodyrequestId, nameof(bodyrequestId), required: true);
            var __workflow_bodycurveType = WorkflowExpression.Compile(bodycurveType, nameof(bodycurveType), required: true);
            var __workflow_bodypricingDate = WorkflowExpression.Compile(bodypricingDate, nameof(bodypricingDate), required: true);
            var __workflow_bodysettlementType = WorkflowExpression.Compile(bodysettlementType, nameof(bodysettlementType), required: true);
            var __workflow_bodyprepayType = WorkflowExpression.Compile(bodyprepayType, nameof(bodyprepayType), required: true);
            var __workflow_bodycalculatePartialDurations4pt = WorkflowExpression.Compile(bodycalculatePartialDurations4pt, nameof(bodycalculatePartialDurations4pt), required: true);
            var __workflow_bodycalculatePartialDurations7pt = WorkflowExpression.Compile(bodycalculatePartialDurations7pt, nameof(bodycalculatePartialDurations7pt), required: true);
            var __workflow_bodyretrieveModelProjections = WorkflowExpression.Compile(bodyretrieveModelProjections, nameof(bodyretrieveModelProjections), required: true);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodyprepayRate = WorkflowExpression.Compile(bodyprepayRate, nameof(bodyprepayRate), required: false);
            var __workflow_bodyretrieveOas = WorkflowExpression.Compile(bodyretrieveOas, nameof(bodyretrieveOas), required: false);
            var __workflow_bodyoptionModel = WorkflowExpression.Compile(bodyoptionModel, nameof(bodyoptionModel), required: false);
            var __workflow_bodyvolatilityType = WorkflowExpression.Compile(bodyvolatilityType, nameof(bodyvolatilityType), required: false);
            var __workflow_bodyprepayDuration = WorkflowExpression.Compile(bodyprepayDuration, nameof(bodyprepayDuration), required: false);
            var __workflow_bodyvolatilityDuration = WorkflowExpression.Compile(bodyvolatilityDuration, nameof(bodyvolatilityDuration), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = ExpressionConverter.ConvertO(__workflow_bodyrequestId);
                bodypropCount++;
                body["curveType"] = ExpressionConverter.ConvertO(__workflow_bodycurveType);
                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pricingDate"] = ExpressionConverter.ConvertO(__workflow_bodypricingDate);
                bodypropCount++;
                body["settlementType"] = ExpressionConverter.ConvertO(__workflow_bodysettlementType);
                bodypropCount++;
                body["prepayType"] = ExpressionConverter.ConvertO(__workflow_bodyprepayType);
                if (__workflow_bodyprepayRate != null)
                {
                    body["prepayRate"] = ExpressionConverter.ConvertO(__workflow_bodyprepayRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculatePartialDurations4pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations4pt);
                bodypropCount++;
                body["calculatePartialDurations7pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations7pt);
                bodypropCount++;
                body["retrieveModelProjections"] = ExpressionConverter.ConvertO(__workflow_bodyretrieveModelProjections);
                if (__workflow_bodyretrieveOas != null)
                {
                    body["retrieveOas"] = ExpressionConverter.ConvertO(__workflow_bodyretrieveOas);
                    bodypropCount++;
                }

                if (__workflow_bodyoptionModel != null)
                {
                    body["optionModel"] = ExpressionConverter.ConvertO(__workflow_bodyoptionModel);
                    bodypropCount++;
                }

                if (__workflow_bodyvolatilityType != null)
                {
                    if (__workflow_bodyvolatilityType != null)
                    {
                        body["volatilityType"] = ExpressionConverter.ConvertO(__workflow_bodyvolatilityType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["volatilityType"] = "Default";
                    bodypropCount++;
                }

                if (__workflow_bodyprepayDuration != null)
                {
                    if (__workflow_bodyprepayDuration != null)
                    {
                        body["prepayDuration"] = ExpressionConverter.ConvertO(__workflow_bodyprepayDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["prepayDuration"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyvolatilityDuration != null)
                {
                    if (__workflow_bodyvolatilityDuration != null)
                    {
                        body["volatilityDuration"] = ExpressionConverter.ConvertO(__workflow_bodyvolatilityDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["volatilityDuration"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkIndicData(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_bodyrequestId = WorkflowExpression.Compile(bodyrequestId, nameof(bodyrequestId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = ExpressionConverter.ConvertO(__workflow_bodyrequestId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse, ApiConnectionActionConfiguration> UploadSecuritiesList(Expression<Func<string>> jobName, Expression<Func<string>> bodysecuritiesList, Expression<Func<string>> bodyudiIdentifiers = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_bodysecuritiesList = WorkflowExpression.Compile(bodysecuritiesList, nameof(bodysecuritiesList), required: true);
            var __workflow_bodyudiIdentifiers = WorkflowExpression.Compile(bodyudiIdentifiers, nameof(bodyudiIdentifiers), required: false);
            return new DeferredBodyAction<UploadSecuritiesListDefaultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/upload-securities-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["securitiesList"] = ExpressionConverter.ConvertO(__workflow_bodysecuritiesList);
                if (__workflow_bodyudiIdentifiers != null)
                {
                    body["udiIdentifiers"] = ExpressionConverter.ConvertO(__workflow_bodyudiIdentifiers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadSecuritiesListDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<CreateUdisResponse, ApiConnectionActionConfiguration> CreateUdis(Expression<Func<string>> jobName, Expression<Func<string>> bodyuserInstruments)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_bodyuserInstruments = WorkflowExpression.Compile(bodyuserInstruments, nameof(bodyuserInstruments), required: true);
            return new DeferredBodyAction<CreateUdisResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/create-udis";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userInstruments"] = ExpressionConverter.ConvertO(__workflow_bodyuserInstruments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUdisResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseJob(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/close-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse, ApiConnectionActionConfiguration> RetrieveBulkResults(Expression<Func<string>> jobName, Expression<Func<outputFormatInput>> outputFormat, Expression<Func<string>> bodypayload)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_outputFormat = WorkflowExpression.Compile(outputFormat, nameof(outputFormat), required: true);
            var __workflow_bodypayload = WorkflowExpression.Compile(bodypayload, nameof(bodypayload), required: true);
            return new DeferredBodyAction<RetrieveBulkResultsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Output format"] = ExpressionConverter.Convert(__workflow_outputFormat);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = ExpressionConverter.ConvertO(__workflow_bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RetrieveBulkResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<IndicDataResponse, ApiConnectionActionConfiguration> IndicData(Expression<Func<string>> bodyidentifier, Expression<Func<bodyidTypeInput>> bodyidType = null)
        {
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: true);
            var __workflow_bodyidType = WorkflowExpression.Compile(bodyidType, nameof(bodyidType), required: false);
            return new DeferredBodyAction<IndicDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                if (__workflow_bodyidType != null)
                {
                    body["idType"] = ExpressionConverter.ConvertO(__workflow_bodyidType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IndicDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<PyAnalyticResponse, ApiConnectionActionConfiguration> PyAnalytics(Expression<Func<string>> bodyidentifier, Expression<Func<string>> bodylevel, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodyvolatilityTypeInput>> bodyvolatilityType, Expression<Func<bodyidTypeInput>> bodyidType = null, Expression<Func<bool>> bodyretrieveOas = null, Expression<Func<bodyoptionModelInput>> bodyoptionModel = null, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<bool>> bodyprepayDuration = null, Expression<Func<bool>> bodyvolatilityDuration = null)
        {
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: true);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: true);
            var __workflow_bodycurveType = WorkflowExpression.Compile(bodycurveType, nameof(bodycurveType), required: true);
            var __workflow_bodypricingDate = WorkflowExpression.Compile(bodypricingDate, nameof(bodypricingDate), required: true);
            var __workflow_bodysettlementType = WorkflowExpression.Compile(bodysettlementType, nameof(bodysettlementType), required: true);
            var __workflow_bodyprepayType = WorkflowExpression.Compile(bodyprepayType, nameof(bodyprepayType), required: true);
            var __workflow_bodycalculatePartialDurations4pt = WorkflowExpression.Compile(bodycalculatePartialDurations4pt, nameof(bodycalculatePartialDurations4pt), required: true);
            var __workflow_bodycalculatePartialDurations7pt = WorkflowExpression.Compile(bodycalculatePartialDurations7pt, nameof(bodycalculatePartialDurations7pt), required: true);
            var __workflow_bodyretrieveModelProjections = WorkflowExpression.Compile(bodyretrieveModelProjections, nameof(bodyretrieveModelProjections), required: true);
            var __workflow_bodyvolatilityType = WorkflowExpression.Compile(bodyvolatilityType, nameof(bodyvolatilityType), required: true);
            var __workflow_bodyidType = WorkflowExpression.Compile(bodyidType, nameof(bodyidType), required: false);
            var __workflow_bodyretrieveOas = WorkflowExpression.Compile(bodyretrieveOas, nameof(bodyretrieveOas), required: false);
            var __workflow_bodyoptionModel = WorkflowExpression.Compile(bodyoptionModel, nameof(bodyoptionModel), required: false);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodyprepayRate = WorkflowExpression.Compile(bodyprepayRate, nameof(bodyprepayRate), required: false);
            var __workflow_bodyprepayDuration = WorkflowExpression.Compile(bodyprepayDuration, nameof(bodyprepayDuration), required: false);
            var __workflow_bodyvolatilityDuration = WorkflowExpression.Compile(bodyvolatilityDuration, nameof(bodyvolatilityDuration), required: false);
            return new DeferredBodyAction<PyAnalyticResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v1/py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                if (__workflow_bodyidType != null)
                {
                    body["idType"] = ExpressionConverter.ConvertO(__workflow_bodyidType);
                    bodypropCount++;
                }

                bodypropCount++;
                body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                if (__workflow_bodyretrieveOas != null)
                {
                    body["retrieveOas"] = ExpressionConverter.ConvertO(__workflow_bodyretrieveOas);
                    bodypropCount++;
                }

                if (__workflow_bodyoptionModel != null)
                {
                    body["optionModel"] = ExpressionConverter.ConvertO(__workflow_bodyoptionModel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["curveType"] = ExpressionConverter.ConvertO(__workflow_bodycurveType);
                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pricingDate"] = ExpressionConverter.ConvertO(__workflow_bodypricingDate);
                bodypropCount++;
                body["settlementType"] = ExpressionConverter.ConvertO(__workflow_bodysettlementType);
                bodypropCount++;
                body["prepayType"] = ExpressionConverter.ConvertO(__workflow_bodyprepayType);
                if (__workflow_bodyprepayRate != null)
                {
                    body["prepayRate"] = ExpressionConverter.ConvertO(__workflow_bodyprepayRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculatePartialDurations4pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations4pt);
                bodypropCount++;
                body["calculatePartialDurations7pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations7pt);
                bodypropCount++;
                body["retrieveModelProjections"] = ExpressionConverter.ConvertO(__workflow_bodyretrieveModelProjections);
                bodypropCount++;
                body["volatilityType"] = ExpressionConverter.ConvertO(__workflow_bodyvolatilityType);
                if (__workflow_bodyprepayDuration != null)
                {
                    if (__workflow_bodyprepayDuration != null)
                    {
                        body["prepayDuration"] = ExpressionConverter.ConvertO(__workflow_bodyprepayDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["prepayDuration"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyvolatilityDuration != null)
                {
                    if (__workflow_bodyvolatilityDuration != null)
                    {
                        body["volatilityDuration"] = ExpressionConverter.ConvertO(__workflow_bodyvolatilityDuration);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["volatilityDuration"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PyAnalyticResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BulkScenarioAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodyvolatilityTypeInput>> bodyvolatilityType, Expression<Func<bool>> bodycalculateHorizonEffectiveMeasures, Expression<Func<bodyhorizonPYMethodInput>> bodyhorizonPYMethod, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<int>> bodyhorizonMonths = null, Expression<Func<int>> bodyhorizonDays = null, Expression<Func<bool>> bodycalculateHorizonOptionMeasures = null, Expression<Func<bool>> bodyuseForwardIndex = null, Expression<Func<bool>> bodyimmediateForwardShift = null, Expression<Func<bool>> bodyscenarioCashflow = null, Expression<Func<bool>> bodycalcPrepaySensitivity = null, Expression<Func<ScenarioV3[]>> bodyscenarios = null)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_bodyrequestId = WorkflowExpression.Compile(bodyrequestId, nameof(bodyrequestId), required: true);
            var __workflow_bodycurveType = WorkflowExpression.Compile(bodycurveType, nameof(bodycurveType), required: true);
            var __workflow_bodypricingDate = WorkflowExpression.Compile(bodypricingDate, nameof(bodypricingDate), required: true);
            var __workflow_bodysettlementType = WorkflowExpression.Compile(bodysettlementType, nameof(bodysettlementType), required: true);
            var __workflow_bodyprepayType = WorkflowExpression.Compile(bodyprepayType, nameof(bodyprepayType), required: true);
            var __workflow_bodycalculatePartialDurations4pt = WorkflowExpression.Compile(bodycalculatePartialDurations4pt, nameof(bodycalculatePartialDurations4pt), required: true);
            var __workflow_bodycalculatePartialDurations7pt = WorkflowExpression.Compile(bodycalculatePartialDurations7pt, nameof(bodycalculatePartialDurations7pt), required: true);
            var __workflow_bodyretrieveModelProjections = WorkflowExpression.Compile(bodyretrieveModelProjections, nameof(bodyretrieveModelProjections), required: true);
            var __workflow_bodyvolatilityType = WorkflowExpression.Compile(bodyvolatilityType, nameof(bodyvolatilityType), required: true);
            var __workflow_bodycalculateHorizonEffectiveMeasures = WorkflowExpression.Compile(bodycalculateHorizonEffectiveMeasures, nameof(bodycalculateHorizonEffectiveMeasures), required: true);
            var __workflow_bodyhorizonPYMethod = WorkflowExpression.Compile(bodyhorizonPYMethod, nameof(bodyhorizonPYMethod), required: true);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodyprepayRate = WorkflowExpression.Compile(bodyprepayRate, nameof(bodyprepayRate), required: false);
            var __workflow_bodyhorizonMonths = WorkflowExpression.Compile(bodyhorizonMonths, nameof(bodyhorizonMonths), required: false);
            var __workflow_bodyhorizonDays = WorkflowExpression.Compile(bodyhorizonDays, nameof(bodyhorizonDays), required: false);
            var __workflow_bodycalculateHorizonOptionMeasures = WorkflowExpression.Compile(bodycalculateHorizonOptionMeasures, nameof(bodycalculateHorizonOptionMeasures), required: false);
            var __workflow_bodyuseForwardIndex = WorkflowExpression.Compile(bodyuseForwardIndex, nameof(bodyuseForwardIndex), required: false);
            var __workflow_bodyimmediateForwardShift = WorkflowExpression.Compile(bodyimmediateForwardShift, nameof(bodyimmediateForwardShift), required: false);
            var __workflow_bodyscenarioCashflow = WorkflowExpression.Compile(bodyscenarioCashflow, nameof(bodyscenarioCashflow), required: false);
            var __workflow_bodycalcPrepaySensitivity = WorkflowExpression.Compile(bodycalcPrepaySensitivity, nameof(bodycalcPrepaySensitivity), required: false);
            var __workflow_bodyscenarios = WorkflowExpression.Compile(bodyscenarios, nameof(bodyscenarios), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-platform/v3/bulk-scenario-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(__workflow_batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = ExpressionConverter.ConvertO(__workflow_bodyrequestId);
                bodypropCount++;
                body["curveType"] = ExpressionConverter.ConvertO(__workflow_bodycurveType);
                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pricingDate"] = ExpressionConverter.ConvertO(__workflow_bodypricingDate);
                bodypropCount++;
                body["settlementType"] = ExpressionConverter.ConvertO(__workflow_bodysettlementType);
                bodypropCount++;
                body["prepayType"] = ExpressionConverter.ConvertO(__workflow_bodyprepayType);
                if (__workflow_bodyprepayRate != null)
                {
                    body["prepayRate"] = ExpressionConverter.ConvertO(__workflow_bodyprepayRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculatePartialDurations4pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations4pt);
                bodypropCount++;
                body["calculatePartialDurations7pt"] = ExpressionConverter.ConvertO(__workflow_bodycalculatePartialDurations7pt);
                bodypropCount++;
                body["retrieveModelProjections"] = ExpressionConverter.ConvertO(__workflow_bodyretrieveModelProjections);
                bodypropCount++;
                body["volatilityType"] = ExpressionConverter.ConvertO(__workflow_bodyvolatilityType);
                if (__workflow_bodyhorizonMonths != null)
                {
                    body["horizonMonths"] = ExpressionConverter.ConvertO(__workflow_bodyhorizonMonths);
                    bodypropCount++;
                }

                if (__workflow_bodyhorizonDays != null)
                {
                    body["horizonDays"] = ExpressionConverter.ConvertO(__workflow_bodyhorizonDays);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculateHorizonEffectiveMeasures"] = ExpressionConverter.ConvertO(__workflow_bodycalculateHorizonEffectiveMeasures);
                if (__workflow_bodycalculateHorizonOptionMeasures != null)
                {
                    if (__workflow_bodycalculateHorizonOptionMeasures != null)
                    {
                        body["calculateHorizonOptionMeasures"] = ExpressionConverter.ConvertO(__workflow_bodycalculateHorizonOptionMeasures);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["calculateHorizonOptionMeasures"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyuseForwardIndex != null)
                {
                    if (__workflow_bodyuseForwardIndex != null)
                    {
                        body["useForwardIndex"] = ExpressionConverter.ConvertO(__workflow_bodyuseForwardIndex);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["useForwardIndex"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyimmediateForwardShift != null)
                {
                    if (__workflow_bodyimmediateForwardShift != null)
                    {
                        body["immediateForwardShift"] = ExpressionConverter.ConvertO(__workflow_bodyimmediateForwardShift);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["immediateForwardShift"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyscenarioCashflow != null)
                {
                    if (__workflow_bodyscenarioCashflow != null)
                    {
                        body["scenarioCashflow"] = ExpressionConverter.ConvertO(__workflow_bodyscenarioCashflow);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["scenarioCashflow"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodycalcPrepaySensitivity != null)
                {
                    if (__workflow_bodycalcPrepaySensitivity != null)
                    {
                        body["calcPrepaySensitivity"] = ExpressionConverter.ConvertO(__workflow_bodycalcPrepaySensitivity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["calcPrepaySensitivity"] = false;
                    bodypropCount++;
                }

                bodypropCount++;
                body["horizonPYMethod"] = ExpressionConverter.ConvertO(__workflow_bodyhorizonPYMethod);
                if (__workflow_bodyscenarios != null)
                {
                    body["Scenarios"] = ExpressionConverter.ConvertO(__workflow_bodyscenarios);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LsegfinancialanalytiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateJobResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class JobStatusResponse
    {
        [JsonProperty("exitStatus")]
        public string ExitStatus { get; set; }

        [JsonProperty("onHold")]
        public bool OnHold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurveTypeInput
    {
        [EnumMember(Value = "On The Run Curve")]
        OnTheRunCurve,
        [EnumMember(Value = "Treasury Model Curve")]
        TreasuryModelCurve,
        [EnumMember(Value = "Swap Curve")]
        SwapCurve,
        [EnumMember(Value = "Swap RFR Curve")]
        SwapRFRCurve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyprepayTypeInput
    {
        Default,
        Model,
        CPR,
        PSA,
        PreExpModel
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurrencyInput
    {
        USD,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionModelInput
    {
        OAS,
        OASEDUR,
        YCMARGIN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvolatilityTypeInput
    {
        MarketWSkew,
        LMMSOFR,
        LMMSOFRFLAT,
        [EnumMember(Value = "default")]
        Default
    }

    public class UploadSecuritiesListDefaultResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public class CreateUdisResponse
    {
        [JsonProperty("udiIdentifiers")]
        public string UdiIdentifiers { get; set; }
    }

    public class RetrieveBulkResultsResponse
    {
        [JsonProperty("results")]
        public string Results { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum outputFormatInput
    {
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "json")]
        Json
    }

    public class IndicDataResponse
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("cfi")]
        public string Cfi { get; set; }

        [JsonProperty("ric")]
        public string Ric { get; set; }

        [JsonProperty("wkn")]
        public string Wkn { get; set; }

        [JsonProperty("figi")]
        public string Figi { get; set; }

        [JsonProperty("frtbSector")]
        public string FrtbSector { get; set; }

        [JsonProperty("frtbRiskWeight")]
        public double FrtbRiskWeight { get; set; }

        [JsonProperty("frtbBucketNumber")]
        public int FrtbBucketNumber { get; set; }

        [JsonProperty("frtbCreditQuality")]
        public string FrtbCreditQuality { get; set; }

        [JsonProperty("frtbRiskClassification")]
        public string FrtbRiskClassification { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("moody")]
        public MoodyRating[] Moody { get; set; }

        [JsonProperty("permId")]
        public string PermId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("putFlag")]
        public bool PutFlag { get; set; }

        [JsonProperty("callFlag")]
        public bool CallFlag { get; set; }

        [JsonProperty("cobsCode")]
        public string CobsCode { get; set; }

        [JsonProperty("country2")]
        public string Country2 { get; set; }

        [JsonProperty("country3")]
        public string Country3 { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dayCount")]
        public string DayCount { get; set; }

        [JsonProperty("glicCode")]
        public string GlicCode { get; set; }

        [JsonProperty("regSFlag")]
        public bool RegSFlag { get; set; }

        [JsonProperty("sinkFlag")]
        public bool SinkFlag { get; set; }

        [JsonProperty("callDelay")]
        public int CallDelay { get; set; }

        [JsonProperty("cmaTicker")]
        public string CmaTicker { get; set; }

        [JsonProperty("datedDate")]
        public string DatedDate { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("p144AFlag")]
        public bool P144AFlag { get; set; }

        [JsonProperty("extendFlag")]
        public string ExtendFlag { get; set; }

        [JsonProperty("isoCountry")]
        public string IsoCountry { get; set; }

        [JsonProperty("issuePrice")]
        public double IssuePrice { get; set; }

        [JsonProperty("issueYield")]
        public double IssueYield { get; set; }

        [JsonProperty("issuerName")]
        public string IssuerName { get; set; }

        [JsonProperty("issuerNameLanguage")]
        public string IssuerNameLanguage { get; set; }

        [JsonProperty("marketType")]
        public string MarketType { get; set; }

        [JsonProperty("securityId")]
        public string SecurityId { get; set; }

        [JsonProperty("vPointType")]
        public string VPointType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("esgBondFlag")]
        public bool EsgBondFlag { get; set; }

        [JsonProperty("indexRating")]
        public string IndexRating { get; set; }

        [JsonProperty("issueAmount")]
        public double IssueAmount { get; set; }

        [JsonProperty("issueSpread")]
        public double IssueSpread { get; set; }

        [JsonProperty("lowerRating")]
        public string LowerRating { get; set; }

        [JsonProperty("paymentFreq")]
        public int PaymentFreq { get; set; }

        [JsonProperty("securedFlag")]
        public bool SecuredFlag { get; set; }

        [JsonProperty("tierCapital")]
        public string TierCapital { get; set; }

        [JsonProperty("deliveryFlag")]
        public string DeliveryFlag { get; set; }

        [JsonProperty("euroCallFlag")]
        public bool EuroCallFlag { get; set; }

        [JsonProperty("indexCountry")]
        public string IndexCountry { get; set; }

        [JsonProperty("industryCode")]
        public string IndustryCode { get; set; }

        [JsonProperty("issuerTicker")]
        public string IssuerTicker { get; set; }

        [JsonProperty("lowestRating")]
        public string LowestRating { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("middleRating")]
        public string MiddleRating { get; set; }

        [JsonProperty("minimumPiece")]
        public double MinimumPiece { get; set; }

        [JsonProperty("nextCallDate")]
        public string NextCallDate { get; set; }

        [JsonProperty("parentTicker")]
        public string ParentTicker { get; set; }

        [JsonProperty("securityType")]
        public string SecurityType { get; set; }

        [JsonProperty("chapter11Flag")]
        public bool Chapter11Flag { get; set; }

        [JsonProperty("currentCoupon")]
        public double CurrentCoupon { get; set; }

        [JsonProperty("debtClassCode")]
        public string DebtClassCode { get; set; }

        [JsonProperty("greenBondFlag")]
        public bool GreenBondFlag { get; set; }

        [JsonProperty("highestRating")]
        public string HighestRating { get; set; }

        [JsonProperty("inDefaultFlag")]
        public bool InDefaultFlag { get; set; }

        [JsonProperty("incomeCountry")]
        public string IncomeCountry { get; set; }

        [JsonProperty("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonProperty("makeWholeFlag")]
        public bool MakeWholeFlag { get; set; }

        [JsonProperty("nextCallPrice")]
        public double NextCallPrice { get; set; }

        [JsonProperty("seniorityType")]
        public string SeniorityType { get; set; }

        [JsonProperty("assetClassCode")]
        public string AssetClassCode { get; set; }

        [JsonProperty("cgmiSectorCode")]
        public string CgmiSectorCode { get; set; }

        [JsonProperty("incomeCountry3")]
        public string IncomeCountry3 { get; set; }

        [JsonProperty("instrumentType")]
        public string InstrumentType { get; set; }

        [JsonProperty("issueBenchmark")]
        public double IssueBenchmark { get; set; }

        [JsonProperty("issuerCountry2")]
        public string IssuerCountry2 { get; set; }

        [JsonProperty("issuerCountry3")]
        public string IssuerCountry3 { get; set; }

        [JsonProperty("lowestRatingNf")]
        public string LowestRatingNf { get; set; }

        [JsonProperty("risingStarFlag")]
        public bool RisingStarFlag { get; set; }

        [JsonProperty("vPointCategory")]
        public string VPointCategory { get; set; }

        [JsonProperty("bloombergTicker")]
        public string BloombergTicker { get; set; }

        [JsonProperty("fallenAngelFlag")]
        public bool FallenAngelFlag { get; set; }

        [JsonProperty("firstCouponDate")]
        public string FirstCouponDate { get; set; }

        [JsonProperty("industrySubCode")]
        public string IndustrySubCode { get; set; }

        [JsonProperty("outstandingDate")]
        public string OutstandingDate { get; set; }

        [JsonProperty("redemptionValue")]
        public double RedemptionValue { get; set; }

        [JsonProperty("restrictionDate")]
        public string RestrictionDate { get; set; }

        [JsonProperty("securitySubType")]
        public string SecuritySubType { get; set; }

        [JsonProperty("tradeConvention")]
        public string TradeConvention { get; set; }

        [JsonProperty("securityCalcType")]
        public string SecurityCalcType { get; set; }

        [JsonProperty("assetClassSubCode")]
        public string AssetClassSubCode { get; set; }

        [JsonProperty("esgEnvScore")]
        public double EsgEnvScore { get; set; }

        [JsonProperty("esgGovScore")]
        public double EsgGovScore { get; set; }

        [JsonProperty("esgSocScore")]
        public double EsgSocScore { get; set; }

        [JsonProperty("esgGlobalScore")]
        public double EsgGlobalScore { get; set; }

        [JsonProperty("esgCommunityScore")]
        public double EsgCommunityScore { get; set; }

        [JsonProperty("esgEmissionsScore")]
        public double EsgEmissionsScore { get; set; }

        [JsonProperty("esgWorkforceScore")]
        public double EsgWorkforceScore { get; set; }

        [JsonProperty("esgInnovationScore")]
        public double EsgInnovationScore { get; set; }

        [JsonProperty("esgManagementScore")]
        public double EsgManagementScore { get; set; }

        [JsonProperty("esgCsrStrategyScore")]
        public double EsgCsrStrategyScore { get; set; }

        [JsonProperty("esgHumanRightsScore")]
        public double EsgHumanRightsScore { get; set; }

        [JsonProperty("esgResourceUseScore")]
        public double EsgResourceUseScore { get; set; }

        [JsonProperty("esgShareholdersScore")]
        public double EsgShareholdersScore { get; set; }

        [JsonProperty("esgProductResponsibilityScore")]
        public double EsgProductResponsibilityScore { get; set; }

        [JsonProperty("finalMaturityDate")]
        public string FinalMaturityDate { get; set; }

        [JsonProperty("modifiedTimeStamp")]
        public string ModifiedTimeStamp { get; set; }

        [JsonProperty("outstandingAmount")]
        public double OutstandingAmount { get; set; }

        [JsonProperty("parentDescription")]
        public string ParentDescription { get; set; }

        [JsonProperty("issuerLowestRating")]
        public string IssuerLowestRating { get; set; }

        [JsonProperty("issuerMiddleRating")]
        public string IssuerMiddleRating { get; set; }

        [JsonProperty("dataUnderwriterList")]
        public UnderwriterItem[] DataUnderwriterList { get; set; }

        [JsonProperty("industryDescription")]
        public string IndustryDescription { get; set; }

        [JsonProperty("issuerHighestRating")]
        public string IssuerHighestRating { get; set; }

        [JsonProperty("leveragedBuyoutFlag")]
        public bool LeveragedBuyoutFlag { get; set; }

        [JsonProperty("clearingOrganization")]
        public string ClearingOrganization { get; set; }

        [JsonProperty("currentHighYieldFlag")]
        public bool CurrentHighYieldFlag { get; set; }

        [JsonProperty("dataCallScheduleList")]
        public CallScheduleItem[] DataCallScheduleList { get; set; }

        [JsonProperty("debtClassDescription")]
        public string DebtClassDescription { get; set; }

        [JsonProperty("privatePlacementFlag")]
        public bool PrivatePlacementFlag { get; set; }

        [JsonProperty("cgmiSectorDescription")]
        public string CgmiSectorDescription { get; set; }

        [JsonProperty("originalHighYieldFlag")]
        public bool OriginalHighYieldFlag { get; set; }

        [JsonProperty("americanEuropeanOption")]
        public string AmericanEuropeanOption { get; set; }

        [JsonProperty("defaultHorizonPyMethod")]
        public string DefaultHorizonPyMethod { get; set; }

        [JsonProperty("industrySubDescription")]
        public string IndustrySubDescription { get; set; }

        [JsonProperty("assetClassSubDescription")]
        public string AssetClassSubDescription { get; set; }
    }

    public class MoodyRating
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class UnderwriterItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("split")]
        public double Split { get; set; }
    }

    public class CallScheduleItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyidTypeInput
    {
        [EnumMember(Value = "SecurityIDEntry")]
        SecurityIdEntry,
        [EnumMember(Value = "SecurityID")]
        SecurityId,
        CUSIP,
        ISIN,
        REGSISIN,
        SEDOL,
        Identifier,
        ChinaInterbankCode,
        ShanghaiExchangeCode,
        ShenzhenExchangeCode,
        [EnumMember(Value = "MXTickerID")]
        MXTickerId
    }

    public class PyAnalyticResponse
    {
        [JsonProperty("oas")]
        public double Oas { get; set; }

        [JsonProperty("wal")]
        public double Wal { get; set; }

        [JsonProperty("dv01")]
        public double Dv01 { get; set; }

        [JsonProperty("isin")]
        public string Isin { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("yield")]
        public double Yield { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("cdYield")]
        public double CdYield { get; set; }

        [JsonProperty("cmmType")]
        public int CmmType { get; set; }

        [JsonProperty("pyLevel")]
        public string PyLevel { get; set; }

        [JsonProperty("zSpread")]
        public double ZSpread { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("ziSpread")]
        public double ZiSpread { get; set; }

        [JsonProperty("znSpread")]
        public double ZnSpread { get; set; }

        [JsonProperty("benchmark")]
        public string Benchmark { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("convexity")]
        public double Convexity { get; set; }

        [JsonProperty("curveDate")]
        public string CurveDate { get; set; }

        [JsonProperty("curveType")]
        public string CurveType { get; set; }

        [JsonProperty("fullPrice")]
        public double FullPrice { get; set; }

        [JsonProperty("modelCode")]
        public int ModelCode { get; set; }

        [JsonProperty("creditLoss")]
        public double CreditLoss { get; set; }

        [JsonProperty("prepayRate")]
        public double PrepayRate { get; set; }

        [JsonProperty("prepayType")]
        public string PrepayType { get; set; }

        [JsonProperty("securityID")]
        public string SecurityId { get; set; }

        [JsonProperty("spreadDV01")]
        public double SpreadDV01 { get; set; }

        [JsonProperty("tsyCurveID")]
        public string TsyCurveId { get; set; }

        [JsonProperty("accruedDays")]
        public int AccruedDays { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("grossSpread")]
        public double GrossSpread { get; set; }

        [JsonProperty("pricingDate")]
        public string PricingDate { get; set; }

        [JsonProperty("swapCurveID")]
        public string SwapCurveId { get; set; }

        [JsonProperty("currentYield")]
        public double CurrentYield { get; set; }

        [JsonProperty("effectiveWAL")]
        public double EffectiveWAL { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("nextCallDate")]
        public string NextCallDate { get; set; }

        [JsonProperty("securityType")]
        public string SecurityType { get; set; }

        [JsonProperty("staticSpread")]
        public double StaticSpread { get; set; }

        [JsonProperty("volModelType")]
        public string VolModelType { get; set; }

        [JsonProperty("yieldToWorst")]
        public double YieldToWorst { get; set; }

        [JsonProperty("convexityCost")]
        public double ConvexityCost { get; set; }

        [JsonProperty("currentCoupon")]
        public double CurrentCoupon { get; set; }

        [JsonProperty("effectiveCV01")]
        public double EffectiveCV01 { get; set; }

        [JsonProperty("effectiveDV01")]
        public double EffectiveDV01 { get; set; }

        [JsonProperty("cmoProcessTime")]
        public int CmoProcessTime { get; set; }

        [JsonProperty("effectiveYield")]
        public double EffectiveYield { get; set; }

        [JsonProperty("marketSettings")]
        public MarketSettings MarketSettings { get; set; }

        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }

        [JsonProperty("spreadDuration")]
        public double SpreadDuration { get; set; }

        [JsonProperty("accruedInterest")]
        public double AccruedInterest { get; set; }

        [JsonProperty("annualizedYield")]
        public double AnnualizedYield { get; set; }

        [JsonProperty("compoundingFreq")]
        public int CompoundingFreq { get; set; }

        [JsonProperty("convexityEffect")]
        public double ConvexityEffect { get; set; }

        [JsonProperty("dataPpmProjList")]
        public DataPpmProjList[] DataPpmProjList { get; set; }

        [JsonProperty("forwardMeasures")]
        public ForwardMeasures ForwardMeasures { get; set; }

        [JsonProperty("nextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [JsonProperty("spreadConvexity")]
        public double SpreadConvexity { get; set; }

        [JsonProperty("yearsToMaturity")]
        public double YearsToMaturity { get; set; }

        [JsonProperty("yieldToNextCall")]
        public double YieldToNextCall { get; set; }

        [JsonProperty("economicExposure")]
        public double EconomicExposure { get; set; }

        [JsonProperty("macaulayDuration")]
        public double MacaulayDuration { get; set; }

        [JsonProperty("settleDateFactor")]
        public double SettleDateFactor { get; set; }

        [JsonProperty("spreadToActCurve")]
        public double SpreadToActCurve { get; set; }

        [JsonProperty("spreadToTsyCurve")]
        public double SpreadToTsyCurve { get; set; }

        [JsonProperty("yieldCurveMargin")]
        public double YieldCurveMargin { get; set; }

        [JsonProperty("yieldToWorstCall")]
        public double YieldToWorstCall { get; set; }

        [JsonProperty("effectiveDuration")]
        public double EffectiveDuration { get; set; }

        [JsonProperty("macaulayConvexity")]
        public double MacaulayConvexity { get; set; }

        [JsonProperty("spreadToBenchmark")]
        public double SpreadToBenchmark { get; set; }

        [JsonProperty("spreadToSwapCurve")]
        public double SpreadToSwapCurve { get; set; }

        [JsonProperty("spreadToWorstCall")]
        public double SpreadToWorstCall { get; set; }

        [JsonProperty("currentAccrualDate")]
        public string CurrentAccrualDate { get; set; }

        [JsonProperty("effectiveConvexity")]
        public double EffectiveConvexity { get; set; }

        [JsonProperty("moatsCurrentCoupon")]
        public double MoatsCurrentCoupon { get; set; }

        [JsonProperty("optionModelCurveID")]
        public string OptionModelCurveId { get; set; }

        [JsonProperty("yieldCurveDuration")]
        public double YieldCurveDuration { get; set; }

        [JsonProperty("benchmarkToNextCall")]
        public string BenchmarkToNextCall { get; set; }

        [JsonProperty("durationToWorstCase")]
        public double DurationToWorstCase { get; set; }

        [JsonProperty("semiAnnualizedYield")]
        public double SemiAnnualizedYield { get; set; }

        [JsonProperty("spreadToRFRSwapCurve")]
        public double SpreadToRFRSwapCurve { get; set; }

        [JsonProperty("yearsToFinalMaturity")]
        public double YearsToFinalMaturity { get; set; }

        [JsonProperty("spreadDurationTreasury")]
        public double SpreadDurationTreasury { get; set; }

        [JsonProperty("dataPartialDurationList")]
        public DataPartialDurationList[] DataPartialDurationList { get; set; }

        [JsonProperty("fundedEffectiveDuration")]
        public double FundedEffectiveDuration { get; set; }

        [JsonProperty("effectiveDurationPriceUp")]
        public double EffectiveDurationPriceUp { get; set; }

        [JsonProperty("fundedEffectiveConvexity")]
        public double FundedEffectiveConvexity { get; set; }

        [JsonProperty("lastPrincipalPaymentDate")]
        public string LastPrincipalPaymentDate { get; set; }

        [JsonProperty("firstPrincipalPaymentDate")]
        public string FirstPrincipalPaymentDate { get; set; }

        [JsonProperty("effectiveDurationPriceDown")]
        public double EffectiveDurationPriceDown { get; set; }

        [JsonProperty("spreadToActCurveToNextCall")]
        public double SpreadToActCurveToNextCall { get; set; }

        [JsonProperty("spreadToTsyCurveToNextCall")]
        public double SpreadToTsyCurveToNextCall { get; set; }

        [JsonProperty("spreadToBenchmarkToNextCall")]
        public double SpreadToBenchmarkToNextCall { get; set; }

        [JsonProperty("spreadToSwapCurveToNextCall")]
        public double SpreadToSwapCurveToNextCall { get; set; }

        [JsonProperty("principalWritedownCreditLoss")]
        public double PrincipalWritedownCreditLoss { get; set; }

        [JsonProperty("cumulativeLossToNextCallCurrent")]
        public double CumulativeLossToNextCallCurrent { get; set; }

        [JsonProperty("cumulativeLossToNextCallOriginal")]
        public double CumulativeLossToNextCallOriginal { get; set; }

        [JsonProperty("cumulativeDefaultToNextCallCurrent")]
        public double CumulativeDefaultToNextCallCurrent { get; set; }

        [JsonProperty("cumulativeDefaultToNextCallOriginal")]
        public double CumulativeDefaultToNextCallOriginal { get; set; }

        [JsonProperty("spreadToTsyCurveAtBenchmarkTenor")]
        public double SpreadToTsyCurveAtBenchmarkTenor { get; set; }

        [JsonProperty("spreadToBenchmarkToWorstCall")]
        public double SpreadToBenchmarkToWorstCall { get; set; }

        [JsonProperty("spreadToActCurveToWorstCall")]
        public double SpreadToActCurveToWorstCall { get; set; }

        [JsonProperty("currentCouponSpreadConvexity")]
        public double CurrentCouponSpreadConvexity { get; set; }

        [JsonProperty("currentCouponSpreadSensitivity")]
        public double CurrentCouponSpreadSensitivity { get; set; }
    }

    public class MarketSettings
    {
        [JsonProperty("settlementDate")]
        public string SettlementDate { get; set; }
    }

    public class DataPpmProjList
    {
        [JsonProperty("oneYear")]
        public double OneYear { get; set; }

        [JsonProperty("longTerm")]
        public double LongTerm { get; set; }

        [JsonProperty("oneMonth")]
        public double OneMonth { get; set; }

        [JsonProperty("sixMonth")]
        public double SixMonth { get; set; }

        [JsonProperty("prepayType")]
        public string PrepayType { get; set; }

        [JsonProperty("threeMonth")]
        public double ThreeMonth { get; set; }
    }

    public class ForwardMeasures
    {
        [JsonProperty("wal")]
        public double Wal { get; set; }

        [JsonProperty("yield")]
        public double Yield { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("cumulativeLoss")]
        public double CumulativeLoss { get; set; }

        [JsonProperty("cumulativeDefaults")]
        public double CumulativeDefaults { get; set; }
    }

    public class DataPartialDurationList
    {
        [JsonProperty("partialDV01")]
        public double PartialDV01 { get; set; }

        [JsonProperty("partialDuration")]
        public double PartialDuration { get; set; }

        [JsonProperty("partialDurationYear")]
        public double PartialDurationYear { get; set; }

        [JsonProperty("partialDurationPriceUp")]
        public double PartialDurationPriceUp { get; set; }

        [JsonProperty("partialDurationPriceDown")]
        public double PartialDurationPriceDown { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyhorizonPYMethodInput
    {
        [EnumMember(Value = "OAS Change")]
        OASChange,
        [EnumMember(Value = "Spread Change")]
        SpreadChange,
        [EnumMember(Value = "DM Change")]
        DMChange,
        [EnumMember(Value = "Static Spread Change")]
        StaticSpreadChange,
        [EnumMember(Value = "Volatility Change")]
        VolatilityChange,
        Default
    }

    public class ScenarioV3
    {
        [JsonProperty("scenarioID")]
        public string ScenarioId { get; set; }

        [JsonProperty("scenarioType")]
        public ScenarioV3ScenarioTypeType ScenarioType { get; set; }

        [JsonProperty("scenarioTiming")]
        public ScenarioV3ScenarioTimingType ScenarioTiming { get; set; }

        [JsonProperty("reinvestmentRate")]
        public string ReinvestmentRate { get; set; }

        [JsonProperty("swapSpreadConstant")]
        public ScenarioV3SwapSpreadConstantType SwapSpreadConstant { get; set; }

        [JsonProperty("interpolationType")]
        public ScenarioV3InterpolationTypeType InterpolationType { get; set; }

        [JsonProperty("curveShifts")]
        public CurveShiftV3[] CurveShifts { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3ScenarioTypeType
    {
        [EnumMember(Value = "Forward Shift (User Scenario)")]
        ForwardShiftUserScenario,
        [EnumMember(Value = "Implied Forward Shift (User Scenario)")]
        ImpliedForwardShiftUserScenario,
        [EnumMember(Value = "Par Shift (User Scenario)")]
        ParShiftUserScenario,
        [EnumMember(Value = "Spot Shift (User Scenario)")]
        SpotShiftUserScenario,
        [EnumMember(Value = "Bear Steep 50 (System Scenario)")]
        BearSteep50SystemScenario,
        [EnumMember(Value = "Bear Steep 100 (System Scenario)")]
        BearSteep100SystemScenario,
        [EnumMember(Value = "Bear Flat 50 (System Scenario)")]
        BearFlat50SystemScenario,
        [EnumMember(Value = "Bear Flat 100 (System Scenario)")]
        BearFlat100SystemScenario,
        [EnumMember(Value = "Bull Steep 50 (System Scenario)")]
        BullSteep50SystemScenario,
        [EnumMember(Value = "Bull Steep 100 (System Scenario)")]
        BullSteep100SystemScenario,
        [EnumMember(Value = "Bull Flat 50 (System Scenario)")]
        BullFlat50SystemScenario,
        [EnumMember(Value = "Bull Flat 100 (System Scenario)")]
        BullFlat100SystemScenario,
        [EnumMember(Value = "Par Shift 300 (System Scenario)")]
        ParShift300SystemScenario2,
        [EnumMember(Value = "Par Shift 200 (System Scenario)")]
        ParShift200SystemScenario2,
        [EnumMember(Value = "Par Shift 100 (System Scenario)")]
        ParShift100SystemScenario2,
        [EnumMember(Value = "Par Shift 50 (System Scenario)")]
        ParShift50SystemScenario2,
        [EnumMember(Value = "Par Shift 25 (System Scenario)")]
        ParShift25SystemScenario2,
        [EnumMember(Value = "Par Shift 0 (System Scenario)")]
        ParShift0SystemScenario,
        [EnumMember(Value = "Par Shift -25 (System Scenario)")]
        ParShift25SystemScenario,
        [EnumMember(Value = "Par Shift -50 (System Scenario)")]
        ParShift50SystemScenario,
        [EnumMember(Value = "Par Shift -100 (System Scenario)")]
        ParShift100SystemScenario,
        [EnumMember(Value = "Par Shift -200 (System Scenario)")]
        ParShift200SystemScenario,
        [EnumMember(Value = "Par Shift -300 (System Scenario)")]
        ParShift300SystemScenario,
        [EnumMember(Value = "Spot Shift 300 (System Scenario)")]
        SpotShift300SystemScenario2,
        [EnumMember(Value = "Spot Shift 200 (System Scenario)")]
        SpotShift200SystemScenario2,
        [EnumMember(Value = "Spot Shift 100 (System Scenario)")]
        SpotShift100SystemScenario2,
        [EnumMember(Value = "Spot Shift 50 (System Scenario)")]
        SpotShift50SystemScenario2,
        [EnumMember(Value = "Spot Shift 25 (System Scenario)")]
        SpotShift25SystemScenario2,
        [EnumMember(Value = "Spot Shift 0 (System Scenario)")]
        SpotShift0SystemScenario,
        [EnumMember(Value = "Spot Shift -25 (System Scenario)")]
        SpotShift25SystemScenario,
        [EnumMember(Value = "Spot Shift -50 (System Scenario)")]
        SpotShift50SystemScenario,
        [EnumMember(Value = "Spot Shift -100 (System Scenario)")]
        SpotShift100SystemScenario,
        [EnumMember(Value = "Spot Shift -200 (System Scenario)")]
        SpotShift200SystemScenario,
        [EnumMember(Value = "Spot Shift -300 (System Scenario)")]
        SpotShift300SystemScenario,
        [EnumMember(Value = "Fwd Shift 300 (System Scenario)")]
        FwdShift300SystemScenario2,
        [EnumMember(Value = "Fwd Shift 200 (System Scenario)")]
        FwdShift200SystemScenario2,
        [EnumMember(Value = "Fwd Shift 100 (System Scenario)")]
        FwdShift100SystemScenario2,
        [EnumMember(Value = "Fwd Shift 50 (System Scenario)")]
        FwdShift50SystemScenario2,
        [EnumMember(Value = "Fwd Shift 25 (System Scenario)")]
        FwdShift25SystemScenario2,
        [EnumMember(Value = "Fwd Shift 0 (System Scenario)")]
        FwdShift0SystemScenario,
        [EnumMember(Value = "Fwd Shift -25 (System Scenario)")]
        FwdShift25SystemScenario,
        [EnumMember(Value = "Fwd Shift -50 (System Scenario)")]
        FwdShift50SystemScenario,
        [EnumMember(Value = "Fwd Shift -100 (System Scenario)")]
        FwdShift100SystemScenario,
        [EnumMember(Value = "Fwd Shift -200 (System Scenario)")]
        FwdShift200SystemScenario,
        [EnumMember(Value = "Fwd Shift -300 (System Scenario)")]
        FwdShift300SystemScenario,
        [EnumMember(Value = "ImplFwd Shift 300 (System Scenario)")]
        ImplFwdShift300SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 200 (System Scenario)")]
        ImplFwdShift200SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 100 (System Scenario)")]
        ImplFwdShift100SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 50 (System Scenario)")]
        ImplFwdShift50SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 25 (System Scenario)")]
        ImplFwdShift25SystemScenario2,
        [EnumMember(Value = "ImplFwd Shift 0 (System Scenario)")]
        ImplFwdShift0SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -25 (System Scenario)")]
        ImplFwdShift25SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -50 (System Scenario)")]
        ImplFwdShift50SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -100 (System Scenario)")]
        ImplFwdShift100SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -200 (System Scenario)")]
        ImplFwdShift200SystemScenario,
        [EnumMember(Value = "ImplFwd Shift -300 (System Scenario)")]
        ImplFwdShift300SystemScenario
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3ScenarioTimingType
    {
        Immediate,
        Gradual,
        AtHorizon
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3SwapSpreadConstantType
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScenarioV3InterpolationTypeType
    {
        Years,
        Yields,
        PrincipalComponents
    }

    public class CurveShiftV3
    {
        [JsonProperty("curveShiftYear")]
        public double CurveShiftYear { get; set; }

        [JsonProperty("curveShiftValue")]
        public double CurveShiftValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti;

    public partial class WorkflowManagedActions
    {
        public LsegfinancialanalytiActions Lsegfinancialanalyti(string connectionId) => new LsegfinancialanalytiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LsegfinancialanalytiTriggers Lsegfinancialanalyti(string connectionId) => new LsegfinancialanalytiTriggers(connectionId);
    }
}