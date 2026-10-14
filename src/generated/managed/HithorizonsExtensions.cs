//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hithorizons
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HithorizonsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanyDetailResultApiResponse> CompanyGet(Expression<Func<string>> hitHorizonsId)
        {
            var __workflow_hitHorizonsId = hitHorizonsId == null ? null : WorkflowExpression.Compile(hitHorizonsId);
            WorkflowExpression.Validate(__workflow_hitHorizonsId, nameof(hitHorizonsId), required: true);
            return new DeferredBodyAction<CompanyDetailResultApiResponse>(() =>
            {
                var apiCallPath = "/Company/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["HitHorizonsId"] = ExpressionConverter.Convert(__workflow_hitHorizonsId);
                return new ApiConnectionAction<CompanyDetailResultApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearch(Expression<Func<string>> dUNSNumber = null, Expression<Func<string>> companyName = null, Expression<Func<string>> nationalId = null, Expression<Func<string>> addressUnstructured = null, Expression<Func<string>> addressStreet = null, Expression<Func<string>> city = null, Expression<Func<string>> stateProvince = null, Expression<Func<string>> country = null, Expression<Func<bool>> showBranches = null, Expression<Func<string>> companyTypes = null, Expression<Func<int>> maxResults = null)
        {
            var __workflow_dUNSNumber = dUNSNumber == null ? null : WorkflowExpression.Compile(dUNSNumber);
            WorkflowExpression.Validate(__workflow_dUNSNumber, nameof(dUNSNumber), required: false);
            var __workflow_companyName = companyName == null ? null : WorkflowExpression.Compile(companyName);
            WorkflowExpression.Validate(__workflow_companyName, nameof(companyName), required: false);
            var __workflow_nationalId = nationalId == null ? null : WorkflowExpression.Compile(nationalId);
            WorkflowExpression.Validate(__workflow_nationalId, nameof(nationalId), required: false);
            var __workflow_addressUnstructured = addressUnstructured == null ? null : WorkflowExpression.Compile(addressUnstructured);
            WorkflowExpression.Validate(__workflow_addressUnstructured, nameof(addressUnstructured), required: false);
            var __workflow_addressStreet = addressStreet == null ? null : WorkflowExpression.Compile(addressStreet);
            WorkflowExpression.Validate(__workflow_addressStreet, nameof(addressStreet), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_stateProvince = stateProvince == null ? null : WorkflowExpression.Compile(stateProvince);
            WorkflowExpression.Validate(__workflow_stateProvince, nameof(stateProvince), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_showBranches = showBranches == null ? null : WorkflowExpression.Compile(showBranches);
            WorkflowExpression.Validate(__workflow_showBranches, nameof(showBranches), required: false);
            var __workflow_companyTypes = companyTypes == null ? null : WorkflowExpression.Compile(companyTypes);
            WorkflowExpression.Validate(__workflow_companyTypes, nameof(companyTypes), required: false);
            var __workflow_maxResults = maxResults == null ? null : WorkflowExpression.Compile(maxResults);
            WorkflowExpression.Validate(__workflow_maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<CompanySearchResponseApiResponse>(() =>
            {
                var apiCallPath = "/Company/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dUNSNumber != null)
                    callPayload.Queries["DUNSNumber"] = ExpressionConverter.Convert(__workflow_dUNSNumber);
                if (__workflow_companyName != null)
                    callPayload.Queries["CompanyName"] = ExpressionConverter.Convert(__workflow_companyName);
                if (__workflow_nationalId != null)
                    callPayload.Queries["NationalId"] = ExpressionConverter.Convert(__workflow_nationalId);
                if (__workflow_addressUnstructured != null)
                    callPayload.Queries["AddressUnstructured"] = ExpressionConverter.Convert(__workflow_addressUnstructured);
                if (__workflow_addressStreet != null)
                    callPayload.Queries["AddressStreet"] = ExpressionConverter.Convert(__workflow_addressStreet);
                if (__workflow_city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_stateProvince != null)
                    callPayload.Queries["StateProvince"] = ExpressionConverter.Convert(__workflow_stateProvince);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (__workflow_showBranches != null)
                    callPayload.Queries["ShowBranches"] = ExpressionConverter.Convert(__workflow_showBranches);
                if (__workflow_companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = ExpressionConverter.Convert(__workflow_companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<CompanySearchResponseApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearchUnstructured(Expression<Func<string>> ids = null, Expression<Func<string>> name = null, Expression<Func<string>> address = null, Expression<Func<bool>> showBranches = null, Expression<Func<string>> companyTypes = null, Expression<Func<int>> maxResults = null)
        {
            var __workflow_ids = ids == null ? null : WorkflowExpression.Compile(ids);
            WorkflowExpression.Validate(__workflow_ids, nameof(ids), required: false);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_showBranches = showBranches == null ? null : WorkflowExpression.Compile(showBranches);
            WorkflowExpression.Validate(__workflow_showBranches, nameof(showBranches), required: false);
            var __workflow_companyTypes = companyTypes == null ? null : WorkflowExpression.Compile(companyTypes);
            WorkflowExpression.Validate(__workflow_companyTypes, nameof(companyTypes), required: false);
            var __workflow_maxResults = maxResults == null ? null : WorkflowExpression.Compile(maxResults);
            WorkflowExpression.Validate(__workflow_maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<CompanySearchResponseApiResponse>(() =>
            {
                var apiCallPath = "/Company/SearchUnstructured";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["Ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_address != null)
                    callPayload.Queries["Address"] = ExpressionConverter.Convert(__workflow_address);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (__workflow_showBranches != null)
                    callPayload.Queries["ShowBranches"] = ExpressionConverter.Convert(__workflow_showBranches);
                if (__workflow_companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = ExpressionConverter.Convert(__workflow_companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (__workflow_maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
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
