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
        public IBodyWorkflowAction<AxOnlineProcedureResult> ExecuteProcedure([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> procedure, [WorkflowExpression] Func<object> parameters = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/procedures/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(procedure, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<AxOnlineProcedureResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> apply = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<bool> crossCompany = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IWorkflowAction DeleteItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicsax")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset)
        {
            var apiCallPath = String.Format("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }
    }

    public class DynamicsaxTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BusinessEventSubscriptionResponse> SubscribeOnABusinessEvent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> dataset, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> businesseventcategory, [WorkflowExpression] Func<string> businessevent, [WorkflowExpression] Func<string> legalEntity = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/{0}/subscribebusinessevent/{1}", ExpressionConverter.ConvertWithUrlEncoding(dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(businessevent, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["businesseventcategory"] = ExpressionConverter.Convert(businesseventcategory);
            if (legalEntity != null)
                callPayload.Queries["legalEntity"] = ExpressionConverter.Convert(legalEntity);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationUrl"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<BusinessEventSubscriptionResponse>(callPayload, triggerName, recurrence);
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