//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xooadb
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class XooadbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xooadb")]
        public IBodyWorkflowAction<string> Query(Expression<Func<string>> fcn, Expression<Func<bool>> async = null, Expression<Func<int>> timeout = null, Expression<Func<string[]>> body = null)
        {
            var __workflow_fcn = fcn == null ? null : WorkflowExpression.Compile(fcn);
            WorkflowExpression.Validate(__workflow_fcn, nameof(fcn), required: true);
            var __workflow_async = async == null ? null : WorkflowExpression.Compile(async);
            WorkflowExpression.Validate(__workflow_async, nameof(async), required: false);
            var __workflow_timeout = timeout == null ? null : WorkflowExpression.Compile(timeout);
            WorkflowExpression.Validate(__workflow_timeout, nameof(timeout), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/query/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_fcn, 1));
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
            var __workflow_fcn = fcn == null ? null : WorkflowExpression.Compile(fcn);
            WorkflowExpression.Validate(__workflow_fcn, nameof(fcn), required: true);
            var __workflow_async = async == null ? null : WorkflowExpression.Compile(async);
            WorkflowExpression.Validate(__workflow_async, nameof(async), required: false);
            var __workflow_timeout = timeout == null ? null : WorkflowExpression.Compile(timeout);
            WorkflowExpression.Validate(__workflow_timeout, nameof(timeout), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoke/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_fcn, 1));
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
