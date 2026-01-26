//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elfsquaddata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElfsquaddataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities(Expression<Func<string>> entityName, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> orderby = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<bool>> count = null)
        {
            var apiCallPath = String.Format("/data/1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<GetEntitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> PostEntityById(Expression<Func<string>> entityName, Expression<Func<object>> entity = null)
        {
            var apiCallPath = String.Format("/data/1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(entity);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> GetEntityById(Expression<Func<string>> entityName, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/data/1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IWorkflowAction DeleteEntityById(Expression<Func<string>> entityName, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/data/1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IWorkflowAction PutEntityById(Expression<Func<string>> entityName, Expression<Func<string>> id, Expression<Func<object>> entity = null)
        {
            var apiCallPath = String.Format("/data/1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(entity);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> InvokeFunction(Expression<Func<string>> functionPath, Expression<Func<object>> functionInputSchema = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(functionPath, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(functionInputSchema);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ElfsquaddataTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTrigger(Expression<Func<string>> triggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/2/webhooks/{0}", ExpressionConverter.ConvertWithUrlEncoding(triggerName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var webHooksSubscription = new JObject();
            var webHooksSubscriptionpropCount = 0;
            webHooksSubscription["callbackUrl"] = "@listCallbackUrl()";
            webHooksSubscriptionpropCount++;
            if (webHooksSubscriptionpropCount > 0)
            {
                callPayload.Body = webHooksSubscription;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class GetEntitiesResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Elfsquaddata;

    public partial class WorkflowManagedActions
    {
        public ElfsquaddataActions Elfsquaddata(string connectionId) => new ElfsquaddataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElfsquaddataTriggers Elfsquaddata(string connectionId) => new ElfsquaddataTriggers(connectionId);
    }
}