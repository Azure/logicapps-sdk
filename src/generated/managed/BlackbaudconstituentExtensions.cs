//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudconstituentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent> CreateConstituentConsent(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodychannel, Expression<Func<bodyresponseInput>> bodyresponse, Expression<Func<string>> bodydate, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconsentStatement = null, Expression<Func<string>> bodyprivacyNotice = null)
        {
            var apiCallPath = "/commpref/v1/consent/consents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["channel"] = ExpressionConverter.ConvertO(bodychannel);
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            bodypropCount++;
            body["constituent_consent_response"] = ExpressionConverter.ConvertO(bodyresponse);
            bodypropCount++;
            body["consent_date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodyconsentStatement != null)
            {
                body["consent_statement"] = ExpressionConverter.ConvertO(bodyconsentStatement);
                bodypropCount++;
            }

            if (bodyprivacyNotice != null)
            {
                body["privacy_notice"] = ExpressionConverter.ConvertO(bodyprivacyNotice);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection> ListConstituentConsents(Expression<Func<string>> constituentId, Expression<Func<bool>> mostRecentOnly = null)
        {
            var apiCallPath = String.Format("/commpref/v1/constituents/{0}/consents", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mostRecentOnly != null)
                callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(mostRecentOnly);
            return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection> ListConstituentSolicitCodes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/commpref/v1/constituents/{0}/constituentsolicitcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = "/commpref/v1/constituentsolicitcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["solicit_code"] = ExpressionConverter.ConvertO(bodysolicitCode);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = String.Format("/commpref/v1/constituentsolicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysolicitCode != null)
            {
                body["solicit_code"] = ExpressionConverter.ConvertO(bodysolicitCode);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress> CreateConstituentAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyaddressType, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var apiCallPath = "/constituent/v1/addresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodyaddressType);
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_lines"] = ExpressionConverter.ConvertO(bodyaddressLines);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodysuburb != null)
            {
                body["suburb"] = ExpressionConverter.ConvertO(bodysuburb);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["information_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = ExpressionConverter.ConvertO(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = ExpressionConverter.ConvertO(bodylOT);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
                bodypropCount++;
            }

            if (bodyvalidFrom != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyvalidFrom);
                bodypropCount++;
            }

            if (bodyvalidTo != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyvalidTo);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["preferred"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            var seasonal_startObject = new JObject();
            var seasonal_startObjectpropCount = 0;
            if (bodyseasonalStartday != null)
            {
                seasonal_startObject["d"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartmonth != null)
            {
                seasonal_startObject["m"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartyear != null)
            {
                seasonal_startObject["y"] = ExpressionConverter.ConvertO(bodyseasonalStartyear);
                seasonal_startObjectpropCount++;
            }

            if (seasonal_startObjectpropCount > 0)
            {
                body["seasonal_start"] = seasonal_startObject;
                bodypropCount++;
            }

            var seasonal_endObject = new JObject();
            var seasonal_endObjectpropCount = 0;
            if (bodyseasonalEndday != null)
            {
                seasonal_endObject["d"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndmonth != null)
            {
                seasonal_endObject["m"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndyear != null)
            {
                seasonal_endObject["y"] = ExpressionConverter.ConvertO(bodyseasonalEndyear);
                seasonal_endObjectpropCount++;
            }

            if (seasonal_endObjectpropCount > 0)
            {
                body["seasonal_end"] = seasonal_endObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAddress(Expression<Func<string>> addressId, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var apiCallPath = String.Format("/constituent/v1/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaddressType != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_lines"] = ExpressionConverter.ConvertO(bodyaddressLines);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodysuburb != null)
            {
                body["suburb"] = ExpressionConverter.ConvertO(bodysuburb);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["information_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = ExpressionConverter.ConvertO(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = ExpressionConverter.ConvertO(bodylOT);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
                bodypropCount++;
            }

            if (bodyvalidFrom != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyvalidFrom);
                bodypropCount++;
            }

            if (bodyvalidTo != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyvalidTo);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["preferred"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            var seasonal_startObject = new JObject();
            var seasonal_startObjectpropCount = 0;
            if (bodyseasonalStartday != null)
            {
                seasonal_startObject["d"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartmonth != null)
            {
                seasonal_startObject["m"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonal_startObjectpropCount++;
            }

            if (bodyseasonalStartyear != null)
            {
                seasonal_startObject["y"] = ExpressionConverter.ConvertO(bodyseasonalStartyear);
                seasonal_startObjectpropCount++;
            }

            if (seasonal_startObjectpropCount > 0)
            {
                body["seasonal_start"] = seasonal_startObject;
                bodypropCount++;
            }

            var seasonal_endObject = new JObject();
            var seasonal_endObjectpropCount = 0;
            if (bodyseasonalEndday != null)
            {
                seasonal_endObject["d"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndmonth != null)
            {
                seasonal_endObject["m"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonal_endObjectpropCount++;
            }

            if (bodyseasonalEndyear != null)
            {
                seasonal_endObject["y"] = ExpressionConverter.ConvertO(bodyseasonalEndyear);
                seasonal_endObjectpropCount++;
            }

            if (seasonal_endObjectpropCount > 0)
            {
                body["seasonal_end"] = seasonal_endObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias> CreateConstituentAlias(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyalias, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = "/constituent/v1/aliases";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyalias);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAlias(Expression<Func<string>> aliasId, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodytype = null)
        {
            var apiCallPath = String.Format("/constituent/v1/aliases/{0}", ExpressionConverter.ConvertWithUrlEncoding(aliasId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyalias != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyalias);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode> CreateConstituentCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyconstituentCode, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = "/constituent/v1/constituentcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodyconstituentCode);
            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction DeleteConstituentCode(Expression<Func<string>> constituentCodeId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituentcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentCode(Expression<Func<string>> constituentCodeId, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituentcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCodeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead> ListConstituents(Expression<Func<string>> listId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> constituentCode = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> customFieldCategory = null, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/constituent/v1/constituents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (constituentCode != null)
                callPayload.Queries["constituent_code"] = ExpressionConverter.Convert(constituentCode);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(constituentId);
            if (customFieldCategory != null)
                callPayload.Queries["custom_field_category"] = ExpressionConverter.Convert(customFieldCategory);
            if (fundraiserStatus != null)
                callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(fundraiserStatus);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (postalCode != null)
                callPayload.Queries["postal_code"] = ExpressionConverter.Convert(postalCode);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead> GetConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiConstituentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<int>> bodydeceasedDateday = null, Expression<Func<int>> bodydeceasedDatemonth = null, Expression<Func<int>> bodydeceasedDateyear = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["last"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodyorganizationName != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyorganizationName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodypreferredName != null)
            {
                body["preferred_name"] = ExpressionConverter.ConvertO(bodypreferredName);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyformerName != null)
            {
                body["former_name"] = ExpressionConverter.ConvertO(bodyformerName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = ExpressionConverter.ConvertO(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = ExpressionConverter.ConvertO(bodysuffix2);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodyrequestsNoEmail != null)
            {
                body["requests_no_email"] = ExpressionConverter.ConvertO(bodyrequestsNoEmail);
                bodypropCount++;
            }

            if (bodyisASolicitor != null)
            {
                body["is_solicitor"] = ExpressionConverter.ConvertO(bodyisASolicitor);
                bodypropCount++;
            }

            if (bodynoValidAddresses != null)
            {
                body["no_valid_address"] = ExpressionConverter.ConvertO(bodynoValidAddresses);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            var birthdateObject = new JObject();
            var birthdateObjectpropCount = 0;
            if (bodybirthdateday != null)
            {
                birthdateObject["d"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthdateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthdateObject["m"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthdateObjectpropCount++;
            }

            if (bodybirthdateyear != null)
            {
                birthdateObject["y"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthdateObjectpropCount++;
            }

            if (birthdateObjectpropCount > 0)
            {
                body["birthdate"] = birthdateObject;
                bodypropCount++;
            }

            if (bodybirthplace != null)
            {
                body["birthplace"] = ExpressionConverter.ConvertO(bodybirthplace);
                bodypropCount++;
            }

            if (bodyethnicity != null)
            {
                body["ethnicity"] = ExpressionConverter.ConvertO(bodyethnicity);
                bodypropCount++;
            }

            if (bodytarget != null)
            {
                body["target"] = ExpressionConverter.ConvertO(bodytarget);
                bodypropCount++;
            }

            if (bodyincome != null)
            {
                body["income"] = ExpressionConverter.ConvertO(bodyincome);
                bodypropCount++;
            }

            if (bodyreceiptType != null)
            {
                body["receipt_type"] = ExpressionConverter.ConvertO(bodyreceiptType);
                bodypropCount++;
            }

            if (bodyreligion != null)
            {
                body["religion"] = ExpressionConverter.ConvertO(bodyreligion);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynumberOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynumberOfEmployees);
                bodypropCount++;
            }

            if (bodymatchesGifts != null)
            {
                body["matches_gifts"] = ExpressionConverter.ConvertO(bodymatchesGifts);
                bodypropCount++;
            }

            if (bodymatchingGiftFactor != null)
            {
                body["matching_gift_factor"] = ExpressionConverter.ConvertO(bodymatchingGiftFactor);
                bodypropCount++;
            }

            var matching_gift_per_gift_minObject = new JObject();
            var matching_gift_per_gift_minObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
            {
                matching_gift_per_gift_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMinminMatchPerGift);
                matching_gift_per_gift_minObjectpropCount++;
            }

            if (matching_gift_per_gift_minObjectpropCount > 0)
            {
                body["matching_gift_per_gift_min"] = matching_gift_per_gift_minObject;
                bodypropCount++;
            }

            var matching_gift_per_gift_maxObject = new JObject();
            var matching_gift_per_gift_maxObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
            {
                matching_gift_per_gift_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                matching_gift_per_gift_maxObjectpropCount++;
            }

            if (matching_gift_per_gift_maxObjectpropCount > 0)
            {
                body["matching_gift_per_gift_max"] = matching_gift_per_gift_maxObject;
                bodypropCount++;
            }

            var matching_gift_total_minObject = new JObject();
            var matching_gift_total_minObjectpropCount = 0;
            if (bodymatchingGiftTotalMinminMatchPerConstit != null)
            {
                matching_gift_total_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMinminMatchPerConstit);
                matching_gift_total_minObjectpropCount++;
            }

            if (matching_gift_total_minObjectpropCount > 0)
            {
                body["matching_gift_total_min"] = matching_gift_total_minObject;
                bodypropCount++;
            }

            var matching_gift_total_maxObject = new JObject();
            var matching_gift_total_maxObjectpropCount = 0;
            if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
            {
                matching_gift_total_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                matching_gift_total_maxObjectpropCount++;
            }

            if (matching_gift_total_maxObjectpropCount > 0)
            {
                body["matching_gift_total_max"] = matching_gift_total_maxObject;
                bodypropCount++;
            }

            if (bodymatchingGiftNotes != null)
            {
                body["matching_gift_notes"] = ExpressionConverter.ConvertO(bodymatchingGiftNotes);
                bodypropCount++;
            }

            if (bodydeceased != null)
            {
                body["deceased"] = ExpressionConverter.ConvertO(bodydeceased);
                bodypropCount++;
            }

            var deceased_dateObject = new JObject();
            var deceased_dateObjectpropCount = 0;
            if (bodydeceasedDateday != null)
            {
                deceased_dateObject["d"] = ExpressionConverter.ConvertO(bodydeceasedDateday);
                deceased_dateObjectpropCount++;
            }

            if (bodydeceasedDatemonth != null)
            {
                deceased_dateObject["m"] = ExpressionConverter.ConvertO(bodydeceasedDatemonth);
                deceased_dateObjectpropCount++;
            }

            if (bodydeceasedDateyear != null)
            {
                deceased_dateObject["y"] = ExpressionConverter.ConvertO(bodydeceasedDateyear);
                deceased_dateObjectpropCount++;
            }

            if (deceased_dateObjectpropCount > 0)
            {
                body["deceased_date"] = deceased_dateObject;
                bodypropCount++;
            }

            if (bodyisMemorial != null)
            {
                body["is_memorial"] = ExpressionConverter.ConvertO(bodyisMemorial);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead> ListConstituentAliases(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/aliases", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead> ListConstituentAttachments(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead> ListConstituentCodes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/constituentcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead> ListConstituentCustomFields(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/educations", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead> ListConstituentEmailAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/emailaddresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead> ListConstituentFundraiserAssignments(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/fundraiserassignments", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfMembershipRead> ListConstituentMemberships(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/memberships", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfMembershipRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiNameFormatSummaryRead> GetConstituentNameFormatSummary(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/nameformats/summary", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiNameFormatSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead> ListConstituentNotes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead> ListConstituentOnlinePresences(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/onlinepresences", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead> ListConstituentPhones(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/phones", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiProfilePictureRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentProfilePicture(Expression<Func<string>> constituentId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodydocumentID, Expression<Func<string>> bodythumbnailID)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["document_id"] = ExpressionConverter.ConvertO(bodydocumentID);
            bodypropCount++;
            body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead> ListConstituentRelationships(Expression<Func<string>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/relationships", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConvertedConstituent> ConvertToConstituent(Expression<Func<string>> nonConstituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/convert/{0}", ExpressionConverter.ConvertWithUrlEncoding(nonConstituentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiConvertedConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment> CreateConstituentAttachment(Expression<Func<string>> bodyconstituentID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/constituent/v1/constituents/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField> CreateConstituentCustomField(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/constituent/v1/constituents/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiDuplicateSearchResultCollection> GetDuplicateSearchResults(Expression<Func<string>> lastOrgName, Expression<Func<string>> firstName = null, Expression<Func<string>> middleName = null, Expression<Func<string>> suffix = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<string[]>> email = null, Expression<Func<string[]>> phone = null, Expression<Func<bool>> searchIndividuals = null, Expression<Func<bool>> searchAliases = null, Expression<Func<bool>> searchContacts = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/constituent/v1/constituents/duplicatesearch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["last_org_name"] = ExpressionConverter.Convert(lastOrgName);
            if (firstName != null)
                callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
            if (middleName != null)
                callPayload.Queries["middle_name"] = ExpressionConverter.Convert(middleName);
            if (suffix != null)
                callPayload.Queries["suffix"] = ExpressionConverter.Convert(suffix);
            if (addressBlock != null)
                callPayload.Queries["address_block"] = ExpressionConverter.Convert(addressBlock);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = ExpressionConverter.Convert(postCode);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            callPayload.Queries["search_individuals"] = Convert.ToString(true);
            if (searchIndividuals != null)
                callPayload.Queries["search_individuals"] = ExpressionConverter.Convert(searchIndividuals);
            callPayload.Queries["search_aliases"] = Convert.ToString(false);
            if (searchAliases != null)
                callPayload.Queries["search_aliases"] = ExpressionConverter.Convert(searchAliases);
            callPayload.Queries["search_contacts"] = Convert.ToString(false);
            if (searchContacts != null)
                callPayload.Queries["search_contacts"] = ExpressionConverter.Convert(searchContacts);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConstituentApiDuplicateSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead> SearchConstituent(Expression<Func<string>> searchText, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeInactive = null, Expression<Func<searchFieldInput>> searchField = null, Expression<Func<bool>> strictSearch = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/constituent/v1/constituents/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (fundraiserStatus != null)
                callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(fundraiserStatus);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (searchField != null)
                callPayload.Queries["search_field"] = ExpressionConverter.Convert(searchField);
            if (strictSearch != null)
                callPayload.Queries["strict_search"] = ExpressionConverter.Convert(strictSearch);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation> CreateConstituentEducation(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyschool, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var apiCallPath = "/constituent/v1/educations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["school"] = ExpressionConverter.ConvertO(bodyschool);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_of"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var date_enteredObject = new JObject();
            var date_enteredObjectpropCount = 0;
            if (bodydateEnteredday != null)
            {
                date_enteredObject["d"] = ExpressionConverter.ConvertO(bodydateEnteredday);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredmonth != null)
            {
                date_enteredObject["m"] = ExpressionConverter.ConvertO(bodydateEnteredmonth);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredyear != null)
            {
                date_enteredObject["y"] = ExpressionConverter.ConvertO(bodydateEnteredyear);
                date_enteredObjectpropCount++;
            }

            if (date_enteredObjectpropCount > 0)
            {
                body["date_entered"] = date_enteredObject;
                bodypropCount++;
            }

            var date_leftObject = new JObject();
            var date_leftObjectpropCount = 0;
            if (bodydateLeftday != null)
            {
                date_leftObject["d"] = ExpressionConverter.ConvertO(bodydateLeftday);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftmonth != null)
            {
                date_leftObject["m"] = ExpressionConverter.ConvertO(bodydateLeftmonth);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftyear != null)
            {
                date_leftObject["y"] = ExpressionConverter.ConvertO(bodydateLeftyear);
                date_leftObjectpropCount++;
            }

            if (date_leftObjectpropCount > 0)
            {
                body["date_left"] = date_leftObject;
                bodypropCount++;
            }

            var date_graduatedObject = new JObject();
            var date_graduatedObjectpropCount = 0;
            if (bodydateGraduatedday != null)
            {
                date_graduatedObject["d"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                date_graduatedObject["m"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedyear != null)
            {
                date_graduatedObject["y"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                date_graduatedObjectpropCount++;
            }

            if (date_graduatedObjectpropCount > 0)
            {
                body["date_graduated"] = date_graduatedObject;
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodygPA != null)
            {
                body["gpa"] = ExpressionConverter.ConvertO(bodygPA);
                bodypropCount++;
            }

            if (bodysubjectOfStudy != null)
            {
                body["subject_of_study"] = ExpressionConverter.ConvertO(bodysubjectOfStudy);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodymajors != null)
            {
                body["majors"] = ExpressionConverter.ConvertO(bodymajors);
                bodypropCount++;
            }

            if (bodyminors != null)
            {
                body["minors"] = ExpressionConverter.ConvertO(bodyminors);
                bodypropCount++;
            }

            if (bodycampus != null)
            {
                body["campus"] = ExpressionConverter.ConvertO(bodycampus);
                bodypropCount++;
            }

            if (bodysocialOrganization != null)
            {
                body["social_organization"] = ExpressionConverter.ConvertO(bodysocialOrganization);
                bodypropCount++;
            }

            if (bodyknownName != null)
            {
                body["known_name"] = ExpressionConverter.ConvertO(bodyknownName);
                bodypropCount++;
            }

            if (bodyclassOfDegree != null)
            {
                body["class_of_degree"] = ExpressionConverter.ConvertO(bodyclassOfDegree);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyfaculty != null)
            {
                body["faculty"] = ExpressionConverter.ConvertO(bodyfaculty);
                bodypropCount++;
            }

            if (bodyregistrationNumber != null)
            {
                body["registration_number"] = ExpressionConverter.ConvertO(bodyregistrationNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentEducation(Expression<Func<string>> educationId, Expression<Func<string>> bodyschool = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var apiCallPath = String.Format("/constituent/v1/educations/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyschool != null)
            {
                body["school"] = ExpressionConverter.ConvertO(bodyschool);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_of"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var date_enteredObject = new JObject();
            var date_enteredObjectpropCount = 0;
            if (bodydateEnteredday != null)
            {
                date_enteredObject["d"] = ExpressionConverter.ConvertO(bodydateEnteredday);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredmonth != null)
            {
                date_enteredObject["m"] = ExpressionConverter.ConvertO(bodydateEnteredmonth);
                date_enteredObjectpropCount++;
            }

            if (bodydateEnteredyear != null)
            {
                date_enteredObject["y"] = ExpressionConverter.ConvertO(bodydateEnteredyear);
                date_enteredObjectpropCount++;
            }

            if (date_enteredObjectpropCount > 0)
            {
                body["date_entered"] = date_enteredObject;
                bodypropCount++;
            }

            var date_leftObject = new JObject();
            var date_leftObjectpropCount = 0;
            if (bodydateLeftday != null)
            {
                date_leftObject["d"] = ExpressionConverter.ConvertO(bodydateLeftday);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftmonth != null)
            {
                date_leftObject["m"] = ExpressionConverter.ConvertO(bodydateLeftmonth);
                date_leftObjectpropCount++;
            }

            if (bodydateLeftyear != null)
            {
                date_leftObject["y"] = ExpressionConverter.ConvertO(bodydateLeftyear);
                date_leftObjectpropCount++;
            }

            if (date_leftObjectpropCount > 0)
            {
                body["date_left"] = date_leftObject;
                bodypropCount++;
            }

            var date_graduatedObject = new JObject();
            var date_graduatedObjectpropCount = 0;
            if (bodydateGraduatedday != null)
            {
                date_graduatedObject["d"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                date_graduatedObject["m"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                date_graduatedObjectpropCount++;
            }

            if (bodydateGraduatedyear != null)
            {
                date_graduatedObject["y"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                date_graduatedObjectpropCount++;
            }

            if (date_graduatedObjectpropCount > 0)
            {
                body["date_graduated"] = date_graduatedObject;
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodygPA != null)
            {
                body["gpa"] = ExpressionConverter.ConvertO(bodygPA);
                bodypropCount++;
            }

            if (bodysubjectOfStudy != null)
            {
                body["subject_of_study"] = ExpressionConverter.ConvertO(bodysubjectOfStudy);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodymajors != null)
            {
                body["majors"] = ExpressionConverter.ConvertO(bodymajors);
                bodypropCount++;
            }

            if (bodyminors != null)
            {
                body["minors"] = ExpressionConverter.ConvertO(bodyminors);
                bodypropCount++;
            }

            if (bodycampus != null)
            {
                body["campus"] = ExpressionConverter.ConvertO(bodycampus);
                bodypropCount++;
            }

            if (bodysocialOrganization != null)
            {
                body["social_organization"] = ExpressionConverter.ConvertO(bodysocialOrganization);
                bodypropCount++;
            }

            if (bodyknownName != null)
            {
                body["known_name"] = ExpressionConverter.ConvertO(bodyknownName);
                bodypropCount++;
            }

            if (bodyclassOfDegree != null)
            {
                body["class_of_degree"] = ExpressionConverter.ConvertO(bodyclassOfDegree);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyfaculty != null)
            {
                body["faculty"] = ExpressionConverter.ConvertO(bodyfaculty);
                bodypropCount++;
            }

            if (bodyregistrationNumber != null)
            {
                body["registration_number"] = ExpressionConverter.ConvertO(bodyregistrationNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyemailType, Expression<Func<string>> bodyemailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/emailaddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodyemailType);
            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodyemailAddress);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = ExpressionConverter.ConvertO(bodydoNotEmail);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemailType != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = ExpressionConverter.ConvertO(bodydoNotEmail);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat> CreateConstituentNameFormat(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var apiCallPath = "/constituent/v1/nameformats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodycustomNameFormat != null)
            {
                body["custom_format"] = ExpressionConverter.ConvertO(bodycustomNameFormat);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["configuration_id"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodycustomName != null)
            {
                body["formatted_name"] = ExpressionConverter.ConvertO(bodycustomName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentNameFormat(Expression<Func<string>> nameFormatId, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var apiCallPath = String.Format("/constituent/v1/nameformats/{0}", ExpressionConverter.ConvertWithUrlEncoding(nameFormatId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodycustomNameFormat != null)
            {
                body["custom_format"] = ExpressionConverter.ConvertO(bodycustomNameFormat);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["configuration_id"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodycustomName != null)
            {
                body["formatted_name"] = ExpressionConverter.ConvertO(bodycustomName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentNote(Expression<Func<string>> noteId, Expression<Func<string>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/constituent/v1/notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(noteId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var dateObject = new JObject();
            var dateObjectpropCount = 0;
            if (bodydateday != null)
            {
                dateObject["d"] = ExpressionConverter.ConvertO(bodydateday);
                dateObjectpropCount++;
            }

            if (bodydatemonth != null)
            {
                dateObject["m"] = ExpressionConverter.ConvertO(bodydatemonth);
                dateObjectpropCount++;
            }

            if (bodydateyear != null)
            {
                dateObject["y"] = ExpressionConverter.ConvertO(bodydateyear);
                dateObjectpropCount++;
            }

            if (dateObjectpropCount > 0)
            {
                body["date"] = dateObject;
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence> CreateConstituentOnlinePresence(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodylink, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/onlinepresences";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["address"] = ExpressionConverter.ConvertO(bodylink);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentOnlinePresence(Expression<Func<string>> onlinePresenceId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodylink = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/onlinepresences/{0}", ExpressionConverter.ConvertWithUrlEncoding(onlinePresenceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodylink != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodylink);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone> CreateConstituentPhone(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodynumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/constituent/v1/phones";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = ExpressionConverter.ConvertO(bodydoNotCall);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentPhone(Expression<Func<string>> phoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = String.Format("/constituent/v1/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(phoneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = ExpressionConverter.ConvertO(bodydoNotCall);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = ExpressionConverter.ConvertO(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat> CreateConstituentPrimaryNameFormat(Expression<Func<string>> bodyconstituentID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var apiCallPath = "/constituent/v1/primarynameformats";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["primary_type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodycustomNameFormat != null)
            {
                body["custom_format"] = ExpressionConverter.ConvertO(bodycustomNameFormat);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["configuration_id"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodycustomName != null)
            {
                body["formatted_name"] = ExpressionConverter.ConvertO(bodycustomName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentPrimaryNameFormat(Expression<Func<string>> primaryNameFormatId, Expression<Func<bool>> bodycustomNameFormat = null, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodycustomName = null)
        {
            var apiCallPath = String.Format("/constituent/v1/primarynameformats/{0}", ExpressionConverter.ConvertWithUrlEncoding(primaryNameFormatId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycustomNameFormat != null)
            {
                body["custom_format"] = ExpressionConverter.ConvertO(bodycustomNameFormat);
                bodypropCount++;
            }

            if (bodyformat != null)
            {
                body["configuration_id"] = ExpressionConverter.ConvertO(bodyformat);
                bodypropCount++;
            }

            if (bodycustomName != null)
            {
                body["formatted_name"] = ExpressionConverter.ConvertO(bodycustomName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentRelationship(Expression<Func<string>> relationshipId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null)
        {
            var apiCallPath = String.Format("/constituent/v1/relationships/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisSpouse != null)
            {
                body["is_spouse"] = ExpressionConverter.ConvertO(bodyisSpouse);
                bodypropCount++;
            }

            if (bodyisConstituentHeadOfHousehold != null)
            {
                body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(bodyisConstituentHeadOfHousehold);
                bodypropCount++;
            }

            if (bodyisSpouseHeadOfHousehold != null)
            {
                body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(bodyisSpouseHeadOfHousehold);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyisContact != null)
            {
                body["is_organization_contact"] = ExpressionConverter.ConvertO(bodyisContact);
                bodypropCount++;
            }

            if (bodyisPrimaryBusiness != null)
            {
                body["is_primary_business"] = ExpressionConverter.ConvertO(bodyisPrimaryBusiness);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["organization_contact_type"] = ExpressionConverter.ConvertO(bodycontactType);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyreligion = null, Expression<Func<bool>> bodyprimaryAddresseecustomAddressee = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeFormat = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeCustomName = null, Expression<Func<bool>> bodyprimarySalutationcustomSalutation = null, Expression<Func<string>> bodyprimarySalutationsalutationFormat = null, Expression<Func<string>> bodyprimarySalutationsalutationCustomName = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var apiCallPath = "/constituent/v1/virtual/individuals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "Individual";
            bodypropCount++;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            bodypropCount++;
            body["last"] = ExpressionConverter.ConvertO(bodylastName);
            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["type"] = ExpressionConverter.ConvertO(bodyaddresstype);
            if (bodyaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresslines != null)
            {
                addressObject["address_lines"] = ExpressionConverter.ConvertO(bodyaddresslines);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddresssuburb != null)
            {
                addressObject["suburb"] = ExpressionConverter.ConvertO(bodyaddresssuburb);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddressstart != null)
            {
                addressObject["start"] = ExpressionConverter.ConvertO(bodyaddressstart);
                addressObjectpropCount++;
            }

            if (bodyaddressend != null)
            {
                addressObject["end"] = ExpressionConverter.ConvertO(bodyaddressend);
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
            phoneObject["type"] = ExpressionConverter.ConvertO(bodyphonetype);
            phoneObjectpropCount++;
            phoneObject["number"] = ExpressionConverter.ConvertO(bodyphonenumber);
            if (bodyphoneisPrimary != null)
            {
                phoneObject["primary"] = ExpressionConverter.ConvertO(bodyphoneisPrimary);
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
            emailObject["type"] = ExpressionConverter.ConvertO(bodyemailtype);
            emailObjectpropCount++;
            emailObject["address"] = ExpressionConverter.ConvertO(bodyemailaddress);
            if (bodyemailisPrimary != null)
            {
                emailObject["primary"] = ExpressionConverter.ConvertO(bodyemailisPrimary);
                emailObjectpropCount++;
            }

            if (emailObjectpropCount > 0)
            {
                body["email"] = emailObject;
                bodypropCount++;
            }

            var online_presenceObject = new JObject();
            var online_presenceObjectpropCount = 0;
            online_presenceObjectpropCount++;
            online_presenceObject["type"] = ExpressionConverter.ConvertO(bodyonlinePresencetype);
            online_presenceObjectpropCount++;
            online_presenceObject["address"] = ExpressionConverter.ConvertO(bodyonlinePresenceaddress);
            if (bodyonlinePresenceisPrimary != null)
            {
                online_presenceObject["primary"] = ExpressionConverter.ConvertO(bodyonlinePresenceisPrimary);
                online_presenceObjectpropCount++;
            }

            if (online_presenceObjectpropCount > 0)
            {
                body["online_presence"] = online_presenceObject;
                bodypropCount++;
            }

            if (bodypreferredName != null)
            {
                body["preferred_name"] = ExpressionConverter.ConvertO(bodypreferredName);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyformerName != null)
            {
                body["former_name"] = ExpressionConverter.ConvertO(bodyformerName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = ExpressionConverter.ConvertO(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = ExpressionConverter.ConvertO(bodysuffix2);
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodyrequestsNoEmail != null)
            {
                body["requests_no_email"] = ExpressionConverter.ConvertO(bodyrequestsNoEmail);
                bodypropCount++;
            }

            if (bodyisASolicitor != null)
            {
                body["is_solicitor"] = ExpressionConverter.ConvertO(bodyisASolicitor);
                bodypropCount++;
            }

            if (bodynoValidAddresses != null)
            {
                body["no_valid_address"] = ExpressionConverter.ConvertO(bodynoValidAddresses);
                bodypropCount++;
            }

            var birthdateObject = new JObject();
            var birthdateObjectpropCount = 0;
            if (bodybirthdateday != null)
            {
                birthdateObject["d"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthdateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthdateObject["m"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthdateObjectpropCount++;
            }

            if (bodybirthdateyear != null)
            {
                birthdateObject["y"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthdateObjectpropCount++;
            }

            if (birthdateObjectpropCount > 0)
            {
                body["birthdate"] = birthdateObject;
                bodypropCount++;
            }

            if (bodybirthplace != null)
            {
                body["birthplace"] = ExpressionConverter.ConvertO(bodybirthplace);
                bodypropCount++;
            }

            if (bodyethnicity != null)
            {
                body["ethnicity"] = ExpressionConverter.ConvertO(bodyethnicity);
                bodypropCount++;
            }

            if (bodytarget != null)
            {
                body["target"] = ExpressionConverter.ConvertO(bodytarget);
                bodypropCount++;
            }

            if (bodyincome != null)
            {
                body["income"] = ExpressionConverter.ConvertO(bodyincome);
                bodypropCount++;
            }

            if (bodyreceiptType != null)
            {
                body["receipt_type"] = ExpressionConverter.ConvertO(bodyreceiptType);
                bodypropCount++;
            }

            if (bodyreligion != null)
            {
                body["religion"] = ExpressionConverter.ConvertO(bodyreligion);
                bodypropCount++;
            }

            var primary_addresseeObject = new JObject();
            var primary_addresseeObjectpropCount = 0;
            if (bodyprimaryAddresseecustomAddressee != null)
            {
                primary_addresseeObject["custom_format"] = ExpressionConverter.ConvertO(bodyprimaryAddresseecustomAddressee);
                primary_addresseeObjectpropCount++;
            }

            if (bodyprimaryAddresseeaddresseeFormat != null)
            {
                primary_addresseeObject["configuration_id"] = ExpressionConverter.ConvertO(bodyprimaryAddresseeaddresseeFormat);
                primary_addresseeObjectpropCount++;
            }

            if (bodyprimaryAddresseeaddresseeCustomName != null)
            {
                primary_addresseeObject["formatted_name"] = ExpressionConverter.ConvertO(bodyprimaryAddresseeaddresseeCustomName);
                primary_addresseeObjectpropCount++;
            }

            if (primary_addresseeObjectpropCount > 0)
            {
                body["primary_addressee"] = primary_addresseeObject;
                bodypropCount++;
            }

            var primary_salutationObject = new JObject();
            var primary_salutationObjectpropCount = 0;
            if (bodyprimarySalutationcustomSalutation != null)
            {
                primary_salutationObject["custom_format"] = ExpressionConverter.ConvertO(bodyprimarySalutationcustomSalutation);
                primary_salutationObjectpropCount++;
            }

            if (bodyprimarySalutationsalutationFormat != null)
            {
                primary_salutationObject["configuration_id"] = ExpressionConverter.ConvertO(bodyprimarySalutationsalutationFormat);
                primary_salutationObjectpropCount++;
            }

            if (bodyprimarySalutationsalutationCustomName != null)
            {
                primary_salutationObject["formatted_name"] = ExpressionConverter.ConvertO(bodyprimarySalutationsalutationCustomName);
                primary_salutationObjectpropCount++;
            }

            if (primary_salutationObjectpropCount > 0)
            {
                body["primary_salutation"] = primary_salutationObject;
                bodypropCount++;
            }

            if (bodyisMemorial != null)
            {
                body["is_memorial"] = ExpressionConverter.ConvertO(bodyisMemorial);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship> CreateIndividualRelationship(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationID, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = "/constituent/v1/virtual/individualrelationships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["relation_id"] = ExpressionConverter.ConvertO(bodyrelationID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisSpouse != null)
            {
                body["is_spouse"] = ExpressionConverter.ConvertO(bodyisSpouse);
                bodypropCount++;
            }

            if (bodyisConstituentHeadOfHousehold != null)
            {
                body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(bodyisConstituentHeadOfHousehold);
                bodypropCount++;
            }

            if (bodyisSpouseHeadOfHousehold != null)
            {
                body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(bodyisSpouseHeadOfHousehold);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodylookupID = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyrequestsNoEmail = null, Expression<Func<bool>> bodyisASolicitor = null, Expression<Func<bool>> bodynoValidAddresses = null, Expression<Func<string>> bodytarget = null, Expression<Func<string>> bodyincome = null, Expression<Func<bodyreceiptTypeInput>> bodyreceiptType = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodyisMemorial = null)
        {
            var apiCallPath = "/constituent/v1/virtual/organizations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["type"] = "Organization";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodylookupID != null)
            {
                body["lookup_id"] = ExpressionConverter.ConvertO(bodylookupID);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["type"] = ExpressionConverter.ConvertO(bodyaddresstype);
            if (bodyaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresslines != null)
            {
                addressObject["address_lines"] = ExpressionConverter.ConvertO(bodyaddresslines);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postal_code"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddresssuburb != null)
            {
                addressObject["suburb"] = ExpressionConverter.ConvertO(bodyaddresssuburb);
                addressObjectpropCount++;
            }

            if (bodyaddresscounty != null)
            {
                addressObject["county"] = ExpressionConverter.ConvertO(bodyaddresscounty);
                addressObjectpropCount++;
            }

            if (bodyaddressstart != null)
            {
                addressObject["start"] = ExpressionConverter.ConvertO(bodyaddressstart);
                addressObjectpropCount++;
            }

            if (bodyaddressend != null)
            {
                addressObject["end"] = ExpressionConverter.ConvertO(bodyaddressend);
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
            phoneObject["type"] = ExpressionConverter.ConvertO(bodyphonetype);
            phoneObjectpropCount++;
            phoneObject["number"] = ExpressionConverter.ConvertO(bodyphonenumber);
            if (bodyphoneisPrimary != null)
            {
                phoneObject["primary"] = ExpressionConverter.ConvertO(bodyphoneisPrimary);
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
            emailObject["type"] = ExpressionConverter.ConvertO(bodyemailtype);
            emailObjectpropCount++;
            emailObject["address"] = ExpressionConverter.ConvertO(bodyemailaddress);
            if (bodyemailisPrimary != null)
            {
                emailObject["primary"] = ExpressionConverter.ConvertO(bodyemailisPrimary);
                emailObjectpropCount++;
            }

            if (emailObjectpropCount > 0)
            {
                body["email"] = emailObject;
                bodypropCount++;
            }

            var online_presenceObject = new JObject();
            var online_presenceObjectpropCount = 0;
            online_presenceObjectpropCount++;
            online_presenceObject["type"] = ExpressionConverter.ConvertO(bodyonlinePresencetype);
            online_presenceObjectpropCount++;
            online_presenceObject["address"] = ExpressionConverter.ConvertO(bodyonlinePresenceaddress);
            if (bodyonlinePresenceisPrimary != null)
            {
                online_presenceObject["primary"] = ExpressionConverter.ConvertO(bodyonlinePresenceisPrimary);
                online_presenceObjectpropCount++;
            }

            if (online_presenceObjectpropCount > 0)
            {
                body["online_presence"] = online_presenceObject;
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodyrequestsNoEmail != null)
            {
                body["requests_no_email"] = ExpressionConverter.ConvertO(bodyrequestsNoEmail);
                bodypropCount++;
            }

            if (bodyisASolicitor != null)
            {
                body["is_solicitor"] = ExpressionConverter.ConvertO(bodyisASolicitor);
                bodypropCount++;
            }

            if (bodynoValidAddresses != null)
            {
                body["no_valid_address"] = ExpressionConverter.ConvertO(bodynoValidAddresses);
                bodypropCount++;
            }

            if (bodytarget != null)
            {
                body["target"] = ExpressionConverter.ConvertO(bodytarget);
                bodypropCount++;
            }

            if (bodyincome != null)
            {
                body["income"] = ExpressionConverter.ConvertO(bodyincome);
                bodypropCount++;
            }

            if (bodyreceiptType != null)
            {
                body["receipt_type"] = ExpressionConverter.ConvertO(bodyreceiptType);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynumberOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynumberOfEmployees);
                bodypropCount++;
            }

            if (bodymatchesGifts != null)
            {
                body["matches_gifts"] = ExpressionConverter.ConvertO(bodymatchesGifts);
                bodypropCount++;
            }

            if (bodymatchingGiftFactor != null)
            {
                body["matching_gift_factor"] = ExpressionConverter.ConvertO(bodymatchingGiftFactor);
                bodypropCount++;
            }

            var matching_gift_per_gift_minObject = new JObject();
            var matching_gift_per_gift_minObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
            {
                matching_gift_per_gift_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMinminMatchPerGift);
                matching_gift_per_gift_minObjectpropCount++;
            }

            if (matching_gift_per_gift_minObjectpropCount > 0)
            {
                body["matching_gift_per_gift_min"] = matching_gift_per_gift_minObject;
                bodypropCount++;
            }

            var matching_gift_per_gift_maxObject = new JObject();
            var matching_gift_per_gift_maxObjectpropCount = 0;
            if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
            {
                matching_gift_per_gift_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                matching_gift_per_gift_maxObjectpropCount++;
            }

            if (matching_gift_per_gift_maxObjectpropCount > 0)
            {
                body["matching_gift_per_gift_max"] = matching_gift_per_gift_maxObject;
                bodypropCount++;
            }

            var matching_gift_total_minObject = new JObject();
            var matching_gift_total_minObjectpropCount = 0;
            if (bodymatchingGiftTotalMinminMatchPerConstit != null)
            {
                matching_gift_total_minObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMinminMatchPerConstit);
                matching_gift_total_minObjectpropCount++;
            }

            if (matching_gift_total_minObjectpropCount > 0)
            {
                body["matching_gift_total_min"] = matching_gift_total_minObject;
                bodypropCount++;
            }

            var matching_gift_total_maxObject = new JObject();
            var matching_gift_total_maxObjectpropCount = 0;
            if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
            {
                matching_gift_total_maxObject["value"] = ExpressionConverter.ConvertO(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                matching_gift_total_maxObjectpropCount++;
            }

            if (matching_gift_total_maxObjectpropCount > 0)
            {
                body["matching_gift_total_max"] = matching_gift_total_maxObject;
                bodypropCount++;
            }

            if (bodymatchingGiftNotes != null)
            {
                body["matching_gift_notes"] = ExpressionConverter.ConvertO(bodymatchingGiftNotes);
                bodypropCount++;
            }

            if (bodyisMemorial != null)
            {
                body["is_memorial"] = ExpressionConverter.ConvertO(bodyisMemorial);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship> CreateOrganizationRelationship(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationID, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodynotes = null)
        {
            var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["relation_id"] = ExpressionConverter.ConvertO(bodyrelationID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreciprocalType != null)
            {
                body["reciprocal_type"] = ExpressionConverter.ConvertO(bodyreciprocalType);
                bodypropCount++;
            }

            var startObject = new JObject();
            var startObjectpropCount = 0;
            if (bodystartday != null)
            {
                startObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                startObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                startObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                startObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                startObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                startObjectpropCount++;
            }

            if (startObjectpropCount > 0)
            {
                body["start"] = startObject;
                bodypropCount++;
            }

            var endObject = new JObject();
            var endObjectpropCount = 0;
            if (bodyendday != null)
            {
                endObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                endObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                endObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                endObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                endObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                endObjectpropCount++;
            }

            if (endObjectpropCount > 0)
            {
                body["end"] = endObject;
                bodypropCount++;
            }

            if (bodyisContact != null)
            {
                body["is_organization_contact"] = ExpressionConverter.ConvertO(bodyisContact);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["organization_contact_type"] = ExpressionConverter.ConvertO(bodycontactType);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodyposition);
                bodypropCount++;
            }

            if (bodyisPrimaryBusiness != null)
            {
                body["is_primary_business"] = ExpressionConverter.ConvertO(bodyisPrimaryBusiness);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment> CreateFundraiserAssignment(Expression<Func<string>> bodyfundraiserID, Expression<Func<string>> bodyconstituentID, Expression<Func<double>> bodyamountamount, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyassignmentStarts = null, Expression<Func<string>> bodyassignmentEnds = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<string>> bodyappealID = null)
        {
            var apiCallPath = "/fundraising/v1/fundraisers/assignments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fundraiser_id"] = ExpressionConverter.ConvertO(bodyfundraiserID);
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyassignmentStarts != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodyassignmentStarts);
                bodypropCount++;
            }

            if (bodyassignmentEnds != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyassignmentEnds);
                bodypropCount++;
            }

            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            amountObjectpropCount++;
            amountObject["value"] = ExpressionConverter.ConvertO(bodyamountamount);
            if (amountObjectpropCount > 0)
            {
                body["amount"] = amountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = ExpressionConverter.ConvertO(bodyfundID);
                bodypropCount++;
            }

            if (bodyappealID != null)
            {
                body["appeal_id"] = ExpressionConverter.ConvertO(bodyappealID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead> ListFundraiserAssignments(Expression<Func<string>> fundraiserId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/fundraising/v1/fundraisers/{0}/assignments", ExpressionConverter.ConvertWithUrlEncoding(fundraiserId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentIdMap> GetConstituentIdFromLookupId(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/constituentidmap/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiConstituentIdMap>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentSearchResultCollection> SearchConstituentEnhanced(Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> email = null, Expression<Func<string>> phoneNumber = null, Expression<Func<int>> limit = null, Expression<Func<string>> addressLines = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<bool>> includeAlias = null, Expression<Func<string>> aliasType = null, Expression<Func<bool>> includeMaidenName = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/constituents/customsearch";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (firstName != null)
                callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
            if (lastName != null)
                callPayload.Queries["last_name"] = ExpressionConverter.Convert(lastName);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(lookupId);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = ExpressionConverter.Convert(phoneNumber);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (addressLines != null)
                callPayload.Queries["address_lines"] = ExpressionConverter.Convert(addressLines);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = ExpressionConverter.Convert(postCode);
            if (includeAlias != null)
                callPayload.Queries["include_alias"] = ExpressionConverter.Convert(includeAlias);
            if (aliasType != null)
                callPayload.Queries["alias_type"] = ExpressionConverter.Convert(aliasType);
            if (includeMaidenName != null)
                callPayload.Queries["include_maiden_name"] = ExpressionConverter.Convert(includeMaidenName);
            return new ApiConnectionAction<NXTDataIntegrationApiConstituentSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentTribute> CreateConstituentTribute(Expression<Func<int>> bodyconstituentID, Expression<Func<int>> bodytributeType, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodydefaultFundID = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyactive = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/tribute";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_record_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["tribute_type_id"] = ExpressionConverter.ConvertO(bodytributeType);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            var start_dateObject = new JObject();
            var start_dateObjectpropCount = 0;
            if (bodystartday != null)
            {
                start_dateObject["d"] = ExpressionConverter.ConvertO(bodystartday);
                start_dateObjectpropCount++;
            }

            if (bodystartmonth != null)
            {
                start_dateObject["m"] = ExpressionConverter.ConvertO(bodystartmonth);
                start_dateObjectpropCount++;
            }

            if (bodystartyear != null)
            {
                start_dateObject["y"] = ExpressionConverter.ConvertO(bodystartyear);
                start_dateObjectpropCount++;
            }

            if (start_dateObjectpropCount > 0)
            {
                body["start_date"] = start_dateObject;
                bodypropCount++;
            }

            var end_dateObject = new JObject();
            var end_dateObjectpropCount = 0;
            if (bodyendday != null)
            {
                end_dateObject["d"] = ExpressionConverter.ConvertO(bodyendday);
                end_dateObjectpropCount++;
            }

            if (bodyendmonth != null)
            {
                end_dateObject["m"] = ExpressionConverter.ConvertO(bodyendmonth);
                end_dateObjectpropCount++;
            }

            if (bodyendyear != null)
            {
                end_dateObject["y"] = ExpressionConverter.ConvertO(bodyendyear);
                end_dateObjectpropCount++;
            }

            if (end_dateObjectpropCount > 0)
            {
                body["end_date"] = end_dateObject;
                bodypropCount++;
            }

            if (bodydefaultFundID != null)
            {
                body["default_fund_id"] = ExpressionConverter.ConvertO(bodydefaultFundID);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["is_active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentTribute>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTribute> GetConstituentTribute(Expression<Func<string>> tributeId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/tribute/{0}", ExpressionConverter.ConvertWithUrlEncoding(tributeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiTribute>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTributeAcknowledgee> CreateTributeAcknowledgee(Expression<Func<int>> bodytributeID, Expression<Func<int>> bodyrelationshipID = null, Expression<Func<int>> bodyletterID = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/tribute/acknowledgee";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["tribute_id"] = ExpressionConverter.ConvertO(bodytributeID);
            if (bodyrelationshipID != null)
            {
                body["relationship_id"] = ExpressionConverter.ConvertO(bodyrelationshipID);
                bodypropCount++;
            }

            if (bodyletterID != null)
            {
                body["letter_id"] = ExpressionConverter.ConvertO(bodyletterID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedTributeAcknowledgee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeCollection> ListConstituentTributes(Expression<Func<int>> constituentId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/tribute/constituent/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiTributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeAcknowledgeeCollection> ListTributeAcknowledgees(Expression<Func<int>> tributeId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/tribute/{0}/acknowledgees", ExpressionConverter.ConvertWithUrlEncoding(tributeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiTributeAcknowledgeeCollection>(callPayload);
        }
    }

    public class BlackbaudconstituentTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string ID { get; set; }

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
        public string LookupID { get; set; }

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

    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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

    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

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
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

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
        public string ConstituentIDValue { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public enum ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatSummaryReadPrimarySalutationType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public enum ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string ConstituentID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("relation_id")]
        public string RelationID { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipID { get; set; }

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
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string ID { get; set; }

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
        public string LookupID { get; set; }

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
        public string ID { get; set; }

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
        public string LookupID { get; set; }
    }

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
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedNameFormat
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentIdMap
    {
        [JsonProperty("system_record_id")]
        public int ID { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultCollection
    {
        [JsonProperty("results")]
        public NXTDataIntegrationApiConstituentSearchResult[] Results { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResult
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupID { get; set; }

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
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiTribute
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("constituent_record_id")]
        public int ConstituentID { get; set; }

        [JsonProperty("tribute_type_name")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_type_id")]
        public int TributeTypeID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public NXTDataIntegrationApiTributeStartType Start { get; set; }

        [JsonProperty("end_date")]
        public NXTDataIntegrationApiTributeEndType End { get; set; }

        [JsonProperty("default_fund_id")]
        public int DefaultFundID { get; set; }

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
        public string ID { get; set; }
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
        public int ID { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeID { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipID { get; set; }

        [JsonProperty("letter")]
        public int LetterID { get; set; }

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