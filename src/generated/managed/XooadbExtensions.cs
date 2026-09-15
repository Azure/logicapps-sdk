//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooadb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XooadbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Query(Expression<Func<string>> fcn, Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/query/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fcn, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["async"] = Convert.ToString(false);
            if (async != null)
                callPayload.Queries["async"] = CSharpExpressionConverter.ConvertO(async);
            callPayload.Queries["timeout"] = Convert.ToString(5000);
            if (timeout != null)
                callPayload.Queries["timeout"] = CSharpExpressionConverter.ConvertO(timeout);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Invoke(Expression<Func<string>> fcn, Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/invoke/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fcn, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["async"] = Convert.ToString(false);
            if (async != null)
                callPayload.Queries["async"] = CSharpExpressionConverter.ConvertO(async);
            callPayload.Queries["timeout"] = Convert.ToString(3000);
            if (timeout != null)
                callPayload.Queries["timeout"] = CSharpExpressionConverter.ConvertO(timeout);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class XooadbTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xooadb;

    public partial class WorkflowManagedActions
    {
        public XooadbActions Xooadb(string connectionId) => new XooadbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XooadbTriggers Xooadb(string connectionId) => new XooadbTriggers(connectionId);
    }
}