//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Globalgivingprojectip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GlobalgivingprojectipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<AccessTokenGetResponse> AccessTokenGet([WorkflowExpression] Func<string> bodyauthRequestuseremail = null, [WorkflowExpression] Func<string> bodyauthRequestuserpassword = null, [WorkflowExpression] Func<string> bodyauthRequestapiKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/userservice/tokens";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var authRequestObject = new JObject();
                var authRequestObjectpropCount = 0;
                var userObject = new JObject();
                var userObjectpropCount = 0;
                if (bodyauthRequestuseremail != null)
                {
                    userObject["email"] = SourceExpressionConverter.ConvertToken(bodyauthRequestuseremail);
                    userObjectpropCount++;
                }

                if (bodyauthRequestuserpassword != null)
                {
                    userObject["password"] = SourceExpressionConverter.ConvertToken(bodyauthRequestuserpassword);
                    userObjectpropCount++;
                }

                if (userObjectpropCount > 0)
                {
                    authRequestObject["user"] = userObject;
                    authRequestObjectpropCount++;
                }

                if (bodyauthRequestapiKey != null)
                {
                    authRequestObject["api_key"] = SourceExpressionConverter.ConvertToken(bodyauthRequestapiKey);
                    authRequestObjectpropCount++;
                }

                if (authRequestObjectpropCount > 0)
                {
                    body["auth_request"] = authRequestObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AccessTokenGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectInformationGetResponse> ProjectInformationGet([WorkflowExpression] Func<string> projectIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/projects/collection/ids";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectIds != null)
                    callPayload.Queries["projectIds"] = SourceExpressionConverter.ConvertO(projectIds);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectInformationGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectInformationSetIDsResponse> ProjectInformationSetIDs([WorkflowExpression] Func<string> projectIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/projects/collection/summary/ids";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectIds != null)
                    callPayload.Queries["projectIds"] = SourceExpressionConverter.ConvertO(projectIds);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectInformationSetIDsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<CampaignProjectGetResponse> CampaignProjectGet([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/campaign/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignProjectGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<CampaignSummaryProjectResponse> CampaignSummaryProject([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/campaign/{0}/projects/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignSummaryProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectCountryGetResponse> ProjectCountryGet([WorkflowExpression] Func<string> iso3166CountryCode, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/countries/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(iso3166CountryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectCountryGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryCountryResponse> ProjectSummaryCountry([WorkflowExpression] Func<string> iso3166CountryCode, [WorkflowExpression] Func<string> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/countries/{0}/projects/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(iso3166CountryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectSummaryCountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectThemeResponse> ProjectTheme([WorkflowExpression] Func<string> themeId, [WorkflowExpression] Func<string> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/themes/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(themeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectThemeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectThemeSummaryResponse> ProjectThemeSummary([WorkflowExpression] Func<string> themeId, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/themes/{0}/projects/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(themeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectThemeSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectOrganizationResponse> ProjectOrganization([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/organizations/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectOrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectOrganizationSummaryResponse> ProjectOrganizationSummary([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/organizations/{0}/projects/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectOrganizationSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet([WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/all/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryGetResponse> ProjectSummaryGet([WorkflowExpression] Func<int> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/all/projects/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectSummaryGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectIDsResponse> ProjectIDs()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/all/projects/ids";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectIDsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectFeaturedResponse> ProjectFeatured()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/featured/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectFeaturedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectFeaturedSummaryResponse> ProjectFeaturedSummary()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/featured/projects/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectFeaturedSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ImageGalleryResponse> ImageGallery([WorkflowExpression] Func<int> projectid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/projects/{0}/imagegallery", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ImageGalleryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<OrganizationGetResponse> OrganizationGet([WorkflowExpression] Func<string> organizationid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/orgservice/organization/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<OrganizationGetAllResponse> OrganizationGetAll([WorkflowExpression] Func<string> nextProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/orgservice/all/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (nextProjectId != null)
                    callPayload.Queries["nextProjectId"] = SourceExpressionConverter.ConvertO(nextProjectId);
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationGetAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<InvoiceOutstandingResponse> InvoiceOutstanding()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceOutstandingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThirdPartyMaxResponse> ThirdPartyMax()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/maxthirdpartytransactionid";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ThirdPartyMaxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectRegionCountResponse> ProjectRegionCount([WorkflowExpression] Func<string> regionname)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/regions/{0}/countries/projects/count", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectRegionCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<RegionProjectCountResponse> RegionProjectCount()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/regions/countries/projects/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RegionProjectCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<RegionGetResponse> RegionGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RegionGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectGetAResponse> ProjectGetA([WorkflowExpression] Func<int> projectid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectGetAResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryResponse> ProjectSummary([WorkflowExpression] Func<int> projectid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public/projectservice/projects/{0}/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThemesResponse> Themes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/themes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ThemesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThemeProjectResponse> ThemeProject()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/projectservice/themes/projects/ids";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ThemeProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSearchResponse> ProjectSearch([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<string> filter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public/services/search/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<DonationSubmitResponse> DonationSubmit([WorkflowExpression] Func<bool> isTest = null, [WorkflowExpression] Func<int> bodydonationrefcode = null, [WorkflowExpression] Func<string> bodydonationtransactionId = null, [WorkflowExpression] Func<string> bodydonationemail = null, [WorkflowExpression] Func<double> bodydonationamount = null, [WorkflowExpression] Func<int> bodydonationprojectid = null, [WorkflowExpression] Func<bool> bodydonationsignupForGGNewsletter = null, [WorkflowExpression] Func<bool> bodydonationsignupForCharityNewsletter = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailfirstname = null, [WorkflowExpression] Func<string> bodydonationpaymentDetaillastname = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailaddress = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailaddress2 = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailcity = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailstate = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailiso3166CountryCode = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailpaymentGateway = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailpaymentGatewayKey = null, [WorkflowExpression] Func<string> bodydonationpaymentDetailpaymentGatewayNonce = null, [WorkflowExpression] Func<string> bodydonationipAddress = null, [WorkflowExpression] Func<string> bodydonationuserAgent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/donationsclient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isTest != null)
                    callPayload.Queries["is_test"] = SourceExpressionConverter.ConvertO(isTest);
                var body = new JObject();
                var bodypropCount = 0;
                var donationObject = new JObject();
                var donationObjectpropCount = 0;
                if (bodydonationrefcode != null)
                {
                    donationObject["refcode"] = SourceExpressionConverter.ConvertToken(bodydonationrefcode);
                    donationObjectpropCount++;
                }

                if (bodydonationtransactionId != null)
                {
                    donationObject["transactionId"] = SourceExpressionConverter.ConvertToken(bodydonationtransactionId);
                    donationObjectpropCount++;
                }

                if (bodydonationemail != null)
                {
                    donationObject["email"] = SourceExpressionConverter.ConvertToken(bodydonationemail);
                    donationObjectpropCount++;
                }

                if (bodydonationamount != null)
                {
                    donationObject["amount"] = SourceExpressionConverter.ConvertToken(bodydonationamount);
                    donationObjectpropCount++;
                }

                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (bodydonationprojectid != null)
                {
                    projectObject["id"] = SourceExpressionConverter.ConvertToken(bodydonationprojectid);
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    donationObject["project"] = projectObject;
                    donationObjectpropCount++;
                }

                if (bodydonationsignupForGGNewsletter != null)
                {
                    donationObject["signupForGGNewsletter"] = SourceExpressionConverter.ConvertToken(bodydonationsignupForGGNewsletter);
                    donationObjectpropCount++;
                }

                if (bodydonationsignupForCharityNewsletter != null)
                {
                    donationObject["signupForCharityNewsletter"] = SourceExpressionConverter.ConvertToken(bodydonationsignupForCharityNewsletter);
                    donationObjectpropCount++;
                }

                var paymentDetailObject = new JObject();
                var paymentDetailObjectpropCount = 0;
                if (bodydonationpaymentDetailfirstname != null)
                {
                    paymentDetailObject["firstname"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailfirstname);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetaillastname != null)
                {
                    paymentDetailObject["lastname"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetaillastname);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailaddress != null)
                {
                    paymentDetailObject["address"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailaddress);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailaddress2 != null)
                {
                    paymentDetailObject["address2"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailaddress2);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailcity != null)
                {
                    paymentDetailObject["city"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailcity);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailstate != null)
                {
                    paymentDetailObject["state"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailstate);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailiso3166CountryCode != null)
                {
                    paymentDetailObject["iso3166CountryCode"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailiso3166CountryCode);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailpaymentGateway != null)
                {
                    paymentDetailObject["paymentGateway"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailpaymentGateway);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailpaymentGatewayKey != null)
                {
                    paymentDetailObject["paymentGatewayKey"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailpaymentGatewayKey);
                    paymentDetailObjectpropCount++;
                }

                if (bodydonationpaymentDetailpaymentGatewayNonce != null)
                {
                    paymentDetailObject["paymentGatewayNonce"] = SourceExpressionConverter.ConvertToken(bodydonationpaymentDetailpaymentGatewayNonce);
                    paymentDetailObjectpropCount++;
                }

                if (paymentDetailObjectpropCount > 0)
                {
                    donationObject["payment_detail"] = paymentDetailObject;
                    donationObjectpropCount++;
                }

                if (bodydonationipAddress != null)
                {
                    donationObject["ipAddress"] = SourceExpressionConverter.ConvertToken(bodydonationipAddress);
                    donationObjectpropCount++;
                }

                if (bodydonationuserAgent != null)
                {
                    donationObject["userAgent"] = SourceExpressionConverter.ConvertToken(bodydonationuserAgent);
                    donationObjectpropCount++;
                }

                if (donationObjectpropCount > 0)
                {
                    body["donation"] = donationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DonationSubmitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCardDesignsResponse> GiftCardDesigns()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/giftcarddesigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardDesignsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCardSendResponse> GiftCardSend([WorkflowExpression] Func<bool> isTest = null, [WorkflowExpression] Func<int> bodygiftCardrefcode = null, [WorkflowExpression] Func<string> bodygiftCardtransactionId = null, [WorkflowExpression] Func<string> bodygiftCardemail = null, [WorkflowExpression] Func<double> bodygiftCardamount = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailfirstname = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetaillastname = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailaddress = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailaddress2 = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailcity = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailstate = null, [WorkflowExpression] Func<string> bodygiftCardpaymentDetailiso3166CountryCode = null, [WorkflowExpression] Func<int> bodygiftCardpaymentDetailzip = null, [WorkflowExpression] Func<int> bodygiftCardpaymentDetailcreditCardNumber = null, [WorkflowExpression] Func<int> bodygiftCardpaymentDetailsecurityCode = null, [WorkflowExpression] Func<int> bodygiftCardpaymentDetailexpiryDateMonth = null, [WorkflowExpression] Func<int> bodygiftCardpaymentDetailexpiryDateYear = null, [WorkflowExpression] Func<int> bodygiftCardgiftCardDesignid = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetaildateToSend = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailfirstname = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetaillastname = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailemail = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailphone = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailto = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailfrom = null, [WorkflowExpression] Func<string> bodygiftCardgiftCardDetailmessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/giftcards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isTest != null)
                    callPayload.Queries["is_test"] = SourceExpressionConverter.ConvertO(isTest);
                var body = new JObject();
                var bodypropCount = 0;
                var giftCardObject = new JObject();
                var giftCardObjectpropCount = 0;
                if (bodygiftCardrefcode != null)
                {
                    giftCardObject["refcode"] = SourceExpressionConverter.ConvertToken(bodygiftCardrefcode);
                    giftCardObjectpropCount++;
                }

                if (bodygiftCardtransactionId != null)
                {
                    giftCardObject["transactionId"] = SourceExpressionConverter.ConvertToken(bodygiftCardtransactionId);
                    giftCardObjectpropCount++;
                }

                if (bodygiftCardemail != null)
                {
                    giftCardObject["email"] = SourceExpressionConverter.ConvertToken(bodygiftCardemail);
                    giftCardObjectpropCount++;
                }

                if (bodygiftCardamount != null)
                {
                    giftCardObject["amount"] = SourceExpressionConverter.ConvertToken(bodygiftCardamount);
                    giftCardObjectpropCount++;
                }

                var paymentDetailObject = new JObject();
                var paymentDetailObjectpropCount = 0;
                if (bodygiftCardpaymentDetailfirstname != null)
                {
                    paymentDetailObject["firstname"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailfirstname);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetaillastname != null)
                {
                    paymentDetailObject["lastname"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetaillastname);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailaddress != null)
                {
                    paymentDetailObject["address"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailaddress);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailaddress2 != null)
                {
                    paymentDetailObject["address2"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailaddress2);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailcity != null)
                {
                    paymentDetailObject["city"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailcity);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailstate != null)
                {
                    paymentDetailObject["state"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailstate);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailiso3166CountryCode != null)
                {
                    paymentDetailObject["iso3166CountryCode"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailiso3166CountryCode);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailzip != null)
                {
                    paymentDetailObject["zip"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailzip);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailcreditCardNumber != null)
                {
                    paymentDetailObject["creditCardNumber"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailcreditCardNumber);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailsecurityCode != null)
                {
                    paymentDetailObject["securityCode"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailsecurityCode);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailexpiryDateMonth != null)
                {
                    paymentDetailObject["expiryDateMonth"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailexpiryDateMonth);
                    paymentDetailObjectpropCount++;
                }

                if (bodygiftCardpaymentDetailexpiryDateYear != null)
                {
                    paymentDetailObject["expiryDateYear"] = SourceExpressionConverter.ConvertToken(bodygiftCardpaymentDetailexpiryDateYear);
                    paymentDetailObjectpropCount++;
                }

                if (paymentDetailObjectpropCount > 0)
                {
                    giftCardObject["payment_detail"] = paymentDetailObject;
                    giftCardObjectpropCount++;
                }

                var giftCardDesignObject = new JObject();
                var giftCardDesignObjectpropCount = 0;
                if (bodygiftCardgiftCardDesignid != null)
                {
                    giftCardDesignObject["id"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDesignid);
                    giftCardDesignObjectpropCount++;
                }

                if (giftCardDesignObjectpropCount > 0)
                {
                    giftCardObject["giftCardDesign"] = giftCardDesignObject;
                    giftCardObjectpropCount++;
                }

                var giftCardDetailObject = new JObject();
                var giftCardDetailObjectpropCount = 0;
                if (bodygiftCardgiftCardDetaildateToSend != null)
                {
                    giftCardDetailObject["dateToSend"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetaildateToSend);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailfirstname != null)
                {
                    giftCardDetailObject["firstname"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailfirstname);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetaillastname != null)
                {
                    giftCardDetailObject["lastname"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetaillastname);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailemail != null)
                {
                    giftCardDetailObject["email"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailemail);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailphone != null)
                {
                    giftCardDetailObject["phone"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailphone);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailto != null)
                {
                    giftCardDetailObject["to"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailto);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailfrom != null)
                {
                    giftCardDetailObject["from"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailfrom);
                    giftCardDetailObjectpropCount++;
                }

                if (bodygiftCardgiftCardDetailmessage != null)
                {
                    giftCardDetailObject["message"] = SourceExpressionConverter.ConvertToken(bodygiftCardgiftCardDetailmessage);
                    giftCardDetailObjectpropCount++;
                }

                if (giftCardDetailObjectpropCount > 0)
                {
                    giftCardObject["giftCard_detail"] = giftCardDetailObject;
                    giftCardObjectpropCount++;
                }

                if (giftCardObjectpropCount > 0)
                {
                    body["giftCard"] = giftCardObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardSendResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCertificateOrderResponse> GiftCertificateOrder([WorkflowExpression] Func<bool> isTest = null, [WorkflowExpression] Func<int> bodygiftCertificaterefcode = null, [WorkflowExpression] Func<double> bodygiftCertificateamount = null, [WorkflowExpression] Func<string> bodygiftCertificatethirdPartyIdentifier = null, [WorkflowExpression] Func<string> bodygiftCertificatecurrencyCode = null, [WorkflowExpression] Func<string> bodygiftCertificateexpirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secure/givingservice/giftcertificates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isTest != null)
                    callPayload.Queries["is_test"] = SourceExpressionConverter.ConvertO(isTest);
                var body = new JObject();
                var bodypropCount = 0;
                var giftCertificateObject = new JObject();
                var giftCertificateObjectpropCount = 0;
                if (bodygiftCertificaterefcode != null)
                {
                    giftCertificateObject["refcode"] = SourceExpressionConverter.ConvertToken(bodygiftCertificaterefcode);
                    giftCertificateObjectpropCount++;
                }

                if (bodygiftCertificateamount != null)
                {
                    giftCertificateObject["amount"] = SourceExpressionConverter.ConvertToken(bodygiftCertificateamount);
                    giftCertificateObjectpropCount++;
                }

                if (bodygiftCertificatethirdPartyIdentifier != null)
                {
                    giftCertificateObject["thirdPartyIdentifier"] = SourceExpressionConverter.ConvertToken(bodygiftCertificatethirdPartyIdentifier);
                    giftCertificateObjectpropCount++;
                }

                if (bodygiftCertificatecurrencyCode != null)
                {
                    giftCertificateObject["currencyCode"] = SourceExpressionConverter.ConvertToken(bodygiftCertificatecurrencyCode);
                    giftCertificateObjectpropCount++;
                }

                if (bodygiftCertificateexpirationDate != null)
                {
                    giftCertificateObject["expirationDate"] = SourceExpressionConverter.ConvertToken(bodygiftCertificateexpirationDate);
                    giftCertificateObjectpropCount++;
                }

                if (giftCertificateObjectpropCount > 0)
                {
                    body["giftCertificate"] = giftCertificateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCertificateOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCertificateDetailsResponse> GiftCertificateDetails([WorkflowExpression] Func<string> giftcertid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secure/givingservice/giftcertificatedetail/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftcertid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftCertificateDetailsResponse>(BuildSourceInput);
        }
    }

    public class GlobalgivingprojectipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccessTokenGetResponse
    {
        [JsonProperty("auth_response")]
        public AccessTokenGetResponseAuthResponseType AuthResponse { get; set; }
    }

    public class AccessTokenGetResponseAuthResponseType
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class ProjectInformationGetResponse
    {
        [JsonProperty("projects")]
        public ProjectInformationGetResponseProjectsType Projects { get; set; }
    }

    public class ProjectInformationGetResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItem[] Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItem
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("countries")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string[] Country { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemCountriesType
    {
        [JsonProperty("country")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string[] Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemThemesType
    {
        [JsonProperty("theme")]
        public ProjectInformationGetResponseProjectsTypeProjectTypeItemThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectInformationGetResponseProjectsTypeProjectTypeItemThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationSetIDsResponse
    {
        [JsonProperty("projects")]
        public ProjectInformationSetIDsResponseProjectsType Projects { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectType Project { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectInformationSetIDsResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectInformationSetIDsResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CampaignProjectGetResponse
    {
        [JsonProperty("projects")]
        public CampaignProjectGetResponseProjectsType Projects { get; set; }
    }

    public class CampaignProjectGetResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public CampaignProjectGetResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public CampaignProjectGetResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class CampaignProjectGetResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CampaignSummaryProjectResponse
    {
        [JsonProperty("projects")]
        public CampaignSummaryProjectResponseProjectsType Projects { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public CampaignSummaryProjectResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("countries")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("donationOptions")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public CampaignSummaryProjectResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class CampaignSummaryProjectResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectCountryGetResponse
    {
        [JsonProperty("projects")]
        public ProjectCountryGetResponseProjectsType Projects { get; set; }
    }

    public class ProjectCountryGetResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectCountryGetResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectCountryGetResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectCountryGetResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectSummaryCountryResponse
    {
        [JsonProperty("projects")]
        public ProjectSummaryCountryResponseProjectsType Projects { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectSummaryCountryResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryCountryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryCountryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeResponse
    {
        [JsonProperty("projects")]
        public ProjectThemeResponseProjectsType Projects { get; set; }
    }

    public class ProjectThemeResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectThemeResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectThemeResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectThemeResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectThemeResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectThemeResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectThemeResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectThemeResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectThemeResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectThemeResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectThemeResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectThemeResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectThemeResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectThemeResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectThemeSummaryResponse
    {
        [JsonProperty("projects")]
        public ProjectThemeSummaryResponseProjectsType Projects { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectThemeSummaryResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("countries")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectThemeSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectThemeSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationResponse
    {
        [JsonProperty("projects")]
        public ProjectOrganizationResponseProjectsType Projects { get; set; }
    }

    public class ProjectOrganizationResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectOrganizationResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectOrganizationResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectOrganizationResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectOrganizationSummaryResponse
    {
        [JsonProperty("projects")]
        public ProjectOrganizationSummaryResponseProjectsType Projects { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectOrganizationSummaryResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectOrganizationSummaryResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectGetResponse
    {
        [JsonProperty("projects")]
        public ProjectGetResponseProjectsType Projects { get; set; }
    }

    public class ProjectGetResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectGetResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectGetResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("dateOfMostRecentReport")]
        public string DateOfMostRecentReport { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectGetResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectGetResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("numberOfReports")]
        public string NumberOfReports { get; set; }

        [JsonProperty("organization")]
        public ProjectGetResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectGetResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectGetResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectGetResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectGetResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectGetResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectSummaryGetResponse
    {
        [JsonProperty("projects")]
        public ProjectSummaryGetResponseProjectsType Projects { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextProjectId")]
        public int NextProjectId { get; set; }

        [JsonProperty("project")]
        public ProjectSummaryGetResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryGetResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectIDsResponse
    {
        [JsonProperty("projects")]
        public ProjectIDsResponseProjectsType Projects { get; set; }
    }

    public class ProjectIDsResponseProjectsType
    {
        [JsonProperty("project")]
        public ProjectIDsResponseProjectsTypeProjectTypeItem[] Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectIDsResponseProjectsTypeProjectTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ProjectFeaturedResponse
    {
        [JsonProperty("projects")]
        public ProjectFeaturedResponseProjectsType Projects { get; set; }
    }

    public class ProjectFeaturedResponseProjectsType
    {
        [JsonProperty("project")]
        public ProjectFeaturedResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public string ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("organization")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeVideosType Videos { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeVideosType
    {
        [JsonProperty("video")]
        public ProjectFeaturedResponseProjectsTypeProjectTypeVideosTypeVideoType Video { get; set; }
    }

    public class ProjectFeaturedResponseProjectsTypeProjectTypeVideosTypeVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectFeaturedSummaryResponse
    {
        [JsonProperty("projects")]
        public ProjectFeaturedSummaryResponseProjectsType Projects { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsType
    {
        [JsonProperty("project")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectType Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("totalProjects")]
        public string TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectFeaturedSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectFeaturedSummaryResponseProjectsTypeProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ImageGalleryResponse
    {
        [JsonProperty("images")]
        public ImageGalleryResponseImagesType Images { get; set; }
    }

    public class ImageGalleryResponseImagesType
    {
        [JsonProperty("image")]
        public ImageGalleryResponseImagesTypeImageTypeItem[] Image { get; set; }
    }

    public class ImageGalleryResponseImagesTypeImageTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imagelink")]
        public ImageGalleryResponseImagesTypeImageTypeItemImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }
    }

    public class ImageGalleryResponseImagesTypeImageTypeItemImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class OrganizationGetResponse
    {
        [JsonProperty("organization")]
        public OrganizationGetResponseOrganizationType Organization { get; set; }
    }

    public class OrganizationGetResponseOrganizationType
    {
        [JsonProperty("activeProjects")]
        public string ActiveProjects { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("ein")]
        public string Ein { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("mission")]
        public string Mission { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("totalProjects")]
        public int TotalProjects { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public OrganizationGetResponseOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public OrganizationGetResponseOrganizationTypeCountriesType Countries { get; set; }
    }

    public class OrganizationGetResponseOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public OrganizationGetResponseOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class OrganizationGetResponseOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrganizationGetResponseOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public OrganizationGetResponseOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class OrganizationGetResponseOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrganizationGetAllResponse
    {
        [JsonProperty("organizations")]
        public OrganizationGetAllResponseOrganizationsType Organizations { get; set; }
    }

    public class OrganizationGetAllResponseOrganizationsType
    {
        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }

        [JsonProperty("nextOrgId")]
        public int NextOrgId { get; set; }

        [JsonProperty("organization")]
        public JToken[] Organization { get; set; }
    }

    public class InvoiceOutstandingResponse
    {
        [JsonProperty("invoices")]
        public InvoiceOutstandingResponseInvoicesType Invoices { get; set; }
    }

    public class InvoiceOutstandingResponseInvoicesType
    {
        [JsonProperty("invoice")]
        public InvoiceOutstandingResponseInvoicesTypeInvoiceTypeItem[] Invoice { get; set; }
    }

    public class InvoiceOutstandingResponseInvoicesTypeInvoiceTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("project")]
        public InvoiceOutstandingResponseInvoicesTypeInvoiceTypeItemProjectType Project { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }
    }

    public class InvoiceOutstandingResponseInvoicesTypeInvoiceTypeItemProjectType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ThirdPartyMaxResponse
    {
        [JsonProperty("order")]
        public ThirdPartyMaxResponseOrderType Order { get; set; }
    }

    public class ThirdPartyMaxResponseOrderType
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("signupForCharityNewsletter")]
        public bool SignupForCharityNewsletter { get; set; }

        [JsonProperty("signupForGGNewsletter")]
        public bool SignupForGGNewsletter { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class ProjectRegionCountResponse
    {
        [JsonProperty("regions")]
        public ProjectRegionCountResponseRegionsType Regions { get; set; }
    }

    public class ProjectRegionCountResponseRegionsType
    {
        [JsonProperty("region")]
        public ProjectRegionCountResponseRegionsTypeRegionType Region { get; set; }
    }

    public class ProjectRegionCountResponseRegionsTypeRegionType
    {
        [JsonProperty("countries")]
        public ProjectRegionCountResponseRegionsTypeRegionTypeCountriesType Countries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectRegionCountResponseRegionsTypeRegionTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectRegionCountResponseRegionsTypeRegionTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectRegionCountResponseRegionsTypeRegionTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectCount")]
        public int ProjectCount { get; set; }
    }

    public class RegionProjectCountResponse
    {
        [JsonProperty("regions")]
        public RegionProjectCountResponseRegionsType Regions { get; set; }
    }

    public class RegionProjectCountResponseRegionsType
    {
        [JsonProperty("region")]
        public RegionProjectCountResponseRegionsTypeRegionType Region { get; set; }
    }

    public class RegionProjectCountResponseRegionsTypeRegionType
    {
        [JsonProperty("countries")]
        public RegionProjectCountResponseRegionsTypeRegionTypeCountriesType Countries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RegionProjectCountResponseRegionsTypeRegionTypeCountriesType
    {
        [JsonProperty("country")]
        public RegionProjectCountResponseRegionsTypeRegionTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class RegionProjectCountResponseRegionsTypeRegionTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectCount")]
        public int ProjectCount { get; set; }
    }

    public class RegionGetResponse
    {
        [JsonProperty("regions")]
        public RegionGetResponseRegionsType Regions { get; set; }
    }

    public class RegionGetResponseRegionsType
    {
        [JsonProperty("region")]
        public RegionGetResponseRegionsTypeRegionTypeItem[] Region { get; set; }
    }

    public class RegionGetResponseRegionsTypeRegionTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetAResponse
    {
        [JsonProperty("project")]
        public ProjectGetAResponseProjectType Project { get; set; }
    }

    public class ProjectGetAResponseProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPostal")]
        public int ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("countries")]
        public ProjectGetAResponseProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectGetAResponseProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("imageSizeOptions")]
        public ProjectGetAResponseProjectTypeImageSizeOptionsType ImageSizeOptions { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("organization")]
        public ProjectGetAResponseProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("themes")]
        public ProjectGetAResponseProjectTypeThemesType Themes { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectGetAResponseProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectGetAResponseProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectGetAResponseProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectGetAResponseProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectGetAResponseProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectGetAResponseProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectGetAResponseProjectTypeImageSizeOptionsType
    {
        [JsonProperty("image")]
        public ProjectGetAResponseProjectTypeImageSizeOptionsTypeImageTypeItem[] Image { get; set; }
    }

    public class ProjectGetAResponseProjectTypeImageSizeOptionsTypeImageTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectGetAResponseProjectTypeOrganizationType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProjectGetAResponseProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectGetAResponseProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectGetAResponseProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryResponse
    {
        [JsonProperty("project")]
        public ProjectSummaryResponseProjectType Project { get; set; }
    }

    public class ProjectSummaryResponseProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryResponseProjectTypeCountriesType Countries { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectSummaryResponseProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("organization")]
        public ProjectSummaryResponseProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryResponseProjectTypeThemesType Themes { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryResponseProjectTypeCountriesTypeCountryType Country { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeCountriesTypeCountryType
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectSummaryResponseProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeOrganizationType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("themes")]
        public ProjectSummaryResponseProjectTypeOrganizationTypeThemesType Themes { get; set; }

        [JsonProperty("countries")]
        public ProjectSummaryResponseProjectTypeOrganizationTypeCountriesType Countries { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeOrganizationTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryResponseProjectTypeOrganizationTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeOrganizationTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeOrganizationTypeCountriesType
    {
        [JsonProperty("country")]
        public ProjectSummaryResponseProjectTypeOrganizationTypeCountriesTypeCountryTypeItem[] Country { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeOrganizationTypeCountriesTypeCountryTypeItem
    {
        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeThemesType
    {
        [JsonProperty("theme")]
        public ProjectSummaryResponseProjectTypeThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ProjectSummaryResponseProjectTypeThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThemesResponse
    {
        [JsonProperty("themes")]
        public ThemesResponseThemesType Themes { get; set; }
    }

    public class ThemesResponseThemesType
    {
        [JsonProperty("theme")]
        public ThemesResponseThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ThemesResponseThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ThemeProjectResponse
    {
        [JsonProperty("themes")]
        public ThemeProjectResponseThemesType Themes { get; set; }
    }

    public class ThemeProjectResponseThemesType
    {
        [JsonProperty("theme")]
        public ThemeProjectResponseThemesTypeThemeTypeItem[] Theme { get; set; }
    }

    public class ThemeProjectResponseThemesTypeThemeTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projects")]
        public ThemeProjectResponseThemesTypeThemeTypeItemProjectsType Projects { get; set; }
    }

    public class ThemeProjectResponseThemesTypeThemeTypeItemProjectsType
    {
        [JsonProperty("project")]
        public ThemeProjectResponseThemesTypeThemeTypeItemProjectsTypeProjectTypeItem[] Project { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }

        [JsonProperty("__text")]
        public string Text { get; set; }
    }

    public class ThemeProjectResponseThemesTypeThemeTypeItemProjectsTypeProjectTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ProjectSearchResponse
    {
        [JsonProperty("search")]
        public ProjectSearchResponseSearchType Search { get; set; }
    }

    public class ProjectSearchResponseSearchType
    {
        [JsonProperty("request")]
        public ProjectSearchResponseSearchTypeRequestType Request { get; set; }

        [JsonProperty("response")]
        public ProjectSearchResponseSearchTypeResponseType Response { get; set; }
    }

    public class ProjectSearchResponseSearchTypeRequestType
    {
        [JsonProperty("filters")]
        public ProjectSearchResponseSearchTypeRequestTypeFiltersType Filters { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }

    public class ProjectSearchResponseSearchTypeRequestTypeFiltersType
    {
        [JsonProperty("filter")]
        public ProjectSearchResponseSearchTypeRequestTypeFiltersTypeFilterType Filter { get; set; }
    }

    public class ProjectSearchResponseSearchTypeRequestTypeFiltersTypeFilterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseType
    {
        [JsonProperty("projects")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsType Projects { get; set; }

        [JsonProperty("_start")]
        public int Start { get; set; }

        [JsonProperty("_numberFound")]
        public int NumberFound { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsType
    {
        [JsonProperty("project")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectType Project { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("activities")]
        public string Activities { get; set; }

        [JsonProperty("additionalDocumentation")]
        public string AdditionalDocumentation { get; set; }

        [JsonProperty("approvedDate")]
        public string ApprovedDate { get; set; }

        [JsonProperty("contactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty("contactAddress2")]
        public string ContactAddress2 { get; set; }

        [JsonProperty("contactCity")]
        public string ContactCity { get; set; }

        [JsonProperty("contactCountry")]
        public string ContactCountry { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contactPostal")]
        public int ContactPostal { get; set; }

        [JsonProperty("contactState")]
        public string ContactState { get; set; }

        [JsonProperty("contactUrl")]
        public string ContactUrl { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("donationOptions")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeDonationOptionsType DonationOptions { get; set; }

        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageGallerySize")]
        public string ImageGallerySize { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("image")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeImageType Image { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("longTermImpact")]
        public string LongTermImpact { get; set; }

        [JsonProperty("need")]
        public string Need { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("organization")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeOrganizationType Organization { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("themeName")]
        public string ThemeName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeDonationOptionsType
    {
        [JsonProperty("donationOption")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem[] DonationOption { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeDonationOptionsTypeDonationOptionTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeImageType
    {
        [JsonProperty("imagelink")]
        public ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeImageTypeImagelinkTypeItem[] Imagelink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeImageTypeImagelinkTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("_size")]
        public string Size { get; set; }
    }

    public class ProjectSearchResponseSearchTypeResponseTypeProjectsTypeProjectTypeOrganizationType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }
    }

    public class DonationSubmitResponse
    {
        [JsonProperty("donation")]
        public DonationSubmitResponseDonationType Donation { get; set; }
    }

    public class DonationSubmitResponseDonationType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("chargedAmount")]
        public double ChargedAmount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("project")]
        public DonationSubmitResponseDonationTypeProjectType Project { get; set; }

        [JsonProperty("signupForCharityNewsletter")]
        public bool SignupForCharityNewsletter { get; set; }

        [JsonProperty("signupForGGNewsletter")]
        public bool SignupForGGNewsletter { get; set; }

        [JsonProperty("refcode")]
        public int Refcode { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("checkedOut")]
        public bool CheckedOut { get; set; }

        [JsonProperty("giftCertificate_detail")]
        public DonationSubmitResponseDonationTypeGiftCertificateDetailType GiftCertificateDetail { get; set; }

        [JsonProperty("receipt")]
        public DonationSubmitResponseDonationTypeReceiptType Receipt { get; set; }
    }

    public class DonationSubmitResponseDonationTypeProjectType
    {
        [JsonProperty("funding")]
        public double Funding { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("numberOfDonations")]
        public int NumberOfDonations { get; set; }

        [JsonProperty("progressReportLink")]
        public string ProgressReportLink { get; set; }

        [JsonProperty("projectLink")]
        public string ProjectLink { get; set; }

        [JsonProperty("remaining")]
        public string Remaining { get; set; }
    }

    public class DonationSubmitResponseDonationTypeGiftCertificateDetailType
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("giftCertificateNumber")]
        public string GiftCertificateNumber { get; set; }

        [JsonProperty("redeemedAmount")]
        public double RedeemedAmount { get; set; }

        [JsonProperty("remainingAmount")]
        public double RemainingAmount { get; set; }
    }

    public class DonationSubmitResponseDonationTypeReceiptType
    {
        [JsonProperty("receiptNumber")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("taxDeductibleContributionAmount")]
        public double TaxDeductibleContributionAmount { get; set; }

        [JsonProperty("totalAmountBilled")]
        public double TotalAmountBilled { get; set; }
    }

    public class GiftCardDesignsResponse
    {
        [JsonProperty("giftCardDesigns")]
        public GiftCardDesignsResponseGiftCardDesignsType GiftCardDesigns { get; set; }
    }

    public class GiftCardDesignsResponseGiftCardDesignsType
    {
        [JsonProperty("giftCardDesign")]
        public GiftCardDesignsResponseGiftCardDesignsTypeGiftCardDesignType GiftCardDesign { get; set; }
    }

    public class GiftCardDesignsResponseGiftCardDesignsTypeGiftCardDesignType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("addressRequired")]
        public bool AddressRequired { get; set; }

        [JsonProperty("amountRequired")]
        public bool AmountRequired { get; set; }

        [JsonProperty("cardType")]
        public string CardType { get; set; }

        [JsonProperty("custom")]
        public bool Custom { get; set; }

        [JsonProperty("emailRequired")]
        public bool EmailRequired { get; set; }

        [JsonProperty("giftCertificate")]
        public bool GiftCertificate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("previewImageUrl")]
        public string PreviewImageUrl { get; set; }

        [JsonProperty("quantityRequired")]
        public bool QuantityRequired { get; set; }

        [JsonProperty("sendToRequired")]
        public bool SendToRequired { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public class GiftCardSendResponse
    {
        [JsonProperty("giftCard")]
        public GiftCardSendResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardSendResponseGiftCardType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("chargedAmount")]
        public double ChargedAmount { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("refcode")]
        public int Refcode { get; set; }

        [JsonProperty("signupForCharityNewsletter")]
        public bool SignupForCharityNewsletter { get; set; }

        [JsonProperty("signupForGGNewsletter")]
        public bool SignupForGGNewsletter { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("checkedOut")]
        public bool CheckedOut { get; set; }

        [JsonProperty("giftCertificate_detail")]
        public GiftCardSendResponseGiftCardTypeGiftCertificateDetailType GiftCertificateDetail { get; set; }

        [JsonProperty("payment_detail")]
        public GiftCardSendResponseGiftCardTypePaymentDetailType PaymentDetail { get; set; }

        [JsonProperty("receipt")]
        public GiftCardSendResponseGiftCardTypeReceiptType Receipt { get; set; }

        [JsonProperty("giftCardDesign")]
        public GiftCardSendResponseGiftCardTypeGiftCardDesignType GiftCardDesign { get; set; }

        [JsonProperty("giftCard_detail")]
        public GiftCardSendResponseGiftCardTypeGiftCardDetailType GiftCardDetail { get; set; }
    }

    public class GiftCardSendResponseGiftCardTypeGiftCertificateDetailType
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("giftCertificateNumber")]
        public string GiftCertificateNumber { get; set; }

        [JsonProperty("remainingAmount")]
        public double RemainingAmount { get; set; }
    }

    public class GiftCardSendResponseGiftCardTypePaymentDetailType
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("iso3166CountryCode")]
        public string Iso3166CountryCode { get; set; }

        [JsonProperty("zip")]
        public int Zip { get; set; }

        [JsonProperty("creditCardNumber")]
        public int CreditCardNumber { get; set; }

        [JsonProperty("securityCode")]
        public int SecurityCode { get; set; }

        [JsonProperty("expiryDateMonth")]
        public int ExpiryDateMonth { get; set; }

        [JsonProperty("expiryDateYear")]
        public int ExpiryDateYear { get; set; }
    }

    public class GiftCardSendResponseGiftCardTypeReceiptType
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("receiptNumber")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("taxDeductibleContributionAmount")]
        public double TaxDeductibleContributionAmount { get; set; }

        [JsonProperty("totalAmountBilled")]
        public double TotalAmountBilled { get; set; }
    }

    public class GiftCardSendResponseGiftCardTypeGiftCardDesignType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class GiftCardSendResponseGiftCardTypeGiftCardDetailType
    {
        [JsonProperty("dateToSend")]
        public string DateToSend { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GiftCertificateOrderResponse
    {
        [JsonProperty("giftCertificate_detail")]
        public GiftCertificateOrderResponseGiftCertificateDetailType GiftCertificateDetail { get; set; }
    }

    public class GiftCertificateOrderResponseGiftCertificateDetailType
    {
        [JsonProperty("giftCertificateNumber")]
        public string GiftCertificateNumber { get; set; }

        [JsonProperty("remainingAmount")]
        public double RemainingAmount { get; set; }

        [JsonProperty("thirdPartyIdentifier")]
        public string ThirdPartyIdentifier { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("redeemUrl")]
        public string RedeemUrl { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GiftCertificateDetailsResponse
    {
        [JsonProperty("giftCertificate_detail")]
        public GiftCertificateDetailsResponseGiftCertificateDetailType GiftCertificateDetail { get; set; }
    }

    public class GiftCertificateDetailsResponseGiftCertificateDetailType
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("giftCertificateNumber")]
        public string GiftCertificateNumber { get; set; }

        [JsonProperty("remainingAmount")]
        public double RemainingAmount { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Globalgivingprojectip;

    public partial class WorkflowManagedActions
    {
        public GlobalgivingprojectipActions Globalgivingprojectip(string connectionId) => new GlobalgivingprojectipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GlobalgivingprojectipTriggers Globalgivingprojectip(string connectionId) => new GlobalgivingprojectipTriggers(connectionId);
    }
}