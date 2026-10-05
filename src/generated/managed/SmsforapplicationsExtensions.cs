//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smsforapplications
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmsforapplicationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        [WorkflowExpressionFactory(nameof(__BuildListJobs))]
        public IBodyWorkflowAction<JobReport[]> ListJobs([WorkflowExpression] Func<bool> jobIdsOnly, [WorkflowExpression] Func<string> fromTs = null, [WorkflowExpression] Func<string> toTs = null, [WorkflowExpression] Func<bool> open = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobReport[]> __BuildListJobs(WorkflowValue<bool> jobIdsOnly, WorkflowValue<string> fromTs = null, WorkflowValue<string> toTs = null, WorkflowValue<bool> open = null, WorkflowValue<int> offset = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(jobIdsOnly, nameof(jobIdsOnly), required: true);
            WorkflowValue.Validate(fromTs, nameof(fromTs), required: false);
            WorkflowValue.Validate(toTs, nameof(toTs), required: false);
            WorkflowValue.Validate(open, nameof(open), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<JobReport[]>(() =>
            {
                var apiCallPath = "/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobIdsOnly"] = ExpressionConverter.Convert(jobIdsOnly);
                if (fromTs != null)
                    callPayload.Queries["fromTs"] = ExpressionConverter.Convert(fromTs);
                if (toTs != null)
                    callPayload.Queries["toTs"] = ExpressionConverter.Convert(toTs);
                callPayload.Queries["open"] = Convert.ToString(false);
                if (open != null)
                    callPayload.Queries["open"] = ExpressionConverter.Convert(open);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<JobReport[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        [WorkflowExpressionFactory(nameof(__BuildGetJob))]
        public IBodyWorkflowAction<JobReport> GetJob([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JobReport> __BuildGetJob(WorkflowValue<string> jobId)
        {
            WorkflowValue.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JobReport>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        [WorkflowExpressionFactory(nameof(__BuildListRecipients))]
        public IBodyWorkflowAction<RecipientReport[]> ListRecipients([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecipientReport[]> __BuildListRecipients(WorkflowValue<string> jobId)
        {
            WorkflowValue.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<RecipientReport[]>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobId"] = ExpressionConverter.Convert(jobId);
                return new ApiConnectionAction<RecipientReport[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<VersionInfoResponse> Get()
        {
            var apiCallPath = "/version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VersionInfoResponse>(callPayload);
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

    public enum JobReportEncodingType
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "utf-16")]
        Utf16
    }

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
