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
        public IBodyWorkflowAction<string> BookAppointment([WorkflowExpression] Func<string> organisationId, [WorkflowExpression] Func<string> bodystartDateTime, [WorkflowExpression] Func<string> bodyendDateTime, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            SourceExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: true);
            SourceExpression.Validate(bodyendDateTime, nameof(bodyendDateTime), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["start"] = SourceExpressionConverter.ConvertToken(bodystartDateTime);
                bodypropCount++;
                body["end"] = SourceExpressionConverter.ConvertToken(bodyendDateTime);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class _10to8Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetAppointmentsResponseItem[]> GetAppointments([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/appointments/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetAppointmentsResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetCustomersResponseItem[]> GetCustomers([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/customers/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<GetCustomersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesAppeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/appeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IncomingMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IncomingMessage[]> GetInboxIncomingMessagesDisappeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/incoming-messages/disappeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<IncomingMessage[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestAppeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/appeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EventProposal[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxBookingRequestDisappeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/booking-proposals/disappeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EventProposal[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestAppeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/appeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EventProposal[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventProposal[]> GetInboxChangeCancellationRequestDisappeared([WorkflowExpression] Func<string> organisationId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organisationId, nameof(organisationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/microsoft-flow/v1/{0}/inbox/rebook-cancellation-proposals/disappeared/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<EventProposal[]>(BuildSourceInput, triggerName, recurrence);
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