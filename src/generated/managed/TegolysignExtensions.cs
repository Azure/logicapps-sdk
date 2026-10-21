//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tegolysign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TegolysignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tegolysign")]
        public IWorkflowAction ImportPDF(Expression<Func<object>> file)
        {
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/webhook/create-draft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class TegolysignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CompletelySigned(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/end-trigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["delivery_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tegolysign;

    public partial class WorkflowManagedActions
    {
        public TegolysignActions Tegolysign(string connectionId) => new TegolysignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TegolysignTriggers Tegolysign(string connectionId) => new TegolysignTriggers(connectionId);
    }
}
