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
        public IBodyWorkflowAction<JToken[]> GenerateDataFromExistingSchema([WorkflowExpression] Func<string> bodyschemaName = null, [WorkflowExpression] Func<string> bodyschemaJSON = null, [WorkflowExpression] Func<int> bodyrecordCount = null)
        {
            SourceExpression.Validate(bodyschemaName, nameof(bodyschemaName), required: false);
            SourceExpression.Validate(bodyschemaJSON, nameof(bodyschemaJSON), required: false);
            SourceExpression.Validate(bodyrecordCount, nameof(bodyrecordCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/generate.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["array"] = Convert.ToString(true);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyschemaName != null)
                {
                    body["schema"] = SourceExpressionConverter.ConvertToken(bodyschemaName);
                    bodypropCount++;
                }

                if (bodyschemaJSON != null)
                {
                    body["fields"] = SourceExpressionConverter.ConvertToken(bodyschemaJSON);
                    bodypropCount++;
                }

                if (bodyrecordCount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodyrecordCount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
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