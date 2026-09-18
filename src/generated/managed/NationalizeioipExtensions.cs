//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nationalizeioip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NationalizeioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nationalizeioip")]
        public IBodyWorkflowAction<CheckNamesNationalityResponseItem[]> CheckNamesNationality([WorkflowExpression] Func<string> name)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CheckNamesNationalityResponseItem[]>(callPayload);
        }
    }

    public class NationalizeioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckNamesNationalityResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public CheckNamesNationalityResponseItemCountryTypeItem[] Country { get; set; }
    }

    public class CheckNamesNationalityResponseItemCountryTypeItem
    {
        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nationalizeioip;

    public partial class WorkflowManagedActions
    {
        public NationalizeioipActions Nationalizeioip(string connectionId) => new NationalizeioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NationalizeioipTriggers Nationalizeioip(string connectionId) => new NationalizeioipTriggers(connectionId);
    }
}