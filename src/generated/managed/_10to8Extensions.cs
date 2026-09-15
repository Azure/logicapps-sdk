//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._10to8
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _10to8Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "10to8")]
        public IBodyWorkflowAction<string> BookAppointment(Expression<Func<string>> organisationId, Expression<Func<string>> bodystartDateTime, Expression<Func<string>> bodyendDateTime, Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["start"] = CSharpExpressionConverter.ConvertToken(bodystartDateTime);
            bodypropCount++;
            body["end"] = CSharpExpressionConverter.ConvertToken(bodyendDateTime);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class _10to8Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetAppointmentsResponseItem[]> GetAppointments(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetAppointmentsResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetCustomersResponseItem[]> GetCustomers(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/customers/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetCustomersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesAppeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/appeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncomingMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesDisappeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/disappeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<IncomingMessage[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestAppeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/appeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EventProposal[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestDisappeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/disappeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EventProposal[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestAppeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/appeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EventProposal[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestDisappeared(Expression<Func<string>> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/disappeared/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<EventProposal[]>(callPayload, triggerName, recurrence);
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