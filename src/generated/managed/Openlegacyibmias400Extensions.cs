//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Openlegacyibmias400
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Openlegacyibmias400Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Cobol(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-AS400Cobol";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Rpg(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-AS400Rpg";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400DataQueue(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-AS400DataQueue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Db2Queries(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-AS400Db2Queries";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openlegacyibmias400")]
        public IBodyWorkflowAction<JToken> AS400Db2Executables(Expression<Func<string>> project, Expression<Func<string>> method, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/dummy-AS400Db2Executables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            callPayload.Queries["method"] = ExpressionConverter.Convert(method);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class Openlegacyibmias400Triggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Openlegacyibmias400;

    public partial class WorkflowManagedActions
    {
        public Openlegacyibmias400Actions Openlegacyibmias400(string connectionId) => new Openlegacyibmias400Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Openlegacyibmias400Triggers Openlegacyibmias400(string connectionId) => new Openlegacyibmias400Triggers(connectionId);
    }
}