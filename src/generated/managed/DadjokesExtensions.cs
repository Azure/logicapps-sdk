//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokes
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DadjokesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokes")]
        public IBodyWorkflowAction<JokeGetResponseItem[]> JokeGet(Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/v1/dadjokes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["X-RapidAPI-Host"] = Convert.ToString("dad-jokes-by-api-ninjas.p.rapidapi.com");
            return new ApiConnectionAction<JokeGetResponseItem[]>(callPayload);
        }
    }

    public class DadjokesTriggers([ConnectionName] string connectionId)
    {
    }

    public class JokeGetResponseItem
    {
        [JsonProperty("joke")]
        public string Joke { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokes;

    public partial class WorkflowManagedActions
    {
        public DadjokesActions Dadjokes(string connectionId) => new DadjokesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DadjokesTriggers Dadjokes(string connectionId) => new DadjokesTriggers(connectionId);
    }
}