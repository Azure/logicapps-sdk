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
        public IBodyWorkflowAction<ContactRead[]> FlowV4ContactsGet([WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_flow/v4/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4Contacts([WorkflowExpression] Func<string> contactcontactEmail, [WorkflowExpression] Func<string> contactcontactName, [WorkflowExpression] Func<string> contactcontactAlternateEmail = null, [WorkflowExpression] Func<string> contactcontactRole = null, [WorkflowExpression] Func<int> contactcontactSPUserId = null, [WorkflowExpression] Func<bool> updateIfExists = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_flow/v4/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateIfExists"] = Convert.ToString(false);
                if (updateIfExists != null)
                    callPayload.Queries["updateIfExists"] = SourceExpressionConverter.ConvertO(updateIfExists);
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
                contact["email"] = SourceExpressionConverter.ConvertToken(contactcontactEmail);
                if (contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = SourceExpressionConverter.ConvertToken(contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (contactcontactRole != null)
                {
                    contact["role"] = SourceExpressionConverter.ConvertToken(contactcontactRole);
                    contactpropCount++;
                }

                if (contactcontactSPUserId != null)
                {
                    contact["spUserId"] = SourceExpressionConverter.ConvertToken(contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = SourceExpressionConverter.ConvertToken(contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByEmailByEmailGet([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Contacts/ByEmail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByEmailByEmailPut([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> contactcontactEmail, [WorkflowExpression] Func<string> contactcontactName, [WorkflowExpression] Func<string> contactcontactAlternateEmail = null, [WorkflowExpression] Func<string> contactcontactRole = null, [WorkflowExpression] Func<int> contactcontactSPUserId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Contacts/ByEmail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
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
                contact["email"] = SourceExpressionConverter.ConvertToken(contactcontactEmail);
                if (contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = SourceExpressionConverter.ConvertToken(contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (contactcontactRole != null)
                {
                    contact["role"] = SourceExpressionConverter.ConvertToken(contactcontactRole);
                    contactpropCount++;
                }

                if (contactcontactSPUserId != null)
                {
                    contact["spUserId"] = SourceExpressionConverter.ConvertToken(contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = SourceExpressionConverter.ConvertToken(contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4ContactsByIdDelete([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByIdGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<ContactRead> FlowV4ContactsByIdPut([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> contactcontactEmail, [WorkflowExpression] Func<string> contactcontactName, [WorkflowExpression] Func<string> contactcontactAlternateEmail = null, [WorkflowExpression] Func<string> contactcontactRole = null, [WorkflowExpression] Func<int> contactcontactSPUserId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
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
                contact["email"] = SourceExpressionConverter.ConvertToken(contactcontactEmail);
                if (contactcontactAlternateEmail != null)
                {
                    contact["emailAlternate"] = SourceExpressionConverter.ConvertToken(contactcontactAlternateEmail);
                    contactpropCount++;
                }

                if (contactcontactRole != null)
                {
                    contact["role"] = SourceExpressionConverter.ConvertToken(contactcontactRole);
                    contactpropCount++;
                }

                if (contactcontactSPUserId != null)
                {
                    contact["spUserId"] = SourceExpressionConverter.ConvertToken(contactcontactSPUserId);
                    contactpropCount++;
                }

                contactpropCount++;
                contact["title"] = SourceExpressionConverter.ConvertToken(contactcontactName);
                if (contactpropCount > 0)
                {
                    callPayload.Body = contact;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead[]> FlowV4OrganizationsGet([WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_flow/v4/Organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4Organizations([WorkflowExpression] Func<string> organizationorganizationTitle)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                organization["title"] = SourceExpressionConverter.ConvertToken(organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4OrganizationsByTitleByTitleDelete([WorkflowExpression] Func<string> title)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(title, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByTitleByTitleGet([WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(title, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByTitleByTitlePut([WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> organizationorganizationTitle)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/ByTitle/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(title, 1));
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
                organization["title"] = SourceExpressionConverter.ConvertToken(organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4OrganizationsByIdDelete([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByIdGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<OrganizationRead> FlowV4OrganizationsByIdPut([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> organizationorganizationTitle)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
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
                organization["title"] = SourceExpressionConverter.ConvertToken(organizationorganizationTitle);
                if (organizationpropCount > 0)
                {
                    callPayload.Body = organization;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead[]> FlowV4TicketsGet([WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_flow/v4/Tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                return callPayload;
            }

            return new ApiConnectionAction<TicketRead[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4Tickets([WorkflowExpression] Func<string> ticketticketBody, [WorkflowExpression] Func<string> ticketticketRequesterEmail, [WorkflowExpression] Func<string> ticketticketSubject, [WorkflowExpression] Func<string> ticketticketAssigneeEmailOrSharePointGroupName = null, [WorkflowExpression] Func<Attachment[]> ticketticketAttachments = null, [WorkflowExpression] Func<string> ticketticketCategory = null, [WorkflowExpression] Func<string[]> ticketticketCcEmails = null, [WorkflowExpression] Func<string> ticketticketDueDate = null, [WorkflowExpression] Func<string> ticketticketPriority = null, [WorkflowExpression] Func<string> ticketticketStatus = null, [WorkflowExpression] Func<string> ticketticketSupportChannel = null, [WorkflowExpression] Func<string[]> ticketticketTagsTitles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_flow/v4/Tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var ticket = new JObject();
                var ticketpropCount = 0;
                if (ticketticketAssigneeEmailOrSharePointGroupName != null)
                {
                    ticket["assignedToEmail"] = SourceExpressionConverter.ConvertToken(ticketticketAssigneeEmailOrSharePointGroupName);
                    ticketpropCount++;
                }

                if (ticketticketAttachments != null)
                {
                    ticket["attachments"] = SourceExpressionConverter.ConvertToken(ticketticketAttachments);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["body"] = SourceExpressionConverter.ConvertToken(ticketticketBody);
                if (ticketticketCategory != null)
                {
                    ticket["category"] = SourceExpressionConverter.ConvertToken(ticketticketCategory);
                    ticketpropCount++;
                }

                if (ticketticketCcEmails != null)
                {
                    ticket["ccEmails"] = SourceExpressionConverter.ConvertToken(ticketticketCcEmails);
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
                    ticket["dueDate"] = SourceExpressionConverter.ConvertToken(ticketticketDueDate);
                    ticketpropCount++;
                }

                if (ticketticketPriority != null)
                {
                    ticket["priority"] = SourceExpressionConverter.ConvertToken(ticketticketPriority);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["requesterEmail"] = SourceExpressionConverter.ConvertToken(ticketticketRequesterEmail);
                if (ticketticketStatus != null)
                {
                    ticket["status"] = SourceExpressionConverter.ConvertToken(ticketticketStatus);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["subject"] = SourceExpressionConverter.ConvertToken(ticketticketSubject);
                if (ticketticketSupportChannel != null)
                {
                    ticket["supportChannel"] = SourceExpressionConverter.ConvertToken(ticketticketSupportChannel);
                    ticketpropCount++;
                }

                if (ticketticketTagsTitles != null)
                {
                    ticket["tagTitles"] = SourceExpressionConverter.ConvertToken(ticketticketTagsTitles);
                    ticketpropCount++;
                }

                if (ticketpropCount > 0)
                {
                    callPayload.Body = ticket;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TicketRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IWorkflowAction FlowV4TicketsByIdDelete([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4TicketsByIdGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<TicketRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<TicketRead> FlowV4TicketsByIdPut([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> ticketticketBody, [WorkflowExpression] Func<string> ticketticketRequesterEmail, [WorkflowExpression] Func<string> ticketticketSubject, [WorkflowExpression] Func<string> ticketticketAssigneeEmailOrSharePointGroupName = null, [WorkflowExpression] Func<Attachment[]> ticketticketAttachments = null, [WorkflowExpression] Func<string> ticketticketCategory = null, [WorkflowExpression] Func<string[]> ticketticketCcEmails = null, [WorkflowExpression] Func<string> ticketticketDueDate = null, [WorkflowExpression] Func<string> ticketticketPriority = null, [WorkflowExpression] Func<string> ticketticketStatus = null, [WorkflowExpression] Func<string> ticketticketSupportChannel = null, [WorkflowExpression] Func<string[]> ticketticketTagsTitles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var ticket = new JObject();
                var ticketpropCount = 0;
                if (ticketticketAssigneeEmailOrSharePointGroupName != null)
                {
                    ticket["assignedToEmail"] = SourceExpressionConverter.ConvertToken(ticketticketAssigneeEmailOrSharePointGroupName);
                    ticketpropCount++;
                }

                if (ticketticketAttachments != null)
                {
                    ticket["attachments"] = SourceExpressionConverter.ConvertToken(ticketticketAttachments);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["body"] = SourceExpressionConverter.ConvertToken(ticketticketBody);
                if (ticketticketCategory != null)
                {
                    ticket["category"] = SourceExpressionConverter.ConvertToken(ticketticketCategory);
                    ticketpropCount++;
                }

                if (ticketticketCcEmails != null)
                {
                    ticket["ccEmails"] = SourceExpressionConverter.ConvertToken(ticketticketCcEmails);
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
                    ticket["dueDate"] = SourceExpressionConverter.ConvertToken(ticketticketDueDate);
                    ticketpropCount++;
                }

                if (ticketticketPriority != null)
                {
                    ticket["priority"] = SourceExpressionConverter.ConvertToken(ticketticketPriority);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["requesterEmail"] = SourceExpressionConverter.ConvertToken(ticketticketRequesterEmail);
                if (ticketticketStatus != null)
                {
                    ticket["status"] = SourceExpressionConverter.ConvertToken(ticketticketStatus);
                    ticketpropCount++;
                }

                ticketpropCount++;
                ticket["subject"] = SourceExpressionConverter.ConvertToken(ticketticketSubject);
                if (ticketticketSupportChannel != null)
                {
                    ticket["supportChannel"] = SourceExpressionConverter.ConvertToken(ticketticketSupportChannel);
                    ticketpropCount++;
                }

                if (ticketticketTagsTitles != null)
                {
                    ticket["tagTitles"] = SourceExpressionConverter.ConvertToken(ticketticketTagsTitles);
                    ticketpropCount++;
                }

                if (ticketpropCount > 0)
                {
                    callPayload.Body = ticket;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TicketRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<string> FlowV4TicketsByIdAttachmentsByFilenameGet([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> filename)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}/Attachments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filename, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead[]> FlowV4TicketsByTicketIdCommentsGet([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}/Comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderBy != null)
                    callPayload.Queries["$orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                return callPayload;
            }

            return new ApiConnectionAction<CommentRead[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead> FlowV4TicketsByTicketIdComments([WorkflowExpression] Func<string> commentcommentBody, [WorkflowExpression] Func<string> commentcommentAuthorEmail, [WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<Attachment[]> commentattachments = null, [WorkflowExpression] Func<string> commentcommentMessageId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}/Comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (commentattachments != null)
                {
                    comment["attachments"] = SourceExpressionConverter.ConvertToken(commentattachments);
                    commentpropCount++;
                }

                commentpropCount++;
                comment["body"] = SourceExpressionConverter.ConvertToken(commentcommentBody);
                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    comment["customFields"] = customFieldsObject;
                    commentpropCount++;
                }

                commentpropCount++;
                comment["fromEmail"] = SourceExpressionConverter.ConvertToken(commentcommentAuthorEmail);
                if (commentcommentMessageId != null)
                {
                    comment["messageId"] = SourceExpressionConverter.ConvertToken(commentcommentMessageId);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailhelpdesk")]
        public IBodyWorkflowAction<CommentRead> FlowV4TicketsByTicketIdCommentsByIdGet([WorkflowExpression] Func<int> ticketId, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_flow/v4/Tickets/{0}/Comments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(ticketId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                return callPayload;
            }

            return new ApiConnectionAction<CommentRead>(BuildSourceInput);
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