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
        public IBodyWorkflowAction<string> RetrieveData([WorkflowExpression] Func<string> githubname, [WorkflowExpression] Func<string> reponame, [WorkflowExpression] Func<string> filewithpath)
        {
            SourceExpression.Validate(githubname, nameof(githubname), required: true);
            SourceExpression.Validate(reponame, nameof(reponame), required: true);
            SourceExpression.Validate(filewithpath, nameof(filewithpath), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(githubname, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reponame, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filewithpath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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