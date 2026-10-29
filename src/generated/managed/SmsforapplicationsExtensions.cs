//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smsforapplications
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmsforapplicationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<JobReport[], ApiConnectionActionConfiguration> ListJobs(Expression<Func<bool>> jobIdsOnly, Expression<Func<string>> fromTs = null, Expression<Func<string>> toTs = null, Expression<Func<bool>> open = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_jobIdsOnly = WorkflowExpression.Compile(jobIdsOnly, nameof(jobIdsOnly), required: true);
            var __workflow_fromTs = WorkflowExpression.Compile(fromTs, nameof(fromTs), required: false);
            var __workflow_toTs = WorkflowExpression.Compile(toTs, nameof(toTs), required: false);
            var __workflow_open = WorkflowExpression.Compile(open, nameof(open), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<JobReport[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobIdsOnly"] = ExpressionConverter.Convert(__workflow_jobIdsOnly);
                if (__workflow_fromTs != null)
                    callPayload.Queries["fromTs"] = ExpressionConverter.Convert(__workflow_fromTs);
                if (__workflow_toTs != null)
                    callPayload.Queries["toTs"] = ExpressionConverter.Convert(__workflow_toTs);
                callPayload.Queries["open"] = Convert.ToString(false);
                if (__workflow_open != null)
                    callPayload.Queries["open"] = ExpressionConverter.Convert(__workflow_open);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<JobReport[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<JobReport, ApiConnectionActionConfiguration> GetJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JobReport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<RecipientReport[], ApiConnectionActionConfiguration> ListRecipients(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<RecipientReport[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobId"] = ExpressionConverter.Convert(__workflow_jobId);
                return new ApiConnectionAction<RecipientReport[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<VersionInfoResponse, ApiConnectionActionConfiguration> Get()
        {
            return new DeferredBodyAction<VersionInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VersionInfoResponse>(callPayload);
            });
        }
    }

    public class SmsforapplicationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class JobReport
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("encoding")]
        public JobReportEncodingType Encoding { get; set; }

        [JsonProperty("billcode")]
        public string Billcode { get; set; }

        [JsonProperty("statusRequested")]
        public bool StatusRequested { get; set; }

        [JsonProperty("flash")]
        public bool Flash { get; set; }

        [JsonProperty("validityMin")]
        public int ValidityMin { get; set; }

        [JsonProperty("customerRef")]
        public string CustomerRef { get; set; }

        [JsonProperty("qos")]
        public JobReportQosType Qos { get; set; }

        [JsonProperty("receiptTs")]
        public string ReceiptTs { get; set; }

        [JsonProperty("finishedTs")]
        public string FinishedTs { get; set; }

        [JsonProperty("recipientIds")]
        public string[] RecipientIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobReportEncodingType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "utf-16")]
        Utf16
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobReportQosType
    {
        EXPRESS,
        NORMAL
    }

    public class RecipientReport
    {
        [JsonProperty("smsId")]
        public string SmsId { get; set; }

        [JsonProperty("dst")]
        public string Dst { get; set; }

        [JsonProperty("processStatus")]
        public string ProcessStatus { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("customerRef")]
        public string CustomerRef { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("sentTs")]
        public string SentTs { get; set; }

        [JsonProperty("finishedTs")]
        public string FinishedTs { get; set; }
    }

    public class VersionInfoResponse
    {
        [JsonProperty("buildNumber")]
        public int BuildNumber { get; set; }

        [JsonProperty("buildTimestamp")]
        public string BuildTimestamp { get; set; }

        [JsonProperty("majorVersion")]
        public int MajorVersion { get; set; }

        [JsonProperty("minorVersion")]
        public int MinorVersion { get; set; }

        [JsonProperty("versionInfo")]
        public string VersionInfo { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smsforapplications;

    public partial class WorkflowManagedActions
    {
        public SmsforapplicationsActions Smsforapplications(string connectionId) => new SmsforapplicationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmsforapplicationsTriggers Smsforapplications(string connectionId) => new SmsforapplicationsTriggers(connectionId);
    }
}