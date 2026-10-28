//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmconstituActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> CreateConstituentAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycountry, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyrecentlyMoved = null, Expression<Func<string>> bodyoldAddress = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodydoNotMailReason = WorkflowExpression.Compile(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyhistoricalStartDate = WorkflowExpression.Compile(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodycongressionalDistrict = WorkflowExpression.Compile(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            var __workflow_bodystateHouseDistrict = WorkflowExpression.Compile(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            var __workflow_bodystateSenateDistrict = WorkflowExpression.Compile(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            var __workflow_bodylocalPrecinct = WorkflowExpression.Compile(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            var __workflow_bodyorigin = WorkflowExpression.Compile(bodyorigin, nameof(bodyorigin), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodyrecentlyMoved = WorkflowExpression.Compile(bodyrecentlyMoved, nameof(bodyrecentlyMoved), required: false);
            var __workflow_bodyoldAddress = WorkflowExpression.Compile(bodyoldAddress, nameof(bodyoldAddress), required: false);
            var __workflow_bodyomitFromValidation = WorkflowExpression.Compile(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            var __workflow_bodycopyToSpouse = WorkflowExpression.Compile(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAddress>(() =>
            {
                var apiCallPath = "/crm-conmg/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                if (__workflow_bodytype != null)
                {
                    body["address_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address_block"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
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
                    body["postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMailReason != null)
                {
                    body["do_not_mail_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMailReason);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["confidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodyseasonalStartmonth != null)
                {
                    startDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartday != null)
                {
                    startDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var endDateObject = new JObject();
                var endDateObjectpropCount = 0;
                if (__workflow_bodyseasonalEndmonth != null)
                {
                    endDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    endDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndday != null)
                {
                    endDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyhistoricalStartDate != null)
                {
                    body["historical_start_date"] = ExpressionConverter.ConvertO(__workflow_bodyhistoricalStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
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

                if (__workflow_bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = ExpressionConverter.ConvertO(__workflow_bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodystateHouseDistrict != null)
                {
                    body["state_house_district"] = ExpressionConverter.ConvertO(__workflow_bodystateHouseDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodystateSenateDistrict != null)
                {
                    body["state_senate_district"] = ExpressionConverter.ConvertO(__workflow_bodystateSenateDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodylocalPrecinct != null)
                {
                    body["local_precinct"] = ExpressionConverter.ConvertO(__workflow_bodylocalPrecinct);
                    bodypropCount++;
                }

                if (__workflow_bodyorigin != null)
                {
                    body["origin"] = ExpressionConverter.ConvertO(__workflow_bodyorigin);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyrecentlyMoved != null)
                {
                    body["recent_move"] = ExpressionConverter.ConvertO(__workflow_bodyrecentlyMoved);
                    bodypropCount++;
                }

                if (__workflow_bodyoldAddress != null)
                {
                    body["old_address"] = ExpressionConverter.ConvertO(__workflow_bodyoldAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyomitFromValidation != null)
                {
                    body["omit_from_validation"] = ExpressionConverter.ConvertO(__workflow_bodyomitFromValidation);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_addresses"] = ExpressionConverter.ConvertO(__workflow_bodycopyToSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_addresses"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAddress(Expression<Func<string>> constituentAddressId)
        {
            var __workflow_constituentAddressId = WorkflowExpression.Compile(constituentAddressId, nameof(constituentAddressId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/addresses/{0}", __workflow_constituentAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAddress(Expression<Func<string>> constituentAddressId, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyhistoricalStartDate = null, Expression<Func<string>> bodyhistoricalEndDate = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodystateHouseDistrict = null, Expression<Func<string>> bodystateSenateDistrict = null, Expression<Func<string>> bodylocalPrecinct = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodyomitFromValidation = null, Expression<Func<bool>> bodyupdateContacts = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_constituentAddressId = WorkflowExpression.Compile(constituentAddressId, nameof(constituentAddressId), required: true);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodydoNotMailReason = WorkflowExpression.Compile(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyhistoricalStartDate = WorkflowExpression.Compile(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            var __workflow_bodyhistoricalEndDate = WorkflowExpression.Compile(bodyhistoricalEndDate, nameof(bodyhistoricalEndDate), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodycongressionalDistrict = WorkflowExpression.Compile(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            var __workflow_bodystateHouseDistrict = WorkflowExpression.Compile(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            var __workflow_bodystateSenateDistrict = WorkflowExpression.Compile(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            var __workflow_bodylocalPrecinct = WorkflowExpression.Compile(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodyomitFromValidation = WorkflowExpression.Compile(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            var __workflow_bodyupdateContacts = WorkflowExpression.Compile(bodyupdateContacts, nameof(bodyupdateContacts), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/addresses/{0}", __workflow_constituentAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["address_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address_block"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
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
                    body["postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMailReason != null)
                {
                    body["do_not_mail_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMailReason);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["confidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodyseasonalStartmonth != null)
                {
                    startDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartday != null)
                {
                    startDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var endDateObject = new JObject();
                var endDateObjectpropCount = 0;
                if (__workflow_bodyseasonalEndmonth != null)
                {
                    endDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    endDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndday != null)
                {
                    endDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyhistoricalStartDate != null)
                {
                    body["historical_start_date"] = ExpressionConverter.ConvertO(__workflow_bodyhistoricalStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyhistoricalEndDate != null)
                {
                    body["historical_end_date"] = ExpressionConverter.ConvertO(__workflow_bodyhistoricalEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
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

                if (__workflow_bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = ExpressionConverter.ConvertO(__workflow_bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodystateHouseDistrict != null)
                {
                    body["state_house_district"] = ExpressionConverter.ConvertO(__workflow_bodystateHouseDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodystateSenateDistrict != null)
                {
                    body["state_senate_district"] = ExpressionConverter.ConvertO(__workflow_bodystateSenateDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodylocalPrecinct != null)
                {
                    body["local_precinct"] = ExpressionConverter.ConvertO(__workflow_bodylocalPrecinct);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodyomitFromValidation != null)
                {
                    body["omit_from_validation"] = ExpressionConverter.ConvertO(__workflow_bodyomitFromValidation);
                    bodypropCount++;
                }

                if (__workflow_bodyupdateContacts != null)
                {
                    body["update_contacts"] = ExpressionConverter.ConvertO(__workflow_bodyupdateContacts);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_addresses"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> CreateConstituentAlternateLookupID(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodyalternateLookupID)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyalternateLookupID = WorkflowExpression.Compile(bodyalternateLookupID, nameof(bodyalternateLookupID), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAlternateLookupID>(() =>
            {
                var apiCallPath = "/crm-conmg/alternatelookupids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["alternate_lookup_id_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["alternate_lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodyalternateLookupID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentAlternateLookupID>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId)
        {
            var __workflow_alternateLookupId = WorkflowExpression.Compile(alternateLookupId, nameof(alternateLookupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/alternatelookupids/{0}", __workflow_alternateLookupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAlternateLookupID(Expression<Func<string>> alternateLookupId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyalternateLookupID = null)
        {
            var __workflow_alternateLookupId = WorkflowExpression.Compile(alternateLookupId, nameof(alternateLookupId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyalternateLookupID = WorkflowExpression.Compile(bodyalternateLookupID, nameof(bodyalternateLookupID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/alternatelookupids/{0}", __workflow_alternateLookupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["alternate_lookup_id_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyalternateLookupID != null)
                {
                    body["alternate_lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodyalternateLookupID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> CreateConstituentAppealResponse(Expression<Func<string>> bodyconstituentAppealID, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyresponse, Expression<Func<string>> bodydate = null)
        {
            var __workflow_bodyconstituentAppealID = WorkflowExpression.Compile(bodyconstituentAppealID, nameof(bodyconstituentAppealID), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyresponse = WorkflowExpression.Compile(bodyresponse, nameof(bodyresponse), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAppealResponse>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappealresponses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_appeal_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentAppealID);
                bodypropCount++;
                body["response_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                bodypropCount++;
                body["response"] = ExpressionConverter.ConvertO(__workflow_bodyresponse);
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentAppealResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> CreateConstituentAppeal(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyappealID, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodyappealID = WorkflowExpression.Compile(bodyappealID, nameof(bodyappealID), required: true);
            var __workflow_bodymailing = WorkflowExpression.Compile(bodymailing, nameof(bodymailing), required: false);
            var __workflow_bodydateSent = WorkflowExpression.Compile(bodydateSent, nameof(bodydateSent), required: false);
            var __workflow_bodypackage = WorkflowExpression.Compile(bodypackage, nameof(bodypackage), required: false);
            var __workflow_bodysourceCode = WorkflowExpression.Compile(bodysourceCode, nameof(bodysourceCode), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAppeal>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappeals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["appeal_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealID);
                if (__workflow_bodymailing != null)
                {
                    body["mkt_segmentation"] = ExpressionConverter.ConvertO(__workflow_bodymailing);
                    bodypropCount++;
                }

                if (__workflow_bodydateSent != null)
                {
                    body["date_sent"] = ExpressionConverter.ConvertO(__workflow_bodydateSent);
                    bodypropCount++;
                }

                if (__workflow_bodypackage != null)
                {
                    body["mkt_package_id"] = ExpressionConverter.ConvertO(__workflow_bodypackage);
                    bodypropCount++;
                }

                if (__workflow_bodysourceCode != null)
                {
                    body["source_code"] = ExpressionConverter.ConvertO(__workflow_bodysourceCode);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentAppeal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAppeal(Expression<Func<string>> constituentAppealId)
        {
            var __workflow_constituentAppealId = WorkflowExpression.Compile(constituentAppealId, nameof(constituentAppealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}", __workflow_constituentAppealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentAppeal(Expression<Func<string>> constituentAppealId, Expression<Func<string>> bodyappealID = null, Expression<Func<string>> bodymailing = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodypackage = null, Expression<Func<string>> bodysourceCode = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_constituentAppealId = WorkflowExpression.Compile(constituentAppealId, nameof(constituentAppealId), required: true);
            var __workflow_bodyappealID = WorkflowExpression.Compile(bodyappealID, nameof(bodyappealID), required: false);
            var __workflow_bodymailing = WorkflowExpression.Compile(bodymailing, nameof(bodymailing), required: false);
            var __workflow_bodydateSent = WorkflowExpression.Compile(bodydateSent, nameof(bodydateSent), required: false);
            var __workflow_bodypackage = WorkflowExpression.Compile(bodypackage, nameof(bodypackage), required: false);
            var __workflow_bodysourceCode = WorkflowExpression.Compile(bodysourceCode, nameof(bodysourceCode), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}", __workflow_constituentAppealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyappealID != null)
                {
                    body["appeal_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealID);
                    bodypropCount++;
                }

                if (__workflow_bodymailing != null)
                {
                    body["mkt_segmentation"] = ExpressionConverter.ConvertO(__workflow_bodymailing);
                    bodypropCount++;
                }

                if (__workflow_bodydateSent != null)
                {
                    body["date_sent"] = ExpressionConverter.ConvertO(__workflow_bodydateSent);
                    bodypropCount++;
                }

                if (__workflow_bodypackage != null)
                {
                    body["mkt_package_id"] = ExpressionConverter.ConvertO(__workflow_bodypackage);
                    bodypropCount++;
                }

                if (__workflow_bodysourceCode != null)
                {
                    body["source_code"] = ExpressionConverter.ConvertO(__workflow_bodysourceCode);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> ListConstituentAppeals(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentAppealCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentappeals/{0}/appeals", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentAppealCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentAttribute(Expression<Func<string>> constituentAttributeId)
        {
            var __workflow_constituentAttributeId = WorkflowExpression.Compile(constituentAttributeId, nameof(constituentAttributeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentattributes/{0}", __workflow_constituentAttributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence> CreateConstituentCorrespondence(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodycorrespondenceCode, Expression<Func<string>> bodydateSent, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodycorrespondenceCode = WorkflowExpression.Compile(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: true);
            var __workflow_bodydateSent = WorkflowExpression.Compile(bodydateSent, nameof(bodydateSent), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentCorrespondence>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentcorrespondencecodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["correspondence_code"] = ExpressionConverter.ConvertO(__workflow_bodycorrespondenceCode);
                bodypropCount++;
                body["date_sent"] = ExpressionConverter.ConvertO(__workflow_bodydateSent);
                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentCorrespondence>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId)
        {
            var __workflow_constituentCorrespondenceId = WorkflowExpression.Compile(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", __workflow_constituentCorrespondenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentCorrespondence(Expression<Func<string>> constituentCorrespondenceId, Expression<Func<string>> bodycorrespondenceCode = null, Expression<Func<string>> bodydateSent = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_constituentCorrespondenceId = WorkflowExpression.Compile(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            var __workflow_bodycorrespondenceCode = WorkflowExpression.Compile(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: false);
            var __workflow_bodydateSent = WorkflowExpression.Compile(bodydateSent, nameof(bodydateSent), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", __workflow_constituentCorrespondenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycorrespondenceCode != null)
                {
                    body["correspondence_code"] = ExpressionConverter.ConvertO(__workflow_bodycorrespondenceCode);
                    bodypropCount++;
                }

                if (__workflow_bodydateSent != null)
                {
                    body["date_sent"] = ExpressionConverter.ConvertO(__workflow_bodydateSent);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> CreateConstituentNote(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyauthorID = WorkflowExpression.Compile(bodyauthorID, nameof(bodyauthorID), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyhTML = WorkflowExpression.Compile(bodyhTML, nameof(bodyhTML), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentNote>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentnotes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["note_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["date_entered"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyauthorID != null)
                {
                    body["author_id"] = ExpressionConverter.ConvertO(__workflow_bodyauthorID);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text_note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyhTML != null)
                {
                    body["html_note"] = ExpressionConverter.ConvertO(__workflow_bodyhTML);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentNote(Expression<Func<string>> constituentNoteId)
        {
            var __workflow_constituentNoteId = WorkflowExpression.Compile(constituentNoteId, nameof(constituentNoteId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentnotes/{0}", __workflow_constituentNoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentNote(Expression<Func<string>> constituentNoteId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyauthorID = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyhTML = null)
        {
            var __workflow_constituentNoteId = WorkflowExpression.Compile(constituentNoteId, nameof(constituentNoteId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyauthorID = WorkflowExpression.Compile(bodyauthorID, nameof(bodyauthorID), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyhTML = WorkflowExpression.Compile(bodyhTML, nameof(bodyhTML), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituentnotes/{0}", __workflow_constituentNoteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["note_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date_entered"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyauthorID != null)
                {
                    body["author_id"] = ExpressionConverter.ConvertO(__workflow_bodyauthorID);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text_note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyhTML != null)
                {
                    body["html_note"] = ExpressionConverter.ConvertO(__workflow_bodyhTML);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> SearchConstituent(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> emailAddress = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<int>> classof = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> middleName = null, Expression<Func<string>> constituency = null, Expression<Func<string>> sourcecode = null, Expression<Func<bool>> includeIndividuals = null, Expression<Func<bool>> includeOrganizations = null, Expression<Func<bool>> includeGroups = null, Expression<Func<bool>> excludeHouseholds = null, Expression<Func<bool>> checkNickname = null, Expression<Func<bool>> checkAliases = null, Expression<Func<bool>> checkAlternateLookupIds = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_addressBlock = WorkflowExpression.Compile(addressBlock, nameof(addressBlock), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_classof = WorkflowExpression.Compile(classof, nameof(classof), required: false);
            var __workflow_exactMatchOnly = WorkflowExpression.Compile(exactMatchOnly, nameof(exactMatchOnly), required: false);
            var __workflow_middleName = WorkflowExpression.Compile(middleName, nameof(middleName), required: false);
            var __workflow_constituency = WorkflowExpression.Compile(constituency, nameof(constituency), required: false);
            var __workflow_sourcecode = WorkflowExpression.Compile(sourcecode, nameof(sourcecode), required: false);
            var __workflow_includeIndividuals = WorkflowExpression.Compile(includeIndividuals, nameof(includeIndividuals), required: false);
            var __workflow_includeOrganizations = WorkflowExpression.Compile(includeOrganizations, nameof(includeOrganizations), required: false);
            var __workflow_includeGroups = WorkflowExpression.Compile(includeGroups, nameof(includeGroups), required: false);
            var __workflow_excludeHouseholds = WorkflowExpression.Compile(excludeHouseholds, nameof(excludeHouseholds), required: false);
            var __workflow_checkNickname = WorkflowExpression.Compile(checkNickname, nameof(checkNickname), required: false);
            var __workflow_checkAliases = WorkflowExpression.Compile(checkAliases, nameof(checkAliases), required: false);
            var __workflow_checkAlternateLookupIds = WorkflowExpression.Compile(checkAlternateLookupIds, nameof(checkAlternateLookupIds), required: false);
            var __workflow_onlyPrimaryAddress = WorkflowExpression.Compile(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_fuzzySearchOnName = WorkflowExpression.Compile(fuzzySearchOnName, nameof(fuzzySearchOnName), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ConmgConstituentSearchResultCollection>(() =>
            {
                var apiCallPath = "/crm-conmg/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyName != null)
                    callPayload.Queries["key_name"] = ExpressionConverter.Convert(__workflow_keyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_emailAddress != null)
                    callPayload.Queries["email_address"] = ExpressionConverter.Convert(__workflow_emailAddress);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_addressBlock != null)
                    callPayload.Queries["address_block"] = ExpressionConverter.Convert(__workflow_addressBlock);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_classof != null)
                    callPayload.Queries["classof"] = ExpressionConverter.Convert(__workflow_classof);
                if (__workflow_exactMatchOnly != null)
                    callPayload.Queries["exact_match_only"] = ExpressionConverter.Convert(__workflow_exactMatchOnly);
                if (__workflow_middleName != null)
                    callPayload.Queries["middle_name"] = ExpressionConverter.Convert(__workflow_middleName);
                if (__workflow_constituency != null)
                    callPayload.Queries["constituency"] = ExpressionConverter.Convert(__workflow_constituency);
                if (__workflow_sourcecode != null)
                    callPayload.Queries["sourcecode"] = ExpressionConverter.Convert(__workflow_sourcecode);
                if (__workflow_includeIndividuals != null)
                    callPayload.Queries["include_individuals"] = ExpressionConverter.Convert(__workflow_includeIndividuals);
                if (__workflow_includeOrganizations != null)
                    callPayload.Queries["include_organizations"] = ExpressionConverter.Convert(__workflow_includeOrganizations);
                if (__workflow_includeGroups != null)
                    callPayload.Queries["include_groups"] = ExpressionConverter.Convert(__workflow_includeGroups);
                if (__workflow_excludeHouseholds != null)
                    callPayload.Queries["exclude_households"] = ExpressionConverter.Convert(__workflow_excludeHouseholds);
                if (__workflow_checkNickname != null)
                    callPayload.Queries["check_nickname"] = ExpressionConverter.Convert(__workflow_checkNickname);
                if (__workflow_checkAliases != null)
                    callPayload.Queries["check_aliases"] = ExpressionConverter.Convert(__workflow_checkAliases);
                if (__workflow_checkAlternateLookupIds != null)
                    callPayload.Queries["check_alternate_lookup_ids"] = ExpressionConverter.Convert(__workflow_checkAlternateLookupIds);
                if (__workflow_onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(__workflow_onlyPrimaryAddress);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_fuzzySearchOnName != null)
                    callPayload.Queries["fuzzy_search_on_name"] = ExpressionConverter.Convert(__workflow_fuzzySearchOnName);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ConmgConstituentSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAddressCollection> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeFormer = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeFormer = WorkflowExpression.Compile(includeFormer, nameof(includeFormer), required: false);
            return new DeferredBodyAction<ConmgAddressCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/addresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeFormer != null)
                    callPayload.Queries["include_former"] = ExpressionConverter.Convert(__workflow_includeFormer);
                return new ApiConnectionAction<ConmgAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> ListConstituentAlternateLookupIDs(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAlternateLookupIDCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/alternatelookupids", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAlternateLookupIDCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgAttributeCollection> ListConstituentAttributes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAttributeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/constituentattributelist", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAttributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> GetConstituentPrimaryContactInfo(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentPrimaryContactInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/contactview", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEducationCollection> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEducationCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/educationalhistories", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEducationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> ListConstituentEmailAddresses(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEmailAddressCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/emailaddresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEmailAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgPhoneCollection> ListConstituentPhones(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgPhoneCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/phones", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgPhoneCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentProfilePicture>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentProfilePicture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> ListConstituentEmploymentHistory(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConmgEmploymentHistoryCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/relationshipjobsinfo", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> ListConstituentSolicitCodes(Expression<Func<string>> constituentId, Expression<Func<bool>> showExpired = null, Expression<Func<dateRangeInput>> dateRange = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_showExpired = WorkflowExpression.Compile(showExpired, nameof(showExpired), required: false);
            var __workflow_dateRange = WorkflowExpression.Compile(dateRange, nameof(dateRange), required: false);
            return new DeferredBodyAction<ConmgSolicitCodeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/solicitcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_showExpired != null)
                    callPayload.Queries["show_expired"] = ExpressionConverter.Convert(__workflow_showExpired);
                if (__workflow_dateRange != null)
                    callPayload.Queries["date_range"] = ExpressionConverter.Convert(__workflow_dateRange);
                return new ApiConnectionAction<ConmgSolicitCodeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgTributeCollection> ListConstituentTributes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgTributeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/tributes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> GetConstituentSummaryProfile(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentSummaryProfile>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/constituents/{0}/view", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentSummaryProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> CreateConstituentEducation(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyeducationalInstitution, Expression<Func<string>> bodystatus, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodyeducationalInstitution = WorkflowExpression.Compile(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyprogram = WorkflowExpression.Compile(bodyprogram, nameof(bodyprogram), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodyhonorAwarded = WorkflowExpression.Compile(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodysourceDateyear = WorkflowExpression.Compile(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            var __workflow_bodysourceDatemonth = WorkflowExpression.Compile(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            var __workflow_bodysourceDateday = WorkflowExpression.Compile(bodysourceDateday, nameof(bodysourceDateday), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodypreferredClassOf = WorkflowExpression.Compile(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            var __workflow_bodyaffiliated = WorkflowExpression.Compile(bodyaffiliated, nameof(bodyaffiliated), required: false);
            var __workflow_bodyfromyear = WorkflowExpression.Compile(bodyfromyear, nameof(bodyfromyear), required: false);
            var __workflow_bodyfrommonth = WorkflowExpression.Compile(bodyfrommonth, nameof(bodyfrommonth), required: false);
            var __workflow_bodyfromday = WorkflowExpression.Compile(bodyfromday, nameof(bodyfromday), required: false);
            var __workflow_bodytoyear = WorkflowExpression.Compile(bodytoyear, nameof(bodytoyear), required: false);
            var __workflow_bodytomonth = WorkflowExpression.Compile(bodytomonth, nameof(bodytomonth), required: false);
            var __workflow_bodytoday = WorkflowExpression.Compile(bodytoday, nameof(bodytoday), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEducation>(() =>
            {
                var apiCallPath = "/crm-conmg/educationalhistories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["educational_institution_id"] = ExpressionConverter.ConvertO(__workflow_bodyeducationalInstitution);
                bodypropCount++;
                body["educational_history_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (__workflow_bodyprimary != null)
                {
                    body["primary_record"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyprogram != null)
                {
                    body["educational_program"] = ExpressionConverter.ConvertO(__workflow_bodyprogram);
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["educational_degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodyhonorAwarded != null)
                {
                    body["educational_award"] = ExpressionConverter.ConvertO(__workflow_bodyhonorAwarded);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["educational_source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                var educationalSourceDateObject = new JObject();
                var educationalSourceDateObjectpropCount = 0;
                if (__workflow_bodysourceDateyear != null)
                {
                    educationalSourceDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodysourceDateyear);
                    educationalSourceDateObjectpropCount++;
                }

                if (__workflow_bodysourceDatemonth != null)
                {
                    educationalSourceDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodysourceDatemonth);
                    educationalSourceDateObjectpropCount++;
                }

                if (__workflow_bodysourceDateday != null)
                {
                    educationalSourceDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodysourceDateday);
                    educationalSourceDateObjectpropCount++;
                }

                if (educationalSourceDateObjectpropCount > 0)
                {
                    body["educational_source_date"] = educationalSourceDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["year"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["month"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["day"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_year"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredClassOf != null)
                {
                    body["preferred_class_year"] = ExpressionConverter.ConvertO(__workflow_bodypreferredClassOf);
                    bodypropCount++;
                }

                if (__workflow_bodyaffiliated != null)
                {
                    body["affiliated"] = ExpressionConverter.ConvertO(__workflow_bodyaffiliated);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodyfromyear != null)
                {
                    startDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodyfromyear);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyfrommonth != null)
                {
                    startDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyfrommonth);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyfromday != null)
                {
                    startDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyfromday);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodytoyear != null)
                {
                    dateLeftObject["year"] = ExpressionConverter.ConvertO(__workflow_bodytoyear);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodytomonth != null)
                {
                    dateLeftObject["month"] = ExpressionConverter.ConvertO(__workflow_bodytomonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodytoday != null)
                {
                    dateLeftObject["day"] = ExpressionConverter.ConvertO(__workflow_bodytoday);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreason != null)
                {
                    body["educational_history_reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodylevel != null)
                {
                    body["educational_history_level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentEducation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEducation(Expression<Func<string>> educationalHistoryId)
        {
            var __workflow_educationalHistoryId = WorkflowExpression.Compile(educationalHistoryId, nameof(educationalHistoryId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/educationalhistories/{0}", __workflow_educationalHistoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEducation(Expression<Func<string>> educationalHistoryId, Expression<Func<string>> bodyeducationalInstitution = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodydegree = null, Expression<Func<string>> bodyhonorAwarded = null, Expression<Func<string>> bodysource = null, Expression<Func<int>> bodysourceDateyear = null, Expression<Func<int>> bodysourceDatemonth = null, Expression<Func<int>> bodysourceDateday = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodyclassOf = null, Expression<Func<int>> bodypreferredClassOf = null, Expression<Func<bool>> bodyaffiliated = null, Expression<Func<int>> bodyfromyear = null, Expression<Func<int>> bodyfrommonth = null, Expression<Func<int>> bodyfromday = null, Expression<Func<int>> bodytoyear = null, Expression<Func<int>> bodytomonth = null, Expression<Func<int>> bodytoday = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodylevel = null)
        {
            var __workflow_educationalHistoryId = WorkflowExpression.Compile(educationalHistoryId, nameof(educationalHistoryId), required: true);
            var __workflow_bodyeducationalInstitution = WorkflowExpression.Compile(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyprogram = WorkflowExpression.Compile(bodyprogram, nameof(bodyprogram), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodyhonorAwarded = WorkflowExpression.Compile(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodysourceDateyear = WorkflowExpression.Compile(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            var __workflow_bodysourceDatemonth = WorkflowExpression.Compile(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            var __workflow_bodysourceDateday = WorkflowExpression.Compile(bodysourceDateday, nameof(bodysourceDateday), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodypreferredClassOf = WorkflowExpression.Compile(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            var __workflow_bodyaffiliated = WorkflowExpression.Compile(bodyaffiliated, nameof(bodyaffiliated), required: false);
            var __workflow_bodyfromyear = WorkflowExpression.Compile(bodyfromyear, nameof(bodyfromyear), required: false);
            var __workflow_bodyfrommonth = WorkflowExpression.Compile(bodyfrommonth, nameof(bodyfrommonth), required: false);
            var __workflow_bodyfromday = WorkflowExpression.Compile(bodyfromday, nameof(bodyfromday), required: false);
            var __workflow_bodytoyear = WorkflowExpression.Compile(bodytoyear, nameof(bodytoyear), required: false);
            var __workflow_bodytomonth = WorkflowExpression.Compile(bodytomonth, nameof(bodytomonth), required: false);
            var __workflow_bodytoday = WorkflowExpression.Compile(bodytoday, nameof(bodytoday), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/educationalhistories/{0}", __workflow_educationalHistoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeducationalInstitution != null)
                {
                    body["educational_institution_id"] = ExpressionConverter.ConvertO(__workflow_bodyeducationalInstitution);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["educational_history_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary_record"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyprogram != null)
                {
                    body["educational_program"] = ExpressionConverter.ConvertO(__workflow_bodyprogram);
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["educational_degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodyhonorAwarded != null)
                {
                    body["educational_award"] = ExpressionConverter.ConvertO(__workflow_bodyhonorAwarded);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["educational_source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                var educationalSourceDateObject = new JObject();
                var educationalSourceDateObjectpropCount = 0;
                if (__workflow_bodysourceDateyear != null)
                {
                    educationalSourceDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodysourceDateyear);
                    educationalSourceDateObjectpropCount++;
                }

                if (__workflow_bodysourceDatemonth != null)
                {
                    educationalSourceDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodysourceDatemonth);
                    educationalSourceDateObjectpropCount++;
                }

                if (__workflow_bodysourceDateday != null)
                {
                    educationalSourceDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodysourceDateday);
                    educationalSourceDateObjectpropCount++;
                }

                if (educationalSourceDateObjectpropCount > 0)
                {
                    body["educational_source_date"] = educationalSourceDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["year"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["month"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["day"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_year"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredClassOf != null)
                {
                    body["preferred_class_year"] = ExpressionConverter.ConvertO(__workflow_bodypreferredClassOf);
                    bodypropCount++;
                }

                if (__workflow_bodyaffiliated != null)
                {
                    body["affiliated"] = ExpressionConverter.ConvertO(__workflow_bodyaffiliated);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (__workflow_bodyfromyear != null)
                {
                    startDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodyfromyear);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyfrommonth != null)
                {
                    startDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyfrommonth);
                    startDateObjectpropCount++;
                }

                if (__workflow_bodyfromday != null)
                {
                    startDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyfromday);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodytoyear != null)
                {
                    dateLeftObject["year"] = ExpressionConverter.ConvertO(__workflow_bodytoyear);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodytomonth != null)
                {
                    dateLeftObject["month"] = ExpressionConverter.ConvertO(__workflow_bodytomonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodytoday != null)
                {
                    dateLeftObject["day"] = ExpressionConverter.ConvertO(__workflow_bodytoday);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreason != null)
                {
                    body["educational_history_reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodylevel != null)
                {
                    body["educational_history_level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyemailAddress, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<string>> bodydoNotEmailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodydoNotEmailReason = WorkflowExpression.Compile(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyorigin = WorkflowExpression.Compile(bodyorigin, nameof(bodyorigin), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodycopyToSpouse = WorkflowExpression.Compile(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEmailAddress>(() =>
            {
                var apiCallPath = "/crm-conmg/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                if (__workflow_bodytype != null)
                {
                    body["email_address_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
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

                if (__workflow_bodydoNotEmailReason != null)
                {
                    body["donotemailreason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmailReason);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["emailisconfidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                if (__workflow_bodyorigin != null)
                {
                    body["origin"] = ExpressionConverter.ConvertO(__workflow_bodyorigin);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_email_address"] = ExpressionConverter.ConvertO(__workflow_bodycopyToSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_email_address"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentEmailAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEmailAddress(Expression<Func<string>> emailAddressId)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<string>> bodydoNotEmailReason = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodydoNotEmailReason = WorkflowExpression.Compile(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodycopyToSpouse = WorkflowExpression.Compile(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["email_address_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
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

                if (__workflow_bodydoNotEmailReason != null)
                {
                    body["donotemailreason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmailReason);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["emailisconfidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_email_address"] = ExpressionConverter.ConvertO(__workflow_bodycopyToSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_email_address"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> CreateFundraiserConstituency(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodydateFrom = WorkflowExpression.Compile(bodydateFrom, nameof(bodydateFrom), required: false);
            var __workflow_bodydateTo = WorkflowExpression.Compile(bodydateTo, nameof(bodydateTo), required: false);
            return new DeferredBodyAction<ConmgCreatedFundraiserConstituency>(() =>
            {
                var apiCallPath = "/crm-conmg/fundraisers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                if (__workflow_bodydateFrom != null)
                {
                    body["date_from"] = ExpressionConverter.ConvertO(__workflow_bodydateFrom);
                    bodypropCount++;
                }

                if (__workflow_bodydateTo != null)
                {
                    body["date_to"] = ExpressionConverter.ConvertO(__workflow_bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedFundraiserConstituency>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId)
        {
            var __workflow_fundraiserConstituencyId = WorkflowExpression.Compile(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/fundraisers/{0}", __workflow_fundraiserConstituencyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditFundraiserConstituency(Expression<Func<string>> fundraiserConstituencyId, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var __workflow_fundraiserConstituencyId = WorkflowExpression.Compile(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            var __workflow_bodydateFrom = WorkflowExpression.Compile(bodydateFrom, nameof(bodydateFrom), required: false);
            var __workflow_bodydateTo = WorkflowExpression.Compile(bodydateTo, nameof(bodydateTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/fundraisers/{0}", __workflow_fundraiserConstituencyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydateFrom != null)
                {
                    body["date_from"] = ExpressionConverter.ConvertO(__workflow_bodydateFrom);
                    bodypropCount++;
                }

                if (__workflow_bodydateTo != null)
                {
                    body["date_to"] = ExpressionConverter.ConvertO(__workflow_bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null)
        {
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodydoNotSendMail = WorkflowExpression.Compile(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            var __workflow_bodydoNotMailReason = WorkflowExpression.Compile(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodycongressionalDistrict = WorkflowExpression.Compile(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            var __workflow_bodyphoneType = WorkflowExpression.Compile(bodyphoneType, nameof(bodyphoneType), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodynickname = WorkflowExpression.Compile(bodynickname, nameof(bodynickname), required: false);
            var __workflow_bodymaidenName = WorkflowExpression.Compile(bodymaidenName, nameof(bodymaidenName), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            return new DeferredBodyAction<ConmgCreatedIndividualConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressType != null)
                {
                    body["address_type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["address_country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address_block"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["address_city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["address_state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["address_post_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotSendMail != null)
                {
                    body["address_do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotSendMail);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMailReason != null)
                {
                    body["address_do_not_mail_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMailReason);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["address_dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
                    bodypropCount++;
                }

                if (__workflow_bodycART != null)
                {
                    body["address_cart"] = ExpressionConverter.ConvertO(__workflow_bodycART);
                    bodypropCount++;
                }

                if (__workflow_bodylOT != null)
                {
                    body["address_lot"] = ExpressionConverter.ConvertO(__workflow_bodylOT);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["address_county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodycongressionalDistrict != null)
                {
                    body["address_congressional_district"] = ExpressionConverter.ConvertO(__workflow_bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneType != null)
                {
                    body["phone_type"] = ExpressionConverter.ConvertO(__workflow_bodyphoneType);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyemailType != null)
                {
                    body["email_address_type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle_name"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
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

                if (__workflow_bodynickname != null)
                {
                    body["nickname"] = ExpressionConverter.ConvertO(__workflow_bodynickname);
                    bodypropCount++;
                }

                if (__workflow_bodymaidenName != null)
                {
                    body["maiden_name"] = ExpressionConverter.ConvertO(__workflow_bodymaidenName);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                var birthDateObject = new JObject();
                var birthDateObjectpropCount = 0;
                if (__workflow_bodybirthdateyear != null)
                {
                    birthDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthDateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthDateObjectpropCount++;
                }

                if (__workflow_bodybirthdateday != null)
                {
                    birthDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthDateObjectpropCount++;
                }

                if (birthDateObjectpropCount > 0)
                {
                    body["birth_date"] = birthDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender_code"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgIndividualConstituent> GetIndividualConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgIndividualConstituent>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/individuals/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditIndividualConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodynickname = null, Expression<Func<string>> bodymaidenName = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodynickname = WorkflowExpression.Compile(bodynickname, nameof(bodynickname), required: false);
            var __workflow_bodymaidenName = WorkflowExpression.Compile(bodymaidenName, nameof(bodymaidenName), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodydeceased = WorkflowExpression.Compile(bodydeceased, nameof(bodydeceased), required: false);
            var __workflow_bodyprofilePicture = WorkflowExpression.Compile(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            var __workflow_bodyprofileThumbnail = WorkflowExpression.Compile(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/individuals/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle_name"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
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

                if (__workflow_bodynickname != null)
                {
                    body["nickname"] = ExpressionConverter.ConvertO(__workflow_bodynickname);
                    bodypropCount++;
                }

                if (__workflow_bodymaidenName != null)
                {
                    body["maiden_name"] = ExpressionConverter.ConvertO(__workflow_bodymaidenName);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                var birthDateObject = new JObject();
                var birthDateObjectpropCount = 0;
                if (__workflow_bodybirthdateyear != null)
                {
                    birthDateObject["year"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthDateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthDateObjectpropCount++;
                }

                if (__workflow_bodybirthdateday != null)
                {
                    birthDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthDateObjectpropCount++;
                }

                if (birthDateObjectpropCount > 0)
                {
                    body["birth_date"] = birthDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender_code"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["web_address"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodydeceased != null)
                {
                    body["deceased"] = ExpressionConverter.ConvertO(__workflow_bodydeceased);
                    bodypropCount++;
                }

                if (__workflow_bodyprofilePicture != null)
                {
                    body["picture"] = ExpressionConverter.ConvertO(__workflow_bodyprofilePicture);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> CreateConstituentInteraction(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysummary, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyexpectedDate, Expression<Func<string>> bodycontactMethod, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyotherLocation = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgNewConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: true);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodyexpectedStarthour = WorkflowExpression.Compile(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            var __workflow_bodyexpectedStartminute = WorkflowExpression.Compile(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            var __workflow_bodyexpectedEndhour = WorkflowExpression.Compile(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            var __workflow_bodyexpectedEndminute = WorkflowExpression.Compile(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodyownerID = WorkflowExpression.Compile(bodyownerID, nameof(bodyownerID), required: false);
            var __workflow_bodyeventID = WorkflowExpression.Compile(bodyeventID, nameof(bodyeventID), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyotherLocation = WorkflowExpression.Compile(bodyotherLocation, nameof(bodyotherLocation), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentInteraction>(() =>
            {
                var apiCallPath = "/crm-conmg/interactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["objective"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStartminute);
                    expectedStartTimeObjectpropCount++;
                }

                if (expectedStartTimeObjectpropCount > 0)
                {
                    body["expected_start_time"] = expectedStartTimeObject;
                    bodypropCount++;
                }

                var expectedEndTimeObject = new JObject();
                var expectedEndTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedEndhour != null)
                {
                    expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                if (__workflow_bodyownerID != null)
                {
                    body["fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                if (__workflow_bodyeventID != null)
                {
                    body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventID);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyotherLocation != null)
                {
                    body["other_location"] = ExpressionConverter.ConvertO(__workflow_bodyotherLocation);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentInteraction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgConstituentInteraction> GetConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredBodyAction<ConmgConstituentInteraction>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentInteraction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentInteraction(Expression<Func<string>> constituentInteractionId)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentInteraction(Expression<Func<string>> constituentInteractionId, Expression<Func<string>> bodysummary = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<string>> bodyownerID = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodycomments = null, Expression<Func<ConmgUpdateConstituentInteractionParticipant[]>> bodyparticipants = null)
        {
            var __workflow_constituentInteractionId = WorkflowExpression.Compile(constituentInteractionId, nameof(constituentInteractionId), required: true);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyexpectedStarthour = WorkflowExpression.Compile(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            var __workflow_bodyexpectedStartminute = WorkflowExpression.Compile(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            var __workflow_bodyexpectedEndhour = WorkflowExpression.Compile(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            var __workflow_bodyexpectedEndminute = WorkflowExpression.Compile(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodyownerID = WorkflowExpression.Compile(bodyownerID, nameof(bodyownerID), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodyeventID = WorkflowExpression.Compile(bodyeventID, nameof(bodyeventID), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/interactions/{0}", __workflow_constituentInteractionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysummary != null)
                {
                    body["objective"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStartminute);
                    expectedStartTimeObjectpropCount++;
                }

                if (expectedStartTimeObjectpropCount > 0)
                {
                    body["expected_start_time"] = expectedStartTimeObject;
                    bodypropCount++;
                }

                var expectedEndTimeObject = new JObject();
                var expectedEndTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedEndhour != null)
                {
                    expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                if (__workflow_bodyownerID != null)
                {
                    body["fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerID);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                if (__workflow_bodyeventID != null)
                {
                    body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventID);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgMergedConstituent> MergeTwoConstituents(Expression<Func<string>> bodysourceConstituentID, Expression<Func<string>> bodytargetConstituentID, Expression<Func<string>> bodyconfiguration, Expression<Func<bool>> bodydeleteSource, Expression<Func<bodydeleteActionInput>> bodydeleteAction, Expression<Func<string>> bodyinactiveReason = null, Expression<Func<string>> bodyinactivityDetails = null)
        {
            var __workflow_bodysourceConstituentID = WorkflowExpression.Compile(bodysourceConstituentID, nameof(bodysourceConstituentID), required: true);
            var __workflow_bodytargetConstituentID = WorkflowExpression.Compile(bodytargetConstituentID, nameof(bodytargetConstituentID), required: true);
            var __workflow_bodyconfiguration = WorkflowExpression.Compile(bodyconfiguration, nameof(bodyconfiguration), required: true);
            var __workflow_bodydeleteSource = WorkflowExpression.Compile(bodydeleteSource, nameof(bodydeleteSource), required: true);
            var __workflow_bodydeleteAction = WorkflowExpression.Compile(bodydeleteAction, nameof(bodydeleteAction), required: true);
            var __workflow_bodyinactiveReason = WorkflowExpression.Compile(bodyinactiveReason, nameof(bodyinactiveReason), required: false);
            var __workflow_bodyinactivityDetails = WorkflowExpression.Compile(bodyinactivityDetails, nameof(bodyinactivityDetails), required: false);
            return new DeferredBodyAction<ConmgMergedConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/mergetwoconstituents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source_id"] = ExpressionConverter.ConvertO(__workflow_bodysourceConstituentID);
                bodypropCount++;
                body["target_id"] = ExpressionConverter.ConvertO(__workflow_bodytargetConstituentID);
                bodypropCount++;
                body["config"] = ExpressionConverter.ConvertO(__workflow_bodyconfiguration);
                bodypropCount++;
                body["delete_source"] = ExpressionConverter.ConvertO(__workflow_bodydeleteSource);
                bodypropCount++;
                body["delete_source_constituent"] = ExpressionConverter.ConvertO(__workflow_bodydeleteAction);
                if (__workflow_bodyinactiveReason != null)
                {
                    body["constituent_inactivity_reason_code"] = ExpressionConverter.ConvertO(__workflow_bodyinactiveReason);
                    bodypropCount++;
                }

                if (__workflow_bodyinactivityDetails != null)
                {
                    body["constituent_inactivity_details"] = ExpressionConverter.ConvertO(__workflow_bodyinactivityDetails);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgMergedConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<bool>> bodydoNotSendMail = null, Expression<Func<string>> bodydoNotMailReason = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycongressionalDistrict = null, Expression<Func<string>> bodyphoneType = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodynoOfSubsidiaryOrgs = WorkflowExpression.Compile(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            var __workflow_bodyparentOrg = WorkflowExpression.Compile(bodyparentOrg, nameof(bodyparentOrg), required: false);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodydoNotSendMail = WorkflowExpression.Compile(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            var __workflow_bodydoNotMailReason = WorkflowExpression.Compile(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodycongressionalDistrict = WorkflowExpression.Compile(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            var __workflow_bodyphoneType = WorkflowExpression.Compile(bodyphoneType, nameof(bodyphoneType), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodywebAddress = WorkflowExpression.Compile(bodywebAddress, nameof(bodywebAddress), required: false);
            var __workflow_bodyisPrimaryOrganization = WorkflowExpression.Compile(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyprofilePicture = WorkflowExpression.Compile(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            var __workflow_bodyprofileThumbnail = WorkflowExpression.Compile(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredBodyAction<ConmgCreatedOrganizationConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfSubsidiaryOrgs != null)
                {
                    body["num_subsidiaries"] = ExpressionConverter.ConvertO(__workflow_bodynoOfSubsidiaryOrgs);
                    bodypropCount++;
                }

                if (__workflow_bodyparentOrg != null)
                {
                    body["parent_corp_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentOrg);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressType != null)
                {
                    body["address_type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["address_country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address_block"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["address_city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["address_state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["address_postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotSendMail != null)
                {
                    body["address_do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotSendMail);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMailReason != null)
                {
                    body["address_do_not_mail_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMailReason);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
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

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodycongressionalDistrict != null)
                {
                    body["congressional_district"] = ExpressionConverter.ConvertO(__workflow_bodycongressionalDistrict);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneType != null)
                {
                    body["phone_type"] = ExpressionConverter.ConvertO(__workflow_bodyphoneType);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyemailType != null)
                {
                    body["email_address_type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodywebAddress != null)
                {
                    body["web_address"] = ExpressionConverter.ConvertO(__workflow_bodywebAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryOrganization != null)
                {
                    body["is_primary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyprofilePicture != null)
                {
                    body["picture"] = ExpressionConverter.ConvertO(__workflow_bodyprofilePicture);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> GetOrganizationConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgOrganizationConstituent>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/organizations/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditOrganizationConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<int>> bodynoOfSubsidiaryOrgs = null, Expression<Func<string>> bodyparentOrg = null, Expression<Func<string>> bodywebAddress = null, Expression<Func<bool>> bodyisPrimaryOrganization = null, Expression<Func<string>> bodyprofilePicture = null, Expression<Func<string>> bodyprofileThumbnail = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodynoOfSubsidiaryOrgs = WorkflowExpression.Compile(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            var __workflow_bodyparentOrg = WorkflowExpression.Compile(bodyparentOrg, nameof(bodyparentOrg), required: false);
            var __workflow_bodywebAddress = WorkflowExpression.Compile(bodywebAddress, nameof(bodywebAddress), required: false);
            var __workflow_bodyisPrimaryOrganization = WorkflowExpression.Compile(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            var __workflow_bodyprofilePicture = WorkflowExpression.Compile(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            var __workflow_bodyprofileThumbnail = WorkflowExpression.Compile(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/organizations/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["organization_name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfSubsidiaryOrgs != null)
                {
                    body["num_subsidiaries"] = ExpressionConverter.ConvertO(__workflow_bodynoOfSubsidiaryOrgs);
                    bodypropCount++;
                }

                if (__workflow_bodyparentOrg != null)
                {
                    body["parent_corp_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentOrg);
                    bodypropCount++;
                }

                if (__workflow_bodywebAddress != null)
                {
                    body["web_address"] = ExpressionConverter.ConvertO(__workflow_bodywebAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryOrganization != null)
                {
                    body["is_primary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyprofilePicture != null)
                {
                    body["picture"] = ExpressionConverter.ConvertO(__workflow_bodyprofilePicture);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileThumbnail != null)
                {
                    body["picture_thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodyprofileThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> CreateConstituentPhone(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodynumber, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<bodyoriginInput>> bodyorigin = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycallAfterhour = WorkflowExpression.Compile(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            var __workflow_bodycallAfterminute = WorkflowExpression.Compile(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            var __workflow_bodycallBeforehour = WorkflowExpression.Compile(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            var __workflow_bodycallBeforeminute = WorkflowExpression.Compile(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodydoNotCallReason = WorkflowExpression.Compile(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            var __workflow_bodydoNotText = WorkflowExpression.Compile(bodydoNotText, nameof(bodydoNotText), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyorigin = WorkflowExpression.Compile(bodyorigin, nameof(bodyorigin), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodycopyToSpouse = WorkflowExpression.Compile(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentPhone>(() =>
            {
                var apiCallPath = "/crm-conmg/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                if (__workflow_bodytype != null)
                {
                    body["phone_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                var startTimeObject = new JObject();
                var startTimeObjectpropCount = 0;
                if (__workflow_bodycallAfterhour != null)
                {
                    startTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodycallAfterhour);
                    startTimeObjectpropCount++;
                }

                if (__workflow_bodycallAfterminute != null)
                {
                    startTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodycallAfterminute);
                    startTimeObjectpropCount++;
                }

                if (startTimeObjectpropCount > 0)
                {
                    body["start_time"] = startTimeObject;
                    bodypropCount++;
                }

                var endTimeObject = new JObject();
                var endTimeObjectpropCount = 0;
                if (__workflow_bodycallBeforehour != null)
                {
                    endTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodycallBeforehour);
                    endTimeObjectpropCount++;
                }

                if (__workflow_bodycallBeforeminute != null)
                {
                    endTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodycallBeforeminute);
                    endTimeObjectpropCount++;
                }

                if (endTimeObjectpropCount > 0)
                {
                    body["end_time"] = endTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
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

                if (__workflow_bodydoNotCallReason != null)
                {
                    body["do_not_call_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCallReason);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotText != null)
                {
                    body["donottext"] = ExpressionConverter.ConvertO(__workflow_bodydoNotText);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["confidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                var seasonalStartDateObject = new JObject();
                var seasonalStartDateObjectpropCount = 0;
                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartDateObjectpropCount++;
                }

                if (seasonalStartDateObjectpropCount > 0)
                {
                    body["seasonal_start_date"] = seasonalStartDateObject;
                    bodypropCount++;
                }

                var seasonalEndDateObject = new JObject();
                var seasonalEndDateObjectpropCount = 0;
                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndDateObjectpropCount++;
                }

                if (seasonalEndDateObjectpropCount > 0)
                {
                    body["seasonal_end_date"] = seasonalEndDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyorigin != null)
                {
                    body["origin"] = ExpressionConverter.ConvertO(__workflow_bodyorigin);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_phone"] = ExpressionConverter.ConvertO(__workflow_bodycopyToSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_phone"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentPhone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentPhone(Expression<Func<string>> constituentPhoneId)
        {
            var __workflow_constituentPhoneId = WorkflowExpression.Compile(constituentPhoneId, nameof(constituentPhoneId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/phones/{0}", __workflow_constituentPhoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentPhone(Expression<Func<string>> constituentPhoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<string>> bodycountry = null, Expression<Func<int>> bodycallAfterhour = null, Expression<Func<int>> bodycallAfterminute = null, Expression<Func<int>> bodycallBeforehour = null, Expression<Func<int>> bodycallBeforeminute = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<string>> bodydoNotCallReason = null, Expression<Func<bool>> bodydoNotText = null, Expression<Func<bool>> bodyisConfidential = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyinfoSourceComments = null, Expression<Func<bool>> bodycopyToSpouse = null, Expression<Func<bool>> bodycopyToHousehold = null)
        {
            var __workflow_constituentPhoneId = WorkflowExpression.Compile(constituentPhoneId, nameof(constituentPhoneId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycallAfterhour = WorkflowExpression.Compile(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            var __workflow_bodycallAfterminute = WorkflowExpression.Compile(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            var __workflow_bodycallBeforehour = WorkflowExpression.Compile(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            var __workflow_bodycallBeforeminute = WorkflowExpression.Compile(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodydoNotCallReason = WorkflowExpression.Compile(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            var __workflow_bodydoNotText = WorkflowExpression.Compile(bodydoNotText, nameof(bodydoNotText), required: false);
            var __workflow_bodyisConfidential = WorkflowExpression.Compile(bodyisConfidential, nameof(bodyisConfidential), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyinfoSourceComments = WorkflowExpression.Compile(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            var __workflow_bodycopyToSpouse = WorkflowExpression.Compile(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            var __workflow_bodycopyToHousehold = WorkflowExpression.Compile(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/phones/{0}", __workflow_constituentPhoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["phone_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                var startTimeObject = new JObject();
                var startTimeObjectpropCount = 0;
                if (__workflow_bodycallAfterhour != null)
                {
                    startTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodycallAfterhour);
                    startTimeObjectpropCount++;
                }

                if (__workflow_bodycallAfterminute != null)
                {
                    startTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodycallAfterminute);
                    startTimeObjectpropCount++;
                }

                if (startTimeObjectpropCount > 0)
                {
                    body["start_time"] = startTimeObject;
                    bodypropCount++;
                }

                var endTimeObject = new JObject();
                var endTimeObjectpropCount = 0;
                if (__workflow_bodycallBeforehour != null)
                {
                    endTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodycallBeforehour);
                    endTimeObjectpropCount++;
                }

                if (__workflow_bodycallBeforeminute != null)
                {
                    endTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodycallBeforeminute);
                    endTimeObjectpropCount++;
                }

                if (endTimeObjectpropCount > 0)
                {
                    body["end_time"] = endTimeObject;
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

                if (__workflow_bodydoNotCallReason != null)
                {
                    body["do_not_call_reason"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCallReason);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotText != null)
                {
                    body["donottext"] = ExpressionConverter.ConvertO(__workflow_bodydoNotText);
                    bodypropCount++;
                }

                if (__workflow_bodyisConfidential != null)
                {
                    body["confidential"] = ExpressionConverter.ConvertO(__workflow_bodyisConfidential);
                    bodypropCount++;
                }

                var seasonalStartDateObject = new JObject();
                var seasonalStartDateObjectpropCount = 0;
                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartDateObjectpropCount++;
                }

                if (seasonalStartDateObjectpropCount > 0)
                {
                    body["seasonal_start_date"] = seasonalStartDateObject;
                    bodypropCount++;
                }

                var seasonalEndDateObject = new JObject();
                var seasonalEndDateObjectpropCount = 0;
                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndDateObject["month"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndDateObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndDateObject["day"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndDateObjectpropCount++;
                }

                if (seasonalEndDateObjectpropCount > 0)
                {
                    body["seasonal_end_date"] = seasonalEndDateObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["info_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyinfoSourceComments != null)
                {
                    body["info_source_comments"] = ExpressionConverter.ConvertO(__workflow_bodyinfoSourceComments);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToSpouse != null)
                {
                    body["update_matching_spouse_phone"] = ExpressionConverter.ConvertO(__workflow_bodycopyToSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodycopyToHousehold != null)
                {
                    body["update_matching_household_phone"] = ExpressionConverter.ConvertO(__workflow_bodycopyToHousehold);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> CreateConstituentEmploymentHistory(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodyrelationship, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodysyncEndDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodyrelationship = WorkflowExpression.Compile(bodyrelationship, nameof(bodyrelationship), required: true);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodycareerLevel = WorkflowExpression.Compile(bodycareerLevel, nameof(bodycareerLevel), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodysyncEndDate = WorkflowExpression.Compile(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodydivision = WorkflowExpression.Compile(bodydivision, nameof(bodydivision), required: false);
            var __workflow_bodycareerLevel2 = WorkflowExpression.Compile(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            var __workflow_bodyresponsibilities = WorkflowExpression.Compile(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEmploymentHistory>(() =>
            {
                var apiCallPath = "/crm-conmg/relationshipjobsinfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["context_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["relationship"] = ExpressionConverter.ConvertO(__workflow_bodyrelationship);
                if (__workflow_bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycareerLevel != null)
                {
                    body["career_level"] = ExpressionConverter.ConvertO(__workflow_bodycareerLevel);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["job_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
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

                if (__workflow_bodysyncEndDate != null)
                {
                    body["sync_end_date_to_relationship"] = ExpressionConverter.ConvertO(__workflow_bodysyncEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["job_department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodydivision != null)
                {
                    body["job_division"] = ExpressionConverter.ConvertO(__workflow_bodydivision);
                    bodypropCount++;
                }

                if (__workflow_bodycareerLevel2 != null)
                {
                    body["job_schedule"] = ExpressionConverter.ConvertO(__workflow_bodycareerLevel2);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibilities != null)
                {
                    body["job_responsibility"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibilities);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    body["private_record"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentEmploymentHistory>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId)
        {
            var __workflow_relationshipJobInfoId = WorkflowExpression.Compile(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", __workflow_relationshipJobInfoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentEmploymentHistory(Expression<Func<string>> relationshipJobInfoId, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodycareerLevel = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodysyncEndDate = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodycareerLevel2 = null, Expression<Func<string>> bodyresponsibilities = null, Expression<Func<bool>> bodyisPrivate = null)
        {
            var __workflow_relationshipJobInfoId = WorkflowExpression.Compile(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodycareerLevel = WorkflowExpression.Compile(bodycareerLevel, nameof(bodycareerLevel), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodysyncEndDate = WorkflowExpression.Compile(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodydivision = WorkflowExpression.Compile(bodydivision, nameof(bodydivision), required: false);
            var __workflow_bodycareerLevel2 = WorkflowExpression.Compile(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            var __workflow_bodyresponsibilities = WorkflowExpression.Compile(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", __workflow_relationshipJobInfoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycareerLevel != null)
                {
                    body["career_level"] = ExpressionConverter.ConvertO(__workflow_bodycareerLevel);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["job_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
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

                if (__workflow_bodysyncEndDate != null)
                {
                    body["sync_end_date_to_relationship"] = ExpressionConverter.ConvertO(__workflow_bodysyncEndDate);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["job_department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodydivision != null)
                {
                    body["job_division"] = ExpressionConverter.ConvertO(__workflow_bodydivision);
                    bodypropCount++;
                }

                if (__workflow_bodycareerLevel2 != null)
                {
                    body["job_schedule"] = ExpressionConverter.ConvertO(__workflow_bodycareerLevel2);
                    bodypropCount++;
                }

                if (__workflow_bodyresponsibilities != null)
                {
                    body["job_responsibility"] = ExpressionConverter.ConvertO(__workflow_bodyresponsibilities);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    body["private_record"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentID = WorkflowExpression.Compile(bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentSolicitCode>(() =>
            {
                var apiCallPath = "/crm-conmg/solicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
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

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConmgCreatedConstituentSolicitCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction DeleteConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/solicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        public IWorkflowAction EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-conmg/solicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
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

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
