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
        public IBodyWorkflowAction<string> Query([WorkflowExpression] Func<string> fcn, [WorkflowExpression] Func<bool> async = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<string[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/query/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fcn, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["async"] = Convert.ToString(false);
                if (async != null)
                    callPayload.Queries["async"] = SourceExpressionConverter.ConvertO(async);
                callPayload.Queries["timeout"] = Convert.ToString(5000);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Invoke([WorkflowExpression] Func<string> fcn, [WorkflowExpression] Func<bool> async = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<string[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoke/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fcn, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["async"] = Convert.ToString(false);
                if (async != null)
                    callPayload.Queries["async"] = SourceExpressionConverter.ConvertO(async);
                callPayload.Queries["timeout"] = Convert.ToString(3000);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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