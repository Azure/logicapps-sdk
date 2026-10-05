//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cmi
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CmiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cmi")]
        [WorkflowExpressionFactory(nameof(__BuildHttpRequest))]
        public IWorkflowAction HttpRequest([WorkflowExpression] Func<string> xCMITENANTNAME, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parameterspath, [WorkflowExpression] Func<string> parametersbody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHttpRequest(WorkflowValue<string> xCMITENANTNAME, WorkflowValue<parametersmethodInput> parametersmethod, WorkflowValue<string> parameterspath, WorkflowValue<string> parametersbody = null)
        {
            WorkflowValue.Validate(xCMITENANTNAME, nameof(xCMITENANTNAME), required: true);
            WorkflowValue.Validate(parametersmethod, nameof(parametersmethod), required: true);
            WorkflowValue.Validate(parameterspath, nameof(parameterspath), required: true);
            WorkflowValue.Validate(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-CMI-TENANT-NAME"] = ExpressionConverter.Convert(xCMITENANTNAME);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = ExpressionConverter.ConvertO(parametersmethod);
                parameterspropCount++;
                parameters["path"] = ExpressionConverter.ConvertO(parameterspath);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["body"] = ExpressionConverter.ConvertO(parametersbody);
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
