//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsax
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DynamicsaxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<AxOnlineProcedureResult> ExecuteProcedure(Expression<Func<string>> dataset, Expression<Func<string>> procedure, Expression<Func<object>> parameters = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_procedure = procedure == null ? null : WorkflowExpression.Compile(procedure);
            WorkflowExpression.Validate(__workflow_procedure, nameof(procedure), required: true);
            var __workflow_parameters = parameters == null ? null : WorkflowExpression.Compile(parameters);
            WorkflowExpression.Validate(__workflow_parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<AxOnlineProcedureResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/procedures/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<AxOnlineProcedureResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> apply = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null, Expression<Func<bool>> crossCompany = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_apply = apply == null ? null : WorkflowExpression.Compile(apply);
            WorkflowExpression.Validate(__workflow_apply, nameof(apply), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_crossCompany = crossCompany == null ? null : WorkflowExpression.Compile(crossCompany);
            WorkflowExpression.Validate(__workflow_crossCompany, nameof(crossCompany), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_apply != null)
                    callPayload.Queries["$apply"] = ExpressionConverter.Convert(__workflow_apply);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_crossCompany != null)
                    callPayload.Queries["cross-company"] = ExpressionConverter.Convert(__workflow_crossCompany);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> id, Expression<Func<object>> item = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_table = table == null ? null : WorkflowExpression.Compile(table);
            WorkflowExpression.Validate(__workflow_table, nameof(table), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }
    }

    public class DynamicsaxTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BusinessEventSubscriptionResponse> SubscribeOnABusinessEvent(Expression<Func<string>> dataset, Expression<Func<string>> businesseventcategory, Expression<Func<string>> businessevent, Expression<Func<string>> legalEntity = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = dataset == null ? null : WorkflowExpression.Compile(dataset);
            WorkflowExpression.Validate(__workflow_dataset, nameof(dataset), required: true);
            var __workflow_businesseventcategory = businesseventcategory == null ? null : WorkflowExpression.Compile(businesseventcategory);
            WorkflowExpression.Validate(__workflow_businesseventcategory, nameof(businesseventcategory), required: true);
            var __workflow_businessevent = businessevent == null ? null : WorkflowExpression.Compile(businessevent);
            WorkflowExpression.Validate(__workflow_businessevent, nameof(businessevent), required: true);
            var __workflow_legalEntity = legalEntity == null ? null : WorkflowExpression.Compile(legalEntity);
            WorkflowExpression.Validate(__workflow_legalEntity, nameof(legalEntity), required: false);
            return new DeferredBodyTrigger<BusinessEventSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/subscribebusinessevent/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_businessevent, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businesseventcategory"] = ExpressionConverter.Convert(__workflow_businesseventcategory);
                if (__workflow_legalEntity != null)
                    callPayload.Queries["legalEntity"] = ExpressionConverter.Convert(__workflow_legalEntity);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<BusinessEventSubscriptionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AxOnlineProcedureResult
    {
        [JsonProperty("value")]
        public string Value { get; set; }
        public JToken OutputParameters { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class BusinessEventSubscriptionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("notificationType")]
        public string NotificationType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsax;

    public partial class WorkflowManagedActions
    {
        public DynamicsaxActions Dynamicsax(string connectionId) => new DynamicsaxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicsaxTriggers Dynamicsax(string connectionId) => new DynamicsaxTriggers(connectionId);
    }
}
