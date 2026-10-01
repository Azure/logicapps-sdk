//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Emaildomainchecker
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EmaildomaincheckerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "emaildomainchecker")]
        public IBodyWorkflowAction<CheckDomainResponse> CheckDomain([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<endpointInput> endpoint)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/checkDomain/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                callPayload.Queries["endpoint"] = SourceExpressionConverter.Convert(endpoint);
                callPayload.Headers["cf"] = Convert.ToString("sk");
                return callPayload;
            }

            return new ApiConnectionAction<CheckDomainResponse>(BuildSourceInput);
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