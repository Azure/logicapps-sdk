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
        public IBodyWorkflowAction<CreateJobResponse> CreateJob(Expression<Func<string>> bodyname, Expression<Func<int>> bodypriority = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<JobStatusResponse> JobStatus(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<JobStatusResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/job-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction<JobStatusResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkPyAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<bool>> bodyretrieveOas = null, Expression<Func<bodyoptionModelInput>> bodyoptionModel = null)
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
            return new DeferredWorkflowAction(() =>
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkIndicData(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_batchSize = WorkflowExpression.Compile(batchSize, nameof(batchSize), required: true);
            var __workflow_bodyrequestId = WorkflowExpression.Compile(bodyrequestId, nameof(bodyrequestId), required: true);
            return new DeferredWorkflowAction(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse> UploadSecuritiesList(Expression<Func<string>> jobName, Expression<Func<string>> bodysecuritiesList)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_bodysecuritiesList = WorkflowExpression.Compile(bodysecuritiesList, nameof(bodysecuritiesList), required: true);
            return new DeferredBodyAction<UploadSecuritiesListDefaultResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/upload-securities-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["securitiesList"] = ExpressionConverter.ConvertO(__workflow_bodysecuritiesList);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadSecuritiesListDefaultResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction CloseJob(Expression<Func<string>> jobName)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/power-platform/v1/close-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> RetrieveBulkResults(Expression<Func<string>> jobName, Expression<Func<outputFormatInput>> outputFormat, Expression<Func<string>> bodypayload)
        {
            var __workflow_jobName = WorkflowExpression.Compile(jobName, nameof(jobName), required: true);
            var __workflow_outputFormat = WorkflowExpression.Compile(outputFormat, nameof(outputFormat), required: true);
            var __workflow_bodypayload = WorkflowExpression.Compile(bodypayload, nameof(bodypayload), required: true);
            return new DeferredBodyAction<RetrieveBulkResultsResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(__workflow_jobName);
                callPayload.Queries["Output Format"] = ExpressionConverter.Convert(__workflow_outputFormat);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = ExpressionConverter.ConvertO(__workflow_bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RetrieveBulkResultsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    public class UploadSecuritiesListDefaultResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
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
