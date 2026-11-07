//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Biztalk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BiztalkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EncodeJson(Expression<Func<object>> requestContent, Expression<Func<string>> documentSpec = null)
        {
            var __workflow_requestContent = WorkflowExpression.Compile(requestContent, nameof(requestContent), required: true);
            var __workflow_documentSpec = WorkflowExpression.Compile(documentSpec, nameof(documentSpec), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EncodeJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_documentSpec != null)
                    callPayload.Queries["documentSpec"] = ExpressionConverter.Convert(__workflow_documentSpec);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestContent);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EncodeXml(Expression<Func<string>> body, Expression<Func<string>> documentSpec = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_documentSpec = WorkflowExpression.Compile(documentSpec, nameof(documentSpec), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EncodeXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_documentSpec != null)
                    callPayload.Queries["documentSpec"] = ExpressionConverter.Convert(__workflow_documentSpec);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "biztalk")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Send(Expression<Func<string>> receiveLocationAddress, Expression<Func<string>> body)
        {
            var __workflow_receiveLocationAddress = WorkflowExpression.Compile(receiveLocationAddress, nameof(receiveLocationAddress), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["receiveLocationAddress"] = ExpressionConverter.Convert(__workflow_receiveLocationAddress);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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