//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openlegacyibmias400
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Openlegacyibmias400Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Cobol([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dummy-AS400Cobol";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Rpg([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dummy-AS400Rpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400DataQueue([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dummy-AS400DataQueue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Db2Queries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dummy-AS400Db2Queries";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Db2Executables([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dummy-AS400Db2Executables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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