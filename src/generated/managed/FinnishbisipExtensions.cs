//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finnishbisip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinnishbisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishbisip")]
        public IBodyWorkflowAction<CompanyByBISCodeResponse> CompanyByBISCode([WorkflowExpression] Func<string> businessId)
        {
            SourceExpression.Validate(businessId, nameof(businessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bis/v1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(businessId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CompanyByBISCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishbisip")]
        public IBodyWorkflowAction<CompanySearchResponse> CompanySearch([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> maxResults = null, [WorkflowExpression] Func<bool> totalResults = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            SourceExpression.Validate(totalResults, nameof(totalResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bis/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["maxResults"] = Convert.ToString(10);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                callPayload.Queries["totalResults"] = Convert.ToString(true);
                if (totalResults != null)
                    callPayload.Queries["totalResults"] = SourceExpressionConverter.ConvertO(totalResults);
                return callPayload;
            }

            return new ApiConnectionAction<CompanySearchResponse>(BuildSourceInput);
        }
    }

    public class FinnishbisipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompanyByBISCodeResponse
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
        public CompanyByBISCodeResponseResultsTypeItem[] Results { get; set; }
    }

    public class CompanyByBISCodeResponseResultsTypeItem
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
        public CompanyByBISCodeResponseResultsTypeItemLiquidationsTypeItem[] Liquidations { get; set; }

        [JsonProperty("names")]
        public CompanyByBISCodeResponseResultsTypeItemNamesTypeItem[] Names { get; set; }

        [JsonProperty("auxiliaryNames")]
        public CompanyByBISCodeResponseResultsTypeItemAuxiliaryNamesTypeItem[] AuxiliaryNames { get; set; }

        [JsonProperty("addresses")]
        public CompanyByBISCodeResponseResultsTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("companyForms")]
        public CompanyByBISCodeResponseResultsTypeItemCompanyFormsTypeItem[] CompanyForms { get; set; }

        [JsonProperty("businessLines")]
        public CompanyByBISCodeResponseResultsTypeItemBusinessLinesTypeItem[] BusinessLines { get; set; }

        [JsonProperty("languages")]
        public CompanyByBISCodeResponseResultsTypeItemLanguagesTypeItem[] Languages { get; set; }

        [JsonProperty("registedOffices")]
        public CompanyByBISCodeResponseResultsTypeItemRegistedOfficesTypeItem[] RegistedOffices { get; set; }

        [JsonProperty("contactDetails")]
        public CompanyByBISCodeResponseResultsTypeItemContactDetailsTypeItem[] ContactDetails { get; set; }

        [JsonProperty("registeredEntries")]
        public CompanyByBISCodeResponseResultsTypeItemRegisteredEntriesTypeItem[] RegisteredEntries { get; set; }

        [JsonProperty("businessIdChanges")]
        public CompanyByBISCodeResponseResultsTypeItemBusinessIdChangesTypeItem[] BusinessIdChanges { get; set; }
    }

    public class CompanyByBISCodeResponseResultsTypeItemLiquidationsTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemNamesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemAuxiliaryNamesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemAddressesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemCompanyFormsTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemBusinessLinesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemLanguagesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemRegistedOfficesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemContactDetailsTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemRegisteredEntriesTypeItem
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

    public class CompanyByBISCodeResponseResultsTypeItemBusinessIdChangesTypeItem
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