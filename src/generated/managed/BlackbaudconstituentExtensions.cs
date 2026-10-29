//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudconstituentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration> CreateConstituentConsent(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodychannel, Expression<Func<bodyresponseInput>> bodyresponse, Expression<Func<string>> bodydate, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconsentStatement = null, Expression<Func<string>> bodyprivacyNotice = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodychannel = WorkflowExpression.Compile(bodychannel, nameof(bodychannel), required: true);
            var __workflow_bodyresponse = WorkflowExpression.Compile(bodyresponse, nameof(bodyresponse), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyconsentStatement = WorkflowExpression.Compile(bodyconsentStatement, nameof(bodyconsentStatement), required: false);
            var __workflow_bodyprivacyNotice = WorkflowExpression.Compile(bodyprivacyNotice, nameof(bodyprivacyNotice), required: false);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/consent/consents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                bodypropCount++;
                body["constituent_consent_response"] = ExpressionConverter.ConvertO(__workflow_bodyresponse);
                bodypropCount++;
                body["consent_date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodyconsentStatement != null)
                {
                    body["consent_statement"] = ExpressionConverter.ConvertO(__workflow_bodyconsentStatement);
                    bodypropCount++;
                }

                if (__workflow_bodyprivacyNotice != null)
                {
                    body["privacy_notice"] = ExpressionConverter.ConvertO(__workflow_bodyprivacyNotice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration> ListConstituentConsents(Expression<Func<string>> constituentId, Expression<Func<bool>> mostRecentOnly = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_mostRecentOnly = WorkflowExpression.Compile(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/consents", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(__workflow_mostRecentOnly);
                return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration> ListConstituentSolicitCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/constituentsolicitcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/constituentsolicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["solicit_code"] = ExpressionConverter.ConvertO(__workflow_bodysolicitCode);
                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituentsolicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysolicitCode != null)
                {
                    body["solicit_code"] = ExpressionConverter.ConvertO(__workflow_bodysolicitCode);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration> CreateConstituentAddress(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyaddressType, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: true);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddressLines = WorkflowExpression.Compile(bodyaddressLines, nameof(bodyaddressLines), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodysuburb = WorkflowExpression.Compile(bodysuburb, nameof(bodysuburb), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodyvalidFrom = WorkflowExpression.Compile(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            var __workflow_bodyvalidTo = WorkflowExpression.Compile(bodyvalidTo, nameof(bodyvalidTo), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartyear = WorkflowExpression.Compile(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndyear = WorkflowExpression.Compile(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLines != null)
                {
                    body["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLines);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysuburb != null)
                {
                    body["suburb"] = ExpressionConverter.ConvertO(__workflow_bodysuburb);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["information_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodycART != null)
                {
                    body["cart"] = ExpressionConverter.ConvertO(__workflow_bodycART);
                    bodypropCount++;
                }

                if (__workflow_bodylOT != null)
                {
                    body["lot"] = ExpressionConverter.ConvertO(__workflow_bodylOT);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidFrom != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyvalidFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidTo != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyvalidTo);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["preferred"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAddress(Expression<Func<string>> addressId, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var __workflow_addressId = WorkflowExpression.Compile(addressId, nameof(addressId), required: true);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddressLines = WorkflowExpression.Compile(bodyaddressLines, nameof(bodyaddressLines), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodysuburb = WorkflowExpression.Compile(bodysuburb, nameof(bodysuburb), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodyvalidFrom = WorkflowExpression.Compile(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            var __workflow_bodyvalidTo = WorkflowExpression.Compile(bodyvalidTo, nameof(bodyvalidTo), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartyear = WorkflowExpression.Compile(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndyear = WorkflowExpression.Compile(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/addresses/{0}", __workflow_addressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressType != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLines != null)
                {
                    body["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLines);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysuburb != null)
                {
                    body["suburb"] = ExpressionConverter.ConvertO(__workflow_bodysuburb);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["information_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodycART != null)
                {
                    body["cart"] = ExpressionConverter.ConvertO(__workflow_bodycART);
                    bodypropCount++;
                }

                if (__workflow_bodylOT != null)
                {
                    body["lot"] = ExpressionConverter.ConvertO(__workflow_bodylOT);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidFrom != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyvalidFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidTo != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyvalidTo);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["preferred"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration> CreateConstituentAlias(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyalias, Expression<Func<string>> bodytype = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/aliases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAlias(Expression<Func<string>> aliasId, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodytype = null)
        {
            var __workflow_aliasId = WorkflowExpression.Compile(aliasId, nameof(aliasId), required: true);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/aliases/{0}", __workflow_aliasId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyalias != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration> CreateConstituentCode(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyconstituentCode, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyconstituentCode = WorkflowExpression.Compile(bodyconstituentCode, nameof(bodyconstituentCode), required: true);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituentcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentCode);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentCode(Expression<Func<string>> constituentCodeId)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCode(Expression<Func<string>> constituentCodeId, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration> ListConstituents(Expression<Func<string>> listId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> constituentCode = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> customFieldCategory = null, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> sort = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_constituentCode = WorkflowExpression.Compile(constituentCode, nameof(constituentCode), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_customFieldCategory = WorkflowExpression.Compile(customFieldCategory, nameof(customFieldCategory), required: false);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_constituentCode != null)
                    callPayload.Queries["constituent_code"] = ExpressionConverter.Convert(__workflow_constituentCode);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_customFieldCategory != null)
                    callPayload.Queries["custom_field_category"] = ExpressionConverter.Convert(__workflow_customFieldCategory);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postal_code"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration> GetConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<int>> bodydeceasedDateday = null, Expression<Func<int>> bodydeceasedDatemonth = null, Expression<Func<int>> bodydeceasedDateyear = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyorganizationName = WorkflowExpression.Compile(bodyorganizationName, nameof(bodyorganizationName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyformerName = WorkflowExpression.Compile(bodyformerName, nameof(bodyformerName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodyrequestsNoEmail = WorkflowExpression.Compile(bodyrequestsNoEmail, nameof(bodyrequestsNoEmail), required: false);
            var __workflow_bodyisASolicitor = WorkflowExpression.Compile(bodyisASolicitor, nameof(bodyisASolicitor), required: false);
            var __workflow_bodynoValidAddresses = WorkflowExpression.Compile(bodynoValidAddresses, nameof(bodynoValidAddresses), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthplace = WorkflowExpression.Compile(bodybirthplace, nameof(bodybirthplace), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodytarget = WorkflowExpression.Compile(bodytarget, nameof(bodytarget), required: false);
            var __workflow_bodyincome = WorkflowExpression.Compile(bodyincome, nameof(bodyincome), required: false);
            var __workflow_bodyreceiptType = WorkflowExpression.Compile(bodyreceiptType, nameof(bodyreceiptType), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynumberOfEmployees = WorkflowExpression.Compile(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            var __workflow_bodymatchesGifts = WorkflowExpression.Compile(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            var __workflow_bodymatchingGiftFactor = WorkflowExpression.Compile(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            var __workflow_bodymatchingGiftPerGiftMinminMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            var __workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            var __workflow_bodymatchingGiftTotalMinminMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftNotes = WorkflowExpression.Compile(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            var __workflow_bodydeceased = WorkflowExpression.Compile(bodydeceased, nameof(bodydeceased), required: false);
            var __workflow_bodydeceasedDateday = WorkflowExpression.Compile(bodydeceasedDateday, nameof(bodydeceasedDateday), required: false);
            var __workflow_bodydeceasedDatemonth = WorkflowExpression.Compile(bodydeceasedDatemonth, nameof(bodydeceasedDatemonth), required: false);
            var __workflow_bodydeceasedDateyear = WorkflowExpression.Compile(bodydeceasedDateyear, nameof(bodydeceasedDateyear), required: false);
            var __workflow_bodyisMemorial = WorkflowExpression.Compile(bodyisMemorial, nameof(bodyisMemorial), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationName);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferred_name"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyformerName != null)
                {
                    body["former_name"] = ExpressionConverter.ConvertO(__workflow_bodyformerName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle2 != null)
                {
                    body["title_2"] = ExpressionConverter.ConvertO(__workflow_bodytitle2);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix2 != null)
                {
                    body["suffix_2"] = ExpressionConverter.ConvertO(__workflow_bodysuffix2);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyisASolicitor != null)
                {
                    body["is_solicitor"] = ExpressionConverter.ConvertO(__workflow_bodyisASolicitor);
                    bodypropCount++;
                }

                if (__workflow_bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = ExpressionConverter.ConvertO(__workflow_bodynoValidAddresses);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (__workflow_bodybirthdateday != null)
                {
                    birthdateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdateyear != null)
                {
                    birthdateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (__workflow_bodybirthplace != null)
                {
                    body["birthplace"] = ExpressionConverter.ConvertO(__workflow_bodybirthplace);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(__workflow_bodytarget);
                    bodypropCount++;
                }

                if (__workflow_bodyincome != null)
                {
                    body["income"] = ExpressionConverter.ConvertO(__workflow_bodyincome);
                    bodypropCount++;
                }

                if (__workflow_bodyreceiptType != null)
                {
                    body["receipt_type"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptType);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodymatchesGifts != null)
                {
                    body["matches_gifts"] = ExpressionConverter.ConvertO(__workflow_bodymatchesGifts);
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (__workflow_bodydeceased != null)
                {
                    body["deceased"] = ExpressionConverter.ConvertO(__workflow_bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (__workflow_bodydeceasedDateday != null)
                {
                    deceasedDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDateday);
                    deceasedDateObjectpropCount++;
                }

                if (__workflow_bodydeceasedDatemonth != null)
                {
                    deceasedDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDatemonth);
                    deceasedDateObjectpropCount++;
                }

                if (__workflow_bodydeceasedDateyear != null)
                {
                    deceasedDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDateyear);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["deceased_date"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisMemorial != null)
                {
                    body["is_memorial"] = ExpressionConverter.ConvertO(__workflow_bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/addresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration> ListConstituentAliases(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/aliases", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration> ListConstituentAttachments(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/attachments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration> ListConstituentCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/constituentcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration> ListConstituentCustomFields(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/customfields", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/educations", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration> ListConstituentEmailAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/emailaddresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListConstituentFundraiserAssignments(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/fundraiserassignments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfMembershipRead, ApiConnectionActionConfiguration> ListConstituentMemberships(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfMembershipRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/memberships", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfMembershipRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiNameFormatSummaryRead, ApiConnectionActionConfiguration> GetConstituentNameFormatSummary(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiNameFormatSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/nameformats/summary", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiNameFormatSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration> ListConstituentNotes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/notes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration> ListConstituentOnlinePresences(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/onlinepresences", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration> ListConstituentPhones(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/phones", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProfilePictureRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentProfilePicture(Expression<Func<string>> constituentId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodythumbnailId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                bodypropCount++;
                body["document_id"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration> ListConstituentRelationships(Expression<Func<string>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/relationships", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConvertedConstituent, ApiConnectionActionConfiguration> ConvertToConstituent(Expression<Func<string>> nonConstituentId)
        {
            var __workflow_nonConstituentId = WorkflowExpression.Compile(nonConstituentId, nameof(nonConstituentId), required: true);
            return new DeferredBodyAction<ConstituentApiConvertedConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/convert/{0}", __workflow_nonConstituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiConvertedConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration> CreateConstituentAttachment(Expression<Func<string>> bodyconstituentId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration> CreateConstituentCustomField(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiDuplicateSearchResultCollection, ApiConnectionActionConfiguration> GetDuplicateSearchResults(Expression<Func<string>> lastOrgName, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> suffix = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<string[]>> email = null, Expression<Func<string[]>> phone = null, Expression<Func<bool>> searchIndividuals = null, Expression<Func<bool>> searchAliases = null, Expression<Func<bool>> searchContacts = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_lastOrgName = WorkflowExpression.Compile(lastOrgName, nameof(lastOrgName), required: true);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_middleName = WorkflowExpression.Compile(middleName, nameof(middleName), required: false);
            var __workflow_suffix = WorkflowExpression.Compile(suffix, nameof(suffix), required: false);
            var __workflow_addressBlock = WorkflowExpression.Compile(addressBlock, nameof(addressBlock), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_searchIndividuals = WorkflowExpression.Compile(searchIndividuals, nameof(searchIndividuals), required: false);
            var __workflow_searchAliases = WorkflowExpression.Compile(searchAliases, nameof(searchAliases), required: false);
            var __workflow_searchContacts = WorkflowExpression.Compile(searchContacts, nameof(searchContacts), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiDuplicateSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/duplicatesearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["last_org_name"] = ExpressionConverter.Convert(__workflow_lastOrgName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_middleName != null)
                    callPayload.Queries["middle_name"] = ExpressionConverter.Convert(__workflow_middleName);
                if (__workflow_suffix != null)
                    callPayload.Queries["suffix"] = ExpressionConverter.Convert(__workflow_suffix);
                if (__workflow_addressBlock != null)
                    callPayload.Queries["address_block"] = ExpressionConverter.Convert(__workflow_addressBlock);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                callPayload.Queries["search_individuals"] = Convert.ToString(true);
                if (__workflow_searchIndividuals != null)
                    callPayload.Queries["search_individuals"] = ExpressionConverter.Convert(__workflow_searchIndividuals);
                callPayload.Queries["search_aliases"] = Convert.ToString(false);
                if (__workflow_searchAliases != null)
                    callPayload.Queries["search_aliases"] = ExpressionConverter.Convert(__workflow_searchAliases);
                callPayload.Queries["search_contacts"] = Convert.ToString(false);
                if (__workflow_searchContacts != null)
                    callPayload.Queries["search_contacts"] = ExpressionConverter.Convert(__workflow_searchContacts);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiDuplicateSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration> SearchConstituent(Expression<Func<string>> searchText, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeInactive = null, Expression<Func<searchFieldInput>> searchField = null, Expression<Func<bool>> strictSearch = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_searchField = WorkflowExpression.Compile(searchField, nameof(searchField), required: false);
            var __workflow_strictSearch = WorkflowExpression.Compile(strictSearch, nameof(strictSearch), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_searchField != null)
                    callPayload.Queries["search_field"] = ExpressionConverter.Convert(__workflow_searchField);
                if (__workflow_strictSearch != null)
                    callPayload.Queries["strict_search"] = ExpressionConverter.Convert(__workflow_strictSearch);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration> CreateConstituentEducation(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyschool, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyschool = WorkflowExpression.Compile(bodyschool, nameof(bodyschool), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateEnteredday = WorkflowExpression.Compile(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            var __workflow_bodydateEnteredmonth = WorkflowExpression.Compile(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            var __workflow_bodydateEnteredyear = WorkflowExpression.Compile(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            var __workflow_bodydateLeftday = WorkflowExpression.Compile(bodydateLeftday, nameof(bodydateLeftday), required: false);
            var __workflow_bodydateLeftmonth = WorkflowExpression.Compile(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            var __workflow_bodydateLeftyear = WorkflowExpression.Compile(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodygPA = WorkflowExpression.Compile(bodygPA, nameof(bodygPA), required: false);
            var __workflow_bodysubjectOfStudy = WorkflowExpression.Compile(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodymajors = WorkflowExpression.Compile(bodymajors, nameof(bodymajors), required: false);
            var __workflow_bodyminors = WorkflowExpression.Compile(bodyminors, nameof(bodyminors), required: false);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodysocialOrganization = WorkflowExpression.Compile(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            var __workflow_bodyknownName = WorkflowExpression.Compile(bodyknownName, nameof(bodyknownName), required: false);
            var __workflow_bodyclassOfDegree = WorkflowExpression.Compile(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyregistrationNumber = WorkflowExpression.Compile(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/educations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["school"] = ExpressionConverter.ConvertO(__workflow_bodyschool);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_of"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (__workflow_bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodydateLeftday != null)
                {
                    dateLeftObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodygPA != null)
                {
                    body["gpa"] = ExpressionConverter.ConvertO(__workflow_bodygPA);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = ExpressionConverter.ConvertO(__workflow_bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodymajors != null)
                {
                    body["majors"] = ExpressionConverter.ConvertO(__workflow_bodymajors);
                    bodypropCount++;
                }

                if (__workflow_bodyminors != null)
                {
                    body["minors"] = ExpressionConverter.ConvertO(__workflow_bodyminors);
                    bodypropCount++;
                }

                if (__workflow_bodycampus != null)
                {
                    body["campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodysocialOrganization != null)
                {
                    body["social_organization"] = ExpressionConverter.ConvertO(__workflow_bodysocialOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyknownName != null)
                {
                    body["known_name"] = ExpressionConverter.ConvertO(__workflow_bodyknownName);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = ExpressionConverter.ConvertO(__workflow_bodyclassOfDegree);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationNumber != null)
                {
                    body["registration_number"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEducation(Expression<Func<string>> educationId, Expression<Func<string>> bodyschool = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var __workflow_educationId = WorkflowExpression.Compile(educationId, nameof(educationId), required: true);
            var __workflow_bodyschool = WorkflowExpression.Compile(bodyschool, nameof(bodyschool), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateEnteredday = WorkflowExpression.Compile(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            var __workflow_bodydateEnteredmonth = WorkflowExpression.Compile(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            var __workflow_bodydateEnteredyear = WorkflowExpression.Compile(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            var __workflow_bodydateLeftday = WorkflowExpression.Compile(bodydateLeftday, nameof(bodydateLeftday), required: false);
            var __workflow_bodydateLeftmonth = WorkflowExpression.Compile(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            var __workflow_bodydateLeftyear = WorkflowExpression.Compile(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodygPA = WorkflowExpression.Compile(bodygPA, nameof(bodygPA), required: false);
            var __workflow_bodysubjectOfStudy = WorkflowExpression.Compile(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodymajors = WorkflowExpression.Compile(bodymajors, nameof(bodymajors), required: false);
            var __workflow_bodyminors = WorkflowExpression.Compile(bodyminors, nameof(bodyminors), required: false);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodysocialOrganization = WorkflowExpression.Compile(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            var __workflow_bodyknownName = WorkflowExpression.Compile(bodyknownName, nameof(bodyknownName), required: false);
            var __workflow_bodyclassOfDegree = WorkflowExpression.Compile(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyregistrationNumber = WorkflowExpression.Compile(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/educations/{0}", __workflow_educationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyschool != null)
                {
                    body["school"] = ExpressionConverter.ConvertO(__workflow_bodyschool);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_of"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (__workflow_bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodydateLeftday != null)
                {
                    dateLeftObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodygPA != null)
                {
                    body["gpa"] = ExpressionConverter.ConvertO(__workflow_bodygPA);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = ExpressionConverter.ConvertO(__workflow_bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodymajors != null)
                {
                    body["majors"] = ExpressionConverter.ConvertO(__workflow_bodymajors);
                    bodypropCount++;
                }

                if (__workflow_bodyminors != null)
                {
                    body["minors"] = ExpressionConverter.ConvertO(__workflow_bodyminors);
                    bodypropCount++;
                }

                if (__workflow_bodycampus != null)
                {
                    body["campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodysocialOrganization != null)
                {
                    body["social_organization"] = ExpressionConverter.ConvertO(__workflow_bodysocialOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyknownName != null)
                {
                    body["known_name"] = ExpressionConverter.ConvertO(__workflow_bodyknownName);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = ExpressionConverter.ConvertO(__workflow_bodyclassOfDegree);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationNumber != null)
                {
                    body["registration_number"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyemailType, Expression<Func<string>> bodyemailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: true);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotEmail != null)
                {
                    body["do_not_email"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemailType != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotEmail != null)
                {
                    body["do_not_email"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration> CreateConstituentNameFormat(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodycustomNameFormat = WorkflowExpression.Compile(bodycustomNameFormat, nameof(bodycustomNameFormat), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodycustomName = WorkflowExpression.Compile(bodycustomName, nameof(bodycustomName), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/nameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodycustomNameFormat != null)
                {
                    body["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodycustomNameFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    body["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodycustomName != null)
                {
                    body["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNameFormat(Expression<Func<string>> nameFormatId, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var __workflow_nameFormatId = WorkflowExpression.Compile(nameFormatId, nameof(nameFormatId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycustomNameFormat = WorkflowExpression.Compile(bodycustomNameFormat, nameof(bodycustomNameFormat), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodycustomName = WorkflowExpression.Compile(bodycustomName, nameof(bodycustomName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/nameformats/{0}", __workflow_nameFormatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycustomNameFormat != null)
                {
                    body["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodycustomNameFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    body["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodycustomName != null)
                {
                    body["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration> CreateConstituentNote(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyauthor = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyauthor = WorkflowExpression.Compile(bodyauthor, nameof(bodyauthor), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNote(Expression<Func<string>> noteId, Expression<Func<string>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_noteId = WorkflowExpression.Compile(noteId, nameof(noteId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/notes/{0}", __workflow_noteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration> CreateConstituentOnlinePresence(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<string>> bodylink, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/onlinepresences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentOnlinePresence(Expression<Func<string>> onlinePresenceId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodylink = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_onlinePresenceId = WorkflowExpression.Compile(onlinePresenceId, nameof(onlinePresenceId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/onlinepresences/{0}", __workflow_onlinePresenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration> CreateConstituentPhone(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<string>> bodynumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotCall != null)
                {
                    body["do_not_call"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCall);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPhone(Expression<Func<string>> phoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_phoneId = WorkflowExpression.Compile(phoneId, nameof(phoneId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/phones/{0}", __workflow_phoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotCall != null)
                {
                    body["do_not_call"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCall);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration> CreateConstituentPrimaryNameFormat(Expression<Func<string>> bodyconstituentId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodycustomNameFormat = WorkflowExpression.Compile(bodycustomNameFormat, nameof(bodycustomNameFormat), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodycustomName = WorkflowExpression.Compile(bodycustomName, nameof(bodycustomName), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedNameFormat, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/primarynameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["primary_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodycustomNameFormat != null)
                {
                    body["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodycustomNameFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    body["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodycustomName != null)
                {
                    body["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPrimaryNameFormat(Expression<Func<string>> primaryNameFormatId, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var __workflow_primaryNameFormatId = WorkflowExpression.Compile(primaryNameFormatId, nameof(primaryNameFormatId), required: true);
            var __workflow_bodycustomNameFormat = WorkflowExpression.Compile(bodycustomNameFormat, nameof(bodycustomNameFormat), required: false);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodycustomName = WorkflowExpression.Compile(bodycustomName, nameof(bodycustomName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/primarynameformats/{0}", __workflow_primaryNameFormatId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomNameFormat != null)
                {
                    body["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodycustomNameFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyformat != null)
                {
                    body["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                if (__workflow_bodycustomName != null)
                {
                    body["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentRelationship(Expression<Func<string>> relationshipId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null)
        {
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisSpouse = WorkflowExpression.Compile(bodyisSpouse, nameof(bodyisSpouse), required: false);
            var __workflow_bodyisConstituentHeadOfHousehold = WorkflowExpression.Compile(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            var __workflow_bodyisSpouseHeadOfHousehold = WorkflowExpression.Compile(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyisContact = WorkflowExpression.Compile(bodyisContact, nameof(bodyisContact), required: false);
            var __workflow_bodyisPrimaryBusiness = WorkflowExpression.Compile(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/relationships/{0}", __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouse != null)
                {
                    body["is_spouse"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyisContact != null)
                {
                    body["is_organization_contact"] = ExpressionConverter.ConvertO(__workflow_bodyisContact);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["organization_contact_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyreligion = null, Expression<Func<bool>> bodyprimaryAddresseecustomAddressee = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeFormat = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeCustomName = null, Expression<Func<bool>> bodyprimarySalutationcustomSalutation = null, Expression<Func<string>> bodyprimarySalutationsalutationFormat = null, Expression<Func<string>> bodyprimarySalutationsalutationCustomName = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyaddresstype = WorkflowExpression.Compile(bodyaddresstype, nameof(bodyaddresstype), required: true);
            var __workflow_bodyphonetype = WorkflowExpression.Compile(bodyphonetype, nameof(bodyphonetype), required: true);
            var __workflow_bodyphonenumber = WorkflowExpression.Compile(bodyphonenumber, nameof(bodyphonenumber), required: true);
            var __workflow_bodyemailtype = WorkflowExpression.Compile(bodyemailtype, nameof(bodyemailtype), required: true);
            var __workflow_bodyemailaddress = WorkflowExpression.Compile(bodyemailaddress, nameof(bodyemailaddress), required: true);
            var __workflow_bodyonlinePresencetype = WorkflowExpression.Compile(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            var __workflow_bodyonlinePresenceaddress = WorkflowExpression.Compile(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresslines = WorkflowExpression.Compile(bodyaddresslines, nameof(bodyaddresslines), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddresssuburb = WorkflowExpression.Compile(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddressstart = WorkflowExpression.Compile(bodyaddressstart, nameof(bodyaddressstart), required: false);
            var __workflow_bodyaddressend = WorkflowExpression.Compile(bodyaddressend, nameof(bodyaddressend), required: false);
            var __workflow_bodyphoneisPrimary = WorkflowExpression.Compile(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            var __workflow_bodyemailisPrimary = WorkflowExpression.Compile(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            var __workflow_bodyonlinePresenceisPrimary = WorkflowExpression.Compile(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyformerName = WorkflowExpression.Compile(bodyformerName, nameof(bodyformerName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodyrequestsNoEmail = WorkflowExpression.Compile(bodyrequestsNoEmail, nameof(bodyrequestsNoEmail), required: false);
            var __workflow_bodyisASolicitor = WorkflowExpression.Compile(bodyisASolicitor, nameof(bodyisASolicitor), required: false);
            var __workflow_bodynoValidAddresses = WorkflowExpression.Compile(bodynoValidAddresses, nameof(bodynoValidAddresses), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthplace = WorkflowExpression.Compile(bodybirthplace, nameof(bodybirthplace), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodytarget = WorkflowExpression.Compile(bodytarget, nameof(bodytarget), required: false);
            var __workflow_bodyincome = WorkflowExpression.Compile(bodyincome, nameof(bodyincome), required: false);
            var __workflow_bodyreceiptType = WorkflowExpression.Compile(bodyreceiptType, nameof(bodyreceiptType), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyprimaryAddresseecustomAddressee = WorkflowExpression.Compile(bodyprimaryAddresseecustomAddressee, nameof(bodyprimaryAddresseecustomAddressee), required: false);
            var __workflow_bodyprimaryAddresseeaddresseeFormat = WorkflowExpression.Compile(bodyprimaryAddresseeaddresseeFormat, nameof(bodyprimaryAddresseeaddresseeFormat), required: false);
            var __workflow_bodyprimaryAddresseeaddresseeCustomName = WorkflowExpression.Compile(bodyprimaryAddresseeaddresseeCustomName, nameof(bodyprimaryAddresseeaddresseeCustomName), required: false);
            var __workflow_bodyprimarySalutationcustomSalutation = WorkflowExpression.Compile(bodyprimarySalutationcustomSalutation, nameof(bodyprimarySalutationcustomSalutation), required: false);
            var __workflow_bodyprimarySalutationsalutationFormat = WorkflowExpression.Compile(bodyprimarySalutationsalutationFormat, nameof(bodyprimarySalutationsalutationFormat), required: false);
            var __workflow_bodyprimarySalutationsalutationCustomName = WorkflowExpression.Compile(bodyprimarySalutationsalutationCustomName, nameof(bodyprimarySalutationsalutationCustomName), required: false);
            var __workflow_bodyisMemorial = WorkflowExpression.Compile(bodyisMemorial, nameof(bodyisMemorial), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Individual";
                bodypropCount++;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddresstype);
                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslines != null)
                {
                    addressObject["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = ExpressionConverter.ConvertO(__workflow_bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstart != null)
                {
                    addressObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressend != null)
                {
                    addressObject["end"] = ExpressionConverter.ConvertO(__workflow_bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyphonenumber);
                if (__workflow_bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress);
                if (__workflow_bodyemailisPrimary != null)
                {
                    emailObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceaddress);
                if (__workflow_bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferred_name"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyformerName != null)
                {
                    body["former_name"] = ExpressionConverter.ConvertO(__workflow_bodyformerName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle2 != null)
                {
                    body["title_2"] = ExpressionConverter.ConvertO(__workflow_bodytitle2);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix2 != null)
                {
                    body["suffix_2"] = ExpressionConverter.ConvertO(__workflow_bodysuffix2);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyisASolicitor != null)
                {
                    body["is_solicitor"] = ExpressionConverter.ConvertO(__workflow_bodyisASolicitor);
                    bodypropCount++;
                }

                if (__workflow_bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = ExpressionConverter.ConvertO(__workflow_bodynoValidAddresses);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (__workflow_bodybirthdateday != null)
                {
                    birthdateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdateyear != null)
                {
                    birthdateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (__workflow_bodybirthplace != null)
                {
                    body["birthplace"] = ExpressionConverter.ConvertO(__workflow_bodybirthplace);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(__workflow_bodytarget);
                    bodypropCount++;
                }

                if (__workflow_bodyincome != null)
                {
                    body["income"] = ExpressionConverter.ConvertO(__workflow_bodyincome);
                    bodypropCount++;
                }

                if (__workflow_bodyreceiptType != null)
                {
                    body["receipt_type"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptType);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                var primaryAddresseeObject = new JObject();
                var primaryAddresseeObjectpropCount = 0;
                if (__workflow_bodyprimaryAddresseecustomAddressee != null)
                {
                    primaryAddresseeObject["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseecustomAddressee);
                    primaryAddresseeObjectpropCount++;
                }

                if (__workflow_bodyprimaryAddresseeaddresseeFormat != null)
                {
                    primaryAddresseeObject["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseeaddresseeFormat);
                    primaryAddresseeObjectpropCount++;
                }

                if (__workflow_bodyprimaryAddresseeaddresseeCustomName != null)
                {
                    primaryAddresseeObject["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseeaddresseeCustomName);
                    primaryAddresseeObjectpropCount++;
                }

                if (primaryAddresseeObjectpropCount > 0)
                {
                    body["primary_addressee"] = primaryAddresseeObject;
                    bodypropCount++;
                }

                var primarySalutationObject = new JObject();
                var primarySalutationObjectpropCount = 0;
                if (__workflow_bodyprimarySalutationcustomSalutation != null)
                {
                    primarySalutationObject["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationcustomSalutation);
                    primarySalutationObjectpropCount++;
                }

                if (__workflow_bodyprimarySalutationsalutationFormat != null)
                {
                    primarySalutationObject["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationsalutationFormat);
                    primarySalutationObjectpropCount++;
                }

                if (__workflow_bodyprimarySalutationsalutationCustomName != null)
                {
                    primarySalutationObject["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationsalutationCustomName);
                    primarySalutationObjectpropCount++;
                }

                if (primarySalutationObjectpropCount > 0)
                {
                    body["primary_salutation"] = primarySalutationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisMemorial != null)
                {
                    body["is_memorial"] = ExpressionConverter.ConvertO(__workflow_bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration> CreateIndividualRelationship(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyrelationId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyrelationId = WorkflowExpression.Compile(bodyrelationId, nameof(bodyrelationId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisSpouse = WorkflowExpression.Compile(bodyisSpouse, nameof(bodyisSpouse), required: false);
            var __workflow_bodyisConstituentHeadOfHousehold = WorkflowExpression.Compile(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            var __workflow_bodyisSpouseHeadOfHousehold = WorkflowExpression.Compile(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individualrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = ExpressionConverter.ConvertO(__workflow_bodyrelationId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouse != null)
                {
                    body["is_spouse"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyaddresstype = WorkflowExpression.Compile(bodyaddresstype, nameof(bodyaddresstype), required: true);
            var __workflow_bodyphonetype = WorkflowExpression.Compile(bodyphonetype, nameof(bodyphonetype), required: true);
            var __workflow_bodyphonenumber = WorkflowExpression.Compile(bodyphonenumber, nameof(bodyphonenumber), required: true);
            var __workflow_bodyemailtype = WorkflowExpression.Compile(bodyemailtype, nameof(bodyemailtype), required: true);
            var __workflow_bodyemailaddress = WorkflowExpression.Compile(bodyemailaddress, nameof(bodyemailaddress), required: true);
            var __workflow_bodyonlinePresencetype = WorkflowExpression.Compile(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            var __workflow_bodyonlinePresenceaddress = WorkflowExpression.Compile(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresslines = WorkflowExpression.Compile(bodyaddresslines, nameof(bodyaddresslines), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddresssuburb = WorkflowExpression.Compile(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddressstart = WorkflowExpression.Compile(bodyaddressstart, nameof(bodyaddressstart), required: false);
            var __workflow_bodyaddressend = WorkflowExpression.Compile(bodyaddressend, nameof(bodyaddressend), required: false);
            var __workflow_bodyphoneisPrimary = WorkflowExpression.Compile(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            var __workflow_bodyemailisPrimary = WorkflowExpression.Compile(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            var __workflow_bodyonlinePresenceisPrimary = WorkflowExpression.Compile(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodyrequestsNoEmail = WorkflowExpression.Compile(bodyrequestsNoEmail, nameof(bodyrequestsNoEmail), required: false);
            var __workflow_bodyisASolicitor = WorkflowExpression.Compile(bodyisASolicitor, nameof(bodyisASolicitor), required: false);
            var __workflow_bodynoValidAddresses = WorkflowExpression.Compile(bodynoValidAddresses, nameof(bodynoValidAddresses), required: false);
            var __workflow_bodytarget = WorkflowExpression.Compile(bodytarget, nameof(bodytarget), required: false);
            var __workflow_bodyincome = WorkflowExpression.Compile(bodyincome, nameof(bodyincome), required: false);
            var __workflow_bodyreceiptType = WorkflowExpression.Compile(bodyreceiptType, nameof(bodyreceiptType), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynumberOfEmployees = WorkflowExpression.Compile(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            var __workflow_bodymatchesGifts = WorkflowExpression.Compile(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            var __workflow_bodymatchingGiftFactor = WorkflowExpression.Compile(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            var __workflow_bodymatchingGiftPerGiftMinminMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            var __workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            var __workflow_bodymatchingGiftTotalMinminMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftNotes = WorkflowExpression.Compile(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            var __workflow_bodyisMemorial = WorkflowExpression.Compile(bodyisMemorial, nameof(bodyisMemorial), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Organization";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddresstype);
                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslines != null)
                {
                    addressObject["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = ExpressionConverter.ConvertO(__workflow_bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstart != null)
                {
                    addressObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressend != null)
                {
                    addressObject["end"] = ExpressionConverter.ConvertO(__workflow_bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyphonenumber);
                if (__workflow_bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress);
                if (__workflow_bodyemailisPrimary != null)
                {
                    emailObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceaddress);
                if (__workflow_bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = ExpressionConverter.ConvertO(__workflow_bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyisASolicitor != null)
                {
                    body["is_solicitor"] = ExpressionConverter.ConvertO(__workflow_bodyisASolicitor);
                    bodypropCount++;
                }

                if (__workflow_bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = ExpressionConverter.ConvertO(__workflow_bodynoValidAddresses);
                    bodypropCount++;
                }

                if (__workflow_bodytarget != null)
                {
                    body["target"] = ExpressionConverter.ConvertO(__workflow_bodytarget);
                    bodypropCount++;
                }

                if (__workflow_bodyincome != null)
                {
                    body["income"] = ExpressionConverter.ConvertO(__workflow_bodyincome);
                    bodypropCount++;
                }

                if (__workflow_bodyreceiptType != null)
                {
                    body["receipt_type"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptType);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodymatchesGifts != null)
                {
                    body["matches_gifts"] = ExpressionConverter.ConvertO(__workflow_bodymatchesGifts);
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (__workflow_bodyisMemorial != null)
                {
                    body["is_memorial"] = ExpressionConverter.ConvertO(__workflow_bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration> CreateOrganizationRelationship(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyrelationId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyrelationId = WorkflowExpression.Compile(bodyrelationId, nameof(bodyrelationId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisContact = WorkflowExpression.Compile(bodyisContact, nameof(bodyisContact), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyisPrimaryBusiness = WorkflowExpression.Compile(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = ExpressionConverter.ConvertO(__workflow_bodyrelationId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisContact != null)
                {
                    body["is_organization_contact"] = ExpressionConverter.ConvertO(__workflow_bodyisContact);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["organization_contact_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration> CreateFundraiserAssignment(Expression<Func<string>> bodyfundraiserId, Expression<Func<string>> bodyconstituentId, Expression<Func<double>> bodyamountamount, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyassignmentStarts = null, Expression<Func<string>> bodyassignmentEnds = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<string>> bodyappealId = null)
        {
            var __workflow_bodyfundraiserId = WorkflowExpression.Compile(bodyfundraiserId, nameof(bodyfundraiserId), required: true);
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyassignmentStarts = WorkflowExpression.Compile(bodyassignmentStarts, nameof(bodyassignmentStarts), required: false);
            var __workflow_bodyassignmentEnds = WorkflowExpression.Compile(bodyassignmentEnds, nameof(bodyassignmentEnds), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyappealId = WorkflowExpression.Compile(bodyappealId, nameof(bodyappealId), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/fundraisers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserId);
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentStarts != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentStarts);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentEnds != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentEnds);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyappealId != null)
                {
                    body["appeal_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListFundraiserAssignments(Expression<Func<string>> fundraiserId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_fundraiserId = WorkflowExpression.Compile(fundraiserId, nameof(fundraiserId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/fundraisers/{0}/assignments", __workflow_fundraiserId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentIdMap, ApiConnectionActionConfiguration> GetConstituentIdFromLookupId(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiConstituentIdMap, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/constituentidmap/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiConstituentIdMap>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentSearchResultCollection, ApiConnectionActionConfiguration> SearchConstituentEnhanced(Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> email = null, Expression<Func<string>> phoneNumber = null, Expression<Func<int>> limit = null, Expression<Func<string>> addressLines = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<bool>> includeAlias = null, Expression<Func<string>> aliasType = null, Expression<Func<bool>> includeMaidenName = null)
        {
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_addressLines = WorkflowExpression.Compile(addressLines, nameof(addressLines), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_includeAlias = WorkflowExpression.Compile(includeAlias, nameof(includeAlias), required: false);
            var __workflow_aliasType = WorkflowExpression.Compile(aliasType, nameof(aliasType), required: false);
            var __workflow_includeMaidenName = WorkflowExpression.Compile(includeMaidenName, nameof(includeMaidenName), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiConstituentSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/constituents/customsearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_addressLines != null)
                    callPayload.Queries["address_lines"] = ExpressionConverter.Convert(__workflow_addressLines);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_includeAlias != null)
                    callPayload.Queries["include_alias"] = ExpressionConverter.Convert(__workflow_includeAlias);
                if (__workflow_aliasType != null)
                    callPayload.Queries["alias_type"] = ExpressionConverter.Convert(__workflow_aliasType);
                if (__workflow_includeMaidenName != null)
                    callPayload.Queries["include_maiden_name"] = ExpressionConverter.Convert(__workflow_includeMaidenName);
                return new ApiConnectionAction<NXTDataIntegrationApiConstituentSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentTribute, ApiConnectionActionConfiguration> CreateConstituentTribute(Expression<Func<int>> bodyconstituentId, Expression<Func<int>> bodytributeType, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodydefaultFundId = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytributeType = WorkflowExpression.Compile(bodytributeType, nameof(bodytributeType), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodydefaultFundId = WorkflowExpression.Compile(bodydefaultFundId, nameof(bodydefaultFundId), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyactive = WorkflowExpression.Compile(bodyactive, nameof(bodyactive), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedConstituentTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_record_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["tribute_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytributeType);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var endDateObject = new JObject();
                var endDateObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endDateObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endDateObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodydefaultFundId != null)
                {
                    body["default_fund_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultFundId);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyactive != null)
                {
                    body["is_active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTribute, ApiConnectionActionConfiguration> GetConstituentTribute(Expression<Func<string>> tributeId)
        {
            var __workflow_tributeId = WorkflowExpression.Compile(tributeId, nameof(tributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/{0}", __workflow_tributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTributeAcknowledgee, ApiConnectionActionConfiguration> CreateTributeAcknowledgee(Expression<Func<int>> bodytributeId, Expression<Func<int>> bodyrelationshipId = null, Expression<Func<int>> bodyletterId = null)
        {
            var __workflow_bodytributeId = WorkflowExpression.Compile(bodytributeId, nameof(bodytributeId), required: true);
            var __workflow_bodyrelationshipId = WorkflowExpression.Compile(bodyrelationshipId, nameof(bodyrelationshipId), required: false);
            var __workflow_bodyletterId = WorkflowExpression.Compile(bodyletterId, nameof(bodyletterId), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedTributeAcknowledgee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute/acknowledgee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tribute_id"] = ExpressionConverter.ConvertO(__workflow_bodytributeId);
                if (__workflow_bodyrelationshipId != null)
                {
                    body["relationship_id"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipId);
                    bodypropCount++;
                }

                if (__workflow_bodyletterId != null)
                {
                    body["letter_id"] = ExpressionConverter.ConvertO(__workflow_bodyletterId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NXTDataIntegrationApiCreatedTributeAcknowledgee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeCollection, ApiConnectionActionConfiguration> ListConstituentTributes(Expression<Func<int>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/constituent/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeAcknowledgeeCollection, ApiConnectionActionConfiguration> ListTributeAcknowledgees(Expression<Func<int>> tributeId)
        {
            var __workflow_tributeId = WorkflowExpression.Compile(tributeId, nameof(tributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiTributeAcknowledgeeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/tribute/{0}/acknowledgees", __workflow_tributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiTributeAcknowledgeeCollection>(callPayload);
            });
        }
    }

    public class BlackbaudconstituentTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyresponseInput
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool NoValidAddresses { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public ConstituentApiConstituentReadReceiptTypeType ReceiptType { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMinMatchPerGiftType MinMatchPerGift { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMaxMatchPerGiftType MaxMatchPerGift { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMinMatchPerConstitType MinMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMaxMatchPerConstitType MaxMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("is_memorial")]
        public bool IsMemorial { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class ConstituentApiConstituentReadMinMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMinMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceiptTypeInput
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIdValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public ConstituentApiConstituentCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiConstituentCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfMembershipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiMembershipRead[] Value { get; set; }
    }

    public class ConstituentApiMembershipRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("standing")]
        public ConstituentApiMembershipReadStandingType Standing { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("joined")]
        public string Joined { get; set; }

        [JsonProperty("dues")]
        public ConstituentApiMembershipReadDuesType Dues { get; set; }

        [JsonProperty("members")]
        public ConstituentApiMembershipMemberRead[] Members { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiMembershipReadStandingType
    {
        New,
        Active,
        Lapsed,
        Dropped
    }

    public class ConstituentApiMembershipReadDuesType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiMembershipMemberRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryMember { get; set; }
    }

    public class ConstituentApiNameFormatSummaryRead
    {
        [JsonProperty("primary_addressee")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeType PrimaryAddressee { get; set; }

        [JsonProperty("primary_salutation")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationType PrimarySalutation { get; set; }

        [JsonProperty("additional_name_formats")]
        public ConstituentApiNameFormatRead[] AdditionalNameFormats { get; set; }
    }

    public class ConstituentApiNameFormatSummaryReadPrimaryAddresseeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatSummaryReadPrimarySalutationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConvertedConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiDuplicateSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiDuplicateSearchResult[] Value { get; set; }
    }

    public class ConstituentApiDuplicateSearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("formatted_address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupId { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId,
        [EnumMember(Value = "email_address")]
        EmailAddress
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedNameFormat
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentIdMap
    {
        [JsonProperty("system_record_id")]
        public int Id { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultCollection
    {
        [JsonProperty("results")]
        public NXTDataIntegrationApiConstituentSearchResult[] Results { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResult
    {
        [JsonProperty("record_id")]
        public int Id { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupId { get; set; }

        [JsonProperty("key_indicator")]
        public string KeyIndicator { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("maiden_name")]
        public string FormerName { get; set; }

        [JsonProperty("title1")]
        public string Title1 { get; set; }

        [JsonProperty("suffix1")]
        public string Suffix1 { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth_date")]
        public NXTDataIntegrationApiConstituentSearchResultBirthdateType Birthdate { get; set; }

        [JsonProperty("spouse_first_name")]
        public string SpouseFirstName { get; set; }

        [JsonProperty("spouse_last_name")]
        public string SpouseLastName { get; set; }

        [JsonProperty("org_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("address_block")]
        public string AddressBlock { get; set; }

        [JsonProperty("address_city_state")]
        public string CityAndState { get; set; }

        [JsonProperty("address_post_code")]
        public string PostalCode { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("matched_alias")]
        public string MatchedAlias { get; set; }

        [JsonProperty("matched_email")]
        public string MatchedEmail { get; set; }

        [JsonProperty("matched_phone")]
        public string MatchedPhone { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("is_deceased")]
        public bool IsDeceased { get; set; }

        [JsonProperty("is_inactive")]
        public bool IsInactive { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedConstituentTribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class NXTDataIntegrationApiTribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("constituent_record_id")]
        public int ConstituentId { get; set; }

        [JsonProperty("tribute_type_name")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_type_id")]
        public int TributeTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public NXTDataIntegrationApiTributeStartType Start { get; set; }

        [JsonProperty("end_date")]
        public NXTDataIntegrationApiTributeEndType End { get; set; }

        [JsonProperty("default_fund_id")]
        public int DefaultFundId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_active")]
        public bool Active { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class NXTDataIntegrationApiTributeStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiTributeEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedTributeAcknowledgee
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class NXTDataIntegrationApiTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTribute[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgeeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTributeAcknowledgee[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeId { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipId { get; set; }

        [JsonProperty("letter")]
        public int LetterId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent;

    public partial class WorkflowManagedActions
    {
        public BlackbaudconstituentActions Blackbaudconstituent(string connectionId) => new BlackbaudconstituentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudconstituentTriggers Blackbaudconstituent(string connectionId) => new BlackbaudconstituentTriggers(connectionId);
    }
}