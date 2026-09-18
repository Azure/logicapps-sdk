//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datascopeforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatascopeformsActions([ConnectionName] string connectionId)
    {
    }

    public class DatascopeformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> FormAnswer([WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hooks_flow/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["subscription_url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Datascopeforms;

    public partial class WorkflowManagedActions
    {
        public DatascopeformsActions Datascopeforms(string connectionId) => new DatascopeformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DatascopeformsTriggers Datascopeforms(string connectionId) => new DatascopeformsTriggers(connectionId);
    }
}