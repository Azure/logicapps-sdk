//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudaltruconsti
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudaltruconstiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> CreateConstituentAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycountry, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyrecentlyMoved = null, Expression<Func<string>> bodyoldAddress = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/alt-conmg/addresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["country"] = ExpressionConverter.ConvertO(bodycountry);
            if (bodytype != null)
            {
                body["address_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = ExpressionConverter.ConvertO(bodyaddress);
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
                body["postcode"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["do_not_mail_reason"] = ExpressionConverter.ConvertO(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                startDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                startDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                startDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
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
                endDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                endDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                endDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                endDateObjectpropCount++;
            }

            if (endDateObjectpropCount > 0)
            {
                body["end_date"] = endDateObject;
                bodypropCount++;
            }

            if (bodyhistoricalStartDate != null)
            {
                body["historical_start_date"] = ExpressionConverter.ConvertO(bodyhistoricalStartDate);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
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

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = ExpressionConverter.ConvertO(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodystateHouseDistrict != null)
            {
                body["state_house_district"] = ExpressionConverter.ConvertO(bodystateHouseDistrict);
                bodypropCount++;
            }

            if (bodystateSenateDistrict != null)
            {
                body["state_senate_district"] = ExpressionConverter.ConvertO(bodystateSenateDistrict);
                bodypropCount++;
            }

            if (bodylocalPrecinct != null)
            {
                body["local_precinct"] = ExpressionConverter.ConvertO(bodylocalPrecinct);
                bodypropCount++;
            }

            if (bodyorigin != null)
            {
                body["origin"] = ExpressionConverter.ConvertO(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodyrecentlyMoved != null)
            {
                body["recent_move"] = ExpressionConverter.ConvertO(bodyrecentlyMoved);
                bodypropCount++;
            }

            if (bodyoldAddress != null)
            {
                body["old_address"] = ExpressionConverter.ConvertO(bodyoldAddress);
                bodypropCount++;
            }

            if (bodyomitFromValidation != null)
            {
                body["omit_from_validation"] = ExpressionConverter.ConvertO(bodyomitFromValidation);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_addresses"] = ExpressionConverter.ConvertO(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_addresses"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAddress(Expression<Func<string>> constituentAddressId)
        {
            var apiCallPath = String.Format("/alt-conmg/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAddressId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAddress(Expression<Func<string>> constituentAddressId, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodyhistoricalEndDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodyupdateContacts = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = String.Format("/alt-conmg/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["address_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = ExpressionConverter.ConvertO(bodyaddress);
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
                body["postcode"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodydoNotMail != null)
            {
                body["do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["do_not_mail_reason"] = ExpressionConverter.ConvertO(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                startDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                startDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                startDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
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
                endDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                endDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                endDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                endDateObjectpropCount++;
            }

            if (endDateObjectpropCount > 0)
            {
                body["end_date"] = endDateObject;
                bodypropCount++;
            }

            if (bodyhistoricalStartDate != null)
            {
                body["historical_start_date"] = ExpressionConverter.ConvertO(bodyhistoricalStartDate);
                bodypropCount++;
            }

            if (bodyhistoricalEndDate != null)
            {
                body["historical_end_date"] = ExpressionConverter.ConvertO(bodyhistoricalEndDate);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
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

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = ExpressionConverter.ConvertO(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodystateHouseDistrict != null)
            {
                body["state_house_district"] = ExpressionConverter.ConvertO(bodystateHouseDistrict);
                bodypropCount++;
            }

            if (bodystateSenateDistrict != null)
            {
                body["state_senate_district"] = ExpressionConverter.ConvertO(bodystateSenateDistrict);
                bodypropCount++;
            }

            if (bodylocalPrecinct != null)
            {
                body["local_precinct"] = ExpressionConverter.ConvertO(bodylocalPrecinct);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodyomitFromValidation != null)
            {
                body["omit_from_validation"] = ExpressionConverter.ConvertO(bodyomitFromValidation);
                bodypropCount++;
            }

            if (bodyupdateContacts != null)
            {
                body["update_contacts"] = ExpressionConverter.ConvertO(bodyupdateContacts);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_addresses"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> CreateConstituentAlternateLookupID(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodyalternateLookupID)
        {
            var apiCallPath = "/alt-conmg/alternatelookupids";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["alternate_lookup_id_type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["alternate_lookup_id"] = ExpressionConverter.ConvertO(bodyalternateLookupID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAlternateLookupID>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId)
        {
            var apiCallPath = String.Format("/alt-conmg/alternatelookupids/{0}", ExpressionConverter.ConvertWithUrlEncoding(alternateLookupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyalternateLookupID = null)
        {
            var apiCallPath = String.Format("/alt-conmg/alternatelookupids/{0}", ExpressionConverter.ConvertWithUrlEncoding(alternateLookupId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["alternate_lookup_id_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyalternateLookupID != null)
            {
                body["alternate_lookup_id"] = ExpressionConverter.ConvertO(bodyalternateLookupID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> CreateConstituentAppealResponse(Expression<Func<string>> bodyconstituentAppealID, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyresponse, Expression<Func<string>> bodydate = null)
        {
            var apiCallPath = "/alt-conmg/constituentappealresponses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_appeal_id"] = ExpressionConverter.ConvertO(bodyconstituentAppealID);
            bodypropCount++;
            body["response_category"] = ExpressionConverter.ConvertO(bodycategory);
            bodypropCount++;
            body["response"] = ExpressionConverter.ConvertO(bodyresponse);
            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppealResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> CreateConstituentAppeal(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyappealID, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/alt-conmg/constituentappeals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["appeal_id"] = ExpressionConverter.ConvertO(bodyappealID);
            if (bodymailing != null)
            {
                body["mkt_segmentation"] = ExpressionConverter.ConvertO(bodymailing);
                bodypropCount++;
            }

            if (bodydateSent != null)
            {
                body["date_sent"] = ExpressionConverter.ConvertO(bodydateSent);
                bodypropCount++;
            }

            if (bodypackage != null)
            {
                body["mkt_package_id"] = ExpressionConverter.ConvertO(bodypackage);
                bodypropCount++;
            }

            if (bodysourceCode != null)
            {
                body["source_code"] = ExpressionConverter.ConvertO(bodysourceCode);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppeal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAppeal(Expression<Func<string>> constituentAppealId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentappeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAppealId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAppeal(Expression<Func<string>> constituentAppealId, Expression<Func<string>> bodyappealID = null, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentappeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAppealId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyappealID != null)
            {
                body["appeal_id"] = ExpressionConverter.ConvertO(bodyappealID);
                bodypropCount++;
            }

            if (bodymailing != null)
            {
                body["mkt_segmentation"] = ExpressionConverter.ConvertO(bodymailing);
                bodypropCount++;
            }

            if (bodydateSent != null)
            {
                body["date_sent"] = ExpressionConverter.ConvertO(bodydateSent);
                bodypropCount++;
            }

            if (bodypackage != null)
            {
                body["mkt_package_id"] = ExpressionConverter.ConvertO(bodypackage);
                bodypropCount++;
            }

            if (bodysourceCode != null)
            {
                body["source_code"] = ExpressionConverter.ConvertO(bodysourceCode);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> ListConstituentAppeals(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentappeals/{0}/appeals", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentAppealCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAttribute(Expression<Func<string>> constituentAttributeId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentattributes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAttributeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> CreateConstituentNote(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var apiCallPath = "/alt-conmg/constituentnotes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["note_type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["date_entered"] = ExpressionConverter.ConvertO(bodydate);
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyauthorID != null)
            {
                body["author_id"] = ExpressionConverter.ConvertO(bodyauthorID);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text_note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodyhTML != null)
            {
                body["html_note"] = ExpressionConverter.ConvertO(bodyhTML);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentNote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentNote(Expression<Func<string>> constituentNoteId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentnotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentNoteId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentNote(Expression<Func<string>> constituentNoteId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var apiCallPath = String.Format("/alt-conmg/constituentnotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentNoteId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["note_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date_entered"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyauthorID != null)
            {
                body["author_id"] = ExpressionConverter.ConvertO(bodyauthorID);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text_note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodyhTML != null)
            {
                body["html_note"] = ExpressionConverter.ConvertO(bodyhTML);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> SearchConstituent(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> emailAddress = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<int>> classof = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> middleName = null, Expression<Func<string>> constituency = null, Expression<Func<string>> sourcecode = null, Expression<Func<bool>> includeIndividuals = null, Expression<Func<bool>> includeOrganizations = null, Expression<Func<bool>> includeGroups = null, Expression<Func<bool>> excludeHouseholds = null, Expression<Func<bool>> checkNickname = null, Expression<Func<bool>> checkAliases = null, Expression<Func<bool>> checkAlternateLookupIds = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/alt-conmg/constituents/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyName != null)
                callPayload.Queries["key_name"] = ExpressionConverter.Convert(keyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(lookupId);
            if (emailAddress != null)
                callPayload.Queries["email_address"] = ExpressionConverter.Convert(emailAddress);
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = ExpressionConverter.Convert(phoneNumber);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (addressBlock != null)
                callPayload.Queries["address_block"] = ExpressionConverter.Convert(addressBlock);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = ExpressionConverter.Convert(postCode);
            if (classof != null)
                callPayload.Queries["classof"] = ExpressionConverter.Convert(classof);
            if (exactMatchOnly != null)
                callPayload.Queries["exact_match_only"] = ExpressionConverter.Convert(exactMatchOnly);
            if (middleName != null)
                callPayload.Queries["middle_name"] = ExpressionConverter.Convert(middleName);
            if (constituency != null)
                callPayload.Queries["constituency"] = ExpressionConverter.Convert(constituency);
            if (sourcecode != null)
                callPayload.Queries["sourcecode"] = ExpressionConverter.Convert(sourcecode);
            if (includeIndividuals != null)
                callPayload.Queries["include_individuals"] = ExpressionConverter.Convert(includeIndividuals);
            if (includeOrganizations != null)
                callPayload.Queries["include_organizations"] = ExpressionConverter.Convert(includeOrganizations);
            if (includeGroups != null)
                callPayload.Queries["include_groups"] = ExpressionConverter.Convert(includeGroups);
            if (excludeHouseholds != null)
                callPayload.Queries["exclude_households"] = ExpressionConverter.Convert(excludeHouseholds);
            if (checkNickname != null)
                callPayload.Queries["check_nickname"] = ExpressionConverter.Convert(checkNickname);
            if (checkAliases != null)
                callPayload.Queries["check_aliases"] = ExpressionConverter.Convert(checkAliases);
            if (checkAlternateLookupIds != null)
                callPayload.Queries["check_alternate_lookup_ids"] = ExpressionConverter.Convert(checkAlternateLookupIds);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(onlyPrimaryAddress);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (fuzzySearchOnName != null)
                callPayload.Queries["fuzzy_search_on_name"] = ExpressionConverter.Convert(fuzzySearchOnName);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<ConmgConstituentSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAddressCollection> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeFormer = null)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeFormer != null)
                callPayload.Queries["include_former"] = ExpressionConverter.Convert(includeFormer);
            return new ApiConnectionAction<ConmgAddressCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> ListConstituentAlternateLookupIDs(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/alternatelookupids", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgAlternateLookupIDCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAttributeCollection> ListConstituentAttributes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/constituentattributelist", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgAttributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> GetConstituentPrimaryContactInfo(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/contactview", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEducationCollection> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/educationalhistories", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgEducationCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> ListConstituentEmailAddresses(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/emailaddresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgEmailAddressCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgPhoneCollection> ListConstituentPhones(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/phones", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgPhoneCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentProfilePicture>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> ListConstituentEmploymentHistory(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/relationshipjobsinfo", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> ListConstituentSolicitCodes(Expression<Func<string>> constituentId, Expression<Func<bool>> showExpired = null, Expression<Func<dateRangeInput>> dateRange = null)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/solicitcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (showExpired != null)
                callPayload.Queries["show_expired"] = ExpressionConverter.Convert(showExpired);
            if (dateRange != null)
                callPayload.Queries["date_range"] = ExpressionConverter.Convert(dateRange);
            return new ApiConnectionAction<ConmgSolicitCodeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgTributeCollection> ListConstituentTributes(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/tributes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgTributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> GetConstituentSummaryProfile(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/constituents/{0}/view", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentSummaryProfile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> CreateConstituentEducation(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyeducationalInstitution, Expression<Func<string>> bodystatus, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var apiCallPath = "/alt-conmg/educationalhistories";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["educational_institution_id"] = ExpressionConverter.ConvertO(bodyeducationalInstitution);
            bodypropCount++;
            body["educational_history_status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodyprimary != null)
            {
                body["primary_record"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyprogram != null)
            {
                body["educational_program"] = ExpressionConverter.ConvertO(bodyprogram);
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["educational_degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodyhonorAwarded != null)
            {
                body["educational_award"] = ExpressionConverter.ConvertO(bodyhonorAwarded);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["educational_source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            var educationalSourceDateObject = new JObject();
            var educationalSourceDateObjectpropCount = 0;
            if (bodysourceDateyear != null)
            {
                educationalSourceDateObject["year"] = ExpressionConverter.ConvertO(bodysourceDateyear);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDatemonth != null)
            {
                educationalSourceDateObject["month"] = ExpressionConverter.ConvertO(bodysourceDatemonth);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDateday != null)
            {
                educationalSourceDateObject["day"] = ExpressionConverter.ConvertO(bodysourceDateday);
                educationalSourceDateObjectpropCount++;
            }

            if (educationalSourceDateObjectpropCount > 0)
            {
                body["educational_source_date"] = educationalSourceDateObject;
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            var dateGraduatedObject = new JObject();
            var dateGraduatedObjectpropCount = 0;
            if (bodydateGraduatedyear != null)
            {
                dateGraduatedObject["year"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                dateGraduatedObject["month"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedday != null)
            {
                dateGraduatedObject["day"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                dateGraduatedObjectpropCount++;
            }

            if (dateGraduatedObjectpropCount > 0)
            {
                body["date_graduated"] = dateGraduatedObject;
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_year"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodypreferredClassOf != null)
            {
                body["preferred_class_year"] = ExpressionConverter.ConvertO(bodypreferredClassOf);
                bodypropCount++;
            }

            if (bodyaffiliated != null)
            {
                body["affiliated"] = ExpressionConverter.ConvertO(bodyaffiliated);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyfromyear != null)
            {
                startDateObject["year"] = ExpressionConverter.ConvertO(bodyfromyear);
                startDateObjectpropCount++;
            }

            if (bodyfrommonth != null)
            {
                startDateObject["month"] = ExpressionConverter.ConvertO(bodyfrommonth);
                startDateObjectpropCount++;
            }

            if (bodyfromday != null)
            {
                startDateObject["day"] = ExpressionConverter.ConvertO(bodyfromday);
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
                dateLeftObject["year"] = ExpressionConverter.ConvertO(bodytoyear);
                dateLeftObjectpropCount++;
            }

            if (bodytomonth != null)
            {
                dateLeftObject["month"] = ExpressionConverter.ConvertO(bodytomonth);
                dateLeftObjectpropCount++;
            }

            if (bodytoday != null)
            {
                dateLeftObject["day"] = ExpressionConverter.ConvertO(bodytoday);
                dateLeftObjectpropCount++;
            }

            if (dateLeftObjectpropCount > 0)
            {
                body["date_left"] = dateLeftObject;
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["educational_history_reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodylevel != null)
            {
                body["educational_history_level"] = ExpressionConverter.ConvertO(bodylevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEducation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEducation(Expression<Func<string>> educationalHistoryId)
        {
            var apiCallPath = String.Format("/alt-conmg/educationalhistories/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationalHistoryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEducation(Expression<Func<string>> educationalHistoryId, Expression<Func<string>> bodyeducationalInstitution = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var apiCallPath = String.Format("/alt-conmg/educationalhistories/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationalHistoryId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyeducationalInstitution != null)
            {
                body["educational_institution_id"] = ExpressionConverter.ConvertO(bodyeducationalInstitution);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["educational_history_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary_record"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyprogram != null)
            {
                body["educational_program"] = ExpressionConverter.ConvertO(bodyprogram);
                bodypropCount++;
            }

            if (bodydegree != null)
            {
                body["educational_degree"] = ExpressionConverter.ConvertO(bodydegree);
                bodypropCount++;
            }

            if (bodyhonorAwarded != null)
            {
                body["educational_award"] = ExpressionConverter.ConvertO(bodyhonorAwarded);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["educational_source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            var educationalSourceDateObject = new JObject();
            var educationalSourceDateObjectpropCount = 0;
            if (bodysourceDateyear != null)
            {
                educationalSourceDateObject["year"] = ExpressionConverter.ConvertO(bodysourceDateyear);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDatemonth != null)
            {
                educationalSourceDateObject["month"] = ExpressionConverter.ConvertO(bodysourceDatemonth);
                educationalSourceDateObjectpropCount++;
            }

            if (bodysourceDateday != null)
            {
                educationalSourceDateObject["day"] = ExpressionConverter.ConvertO(bodysourceDateday);
                educationalSourceDateObjectpropCount++;
            }

            if (educationalSourceDateObjectpropCount > 0)
            {
                body["educational_source_date"] = educationalSourceDateObject;
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            var dateGraduatedObject = new JObject();
            var dateGraduatedObjectpropCount = 0;
            if (bodydateGraduatedyear != null)
            {
                dateGraduatedObject["year"] = ExpressionConverter.ConvertO(bodydateGraduatedyear);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedmonth != null)
            {
                dateGraduatedObject["month"] = ExpressionConverter.ConvertO(bodydateGraduatedmonth);
                dateGraduatedObjectpropCount++;
            }

            if (bodydateGraduatedday != null)
            {
                dateGraduatedObject["day"] = ExpressionConverter.ConvertO(bodydateGraduatedday);
                dateGraduatedObjectpropCount++;
            }

            if (dateGraduatedObjectpropCount > 0)
            {
                body["date_graduated"] = dateGraduatedObject;
                bodypropCount++;
            }

            if (bodyclassOf != null)
            {
                body["class_year"] = ExpressionConverter.ConvertO(bodyclassOf);
                bodypropCount++;
            }

            if (bodypreferredClassOf != null)
            {
                body["preferred_class_year"] = ExpressionConverter.ConvertO(bodypreferredClassOf);
                bodypropCount++;
            }

            if (bodyaffiliated != null)
            {
                body["affiliated"] = ExpressionConverter.ConvertO(bodyaffiliated);
                bodypropCount++;
            }

            var startDateObject = new JObject();
            var startDateObjectpropCount = 0;
            if (bodyfromyear != null)
            {
                startDateObject["year"] = ExpressionConverter.ConvertO(bodyfromyear);
                startDateObjectpropCount++;
            }

            if (bodyfrommonth != null)
            {
                startDateObject["month"] = ExpressionConverter.ConvertO(bodyfrommonth);
                startDateObjectpropCount++;
            }

            if (bodyfromday != null)
            {
                startDateObject["day"] = ExpressionConverter.ConvertO(bodyfromday);
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
                dateLeftObject["year"] = ExpressionConverter.ConvertO(bodytoyear);
                dateLeftObjectpropCount++;
            }

            if (bodytomonth != null)
            {
                dateLeftObject["month"] = ExpressionConverter.ConvertO(bodytomonth);
                dateLeftObjectpropCount++;
            }

            if (bodytoday != null)
            {
                dateLeftObject["day"] = ExpressionConverter.ConvertO(bodytoday);
                dateLeftObjectpropCount++;
            }

            if (dateLeftObjectpropCount > 0)
            {
                body["date_left"] = dateLeftObject;
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["educational_history_reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodylevel != null)
            {
                body["educational_history_level"] = ExpressionConverter.ConvertO(bodylevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyemailAddress, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/alt-conmg/emailaddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodytype != null)
            {
                body["email_address_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            bodypropCount++;
            body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
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

            if (bodyorigin != null)
            {
                body["origin"] = ExpressionConverter.ConvertO(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_email_address"] = ExpressionConverter.ConvertO(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_email_address"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmailAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEmailAddress(Expression<Func<string>> emailAddressId)
        {
            var apiCallPath = String.Format("/alt-conmg/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = String.Format("/alt-conmg/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["email_address_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
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

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_email_address"] = ExpressionConverter.ConvertO(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_email_address"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> CreateFundraiserConstituency(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var apiCallPath = "/alt-conmg/fundraisers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodydateFrom != null)
            {
                body["date_from"] = ExpressionConverter.ConvertO(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = ExpressionConverter.ConvertO(bodydateTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedFundraiserConstituency>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId)
        {
            var apiCallPath = String.Format("/alt-conmg/fundraisers/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundraiserConstituencyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var apiCallPath = String.Format("/alt-conmg/fundraisers/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundraiserConstituencyId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydateFrom != null)
            {
                body["date_from"] = ExpressionConverter.ConvertO(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = ExpressionConverter.ConvertO(bodydateTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null)
        {
            var apiCallPath = "/alt-conmg/individuals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodyaddressType != null)
            {
                body["address_type"] = ExpressionConverter.ConvertO(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["address_country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["address_city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["address_state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["address_post_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodydoNotSendMail != null)
            {
                body["address_do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotSendMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["address_do_not_mail_reason"] = ExpressionConverter.ConvertO(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["address_dpc"] = ExpressionConverter.ConvertO(bodydPC);
                bodypropCount++;
            }

            if (bodycART != null)
            {
                body["address_cart"] = ExpressionConverter.ConvertO(bodycART);
                bodypropCount++;
            }

            if (bodylOT != null)
            {
                body["address_lot"] = ExpressionConverter.ConvertO(bodylOT);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["address_county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["address_congressional_district"] = ExpressionConverter.ConvertO(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodyphoneType != null)
            {
                body["phone_type"] = ExpressionConverter.ConvertO(bodyphoneType);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phone_number"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyemailType != null)
            {
                body["email_address_type"] = ExpressionConverter.ConvertO(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle_name"] = ExpressionConverter.ConvertO(bodymiddleName);
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

            if (bodynickname != null)
            {
                body["nickname"] = ExpressionConverter.ConvertO(bodynickname);
                bodypropCount++;
            }

            if (bodymaidenName != null)
            {
                body["maiden_name"] = ExpressionConverter.ConvertO(bodymaidenName);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            var birthDateObject = new JObject();
            var birthDateObjectpropCount = 0;
            if (bodybirthdateyear != null)
            {
                birthDateObject["year"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthDateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthDateObject["month"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthDateObjectpropCount++;
            }

            if (bodybirthdateday != null)
            {
                birthDateObject["day"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthDateObjectpropCount++;
            }

            if (birthDateObjectpropCount > 0)
            {
                body["birth_date"] = birthDateObject;
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender_code"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditIndividualConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = String.Format("/alt-conmg/individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylastName != null)
            {
                body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodysuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodysuffix);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["middle_name"] = ExpressionConverter.ConvertO(bodymiddleName);
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

            if (bodynickname != null)
            {
                body["nickname"] = ExpressionConverter.ConvertO(bodynickname);
                bodypropCount++;
            }

            if (bodymaidenName != null)
            {
                body["maiden_name"] = ExpressionConverter.ConvertO(bodymaidenName);
                bodypropCount++;
            }

            if (bodymaritalStatus != null)
            {
                body["marital_status"] = ExpressionConverter.ConvertO(bodymaritalStatus);
                bodypropCount++;
            }

            var birthDateObject = new JObject();
            var birthDateObjectpropCount = 0;
            if (bodybirthdateyear != null)
            {
                birthDateObject["year"] = ExpressionConverter.ConvertO(bodybirthdateyear);
                birthDateObjectpropCount++;
            }

            if (bodybirthdatemonth != null)
            {
                birthDateObject["month"] = ExpressionConverter.ConvertO(bodybirthdatemonth);
                birthDateObjectpropCount++;
            }

            if (bodybirthdateday != null)
            {
                birthDateObject["day"] = ExpressionConverter.ConvertO(bodybirthdateday);
                birthDateObjectpropCount++;
            }

            if (birthDateObjectpropCount > 0)
            {
                body["birth_date"] = birthDateObject;
                bodypropCount++;
            }

            if (bodygender != null)
            {
                body["gender_code"] = ExpressionConverter.ConvertO(bodygender);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["web_address"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodygivesAnonymously != null)
            {
                body["gives_anonymously"] = ExpressionConverter.ConvertO(bodygivesAnonymously);
                bodypropCount++;
            }

            if (bodydeceased != null)
            {
                body["deceased"] = ExpressionConverter.ConvertO(bodydeceased);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = ExpressionConverter.ConvertO(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = ExpressionConverter.ConvertO(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgIndividualConstituent> GetIndividualConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgIndividualConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> CreateConstituentInteraction(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysummary, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyexpectedDate, Expression<Func<string>> bodycontactMethod, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgNewConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = "/alt-conmg/interactions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["objective"] = ExpressionConverter.ConvertO(bodysummary);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
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
                expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            if (bodyownerID != null)
            {
                body["fundraiser_id"] = ExpressionConverter.ConvertO(bodyownerID);
                bodypropCount++;
            }

            bodypropCount++;
            body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
            if (bodyeventID != null)
            {
                body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentInteraction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var apiCallPath = String.Format("/alt-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentInteraction(Expression<Func<string>> constituentInteractionId, Expression<Func<string>> bodysummary = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgUpdateConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = String.Format("/alt-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysummary != null)
            {
                body["objective"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                bodypropCount++;
            }

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
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
                expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            if (bodyownerID != null)
            {
                body["fundraiser_id"] = ExpressionConverter.ConvertO(bodyownerID);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentInteraction> GetConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var apiCallPath = String.Format("/alt-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgConstituentInteraction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgMergedConstituent> MergeTwoConstituents(Expression<Func<string>> bodysourceConstituentID, Expression<Func<string>> bodytargetConstituentID, Expression<Func<string>> bodyconfiguration, Expression<Func<bool>> bodydeleteSource, Expression<Func<bodydeleteActionInput>> bodydeleteAction, Expression<Func<string>> bodyinactiveReason = null, Expression<Func<string>> bodyinactivityDetails = null)
        {
            var apiCallPath = "/alt-conmg/mergetwoconstituents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["source_id"] = ExpressionConverter.ConvertO(bodysourceConstituentID);
            bodypropCount++;
            body["target_id"] = ExpressionConverter.ConvertO(bodytargetConstituentID);
            bodypropCount++;
            body["config"] = ExpressionConverter.ConvertO(bodyconfiguration);
            bodypropCount++;
            body["delete_source"] = ExpressionConverter.ConvertO(bodydeleteSource);
            bodypropCount++;
            body["delete_source_constituent"] = ExpressionConverter.ConvertO(bodydeleteAction);
            if (bodyinactiveReason != null)
            {
                body["constituent_inactivity_reason_code"] = ExpressionConverter.ConvertO(bodyinactiveReason);
                bodypropCount++;
            }

            if (bodyinactivityDetails != null)
            {
                body["constituent_inactivity_details"] = ExpressionConverter.ConvertO(bodyinactivityDetails);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgMergedConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = "/alt-conmg/organizations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodynoOfSubsidiaryOrgs != null)
            {
                body["num_subsidiaries"] = ExpressionConverter.ConvertO(bodynoOfSubsidiaryOrgs);
                bodypropCount++;
            }

            if (bodyparentOrg != null)
            {
                body["parent_corp_id"] = ExpressionConverter.ConvertO(bodyparentOrg);
                bodypropCount++;
            }

            if (bodyaddressType != null)
            {
                body["address_type"] = ExpressionConverter.ConvertO(bodyaddressType);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["address_country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address_block"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["address_city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["address_state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["address_postcode"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodydoNotSendMail != null)
            {
                body["address_do_not_mail"] = ExpressionConverter.ConvertO(bodydoNotSendMail);
                bodypropCount++;
            }

            if (bodydoNotMailReason != null)
            {
                body["address_do_not_mail_reason"] = ExpressionConverter.ConvertO(bodydoNotMailReason);
                bodypropCount++;
            }

            if (bodydPC != null)
            {
                body["dpc"] = ExpressionConverter.ConvertO(bodydPC);
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

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodycongressionalDistrict != null)
            {
                body["congressional_district"] = ExpressionConverter.ConvertO(bodycongressionalDistrict);
                bodypropCount++;
            }

            if (bodyphoneType != null)
            {
                body["phone_type"] = ExpressionConverter.ConvertO(bodyphoneType);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phone_number"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyemailType != null)
            {
                body["email_address_type"] = ExpressionConverter.ConvertO(bodyemailType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodywebAddress != null)
            {
                body["web_address"] = ExpressionConverter.ConvertO(bodywebAddress);
                bodypropCount++;
            }

            if (bodyisPrimaryOrganization != null)
            {
                body["is_primary"] = ExpressionConverter.ConvertO(bodyisPrimaryOrganization);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = ExpressionConverter.ConvertO(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = ExpressionConverter.ConvertO(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditOrganizationConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var apiCallPath = String.Format("/alt-conmg/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["organization_name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyindustry != null)
            {
                body["industry"] = ExpressionConverter.ConvertO(bodyindustry);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["num_employees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodynoOfSubsidiaryOrgs != null)
            {
                body["num_subsidiaries"] = ExpressionConverter.ConvertO(bodynoOfSubsidiaryOrgs);
                bodypropCount++;
            }

            if (bodyparentOrg != null)
            {
                body["parent_corp_id"] = ExpressionConverter.ConvertO(bodyparentOrg);
                bodypropCount++;
            }

            if (bodywebAddress != null)
            {
                body["web_address"] = ExpressionConverter.ConvertO(bodywebAddress);
                bodypropCount++;
            }

            if (bodyisPrimaryOrganization != null)
            {
                body["is_primary"] = ExpressionConverter.ConvertO(bodyisPrimaryOrganization);
                bodypropCount++;
            }

            if (bodyprofilePicture != null)
            {
                body["picture"] = ExpressionConverter.ConvertO(bodyprofilePicture);
                bodypropCount++;
            }

            if (bodyprofileThumbnail != null)
            {
                body["picture_thumbnail"] = ExpressionConverter.ConvertO(bodyprofileThumbnail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> GetOrganizationConstituent(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/alt-conmg/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConmgOrganizationConstituent>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> CreateConstituentPhone(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodynumber, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = "/alt-conmg/phones";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodytype != null)
            {
                body["phone_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            var startTimeObject = new JObject();
            var startTimeObjectpropCount = 0;
            if (bodycallAfterhour != null)
            {
                startTimeObject["hour"] = ExpressionConverter.ConvertO(bodycallAfterhour);
                startTimeObjectpropCount++;
            }

            if (bodycallAfterminute != null)
            {
                startTimeObject["minute"] = ExpressionConverter.ConvertO(bodycallAfterminute);
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
                endTimeObject["hour"] = ExpressionConverter.ConvertO(bodycallBeforehour);
                endTimeObjectpropCount++;
            }

            if (bodycallBeforeminute != null)
            {
                endTimeObject["minute"] = ExpressionConverter.ConvertO(bodycallBeforeminute);
                endTimeObjectpropCount++;
            }

            if (endTimeObjectpropCount > 0)
            {
                body["end_time"] = endTimeObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
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

            if (bodydoNotCallReason != null)
            {
                body["do_not_call_reason"] = ExpressionConverter.ConvertO(bodydoNotCallReason);
                bodypropCount++;
            }

            if (bodydoNotText != null)
            {
                body["donottext"] = ExpressionConverter.ConvertO(bodydoNotText);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
                bodypropCount++;
            }

            var seasonalStartDateObject = new JObject();
            var seasonalStartDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                seasonalStartDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonalStartDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                seasonalStartDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
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
                seasonalEndDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonalEndDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                seasonalEndDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonalEndDateObjectpropCount++;
            }

            if (seasonalEndDateObjectpropCount > 0)
            {
                body["seasonal_end_date"] = seasonalEndDateObject;
                bodypropCount++;
            }

            if (bodyorigin != null)
            {
                body["origin"] = ExpressionConverter.ConvertO(bodyorigin);
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_phone"] = ExpressionConverter.ConvertO(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_phone"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentPhone>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentPhone(Expression<Func<string>> constituentPhoneId)
        {
            var apiCallPath = String.Format("/alt-conmg/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentPhoneId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentPhone(Expression<Func<string>> constituentPhoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var apiCallPath = String.Format("/alt-conmg/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentPhoneId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["phone_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            var startTimeObject = new JObject();
            var startTimeObjectpropCount = 0;
            if (bodycallAfterhour != null)
            {
                startTimeObject["hour"] = ExpressionConverter.ConvertO(bodycallAfterhour);
                startTimeObjectpropCount++;
            }

            if (bodycallAfterminute != null)
            {
                startTimeObject["minute"] = ExpressionConverter.ConvertO(bodycallAfterminute);
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
                endTimeObject["hour"] = ExpressionConverter.ConvertO(bodycallBeforehour);
                endTimeObjectpropCount++;
            }

            if (bodycallBeforeminute != null)
            {
                endTimeObject["minute"] = ExpressionConverter.ConvertO(bodycallBeforeminute);
                endTimeObjectpropCount++;
            }

            if (endTimeObjectpropCount > 0)
            {
                body["end_time"] = endTimeObject;
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

            if (bodydoNotCallReason != null)
            {
                body["do_not_call_reason"] = ExpressionConverter.ConvertO(bodydoNotCallReason);
                bodypropCount++;
            }

            if (bodydoNotText != null)
            {
                body["donottext"] = ExpressionConverter.ConvertO(bodydoNotText);
                bodypropCount++;
            }

            if (bodyisConfidential != null)
            {
                body["confidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
                bodypropCount++;
            }

            var seasonalStartDateObject = new JObject();
            var seasonalStartDateObjectpropCount = 0;
            if (bodyseasonalStartmonth != null)
            {
                seasonalStartDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalStartmonth);
                seasonalStartDateObjectpropCount++;
            }

            if (bodyseasonalStartday != null)
            {
                seasonalStartDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalStartday);
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
                seasonalEndDateObject["month"] = ExpressionConverter.ConvertO(bodyseasonalEndmonth);
                seasonalEndDateObjectpropCount++;
            }

            if (bodyseasonalEndday != null)
            {
                seasonalEndDateObject["day"] = ExpressionConverter.ConvertO(bodyseasonalEndday);
                seasonalEndDateObjectpropCount++;
            }

            if (seasonalEndDateObjectpropCount > 0)
            {
                body["seasonal_end_date"] = seasonalEndDateObject;
                bodypropCount++;
            }

            if (bodyinformationSource != null)
            {
                body["info_source"] = ExpressionConverter.ConvertO(bodyinformationSource);
                bodypropCount++;
            }

            if (bodyinfoSourceComments != null)
            {
                body["info_source_comments"] = ExpressionConverter.ConvertO(bodyinfoSourceComments);
                bodypropCount++;
            }

            if (bodycopyToSpouse != null)
            {
                body["update_matching_spouse_phone"] = ExpressionConverter.ConvertO(bodycopyToSpouse);
                bodypropCount++;
            }

            if (bodycopyToHousehold != null)
            {
                body["update_matching_household_phone"] = ExpressionConverter.ConvertO(bodycopyToHousehold);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> CreateConstituentEmploymentHistory(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationship, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var apiCallPath = "/alt-conmg/relationshipjobsinfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["context_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["relationship"] = ExpressionConverter.ConvertO(bodyrelationship);
            if (bodyjobTitle != null)
            {
                body["job_title"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycareerLevel != null)
            {
                body["career_level"] = ExpressionConverter.ConvertO(bodycareerLevel);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["job_category"] = ExpressionConverter.ConvertO(bodycategory);
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

            if (bodydepartment != null)
            {
                body["job_department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["job_division"] = ExpressionConverter.ConvertO(bodydivision);
                bodypropCount++;
            }

            if (bodycareerLevel2 != null)
            {
                body["job_schedule"] = ExpressionConverter.ConvertO(bodycareerLevel2);
                bodypropCount++;
            }

            if (bodyresponsibilities != null)
            {
                body["job_responsibility"] = ExpressionConverter.ConvertO(bodyresponsibilities);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["private_record"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmploymentHistory>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId)
        {
            var apiCallPath = String.Format("/alt-conmg/relationshipjobsinfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipJobInfoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var apiCallPath = String.Format("/alt-conmg/relationshipjobsinfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipJobInfoId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyjobTitle != null)
            {
                body["job_title"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodycareerLevel != null)
            {
                body["career_level"] = ExpressionConverter.ConvertO(bodycareerLevel);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["job_category"] = ExpressionConverter.ConvertO(bodycategory);
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

            if (bodydepartment != null)
            {
                body["job_department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["job_division"] = ExpressionConverter.ConvertO(bodydivision);
                bodypropCount++;
            }

            if (bodycareerLevel2 != null)
            {
                body["job_schedule"] = ExpressionConverter.ConvertO(bodycareerLevel2);
                bodypropCount++;
            }

            if (bodyresponsibilities != null)
            {
                body["job_responsibility"] = ExpressionConverter.ConvertO(bodyresponsibilities);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["private_record"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/alt-conmg/solicitcodes";
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

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentSolicitCode>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId)
        {
            var apiCallPath = String.Format("/alt-conmg/solicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/alt-conmg/solicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
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

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudaltruconstiTriggers([ConnectionName] string connectionId)
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

    public class ConmgUpdateConstituentInteractionParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudaltruconsti;

    public partial class WorkflowManagedActions
    {
        public BlackbaudaltruconstiActions Blackbaudaltruconsti(string connectionId) => new BlackbaudaltruconstiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudaltruconstiTriggers Blackbaudaltruconsti(string connectionId) => new BlackbaudaltruconstiTriggers(connectionId);
    }
}