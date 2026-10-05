//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmconstitu
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmconstituActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentAddress))]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> CreateConstituentAddress([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyhistoricalStartDate = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodystateHouseDistrict = null, [WorkflowExpression] Func<string> bodystateSenateDistrict = null, [WorkflowExpression] Func<string> bodylocalPrecinct = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodyrecentlyMoved = null, [WorkflowExpression] Func<string> bodyoldAddress = null, [WorkflowExpression] Func<bool> bodyomitFromValidation = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAddress> __BuildCreateConstituentAddress(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodycountry, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypostalCode = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotMail = null, WorkflowValue<string> bodydoNotMailReason = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<int> bodyseasonalStartmonth = null, WorkflowValue<int> bodyseasonalStartday = null, WorkflowValue<int> bodyseasonalEndmonth = null, WorkflowValue<int> bodyseasonalEndday = null, WorkflowValue<string> bodyhistoricalStartDate = null, WorkflowValue<string> bodycounty = null, WorkflowValue<string> bodyregion = null, WorkflowValue<string> bodydPC = null, WorkflowValue<string> bodycART = null, WorkflowValue<string> bodylOT = null, WorkflowValue<string> bodycongressionalDistrict = null, WorkflowValue<string> bodystateHouseDistrict = null, WorkflowValue<string> bodystateSenateDistrict = null, WorkflowValue<string> bodylocalPrecinct = null, WorkflowValue<bodyoriginInput> bodyorigin = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodyrecentlyMoved = null, WorkflowValue<string> bodyoldAddress = null, WorkflowValue<bool> bodyomitFromValidation = null, WorkflowValue<bool> bodycopyToSpouse = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            WorkflowValue.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowValue.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowValue.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowValue.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowValue.Validate(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            WorkflowValue.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowValue.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowValue.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowValue.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowValue.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowValue.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowValue.Validate(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            WorkflowValue.Validate(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            WorkflowValue.Validate(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            WorkflowValue.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodyrecentlyMoved, nameof(bodyrecentlyMoved), required: false);
            WorkflowValue.Validate(bodyoldAddress, nameof(bodyoldAddress), required: false);
            WorkflowValue.Validate(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            WorkflowValue.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAddress>(() =>
            {
                var apiCallPath = "/crm-conmg/addresses";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentAddress))]
        public IWorkflowAction DeleteConstituentAddress([WorkflowExpression] Func<string> constituentAddressId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAddress(WorkflowValue<string> constituentAddressId)
        {
            WorkflowValue.Validate(constituentAddressId, nameof(constituentAddressId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAddressId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentAddress))]
        public IWorkflowAction EditConstituentAddress([WorkflowExpression] Func<string> constituentAddressId, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyhistoricalStartDate = null, [WorkflowExpression] Func<string> bodyhistoricalEndDate = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodystateHouseDistrict = null, [WorkflowExpression] Func<string> bodystateSenateDistrict = null, [WorkflowExpression] Func<string> bodylocalPrecinct = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodyomitFromValidation = null, [WorkflowExpression] Func<bool> bodyupdateContacts = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAddress(WorkflowValue<string> constituentAddressId, WorkflowValue<string> bodycountry = null, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypostalCode = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotMail = null, WorkflowValue<string> bodydoNotMailReason = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<int> bodyseasonalStartmonth = null, WorkflowValue<int> bodyseasonalStartday = null, WorkflowValue<int> bodyseasonalEndmonth = null, WorkflowValue<int> bodyseasonalEndday = null, WorkflowValue<string> bodyhistoricalStartDate = null, WorkflowValue<string> bodyhistoricalEndDate = null, WorkflowValue<string> bodycounty = null, WorkflowValue<string> bodyregion = null, WorkflowValue<string> bodydPC = null, WorkflowValue<string> bodycART = null, WorkflowValue<string> bodylOT = null, WorkflowValue<string> bodycongressionalDistrict = null, WorkflowValue<string> bodystateHouseDistrict = null, WorkflowValue<string> bodystateSenateDistrict = null, WorkflowValue<string> bodylocalPrecinct = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodyomitFromValidation = null, WorkflowValue<bool> bodyupdateContacts = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(constituentAddressId, nameof(constituentAddressId), required: true);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotMail, nameof(bodydoNotMail), required: false);
            WorkflowValue.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowValue.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowValue.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowValue.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowValue.Validate(bodyhistoricalStartDate, nameof(bodyhistoricalStartDate), required: false);
            WorkflowValue.Validate(bodyhistoricalEndDate, nameof(bodyhistoricalEndDate), required: false);
            WorkflowValue.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowValue.Validate(bodyregion, nameof(bodyregion), required: false);
            WorkflowValue.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowValue.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowValue.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowValue.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowValue.Validate(bodystateHouseDistrict, nameof(bodystateHouseDistrict), required: false);
            WorkflowValue.Validate(bodystateSenateDistrict, nameof(bodystateSenateDistrict), required: false);
            WorkflowValue.Validate(bodylocalPrecinct, nameof(bodylocalPrecinct), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodyomitFromValidation, nameof(bodyomitFromValidation), required: false);
            WorkflowValue.Validate(bodyupdateContacts, nameof(bodyupdateContacts), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAddressId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentAlternateLookupID))]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> CreateConstituentAlternateLookupID([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyalternateLookupID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAlternateLookupID> __BuildCreateConstituentAlternateLookupID(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodytype, WorkflowValue<string> bodyalternateLookupID)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyalternateLookupID, nameof(bodyalternateLookupID), required: true);
            return new DeferredBodyAction<ConmgCreatedConstituentAlternateLookupID>(() =>
            {
                var apiCallPath = "/crm-conmg/alternatelookupids";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentAlternateLookupID))]
        public IWorkflowAction DeleteConstituentAlternateLookupID([WorkflowExpression] Func<string> alternateLookupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAlternateLookupID(WorkflowValue<string> alternateLookupId)
        {
            WorkflowValue.Validate(alternateLookupId, nameof(alternateLookupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/alternatelookupids/{0}", ExpressionConverter.ConvertWithUrlEncoding(alternateLookupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentAlternateLookupID))]
        public IWorkflowAction EditConstituentAlternateLookupID([WorkflowExpression] Func<string> alternateLookupId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyalternateLookupID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAlternateLookupID(WorkflowValue<string> alternateLookupId, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyalternateLookupID = null)
        {
            WorkflowValue.Validate(alternateLookupId, nameof(alternateLookupId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyalternateLookupID, nameof(bodyalternateLookupID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/alternatelookupids/{0}", ExpressionConverter.ConvertWithUrlEncoding(alternateLookupId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentAppealResponse))]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> CreateConstituentAppealResponse([WorkflowExpression] Func<string> bodyconstituentAppealID, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodyresponse, [WorkflowExpression] Func<string> bodydate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppealResponse> __BuildCreateConstituentAppealResponse(WorkflowValue<string> bodyconstituentAppealID, WorkflowValue<string> bodycategory, WorkflowValue<string> bodyresponse, WorkflowValue<string> bodydate = null)
        {
            WorkflowValue.Validate(bodyconstituentAppealID, nameof(bodyconstituentAppealID), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowValue.Validate(bodyresponse, nameof(bodyresponse), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAppealResponse>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappealresponses";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentAppeal))]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> CreateConstituentAppeal([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyappealID, [WorkflowExpression] Func<string> bodymailing = null, [WorkflowExpression] Func<string> bodydateSent = null, [WorkflowExpression] Func<string> bodypackage = null, [WorkflowExpression] Func<string> bodysourceCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentAppeal> __BuildCreateConstituentAppeal(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodyappealID, WorkflowValue<string> bodymailing = null, WorkflowValue<string> bodydateSent = null, WorkflowValue<string> bodypackage = null, WorkflowValue<string> bodysourceCode = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodyappealID, nameof(bodyappealID), required: true);
            WorkflowValue.Validate(bodymailing, nameof(bodymailing), required: false);
            WorkflowValue.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowValue.Validate(bodypackage, nameof(bodypackage), required: false);
            WorkflowValue.Validate(bodysourceCode, nameof(bodysourceCode), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentAppeal>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentappeals";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentAppeal))]
        public IWorkflowAction DeleteConstituentAppeal([WorkflowExpression] Func<string> constituentAppealId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAppeal(WorkflowValue<string> constituentAppealId)
        {
            WorkflowValue.Validate(constituentAppealId, nameof(constituentAppealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAppealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentAppeal))]
        public IWorkflowAction EditConstituentAppeal([WorkflowExpression] Func<string> constituentAppealId, [WorkflowExpression] Func<string> bodyappealID = null, [WorkflowExpression] Func<string> bodymailing = null, [WorkflowExpression] Func<string> bodydateSent = null, [WorkflowExpression] Func<string> bodypackage = null, [WorkflowExpression] Func<string> bodysourceCode = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentAppeal(WorkflowValue<string> constituentAppealId, WorkflowValue<string> bodyappealID = null, WorkflowValue<string> bodymailing = null, WorkflowValue<string> bodydateSent = null, WorkflowValue<string> bodypackage = null, WorkflowValue<string> bodysourceCode = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(constituentAppealId, nameof(constituentAppealId), required: true);
            WorkflowValue.Validate(bodyappealID, nameof(bodyappealID), required: false);
            WorkflowValue.Validate(bodymailing, nameof(bodymailing), required: false);
            WorkflowValue.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowValue.Validate(bodypackage, nameof(bodypackage), required: false);
            WorkflowValue.Validate(bodysourceCode, nameof(bodysourceCode), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAppealId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentAppeals))]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> ListConstituentAppeals([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentAppealCollection> __BuildListConstituentAppeals(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentAppealCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentappeals/{0}/appeals", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentAppealCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentAttribute))]
        public IWorkflowAction DeleteConstituentAttribute([WorkflowExpression] Func<string> constituentAttributeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentAttribute(WorkflowValue<string> constituentAttributeId)
        {
            WorkflowValue.Validate(constituentAttributeId, nameof(constituentAttributeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentattributes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentAttributeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentCorrespondence))]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence> CreateConstituentCorrespondence([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodycorrespondenceCode, [WorkflowExpression] Func<string> bodydateSent, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentCorrespondence> __BuildCreateConstituentCorrespondence(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodycorrespondenceCode, WorkflowValue<string> bodydateSent, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: true);
            WorkflowValue.Validate(bodydateSent, nameof(bodydateSent), required: true);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentCorrespondence>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentcorrespondencecodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
                bodypropCount++;
                body["correspondence_code"] = ExpressionConverter.ConvertO(bodycorrespondenceCode);
                bodypropCount++;
                body["date_sent"] = ExpressionConverter.ConvertO(bodydateSent);
                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentCorrespondence))]
        public IWorkflowAction DeleteConstituentCorrespondence([WorkflowExpression] Func<string> constituentCorrespondenceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentCorrespondence(WorkflowValue<string> constituentCorrespondenceId)
        {
            WorkflowValue.Validate(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCorrespondenceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentCorrespondence))]
        public IWorkflowAction EditConstituentCorrespondence([WorkflowExpression] Func<string> constituentCorrespondenceId, [WorkflowExpression] Func<string> bodycorrespondenceCode = null, [WorkflowExpression] Func<string> bodydateSent = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentCorrespondence(WorkflowValue<string> constituentCorrespondenceId, WorkflowValue<string> bodycorrespondenceCode = null, WorkflowValue<string> bodydateSent = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(constituentCorrespondenceId, nameof(constituentCorrespondenceId), required: true);
            WorkflowValue.Validate(bodycorrespondenceCode, nameof(bodycorrespondenceCode), required: false);
            WorkflowValue.Validate(bodydateSent, nameof(bodydateSent), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentcorrespondencecodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentCorrespondenceId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycorrespondenceCode != null)
                {
                    body["correspondence_code"] = ExpressionConverter.ConvertO(bodycorrespondenceCode);
                    bodypropCount++;
                }

                if (bodydateSent != null)
                {
                    body["date_sent"] = ExpressionConverter.ConvertO(bodydateSent);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentNote))]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> CreateConstituentNote([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyauthorID = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyhTML = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentNote> __BuildCreateConstituentNote(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodytype, WorkflowValue<string> bodydate, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyauthorID = null, WorkflowValue<string> bodynote = null, WorkflowValue<string> bodyhTML = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyauthorID, nameof(bodyauthorID), required: false);
            WorkflowValue.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowValue.Validate(bodyhTML, nameof(bodyhTML), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentNote>(() =>
            {
                var apiCallPath = "/crm-conmg/constituentnotes";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentNote))]
        public IWorkflowAction DeleteConstituentNote([WorkflowExpression] Func<string> constituentNoteId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentNote(WorkflowValue<string> constituentNoteId)
        {
            WorkflowValue.Validate(constituentNoteId, nameof(constituentNoteId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentnotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentNoteId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentNote))]
        public IWorkflowAction EditConstituentNote([WorkflowExpression] Func<string> constituentNoteId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyauthorID = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyhTML = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentNote(WorkflowValue<string> constituentNoteId, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyauthorID = null, WorkflowValue<string> bodynote = null, WorkflowValue<string> bodyhTML = null)
        {
            WorkflowValue.Validate(constituentNoteId, nameof(constituentNoteId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyauthorID, nameof(bodyauthorID), required: false);
            WorkflowValue.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowValue.Validate(bodyhTML, nameof(bodyhTML), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituentnotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentNoteId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildSearchConstituent))]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> SearchConstituent([WorkflowExpression] Func<string> keyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> emailAddress = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> addressBlock = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<int> classof = null, [WorkflowExpression] Func<bool> exactMatchOnly = null, [WorkflowExpression] Func<string> middleName = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<string> sourcecode = null, [WorkflowExpression] Func<bool> includeIndividuals = null, [WorkflowExpression] Func<bool> includeOrganizations = null, [WorkflowExpression] Func<bool> includeGroups = null, [WorkflowExpression] Func<bool> excludeHouseholds = null, [WorkflowExpression] Func<bool> checkNickname = null, [WorkflowExpression] Func<bool> checkAliases = null, [WorkflowExpression] Func<bool> checkAlternateLookupIds = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> fuzzySearchOnName = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentSearchResultCollection> __BuildSearchConstituent(WorkflowValue<string> keyName = null, WorkflowValue<string> firstName = null, WorkflowValue<string> lookupId = null, WorkflowValue<string> emailAddress = null, WorkflowValue<string> phoneNumber = null, WorkflowValue<string> country = null, WorkflowValue<string> addressBlock = null, WorkflowValue<string> city = null, WorkflowValue<string> state = null, WorkflowValue<string> postCode = null, WorkflowValue<int> classof = null, WorkflowValue<bool> exactMatchOnly = null, WorkflowValue<string> middleName = null, WorkflowValue<string> constituency = null, WorkflowValue<string> sourcecode = null, WorkflowValue<bool> includeIndividuals = null, WorkflowValue<bool> includeOrganizations = null, WorkflowValue<bool> includeGroups = null, WorkflowValue<bool> excludeHouseholds = null, WorkflowValue<bool> checkNickname = null, WorkflowValue<bool> checkAliases = null, WorkflowValue<bool> checkAlternateLookupIds = null, WorkflowValue<bool> onlyPrimaryAddress = null, WorkflowValue<bool> includeDeceased = null, WorkflowValue<bool> includeInactive = null, WorkflowValue<bool> fuzzySearchOnName = null, WorkflowValue<int> limit = null)
        {
            WorkflowValue.Validate(keyName, nameof(keyName), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(lookupId, nameof(lookupId), required: false);
            WorkflowValue.Validate(emailAddress, nameof(emailAddress), required: false);
            WorkflowValue.Validate(phoneNumber, nameof(phoneNumber), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(addressBlock, nameof(addressBlock), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(postCode, nameof(postCode), required: false);
            WorkflowValue.Validate(classof, nameof(classof), required: false);
            WorkflowValue.Validate(exactMatchOnly, nameof(exactMatchOnly), required: false);
            WorkflowValue.Validate(middleName, nameof(middleName), required: false);
            WorkflowValue.Validate(constituency, nameof(constituency), required: false);
            WorkflowValue.Validate(sourcecode, nameof(sourcecode), required: false);
            WorkflowValue.Validate(includeIndividuals, nameof(includeIndividuals), required: false);
            WorkflowValue.Validate(includeOrganizations, nameof(includeOrganizations), required: false);
            WorkflowValue.Validate(includeGroups, nameof(includeGroups), required: false);
            WorkflowValue.Validate(excludeHouseholds, nameof(excludeHouseholds), required: false);
            WorkflowValue.Validate(checkNickname, nameof(checkNickname), required: false);
            WorkflowValue.Validate(checkAliases, nameof(checkAliases), required: false);
            WorkflowValue.Validate(checkAlternateLookupIds, nameof(checkAlternateLookupIds), required: false);
            WorkflowValue.Validate(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            WorkflowValue.Validate(includeDeceased, nameof(includeDeceased), required: false);
            WorkflowValue.Validate(includeInactive, nameof(includeInactive), required: false);
            WorkflowValue.Validate(fuzzySearchOnName, nameof(fuzzySearchOnName), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ConmgConstituentSearchResultCollection>(() =>
            {
                var apiCallPath = "/crm-conmg/constituents/search";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituent))]
        public IWorkflowAction DeleteConstituent([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituent(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentAddresses))]
        public IBodyWorkflowAction<ConmgAddressCollection> ListConstituentAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeFormer = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAddressCollection> __BuildListConstituentAddresses(WorkflowValue<string> constituentId, WorkflowValue<bool> includeFormer = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(includeFormer, nameof(includeFormer), required: false);
            return new DeferredBodyAction<ConmgAddressCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeFormer != null)
                    callPayload.Queries["include_former"] = ExpressionConverter.Convert(includeFormer);
                return new ApiConnectionAction<ConmgAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentAlternateLookupIDs))]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> ListConstituentAlternateLookupIDs([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAlternateLookupIDCollection> __BuildListConstituentAlternateLookupIDs(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAlternateLookupIDCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/alternatelookupids", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAlternateLookupIDCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentAttributes))]
        public IBodyWorkflowAction<ConmgAttributeCollection> ListConstituentAttributes([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgAttributeCollection> __BuildListConstituentAttributes(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgAttributeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/constituentattributelist", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgAttributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetConstituentPrimaryContactInfo))]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> GetConstituentPrimaryContactInfo([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentPrimaryContactInfo> __BuildGetConstituentPrimaryContactInfo(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentPrimaryContactInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/contactview", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentPrimaryContactInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentEducations))]
        public IBodyWorkflowAction<ConmgEducationCollection> ListConstituentEducations([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEducationCollection> __BuildListConstituentEducations(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEducationCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/educationalhistories", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEducationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentEmailAddresses))]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> ListConstituentEmailAddresses([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEmailAddressCollection> __BuildListConstituentEmailAddresses(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgEmailAddressCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/emailaddresses", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgEmailAddressCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentPhones))]
        public IBodyWorkflowAction<ConmgPhoneCollection> ListConstituentPhones([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgPhoneCollection> __BuildListConstituentPhones(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgPhoneCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/phones", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgPhoneCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetConstituentProfilePicture))]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> GetConstituentProfilePicture([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentProfilePicture> __BuildGetConstituentProfilePicture(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentProfilePicture>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/profilepicture", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentProfilePicture>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentEmploymentHistory))]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> ListConstituentEmploymentHistory([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgEmploymentHistoryCollection> __BuildListConstituentEmploymentHistory(WorkflowValue<string> constituentId, WorkflowValue<bool> includeInactive = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConmgEmploymentHistoryCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/relationshipjobsinfo", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
                return new ApiConnectionAction<ConmgEmploymentHistoryCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentSolicitCodes))]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> ListConstituentSolicitCodes([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> showExpired = null, [WorkflowExpression] Func<dateRangeInput> dateRange = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgSolicitCodeCollection> __BuildListConstituentSolicitCodes(WorkflowValue<string> constituentId, WorkflowValue<bool> showExpired = null, WorkflowValue<dateRangeInput> dateRange = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(showExpired, nameof(showExpired), required: false);
            WorkflowValue.Validate(dateRange, nameof(dateRange), required: false);
            return new DeferredBodyAction<ConmgSolicitCodeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/solicitcodes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (showExpired != null)
                    callPayload.Queries["show_expired"] = ExpressionConverter.Convert(showExpired);
                if (dateRange != null)
                    callPayload.Queries["date_range"] = ExpressionConverter.Convert(dateRange);
                return new ApiConnectionAction<ConmgSolicitCodeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildListConstituentTributes))]
        public IBodyWorkflowAction<ConmgTributeCollection> ListConstituentTributes([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgTributeCollection> __BuildListConstituentTributes(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgTributeCollection>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/tributes", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetConstituentSummaryProfile))]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> GetConstituentSummaryProfile([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentSummaryProfile> __BuildGetConstituentSummaryProfile(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgConstituentSummaryProfile>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/constituents/{0}/view", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentSummaryProfile>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentEducation))]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> CreateConstituentEducation([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyeducationalInstitution, [WorkflowExpression] Func<string> bodystatus, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyprogram = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<string> bodyhonorAwarded = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<int> bodysourceDateyear = null, [WorkflowExpression] Func<int> bodysourceDatemonth = null, [WorkflowExpression] Func<int> bodysourceDateday = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodyclassOf = null, [WorkflowExpression] Func<int> bodypreferredClassOf = null, [WorkflowExpression] Func<bool> bodyaffiliated = null, [WorkflowExpression] Func<int> bodyfromyear = null, [WorkflowExpression] Func<int> bodyfrommonth = null, [WorkflowExpression] Func<int> bodyfromday = null, [WorkflowExpression] Func<int> bodytoyear = null, [WorkflowExpression] Func<int> bodytomonth = null, [WorkflowExpression] Func<int> bodytoday = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylevel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEducation> __BuildCreateConstituentEducation(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodyeducationalInstitution, WorkflowValue<string> bodystatus, WorkflowValue<bool> bodyprimary = null, WorkflowValue<string> bodyprogram = null, WorkflowValue<string> bodydegree = null, WorkflowValue<string> bodyhonorAwarded = null, WorkflowValue<string> bodysource = null, WorkflowValue<int> bodysourceDateyear = null, WorkflowValue<int> bodysourceDatemonth = null, WorkflowValue<int> bodysourceDateday = null, WorkflowValue<string> bodycomments = null, WorkflowValue<int> bodydateGraduatedyear = null, WorkflowValue<int> bodydateGraduatedmonth = null, WorkflowValue<int> bodydateGraduatedday = null, WorkflowValue<int> bodyclassOf = null, WorkflowValue<int> bodypreferredClassOf = null, WorkflowValue<bool> bodyaffiliated = null, WorkflowValue<int> bodyfromyear = null, WorkflowValue<int> bodyfrommonth = null, WorkflowValue<int> bodyfromday = null, WorkflowValue<int> bodytoyear = null, WorkflowValue<int> bodytomonth = null, WorkflowValue<int> bodytoday = null, WorkflowValue<string> bodyreason = null, WorkflowValue<string> bodylevel = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: true);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: true);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodyprogram, nameof(bodyprogram), required: false);
            WorkflowValue.Validate(bodydegree, nameof(bodydegree), required: false);
            WorkflowValue.Validate(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowValue.Validate(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            WorkflowValue.Validate(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            WorkflowValue.Validate(bodysourceDateday, nameof(bodysourceDateday), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            WorkflowValue.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            WorkflowValue.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            WorkflowValue.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            WorkflowValue.Validate(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            WorkflowValue.Validate(bodyaffiliated, nameof(bodyaffiliated), required: false);
            WorkflowValue.Validate(bodyfromyear, nameof(bodyfromyear), required: false);
            WorkflowValue.Validate(bodyfrommonth, nameof(bodyfrommonth), required: false);
            WorkflowValue.Validate(bodyfromday, nameof(bodyfromday), required: false);
            WorkflowValue.Validate(bodytoyear, nameof(bodytoyear), required: false);
            WorkflowValue.Validate(bodytomonth, nameof(bodytomonth), required: false);
            WorkflowValue.Validate(bodytoday, nameof(bodytoday), required: false);
            WorkflowValue.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowValue.Validate(bodylevel, nameof(bodylevel), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEducation>(() =>
            {
                var apiCallPath = "/crm-conmg/educationalhistories";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentEducation))]
        public IWorkflowAction DeleteConstituentEducation([WorkflowExpression] Func<string> educationalHistoryId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEducation(WorkflowValue<string> educationalHistoryId)
        {
            WorkflowValue.Validate(educationalHistoryId, nameof(educationalHistoryId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/educationalhistories/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationalHistoryId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentEducation))]
        public IWorkflowAction EditConstituentEducation([WorkflowExpression] Func<string> educationalHistoryId, [WorkflowExpression] Func<string> bodyeducationalInstitution = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyprogram = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<string> bodyhonorAwarded = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<int> bodysourceDateyear = null, [WorkflowExpression] Func<int> bodysourceDatemonth = null, [WorkflowExpression] Func<int> bodysourceDateday = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodyclassOf = null, [WorkflowExpression] Func<int> bodypreferredClassOf = null, [WorkflowExpression] Func<bool> bodyaffiliated = null, [WorkflowExpression] Func<int> bodyfromyear = null, [WorkflowExpression] Func<int> bodyfrommonth = null, [WorkflowExpression] Func<int> bodyfromday = null, [WorkflowExpression] Func<int> bodytoyear = null, [WorkflowExpression] Func<int> bodytomonth = null, [WorkflowExpression] Func<int> bodytoday = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodylevel = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEducation(WorkflowValue<string> educationalHistoryId, WorkflowValue<string> bodyeducationalInstitution = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<string> bodyprogram = null, WorkflowValue<string> bodydegree = null, WorkflowValue<string> bodyhonorAwarded = null, WorkflowValue<string> bodysource = null, WorkflowValue<int> bodysourceDateyear = null, WorkflowValue<int> bodysourceDatemonth = null, WorkflowValue<int> bodysourceDateday = null, WorkflowValue<string> bodycomments = null, WorkflowValue<int> bodydateGraduatedyear = null, WorkflowValue<int> bodydateGraduatedmonth = null, WorkflowValue<int> bodydateGraduatedday = null, WorkflowValue<int> bodyclassOf = null, WorkflowValue<int> bodypreferredClassOf = null, WorkflowValue<bool> bodyaffiliated = null, WorkflowValue<int> bodyfromyear = null, WorkflowValue<int> bodyfrommonth = null, WorkflowValue<int> bodyfromday = null, WorkflowValue<int> bodytoyear = null, WorkflowValue<int> bodytomonth = null, WorkflowValue<int> bodytoday = null, WorkflowValue<string> bodyreason = null, WorkflowValue<string> bodylevel = null)
        {
            WorkflowValue.Validate(educationalHistoryId, nameof(educationalHistoryId), required: true);
            WorkflowValue.Validate(bodyeducationalInstitution, nameof(bodyeducationalInstitution), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodyprogram, nameof(bodyprogram), required: false);
            WorkflowValue.Validate(bodydegree, nameof(bodydegree), required: false);
            WorkflowValue.Validate(bodyhonorAwarded, nameof(bodyhonorAwarded), required: false);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowValue.Validate(bodysourceDateyear, nameof(bodysourceDateyear), required: false);
            WorkflowValue.Validate(bodysourceDatemonth, nameof(bodysourceDatemonth), required: false);
            WorkflowValue.Validate(bodysourceDateday, nameof(bodysourceDateday), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            WorkflowValue.Validate(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            WorkflowValue.Validate(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            WorkflowValue.Validate(bodyclassOf, nameof(bodyclassOf), required: false);
            WorkflowValue.Validate(bodypreferredClassOf, nameof(bodypreferredClassOf), required: false);
            WorkflowValue.Validate(bodyaffiliated, nameof(bodyaffiliated), required: false);
            WorkflowValue.Validate(bodyfromyear, nameof(bodyfromyear), required: false);
            WorkflowValue.Validate(bodyfrommonth, nameof(bodyfrommonth), required: false);
            WorkflowValue.Validate(bodyfromday, nameof(bodyfromday), required: false);
            WorkflowValue.Validate(bodytoyear, nameof(bodytoyear), required: false);
            WorkflowValue.Validate(bodytomonth, nameof(bodytomonth), required: false);
            WorkflowValue.Validate(bodytoday, nameof(bodytoday), required: false);
            WorkflowValue.Validate(bodyreason, nameof(bodyreason), required: false);
            WorkflowValue.Validate(bodylevel, nameof(bodylevel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/educationalhistories/{0}", ExpressionConverter.ConvertWithUrlEncoding(educationalHistoryId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentEmailAddress))]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> CreateConstituentEmailAddress([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyemailAddress, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<string> bodydoNotEmailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmailAddress> __BuildCreateConstituentEmailAddress(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodyemailAddress, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotEmail = null, WorkflowValue<string> bodydoNotEmailReason = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<bodyoriginInput> bodyorigin = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodycopyToSpouse = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            WorkflowValue.Validate(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEmailAddress>(() =>
            {
                var apiCallPath = "/crm-conmg/emailaddresses";
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

                if (bodydoNotEmailReason != null)
                {
                    body["donotemailreason"] = ExpressionConverter.ConvertO(bodydoNotEmailReason);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["emailisconfidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentEmailAddress))]
        public IWorkflowAction DeleteConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEmailAddress(WorkflowValue<string> emailAddressId)
        {
            WorkflowValue.Validate(emailAddressId, nameof(emailAddressId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentEmailAddress))]
        public IWorkflowAction EditConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<string> bodydoNotEmailReason = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEmailAddress(WorkflowValue<string> emailAddressId, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotEmail = null, WorkflowValue<string> bodydoNotEmailReason = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodycopyToSpouse = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(emailAddressId, nameof(emailAddressId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            WorkflowValue.Validate(bodydoNotEmailReason, nameof(bodydoNotEmailReason), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/emailaddresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailAddressId, 1));
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

                if (bodydoNotEmailReason != null)
                {
                    body["donotemailreason"] = ExpressionConverter.ConvertO(bodydoNotEmailReason);
                    bodypropCount++;
                }

                if (bodyisConfidential != null)
                {
                    body["emailisconfidential"] = ExpressionConverter.ConvertO(bodyisConfidential);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFundraiserConstituency))]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> CreateFundraiserConstituency([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedFundraiserConstituency> __BuildCreateFundraiserConstituency(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodydateFrom = null, WorkflowValue<string> bodydateTo = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodydateFrom, nameof(bodydateFrom), required: false);
            WorkflowValue.Validate(bodydateTo, nameof(bodydateTo), required: false);
            return new DeferredBodyAction<ConmgCreatedFundraiserConstituency>(() =>
            {
                var apiCallPath = "/crm-conmg/fundraisers";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFundraiserConstituency))]
        public IWorkflowAction DeleteFundraiserConstituency([WorkflowExpression] Func<string> fundraiserConstituencyId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFundraiserConstituency(WorkflowValue<string> fundraiserConstituencyId)
        {
            WorkflowValue.Validate(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/fundraisers/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundraiserConstituencyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditFundraiserConstituency))]
        public IWorkflowAction EditFundraiserConstituency([WorkflowExpression] Func<string> fundraiserConstituencyId, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditFundraiserConstituency(WorkflowValue<string> fundraiserConstituencyId, WorkflowValue<string> bodydateFrom = null, WorkflowValue<string> bodydateTo = null)
        {
            WorkflowValue.Validate(fundraiserConstituencyId, nameof(fundraiserConstituencyId), required: true);
            WorkflowValue.Validate(bodydateFrom, nameof(bodydateFrom), required: false);
            WorkflowValue.Validate(bodydateTo, nameof(bodydateTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/fundraisers/{0}", ExpressionConverter.ConvertWithUrlEncoding(fundraiserConstituencyId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIndividualConstituent))]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> CreateIndividualConstituent([WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodydoNotSendMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodyphoneType = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodynickname = null, [WorkflowExpression] Func<string> bodymaidenName = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<string> bodygender = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedIndividualConstituent> __BuildCreateIndividualConstituent(WorkflowValue<string> bodylastName, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodysuffix = null, WorkflowValue<string> bodyaddressType = null, WorkflowValue<string> bodycountry = null, WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypostalCode = null, WorkflowValue<bool> bodydoNotSendMail = null, WorkflowValue<string> bodydoNotMailReason = null, WorkflowValue<string> bodydPC = null, WorkflowValue<string> bodycART = null, WorkflowValue<string> bodylOT = null, WorkflowValue<string> bodycounty = null, WorkflowValue<string> bodycongressionalDistrict = null, WorkflowValue<string> bodyphoneType = null, WorkflowValue<string> bodyphoneNumber = null, WorkflowValue<string> bodyemailType = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodymiddleName = null, WorkflowValue<string> bodytitle2 = null, WorkflowValue<string> bodysuffix2 = null, WorkflowValue<string> bodynickname = null, WorkflowValue<string> bodymaidenName = null, WorkflowValue<string> bodymaritalStatus = null, WorkflowValue<int> bodybirthdateyear = null, WorkflowValue<int> bodybirthdatemonth = null, WorkflowValue<int> bodybirthdateday = null, WorkflowValue<string> bodygender = null)
        {
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodysuffix, nameof(bodysuffix), required: false);
            WorkflowValue.Validate(bodyaddressType, nameof(bodyaddressType), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowValue.Validate(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            WorkflowValue.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowValue.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowValue.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowValue.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowValue.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowValue.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowValue.Validate(bodyphoneType, nameof(bodyphoneType), required: false);
            WorkflowValue.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowValue.Validate(bodyemailType, nameof(bodyemailType), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowValue.Validate(bodytitle2, nameof(bodytitle2), required: false);
            WorkflowValue.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            WorkflowValue.Validate(bodynickname, nameof(bodynickname), required: false);
            WorkflowValue.Validate(bodymaidenName, nameof(bodymaidenName), required: false);
            WorkflowValue.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowValue.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            WorkflowValue.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            WorkflowValue.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            WorkflowValue.Validate(bodygender, nameof(bodygender), required: false);
            return new DeferredBodyAction<ConmgCreatedIndividualConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/individuals";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetIndividualConstituent))]
        public IBodyWorkflowAction<ConmgIndividualConstituent> GetIndividualConstituent([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgIndividualConstituent> __BuildGetIndividualConstituent(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgIndividualConstituent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditIndividualConstituent))]
        public IWorkflowAction EditIndividualConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodynickname = null, [WorkflowExpression] Func<string> bodymaidenName = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditIndividualConstituent(WorkflowValue<string> constituentId, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodysuffix = null, WorkflowValue<string> bodymiddleName = null, WorkflowValue<string> bodytitle2 = null, WorkflowValue<string> bodysuffix2 = null, WorkflowValue<string> bodynickname = null, WorkflowValue<string> bodymaidenName = null, WorkflowValue<string> bodymaritalStatus = null, WorkflowValue<int> bodybirthdateyear = null, WorkflowValue<int> bodybirthdatemonth = null, WorkflowValue<int> bodybirthdateday = null, WorkflowValue<string> bodygender = null, WorkflowValue<string> bodywebsite = null, WorkflowValue<bool> bodygivesAnonymously = null, WorkflowValue<bool> bodydeceased = null, WorkflowValue<string> bodyprofilePicture = null, WorkflowValue<string> bodyprofileThumbnail = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodysuffix, nameof(bodysuffix), required: false);
            WorkflowValue.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowValue.Validate(bodytitle2, nameof(bodytitle2), required: false);
            WorkflowValue.Validate(bodysuffix2, nameof(bodysuffix2), required: false);
            WorkflowValue.Validate(bodynickname, nameof(bodynickname), required: false);
            WorkflowValue.Validate(bodymaidenName, nameof(bodymaidenName), required: false);
            WorkflowValue.Validate(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            WorkflowValue.Validate(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            WorkflowValue.Validate(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            WorkflowValue.Validate(bodybirthdateday, nameof(bodybirthdateday), required: false);
            WorkflowValue.Validate(bodygender, nameof(bodygender), required: false);
            WorkflowValue.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowValue.Validate(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            WorkflowValue.Validate(bodydeceased, nameof(bodydeceased), required: false);
            WorkflowValue.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowValue.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentInteraction))]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> CreateConstituentInteraction([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodysummary, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodyexpectedDate, [WorkflowExpression] Func<string> bodycontactMethod, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<string> bodyownerID = null, [WorkflowExpression] Func<string> bodyeventID = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyotherLocation = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<ConmgNewConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentInteraction> __BuildCreateConstituentInteraction(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodysummary, WorkflowValue<bodystatusInput> bodystatus, WorkflowValue<string> bodyexpectedDate, WorkflowValue<string> bodycontactMethod, WorkflowValue<string> bodycategory = null, WorkflowValue<string> bodysubcategory = null, WorkflowValue<int> bodyexpectedStarthour = null, WorkflowValue<int> bodyexpectedStartminute = null, WorkflowValue<int> bodyexpectedEndhour = null, WorkflowValue<int> bodyexpectedEndminute = null, WorkflowValue<string> bodyactualDate = null, WorkflowValue<int> bodyactualStarthour = null, WorkflowValue<int> bodyactualStartminute = null, WorkflowValue<int> bodyactualEndhour = null, WorkflowValue<int> bodyactualEndminute = null, WorkflowValue<string> bodytimeZone = null, WorkflowValue<bool> bodyallDayEvent = null, WorkflowValue<string> bodyownerID = null, WorkflowValue<string> bodyeventID = null, WorkflowValue<string> bodylocation = null, WorkflowValue<string> bodyotherLocation = null, WorkflowValue<string> bodycomments = null, WorkflowValue<ConmgNewConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodysummary, nameof(bodysummary), required: true);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: true);
            WorkflowValue.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: true);
            WorkflowValue.Validate(bodycontactMethod, nameof(bodycontactMethod), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowValue.Validate(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            WorkflowValue.Validate(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            WorkflowValue.Validate(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            WorkflowValue.Validate(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            WorkflowValue.Validate(bodyactualDate, nameof(bodyactualDate), required: false);
            WorkflowValue.Validate(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            WorkflowValue.Validate(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            WorkflowValue.Validate(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            WorkflowValue.Validate(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            WorkflowValue.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowValue.Validate(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            WorkflowValue.Validate(bodyownerID, nameof(bodyownerID), required: false);
            WorkflowValue.Validate(bodyeventID, nameof(bodyeventID), required: false);
            WorkflowValue.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowValue.Validate(bodyotherLocation, nameof(bodyotherLocation), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentInteraction>(() =>
            {
                var apiCallPath = "/crm-conmg/interactions";
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

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodyotherLocation != null)
                {
                    body["other_location"] = ExpressionConverter.ConvertO(bodyotherLocation);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetConstituentInteraction))]
        public IBodyWorkflowAction<ConmgConstituentInteraction> GetConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgConstituentInteraction> __BuildGetConstituentInteraction(WorkflowValue<string> constituentInteractionId)
        {
            WorkflowValue.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredBodyAction<ConmgConstituentInteraction>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgConstituentInteraction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentInteraction))]
        public IWorkflowAction DeleteConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentInteraction(WorkflowValue<string> constituentInteractionId)
        {
            WorkflowValue.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentInteraction))]
        public IWorkflowAction EditConstituentInteraction([WorkflowExpression] Func<string> constituentInteractionId, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<string> bodyownerID = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodyeventID = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<ConmgUpdateConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentInteraction(WorkflowValue<string> constituentInteractionId, WorkflowValue<string> bodysummary = null, WorkflowValue<bodystatusInput> bodystatus = null, WorkflowValue<string> bodycategory = null, WorkflowValue<string> bodysubcategory = null, WorkflowValue<string> bodyexpectedDate = null, WorkflowValue<int> bodyexpectedStarthour = null, WorkflowValue<int> bodyexpectedStartminute = null, WorkflowValue<int> bodyexpectedEndhour = null, WorkflowValue<int> bodyexpectedEndminute = null, WorkflowValue<string> bodyactualDate = null, WorkflowValue<int> bodyactualStarthour = null, WorkflowValue<int> bodyactualStartminute = null, WorkflowValue<int> bodyactualEndhour = null, WorkflowValue<int> bodyactualEndminute = null, WorkflowValue<string> bodytimeZone = null, WorkflowValue<bool> bodyallDayEvent = null, WorkflowValue<string> bodyownerID = null, WorkflowValue<string> bodycontactMethod = null, WorkflowValue<string> bodyeventID = null, WorkflowValue<string> bodycomments = null, WorkflowValue<ConmgUpdateConstituentInteractionParticipant[]> bodyparticipants = null)
        {
            WorkflowValue.Validate(constituentInteractionId, nameof(constituentInteractionId), required: true);
            WorkflowValue.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowValue.Validate(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            WorkflowValue.Validate(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            WorkflowValue.Validate(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            WorkflowValue.Validate(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            WorkflowValue.Validate(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            WorkflowValue.Validate(bodyactualDate, nameof(bodyactualDate), required: false);
            WorkflowValue.Validate(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            WorkflowValue.Validate(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            WorkflowValue.Validate(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            WorkflowValue.Validate(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            WorkflowValue.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowValue.Validate(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            WorkflowValue.Validate(bodyownerID, nameof(bodyownerID), required: false);
            WorkflowValue.Validate(bodycontactMethod, nameof(bodycontactMethod), required: false);
            WorkflowValue.Validate(bodyeventID, nameof(bodyeventID), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowValue.Validate(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/interactions/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentInteractionId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildMergeTwoConstituents))]
        public IBodyWorkflowAction<ConmgMergedConstituent> MergeTwoConstituents([WorkflowExpression] Func<string> bodysourceConstituentID, [WorkflowExpression] Func<string> bodytargetConstituentID, [WorkflowExpression] Func<string> bodyconfiguration, [WorkflowExpression] Func<bool> bodydeleteSource, [WorkflowExpression] Func<bodydeleteActionInput> bodydeleteAction, [WorkflowExpression] Func<string> bodyinactiveReason = null, [WorkflowExpression] Func<string> bodyinactivityDetails = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgMergedConstituent> __BuildMergeTwoConstituents(WorkflowValue<string> bodysourceConstituentID, WorkflowValue<string> bodytargetConstituentID, WorkflowValue<string> bodyconfiguration, WorkflowValue<bool> bodydeleteSource, WorkflowValue<bodydeleteActionInput> bodydeleteAction, WorkflowValue<string> bodyinactiveReason = null, WorkflowValue<string> bodyinactivityDetails = null)
        {
            WorkflowValue.Validate(bodysourceConstituentID, nameof(bodysourceConstituentID), required: true);
            WorkflowValue.Validate(bodytargetConstituentID, nameof(bodytargetConstituentID), required: true);
            WorkflowValue.Validate(bodyconfiguration, nameof(bodyconfiguration), required: true);
            WorkflowValue.Validate(bodydeleteSource, nameof(bodydeleteSource), required: true);
            WorkflowValue.Validate(bodydeleteAction, nameof(bodydeleteAction), required: true);
            WorkflowValue.Validate(bodyinactiveReason, nameof(bodyinactiveReason), required: false);
            WorkflowValue.Validate(bodyinactivityDetails, nameof(bodyinactivityDetails), required: false);
            return new DeferredBodyAction<ConmgMergedConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/mergetwoconstituents";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrganizationConstituent))]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> CreateOrganizationConstituent([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<int> bodynoOfSubsidiaryOrgs = null, [WorkflowExpression] Func<string> bodyparentOrg = null, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<bool> bodydoNotSendMail = null, [WorkflowExpression] Func<string> bodydoNotMailReason = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycongressionalDistrict = null, [WorkflowExpression] Func<string> bodyphoneType = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodywebAddress = null, [WorkflowExpression] Func<bool> bodyisPrimaryOrganization = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedOrganizationConstituent> __BuildCreateOrganizationConstituent(WorkflowValue<string> bodyname, WorkflowValue<string> bodyindustry = null, WorkflowValue<int> bodynoOfEmployees = null, WorkflowValue<int> bodynoOfSubsidiaryOrgs = null, WorkflowValue<string> bodyparentOrg = null, WorkflowValue<string> bodyaddressType = null, WorkflowValue<string> bodycountry = null, WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodypostalCode = null, WorkflowValue<bool> bodydoNotSendMail = null, WorkflowValue<string> bodydoNotMailReason = null, WorkflowValue<string> bodydPC = null, WorkflowValue<string> bodycART = null, WorkflowValue<string> bodylOT = null, WorkflowValue<string> bodycounty = null, WorkflowValue<string> bodycongressionalDistrict = null, WorkflowValue<string> bodyphoneType = null, WorkflowValue<string> bodyphoneNumber = null, WorkflowValue<string> bodyemailType = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodywebAddress = null, WorkflowValue<bool> bodyisPrimaryOrganization = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyprofilePicture = null, WorkflowValue<string> bodyprofileThumbnail = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyindustry, nameof(bodyindustry), required: false);
            WorkflowValue.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowValue.Validate(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            WorkflowValue.Validate(bodyparentOrg, nameof(bodyparentOrg), required: false);
            WorkflowValue.Validate(bodyaddressType, nameof(bodyaddressType), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowValue.Validate(bodydoNotSendMail, nameof(bodydoNotSendMail), required: false);
            WorkflowValue.Validate(bodydoNotMailReason, nameof(bodydoNotMailReason), required: false);
            WorkflowValue.Validate(bodydPC, nameof(bodydPC), required: false);
            WorkflowValue.Validate(bodycART, nameof(bodycART), required: false);
            WorkflowValue.Validate(bodylOT, nameof(bodylOT), required: false);
            WorkflowValue.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowValue.Validate(bodycongressionalDistrict, nameof(bodycongressionalDistrict), required: false);
            WorkflowValue.Validate(bodyphoneType, nameof(bodyphoneType), required: false);
            WorkflowValue.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowValue.Validate(bodyemailType, nameof(bodyemailType), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodywebAddress, nameof(bodywebAddress), required: false);
            WorkflowValue.Validate(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowValue.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredBodyAction<ConmgCreatedOrganizationConstituent>(() =>
            {
                var apiCallPath = "/crm-conmg/organizations";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildGetOrganizationConstituent))]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> GetOrganizationConstituent([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgOrganizationConstituent> __BuildGetOrganizationConstituent(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConmgOrganizationConstituent>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConmgOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditOrganizationConstituent))]
        public IWorkflowAction EditOrganizationConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<int> bodynoOfSubsidiaryOrgs = null, [WorkflowExpression] Func<string> bodyparentOrg = null, [WorkflowExpression] Func<string> bodywebAddress = null, [WorkflowExpression] Func<bool> bodyisPrimaryOrganization = null, [WorkflowExpression] Func<string> bodyprofilePicture = null, [WorkflowExpression] Func<string> bodyprofileThumbnail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditOrganizationConstituent(WorkflowValue<string> constituentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyindustry = null, WorkflowValue<int> bodynoOfEmployees = null, WorkflowValue<int> bodynoOfSubsidiaryOrgs = null, WorkflowValue<string> bodyparentOrg = null, WorkflowValue<string> bodywebAddress = null, WorkflowValue<bool> bodyisPrimaryOrganization = null, WorkflowValue<string> bodyprofilePicture = null, WorkflowValue<string> bodyprofileThumbnail = null)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyindustry, nameof(bodyindustry), required: false);
            WorkflowValue.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowValue.Validate(bodynoOfSubsidiaryOrgs, nameof(bodynoOfSubsidiaryOrgs), required: false);
            WorkflowValue.Validate(bodyparentOrg, nameof(bodyparentOrg), required: false);
            WorkflowValue.Validate(bodywebAddress, nameof(bodywebAddress), required: false);
            WorkflowValue.Validate(bodyisPrimaryOrganization, nameof(bodyisPrimaryOrganization), required: false);
            WorkflowValue.Validate(bodyprofilePicture, nameof(bodyprofilePicture), required: false);
            WorkflowValue.Validate(bodyprofileThumbnail, nameof(bodyprofileThumbnail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentPhone))]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> CreateConstituentPhone([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodycallAfterhour = null, [WorkflowExpression] Func<int> bodycallAfterminute = null, [WorkflowExpression] Func<int> bodycallBeforehour = null, [WorkflowExpression] Func<int> bodycallBeforeminute = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<string> bodydoNotCallReason = null, [WorkflowExpression] Func<bool> bodydoNotText = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<bodyoriginInput> bodyorigin = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentPhone> __BuildCreateConstituentPhone(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodynumber, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodycountry = null, WorkflowValue<int> bodycallAfterhour = null, WorkflowValue<int> bodycallAfterminute = null, WorkflowValue<int> bodycallBeforehour = null, WorkflowValue<int> bodycallBeforeminute = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotCall = null, WorkflowValue<string> bodydoNotCallReason = null, WorkflowValue<bool> bodydoNotText = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<int> bodyseasonalStartmonth = null, WorkflowValue<int> bodyseasonalStartday = null, WorkflowValue<int> bodyseasonalEndmonth = null, WorkflowValue<int> bodyseasonalEndday = null, WorkflowValue<bodyoriginInput> bodyorigin = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodycopyToSpouse = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodynumber, nameof(bodynumber), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            WorkflowValue.Validate(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            WorkflowValue.Validate(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            WorkflowValue.Validate(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            WorkflowValue.Validate(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            WorkflowValue.Validate(bodydoNotText, nameof(bodydoNotText), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowValue.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowValue.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowValue.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowValue.Validate(bodyorigin, nameof(bodyorigin), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentPhone>(() =>
            {
                var apiCallPath = "/crm-conmg/phones";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentPhone))]
        public IWorkflowAction DeleteConstituentPhone([WorkflowExpression] Func<string> constituentPhoneId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentPhone(WorkflowValue<string> constituentPhoneId)
        {
            WorkflowValue.Validate(constituentPhoneId, nameof(constituentPhoneId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentPhoneId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentPhone))]
        public IWorkflowAction EditConstituentPhone([WorkflowExpression] Func<string> constituentPhoneId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<int> bodycallAfterhour = null, [WorkflowExpression] Func<int> bodycallAfterminute = null, [WorkflowExpression] Func<int> bodycallBeforehour = null, [WorkflowExpression] Func<int> bodycallBeforeminute = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<string> bodydoNotCallReason = null, [WorkflowExpression] Func<bool> bodydoNotText = null, [WorkflowExpression] Func<bool> bodyisConfidential = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyinfoSourceComments = null, [WorkflowExpression] Func<bool> bodycopyToSpouse = null, [WorkflowExpression] Func<bool> bodycopyToHousehold = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentPhone(WorkflowValue<string> constituentPhoneId, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodynumber = null, WorkflowValue<string> bodycountry = null, WorkflowValue<int> bodycallAfterhour = null, WorkflowValue<int> bodycallAfterminute = null, WorkflowValue<int> bodycallBeforehour = null, WorkflowValue<int> bodycallBeforeminute = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodyprimary = null, WorkflowValue<bool> bodydoNotCall = null, WorkflowValue<string> bodydoNotCallReason = null, WorkflowValue<bool> bodydoNotText = null, WorkflowValue<bool> bodyisConfidential = null, WorkflowValue<int> bodyseasonalStartmonth = null, WorkflowValue<int> bodyseasonalStartday = null, WorkflowValue<int> bodyseasonalEndmonth = null, WorkflowValue<int> bodyseasonalEndday = null, WorkflowValue<string> bodyinformationSource = null, WorkflowValue<string> bodyinfoSourceComments = null, WorkflowValue<bool> bodycopyToSpouse = null, WorkflowValue<bool> bodycopyToHousehold = null)
        {
            WorkflowValue.Validate(constituentPhoneId, nameof(constituentPhoneId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodynumber, nameof(bodynumber), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodycallAfterhour, nameof(bodycallAfterhour), required: false);
            WorkflowValue.Validate(bodycallAfterminute, nameof(bodycallAfterminute), required: false);
            WorkflowValue.Validate(bodycallBeforehour, nameof(bodycallBeforehour), required: false);
            WorkflowValue.Validate(bodycallBeforeminute, nameof(bodycallBeforeminute), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodyprimary, nameof(bodyprimary), required: false);
            WorkflowValue.Validate(bodydoNotCall, nameof(bodydoNotCall), required: false);
            WorkflowValue.Validate(bodydoNotCallReason, nameof(bodydoNotCallReason), required: false);
            WorkflowValue.Validate(bodydoNotText, nameof(bodydoNotText), required: false);
            WorkflowValue.Validate(bodyisConfidential, nameof(bodyisConfidential), required: false);
            WorkflowValue.Validate(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            WorkflowValue.Validate(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            WorkflowValue.Validate(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            WorkflowValue.Validate(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            WorkflowValue.Validate(bodyinformationSource, nameof(bodyinformationSource), required: false);
            WorkflowValue.Validate(bodyinfoSourceComments, nameof(bodyinfoSourceComments), required: false);
            WorkflowValue.Validate(bodycopyToSpouse, nameof(bodycopyToSpouse), required: false);
            WorkflowValue.Validate(bodycopyToHousehold, nameof(bodycopyToHousehold), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/phones/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentPhoneId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentEmploymentHistory))]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> CreateConstituentEmploymentHistory([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodyrelationship, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycareerLevel = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodysyncEndDate = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodycareerLevel2 = null, [WorkflowExpression] Func<string> bodyresponsibilities = null, [WorkflowExpression] Func<bool> bodyisPrivate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentEmploymentHistory> __BuildCreateConstituentEmploymentHistory(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodyrelationship, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodycareerLevel = null, WorkflowValue<string> bodycategory = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodysyncEndDate = null, WorkflowValue<string> bodydepartment = null, WorkflowValue<string> bodydivision = null, WorkflowValue<string> bodycareerLevel2 = null, WorkflowValue<string> bodyresponsibilities = null, WorkflowValue<bool> bodyisPrivate = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodycareerLevel, nameof(bodycareerLevel), required: false);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            WorkflowValue.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowValue.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowValue.Validate(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            WorkflowValue.Validate(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentEmploymentHistory>(() =>
            {
                var apiCallPath = "/crm-conmg/relationshipjobsinfo";
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

                if (bodysyncEndDate != null)
                {
                    body["sync_end_date_to_relationship"] = ExpressionConverter.ConvertO(bodysyncEndDate);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentEmploymentHistory))]
        public IWorkflowAction DeleteConstituentEmploymentHistory([WorkflowExpression] Func<string> relationshipJobInfoId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentEmploymentHistory(WorkflowValue<string> relationshipJobInfoId)
        {
            WorkflowValue.Validate(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipJobInfoId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentEmploymentHistory))]
        public IWorkflowAction EditConstituentEmploymentHistory([WorkflowExpression] Func<string> relationshipJobInfoId, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodycareerLevel = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodysyncEndDate = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodycareerLevel2 = null, [WorkflowExpression] Func<string> bodyresponsibilities = null, [WorkflowExpression] Func<bool> bodyisPrivate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentEmploymentHistory(WorkflowValue<string> relationshipJobInfoId, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodycareerLevel = null, WorkflowValue<string> bodycategory = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<bool> bodysyncEndDate = null, WorkflowValue<string> bodydepartment = null, WorkflowValue<string> bodydivision = null, WorkflowValue<string> bodycareerLevel2 = null, WorkflowValue<string> bodyresponsibilities = null, WorkflowValue<bool> bodyisPrivate = null)
        {
            WorkflowValue.Validate(relationshipJobInfoId, nameof(relationshipJobInfoId), required: true);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodycareerLevel, nameof(bodycareerLevel), required: false);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodysyncEndDate, nameof(bodysyncEndDate), required: false);
            WorkflowValue.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowValue.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowValue.Validate(bodycareerLevel2, nameof(bodycareerLevel2), required: false);
            WorkflowValue.Validate(bodyresponsibilities, nameof(bodyresponsibilities), required: false);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/relationshipjobsinfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(relationshipJobInfoId, 1));
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

                if (bodysyncEndDate != null)
                {
                    body["sync_end_date_to_relationship"] = ExpressionConverter.ConvertO(bodysyncEndDate);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConstituentSolicitCode))]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> CreateConstituentSolicitCode([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodysolicitCode, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConmgCreatedConstituentSolicitCode> __BuildCreateConstituentSolicitCode(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodysolicitCode, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodysolicitCode, nameof(bodysolicitCode), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConmgCreatedConstituentSolicitCode>(() =>
            {
                var apiCallPath = "/crm-conmg/solicitcodes";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConstituentSolicitCode))]
        public IWorkflowAction DeleteConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteConstituentSolicitCode(WorkflowValue<string> constituentSolicitCodeId)
        {
            WorkflowValue.Validate(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/solicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmconstitu")]
        [WorkflowExpressionFactory(nameof(__BuildEditConstituentSolicitCode))]
        public IWorkflowAction EditConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId, [WorkflowExpression] Func<string> bodysolicitCode = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditConstituentSolicitCode(WorkflowValue<string> constituentSolicitCodeId, WorkflowValue<string> bodysolicitCode = null, WorkflowValue<string> bodystartDate = null, WorkflowValue<string> bodyendDate = null, WorkflowValue<string> bodycomments = null)
        {
            WorkflowValue.Validate(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            WorkflowValue.Validate(bodysolicitCode, nameof(bodysolicitCode), required: false);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowValue.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowValue.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm-conmg/solicitcodes/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentSolicitCodeId, 1));
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
