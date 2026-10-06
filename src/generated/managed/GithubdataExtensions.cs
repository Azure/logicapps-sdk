//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubdata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubdataActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubdata")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveData))]
        public IBodyWorkflowAction<string> RetrieveData([WorkflowExpression] Func<string> githubname, [WorkflowExpression] Func<string> reponame, [WorkflowExpression] Func<string> filewithpath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubdata")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRetrieveData(WorkflowExpression<string> githubname, WorkflowExpression<string> reponame, WorkflowExpression<string> filewithpath)
        {
            WorkflowExpression.Validate(githubname, nameof(githubname), required: true);
            WorkflowExpression.Validate(reponame, nameof(reponame), required: true);
            WorkflowExpression.Validate(filewithpath, nameof(filewithpath), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(githubname, 1), ExpressionConverter.ConvertWithUrlEncoding(reponame, 1), ExpressionConverter.ConvertWithUrlEncoding(filewithpath, 1));
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