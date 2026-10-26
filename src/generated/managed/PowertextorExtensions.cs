//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Powertextor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PowertextorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToMultipleContactsResponse, ApiConnectionActionConfiguration> SendTextMessageToMultipleContacts(Expression<Func<SendTextMessageToMultipleContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageToMultipleContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForContactsResponse, ApiConnectionActionConfiguration> ScheduleReviewTextMessageForContacts(Expression<Func<ScheduleReviewTextMessageForContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewTextMessageForContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewcontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewTextMessageForContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToMultipleGroupsResponse, ApiConnectionActionConfiguration> SendTextMessageToMultipleGroups(Expression<Func<SendTextMessageToMultipleGroupsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageToMultipleGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageToMultipleGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextGroupsResponse, ApiConnectionActionConfiguration> SendReviewTextGroups(Expression<Func<SendReviewTextGroupsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewTextGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewTextGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleMessageForAContactResponse, ApiConnectionActionConfiguration> ScheduleMessageForAContact(Expression<Func<ScheduleMessageForAContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleMessageForAContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleMessageForAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleMessageForGroupsResponse, ApiConnectionActionConfiguration> ScheduleMessageForGroups(Expression<Func<ScheduleMessageForGroupsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleMessageForGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextbulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleMessageForGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewMessageForAContactResponse, ApiConnectionActionConfiguration> ScheduleReviewMessageForAContact(Expression<Func<ScheduleReviewMessageForAContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewMessageForAContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewtext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewMessageForAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewGroupsResponse, ApiConnectionActionConfiguration> ScheduleReviewGroups(Expression<Func<ScheduleReviewGroupsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduledbulkreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextToAContactResponse, ApiConnectionActionConfiguration> SendTextToAContact(Expression<Func<SendTextToAContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextToAContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendmessagesinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextToAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextToMultipleContactsResponse, ApiConnectionActionConfiguration> ScheduleTextToMultipleContacts(Expression<Func<ScheduleTextToMultipleContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleTextToMultipleContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextmulticontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleTextToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewSingleContactResponse, ApiConnectionActionConfiguration> SendReviewSingleContact(Expression<Func<SendReviewSingleContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewSingleContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendereviewsinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewSingleContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMultipleContactsResponse, ApiConnectionActionConfiguration> SendReviewTextMultipleContacts(Expression<Func<SendReviewTextMultipleContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewTextMultipleContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendereviewmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewTextMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToAContactResponse, ApiConnectionActionConfiguration> SendTextMessageEventReminderToAContact(Expression<Func<SendTextMessageEventReminderToAContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageEventReminderToAContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendreminderssinglecontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageEventReminderToAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToMultipleContactsResponse, ApiConnectionActionConfiguration> SendTextMessageEventReminderToMultipleContacts(Expression<Func<SendTextMessageEventReminderToMultipleContactsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageEventReminderToMultipleContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendremindersmulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageEventReminderToMultipleContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageEventReminderToGroupsResponse, ApiConnectionActionConfiguration> SendTextMessageEventReminderToGroups(Expression<Func<SendTextMessageEventReminderToGroupsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageEventReminderToGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendremindertogroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageEventReminderToGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToANumberResponse, ApiConnectionActionConfiguration> SendTextMessageToANumber(Expression<Func<SendTextMessageToANumberInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageToANumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendsimple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageToANumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageForAGroupResponse, ApiConnectionActionConfiguration> ScheduleReviewTextMessageForAGroup(Expression<Func<ScheduleReviewTextMessageForAGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewTextMessageForAGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduledsingleGroupreview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewTextMessageForAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextMessagesForAGroupResponse, ApiConnectionActionConfiguration> ScheduleTextMessagesForAGroup(Expression<Func<ScheduleTextMessagesForAGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleTextMessagesForAGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextsingleGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleTextMessagesForAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextEventReminderToAGroupResponse, ApiConnectionActionConfiguration> SendTextEventReminderToAGroup(Expression<Func<SendTextEventReminderToAGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextEventReminderToAGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendremindertosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextEventReminderToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMessageToAGroupResponse, ApiConnectionActionConfiguration> SendReviewTextMessageToAGroup(Expression<Func<SendReviewTextMessageToAGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewTextMessageToAGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendreviewtosinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewTextMessageToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageToAGroupResponse, ApiConnectionActionConfiguration> SendTextMessageToAGroup(Expression<Func<SendTextMessageToAGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageToAGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendsinglegroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageToAGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextToANewGroupResponse, ApiConnectionActionConfiguration> SendTextToANewGroup(Expression<Func<SendTextToANewGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextToANewGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/creategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextForANewGroupResponse, ApiConnectionActionConfiguration> ScheduleTextForANewGroup(Expression<Func<ScheduleTextForANewGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleTextForANewGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduledcreategroupsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleTextForANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextEventReminderToNewGroupResponse, ApiConnectionActionConfiguration> SendTextEventReminderToNewGroup(Expression<Func<SendTextEventReminderToNewGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextEventReminderToNewGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/creategroupremindersend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextEventReminderToNewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageToANewContactResponse, ApiConnectionActionConfiguration> SendMessageToANewContact(Expression<Func<SendMessageToANewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageToANewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendsimplewithName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewTextMessageToANewContactResponse, ApiConnectionActionConfiguration> ScheduleReviewTextMessageToANewContact(Expression<Func<ScheduleReviewTextMessageToANewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewTextMessageToANewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/schedulereviewtextwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewTextMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewTextMessageToANewContactResponse, ApiConnectionActionConfiguration> SendReviewTextMessageToANewContact(Expression<Func<SendReviewTextMessageToANewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewTextMessageToANewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/createcontactreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewTextMessageToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleReviewToANewGroupResponse, ApiConnectionActionConfiguration> ScheduleReviewToANewGroup(Expression<Func<ScheduleReviewToANewGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleReviewToANewGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/creategroupschedulereview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleReviewToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendReviewToANewGroupResponse, ApiConnectionActionConfiguration> SendReviewToANewGroup(Expression<Func<SendReviewToANewGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendReviewToANewGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/creategroupreviewsend";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendReviewToANewGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<ScheduleTextForANewContactResponse, ApiConnectionActionConfiguration> ScheduleTextForANewContact(Expression<Func<ScheduleTextForANewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ScheduleTextForANewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/scheduletextwithname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ScheduleTextForANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<CreateAContactResponse, ApiConnectionActionConfiguration> CreateAContact(Expression<Func<CreateAContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contacts/contactnew";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageEventReminderToANewContactResponse, ApiConnectionActionConfiguration> SendMessageEventReminderToANewContact(Expression<Func<SendMessageEventReminderToANewContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageEventReminderToANewContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendreminderwithcontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageEventReminderToANewContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<UpdateAPowerTextorContactResponse, ApiConnectionActionConfiguration> UpdateAPowerTextorContact(Expression<Func<UpdateAPowerTextorContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateAPowerTextorContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contacts/contactupdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateAPowerTextorContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendMessageToMultipleNumbersResponse, ApiConnectionActionConfiguration> SendMessageToMultipleNumbers(Expression<Func<SendMessageToMultipleNumbersInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendMessageToMultipleNumbersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendtomulticontact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendMessageToMultipleNumbersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "powertextor")]
        public IBodyWorkflowAction<SendTextMessageResponse, ApiConnectionActionConfiguration> SendTextMessage(Expression<Func<SendTextMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendTextMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages/sendsimpletext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendTextMessageResponse>(callPayload);
            });
        }
    }

    public class PowertextorTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ProductionWebhook(Expression<Func<ProductionWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/twilio/registration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> MMSWebhook(Expression<Func<MMSWebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/twilio/MMSregistration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendTextMessageToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageToMultipleContactsResponseErrorType Error { get; set; }
        public SendTextMessageToMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageToMultipleContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponse
    {
        public ScheduleReviewTextMessageForContactsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public ScheduleReviewTextMessageForContactsResponseErrorType Error { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageForContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GooglePlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
    }

    public class SendTextMessageToMultipleGroupsResponse
    {
        public SendTextMessageToMultipleGroupsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class SendTextMessageToMultipleGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToMultipleGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendReviewTextGroupsResponse
    {
        public SendReviewTextGroupsResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class SendReviewTextGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleMessageForAContactResponse
    {
        public bool Success { get; set; }
        public ScheduleMessageForAContactResponseErrorType Error { get; set; }
        public ScheduleMessageForAContactResponseDataType Data { get; set; }
    }

    public class ScheduleMessageForAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleMessageForAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleMessageForAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleMessageForAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleMessageForAContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
    }

    public class ScheduleMessageForGroupsResponse
    {
        public bool Success { get; set; }
        public ScheduleMessageForGroupsResponseErrorType Error { get; set; }
        public ScheduleMessageForGroupsResponseDataType Data { get; set; }
    }

    public class ScheduleMessageForGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleMessageForGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleMessageForGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleMessageForGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleMessageForGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewMessageForAContactResponseErrorType Error { get; set; }
        public ScheduleReviewMessageForAContactResponseDataType Data { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewMessageForAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewMessageForAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewMessageForAContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GooglePlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleReviewGroupsResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewGroupsResponseErrorType Error { get; set; }
        public ScheduleReviewGroupsResponseDataType Data { get; set; }
    }

    public class ScheduleReviewGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextToAContactResponse
    {
        public SendTextToAContactResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextToAContactResponseErrorType Error { get; set; }
    }

    public class SendTextToAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextToAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextToAContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public ScheduleTextToMultipleContactsResponseErrorType Error { get; set; }
        public ScheduleTextToMultipleContactsResponseDataType Data { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleTextToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleTextToMultipleContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
    }

    public class SendReviewSingleContactResponse
    {
        public bool Success { get; set; }
        public SendReviewSingleContactResponseErrorType Error { get; set; }
        public SendReviewSingleContactResponseDataType Data { get; set; }
    }

    public class SendReviewSingleContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewSingleContactResponseDataType
    {
        public string MessageId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string ReferenceId { get; set; }
        public string Direction { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public string CampaignId { get; set; }
        public int Rating { get; set; }
        public int Segments { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
        public string CreatedAt { get; set; }
        public SendReviewSingleContactResponseDataTypeAccountType Account { get; set; }
        public SendReviewSingleContactResponseDataTypeContactType Contact { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeAccountType
    {
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string ServicePhone { get; set; }
        public string StripeCustomerId { get; set; }
        public string StripeSubscriptionId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeContactType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public SendReviewSingleContactResponseDataTypeContactTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class SendReviewSingleContactResponseDataTypeContactTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewSingleContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GooglePlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendReviewTextMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMultipleContactsResponseErrorType Error { get; set; }
        public SendReviewTextMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMultipleContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GooglePlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToAContactResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToAContactResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToAContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToMultipleContactsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToMultipleContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponse
    {
        public bool Success { get; set; }
        public SendTextMessageEventReminderToGroupsResponseErrorType Error { get; set; }
        public SendTextMessageEventReminderToGroupsResponseDataType Data { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageEventReminderToGroupsResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageEventReminderToGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageToANumberResponse
    {
        public SendTextMessageToANumberResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextMessageToANumberResponseErrorType Error { get; set; }
    }

    public class SendTextMessageToANumberResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToANumberResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToANumberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseErrorType Error { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseDataType Data { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewTextMessageForAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewTextMessageForAGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleTextMessagesForAGroupResponse
    {
        public ScheduleTextMessagesForAGroupResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public string Error { get; set; }
    }

    public class ScheduleTextMessagesForAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextMessagesForAGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextEventReminderToAGroupResponse
    {
        public bool Success { get; set; }
        public SendTextEventReminderToAGroupResponseErrorType Error { get; set; }
        public SendTextEventReminderToAGroupResponseDataType Data { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextEventReminderToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextEventReminderToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextEventReminderToAGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMessageToAGroupResponseErrorType Error { get; set; }
        public SendReviewTextMessageToAGroupResponseDataType Data { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMessageToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMessageToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMessageToAGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageToAGroupResponse
    {
        public bool Success { get; set; }
        public SendTextMessageToAGroupResponseErrorType Error { get; set; }
        public SendTextMessageToAGroupResponseDataType Data { get; set; }
    }

    public class SendTextMessageToAGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageToAGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendTextMessageToAGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageToAGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendTextMessageToAGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextToANewGroupResponse
    {
        public bool Success { get; set; }
        public SendTextToANewGroupResponseErrorType Error { get; set; }
        public SendTextToANewGroupResponseDataType Data { get; set; }
    }

    public class SendTextToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextToANewGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleTextForANewGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleTextForANewGroupResponseErrorType Error { get; set; }
        public ScheduleTextForANewGroupResponseDataType Data { get; set; }
    }

    public class ScheduleTextForANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextForANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextForANewGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponse
    {
        public bool Success { get; set; }
        public SendTextEventReminderToNewGroupResponseErrorType Error { get; set; }
        public SendTextEventReminderToNewGroupResponseDataType Data { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextEventReminderToNewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextEventReminderToNewGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public SendMessageToANewContactResponseErrorType Error { get; set; }
        public SendMessageToANewContactResponseDataType Data { get; set; }
    }

    public class SendMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendMessageToANewContactInput
    {
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseErrorType Error { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseDataType Data { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewTextMessageToANewContactInput
    {
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GooglePlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponse
    {
        public bool Success { get; set; }
        public SendReviewTextMessageToANewContactResponseErrorType Error { get; set; }
        public SendReviewTextMessageToANewContactResponseDataType Data { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewTextMessageToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewTextMessageToANewContactInput
    {
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleReviewToANewGroupResponse
    {
        public bool Success { get; set; }
        public ScheduleReviewToANewGroupResponseErrorType Error { get; set; }
        public ScheduleReviewToANewGroupResponseDataType Data { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleReviewToANewGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleReviewToANewGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleReviewToANewGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendReviewToANewGroupResponse
    {
        public bool Success { get; set; }
        public SendReviewToANewGroupResponseErrorType Error { get; set; }
        public SendReviewToANewGroupResponseDataType Data { get; set; }
    }

    public class SendReviewToANewGroupResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendReviewToANewGroupResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendReviewToANewGroupResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendReviewToANewGroupResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendReviewToANewGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReviewText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlaceId { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ScheduleTextForANewContactResponse
    {
        public bool Success { get; set; }
        public ScheduleTextForANewContactResponseErrorType Error { get; set; }
        public ScheduleTextForANewContactResponseDataType Data { get; set; }
    }

    public class ScheduleTextForANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class ScheduleTextForANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public ScheduleTextForANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class ScheduleTextForANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class ScheduleTextForANewContactInput
    {
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScheduledTime { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class CreateAContactResponse
    {
        public bool Success { get; set; }
        public CreateAContactResponseErrorType Error { get; set; }
        public CreateAContactResponseDataType Data { get; set; }
    }

    public class CreateAContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class CreateAContactResponseDataType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public CreateAContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class CreateAContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class CreateAContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponse
    {
        public bool Success { get; set; }
        public SendMessageEventReminderToANewContactResponseErrorType Error { get; set; }
        public SendMessageEventReminderToANewContactResponseDataType Data { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public SendMessageEventReminderToANewContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageEventReminderToANewContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendMessageEventReminderToANewContactInput
    {
        public string ContactName { get; set; }
        public string ContactLastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReminderText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Time { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class UpdateAPowerTextorContactResponse
    {
        public bool Success { get; set; }
        public UpdateAPowerTextorContactResponseErrorType Error { get; set; }
        public UpdateAPowerTextorContactResponseDataType Data { get; set; }
    }

    public class UpdateAPowerTextorContactResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class UpdateAPowerTextorContactResponseDataType
    {
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public bool WelcomeSent { get; set; }
        public string Status { get; set; }
        public UpdateAPowerTextorContactResponseDataTypeGroupsTypeItem[] Groups { get; set; }
    }

    public class UpdateAPowerTextorContactResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public int ContactsCount { get; set; }
    }

    public class UpdateAPowerTextorContactInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Contact { get; set; }
        public string UpdatedContactName { get; set; }
        public string UpdatedContactLastName { get; set; }
        public string UpdatedContactNumber { get; set; }
    }

    public class SendMessageToMultipleNumbersResponse
    {
        public bool Success { get; set; }
        public SendMessageToMultipleNumbersResponseErrorType Error { get; set; }
        public SendMessageToMultipleNumbersResponseDataType Data { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public SendMessageToMultipleNumbersResponseDataTypeGroupsTypeItem[] Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendMessageToMultipleNumbersResponseDataTypeGroupsTypeItem
    {
        public string GroupId { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public int ContactsCount { get; set; }
    }

    public class SendMessageToMultipleNumbersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class SendTextMessageResponse
    {
        public SendTextMessageResponseDataType Data { get; set; }
        public bool Success { get; set; }
        public SendTextMessageResponseErrorType Error { get; set; }
    }

    public class SendTextMessageResponseDataType
    {
        public string CampaignId { get; set; }
        public string AccountId { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public string SendDate { get; set; }
        public string PlaceId { get; set; }
        public string Status { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool IsReminder { get; set; }
        public string Groups { get; set; }
        public int Reach { get; set; }
        public int SentCount { get; set; }
        public int UndeliveredCount { get; set; }
    }

    public class SendTextMessageResponseErrorType
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class SendTextMessageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }
        public bool? ReplySTOPToOptOut { get; set; }
    }

    public class ProductionWebhookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
    }

    public class MMSWebhookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebHookUri { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Powertextor;

    public partial class WorkflowManagedActions
    {
        public PowertextorActions Powertextor(string connectionId) => new PowertextorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PowertextorTriggers Powertextor(string connectionId) => new PowertextorTriggers(connectionId);
    }
}