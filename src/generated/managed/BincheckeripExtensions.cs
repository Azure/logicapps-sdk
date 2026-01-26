//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bincheckerip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BincheckeripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bincheckerip")]
        public IBodyWorkflowAction<SeachResponse> Seach(Expression<Func<int>> bIN)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(bIN, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SeachResponse>(callPayload);
        }
    }

    public class BincheckeripTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeachResponse
    {
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bincheckerip;

    public partial class WorkflowManagedActions
    {
        public BincheckeripActions Bincheckerip(string connectionId) => new BincheckeripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BincheckeripTriggers Bincheckerip(string connectionId) => new BincheckeripTriggers(connectionId);
    }
}