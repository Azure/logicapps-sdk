//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompaniesList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompaniesCreate(Expression<Func<CompaniesCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompaniesRead(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompaniesArchive(Expression<Func<string>> companyId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompaniesUpdate(Expression<Func<string>> companyId, Expression<Func<CompaniesUpdateInput>> properties)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties[]"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactsCreate(Expression<Func<ContactsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactsRead(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactsArchive(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactsUpdate(Expression<Func<string>> contactId, Expression<Func<ContactsUpdateInput>> properties)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DealsList(Expression<Func<string>> properties = null, Expression<Func<int>> limit = null, Expression<Func<string>> after = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DealsCreate(Expression<Func<DealsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DealsRead(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DealsArchive(Expression<Func<string>> dealId)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DealsUpdate(Expression<Func<string>> dealId, Expression<Func<DealsUpdateInput>> body)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProductsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProductsCreate(Expression<Func<ProductsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProductsRead(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProductsArchive(Expression<Func<string>> productId)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProductsUpdate(Expression<Func<string>> productId, Expression<Func<ProductsUpdateInput>> properties = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LineItemsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LineItemsCreate(Expression<Func<LineItemsCreateInput>> properties)
        {
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LineItemsRead(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LineItemsArchive(Expression<Func<string>> lineItemId)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LineItemsUpdate(Expression<Func<string>> lineItemId, Expression<Func<LineItemsUpdateInput>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TicketsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TicketsCreate(Expression<Func<TicketsCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TicketsRead(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TicketsArchive(Expression<Func<string>> ticketId)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TicketsUpdate(Expression<Func<string>> ticketId, Expression<Func<TicketsUpdateInput>> body, Expression<Func<string>> idProperty = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HubspotcrmTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompaniesCreateInput
    {
        [JsonProperty("properties")]
        public CompaniesCreateInputPropertiesType Properties { get; set; }
    }

    public class CompaniesCreateInputPropertiesType
    {
        [JsonProperty("about_us")]
        public string AboutUs { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("annualrevenue")]
        public string Annualrevenue { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("days_to_close")]
        public string DaysToClose { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("facebook_company_page")]
        public string FacebookCompanyPage { get; set; }

        [JsonProperty("facebookfans")]
        public string Facebookfans { get; set; }

        [JsonProperty("first_contact_createdate")]
        public string FirstContactCreatedate { get; set; }

        [JsonProperty("first_conversion_date")]
        public string FirstConversionDate { get; set; }

        [JsonProperty("first_conversion_event_name")]
        public string FirstConversionEventName { get; set; }

        [JsonProperty("first_deal_created_date")]
        public string FirstDealCreatedDate { get; set; }

        [JsonProperty("founded_year")]
        public string FoundedYear { get; set; }

        [JsonProperty("googleplus_page")]
        public string GoogleplusPage { get; set; }

        [JsonProperty("hs_analytics_first_timestamp")]
        public string HsAnalyticsFirstTimestamp { get; set; }

        [JsonProperty("hs_analytics_first_touch_converting_campaign")]
        public string HsAnalyticsFirstTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_first_visit_timestamp")]
        public string HsAnalyticsFirstVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_timestamp")]
        public string HsAnalyticsLastTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_touch_converting_campaign")]
        public string HsAnalyticsLastTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_last_visit_timestamp")]
        public string HsAnalyticsLastVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_num_page_views")]
        public string HsAnalyticsNumPageViews { get; set; }

        [JsonProperty("hs_analytics_num_visits")]
        public string HsAnalyticsNumVisits { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_ideal_customer_profile")]
        public string HsIdealCustomerProfile { get; set; }

        [JsonProperty("hs_is_target_account")]
        public string HsIsTargetAccount { get; set; }

        [JsonProperty("hs_last_booked_meeting_date")]
        public string HsLastBookedMeetingDate { get; set; }

        [JsonProperty("hs_last_logged_call_date")]
        public string HsLastLoggedCallDate { get; set; }

        [JsonProperty("hs_last_open_task_date")]
        public string HsLastOpenTaskDate { get; set; }

        [JsonProperty("hs_last_sales_activity_timestamp")]
        public string HsLastSalesActivityTimestamp { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_lead_status")]
        public string HsLeadStatus { get; set; }

        [JsonProperty("hs_num_blockers")]
        public string HsNumBlockers { get; set; }

        [JsonProperty("hs_num_child_companies")]
        public string HsNumChildCompanies { get; set; }

        [JsonProperty("hs_num_contacts_with_buying_roles")]
        public string HsNumContactsWithBuyingRoles { get; set; }

        [JsonProperty("hs_num_decision_makers")]
        public string HsNumDecisionMakers { get; set; }

        [JsonProperty("hs_num_open_deals")]
        public string HsNumOpenDeals { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_parent_company_id")]
        public string HsParentCompanyId { get; set; }

        [JsonProperty("hs_predictivecontactscore_v2")]
        public string HsPredictivecontactscoreV2 { get; set; }

        [JsonProperty("hs_total_deal_value")]
        public string HsTotalDealValue { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("is_public")]
        public string IsPublic { get; set; }

        [JsonProperty("lifecyclestage")]
        public string Lifecyclestage { get; set; }

        [JsonProperty("linkedin_company_page")]
        public string LinkedinCompanyPage { get; set; }

        [JsonProperty("linkedinbio")]
        public string Linkedinbio { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_contacts")]
        public string NumAssociatedContacts { get; set; }

        [JsonProperty("num_associated_deals")]
        public string NumAssociatedDeals { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_conversion_events")]
        public string NumConversionEvents { get; set; }

        [JsonProperty("numberofemployees")]
        public string Numberofemployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("recent_conversion_date")]
        public string RecentConversionDate { get; set; }

        [JsonProperty("recent_conversion_event_name")]
        public string RecentConversionEventName { get; set; }

        [JsonProperty("recent_deal_amount")]
        public string RecentDealAmount { get; set; }

        [JsonProperty("recent_deal_close_date")]
        public string RecentDealCloseDate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("total_money_raised")]
        public string TotalMoneyRaised { get; set; }

        [JsonProperty("total_revenue")]
        public string TotalRevenue { get; set; }

        [JsonProperty("twitterbio")]
        public string Twitterbio { get; set; }

        [JsonProperty("twitterfollowers")]
        public string Twitterfollowers { get; set; }

        [JsonProperty("twitterhandle")]
        public string Twitterhandle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("web_technologies")]
        public string WebTechnologies { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class CompaniesUpdateInput
    {
        [JsonProperty("properties")]
        public CompaniesUpdateInputPropertiesType Properties { get; set; }
    }

    public class CompaniesUpdateInputPropertiesType
    {
        [JsonProperty("about_us")]
        public string AboutUs { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("annualrevenue")]
        public string Annualrevenue { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("days_to_close")]
        public string DaysToClose { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("facebook_company_page")]
        public string FacebookCompanyPage { get; set; }

        [JsonProperty("facebookfans")]
        public string Facebookfans { get; set; }

        [JsonProperty("first_contact_createdate")]
        public string FirstContactCreatedate { get; set; }

        [JsonProperty("first_conversion_date")]
        public string FirstConversionDate { get; set; }

        [JsonProperty("first_conversion_event_name")]
        public string FirstConversionEventName { get; set; }

        [JsonProperty("first_deal_created_date")]
        public string FirstDealCreatedDate { get; set; }

        [JsonProperty("founded_year")]
        public string FoundedYear { get; set; }

        [JsonProperty("googleplus_page")]
        public string GoogleplusPage { get; set; }

        [JsonProperty("hs_analytics_first_timestamp")]
        public string HsAnalyticsFirstTimestamp { get; set; }

        [JsonProperty("hs_analytics_first_touch_converting_campaign")]
        public string HsAnalyticsFirstTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_first_visit_timestamp")]
        public string HsAnalyticsFirstVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_timestamp")]
        public string HsAnalyticsLastTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_touch_converting_campaign")]
        public string HsAnalyticsLastTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_last_visit_timestamp")]
        public string HsAnalyticsLastVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_num_page_views")]
        public string HsAnalyticsNumPageViews { get; set; }

        [JsonProperty("hs_analytics_num_visits")]
        public string HsAnalyticsNumVisits { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_ideal_customer_profile")]
        public string HsIdealCustomerProfile { get; set; }

        [JsonProperty("hs_is_target_account")]
        public string HsIsTargetAccount { get; set; }

        [JsonProperty("hs_last_booked_meeting_date")]
        public string HsLastBookedMeetingDate { get; set; }

        [JsonProperty("hs_last_logged_call_date")]
        public string HsLastLoggedCallDate { get; set; }

        [JsonProperty("hs_last_open_task_date")]
        public string HsLastOpenTaskDate { get; set; }

        [JsonProperty("hs_last_sales_activity_timestamp")]
        public string HsLastSalesActivityTimestamp { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_lead_status")]
        public string HsLeadStatus { get; set; }

        [JsonProperty("hs_num_blockers")]
        public string HsNumBlockers { get; set; }

        [JsonProperty("hs_num_child_companies")]
        public string HsNumChildCompanies { get; set; }

        [JsonProperty("hs_num_contacts_with_buying_roles")]
        public string HsNumContactsWithBuyingRoles { get; set; }

        [JsonProperty("hs_num_decision_makers")]
        public string HsNumDecisionMakers { get; set; }

        [JsonProperty("hs_num_open_deals")]
        public string HsNumOpenDeals { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_parent_company_id")]
        public string HsParentCompanyId { get; set; }

        [JsonProperty("hs_predictivecontactscore_v2")]
        public string HsPredictivecontactscoreV2 { get; set; }

        [JsonProperty("hs_total_deal_value")]
        public string HsTotalDealValue { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("is_public")]
        public string IsPublic { get; set; }

        [JsonProperty("lifecyclestage")]
        public string Lifecyclestage { get; set; }

        [JsonProperty("linkedin_company_page")]
        public string LinkedinCompanyPage { get; set; }

        [JsonProperty("linkedinbio")]
        public string Linkedinbio { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_contacts")]
        public string NumAssociatedContacts { get; set; }

        [JsonProperty("num_associated_deals")]
        public string NumAssociatedDeals { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_conversion_events")]
        public string NumConversionEvents { get; set; }

        [JsonProperty("numberofemployees")]
        public string Numberofemployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("recent_conversion_date")]
        public string RecentConversionDate { get; set; }

        [JsonProperty("recent_conversion_event_name")]
        public string RecentConversionEventName { get; set; }

        [JsonProperty("recent_deal_amount")]
        public string RecentDealAmount { get; set; }

        [JsonProperty("recent_deal_close_date")]
        public string RecentDealCloseDate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("total_money_raised")]
        public string TotalMoneyRaised { get; set; }

        [JsonProperty("total_revenue")]
        public string TotalRevenue { get; set; }

        [JsonProperty("twitterbio")]
        public string Twitterbio { get; set; }

        [JsonProperty("twitterfollowers")]
        public string Twitterfollowers { get; set; }

        [JsonProperty("twitterhandle")]
        public string Twitterhandle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("web_technologies")]
        public string WebTechnologies { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ContactsCreateInput
    {
        [JsonProperty("properties")]
        public ContactsCreateInputPropertiesType Properties { get; set; }
    }

    public class ContactsCreateInputPropertiesType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("annualrevenue")]
        public string Annualrevenue { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_size")]
        public string CompanySize { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("currentlyinworkflow")]
        public string Currentlyinworkflow { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("days_to_close")]
        public string DaysToClose { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("field_of_study")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("first_conversion_date")]
        public string FirstConversionDate { get; set; }

        [JsonProperty("first_conversion_event_name")]
        public string FirstConversionEventName { get; set; }

        [JsonProperty("first_deal_created_date")]
        public string FirstDealCreatedDate { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("graduation_date")]
        public string GraduationDate { get; set; }

        [JsonProperty("hs_analytics_average_page_views")]
        public string HsAnalyticsAveragePageViews { get; set; }

        [JsonProperty("hs_analytics_first_referrer")]
        public string HsAnalyticsFirstReferrer { get; set; }

        [JsonProperty("hs_analytics_first_timestamp")]
        public string HsAnalyticsFirstTimestamp { get; set; }

        [JsonProperty("hs_analytics_first_touch_converting_campaign")]
        public string HsAnalyticsFirstTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_first_url")]
        public string HsAnalyticsFirstUrl { get; set; }

        [JsonProperty("hs_analytics_first_visit_timestamp")]
        public string HsAnalyticsFirstVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_referrer")]
        public string HsAnalyticsLastReferrer { get; set; }

        [JsonProperty("hs_analytics_last_timestamp")]
        public string HsAnalyticsLastTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_touch_converting_campaign")]
        public string HsAnalyticsLastTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_last_url")]
        public string HsAnalyticsLastUrl { get; set; }

        [JsonProperty("hs_analytics_last_visit_timestamp")]
        public string HsAnalyticsLastVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_num_event_completions")]
        public string HsAnalyticsNumEventCompletions { get; set; }

        [JsonProperty("hs_analytics_num_page_views")]
        public string HsAnalyticsNumPageViews { get; set; }

        [JsonProperty("hs_analytics_num_visits")]
        public string HsAnalyticsNumVisits { get; set; }

        [JsonProperty("hs_analytics_revenue")]
        public string HsAnalyticsRevenue { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_buying_role")]
        public string HsBuyingRole { get; set; }

        [JsonProperty("hs_content_membership_email_confirmed")]
        public string HsContentMembershipEmailConfirmed { get; set; }

        [JsonProperty("hs_content_membership_notes")]
        public string HsContentMembershipNotes { get; set; }

        [JsonProperty("hs_content_membership_registered_at")]
        public string HsContentMembershipRegisteredAt { get; set; }

        [JsonProperty("hs_content_membership_registration_domain_sent_to")]
        public string HsContentMembershipRegistrationDomainSentTo { get; set; }

        [JsonProperty("hs_content_membership_registration_email_sent_at")]
        public string HsContentMembershipRegistrationEmailSentAt { get; set; }

        [JsonProperty("hs_content_membership_status")]
        public string HsContentMembershipStatus { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_email_bad_address")]
        public string HsEmailBadAddress { get; set; }

        [JsonProperty("hs_email_bounce")]
        public string HsEmailBounce { get; set; }

        [JsonProperty("hs_email_click")]
        public string HsEmailClick { get; set; }

        [JsonProperty("hs_email_customer_quarantined_reason")]
        public string HsEmailCustomerQuarantinedReason { get; set; }

        [JsonProperty("hs_email_delivered")]
        public string HsEmailDelivered { get; set; }

        [JsonProperty("hs_email_domain")]
        public string HsEmailDomain { get; set; }

        [JsonProperty("hs_email_first_click_date")]
        public string HsEmailFirstClickDate { get; set; }

        [JsonProperty("hs_email_first_open_date")]
        public string HsEmailFirstOpenDate { get; set; }

        [JsonProperty("hs_email_first_reply_date")]
        public string HsEmailFirstReplyDate { get; set; }

        [JsonProperty("hs_email_first_send_date")]
        public string HsEmailFirstSendDate { get; set; }

        [JsonProperty("hs_email_hard_bounce_reason_enum")]
        public string HsEmailHardBounceReasonEnum { get; set; }

        [JsonProperty("hs_email_last_click_date")]
        public string HsEmailLastClickDate { get; set; }

        [JsonProperty("hs_email_last_email_name")]
        public string HsEmailLastEmailName { get; set; }

        [JsonProperty("hs_email_last_open_date")]
        public string HsEmailLastOpenDate { get; set; }

        [JsonProperty("hs_email_last_reply_date")]
        public string HsEmailLastReplyDate { get; set; }

        [JsonProperty("hs_email_last_send_date")]
        public string HsEmailLastSendDate { get; set; }

        [JsonProperty("hs_email_open")]
        public string HsEmailOpen { get; set; }

        [JsonProperty("hs_email_optout")]
        public string HsEmailOptout { get; set; }

        [JsonProperty("hs_email_optout_12592317")]
        public string HsEmailOptout12592317 { get; set; }

        [JsonProperty("hs_email_quarantined")]
        public string HsEmailQuarantined { get; set; }

        [JsonProperty("hs_email_quarantined_reason")]
        public string HsEmailQuarantinedReason { get; set; }

        [JsonProperty("hs_email_replied")]
        public string HsEmailReplied { get; set; }

        [JsonProperty("hs_email_sends_since_last_engagement")]
        public string HsEmailSendsSinceLastEngagement { get; set; }

        [JsonProperty("hs_emailconfirmationstatus")]
        public string HsEmailconfirmationstatus { get; set; }

        [JsonProperty("hs_facebook_click_id")]
        public string HsFacebookClickId { get; set; }

        [JsonProperty("hs_feedback_last_nps_follow_up")]
        public string HsFeedbackLastNpsFollowUp { get; set; }

        [JsonProperty("hs_feedback_last_nps_rating")]
        public string HsFeedbackLastNpsRating { get; set; }

        [JsonProperty("hs_feedback_last_survey_date")]
        public string HsFeedbackLastSurveyDate { get; set; }

        [JsonProperty("hs_google_click_id")]
        public string HsGoogleClickId { get; set; }

        [JsonProperty("hs_ip_timezone")]
        public string HsIpTimezone { get; set; }

        [JsonProperty("hs_is_unworked")]
        public string HsIsUnworked { get; set; }

        [JsonProperty("hs_language")]
        public string HsLanguage { get; set; }

        [JsonProperty("hs_last_sales_activity_timestamp")]
        public string HsLastSalesActivityTimestamp { get; set; }

        [JsonProperty("hs_lead_status")]
        public string HsLeadStatus { get; set; }

        [JsonProperty("hs_legal_basis")]
        public string HsLegalBasis { get; set; }

        [JsonProperty("hs_lifecyclestage_customer_date")]
        public string HsLifecyclestageCustomerDate { get; set; }

        [JsonProperty("hs_lifecyclestage_evangelist_date")]
        public string HsLifecyclestageEvangelistDate { get; set; }

        [JsonProperty("hs_lifecyclestage_lead_date")]
        public string HsLifecyclestageLeadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_marketingqualifiedlead_date")]
        public string HsLifecyclestageMarketingqualifiedleadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_opportunity_date")]
        public string HsLifecyclestageOpportunityDate { get; set; }

        [JsonProperty("hs_lifecyclestage_other_date")]
        public string HsLifecyclestageOtherDate { get; set; }

        [JsonProperty("hs_lifecyclestage_salesqualifiedlead_date")]
        public string HsLifecyclestageSalesqualifiedleadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_subscriber_date")]
        public string HsLifecyclestageSubscriberDate { get; set; }

        [JsonProperty("hs_marketable_reason_id")]
        public string HsMarketableReasonId { get; set; }

        [JsonProperty("hs_marketable_reason_type")]
        public string HsMarketableReasonType { get; set; }

        [JsonProperty("hs_marketable_status")]
        public string HsMarketableStatus { get; set; }

        [JsonProperty("hs_marketable_until_renewal")]
        public string HsMarketableUntilRenewal { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_persona")]
        public string HsPersona { get; set; }

        [JsonProperty("hs_predictivecontactscore")]
        public string HsPredictivecontactscore { get; set; }

        [JsonProperty("hs_predictivecontactscore_v2")]
        public string HsPredictivecontactscoreV2 { get; set; }

        [JsonProperty("hs_predictivecontactscorebucket")]
        public string HsPredictivecontactscorebucket { get; set; }

        [JsonProperty("hs_predictivescoringtier")]
        public string HsPredictivescoringtier { get; set; }

        [JsonProperty("hs_sales_email_last_clicked")]
        public string HsSalesEmailLastClicked { get; set; }

        [JsonProperty("hs_sales_email_last_opened")]
        public string HsSalesEmailLastOpened { get; set; }

        [JsonProperty("hs_sales_email_last_replied")]
        public string HsSalesEmailLastReplied { get; set; }

        [JsonProperty("hs_sequences_is_enrolled")]
        public string HsSequencesIsEnrolled { get; set; }

        [JsonProperty("hs_time_between_contact_creation_and_deal_close")]
        public string HsTimeBetweenContactCreationAndDealClose { get; set; }

        [JsonProperty("hs_time_between_contact_creation_and_deal_creation")]
        public string HsTimeBetweenContactCreationAndDealCreation { get; set; }

        [JsonProperty("hs_time_to_move_from_lead_to_customer")]
        public string HsTimeToMoveFromLeadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_marketingqualifiedlead_to_customer")]
        public string HsTimeToMoveFromMarketingqualifiedleadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_opportunity_to_customer")]
        public string HsTimeToMoveFromOpportunityToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_salesqualifiedlead_to_customer")]
        public string HsTimeToMoveFromSalesqualifiedleadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_subscriber_to_customer")]
        public string HsTimeToMoveFromSubscriberToCustomer { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("hubspotscore")]
        public string Hubspotscore { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("ip_city")]
        public string IpCity { get; set; }

        [JsonProperty("ip_country")]
        public string IpCountry { get; set; }

        [JsonProperty("ip_country_code")]
        public string IpCountryCode { get; set; }

        [JsonProperty("ip_state")]
        public string IpState { get; set; }

        [JsonProperty("ip_state_code")]
        public string IpStateCode { get; set; }

        [JsonProperty("job_function")]
        public string JobFunction { get; set; }

        [JsonProperty("jobtitle")]
        public string Jobtitle { get; set; }

        [JsonProperty("lastmodifieddate")]
        public string Lastmodifieddate { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("lifecyclestage")]
        public string Lifecyclestage { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("military_status")]
        public string MilitaryStatus { get; set; }

        [JsonProperty("mobilephone")]
        public string Mobilephone { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_deals")]
        public string NumAssociatedDeals { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_conversion_events")]
        public string NumConversionEvents { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("num_unique_conversion_events")]
        public string NumUniqueConversionEvents { get; set; }

        [JsonProperty("numemployees")]
        public string Numemployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("recent_conversion_date")]
        public string RecentConversionDate { get; set; }

        [JsonProperty("recent_conversion_event_name")]
        public string RecentConversionEventName { get; set; }

        [JsonProperty("recent_deal_amount")]
        public string RecentDealAmount { get; set; }

        [JsonProperty("recent_deal_close_date")]
        public string RecentDealCloseDate { get; set; }

        [JsonProperty("relationship_status")]
        public string RelationshipStatus { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("total_revenue")]
        public string TotalRevenue { get; set; }

        [JsonProperty("twitterhandle")]
        public string Twitterhandle { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("work_email")]
        public string WorkEmail { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ContactsUpdateInput
    {
        [JsonProperty("properties")]
        public ContactsUpdateInputPropertiesType Properties { get; set; }
    }

    public class ContactsUpdateInputPropertiesType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("annualrevenue")]
        public string Annualrevenue { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_size")]
        public string CompanySize { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("currentlyinworkflow")]
        public string Currentlyinworkflow { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("days_to_close")]
        public string DaysToClose { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("field_of_study")]
        public string FieldOfStudy { get; set; }

        [JsonProperty("first_conversion_date")]
        public string FirstConversionDate { get; set; }

        [JsonProperty("first_conversion_event_name")]
        public string FirstConversionEventName { get; set; }

        [JsonProperty("first_deal_created_date")]
        public string FirstDealCreatedDate { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("graduation_date")]
        public string GraduationDate { get; set; }

        [JsonProperty("hs_analytics_average_page_views")]
        public string HsAnalyticsAveragePageViews { get; set; }

        [JsonProperty("hs_analytics_first_referrer")]
        public string HsAnalyticsFirstReferrer { get; set; }

        [JsonProperty("hs_analytics_first_timestamp")]
        public string HsAnalyticsFirstTimestamp { get; set; }

        [JsonProperty("hs_analytics_first_touch_converting_campaign")]
        public string HsAnalyticsFirstTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_first_url")]
        public string HsAnalyticsFirstUrl { get; set; }

        [JsonProperty("hs_analytics_first_visit_timestamp")]
        public string HsAnalyticsFirstVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_referrer")]
        public string HsAnalyticsLastReferrer { get; set; }

        [JsonProperty("hs_analytics_last_timestamp")]
        public string HsAnalyticsLastTimestamp { get; set; }

        [JsonProperty("hs_analytics_last_touch_converting_campaign")]
        public string HsAnalyticsLastTouchConvertingCampaign { get; set; }

        [JsonProperty("hs_analytics_last_url")]
        public string HsAnalyticsLastUrl { get; set; }

        [JsonProperty("hs_analytics_last_visit_timestamp")]
        public string HsAnalyticsLastVisitTimestamp { get; set; }

        [JsonProperty("hs_analytics_num_event_completions")]
        public string HsAnalyticsNumEventCompletions { get; set; }

        [JsonProperty("hs_analytics_num_page_views")]
        public string HsAnalyticsNumPageViews { get; set; }

        [JsonProperty("hs_analytics_num_visits")]
        public string HsAnalyticsNumVisits { get; set; }

        [JsonProperty("hs_analytics_revenue")]
        public string HsAnalyticsRevenue { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_buying_role")]
        public string HsBuyingRole { get; set; }

        [JsonProperty("hs_content_membership_email_confirmed")]
        public string HsContentMembershipEmailConfirmed { get; set; }

        [JsonProperty("hs_content_membership_notes")]
        public string HsContentMembershipNotes { get; set; }

        [JsonProperty("hs_content_membership_registered_at")]
        public string HsContentMembershipRegisteredAt { get; set; }

        [JsonProperty("hs_content_membership_registration_domain_sent_to")]
        public string HsContentMembershipRegistrationDomainSentTo { get; set; }

        [JsonProperty("hs_content_membership_registration_email_sent_at")]
        public string HsContentMembershipRegistrationEmailSentAt { get; set; }

        [JsonProperty("hs_content_membership_status")]
        public string HsContentMembershipStatus { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_email_bad_address")]
        public string HsEmailBadAddress { get; set; }

        [JsonProperty("hs_email_bounce")]
        public string HsEmailBounce { get; set; }

        [JsonProperty("hs_email_click")]
        public string HsEmailClick { get; set; }

        [JsonProperty("hs_email_customer_quarantined_reason")]
        public string HsEmailCustomerQuarantinedReason { get; set; }

        [JsonProperty("hs_email_delivered")]
        public string HsEmailDelivered { get; set; }

        [JsonProperty("hs_email_domain")]
        public string HsEmailDomain { get; set; }

        [JsonProperty("hs_email_first_click_date")]
        public string HsEmailFirstClickDate { get; set; }

        [JsonProperty("hs_email_first_open_date")]
        public string HsEmailFirstOpenDate { get; set; }

        [JsonProperty("hs_email_first_reply_date")]
        public string HsEmailFirstReplyDate { get; set; }

        [JsonProperty("hs_email_first_send_date")]
        public string HsEmailFirstSendDate { get; set; }

        [JsonProperty("hs_email_hard_bounce_reason_enum")]
        public string HsEmailHardBounceReasonEnum { get; set; }

        [JsonProperty("hs_email_last_click_date")]
        public string HsEmailLastClickDate { get; set; }

        [JsonProperty("hs_email_last_email_name")]
        public string HsEmailLastEmailName { get; set; }

        [JsonProperty("hs_email_last_open_date")]
        public string HsEmailLastOpenDate { get; set; }

        [JsonProperty("hs_email_last_reply_date")]
        public string HsEmailLastReplyDate { get; set; }

        [JsonProperty("hs_email_last_send_date")]
        public string HsEmailLastSendDate { get; set; }

        [JsonProperty("hs_email_open")]
        public string HsEmailOpen { get; set; }

        [JsonProperty("hs_email_optout")]
        public string HsEmailOptout { get; set; }

        [JsonProperty("hs_email_optout_12592317")]
        public string HsEmailOptout12592317 { get; set; }

        [JsonProperty("hs_email_quarantined")]
        public string HsEmailQuarantined { get; set; }

        [JsonProperty("hs_email_quarantined_reason")]
        public string HsEmailQuarantinedReason { get; set; }

        [JsonProperty("hs_email_replied")]
        public string HsEmailReplied { get; set; }

        [JsonProperty("hs_email_sends_since_last_engagement")]
        public string HsEmailSendsSinceLastEngagement { get; set; }

        [JsonProperty("hs_emailconfirmationstatus")]
        public string HsEmailconfirmationstatus { get; set; }

        [JsonProperty("hs_facebook_click_id")]
        public string HsFacebookClickId { get; set; }

        [JsonProperty("hs_feedback_last_nps_follow_up")]
        public string HsFeedbackLastNpsFollowUp { get; set; }

        [JsonProperty("hs_feedback_last_nps_rating")]
        public string HsFeedbackLastNpsRating { get; set; }

        [JsonProperty("hs_feedback_last_survey_date")]
        public string HsFeedbackLastSurveyDate { get; set; }

        [JsonProperty("hs_google_click_id")]
        public string HsGoogleClickId { get; set; }

        [JsonProperty("hs_ip_timezone")]
        public string HsIpTimezone { get; set; }

        [JsonProperty("hs_is_unworked")]
        public string HsIsUnworked { get; set; }

        [JsonProperty("hs_language")]
        public string HsLanguage { get; set; }

        [JsonProperty("hs_last_sales_activity_timestamp")]
        public string HsLastSalesActivityTimestamp { get; set; }

        [JsonProperty("hs_lead_status")]
        public string HsLeadStatus { get; set; }

        [JsonProperty("hs_legal_basis")]
        public string HsLegalBasis { get; set; }

        [JsonProperty("hs_lifecyclestage_customer_date")]
        public string HsLifecyclestageCustomerDate { get; set; }

        [JsonProperty("hs_lifecyclestage_evangelist_date")]
        public string HsLifecyclestageEvangelistDate { get; set; }

        [JsonProperty("hs_lifecyclestage_lead_date")]
        public string HsLifecyclestageLeadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_marketingqualifiedlead_date")]
        public string HsLifecyclestageMarketingqualifiedleadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_opportunity_date")]
        public string HsLifecyclestageOpportunityDate { get; set; }

        [JsonProperty("hs_lifecyclestage_other_date")]
        public string HsLifecyclestageOtherDate { get; set; }

        [JsonProperty("hs_lifecyclestage_salesqualifiedlead_date")]
        public string HsLifecyclestageSalesqualifiedleadDate { get; set; }

        [JsonProperty("hs_lifecyclestage_subscriber_date")]
        public string HsLifecyclestageSubscriberDate { get; set; }

        [JsonProperty("hs_marketable_reason_id")]
        public string HsMarketableReasonId { get; set; }

        [JsonProperty("hs_marketable_reason_type")]
        public string HsMarketableReasonType { get; set; }

        [JsonProperty("hs_marketable_status")]
        public string HsMarketableStatus { get; set; }

        [JsonProperty("hs_marketable_until_renewal")]
        public string HsMarketableUntilRenewal { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_persona")]
        public string HsPersona { get; set; }

        [JsonProperty("hs_predictivecontactscore")]
        public string HsPredictivecontactscore { get; set; }

        [JsonProperty("hs_predictivecontactscore_v2")]
        public string HsPredictivecontactscoreV2 { get; set; }

        [JsonProperty("hs_predictivecontactscorebucket")]
        public string HsPredictivecontactscorebucket { get; set; }

        [JsonProperty("hs_predictivescoringtier")]
        public string HsPredictivescoringtier { get; set; }

        [JsonProperty("hs_sales_email_last_clicked")]
        public string HsSalesEmailLastClicked { get; set; }

        [JsonProperty("hs_sales_email_last_opened")]
        public string HsSalesEmailLastOpened { get; set; }

        [JsonProperty("hs_sales_email_last_replied")]
        public string HsSalesEmailLastReplied { get; set; }

        [JsonProperty("hs_sequences_is_enrolled")]
        public string HsSequencesIsEnrolled { get; set; }

        [JsonProperty("hs_time_between_contact_creation_and_deal_close")]
        public string HsTimeBetweenContactCreationAndDealClose { get; set; }

        [JsonProperty("hs_time_between_contact_creation_and_deal_creation")]
        public string HsTimeBetweenContactCreationAndDealCreation { get; set; }

        [JsonProperty("hs_time_to_move_from_lead_to_customer")]
        public string HsTimeToMoveFromLeadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_marketingqualifiedlead_to_customer")]
        public string HsTimeToMoveFromMarketingqualifiedleadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_opportunity_to_customer")]
        public string HsTimeToMoveFromOpportunityToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_salesqualifiedlead_to_customer")]
        public string HsTimeToMoveFromSalesqualifiedleadToCustomer { get; set; }

        [JsonProperty("hs_time_to_move_from_subscriber_to_customer")]
        public string HsTimeToMoveFromSubscriberToCustomer { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("hubspotscore")]
        public string Hubspotscore { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("ip_city")]
        public string IpCity { get; set; }

        [JsonProperty("ip_country")]
        public string IpCountry { get; set; }

        [JsonProperty("ip_country_code")]
        public string IpCountryCode { get; set; }

        [JsonProperty("ip_state")]
        public string IpState { get; set; }

        [JsonProperty("ip_state_code")]
        public string IpStateCode { get; set; }

        [JsonProperty("job_function")]
        public string JobFunction { get; set; }

        [JsonProperty("jobtitle")]
        public string Jobtitle { get; set; }

        [JsonProperty("lastmodifieddate")]
        public string Lastmodifieddate { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("lifecyclestage")]
        public string Lifecyclestage { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("military_status")]
        public string MilitaryStatus { get; set; }

        [JsonProperty("mobilephone")]
        public string Mobilephone { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_deals")]
        public string NumAssociatedDeals { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_conversion_events")]
        public string NumConversionEvents { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("num_unique_conversion_events")]
        public string NumUniqueConversionEvents { get; set; }

        [JsonProperty("numemployees")]
        public string Numemployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("recent_conversion_date")]
        public string RecentConversionDate { get; set; }

        [JsonProperty("recent_conversion_event_name")]
        public string RecentConversionEventName { get; set; }

        [JsonProperty("recent_deal_amount")]
        public string RecentDealAmount { get; set; }

        [JsonProperty("recent_deal_close_date")]
        public string RecentDealCloseDate { get; set; }

        [JsonProperty("relationship_status")]
        public string RelationshipStatus { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("total_revenue")]
        public string TotalRevenue { get; set; }

        [JsonProperty("twitterhandle")]
        public string Twitterhandle { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("work_email")]
        public string WorkEmail { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class DealsCreateInput
    {
        [JsonProperty("properties")]
        public DealsCreateInputPropertiesType Properties { get; set; }
    }

    public class DealsCreateInputPropertiesType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("amount_in_home_currency")]
        public string AmountInHomeCurrency { get; set; }

        [JsonProperty("closed_lost_reason")]
        public string ClosedLostReason { get; set; }

        [JsonProperty("closed_won_reason")]
        public string ClosedWonReason { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("dealname")]
        public string Dealname { get; set; }

        [JsonProperty("dealstage")]
        public string Dealstage { get; set; }

        [JsonProperty("dealtype")]
        public string Dealtype { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("hs_acv")]
        public string HsAcv { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_arr")]
        public string HsArr { get; set; }

        [JsonProperty("hs_forecast_amount")]
        public string HsForecastAmount { get; set; }

        [JsonProperty("hs_forecast_probability")]
        public string HsForecastProbability { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_manual_forecast_category")]
        public string HsManualForecastCategory { get; set; }

        [JsonProperty("hs_mrr")]
        public string HsMrr { get; set; }

        [JsonProperty("hs_next_step")]
        public string HsNextStep { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_priority")]
        public string HsPriority { get; set; }

        [JsonProperty("hs_tcv")]
        public string HsTcv { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_contacts")]
        public string NumAssociatedContacts { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("pipeline")]
        public string Pipeline { get; set; }
    }

    public class DealsUpdateInput
    {
        [JsonProperty("properties")]
        public DealsUpdateInputPropertiesType Properties { get; set; }
    }

    public class DealsUpdateInputPropertiesType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("amount_in_home_currency")]
        public string AmountInHomeCurrency { get; set; }

        [JsonProperty("closed_lost_reason")]
        public string ClosedLostReason { get; set; }

        [JsonProperty("closed_won_reason")]
        public string ClosedWonReason { get; set; }

        [JsonProperty("closedate")]
        public string Closedate { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("dealname")]
        public string Dealname { get; set; }

        [JsonProperty("dealstage")]
        public string Dealstage { get; set; }

        [JsonProperty("dealtype")]
        public string Dealtype { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("engagements_last_meeting_booked")]
        public string EngagementsLastMeetingBooked { get; set; }

        [JsonProperty("engagements_last_meeting_booked_campaign")]
        public string EngagementsLastMeetingBookedCampaign { get; set; }

        [JsonProperty("engagements_last_meeting_booked_medium")]
        public string EngagementsLastMeetingBookedMedium { get; set; }

        [JsonProperty("engagements_last_meeting_booked_source")]
        public string EngagementsLastMeetingBookedSource { get; set; }

        [JsonProperty("hs_acv")]
        public string HsAcv { get; set; }

        [JsonProperty("hs_analytics_source")]
        public string HsAnalyticsSource { get; set; }

        [JsonProperty("hs_analytics_source_data_1")]
        public string HsAnalyticsSourceData1 { get; set; }

        [JsonProperty("hs_analytics_source_data_2")]
        public string HsAnalyticsSourceData2 { get; set; }

        [JsonProperty("hs_arr")]
        public string HsArr { get; set; }

        [JsonProperty("hs_forecast_amount")]
        public string HsForecastAmount { get; set; }

        [JsonProperty("hs_forecast_probability")]
        public string HsForecastProbability { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_manual_forecast_category")]
        public string HsManualForecastCategory { get; set; }

        [JsonProperty("hs_mrr")]
        public string HsMrr { get; set; }

        [JsonProperty("hs_next_step")]
        public string HsNextStep { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_priority")]
        public string HsPriority { get; set; }

        [JsonProperty("hs_tcv")]
        public string HsTcv { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("notes_last_contacted")]
        public string NotesLastContacted { get; set; }

        [JsonProperty("notes_last_updated")]
        public string NotesLastUpdated { get; set; }

        [JsonProperty("notes_next_activity_date")]
        public string NotesNextActivityDate { get; set; }

        [JsonProperty("num_associated_contacts")]
        public string NumAssociatedContacts { get; set; }

        [JsonProperty("num_contacted_notes")]
        public string NumContactedNotes { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("pipeline")]
        public string Pipeline { get; set; }
    }

    public class ProductsCreateInput
    {
        [JsonProperty("properties")]
        public ProductsCreateInputPropertiesType Properties { get; set; }
    }

    public class ProductsCreateInputPropertiesType
    {
        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hs_cost_of_goods_sold")]
        public string HsCostOfGoodsSold { get; set; }

        [JsonProperty("hs_created_by_user_id")]
        public string HsCreatedByUserId { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_images")]
        public string HsImages { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_recurring_billing_period")]
        public string HsRecurringBillingPeriod { get; set; }

        [JsonProperty("hs_sku")]
        public string HsSku { get; set; }

        [JsonProperty("hs_updated_by_user_id")]
        public string HsUpdatedByUserId { get; set; }

        [JsonProperty("hs_url")]
        public string HsUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("recurringbillingfrequency")]
        public string Recurringbillingfrequency { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }
    }

    public class ProductsUpdateInput
    {
        [JsonProperty("properties")]
        public ProductsUpdateInputPropertiesType Properties { get; set; }
    }

    public class ProductsUpdateInputPropertiesType
    {
        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hs_cost_of_goods_sold")]
        public string HsCostOfGoodsSold { get; set; }

        [JsonProperty("hs_created_by_user_id")]
        public string HsCreatedByUserId { get; set; }

        [JsonProperty("hs_createdate")]
        public string HsCreatedate { get; set; }

        [JsonProperty("hs_images")]
        public string HsImages { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_object_id")]
        public string HsObjectId { get; set; }

        [JsonProperty("hs_recurring_billing_period")]
        public string HsRecurringBillingPeriod { get; set; }

        [JsonProperty("hs_sku")]
        public string HsSku { get; set; }

        [JsonProperty("hs_updated_by_user_id")]
        public string HsUpdatedByUserId { get; set; }

        [JsonProperty("hs_url")]
        public string HsUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("recurringbillingfrequency")]
        public string Recurringbillingfrequency { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }
    }

    public class LineItemsCreateInput
    {
        [JsonProperty("properties")]
        public LineItemsCreateInputPropertiesType Properties { get; set; }
    }

    public class LineItemsCreateInputPropertiesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hs_product_id")]
        public string HsProductId { get; set; }

        [JsonProperty("hs_recurring_billing_period")]
        public string HsRecurringBillingPeriod { get; set; }

        [JsonProperty("recurringbillingfrequency")]
        public string Recurringbillingfrequency { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }

    public class LineItemsUpdateInput
    {
        [JsonProperty("properties")]
        public LineItemsUpdateInputPropertiesType Properties { get; set; }
    }

    public class LineItemsUpdateInputPropertiesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hs_product_id")]
        public string HsProductId { get; set; }

        [JsonProperty("hs_recurring_billing_period")]
        public string HsRecurringBillingPeriod { get; set; }

        [JsonProperty("recurringbillingfrequency")]
        public string Recurringbillingfrequency { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }
    }

    public class TicketsCreateInput
    {
        [JsonProperty("properties")]
        public TicketsCreateInputPropertiesType Properties { get; set; }
    }

    public class TicketsCreateInputPropertiesType
    {
        [JsonProperty("closed_date")]
        public string ClosedDate { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("first_agent_reply_date")]
        public string FirstAgentReplyDate { get; set; }

        [JsonProperty("hs_feedback_last_ces_follow_up")]
        public string HsFeedbackLastCesFollowUp { get; set; }

        [JsonProperty("hs_feedback_last_ces_rating")]
        public string HsFeedbackLastCesRating { get; set; }

        [JsonProperty("hs_feedback_last_survey_date")]
        public string HsFeedbackLastSurveyDate { get; set; }

        [JsonProperty("hs_lastactivitydate")]
        public string HsLastactivitydate { get; set; }

        [JsonProperty("hs_lastcontacted")]
        public string HsLastcontacted { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_nextactivitydate")]
        public string HsNextactivitydate { get; set; }

        [JsonProperty("hs_num_times_contacted")]
        public string HsNumTimesContacted { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("last_reply_date")]
        public string LastReplyDate { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("time_to_close")]
        public string TimeToClose { get; set; }

        [JsonProperty("time_to_first_agent_reply")]
        public string TimeToFirstAgentReply { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("hs_file_upload")]
        public string HsFileUpload { get; set; }

        [JsonProperty("hs_num_associated_companies")]
        public string HsNumAssociatedCompanies { get; set; }

        [JsonProperty("hs_pipeline")]
        public string HsPipeline { get; set; }

        [JsonProperty("hs_pipeline_stage")]
        public string HsPipelineStage { get; set; }

        [JsonProperty("hs_resolution")]
        public string HsResolution { get; set; }

        [JsonProperty("hs_ticket_category")]
        public string HsTicketCategory { get; set; }

        [JsonProperty("hs_ticket_id")]
        public string HsTicketId { get; set; }

        [JsonProperty("hs_ticket_priority")]
        public string HsTicketPriority { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class TicketsUpdateInput
    {
        [JsonProperty("properties")]
        public TicketsUpdateInputPropertiesType Properties { get; set; }
    }

    public class TicketsUpdateInputPropertiesType
    {
        [JsonProperty("closed_date")]
        public string ClosedDate { get; set; }

        [JsonProperty("createdate")]
        public string Createdate { get; set; }

        [JsonProperty("first_agent_reply_date")]
        public string FirstAgentReplyDate { get; set; }

        [JsonProperty("hs_feedback_last_ces_follow_up")]
        public string HsFeedbackLastCesFollowUp { get; set; }

        [JsonProperty("hs_feedback_last_ces_rating")]
        public string HsFeedbackLastCesRating { get; set; }

        [JsonProperty("hs_feedback_last_survey_date")]
        public string HsFeedbackLastSurveyDate { get; set; }

        [JsonProperty("hs_lastactivitydate")]
        public string HsLastactivitydate { get; set; }

        [JsonProperty("hs_lastcontacted")]
        public string HsLastcontacted { get; set; }

        [JsonProperty("hs_lastmodifieddate")]
        public string HsLastmodifieddate { get; set; }

        [JsonProperty("hs_nextactivitydate")]
        public string HsNextactivitydate { get; set; }

        [JsonProperty("hs_num_times_contacted")]
        public string HsNumTimesContacted { get; set; }

        [JsonProperty("hubspot_owner_assigneddate")]
        public string HubspotOwnerAssigneddate { get; set; }

        [JsonProperty("last_reply_date")]
        public string LastReplyDate { get; set; }

        [JsonProperty("num_notes")]
        public string NumNotes { get; set; }

        [JsonProperty("time_to_close")]
        public string TimeToClose { get; set; }

        [JsonProperty("time_to_first_agent_reply")]
        public string TimeToFirstAgentReply { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("hs_file_upload")]
        public string HsFileUpload { get; set; }

        [JsonProperty("hs_num_associated_companies")]
        public string HsNumAssociatedCompanies { get; set; }

        [JsonProperty("hs_pipeline")]
        public string HsPipeline { get; set; }

        [JsonProperty("hs_pipeline_stage")]
        public string HsPipelineStage { get; set; }

        [JsonProperty("hs_resolution")]
        public string HsResolution { get; set; }

        [JsonProperty("hs_ticket_category")]
        public string HsTicketCategory { get; set; }

        [JsonProperty("hs_ticket_id")]
        public string HsTicketId { get; set; }

        [JsonProperty("hs_ticket_priority")]
        public string HsTicketPriority { get; set; }

        [JsonProperty("hubspot_owner_id")]
        public string HubspotOwnerId { get; set; }

        [JsonProperty("hubspot_team_id")]
        public string HubspotTeamId { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm;

    public partial class WorkflowManagedActions
    {
        public HubspotcrmActions Hubspotcrm(string connectionId) => new HubspotcrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotcrmTriggers Hubspotcrm(string connectionId) => new HubspotcrmTriggers(connectionId);
    }
}