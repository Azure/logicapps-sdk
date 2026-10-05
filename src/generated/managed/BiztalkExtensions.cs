//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Biztalk
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BiztalkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        [WorkflowExpressionFactory(nameof(__BuildEncodeJson))]
        public IBodyWorkflowAction<string> EncodeJson([WorkflowExpression] Func<string> documentSpec = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEncodeJson(WorkflowValue<string> documentSpec = null)
        {
            WorkflowValue.Validate(documentSpec, nameof(documentSpec), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/EncodeJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentSpec != null)
                    callPayload.Queries["documentSpec"] = ExpressionConverter.Convert(documentSpec);
                var requestContent = new JObject();
                var requestContentpropCount = 0;
                if (requestContentpropCount > 0)
                {
                    callPayload.Body = requestContent;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        [WorkflowExpressionFactory(nameof(__BuildEncodeXml))]
        public IBodyWorkflowAction<string> EncodeXml([WorkflowExpression] Func<string> documentSpec = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildEncodeXml(WorkflowValue<string> documentSpec = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(documentSpec, nameof(documentSpec), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/EncodeXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentSpec != null)
                    callPayload.Queries["documentSpec"] = ExpressionConverter.Convert(documentSpec);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        [WorkflowExpressionFactory(nameof(__BuildSend))]
        public IBodyWorkflowAction<string> Send([WorkflowExpression] Func<string> receiveLocationAddress, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSend(WorkflowValue<string> receiveLocationAddress, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(receiveLocationAddress, nameof(receiveLocationAddress), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["receiveLocationAddress"] = ExpressionConverter.Convert(receiveLocationAddress);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class BiztalkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Biztalk;

    public partial class WorkflowManagedActions
    {
        public BiztalkActions Biztalk(string connectionId) => new BiztalkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BiztalkTriggers Biztalk(string connectionId) => new BiztalkTriggers(connectionId);
    }
}
