//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dadjokes
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DadjokesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dadjokes")]
        [WorkflowExpressionFactory(nameof(__BuildJokeGet))]
        public IBodyWorkflowAction<JokeGetResponseItem[]> JokeGet([WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JokeGetResponseItem[]> __BuildJokeGet(WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<JokeGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/dadjokes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Headers["X-RapidAPI-Host"] = Convert.ToString("dad-jokes-by-api-ninjas.p.rapidapi.com");
                return new ApiConnectionAction<JokeGetResponseItem[]>(callPayload);
            });
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
