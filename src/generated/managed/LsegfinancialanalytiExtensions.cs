//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lsegfinancialanalyti
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LsegfinancialanalytiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<CreateJobResponse> CreateJob(Expression<Func<string>> bodyname, Expression<Func<int>> bodypriority = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<JobStatusResponse> JobStatus(Expression<Func<string>> jobName)
        {
            var apiCallPath = "/power-platform/v1/job-status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
            return new ApiConnectionAction<JobStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkPyAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<bool>> bodyretrieveOas = null, Expression<Func<bodyoptionModelInput>> bodyoptionModel = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkIndicData(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse> UploadSecuritiesList(Expression<Func<string>> jobName, Expression<Func<string>> bodysecuritiesList)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction CloseJob(Expression<Func<string>> jobName)
        {
            var apiCallPath = "/power-platform/v1/close-job";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Job name"] = ExpressionConverter.Convert(jobName);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> RetrieveBulkResults(Expression<Func<string>> jobName, Expression<Func<outputFormatInput>> outputFormat, Expression<Func<string>> bodypayload)
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

    public enum bodyprepayTypeInput
    {
        Default,
        Model,
        CPR,
        PSA,
        PreExpModel
    }

    public enum bodycurrencyInput
    {
        USD,
        EUR
    }

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