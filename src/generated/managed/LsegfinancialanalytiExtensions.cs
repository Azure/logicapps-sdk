//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LsegfinancialanalytiActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildCreateJob))]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodypriority = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateJobResponse> __BuildCreateJob(WorkflowExpression<string> bodyname, WorkflowExpression<int> bodypriority = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            return new DeferredBodyAction<CreateJobResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/create-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildJobStatus))]
        public IBodyWorkflowAction<JobStatusResponse> JobStatus([WorkflowExpression] Func<string> jobName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobStatusResponse> __BuildJobStatus(WorkflowExpression<string> jobName)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            return new DeferredBodyAction<JobStatusResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/job-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                return new ApiConnectionAction<JobStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildBulkPyAnalytics))]
        public IWorkflowAction BulkPyAnalytics([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<int> batchSize, [WorkflowExpression] Func<string> bodyrequestId, [WorkflowExpression] Func<bodycurveTypeInput> bodycurveType, [WorkflowExpression] Func<string> bodypricingDate, [WorkflowExpression] Func<string> bodysettlementType, [WorkflowExpression] Func<bodyprepayTypeInput> bodyprepayType, [WorkflowExpression] Func<bool> bodycalculatePartialDurations4pt, [WorkflowExpression] Func<bool> bodycalculatePartialDurations7pt, [WorkflowExpression] Func<bool> bodyretrieveModelProjections, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency = null, [WorkflowExpression] Func<int> bodyprepayRate = null, [WorkflowExpression] Func<bool> bodyretrieveOas = null, [WorkflowExpression] Func<bodyoptionModelInput> bodyoptionModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBulkPyAnalytics(WorkflowExpression<string> jobName, WorkflowExpression<int> batchSize, WorkflowExpression<string> bodyrequestId, WorkflowExpression<bodycurveTypeInput> bodycurveType, WorkflowExpression<string> bodypricingDate, WorkflowExpression<string> bodysettlementType, WorkflowExpression<bodyprepayTypeInput> bodyprepayType, WorkflowExpression<bool> bodycalculatePartialDurations4pt, WorkflowExpression<bool> bodycalculatePartialDurations7pt, WorkflowExpression<bool> bodyretrieveModelProjections, WorkflowExpression<bodycurrencyInput> bodycurrency = null, WorkflowExpression<int> bodyprepayRate = null, WorkflowExpression<bool> bodyretrieveOas = null, WorkflowExpression<bodyoptionModelInput> bodyoptionModel = null)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            WorkflowExpression.Validate(batchSize, nameof(batchSize), required: true);
            WorkflowExpression.Validate(bodyrequestId, nameof(bodyrequestId), required: true);
            WorkflowExpression.Validate(bodycurveType, nameof(bodycurveType), required: true);
            WorkflowExpression.Validate(bodypricingDate, nameof(bodypricingDate), required: true);
            WorkflowExpression.Validate(bodysettlementType, nameof(bodysettlementType), required: true);
            WorkflowExpression.Validate(bodyprepayType, nameof(bodyprepayType), required: true);
            WorkflowExpression.Validate(bodycalculatePartialDurations4pt, nameof(bodycalculatePartialDurations4pt), required: true);
            WorkflowExpression.Validate(bodycalculatePartialDurations7pt, nameof(bodycalculatePartialDurations7pt), required: true);
            WorkflowExpression.Validate(bodyretrieveModelProjections, nameof(bodyretrieveModelProjections), required: true);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodyprepayRate, nameof(bodyprepayRate), required: false);
            WorkflowExpression.Validate(bodyretrieveOas, nameof(bodyretrieveOas), required: false);
            WorkflowExpression.Validate(bodyoptionModel, nameof(bodyoptionModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = ExpressionConverter.ConvertO(bodyrequestId);
                bodypropCount++;
                body["curveType"] = ExpressionConverter.ConvertO(bodycurveType);
                if (bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(bodycurrency);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pricingDate"] = ExpressionConverter.ConvertO(bodypricingDate);
                bodypropCount++;
                body["settlementType"] = ExpressionConverter.ConvertO(bodysettlementType);
                bodypropCount++;
                body["prepayType"] = ExpressionConverter.ConvertO(bodyprepayType);
                if (bodyprepayRate != null)
                {
                    body["prepayRate"] = ExpressionConverter.ConvertO(bodyprepayRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculatePartialDurations4pt"] = ExpressionConverter.ConvertO(bodycalculatePartialDurations4pt);
                bodypropCount++;
                body["calculatePartialDurations7pt"] = ExpressionConverter.ConvertO(bodycalculatePartialDurations7pt);
                bodypropCount++;
                body["retrieveModelProjections"] = ExpressionConverter.ConvertO(bodyretrieveModelProjections);
                if (bodyretrieveOas != null)
                {
                    body["retrieveOas"] = ExpressionConverter.ConvertO(bodyretrieveOas);
                    bodypropCount++;
                }

                if (bodyoptionModel != null)
                {
                    body["optionModel"] = ExpressionConverter.ConvertO(bodyoptionModel);
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
        [WorkflowExpressionFactory(nameof(__BuildBulkIndicData))]
        public IWorkflowAction BulkIndicData([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<int> batchSize, [WorkflowExpression] Func<string> bodyrequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBulkIndicData(WorkflowExpression<string> jobName, WorkflowExpression<int> batchSize, WorkflowExpression<string> bodyrequestId)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            WorkflowExpression.Validate(batchSize, nameof(batchSize), required: true);
            WorkflowExpression.Validate(bodyrequestId, nameof(bodyrequestId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/power-platform/v1/bulk-indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                callPayload.Queries["Batch Size"] = ExpressionConverter.Convert(batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = ExpressionConverter.ConvertO(bodyrequestId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildUploadSecuritiesList))]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse> UploadSecuritiesList([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<string> bodysecuritiesList)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse> __BuildUploadSecuritiesList(WorkflowExpression<string> jobName, WorkflowExpression<string> bodysecuritiesList)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            WorkflowExpression.Validate(bodysecuritiesList, nameof(bodysecuritiesList), required: true);
            return new DeferredBodyAction<UploadSecuritiesListDefaultResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/upload-securities-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["securitiesList"] = ExpressionConverter.ConvertO(bodysecuritiesList);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadSecuritiesListDefaultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildCloseJob))]
        public IWorkflowAction CloseJob([WorkflowExpression] Func<string> jobName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseJob(WorkflowExpression<string> jobName)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/power-platform/v1/close-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveBulkResults))]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> RetrieveBulkResults([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<outputFormatInput> outputFormat, [WorkflowExpression] Func<string> bodypayload)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> __BuildRetrieveBulkResults(WorkflowExpression<string> jobName, WorkflowExpression<outputFormatInput> outputFormat, WorkflowExpression<string> bodypayload)
        {
            WorkflowExpression.Validate(jobName, nameof(jobName), required: true);
            WorkflowExpression.Validate(outputFormat, nameof(outputFormat), required: true);
            WorkflowExpression.Validate(bodypayload, nameof(bodypayload), required: true);
            return new DeferredBodyAction<RetrieveBulkResultsResponse>(() =>
            {
                var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
                callPayload.Queries["Output Format"] = ExpressionConverter.Convert(outputFormat);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = ExpressionConverter.ConvertO(bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RetrieveBulkResultsResponse>(callPayload);
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