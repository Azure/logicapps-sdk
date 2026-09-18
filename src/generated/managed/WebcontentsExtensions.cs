//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webcontents
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebcontentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetFileContent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webcontents")]
        public IBodyWorkflowAction<JToken> InvokeHttp([WorkflowExpression] Func<requestmethodInput> requestmethod, [WorkflowExpression] Func<string> requesturlOfTheRequest, [WorkflowExpression] Func<string> requestbodyOfTheRequest = null)
        {
            SourceExpression.Validate(requestmethod, nameof(requestmethod), required: true);
            SourceExpression.Validate(requesturlOfTheRequest, nameof(requesturlOfTheRequest), required: true);
            SourceExpression.Validate(requestbodyOfTheRequest, nameof(requestbodyOfTheRequest), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/codeless/InvokeHttp";
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

    public class WebcontentsTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webcontents;

    public partial class WorkflowManagedActions
    {
        public WebcontentsActions Webcontents(string connectionId) => new WebcontentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebcontentsTriggers Webcontents(string connectionId) => new WebcontentsTriggers(connectionId);
    }
}