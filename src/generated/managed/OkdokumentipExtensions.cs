//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Okdokumentip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OkdokumentipActions([ConnectionName] string connectionId)
    {
    }

    public class OkdokumentipTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WaitForSignature(Expression<Func<string>> signatureRequestId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/signatureRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(signatureRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["sendInfoURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Okdokumentip;

    public partial class WorkflowManagedActions
    {
        public OkdokumentipActions Okdokumentip(string connectionId) => new OkdokumentipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OkdokumentipTriggers Okdokumentip(string connectionId) => new OkdokumentipTriggers(connectionId);
    }
}