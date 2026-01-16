//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmmainframe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenlegacyibmmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfCicsCobol(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfCicsCobol";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfCtgCobol(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfCtgCobol";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfImsCobol(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfImsCobol";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfNatural(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfNatural";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfVsamCics(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfVsamCics";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> Mf3270Screens(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-Mf3270Screens";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        public IBodyWorkflowAction<JToken> MfMq(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-MfMq";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class OpenlegacyibmmainframeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmmainframe;

    public partial class WorkflowManagedActions
    {
        public OpenlegacyibmmainframeActions Openlegacyibmmainframe(string connectionId) => new OpenlegacyibmmainframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenlegacyibmmainframeTriggers Openlegacyibmmainframe(string connectionId) => new OpenlegacyibmmainframeTriggers(connectionId);
    }
}