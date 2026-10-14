//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cmi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CmiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cmi")]
        public IWorkflowAction HttpRequest(Expression<Func<string>> xCMITENANTNAME, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parameterspath, Expression<Func<string>> parametersbody = null)
        {
            var __workflow_xCMITENANTNAME = xCMITENANTNAME == null ? null : WorkflowExpression.Compile(xCMITENANTNAME);
            WorkflowExpression.Validate(__workflow_xCMITENANTNAME, nameof(xCMITENANTNAME), required: true);
            var __workflow_parametersmethod = parametersmethod == null ? null : WorkflowExpression.Compile(parametersmethod);
            WorkflowExpression.Validate(__workflow_parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parameterspath = parameterspath == null ? null : WorkflowExpression.Compile(parameterspath);
            WorkflowExpression.Validate(__workflow_parameterspath, nameof(parameterspath), required: true);
            var __workflow_parametersbody = parametersbody == null ? null : WorkflowExpression.Compile(parametersbody);
            WorkflowExpression.Validate(__workflow_parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-CMI-TENANT-NAME"] = ExpressionConverter.Convert(__workflow_xCMITENANTNAME);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = ExpressionConverter.ConvertO(__workflow_parametersmethod);
                parameterspropCount++;
                parameters["path"] = ExpressionConverter.ConvertO(__workflow_parameterspath);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (__workflow_parametersbody != null)
                {
                    parameters["body"] = ExpressionConverter.ConvertO(__workflow_parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CmiTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum parametersmethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cmi;

    public partial class WorkflowManagedActions
    {
        public CmiActions Cmi(string connectionId) => new CmiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CmiTriggers Cmi(string connectionId) => new CmiTriggers(connectionId);
    }
}
