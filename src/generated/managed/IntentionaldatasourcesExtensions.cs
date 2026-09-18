//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intentionaldatasources
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntentionaldatasourcesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntity([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(oDataQuery, nameof(oDataQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = SourceExpressionConverter.ConvertO(token);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = SourceExpressionConverter.ConvertO(oDataQuery);
                return callPayload;
            }

            return new ApiConnectionAction<SingleEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<SingleEntity> SingleEntityById([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(oDataQuery, nameof(oDataQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = SourceExpressionConverter.ConvertO(token);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = SourceExpressionConverter.ConvertO(oDataQuery);
                return callPayload;
            }

            return new ApiConnectionAction<SingleEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntity([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(oDataQuery, nameof(oDataQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = SourceExpressionConverter.ConvertO(token);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = SourceExpressionConverter.ConvertO(oDataQuery);
                return callPayload;
            }

            return new ApiConnectionAction<ListEntity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intentionaldatasources")]
        public IBodyWorkflowAction<ListEntity> ListEntityById([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> oDataQuery = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(oDataQuery, nameof(oDataQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(service, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = SourceExpressionConverter.ConvertO(token);
                if (oDataQuery != null)
                    callPayload.Queries["oDataQuery"] = SourceExpressionConverter.ConvertO(oDataQuery);
                return callPayload;
            }

            return new ApiConnectionAction<ListEntity>(BuildSourceInput);
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