//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntentionaldatasourcesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        [WorkflowExpressionFactory(nameof(__BuildSingleEntity))]
        public IBodyWorkflowAction<SingleEntity> SingleEntity([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleEntity> __BuildSingleEntity(WorkflowValue<string> token, WorkflowValue<string> service, WorkflowValue<string> entity, WorkflowValue<string> id = null, WorkflowValue<string> oDataQuery = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<SingleEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(service, 1), ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(token);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        [WorkflowExpressionFactory(nameof(__BuildSingleEntityById))]
        public IBodyWorkflowAction<SingleEntity> SingleEntityById([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleEntity> __BuildSingleEntityById(WorkflowValue<string> token, WorkflowValue<string> service, WorkflowValue<string> entity, WorkflowValue<string> id, WorkflowValue<string> oDataQuery = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<SingleEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(service, 1), ExpressionConverter.ConvertWithUrlEncoding(entity, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(token);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(oDataQuery);
                return new ApiConnectionAction<SingleEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        [WorkflowExpressionFactory(nameof(__BuildListEntity))]
        public IBodyWorkflowAction<ListEntity> ListEntity([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListEntity> __BuildListEntity(WorkflowValue<string> token, WorkflowValue<string> service, WorkflowValue<string> entity, WorkflowValue<string> id = null, WorkflowValue<string> oDataQuery = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<ListEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/list", ExpressionConverter.ConvertWithUrlEncoding(service, 1), ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(token);
                if (id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        [WorkflowExpressionFactory(nameof(__BuildListEntityById))]
        public IBodyWorkflowAction<ListEntity> ListEntityById([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListEntity> __BuildListEntityById(WorkflowValue<string> token, WorkflowValue<string> service, WorkflowValue<string> entity, WorkflowValue<string> id, WorkflowValue<string> oDataQuery = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(oDataQuery, nameof(oDataQuery), required: false);
            return new DeferredBodyAction<ListEntity>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/list", ExpressionConverter.ConvertWithUrlEncoding(service, 1), ExpressionConverter.ConvertWithUrlEncoding(entity, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(token);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = ExpressionConverter.Convert(oDataQuery);
                return new ApiConnectionAction<ListEntity>(callPayload);
            });
        }
    }

    public class IntentionaldatasourcesTriggers([ConnectionName] string connectionId)
    {
    }

    public class SingleEntity
    {
        public JToken DynamicProperties { get; set; }
    }

    public class ListEntity
    {
        public JToken DynamicProperties { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources;

    public partial class WorkflowManagedActions
    {
        public IntentionaldatasourcesActions Intentionaldatasources(string connectionId) => new IntentionaldatasourcesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntentionaldatasourcesTriggers Intentionaldatasources(string connectionId) => new IntentionaldatasourcesTriggers(connectionId);
    }
}
