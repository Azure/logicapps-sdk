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
                body["priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
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
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            return new ApiConnectionAction<JobStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkPyAnalytics(Expression<Func<string>> jobName, Expression<Func<int>> batchSize, Expression<Func<string>> bodyrequestId, Expression<Func<bodycurveTypeInput>> bodycurveType, Expression<Func<string>> bodypricingDate, Expression<Func<string>> bodysettlementType, Expression<Func<bodyprepayTypeInput>> bodyprepayType, Expression<Func<bool>> bodycalculatePartialDurations4pt, Expression<Func<bool>> bodycalculatePartialDurations7pt, Expression<Func<bool>> bodyretrieveModelProjections, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<int>> bodyprepayRate = null, Expression<Func<bool>> bodyretrieveOas = null, Expression<Func<bodyoptionModelInput>> bodyoptionModel = null)
        {
            var apiCallPath = "/power-platform/v1/bulk-py-analytics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            callPayload.Queries["Batch Size"] = CSharpExpressionConverter.ConvertO(batchSize);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["requestId"] = CSharpExpressionConverter.ConvertToken(bodyrequestId);
            bodypropCount++;
            body["curveType"] = CSharpExpressionConverter.Convert(bodycurveType);
            if (bodycurrency != null)
            {
                body["currency"] = CSharpExpressionConverter.Convert(bodycurrency);
                bodypropCount++;
            }

            bodypropCount++;
            body["pricingDate"] = CSharpExpressionConverter.ConvertToken(bodypricingDate);
            bodypropCount++;
            body["settlementType"] = CSharpExpressionConverter.ConvertToken(bodysettlementType);
            bodypropCount++;
            body["prepayType"] = CSharpExpressionConverter.Convert(bodyprepayType);
            if (bodyprepayRate != null)
            {
                body["prepayRate"] = CSharpExpressionConverter.ConvertToken(bodyprepayRate);
                bodypropCount++;
            }

            bodypropCount++;
            body["calculatePartialDurations4pt"] = CSharpExpressionConverter.ConvertToken(bodycalculatePartialDurations4pt);
            bodypropCount++;
            body["calculatePartialDurations7pt"] = CSharpExpressionConverter.ConvertToken(bodycalculatePartialDurations7pt);
            bodypropCount++;
            body["retrieveModelProjections"] = CSharpExpressionConverter.ConvertToken(bodyretrieveModelProjections);
            if (bodyretrieveOas != null)
            {
                body["retrieveOas"] = CSharpExpressionConverter.ConvertToken(bodyretrieveOas);
                bodypropCount++;
            }

            if (bodyoptionModel != null)
            {
                body["optionModel"] = CSharpExpressionConverter.Convert(bodyoptionModel);
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
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            callPayload.Queries["Batch Size"] = CSharpExpressionConverter.ConvertO(batchSize);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["requestId"] = CSharpExpressionConverter.ConvertToken(bodyrequestId);
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
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["securitiesList"] = CSharpExpressionConverter.ConvertToken(bodysecuritiesList);
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
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> RetrieveBulkResults(Expression<Func<string>> jobName, Expression<Func<outputFormatInput>> outputFormat, Expression<Func<string>> bodypayload)
        {
            var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Job name"] = CSharpExpressionConverter.ConvertO(jobName);
            callPayload.Queries["Output Format"] = CSharpExpressionConverter.Convert(outputFormat);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["payload"] = CSharpExpressionConverter.ConvertToken(bodypayload);
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