//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Datascopeforms
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DatascopeformsActions([ConnectionName] string connectionId)
    {
    }

    public class DatascopeformsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildFormAnswer))]
        public IBodyWorkflowTrigger<JToken> FormAnswer([WorkflowExpression] Func<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildFormAnswer(WorkflowValue<string> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/hooks_flow/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["subscription_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
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
