//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Nameapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NameapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nameapi")]
        public IBodyWorkflowAction<DetectDeaResponse> DetectDea(Expression<Func<string>> emailAddress)
        {
            var apiCallPath = "/v5.3/email/disposableemailaddressdetector";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["emailAddress"] = ExpressionConverter.Convert(emailAddress);
            return new ApiConnectionAction<DetectDeaResponse>(callPayload);
        }
    }

    public class NameapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class DetectDeaResponse
    {
        [JsonProperty("disposable")]
        public string Disposable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Nameapi;

    public partial class WorkflowManagedActions
    {
        public NameapiActions Nameapi(string connectionId) => new NameapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NameapiTriggers Nameapi(string connectionId) => new NameapiTriggers(connectionId);
    }
}