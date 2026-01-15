//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Biztalk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BiztalkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> EncodeJson(Expression<Func<string>> documentSpec = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> EncodeXml(Expression<Func<string>> documentSpec = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/EncodeXml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (documentSpec != null)
                callPayload.Queries["documentSpec"] = ExpressionConverter.Convert(documentSpec);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string> Send(Expression<Func<string>> receiveLocationAddress, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/Send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["receiveLocationAddress"] = ExpressionConverter.Convert(receiveLocationAddress);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class BiztalkTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Biztalk;

    public partial class WorkflowManagedActions
    {
        public BiztalkActions Biztalk(string connectionId) => new BiztalkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BiztalkTriggers Biztalk(string connectionId) => new BiztalkTriggers(connectionId);
    }
}