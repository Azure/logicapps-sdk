//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dimeschedulerv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Dimeschedulerv2Actions([ConnectionName] string connectionId)
    {
    }

    public class Dimeschedulerv2Triggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CreateAppointment(Expression<Func<CreateAppointmentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> UpdateAppointment(Expression<Func<UpdateAppointmentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> DeleteAppointment(Expression<Func<DeleteAppointmentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class CreateAppointmentBodyInput
    {
        public CreateAppointmentBodyInput(string sourceApp)
        {
            this.SourceApp = sourceApp;
        }

        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Create"
        };
    }

    public class UpdateAppointmentBodyInput
    {
        public UpdateAppointmentBodyInput(string sourceApp)
        {
            this.SourceApp = sourceApp;
        }

        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Update"
        };
    }

    public class DeleteAppointmentBodyInput
    {
        public DeleteAppointmentBodyInput(string sourceApp)
        {
            this.SourceApp = sourceApp;
        }

        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Delete"
        };
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dimeschedulerv2;

    public partial class WorkflowManagedActions
    {
        public Dimeschedulerv2Actions Dimeschedulerv2(string connectionId) => new Dimeschedulerv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Dimeschedulerv2Triggers Dimeschedulerv2(string connectionId) => new Dimeschedulerv2Triggers(connectionId);
    }
}