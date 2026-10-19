//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooadb
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XooadbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Query(Expression<Func<string>> fcn, Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_fcn = WorkflowExpression.Compile(fcn, nameof(fcn), required: true);
            var __workflow_async = WorkflowExpression.Compile(async, nameof(async), required: false);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/{0}", __workflow_fcn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["async"] = Convert.ToString(false);
                if (__workflow_async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(__workflow_async);
                callPayload.Queries["timeout"] = Convert.ToString(5000);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Invoke(Expression<Func<string>> fcn, Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_fcn = WorkflowExpression.Compile(fcn, nameof(fcn), required: true);
            var __workflow_async = WorkflowExpression.Compile(async, nameof(async), required: false);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoke/{0}", __workflow_fcn.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["async"] = Convert.ToString(false);
                if (__workflow_async != null)
                    callPayload.Queries["async"] = ExpressionConverter.Convert(__workflow_async);
                callPayload.Queries["timeout"] = Convert.ToString(3000);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
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
