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
        public IBodyWorkflowAction<AccessTokenGetResponse> AccessTokenGet(Expression<Func<string>> bodyauthRequestuseremail = null, Expression<Func<string>> bodyauthRequestuserpassword = null, Expression<Func<string>> bodyauthRequestapiKey = null)
        {
            var apiCallPath = "/userservice/tokens";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var auth_requestObject = new JObject();
            var auth_requestObjectpropCount = 0;
            var userObject = new JObject();
            var userObjectpropCount = 0;
            if (bodyauthRequestuseremail != null)
            {
                userObject["email"] = ExpressionConverter.ConvertO(bodyauthRequestuseremail);
                userObjectpropCount++;
            }

            if (bodyauthRequestuserpassword != null)
            {
                userObject["password"] = ExpressionConverter.ConvertO(bodyauthRequestuserpassword);
                userObjectpropCount++;
            }

            if (userObjectpropCount > 0)
            {
                auth_requestObject["user"] = userObject;
                auth_requestObjectpropCount++;
            }

            if (bodyauthRequestapiKey != null)
            {
                auth_requestObject["api_key"] = ExpressionConverter.ConvertO(bodyauthRequestapiKey);
                auth_requestObjectpropCount++;
            }

            if (auth_requestObjectpropCount > 0)
            {
                body["auth_request"] = auth_requestObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AccessTokenGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectInformationGetResponse> ProjectInformationGet(Expression<Func<string>> projectIds = null)
        {
            var apiCallPath = "/public/projectservice/projects/collection/ids";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectIds != null)
                callPayload.Queries["projectIds"] = ExpressionConverter.Convert(projectIds);
            return new ApiConnectionAction<ProjectInformationGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectInformationSetIDsResponse> ProjectInformationSetIDs(Expression<Func<string>> projectIds = null)
        {
            var apiCallPath = "/public/projectservice/projects/collection/summary/ids";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectIds != null)
                callPayload.Queries["projectIds"] = ExpressionConverter.Convert(projectIds);
            return new ApiConnectionAction<ProjectInformationSetIDsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<CampaignProjectGetResponse> CampaignProjectGet(Expression<Func<string>> campaignId, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/campaign/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<CampaignProjectGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<CampaignSummaryProjectResponse> CampaignSummaryProject(Expression<Func<string>> campaignId, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/campaign/{0}/projects/summary", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<CampaignSummaryProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectCountryGetResponse> ProjectCountryGet(Expression<Func<string>> iso3166CountryCode, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/countries/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(iso3166CountryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectCountryGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryCountryResponse> ProjectSummaryCountry(Expression<Func<string>> iso3166CountryCode, Expression<Func<string>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/countries/{0}/projects/summary", ExpressionConverter.ConvertWithUrlEncoding(iso3166CountryCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectSummaryCountryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectThemeResponse> ProjectTheme(Expression<Func<string>> themeId, Expression<Func<string>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/themes/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(themeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectThemeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectThemeSummaryResponse> ProjectThemeSummary(Expression<Func<string>> themeId, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/themes/{0}/projects/summary", ExpressionConverter.ConvertWithUrlEncoding(themeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectThemeSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectOrganizationResponse> ProjectOrganization(Expression<Func<string>> organizationId, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/organizations/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectOrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectOrganizationSummaryResponse> ProjectOrganizationSummary(Expression<Func<string>> organizationId, Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = String.Format("/public/projectservice/organizations/{0}/projects/summary", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectOrganizationSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectGetResponse> ProjectGet(Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = "/public/projectservice/all/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryGetResponse> ProjectSummaryGet(Expression<Func<int>> nextProjectId = null)
        {
            var apiCallPath = "/public/projectservice/all/projects/summary";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<ProjectSummaryGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectIDsResponse> ProjectIDs()
        {
            var apiCallPath = "/public/projectservice/all/projects/ids";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectIDsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectFeaturedResponse> ProjectFeatured()
        {
            var apiCallPath = "/public/projectservice/featured/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectFeaturedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectFeaturedSummaryResponse> ProjectFeaturedSummary()
        {
            var apiCallPath = "/public/projectservice/featured/projects/summary";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectFeaturedSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ImageGalleryResponse> ImageGallery(Expression<Func<int>> projectid)
        {
            var apiCallPath = String.Format("/public/projectservice/projects/{0}/imagegallery", ExpressionConverter.ConvertWithUrlEncoding(projectid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ImageGalleryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<OrganizationGetResponse> OrganizationGet(Expression<Func<string>> organizationid)
        {
            var apiCallPath = String.Format("/public/orgservice/organization/{0}", ExpressionConverter.ConvertWithUrlEncoding(organizationid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrganizationGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<OrganizationGetAllResponse> OrganizationGetAll(Expression<Func<string>> nextProjectId = null)
        {
            var apiCallPath = "/public/orgservice/all/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (nextProjectId != null)
                callPayload.Queries["nextProjectId"] = ExpressionConverter.Convert(nextProjectId);
            return new ApiConnectionAction<OrganizationGetAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<InvoiceOutstandingResponse> InvoiceOutstanding()
        {
            var apiCallPath = "/secure/givingservice/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InvoiceOutstandingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThirdPartyMaxResponse> ThirdPartyMax()
        {
            var apiCallPath = "/secure/givingservice/maxthirdpartytransactionid";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ThirdPartyMaxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectRegionCountResponse> ProjectRegionCount(Expression<Func<string>> regionname)
        {
            var apiCallPath = String.Format("/public/projectservice/regions/{0}/countries/projects/count", ExpressionConverter.ConvertWithUrlEncoding(regionname, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectRegionCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<RegionProjectCountResponse> RegionProjectCount()
        {
            var apiCallPath = "/public/projectservice/regions/countries/projects/count";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RegionProjectCountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<RegionGetResponse> RegionGet()
        {
            var apiCallPath = "/public/projectservice/regions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RegionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectGetAResponse> ProjectGetA(Expression<Func<int>> projectid)
        {
            var apiCallPath = String.Format("/public/projectservice/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectGetAResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSummaryResponse> ProjectSummary(Expression<Func<int>> projectid)
        {
            var apiCallPath = String.Format("/public/projectservice/projects/{0}/summary", ExpressionConverter.ConvertWithUrlEncoding(projectid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectSummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThemesResponse> Themes()
        {
            var apiCallPath = "/public/projectservice/themes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ThemesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ThemeProjectResponse> ThemeProject()
        {
            var apiCallPath = "/public/projectservice/themes/projects/ids";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ThemeProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<ProjectSearchResponse> ProjectSearch(Expression<Func<string>> q = null, Expression<Func<int>> start = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/public/services/search/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<ProjectSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<DonationSubmitResponse> DonationSubmit(Expression<Func<bool>> isTest = null, Expression<Func<int>> bodydonationrefcode = null, Expression<Func<string>> bodydonationtransactionId = null, Expression<Func<string>> bodydonationemail = null, Expression<Func<double>> bodydonationamount = null, Expression<Func<int>> bodydonationprojectid = null, Expression<Func<bool>> bodydonationsignupForGGNewsletter = null, Expression<Func<bool>> bodydonationsignupForCharityNewsletter = null, Expression<Func<string>> bodydonationpaymentDetailfirstname = null, Expression<Func<string>> bodydonationpaymentDetaillastname = null, Expression<Func<string>> bodydonationpaymentDetailaddress = null, Expression<Func<string>> bodydonationpaymentDetailaddress2 = null, Expression<Func<string>> bodydonationpaymentDetailcity = null, Expression<Func<string>> bodydonationpaymentDetailstate = null, Expression<Func<string>> bodydonationpaymentDetailiso3166CountryCode = null, Expression<Func<string>> bodydonationpaymentDetailpaymentGateway = null, Expression<Func<string>> bodydonationpaymentDetailpaymentGatewayKey = null, Expression<Func<string>> bodydonationpaymentDetailpaymentGatewayNonce = null, Expression<Func<string>> bodydonationipAddress = null, Expression<Func<string>> bodydonationuserAgent = null)
        {
            var apiCallPath = "/secure/givingservice/donationsclient";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isTest != null)
                callPayload.Queries["is_test"] = ExpressionConverter.Convert(isTest);
            var body = new JObject();
            var bodypropCount = 0;
            var donationObject = new JObject();
            var donationObjectpropCount = 0;
            if (bodydonationrefcode != null)
            {
                donationObject["refcode"] = ExpressionConverter.ConvertO(bodydonationrefcode);
                donationObjectpropCount++;
            }

            if (bodydonationtransactionId != null)
            {
                donationObject["transactionId"] = ExpressionConverter.ConvertO(bodydonationtransactionId);
                donationObjectpropCount++;
            }

            if (bodydonationemail != null)
            {
                donationObject["email"] = ExpressionConverter.ConvertO(bodydonationemail);
                donationObjectpropCount++;
            }

            if (bodydonationamount != null)
            {
                donationObject["amount"] = ExpressionConverter.ConvertO(bodydonationamount);
                donationObjectpropCount++;
            }

            var projectObject = new JObject();
            var projectObjectpropCount = 0;
            if (bodydonationprojectid != null)
            {
                projectObject["id"] = ExpressionConverter.ConvertO(bodydonationprojectid);
                projectObjectpropCount++;
            }

            if (projectObjectpropCount > 0)
            {
                donationObject["project"] = projectObject;
                donationObjectpropCount++;
            }

            if (bodydonationsignupForGGNewsletter != null)
            {
                donationObject["signupForGGNewsletter"] = ExpressionConverter.ConvertO(bodydonationsignupForGGNewsletter);
                donationObjectpropCount++;
            }

            if (bodydonationsignupForCharityNewsletter != null)
            {
                donationObject["signupForCharityNewsletter"] = ExpressionConverter.ConvertO(bodydonationsignupForCharityNewsletter);
                donationObjectpropCount++;
            }

            var payment_detailObject = new JObject();
            var payment_detailObjectpropCount = 0;
            if (bodydonationpaymentDetailfirstname != null)
            {
                payment_detailObject["firstname"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailfirstname);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetaillastname != null)
            {
                payment_detailObject["lastname"] = ExpressionConverter.ConvertO(bodydonationpaymentDetaillastname);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailaddress != null)
            {
                payment_detailObject["address"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailaddress);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailaddress2 != null)
            {
                payment_detailObject["address2"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailaddress2);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailcity != null)
            {
                payment_detailObject["city"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailcity);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailstate != null)
            {
                payment_detailObject["state"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailstate);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailiso3166CountryCode != null)
            {
                payment_detailObject["iso3166CountryCode"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailiso3166CountryCode);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailpaymentGateway != null)
            {
                payment_detailObject["paymentGateway"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailpaymentGateway);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailpaymentGatewayKey != null)
            {
                payment_detailObject["paymentGatewayKey"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailpaymentGatewayKey);
                payment_detailObjectpropCount++;
            }

            if (bodydonationpaymentDetailpaymentGatewayNonce != null)
            {
                payment_detailObject["paymentGatewayNonce"] = ExpressionConverter.ConvertO(bodydonationpaymentDetailpaymentGatewayNonce);
                payment_detailObjectpropCount++;
            }

            if (payment_detailObjectpropCount > 0)
            {
                donationObject["payment_detail"] = payment_detailObject;
                donationObjectpropCount++;
            }

            if (bodydonationipAddress != null)
            {
                donationObject["ipAddress"] = ExpressionConverter.ConvertO(bodydonationipAddress);
                donationObjectpropCount++;
            }

            if (bodydonationuserAgent != null)
            {
                donationObject["userAgent"] = ExpressionConverter.ConvertO(bodydonationuserAgent);
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

            return new ApiConnectionAction<DonationSubmitResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCardDesignsResponse> GiftCardDesigns()
        {
            var apiCallPath = "/secure/givingservice/giftcarddesigns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftCardDesignsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCardSendResponse> GiftCardSend(Expression<Func<bool>> isTest = null, Expression<Func<int>> bodygiftCardrefcode = null, Expression<Func<string>> bodygiftCardtransactionId = null, Expression<Func<string>> bodygiftCardemail = null, Expression<Func<double>> bodygiftCardamount = null, Expression<Func<string>> bodygiftCardpaymentDetailfirstname = null, Expression<Func<string>> bodygiftCardpaymentDetaillastname = null, Expression<Func<string>> bodygiftCardpaymentDetailaddress = null, Expression<Func<string>> bodygiftCardpaymentDetailaddress2 = null, Expression<Func<string>> bodygiftCardpaymentDetailcity = null, Expression<Func<string>> bodygiftCardpaymentDetailstate = null, Expression<Func<string>> bodygiftCardpaymentDetailiso3166CountryCode = null, Expression<Func<int>> bodygiftCardpaymentDetailzip = null, Expression<Func<int>> bodygiftCardpaymentDetailcreditCardNumber = null, Expression<Func<int>> bodygiftCardpaymentDetailsecurityCode = null, Expression<Func<int>> bodygiftCardpaymentDetailexpiryDateMonth = null, Expression<Func<int>> bodygiftCardpaymentDetailexpiryDateYear = null, Expression<Func<int>> bodygiftCardgiftCardDesignid = null, Expression<Func<string>> bodygiftCardgiftCardDetaildateToSend = null, Expression<Func<string>> bodygiftCardgiftCardDetailfirstname = null, Expression<Func<string>> bodygiftCardgiftCardDetaillastname = null, Expression<Func<string>> bodygiftCardgiftCardDetailemail = null, Expression<Func<string>> bodygiftCardgiftCardDetailphone = null, Expression<Func<string>> bodygiftCardgiftCardDetailto = null, Expression<Func<string>> bodygiftCardgiftCardDetailfrom = null, Expression<Func<string>> bodygiftCardgiftCardDetailmessage = null)
        {
            var apiCallPath = "/secure/givingservice/giftcards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isTest != null)
                callPayload.Queries["is_test"] = ExpressionConverter.Convert(isTest);
            var body = new JObject();
            var bodypropCount = 0;
            var giftCardObject = new JObject();
            var giftCardObjectpropCount = 0;
            if (bodygiftCardrefcode != null)
            {
                giftCardObject["refcode"] = ExpressionConverter.ConvertO(bodygiftCardrefcode);
                giftCardObjectpropCount++;
            }

            if (bodygiftCardtransactionId != null)
            {
                giftCardObject["transactionId"] = ExpressionConverter.ConvertO(bodygiftCardtransactionId);
                giftCardObjectpropCount++;
            }

            if (bodygiftCardemail != null)
            {
                giftCardObject["email"] = ExpressionConverter.ConvertO(bodygiftCardemail);
                giftCardObjectpropCount++;
            }

            if (bodygiftCardamount != null)
            {
                giftCardObject["amount"] = ExpressionConverter.ConvertO(bodygiftCardamount);
                giftCardObjectpropCount++;
            }

            var payment_detailObject = new JObject();
            var payment_detailObjectpropCount = 0;
            if (bodygiftCardpaymentDetailfirstname != null)
            {
                payment_detailObject["firstname"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailfirstname);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetaillastname != null)
            {
                payment_detailObject["lastname"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetaillastname);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailaddress != null)
            {
                payment_detailObject["address"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailaddress);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailaddress2 != null)
            {
                payment_detailObject["address2"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailaddress2);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailcity != null)
            {
                payment_detailObject["city"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailcity);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailstate != null)
            {
                payment_detailObject["state"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailstate);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailiso3166CountryCode != null)
            {
                payment_detailObject["iso3166CountryCode"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailiso3166CountryCode);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailzip != null)
            {
                payment_detailObject["zip"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailzip);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailcreditCardNumber != null)
            {
                payment_detailObject["creditCardNumber"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailcreditCardNumber);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailsecurityCode != null)
            {
                payment_detailObject["securityCode"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailsecurityCode);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailexpiryDateMonth != null)
            {
                payment_detailObject["expiryDateMonth"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailexpiryDateMonth);
                payment_detailObjectpropCount++;
            }

            if (bodygiftCardpaymentDetailexpiryDateYear != null)
            {
                payment_detailObject["expiryDateYear"] = ExpressionConverter.ConvertO(bodygiftCardpaymentDetailexpiryDateYear);
                payment_detailObjectpropCount++;
            }

            if (payment_detailObjectpropCount > 0)
            {
                giftCardObject["payment_detail"] = payment_detailObject;
                giftCardObjectpropCount++;
            }

            var giftCardDesignObject = new JObject();
            var giftCardDesignObjectpropCount = 0;
            if (bodygiftCardgiftCardDesignid != null)
            {
                giftCardDesignObject["id"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDesignid);
                giftCardDesignObjectpropCount++;
            }

            if (giftCardDesignObjectpropCount > 0)
            {
                giftCardObject["giftCardDesign"] = giftCardDesignObject;
                giftCardObjectpropCount++;
            }

            var giftCard_detailObject = new JObject();
            var giftCard_detailObjectpropCount = 0;
            if (bodygiftCardgiftCardDetaildateToSend != null)
            {
                giftCard_detailObject["dateToSend"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetaildateToSend);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailfirstname != null)
            {
                giftCard_detailObject["firstname"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailfirstname);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetaillastname != null)
            {
                giftCard_detailObject["lastname"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetaillastname);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailemail != null)
            {
                giftCard_detailObject["email"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailemail);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailphone != null)
            {
                giftCard_detailObject["phone"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailphone);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailto != null)
            {
                giftCard_detailObject["to"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailto);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailfrom != null)
            {
                giftCard_detailObject["from"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailfrom);
                giftCard_detailObjectpropCount++;
            }

            if (bodygiftCardgiftCardDetailmessage != null)
            {
                giftCard_detailObject["message"] = ExpressionConverter.ConvertO(bodygiftCardgiftCardDetailmessage);
                giftCard_detailObjectpropCount++;
            }

            if (giftCard_detailObjectpropCount > 0)
            {
                giftCardObject["giftCard_detail"] = giftCard_detailObject;
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

            return new ApiConnectionAction<GiftCardSendResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCertificateOrderResponse> GiftCertificateOrder(Expression<Func<bool>> isTest = null, Expression<Func<int>> bodygiftCertificaterefcode = null, Expression<Func<double>> bodygiftCertificateamount = null, Expression<Func<string>> bodygiftCertificatethirdPartyIdentifier = null, Expression<Func<string>> bodygiftCertificatecurrencyCode = null, Expression<Func<string>> bodygiftCertificateexpirationDate = null)
        {
            var apiCallPath = "/secure/givingservice/giftcertificates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (isTest != null)
                callPayload.Queries["is_test"] = ExpressionConverter.Convert(isTest);
            var body = new JObject();
            var bodypropCount = 0;
            var giftCertificateObject = new JObject();
            var giftCertificateObjectpropCount = 0;
            if (bodygiftCertificaterefcode != null)
            {
                giftCertificateObject["refcode"] = ExpressionConverter.ConvertO(bodygiftCertificaterefcode);
                giftCertificateObjectpropCount++;
            }

            if (bodygiftCertificateamount != null)
            {
                giftCertificateObject["amount"] = ExpressionConverter.ConvertO(bodygiftCertificateamount);
                giftCertificateObjectpropCount++;
            }

            if (bodygiftCertificatethirdPartyIdentifier != null)
            {
                giftCertificateObject["thirdPartyIdentifier"] = ExpressionConverter.ConvertO(bodygiftCertificatethirdPartyIdentifier);
                giftCertificateObjectpropCount++;
            }

            if (bodygiftCertificatecurrencyCode != null)
            {
                giftCertificateObject["currencyCode"] = ExpressionConverter.ConvertO(bodygiftCertificatecurrencyCode);
                giftCertificateObjectpropCount++;
            }

            if (bodygiftCertificateexpirationDate != null)
            {
                giftCertificateObject["expirationDate"] = ExpressionConverter.ConvertO(bodygiftCertificateexpirationDate);
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

            return new ApiConnectionAction<GiftCertificateOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "globalgivingprojectip")]
        public IBodyWorkflowAction<GiftCertificateDetailsResponse> GiftCertificateDetails(Expression<Func<string>> giftcertid)
        {
            var apiCallPath = String.Format("/secure/givingservice/giftcertificatedetail/{0}/", ExpressionConverter.ConvertWithUrlEncoding(giftcertid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftCertificateDetailsResponse>(callPayload);
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