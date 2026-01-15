//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Microsoftbookings
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftbookingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftbookings")]
        public IBodyWorkflowAction<ListMailboxResponse> ListBookingsBusinessUserAsAdmin()
        {
            var apiCallPath = "/BookingsService/api/V1/bookingBusinessesUserAsAdmin";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Prefer-OWAUserConfig"] = Convert.ToString("true");
            return new ApiConnectionAction<ListMailboxResponse>(callPayload);
        }
    }

    public class MicrosoftbookingsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListMailboxResponse
    {
        [JsonProperty("mailboxes")]
        public MailboxEntity[] Mailboxes { get; set; }
    }

    public class MailboxEntity
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Microsoftbookings;

    public partial class WorkflowManagedActions
    {
        public MicrosoftbookingsActions Microsoftbookings(string connectionId) => new MicrosoftbookingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftbookingsTriggers Microsoftbookings(string connectionId) => new MicrosoftbookingsTriggers(connectionId);
    }
}