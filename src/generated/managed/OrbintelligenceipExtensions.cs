//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orbintelligenceip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrbintelligenceipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbintelligenceip")]
        public IBodyWorkflowAction<MatchResponse> Match([WorkflowExpression] Func<string> apiKey = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> website = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> ein = null, [WorkflowExpression] Func<string> npi = null, [WorkflowExpression] Func<string> lei = null, [WorkflowExpression] Func<string> requestId = null, [WorkflowExpression] Func<string> orbNum = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/3/match/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiKey != null)
                    callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (address1 != null)
                    callPayload.Queries["address1"] = SourceExpressionConverter.ConvertO(address1);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (website != null)
                    callPayload.Queries["website"] = SourceExpressionConverter.ConvertO(website);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (ein != null)
                    callPayload.Queries["ein"] = SourceExpressionConverter.ConvertO(ein);
                if (npi != null)
                    callPayload.Queries["npi"] = SourceExpressionConverter.ConvertO(npi);
                if (lei != null)
                    callPayload.Queries["lei"] = SourceExpressionConverter.ConvertO(lei);
                if (requestId != null)
                    callPayload.Queries["request_id"] = SourceExpressionConverter.ConvertO(requestId);
                if (orbNum != null)
                    callPayload.Queries["orb_num"] = SourceExpressionConverter.ConvertO(orbNum);
                return callPayload;
            }

            return new ApiConnectionAction<MatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbintelligenceip")]
        public IBodyWorkflowAction<FetchResponse> Fetch([WorkflowExpression] Func<string> orbNum, [WorkflowExpression] Func<string> apiKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/3/fetch/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orbNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiKey != null)
                    callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                return callPayload;
            }

            return new ApiConnectionAction<FetchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbintelligenceip")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> apiKey = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<entityTypeInput> entityType = null, [WorkflowExpression] Func<string> parentOrbNum = null, [WorkflowExpression] Func<int> ultimateParentOrbNum = null, [WorkflowExpression] Func<string> industry = null, [WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<employeesInputItem[]> employees = null, [WorkflowExpression] Func<revenueInputItem[]> revenue = null, [WorkflowExpression] Func<string> techs = null, [WorkflowExpression] Func<string> techCategories = null, [WorkflowExpression] Func<string> naicsCodes = null, [WorkflowExpression] Func<string> sicCodes = null, [WorkflowExpression] Func<string> rankings = null, [WorkflowExpression] Func<string> importanceScore = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> cusip = null, [WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<string> exchange = null, [WorkflowExpression] Func<bool> showFullProfile = null, [WorkflowExpression] Func<string> include = null, [WorkflowExpression] Func<int> orbNum = null, [WorkflowExpression] Func<string[]> categories = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/3/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiKey != null)
                    callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (entityType != null)
                    callPayload.Queries["entity_type"] = SourceExpressionConverter.Convert(entityType);
                if (parentOrbNum != null)
                    callPayload.Queries["parent_orb_num"] = SourceExpressionConverter.ConvertO(parentOrbNum);
                if (ultimateParentOrbNum != null)
                    callPayload.Queries["ultimate_parent_orb_num"] = SourceExpressionConverter.ConvertO(ultimateParentOrbNum);
                if (industry != null)
                    callPayload.Queries["industry"] = SourceExpressionConverter.ConvertO(industry);
                if (address1 != null)
                    callPayload.Queries["address1"] = SourceExpressionConverter.ConvertO(address1);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (employees != null)
                    callPayload.Queries["employees"] = SourceExpressionConverter.ConvertO(employees);
                if (revenue != null)
                    callPayload.Queries["revenue"] = SourceExpressionConverter.ConvertO(revenue);
                if (techs != null)
                    callPayload.Queries["techs"] = SourceExpressionConverter.ConvertO(techs);
                if (techCategories != null)
                    callPayload.Queries["tech_categories"] = SourceExpressionConverter.ConvertO(techCategories);
                if (naicsCodes != null)
                    callPayload.Queries["naics_codes"] = SourceExpressionConverter.ConvertO(naicsCodes);
                if (sicCodes != null)
                    callPayload.Queries["sic_codes"] = SourceExpressionConverter.ConvertO(sicCodes);
                if (rankings != null)
                    callPayload.Queries["rankings"] = SourceExpressionConverter.ConvertO(rankings);
                if (importanceScore != null)
                    callPayload.Queries["importance_score"] = SourceExpressionConverter.ConvertO(importanceScore);
                if (cik != null)
                    callPayload.Queries["cik"] = SourceExpressionConverter.ConvertO(cik);
                if (cusip != null)
                    callPayload.Queries["cusip"] = SourceExpressionConverter.ConvertO(cusip);
                if (ticker != null)
                    callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (exchange != null)
                    callPayload.Queries["exchange"] = SourceExpressionConverter.ConvertO(exchange);
                if (showFullProfile != null)
                    callPayload.Queries["show_full_profile"] = SourceExpressionConverter.ConvertO(showFullProfile);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                if (orbNum != null)
                    callPayload.Queries["orb_num"] = SourceExpressionConverter.ConvertO(orbNum);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbintelligenceip")]
        public IBodyWorkflowAction<LookAlikeResponse> LookAlike([WorkflowExpression] Func<int> orbNum, [WorkflowExpression] Func<string> apiKey = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> industry = null, [WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<employeesInputItem[]> employees = null, [WorkflowExpression] Func<revenueInputItem[]> revenue = null, [WorkflowExpression] Func<string> techs = null, [WorkflowExpression] Func<string> techCategories = null, [WorkflowExpression] Func<string> naicsCodes = null, [WorkflowExpression] Func<string> sicCodes = null, [WorkflowExpression] Func<string> rankings = null, [WorkflowExpression] Func<string> cik = null, [WorkflowExpression] Func<string> cusip = null, [WorkflowExpression] Func<string> ticker = null, [WorkflowExpression] Func<string> exchange = null, [WorkflowExpression] Func<bool> showFullProfile = null, [WorkflowExpression] Func<string> include = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/3/lookalike/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiKey != null)
                    callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (industry != null)
                    callPayload.Queries["industry"] = SourceExpressionConverter.ConvertO(industry);
                if (address1 != null)
                    callPayload.Queries["address1"] = SourceExpressionConverter.ConvertO(address1);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (zip != null)
                    callPayload.Queries["zip"] = SourceExpressionConverter.ConvertO(zip);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (employees != null)
                    callPayload.Queries["employees"] = SourceExpressionConverter.ConvertO(employees);
                if (revenue != null)
                    callPayload.Queries["revenue"] = SourceExpressionConverter.ConvertO(revenue);
                if (techs != null)
                    callPayload.Queries["techs"] = SourceExpressionConverter.ConvertO(techs);
                if (techCategories != null)
                    callPayload.Queries["tech_categories"] = SourceExpressionConverter.ConvertO(techCategories);
                if (naicsCodes != null)
                    callPayload.Queries["naics_codes"] = SourceExpressionConverter.ConvertO(naicsCodes);
                if (sicCodes != null)
                    callPayload.Queries["sic_codes"] = SourceExpressionConverter.ConvertO(sicCodes);
                if (rankings != null)
                    callPayload.Queries["rankings"] = SourceExpressionConverter.ConvertO(rankings);
                if (cik != null)
                    callPayload.Queries["cik"] = SourceExpressionConverter.ConvertO(cik);
                if (cusip != null)
                    callPayload.Queries["cusip"] = SourceExpressionConverter.ConvertO(cusip);
                if (ticker != null)
                    callPayload.Queries["ticker"] = SourceExpressionConverter.ConvertO(ticker);
                if (exchange != null)
                    callPayload.Queries["exchange"] = SourceExpressionConverter.ConvertO(exchange);
                if (showFullProfile != null)
                    callPayload.Queries["show_full_profile"] = SourceExpressionConverter.ConvertO(showFullProfile);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                callPayload.Queries["orb_num"] = SourceExpressionConverter.ConvertO(orbNum);
                return callPayload;
            }

            return new ApiConnectionAction<LookAlikeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbintelligenceip")]
        public IBodyWorkflowAction<CorporateTreeResponse> CorporateTree([WorkflowExpression] Func<string> orbNum, [WorkflowExpression] Func<string> apiKey = null, [WorkflowExpression] Func<bool> showFullProfile = null, [WorkflowExpression] Func<string> include = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/3/corporate_tree/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orbNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (apiKey != null)
                    callPayload.Queries["api_key"] = SourceExpressionConverter.ConvertO(apiKey);
                if (showFullProfile != null)
                    callPayload.Queries["show_full_profile"] = SourceExpressionConverter.ConvertO(showFullProfile);
                if (include != null)
                    callPayload.Queries["include"] = SourceExpressionConverter.ConvertO(include);
                return callPayload;
            }

            return new ApiConnectionAction<CorporateTreeResponse>(BuildSourceInput);
        }
    }

    public class OrbintelligenceipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MatchResponse
    {
        [JsonProperty("request_fields")]
        public JToken InputDataToMatch { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("results")]
        public MatchResponseResultsTypeItem[] Results { get; set; }
    }

    public class MatchResponseResultsTypeItem
    {
        [JsonProperty("result_number")]
        public int ResultNumber { get; set; }

        [JsonProperty("orb_num")]
        public int OrbNumberOfTheCandidateProfile { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity_type")]
        public MatchResponseResultsTypeItemEntityTypeType EntityType { get; set; }

        [JsonProperty("company_status")]
        public MatchResponseResultsTypeItemCompanyStatusType CompanyStatus { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("is_standalone_company")]
        public bool IsStandaloneCompany { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso_country_code")]
        public string IsoCountryCode { get; set; }

        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        [JsonProperty("full_profile")]
        public MatchResponseResultsTypeItemFullProfileType FullProfile { get; set; }

        [JsonProperty("confidence_score")]
        public double ConfidenceScore { get; set; }

        [JsonProperty("match_mask")]
        public MatchResponseResultsTypeItemMatchMaskType MatchMask { get; set; }

        [JsonProperty("matched_fields")]
        public JToken MatchedFields { get; set; }
    }

    public enum MatchResponseResultsTypeItemEntityTypeType
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "branch")]
        Branch
    }

    public enum MatchResponseResultsTypeItemCompanyStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class MatchResponseResultsTypeItemFullProfileType
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("webdomains")]
        public string[] Webdomains { get; set; }

        [JsonProperty("webdomains_info")]
        public MatchResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem[] WebdomainsInfo { get; set; }

        [JsonProperty("address")]
        public MatchResponseResultsTypeItemFullProfileTypeAddressType Address { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("naics_code")]
        public string NaicsCode { get; set; }

        [JsonProperty("naics_description")]
        public string NaicsDescription { get; set; }

        [JsonProperty("naics_codes")]
        public MatchResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem[] NaicsCodes { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("sic_codes")]
        public MatchResponseResultsTypeItemFullProfileTypeSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("categories")]
        public MatchResponseResultsTypeItemFullProfileTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("employees_range")]
        public string EmployeesRange { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("revenue_range")]
        public string RevenueRange { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedin_account")]
        public MatchResponseResultsTypeItemFullProfileTypeLinkedinAccountType LinkedinAccount { get; set; }

        [JsonProperty("facebook_account")]
        public MatchResponseResultsTypeItemFullProfileTypeFacebookAccountType FacebookAccount { get; set; }

        [JsonProperty("twitter_account")]
        public MatchResponseResultsTypeItemFullProfileTypeTwitterAccountType TwitterAccount { get; set; }

        [JsonProperty("googleplus_account")]
        public MatchResponseResultsTypeItemFullProfileTypeGoogleplusAccountType GoogleplusAccount { get; set; }

        [JsonProperty("youtube_account")]
        public MatchResponseResultsTypeItemFullProfileTypeYoutubeAccountType YoutubeAccount { get; set; }

        [JsonProperty("technologies")]
        public MatchResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem[] Technologies { get; set; }

        [JsonProperty("rankings")]
        public string[] Rankings { get; set; }

        [JsonProperty("ranking_positions")]
        public MatchResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem[] RankingPositions { get; set; }

        [JsonProperty("eins")]
        public string[] Eins { get; set; }

        [JsonProperty("npis")]
        public string[] Npis { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("total_funding")]
        public int TotalFunding { get; set; }

        [JsonProperty("last_funding_round_amount")]
        public int LastFundingRoundAmount { get; set; }

        [JsonProperty("last_funding_round_year")]
        public int LastFundingRoundYear { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("importance_score")]
        public string ImportanceScore { get; set; }

        [JsonProperty("tickers")]
        public MatchResponseResultsTypeItemFullProfileTypeTickersTypeItem[] Tickers { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("cidrs_count")]
        public int CidrsCount { get; set; }

        [JsonProperty("liveramp_idl_count")]
        public int LiverampIdlCount { get; set; }

        [JsonProperty("liveramp_device_count")]
        public int LiverampDeviceCount { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem
    {
        [JsonProperty("orb_web_rank")]
        public int OrbWebRank { get; set; }

        [JsonProperty("domain_has_website")]
        public int DomainHasWebsite { get; set; }

        [JsonProperty("domain_is_email_hosting")]
        public int DomainIsEmailHosting { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("domain_has_email")]
        public int DomainHasEmail { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeLinkedinAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeFacebookAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeTwitterAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeGoogleplusAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeYoutubeAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem
    {
        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class MatchResponseResultsTypeItemFullProfileTypeTickersTypeItem
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public class MatchResponseResultsTypeItemMatchMaskType
    {
        [JsonProperty("main_name")]
        public string MainName { get; set; }

        [JsonProperty("corp_elem")]
        public string CorpElem { get; set; }

        [JsonProperty("other_names")]
        public string OtherNames { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("npi")]
        public string Npi { get; set; }

        [JsonProperty("lei")]
        public string Lei { get; set; }
    }

    public class FetchResponse
    {
        [JsonProperty("orb_num")]
        public int OrbNumber { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("webdomains")]
        public string[] Webdomains { get; set; }

        [JsonProperty("webdomains_info")]
        public FetchResponseWebdomainsInfoTypeItem[] WebdomainsInfo { get; set; }

        [JsonProperty("address")]
        public FetchResponseAddressType Address { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("naics_code")]
        public string NaicsCode { get; set; }

        [JsonProperty("naics_description")]
        public string NaicsDescription { get; set; }

        [JsonProperty("naics_codes")]
        public FetchResponseNaicsCodesTypeItem[] NaicsCodes { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("sic_codes")]
        public FetchResponseSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("categories")]
        public FetchResponseCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("employees_range")]
        public string EmployeesRange { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("revenue_range")]
        public string RevenueRange { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedin_account")]
        public FetchResponseLinkedinAccountType LinkedinAccount { get; set; }

        [JsonProperty("facebook_account")]
        public FetchResponseFacebookAccountType FacebookAccount { get; set; }

        [JsonProperty("twitter_account")]
        public FetchResponseTwitterAccountType TwitterAccount { get; set; }

        [JsonProperty("googleplus_account")]
        public FetchResponseGoogleplusAccountType GoogleplusAccount { get; set; }

        [JsonProperty("youtube_account")]
        public FetchResponseYoutubeAccountType YoutubeAccount { get; set; }

        [JsonProperty("technologies")]
        public FetchResponseTechnologiesTypeItem[] Technologies { get; set; }

        [JsonProperty("rankings")]
        public string[] Rankings { get; set; }

        [JsonProperty("ranking_positions")]
        public FetchResponseRankingPositionsTypeItem[] RankingPositions { get; set; }

        [JsonProperty("eins")]
        public string[] Eins { get; set; }

        [JsonProperty("npis")]
        public string[] Npis { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("total_funding")]
        public int TotalFunding { get; set; }

        [JsonProperty("last_funding_round_amount")]
        public int LastFundingRoundAmount { get; set; }

        [JsonProperty("last_funding_round_year")]
        public int LastFundingRoundYear { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("importance_score")]
        public string ImportanceScore { get; set; }

        [JsonProperty("tickers")]
        public FetchResponseTickersTypeItem[] Tickers { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("cidrs_count")]
        public int CidrsCount { get; set; }

        [JsonProperty("liveramp_idl_count")]
        public int LiverampIdlCount { get; set; }

        [JsonProperty("liveramp_device_count")]
        public int LiverampDeviceCount { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class FetchResponseWebdomainsInfoTypeItem
    {
        [JsonProperty("orb_web_rank")]
        public int OrbWebRank { get; set; }

        [JsonProperty("domain_has_website")]
        public int DomainHasWebsite { get; set; }

        [JsonProperty("domain_is_email_hosting")]
        public int DomainIsEmailHosting { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("domain_has_email")]
        public int DomainHasEmail { get; set; }
    }

    public class FetchResponseAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class FetchResponseNaicsCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FetchResponseSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FetchResponseCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }

    public class FetchResponseLinkedinAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class FetchResponseFacebookAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class FetchResponseTwitterAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class FetchResponseGoogleplusAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class FetchResponseYoutubeAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class FetchResponseTechnologiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FetchResponseRankingPositionsTypeItem
    {
        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class FetchResponseTickersTypeItem
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public class SearchResponse
    {
        [JsonProperty("request_fields")]
        public JToken RequestFields { get; set; }

        [JsonProperty("facets")]
        public JToken Facets { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("results")]
        public SearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class SearchResponseResultsTypeItem
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity_type")]
        public SearchResponseResultsTypeItemEntityTypeType EntityType { get; set; }

        [JsonProperty("company_status")]
        public SearchResponseResultsTypeItemCompanyStatusType CompanyStatus { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("is_standalone_company")]
        public bool IsStandaloneCompany { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso_country_code")]
        public string IsoCountryCode { get; set; }

        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        [JsonProperty("full_profile")]
        public SearchResponseResultsTypeItemFullProfileType FullProfile { get; set; }
    }

    public enum SearchResponseResultsTypeItemEntityTypeType
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "branch")]
        Branch
    }

    public enum SearchResponseResultsTypeItemCompanyStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class SearchResponseResultsTypeItemFullProfileType
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("webdomains")]
        public string[] Webdomains { get; set; }

        [JsonProperty("webdomains_info")]
        public SearchResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem[] WebdomainsInfo { get; set; }

        [JsonProperty("address")]
        public SearchResponseResultsTypeItemFullProfileTypeAddressType Address { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("naics_code")]
        public string NaicsCode { get; set; }

        [JsonProperty("naics_description")]
        public string NaicsDescription { get; set; }

        [JsonProperty("naics_codes")]
        public SearchResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem[] NaicsCodes { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("sic_codes")]
        public SearchResponseResultsTypeItemFullProfileTypeSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("categories")]
        public SearchResponseResultsTypeItemFullProfileTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("employees_range")]
        public string EmployeesRange { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("revenue_range")]
        public string RevenueRange { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedin_account")]
        public SearchResponseResultsTypeItemFullProfileTypeLinkedinAccountType LinkedinAccount { get; set; }

        [JsonProperty("facebook_account")]
        public SearchResponseResultsTypeItemFullProfileTypeFacebookAccountType FacebookAccount { get; set; }

        [JsonProperty("twitter_account")]
        public SearchResponseResultsTypeItemFullProfileTypeTwitterAccountType TwitterAccount { get; set; }

        [JsonProperty("googleplus_account")]
        public SearchResponseResultsTypeItemFullProfileTypeGoogleplusAccountType GoogleplusAccount { get; set; }

        [JsonProperty("youtube_account")]
        public SearchResponseResultsTypeItemFullProfileTypeYoutubeAccountType YoutubeAccount { get; set; }

        [JsonProperty("technologies")]
        public SearchResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem[] Technologies { get; set; }

        [JsonProperty("rankings")]
        public string[] Rankings { get; set; }

        [JsonProperty("ranking_positions")]
        public SearchResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem[] RankingPositions { get; set; }

        [JsonProperty("eins")]
        public string[] Eins { get; set; }

        [JsonProperty("npis")]
        public string[] Npis { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("total_funding")]
        public int TotalFunding { get; set; }

        [JsonProperty("last_funding_round_amount")]
        public int LastFundingRoundAmount { get; set; }

        [JsonProperty("last_funding_round_year")]
        public int LastFundingRoundYear { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("importance_score")]
        public string ImportanceScore { get; set; }

        [JsonProperty("tickers")]
        public SearchResponseResultsTypeItemFullProfileTypeTickersTypeItem[] Tickers { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("cidrs_count")]
        public int CidrsCount { get; set; }

        [JsonProperty("liveramp_idl_count")]
        public int LiverampIdlCount { get; set; }

        [JsonProperty("liveramp_device_count")]
        public int LiverampDeviceCount { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem
    {
        [JsonProperty("orb_web_rank")]
        public int OrbWebRank { get; set; }

        [JsonProperty("domain_has_website")]
        public int DomainHasWebsite { get; set; }

        [JsonProperty("domain_is_email_hosting")]
        public int DomainIsEmailHosting { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("domain_has_email")]
        public int DomainHasEmail { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeLinkedinAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeFacebookAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeTwitterAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeGoogleplusAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeYoutubeAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem
    {
        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class SearchResponseResultsTypeItemFullProfileTypeTickersTypeItem
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public enum entityTypeInput
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "branch")]
        Branch
    }

    public enum employeesInputItem
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "1-10")]
        _110,
        [EnumMember(Value = "10-50")]
        _1050,
        [EnumMember(Value = "50-200")]
        _50200,
        [EnumMember(Value = "200-500")]
        _200500,
        [EnumMember(Value = "500-1k")]
        _5001k,
        [EnumMember(Value = "1k-5k")]
        _1k5k,
        [EnumMember(Value = "5k-10k")]
        _5k10k,
        [EnumMember(Value = "10k")]
        _10k
    }

    public enum revenueInputItem
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "0-1m")]
        _01m,
        [EnumMember(Value = "1m-10m")]
        _1m10m,
        [EnumMember(Value = "10m-50m")]
        _10m50m,
        [EnumMember(Value = "50m-100m")]
        _50m100m,
        [EnumMember(Value = "100m-200m")]
        _100m200m,
        [EnumMember(Value = "200m-1b")]
        _200m1b,
        [EnumMember(Value = "1b")]
        _1b
    }

    public class LookAlikeResponse
    {
        [JsonProperty("request_fields")]
        public JToken RequestFields { get; set; }

        [JsonProperty("facets")]
        public JToken Facets { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("results")]
        public LookAlikeResponseResultsTypeItem[] Results { get; set; }
    }

    public class LookAlikeResponseResultsTypeItem
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity_type")]
        public LookAlikeResponseResultsTypeItemEntityTypeType EntityType { get; set; }

        [JsonProperty("company_status")]
        public LookAlikeResponseResultsTypeItemCompanyStatusType CompanyStatus { get; set; }

        [JsonProperty("parent_orb_num")]
        public string ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public string UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("is_standalone_company")]
        public bool IsStandaloneCompany { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso_country_code")]
        public string IsoCountryCode { get; set; }

        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        [JsonProperty("full_profile")]
        public LookAlikeResponseResultsTypeItemFullProfileType FullProfile { get; set; }
    }

    public enum LookAlikeResponseResultsTypeItemEntityTypeType
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "branch")]
        Branch
    }

    public enum LookAlikeResponseResultsTypeItemCompanyStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class LookAlikeResponseResultsTypeItemFullProfileType
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_orb_num")]
        public string ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public string UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("webdomains")]
        public string[] Webdomains { get; set; }

        [JsonProperty("webdomains_info")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem[] WebdomainsInfo { get; set; }

        [JsonProperty("address")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeAddressType Address { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("naics_code")]
        public string NaicsCode { get; set; }

        [JsonProperty("naics_description")]
        public string NaicsDescription { get; set; }

        [JsonProperty("naics_codes")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem[] NaicsCodes { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("sic_codes")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("categories")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("employees_range")]
        public string EmployeesRange { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("revenue_range")]
        public string RevenueRange { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedin_account")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeLinkedinAccountType LinkedinAccount { get; set; }

        [JsonProperty("facebook_account")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeFacebookAccountType FacebookAccount { get; set; }

        [JsonProperty("twitter_account")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeTwitterAccountType TwitterAccount { get; set; }

        [JsonProperty("googleplus_account")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeGoogleplusAccountType GoogleplusAccount { get; set; }

        [JsonProperty("youtube_account")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeYoutubeAccountType YoutubeAccount { get; set; }

        [JsonProperty("technologies")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem[] Technologies { get; set; }

        [JsonProperty("rankings")]
        public string[] Rankings { get; set; }

        [JsonProperty("ranking_positions")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem[] RankingPositions { get; set; }

        [JsonProperty("eins")]
        public string[] Eins { get; set; }

        [JsonProperty("npis")]
        public string[] Npis { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("total_funding")]
        public int TotalFunding { get; set; }

        [JsonProperty("last_funding_round_amount")]
        public int LastFundingRoundAmount { get; set; }

        [JsonProperty("last_funding_round_year")]
        public int LastFundingRoundYear { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("importance_score")]
        public string ImportanceScore { get; set; }

        [JsonProperty("tickers")]
        public LookAlikeResponseResultsTypeItemFullProfileTypeTickersTypeItem[] Tickers { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("cidrs_count")]
        public int CidrsCount { get; set; }

        [JsonProperty("liveramp_idl_count")]
        public int LiverampIdlCount { get; set; }

        [JsonProperty("liveramp_device_count")]
        public int LiverampDeviceCount { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem
    {
        [JsonProperty("orb_web_rank")]
        public int OrbWebRank { get; set; }

        [JsonProperty("domain_has_website")]
        public int DomainHasWebsite { get; set; }

        [JsonProperty("domain_is_email_hosting")]
        public int DomainIsEmailHosting { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("domain_has_email")]
        public int DomainHasEmail { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeLinkedinAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeFacebookAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeTwitterAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeGoogleplusAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeYoutubeAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem
    {
        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class LookAlikeResponseResultsTypeItemFullProfileTypeTickersTypeItem
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }

    public class CorporateTreeResponse
    {
        [JsonProperty("request_fields")]
        public JToken RequestFields { get; set; }

        [JsonProperty("facets")]
        public JToken Facets { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("results")]
        public CorporateTreeResponseResultsTypeItem[] Results { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItem
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity_type")]
        public CorporateTreeResponseResultsTypeItemEntityTypeType EntityType { get; set; }

        [JsonProperty("company_status")]
        public CorporateTreeResponseResultsTypeItemCompanyStatusType CompanyStatus { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("is_standalone_company")]
        public bool IsStandaloneCompany { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso_country_code")]
        public string IsoCountryCode { get; set; }

        [JsonProperty("fetch_url")]
        public string FetchUrl { get; set; }

        [JsonProperty("full_profile")]
        public CorporateTreeResponseResultsTypeItemFullProfileType FullProfile { get; set; }
    }

    public enum CorporateTreeResponseResultsTypeItemEntityTypeType
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "branch")]
        Branch
    }

    public enum CorporateTreeResponseResultsTypeItemCompanyStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileType
    {
        [JsonProperty("orb_num")]
        public int OrbNum { get; set; }

        [JsonProperty("orb_nums")]
        public int[] OrbNums { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_orb_num")]
        public int ParentOrbNum { get; set; }

        [JsonProperty("parent_name")]
        public string ParentName { get; set; }

        [JsonProperty("ultimate_parent_orb_num")]
        public int UltimateParentOrbNum { get; set; }

        [JsonProperty("ultimate_parent_name")]
        public string UltimateParentName { get; set; }

        [JsonProperty("subsidiaries_count")]
        public int SubsidiariesCount { get; set; }

        [JsonProperty("branches_count")]
        public int BranchesCount { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("webdomains")]
        public string[] Webdomains { get; set; }

        [JsonProperty("webdomains_info")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem[] WebdomainsInfo { get; set; }

        [JsonProperty("address")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeAddressType Address { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("naics_code")]
        public string NaicsCode { get; set; }

        [JsonProperty("naics_description")]
        public string NaicsDescription { get; set; }

        [JsonProperty("naics_codes")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem[] NaicsCodes { get; set; }

        [JsonProperty("sic_code")]
        public string SicCode { get; set; }

        [JsonProperty("sic_description")]
        public string SicDescription { get; set; }

        [JsonProperty("sic_codes")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("categories")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("employees_range")]
        public string EmployeesRange { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("revenue_range")]
        public string RevenueRange { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("year_founded")]
        public int YearFounded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("linkedin_account")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeLinkedinAccountType LinkedinAccount { get; set; }

        [JsonProperty("facebook_account")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeFacebookAccountType FacebookAccount { get; set; }

        [JsonProperty("twitter_account")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeTwitterAccountType TwitterAccount { get; set; }

        [JsonProperty("googleplus_account")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeGoogleplusAccountType GoogleplusAccount { get; set; }

        [JsonProperty("youtube_account")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeYoutubeAccountType YoutubeAccount { get; set; }

        [JsonProperty("technologies")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem[] Technologies { get; set; }

        [JsonProperty("rankings")]
        public string[] Rankings { get; set; }

        [JsonProperty("ranking_positions")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem[] RankingPositions { get; set; }

        [JsonProperty("eins")]
        public string[] Eins { get; set; }

        [JsonProperty("npis")]
        public string[] Npis { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("total_funding")]
        public int TotalFunding { get; set; }

        [JsonProperty("last_funding_round_amount")]
        public int LastFundingRoundAmount { get; set; }

        [JsonProperty("last_funding_round_year")]
        public int LastFundingRoundYear { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("importance_score")]
        public string ImportanceScore { get; set; }

        [JsonProperty("tickers")]
        public CorporateTreeResponseResultsTypeItemFullProfileTypeTickersTypeItem[] Tickers { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("cik")]
        public string Cik { get; set; }

        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("cidrs_count")]
        public int CidrsCount { get; set; }

        [JsonProperty("liveramp_idl_count")]
        public int LiverampIdlCount { get; set; }

        [JsonProperty("liveramp_device_count")]
        public int LiverampDeviceCount { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeWebdomainsInfoTypeItem
    {
        [JsonProperty("orb_web_rank")]
        public int OrbWebRank { get; set; }

        [JsonProperty("domain_has_website")]
        public int DomainHasWebsite { get; set; }

        [JsonProperty("domain_is_email_hosting")]
        public int DomainIsEmailHosting { get; set; }

        [JsonProperty("webdomain")]
        public string Webdomain { get; set; }

        [JsonProperty("domain_has_email")]
        public int DomainHasEmail { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeAddressType
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeNaicsCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeLinkedinAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeFacebookAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeTwitterAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeGoogleplusAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeYoutubeAccountType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("followers")]
        public int Followers { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeTechnologiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeRankingPositionsTypeItem
    {
        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class CorporateTreeResponseResultsTypeItemFullProfileTypeTickersTypeItem
    {
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Orbintelligenceip;

    public partial class WorkflowManagedActions
    {
        public OrbintelligenceipActions Orbintelligenceip(string connectionId) => new OrbintelligenceipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrbintelligenceipTriggers Orbintelligenceip(string connectionId) => new OrbintelligenceipTriggers(connectionId);
    }
}