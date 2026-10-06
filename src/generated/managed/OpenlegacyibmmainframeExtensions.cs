//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmmainframe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenlegacyibmmainframeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfCicsCobol))]
        public IBodyWorkflowAction<JToken> MfCicsCobol([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfCicsCobol(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfCicsCobol";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfCtgCobol))]
        public IBodyWorkflowAction<JToken> MfCtgCobol([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfCtgCobol(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfCtgCobol";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfImsCobol))]
        public IBodyWorkflowAction<JToken> MfImsCobol([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfImsCobol(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfImsCobol";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfNatural))]
        public IBodyWorkflowAction<JToken> MfNatural([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfNatural(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfNatural";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfVsamCics))]
        public IBodyWorkflowAction<JToken> MfVsamCics([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfVsamCics(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfVsamCics";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMf3270Screens))]
        public IBodyWorkflowAction<JToken> Mf3270Screens([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMf3270Screens(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-Mf3270Screens";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildMfMq))]
        public IBodyWorkflowAction<JToken> MfMq([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildMfMq(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-MfMq";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class OpenlegacyibmmainframeTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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