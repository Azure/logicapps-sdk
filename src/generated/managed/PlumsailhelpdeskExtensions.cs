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
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4Contacts(Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null, Expression<Func<bool>> updateIfExists = null)
        {
            var __workflow_contactcontactEmail = WorkflowExpression.Compile(contactcontactEmail, nameof(contactcontactEmail), required: true);
            var __workflow_contactcontactName = WorkflowExpression.Compile(contactcontactName, nameof(contactcontactName), required: true);
            var __workflow_contactcontactAlternateEmail = WorkflowExpression.Compile(contactcontactAlternateEmail, nameof(contactcontactAlternateEmail), required: false);
            var __workflow_contactcontactRole = WorkflowExpression.Compile(contactcontactRole, nameof(contactcontactRole), required: false);
            var __workflow_contactcontactSPUserId = WorkflowExpression.Compile(contactcontactSPUserId, nameof(contactcontactSPUserId), required: false);
            var __workflow_updateIfExists = WorkflowExpression.Compile(updateIfExists, nameof(updateIfExists), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateIfExists"] = Convert.ToString(false);
                if (__workflow_updateIfExists != null)
                    callPayload.Queries["updateIfExists"] = ExpressionConverter.Convert(__workflow_updateIfExists);
                var contact = new JObject();
                var contactpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    contact["customFields"] = customFieldsObject;
                    contactpropCount++;
                }

                contactpropCount++;
                contact["email"] = ExpressionConverter.ConvertO(__workflow_contactcontactEmail);
                if (__workflow_contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = ExpressionConverter.ConvertO(__workflow_contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (__workflow_contactcontactRole != null)
                {
                    contact["role"] = ExpressionConverter.ConvertO(__workflow_contactcontactRole);
                    contactpropCount++;
                }

                if (__workflow_contactcontactSPUserId != null)
                {
                    contact["spUserId"] = ExpressionConverter.ConvertO(__workflow_contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = ExpressionConverter.ConvertO(__workflow_contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }

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
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByEmailByEmailPut(Expression<Func<string>> email, Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_contactcontactEmail = WorkflowExpression.Compile(contactcontactEmail, nameof(contactcontactEmail), required: true);
            var __workflow_contactcontactName = WorkflowExpression.Compile(contactcontactName, nameof(contactcontactName), required: true);
            var __workflow_contactcontactAlternateEmail = WorkflowExpression.Compile(contactcontactAlternateEmail, nameof(contactcontactAlternateEmail), required: false);
            var __workflow_contactcontactRole = WorkflowExpression.Compile(contactcontactRole, nameof(contactcontactRole), required: false);
            var __workflow_contactcontactSPUserId = WorkflowExpression.Compile(contactcontactSPUserId, nameof(contactcontactSPUserId), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/ByEmail/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var contact = new JObject();
                var contactpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    contact["customFields"] = customFieldsObject;
                    contactpropCount++;
                }

                contactpropCount++;
                contact["email"] = ExpressionConverter.ConvertO(__workflow_contactcontactEmail);
                if (__workflow_contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = ExpressionConverter.ConvertO(__workflow_contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (__workflow_contactcontactRole != null)
                {
                    contact["role"] = ExpressionConverter.ConvertO(__workflow_contactcontactRole);
                    contactpropCount++;
                }

                if (__workflow_contactcontactSPUserId != null)
                {
                    contact["spUserId"] = ExpressionConverter.ConvertO(__workflow_contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = ExpressionConverter.ConvertO(__workflow_contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }

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
        public IBodyWorkflowAction<ContactRead, ApiConnectionActionConfiguration> FlowV4ContactsByIdPut(Expression<Func<int>> id, Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_contactcontactEmail = WorkflowExpression.Compile(contactcontactEmail, nameof(contactcontactEmail), required: true);
            var __workflow_contactcontactName = WorkflowExpression.Compile(contactcontactName, nameof(contactcontactName), required: true);
            var __workflow_contactcontactAlternateEmail = WorkflowExpression.Compile(contactcontactAlternateEmail, nameof(contactcontactAlternateEmail), required: false);
            var __workflow_contactcontactRole = WorkflowExpression.Compile(contactcontactRole, nameof(contactcontactRole), required: false);
            var __workflow_contactcontactSPUserId = WorkflowExpression.Compile(contactcontactSPUserId, nameof(contactcontactSPUserId), required: false);
            return new DeferredBodyAction<ContactRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Contacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var contact = new JObject();
                var contactpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    contact["customFields"] = customFieldsObject;
                    contactpropCount++;
                }

                contactpropCount++;
                contact["email"] = ExpressionConverter.ConvertO(__workflow_contactcontactEmail);
                if (__workflow_contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = ExpressionConverter.ConvertO(__workflow_contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (__workflow_contactcontactRole != null)
                {
                    contact["role"] = ExpressionConverter.ConvertO(__workflow_contactcontactRole);
                    contactpropCount++;
                }

                if (__workflow_contactcontactSPUserId != null)
                {
                    contact["spUserId"] = ExpressionConverter.ConvertO(__workflow_contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = ExpressionConverter.ConvertO(__workflow_contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }

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
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4Organizations(Expression<Func<string>> organizationorganizationTitle)
        {
            var __workflow_organizationorganizationTitle = WorkflowExpression.Compile(organizationorganizationTitle, nameof(organizationorganizationTitle), required: true);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var organization = new JObject();
                var organizationpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    organization["customFields"] = customFieldsObject;
                    organizationpropCount++;
                }

                organizationpropCount++;
                organization["title"] = ExpressionConverter.ConvertO(__workflow_organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }

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
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByTitleByTitlePut(Expression<Func<string>> title, Expression<Func<string>> organizationorganizationTitle)
        {
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: true);
            var __workflow_organizationorganizationTitle = WorkflowExpression.Compile(organizationorganizationTitle, nameof(organizationorganizationTitle), required: true);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", __workflow_title.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var organization = new JObject();
                var organizationpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    organization["customFields"] = customFieldsObject;
                    organizationpropCount++;
                }

                organizationpropCount++;
                organization["title"] = ExpressionConverter.ConvertO(__workflow_organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }

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
        public IBodyWorkflowAction<OrganizationRead, ApiConnectionActionConfiguration> FlowV4OrganizationsByIdPut(Expression<Func<int>> id, Expression<Func<string>> organizationorganizationTitle)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_organizationorganizationTitle = WorkflowExpression.Compile(organizationorganizationTitle, nameof(organizationorganizationTitle), required: true);
            return new DeferredBodyAction<OrganizationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Organizations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var organization = new JObject();
                var organizationpropCount = 0;
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    organization["customFields"] = customFieldsObject;
                    organizationpropCount++;
                }

                organizationpropCount++;
                organization["title"] = ExpressionConverter.ConvertO(__workflow_organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }

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
        public IBodyWorkflowAction<TicketRead, ApiConnectionActionConfiguration> FlowV4Tickets(Expression<Func<string>> ticketticketBody, Expression<Func<string>> ticketticketRequesterEmail, Expression<Func<string>> ticketticketSubject, Expression<Func<string>> ticketticketAssigneeEmailOrSharePointGroupName = null, Expression<Func<Attachment[]>> ticketticketAttachments = null, Expression<Func<string>> ticketticketCategory = null, Expression<Func<string[]>> ticketticketCcEmails = null, Expression<Func<string>> ticketticketDueDate = null, Expression<Func<string>> ticketticketPriority = null, Expression<Func<string>> ticketticketStatus = null, Expression<Func<string>> ticketticketSupportChannel = null, Expression<Func<string[]>> ticketticketTagsTitles = null)
        {
            var __workflow_ticketticketBody = WorkflowExpression.Compile(ticketticketBody, nameof(ticketticketBody), required: true);
            var __workflow_ticketticketRequesterEmail = WorkflowExpression.Compile(ticketticketRequesterEmail, nameof(ticketticketRequesterEmail), required: true);
            var __workflow_ticketticketSubject = WorkflowExpression.Compile(ticketticketSubject, nameof(ticketticketSubject), required: true);
            var __workflow_ticketticketAssigneeEmailOrSharePointGroupName = WorkflowExpression.Compile(ticketticketAssigneeEmailOrSharePointGroupName, nameof(ticketticketAssigneeEmailOrSharePointGroupName), required: false);
            var __workflow_ticketticketAttachments = WorkflowExpression.Compile(ticketticketAttachments, nameof(ticketticketAttachments), required: false);
            var __workflow_ticketticketCategory = WorkflowExpression.Compile(ticketticketCategory, nameof(ticketticketCategory), required: false);
            var __workflow_ticketticketCcEmails = WorkflowExpression.Compile(ticketticketCcEmails, nameof(ticketticketCcEmails), required: false);
            var __workflow_ticketticketDueDate = WorkflowExpression.Compile(ticketticketDueDate, nameof(ticketticketDueDate), required: false);
            var __workflow_ticketticketPriority = WorkflowExpression.Compile(ticketticketPriority, nameof(ticketticketPriority), required: false);
            var __workflow_ticketticketStatus = WorkflowExpression.Compile(ticketticketStatus, nameof(ticketticketStatus), required: false);
            var __workflow_ticketticketSupportChannel = WorkflowExpression.Compile(ticketticketSupportChannel, nameof(ticketticketSupportChannel), required: false);
            var __workflow_ticketticketTagsTitles = WorkflowExpression.Compile(ticketticketTagsTitles, nameof(ticketticketTagsTitles), required: false);
            return new DeferredBodyAction<TicketRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_flow/v4/Tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var ticket = new JObject();
                var ticketpropCount = 0;
                if (__workflow_ticketticketAssigneeEmailOrSharePointGroupName != null)
                {
                    ticket["assignedToEmail"] = ExpressionConverter.ConvertO(__workflow_ticketticketAssigneeEmailOrSharePointGroupName);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketAttachments != null)
                {
                    ticket["attachments"] = ExpressionConverter.ConvertO(__workflow_ticketticketAttachments);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["body"] = ExpressionConverter.ConvertO(__workflow_ticketticketBody);
                if (__workflow_ticketticketCategory != null)
                {
                    ticket["category"] = ExpressionConverter.ConvertO(__workflow_ticketticketCategory);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketCcEmails != null)
                {
                    ticket["ccEmails"] = ExpressionConverter.ConvertO(__workflow_ticketticketCcEmails);
                    ticketpropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    ticket["customFields"] = customFieldsObject;
                    ticketpropCount++;
                }

                if (__workflow_ticketticketDueDate != null)
                {
                    ticket["dueDate"] = ExpressionConverter.ConvertO(__workflow_ticketticketDueDate);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketPriority != null)
                {
                    ticket["priority"] = ExpressionConverter.ConvertO(__workflow_ticketticketPriority);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["requesterEmail"] = ExpressionConverter.ConvertO(__workflow_ticketticketRequesterEmail);
                if (__workflow_ticketticketStatus != null)
                {
                    ticket["status"] = ExpressionConverter.ConvertO(__workflow_ticketticketStatus);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["subject"] = ExpressionConverter.ConvertO(__workflow_ticketticketSubject);
                if (__workflow_ticketticketSupportChannel != null)
                {
                    ticket["supportChannel"] = ExpressionConverter.ConvertO(__workflow_ticketticketSupportChannel);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketTagsTitles != null)
                {
                    ticket["tagTitles"] = ExpressionConverter.ConvertO(__workflow_ticketticketTagsTitles);
                    ticketpropCount++;
                }

                if (ticketpropCount > 0)
                {
                    callPayload.Body = ticket;
                }

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
        public IBodyWorkflowAction<TicketRead, ApiConnectionActionConfiguration> FlowV4TicketsByIdPut(Expression<Func<int>> id, Expression<Func<string>> ticketticketBody, Expression<Func<string>> ticketticketRequesterEmail, Expression<Func<string>> ticketticketSubject, Expression<Func<string>> ticketticketAssigneeEmailOrSharePointGroupName = null, Expression<Func<Attachment[]>> ticketticketAttachments = null, Expression<Func<string>> ticketticketCategory = null, Expression<Func<string[]>> ticketticketCcEmails = null, Expression<Func<string>> ticketticketDueDate = null, Expression<Func<string>> ticketticketPriority = null, Expression<Func<string>> ticketticketStatus = null, Expression<Func<string>> ticketticketSupportChannel = null, Expression<Func<string[]>> ticketticketTagsTitles = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ticketticketBody = WorkflowExpression.Compile(ticketticketBody, nameof(ticketticketBody), required: true);
            var __workflow_ticketticketRequesterEmail = WorkflowExpression.Compile(ticketticketRequesterEmail, nameof(ticketticketRequesterEmail), required: true);
            var __workflow_ticketticketSubject = WorkflowExpression.Compile(ticketticketSubject, nameof(ticketticketSubject), required: true);
            var __workflow_ticketticketAssigneeEmailOrSharePointGroupName = WorkflowExpression.Compile(ticketticketAssigneeEmailOrSharePointGroupName, nameof(ticketticketAssigneeEmailOrSharePointGroupName), required: false);
            var __workflow_ticketticketAttachments = WorkflowExpression.Compile(ticketticketAttachments, nameof(ticketticketAttachments), required: false);
            var __workflow_ticketticketCategory = WorkflowExpression.Compile(ticketticketCategory, nameof(ticketticketCategory), required: false);
            var __workflow_ticketticketCcEmails = WorkflowExpression.Compile(ticketticketCcEmails, nameof(ticketticketCcEmails), required: false);
            var __workflow_ticketticketDueDate = WorkflowExpression.Compile(ticketticketDueDate, nameof(ticketticketDueDate), required: false);
            var __workflow_ticketticketPriority = WorkflowExpression.Compile(ticketticketPriority, nameof(ticketticketPriority), required: false);
            var __workflow_ticketticketStatus = WorkflowExpression.Compile(ticketticketStatus, nameof(ticketticketStatus), required: false);
            var __workflow_ticketticketSupportChannel = WorkflowExpression.Compile(ticketticketSupportChannel, nameof(ticketticketSupportChannel), required: false);
            var __workflow_ticketticketTagsTitles = WorkflowExpression.Compile(ticketticketTagsTitles, nameof(ticketticketTagsTitles), required: false);
            return new DeferredBodyAction<TicketRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var ticket = new JObject();
                var ticketpropCount = 0;
                if (__workflow_ticketticketAssigneeEmailOrSharePointGroupName != null)
                {
                    ticket["assignedToEmail"] = ExpressionConverter.ConvertO(__workflow_ticketticketAssigneeEmailOrSharePointGroupName);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketAttachments != null)
                {
                    ticket["attachments"] = ExpressionConverter.ConvertO(__workflow_ticketticketAttachments);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["body"] = ExpressionConverter.ConvertO(__workflow_ticketticketBody);
                if (__workflow_ticketticketCategory != null)
                {
                    ticket["category"] = ExpressionConverter.ConvertO(__workflow_ticketticketCategory);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketCcEmails != null)
                {
                    ticket["ccEmails"] = ExpressionConverter.ConvertO(__workflow_ticketticketCcEmails);
                    ticketpropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    ticket["customFields"] = customFieldsObject;
                    ticketpropCount++;
                }

                if (__workflow_ticketticketDueDate != null)
                {
                    ticket["dueDate"] = ExpressionConverter.ConvertO(__workflow_ticketticketDueDate);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketPriority != null)
                {
                    ticket["priority"] = ExpressionConverter.ConvertO(__workflow_ticketticketPriority);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["requesterEmail"] = ExpressionConverter.ConvertO(__workflow_ticketticketRequesterEmail);
                if (__workflow_ticketticketStatus != null)
                {
                    ticket["status"] = ExpressionConverter.ConvertO(__workflow_ticketticketStatus);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["subject"] = ExpressionConverter.ConvertO(__workflow_ticketticketSubject);
                if (__workflow_ticketticketSupportChannel != null)
                {
                    ticket["supportChannel"] = ExpressionConverter.ConvertO(__workflow_ticketticketSupportChannel);
                    ticketpropCount++;
                }

                if (__workflow_ticketticketTagsTitles != null)
                {
                    ticket["tagTitles"] = ExpressionConverter.ConvertO(__workflow_ticketticketTagsTitles);
                    ticketpropCount++;
                }

                if (ticketpropCount > 0)
                {
                    callPayload.Body = ticket;
                }

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
        public IBodyWorkflowAction<CommentRead, ApiConnectionActionConfiguration> FlowV4TicketsByTicketIdComments(Expression<Func<string>> commentcommentBody, Expression<Func<string>> commentcommentAuthorEmail, Expression<Func<int>> ticketId, Expression<Func<Attachment[]>> commentattachments = null, Expression<Func<string>> commentcommentMessageId = null)
        {
            var __workflow_commentcommentBody = WorkflowExpression.Compile(commentcommentBody, nameof(commentcommentBody), required: true);
            var __workflow_commentcommentAuthorEmail = WorkflowExpression.Compile(commentcommentAuthorEmail, nameof(commentcommentAuthorEmail), required: true);
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_commentattachments = WorkflowExpression.Compile(commentattachments, nameof(commentattachments), required: false);
            var __workflow_commentcommentMessageId = WorkflowExpression.Compile(commentcommentMessageId, nameof(commentcommentMessageId), required: false);
            return new DeferredBodyAction<CommentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_flow/v4/Tickets/{0}/Comments", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (__workflow_commentattachments != null)
                {
                    comment["attachments"] = ExpressionConverter.ConvertO(__workflow_commentattachments);
                    commentpropCount++;
                }

                commentpropCount++;
                comment["body"] = ExpressionConverter.ConvertO(__workflow_commentcommentBody);
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    comment["customFields"] = customFieldsObject;
                    commentpropCount++;
                }

                commentpropCount++;
                comment["fromEmail"] = ExpressionConverter.ConvertO(__workflow_commentcommentAuthorEmail);
                if (__workflow_commentcommentMessageId != null)
                {
                    comment["messageId"] = ExpressionConverter.ConvertO(__workflow_commentcommentMessageId);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

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

    public class OrganizationRead
    {
        [JsonProperty("customFields")]
        public JToken OrganizationCustomFields { get; set; }

        [JsonProperty("id")]
        public int OrganizationId { get; set; }

        [JsonProperty("title")]
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

    public class Attachment
    {
        public string AttachmentContent { get; set; }

        [JsonProperty("Name")]
        public string AttachmentFileName { get; set; }
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