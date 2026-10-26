//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubdata
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubdata")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RetrieveData(Expression<Func<string>> githubname, Expression<Func<string>> reponame, Expression<Func<string>> filewithpath)
        {
            var __workflow_githubname = WorkflowExpression.Compile(githubname, nameof(githubname), required: true);
            var __workflow_reponame = WorkflowExpression.Compile(reponame, nameof(reponame), required: true);
            var __workflow_filewithpath = WorkflowExpression.Compile(filewithpath, nameof(filewithpath), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/{2}", __workflow_githubname.WithUrlEncoding(1), __workflow_reponame.WithUrlEncoding(1), __workflow_filewithpath.WithUrlEncoding(1)));
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