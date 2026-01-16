//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Medallia
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MedalliaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        public IWorkflowAction TriggerInvitation(Expression<Func<string>> service, Expression<Func<string>> instanceURL)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "medallia")]
        public IWorkflowAction SendExperienceSignals(Expression<Func<string>> service, Expression<Func<string>> instanceURL)
        {
            var apiCallPath = String.Format("/inbound/v1/{0}", ExpressionConverter.ConvertWithUrlEncoding(service, 1));
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
        }
    }

    public class MedalliaTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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