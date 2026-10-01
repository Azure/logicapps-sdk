//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractcompanyenric
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractcompanyenricActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractcompanyenric")]
        public IBodyWorkflowAction<ValidateResponse> Validate([WorkflowExpression] Func<string> domain)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                return callPayload;
            }

            return new ApiConnectionAction<ValidateResponse>(BuildSourceInput);
        }
    }

    public class AbstractcompanyenricTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("employees_count")]
        public int EmployeesCount { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractcompanyenric;

    public partial class WorkflowManagedActions
    {
        public AbstractcompanyenricActions Abstractcompanyenric(string connectionId) => new AbstractcompanyenricActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractcompanyenricTriggers Abstractcompanyenric(string connectionId) => new AbstractcompanyenricTriggers(connectionId);
    }
}