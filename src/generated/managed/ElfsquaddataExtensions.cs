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
        public IBodyWorkflowAction<GetEntitiesResponse> GetEntities([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<bool> count = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/data/1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<GetEntitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> PostEntityById([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<object> entity = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/data/1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entity);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> GetEntityById([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/data/1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IWorkflowAction DeleteEntityById([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/data/1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IWorkflowAction PutEntityById([WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> entity = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/data/1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entity);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquaddata")]
        public IBodyWorkflowAction<JToken> InvokeFunction([WorkflowExpression] Func<string> functionPath, [WorkflowExpression] Func<object> functionInputSchema = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(functionPath, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(functionInputSchema);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class ElfsquaddataTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTrigger([WorkflowExpression] Func<string> triggerName2, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/2/webhooks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(triggerName2, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var webHooksSubscription = new JObject();
                var webHooksSubscriptionpropCount = 0;
                webHooksSubscription["callbackUrl"] = "#{listCallbackUrl()}";
                webHooksSubscriptionpropCount++;
                if (webHooksSubscriptionpropCount > 0)
                {
                    callPayload.Body = webHooksSubscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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