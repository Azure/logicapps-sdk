//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mockarooip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MockarooipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockarooip")]
        public IBodyWorkflowAction<JToken[]> GenerateDataFromExistingSchema(Expression<Func<string>> bodyschemaName = null, Expression<Func<string>> bodyschemaJSON = null, Expression<Func<int>> bodyrecordCount = null)
        {
            var __workflow_bodyschemaName = WorkflowExpression.Compile(bodyschemaName, nameof(bodyschemaName), required: false);
            var __workflow_bodyschemaJSON = WorkflowExpression.Compile(bodyschemaJSON, nameof(bodyschemaJSON), required: false);
            var __workflow_bodyrecordCount = WorkflowExpression.Compile(bodyrecordCount, nameof(bodyrecordCount), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/api/generate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["array"] = Convert.ToString(true);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyschemaName != null)
                {
                    body["schema"] = ExpressionConverter.ConvertO(__workflow_bodyschemaName);
                    bodypropCount++;
                }

                if (__workflow_bodyschemaJSON != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyschemaJSON);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordCount != null)
                {
                    body["count"] = ExpressionConverter.ConvertO(__workflow_bodyrecordCount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }
    }

    public class MockarooipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mockarooip;

    public partial class WorkflowManagedActions
    {
        public MockarooipActions Mockarooip(string connectionId) => new MockarooipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MockarooipTriggers Mockarooip(string connectionId) => new MockarooipTriggers(connectionId);
    }
}
