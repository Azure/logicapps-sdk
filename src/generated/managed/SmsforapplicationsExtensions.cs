//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smsforapplications
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmsforapplicationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<JobReport[]> ListJobs([WorkflowExpression] Func<bool> jobIdsOnly, [WorkflowExpression] Func<string> fromTs = null, [WorkflowExpression] Func<string> toTs = null, [WorkflowExpression] Func<bool> open = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(jobIdsOnly, nameof(jobIdsOnly), required: true);
            SourceExpression.Validate(fromTs, nameof(fromTs), required: false);
            SourceExpression.Validate(toTs, nameof(toTs), required: false);
            SourceExpression.Validate(open, nameof(open), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobIdsOnly"] = SourceExpressionConverter.ConvertO(jobIdsOnly);
                if (fromTs != null)
                    callPayload.Queries["fromTs"] = SourceExpressionConverter.ConvertO(fromTs);
                if (toTs != null)
                    callPayload.Queries["toTs"] = SourceExpressionConverter.ConvertO(toTs);
                callPayload.Queries["open"] = Convert.ToString(false);
                if (open != null)
                    callPayload.Queries["open"] = SourceExpressionConverter.ConvertO(open);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<JobReport[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<JobReport> GetJob([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JobReport>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<RecipientReport[]> ListRecipients([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jobId"] = SourceExpressionConverter.ConvertO(jobId);
                return callPayload;
            }

            return new ApiConnectionAction<RecipientReport[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsforapplications")]
        public IBodyWorkflowAction<VersionInfoResponse> Get()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VersionInfoResponse>(BuildSourceInput);
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