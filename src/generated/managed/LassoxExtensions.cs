//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lassox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LassoxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        public IWorkflowAction ActivateUser(Expression<Func<productInput>> product, Expression<Func<string>> productUserId)
        {
            var apiCallPath = "/users/activatefromproduct";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Product"] = ExpressionConverter.Convert(product);
            callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(productUserId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lassox")]
        public IWorkflowAction DeactivateUser(Expression<Func<productInput>> product, Expression<Func<string>> productUserId)
        {
            var apiCallPath = "/users/deactivatefromproduct";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Product"] = ExpressionConverter.Convert(product);
            callPayload.Queries["ProductUserId"] = ExpressionConverter.Convert(productUserId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class LassoxTriggers([ConnectionName] string connectionId)
    {
    }

    public enum productInput
    {
        [EnumMember(Value = "dynamicscrm")]
        Dynamicscrm
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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