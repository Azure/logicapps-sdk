//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftbookings
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftbookingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftbookings")]
        public IBodyWorkflowAction<ListMailboxResponse, ApiConnectionActionConfiguration> ListBookingsBusinessUserAsAdmin()
        {
            return new DeferredBodyAction<ListMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BookingsService/api/V1/bookingBusinessesUserAsAdmin";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Prefer-OWAUserConfig"] = Convert.ToString("true");
                return new ApiConnectionAction<ListMailboxResponse>(callPayload);
            });
        }
    }

    public class MicrosoftbookingsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Webhookresponse, ApiConnectionPollingTriggerConfiguration> CreateAppointment(Expression<Func<string>> sMTPAddress)
        {
            var __workflow_sMTPAddress = WorkflowExpression.Compile(sMTPAddress, nameof(sMTPAddress), required: true);
            return new DeferredBodyTrigger<Webhookresponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/BookingsService/api/V1/bookingBusinesses/{0}/webhook/AppointmentCreated", __workflow_sMTPAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CreateAppointmentBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<Webhookresponse>(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UpdateAppointment(Expression<Func<string>> sMTPAddress)
        {
            var __workflow_sMTPAddress = WorkflowExpression.Compile(sMTPAddress, nameof(sMTPAddress), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/BookingsService/api/V1/bookingBusinesses/{0}/webhook/AppointmentUpdated", __workflow_sMTPAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new UpdateAppointmentBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CancelAppointment(Expression<Func<string>> sMTPAddress)
        {
            var __workflow_sMTPAddress = WorkflowExpression.Compile(sMTPAddress, nameof(sMTPAddress), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/BookingsService/api/V1/bookingBusinesses/{0}/webhook/AppointmentDeleted", __workflow_sMTPAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CancelAppointmentBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
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

    public class Webhookresponse
    {
        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }
    }

    public class CreateAppointmentBodyInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAppointmentBodyInputWebhookType Webhook { get; set; } = new CreateAppointmentBodyInputWebhookType();
    }

    public class CreateAppointmentBodyInputWebhookType
    {
        [JsonProperty("notification_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("change_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Created"
        };
    }

    public class UpdateAppointmentBodyInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateAppointmentBodyInputWebhookType Webhook { get; set; } = new UpdateAppointmentBodyInputWebhookType();
    }

    public class UpdateAppointmentBodyInputWebhookType
    {
        [JsonProperty("notification_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("change_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Updated"
        };
    }

    public class CancelAppointmentBodyInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        public CancelAppointmentBodyInputWebhookType Webhook { get; set; } = new CancelAppointmentBodyInputWebhookType();
    }

    public class CancelAppointmentBodyInputWebhookType
    {
        [JsonProperty("notification_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("change_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Deleted"
        };
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftbookings;

    public partial class WorkflowManagedActions
    {
        public MicrosoftbookingsActions Microsoftbookings(string connectionId) => new MicrosoftbookingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftbookingsTriggers Microsoftbookings(string connectionId) => new MicrosoftbookingsTriggers(connectionId);
    }
}