//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Youneedabudgetip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YouneedabudgetipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "youneedabudgetip")]
        public IBodyWorkflowAction<UserResponse> GetUser()
        {
            var apiCallPath = "/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class YouneedabudgetipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserResponse
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Youneedabudgetip;

    public partial class WorkflowManagedActions
    {
        public YouneedabudgetipActions Youneedabudgetip(string connectionId) => new YouneedabudgetipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YouneedabudgetipTriggers Youneedabudgetip(string connectionId) => new YouneedabudgetipTriggers(connectionId);
    }
}