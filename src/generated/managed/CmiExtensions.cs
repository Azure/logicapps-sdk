//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cmi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CmiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cmi")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> xCMITENANTNAME, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parameterspath, Expression<Func<string>> parametersbody = null)
        {
            var __workflow_xCMITENANTNAME = WorkflowExpression.Compile(xCMITENANTNAME, nameof(xCMITENANTNAME), required: true);
            var __workflow_parametersmethod = WorkflowExpression.Compile(parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parameterspath = WorkflowExpression.Compile(parameterspath, nameof(parameterspath), required: true);
            var __workflow_parametersbody = WorkflowExpression.Compile(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
