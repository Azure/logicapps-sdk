//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emaildomainchecker
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmaildomaincheckerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emaildomainchecker")]
        [WorkflowExpressionFactory(nameof(__BuildCheckDomain))]
        public IBodyWorkflowAction<CheckDomainResponse> CheckDomain([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<endpointInput> endpoint)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emaildomainchecker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckDomainResponse> __BuildCheckDomain(WorkflowExpression<string> domain, WorkflowExpression<endpointInput> endpoint)
        {
            WorkflowExpression.Validate(domain, nameof(domain), required: true);
            WorkflowExpression.Validate(endpoint, nameof(endpoint), required: true);
            return new DeferredBodyAction<CheckDomainResponse>(() =>
            {
                var apiCallPath = "/checkDomain/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                callPayload.Queries["endpoint"] = ExpressionConverter.Convert(endpoint);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return new ApiConnectionAction<CheckDomainResponse>(callPayload);
            });
        }
    }

    public class EmaildomaincheckerTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckDomainResponse
    {
        [JsonProperty("valid_email_domain")]
        public bool ValidEmailDomain { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("email_delivered_to")]
        public string EmailDeliveredTo { get; set; }

        [JsonProperty("email_delivered_to_array")]
        public string[] EmailDeliveredToArray { get; set; }

        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }

        [JsonProperty("message_from_developer")]
        public string MessageFromDeveloper { get; set; }
    }

    public enum endpointInput
    {
        RapidAPI,
        Blobr
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Emaildomainchecker;

    public partial class WorkflowManagedActions
    {
        public EmaildomaincheckerActions Emaildomainchecker(string connectionId) => new EmaildomaincheckerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EmaildomaincheckerTriggers Emaildomainchecker(string connectionId) => new EmaildomaincheckerTriggers(connectionId);
    }
}