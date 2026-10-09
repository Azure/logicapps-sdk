//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._10to8
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _10to8Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "10to8")]
        [WorkflowExpressionFactory(nameof(__BuildBookAppointment))]
        public IBodyWorkflowAction<string> BookAppointment([WorkflowExpression] Func<string> organisationId, [WorkflowExpression] Func<string> bodystartDateTime, [WorkflowExpression] Func<string> bodyendDateTime, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildBookAppointment(WorkflowExpression<string> organisationId, WorkflowExpression<string> bodystartDateTime, WorkflowExpression<string> bodyendDateTime, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodydescription)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            WorkflowExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: true);
            WorkflowExpression.Validate(bodyendDateTime, nameof(bodyendDateTime), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["start"] = ExpressionConverter.ConvertO(bodystartDateTime);
                bodypropCount++;
                body["end"] = ExpressionConverter.ConvertO(bodyendDateTime);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class _10to8Triggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildGetAppointments))]
        public IBodyWorkflowTrigger<GetAppointmentsResponseItem[]> GetAppointments([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetAppointmentsResponseItem[]> __BuildGetAppointments(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<GetAppointmentsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetAppointmentsResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetCustomers))]
        public IBodyWorkflowTrigger<GetCustomersResponseItem[]> GetCustomers([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<GetCustomersResponseItem[]> __BuildGetCustomers(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<GetCustomersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/customers/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<GetCustomersResponseItem[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxIncomingMessagesAppeared))]
        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesAppeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IncomingMessage[]> __BuildGetInboxIncomingMessagesAppeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<IncomingMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/appeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<IncomingMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxIncomingMessagesDisappeared))]
        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesDisappeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<IncomingMessage[]> __BuildGetInboxIncomingMessagesDisappeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<IncomingMessage[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/disappeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<IncomingMessage[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxBookingRequestAppeared))]
        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestAppeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventProposal[]> __BuildGetInboxBookingRequestAppeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<EventProposal[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/appeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EventProposal[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxBookingRequestDisappeared))]
        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestDisappeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventProposal[]> __BuildGetInboxBookingRequestDisappeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<EventProposal[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/disappeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EventProposal[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxChangeCancellationRequestAppeared))]
        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestAppeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventProposal[]> __BuildGetInboxChangeCancellationRequestAppeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<EventProposal[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/appeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EventProposal[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildGetInboxChangeCancellationRequestDisappeared))]
        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestDisappeared([WorkflowExpression] Func<string> organisationId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventProposal[]> __BuildGetInboxChangeCancellationRequestDisappeared(WorkflowExpression<string> organisationId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organisationId, nameof(organisationId), required: true);
            return new DeferredBodyTrigger<EventProposal[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/disappeared/", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<EventProposal[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetAppointmentsResponseItem
    {
        [JsonProperty("start")]
        public string StartDateTime { get; set; }

        [JsonProperty("end")]
        public string EndDateTime { get; set; }

        [JsonProperty("name")]
        public string NameOfAppointment { get; set; }

        [JsonProperty("customers_name")]
        public string CustomerSName { get; set; }

        [JsonProperty("customers_email")]
        public string CustomerSEmailAddress { get; set; }

        [JsonProperty("customers_number")]
        public string CustomerSPhoneNumber { get; set; }

        [JsonProperty("id")]
        public int AppointmentIDNumber { get; set; }
    }

    public class GetCustomersResponseItem
    {
        [JsonProperty("name")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string CustomerSEmailAddress { get; set; }

        [JsonProperty("mobile_number")]
        public string CustomerSMobileNumber { get; set; }

        [JsonProperty("id")]
        public int CustomerIDNumber { get; set; }
    }

    public class IncomingMessage
    {
        [JsonProperty("from_name")]
        public string CustomerName { get; set; }

        [JsonProperty("from_contact")]
        public string PhoneNumberOrEmailAddress { get; set; }

        [JsonProperty("content")]
        public string MessageContent { get; set; }

        [JsonProperty("received")]
        public string ReceivedAtDateTime { get; set; }

        [JsonProperty("id")]
        public int MessageID { get; set; }
    }

    public class EventProposal
    {
        [JsonProperty("from_name")]
        public string CustomerName { get; set; }

        [JsonProperty("from_contact")]
        public string EmailAddressOrPhoneNumber { get; set; }

        [JsonProperty("appointment_name")]
        public string AppointmentName { get; set; }

        [JsonProperty("appointment_start")]
        public string AppointmentStartDateTime { get; set; }

        [JsonProperty("received")]
        public string RequestReceivedDateTime { get; set; }

        [JsonProperty("type")]
        public string TypeOfRequest { get; set; }

        [JsonProperty("id")]
        public int RequestIDNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._10to8;

    public partial class WorkflowManagedActions
    {
        public _10to8Actions _10to8(string connectionId) => new _10to8Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _10to8Triggers _10to8(string connectionId) => new _10to8Triggers(connectionId);
    }
}