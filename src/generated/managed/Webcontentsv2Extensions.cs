//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webcontentsv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Webcontentsv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontentsv2")]
        public IBodyWorkflowAction<JToken> InvokeHttp([WorkflowExpression] Func<requestmethodInput> requestmethod, [WorkflowExpression] Func<string> requesturlOfTheRequest, [WorkflowExpression] Func<string> requestbodyOfTheRequest = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/InvokeHttp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["method"] = SourceExpressionConverter.Convert(requestmethod);
                requestpropCount++;
                request["url"] = SourceExpressionConverter.ConvertToken(requesturlOfTheRequest);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    request["headers"] = headersObject;
                    requestpropCount++;
                }

                if (requestbodyOfTheRequest != null)
                {
                    request["body"] = SourceExpressionConverter.ConvertToken(requestbodyOfTheRequest);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class Webcontentsv2Triggers([ConnectionName] string connectionId)
    {
    }

    public enum requestmethodInput
    {
        GET,
        DELETE,
        PATCH,
        POST,
        PUT
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webcontentsv2;

    public partial class WorkflowManagedActions
    {
        public Webcontentsv2Actions Webcontentsv2(string connectionId) => new Webcontentsv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Webcontentsv2Triggers Webcontentsv2(string connectionId) => new Webcontentsv2Triggers(connectionId);
    }
}