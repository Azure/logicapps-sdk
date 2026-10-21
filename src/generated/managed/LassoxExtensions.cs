//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lassox
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LassoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        public IWorkflowAction ActivateUser(Expression<Func<productInput>> product, Expression<Func<string>> productUserId)
        {
            var __workflow_product = WorkflowExpression.Compile(product, nameof(product), required: true);
            var __workflow_productUserId = WorkflowExpression.Compile(productUserId, nameof(productUserId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users/activatefromproduct";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Product"] = ExpressionConverter.Convert(__workflow_product);
                callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(__workflow_productUserId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        public IWorkflowAction DeactivateUser(Expression<Func<productInput>> product, Expression<Func<string>> productUserId)
        {
            var __workflow_product = WorkflowExpression.Compile(product, nameof(product), required: true);
            var __workflow_productUserId = WorkflowExpression.Compile(productUserId, nameof(productUserId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/users/deactivatefromproduct";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Product"] = ExpressionConverter.Convert(__workflow_product);
                callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(__workflow_productUserId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
