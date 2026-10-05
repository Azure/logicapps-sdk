//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Medallia
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MedalliaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        [WorkflowExpressionFactory(nameof(__BuildTriggerInvitation))]
        public IWorkflowAction TriggerInvitation([WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> instanceURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTriggerInvitation(WorkflowValue<string> service, WorkflowValue<string> instanceURL)
        {
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(instanceURL, nameof(instanceURL), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance-URL"] = ExpressionConverter.Convert(instanceURL);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        [WorkflowExpressionFactory(nameof(__BuildSendExperienceSignals))]
        public IWorkflowAction SendExperienceSignals([WorkflowExpression] Func<string> service, [WorkflowExpression] Func<string> instanceURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendExperienceSignals(WorkflowValue<string> service, WorkflowValue<string> instanceURL)
        {
            WorkflowValue.Validate(service, nameof(service), required: true);
            WorkflowValue.Validate(instanceURL, nameof(instanceURL), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/inbound/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Instance-URL"] = ExpressionConverter.Convert(instanceURL);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class MedalliaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Medallia;

    public partial class WorkflowManagedActions
    {
        public MedalliaActions Medallia(string connectionId) => new MedalliaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MedalliaTriggers Medallia(string connectionId) => new MedalliaTriggers(connectionId);
    }
}
