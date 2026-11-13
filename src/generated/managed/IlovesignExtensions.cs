//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IlovesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovesign")]
        public IBodyWorkflowAction<SignResponse, ApiConnectionActionConfiguration> Sign(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SignResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SignResponse>(callPayload);
            });
        }
    }

    public class IlovesignTriggers([ConnectionName] string connectionId)
    {
    }

    public class SignResponse
    {
        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputFileSourceType fileSource, string fileName)
        {
            this.FileSource = fileSource;
            this.FileName = fileName;
        }

        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("signers")]
        public string Signers { get; set; }

        [JsonProperty("signers_emails")]
        public string SignersEmails { get; set; }

        [JsonProperty("signs_positions")]
        public string SignsPositions { get; set; }

        [JsonProperty("sign_type")]
        public BodyInputSignTypeType? SignType { get; set; }

        [JsonProperty("expiration_days")]
        public string ExpirationDays { get; set; }

        [JsonProperty("signer_reminders")]
        public BodyInputSignerRemindersType? SignerReminders { get; set; }

        [JsonProperty("signer_reminder_days_cycle")]
        public string SignerReminderDaysCycle { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFileSourceType
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSignTypeType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "validator")]
        Validator,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSignerRemindersType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovesign;

    public partial class WorkflowManagedActions
    {
        public IlovesignActions Ilovesign(string connectionId) => new IlovesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IlovesignTriggers Ilovesign(string connectionId) => new IlovesignTriggers(connectionId);
    }
}