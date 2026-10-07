//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Libreborip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LibreboripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libreborip")]
        [WorkflowExpressionFactory(nameof(__BuildLibrebormeSearchCompany))]
        public IBodyWorkflowAction<LibrebormeSearchCompanyResponse> LibrebormeSearchCompany([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> province = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libreborip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LibrebormeSearchCompanyResponse> __BuildLibrebormeSearchCompany(WorkflowExpression<string> query, WorkflowExpression<string> page = null, WorkflowExpression<string> province = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(province, nameof(province), required: false);
            return new DeferredBodyAction<LibrebormeSearchCompanyResponse>(() =>
            {
                var apiCallPath = "/company/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (province != null)
                    callPayload.Queries["province"] = ExpressionConverter.Convert(province);
                return new ApiConnectionAction<LibrebormeSearchCompanyResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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