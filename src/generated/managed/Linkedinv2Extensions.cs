//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Linkedinv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Linkedinv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ListCompaniesResponseV2Item[]> ListCompaniesV2()
        {
            var apiCallPath = "/v2/organizationalEntityAcls";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListCompaniesResponseV2Item[]>(callPayload);
        }
    }

    public class Linkedinv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class ListCompaniesResponseV2Item
    {
        [JsonProperty("companyUrn")]
        public string CompanyUrn { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Linkedinv2;

    public partial class WorkflowManagedActions
    {
        public Linkedinv2Actions Linkedinv2(string connectionId) => new Linkedinv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Linkedinv2Triggers Linkedinv2(string connectionId) => new Linkedinv2Triggers(connectionId);
    }
}