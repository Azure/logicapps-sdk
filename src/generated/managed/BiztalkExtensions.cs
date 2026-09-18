//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Biztalk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BiztalkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> EncodeJson([WorkflowExpression] Func<string> documentSpec = null)
        {
            SourceExpression.Validate(documentSpec, nameof(documentSpec), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentSpec != null)
                    callPayload.Queries["documentSpec"] = SourceExpressionConverter.ConvertO(documentSpec);
                var requestContent = new JObject();
                var requestContentpropCount = 0;
                if (requestContentpropCount > 0)
                {
                    callPayload.Body = requestContent;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> EncodeXml([WorkflowExpression] Func<string> documentSpec = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(documentSpec, nameof(documentSpec), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EncodeXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentSpec != null)
                    callPayload.Queries["documentSpec"] = SourceExpressionConverter.ConvertO(documentSpec);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> Send([WorkflowExpression] Func<string> receiveLocationAddress, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(receiveLocationAddress, nameof(receiveLocationAddress), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["receiveLocationAddress"] = SourceExpressionConverter.ConvertO(receiveLocationAddress);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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