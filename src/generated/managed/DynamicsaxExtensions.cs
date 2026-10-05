//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicsax
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicsaxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteProcedure))]
        public IBodyWorkflowAction<AxOnlineProcedureResult> ExecuteProcedure([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AxOnlineProcedureResult> __BuildExecuteProcedure(WorkflowValue<string> dataset, WorkflowValue<string> procedure, WorkflowValue<object> parameters = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(procedure, nameof(procedure), required: true);
            WorkflowValue.Validate(parameters, nameof(parameters), required: false);
            return new DeferredBodyAction<AxOnlineProcedureResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/procedures/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(parameters);
                return new ApiConnectionAction<AxOnlineProcedureResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> apply = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<bool> crossCompany = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> apply = null, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<string> select = null, WorkflowValue<bool> crossCompany = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(apply, nameof(apply), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(crossCompany, nameof(crossCompany), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apply != null)
                    callPayload.Queries["$apply"] = ExpressionConverter.Convert(apply);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (crossCompany != null)
                    callPayload.Queries["cross-company"] = ExpressionConverter.Convert(crossCompany);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildPostItem))]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPostItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPatchItem(WorkflowValue<string> dataset, WorkflowValue<string> table, WorkflowValue<string> id, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> dataset)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TablesList> __BuildGetTables(WorkflowValue<string> dataset)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }
    }

    public class DynamicsaxTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildSubscribeOnABusinessEvent))]
        public IBodyWorkflowTrigger<BusinessEventSubscriptionResponse> SubscribeOnABusinessEvent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> businesseventcategory, [WorkflowExpression] Func<string> businessevent, [WorkflowExpression] Func<string> legalEntity = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BusinessEventSubscriptionResponse> __BuildSubscribeOnABusinessEvent(WorkflowValue<string> dataset, WorkflowValue<string> businesseventcategory, WorkflowValue<string> businessevent, WorkflowValue<string> legalEntity = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(dataset, nameof(dataset), required: true);
            WorkflowValue.Validate(businesseventcategory, nameof(businesseventcategory), required: true);
            WorkflowValue.Validate(businessevent, nameof(businessevent), required: true);
            WorkflowValue.Validate(legalEntity, nameof(legalEntity), required: false);
            return new DeferredBodyTrigger<BusinessEventSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/subscribebusinessevent/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(businessevent, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businesseventcategory"] = ExpressionConverter.Convert(businesseventcategory);
                if (legalEntity != null)
                    callPayload.Queries["legalEntity"] = ExpressionConverter.Convert(legalEntity);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<BusinessEventSubscriptionResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
