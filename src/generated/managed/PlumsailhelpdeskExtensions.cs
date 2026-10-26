//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailhelpdesk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailhelpdeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead[], ApiConnectionActionConfiguration> FlowV4ContactsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<ContactRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<ContactRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4Contacts(Expression<Func<FlowV4ContactsPostInput>> contact = null, Expression<Func<bool>> updateIfExists = null)
        {
            var __workflow_contact = WorkflowExpression.Compile(contact, nameof(contact), required: false);
            var __workflow_updateIfExists = WorkflowExpression.Compile(updateIfExists, nameof(updateIfExists), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateIfExists"] = Convert.ToString(false);
                if (__workflow_updateIfExists != null)
                    callPayload.Queries["updateIfExists"] = ExpressionConverter.Convert(__workflow_updateIfExists);
                if (__workflow_contact != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_contact);
                return new ApiConnectionAction<ContactRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByEmailByEmailGet(Expression<Func<string>> email, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/ByEmail/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<ContactRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByEmailByEmailPut(Expression<Func<string>> email, Expression<Func<FlowV4ContactsByEmailByEmailPutInput>> contact = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_contact = WorkflowExpression.Compile(contact, nameof(contact), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/ByEmail/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contact != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_contact);
                return new ApiConnectionAction<ContactRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV4ContactsByIdDelete(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<ContactRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByIdPut(Expression<Func<int>> id, Expression<Func<FlowV4ContactsByIdPutInput>> contact = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_contact = WorkflowExpression.Compile(contact, nameof(contact), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contact != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_contact);
                return new ApiConnectionAction<ContactRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead[], ApiConnectionActionConfiguration> FlowV4OrganizationsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<OrganizationRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<OrganizationRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4Organizations(Expression<Func<FlowV4OrganizationsPostInput>> organization = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_organization != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_organization);
                return new ApiConnectionAction<OrganizationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV4OrganizationsByTitleByTitleDelete(Expression<Func<string>> title)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", __workflow_title.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByTitleByTitleGet(Expression<Func<string>> title, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", __workflow_title.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<OrganizationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByTitleByTitlePut(Expression<Func<string>> title, Expression<Func<FlowV4OrganizationsByTitleByTitlePutInput>> organization = null)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", __workflow_title.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_organization != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_organization);
                return new ApiConnectionAction<OrganizationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV4OrganizationsByIdDelete(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<OrganizationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByIdPut(Expression<Func<int>> id, Expression<Func<FlowV4OrganizationsByIdPutInput>> organization = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_organization != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_organization);
                return new ApiConnectionAction<OrganizationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead[], ApiConnectionActionConfiguration> FlowV4TicketsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredBodyAction<TicketRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                return new ApiConnectionAction<TicketRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead, ApiConnectionActionConfiguration> FlowV4Tickets(Expression<Func<FlowV4TicketsPostInput>> ticket = null)
        {
            var __workflow_ticket = WorkflowExpression.Compile(ticket, nameof(ticket), required: false);
            return new DeferredBodyAction<TicketRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ticket != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_ticket);
                return new ApiConnectionAction<TicketRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowV4TicketsByIdDelete(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead, ApiConnectionActionConfiguration> FlowV4TicketsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<TicketRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<TicketRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead, ApiConnectionActionConfiguration> FlowV4TicketsByIdPut(Expression<Func<int>> id, Expression<Func<FlowV4TicketsByIdPutInput>> ticket = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ticket = WorkflowExpression.Compile(ticket, nameof(ticket), required: false);
            return new DeferredBodyAction<TicketRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ticket != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_ticket);
                return new ApiConnectionAction<TicketRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlowV4TicketsByIdAttachmentsByFilenameGet(Expression<Func<int>> id, Expression<Func<string>> filename)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}/Attachments/{1}", __workflow_id.WithUrlEncoding(1), __workflow_filename.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead[], ApiConnectionActionConfiguration> FlowV4TicketsByTicketIdCommentsGet(Expression<Func<int>> ticketId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredBodyAction<CommentRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}/Comments", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction<CommentRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead, ApiConnectionActionConfiguration> FlowV4TicketsByTicketIdComments(Expression<Func<int>> ticketId, Expression<Func<FlowV4TicketsByTicketIdCommentsPostInput>> comment = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<CommentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}/Comments", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_comment != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_comment);
                return new ApiConnectionAction<CommentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead, ApiConnectionActionConfiguration> FlowV4TicketsByTicketIdCommentsByIdGet(Expression<Func<int>> ticketId, Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredBodyAction<CommentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}/Comments/{1}", __workflow_ticketId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                return new ApiConnectionAction<CommentRead>(callPayload);
            });
        }
    }

    public class PlumsailhelpdeskTriggers([ConnectionName] string connectionId)
    {
    }

    public class ContactRead
    {
        [JsonProperty("customFields")]
        public JToken ContactCustomFields { get; set; }

        [JsonProperty("email")]
        public string ContactEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("id")]
        public int ContactId { get; set; }

        [JsonProperty("role")]
        public string ContactRole { get; set; }

        [JsonProperty("spUserId")]
        public int ContactSPUserId { get; set; }

        [JsonProperty("title")]
        public string ContactFullName { get; set; }
    }

    public class FlowV4ContactsPostInput
    {
        [JsonProperty("customFields")]
        public JToken ContactCustomFields { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("role")]
        public string ContactRole { get; set; }

        [JsonProperty("spUserId")]
        public int? ContactSPUserId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }
    }

    public class FlowV4ContactsByEmailByEmailPutInput
    {
        [JsonProperty("customFields")]
        public JToken ContactCustomFields { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("role")]
        public string ContactRole { get; set; }

        [JsonProperty("spUserId")]
        public int? ContactSPUserId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }
    }

    public class FlowV4ContactsByIdPutInput
    {
        [JsonProperty("customFields")]
        public JToken ContactCustomFields { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string ContactAlternateEmail { get; set; }

        [JsonProperty("role")]
        public string ContactRole { get; set; }

        [JsonProperty("spUserId")]
        public int? ContactSPUserId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactName { get; set; }
    }

    public class OrganizationRead
    {
        [JsonProperty("customFields")]
        public JToken OrganizationCustomFields { get; set; }

        [JsonProperty("id")]
        public int OrganizationId { get; set; }

        [JsonProperty("title")]
        public string OrganizationTitle { get; set; }
    }

    public class FlowV4OrganizationsPostInput
    {
        [JsonProperty("customFields")]
        public JToken OrganizationCustomFields { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationTitle { get; set; }
    }

    public class FlowV4OrganizationsByTitleByTitlePutInput
    {
        [JsonProperty("customFields")]
        public JToken OrganizationCustomFields { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationTitle { get; set; }
    }

    public class FlowV4OrganizationsByIdPutInput
    {
        [JsonProperty("customFields")]
        public JToken OrganizationCustomFields { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganizationTitle { get; set; }
    }

    public class TicketRead
    {
        [JsonProperty("assignedTo")]
        public Assignee AssignedTo { get; set; }

        [JsonProperty("attachments")]
        public string[] TicketAttachments { get; set; }

        [JsonProperty("category")]
        public string TicketCategory { get; set; }

        [JsonProperty("cc")]
        public Cc[] TicketCc { get; set; }

        [JsonProperty("created")]
        public string TicketCreationDate { get; set; }

        [JsonProperty("customFields")]
        public JToken TicketCustomFields { get; set; }

        [JsonProperty("dueDate")]
        public string TicketDueDate { get; set; }

        [JsonProperty("id")]
        public int TicketId { get; set; }

        [JsonProperty("priority")]
        public string TicketPriority { get; set; }

        [JsonProperty("requester")]
        public Requester Requester { get; set; }

        [JsonProperty("resolutionDate")]
        public string TicketResolutionDate { get; set; }

        [JsonProperty("status")]
        public string TicketStatus { get; set; }

        [JsonProperty("subject")]
        public string TicketSubject { get; set; }

        [JsonProperty("tags")]
        public TagRead[] TicketTags { get; set; }

        [JsonProperty("ticketID")]
        public string CustomTicketId { get; set; }
    }

    public class Assignee
    {
        [JsonProperty("customFields")]
        public JToken AssigneeCustomFields { get; set; }

        [JsonProperty("email")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string AssigneeAlternateEmail { get; set; }

        [JsonProperty("id")]
        public int AssigneeId { get; set; }

        [JsonProperty("role")]
        public string AssigneeRole { get; set; }

        [JsonProperty("spUserId")]
        public int AssigneeSPUserId { get; set; }

        [JsonProperty("title")]
        public string AssigneeFullName { get; set; }
    }

    public class Cc
    {
        [JsonProperty("customFields")]
        public JToken CcCustomFields { get; set; }

        [JsonProperty("email")]
        public string CcEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string CcAlternateEmail { get; set; }

        [JsonProperty("id")]
        public int CcId { get; set; }

        [JsonProperty("role")]
        public string CcRole { get; set; }

        [JsonProperty("spUserId")]
        public int CcSPUserId { get; set; }

        [JsonProperty("title")]
        public string CcFullName { get; set; }
    }

    public class Requester
    {
        [JsonProperty("customFields")]
        public JToken RequesterCustomFields { get; set; }

        [JsonProperty("email")]
        public string RequesterEmail { get; set; }

        [JsonProperty("emailAlternate")]
        public string RequesterAlternateEmail { get; set; }

        [JsonProperty("id")]
        public int RequesterId { get; set; }

        [JsonProperty("role")]
        public string RequesterRole { get; set; }

        [JsonProperty("spUserId")]
        public int RequesterSPUserId { get; set; }

        [JsonProperty("title")]
        public string RequesterFullName { get; set; }
    }

    public class TagRead
    {
        [JsonProperty("customFields")]
        public JToken TagCustomFields { get; set; }

        [JsonProperty("id")]
        public int TagId { get; set; }

        [JsonProperty("title")]
        public string TagTitle { get; set; }
    }

    public class FlowV4TicketsPostInput
    {
        [JsonProperty("assignedToEmail")]
        public string TicketAssigneeEmailOrSharePointGroupName { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] TicketAttachments { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketBody { get; set; }

        [JsonProperty("category")]
        public string TicketCategory { get; set; }

        [JsonProperty("ccEmails")]
        public string[] TicketCcEmails { get; set; }

        [JsonProperty("customFields")]
        public JToken TicketCustomFields { get; set; }

        [JsonProperty("dueDate")]
        public string TicketDueDate { get; set; }

        [JsonProperty("priority")]
        public string TicketPriority { get; set; }

        [JsonProperty("requesterEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketRequesterEmail { get; set; }

        [JsonProperty("status")]
        public string TicketStatus { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketSubject { get; set; }

        [JsonProperty("supportChannel")]
        public string TicketSupportChannel { get; set; }

        [JsonProperty("tagTitles")]
        public string[] TicketTagsTitles { get; set; }
    }

    public class Attachment
    {
        public string AttachmentContent { get; set; }

        [JsonProperty("Name")]
        public string AttachmentFileName { get; set; }
    }

    public class FlowV4TicketsByIdPutInput
    {
        [JsonProperty("assignedToEmail")]
        public string TicketAssigneeEmailOrSharePointGroupName { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] TicketAttachments { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketBody { get; set; }

        [JsonProperty("category")]
        public string TicketCategory { get; set; }

        [JsonProperty("ccEmails")]
        public string[] TicketCcEmails { get; set; }

        [JsonProperty("customFields")]
        public JToken TicketCustomFields { get; set; }

        [JsonProperty("dueDate")]
        public string TicketDueDate { get; set; }

        [JsonProperty("priority")]
        public string TicketPriority { get; set; }

        [JsonProperty("requesterEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketRequesterEmail { get; set; }

        [JsonProperty("status")]
        public string TicketStatus { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TicketSubject { get; set; }

        [JsonProperty("supportChannel")]
        public string TicketSupportChannel { get; set; }

        [JsonProperty("tagTitles")]
        public string[] TicketTagsTitles { get; set; }
    }

    public class CommentRead
    {
        [JsonProperty("body")]
        public string CommentBody { get; set; }

        [JsonProperty("created")]
        public string CommentCreationDate { get; set; }

        [JsonProperty("customFields")]
        public JToken CommentCustomFields { get; set; }

        [JsonProperty("fromEmail")]
        public string CommentAuthorEmail { get; set; }

        [JsonProperty("fromName")]
        public string CommentAuthorName { get; set; }

        [JsonProperty("id")]
        public int CommentId { get; set; }

        [JsonProperty("messageId")]
        public string CommentMessageId { get; set; }
    }

    public class FlowV4TicketsByTicketIdCommentsPostInput
    {
        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentBody { get; set; }

        [JsonProperty("customFields")]
        public JToken CommentCustomFields { get; set; }

        [JsonProperty("fromEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommentAuthorEmail { get; set; }

        [JsonProperty("messageId")]
        public string CommentMessageId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailhelpdesk;

    public partial class WorkflowManagedActions
    {
        public PlumsailhelpdeskActions Plumsailhelpdesk(string connectionId) => new PlumsailhelpdeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlumsailhelpdeskTriggers Plumsailhelpdesk(string connectionId) => new PlumsailhelpdeskTriggers(connectionId);
    }
}