//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Draup
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DraupActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetCompanyPrioritiesResponse> GetCompanyPriorities([WorkflowExpression] Func<int> accountId, [WorkflowExpression] Func<string> bodyworkload = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/priorities/{0}/account_priorities/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkload != null)
                {
                    body["workload"] = SourceExpressionConverter.ConvertToken(bodyworkload);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanyPrioritiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetFinancialsResponse> GetFinancials([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/account_profile/{0}/financials/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetFinancialsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetDecisionMakersResponse> GetDecisionMakers([WorkflowExpression] Func<int> accountId, [WorkflowExpression] Func<string> bodyworkload = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/executives/{0}/key_executives/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkload != null)
                {
                    body["workload"] = SourceExpressionConverter.ConvertToken(bodyworkload);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDecisionMakersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetRelevantWorkloadsResponse> GetRelevantWorkloads([WorkflowExpression] Func<string> bodyuserDescription)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/universe/get_relevant_workloads/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_description"] = SourceExpressionConverter.ConvertToken(bodyuserDescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetRelevantWorkloadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetAccountIdsResponse> GetAccountIds([WorkflowExpression] Func<string> bodysearchKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/universe/search/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["search_key"] = SourceExpressionConverter.ConvertToken(bodysearchKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAccountIdsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetItSpendResponse> GetItSpend([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/{0}/financials/revenue_by_it_spend/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetItSpendResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetCompetitorsResponse> GetCompetitors([WorkflowExpression] Func<int> accountId, [WorkflowExpression] Func<string> bodyworkload = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/{0}/get_product_competitors/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkload != null)
                {
                    body["workload"] = SourceExpressionConverter.ConvertToken(bodyworkload);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetCompetitorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetCompanySignalsResponse> GetCompanySignals([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/account_profile/{0}/top_signals/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanySignalsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetRevenueByBusinessResponse> GetRevenueByBusiness([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/account_profile/{0}/revenue_by_business/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetRevenueByBusinessResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetRevenueByRegionResponse> GetRevenueByRegion([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/{0}/financials/revenue_by_region", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetRevenueByRegionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetOutsourcingDetailsResponse> GetOutsourcingDetails([WorkflowExpression] Func<int> accountId, [WorkflowExpression] Func<string> bodyoutsourcingInWorkloads = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/{0}/outsourcing/engagement_details/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyoutsourcingInWorkloads != null)
                {
                    body["outsourcing_in_workloads"] = SourceExpressionConverter.ConvertToken(bodyoutsourcingInWorkloads);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetOutsourcingDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetCompanyDetailsResponse> GetCompanyDetails([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/account_profile/{0}/about/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanyDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetTechStackProductsResponse> GetTechStackProducts([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/api/tech_stack/{0}/tech_stack_products/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetTechStackProductsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetHiringTimelineResponse> GetHiringTimeline([WorkflowExpression] Func<int> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasub/accounts/hiring/timeline/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetHiringTimelineResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetLocationDemographicsResponse> GetLocationDemographics([WorkflowExpression] Func<string> location, [WorkflowExpression] Func<bool> isCountry = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/ecosystem/v2/get_location_demographics_data/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (isCountry != null)
                    callPayload.Queries["is_country"] = SourceExpressionConverter.ConvertO(isCountry);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                return callPayload;
            }

            return new ApiConnectionAction<GetLocationDemographicsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetKeyTrendsResponse> GetKeyTrends([WorkflowExpression] Func<string> bodyvertical)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/ecosystem/api/v2/vertical_key_priorities/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["vertical"] = SourceExpressionConverter.ConvertToken(bodyvertical);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetKeyTrendsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetEcosystemTechStackResponse> GetEcosystemTechStack([WorkflowExpression] Func<string> bodywidget, [WorkflowExpression] Func<string> bodyvertical)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/ecosystem/api/v2/tech_stack/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["widget"] = SourceExpressionConverter.ConvertToken(bodywidget);
                bodypropCount++;
                body["vertical"] = SourceExpressionConverter.ConvertToken(bodyvertical);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetEcosystemTechStackResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetVerticalOutsourcingDataResponse> GetVerticalOutsourcingData([WorkflowExpression] Func<string> bodywidget, [WorkflowExpression] Func<string> bodyvertical)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/ecosystem/api/v2/vertical_outsourcing/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["widget"] = SourceExpressionConverter.ConvertToken(bodywidget);
                bodypropCount++;
                body["vertical"] = SourceExpressionConverter.ConvertToken(bodyvertical);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetVerticalOutsourcingDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<GetEmployersDataResponse> GetEmployersData([WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyvertical = null, [WorkflowExpression] Func<bool> bodyisCountry = null, [WorkflowExpression] Func<string> bodyanalysisType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/ecosystem/v2/get_employers_data/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyvertical != null)
                {
                    body["vertical"] = SourceExpressionConverter.ConvertToken(bodyvertical);
                    bodypropCount++;
                }

                if (bodyisCountry != null)
                {
                    body["is_country"] = SourceExpressionConverter.ConvertToken(bodyisCountry);
                    bodypropCount++;
                }

                if (bodyanalysisType != null)
                {
                    body["analysis_type"] = SourceExpressionConverter.ConvertToken(bodyanalysisType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetEmployersDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "draup")]
        public IBodyWorkflowAction<ExtractEntitiesResponse> ExtractEntities([WorkflowExpression] Func<string> bodyuserQuery)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasub/core/extract_entities/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["product-id"] = Convert.ToString(4);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_query"] = SourceExpressionConverter.ConvertToken(bodyuserQuery);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractEntitiesResponse>(BuildSourceInput);
        }
    }

    public class DraupTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCompanyPrioritiesResponse
    {
        [JsonProperty("result")]
        public GetCompanyPrioritiesResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCompanyPrioritiesResponseResultTypeItem
    {
        [JsonProperty("source_type")]
        public string[] SourceType { get; set; }

        [JsonProperty("usecase_info")]
        public GetCompanyPrioritiesResponseResultTypeItemUsecaseInfoTypeItem[] UsecaseInfo { get; set; }

        [JsonProperty("priority_name")]
        public string PriorityName { get; set; }

        [JsonProperty("source_quarter")]
        public string SourceQuarter { get; set; }

        [JsonProperty("business_function")]
        public string BusinessFunction { get; set; }

        [JsonProperty("applicable_usecases")]
        public string[] ApplicableUsecases { get; set; }

        [JsonProperty("functional_workload")]
        public string[] FunctionalWorkload { get; set; }

        [JsonProperty("priority_description")]
        public string PriorityDescription { get; set; }

        [JsonProperty("account_priorities_id")]
        public int AccountPrioritiesId { get; set; }

        [JsonProperty("source_publication_date")]
        public string SourcePublicationDate { get; set; }
    }

    public class GetCompanyPrioritiesResponseResultTypeItemUsecaseInfoTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFinancialsResponse
    {
        [JsonProperty("result")]
        public GetFinancialsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetFinancialsResponseResultTypeItem
    {
        [JsonProperty("ebitda")]
        public GetFinancialsResponseResultTypeItemEbitdaType Ebitda { get; set; }

        [JsonProperty("itspend")]
        public GetFinancialsResponseResultTypeItemItspendType Itspend { get; set; }

        [JsonProperty("revenue")]
        public GetFinancialsResponseResultTypeItemRevenueType Revenue { get; set; }

        [JsonProperty("rndspend")]
        public GetFinancialsResponseResultTypeItemRndspendType Rndspend { get; set; }

        [JsonProperty("valuation")]
        public double Valuation { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("concerned_year")]
        public int ConcernedYear { get; set; }

        [JsonProperty("last_funded_on")]
        public string LastFundedOn { get; set; }

        [JsonProperty("num_funding_rounds")]
        public int NumFundingRounds { get; set; }

        [JsonProperty("avg_conversion_rate")]
        public double AvgConversionRate { get; set; }

        [JsonProperty("last_funding_amount")]
        public double LastFundingAmount { get; set; }

        [JsonProperty("total_funding_amount")]
        public double TotalFundingAmount { get; set; }
    }

    public class GetFinancialsResponseResultTypeItemEbitdaType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetFinancialsResponseResultTypeItemItspendType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetFinancialsResponseResultTypeItemRevenueType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetFinancialsResponseResultTypeItemRndspendType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetDecisionMakersResponse
    {
        [JsonProperty("executives")]
        public GetDecisionMakersResponseExecutivesTypeItem[] Executives { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetDecisionMakersResponseExecutivesTypeItem
    {
        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("email")]
        public string[] Email { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("patents")]
        public string[] Patents { get; set; }

        [JsonProperty("raw_bio")]
        public string RawBio { get; set; }

        [JsonProperty("schools")]
        public string[] Schools { get; set; }

        [JsonProperty("job_role")]
        public string JobRole { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("vertical")]
        public string Vertical { get; set; }

        [JsonProperty("draup_url")]
        public string DraupUrl { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("verticals")]
        public string[] Verticals { get; set; }

        [JsonProperty("workloads")]
        public string[] Workloads { get; set; }

        [JsonProperty("core_skills")]
        public string[] CoreSkills { get; set; }

        [JsonProperty("notes_count")]
        public int NotesCount { get; set; }

        [JsonProperty("soft_skills")]
        public string[] SoftSkills { get; set; }

        [JsonProperty("twitter_url")]
        public string TwitterUrl { get; set; }

        [JsonProperty("executive_id")]
        public string ExecutiveId { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("publications")]
        public string[] Publications { get; set; }

        [JsonProperty("is_eu_profile")]
        public bool IsEuProfile { get; set; }

        [JsonProperty("projects_list")]
        public JToken[] ProjectsList { get; set; }

        [JsonProperty("working_style")]
        public string WorkingStyle { get; set; }

        [JsonProperty("business_units")]
        public string[] BusinessUnits { get; set; }

        [JsonProperty("certifications")]
        public string[] Certifications { get; set; }

        [JsonProperty("executive_name")]
        public string ExecutiveName { get; set; }

        [JsonProperty("job_role_array")]
        public string[] JobRoleArray { get; set; }

        [JsonProperty("past_companies")]
        public string[] PastCompanies { get; set; }

        [JsonProperty("past_job_roles")]
        public string[] PastJobRoles { get; set; }

        [JsonProperty("account_logo_url")]
        public string AccountLogoUrl { get; set; }

        [JsonProperty("raw_account_name")]
        public string RawAccountName { get; set; }

        [JsonProperty("volunteering_orgs")]
        public string[] VolunteeringOrgs { get; set; }

        [JsonProperty("business_functions")]
        public string[] BusinessFunctions { get; set; }

        [JsonProperty("executive_logo_url")]
        public string ExecutiveLogoUrl { get; set; }

        [JsonProperty("honours_and_awards")]
        public string[] HonoursAndAwards { get; set; }

        [JsonProperty("interpreted_skills")]
        public string[] InterpretedSkills { get; set; }

        [JsonProperty("level_in_org_grade")]
        public string LevelInOrgGrade { get; set; }

        [JsonProperty("personality_traits")]
        public string[] PersonalityTraits { get; set; }

        [JsonProperty("deal_size_influence")]
        public string DealSizeInfluence { get; set; }

        [JsonProperty("sales_sorting_index")]
        public double SalesSortingIndex { get; set; }

        [JsonProperty("years_of_experience")]
        public double YearsOfExperience { get; set; }

        [JsonProperty("budget_control_value")]
        public string BudgetControlValue { get; set; }

        [JsonProperty("current_org_experience")]
        public double CurrentOrgExperience { get; set; }

        [JsonProperty("current_role_experience")]
        public double CurrentRoleExperience { get; set; }

        [JsonProperty("current_title_experience")]
        public double CurrentTitleExperience { get; set; }

        [JsonProperty("level_in_org_designation")]
        public string LevelInOrgDesignation { get; set; }
    }

    public class GetRelevantWorkloadsResponse
    {
        [JsonProperty("workloads")]
        public string[] Workloads { get; set; }
    }

    public class GetAccountIdsResponse
    {
        [JsonProperty("data")]
        public GetAccountIdsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetAccountIdsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("ai_suggested")]
        public bool AiSuggested { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class GetItSpendResponse
    {
        [JsonProperty("headerSuffix")]
        public GetItSpendResponseHeaderSuffixType HeaderSuffix { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class GetItSpendResponseHeaderSuffixType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetCompetitorsResponse
    {
        [JsonProperty("data")]
        public GetCompetitorsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetCompetitorsResponseDataTypeItem
    {
        [JsonProperty("competitor_name")]
        public string CompetitorName { get; set; }

        [JsonProperty("top_products")]
        public string[] TopProducts { get; set; }

        [JsonProperty("total_product_count")]
        public int TotalProductCount { get; set; }
    }

    public class GetCompanySignalsResponse
    {
        [JsonProperty("result")]
        public GetCompanySignalsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCompanySignalsResponseResultTypeItem
    {
        [JsonProperty("helpful")]
        public string Helpful { get; set; }

        [JsonProperty("accounts")]
        public string[] Accounts { get; set; }

        [JsonProperty("bookmark")]
        public bool Bookmark { get; set; }

        [JsonProperty("news_url")]
        public string NewsUrl { get; set; }

        [JsonProperty("highlights")]
        public string[] Highlights { get; set; }

        [JsonProperty("news_image")]
        public string NewsImage { get; set; }

        [JsonProperty("news_title")]
        public string NewsTitle { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("news_source")]
        public string NewsSource { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_captured")]
        public string DateCaptured { get; set; }

        [JsonProperty("account_signal_id")]
        public int AccountSignalId { get; set; }

        [JsonProperty("signal_categories")]
        public string[] SignalCategories { get; set; }
    }

    public class GetRevenueByBusinessResponse
    {
        [JsonProperty("result")]
        public GetRevenueByBusinessResponseResultTypeItem[] Result { get; set; }
    }

    public class GetRevenueByBusinessResponseResultTypeItem
    {
        [JsonProperty("business_unit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("current_amount")]
        public double CurrentAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("percentage_share")]
        public double PercentageShare { get; set; }

        [JsonProperty("growth_percentage")]
        public double GrowthPercentage { get; set; }

        [JsonProperty("latest_year")]
        public int LatestYear { get; set; }
    }

    public class GetRevenueByRegionResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("year")]
        public double Year { get; set; }

        [JsonProperty("headerSuffix")]
        public GetRevenueByRegionResponseHeaderSuffixType HeaderSuffix { get; set; }
    }

    public class GetRevenueByRegionResponseHeaderSuffixType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }
    }

    public class GetOutsourcingDetailsResponse
    {
        [JsonProperty("data")]
        public GetOutsourcingDetailsResponseDataType Data { get; set; }
    }

    public class GetOutsourcingDetailsResponseDataType
    {
        [JsonProperty("rowData")]
        public JToken[][] RowData { get; set; }

        [JsonProperty("columnDefs")]
        public GetOutsourcingDetailsResponseDataTypeColumnDefsTypeItem[] ColumnDefs { get; set; }

        [JsonProperty("tableDefId")]
        public string TableDefId { get; set; }

        [JsonProperty("resultCount")]
        public int ResultCount { get; set; }
    }

    public class GetOutsourcingDetailsResponseDataTypeColumnDefsTypeItem
    {
        [JsonProperty("hide")]
        public bool Hide { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("headerName")]
        public string HeaderName { get; set; }
    }

    public class GetCompanyDetailsResponse
    {
        [JsonProperty("result")]
        public GetCompanyDetailsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCompanyDetailsResponseResultTypeItem
    {
        [JsonProperty("oi_score")]
        public double OiScore { get; set; }

        [JsonProperty("verticals")]
        public string[] Verticals { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("headquarter")]
        public string Headquarter { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("sub_verticals")]
        public string[] SubVerticals { get; set; }

        [JsonProperty("total_workforce")]
        public int TotalWorkforce { get; set; }

        [JsonProperty("primary_vertical")]
        public string PrimaryVertical { get; set; }
    }

    public class GetTechStackProductsResponse
    {
        [JsonProperty("result")]
        public GetTechStackProductsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetTechStackProductsResponseResultTypeItem
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }

        [JsonProperty("workloads")]
        public string Workloads { get; set; }

        [JsonProperty("developer_company")]
        public string DeveloperCompany { get; set; }

        [JsonProperty("last_evidence_date")]
        public string LastEvidenceDate { get; set; }

        [JsonProperty("tech_stack_product")]
        public string TechStackProduct { get; set; }

        [JsonProperty("first_evidence_date")]
        public string FirstEvidenceDate { get; set; }

        [JsonProperty("product_picture_url")]
        public string ProductPictureUrl { get; set; }

        [JsonProperty("tech_stack_category")]
        public string TechStackCategory { get; set; }

        [JsonProperty("g2_sub_category_name")]
        public string G2SubCategoryName { get; set; }

        [JsonProperty("tech_stack_product_id")]
        public int TechStackProductId { get; set; }
    }

    public class GetHiringTimelineResponse
    {
        [JsonProperty("data")]
        public GetHiringTimelineResponseDataType Data { get; set; }
    }

    public class GetHiringTimelineResponseDataType
    {
        [JsonProperty("avg")]
        public int Avg { get; set; }

        [JsonProperty("stddev")]
        public double Stddev { get; set; }

        [JsonProperty("plot_points")]
        public int[] PlotPoints { get; set; }

        [JsonProperty("hiring_timeline")]
        public GetHiringTimelineResponseDataTypeHiringTimelineTypeItem[] HiringTimeline { get; set; }

        [JsonProperty("partial_months_hiring_timeline")]
        public GetHiringTimelineResponseDataTypePartialMonthsHiringTimelineTypeItem[] PartialMonthsHiringTimeline { get; set; }
    }

    public class GetHiringTimelineResponseDataTypeHiringTimelineTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("job_count")]
        public int JobCount { get; set; }
    }

    public class GetHiringTimelineResponseDataTypePartialMonthsHiringTimelineTypeItem
    {
        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("job_count")]
        public int JobCount { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class GetLocationDemographicsResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("loc_map_data")]
        public JToken LocMapData { get; set; }
    }

    public class GetKeyTrendsResponse
    {
        [JsonProperty("result")]
        public GetKeyTrendsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetKeyTrendsResponseResultTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_relevant")]
        public bool IsRelevant { get; set; }
    }

    public class GetEcosystemTechStackResponse
    {
        [JsonProperty("hml")]
        public GetEcosystemTechStackResponseHmlType Hml { get; set; }

        [JsonProperty("result")]
        public GetEcosystemTechStackResponseResultTypeItem[] Result { get; set; }
    }

    public class GetEcosystemTechStackResponseHmlType
    {
        [JsonProperty("33_percentile")]
        public int _33Percentile { get; set; }

        [JsonProperty("67_percentile")]
        public int _67Percentile { get; set; }
    }

    public class GetEcosystemTechStackResponseResultTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }
    }

    public class GetVerticalOutsourcingDataResponse
    {
        [JsonProperty("hml")]
        public GetVerticalOutsourcingDataResponseHmlType Hml { get; set; }

        [JsonProperty("result")]
        public GetVerticalOutsourcingDataResponseResultTypeItem[] Result { get; set; }
    }

    public class GetVerticalOutsourcingDataResponseHmlType
    {
        [JsonProperty("33_percentile")]
        public int _33Percentile { get; set; }

        [JsonProperty("67_percentile")]
        public int _67Percentile { get; set; }
    }

    public class GetVerticalOutsourcingDataResponseResultTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }
    }

    public class GetEmployersDataResponse
    {
        [JsonProperty("hml")]
        public GetEmployersDataResponseHmlType Hml { get; set; }

        [JsonProperty("employers")]
        public GetEmployersDataResponseEmployersTypeItem[] Employers { get; set; }
    }

    public class GetEmployersDataResponseHmlType
    {
        [JsonProperty("33_percentile")]
        public int _33Percentile { get; set; }

        [JsonProperty("67_percentile")]
        public int _67Percentile { get; set; }
    }

    public class GetEmployersDataResponseEmployersTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("account_logo")]
        public string AccountLogo { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }
    }

    public class ExtractEntitiesResponse
    {
        [JsonProperty("entities")]
        public ExtractEntitiesResponseEntitiesTypeItem[] Entities { get; set; }
    }

    public class ExtractEntitiesResponseEntitiesTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Draup;

    public partial class WorkflowManagedActions
    {
        public DraupActions Draup(string connectionId) => new DraupActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DraupTriggers Draup(string connectionId) => new DraupTriggers(connectionId);
    }
}