//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hithorizons
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HithorizonsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyGet))]
        public IBodyWorkflowAction<CompanyDetailResultApiResponse> CompanyGet([WorkflowExpression] Func<string> hitHorizonsId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyDetailResultApiResponse> __BuildCompanyGet(WorkflowExpression<string> hitHorizonsId)
        {
            WorkflowExpression.Validate(hitHorizonsId, nameof(hitHorizonsId), required: true);
            return new DeferredBodyAction<CompanyDetailResultApiResponse>(() =>
            {
                var apiCallPath = "/Company/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["HitHorizonsId"] = ExpressionConverter.Convert(hitHorizonsId);
                return new ApiConnectionAction<CompanyDetailResultApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        [WorkflowExpressionFactory(nameof(__BuildCompanySearch))]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearch([WorkflowExpression] Func<string> dUNSNumber = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<string> nationalId = null, [WorkflowExpression] Func<string> addressUnstructured = null, [WorkflowExpression] Func<string> addressStreet = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> stateProvince = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<bool> showBranches = null, [WorkflowExpression] Func<string> companyTypes = null, [WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> __BuildCompanySearch(WorkflowExpression<string> dUNSNumber = null, WorkflowExpression<string> companyName = null, WorkflowExpression<string> nationalId = null, WorkflowExpression<string> addressUnstructured = null, WorkflowExpression<string> addressStreet = null, WorkflowExpression<string> city = null, WorkflowExpression<string> stateProvince = null, WorkflowExpression<string> country = null, WorkflowExpression<bool> showBranches = null, WorkflowExpression<string> companyTypes = null, WorkflowExpression<int> maxResults = null)
        {
            WorkflowExpression.Validate(dUNSNumber, nameof(dUNSNumber), required: false);
            WorkflowExpression.Validate(companyName, nameof(companyName), required: false);
            WorkflowExpression.Validate(nationalId, nameof(nationalId), required: false);
            WorkflowExpression.Validate(addressUnstructured, nameof(addressUnstructured), required: false);
            WorkflowExpression.Validate(addressStreet, nameof(addressStreet), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(stateProvince, nameof(stateProvince), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(showBranches, nameof(showBranches), required: false);
            WorkflowExpression.Validate(companyTypes, nameof(companyTypes), required: false);
            WorkflowExpression.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<CompanySearchResponseApiResponse>(() =>
            {
                var apiCallPath = "/Company/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dUNSNumber != null)
                    callPayload.Queries["DUNSNumber"] = ExpressionConverter.Convert(dUNSNumber);
                if (companyName != null)
                    callPayload.Queries["CompanyName"] = ExpressionConverter.Convert(companyName);
                if (nationalId != null)
                    callPayload.Queries["NationalId"] = ExpressionConverter.Convert(nationalId);
                if (addressUnstructured != null)
                    callPayload.Queries["AddressUnstructured"] = ExpressionConverter.Convert(addressUnstructured);
                if (addressStreet != null)
                    callPayload.Queries["AddressStreet"] = ExpressionConverter.Convert(addressStreet);
                if (city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(city);
                if (stateProvince != null)
                    callPayload.Queries["StateProvince"] = ExpressionConverter.Convert(stateProvince);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (showBranches != null)
                    callPayload.Queries["ShowBranches"] = ExpressionConverter.Convert(showBranches);
                if (companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = ExpressionConverter.Convert(companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<CompanySearchResponseApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        [WorkflowExpressionFactory(nameof(__BuildCompanySearchUnstructured))]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearchUnstructured([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<bool> showBranches = null, [WorkflowExpression] Func<string> companyTypes = null, [WorkflowExpression] Func<int> maxResults = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> __BuildCompanySearchUnstructured(WorkflowExpression<string> ids = null, WorkflowExpression<string> name = null, WorkflowExpression<string> address = null, WorkflowExpression<bool> showBranches = null, WorkflowExpression<string> companyTypes = null, WorkflowExpression<int> maxResults = null)
        {
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(address, nameof(address), required: false);
            WorkflowExpression.Validate(showBranches, nameof(showBranches), required: false);
            WorkflowExpression.Validate(companyTypes, nameof(companyTypes), required: false);
            WorkflowExpression.Validate(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<CompanySearchResponseApiResponse>(() =>
            {
                var apiCallPath = "/Company/SearchUnstructured";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["Ids"] = ExpressionConverter.Convert(ids);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (address != null)
                    callPayload.Queries["Address"] = ExpressionConverter.Convert(address);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (showBranches != null)
                    callPayload.Queries["ShowBranches"] = ExpressionConverter.Convert(showBranches);
                if (companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = ExpressionConverter.Convert(companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(maxResults);
                return new ApiConnectionAction<CompanySearchResponseApiResponse>(callPayload);
            });
        }
    }

    public class HithorizonsTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompanyDetailResultApiResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public CompanyDetailResult Result { get; set; }
    }

    public class CompanyDetailResult
    {
        public string HitHorizonsId { get; set; }
        public string DUNSNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanySecondaryName { get; set; }
        public string AddressStreetLine1 { get; set; }
        public string AddressStreetLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string NationalId { get; set; }
        public string NationalIdType { get; set; }
        public string SICText { get; set; }
        public string SICCode { get; set; }
        public string Industry { get; set; }
        public string LocalActivityCode { get; set; }
        public string LocalActivityCodeType { get; set; }
        public int EstablishmentOfOwnership { get; set; }
        public double SalesLocal { get; set; }
        public string LocalCurrency { get; set; }
        public string SalesAccuracyIndicator { get; set; }
        public double SalesUSD { get; set; }
        public double SalesEUR { get; set; }
        public JToken HitHorizonsSalesAnalysis { get; set; }
        public int EmployeesNumber { get; set; }
        public string EmployeesNumberAccuracyIndicator { get; set; }
        public int EmployeesNumberTotal { get; set; }
        public string EmployeesNumberTotalAccuracyIndicator { get; set; }
        public JToken HitHorizonsEmployeesAnalysis { get; set; }
        public int CompanyType { get; set; }
        public int LocationType { get; set; }
        public string HitHorizonsCompanyProfileURL { get; set; }
    }

    public class CompanySearchResponseApiResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public CompanySearchResponse Result { get; set; }
    }

    public class CompanySearchResponse
    {
        public CompanySearchResult[] Results { get; set; }
        public int ResultsCount { get; set; }
        public int TotalCount { get; set; }
    }

    public class CompanySearchResult
    {
        public string HitHorizonsId { get; set; }
        public string DUNSNumber { get; set; }
        public string CompanyName { get; set; }
        public string CompanySecondaryName { get; set; }
        public string AddressStreetLine1 { get; set; }
        public string AddressStreetLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }
        public string NationalId { get; set; }
        public string Industry { get; set; }
        public int EstablishmentOfOwnership { get; set; }
        public double SalesEUR { get; set; }
        public int EmployeesNumber { get; set; }
        public string CompanyProfileURL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hithorizons;

    public partial class WorkflowManagedActions
    {
        public HithorizonsActions Hithorizons(string connectionId) => new HithorizonsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HithorizonsTriggers Hithorizons(string connectionId) => new HithorizonsTriggers(connectionId);
    }
}