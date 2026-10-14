//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubdata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GithubdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubdata")]
        public IBodyWorkflowAction<string> RetrieveData(Expression<Func<string>> githubname, Expression<Func<string>> reponame, Expression<Func<string>> filewithpath)
        {
            var __workflow_githubname = githubname == null ? null : WorkflowExpression.Compile(githubname);
            WorkflowExpression.Validate(__workflow_githubname, nameof(githubname), required: true);
            var __workflow_reponame = reponame == null ? null : WorkflowExpression.Compile(reponame);
            WorkflowExpression.Validate(__workflow_reponame, nameof(reponame), required: true);
            var __workflow_filewithpath = filewithpath == null ? null : WorkflowExpression.Compile(filewithpath);
            WorkflowExpression.Validate(__workflow_filewithpath, nameof(filewithpath), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_githubname, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_reponame, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_filewithpath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class GithubdataTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Githubdata;

    public partial class WorkflowManagedActions
    {
        public GithubdataActions Githubdata(string connectionId) => new GithubdataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GithubdataTriggers Githubdata(string connectionId) => new GithubdataTriggers(connectionId);
    }
}
