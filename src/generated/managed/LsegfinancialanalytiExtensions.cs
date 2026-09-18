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
        public IBodyWorkflowAction<CreateJobResponse> CreateJob([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodypriority = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/create-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<JobStatusResponse> JobStatus([WorkflowExpression] Func<string> jobName)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/job-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                return callPayload;
            }

            return new ApiConnectionAction<JobStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkPyAnalytics([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<int> batchSize, [WorkflowExpression] Func<string> bodyrequestId, [WorkflowExpression] Func<bodycurveTypeInput> bodycurveType, [WorkflowExpression] Func<string> bodypricingDate, [WorkflowExpression] Func<string> bodysettlementType, [WorkflowExpression] Func<bodyprepayTypeInput> bodyprepayType, [WorkflowExpression] Func<bool> bodycalculatePartialDurations4pt, [WorkflowExpression] Func<bool> bodycalculatePartialDurations7pt, [WorkflowExpression] Func<bool> bodyretrieveModelProjections, [WorkflowExpression] Func<bodycurrencyInput> bodycurrency = null, [WorkflowExpression] Func<int> bodyprepayRate = null, [WorkflowExpression] Func<bool> bodyretrieveOas = null, [WorkflowExpression] Func<bodyoptionModelInput> bodyoptionModel = null)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            SourceExpression.Validate(batchSize, nameof(batchSize), required: true);
            SourceExpression.Validate(bodyrequestId, nameof(bodyrequestId), required: true);
            SourceExpression.Validate(bodycurveType, nameof(bodycurveType), required: true);
            SourceExpression.Validate(bodypricingDate, nameof(bodypricingDate), required: true);
            SourceExpression.Validate(bodysettlementType, nameof(bodysettlementType), required: true);
            SourceExpression.Validate(bodyprepayType, nameof(bodyprepayType), required: true);
            SourceExpression.Validate(bodycalculatePartialDurations4pt, nameof(bodycalculatePartialDurations4pt), required: true);
            SourceExpression.Validate(bodycalculatePartialDurations7pt, nameof(bodycalculatePartialDurations7pt), required: true);
            SourceExpression.Validate(bodyretrieveModelProjections, nameof(bodyretrieveModelProjections), required: true);
            SourceExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            SourceExpression.Validate(bodyprepayRate, nameof(bodyprepayRate), required: false);
            SourceExpression.Validate(bodyretrieveOas, nameof(bodyretrieveOas), required: false);
            SourceExpression.Validate(bodyoptionModel, nameof(bodyoptionModel), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/bulk-py-analytics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                callPayload.Queries["Batch Size"] = SourceExpressionConverter.ConvertO(batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = SourceExpressionConverter.ConvertToken(bodyrequestId);
                bodypropCount++;
                body["curveType"] = SourceExpressionConverter.Convert(bodycurveType);
                if (bodycurrency != null)
                {
                    body["currency"] = SourceExpressionConverter.Convert(bodycurrency);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pricingDate"] = SourceExpressionConverter.ConvertToken(bodypricingDate);
                bodypropCount++;
                body["settlementType"] = SourceExpressionConverter.ConvertToken(bodysettlementType);
                bodypropCount++;
                body["prepayType"] = SourceExpressionConverter.Convert(bodyprepayType);
                if (bodyprepayRate != null)
                {
                    body["prepayRate"] = SourceExpressionConverter.ConvertToken(bodyprepayRate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["calculatePartialDurations4pt"] = SourceExpressionConverter.ConvertToken(bodycalculatePartialDurations4pt);
                bodypropCount++;
                body["calculatePartialDurations7pt"] = SourceExpressionConverter.ConvertToken(bodycalculatePartialDurations7pt);
                bodypropCount++;
                body["retrieveModelProjections"] = SourceExpressionConverter.ConvertToken(bodyretrieveModelProjections);
                if (bodyretrieveOas != null)
                {
                    body["retrieveOas"] = SourceExpressionConverter.ConvertToken(bodyretrieveOas);
                    bodypropCount++;
                }

                if (bodyoptionModel != null)
                {
                    body["optionModel"] = SourceExpressionConverter.Convert(bodyoptionModel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction BulkIndicData([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<int> batchSize, [WorkflowExpression] Func<string> bodyrequestId)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            SourceExpression.Validate(batchSize, nameof(batchSize), required: true);
            SourceExpression.Validate(bodyrequestId, nameof(bodyrequestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/bulk-indic-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                callPayload.Queries["Batch Size"] = SourceExpressionConverter.ConvertO(batchSize);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["requestId"] = SourceExpressionConverter.ConvertToken(bodyrequestId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<UploadSecuritiesListDefaultResponse> UploadSecuritiesList([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<string> bodysecuritiesList)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            SourceExpression.Validate(bodysecuritiesList, nameof(bodysecuritiesList), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/upload-securities-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["securitiesList"] = SourceExpressionConverter.ConvertToken(bodysecuritiesList);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadSecuritiesListDefaultResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IWorkflowAction CloseJob([WorkflowExpression] Func<string> jobName)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/close-job";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lsegfinancialanalyti")]
        public IBodyWorkflowAction<RetrieveBulkResultsResponse> RetrieveBulkResults([WorkflowExpression] Func<string> jobName, [WorkflowExpression] Func<outputFormatInput> outputFormat, [WorkflowExpression] Func<string> bodypayload)
        {
            SourceExpression.Validate(jobName, nameof(jobName), required: true);
            SourceExpression.Validate(outputFormat, nameof(outputFormat), required: true);
            SourceExpression.Validate(bodypayload, nameof(bodypayload), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-platform/v1/retrieve-results-bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Job name"] = SourceExpressionConverter.ConvertO(jobName);
                callPayload.Queries["Output Format"] = SourceExpressionConverter.Convert(outputFormat);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = SourceExpressionConverter.ConvertToken(bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveBulkResultsResponse>(BuildSourceInput);
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