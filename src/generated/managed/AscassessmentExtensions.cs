//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ascassessment
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AscassessmentActions([ConnectionName] string connectionId)
    {
    }

    public class AscassessmentTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASCAssessmentTriggerSubscribe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Microsoft.Security/Assessment/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback_url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ascassessment;

    public partial class WorkflowManagedActions
    {
        public AscassessmentActions Ascassessment(string connectionId) => new AscassessmentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AscassessmentTriggers Ascassessment(string connectionId) => new AscassessmentTriggers(connectionId);
    }
}