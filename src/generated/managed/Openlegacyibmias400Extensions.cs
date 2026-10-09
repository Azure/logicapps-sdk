//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmias400
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Openlegacyibmias400Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        [WorkflowExpressionFactory(nameof(__BuildAS400Cobol))]
        public IBodyWorkflowAction<JToken> AS400Cobol([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAS400Cobol(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-AS400Cobol";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        [WorkflowExpressionFactory(nameof(__BuildAS400Rpg))]
        public IBodyWorkflowAction<JToken> AS400Rpg([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAS400Rpg(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-AS400Rpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        [WorkflowExpressionFactory(nameof(__BuildAS400DataQueue))]
        public IBodyWorkflowAction<JToken> AS400DataQueue([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAS400DataQueue(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-AS400DataQueue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        [WorkflowExpressionFactory(nameof(__BuildAS400Db2Queries))]
        public IBodyWorkflowAction<JToken> AS400Db2Queries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAS400Db2Queries(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-AS400Db2Queries";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        [WorkflowExpressionFactory(nameof(__BuildAS400Db2Executables))]
        public IBodyWorkflowAction<JToken> AS400Db2Executables([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildAS400Db2Executables(WorkflowExpression<string> project, WorkflowExpression<string> method, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(project, nameof(project), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/dummy-AS400Db2Executables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class Openlegacyibmias400Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmias400;

    public partial class WorkflowManagedActions
    {
        public Openlegacyibmias400Actions Openlegacyibmias400(string connectionId) => new Openlegacyibmias400Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Openlegacyibmias400Triggers Openlegacyibmias400(string connectionId) => new Openlegacyibmias400Triggers(connectionId);
    }
}