//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Si3270
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Si3270Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "si3270")]
        public IBodyWorkflowAction<JToken> ExecuteMethod(Expression<Func<string>> hidxName, Expression<Func<string>> methodName, Expression<Func<object>> parameters = null)
        {
            var apiCallPath = String.Format("/hidx/{0}/methods/{1}/call", ExpressionConverter.ConvertWithUrlEncoding(hidxName, 1), ExpressionConverter.ConvertWithUrlEncoding(methodName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(parameters);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class Si3270Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Si3270;

    public partial class WorkflowManagedActions
    {
        public Si3270Actions Si3270(string connectionId) => new Si3270Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Si3270Triggers Si3270(string connectionId) => new Si3270Triggers(connectionId);
    }
}