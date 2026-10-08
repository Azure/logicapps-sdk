//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lassox
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LassoxActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        [WorkflowExpressionFactory(nameof(__BuildActivateUser))]
        public IWorkflowAction ActivateUser([WorkflowExpression] Func<productInput> product, [WorkflowExpression] Func<string> productUserId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildActivateUser(WorkflowExpression<productInput> product, WorkflowExpression<string> productUserId)
        {
            WorkflowExpression.Validate(product, nameof(product), required: true);
            WorkflowExpression.Validate(productUserId, nameof(productUserId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users/activatefromproduct";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Product"] = ExpressionConverter.Convert(product);
                callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(productUserId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        [WorkflowExpressionFactory(nameof(__BuildDeactivateUser))]
        public IWorkflowAction DeactivateUser([WorkflowExpression] Func<productInput> product, [WorkflowExpression] Func<string> productUserId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeactivateUser(WorkflowExpression<productInput> product, WorkflowExpression<string> productUserId)
        {
            WorkflowExpression.Validate(product, nameof(product), required: true);
            WorkflowExpression.Validate(productUserId, nameof(productUserId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users/deactivatefromproduct";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Product"] = ExpressionConverter.Convert(product);
                callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(productUserId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LassoxTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum productInput
    {
        [EnumMember(Value = "dynamicscrm")]
        Dynamicscrm
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lassox;

    public partial class WorkflowManagedActions
    {
        public LassoxActions Lassox(string connectionId) => new LassoxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LassoxTriggers Lassox(string connectionId) => new LassoxTriggers(connectionId);
    }
}