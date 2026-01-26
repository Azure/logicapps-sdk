//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcsemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult> GetMessageStatusGAVersion(Expression<Func<string>> operationId)
        {
            var apiCallPath = String.Format("/emails/operations/{0}", ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
            return new ApiConnectionAction<EmailSendResult>(callPayload);
        }
    }

    public class AcsemailTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmailSendResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public EmailSendResultStatusType Status { get; set; }

        [JsonProperty("error")]
        public ErrorDetail Error { get; set; }
    }

    public enum EmailSendResultStatusType
    {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        Canceled
    }

    public class ErrorDetail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("details")]
        public ErrorDetail[] Details { get; set; }

        [JsonProperty("additionalInfo")]
        public ErrorAdditionalInfo[] AdditionalInfo { get; set; }
    }

    public class ErrorAdditionalInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("info")]
        public JToken Info { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail;

    public partial class WorkflowManagedActions
    {
        public AcsemailActions Acsemail(string connectionId) => new AcsemailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcsemailTriggers Acsemail(string connectionId) => new AcsemailTriggers(connectionId);
    }
}