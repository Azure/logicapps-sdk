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
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> CreateConstituentAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyhistoricalStartDate = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodystateHouseDistrict = null, [WorkflowExpression] Func<string> bodystateSenateDistrict = null, [WorkflowExpression] Func<string> bodylocalPrecinct = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodyrecentlyMoved = null, [WorkflowExpression] Func<string> bodyoldAddress = null, [WorkflowExpression] Func<bool> bodyomitFromValidation = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                if (bodytype != null)
                {
                    body["address_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address_block"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postcode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                if (bodydoNotMailReason != null)
                {
                    body["do_not_mail_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotMailReason);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["confidential"] = SourceExpressionConverter.ConvertToken(bodyisConfidential);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodyseasonalStartmonth != null)
                {
                    startDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    startDateObjectpropCount++;
                }

                if (bodyseasonalStartday != null)
                {
                    startDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
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
                    endDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    endDateObjectpropCount++;
                }

                if (bodyseasonalEndday != null)
                {
                    endDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (bodyhistoricalStartDate != null)
                {
                    body["historical_start_date"] = SourceExpressionConverter.ConvertToken(bodyhistoricalStartDate);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = SourceExpressionConverter.ConvertToken(bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (bodystateHouseDistrict != null)
                {
                    body["state_house_district"] = SourceExpressionConverter.ConvertToken(bodystateHouseDistrict);
                    bodypropCount++;
                }

                if (bodystateSenateDistrict != null)
                {
                    body["state_senate_district"] = SourceExpressionConverter.ConvertToken(bodystateSenateDistrict);
                    bodypropCount++;
                }

                if (bodylocalPrecinct != null)
                {
                    body["local_precinct"] = SourceExpressionConverter.ConvertToken(bodylocalPrecinct);
                    bodypropCount++;
                }

                if (bodyorigin != null)
                {
                    body["origin"] = SourceExpressionConverter.Convert(bodyorigin);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodyrecentlyMoved != null)
                {
                    body["recent_move"] = SourceExpressionConverter.ConvertToken(bodyrecentlyMoved);
                    bodypropCount++;
                }

                if (bodyoldAddress != null)
                {
                    body["old_address"] = SourceExpressionConverter.ConvertToken(bodyoldAddress);
                    bodypropCount++;
                }

                if (bodyomitFromValidation != null)
                {
                    body["omit_from_validation"] = SourceExpressionConverter.ConvertToken(bodyomitFromValidation);
                    bodypropCount++;
                }

                if (bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_addresses"] = SourceExpressionConverter.ConvertToken(bodycopyToSpouse);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_addresses"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAddress([WorkflowExpression] Func<string> constituentAddressId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/addresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAddressId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAddress([WorkflowExpression] Func<string> constituentAddressId, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyhistoricalStartDate = null, [WorkflowExpression] Func<string> bodyhistoricalEndDate = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodystateHouseDistrict = null, [WorkflowExpression] Func<string> bodystateSenateDistrict = null, [WorkflowExpression] Func<string> bodylocalPrecinct = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodyomitFromValidation = null, [WorkflowExpression] Func<bool> bodyupdateContacts = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/addresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAddressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["address_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address_block"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postcode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                if (bodydoNotMailReason != null)
                {
                    body["do_not_mail_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotMailReason);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["confidential"] = SourceExpressionConverter.ConvertToken(bodyisConfidential);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodyseasonalStartmonth != null)
                {
                    startDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    startDateObjectpropCount++;
                }

                if (bodyseasonalStartday != null)
                {
                    startDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
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
                    endDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    endDateObjectpropCount++;
                }

                if (bodyseasonalEndday != null)
                {
                    endDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (bodyhistoricalStartDate != null)
                {
                    body["historical_start_date"] = SourceExpressionConverter.ConvertToken(bodyhistoricalStartDate);
                    bodypropCount++;
                }

                if (bodyhistoricalEndDate != null)
                {
                    body["historical_end_date"] = SourceExpressionConverter.ConvertToken(bodyhistoricalEndDate);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = SourceExpressionConverter.ConvertToken(bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (bodystateHouseDistrict != null)
                {
                    body["state_house_district"] = SourceExpressionConverter.ConvertToken(bodystateHouseDistrict);
                    bodypropCount++;
                }

                if (bodystateSenateDistrict != null)
                {
                    body["state_senate_district"] = SourceExpressionConverter.ConvertToken(bodystateSenateDistrict);
                    bodypropCount++;
                }

                if (bodylocalPrecinct != null)
                {
                    body["local_precinct"] = SourceExpressionConverter.ConvertToken(bodylocalPrecinct);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodyomitFromValidation != null)
                {
                    body["omit_from_validation"] = SourceExpressionConverter.ConvertToken(bodyomitFromValidation);
                    bodypropCount++;
                }

                if (bodyupdateContacts != null)
                {
                    body["update_contacts"] = SourceExpressionConverter.ConvertToken(bodyupdateContacts);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_addresses"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupId> CreateConstituentAlternateLookupId([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyalternateLookupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/alternatelookupids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["alternate_lookup_id_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["alternate_lookup_id"] = SourceExpressionConverter.ConvertToken(bodyalternateLookupId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAlternateLookupId>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAlternateLookupId([WorkflowExpression] Func<string> alternateLookupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/alternatelookupids/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(alternateLookupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAlternateLookupId([WorkflowExpression] Func<string> alternateLookupId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyalternateLookupId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/alternatelookupids/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(alternateLookupId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["alternate_lookup_id_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyalternateLookupId != null)
                {
                    body["alternate_lookup_id"] = SourceExpressionConverter.ConvertToken(bodyalternateLookupId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> CreateConstituentAppealResponse([WorkflowExpression] Func<string> bodyconstituentAppealId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodyresponse, [WorkflowExpression] Func<string> bodydate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/constituentappealresponses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_appeal_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentAppealId);
                bodypropCount++;
                body["response_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
                body["response"] = SourceExpressionConverter.ConvertToken(bodyresponse);
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppealResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> CreateConstituentAppeal([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyappealId, [WorkflowExpression] Func<string> bodymailing = null, [WorkflowExpression] Func<string> bodydateSent = null, [WorkflowExpression] Func<string> bodypackage = null, [WorkflowExpression] Func<string> bodysourceCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/constituentappeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                if (bodymailing != null)
                {
                    body["mkt_segmentation"] = SourceExpressionConverter.ConvertToken(bodymailing);
                    bodypropCount++;
                }

                if (bodydateSent != null)
                {
                    body["date_sent"] = SourceExpressionConverter.ConvertToken(bodydateSent);
                    bodypropCount++;
                }

                if (bodypackage != null)
                {
                    body["mkt_package_id"] = SourceExpressionConverter.ConvertToken(bodypackage);
                    bodypropCount++;
                }

                if (bodysourceCode != null)
                {
                    body["source_code"] = SourceExpressionConverter.ConvertToken(bodysourceCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentAppeal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAppeal([WorkflowExpression] Func<string> constituentAppealId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentappeals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAppealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentAppeal([WorkflowExpression] Func<string> constituentAppealId, [WorkflowExpression] Func<string> bodyappealId = null, [WorkflowExpression] Func<string> bodymailing = null, [WorkflowExpression] Func<string> bodydateSent = null, [WorkflowExpression] Func<string> bodypackage = null, [WorkflowExpression] Func<string> bodysourceCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentappeals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAppealId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyappealId != null)
                {
                    body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                    bodypropCount++;
                }

                if (bodymailing != null)
                {
                    body["mkt_segmentation"] = SourceExpressionConverter.ConvertToken(bodymailing);
                    bodypropCount++;
                }

                if (bodydateSent != null)
                {
                    body["date_sent"] = SourceExpressionConverter.ConvertToken(bodydateSent);
                    bodypropCount++;
                }

                if (bodypackage != null)
                {
                    body["mkt_package_id"] = SourceExpressionConverter.ConvertToken(bodypackage);
                    bodypropCount++;
                }

                if (bodysourceCode != null)
                {
                    body["source_code"] = SourceExpressionConverter.ConvertToken(bodysourceCode);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> ListConstituentAppeals([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentappeals/{0}/appeals", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentAppealCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentAttribute([WorkflowExpression] Func<string> constituentAttributeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentattributes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentAttributeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> CreateConstituentNote([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyauthorId = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyhTML = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/constituentnotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["note_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["date_entered"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyauthorId != null)
                {
                    body["author_id"] = SourceExpressionConverter.ConvertToken(bodyauthorId);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text_note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyhTML != null)
                {
                    body["html_note"] = SourceExpressionConverter.ConvertToken(bodyhTML);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentNote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentNote([WorkflowExpression] Func<string> constituentNoteId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentnotes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentNoteId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentNote([WorkflowExpression] Func<string> constituentNoteId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyauthorId = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyhTML = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituentnotes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentNoteId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["note_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date_entered"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyauthorId != null)
                {
                    body["author_id"] = SourceExpressionConverter.ConvertToken(bodyauthorId);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text_note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyhTML != null)
                {
                    body["html_note"] = SourceExpressionConverter.ConvertToken(bodyhTML);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> SearchConstituent([WorkflowExpression] Func<string> keyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> emailAddress = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> addressBlock = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<int> classof = null, [WorkflowExpression] Func<bool> exactMatchOnly = null, [WorkflowExpression] Func<string> middleName = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<string> sourcecode = null, [WorkflowExpression] Func<bool> includeIndividuals = null, [WorkflowExpression] Func<bool> includeOrganizations = null, [WorkflowExpression] Func<bool> includeGroups = null, [WorkflowExpression] Func<bool> excludeHouseholds = null, [WorkflowExpression] Func<bool> checkNickname = null, [WorkflowExpression] Func<bool> checkAliases = null, [WorkflowExpression] Func<bool> checkAlternateLookupIds = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> fuzzySearchOnName = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (keyName != null)
                    callPayload.Queries["key_name"] = SourceExpressionConverter.ConvertO(keyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = SourceExpressionConverter.ConvertO(lookupId);
                if (emailAddress != null)
                    callPayload.Queries["email_address"] = SourceExpressionConverter.ConvertO(emailAddress);
                if (phoneNumber != null)
                    callPayload.Queries["phone_number"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (addressBlock != null)
                    callPayload.Queries["address_block"] = SourceExpressionConverter.ConvertO(addressBlock);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (postCode != null)
                    callPayload.Queries["post_code"] = SourceExpressionConverter.ConvertO(postCode);
                if (classof != null)
                    callPayload.Queries["classof"] = SourceExpressionConverter.ConvertO(classof);
                if (exactMatchOnly != null)
                    callPayload.Queries["exact_match_only"] = SourceExpressionConverter.ConvertO(exactMatchOnly);
                if (middleName != null)
                    callPayload.Queries["middle_name"] = SourceExpressionConverter.ConvertO(middleName);
                if (constituency != null)
                    callPayload.Queries["constituency"] = SourceExpressionConverter.ConvertO(constituency);
                if (sourcecode != null)
                    callPayload.Queries["sourcecode"] = SourceExpressionConverter.ConvertO(sourcecode);
                if (includeIndividuals != null)
                    callPayload.Queries["include_individuals"] = SourceExpressionConverter.ConvertO(includeIndividuals);
                if (includeOrganizations != null)
                    callPayload.Queries["include_organizations"] = SourceExpressionConverter.ConvertO(includeOrganizations);
                if (includeGroups != null)
                    callPayload.Queries["include_groups"] = SourceExpressionConverter.ConvertO(includeGroups);
                if (excludeHouseholds != null)
                    callPayload.Queries["exclude_households"] = SourceExpressionConverter.ConvertO(excludeHouseholds);
                if (checkNickname != null)
                    callPayload.Queries["check_nickname"] = SourceExpressionConverter.ConvertO(checkNickname);
                if (checkAliases != null)
                    callPayload.Queries["check_aliases"] = SourceExpressionConverter.ConvertO(checkAliases);
                if (checkAlternateLookupIds != null)
                    callPayload.Queries["check_alternate_lookup_ids"] = SourceExpressionConverter.ConvertO(checkAlternateLookupIds);
                if (onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = SourceExpressionConverter.ConvertO(onlyPrimaryAddress);
                if (includeDeceased != null)
                    callPayload.Queries["include_deceased"] = SourceExpressionConverter.ConvertO(includeDeceased);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (fuzzySearchOnName != null)
                    callPayload.Queries["fuzzy_search_on_name"] = SourceExpressionConverter.ConvertO(fuzzySearchOnName);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentSearchResultCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituent([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAddressCollection> ListConstituentAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeFormer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeFormer != null)
                    callPayload.Queries["include_former"] = SourceExpressionConverter.ConvertO(includeFormer);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgAddressCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAlternateLookupIdCollection> ListConstituentAlternateLookupIDs([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/alternatelookupids", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgAlternateLookupIdCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgAttributeCollection> ListConstituentAttributes([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/constituentattributelist", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgAttributeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> GetConstituentPrimaryContactInfo([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/contactview", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEducationCollection> ListConstituentEducations([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/educationalhistories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgEducationCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> ListConstituentEmailAddresses([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/emailaddresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgEmailAddressCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgPhoneCollection> ListConstituentPhones([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/phones", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgPhoneCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> GetConstituentProfilePicture([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/profilepicture", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentProfilePicture>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> ListConstituentEmploymentHistory([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/relationshipjobsinfo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> ListConstituentSolicitCodes([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> showExpired = null, [WorkflowExpression] Func<dateRangeInput> dateRange = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/solicitcodes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (showExpired != null)
                    callPayload.Queries["show_expired"] = SourceExpressionConverter.ConvertO(showExpired);
                if (dateRange != null)
                    callPayload.Queries["date_range"] = SourceExpressionConverter.Convert(dateRange);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgSolicitCodeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgTributeCollection> ListConstituentTributes([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/tributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgTributeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> GetConstituentSummaryProfile([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/constituents/{0}/view", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentSummaryProfile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> CreateConstituentEducation([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyeducationalInstitution, [WorkflowExpression] Func<string> bodystatus, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyprogram = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<string> bodyhonorAwarded = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<int> bodysourceDateyear = null, [WorkflowExpression] Func<int> bodysourceDatemonth = null, [WorkflowExpression] Func<int> bodysourceDateday = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodyclassOf = null, [WorkflowExpression] Func<int> bodypreferredClassOf = null, [WorkflowExpression] Func<bool> bodyaffiliated = null, [WorkflowExpression] Func<int> bodyfromyear = null, [WorkflowExpression] Func<int> bodyfrommonth = null, [WorkflowExpression] Func<int> bodyfromday = null, [WorkflowExpression] Func<int> bodytoyear = null, [WorkflowExpression] Func<int> bodytomonth = null, [WorkflowExpression] Func<int> bodytoday = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylevel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/educationalhistories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["educational_institution_id"] = SourceExpressionConverter.ConvertToken(bodyeducationalInstitution);
                bodypropCount++;
                body["educational_history_status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                if (bodyprimary != null)
                {
                    body["primary_record"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyprogram != null)
                {
                    body["educational_program"] = SourceExpressionConverter.ConvertToken(bodyprogram);
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["educational_degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodyhonorAwarded != null)
                {
                    body["educational_award"] = SourceExpressionConverter.ConvertToken(bodyhonorAwarded);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["educational_source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                var educationalSourceDateObject = new JObject();
                var educationalSourceDateObjectpropCount = 0;
                if (bodysourceDateyear != null)
                {
                    educationalSourceDateObject["year"] = SourceExpressionConverter.ConvertToken(bodysourceDateyear);
                    educationalSourceDateObjectpropCount++;
                }

                if (bodysourceDatemonth != null)
                {
                    educationalSourceDateObject["month"] = SourceExpressionConverter.ConvertToken(bodysourceDatemonth);
                    educationalSourceDateObjectpropCount++;
                }

                if (bodysourceDateday != null)
                {
                    educationalSourceDateObject["day"] = SourceExpressionConverter.ConvertToken(bodysourceDateday);
                    educationalSourceDateObjectpropCount++;
                }

                if (educationalSourceDateObjectpropCount > 0)
                {
                    body["educational_source_date"] = educationalSourceDateObject;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["year"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["month"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["day"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_year"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodypreferredClassOf != null)
                {
                    body["preferred_class_year"] = SourceExpressionConverter.ConvertToken(bodypreferredClassOf);
                    bodypropCount++;
                }

                if (bodyaffiliated != null)
                {
                    body["affiliated"] = SourceExpressionConverter.ConvertToken(bodyaffiliated);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodyfromyear != null)
                {
                    startDateObject["year"] = SourceExpressionConverter.ConvertToken(bodyfromyear);
                    startDateObjectpropCount++;
                }

                if (bodyfrommonth != null)
                {
                    startDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyfrommonth);
                    startDateObjectpropCount++;
                }

                if (bodyfromday != null)
                {
                    startDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyfromday);
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
                    dateLeftObject["year"] = SourceExpressionConverter.ConvertToken(bodytoyear);
                    dateLeftObjectpropCount++;
                }

                if (bodytomonth != null)
                {
                    dateLeftObject["month"] = SourceExpressionConverter.ConvertToken(bodytomonth);
                    dateLeftObjectpropCount++;
                }

                if (bodytoday != null)
                {
                    dateLeftObject["day"] = SourceExpressionConverter.ConvertToken(bodytoday);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["educational_history_reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodylevel != null)
                {
                    body["educational_history_level"] = SourceExpressionConverter.ConvertToken(bodylevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEducation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEducation([WorkflowExpression] Func<string> educationalHistoryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/educationalhistories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationalHistoryId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEducation([WorkflowExpression] Func<string> educationalHistoryId, [WorkflowExpression] Func<string> bodyeducationalInstitution = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyprogram = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<string> bodyhonorAwarded = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<int> bodysourceDateyear = null, [WorkflowExpression] Func<int> bodysourceDatemonth = null, [WorkflowExpression] Func<int> bodysourceDateday = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodyclassOf = null, [WorkflowExpression] Func<int> bodypreferredClassOf = null, [WorkflowExpression] Func<bool> bodyaffiliated = null, [WorkflowExpression] Func<int> bodyfromyear = null, [WorkflowExpression] Func<int> bodyfrommonth = null, [WorkflowExpression] Func<int> bodyfromday = null, [WorkflowExpression] Func<int> bodytoyear = null, [WorkflowExpression] Func<int> bodytomonth = null, [WorkflowExpression] Func<int> bodytoday = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylevel = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/educationalhistories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationalHistoryId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeducationalInstitution != null)
                {
                    body["educational_institution_id"] = SourceExpressionConverter.ConvertToken(bodyeducationalInstitution);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["educational_history_status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary_record"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyprogram != null)
                {
                    body["educational_program"] = SourceExpressionConverter.ConvertToken(bodyprogram);
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["educational_degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodyhonorAwarded != null)
                {
                    body["educational_award"] = SourceExpressionConverter.ConvertToken(bodyhonorAwarded);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["educational_source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                var educationalSourceDateObject = new JObject();
                var educationalSourceDateObjectpropCount = 0;
                if (bodysourceDateyear != null)
                {
                    educationalSourceDateObject["year"] = SourceExpressionConverter.ConvertToken(bodysourceDateyear);
                    educationalSourceDateObjectpropCount++;
                }

                if (bodysourceDatemonth != null)
                {
                    educationalSourceDateObject["month"] = SourceExpressionConverter.ConvertToken(bodysourceDatemonth);
                    educationalSourceDateObjectpropCount++;
                }

                if (bodysourceDateday != null)
                {
                    educationalSourceDateObject["day"] = SourceExpressionConverter.ConvertToken(bodysourceDateday);
                    educationalSourceDateObjectpropCount++;
                }

                if (educationalSourceDateObjectpropCount > 0)
                {
                    body["educational_source_date"] = educationalSourceDateObject;
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["year"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["month"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["day"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_year"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodypreferredClassOf != null)
                {
                    body["preferred_class_year"] = SourceExpressionConverter.ConvertToken(bodypreferredClassOf);
                    bodypropCount++;
                }

                if (bodyaffiliated != null)
                {
                    body["affiliated"] = SourceExpressionConverter.ConvertToken(bodyaffiliated);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodyfromyear != null)
                {
                    startDateObject["year"] = SourceExpressionConverter.ConvertToken(bodyfromyear);
                    startDateObjectpropCount++;
                }

                if (bodyfrommonth != null)
                {
                    startDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyfrommonth);
                    startDateObjectpropCount++;
                }

                if (bodyfromday != null)
                {
                    startDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyfromday);
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
                    dateLeftObject["year"] = SourceExpressionConverter.ConvertToken(bodytoyear);
                    dateLeftObjectpropCount++;
                }

                if (bodytomonth != null)
                {
                    dateLeftObject["month"] = SourceExpressionConverter.ConvertToken(bodytomonth);
                    dateLeftObjectpropCount++;
                }

                if (bodytoday != null)
                {
                    dateLeftObject["day"] = SourceExpressionConverter.ConvertToken(bodytoday);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["educational_history_reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodylevel != null)
                {
                    body["educational_history_level"] = SourceExpressionConverter.ConvertToken(bodylevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> CreateConstituentEmailAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyemailAddress, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodytype != null)
                {
                    body["email_address_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyorigin != null)
                {
                    body["origin"] = SourceExpressionConverter.Convert(bodyorigin);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_email_address"] = SourceExpressionConverter.ConvertToken(bodycopyToSpouse);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_email_address"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmailAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/emailaddresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/emailaddresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["email_address_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_email_address"] = SourceExpressionConverter.ConvertToken(bodycopyToSpouse);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_email_address"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> CreateFundraiserConstituency([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/fundraisers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodydateFrom != null)
                {
                    body["date_from"] = SourceExpressionConverter.ConvertToken(bodydateFrom);
                    bodypropCount++;
                }

                if (bodydateTo != null)
                {
                    body["date_to"] = SourceExpressionConverter.ConvertToken(bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedFundraiserConstituency>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteFundraiserConstituency([WorkflowExpression] Func<string> fundraiserConstituencyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/fundraisers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserConstituencyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditFundraiserConstituency([WorkflowExpression] Func<string> fundraiserConstituencyId, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/fundraisers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserConstituencyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydateFrom != null)
                {
                    body["date_from"] = SourceExpressionConverter.ConvertToken(bodydateFrom);
                    bodypropCount++;
                }

                if (bodydateTo != null)
                {
                    body["date_to"] = SourceExpressionConverter.ConvertToken(bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> CreateIndividualConstituent([WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodydoNotSendMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodyphoneType = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodynickname = null, [WorkflowExpression] Func<string> bodymaidenName = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<string> bodygender = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodyaddressType != null)
                {
                    body["address_type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["address_country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address_block"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["address_city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["address_state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["address_post_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodydoNotSendMail != null)
                {
                    body["address_do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotSendMail);
                    bodypropCount++;
                }

                if (bodydoNotMailReason != null)
                {
                    body["address_do_not_mail_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotMailReason);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["address_dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["address_cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["address_lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["address_county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodycongressionalDistrict != null)
                {
                    body["address_congressional_district"] = SourceExpressionConverter.ConvertToken(bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (bodyphoneType != null)
                {
                    body["phone_type"] = SourceExpressionConverter.ConvertToken(bodyphoneType);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemailType != null)
                {
                    body["email_address_type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodynickname != null)
                {
                    body["nickname"] = SourceExpressionConverter.ConvertToken(bodynickname);
                    bodypropCount++;
                }

                if (bodymaidenName != null)
                {
                    body["maiden_name"] = SourceExpressionConverter.ConvertToken(bodymaidenName);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                var birthDateObject = new JObject();
                var birthDateObjectpropCount = 0;
                if (bodybirthdateyear != null)
                {
                    birthDateObject["year"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthDateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthDateObject["month"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthDateObjectpropCount++;
                }

                if (bodybirthdateday != null)
                {
                    birthDateObject["day"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthDateObjectpropCount++;
                }

                if (birthDateObjectpropCount > 0)
                {
                    body["birth_date"] = birthDateObject;
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender_code"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedIndividualConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditIndividualConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodynickname = null, [WorkflowExpression] Func<string> bodymaidenName = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/individuals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle_name"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodynickname != null)
                {
                    body["nickname"] = SourceExpressionConverter.ConvertToken(bodynickname);
                    bodypropCount++;
                }

                if (bodymaidenName != null)
                {
                    body["maiden_name"] = SourceExpressionConverter.ConvertToken(bodymaidenName);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                var birthDateObject = new JObject();
                var birthDateObjectpropCount = 0;
                if (bodybirthdateyear != null)
                {
                    birthDateObject["year"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthDateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthDateObject["month"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthDateObjectpropCount++;
                }

                if (bodybirthdateday != null)
                {
                    birthDateObject["day"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthDateObjectpropCount++;
                }

                if (birthDateObjectpropCount > 0)
                {
                    body["birth_date"] = birthDateObject;
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender_code"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["web_address"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodydeceased != null)
                {
                    body["deceased"] = SourceExpressionConverter.ConvertToken(bodydeceased);
                    bodypropCount++;
                }

                if (bodyprofilePicture != null)
                {
                    body["picture"] = SourceExpressionConverter.ConvertToken(bodyprofilePicture);
                    bodypropCount++;
                }

                if (bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = SourceExpressionConverter.ConvertToken(bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgIndividualConstituent> GetIndividualConstituent([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/individuals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgIndividualConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> CreateConstituentInteraction([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodysummary, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodyexpectedDate, [WorkflowExpression] Func<string> bodycontactMethod, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyeventId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<ConmgNewConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/interactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["objective"] = SourceExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedStartminute);
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
                    expectedEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                if (bodyeventId != null)
                {
                    body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentInteraction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/interactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodyeventId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<ConmgUpdateConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/interactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysummary != null)
                {
                    body["objective"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedStartminute);
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
                    expectedEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgConstituentInteraction> GetConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/interactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentInteractionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgConstituentInteraction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgMergedConstituent> MergeTwoConstituents([WorkflowExpression] Func<string> bodysourceConstituentId, [WorkflowExpression] Func<string> bodytargetConstituentId, [WorkflowExpression] Func<string> bodyconfiguration, [WorkflowExpression] Func<bool> bodydeleteSource, [WorkflowExpression] Func<bodydeleteActionInput> bodydeleteAction, [WorkflowExpression] Func<string> bodyinactiveReason = null, [WorkflowExpression] Func<string> bodyinactivityDetails = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/mergetwoconstituents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source_id"] = SourceExpressionConverter.ConvertToken(bodysourceConstituentId);
                bodypropCount++;
                body["target_id"] = SourceExpressionConverter.ConvertToken(bodytargetConstituentId);
                bodypropCount++;
                body["config"] = SourceExpressionConverter.ConvertToken(bodyconfiguration);
                bodypropCount++;
                body["delete_source"] = SourceExpressionConverter.ConvertToken(bodydeleteSource);
                bodypropCount++;
                body["delete_source_constituent"] = SourceExpressionConverter.Convert(bodydeleteAction);
                if (bodyinactiveReason != null)
                {
                    body["constituent_inactivity_reason_code"] = SourceExpressionConverter.ConvertToken(bodyinactiveReason);
                    bodypropCount++;
                }

                if (bodyinactivityDetails != null)
                {
                    body["constituent_inactivity_details"] = SourceExpressionConverter.ConvertToken(bodyinactivityDetails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgMergedConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> CreateOrganizationConstituent([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<int> bodynoOfSubsidiaryOrgs = null, [WorkflowExpression] Func<string> bodyparentOrg = null, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodydoNotSendMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodyphoneType = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodywebAddress = null, [WorkflowExpression] Func<bool> bodyisPrimaryOrganization = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodynoOfSubsidiaryOrgs != null)
                {
                    body["num_subsidiaries"] = SourceExpressionConverter.ConvertToken(bodynoOfSubsidiaryOrgs);
                    bodypropCount++;
                }

                if (bodyparentOrg != null)
                {
                    body["parent_corp_id"] = SourceExpressionConverter.ConvertToken(bodyparentOrg);
                    bodypropCount++;
                }

                if (bodyaddressType != null)
                {
                    body["address_type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["address_country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address_block"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["address_city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["address_state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["address_postcode"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodydoNotSendMail != null)
                {
                    body["address_do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotSendMail);
                    bodypropCount++;
                }

                if (bodydoNotMailReason != null)
                {
                    body["address_do_not_mail_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotMailReason);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = SourceExpressionConverter.ConvertToken(bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (bodyphoneType != null)
                {
                    body["phone_type"] = SourceExpressionConverter.ConvertToken(bodyphoneType);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemailType != null)
                {
                    body["email_address_type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodywebAddress != null)
                {
                    body["web_address"] = SourceExpressionConverter.ConvertToken(bodywebAddress);
                    bodypropCount++;
                }

                if (bodyisPrimaryOrganization != null)
                {
                    body["is_primary"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryOrganization);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyprofilePicture != null)
                {
                    body["picture"] = SourceExpressionConverter.ConvertToken(bodyprofilePicture);
                    bodypropCount++;
                }

                if (bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = SourceExpressionConverter.ConvertToken(bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedOrganizationConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditOrganizationConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<int> bodynoOfSubsidiaryOrgs = null, [WorkflowExpression] Func<string> bodyparentOrg = null, [WorkflowExpression] Func<string> bodywebAddress = null, [WorkflowExpression] Func<bool> bodyisPrimaryOrganization = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["organization_name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodynoOfSubsidiaryOrgs != null)
                {
                    body["num_subsidiaries"] = SourceExpressionConverter.ConvertToken(bodynoOfSubsidiaryOrgs);
                    bodypropCount++;
                }

                if (bodyparentOrg != null)
                {
                    body["parent_corp_id"] = SourceExpressionConverter.ConvertToken(bodyparentOrg);
                    bodypropCount++;
                }

                if (bodywebAddress != null)
                {
                    body["web_address"] = SourceExpressionConverter.ConvertToken(bodywebAddress);
                    bodypropCount++;
                }

                if (bodyisPrimaryOrganization != null)
                {
                    body["is_primary"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryOrganization);
                    bodypropCount++;
                }

                if (bodyprofilePicture != null)
                {
                    body["picture"] = SourceExpressionConverter.ConvertToken(bodyprofilePicture);
                    bodypropCount++;
                }

                if (bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = SourceExpressionConverter.ConvertToken(bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> GetOrganizationConstituent([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConmgOrganizationConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> CreateConstituentPhone([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodycallAfterhour = null, [WorkflowExpression] Func<int> bodycallAfterminute = null, [WorkflowExpression] Func<int> bodycallBeforehour = null, [WorkflowExpression] Func<int> bodycallBeforeminute = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<string> bodydoNotCallReason = null, [WorkflowExpression] Func<bool> bodydoNotText = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodytype != null)
                {
                    body["phone_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                var startTimeObject = new JObject();
                var startTimeObjectpropCount = 0;
                if (bodycallAfterhour != null)
                {
                    startTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodycallAfterhour);
                    startTimeObjectpropCount++;
                }

                if (bodycallAfterminute != null)
                {
                    startTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodycallAfterminute);
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
                    endTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodycallBeforehour);
                    endTimeObjectpropCount++;
                }

                if (bodycallBeforeminute != null)
                {
                    endTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodycallBeforeminute);
                    endTimeObjectpropCount++;
                }

                if (endTimeObjectpropCount > 0)
                {
                    body["end_time"] = endTimeObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodydoNotCallReason != null)
                {
                    body["do_not_call_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotCallReason);
                    bodypropCount++;
                }

                if (bodydoNotText != null)
                {
                    body["donottext"] = SourceExpressionConverter.ConvertToken(bodydoNotText);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["confidential"] = SourceExpressionConverter.ConvertToken(bodyisConfidential);
                    bodypropCount++;
                }

                var seasonalStartDateObject = new JObject();
                var seasonalStartDateObjectpropCount = 0;
                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartDateObjectpropCount++;
                }

                if (bodyseasonalStartday != null)
                {
                    seasonalStartDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
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
                    seasonalEndDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndDateObjectpropCount++;
                }

                if (bodyseasonalEndday != null)
                {
                    seasonalEndDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndDateObjectpropCount++;
                }

                if (seasonalEndDateObjectpropCount > 0)
                {
                    body["seasonal_end_date"] = seasonalEndDateObject;
                    bodypropCount++;
                }

                if (bodyorigin != null)
                {
                    body["origin"] = SourceExpressionConverter.Convert(bodyorigin);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_phone"] = SourceExpressionConverter.ConvertToken(bodycopyToSpouse);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_phone"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentPhone>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentPhone([WorkflowExpression] Func<string> constituentPhoneId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/phones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentPhoneId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentPhone([WorkflowExpression] Func<string> constituentPhoneId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodycallAfterhour = null, [WorkflowExpression] Func<int> bodycallAfterminute = null, [WorkflowExpression] Func<int> bodycallBeforehour = null, [WorkflowExpression] Func<int> bodycallBeforeminute = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<string> bodydoNotCallReason = null, [WorkflowExpression] Func<bool> bodydoNotText = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/phones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentPhoneId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["phone_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                var startTimeObject = new JObject();
                var startTimeObjectpropCount = 0;
                if (bodycallAfterhour != null)
                {
                    startTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodycallAfterhour);
                    startTimeObjectpropCount++;
                }

                if (bodycallAfterminute != null)
                {
                    startTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodycallAfterminute);
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
                    endTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodycallBeforehour);
                    endTimeObjectpropCount++;
                }

                if (bodycallBeforeminute != null)
                {
                    endTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodycallBeforeminute);
                    endTimeObjectpropCount++;
                }

                if (endTimeObjectpropCount > 0)
                {
                    body["end_time"] = endTimeObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodydoNotCallReason != null)
                {
                    body["do_not_call_reason"] = SourceExpressionConverter.ConvertToken(bodydoNotCallReason);
                    bodypropCount++;
                }

                if (bodydoNotText != null)
                {
                    body["donottext"] = SourceExpressionConverter.ConvertToken(bodydoNotText);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["confidential"] = SourceExpressionConverter.ConvertToken(bodyisConfidential);
                    bodypropCount++;
                }

                var seasonalStartDateObject = new JObject();
                var seasonalStartDateObjectpropCount = 0;
                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartDateObjectpropCount++;
                }

                if (bodyseasonalStartday != null)
                {
                    seasonalStartDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
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
                    seasonalEndDateObject["month"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndDateObjectpropCount++;
                }

                if (bodyseasonalEndday != null)
                {
                    seasonalEndDateObject["day"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndDateObjectpropCount++;
                }

                if (seasonalEndDateObjectpropCount > 0)
                {
                    body["seasonal_end_date"] = seasonalEndDateObject;
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["info_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = SourceExpressionConverter.ConvertToken(bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_phone"] = SourceExpressionConverter.ConvertToken(bodycopyToSpouse);
                    bodypropCount++;
                }

                if (bodycopyToHousehold != null)
                {
                    body["update_matching_household_phone"] = SourceExpressionConverter.ConvertToken(bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> CreateConstituentEmploymentHistory([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyrelationship, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycareerLevel = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodycareerLevel2 = null, [WorkflowExpression] Func<string> bodyresponsibilities = null, [WorkflowExpression] Func<bool> bodyisPrivate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/relationshipjobsinfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["relationship"] = SourceExpressionConverter.ConvertToken(bodyrelationship);
                if (bodyjobTitle != null)
                {
                    body["job_title"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodycareerLevel != null)
                {
                    body["career_level"] = SourceExpressionConverter.ConvertToken(bodycareerLevel);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["job_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["job_department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodydivision != null)
                {
                    body["job_division"] = SourceExpressionConverter.ConvertToken(bodydivision);
                    bodypropCount++;
                }

                if (bodycareerLevel2 != null)
                {
                    body["job_schedule"] = SourceExpressionConverter.ConvertToken(bodycareerLevel2);
                    bodypropCount++;
                }

                if (bodyresponsibilities != null)
                {
                    body["job_responsibility"] = SourceExpressionConverter.ConvertToken(bodyresponsibilities);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["private_record"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentEmploymentHistory>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentEmploymentHistory([WorkflowExpression] Func<string> relationshipJobInfoId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/relationshipjobsinfo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipJobInfoId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentEmploymentHistory([WorkflowExpression] Func<string> relationshipJobInfoId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycareerLevel = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodycareerLevel2 = null, [WorkflowExpression] Func<string> bodyresponsibilities = null, [WorkflowExpression] Func<bool> bodyisPrivate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/relationshipjobsinfo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipJobInfoId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["job_title"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodycareerLevel != null)
                {
                    body["career_level"] = SourceExpressionConverter.ConvertToken(bodycareerLevel);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["job_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["job_department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodydivision != null)
                {
                    body["job_division"] = SourceExpressionConverter.ConvertToken(bodydivision);
                    bodypropCount++;
                }

                if (bodycareerLevel2 != null)
                {
                    body["job_schedule"] = SourceExpressionConverter.ConvertToken(bodycareerLevel2);
                    bodypropCount++;
                }

                if (bodyresponsibilities != null)
                {
                    body["job_responsibility"] = SourceExpressionConverter.ConvertToken(bodyresponsibilities);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["private_record"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> CreateConstituentSolicitCode([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodysolicitCode, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/alt-conmg/solicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConmgCreatedConstituentSolicitCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction DeleteConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/solicitcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudaltruconsti")]
        public IWorkflowAction EditConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId, [WorkflowExpression] Func<string> bodysolicitCode = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/alt-conmg/solicitcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysolicitCode != null)
                {
                    body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

    public class ConmgCreatedConstituentAlternateLookupId
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

    public class ConmgAlternateLookupIdCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConmgAlternateLookupId[] Value { get; set; }
    }

    public class ConmgAlternateLookupId
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