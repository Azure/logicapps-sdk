//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmconstituActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> CreateConstituentAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycountry, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyrecentlyMoved = null, Expression<Func<string>> bodyoldAddress = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/crm-conmg/addresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
            if (bodytype != null)
            {
                body["address_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postcode"] = CSharpExpressionConverter.ConvertToken(bodypostalCode);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = CSharpExpressionConverter.ConvertToken(bodydoNotMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["do_not_mail_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                startDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                startDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                startDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartday);
                startDateObjectpropCount++;
            }

            if (startDateObjectpropCount > 0)
            {
                body["start_date"] = startDateObject;
                bodypropCount++;
            }

            var endDateObject = new JObject();
            var endDateObjectpropCount = 0;
            if (bodyseasonalEndmonth != null)
            {
                endDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                endDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                endDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndday);
                endDateObjectpropCount++;
            }

            if (endDateObjectpropCount > 0)
            {
                body["end_date"] = endDateObject;
                bodypropCount++;
            }

            if (bodyhistoricalStartDate != null)
            {
                body["historical_start_date"] = CSharpExpressionConverter.ConvertToken(bodyhistoricalStartDate);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = CSharpExpressionConverter.ConvertToken(bodycounty);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = CSharpExpressionConverter.ConvertToken(bodydPC);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = CSharpExpressionConverter.ConvertToken(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = CSharpExpressionConverter.ConvertToken(bodylOT);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = CSharpExpressionConverter.ConvertToken(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodystateHouseDistrict != null)
            {
                body["state_house_district"] = CSharpExpressionConverter.ConvertToken(bodystateHouseDistrict);
                bodypropCount++;
            }

            if (bodystateSenateDistrict != null)
            {
                body["state_senate_district"] = CSharpExpressionConverter.ConvertToken(bodystateSenateDistrict);
                bodypropCount++;
            }

            if (bodylocalPrecinct != null)
            {
                body["local_precinct"] = CSharpExpressionConverter.ConvertToken(bodylocalPrecinct);
                bodypropCount++;
            }

            if (bodyorigin != null)
            {
                body["origin"] = CSharpExpressionConverter.Convert(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodyrecentlyMoved != null)
            {
                body["recent_move"] = CSharpExpressionConverter.ConvertToken(bodyrecentlyMoved);
                bodypropCount++;
            }

            if (bodyoldAddress != null)
            {
                body["old_address"] = CSharpExpressionConverter.ConvertToken(bodyoldAddress);
                bodypropCount++;
            }

            if (bodyomitFromValidation != null)
            {
                body["omit_from_validation"] = CSharpExpressionConverter.ConvertToken(bodyomitFromValidation);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_addresses"] = CSharpExpressionConverter.ConvertToken(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_addresses"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAddress(Expression<Func<string>> constituentAddressId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/addresses/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAddressId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAddress(Expression<Func<string>> constituentAddressId, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodyhistoricalEndDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodyupdateContacts = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/addresses/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["address_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postcode"] = CSharpExpressionConverter.ConvertToken(bodypostalCode);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = CSharpExpressionConverter.ConvertToken(bodydoNotMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["do_not_mail_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                startDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                startDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                startDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartday);
                startDateObjectpropCount++;
            }

            if (startDateObjectpropCount > 0)
            {
                body["start_date"] = startDateObject;
                bodypropCount++;
            }

            var endDateObject = new JObject();
            var endDateObjectpropCount = 0;
            if (bodyseasonalEndmonth != null)
            {
                endDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                endDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                endDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndday);
                endDateObjectpropCount++;
            }

            if (endDateObjectpropCount > 0)
            {
                body["end_date"] = endDateObject;
                bodypropCount++;
            }

            if (bodyhistoricalStartDate != null)
            {
                body["historical_start_date"] = CSharpExpressionConverter.ConvertToken(bodyhistoricalStartDate);
                bodypropCount++;
            }

            if (bodyhistoricalEndDate != null)
            {
                body["historical_end_date"] = CSharpExpressionConverter.ConvertToken(bodyhistoricalEndDate);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = CSharpExpressionConverter.ConvertToken(bodycounty);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = CSharpExpressionConverter.ConvertToken(bodyregion);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = CSharpExpressionConverter.ConvertToken(bodydPC);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = CSharpExpressionConverter.ConvertToken(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = CSharpExpressionConverter.ConvertToken(bodylOT);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = CSharpExpressionConverter.ConvertToken(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodystateHouseDistrict != null)
            {
                body["state_house_district"] = CSharpExpressionConverter.ConvertToken(bodystateHouseDistrict);
                bodypropCount++;
            }

            if (bodystateSenateDistrict != null)
            {
                body["state_senate_district"] = CSharpExpressionConverter.ConvertToken(bodystateSenateDistrict);
                bodypropCount++;
            }

            if (bodylocalPrecinct != null)
            {
                body["local_precinct"] = CSharpExpressionConverter.ConvertToken(bodylocalPrecinct);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodyomitFromValidation != null)
            {
                body["omit_from_validation"] = CSharpExpressionConverter.ConvertToken(bodyomitFromValidation);
                bodypropCount++;
            }

            if (bodyupdateContacts != null)
            {
                body["update_contacts"] = CSharpExpressionConverter.ConvertToken(bodyupdateContacts);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_addresses"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> CreateConstituentAlternateLookupID(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodyalternateLookupID)
        {
            var apiCallPath = "/crm-conmg/alternatelookupids";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["alternate_lookup_id_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["alternate_lookup_id"] = CSharpExpressionConverter.ConvertToken(bodyalternateLookupID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAlternateLookupID>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/alternatelookupids/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(alternateLookupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyalternateLookupID = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/alternatelookupids/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(alternateLookupId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["alternate_lookup_id_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyalternateLookupID != null)
            {
                body["alternate_lookup_id"] = CSharpExpressionConverter.ConvertToken(bodyalternateLookupID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> CreateConstituentAppealResponse(Expression<Func<string>> bodyconstituentAppealID, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyresponse, Expression<Func<string>> bodydate = null)
        {
            var apiCallPath = "/crm-conmg/constituentappealresponses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_appeal_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentAppealID);
            bodypropCount++;
            body["response_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
            bodypropCount++;
            body["response"] = CSharpExpressionConverter.ConvertToken(bodyresponse);
            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppealResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> CreateConstituentAppeal(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyappealID, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/crm-conmg/constituentappeals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["appeal_id"] = CSharpExpressionConverter.ConvertToken(bodyappealID);
            if (bodymailing != null)
            {
                body["mkt_segmentation"] = CSharpExpressionConverter.ConvertToken(bodymailing);
                bodypropCount++;
            }

            if (bodydateSent != null)
            {
                body["date_sent"] = CSharpExpressionConverter.ConvertToken(bodydateSent);
                bodypropCount++;
            }

            if (bodypackage != null)
            {
                body["mkt_package_id"] = CSharpExpressionConverter.ConvertToken(bodypackage);
                bodypropCount++;
            }

            if (bodysourceCode != null)
            {
                body["source_code"] = CSharpExpressionConverter.ConvertToken(bodysourceCode);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppeal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAppeal(Expression<Func<string>> constituentAppealId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAppealId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAppeal(Expression<Func<string>> constituentAppealId, Expression<Func<string>> bodyappealID = null, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAppealId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyappealID != null)
            {
                body["appeal_id"] = CSharpExpressionConverter.ConvertToken(bodyappealID);
                bodypropCount++;
            }

            if (bodymailing != null)
            {
                body["mkt_segmentation"] = CSharpExpressionConverter.ConvertToken(bodymailing);
                bodypropCount++;
            }

            if (bodydateSent != null)
            {
                body["date_sent"] = CSharpExpressionConverter.ConvertToken(bodydateSent);
                bodypropCount++;
            }

            if (bodypackage != null)
            {
                body["mkt_package_id"] = CSharpExpressionConverter.ConvertToken(bodypackage);
                bodypropCount++;
            }

            if (bodysourceCode != null)
            {
                body["source_code"] = CSharpExpressionConverter.ConvertToken(bodysourceCode);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> ListConstituentAppeals(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}/appeals", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentAppealCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAttribute(Expression<Func<string>> constituentAttributeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentattributes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAttributeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence> CreateConstituentCorrespondence(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycorrespondenceCode, Expression<Func<string>> bodydateSent, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/crm-conmg/constituentcorrespondencecodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["correspondence_code"] = CSharpExpressionConverter.ConvertToken(bodycorrespondenceCode);
            bodypropCount++;
            body["date_sent"] = CSharpExpressionConverter.ConvertToken(bodydateSent);
            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentCorrespondence>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCorrespondenceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId, Expression<Func<string>> bodycorrespondenceCode = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCorrespondenceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycorrespondenceCode != null)
            {
                body["correspondence_code"] = CSharpExpressionConverter.ConvertToken(bodycorrespondenceCode);
                bodypropCount++;
            }

            if (bodydateSent != null)
            {
                body["date_sent"] = CSharpExpressionConverter.ConvertToken(bodydateSent);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> CreateConstituentNote(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var apiCallPath = "/crm-conmg/constituentnotes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["note_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["date_entered"] = CSharpExpressionConverter.ConvertToken(bodydate);
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyauthorID != null)
            {
                body["author_id"] = CSharpExpressionConverter.ConvertToken(bodyauthorID);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text_note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodyhTML != null)
            {
                body["html_note"] = CSharpExpressionConverter.ConvertToken(bodyhTML);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentNote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentNote(Expression<Func<string>> constituentNoteId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentnotes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentNoteId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentNote(Expression<Func<string>> constituentNoteId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentnotes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentNoteId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["note_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date_entered"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyauthorID != null)
            {
                body["author_id"] = CSharpExpressionConverter.ConvertToken(bodyauthorID);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text_note"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodyhTML != null)
            {
                body["html_note"] = CSharpExpressionConverter.ConvertToken(bodyhTML);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> SearchConstituent(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> emailAddress = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<int>> classof = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> middleName = null, Expression<Func<string>> constituency = null, Expression<Func<string>> sourcecode = null, Expression<Func<bool>> includeIndividuals = null, Expression<Func<bool>> includeOrganizations = null, Expression<Func<bool>> includeGroups = null, Expression<Func<bool>> excludeHouseholds = null, Expression<Func<bool>> checkNickname = null, Expression<Func<bool>> checkAliases = null, Expression<Func<bool>> checkAlternateLookupIds = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/crm-conmg/constituents/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyName != null)
                callPayload.Queries["key_name"] = CSharpExpressionConverter.ConvertO(keyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = CSharpExpressionConverter.ConvertO(lookupId);
            if (emailAddress != null)
                callPayload.Queries["email_address"] = CSharpExpressionConverter.ConvertO(emailAddress);
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = CSharpExpressionConverter.ConvertO(phoneNumber);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (addressBlock != null)
                callPayload.Queries["address_block"] = CSharpExpressionConverter.ConvertO(addressBlock);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (state != null)
                callPayload.Queries["state"] = CSharpExpressionConverter.ConvertO(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = CSharpExpressionConverter.ConvertO(postCode);
            if (classof != null)
                callPayload.Queries["classof"] = CSharpExpressionConverter.ConvertO(classof);
            if (exactMatchOnly != null)
                callPayload.Queries["exact_match_only"] = CSharpExpressionConverter.ConvertO(exactMatchOnly);
            if (middleName != null)
                callPayload.Queries["middle_name"] = CSharpExpressionConverter.ConvertO(middleName);
            if (constituency != null)
                callPayload.Queries["constituency"] = CSharpExpressionConverter.ConvertO(constituency);
            if (sourcecode != null)
                callPayload.Queries["sourcecode"] = CSharpExpressionConverter.ConvertO(sourcecode);
            if (includeIndividuals != null)
                callPayload.Queries["include_individuals"] = CSharpExpressionConverter.ConvertO(includeIndividuals);
            if (includeOrganizations != null)
                callPayload.Queries["include_organizations"] = CSharpExpressionConverter.ConvertO(includeOrganizations);
            if (includeGroups != null)
                callPayload.Queries["include_groups"] = CSharpExpressionConverter.ConvertO(includeGroups);
            if (excludeHouseholds != null)
                callPayload.Queries["exclude_households"] = CSharpExpressionConverter.ConvertO(excludeHouseholds);
            if (checkNickname != null)
                callPayload.Queries["check_nickname"] = CSharpExpressionConverter.ConvertO(checkNickname);
            if (checkAliases != null)
                callPayload.Queries["check_aliases"] = CSharpExpressionConverter.ConvertO(checkAliases);
            if (checkAlternateLookupIds != null)
                callPayload.Queries["check_alternate_lookup_ids"] = CSharpExpressionConverter.ConvertO(checkAlternateLookupIds);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = CSharpExpressionConverter.ConvertO(onlyPrimaryAddress);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = CSharpExpressionConverter.ConvertO(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            if (fuzzySearchOnName != null)
                callPayload.Queries["fuzzy_search_on_name"] = CSharpExpressionConverter.ConvertO(fuzzySearchOnName);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<ConmgConstituentSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAddressCollection> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeFormer = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/addresses", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeFormer != null)
                callPayload.Queries["include_former"] = CSharpExpressionConverter.ConvertO(includeFormer);
            return new ApiConnectionAction<ConmgAddressCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> ListConstituentAlternateLookupIDs(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/alternatelookupids", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgAlternateLookupIDCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAttributeCollection> ListConstituentAttributes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/constituentattributelist", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgAttributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> GetConstituentPrimaryContactInfo(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/contactview", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEducationCollection> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/educationalhistories", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgEducationCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> ListConstituentEmailAddresses(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/emailaddresses", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgEmailAddressCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgPhoneCollection> ListConstituentPhones(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/phones", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgPhoneCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/profilepicture", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentProfilePicture>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> ListConstituentEmploymentHistory(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/relationshipjobsinfo", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> ListConstituentSolicitCodes(Expression<Func<string>> constituentId, Expression<Func<bool>> showExpired = null, Expression<Func<dateRangeInput>> dateRange = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/solicitcodes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (showExpired != null)
                callPayload.Queries["show_expired"] = CSharpExpressionConverter.ConvertO(showExpired);
            if (dateRange != null)
                callPayload.Queries["date_range"] = CSharpExpressionConverter.Convert(dateRange);
            return new ApiConnectionAction<ConmgSolicitCodeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgTributeCollection> ListConstituentTributes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/tributes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgTributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> GetConstituentSummaryProfile(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/view", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentSummaryProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> CreateConstituentEducation(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyeducationalInstitution, Expression<Func<string>> bodystatus, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var apiCallPath = "/crm-conmg/educationalhistories";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["educational_institution_id"] = CSharpExpressionConverter.ConvertToken(bodyeducationalInstitution);
            bodypropCount++;
            body["educational_history_status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
            if (bodyprimary != null)
            {
                body["primary_record"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodyprogram != null)
            {
                body["educational_program"] = CSharpExpressionConverter.ConvertToken(bodyprogram);
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["educational_degree"] = CSharpExpressionConverter.ConvertToken(bodydegree);
                bodypropCount++;
            }

            if (bodyhonorAwarded != null)
            {
                body["educational_award"] = CSharpExpressionConverter.ConvertToken(bodyhonorAwarded);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["educational_source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            var educationalSourceDateObject = new JObject();
            var educationalSourceDateObjectpropCount = 0;
            if (bodysourceDateyear != null)
            {
                educationalSourceDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodysourceDateyear);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDatemonth != null)
            {
                educationalSourceDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodysourceDatemonth);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDateday != null)
            {
                educationalSourceDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodysourceDateday);
                educationalSourceDateObjectpropCount++;
            }

            if (educationalSourceDateObjectpropCount > 0)
            {
                body["educational_source_date"] = educationalSourceDateObject;
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            var dateGraduatedObject = new JObject();
            var dateGraduatedObjectpropCount = 0;
            if (bodydateGraduatedyear != null)
            {
                dateGraduatedObject["year"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedyear);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                dateGraduatedObject["month"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedday != null)
            {
                dateGraduatedObject["day"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedday);
                dateGraduatedObjectpropCount++;
            }

            if (dateGraduatedObjectpropCount > 0)
            {
                body["date_graduated"] = dateGraduatedObject;
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_year"] = CSharpExpressionConverter.ConvertToken(bodyclassOf);
                bodypropCount++;
            }

            if (bodypreferredClassOf != null)
            {
                body["preferred_class_year"] = CSharpExpressionConverter.ConvertToken(bodypreferredClassOf);
                bodypropCount++;
            }

            if (bodyaffiliated != null)
            {
                body["affiliated"] = CSharpExpressionConverter.ConvertToken(bodyaffiliated);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyfromyear != null)
            {
                startDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodyfromyear);
                startDateObjectpropCount++;
            }

            if (bodyfrommonth != null)
            {
                startDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyfrommonth);
                startDateObjectpropCount++;
            }

            if (bodyfromday != null)
            {
                startDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyfromday);
                startDateObjectpropCount++;
            }

            if (startDateObjectpropCount > 0)
            {
                body["start_date"] = startDateObject;
                bodypropCount++;
            }

            var dateLeftObject = new JObject();
            var dateLeftObjectpropCount = 0;
            if (bodytoyear != null)
            {
                dateLeftObject["year"] = CSharpExpressionConverter.ConvertToken(bodytoyear);
                dateLeftObjectpropCount++;
            }

            if (bodytomonth != null)
            {
                dateLeftObject["month"] = CSharpExpressionConverter.ConvertToken(bodytomonth);
                dateLeftObjectpropCount++;
            }

            if (bodytoday != null)
            {
                dateLeftObject["day"] = CSharpExpressionConverter.ConvertToken(bodytoday);
                dateLeftObjectpropCount++;
            }

            if (dateLeftObjectpropCount > 0)
            {
                body["date_left"] = dateLeftObject;
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["educational_history_reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodylevel != null)
            {
                body["educational_history_level"] = CSharpExpressionConverter.ConvertToken(bodylevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEducation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEducation(Expression<Func<string>> educationalHistoryId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/educationalhistories/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationalHistoryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEducation(Expression<Func<string>> educationalHistoryId, Expression<Func<string>> bodyeducationalInstitution = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/educationalhistories/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationalHistoryId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyeducationalInstitution != null)
            {
                body["educational_institution_id"] = CSharpExpressionConverter.ConvertToken(bodyeducationalInstitution);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["educational_history_status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary_record"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodyprogram != null)
            {
                body["educational_program"] = CSharpExpressionConverter.ConvertToken(bodyprogram);
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["educational_degree"] = CSharpExpressionConverter.ConvertToken(bodydegree);
                bodypropCount++;
            }

            if (bodyhonorAwarded != null)
            {
                body["educational_award"] = CSharpExpressionConverter.ConvertToken(bodyhonorAwarded);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["educational_source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            var educationalSourceDateObject = new JObject();
            var educationalSourceDateObjectpropCount = 0;
            if (bodysourceDateyear != null)
            {
                educationalSourceDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodysourceDateyear);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDatemonth != null)
            {
                educationalSourceDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodysourceDatemonth);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDateday != null)
            {
                educationalSourceDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodysourceDateday);
                educationalSourceDateObjectpropCount++;
            }

            if (educationalSourceDateObjectpropCount > 0)
            {
                body["educational_source_date"] = educationalSourceDateObject;
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            var dateGraduatedObject = new JObject();
            var dateGraduatedObjectpropCount = 0;
            if (bodydateGraduatedyear != null)
            {
                dateGraduatedObject["year"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedyear);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                dateGraduatedObject["month"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedday != null)
            {
                dateGraduatedObject["day"] = CSharpExpressionConverter.ConvertToken(bodydateGraduatedday);
                dateGraduatedObjectpropCount++;
            }

            if (dateGraduatedObjectpropCount > 0)
            {
                body["date_graduated"] = dateGraduatedObject;
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_year"] = CSharpExpressionConverter.ConvertToken(bodyclassOf);
                bodypropCount++;
            }

            if (bodypreferredClassOf != null)
            {
                body["preferred_class_year"] = CSharpExpressionConverter.ConvertToken(bodypreferredClassOf);
                bodypropCount++;
            }

            if (bodyaffiliated != null)
            {
                body["affiliated"] = CSharpExpressionConverter.ConvertToken(bodyaffiliated);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyfromyear != null)
            {
                startDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodyfromyear);
                startDateObjectpropCount++;
            }

            if (bodyfrommonth != null)
            {
                startDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyfrommonth);
                startDateObjectpropCount++;
            }

            if (bodyfromday != null)
            {
                startDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyfromday);
                startDateObjectpropCount++;
            }

            if (startDateObjectpropCount > 0)
            {
                body["start_date"] = startDateObject;
                bodypropCount++;
            }

            var dateLeftObject = new JObject();
            var dateLeftObjectpropCount = 0;
            if (bodytoyear != null)
            {
                dateLeftObject["year"] = CSharpExpressionConverter.ConvertToken(bodytoyear);
                dateLeftObjectpropCount++;
            }

            if (bodytomonth != null)
            {
                dateLeftObject["month"] = CSharpExpressionConverter.ConvertToken(bodytomonth);
                dateLeftObjectpropCount++;
            }

            if (bodytoday != null)
            {
                dateLeftObject["day"] = CSharpExpressionConverter.ConvertToken(bodytoday);
                dateLeftObjectpropCount++;
            }

            if (dateLeftObjectpropCount > 0)
            {
                body["date_left"] = dateLeftObject;
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["educational_history_reason"] = CSharpExpressionConverter.ConvertToken(bodyreason);
                bodypropCount++;
            }

            if (bodylevel != null)
            {
                body["educational_history_level"] = CSharpExpressionConverter.ConvertToken(bodylevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyemailAddress, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<string>> bodydoNotEmailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/crm-conmg/emailaddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            if (bodytype != null)
            {
                body["email_address_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            bodypropCount++;
            body["email_address"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = CSharpExpressionConverter.ConvertToken(bodydoNotEmail);
                bodypropCount++;
            }

            if (bodydoNotEmailReason != null)
            {
                body["donotemailreason"] = CSharpExpressionConverter.ConvertToken(bodydoNotEmailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["emailisconfidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            if (bodyorigin != null)
            {
                body["origin"] = CSharpExpressionConverter.Convert(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_email_address"] = CSharpExpressionConverter.ConvertToken(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_email_address"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmailAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEmailAddress(Expression<Func<string>> emailAddressId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/emailaddresses/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<string>> bodydoNotEmailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/emailaddresses/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["email_address_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotEmail != null)
            {
                body["do_not_email"] = CSharpExpressionConverter.ConvertToken(bodydoNotEmail);
                bodypropCount++;
            }

            if (bodydoNotEmailReason != null)
            {
                body["donotemailreason"] = CSharpExpressionConverter.ConvertToken(bodydoNotEmailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["emailisconfidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_email_address"] = CSharpExpressionConverter.ConvertToken(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_email_address"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> CreateFundraiserConstituency(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var apiCallPath = "/crm-conmg/fundraisers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            if (bodydateFrom != null)
            {
                body["date_from"] = CSharpExpressionConverter.ConvertToken(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = CSharpExpressionConverter.ConvertToken(bodydateTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedFundraiserConstituency>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/fundraisers/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserConstituencyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/fundraisers/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserConstituencyId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydateFrom != null)
            {
                body["date_from"] = CSharpExpressionConverter.ConvertToken(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = CSharpExpressionConverter.ConvertToken(bodydateTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null)
        {
            var apiCallPath = "/crm-conmg/individuals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = CSharpExpressionConverter.ConvertToken(bodysuffix);
                bodypropCount++;
            }

            if (bodyaddressType != null)
            {
                body["address_type"] = CSharpExpressionConverter.ConvertToken(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["address_country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["address_city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["address_state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["address_post_code"] = CSharpExpressionConverter.ConvertToken(bodypostalCode);
                bodypropCount++;
            }

            if (bodydoNotSendMail != null)
            {
                body["address_do_not_mail"] = CSharpExpressionConverter.ConvertToken(bodydoNotSendMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["address_do_not_mail_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["address_dpc"] = CSharpExpressionConverter.ConvertToken(bodydPC);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["address_cart"] = CSharpExpressionConverter.ConvertToken(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["address_lot"] = CSharpExpressionConverter.ConvertToken(bodylOT);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["address_county"] = CSharpExpressionConverter.ConvertToken(bodycounty);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["address_congressional_district"] = CSharpExpressionConverter.ConvertToken(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodyphoneType != null)
            {
                body["phone_type"] = CSharpExpressionConverter.ConvertToken(bodyphoneType);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phone_number"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyemailType != null)
            {
                body["email_address_type"] = CSharpExpressionConverter.ConvertToken(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle_name"] = CSharpExpressionConverter.ConvertToken(bodymiddleName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = CSharpExpressionConverter.ConvertToken(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = CSharpExpressionConverter.ConvertToken(bodysuffix2);
                bodypropCount++;
            }

            if (bodynickname != null)
            {
                body["nickname"] = CSharpExpressionConverter.ConvertToken(bodynickname);
                bodypropCount++;
            }

            if (bodymaidenName != null)
            {
                body["maiden_name"] = CSharpExpressionConverter.ConvertToken(bodymaidenName);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = CSharpExpressionConverter.ConvertToken(bodymaritalStatus);
                bodypropCount++;
            }

            var birthDateObject = new JObject();
            var birthDateObjectpropCount = 0;
            if (bodybirthdateyear != null)
            {
                birthDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodybirthdateyear);
                birthDateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodybirthdatemonth);
                birthDateObjectpropCount++;
            }

            if (bodybirthdateday != null)
            {
                birthDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodybirthdateday);
                birthDateObjectpropCount++;
            }

            if (birthDateObjectpropCount > 0)
            {
                body["birth_date"] = birthDateObject;
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender_code"] = CSharpExpressionConverter.ConvertToken(bodygender);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgIndividualConstituent> GetIndividualConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/individuals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditIndividualConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/individuals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = CSharpExpressionConverter.ConvertToken(bodysuffix);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle_name"] = CSharpExpressionConverter.ConvertToken(bodymiddleName);
                bodypropCount++;
            }

            if (bodytitle2 != null)
            {
                body["title_2"] = CSharpExpressionConverter.ConvertToken(bodytitle2);
                bodypropCount++;
            }

            if (bodysuffix2 != null)
            {
                body["suffix_2"] = CSharpExpressionConverter.ConvertToken(bodysuffix2);
                bodypropCount++;
            }

            if (bodynickname != null)
            {
                body["nickname"] = CSharpExpressionConverter.ConvertToken(bodynickname);
                bodypropCount++;
            }

            if (bodymaidenName != null)
            {
                body["maiden_name"] = CSharpExpressionConverter.ConvertToken(bodymaidenName);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = CSharpExpressionConverter.ConvertToken(bodymaritalStatus);
                bodypropCount++;
            }

            var birthDateObject = new JObject();
            var birthDateObjectpropCount = 0;
            if (bodybirthdateyear != null)
            {
                birthDateObject["year"] = CSharpExpressionConverter.ConvertToken(bodybirthdateyear);
                birthDateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodybirthdatemonth);
                birthDateObjectpropCount++;
            }

            if (bodybirthdateday != null)
            {
                birthDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodybirthdateday);
                birthDateObjectpropCount++;
            }

            if (birthDateObjectpropCount > 0)
            {
                body["birth_date"] = birthDateObject;
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender_code"] = CSharpExpressionConverter.ConvertToken(bodygender);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["web_address"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = CSharpExpressionConverter.ConvertToken(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodydeceased != null)
            {
                body["deceased"] = CSharpExpressionConverter.ConvertToken(bodydeceased);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = CSharpExpressionConverter.ConvertToken(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = CSharpExpressionConverter.ConvertToken(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> CreateConstituentInteraction(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysummary, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyexpectedDate, Expression<Func<string>> bodycontactMethod, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyotherLocation = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgNewConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = "/crm-conmg/interactions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["objective"] = CSharpExpressionConverter.ConvertToken(bodysummary);
            bodypropCount++;
            body["status"] = CSharpExpressionConverter.Convert(bodystatus);
            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStartminute);
                expectedStartTimeObjectpropCount++;
            }

            if (expectedStartTimeObjectpropCount > 0)
            {
                body["expected_start_time"] = expectedStartTimeObject;
                bodypropCount++;
            }

            var expectedEndTimeObject = new JObject();
            var expectedEndTimeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expectedEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            if (bodyownerID != null)
            {
                body["fundraiser_id"] = CSharpExpressionConverter.ConvertToken(bodyownerID);
                bodypropCount++;
            }

            bodypropCount++;
            body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
            if (bodyeventID != null)
            {
                body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodyotherLocation != null)
            {
                body["other_location"] = CSharpExpressionConverter.ConvertToken(bodyotherLocation);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentInteraction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentInteraction> GetConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentInteraction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentInteraction(Expression<Func<string>> constituentInteractionId, Expression<Func<string>> bodysummary = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgUpdateConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysummary != null)
            {
                body["objective"] = CSharpExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
                bodypropCount++;
            }

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStartminute);
                expectedStartTimeObjectpropCount++;
            }

            if (expectedStartTimeObjectpropCount > 0)
            {
                body["expected_start_time"] = expectedStartTimeObject;
                bodypropCount++;
            }

            var expectedEndTimeObject = new JObject();
            var expectedEndTimeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expectedEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            if (bodyownerID != null)
            {
                body["fundraiser_id"] = CSharpExpressionConverter.ConvertToken(bodyownerID);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgMergedConstituent> MergeTwoConstituents(Expression<Func<string>> bodysourceConstituentID, Expression<Func<string>> bodytargetConstituentID, Expression<Func<string>> bodyconfiguration, Expression<Func<bool>> bodydeleteSource, Expression<Func<bodydeleteActionInput>> bodydeleteAction, Expression<Func<string>> bodyinactiveReason = null, Expression<Func<string>> bodyinactivityDetails = null)
        {
            var apiCallPath = "/crm-conmg/mergetwoconstituents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["source_id"] = CSharpExpressionConverter.ConvertToken(bodysourceConstituentID);
            bodypropCount++;
            body["target_id"] = CSharpExpressionConverter.ConvertToken(bodytargetConstituentID);
            bodypropCount++;
            body["config"] = CSharpExpressionConverter.ConvertToken(bodyconfiguration);
            bodypropCount++;
            body["delete_source"] = CSharpExpressionConverter.ConvertToken(bodydeleteSource);
            bodypropCount++;
            body["delete_source_constituent"] = CSharpExpressionConverter.Convert(bodydeleteAction);
            if (bodyinactiveReason != null)
            {
                body["constituent_inactivity_reason_code"] = CSharpExpressionConverter.ConvertToken(bodyinactiveReason);
                bodypropCount++;
            }

            if (bodyinactivityDetails != null)
            {
                body["constituent_inactivity_details"] = CSharpExpressionConverter.ConvertToken(bodyinactivityDetails);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgMergedConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = "/crm-conmg/organizations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodyindustry != null)
            {
                body["industry"] = CSharpExpressionConverter.ConvertToken(bodyindustry);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["num_employees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodynoOfSubsidiaryOrgs != null)
            {
                body["num_subsidiaries"] = CSharpExpressionConverter.ConvertToken(bodynoOfSubsidiaryOrgs);
                bodypropCount++;
            }

            if (bodyparentOrg != null)
            {
                body["parent_corp_id"] = CSharpExpressionConverter.ConvertToken(bodyparentOrg);
                bodypropCount++;
            }

            if (bodyaddressType != null)
            {
                body["address_type"] = CSharpExpressionConverter.ConvertToken(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["address_country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["address_city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["address_state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["address_postcode"] = CSharpExpressionConverter.ConvertToken(bodypostalCode);
                bodypropCount++;
            }

            if (bodydoNotSendMail != null)
            {
                body["address_do_not_mail"] = CSharpExpressionConverter.ConvertToken(bodydoNotSendMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["address_do_not_mail_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = CSharpExpressionConverter.ConvertToken(bodydPC);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["cart"] = CSharpExpressionConverter.ConvertToken(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["lot"] = CSharpExpressionConverter.ConvertToken(bodylOT);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = CSharpExpressionConverter.ConvertToken(bodycounty);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = CSharpExpressionConverter.ConvertToken(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodyphoneType != null)
            {
                body["phone_type"] = CSharpExpressionConverter.ConvertToken(bodyphoneType);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phone_number"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyemailType != null)
            {
                body["email_address_type"] = CSharpExpressionConverter.ConvertToken(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodywebAddress != null)
            {
                body["web_address"] = CSharpExpressionConverter.ConvertToken(bodywebAddress);
                bodypropCount++;
            }

            if (bodyisPrimaryOrganization != null)
            {
                body["is_primary"] = CSharpExpressionConverter.ConvertToken(bodyisPrimaryOrganization);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = CSharpExpressionConverter.ConvertToken(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = CSharpExpressionConverter.ConvertToken(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> GetOrganizationConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/organizations/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditOrganizationConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/organizations/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["organization_name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = CSharpExpressionConverter.ConvertToken(bodyindustry);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["num_employees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodynoOfSubsidiaryOrgs != null)
            {
                body["num_subsidiaries"] = CSharpExpressionConverter.ConvertToken(bodynoOfSubsidiaryOrgs);
                bodypropCount++;
            }

            if (bodyparentOrg != null)
            {
                body["parent_corp_id"] = CSharpExpressionConverter.ConvertToken(bodyparentOrg);
                bodypropCount++;
            }

            if (bodywebAddress != null)
            {
                body["web_address"] = CSharpExpressionConverter.ConvertToken(bodywebAddress);
                bodypropCount++;
            }

            if (bodyisPrimaryOrganization != null)
            {
                body["is_primary"] = CSharpExpressionConverter.ConvertToken(bodyisPrimaryOrganization);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = CSharpExpressionConverter.ConvertToken(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = CSharpExpressionConverter.ConvertToken(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> CreateConstituentPhone(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodynumber, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/crm-conmg/phones";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            if (bodytype != null)
            {
                body["phone_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = CSharpExpressionConverter.ConvertToken(bodynumber);
            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            var startTimeObject = new JObject();
            var startTimeObjectpropCount = 0;
            if (bodycallAfterhour != null)
            {
                startTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodycallAfterhour);
                startTimeObjectpropCount++;
            }

            if (bodycallAfterminute != null)
            {
                startTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodycallAfterminute);
                startTimeObjectpropCount++;
            }

            if (startTimeObjectpropCount > 0)
            {
                body["start_time"] = startTimeObject;
                bodypropCount++;
            }

            var endTimeObject = new JObject();
            var endTimeObjectpropCount = 0;
            if (bodycallBeforehour != null)
            {
                endTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodycallBeforehour);
                endTimeObjectpropCount++;
            }

            if (bodycallBeforeminute != null)
            {
                endTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodycallBeforeminute);
                endTimeObjectpropCount++;
            }

            if (endTimeObjectpropCount > 0)
            {
                body["end_time"] = endTimeObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = CSharpExpressionConverter.ConvertToken(bodydoNotCall);
                bodypropCount++;
            }

            if (bodydoNotCallReason != null)
            {
                body["do_not_call_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotCallReason);
                bodypropCount++;
            }

            if (bodydoNotText != null)
            {
                body["donottext"] = CSharpExpressionConverter.ConvertToken(bodydoNotText);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            var seasonalStartDateObject = new JObject();
            var seasonalStartDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                seasonalStartDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                seasonalStartDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                seasonalStartDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartday);
                seasonalStartDateObjectpropCount++;
            }

            if (seasonalStartDateObjectpropCount > 0)
            {
                body["seasonal_start_date"] = seasonalStartDateObject;
                bodypropCount++;
            }

            var seasonalEndDateObject = new JObject();
            var seasonalEndDateObjectpropCount = 0;
            if (bodyseasonalEndmonth != null)
            {
                seasonalEndDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                seasonalEndDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                seasonalEndDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndday);
                seasonalEndDateObjectpropCount++;
            }

            if (seasonalEndDateObjectpropCount > 0)
            {
                body["seasonal_end_date"] = seasonalEndDateObject;
                bodypropCount++;
            }

            if (bodyorigin != null)
            {
                body["origin"] = CSharpExpressionConverter.Convert(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_phone"] = CSharpExpressionConverter.ConvertToken(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_phone"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentPhone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentPhone(Expression<Func<string>> constituentPhoneId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/phones/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentPhoneId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentPhone(Expression<Func<string>> constituentPhoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/phones/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentPhoneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["phone_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = CSharpExpressionConverter.ConvertToken(bodynumber);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            var startTimeObject = new JObject();
            var startTimeObjectpropCount = 0;
            if (bodycallAfterhour != null)
            {
                startTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodycallAfterhour);
                startTimeObjectpropCount++;
            }

            if (bodycallAfterminute != null)
            {
                startTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodycallAfterminute);
                startTimeObjectpropCount++;
            }

            if (startTimeObjectpropCount > 0)
            {
                body["start_time"] = startTimeObject;
                bodypropCount++;
            }

            var endTimeObject = new JObject();
            var endTimeObjectpropCount = 0;
            if (bodycallBeforehour != null)
            {
                endTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodycallBeforehour);
                endTimeObjectpropCount++;
            }

            if (bodycallBeforeminute != null)
            {
                endTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodycallBeforeminute);
                endTimeObjectpropCount++;
            }

            if (endTimeObjectpropCount > 0)
            {
                body["end_time"] = endTimeObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = CSharpExpressionConverter.ConvertToken(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotCall != null)
            {
                body["do_not_call"] = CSharpExpressionConverter.ConvertToken(bodydoNotCall);
                bodypropCount++;
            }

            if (bodydoNotCallReason != null)
            {
                body["do_not_call_reason"] = CSharpExpressionConverter.ConvertToken(bodydoNotCallReason);
                bodypropCount++;
            }

            if (bodydoNotText != null)
            {
                body["donottext"] = CSharpExpressionConverter.ConvertToken(bodydoNotText);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = CSharpExpressionConverter.ConvertToken(bodyisConfidential);
                bodypropCount++;
            }

            var seasonalStartDateObject = new JObject();
            var seasonalStartDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                seasonalStartDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                seasonalStartDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                seasonalStartDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalStartday);
                seasonalStartDateObjectpropCount++;
            }

            if (seasonalStartDateObjectpropCount > 0)
            {
                body["seasonal_start_date"] = seasonalStartDateObject;
                bodypropCount++;
            }

            var seasonalEndDateObject = new JObject();
            var seasonalEndDateObjectpropCount = 0;
            if (bodyseasonalEndmonth != null)
            {
                seasonalEndDateObject["month"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                seasonalEndDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                seasonalEndDateObject["day"] = CSharpExpressionConverter.ConvertToken(bodyseasonalEndday);
                seasonalEndDateObjectpropCount++;
            }

            if (seasonalEndDateObjectpropCount > 0)
            {
                body["seasonal_end_date"] = seasonalEndDateObject;
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = CSharpExpressionConverter.ConvertToken(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = CSharpExpressionConverter.ConvertToken(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_phone"] = CSharpExpressionConverter.ConvertToken(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_phone"] = CSharpExpressionConverter.ConvertToken(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> CreateConstituentEmploymentHistory(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationship, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodysyncEndDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var apiCallPath = "/crm-conmg/relationshipjobsinfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["relationship"] = CSharpExpressionConverter.ConvertToken(bodyrelationship);
            if (bodyjobTitle != null)
            {
                body["job_title"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycareerLevel != null)
            {
                body["career_level"] = CSharpExpressionConverter.ConvertToken(bodycareerLevel);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["job_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodysyncEndDate != null)
            {
                body["sync_end_date_to_relationship"] = CSharpExpressionConverter.ConvertToken(bodysyncEndDate);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["job_department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["job_division"] = CSharpExpressionConverter.ConvertToken(bodydivision);
                bodypropCount++;
            }

            if (bodycareerLevel2 != null)
            {
                body["job_schedule"] = CSharpExpressionConverter.ConvertToken(bodycareerLevel2);
                bodypropCount++;
            }

            if (bodyresponsibilities != null)
            {
                body["job_responsibility"] = CSharpExpressionConverter.ConvertToken(bodyresponsibilities);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["private_record"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmploymentHistory>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipJobInfoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodysyncEndDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipJobInfoId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyjobTitle != null)
            {
                body["job_title"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycareerLevel != null)
            {
                body["career_level"] = CSharpExpressionConverter.ConvertToken(bodycareerLevel);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["job_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodysyncEndDate != null)
            {
                body["sync_end_date_to_relationship"] = CSharpExpressionConverter.ConvertToken(bodysyncEndDate);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["job_department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["job_division"] = CSharpExpressionConverter.ConvertToken(bodydivision);
                bodypropCount++;
            }

            if (bodycareerLevel2 != null)
            {
                body["job_schedule"] = CSharpExpressionConverter.ConvertToken(bodycareerLevel2);
                bodypropCount++;
            }

            if (bodyresponsibilities != null)
            {
                body["job_responsibility"] = CSharpExpressionConverter.ConvertToken(bodyresponsibilities);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["private_record"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/crm-conmg/solicitcodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["solicit_code"] = CSharpExpressionConverter.ConvertToken(bodysolicitCode);
            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentSolicitCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/solicitcodes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-conmg/solicitcodes/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysolicitCode != null)
            {
                body["solicit_code"] = CSharpExpressionConverter.ConvertToken(bodysolicitCode);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudcrmconstituTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConmgCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyoriginInput
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "web forms")]
        WebForms
    }

    public class ConmgCreatedConstituentAlternateLookupID
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentAppealResponse
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgConstituentAppealCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgConstituentAppeal[] Value { get; set; }
    }

    public class ConmgConstituentAppeal
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("appeal")]
        public string AppealName { get; set; }

        [JsonProperty("description")]
        public string AppealDescription { get; set; }

        [JsonProperty("mkt_segmentation_id")]
        public string MailingID { get; set; }

        [JsonProperty("mailing")]
        public string MailingName { get; set; }

        [JsonProperty("mailing_family_type_code")]
        public int MailingFamilyTypeCode { get; set; }

        [JsonProperty("date_sent")]
        public string DateSent { get; set; }

        [JsonProperty("package")]
        public string PackageName { get; set; }

        [JsonProperty("source_code")]
        public string SourceCode { get; set; }

        [JsonProperty("mkt_segmentation_segment_id")]
        public string SegmentID { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("finder_number")]
        public int FinderNumber { get; set; }

        [JsonProperty("test_segment")]
        public string TestSegment { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("has_responses")]
        public bool HasResponses { get; set; }

        [JsonProperty("appeal_mailing")]
        public bool AppealMailing { get; set; }

        [JsonProperty("time_frame_text")]
        public string TimeFrame { get; set; }

        [JsonProperty("time_frame_group_sort")]
        public string TimeFrameGroupSort { get; set; }
    }

    public class ConmgCreatedConstituentCorrespondence
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgConstituentSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgConstituentSearchResult[] Value { get; set; }
    }

    public class ConmgConstituentSearchResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("suffixcodeid")]
        public string SuffixCodeID { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("sort_constituent_name")]
        public string SortName { get; set; }

        [JsonProperty("country_id")]
        public string CountryID { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("post_code")]
        public string Postcode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("classof")]
        public int ClassOf { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("organization")]
        public bool IsOrganization { get; set; }

        [JsonProperty("group")]
        public bool IsGroup { get; set; }

        [JsonProperty("household")]
        public bool IsHousehold { get; set; }

        [JsonProperty("prospectmanager")]
        public string ProspectManager { get; set; }
    }

    public class ConmgAddressCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAddress[] Value { get; set; }
    }

    public class ConmgAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contact_info")]
        public string Address { get; set; }

        [JsonProperty("primary")]
        public string IsPrimary { get; set; }

        [JsonProperty("confidential")]
        public bool IsConfidential { get; set; }

        [JsonProperty("former")]
        public bool IsFormer { get; set; }

        [JsonProperty("do_not_contact")]
        public string DoNotContact { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("geocoded")]
        public bool Geocoded { get; set; }

        [JsonProperty("pending_geocode")]
        public bool PendingGeocode { get; set; }

        [JsonProperty("invalid_geocode")]
        public bool InvalidGeocode { get; set; }

        [JsonProperty("map_context_id")]
        public string MapContextID { get; set; }
    }

    public class ConmgAlternateLookupIDCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAlternateLookupID[] Value { get; set; }
    }

    public class ConmgAlternateLookupID
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("alternate_lookup_id")]
        public string AlternateLookupID { get; set; }
    }

    public class ConmgAttributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAttribute[] Value { get; set; }
    }

    public class ConmgAttribute
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("attribute_category_id")]
        public string CategoryID { get; set; }

        [JsonProperty("attribute_group")]
        public string Group { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class ConmgConstituentPrimaryContactInfo
    {
        [JsonProperty("address_type_label")]
        public string AddressType { get; set; }

        [JsonProperty("address_type_id")]
        public string AddressTypeID { get; set; }

        [JsonProperty("country_id")]
        public string PrimaryAddressCountryID { get; set; }

        [JsonProperty("address")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("city")]
        public string PrimaryAddressCity { get; set; }

        [JsonProperty("state_id")]
        public string PrimaryAddressStateID { get; set; }

        [JsonProperty("post_code")]
        public string PrimaryAddressPostalCode { get; set; }

        [JsonProperty("confidential")]
        public bool IsAddressConfidential { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("do_not_mail_reason_code_id")]
        public string DoNotMailReasonID { get; set; }

        [JsonProperty("phone_type_label")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_type_id")]
        public string PrimaryPhoneTypeID { get; set; }

        [JsonProperty("phone")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("phone_is_confidential")]
        public bool IsPhoneConfidential { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("do_not_call_reason_code_id")]
        public string DoNotCallReasonID { get; set; }

        [JsonProperty("email_type_label")]
        public string PrimaryEmailAddressType { get; set; }

        [JsonProperty("email_type_id")]
        public string PrimaryEmailAddressTypeID { get; set; }

        [JsonProperty("email")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }
    }

    public class ConmgEducationCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEducation[] Value { get; set; }
    }

    public class ConmgEducation
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string EducationalInstitution { get; set; }

        [JsonProperty("education_history_status")]
        public string Status { get; set; }

        [JsonProperty("primary_record")]
        public bool Primary { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("class_of")]
        public int ClassOf { get; set; }

        [JsonProperty("affiliated")]
        public bool Afflilated { get; set; }

        [JsonProperty("start_date")]
        public ConmgEducationFromType From { get; set; }

        [JsonProperty("end_date")]
        public ConmgEducationToType To { get; set; }
    }

    public class ConmgEducationFromType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgEducationToType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgEmailAddressCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEmailAddress[] Value { get; set; }
    }

    public class ConmgEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }
    }

    public class ConmgPhoneCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgPhone[] Value { get; set; }
    }

    public class ConmgPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone_number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("donotcall")]
        public bool DoNotCall { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("info_source_comments")]
        public string InfoSourceComments { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("start_time")]
        public ConmgPhoneCallAfterType CallAfter { get; set; }

        [JsonProperty("end_time")]
        public ConmgPhoneCallBeforeType CallBefore { get; set; }
    }

    public class ConmgPhoneCallAfterType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgPhoneCallBeforeType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentProfilePicture
    {
        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("key_name")]
        public string KeyName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("nick_name")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }
    }

    public class ConmgEmploymentHistoryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgEmploymentHistory[] Value { get; set; }
    }

    public class ConmgEmploymentHistory
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Relationship { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("job_schedule")]
        public string CareerLevel { get; set; }

        [JsonProperty("job_category")]
        public string Category { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("job_department")]
        public string Department { get; set; }

        [JsonProperty("job_division")]
        public string Division { get; set; }

        [JsonProperty("job_responsibility")]
        public string Responsibilities { get; set; }

        [JsonProperty("private_record")]
        public bool IsPrivate { get; set; }
    }

    public class ConmgSolicitCodeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgSolicitCode[] Value { get; set; }
    }

    public class ConmgSolicitCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }
    }

    public enum dateRangeInput
    {
        [EnumMember(Value = "All dates")]
        AllDates,
        [EnumMember(Value = "Last 30 days")]
        Last30Days,
        [EnumMember(Value = "Last 60 days")]
        Last60Days,
        [EnumMember(Value = "Last 90 days")]
        Last90Days,
        [EnumMember(Value = "Last 6 months")]
        Last6Months,
        [EnumMember(Value = "Last year")]
        LastYear,
        [EnumMember(Value = "Last 2 years")]
        Last2Years
    }

    public class ConmgTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgTribute[] Value { get; set; }
    }

    public class ConmgTribute
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("tribute_type")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_text")]
        public string TributeText { get; set; }

        [JsonProperty("tributee")]
        public bool IsTributee { get; set; }

        [JsonProperty("acknowledgee")]
        public bool IsAcknowledgee { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }
    }

    public class ConmgConstituentSummaryProfile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("constituent_profile")]
        public bool IsAConstituentProfile { get; set; }

        [JsonProperty("organization")]
        public bool IsOrganization { get; set; }

        [JsonProperty("top_parent")]
        public string ParentOrganization { get; set; }

        [JsonProperty("top_parent_id")]
        public string ParentOrganizationID { get; set; }

        [JsonProperty("group")]
        public bool IsGroup { get; set; }

        [JsonProperty("dissolved")]
        public bool IsGroupDissolved { get; set; }

        [JsonProperty("group_type")]
        public string GroupType { get; set; }

        [JsonProperty("group_member_count")]
        public int NumberOfGroupMembers { get; set; }

        [JsonProperty("committee_member")]
        public bool IsCommitteeMember { get; set; }

        [JsonProperty("household")]
        public bool IsHousehold { get; set; }

        [JsonProperty("household_id")]
        public string HouseholdID { get; set; }

        [JsonProperty("household_text")]
        public string HouseholdText { get; set; }

        [JsonProperty("inactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("constituent_inactivity_reason")]
        public string InactivityReason { get; set; }

        [JsonProperty("deceased")]
        public bool IsDeceased { get; set; }

        [JsonProperty("deceaseddate")]
        public ConmgConstituentSummaryProfileSourceDateType SourceDate { get; set; }

        [JsonProperty("spouse_deceased")]
        public bool IsSpouseDeceased { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("declarations_on_file")]
        public bool DeclarationsOnFile { get; set; }

        [JsonProperty("wealthpoint_update_pending")]
        public bool WealthPointUpdatePending { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("primary_business")]
        public string PrimaryBusiness { get; set; }

        [JsonProperty("primary_business_id")]
        public string PrimaryBusinessID { get; set; }

        [JsonProperty("primary_education")]
        public string PrimaryEducation { get; set; }

        [JsonProperty("primary_education_id")]
        public string PrimaryEducationID { get; set; }

        [JsonProperty("education_attribute_defined")]
        public bool EducationAttributesDefined { get; set; }

        [JsonProperty("related_constituent")]
        public string RelatedConstituent { get; set; }

        [JsonProperty("related_constituent_id")]
        public string RelatedConstituentID { get; set; }

        [JsonProperty("solicit_code_count")]
        public int SolicitCodeCount { get; set; }

        [JsonProperty("address_id")]
        public string PrimaryAddressID { get; set; }

        [JsonProperty("address")]
        public string PrimaryAddress { get; set; }

        [JsonProperty("address_is_confidential")]
        public bool IsAddressConfidential { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("phone_number_id")]
        public string PrimaryPhoneID { get; set; }

        [JsonProperty("phone_type")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("phone_is_confidential")]
        public bool IsPhoneConfidential { get; set; }

        [JsonProperty("do_not_phone")]
        public bool DoNotCall { get; set; }

        [JsonProperty("email_address_id")]
        public string PrimaryEmailAddressID { get; set; }

        [JsonProperty("email_address")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("registrant_status_text")]
        public string RegistrantStatusText { get; set; }

        [JsonProperty("vendor_status_text")]
        public string VendorStatusText { get; set; }

        [JsonProperty("alumnus_status_text")]
        public string AlumnusStatusText { get; set; }

        [JsonProperty("alumnus_enrollment_id")]
        public string AlumnusEnrollmentID { get; set; }

        [JsonProperty("current_enrollment_id")]
        public string CurrentEnrollmentID { get; set; }

        [JsonProperty("current_enrollment_id_2")]
        public string CurrentEnrollmentID2 { get; set; }

        [JsonProperty("current_enrollment_id_3")]
        public string CurrentEnrollmentID3 { get; set; }

        [JsonProperty("student_enrollment_id")]
        public string StudentEnrollmentID { get; set; }

        [JsonProperty("current_school")]
        public string CurrentSchool { get; set; }

        [JsonProperty("current_school_2")]
        public string CurrentSchool2 { get; set; }

        [JsonProperty("current_school_3")]
        public string CurrentSchool3 { get; set; }

        [JsonProperty("lifecycle_stage")]
        public string LifecycleStage { get; set; }

        [JsonProperty("lifecycle_stage_as_of")]
        public string LifecycleStageAsOf { get; set; }

        [JsonProperty("planned_giver_stage")]
        public string PlannedGiverStage { get; set; }

        [JsonProperty("planned_giver_stage_as_of")]
        public string PlannedGiverStageAsOf { get; set; }

        [JsonProperty("donor_state")]
        public string DonorState { get; set; }

        [JsonProperty("donor_state_code")]
        public int DonorStateCode { get; set; }

        [JsonProperty("sponsor_type_code")]
        public int SponsorTypeCode { get; set; }

        [JsonProperty("last_revenue_date")]
        public string LastRevenueDate { get; set; }

        [JsonProperty("alumnus_constituency_text")]
        public string AlumnusConstituencyText { get; set; }

        [JsonProperty("advocate_constituency_text")]
        public string AdvocateConstituencyText { get; set; }

        [JsonProperty("bank_constituency_text")]
        public string BankConstituencyText { get; set; }

        [JsonProperty("board_member_constituency_text")]
        public string BoardMemberConstituencyText { get; set; }

        [JsonProperty("committee_constituency_text")]
        public string CommitteeConstituencyText { get; set; }

        [JsonProperty("committee_member_constituency_text")]
        public string CommitteeMemberConstituencyText { get; set; }

        [JsonProperty("community_member_constituency_text")]
        public string CommunityMemberConstituencyText { get; set; }

        [JsonProperty("donor_constituency_text")]
        public string DonorConstituencyText { get; set; }

        [JsonProperty("faculty_constituency_text")]
        public string FacultyConstituencyText { get; set; }

        [JsonProperty("fundraiser_constituency_text")]
        public string FundraiserConstituencyText { get; set; }

        [JsonProperty("fundraising_group_constituency_text")]
        public string FundraisingGroupConstituencyText { get; set; }

        [JsonProperty("grantor_constituency_text")]
        public string GrantorConstituencyText { get; set; }

        [JsonProperty("loyal_donor_constituency_text")]
        public string LoyalDonorConstituencyText { get; set; }

        [JsonProperty("major_donor_constituency_text")]
        public string MajorDonorConstituencyText { get; set; }

        [JsonProperty("matchfinder_constituency_text")]
        public string MatchFinderConstituencyText { get; set; }

        [JsonProperty("matchfinder_online_record_id")]
        public int MatchFinderOnlineRecordID { get; set; }

        [JsonProperty("member_constituency_text")]
        public string MemberConstituencyText { get; set; }

        [JsonProperty("nfg_constituency_text")]
        public string NFGConstituencyText { get; set; }

        [JsonProperty("patron_constituency_text")]
        public string PatronConstituencyText { get; set; }

        [JsonProperty("plannedgiverconstituencytext")]
        public string PlannedGiverConstituencyText { get; set; }

        [JsonProperty("prospect_constituency_text")]
        public string ProspectConstituencyText { get; set; }

        [JsonProperty("recognition_constituency_text")]
        public string RecognitionConstituencyText { get; set; }

        [JsonProperty("relation_constituency_text")]
        public string RelationConstituencyText { get; set; }

        [JsonProperty("sponsor_constituency_text")]
        public string SponsorConstituencyText { get; set; }

        [JsonProperty("staff_constituency_text")]
        public string StaffConstituencyText { get; set; }

        [JsonProperty("student_constituency_text")]
        public string StudentConstituencyText { get; set; }

        [JsonProperty("student_relation_constituency_text")]
        public string StudentRelationConstituencyText { get; set; }

        [JsonProperty("user_defined_constituency_text")]
        public string UserDefinedConstituencyText { get; set; }

        [JsonProperty("volunteer_constituency_text")]
        public string VolunteerConstituencyText { get; set; }

        [JsonProperty("constituencies_display_order")]
        public ConmgConstituencyDisplayOrder[] ConstituenciesDisplayOrder { get; set; }

        [JsonProperty("user_defined_constituencies")]
        public ConmgUserDefinedConstituency[] UserDefinedConstituencies { get; set; }

        [JsonProperty("student_relation_constituencies")]
        public ConmgStudentRelationConstituency[] StudentRelationConstituencies { get; set; }

        [JsonProperty("social_media_accounts")]
        public ConmgConstituentSocialMediaAccount[] SocialMediaAccounts { get; set; }
    }

    public class ConmgConstituentSummaryProfileSourceDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgConstituencyDisplayOrder
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("system")]
        public bool IsSystem { get; set; }
    }

    public class ConmgUserDefinedConstituency
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class ConmgStudentRelationConstituency
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }
    }

    public class ConmgConstituentSocialMediaAccount
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("social_media_service_id")]
        public string ServiceID { get; set; }

        [JsonProperty("social_media_service_name")]
        public string ServiceName { get; set; }

        [JsonProperty("social_media_service_icon")]
        public string Icon { get; set; }

        [JsonProperty("social_media_account_type_code_id")]
        public string AccountTypeID { get; set; }

        [JsonProperty("social_media_account_type")]
        public string AccountType { get; set; }

        [JsonProperty("user_id")]
        public string UserID { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info_source_code_id")]
        public string InfoSourceCodeID { get; set; }

        [JsonProperty("info_source")]
        public string InfoSource { get; set; }

        [JsonProperty("do_not_contact")]
        public bool DoNotContact { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class ConmgCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedFundraiserConstituency
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgIndividualConstituent
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStatus { get; set; }

        [JsonProperty("birth_date")]
        public ConmgIndividualConstituentSourceDateType SourceDate { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("gender_code")]
        public string Gender { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfilePictureThumbnail { get; set; }
    }

    public class ConmgIndividualConstituentSourceDateType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }
    }

    public class ConmgCreatedConstituentInteraction
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodystatusInput
    {
        Pending,
        Completed,
        Canceled,
        Declined
    }

    public class ConmgNewConstituentInteractionParticipant
    {
        [JsonProperty("constituent_id")]
        public string ConstitID { get; set; }
    }

    public class ConmgConstituentInteraction
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("constituent_name")]
        public string ConstituentName { get; set; }

        [JsonProperty("objective")]
        public string Summary { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_start_time")]
        public ConmgConstituentInteractionExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public ConmgConstituentInteractionExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public ConmgConstituentInteractionActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public ConmgConstituentInteractionActualEndType ActualEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("all_day_event")]
        public bool AllDayEvent { get; set; }

        [JsonProperty("fundraiser_id")]
        public string OwnerID { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("participants")]
        public ConmgConstituentInteractionParticipant[] Participants { get; set; }
    }

    public class ConmgConstituentInteractionExpectedStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionExpectedEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionActualStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionActualEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class ConmgConstituentInteractionParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }
    }

    public class ConmgUpdateConstituentInteractionParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }
    }

    public class ConmgMergedConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodydeleteActionInput
    {
        [EnumMember(Value = "delete source constituent")]
        DeleteSourceConstituent,
        [EnumMember(Value = "mark source constituent inactive")]
        MarkSourceConstituentInactive
    }

    public class ConmgCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgOrganizationConstituent
    {
        [JsonProperty("organization_name")]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("parent_corp_id")]
        public string ParentCorporation { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("num_subsidiaries")]
        public int NumberOfSubsidiaries { get; set; }

        [JsonProperty("web_address")]
        public string Website { get; set; }

        [JsonProperty("is_primary")]
        public bool IsAPrimaryOrganization { get; set; }

        [JsonProperty("picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("picture_thumbnail")]
        public string ProfilePictureThumbnail { get; set; }

        [JsonProperty("primary_address_id")]
        public string PrimaryAddressID { get; set; }

        [JsonProperty("address_type")]
        public string PrimaryAddressType { get; set; }

        [JsonProperty("address_country")]
        public string PrimaryAddressCountry { get; set; }

        [JsonProperty("address_block")]
        public string PrimaryAddressBlock { get; set; }

        [JsonProperty("address_city")]
        public string PrimaryAddressCity { get; set; }

        [JsonProperty("address_state")]
        public string PrimaryAddressState { get; set; }

        [JsonProperty("address_postcode")]
        public string PrimaryAddressPostalCode { get; set; }

        [JsonProperty("address_do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("address_do_not_mail_reason")]
        public string DoNotMailReason { get; set; }

        [JsonProperty("primary_phone_id")]
        public string PrimaryPhoneID { get; set; }

        [JsonProperty("phone_type")]
        public string PrimaryPhoneType { get; set; }

        [JsonProperty("phone_number")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("primary_email_address_id")]
        public string PrimaryEmailAddressID { get; set; }

        [JsonProperty("email_address_type")]
        public string PrimaryEmailAddressType { get; set; }

        [JsonProperty("email_address")]
        public string PrimaryEmailAddress { get; set; }
    }

    public class ConmgCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentEmploymentHistory
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConmgCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu;

    public partial class WorkflowManagedActions
    {
        public BlackbaudcrmconstituActions Blackbaudcrmconstitu(string connectionId) => new BlackbaudcrmconstituActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudcrmconstituTriggers Blackbaudcrmconstitu(string connectionId) => new BlackbaudcrmconstituTriggers(connectionId);
    }
}