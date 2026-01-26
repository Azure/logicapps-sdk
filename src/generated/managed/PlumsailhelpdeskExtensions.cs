//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailhelpdesk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailhelpdeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead[]> FlowV4ContactsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var apiCallPath = "/_flow/v4/Contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderBy != null)
                callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
            return new ApiConnectionAction<ContactRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsPost(Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null, Expression<Func<bool>> updateIfExists = null)
        {
            var apiCallPath = "/_flow/v4/Contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["updateIfExists"] = Convert.ToString(false);
            if (updateIfExists != null)
                callPayload.Queries["updateIfExists"] = ExpressionConverter.Convert(updateIfExists);
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
            contact["email"] = ExpressionConverter.ConvertO(contactcontactEmail);
            if (contactcontactAlternateEmail != null)
            {
                contact["emailAlternate"] = ExpressionConverter.ConvertO(contactcontactAlternateEmail);
                contactpropCount++;
            }

            if (contactcontactRole != null)
            {
                contact["role"] = ExpressionConverter.ConvertO(contactcontactRole);
                contactpropCount++;
            }

            if (contactcontactSPUserId != null)
            {
                contact["spUserId"] = ExpressionConverter.ConvertO(contactcontactSPUserId);
                contactpropCount++;
            }

            contactpropCount++;
            contact["title"] = ExpressionConverter.ConvertO(contactcontactName);
            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ContactRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByEmailByEmailGet(Expression<Func<string>> email, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Contacts/ByEmail/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<ContactRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByEmailByEmailPut(Expression<Func<string>> email, Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Contacts/ByEmail/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
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
            contact["email"] = ExpressionConverter.ConvertO(contactcontactEmail);
            if (contactcontactAlternateEmail != null)
            {
                contact["emailAlternate"] = ExpressionConverter.ConvertO(contactcontactAlternateEmail);
                contactpropCount++;
            }

            if (contactcontactRole != null)
            {
                contact["role"] = ExpressionConverter.ConvertO(contactcontactRole);
                contactpropCount++;
            }

            if (contactcontactSPUserId != null)
            {
                contact["spUserId"] = ExpressionConverter.ConvertO(contactcontactSPUserId);
                contactpropCount++;
            }

            contactpropCount++;
            contact["title"] = ExpressionConverter.ConvertO(contactcontactName);
            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ContactRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4ContactsByIdDelete(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/_flow/v4/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<ContactRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByIdPut(Expression<Func<int>> id, Expression<Func<string>> contactcontactEmail, Expression<Func<string>> contactcontactName, Expression<Func<string>> contactcontactAlternateEmail = null, Expression<Func<string>> contactcontactRole = null, Expression<Func<int>> contactcontactSPUserId = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            contact["email"] = ExpressionConverter.ConvertO(contactcontactEmail);
            if (contactcontactAlternateEmail != null)
            {
                contact["emailAlternate"] = ExpressionConverter.ConvertO(contactcontactAlternateEmail);
                contactpropCount++;
            }

            if (contactcontactRole != null)
            {
                contact["role"] = ExpressionConverter.ConvertO(contactcontactRole);
                contactpropCount++;
            }

            if (contactcontactSPUserId != null)
            {
                contact["spUserId"] = ExpressionConverter.ConvertO(contactcontactSPUserId);
                contactpropCount++;
            }

            contactpropCount++;
            contact["title"] = ExpressionConverter.ConvertO(contactcontactName);
            if (contactpropCount > 0)
            {
                callPayload.Body = contact;
            }

            return new ApiConnectionAction<ContactRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead[]> FlowV4OrganizationsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var apiCallPath = "/_flow/v4/Organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderBy != null)
                callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
            return new ApiConnectionAction<OrganizationRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsPost(Expression<Func<string>> organizationorganizationTitle)
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
            organization["title"] = ExpressionConverter.ConvertO(organizationorganizationTitle);
            if (organizationpropCount > 0)
            {
                callPayload.Body = organization;
            }

            return new ApiConnectionAction<OrganizationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4OrganizationsByTitleByTitleDelete(Expression<Func<string>> title)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/ByTitle/{0}", ExpressionConverter.ConvertWithUrlEncoding(title, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByTitleByTitleGet(Expression<Func<string>> title, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/ByTitle/{0}", ExpressionConverter.ConvertWithUrlEncoding(title, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<OrganizationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByTitleByTitlePut(Expression<Func<string>> title, Expression<Func<string>> organizationorganizationTitle)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/ByTitle/{0}", ExpressionConverter.ConvertWithUrlEncoding(title, 1));
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
            organization["title"] = ExpressionConverter.ConvertO(organizationorganizationTitle);
            if (organizationpropCount > 0)
            {
                callPayload.Body = organization;
            }

            return new ApiConnectionAction<OrganizationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4OrganizationsByIdDelete(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<OrganizationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByIdPut(Expression<Func<int>> id, Expression<Func<string>> organizationorganizationTitle)
        {
            var apiCallPath = String.Format("/_flow/v4/Organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            organization["title"] = ExpressionConverter.ConvertO(organizationorganizationTitle);
            if (organizationpropCount > 0)
            {
                callPayload.Body = organization;
            }

            return new ApiConnectionAction<OrganizationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead[]> FlowV4TicketsGet(Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null)
        {
            var apiCallPath = "/_flow/v4/Tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderBy != null)
                callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
            return new ApiConnectionAction<TicketRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4TicketsPost(Expression<Func<string>> ticketticketBody, Expression<Func<string>> ticketticketRequesterEmail, Expression<Func<string>> ticketticketSubject, Expression<Func<string>> ticketticketAssigneeEmailOrSharePointGroupName = null, Expression<Func<Attachment[]>> ticketticketAttachments = null, Expression<Func<string>> ticketticketCategory = null, Expression<Func<string[]>> ticketticketCcEmails = null, Expression<Func<string>> ticketticketDueDate = null, Expression<Func<string>> ticketticketPriority = null, Expression<Func<string>> ticketticketStatus = null, Expression<Func<string>> ticketticketSupportChannel = null, Expression<Func<string[]>> ticketticketTagsTitles = null)
        {
            var apiCallPath = "/_flow/v4/Tickets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var ticket = new JObject();
            var ticketpropCount = 0;
            if (ticketticketAssigneeEmailOrSharePointGroupName != null)
            {
                ticket["assignedToEmail"] = ExpressionConverter.ConvertO(ticketticketAssigneeEmailOrSharePointGroupName);
                ticketpropCount++;
            }

            if (ticketticketAttachments != null)
            {
                ticket["attachments"] = ExpressionConverter.ConvertO(ticketticketAttachments);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["body"] = ExpressionConverter.ConvertO(ticketticketBody);
            if (ticketticketCategory != null)
            {
                ticket["category"] = ExpressionConverter.ConvertO(ticketticketCategory);
                ticketpropCount++;
            }

            if (ticketticketCcEmails != null)
            {
                ticket["ccEmails"] = ExpressionConverter.ConvertO(ticketticketCcEmails);
                ticketpropCount++;
            }

            var customFieldsObject = new JObject();
            var customFieldsObjectpropCount = 0;
            if (customFieldsObjectpropCount > 0)
            {
                ticket["customFields"] = customFieldsObject;
                ticketpropCount++;
            }

            if (ticketticketDueDate != null)
            {
                ticket["dueDate"] = ExpressionConverter.ConvertO(ticketticketDueDate);
                ticketpropCount++;
            }

            if (ticketticketPriority != null)
            {
                ticket["priority"] = ExpressionConverter.ConvertO(ticketticketPriority);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["requesterEmail"] = ExpressionConverter.ConvertO(ticketticketRequesterEmail);
            if (ticketticketStatus != null)
            {
                ticket["status"] = ExpressionConverter.ConvertO(ticketticketStatus);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["subject"] = ExpressionConverter.ConvertO(ticketticketSubject);
            if (ticketticketSupportChannel != null)
            {
                ticket["supportChannel"] = ExpressionConverter.ConvertO(ticketticketSupportChannel);
                ticketpropCount++;
            }

            if (ticketticketTagsTitles != null)
            {
                ticket["tagTitles"] = ExpressionConverter.ConvertO(ticketticketTagsTitles);
                ticketpropCount++;
            }

            if (ticketpropCount > 0)
            {
                callPayload.Body = ticket;
            }

            return new ApiConnectionAction<TicketRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4TicketsByIdDelete(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4TicketsByIdGet(Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<TicketRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4TicketsByIdPut(Expression<Func<int>> id, Expression<Func<string>> ticketticketBody, Expression<Func<string>> ticketticketRequesterEmail, Expression<Func<string>> ticketticketSubject, Expression<Func<string>> ticketticketAssigneeEmailOrSharePointGroupName = null, Expression<Func<Attachment[]>> ticketticketAttachments = null, Expression<Func<string>> ticketticketCategory = null, Expression<Func<string[]>> ticketticketCcEmails = null, Expression<Func<string>> ticketticketDueDate = null, Expression<Func<string>> ticketticketPriority = null, Expression<Func<string>> ticketticketStatus = null, Expression<Func<string>> ticketticketSupportChannel = null, Expression<Func<string[]>> ticketticketTagsTitles = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var ticket = new JObject();
            var ticketpropCount = 0;
            if (ticketticketAssigneeEmailOrSharePointGroupName != null)
            {
                ticket["assignedToEmail"] = ExpressionConverter.ConvertO(ticketticketAssigneeEmailOrSharePointGroupName);
                ticketpropCount++;
            }

            if (ticketticketAttachments != null)
            {
                ticket["attachments"] = ExpressionConverter.ConvertO(ticketticketAttachments);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["body"] = ExpressionConverter.ConvertO(ticketticketBody);
            if (ticketticketCategory != null)
            {
                ticket["category"] = ExpressionConverter.ConvertO(ticketticketCategory);
                ticketpropCount++;
            }

            if (ticketticketCcEmails != null)
            {
                ticket["ccEmails"] = ExpressionConverter.ConvertO(ticketticketCcEmails);
                ticketpropCount++;
            }

            var customFieldsObject = new JObject();
            var customFieldsObjectpropCount = 0;
            if (customFieldsObjectpropCount > 0)
            {
                ticket["customFields"] = customFieldsObject;
                ticketpropCount++;
            }

            if (ticketticketDueDate != null)
            {
                ticket["dueDate"] = ExpressionConverter.ConvertO(ticketticketDueDate);
                ticketpropCount++;
            }

            if (ticketticketPriority != null)
            {
                ticket["priority"] = ExpressionConverter.ConvertO(ticketticketPriority);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["requesterEmail"] = ExpressionConverter.ConvertO(ticketticketRequesterEmail);
            if (ticketticketStatus != null)
            {
                ticket["status"] = ExpressionConverter.ConvertO(ticketticketStatus);
                ticketpropCount++;
            }

            ticketpropCount++;
            ticket["subject"] = ExpressionConverter.ConvertO(ticketticketSubject);
            if (ticketticketSupportChannel != null)
            {
                ticket["supportChannel"] = ExpressionConverter.ConvertO(ticketticketSupportChannel);
                ticketpropCount++;
            }

            if (ticketticketTagsTitles != null)
            {
                ticket["tagTitles"] = ExpressionConverter.ConvertO(ticketticketTagsTitles);
                ticketpropCount++;
            }

            if (ticketpropCount > 0)
            {
                callPayload.Body = ticket;
            }

            return new ApiConnectionAction<TicketRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<string> FlowV4TicketsByIdAttachmentsByFilenameGet(Expression<Func<int>> id, Expression<Func<string>> filename)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}/Attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(filename, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead[]> FlowV4TicketsByTicketIdCommentsGet(Expression<Func<int>> ticketId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}/Comments", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderBy != null)
                callPayload.Queries["$orderBy"] = ExpressionConverter.Convert(orderBy);
            return new ApiConnectionAction<CommentRead[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead> FlowV4TicketsByTicketIdCommentsPost(Expression<Func<string>> commentcommentBody, Expression<Func<string>> commentcommentAuthorEmail, Expression<Func<int>> ticketId, Expression<Func<Attachment[]>> commentattachments = null, Expression<Func<string>> commentcommentMessageId = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}/Comments", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var comment = new JObject();
            var commentpropCount = 0;
            if (commentattachments != null)
            {
                comment["attachments"] = ExpressionConverter.ConvertO(commentattachments);
                commentpropCount++;
            }

            commentpropCount++;
            comment["body"] = ExpressionConverter.ConvertO(commentcommentBody);
            var customFieldsObject = new JObject();
            var customFieldsObjectpropCount = 0;
            if (customFieldsObjectpropCount > 0)
            {
                comment["customFields"] = customFieldsObject;
                commentpropCount++;
            }

            commentpropCount++;
            comment["fromEmail"] = ExpressionConverter.ConvertO(commentcommentAuthorEmail);
            if (commentcommentMessageId != null)
            {
                comment["messageId"] = ExpressionConverter.ConvertO(commentcommentMessageId);
                commentpropCount++;
            }

            if (commentpropCount > 0)
            {
                callPayload.Body = comment;
            }

            return new ApiConnectionAction<CommentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead> FlowV4TicketsByTicketIdCommentsByIdGet(Expression<Func<int>> ticketId, Expression<Func<int>> id, Expression<Func<string>> select = null, Expression<Func<string>> expand = null)
        {
            var apiCallPath = String.Format("/_flow/v4/Tickets/{0}/Comments/{1}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction<CommentRead>(callPayload);
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
        public int ContactID { get; set; }

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
        public int OrganizationID { get; set; }

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
        public int TicketID { get; set; }

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
        public string CustomTicketID { get; set; }
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
        public int AssigneeID { get; set; }

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
        public int CcID { get; set; }

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
        public int RequesterID { get; set; }

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
        public int TagID { get; set; }

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
        public int CommentID { get; set; }

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