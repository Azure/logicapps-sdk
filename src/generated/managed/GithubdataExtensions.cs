//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Githubdata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GithubdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "githubdata")]
        public IBodyWorkflowAction<string> RetrieveData(Expression<Func<string>> githubname, Expression<Func<string>> reponame, Expression<Func<string>> filewithpath)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(githubname, 1), ExpressionConverter.ConvertWithUrlEncoding(reponame, 1), ExpressionConverter.ConvertWithUrlEncoding(filewithpath, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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