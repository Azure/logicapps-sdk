//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Libreborip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LibreboripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libreborip")]
        public IBodyWorkflowAction<LibrebormeSearchCompanyResponse> LibrebormeSearchCompany([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> province = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/company/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (province != null)
                    callPayload.Queries["province"] = SourceExpressionConverter.ConvertO(province);
                return callPayload;
            }

            return new ApiConnectionAction<LibrebormeSearchCompanyResponse>(BuildSourceInput);
        }
    }

    public class LibreboripTriggers([ConnectionName] string connectionId)
    {
    }

    public class LibrebormeSearchCompanyResponse
    {
        [JsonProperty("companies")]
        public CompanySearchResult[] Companies { get; set; }

        [JsonProperty("count_results")]
        public int CountResults { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }

    public class CompanySearchResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("status")]
        public CompanyStatus Status { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }
    }

    public enum CompanyStatus
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "dissolved")]
        Dissolved,
        [EnumMember(Value = "renamed")]
        Renamed,
        [EnumMember(Value = "transformed")]
        Transformed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Libreborip;

    public partial class WorkflowManagedActions
    {
        public LibreboripActions Libreborip(string connectionId) => new LibreboripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LibreboripTriggers Libreborip(string connectionId) => new LibreboripTriggers(connectionId);
    }
}