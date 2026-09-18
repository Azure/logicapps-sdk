//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hithorizons
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HithorizonsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanyDetailResultApiResponse> CompanyGet([WorkflowExpression] Func<string> hitHorizonsId)
        {
            SourceExpression.Validate(hitHorizonsId, nameof(hitHorizonsId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Company/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["HitHorizonsId"] = SourceExpressionConverter.ConvertO(hitHorizonsId);
                return callPayload;
            }

            return new ApiConnectionAction<CompanyDetailResultApiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearch([WorkflowExpression] Func<string> dUNSNumber = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<string> nationalId = null, [WorkflowExpression] Func<string> addressUnstructured = null, [WorkflowExpression] Func<string> addressStreet = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> stateProvince = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<bool> showBranches = null, [WorkflowExpression] Func<string> companyTypes = null, [WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(dUNSNumber, nameof(dUNSNumber), required: false);
            SourceExpression.Validate(companyName, nameof(companyName), required: false);
            SourceExpression.Validate(nationalId, nameof(nationalId), required: false);
            SourceExpression.Validate(addressUnstructured, nameof(addressUnstructured), required: false);
            SourceExpression.Validate(addressStreet, nameof(addressStreet), required: false);
            SourceExpression.Validate(city, nameof(city), required: false);
            SourceExpression.Validate(stateProvince, nameof(stateProvince), required: false);
            SourceExpression.Validate(country, nameof(country), required: false);
            SourceExpression.Validate(showBranches, nameof(showBranches), required: false);
            SourceExpression.Validate(companyTypes, nameof(companyTypes), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Company/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dUNSNumber != null)
                    callPayload.Queries["DUNSNumber"] = SourceExpressionConverter.ConvertO(dUNSNumber);
                if (companyName != null)
                    callPayload.Queries["CompanyName"] = SourceExpressionConverter.ConvertO(companyName);
                if (nationalId != null)
                    callPayload.Queries["NationalId"] = SourceExpressionConverter.ConvertO(nationalId);
                if (addressUnstructured != null)
                    callPayload.Queries["AddressUnstructured"] = SourceExpressionConverter.ConvertO(addressUnstructured);
                if (addressStreet != null)
                    callPayload.Queries["AddressStreet"] = SourceExpressionConverter.ConvertO(addressStreet);
                if (city != null)
                    callPayload.Queries["City"] = SourceExpressionConverter.ConvertO(city);
                if (stateProvince != null)
                    callPayload.Queries["StateProvince"] = SourceExpressionConverter.ConvertO(stateProvince);
                if (country != null)
                    callPayload.Queries["Country"] = SourceExpressionConverter.ConvertO(country);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (showBranches != null)
                    callPayload.Queries["ShowBranches"] = SourceExpressionConverter.ConvertO(showBranches);
                if (companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = SourceExpressionConverter.ConvertO(companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<CompanySearchResponseApiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hithorizons")]
        public IBodyWorkflowAction<CompanySearchResponseApiResponse> CompanySearchUnstructured([WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<bool> showBranches = null, [WorkflowExpression] Func<string> companyTypes = null, [WorkflowExpression] Func<int> maxResults = null)
        {
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(showBranches, nameof(showBranches), required: false);
            SourceExpression.Validate(companyTypes, nameof(companyTypes), required: false);
            SourceExpression.Validate(maxResults, nameof(maxResults), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Company/SearchUnstructured";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ids != null)
                    callPayload.Queries["Ids"] = SourceExpressionConverter.ConvertO(ids);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (address != null)
                    callPayload.Queries["Address"] = SourceExpressionConverter.ConvertO(address);
                callPayload.Queries["ShowBranches"] = Convert.ToString(false);
                if (showBranches != null)
                    callPayload.Queries["ShowBranches"] = SourceExpressionConverter.ConvertO(showBranches);
                if (companyTypes != null)
                    callPayload.Queries["CompanyTypes"] = SourceExpressionConverter.ConvertO(companyTypes);
                callPayload.Queries["MaxResults"] = Convert.ToString(20);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<CompanySearchResponseApiResponse>(BuildSourceInput);
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