//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finnishbisip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinnishbisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishbisip")]
        public IBodyWorkflowAction<CompanyByBisCodeResponse, ApiConnectionActionConfiguration> CompanyByBisCode(Expression<Func<string>> businessId)
        {
            var __workflow_businessId = WorkflowExpression.Compile(businessId, nameof(businessId), required: true);
            return new DeferredBodyAction<CompanyByBisCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bis/v1/{0}", __workflow_businessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyByBisCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishbisip")]
        public IBodyWorkflowAction<CompanySearchResponse, ApiConnectionActionConfiguration> CompanySearch(Expression<Func<string>> name = null, Expression<Func<int>> maxResults = null, Expression<Func<bool>> totalResults = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            var __workflow_totalResults = WorkflowExpression.Compile(totalResults, nameof(totalResults), required: false);
            return new DeferredBodyAction<CompanySearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bis/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["maxResults"] = Convert.ToString(10);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                callPayload.Queries["totalResults"] = Convert.ToString(true);
                if (__workflow_totalResults != null)
                    callPayload.Queries["totalResults"] = ExpressionConverter.Convert(__workflow_totalResults);
                return new ApiConnectionAction<CompanySearchResponse>(callPayload);
            });
        }
    }

    public class FinnishbisipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompanyByBisCodeResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsFrom")]
        public int ResultsFrom { get; set; }

        [JsonProperty("previousResultsUri")]
        public string PreviousResultsUri { get; set; }

        [JsonProperty("nextResultsUri")]
        public string NextResultsUri { get; set; }

        [JsonProperty("exceptionNoticeUri")]
        public string ExceptionNoticeUri { get; set; }

        [JsonProperty("results")]
        public CompanyByBisCodeResponseResultsTypeItem[] Results { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItem
    {
        [JsonProperty("businessId")]
        public string BusinessId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("companyForm")]
        public string CompanyForm { get; set; }

        [JsonProperty("detailsUri")]
        public string DetailsUri { get; set; }

        [JsonProperty("liquidations")]
        public CompanyByBisCodeResponseResultsTypeItemLiquidationsTypeItem[] Liquidations { get; set; }

        [JsonProperty("names")]
        public CompanyByBisCodeResponseResultsTypeItemNamesTypeItem[] Names { get; set; }

        [JsonProperty("auxiliaryNames")]
        public CompanyByBisCodeResponseResultsTypeItemAuxiliaryNamesTypeItem[] AuxiliaryNames { get; set; }

        [JsonProperty("addresses")]
        public CompanyByBisCodeResponseResultsTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("companyForms")]
        public CompanyByBisCodeResponseResultsTypeItemCompanyFormsTypeItem[] CompanyForms { get; set; }

        [JsonProperty("businessLines")]
        public CompanyByBisCodeResponseResultsTypeItemBusinessLinesTypeItem[] BusinessLines { get; set; }

        [JsonProperty("languages")]
        public CompanyByBisCodeResponseResultsTypeItemLanguagesTypeItem[] Languages { get; set; }

        [JsonProperty("registedOffices")]
        public CompanyByBisCodeResponseResultsTypeItemRegistedOfficesTypeItem[] RegistedOffices { get; set; }

        [JsonProperty("contactDetails")]
        public CompanyByBisCodeResponseResultsTypeItemContactDetailsTypeItem[] ContactDetails { get; set; }

        [JsonProperty("registeredEntries")]
        public CompanyByBisCodeResponseResultsTypeItemRegisteredEntriesTypeItem[] RegisteredEntries { get; set; }

        [JsonProperty("businessIdChanges")]
        public CompanyByBisCodeResponseResultsTypeItemBusinessIdChangesTypeItem[] BusinessIdChanges { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemLiquidationsTypeItem
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemNamesTypeItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemAuxiliaryNamesTypeItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemAddressesTypeItem
    {
        [JsonProperty("careOf")]
        public string CareOf { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemCompanyFormsTypeItem
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemBusinessLinesTypeItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemLanguagesTypeItem
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemRegistedOfficesTypeItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemContactDetailsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemRegisteredEntriesTypeItem
    {
        [JsonProperty("authority")]
        public int Authority { get; set; }

        [JsonProperty("register")]
        public int Register { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("statusDate")]
        public string StatusDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CompanyByBisCodeResponseResultsTypeItemBusinessIdChangesTypeItem
    {
        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("changeDate")]
        public string ChangeDate { get; set; }

        [JsonProperty("change")]
        public string Change { get; set; }

        [JsonProperty("oldBusinessId")]
        public string OldBusinessId { get; set; }

        [JsonProperty("newBusinessId")]
        public string NewBusinessId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class CompanySearchResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("resultsFrom")]
        public int ResultsFrom { get; set; }

        [JsonProperty("previousResultsUri")]
        public string PreviousResultsUri { get; set; }

        [JsonProperty("nextResultsUri")]
        public string NextResultsUri { get; set; }

        [JsonProperty("exceptionNoticeUri")]
        public string ExceptionNoticeUri { get; set; }

        [JsonProperty("results")]
        public CompanySearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CompanySearchResponseResultsTypeItem
    {
        [JsonProperty("businessId")]
        public string BusinessId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("companyForm")]
        public string CompanyForm { get; set; }

        [JsonProperty("detailsUri")]
        public string DetailsUri { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finnishbisip;

    public partial class WorkflowManagedActions
    {
        public FinnishbisipActions Finnishbisip(string connectionId) => new FinnishbisipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinnishbisipTriggers Finnishbisip(string connectionId) => new FinnishbisipTriggers(connectionId);
    }
}