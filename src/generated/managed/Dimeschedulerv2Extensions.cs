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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateAppointment(Expression<Func<CreateAppointmentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UpdateAppointment(Expression<Func<UpdateAppointmentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DeleteAppointment(Expression<Func<DeleteAppointmentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/AppointmentDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateAppointmentInput
    {
        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Create"
        };
    }

    public class UpdateAppointmentInput
    {
        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Appointments";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] ChangeType { get; set; } = new string[]
        {
            "Update"
        };
    }

    public class DeleteAppointmentInput
    {
        [JsonProperty("sourceApp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceApp { get; set; }

        [JsonProperty("notificationURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationURL { get; set; } = "#{listCallbackUrl()}";

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