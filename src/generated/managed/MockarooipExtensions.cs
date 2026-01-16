//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mockarooip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MockarooipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockarooip")]
        public IBodyWorkflowAction<JToken[]> GenerateDataFromExistingSchema(Expression<Func<string>> bodyschemaName = null, Expression<Func<string>> bodyschemaJSON = null, Expression<Func<int>> bodyrecordCount = null)
        {
            var apiCallPath = "/api/generate.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["array"] = Convert.ToString(true);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyschemaName != null)
            {
                body["schema"] = ExpressionConverter.ConvertO(bodyschemaName);
                bodypropCount++;
            }

            if (bodyschemaJSON != null)
            {
                body["fields"] = ExpressionConverter.ConvertO(bodyschemaJSON);
                bodypropCount++;
            }

            if (bodyrecordCount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodyrecordCount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
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