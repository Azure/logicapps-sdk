//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cmi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CmiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cmi")]
        public IWorkflowAction HttpRequest([WorkflowExpression] Func<string> xCMITENANTNAME, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parameterspath, [WorkflowExpression] Func<string> parametersbody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-CMI-TENANT-NAME"] = SourceExpressionConverter.ConvertO(xCMITENANTNAME);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = SourceExpressionConverter.Convert(parametersmethod);
                parameterspropCount++;
                parameters["path"] = SourceExpressionConverter.ConvertToken(parameterspath);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["body"] = SourceExpressionConverter.ConvertToken(parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CmiTriggers([ConnectionName] string connectionId)
    {
    }

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